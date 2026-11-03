using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class SourceLanguage
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<Match, string> _003C_003E9__14_0;

		public static Func<Match, string> _003C_003E9__16_0;

		public static Func<Match, string> _003C_003E9__19_0;

		internal string A(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal string a(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal string B(Match P_0)
		{
			return ((Capture)P_0).Value;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public int i;

		internal bool A(string P_0)
		{
			return Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)SmallWordsOf[i], P_0, (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public int i;

		internal bool A(string P_0)
		{
			return Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)SmallWordsOf[i], P_0, (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		}
	}

	private const string LettersEnglishDoesNotWrite = "àâäçèéêëîïôöùûüÿœæáíóúñãõżłśćęąńźğşıİøåðþßąėįųūčšžěřůťďňāēīķļņ";

	private static readonly string[] CodesOf = new string[8]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hF(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hf(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hG(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hg(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ge(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hH(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hh(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hp()
	};

	private static readonly string[][] SmallWordsOf = new string[8][]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hR().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hr().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hS().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hs().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hT().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ht().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hU().Split(' ', (StringSplitOptions)0),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hu().Split(' ', (StringSplitOptions)0)
	};

	private static readonly HashSet<string> SmallWordsOfEnglish = new HashSet<string>((System.Collections.Generic.IEnumerable<string>)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hV().Split(' ', (StringSplitOptions)0), (IEqualityComparer<string>)(object)StringComparer.Ordinal);

	private static readonly HashSet<string> LanguageNames = new HashSet<string>((System.Collections.Generic.IEnumerable<string>)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hv().Split(' ', (StringSplitOptions)0), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);

	private static readonly HashSet<string> TheSourceLanguagesNames = new HashSet<string>((System.Collections.Generic.IEnumerable<string>)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hW().Split(' ', (StringSplitOptions)0), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);

	private static readonly Regex ContainerWords = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hw(), (RegexOptions)512);

	private static readonly Regex Markup = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hX(), (RegexOptions)512);

	private static readonly Regex Placeholder = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hx(), (RegexOptions)512);

	private static readonly Regex Words = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hY(), (RegexOptions)512);

	public static NotTheSourceLanguage Judge(string text, string? container = null)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return NotTheSourceLanguage.No;
		}
		if (A(text))
		{
			return NotTheSourceLanguage.AnotherScript;
		}
		if (container != null && container.Length > 0 && a(container))
		{
			return NotTheSourceLanguage.AContainerThatNamesItsLanguage;
		}
		if (!C(text))
		{
			return NotTheSourceLanguage.No;
		}
		return NotTheSourceLanguage.AnotherLatinLanguage;
	}

	public static bool IsTheSourceLanguage(string text, string? container = null)
	{
		return Judge(text, container) == NotTheSourceLanguage.No;
	}

	public static string? WhichLatinLanguage(string text)
	{
		return A(text, true);
	}

	public static string? WhichLatinLanguageOf(System.Collections.Generic.IEnumerable<string> lines)
	{
		ArgumentNullException.ThrowIfNull((object)lines, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.he());
		return A(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X(), lines), false);
	}

	private static string? A(string P_0, bool P_1)
	{
		if (string.IsNullOrWhiteSpace(P_0) || A(P_0))
		{
			return null;
		}
		string text = Placeholder.Replace(Markup.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()).ToLowerInvariant();
		string[] array = Enumerable.ToArray<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)Words.Matches(text), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)));
		if (array.Length == 0)
		{
			return null;
		}
		HashSet<string> smallWordsOfEnglish = SmallWordsOfEnglish;
		int num = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)smallWordsOfEnglish.Contains);
		int num2 = -1;
		int num3 = 0;
		int i;
		for (i = 0; i < SmallWordsOf.Length; i++)
		{
			int num4 = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)((string P_0) => Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)SmallWordsOf[i], P_0, (IEqualityComparer<string>)(object)StringComparer.Ordinal)));
			if (num4 > num3)
			{
				num3 = num4;
				num2 = i;
			}
		}
		if (num2 < 0)
		{
			return null;
		}
		if ((num3 < 2 || num3 <= num) && (!P_1 || array.Length > 4 || num != 0 || num3 < 1 || !A(num2)))
		{
			return null;
		}
		return CodesOf[num2];
	}

	private static bool A(string P_0)
	{
		foreach (char c in P_0)
		{
			if (char.IsLetter(c))
			{
				int num = c;
				if ((num >= 880 && num <= 1023) || (num >= 1024 && num <= 1327) || (num >= 1424 && num <= 1535) || (num >= 2304 && num <= 2431) || (num >= 3584 && num <= 3711) || (num >= 4352 && num <= 4607) || (num >= 12352 && num <= 12543) || (num >= 13312 && num <= 40959) || (num >= 44032 && num <= 55215) || (num >= 63744 && num <= 64255))
				{
					return true;
				}
			}
		}
		return false;
	}

	private static bool a(string P_0)
	{
		string text = B(P_0);
		string[] array = Enumerable.ToArray<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)ContainerWords.Matches(text), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)));
		HashSet<string> languageNames = LanguageNames;
		if (!Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)languageNames.Contains))
		{
			return b(text);
		}
		HashSet<string> theSourceLanguagesNames = TheSourceLanguagesNames;
		return !Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)theSourceLanguagesNames.Contains);
	}

	private static string B(string P_0)
	{
		string[] array = P_0.Split(new char[2] { '/', '\\' }, (StringSplitOptions)1);
		if (array.Length > 1)
		{
			return string.Join('/', array[^2..]);
		}
		return P_0;
	}

	private static bool b(string P_0)
	{
		string[] array = new string[26]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hF(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hf(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hG(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hg(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ge(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hH(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hh(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hI(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hi(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hJ(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hj(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hK(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hk(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hL(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hl(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gX(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hM(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hm(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hN(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hn(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hO(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ho(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hP(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hp(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.go(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hQ()
		};
		char[] array2 = new char[6];
		RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		string[] array3 = P_0.Split(array2, (StringSplitOptions)1);
		foreach (string text in array3)
		{
			if (Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)array, text.ToLowerInvariant()))
			{
				return true;
			}
		}
		return false;
	}

	private static bool C(string P_0)
	{
		foreach (char c in P_0)
		{
			if (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hq().Contains(char.ToLowerInvariant(c)))
			{
				return true;
			}
		}
		string text = Placeholder.Replace(Markup.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()).ToLowerInvariant();
		string[] array = Enumerable.ToArray<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)Words.Matches(text), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)));
		if (array.Length == 0)
		{
			return false;
		}
		HashSet<string> smallWordsOfEnglish = SmallWordsOfEnglish;
		int num = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)smallWordsOfEnglish.Contains);
		int num2 = 0;
		int num3 = 0;
		int i;
		for (i = 0; i < SmallWordsOf.Length; i++)
		{
			int num4 = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)((string P_0) => Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)SmallWordsOf[i], P_0, (IEqualityComparer<string>)(object)StringComparer.Ordinal)));
			num2 = Math.Max(num2, num4);
			if (A(i))
			{
				num3 = Math.Max(num3, num4);
			}
		}
		if (num2 >= 2 && num2 > num)
		{
			return true;
		}
		if (array.Length <= 4 && num == 0)
		{
			return num3 >= 1;
		}
		return false;
	}

	private static bool A(int P_0)
	{
		return CodesOf[P_0] != EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hp();
	}
}
