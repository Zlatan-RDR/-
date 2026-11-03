using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using HarmonyLib;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class SelfPortrait
{
	internal const string MarkerFileName = "capture-screenshots.txt";

	private readonly string _directory;

	private readonly Action<string> _log;

	private readonly MethodInfo _capture;

	private readonly float _minimumGapSeconds;

	private readonly int _count;

	private readonly Stopwatch _clock = Stopwatch.StartNew();

	private float _lastAt;

	private int _taken;

	private SelfPortrait(string directory, Action<string> log, MethodInfo capture, float minimumGapSeconds, int count)
	{
		_directory = directory;
		_log = log;
		_capture = capture;
		_minimumGapSeconds = minimumGapSeconds;
		_count = count;
	}

	internal static SelfPortrait TryCreate(string workDirectory, Action<string> log, float minimumGapSeconds = 8f, int count = 10)
	{
		if (!File.Exists(Path.Combine(workDirectory, "capture-screenshots.txt")))
		{
			return null;
		}
		Type type = AccessTools.TypeByName("UnityEngine.ScreenCapture");
		MethodInfo methodInfo = ((type == null) ? null : AccessTools.Method(type, "CaptureScreenshot", new Type[1] { typeof(string) }, (Type[])null));
		if (methodInfo == null)
		{
			log("هذه اللعبة لا تتيح التصوير الذاتي — ي\u064fتخط\u0651ى.");
			return null;
		}
		string text = Path.Combine(workDirectory, "screenshots");
		Directory.CreateDirectory(text);
		log("التصوير الذاتي مفع\u0651ل: حتى " + count + " صورة، بفاصل " + minimumGapSeconds + " ثانية على الأقل.");
		return new SelfPortrait(text, log, methodInfo, minimumGapSeconds, count);
	}

	internal void Trigger()
	{
		if (_taken >= _count)
		{
			return;
		}
		float num = (float)_clock.Elapsed.TotalSeconds;
		if (_taken > 0 && num - _lastAt < _minimumGapSeconds)
		{
			return;
		}
		_lastAt = num;
		_taken++;
		string text = Path.Combine(_directory, "shot-" + _taken.ToString("00") + ".png");
		try
		{
			_capture.Invoke(null, new object[1] { text });
			_log("صورة: " + text);
		}
		catch (Exception e)
		{
			_log("تعذ\u0651ر التصوير: " + WhyItFailed.Line(e));
			_taken = _count;
		}
	}
}
