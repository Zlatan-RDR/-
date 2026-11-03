using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class NamesOnlyAllahBears
{
	private sealed class A : IEquatable<A>
	{
		[CompilerGenerated]
		private System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(A);
			}
		}

		[field: CompilerGenerated]
		public Regex English
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public Regex Arabic
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public Func<Match, string> Instead
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public bool InAnyGame
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public A(Regex P_0, Regex P_1, Func<Match, string> P_2, bool P_3 = false)
		{
			English = P_0;
			Arabic = P_1;
			Instead = P_2;
			InAnyGame = P_3;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rj());
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.o());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ps());
			P_0.Append((object)English);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pT());
			P_0.Append((object)Arabic);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RK());
			P_0.Append((object)Instead);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rk());
			P_0.Append(((object)InAnyGame).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(A? P_0, A? P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(A? P_0, A? P_1)
		{
			if ((object)P_0 != P_1)
			{
				return P_0?.Equals(P_1) ?? false;
			}
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Regex>.Default.GetHashCode(English)) * -1521134295 + EqualityComparer<Regex>.Default.GetHashCode(Arabic)) * -1521134295 + EqualityComparer<Func<Match, string>>.Default.GetHashCode(Instead)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(InAnyGame);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as A);
		}

		[CompilerGenerated]
		public bool Equals(A? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<Regex>.Default.Equals(English, other.English) && EqualityComparer<Regex>.Default.Equals(Arabic, other.Arabic) && EqualityComparer<Func<Match, string>>.Default.Equals(Instead, other.Instead))
				{
					return EqualityComparer<bool>.Default.Equals(InAnyGame, other.InAnyGame);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		public A A()
		{
			return new A(this);
		}

		[CompilerGenerated]
		private A(A P_0)
		{
			English = P_0.English;
			Arabic = P_0.Arabic;
			Instead = P_0.Instead;
			InAnyGame = P_0.InAnyGame;
		}

		[CompilerGenerated]
		public void A(out Regex P_0, out Regex P_1, out Func<Match, string> P_2, out bool P_3)
		{
			P_0 = English;
			P_1 = Arabic;
			P_2 = Instead;
			P_3 = InAnyGame;
		}
	}

	[CompilerGenerated]
	private static class a
	{
		public static Func<string, A, string> _003C0_003E__Replace;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B
	{
		public static readonly B _003C_003E9 = new B();

		public static Func<string, bool> _003C_003E9__11_0;

		internal bool A(string P_0)
		{
			return AHeavenlyFaith.IsMatch(P_0);
		}

		internal string A(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RL();
		}

		internal string a(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rl();
		}

		internal string B(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RM();
		}

		internal string b(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rm();
		}

		internal string C(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RN();
		}

		internal string c(Match P_0)
		{
			return NamesOnlyAllahBears.B(((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rn();
		}

		internal string D(Match P_0)
		{
			return NamesOnlyAllahBears.B(((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RO();
		}

		internal string d(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ro();
		}

		internal string E(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + (P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RP()].Success ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rp() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()) + ((((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RQ() || (P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RP()].Success && ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value.Length == 0 && !P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rq()].Success)) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RR() : (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ro() + ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value));
		}

		internal string e(Match P_0)
		{
			if (!P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RP()].Success)
			{
				if (!((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value.EndsWith('ل'))
				{
					return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rr();
				}
				string value = ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value;
				return value.Substring(0, value.Length - 1) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RS();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rs();
		}
	}

	public const int AtLeastLines = 2;

	private static readonly Regex AHeavenlyFaith = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cF(), (RegexOptions)9);

	private const string Before = "(?<![\\p{L}\\p{M}])";

	private const string After = "(?![\\p{L}\\p{M}])";

	private const string NotAfterAbd = "(?<!(?<![\\p{L}\\p{M}])[وفبلك]?عبد ?)";

	private static readonly Regex TheNameOfAllah = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cf(), (RegexOptions)8);

	private const string WithTheArticle = "(?<pre>[وف]?(?:[بك]?ال|لل))";

	private static readonly A[] Names = new A[10]
	{
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cG()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cg()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RL()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cH()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ch()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rl()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cI()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ci()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RM()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cJ()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cj()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rm()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cK()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ck()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RN()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cL()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cl()), (Match P_0) => B(((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rn()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cM()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cm()), (Match P_0) => B(((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RO()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cN()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cn()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ro()),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cN()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cO()), (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + (P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RP()].Success ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rp() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()) + ((((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RQ() || (P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RP()].Success && ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value.Length == 0 && !P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rq()].Success)) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RR() : (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ro() + ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value))),
		new A(A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.co()), a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cP()), delegate(Match P_0)
		{
			if (!P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RP()].Success)
			{
				if (!((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value.EndsWith('ل'))
				{
					return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rr();
				}
				string value = ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value;
				return value.Substring(0, value.Length - 1) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RS();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rs();
		}, true)
	};

	private static Regex A(string P_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Regex(P_0, (RegexOptions)9);
	}

	private static Regex a(string P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Regex(P_0, (RegexOptions)8);
	}

	public static bool SpeaksOfAHeavenlyFaith(System.Collections.Generic.IEnumerable<string> lines)
	{
		return Enumerable.Count<string>(Enumerable.Take<string>(Enumerable.Where<string>(lines, (Func<string, bool>)((string P_0) => AHeavenlyFaith.IsMatch(P_0))), 2)) >= 2;
	}

	public static string Mend(string source, string translation, bool? theGameSpeaksOfAHeavenlyFaith)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(translation) || StoryGods.SpeaksOfTheOneGod(source) || TheNameOfAllah.IsMatch(StoryGods.a(translation).Item1))
		{
			return translation;
		}
		bool flag = theGameSpeaksOfAHeavenlyFaith == false || StoryGods.NamesAStoryGod(source);
		A[] names = Names;
		foreach (A a in names)
		{
			if ((a.InAnyGame || flag) && a.English.IsMatch(source))
			{
				translation = A(translation, a);
			}
		}
		return translation;
	}

	public static string MendedAnywhere(string text)
	{
		return Enumerable.Aggregate<A, string>((System.Collections.Generic.IEnumerable<A>)Names, text, (Func<string, A, string>)A);
	}

	private static string A(string P_0, A P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		ValueTuple<string, int[]> val = StoryGods.a(P_0);
		string item = val.Item1;
		int[] item2 = val.Item2;
		MatchCollection val2 = P_1.Arabic.Matches(item);
		if (val2.Count == 0)
		{
			return P_0;
		}
		StringBuilder val3 = new StringBuilder(P_0.Length + 8);
		int num = 0;
		foreach (Match item3 in val2)
		{
			Match val4 = item3;
			int num2 = item2[((Capture)val4).Index];
			int num3 = ((((Capture)val4).Index + ((Capture)val4).Length < item2.Length) ? item2[((Capture)val4).Index + ((Capture)val4).Length] : P_0.Length);
			val3.Append(P_0, num, num2 - num);
			val3.Append(P_1.Instead.Invoke(val4));
			num = num3;
		}
		val3.Append(P_0, num, P_0.Length - num);
		return ((object)val3).ToString();
	}

	private static string B(string P_0)
	{
		string text;
		if (!P_0.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cE(), (StringComparison)4))
		{
			if (!P_0.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ce(), (StringComparison)4))
			{
				return P_0;
			}
			text = P_0;
			return text.Substring(0, text.Length - 2);
		}
		text = P_0;
		return text.Substring(0, text.Length - 1);
	}
}
