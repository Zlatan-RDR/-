using System;
using System.Runtime.CompilerServices;

namespace Miqbas.Rendering.Arabic;

public static class AShortLabel
{
	public const int LongestLabel = 24;

	private static readonly char[] SentenceMarks;

	public static bool TheLine(string? line)
	{
		if (string.IsNullOrWhiteSpace(line))
		{
			return false;
		}
		string text = line.Trim();
		if (text.Length > 24 || text.IndexOfAny(SentenceMarks) >= 0)
		{
			return false;
		}
		return text.Split(new char[1] { ' ' }, (StringSplitOptions)1).Length <= 2;
	}

	static AShortLabel()
	{
		char[] array = new char[7];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		SentenceMarks = array;
	}
}
