using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public static class AnExceptionInTheLog
{
	[CompilerGenerated]
	private sealed class A
	{
		public string logText;

		internal string A(Match P_0)
		{
			return AnExceptionInTheLog.A(logText, P_0);
		}
	}

	private static readonly Regex Thrown = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oW(), (RegexOptions)10);

	public static string? In(string? logText)
	{
		if (string.IsNullOrEmpty(logText))
		{
			return null;
		}
		Match val = Thrown.Match(logText);
		if (!((Group)val).Success)
		{
			return null;
		}
		return ((Capture)val.Groups[1]).Value;
	}

	public static System.Collections.Generic.IReadOnlyList<string> ShapesIn(string? logText)
	{
		string logText2 = logText;
		if (!string.IsNullOrEmpty(logText2))
		{
			return (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)Thrown.Matches(logText2), (Func<Match, string>)((Match P_0) => A(logText2, P_0))), (IEqualityComparer<string>)(object)StringComparer.Ordinal));
		}
		return (System.Collections.Generic.IReadOnlyList<string>)new List<string>();
	}

	public static string? NewIn(string? logText, System.Collections.Generic.IReadOnlyCollection<string>? theCleanRunsThrows)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (string.IsNullOrEmpty(logText))
		{
			return null;
		}
		foreach (Match item in Thrown.Matches(logText))
		{
			Match val = item;
			if (theCleanRunsThrows == null || !Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)theCleanRunsThrows, A(logText, val)))
			{
				return ((Capture)val.Groups[1]).Value;
			}
		}
		return null;
	}

	private static string A(string P_0, Match P_1)
	{
		int index = ((Capture)P_1.Groups[1]).Index;
		int num = ((index != 0) ? (P_0.LastIndexOf('\n', index - 1) + 1) : 0);
		int num2 = P_0.IndexOf('\n', index);
		int num3 = num;
		string text = P_0.Substring(num3, ((num2 < 0) ? P_0.Length : num2) - num3).Trim();
		if (num2 >= 0)
		{
			int num4 = P_0.IndexOf('\n', num2 + 1);
			num3 = num2 + 1;
			string text2 = P_0.Substring(num3, ((num4 < 0) ? P_0.Length : num4) - num3).Trim();
			if (text2.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ov(), (StringComparison)4))
			{
				text = text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ol() + text2;
			}
		}
		return LogMilestone.ShapeOf(text);
	}
}
