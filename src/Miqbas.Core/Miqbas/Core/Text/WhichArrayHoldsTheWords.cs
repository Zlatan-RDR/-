using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class WhichArrayHoldsTheWords
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>, bool> _003C_003E9__1_0;

		public static Func<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>, ValueTuple<string, double, int>> _003C_003E9__1_1;

		public static Func<ValueTuple<string, double, int>, double> _003C_003E9__1_2;

		public static Func<ValueTuple<string, double, int>, string> _003C_003E9__1_3;

		public static Func<string, bool> _003C_003E9__2_0;

		public static Func<string, bool> _003C_003E9__2_1;

		internal bool A(KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>> P_0)
		{
			return ((System.Collections.Generic.IReadOnlyCollection<string>)P_0.Value).Count >= 30;
		}

		internal ValueTuple<string, double, int> a(KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>> P_0)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, double, int>(P_0.Key, WhichArrayHoldsTheWords.A(P_0.Value), ((System.Collections.Generic.IReadOnlyCollection<string>)P_0.Value).Count);
		}

		internal double A(ValueTuple<string, double, int> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item2;
		}

		internal string a(ValueTuple<string, double, int> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item1;
		}

		internal bool A(string P_0)
		{
			return P_0.Contains(' ', (StringComparison)4);
		}

		internal bool a(string P_0)
		{
			if (P_0.Length > 0)
			{
				return WhichArrayHoldsTheWords.A(P_0[P_0.Length - 1]);
			}
			return false;
		}
	}

	public const int TooFewToTell = 30;

	public static TheWordsArray LookAt(IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>> arrays)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)arrays, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iz());
		List<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>> val = Enumerable.ToList<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>>(Enumerable.Where<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>>)arrays, (Func<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>, bool>)((KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>> P_0) => ((System.Collections.Generic.IReadOnlyCollection<string>)P_0.Value).Count >= 30)));
		if (val.Count < 2)
		{
			return new TheWordsArray
			{
				InArabic = ((val.Count == 0) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ja() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JA())
			};
		}
		List<ValueTuple<string, double, int>> val2 = Enumerable.ToList<ValueTuple<string, double, int>>((System.Collections.Generic.IEnumerable<ValueTuple<string, double, int>>)Enumerable.OrderByDescending<ValueTuple<string, double, int>, double>(Enumerable.Select<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>, ValueTuple<string, double, int>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>>)val, (Func<KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>>, ValueTuple<string, double, int>>)((KeyValuePair<string, System.Collections.Generic.IReadOnlyList<string>> P_0) => new ValueTuple<string, double, int>(P_0.Key, A(P_0.Value), ((System.Collections.Generic.IReadOnlyCollection<string>)P_0.Value).Count))), (Func<ValueTuple<string, double, int>, double>)((ValueTuple<string, double, int> a) => a.Item2)));
		ValueTuple<string, double, int> val3 = val2[0];
		ValueTuple<string, double, int> val4 = val2[1];
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (val3.Item2 - val4.Item2 < 0.3)
		{
			TheWordsArray theWordsArray = new TheWordsArray();
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(44, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JB());
			defaultInterpolatedStringHandler.AppendFormatted<double>(val3.Item2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fg());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jb());
			defaultInterpolatedStringHandler.AppendFormatted<double>(val4.Item2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fg());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JC());
			theWordsArray.InArabic = defaultInterpolatedStringHandler.ToStringAndClear();
			return theWordsArray;
		}
		TheWordsArray obj = new TheWordsArray
		{
			Name = val3.Item1,
			LeftAlone = (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Select<ValueTuple<string, double, int>, string>(Enumerable.Skip<ValueTuple<string, double, int>>((System.Collections.Generic.IEnumerable<ValueTuple<string, double, int>>)val2, 1), (Func<ValueTuple<string, double, int>, string>)((ValueTuple<string, double, int> a) => a.Item1)))
		};
		defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(39, 4);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW());
		defaultInterpolatedStringHandler.AppendFormatted(val3.Item1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jc());
		defaultInterpolatedStringHandler.AppendFormatted<double>(val3.Item2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fg());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JD());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jd());
		defaultInterpolatedStringHandler.AppendFormatted(val4.Item1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JE());
		defaultInterpolatedStringHandler.AppendFormatted<double>(val4.Item2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fg());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EI());
		obj.InArabic = defaultInterpolatedStringHandler.ToStringAndClear();
		return obj;
	}

	private static double A(System.Collections.Generic.IReadOnlyList<string> P_0)
	{
		if (((System.Collections.Generic.IReadOnlyCollection<string>)P_0).Count == 0)
		{
			return 0.0;
		}
		int num = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)P_0, (Func<string, bool>)((string P_0) => P_0.Contains(' ', (StringComparison)4)));
		int num2 = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)P_0, (Func<string, bool>)((string P_0) => P_0.Length > 0 && A(P_0[P_0.Length - 1])));
		double num3 = 1.0 - (double)Enumerable.Count<string>(Enumerable.Distinct<string>((System.Collections.Generic.IEnumerable<string>)P_0, (IEqualityComparer<string>)(object)StringComparer.Ordinal)) / (double)((System.Collections.Generic.IReadOnlyCollection<string>)P_0).Count;
		return ((double)num / (double)((System.Collections.Generic.IReadOnlyCollection<string>)P_0).Count + (double)num2 / (double)((System.Collections.Generic.IReadOnlyCollection<string>)P_0).Count + num3) / 3.0;
	}

	private static bool A(char P_0)
	{
		switch (P_0)
		{
		case '!':
		case '.':
		case ':':
		case '?':
		case '،':
		case '؛':
		case '؟':
		case '…':
			return true;
		default:
			return false;
		}
	}
}
