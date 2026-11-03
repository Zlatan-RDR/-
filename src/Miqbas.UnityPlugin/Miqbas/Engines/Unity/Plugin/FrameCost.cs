using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Miqbas.Engines.Unity.Plugin;

public sealed class FrameCost
{
	public const double SlowFrameMs = 50.0;

	public const double WindowSeconds = 60.0;

	public static readonly FrameCost Shared = new FrameCost();

	private long _oursThisFrame;

	private long _longestPieceTicks;

	private int _frames;

	private int _slow;

	private double _frameMsSum;

	private double _frameMsMax;

	private double _oursMsSum;

	private double _oursMsMax;

	private double _windowMs;

	private const int Deepest = 8;

	[ThreadStatic]
	private static int _depth;

	[ThreadStatic]
	private static string[] _innerAt;

	[ThreadStatic]
	private static long[] _innerTicksAt;

	[ThreadStatic]
	private static long[] _innerEndedAt;

	private string _longestPieceName;

	public static long Start()
	{
		return Stopwatch.GetTimestamp();
	}

	public static double Milliseconds(long ticks)
	{
		return (double)ticks * 1000.0 / (double)Stopwatch.Frequency;
	}

	public void Spent(long started, string what = null)
	{
		SpentTicks(Stopwatch.GetTimestamp() - started, what);
	}

	public void Piece(string what, long started)
	{
		long ticks = Stopwatch.GetTimestamp() - started;
		if (_depth > 0)
		{
			NoteInner(_depth - 1, started, ticks, what);
		}
		else
		{
			NoteLongest(ticks, what);
		}
	}

	public long Enter()
	{
		if (_innerAt == null)
		{
			_innerAt = new string[8];
			_innerTicksAt = new long[8];
			_innerEndedAt = new long[8];
		}
		if (_depth < 8)
		{
			_innerAt[_depth] = null;
			_innerTicksAt[_depth] = 0L;
		}
		_depth++;
		return Stopwatch.GetTimestamp();
	}

	public void Leave(long started, string what)
	{
		long num = Stopwatch.GetTimestamp() - started;
		if (_depth > 0)
		{
			_depth--;
		}
		int depth = _depth;
		string what2 = what;
		if (depth < 8)
		{
			string[] innerAt = _innerAt;
			string text = ((innerAt != null) ? innerAt[depth] : null);
			if (text != null && _innerTicksAt[depth] * 2 >= num)
			{
				what2 = what + " ← " + text;
			}
		}
		if (depth > 0)
		{
			NoteInner(depth - 1, started, num, what2);
		}
		else
		{
			SpentTicks(num, what2);
		}
	}

	private static void NoteInner(int depth, long started, long ticks, string what)
	{
		if (depth < 8 && _innerAt != null && ticks > _innerTicksAt[depth])
		{
			string text = _innerAt[depth];
			if (text != null && _innerEndedAt[depth] >= started && _innerTicksAt[depth] * 2 >= ticks)
			{
				what = what + " ← " + text;
			}
			_innerAt[depth] = what;
			_innerTicksAt[depth] = ticks;
			_innerEndedAt[depth] = started + ticks;
		}
	}

	public void SpentTicks(long ticks, string what = null)
	{
		Interlocked.Add(ref _oursThisFrame, ticks);
		NoteLongest(ticks, what);
	}

	private void NoteLongest(long ticks, string what)
	{
		long num;
		do
		{
			num = Interlocked.Read(ref _longestPieceTicks);
			if (ticks <= num)
			{
				return;
			}
		}
		while (Interlocked.CompareExchange(ref _longestPieceTicks, ticks, num) != num);
		if (what != null)
		{
			_longestPieceName = what;
		}
	}

	public string Frame(double frameMs)
	{
		double num = Milliseconds(Interlocked.Exchange(ref _oursThisFrame, 0L));
		_frames++;
		_frameMsSum += frameMs;
		_oursMsSum += num;
		_windowMs += frameMs;
		if (frameMs > _frameMsMax)
		{
			_frameMsMax = frameMs;
		}
		if (num > _oursMsMax)
		{
			_oursMsMax = num;
		}
		if (frameMs >= 50.0)
		{
			_slow++;
		}
		if (_windowMs < 60000.0)
		{
			return null;
		}
		string result = string.Format(CultureInfo.InvariantCulture, "[Miqbas] frame-cost: frames={0} frame-avg={1:0.0}ms frame-max={2:0.0}ms slow={3} miqbas-avg={4:0.00}ms miqbas-max={5:0.0}ms miqbas-longest={6:0.0}ms ({7})", _frames, _frameMsSum / (double)_frames, _frameMsMax, _slow, _oursMsSum / (double)_frames, _oursMsMax, Milliseconds(Interlocked.Exchange(ref _longestPieceTicks, 0L)), _longestPieceName ?? "لم ي\u064fسم\u064e\u0651");
		_frames = 0;
		_slow = 0;
		_frameMsSum = 0.0;
		_frameMsMax = 0.0;
		_oursMsSum = 0.0;
		_oursMsMax = 0.0;
		_windowMs = 0.0;
		return result;
	}
}
