using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class TermMatch
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<char, bool> _003C0_003E__IsLetter;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<char, bool> _003C_003E9__0_0;

		internal bool A(char P_0)
		{
			if (char.IsLetter(P_0))
			{
				return char.IsUpper(P_0);
			}
			return true;
		}
	}

	public static bool IsAcronym(string term)
	{
		if (Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)term, (Func<char, bool>)char.IsLetter) >= 2)
		{
			return Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)term, (Func<char, bool>)((char P_0) => !char.IsLetter(P_0) || char.IsUpper(P_0)));
		}
		return false;
	}

	public static StringComparison ComparisonFor(string term)
	{
		if (IsAcronym(term))
		{
			return (StringComparison)4;
		}
		return (StringComparison)5;
	}

	public static bool AsAWholeWord(string text, string term)
	{
		return Regex.IsMatch(text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BQ() + Regex.Escape(term) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BQ(), (RegexOptions)(!IsAcronym(term)));
	}
}
