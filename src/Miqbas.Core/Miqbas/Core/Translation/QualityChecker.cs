using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

public static class QualityChecker
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<char, bool> _003C0_003E__IsAsciiLetter;

		public static Func<char, bool> _003C1_003E__IsLetter;

		public static Func<char, bool> _003C2_003E__IsAsciiDigit;

		public static Func<char, bool> _003C3_003E__IsAsciiLetterOrDigit;

		public static Func<char, bool> _003C4_003E__IsWhiteSpace;

		public static Func<char, bool> _003C5_003E__IsLower;

		public static Func<char, bool> _003C6_003E__IsLetterOrDigit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, string> _003C_003E9__18_0;

		public static Func<string, bool> _003C_003E9__18_1;

		public static Func<string, string> _003C_003E9__23_0;

		public static Func<string, bool> _003C_003E9__23_1;

		public static Func<string, bool> _003C_003E9__24_0;

		public static Func<string, bool> _003C_003E9__24_1;

		public static Func<char, bool> _003C_003E9__24_3;

		public static Func<string, bool> _003C_003E9__24_2;

		public static Func<string, bool> _003C_003E9__26_0;

		public static Func<string, bool> _003C_003E9__26_1;

		public static Func<Match, string> _003C_003E9__33_0;

		public static Func<string, string> _003C_003E9__33_1;

		public static Func<Match, string> _003C_003E9__33_2;

		public static Func<string, string> _003C_003E9__33_3;

		public static Func<string, string> _003C_003E9__33_4;

		public static Func<IGrouping<string, string>, bool> _003C_003E9__33_5;

		public static Func<IGrouping<string, string>, string> _003C_003E9__33_6;

		public static Func<string, string> _003C_003E9__33_7;

		public static Func<string, string> _003C_003E9__33_8;

		public static Func<string, string> _003C_003E9__33_9;

		public static Func<char, bool> _003C_003E9__40_0;

		public static Func<char, bool> _003C_003E9__40_1;

		public static Func<GlossaryEntry, bool> _003C_003E9__41_0;

		public static Func<GlossaryEntry, bool> _003C_003E9__43_0;

		public static Func<Match, string> _003C_003E9__45_0;

		public static Func<Match, string> _003C_003E9__45_3;

		public static Func<Match, string> _003C_003E9__51_0;

		public static Func<IGrouping<string, Match>, string> _003C_003E9__51_1;

		public static Func<IGrouping<string, Match>, int> _003C_003E9__51_2;

		public static Func<Match, string> _003C_003E9__51_3;

		public static Func<GlossaryEntry, bool> _003C_003E9__54_0;

		public static Func<GlossaryEntry, int> _003C_003E9__54_1;

		internal string A(string P_0)
		{
			return P_0.Trim(NameEdges);
		}

		internal bool a(string P_0)
		{
			return P_0.Length > 0;
		}

		internal string B(string P_0)
		{
			return P_0.Trim(NameEdges);
		}

		internal bool b(string P_0)
		{
			return TitlecaseName.IsMatch(P_0);
		}

		internal bool C(string P_0)
		{
			return Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsLetter);
		}

		internal bool c(string P_0)
		{
			if (!P_0.Contains('™'))
			{
				return P_0.Contains('®');
			}
			return true;
		}

		internal bool D(string P_0)
		{
			if (!RomanNumeral.IsMatch(P_0))
			{
				if (Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsLetter) >= 2)
				{
					return Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => !char.IsLetter(P_0) || char.IsUpper(P_0)));
				}
				return false;
			}
			return true;
		}

		internal bool A(char P_0)
		{
			if (char.IsLetter(P_0))
			{
				return char.IsUpper(P_0);
			}
			return true;
		}

		internal bool d(string P_0)
		{
			if (P_0.Length <= 24)
			{
				if (!char.IsAsciiLetterUpper(P_0[0]))
				{
					return char.IsAsciiDigit(P_0[0]);
				}
				return true;
			}
			return false;
		}

		internal bool E(string P_0)
		{
			if (Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsAsciiLetter) && Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsAsciiDigit))
			{
				return Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsAsciiLetterOrDigit);
			}
			return false;
		}

		internal string A(Match P_0)
		{
			return ((Capture)P_0.Groups[1]).Value;
		}

		internal string e(string P_0)
		{
			return P_0;
		}

		internal string a(Match P_0)
		{
			return ((Capture)P_0.Groups[1]).Value;
		}

		internal string F(string P_0)
		{
			return P_0;
		}

		internal string f(string P_0)
		{
			return P_0;
		}

		internal bool A(IGrouping<string, string> P_0)
		{
			return Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)P_0) > 1;
		}

		internal string a(IGrouping<string, string> P_0)
		{
			return P_0.Key;
		}

		internal string G(string P_0)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB();
		}

		internal string g(string P_0)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB();
		}

		internal string H(string P_0)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB();
		}

		internal bool a(char P_0)
		{
			return P_0 == '\n';
		}

		internal bool B(char P_0)
		{
			return P_0 == '\n';
		}

		internal bool A(GlossaryEntry P_0)
		{
			return P_0.Locked;
		}

		internal bool a(GlossaryEntry P_0)
		{
			return P_0.Locked;
		}

		internal string B(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal string b(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal string C(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal string A(IGrouping<string, Match> P_0)
		{
			return P_0.Key;
		}

		internal int a(IGrouping<string, Match> P_0)
		{
			return Enumerable.Count<Match>((System.Collections.Generic.IEnumerable<Match>)P_0);
		}

		internal string c(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal bool B(GlossaryEntry P_0)
		{
			if (P_0.Locked)
			{
				return P_0.Term.Length > 0;
			}
			return false;
		}

		internal int b(GlossaryEntry P_0)
		{
			return P_0.Term.Length;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public HashSet<string> inSource;

		public HashSet<string> keptOnPurpose;

		internal bool A(string P_0)
		{
			if (inSource.Contains(P_0))
			{
				return !keptOnPurpose.Contains(P_0);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string opening;

		internal bool A(string P_0)
		{
			return opening.StartsWith(P_0, (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public string source;

		public string translation;

		internal bool A(GlossaryEntry P_0)
		{
			if (QualityChecker.A(source, P_0.Term))
			{
				return QualityChecker.A(translation, P_0);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public HashSet<string> known;

		public string translation;

		internal bool A(string P_0)
		{
			return !known.Contains(P_0);
		}

		internal bool A(Match P_0)
		{
			if (!known.Contains(((Capture)P_0).Value))
			{
				if (!F(((Capture)P_0).Value))
				{
					return QualityChecker.A(translation, P_0);
				}
				return true;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public Dictionary<string, int> inSource;

		internal bool A(IGrouping<string, Match> P_0)
		{
			return Enumerable.Count<Match>((System.Collections.Generic.IEnumerable<Match>)P_0) > CollectionExtensions.GetValueOrDefault<string, int>((IReadOnlyDictionary<string, int>)(object)inSource, P_0.Key);
		}
	}

	private static readonly Regex Placeholder = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EN(), (RegexOptions)8);

	private static readonly Regex ArabicLetter = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.En(), (RegexOptions)8);

	private static readonly Regex ForeignScript = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EO(), (RegexOptions)8);

	private static readonly Regex OtherLanguagesArabicLetter = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Eo(), (RegexOptions)8);

	private static readonly string[] ChatterMarkers = new string[12]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EP(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ep(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EQ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Eq(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ER(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Er(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ES(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Es(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ET(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Et(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EU(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Eu()
	};

	private static readonly Regex LatinWord = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EV(), (RegexOptions)8);

	private static readonly Regex LiteralEscape = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ev(), (RegexOptions)8);

	private static readonly Regex DetachedArticleAt = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EW(), (RegexOptions)8);

	private static readonly Regex TitlecaseName = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ew(), (RegexOptions)8);

	private static readonly char[] NameEdges = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EX().ToCharArray();

	private static readonly Regex ArabicWord = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ex(), (RegexOptions)8);

	private static readonly Regex RomanNumeral = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EY(), (RegexOptions)8);

	private static readonly HashSet<string> Articles;

	private static readonly Regex Bracketed;

	private static readonly Regex AnAddressOrACode;

	private static readonly Regex KeyOrVersionOrTime;

	private static readonly Regex ProgramsNameLetters;

	private static readonly Regex ProgramsNameJoint;

	private static readonly string[] OpenersThatAreTheLineItself;

	private static readonly Regex CertaintyInTheLine;

	private static readonly HashSet<string> LowerCaseUnits;

	private const string ArabicLetterClass = "[ء-ؿف-يٱ-ۓ]";

	public static System.Collections.Generic.IReadOnlyList<QualityIssue> Check(string sourceMasked, string translation, StyleProfile style, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary = null, int? room = null)
	{
		List<QualityIssue> val = new List<QualityIssue>();
		if (string.IsNullOrWhiteSpace(translation))
		{
			val.Add(new QualityIssue
			{
				Kind = QualityIssueKind.Empty,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dS()
			});
			return (System.Collections.Generic.IReadOnlyList<QualityIssue>)val;
		}
		a(sourceMasked, translation, val);
		a(sourceMasked, translation, glossary, val);
		B(sourceMasked, translation, val);
		a(translation, val);
		A(sourceMasked, translation, style, val);
		b(sourceMasked, translation, val);
		B(sourceMasked, translation, glossary, val);
		C(sourceMasked, translation, glossary, val);
		C(sourceMasked, translation, val);
		A(translation, val);
		A(sourceMasked, translation, glossary, val);
		A(sourceMasked, translation, val);
		A(translation, room, val);
		return (System.Collections.Generic.IReadOnlyList<QualityIssue>)val;
	}

	private static void A(string P_0, int? P_1, List<QualityIssue> P_2)
	{
		if (P_1.HasValue)
		{
			int valueOrDefault = P_1.GetValueOrDefault();
			if (!TheRoomOfALine.Fits(P_0, valueOrDefault))
			{
				QualityIssue obj = new QualityIssue
				{
					Kind = QualityIssueKind.TooLongForItsRoom
				};
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(59, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ds());
				defaultInterpolatedStringHandler.AppendFormatted<int>(TheRoomOfALine.Letters(P_0));
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dT());
				defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dt());
				obj.Message = defaultInterpolatedStringHandler.ToStringAndClear();
				P_2.Add(obj);
			}
		}
	}

	private static void A(string P_0, string P_1, List<QualityIssue> P_2)
	{
		if (StoryGods.NamesAStoryGod(P_0))
		{
			System.Collections.Generic.IReadOnlyList<string> readOnlyList = StoryGods.WrittenAsIlah(P_1);
			if (readOnlyList != null && ((System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count > 0)
			{
				P_2.Add(new QualityIssue
				{
					Kind = QualityIssueKind.StoryGodAsIlah,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dU() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.du(), (System.Collections.Generic.IEnumerable<string>)readOnlyList) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dV()
				});
			}
		}
	}

	private static void A(string P_0, List<QualityIssue> P_1)
	{
		if (DetachedArticleAt.IsMatch(P_0))
		{
			P_1.Add(new QualityIssue
			{
				Kind = QualityIssueKind.DetachedArticle,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dv(),
				AcceptedOnLastAttempt = true
			});
		}
	}

	private static void A(string P_0, string P_1, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary, List<QualityIssue> P_3)
	{
		string text = Placeholder.Replace(P_1, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
		if (ArabicWord.Matches(text).Count < 3)
		{
			return;
		}
		string text2 = Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
		HashSet<string> inSource = Enumerable.ToHashSet<string>(C(text2), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		inSource.ExceptWith((System.Collections.Generic.IEnumerable<string>)a(text2));
		text = Bracketed.Replace(text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
		HashSet<string> keptOnPurpose = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)(glossary ?? System.Array.Empty<GlossaryEntry>())).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlossaryEntry current = enumerator.Current;
				if (Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)current.Translation, (Func<char, bool>)char.IsAsciiLetter))
				{
					keptOnPurpose.UnionWith(C(current.Term));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		List<string> val = Enumerable.ToList<string>(Enumerable.Take<string>(Enumerable.Distinct<string>(Enumerable.Where<string>(C(text), (Func<string, bool>)((string P_0) => inSource.Contains(P_0) && !keptOnPurpose.Contains(P_0))), (IEqualityComparer<string>)(object)StringComparer.Ordinal), 3));
		if (val.Count != 0)
		{
			P_3.Add(new QualityIssue
			{
				Kind = QualityIssueKind.NameLeftInLatin,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.du(), (System.Collections.Generic.IEnumerable<string>)val) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dw(),
				AcceptedOnLastAttempt = true
			});
		}
	}

	private static bool A(string P_0)
	{
		List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()).Split((char[])null, (StringSplitOptions)1), (Func<string, string>)((string P_0) => P_0.Trim(NameEdges))), (Func<string, bool>)((string P_0) => P_0.Length > 0)));
		if (val.Count > 0)
		{
			HashSet<string> articles = Articles;
			return Enumerable.All<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)articles.Contains);
		}
		return false;
	}

	private static HashSet<string> a(string P_0)
	{
		HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		string[] array = P_0.Split((char[])null, (StringSplitOptions)1);
		int num = 0;
		while (num < array.Length)
		{
			int num2 = num;
			while (num2 < array.Length && B(array[num2]))
			{
				num2++;
				if (b(array[num2 - 1]))
				{
					break;
				}
			}
			if (num2 - num >= 3)
			{
				for (int i = num; i < num2; i++)
				{
					val.Add(array[i].Trim(NameEdges));
				}
			}
			num = Math.Max(num2, num + 1);
		}
		return val;
	}

	private static bool B(string P_0)
	{
		char[] array = new char[5];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		string text = P_0.TrimStart(array);
		if (text != null && text.Length > 0)
		{
			return char.IsAsciiLetterUpper(text[0]);
		}
		return false;
	}

	private static bool b(string P_0)
	{
		switch (P_0[P_0.Length - 1])
		{
		case '!':
		case '"':
		case ')':
		case ',':
		case '.':
		case ':':
		case ';':
		case '?':
		case ']':
		case '»':
			return true;
		default:
			return false;
		}
	}

	private static System.Collections.Generic.IEnumerable<string> C(string P_0)
	{
		return Enumerable.Where<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)P_0.Split((char[])null, (StringSplitOptions)1), (Func<string, string>)((string P_0) => P_0.Trim(NameEdges))), (Func<string, bool>)((string P_0) => TitlecaseName.IsMatch(P_0)));
	}

	private static bool c(string P_0)
	{
		string text = Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
		char[] array = new char[10];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)text.Split(array, (StringSplitOptions)1), (Func<string, bool>)((string P_0) => Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsLetter))));
		if (val.Count == 0)
		{
			return false;
		}
		if (val.Count <= 5 && Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => P_0.Contains('™') || P_0.Contains('®'))))
		{
			return true;
		}
		return Enumerable.All<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => RomanNumeral.IsMatch(P_0) || (Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsLetter) >= 2 && Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => !char.IsLetter(P_0) || char.IsUpper(P_0))))));
	}

	private static bool D(string P_0)
	{
		string text = P_0.Trim();
		bool flag = text.Length >= 4 && ProgramsNameLetters.IsMatch(text) && Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsAsciiLetter);
		if (flag)
		{
			char c = text[0];
			bool flag2 = ((c == '/' || c == '\\') ? true : false);
			flag = flag2 || ProgramsNameJoint.IsMatch(text);
		}
		return flag;
	}

	private static bool d(string P_0)
	{
		string[] array = Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()).Split((char[])null, (StringSplitOptions)1);
		int num = array.Length;
		if (num > 0 && num <= 3 && Enumerable.All<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)((string P_0) => P_0.Length <= 24 && (char.IsAsciiLetterUpper(P_0[0]) || char.IsAsciiDigit(P_0[0])))))
		{
			return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, bool>)((string P_0) => Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsAsciiLetter) && Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsAsciiDigit) && Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsAsciiLetterOrDigit)));
		}
		return false;
	}

	private static bool E(string P_0)
	{
		if (P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dX(), (StringComparison)4) && P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dx(), (StringComparison)4))
		{
			return P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dY(), (StringComparison)4);
		}
		return false;
	}

	private static bool e(string P_0)
	{
		string text = Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Trim().Trim(new char[2] { '"', '\'' });
		if (text.Length <= 0 || Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsWhiteSpace) || !AnAddressOrACode.IsMatch(text))
		{
			return KeyOrVersionOrTime.IsMatch(P_0.Trim());
		}
		return true;
	}

	private static void a(string P_0, string P_1, List<QualityIssue> P_2)
	{
		List<string> val = Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)Placeholder.Matches(P_0), (Func<Match, string>)((Match P_0) => ((Capture)P_0.Groups[1]).Value)), (Func<string, string>)((string P_0) => P_0)));
		List<string> val2 = Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)Placeholder.Matches(P_1), (Func<Match, string>)((Match P_0) => ((Capture)P_0.Groups[1]).Value)), (Func<string, string>)((string P_0) => P_0)));
		if (Enumerable.SequenceEqual<string>((System.Collections.Generic.IEnumerable<string>)val, (System.Collections.Generic.IEnumerable<string>)val2))
		{
			return;
		}
		List<string> val3 = Enumerable.ToList<string>(Enumerable.Except<string>((System.Collections.Generic.IEnumerable<string>)val, (System.Collections.Generic.IEnumerable<string>)val2));
		List<string> val4 = Enumerable.ToList<string>(Enumerable.Except<string>((System.Collections.Generic.IEnumerable<string>)val2, (System.Collections.Generic.IEnumerable<string>)val));
		List<string> val5 = Enumerable.ToList<string>(Enumerable.Select<IGrouping<string, string>, string>(Enumerable.Where<IGrouping<string, string>>(Enumerable.GroupBy<string, string>((System.Collections.Generic.IEnumerable<string>)val2, (Func<string, string>)((string P_0) => P_0)), (Func<IGrouping<string, string>, bool>)((IGrouping<string, string> P_0) => Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)P_0) > 1)), (Func<IGrouping<string, string>, string>)((IGrouping<string, string> P_0) => P_0.Key)));
		List<string> val6 = new List<string>();
		if (val3.Count > 0)
		{
			val6.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dy() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dZ(), Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)val3, (Func<string, string>)((string P_0) => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB()))));
		}
		if (val4.Count > 0)
		{
			val6.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dz() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dZ(), Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)val4, (Func<string, string>)((string P_0) => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB()))));
		}
		if (val5.Count > 0)
		{
			val6.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EA() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dZ(), Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)val5, (Func<string, string>)((string P_0) => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB()))));
		}
		P_2.Add(new QualityIssue
		{
			Kind = QualityIssueKind.PlaceholderMismatch,
			Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ea() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DN(), (System.Collections.Generic.IEnumerable<string>)val6) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB()
		});
	}

	private static void a(string P_0, string P_1, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary, List<QualityIssue> P_3)
	{
		if (f(P_0) && !A(P_0, glossary) && !c(P_0) && !A(P_0) && !D(P_0) && !d(P_0) && !E(P_0) && !e(P_0))
		{
			if (!ArabicLetter.IsMatch(P_1))
			{
				P_3.Add(new QualityIssue
				{
					Kind = QualityIssueKind.NotArabic,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Eb()
				});
			}
			Match val = ForeignScript.Match(P_1);
			if (val != null && ((Group)val).Success)
			{
				P_3.Add(new QualityIssue
				{
					Kind = QualityIssueKind.NotArabic,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EC() + ((Capture)val).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ec()
				});
			}
			Match val2 = OtherLanguagesArabicLetter.Match(P_1);
			if (val2 != null && ((Group)val2).Success)
			{
				P_3.Add(new QualityIssue
				{
					Kind = QualityIssueKind.NotArabic,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ED() + ((Capture)val2).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ed()
				});
			}
		}
	}

	private static void B(string P_0, string P_1, List<QualityIssue> P_2)
	{
		string opening = P_0.TrimStart().Replace('’', '\'');
		if (Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)OpenersThatAreTheLineItself, (Func<string, bool>)((string P_0) => opening.StartsWith(P_0, (StringComparison)5))) || CertaintyInTheLine.IsMatch(P_0))
		{
			return;
		}
		string text = P_1.TrimStart();
		string[] chatterMarkers = ChatterMarkers;
		foreach (string text2 in chatterMarkers)
		{
			if (text.StartsWith(text2, (StringComparison)5))
			{
				P_2.Add(new QualityIssue
				{
					Kind = QualityIssueKind.Chatter,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EE() + text2 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ee()
				});
				break;
			}
		}
	}

	private static void a(string P_0, List<QualityIssue> P_1)
	{
		if (ArabicPresentationForms.AreIn(P_0))
		{
			P_1.Add(new QualityIssue
			{
				Kind = QualityIssueKind.PresentationForms,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EF()
			});
		}
	}

	private static void A(string P_0, string P_1, StyleProfile P_2, List<QualityIssue> P_3)
	{
		string text = Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Trim();
		string text2 = Placeholder.Replace(P_1, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Trim();
		if (!(ScriptWeight.Weigh(text) < 20.0))
		{
			double num = (double)text2.Length / ScriptWeight.Weigh(text);
			if (num > P_2.MaxLengthRatio)
			{
				QualityIssue obj = new QualityIssue
				{
					Kind = QualityIssueKind.TooLong
				};
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(52, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ef());
				defaultInterpolatedStringHandler.AppendFormatted<double>((num - 1.0) * 100.0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EG());
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Eg());
				obj.Message = defaultInterpolatedStringHandler.ToStringAndClear();
				obj.Blocking = false;
				P_3.Add(obj);
			}
		}
	}

	private static void b(string P_0, string P_1, List<QualityIssue> P_2)
	{
		int num = Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 == '\n'));
		int num2 = Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)P_1, (Func<char, bool>)((char P_0) => P_0 == '\n'));
		if (num != num2)
		{
			QualityIssue obj = new QualityIssue
			{
				Kind = QualityIssueKind.LineBreakMismatch
			};
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(42, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EH());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Eh());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EI());
			obj.Message = defaultInterpolatedStringHandler.ToStringAndClear();
			obj.Blocking = false;
			P_2.Add(obj);
		}
	}

	public static bool HonoursTheLockedTerms(string source, string translation, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary)
	{
		string source2 = source;
		string translation2 = translation;
		if (glossary == null)
		{
			return true;
		}
		return Enumerable.All<GlossaryEntry>(Enumerable.Where<GlossaryEntry>((System.Collections.Generic.IEnumerable<GlossaryEntry>)glossary, (Func<GlossaryEntry, bool>)((GlossaryEntry P_0) => P_0.Locked)), (Func<GlossaryEntry, bool>)((GlossaryEntry P_0) => !A(source2, P_0.Term) || A(translation2, P_0)));
	}

	private static bool A(string P_0, GlossaryEntry P_1)
	{
		if (!string.Equals(P_1.Term, P_1.Translation, (StringComparison)5))
		{
			if (!P_0.Contains(P_1.Translation, (StringComparison)4) && !P_0.Contains(StoryGods.Mend(P_1.Translation), (StringComparison)4))
			{
				return P_0.Contains(NamesOnlyAllahBears.MendedAnywhere(P_1.Translation), (StringComparison)4);
			}
			return true;
		}
		return P_0.Contains(P_1.Translation, (StringComparison)5);
	}

	private static void B(string P_0, string P_1, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary, List<QualityIssue> P_3)
	{
		if (glossary == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = Enumerable.Where<GlossaryEntry>((System.Collections.Generic.IEnumerable<GlossaryEntry>)glossary, (Func<GlossaryEntry, bool>)((GlossaryEntry P_0) => P_0.Locked)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlossaryEntry current = enumerator.Current;
				if (A(P_0, current.Term) && !A(P_1, current))
				{
					QualityIssue obj = new QualityIssue
					{
						Kind = QualityIssueKind.GlossaryViolation
					};
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(42, 2);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ei());
					defaultInterpolatedStringHandler.AppendFormatted(current.Term);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EJ());
					defaultInterpolatedStringHandler.AppendFormatted(current.Translation);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ej());
					obj.Message = defaultInterpolatedStringHandler.ToStringAndClear();
					P_3.Add(obj);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		b(P_0, P_1, glossary, P_3);
	}

	private static void b(string P_0, string P_1, System.Collections.Generic.IReadOnlyList<GlossaryEntry> P_2, List<QualityIssue> P_3)
	{
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)P_2).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlossaryEntry current = enumerator.Current;
				if (!string.Equals(current.Term, current.Translation, (StringComparison)5) && A(P_0, current.Term) && A(P_1, current.Term))
				{
					QualityIssue obj = new QualityIssue
					{
						Kind = QualityIssueKind.GlossaryViolation
					};
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(48, 2);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW());
					defaultInterpolatedStringHandler.AppendFormatted(current.Term);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EK());
					defaultInterpolatedStringHandler.AppendFormatted(current.Translation);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ek());
					obj.Message = defaultInterpolatedStringHandler.ToStringAndClear();
					obj.Blocking = false;
					P_3.Add(obj);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static void C(string P_0, string P_1, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary, List<QualityIssue> P_3)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		string translation = P_1;
		HashSet<string> known = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		foreach (Match item in LatinWord.Matches(P_0))
		{
			Match val = item;
			known.Add(((Capture)val).Value);
		}
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator2 = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)(glossary ?? System.Array.Empty<GlossaryEntry>())).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				GlossaryEntry current = enumerator2.Current;
				foreach (Match item2 in LatinWord.Matches(current.Term + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X() + current.Translation))
				{
					Match val2 = item2;
					known.Add(((Capture)val2).Value);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
		List<string> val3 = Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Where<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)LatinWord.Matches(translation), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (Func<string, bool>)((string P_0) => !known.Contains(P_0))), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		if (val3.Count != 0)
		{
			List<string> val4 = Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<Match, string>(Enumerable.Where<Match>((System.Collections.Generic.IEnumerable<Match>)LatinWord.Matches(translation), (Func<Match, bool>)((Match P_0) => !known.Contains(((Capture)P_0).Value) && (F(((Capture)P_0).Value) || A(translation, P_0)))), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
			System.Collections.Generic.IEnumerable<string> enumerable = Enumerable.Take<string>((System.Collections.Generic.IEnumerable<string>)((val4.Count > 0) ? val4 : val3), 3);
			P_3.Add(new QualityIssue
			{
				Kind = QualityIssueKind.LatinWordNotInSource,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.du(), enumerable) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EL(),
				Blocking = (val4.Count > 0)
			});
		}
	}

	private static bool F(string P_0)
	{
		if (P_0.Length >= 3 && Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsLower))
		{
			return !LowerCaseUnits.Contains(P_0);
		}
		return false;
	}

	private static bool A(string P_0, Match P_1)
	{
		char c = ((((Capture)P_1).Index > 0) ? P_0[((Capture)P_1).Index - 1] : '\0');
		if (!A((((Capture)P_1).Index + ((Capture)P_1).Length < P_0.Length) ? P_0[((Capture)P_1).Index + ((Capture)P_1).Length] : '\0'))
		{
			if (A(c))
			{
				return char.IsLower(((Capture)P_1).Value[0]);
			}
			return false;
		}
		return true;
	}

	private static bool A(char P_0)
	{
		return Regex.IsMatch(P_0.ToString(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.El());
	}

	private static void C(string P_0, string P_1, List<QualityIssue> P_2)
	{
		Dictionary<string, int> inSource = Enumerable.ToDictionary<IGrouping<string, Match>, string, int>(Enumerable.GroupBy<Match, string>((System.Collections.Generic.IEnumerable<Match>)LiteralEscape.Matches(P_0), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (Func<IGrouping<string, Match>, string>)((IGrouping<string, Match> P_0) => P_0.Key), (Func<IGrouping<string, Match>, int>)((IGrouping<string, Match> P_0) => Enumerable.Count<Match>((System.Collections.Generic.IEnumerable<Match>)P_0)), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		IGrouping<string, Match> val = Enumerable.FirstOrDefault<IGrouping<string, Match>>(Enumerable.GroupBy<Match, string>((System.Collections.Generic.IEnumerable<Match>)LiteralEscape.Matches(P_1), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (Func<IGrouping<string, Match>, bool>)((IGrouping<string, Match> P_0) => Enumerable.Count<Match>((System.Collections.Generic.IEnumerable<Match>)P_0) > CollectionExtensions.GetValueOrDefault<string, int>((IReadOnlyDictionary<string, int>)(object)inSource, P_0.Key)));
		if (val != null)
		{
			P_2.Add(new QualityIssue
			{
				Kind = QualityIssueKind.EscapeSequenceNotInSource,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EM() + val.Key + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Em()
			});
		}
	}

	private static bool A(string P_0, string P_1)
	{
		return TermMatch.AsAWholeWord(P_0, P_1);
	}

	private static bool f(string P_0)
	{
		return !string.IsNullOrWhiteSpace(Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Trim());
	}

	private static bool A(string P_0, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (glossary == null)
		{
			return false;
		}
		List<GlossaryEntry> val = Enumerable.ToList<GlossaryEntry>(Enumerable.Where<GlossaryEntry>((System.Collections.Generic.IEnumerable<GlossaryEntry>)glossary, (Func<GlossaryEntry, bool>)((GlossaryEntry P_0) => P_0.Locked && P_0.Term.Length > 0)));
		if (val.Count == 0)
		{
			return false;
		}
		string text = Placeholder.Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)Enumerable.OrderByDescending<GlossaryEntry, int>((System.Collections.Generic.IEnumerable<GlossaryEntry>)val, (Func<GlossaryEntry, int>)((GlossaryEntry P_0) => P_0.Term.Length))).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlossaryEntry current = enumerator.Current;
				text = text.Replace(current.Term, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X(), TermMatch.ComparisonFor(current.Term));
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return !Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsLetterOrDigit);
	}

	static QualityChecker()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@do());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ey());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EZ());
		Articles = obj;
		Bracketed = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ez(), (RegexOptions)8);
		AnAddressOrACode = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eA(), (RegexOptions)520);
		KeyOrVersionOrTime = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ea(), (RegexOptions)520);
		ProgramsNameLetters = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eB(), (RegexOptions)8);
		ProgramsNameJoint = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eb(), (RegexOptions)8);
		OpenersThatAreTheLineItself = new string[12]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eC(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ec(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eD(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ed(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eE(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ee(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eF(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ES(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Es(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ef(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eG(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eg()
		};
		CertaintyInTheLine = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eH(), (RegexOptions)9);
		HashSet<string> obj2 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eh());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eI());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ei());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eJ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ej());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eK());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ek());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eL());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.el());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eM());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.em());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eN());
		LowerCaseUnits = obj2;
	}
}
