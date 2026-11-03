using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class WhereTheLineCameFrom
{
	internal const int MostLines = 120;

	private const int FramesKept = 8;

	private static readonly UTF8Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	private static readonly string[] NotTheAnswer = new string[6] { "Miqbas.", "HarmonyLib", "MonoMod", "System.", "UnityEngine.", "TMPro." };

	private readonly HashSet<string> _seen = new HashSet<string>(StringComparer.Ordinal);

	private readonly List<string> _pending = new List<string>();

	private readonly object _gate = new object();

	private readonly string _path;

	internal int Count
	{
		get
		{
			lock (_gate)
			{
				return _seen.Count;
			}
		}
	}

	internal WhereTheLineCameFrom(string path)
	{
		_path = path;
	}

	internal void Record(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return;
		}
		lock (_gate)
		{
			if (_seen.Count >= 120 || !_seen.Add(value))
			{
				return;
			}
		}
		string text;
		try
		{
			text = TheTrailAbove();
		}
		catch (Exception)
		{
			return;
		}
		if (text.Length == 0)
		{
			return;
		}
		lock (_gate)
		{
			_pending.Add(TextEscaping.Escape(value) + "\t" + text);
			if (_pending.Count < 10)
			{
				return;
			}
		}
		Flush();
	}

	internal void Flush()
	{
		List<string> list;
		lock (_gate)
		{
			if (_pending.Count == 0)
			{
				return;
			}
			list = new List<string>(_pending);
			_pending.Clear();
		}
		try
		{
			File.AppendAllText(_path, string.Join("\n", list.ToArray()) + "\n", Utf8NoBom);
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	private static string TheTrailAbove()
	{
		StackTrace stackTrace = new StackTrace(fNeedFileInfo: false);
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		for (int i = 0; i < stackTrace.FrameCount; i++)
		{
			if (num >= 8)
			{
				break;
			}
			MethodBase method = stackTrace.GetFrame(i).GetMethod();
			if (method == null)
			{
				continue;
			}
			string text = NameOf(method);
			if (text.Length != 0 && !IsFurniture(text))
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(" < ");
				}
				stringBuilder.Append(text);
				num++;
			}
		}
		return stringBuilder.ToString();
	}

	private static string NameOf(MethodBase method)
	{
		Type declaringType = method.DeclaringType;
		if (declaringType == null)
		{
			return method.Name ?? string.Empty;
		}
		string text = ((declaringType.Assembly == null) ? "?" : declaringType.Assembly.GetName().Name);
		return declaringType.FullName + "." + method.Name + " [" + text + "]";
	}

	private static bool IsFurniture(string name)
	{
		string[] notTheAnswer = NotTheAnswer;
		foreach (string value in notTheAnswer)
		{
			if (name.StartsWith(value, StringComparison.Ordinal))
			{
				return true;
			}
		}
		return false;
	}
}
