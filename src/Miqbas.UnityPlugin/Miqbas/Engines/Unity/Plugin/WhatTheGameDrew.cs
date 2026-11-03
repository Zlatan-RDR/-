using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class WhatTheGameDrew
{
	internal const string FileName = "drawn-count.txt";

	internal const int MostDistinctLines = 50000;

	internal const int MostOfOneShape = 4;

	internal const int SaveEvery = 100;

	private static readonly UTF8Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

	private readonly HashSet<string> _drawn = new HashSet<string>(StringComparer.Ordinal);

	private readonly HashSet<string> _answered = new HashSet<string>(StringComparer.Ordinal);

	private readonly Dictionary<string, int> _shapes = new Dictionary<string, int>(StringComparer.Ordinal);

	private readonly object _gate = new object();

	private readonly string _path;

	private int _sinceSave;

	private bool _full;

	private int _saidAt = -1;

	private int _savedDrawn = -1;

	private int _savedAnswered = -1;

	internal int Drawn
	{
		get
		{
			lock (_gate)
			{
				return _drawn.Count;
			}
		}
	}

	internal int Answered
	{
		get
		{
			lock (_gate)
			{
				return _answered.Count;
			}
		}
	}

	internal bool HitTheCeiling
	{
		get
		{
			lock (_gate)
			{
				return _full;
			}
		}
	}

	internal WhatTheGameDrew(string path)
	{
		_path = path;
	}

	internal static bool APlayerReadsIt(string line)
	{
		int num = 0;
		bool flag = true;
		bool flag2 = false;
		bool flag3 = false;
		foreach (char c in line)
		{
			if (char.IsLetter(c))
			{
				num++;
			}
			if (c == '$')
			{
				flag2 = true;
				flag3 = true;
			}
			else if (char.IsWhiteSpace(c))
			{
				flag2 = false;
			}
			else if (!flag2 || (!char.IsLetterOrDigit(c) && c != '_'))
			{
				flag = false;
			}
		}
		if (num >= 2)
		{
			return !(flag3 && flag);
		}
		return false;
	}

	internal string Record(string line, bool weAnswered)
	{
		if (string.IsNullOrEmpty(line) || !APlayerReadsIt(line))
		{
			return null;
		}
		bool flag = false;
		lock (_gate)
		{
			if (_drawn.Count >= 50000)
			{
				_full = true;
				return null;
			}
			if (!_drawn.Contains(line) && TooManyOfThisShape(line))
			{
				return null;
			}
			bool num = _drawn.Add(line);
			if (weAnswered)
			{
				_answered.Add(line);
			}
			if (!num)
			{
				return null;
			}
			if (++_sinceSave >= 100)
			{
				_sinceSave = 0;
				flag = true;
			}
		}
		if (!flag)
		{
			return null;
		}
		Save();
		return SayIt(1);
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

	internal string Lines(bool final = false)
	{
		int count;
		int count2;
		bool full;
		lock (_gate)
		{
			count = _drawn.Count;
			count2 = _answered.Count;
			full = _full;
		}
		return "drawn=" + count.ToString(CultureInfo.InvariantCulture) + Environment.NewLine + "answered=" + count2.ToString(CultureInfo.InvariantCulture) + Environment.NewLine + "atleast=" + (full ? "1" : "0") + Environment.NewLine + "final=" + (final ? "1" : "0") + Environment.NewLine;
	}

	internal string SayIt(int everyNewLines)
	{
		int count;
		int count2;
		bool full;
		lock (_gate)
		{
			if (_drawn.Count - _saidAt < everyNewLines)
			{
				return null;
			}
			_saidAt = _drawn.Count;
			count = _drawn.Count;
			count2 = _answered.Count;
			full = _full;
		}
		return "ما رسمته اللعبة حتى الآن: " + count + " سطر\u064bا مختلف\u064bا، منها " + count2 + " يعرفها مقباس، و" + ((count > count2) ? (count - count2) : 0) + " لا يعرفها" + (full ? " (بلغ العد\u0651 سقفه، فالرقم حد\u064c\u0651 أدنى)" : string.Empty) + ".";
	}

	internal bool SaveIfChanged()
	{
		lock (_gate)
		{
			if (_drawn.Count == _savedDrawn && _answered.Count == _savedAnswered)
			{
				return false;
			}
		}
		Save();
		return true;
	}

	internal void Save(bool final = false)
	{
		lock (_gate)
		{
			_savedDrawn = _drawn.Count;
			_savedAnswered = _answered.Count;
		}
		try
		{
			File.WriteAllText(_path, Lines(final), Utf8NoBom);
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
	}
}
