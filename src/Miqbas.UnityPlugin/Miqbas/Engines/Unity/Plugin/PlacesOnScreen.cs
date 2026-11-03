using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class PlacesOnScreen
{
	private sealed class Seen
	{
		internal int English;

		internal int Arabic;

		internal int Missing;

		internal string Font;
	}

	private sealed class Waiting
	{
		internal int Place { get; }

		internal string Drawn { get; }

		internal object Label { get; }

		internal int At { get; }

		internal Waiting(int place, string drawn, object label, int at)
		{
			Place = place;
			Drawn = drawn;
			Label = label;
			At = at;
		}
	}

	internal const string WatchFileName = "places-watch.txt";

	internal const string SeenFileName = "places-seen.txt";

	internal const int MostWatched = 200000;

	internal const int MostWaiting = 256;

	internal const int AskAfterMilliseconds = 1000;

	private static readonly UTF8Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	private readonly ulong[] _prints;

	private readonly int[] _placeAndKind;

	private readonly HashSet<ulong> _counted = new HashSet<ulong>();

	private readonly Dictionary<int, Seen> _places = new Dictionary<int, Seen>();

	private readonly Queue<Waiting> _waiting = new Queue<Waiting>();

	private readonly object _gate = new object();

	private readonly string _path;

	private int _changes;

	private int _savedAt = -1;

	private static readonly Dictionary<Type, Func<object, char, bool>> Asks = new Dictionary<Type, Func<object, char, bool>>();

	internal int AskAfter { get; set; } = 1000;


	internal int Watched => _prints.Length;

	private PlacesOnScreen(Dictionary<ulong, KeyValuePair<int, bool>> watched, string path)
	{
		_prints = new ulong[watched.Count];
		_placeAndKind = new int[watched.Count];
		int num = 0;
		foreach (KeyValuePair<ulong, KeyValuePair<int, bool>> item in watched)
		{
			_prints[num] = item.Key;
			_placeAndKind[num] = (item.Value.Key << 1) | (item.Value.Value ? 1 : 0);
			num++;
		}
		Array.Sort(_prints, _placeAndKind);
		_path = path;
	}

	internal static PlacesOnScreen Load(string workDirectory)
	{
		string path = Path.Combine(workDirectory, "places-watch.txt");
		if (!File.Exists(path))
		{
			return null;
		}
		Dictionary<ulong, KeyValuePair<int, bool>> dictionary = new Dictionary<ulong, KeyValuePair<int, bool>>();
		string[] array = File.ReadAllLines(path);
		int result = default(int);
		ulong result2 = default(ulong);
		foreach (string text in array)
		{
			if (dictionary.Count >= 200000)
			{
				break;
			}
			string[] array2 = text.Split(new char[1] { '\t' });
			bool flag = array2.Length != 3 || !int.TryParse(array2[0], NumberStyles.None, CultureInfo.InvariantCulture, out result) || !ulong.TryParse(array2[1], NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out result2);
			if (!flag)
			{
				string text2 = array2[2];
				bool flag2 = ((text2 == "e" || text2 == "a") ? true : false);
				flag = !flag2;
			}
			if (!flag)
			{
				dictionary[result2] = new KeyValuePair<int, bool>(result, array2[2] == "a");
			}
		}
		return new PlacesOnScreen(dictionary, Path.Combine(workDirectory, "places-seen.txt"));
	}

	internal void Saw(string line, string translation, object label)
	{
		if (string.IsNullOrEmpty(line))
		{
			return;
		}
		ulong num = Fingerprint(line);
		int num2 = Array.BinarySearch(_prints, num);
		if (num2 < 0)
		{
			return;
		}
		KeyValuePair<int, bool> keyValuePair = new KeyValuePair<int, bool>(_placeAndKind[num2] >> 1, (_placeAndKind[num2] & 1) == 1);
		lock (_gate)
		{
			if (!_counted.Add(num))
			{
				return;
			}
		}
		string drawn = translation ?? line;
		bool flag = keyValuePair.Value || translation != null;
		lock (_gate)
		{
			Seen seen = SeenOf(keyValuePair.Key);
			if (!flag)
			{
				seen.English++;
			}
			else if (label != null && _waiting.Count < 256)
			{
				_waiting.Enqueue(new Waiting(keyValuePair.Key, drawn, label, Environment.TickCount));
			}
			else
			{
				seen.Arabic++;
			}
			_changes++;
		}
	}

	internal void AskTheFonts()
	{
		while (true)
		{
			Waiting waiting;
			lock (_gate)
			{
				if (_waiting.Count == 0 || Environment.TickCount - _waiting.Peek().At < AskAfter)
				{
					break;
				}
				waiting = _waiting.Dequeue();
			}
			string text = FontLacking(waiting.Label, waiting.Drawn);
			lock (_gate)
			{
				Seen seen = SeenOf(waiting.Place);
				seen.Arabic++;
				if (text != null)
				{
					seen.Missing++;
					seen.Font = seen.Font ?? text;
				}
				_changes++;
			}
		}
	}

	internal string Lines()
	{
		StringBuilder stringBuilder = new StringBuilder();
		lock (_gate)
		{
			foreach (KeyValuePair<int, Seen> place in _places)
			{
				stringBuilder.Append(place.Key.ToString(CultureInfo.InvariantCulture)).Append('\t').Append(place.Value.English.ToString(CultureInfo.InvariantCulture))
					.Append('\t')
					.Append((place.Value.Arabic + StillWaiting(place.Key)).ToString(CultureInfo.InvariantCulture))
					.Append('\t')
					.Append(place.Value.Missing.ToString(CultureInfo.InvariantCulture))
					.Append('\t')
					.Append(Clean(place.Value.Font))
					.Append('\n');
			}
		}
		return stringBuilder.ToString();
	}

	internal bool SaveIfChanged()
	{
		lock (_gate)
		{
			if (_changes == _savedAt)
			{
				return false;
			}
			_savedAt = _changes;
		}
		Save();
		return true;
	}

	internal void Save()
	{
		try
		{
			File.WriteAllText(_path, Lines(), Utf8NoBom);
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	internal static ulong Fingerprint(string line)
	{
		ulong num = 14695981039346656037uL;
		foreach (char c in line)
		{
			num ^= c;
			num *= 1099511628211L;
		}
		return num;
	}

	internal static string FontLacking(object label, string drawn)
	{
		try
		{
			object obj = label?.GetType().GetProperty("font", BindingFlags.Instance | BindingFlags.Public)?.GetValue(label, null);
			if (obj == null)
			{
				return null;
			}
			Func<object, char, bool> func = HasCharacterOf(obj.GetType());
			if (func == null)
			{
				return null;
			}
			HashSet<char> hashSet = new HashSet<char>();
			foreach (char c in drawn)
			{
				if (IsArabicLetter(c) && hashSet.Add(c) && hashSet.Count <= 64 && !func(obj, c))
				{
					return (obj.GetType().GetProperty("name", BindingFlags.Instance | BindingFlags.Public)?.GetValue(obj, null) as string) ?? obj.GetType().Name;
				}
			}
			return null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	internal static bool IsArabicLetter(char c)
	{
		if ((c < 'ء' || c > 'ي') && (c < 'ٱ' || c > 'ۓ') && (c < 'ﭐ' || c > '﷿'))
		{
			if (c >= 'ﹰ')
			{
				return c <= 'ﻼ';
			}
			return false;
		}
		return true;
	}

	private static Func<object, char, bool> HasCharacterOf(Type type)
	{
		lock (Asks)
		{
			if (Asks.TryGetValue(type, out var value))
			{
				return value;
			}
			Func<object, char, bool> func = null;
			MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
			foreach (MethodInfo methodInfo in methods)
			{
				if (methodInfo.Name != "HasCharacter" || methodInfo.ReturnType != typeof(bool))
				{
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				if (parameters.Length == 0)
				{
					continue;
				}
				Type first = parameters[0].ParameterType;
				int rest = parameters.Length - 1;
				if ((first != typeof(int) && first != typeof(char) && first != typeof(uint)) || (rest > 0 && parameters[1].ParameterType != typeof(bool)) || (rest > 1 && parameters[2].ParameterType != typeof(bool)) || rest > 2)
				{
					continue;
				}
				MethodInfo chosen = methodInfo;
				func = delegate(object font, char c)
				{
					object[] array = new object[parameters.Length];
					array[0] = ((first == typeof(char)) ? ((object)c) : ((first == typeof(uint)) ? ((object)(uint)c) : ((object)(int)c)));
					if (rest > 0)
					{
						array[1] = true;
					}
					if (rest > 1)
					{
						array[2] = false;
					}
					return (bool)chosen.Invoke(font, array);
				};
				if (rest >= 1)
				{
					break;
				}
			}
			Asks[type] = func;
			return func;
		}
	}

	private Seen SeenOf(int place)
	{
		if (!_places.TryGetValue(place, out var value))
		{
			value = (_places[place] = new Seen());
		}
		return value;
	}

	private int StillWaiting(int place)
	{
		int num = 0;
		foreach (Waiting item in _waiting)
		{
			if (item.Place == place)
			{
				num++;
			}
		}
		return num;
	}

	private static string Clean(string font)
	{
		if (string.IsNullOrEmpty(font))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(font.Length);
		foreach (char c in font)
		{
			stringBuilder.Append(char.IsControl(c) ? ' ' : c);
		}
		if (stringBuilder.Length <= 120)
		{
			return stringBuilder.ToString();
		}
		return stringBuilder.ToString(0, 120);
	}
}
