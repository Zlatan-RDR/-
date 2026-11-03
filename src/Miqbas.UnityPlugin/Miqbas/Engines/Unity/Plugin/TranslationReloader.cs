using System;
using System.IO;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class TranslationReloader
{
	internal static readonly TimeSpan LookEvery = TimeSpan.FromSeconds(2.0);

	private DateTime _lastLookedUtc = DateTime.MinValue;

	private DateTime _lastSeenWriteUtc;

	internal string Path { get; }

	internal TranslationReloader(string path)
	{
		Path = path;
		_lastSeenWriteUtc = WriteTimeOf(path);
	}

	internal bool HasChanged(DateTime nowUtc)
	{
		if (nowUtc - _lastLookedUtc < LookEvery)
		{
			return false;
		}
		_lastLookedUtc = nowUtc;
		DateTime dateTime = WriteTimeOf(Path);
		if (dateTime == _lastSeenWriteUtc)
		{
			return false;
		}
		_lastSeenWriteUtc = dateTime;
		return true;
	}

	private static DateTime WriteTimeOf(string path)
	{
		try
		{
			return File.Exists(path) ? File.GetLastWriteTimeUtc(path) : DateTime.MinValue;
		}
		catch (Exception)
		{
			return DateTime.MinValue;
		}
	}
}
