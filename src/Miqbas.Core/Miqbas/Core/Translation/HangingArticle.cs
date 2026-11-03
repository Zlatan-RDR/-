using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class HangingArticle
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static MatchEvaluator _003C_003E9__2_0;

		public static MatchEvaluator _003C_003E9__2_1;

		internal string A(Match P_0)
		{
			if (P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rh()].Success)
			{
				string value = ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rh()]).Value;
				if (!(value == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RI()))
				{
					return value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ri();
				}
				return value;
			}
			if (!P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gc()].Success)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
			}
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gc()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RJ();
		}

		internal string a(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rh()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ce();
		}
	}

	private static readonly Regex BeforeACode = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cf(), (RegexOptions)8);

	private static readonly Regex SplitFromItsWord = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CG(), (RegexOptions)8);

	public static string Mend(string masked)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		Regex beforeACode = BeforeACode;
		object obj = A._003C_003E9__2_0;
		if (obj == null)
		{
			MatchEvaluator val = delegate(Match P_0)
			{
				if (P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rh()].Success)
				{
					string value = ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rh()]).Value;
					if (!(value == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RI()))
					{
						return value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ri();
					}
					return value;
				}
				return (!P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gc()].Success) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y() : (((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gc()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RJ());
			};
			A._003C_003E9__2_0 = val;
			obj = (object)val;
		}
		string text = beforeACode.Replace(masked, (MatchEvaluator)obj);
		Regex splitFromItsWord = SplitFromItsWord;
		object obj2 = A._003C_003E9__2_1;
		if (obj2 == null)
		{
			MatchEvaluator val2 = (Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rh()]).Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ce();
			A._003C_003E9__2_1 = val2;
			obj2 = (object)val2;
		}
		return splitFromItsWord.Replace(text, (MatchEvaluator)obj2);
	}
}
