using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class VariableMasker
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

		public static Func<string, bool> _003C_003E9__17_1;

		public static Func<string, bool> _003C_003E9__17_3;

		public static Func<string, int> _003C_003E9__17_4;

		public static Func<string, bool> _003C_003E9__18_0;

		public static Func<string, int> _003C_003E9__18_1;

		public static Func<bool, int, ValueTuple<bool, int>> _003C_003E9__21_1;

		public static Func<ValueTuple<bool, int>, bool> _003C_003E9__21_2;

		internal bool A(string P_0)
		{
			return P_0.StartsWith('#');
		}

		internal bool a(string P_0)
		{
			return !P_0.StartsWith('#');
		}

		internal int B(string P_0)
		{
			return P_0.Length;
		}

		internal bool b(string P_0)
		{
			return P_0.Length > 0;
		}

		internal int C(string P_0)
		{
			return P_0.Length;
		}

		internal ValueTuple<bool, int> A(bool P_0, int P_1)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<bool, int>(P_0, P_1);
		}

		internal bool A(ValueTuple<bool, int> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return !t.Item1;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public List<string> tokens;

		internal string A(Match P_0)
		{
			if (!VariableMasker.A(((Capture)P_0.Groups[1]).Value))
			{
				return ((Capture)P_0).Value;
			}
			tokens.Add(((Capture)P_0).Value);
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
			defaultInterpolatedStringHandler.AppendFormatted<int>(tokens.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		internal string a(Match P_0)
		{
			tokens.Add(((Capture)P_0).Value);
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
			defaultInterpolatedStringHandler.AppendFormatted<int>(tokens.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public System.Collections.Generic.IReadOnlyList<string> tokens;

		public bool[] seen;

		internal string A(Match P_0)
		{
			int num = int.Parse(((Capture)P_0.Groups[1]).Value) - 1;
			if (num < 0 || num >= ((System.Collections.Generic.IReadOnlyCollection<string>)tokens).Count)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(87, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rO());
				defaultInterpolatedStringHandler.AppendFormatted(((Capture)P_0).Value);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ro());
				defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<string>)tokens).Count);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EI());
				throw new MaskRestoreException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (seen[num])
			{
				throw new MaskRestoreException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rP() + ((Capture)P_0).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rp());
			}
			seen[num] = true;
			return tokens[num];
		}

		internal string A(ValueTuple<bool, int> t)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
			defaultInterpolatedStringHandler.AppendFormatted<int>(t.Item2 + 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rQ());
			defaultInterpolatedStringHandler.AppendFormatted(tokens[t.Item2]);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	private const string ParadoxExpression = "\\[\\s?(?:['%A-Za-z0-9_][A-Za-z0-9_' %]{0,80}(?:[.,][^\\s\\]]|[(|])[^\\[\\]\\r\\n]{0,1500}|[A-Za-z_]*[A-Z][A-Za-z0-9_]*)\\]";

	private const string ParadoxValue = "\\$[A-Za-z0-9_][^$\\s]{0,200}\\$";

	private const string ParadoxIcon = "@(?:[A-Za-z0-9_:.]|\\[[^\\[\\]\\r\\n]*\\]|\\$[^$\\r\\n]*\\$)+!";

	private const string ParadoxStyle = "#!|#[A-Za-z][A-Za-z0-9_;]*(?::(?:\\{(?:\\[[^\\]\\r\\n]*\\]|[^}\\r\\n])*\\}|\\[[^\\]\\r\\n]*\\]|\\$[^$\\r\\n]*\\$|[^\\s#\"\\[{$])*)?(?: |(?=\\n)|$)";

	private const string ParadoxClassicCodes = "§[A-Za-z0-9!]|£[A-Za-z0-9_]+(?:\\|[A-Za-z0-9_]+)?|\\[\\?[^\\[\\]\\r\\n]{1,300}\\]";

	private const string LineOrKeyInParentheses = "[@#]\\([A-Za-z_][A-Za-z0-9_.]{0,63}\\)";

	private const string BareDollarName = "\\$[A-Za-z_][A-Za-z0-9_]*";

	private const string NumberedValue = "%\\d{1,2}(?![\\d$])";

	private const string AdventureCreatorCodes = "\\[(?:expression|paramlabel|paramvalue):[^\\[\\]\\r\\n]{1,64}\\]|\\[(?:wait|hold|continue)(?::[0-9.]{1,6})?\\]|(?<![A-Za-z0-9&])&\\d{1,6}(?![\\d;])";

	private const string HashCodes = "(?<![#A-Za-z0-9])(?:#k[A-Za-z0-9_/]{1,64}#z|#c[0-9A-Fa-f]{6}|#[A-Za-z][A-Za-z0-9_]{1,40}#(?![#!A-Za-z0-9]))";

	private static readonly Regex TokenPattern = new Regex(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fV(), new string[21]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fv(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fW(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fw(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fX(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fx(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fY(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fy(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fZ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fz(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GA(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ga(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GB(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gb(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GC(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gc(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GD(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gd(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GE(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ge(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GF(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gf()
	}), (RegexOptions)8);

	private static readonly Regex TokenPatternKeepingNewlines = new Regex(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fV(), new string[19]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fv(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fw(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fX(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fx(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fY(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fy(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fZ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fz(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GA(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ga(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GB(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gb(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GC(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gc(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GD(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gd(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GE(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ge(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GF()
	}), (RegexOptions)8);

	private static readonly Regex PlaceholderPattern = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GG(), (RegexOptions)8);

	public const int TagsThatFoldTerms = 8;

	private static readonly Regex ShortTaggedTerm = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gg(), (RegexOptions)8);

	private static bool A(string P_0)
	{
		string text = P_0.Trim();
		int length = text.Length;
		if (length > 0 && length <= 40)
		{
			return text.Split((char[])null, (StringSplitOptions)1).Length <= 3;
		}
		return false;
	}

	public static int CountTags(string source)
	{
		if (string.IsNullOrEmpty(source))
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] == '<' && source.IndexOf('>', i + 1) > i)
			{
				num++;
			}
		}
		return num;
	}

	public static MaskedText Mask(string source, bool maskNewlines = true, IReadOnlyDictionary<string, string>? terms = null, System.Collections.Generic.IReadOnlyCollection<string>? codes = null)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		List<string> tokens = new List<string>();
		Regex obj = (maskNewlines ? TokenPattern : TokenPatternKeepingNewlines);
		string text = ((CountTags(source) >= 8) ? ShortTaggedTerm.Replace(source, (MatchEvaluator)delegate(Match P_0)
		{
			if (!A(((Capture)P_0.Groups[1]).Value))
			{
				return ((Capture)P_0).Value;
			}
			tokens.Add(((Capture)P_0).Value);
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler3.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
			defaultInterpolatedStringHandler3.AppendFormatted<int>(tokens.Count);
			defaultInterpolatedStringHandler3.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
			return defaultInterpolatedStringHandler3.ToStringAndClear();
		}) : source);
		if (codes != null && codes.Count > 0)
		{
			text = A(text, Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)codes, (Func<string, bool>)((string P_0) => P_0.StartsWith('#'))), tokens);
		}
		string text2 = obj.Replace(text, (MatchEvaluator)delegate(Match P_0)
		{
			tokens.Add(((Capture)P_0).Value);
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
			defaultInterpolatedStringHandler2.AppendFormatted<int>(tokens.Count);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		});
		if (codes != null && codes.Count > 0)
		{
			text2 = A(text2, Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)codes, (Func<string, bool>)((string P_0) => !P_0.StartsWith('#'))), tokens);
		}
		if (terms != null && ((System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, string>>)terms).Count > 0 && a(text2))
		{
			System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderByDescending<string, int>(terms.Keys, (Func<string, int>)((string P_0) => P_0.Length))).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					if (current.Length != 0 && terms[current].Length != 0)
					{
						int num = text2.IndexOf(current, TermMatch.ComparisonFor(current));
						if (num >= 0 && A(text2, num, current.Length))
						{
							tokens.Add(terms[current]);
							string text3 = text2.Substring(0, num);
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
							defaultInterpolatedStringHandler.AppendFormatted<int>(tokens.Count);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
							string text4 = defaultInterpolatedStringHandler.ToStringAndClear();
							string text5 = text2;
							int num2 = num + current.Length;
							text2 = text3 + text4 + text5.Substring(num2, text5.Length - num2);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		return new MaskedText
		{
			Masked = text2,
			Tokens = (System.Collections.Generic.IReadOnlyList<string>)tokens
		};
	}

	private static string A(string P_0, System.Collections.Generic.IEnumerable<string> P_1, List<string> P_2)
	{
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderByDescending<string, int>(Enumerable.Where<string>(P_1, (Func<string, bool>)((string P_0) => P_0.Length > 0)), (Func<string, int>)((string P_0) => P_0.Length))).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				int num = 0;
				int num2;
				while ((num2 = P_0.IndexOf(current, num, (StringComparison)4)) >= 0)
				{
					P_2.Add(current);
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
					defaultInterpolatedStringHandler.AppendFormatted<int>(P_2.Count);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
					string text = defaultInterpolatedStringHandler.ToStringAndClear();
					string text2 = P_0.Substring(0, num2);
					string text3 = P_0;
					int num3 = num2 + current.Length;
					P_0 = text2 + text + text3.Substring(num3, text3.Length - num3);
					num = num2 + text.Length;
				}
			}
			return P_0;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static bool a(string P_0)
	{
		int num = 0;
		string[] array = P_0.Split((char[])null, (StringSplitOptions)1);
		foreach (string text in array)
		{
			if (Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsLetter) && !text.StartsWith('⟦'))
			{
				num++;
			}
		}
		return num <= 3;
	}

	private static bool A(string P_0, int P_1, int P_2)
	{
		bool num = P_1 == 0 || !char.IsLetterOrDigit(P_0[P_1 - 1]);
		bool flag = P_1 + P_2 >= P_0.Length || !char.IsLetterOrDigit(P_0[P_1 + P_2]);
		return num && flag;
	}

	public static string Unmask(string translatedMasked, System.Collections.Generic.IReadOnlyList<string> tokens)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		System.Collections.Generic.IReadOnlyList<string> tokens2 = tokens;
		bool[] seen = new bool[((System.Collections.Generic.IReadOnlyCollection<string>)tokens2).Count];
		string text = PlaceholderPattern.Replace(translatedMasked, (MatchEvaluator)delegate(Match P_0)
		{
			int num = int.Parse(((Capture)P_0.Groups[1]).Value) - 1;
			if (num < 0 || num >= ((System.Collections.Generic.IReadOnlyCollection<string>)tokens2).Count)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(87, 2);
				defaultInterpolatedStringHandler3.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rO());
				defaultInterpolatedStringHandler3.AppendFormatted(((Capture)P_0).Value);
				defaultInterpolatedStringHandler3.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ro());
				defaultInterpolatedStringHandler3.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<string>)tokens2).Count);
				defaultInterpolatedStringHandler3.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EI());
				throw new MaskRestoreException(defaultInterpolatedStringHandler3.ToStringAndClear());
			}
			if (seen[num])
			{
				throw new MaskRestoreException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rP() + ((Capture)P_0).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rp());
			}
			seen[num] = true;
			return tokens2[num];
		});
		List<string> val = Enumerable.ToList<string>(Enumerable.Select<ValueTuple<bool, int>, string>(Enumerable.Where<ValueTuple<bool, int>>(Enumerable.Select<bool, ValueTuple<bool, int>>((System.Collections.Generic.IEnumerable<bool>)seen, (Func<bool, int, ValueTuple<bool, int>>)((bool P_0, int P_1) => new ValueTuple<bool, int>(P_0, P_1))), (Func<ValueTuple<bool, int>, bool>)((ValueTuple<bool, int> t) => !t.Item1)), (Func<ValueTuple<bool, int>, string>)delegate(ValueTuple<bool, int> t)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
			defaultInterpolatedStringHandler2.AppendFormatted<int>(t.Item2 + 1);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rQ());
			defaultInterpolatedStringHandler2.AppendFormatted(tokens2[t.Item2]);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}));
		if (val.Count > 0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(41, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fU());
			defaultInterpolatedStringHandler.AppendFormatted<int>(val.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fu());
			defaultInterpolatedStringHandler.AppendFormatted(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dZ(), (System.Collections.Generic.IEnumerable<string>)val));
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
			throw new MaskRestoreException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (text.IndexOf('⟦') < 0 && text.IndexOf('⟧') < 0)
		{
			return text;
		}
		return text.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
	}
}
