using System;
using System.Collections.Generic;
using System.Threading;

namespace Miqbas.Engines.Unity.Plugin;

internal static class HandedWords
{
	internal const int Most = 20000;

	private static readonly HashSet<string> Logical = new HashSet<string>(StringComparer.Ordinal);

	private static readonly HashSet<string> Visual = new HashSet<string>(StringComparer.Ordinal);

	private static readonly object Gate = new object();

	internal const int EnoughWipesToStopArguing = 5;

	private static int _flagWiped;

	internal static bool FlagHolds => Volatile.Read(ref _flagWiped) < 5;

	internal static void NoteLogical(string line)
	{
		Note(Logical, line);
	}

	internal static void NoteVisual(string line)
	{
		Note(Visual, line);
	}

	internal static bool IsOurLogical(string line)
	{
		return Holds(Logical, line);
	}

	internal static bool IsOurVisual(string line)
	{
		return Holds(Visual, line);
	}

	internal static SweepVerdict Judge(bool? rightToLeft, bool ourLogical, bool ourVisual)
	{
		if (ourVisual)
		{
			if (!rightToLeft.GetValueOrDefault())
			{
				return SweepVerdict.LeaveAlone;
			}
			return SweepVerdict.TurnLeftToRight;
		}
		if (ourLogical)
		{
			if (rightToLeft != false)
			{
				return SweepVerdict.LeaveAlone;
			}
			return SweepVerdict.TurnRightToLeft;
		}
		return SweepVerdict.NotOurs;
	}

	internal static bool NoteFlagWiped()
	{
		return Interlocked.Increment(ref _flagWiped) == 5;
	}

	internal static void Forget()
	{
		lock (Gate)
		{
			Logical.Clear();
			Visual.Clear();
		}
		Volatile.Write(ref _flagWiped, 0);
	}

	private static void Note(HashSet<string> set, string line)
	{
		if (string.IsNullOrEmpty(line))
		{
			return;
		}
		lock (Gate)
		{
			if (set.Count < 20000)
			{
				set.Add(line);
			}
		}
	}

	private static bool Holds(HashSet<string> set, string line)
	{
		if (string.IsNullOrEmpty(line))
		{
			return false;
		}
		lock (Gate)
		{
			return set.Contains(line);
		}
	}
}
