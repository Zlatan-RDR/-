using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Miqbas.Rendering.Arabic;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class InstantTranslator
{
	private sealed class InstantSession
	{
		internal int Port;

		internal string Token;

		internal int Lanes = 1;

		internal static InstantSession ReadFrom(string workDirectory)
		{
			try
			{
				string path = Path.Combine(workDirectory ?? "", "instant.txt");
				if (!File.Exists(path))
				{
					return null;
				}
				InstantSession instantSession = new InstantSession();
				string[] array = ReadWhileWritten.Lines(path);
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					if (text.Length == 0 || text[0] == '#')
					{
						continue;
					}
					int num = text.IndexOf('=');
					if (num <= 0)
					{
						continue;
					}
					string text2 = text.Substring(0, num).Trim();
					string text3 = text.Substring(num + 1).Trim();
					switch (text2)
					{
					case "port":
					{
						if (int.TryParse(text3, out var result2))
						{
							instantSession.Port = result2;
						}
						break;
					}
					case "token":
						instantSession.Token = text3;
						break;
					case "lanes":
					{
						if (int.TryParse(text3, out var result))
						{
							instantSession.Lanes = result;
						}
						break;
					}
					}
				}
				return (instantSession.Port > 0 && !string.IsNullOrEmpty(instantSession.Token)) ? instantSession : null;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}

	internal const int SettleMilliseconds = 1000;

	internal const int MaxRequestsPerSession = 4000;

	private const int RequestTimeoutMilliseconds = 20000;

	internal const int MillisecondsPerCharacter = 100;

	internal const int LongestTimeoutMilliseconds = 120000;

	internal const int RetryAfterMilliseconds = 30000;

	internal const int MostRetries = 3;

	internal static int RefusedRetryAfterMilliseconds = 120000;

	private readonly Dictionary<string, int> _waiting = new Dictionary<string, int>(StringComparer.Ordinal);

	private readonly HashSet<string> _asked = new HashSet<string>(StringComparer.Ordinal);

	private readonly List<KeyValuePair<string, string>> _arrived = new List<KeyValuePair<string, string>>();

	private readonly object _gate = new object();

	private readonly string _workDirectory;

	private readonly Action<string> _log;

	private readonly List<Thread> _workers = new List<Thread>();

	private readonly List<HttpWebRequest> _inFlight = new List<HttpWebRequest>();

	private int _lanes = 1;

	private volatile bool _stopping;

	private int _sent;

	private int _answered;

	private bool _noSessionSaid;

	private readonly Dictionary<string, int> _retries = new Dictionary<string, int>(StringComparer.Ordinal);

	private const int MostLanes = 4;

	internal const int LinesInOneAsking = 20;

	private const char BetweenLines = '\u001e';

	private int _manyIsUnderstood = 1;

	internal int Sent
	{
		get
		{
			lock (_gate)
			{
				return _sent;
			}
		}
	}

	internal static int TimeoutFor(string source)
	{
		return (int)Math.Min(20000 + (long)(source?.Length ?? 0) * 100L, 120000L);
	}

	internal static string ChooseNext(IEnumerable<KeyValuePair<string, int>> waiting, int now)
	{
		return ChooseNext(waiting, now, shortLabelsOnly: false);
	}

	internal static string ChooseNext(IEnumerable<KeyValuePair<string, int>> waiting, int now, bool shortLabelsOnly)
	{
		string text = null;
		int num = int.MaxValue;
		foreach (KeyValuePair<string, int> item in waiting)
		{
			if (now - item.Value >= 1000 && (!shortLabelsOnly || AShortLabel.TheLine(item.Key)))
			{
				int length = item.Key.Length;
				if (text == null || length < num)
				{
					num = length;
					text = item.Key;
				}
			}
		}
		return text;
	}

	internal InstantTranslator(string workDirectory, Action<string> log)
	{
		_workDirectory = workDirectory;
		_log = log ?? ((Action<string>)delegate
		{
		});
	}

	internal bool AlreadyInHand(string source)
	{
		if (string.IsNullOrEmpty(source) || !WorthTranslating.TheLine(source))
		{
			return true;
		}
		lock (_gate)
		{
			return _asked.Contains(source) || _waiting.ContainsKey(source);
		}
	}

	internal void Request(string source)
	{
		if (string.IsNullOrEmpty(source) || !WorthTranslating.TheLine(source))
		{
			return;
		}
		lock (_gate)
		{
			if (_sent >= 4000 || _asked.Contains(source))
			{
				return;
			}
			_waiting[source] = Environment.TickCount;
		}
		EnsureWorker();
	}

	internal List<KeyValuePair<string, string>> TakeArrived()
	{
		lock (_gate)
		{
			if (_arrived.Count == 0)
			{
				return null;
			}
			List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>(_arrived);
			_arrived.Clear();
			return result;
		}
	}

	internal void Stop()
	{
		_stopping = true;
		HttpWebRequest[] array;
		lock (_gate)
		{
			array = _inFlight.ToArray();
		}
		HttpWebRequest[] array2 = array;
		foreach (HttpWebRequest httpWebRequest in array2)
		{
			try
			{
				httpWebRequest.Abort();
			}
			catch
			{
			}
		}
		Thread[] array3;
		lock (_gate)
		{
			array3 = _workers.ToArray();
		}
		Thread[] array4 = array3;
		foreach (Thread thread in array4)
		{
			try
			{
				thread.Join(2000);
			}
			catch
			{
			}
		}
	}

	private void EnsureWorker()
	{
		lock (_gate)
		{
			if (_workers.Count == 0)
			{
				_lanes = LanesForThisSession();
			}
			while (_workers.Count < _lanes)
			{
				bool keptForLabels = _lanes > 1 && _workers.Count < _lanes / 2;
				Thread thread = new Thread((ThreadStart)delegate
				{
					Work(keptForLabels);
				})
				{
					IsBackground = true,
					Name = "Miqbas instant translation " + (_workers.Count + 1) + (keptForLabels ? " (labels)" : "")
				};
				_workers.Add(thread);
				thread.Start();
			}
		}
	}

	private int LanesForThisSession()
	{
		int num = InstantSession.ReadFrom(_workDirectory)?.Lanes ?? 1;
		if (num < 1)
		{
			num = 1;
		}
		if (num > 4)
		{
			num = 4;
		}
		if (num > 1)
		{
			_log("الترجمة الفورية تسأل " + num + " أسطر مع\u064bا.");
		}
		return num;
	}

	private void Work(bool shortLabelsOnly)
	{
		while (!_stopping)
		{
			List<string> list = HandfulSettled(shortLabelsOnly);
			if (list.Count == 0)
			{
				Thread.Sleep(200);
				continue;
			}
			List<string> list2 = ((list.Count == 1) ? new List<string> { Ask(list[0]) } : AskMany(list));
			for (int i = 0; i < list.Count && i < list2.Count; i++)
			{
				string text = list2[i];
				if (!string.IsNullOrEmpty(text))
				{
					lock (_gate)
					{
						_arrived.Add(new KeyValuePair<string, string>(list[i], text));
						_answered++;
					}
					if (_answered == 1)
					{
						_log("وصلت أو\u0651ل ترجمة فورية: «" + list[i] + "» ← «" + text + "».");
					}
				}
			}
		}
	}

	private string NextSettled(bool shortLabelsOnly)
	{
		lock (_gate)
		{
			string text = ChooseNext(_waiting, Environment.TickCount, shortLabelsOnly);
			if (text != null)
			{
				_waiting.Remove(text);
				_asked.Add(text);
				_sent++;
			}
			return text;
		}
	}

	private List<string> HandfulSettled(bool shortLabelsOnly)
	{
		List<string> list = new List<string>();
		lock (_gate)
		{
			while (list.Count < 20)
			{
				string text = ChooseNext(_waiting, Environment.TickCount, shortLabelsOnly);
				if (text == null || _sent >= 4000)
				{
					break;
				}
				_waiting.Remove(text);
				_asked.Add(text);
				_sent++;
				list.Add(text);
			}
		}
		return list;
	}

	private List<string> AskMany(List<string> sources)
	{
		List<string> list = new List<string>(sources.Count);
		if (Volatile.Read(ref _manyIsUnderstood) != 0)
		{
			string text = string.Join('\u001e'.ToString(), sources.ToArray());
			string text2 = Post("/translate-many", text, TimeoutFor(text));
			if (text2 != null)
			{
				string[] array = text2.Split(new char[1] { '\u001e' });
				if (array.Length == sources.Count)
				{
					list.AddRange(array);
					return list;
				}
				for (int i = 0; i < sources.Count; i++)
				{
					list.Add(null);
				}
				return list;
			}
		}
		foreach (string source in sources)
		{
			list.Add(Ask(source));
		}
		return list;
	}

	private string Post(string path, string body, int timeoutMilliseconds)
	{
		InstantSession instantSession = InstantSession.ReadFrom(_workDirectory);
		if (instantSession == null || _stopping)
		{
			return null;
		}
		HttpWebRequest httpWebRequest = null;
		try
		{
			httpWebRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:" + instantSession.Port + path);
			lock (_gate)
			{
				_inFlight.Add(httpWebRequest);
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "text/plain; charset=utf-8";
			httpWebRequest.Timeout = timeoutMilliseconds;
			httpWebRequest.ReadWriteTimeout = timeoutMilliseconds;
			httpWebRequest.Headers.Add("X-Miqbas-Token", instantSession.Token);
			byte[] bytes = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false).GetBytes(body);
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.NotFound)
			{
				Volatile.Write(ref _manyIsUnderstood, 0);
				return null;
			}
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				return null;
			}
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
			return streamReader.ReadToEnd();
		}
		catch (WebException ex)
		{
			if (ex.Response is HttpWebResponse { StatusCode: HttpStatusCode.NotFound })
			{
				Volatile.Write(ref _manyIsUnderstood, 0);
			}
			return null;
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			if (httpWebRequest != null)
			{
				lock (_gate)
				{
					_inFlight.Remove(httpWebRequest);
				}
			}
		}
	}

	private string Ask(string source)
	{
		InstantSession instantSession = InstantSession.ReadFrom(_workDirectory);
		if (instantSession == null)
		{
			if (!_noSessionSaid)
			{
				_noSessionSaid = true;
				_log("لا ترجمة فورية الآن — مقباس مغلق أو لم ت\u064fشغ\u064e\u0651ل، والسطور ت\u064fجمع للترجمة لاحق\u064bا.");
			}
			return null;
		}
		HttpWebRequest httpWebRequest = null;
		try
		{
			if (_stopping)
			{
				return null;
			}
			httpWebRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:" + instantSession.Port + "/translate");
			lock (_gate)
			{
				_inFlight.Add(httpWebRequest);
			}
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "text/plain; charset=utf-8";
			int readWriteTimeout = (httpWebRequest.Timeout = TimeoutFor(source));
			httpWebRequest.ReadWriteTimeout = readWriteTimeout;
			httpWebRequest.Headers.Add("X-Miqbas-Token", instantSession.Token);
			byte[] bytes = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false).GetBytes(source);
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				AskAgainLater(source, RefusedRetryAfterMilliseconds, "ر\u064fفض");
				return null;
			}
			using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
			string text = streamReader.ReadToEnd();
			return string.IsNullOrEmpty(text) ? null : text;
		}
		catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
		{
			if (AskAgainLater(source, 30000, "تأخ\u0651ر"))
			{
				return null;
			}
			_log("تعذ\u0651رت ترجمة فورية لسطر: " + WhyItFailed.Line(ex));
			return null;
		}
		catch (Exception e)
		{
			if (_stopping)
			{
				return null;
			}
			_log("تعذ\u0651رت ترجمة فورية لسطر: " + WhyItFailed.Line(e));
			return null;
		}
		finally
		{
			if (httpWebRequest != null)
			{
				lock (_gate)
				{
					_inFlight.Remove(httpWebRequest);
				}
			}
		}
	}

	private bool AskAgainLater(string source, int firstDelayMilliseconds, string why)
	{
		lock (_gate)
		{
			_retries.TryGetValue(source, out var value);
			if (value >= 3)
			{
				return false;
			}
			_retries[source] = value + 1;
			_asked.Remove(source);
			int num = firstDelayMilliseconds << value;
			_waiting[source] = Environment.TickCount + num;
			_log(why + " جواب «" + Shorten(source) + "» — سي\u064fسأل عنه مر\u0651ة أخرى بعد " + num / 1000 + " ثانية (" + (value + 1) + " من " + 3 + ").");
			return true;
		}
	}

	private static string Shorten(string source)
	{
		if (source != null)
		{
			if (source.Length > 40)
			{
				return source.Substring(0, 40) + "…";
			}
			return source;
		}
		return "";
	}
}
