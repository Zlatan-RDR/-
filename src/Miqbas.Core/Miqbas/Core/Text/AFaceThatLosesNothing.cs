using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class AFaceThatLosesNothing
{
	[CompilerGenerated]
	private sealed class A
	{
		public IDrawSomeCharacters replacement;

		internal bool A(int P_0)
		{
			return !replacement.Has(P_0);
		}
	}

	public static FaceCoverage Compare(string name, IDrawSomeCharacters original, IDrawSomeCharacters replacement, System.Collections.Generic.IReadOnlyCollection<int> wantedArabic)
	{
		IDrawSomeCharacters replacement2 = replacement;
		ArgumentNullException.ThrowIfNull((object)original, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GT());
		ArgumentNullException.ThrowIfNull((object)replacement2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gt());
		ArgumentNullException.ThrowIfNull((object)wantedArabic, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GU());
		List<int> val = new List<int>();
		System.Collections.Generic.IEnumerator<int> enumerator = ((System.Collections.Generic.IEnumerable<int>)original.Characters).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				int current = enumerator.Current;
				if (!replacement2.Has(current) && !A(original, current))
				{
					val.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		List<int> missingArabic = Enumerable.ToList<int>(Enumerable.Where<int>((System.Collections.Generic.IEnumerable<int>)wantedArabic, (Func<int, bool>)((int P_0) => !replacement2.Has(P_0))));
		return new FaceCoverage
		{
			Original = name,
			Lost = (System.Collections.Generic.IReadOnlyList<int>)val,
			MissingArabic = (System.Collections.Generic.IReadOnlyList<int>)missingArabic
		};
	}

	private static bool A(IDrawSomeCharacters P_0, int P_1)
	{
		if (P_0.OutlinesAreReadable)
		{
			return P_0.OutlineBytesOf(P_1) == 0;
		}
		return false;
	}

	public static ValueTuple<int, System.Collections.Generic.IReadOnlyList<FaceCoverage>> Widest(string name, IDrawSomeCharacters original, System.Collections.Generic.IReadOnlyList<ValueTuple<string, IDrawSomeCharacters>> replacements, System.Collections.Generic.IReadOnlyCollection<int> wantedArabic)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)replacements, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gu());
		List<FaceCoverage> val = new List<FaceCoverage>();
		for (int i = 0; i < ((System.Collections.Generic.IReadOnlyCollection<ValueTuple<string, IDrawSomeCharacters>>)replacements).Count; i++)
		{
			FaceCoverage faceCoverage = Compare(name, original, replacements[i].Item2, wantedArabic);
			if (faceCoverage.LosesNothing)
			{
				return new ValueTuple<int, System.Collections.Generic.IReadOnlyList<FaceCoverage>>(i, (System.Collections.Generic.IReadOnlyList<FaceCoverage>)val);
			}
			FaceCoverage faceCoverage2 = faceCoverage._003CClone_003E_0024();
			faceCoverage2.Original = name + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV() + replacements[i].Item1;
			val.Add(faceCoverage2);
		}
		return new ValueTuple<int, System.Collections.Generic.IReadOnlyList<FaceCoverage>>(-1, (System.Collections.Generic.IReadOnlyList<FaceCoverage>)val);
	}
}
