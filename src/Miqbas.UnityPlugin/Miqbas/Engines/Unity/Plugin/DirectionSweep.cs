using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using HarmonyLib;

namespace Miqbas.Engines.Unity.Plugin;

internal static class DirectionSweep
{
	private static readonly TimeSpan Gap = TimeSpan.FromMilliseconds(400.0);

	internal const int TimesItsOwnCost = 40;

	internal static readonly TimeSpan LongestWait = TimeSpan.FromSeconds(4.0);

	internal static readonly TimeSpan OneSlice = TimeSpan.FromMilliseconds(2.0);

	internal static readonly TimeSpan BetweenSlices = TimeSpan.FromMilliseconds(16.0);

	internal static readonly TimeSpan OldestWalk = TimeSpan.FromSeconds(3.0);

	private const double HeavyMs = 10.0;

	private static long _lastEnded;

	private static long _gap;

	private static long _lastSlice;

	private static IEnumerator _walk;

	private static long _walkBegan;

	private static long _walkSpent;

	private static int _slices;

	private static int _seen;

	private static int _unreadable;

	private static int _arabic;

	private static int _alreadyRight;

	private static int _unknownDirection;

	private static IEnumerable _list;

	private static long _askTook;

	private static long _askAgainAt;

	private static Action<object> _judgeEach;

	private static Func<long> _clock;

	private static bool _saidHeavy;

	private static bool _inside;

	private static MethodInfo _findObjects;

	private static Type _textType;

	private static bool _unavailable;

	private static int _fixed;

	private static bool _takesTheTypeAsArgument;

	private static string _whyUnavailable = "سبب\u064c غير معروف.";

	private static bool _reported;

	private static int _passes;

	internal static void MaybeRun()
	{
		if (_unavailable || !MiqbasPlugin.SweepsDirection)
		{
			return;
		}
		long timestamp = Stopwatch.GetTimestamp();
		if (_inside || ((_walk == null) ? (timestamp - _lastEnded < _gap) : (timestamp - _lastSlice < StopwatchTicks(BetweenSlices))))
		{
			return;
		}
		_lastSlice = timestamp;
		_inside = true;
		try
		{
			if (_walk != null || Begin())
			{
				Carry();
			}
		}
		catch (Exception e)
		{
			_unavailable = true;
			_walk = null;
			MiqbasPlugin.Log("مسح الاتجاه توق\u0651ف: " + WhyItFailed.Line(e));
		}
		finally
		{
			_inside = false;
		}
	}

	internal static TimeSpan GapAfter(TimeSpan walkTook)
	{
		TimeSpan timeSpan = TimeSpan.FromTicks(walkTook.Ticks * 40);
		if (!(timeSpan < Gap))
		{
			if (!(timeSpan > LongestWait))
			{
				return timeSpan;
			}
			return LongestWait;
		}
		return Gap;
	}

	internal static TimeSpan ReuseTheListFor(TimeSpan askTook)
	{
		TimeSpan timeSpan = TimeSpan.FromTicks(askTook.Ticks * 40);
		if (!(timeSpan > LongestWait))
		{
			return timeSpan;
		}
		return LongestWait;
	}

	internal static bool WalkASlice(IEnumerator labels, Action<object> each, Func<long> clock, long until)
	{
		for (int i = 0; i <= 0 || clock() < until; i++)
		{
			object current;
			try
			{
				if (!labels.MoveNext())
				{
					return true;
				}
				current = labels.Current;
			}
			catch
			{
				return true;
			}
			if (current != null)
			{
				try
				{
					each(current);
				}
				catch
				{
				}
			}
		}
		return false;
	}

	internal static IEnumerable LiveLabels()
	{
		if (_unavailable)
		{
			return null;
		}
		try
		{
			if (_findObjects == null && !Resolve())
			{
				return null;
			}
			if (_list == null || Stopwatch.GetTimestamp() >= _askAgainAt)
			{
				AskTheGame();
			}
			return _list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static object AskTheGame()
	{
		long timestamp = Stopwatch.GetTimestamp();
		object? obj = (_takesTheTypeAsArgument ? _findObjects.Invoke(null, new object[1] { _textType }) : _findObjects.Invoke(null, null));
		long timestamp2 = Stopwatch.GetTimestamp();
		FrameCost.Shared.Piece("سؤال\u064f اللعبة عن لافتاتها", timestamp);
		_list = obj as IEnumerable;
		_askTook = timestamp2 - timestamp;
		_askAgainAt = timestamp2 + StopwatchTicks(ReuseTheListFor(Span(_askTook)));
		return obj;
	}

	private static bool Begin()
	{
		if (_findObjects == null && !Resolve())
		{
			_unavailable = true;
			MiqbasPlugin.Log("مسح الاتجاه لا يعمل في هذه اللعبة: " + _whyUnavailable);
			return false;
		}
		if (_list == null || Stopwatch.GetTimestamp() >= _askAgainAt)
		{
			object obj = AskTheGame();
			if (_list == null)
			{
				_unavailable = true;
				MiqbasPlugin.Log("مسح الاتجاه لا يعمل في هذه اللعبة: قائمة اللافتات جاءت بشكل\u064d لا ي\u064fقرأ (" + (obj?.GetType().Name ?? "لا شيء") + ").");
				return false;
			}
		}
		_walk = _list.GetEnumerator();
		_walkBegan = Stopwatch.GetTimestamp();
		_walkSpent = 0L;
		_slices = 0;
		_seen = 0;
		_unreadable = 0;
		_arabic = 0;
		_alreadyRight = 0;
		_unknownDirection = 0;
		return true;
	}

	private static void Carry()
	{
		if (_judgeEach == null)
		{
			_judgeEach = Judge;
		}
		if (_clock == null)
		{
			_clock = Stopwatch.GetTimestamp;
		}
		long timestamp = Stopwatch.GetTimestamp();
		_slices++;
		bool flag = WalkASlice(_walk, _judgeEach, _clock, timestamp + StopwatchTicks(OneSlice));
		long timestamp2 = Stopwatch.GetTimestamp();
		_walkSpent += timestamp2 - timestamp;
		if (flag || timestamp2 - _walkBegan >= StopwatchTicks(OldestWalk))
		{
			_walk = null;
			_lastEnded = timestamp2;
			_gap = StopwatchTicks(GapAfter(Span(_walkSpent)));
			SayItIsHeavy();
			if (flag)
			{
				ReportTheFirstPass(_seen, _unreadable, _arabic, _alreadyRight, _unknownDirection);
			}
		}
	}

	private static void SayItIsHeavy()
	{
		double num = FrameCost.Milliseconds(_askTook);
		double num2 = FrameCost.Milliseconds(_walkSpent);
		if (!_saidHeavy && (!(num < 10.0) || !(num2 < 10.0)))
		{
			_saidHeavy = true;
			MiqbasPlugin.Log(string.Format(CultureInfo.InvariantCulture, "مسح الاتجاه ثقيل في هذه اللعبة: سؤالها عن لافتاتها أخذ {0:0.0} مللي ثانية، والمرور على {1} لافتة {2:0.0} مللي ثانية في {3} قطعة — فصار السؤال مرة كل {4:0.0} ثانية على الأكثر، والمرور كل {5:0.0} ثانية.", num, _seen, num2, _slices, ReuseTheListFor(Span(_askTook)).TotalSeconds, GapAfter(Span(_walkSpent)).TotalSeconds));
		}
	}

	private static long StopwatchTicks(TimeSpan span)
	{
		return (long)(span.TotalSeconds * (double)Stopwatch.Frequency);
	}

	private static TimeSpan Span(long stopwatchTicks)
	{
		return TimeSpan.FromTicks((long)((double)stopwatchTicks * 10000000.0 / (double)Stopwatch.Frequency));
	}

	private static void Judge(object label)
	{
		_seen++;
		MethodInfo methodInfo = TextRegistry.GetterFor(label.GetType());
		if ((object)methodInfo == null || !(methodInfo.Invoke(label, null) is string text))
		{
			_unreadable++;
			return;
		}
		ArabicLettersOnALegacyLabel.Follow(label, text);
		if (text.Length == 0 || !ArabicDirection.ContainsArabic(text))
		{
			if (HasLetters(text) && ArabicDirection.IsOwned(label))
			{
				ArabicDirection.Release(label);
				Counted();
			}
			return;
		}
		_arabic++;
		if (MiqbasPlugin.FilesRepaired)
		{
			if (ArabicDirection.IsRightToLeft(label).GetValueOrDefault())
			{
				ArabicDirection.LayOutLeftToRight(label);
				Counted();
			}
			return;
		}
		bool? flag = ArabicDirection.IsRightToLeft(label);
		switch (HandedWords.Judge(flag, HandedWords.IsOurLogical(text), HandedWords.IsOurVisual(text)))
		{
		case SweepVerdict.TurnRightToLeft:
			if (HandedWords.NoteFlagWiped())
			{
				MiqbasPlugin.Log("هذه اللعبة تمسح اتجاه النص، فمقباس سيسل\u0651م الكلمات مقلوبة\u064b بنفسه من الآن.");
			}
			if (HandedWords.FlagHolds)
			{
				ArabicDirection.ApplyTo(label);
			}
			else
			{
				ArabicDirection.LayOutLeftToRight(label);
				TextRegistry.SetterFor(label.GetType())?.Invoke(label, new object[1] { text });
			}
			Counted();
			return;
		case SweepVerdict.TurnLeftToRight:
			ArabicDirection.LayOutLeftToRight(label);
			Counted();
			return;
		case SweepVerdict.LeaveAlone:
			_alreadyRight++;
			return;
		}
		if (flag == false)
		{
			if (ArabicDirection.AlreadyLaidOut(text))
			{
				ArabicDirection.LayOutLeftToRight(label);
				_alreadyRight++;
			}
			else
			{
				ArabicDirection.ApplyTo(label);
				Counted();
			}
		}
		else if (flag.GetValueOrDefault())
		{
			_alreadyRight++;
		}
		else
		{
			_unknownDirection++;
		}
	}

	private static void ReportTheFirstPass(int seen, int unreadable, int arabic, int alreadyRight, int unknownDirection)
	{
		_passes++;
		if (!_reported && (arabic != 0 || _passes >= 25))
		{
			_reported = true;
			MiqbasPlugin.Log($"مسح الاتجاه — بعد {_passes} جولة: {seen} لافتة، منها {unreadable} لا ي\u064fقرأ نص\u0651ها، " + $"و{arabic} فيها عربية: {alreadyRight} اتجاهها صحيح أصل\u064bا، " + $"و{unknownDirection} لا ي\u064fعرف اتجاهها، والباقي ض\u064fبط.");
		}
	}

	private static bool HasLetters(string shown)
	{
		for (int i = 0; i < shown.Length; i++)
		{
			if (char.IsLetter(shown[i]))
			{
				return true;
			}
		}
		return false;
	}

	private static void Counted()
	{
		_fixed++;
		bool flag;
		switch (_fixed)
		{
		case 1:
		case 10:
		case 100:
		case 500:
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			MiqbasPlugin.Log($"مسح الاتجاه: ض\u064fبطت {_fixed} لافتة عربية كانت من اليسار.");
		}
	}

	private static bool Resolve()
	{
		_textType = AccessTools.TypeByName("TMPro.TMP_Text");
		if (_textType == null)
		{
			_whyUnavailable = "لا يوجد TextMeshPro في هذه اللعبة.";
			return false;
		}
		Type type = AccessTools.TypeByName("UnityEngine.Resources");
		if (type == null)
		{
			_whyUnavailable = "تعذ\u0651ر بلوغ UnityEngine.Resources.";
			return false;
		}
		MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Public);
		foreach (MethodInfo methodInfo in methods)
		{
			if (!(methodInfo.Name != "FindObjectsOfTypeAll") && methodInfo.IsGenericMethodDefinition && methodInfo.GetParameters().Length == 0)
			{
				try
				{
					_findObjects = methodInfo.MakeGenericMethod(_textType);
					_takesTheTypeAsArgument = false;
					return true;
				}
				catch (Exception e)
				{
					_whyUnavailable = WhyItFailed.Line(e);
				}
			}
		}
		_findObjects = type.GetMethod("FindObjectsOfTypeAll", BindingFlags.Static | BindingFlags.Public, null, new Type[1] { typeof(Type) }, null);
		if (_findObjects == null)
		{
			_whyUnavailable = "لا توجد في هذه اللعبة طريقة لتعداد لافتاتها (FindObjectsOfTypeAll بشكليه).";
			return false;
		}
		_takesTheTypeAsArgument = true;
		return true;
	}
}
