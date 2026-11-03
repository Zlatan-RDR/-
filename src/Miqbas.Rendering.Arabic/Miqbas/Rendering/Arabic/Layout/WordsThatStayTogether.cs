using System;
using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007B78C53E54_002D85C4_002D4BB2_002DB75C_002D1FE345444E71_007D;

namespace Miqbas.Rendering.Arabic.Layout;

public static class WordsThatStayTogether
{
	private struct A
	{
		public int Start;

		public int Count;
	}

	private static readonly HashSet<string> Prepositions;

	public static bool HoldsTheNext(string word)
	{
		if (string.IsNullOrEmpty(word))
		{
			return false;
		}
		if (Prepositions.Contains(word) || (word.Length > 2 && (word[0] == 'و' || word[0] == 'ف') && Prepositions.Contains(word.Substring(1))))
		{
			return true;
		}
		return A(word);
	}

	public static List<string> Units(global::System.Collections.Generic.IList<string> words)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (words == null)
		{
			throw new ArgumentNullException(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ad());
		}
		List<string> val = new List<string>(((global::System.Collections.Generic.ICollection<string>)words).Count);
		Enumerator<A> enumerator = A(words).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				val.Add(A(words, current));
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	public static List<string> Break(global::System.Collections.Generic.IList<string> words, Func<global::System.Collections.Generic.IList<string>, List<string>> layOut, Func<string, bool> fitsALine)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (words == null)
		{
			throw new ArgumentNullException(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ad());
		}
		if (layOut == null)
		{
			throw new ArgumentNullException(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aE());
		}
		if (fitsALine == null)
		{
			throw new ArgumentNullException(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ae());
		}
		List<string> val = new List<string>(((global::System.Collections.Generic.ICollection<string>)words).Count);
		Enumerator<A> enumerator = A(words).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				string text = A(words, current);
				if (current.Count == 1 || fitsALine.Invoke(text))
				{
					val.Add(text);
					continue;
				}
				for (int i = current.Start; i < current.Start + current.Count; i++)
				{
					val.Add(words[i]);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		if (val.Count == ((global::System.Collections.Generic.ICollection<string>)words).Count)
		{
			return layOut.Invoke(words);
		}
		List<string> val2 = layOut.Invoke((global::System.Collections.Generic.IList<string>)val);
		List<string> val3 = layOut.Invoke(words);
		if (val2.Count > val3.Count)
		{
			return val3;
		}
		return val2;
	}

	private static List<A> A(global::System.Collections.Generic.IList<string> P_0)
	{
		List<A> val = new List<A>(((global::System.Collections.Generic.ICollection<string>)P_0).Count);
		int num = 0;
		for (int i = 0; i < ((global::System.Collections.Generic.ICollection<string>)P_0).Count; i++)
		{
			if (i >= ((global::System.Collections.Generic.ICollection<string>)P_0).Count - 1 || !HoldsTheNext(P_0[i]))
			{
				val.Add(new A
				{
					Start = num,
					Count = i - num + 1
				});
				num = i + 1;
			}
		}
		return val;
	}

	private static string A(global::System.Collections.Generic.IList<string> P_0, A P_1)
	{
		if (P_1.Count == 1)
		{
			return P_0[P_1.Start];
		}
		string[] array = new string[P_1.Count];
		for (int i = 0; i < P_1.Count; i++)
		{
			array[i] = P_0[P_1.Start + i];
		}
		return string.Join(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aB(), array);
	}

	private static bool A(string P_0)
	{
		int num = ((P_0[0] == '+' || P_0[0] == '-') ? 1 : 0);
		int num2 = P_0.Length;
		if (num2 > num && (P_0[num2 - 1] == '%' || P_0[num2 - 1] == '٪'))
		{
			num2--;
		}
		if (num2 <= num)
		{
			return false;
		}
		int num3 = 0;
		for (int i = num; i < num2; i++)
		{
			char c = P_0[i];
			if ((c >= '0' && c <= '9') || (c >= '٠' && c <= '٩') || (c >= '۰' && c <= '۹'))
			{
				num3++;
			}
			else if ((c != ',' && c != '.' && c != '٫' && c != '٬') || i == num || i == num2 - 1)
			{
				return false;
			}
		}
		return num3 > 0;
	}

	static WordsThatStayTogether()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aF());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.af());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aG());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ag());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aH());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ah());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aI());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ai());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aJ());
		Prepositions = obj;
	}
}
