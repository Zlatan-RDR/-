using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class TextObserver
{
	private const int MaxLength = 4000;

	private const int MaxDistinctStrings = 50000;

	private const int FlushEvery = 50;

	internal const int MostOfOneShape = 4;

	private static readonly UTF8Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	private readonly HashSet<string> _seen = new HashSet<string>(StringComparer.Ordinal);

	private readonly List<string> _pending = new List<string>();

	private readonly Dictionary<string, int> _shapes = new Dictionary<string, int>(StringComparer.Ordinal);

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

	internal TextObserver(string path)
	{
		_path = path;
	}

	internal void Record(string value)
	{
		if (!IsWorthTranslating(value))
		{
			return;
		}
		lock (_gate)
		{
			if (_seen.Count < 50000 && _seen.Add(value) && !TooManyOfThisShape(value))
			{
				_pending.Add(value);
				if (_pending.Count >= 50)
				{
					FlushLocked();
				}
			}
		}
	}

	private bool TooManyOfThisShape(string value)
	{
		string text = TheShapeOfALine.Of(value);
		if ((object)text == value)
		{
			return false;
		}
		_shapes.TryGetValue(text, out var value2);
		if (value2 >= 4)
		{
			return true;
		}
		_shapes[text] = value2 + 1;
		return false;
	}

	internal void Flush()
	{
		lock (_gate)
		{
			FlushLocked();
		}
	}

	internal static bool IsWorthTranslating(string value)
	{
		if (string.IsNullOrWhiteSpace(value) || value.Length > 4000)
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		bool flag = value.IndexOf('<') >= 0 || value.IndexOf('[') >= 0 || value.IndexOf('{') >= 0;
		bool flag2 = false;
		bool flag3 = false;
		for (int i = 0; i < value.Length; i++)
		{
			char c = value[i];
			if (flag)
			{
				if (!flag2 && !flag3 && c == '<' && ClosesSoon(value, i, '>'))
				{
					flag2 = true;
					continue;
				}
				if (flag2)
				{
					flag2 = c != '>';
					continue;
				}
				if (!flag3 && (c == '[' || c == '{') && ClosesSoon(value, i, (c == '[') ? ']' : '}'))
				{
					flag3 = true;
					continue;
				}
				if (flag3)
				{
					flag3 = c != ']' && c != '}';
					continue;
				}
			}
			if (char.IsLetter(c))
			{
				num++;
			}
			else if (char.IsDigit(c))
			{
				num2++;
			}
		}
		if (num < 2)
		{
			return false;
		}
		return num > num2;
	}

	private static bool ClosesSoon(string value, int start, char closing)
	{
		int num = Math.Min(value.Length, start + 48);
		for (int i = start + 1; i < num; i++)
		{
			if (value[i] == closing)
			{
				return true;
			}
			if (char.IsWhiteSpace(value[i]))
			{
				return false;
			}
		}
		return false;
	}

	private void FlushLocked()
	{
		if (_pending.Count == 0)
		{
			return;
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string item in _pending)
			{
				stringBuilder.AppendLine(TextEscaping.Escape(item));
			}
			File.AppendAllText(_path, stringBuilder.ToString(), Utf8NoBom);
			_pending.Clear();
		}
		catch (IOException)
		{
		}
	}
}
