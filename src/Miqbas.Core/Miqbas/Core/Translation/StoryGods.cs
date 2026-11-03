using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Translation;

public static class StoryGods
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<Match, string> _003C_003E9__5_0;

		internal string A(Match P_0)
		{
			return ((Capture)P_0).Value;
		}
	}

	private static readonly Regex AGodInTheSource = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ex(), (RegexOptions)9);

	private static readonly Regex TheOneGod = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eY(), (RegexOptions)9);

	private static readonly Regex TheNoun = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ey(), (RegexOptions)8);

	public static bool SpeaksOfTheOneGod(string source)
	{
		return TheOneGod.IsMatch(source);
	}

	public static bool NamesAStoryGod(string source)
	{
		if (AGodInTheSource.IsMatch(source))
		{
			return !TheOneGod.IsMatch(source);
		}
		return false;
	}

	public static System.Collections.Generic.IReadOnlyList<string> WrittenAsIlah(string translation)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		string item = a(translation).Item1;
		List<string> obj = new List<string>();
		obj.AddRange(Enumerable.Distinct<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)TheNoun.Matches(item), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal));
		return new k<string>(obj);
	}

	public static string Mend(string translation)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		ValueTuple<string, int[]> val = a(translation);
		string item = val.Item1;
		int[] item2 = val.Item2;
		MatchCollection val2 = TheNoun.Matches(item);
		if (val2.Count == 0)
		{
			return translation;
		}
		StringBuilder val3 = new StringBuilder(translation.Length + 8);
		int num = 0;
		foreach (Match item3 in val2)
		{
			Match val4 = item3;
			int num2 = item2[((Capture)val4).Index];
			int num3 = ((((Capture)val4).Index + ((Capture)val4).Length < item2.Length) ? item2[((Capture)val4).Index + ((Capture)val4).Length] : translation.Length);
			val3.Append(translation, num, num2 - num);
			val3.Append(((Capture)val4.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eS()]).Value).Append(A(((Capture)val4.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.es()]).Value)).Append(((Capture)val4.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eT()]).Value);
			num = num3;
		}
		val3.Append(translation, num, translation.Length - num);
		return ((object)val3).ToString();
	}

	private static string A(string P_0)
	{
		if (!(P_0 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.et()))
		{
			if (!(P_0 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eU()))
			{
				if (!(P_0 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eu()))
				{
					if (P_0 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eV())
					{
						return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ew();
					}
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eX();
				}
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eW();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eW();
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ev();
	}

	internal static ValueTuple<string, int[]> a(string P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder(P_0.Length);
		List<int> val2 = new List<int>(P_0.Length + 1);
		for (int i = 0; i < P_0.Length; i++)
		{
			char c = P_0[i];
			bool flag;
			switch (c)
			{
			case 'ـ':
			case '\u064b':
			case '\u064c':
			case '\u064d':
			case '\u064e':
			case '\u064f':
			case '\u0650':
			case '\u0651':
			case '\u0652':
			case '\u0653':
			case '\u0654':
			case '\u0655':
			case '\u0656':
			case '\u0657':
			case '\u0658':
			case '\u0659':
			case '\u065a':
			case '\u065b':
			case '\u065c':
			case '\u065d':
			case '\u065e':
			case '\u065f':
			case '\u0670':
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (!flag)
			{
				val.Append(c);
				val2.Add(i);
			}
		}
		val2.Add(P_0.Length);
		return new ValueTuple<string, int[]>(((object)val).ToString(), val2.ToArray());
	}
}
