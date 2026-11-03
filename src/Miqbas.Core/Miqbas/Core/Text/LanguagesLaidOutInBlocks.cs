using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class LanguagesLaidOutInBlocks
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ValueTuple<int, int>, int> _003C_003E9__0_0;

		internal int A(ValueTuple<int, int> r)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return r.Item2;
		}
	}

	public static TheSourceBlock LookAt(System.Collections.Generic.IReadOnlyList<string> strings)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)strings, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ht());
		TheSourceBlock result = new TheSourceBlock
		{
			Found = false,
			Languages = 0,
			BlockSize = 0,
			TakeFirst = ((System.Collections.Generic.IReadOnlyCollection<string>)strings).Count
		};
		if (((System.Collections.Generic.IReadOnlyCollection<string>)strings).Count < 30)
		{
			return result;
		}
		Dictionary<string, ValueTuple<int, int>> val = new Dictionary<string, ValueTuple<int, int>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		int num = 0;
		int num2 = 0;
		string[] array = new string[2]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HZ(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hz()
		};
		foreach (string text in array)
		{
			List<int> val2 = new List<int>();
			for (int j = 0; j < ((System.Collections.Generic.IReadOnlyCollection<string>)strings).Count; j++)
			{
				if (A(strings[j]) == text)
				{
					val2.Add(j);
				}
			}
			if (val2.Count < 3)
			{
				continue;
			}
			int num3 = val2[0];
			int num4 = 1;
			int num5 = val2[0];
			int num6 = 1;
			for (int k = 1; k < val2.Count; k++)
			{
				num2++;
				if (val2[k] - val2[k - 1] == 1)
				{
					num++;
					num6++;
				}
				else
				{
					num5 = val2[k];
					num6 = 1;
				}
				if (num6 > num4)
				{
					num4 = num6;
					num3 = num5;
				}
			}
			val[text] = new ValueTuple<int, int>(num3, num4);
		}
		if (val.Count == 0 || num2 == 0 || (double)num / (double)num2 < 0.9)
		{
			return result;
		}
		int num7 = Enumerable.Max<ValueTuple<int, int>>((System.Collections.Generic.IEnumerable<ValueTuple<int, int>>)val.Values, (Func<ValueTuple<int, int>, int>)((ValueTuple<int, int> r) => r.Item2));
		if (num7 < 3)
		{
			return result;
		}
		int num8 = (int)Math.Round((double)((System.Collections.Generic.IReadOnlyCollection<string>)strings).Count / (double)num7);
		if (num8 < 3)
		{
			return result;
		}
		double num9 = (double)((System.Collections.Generic.IReadOnlyCollection<string>)strings).Count / (double)num8;
		int num10 = (int)Math.Ceiling(num9);
		Enumerator<string, ValueTuple<int, int>> enumerator = val.Values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				double num11 = (double)enumerator.Current.Item1 / num9;
				if (Math.Abs(num11 - Math.Round(num11)) > 0.2)
				{
					return result;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return new TheSourceBlock
		{
			Found = true,
			Languages = num8,
			BlockSize = num10,
			TakeFirst = Math.Min(num10, ((System.Collections.Generic.IReadOnlyCollection<string>)strings).Count)
		};
	}

	private static string? A(string P_0)
	{
		foreach (int num in P_0)
		{
			if (num >= 1024 && num <= 1327)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HZ();
			}
			if (num >= 44032 && num <= 55215)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hz();
			}
		}
		return null;
	}
}
