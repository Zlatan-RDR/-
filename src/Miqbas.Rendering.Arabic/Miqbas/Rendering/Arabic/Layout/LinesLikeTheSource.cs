using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B78C53E54_002D85C4_002D4BB2_002DB75C_002D1FE345444E71_007D;

namespace Miqbas.Rendering.Arabic.Layout;

public static class LinesLikeTheSource
{
	public static string Follow(string source, string translated)
	{
		if (source == null || translated == null || translated.IndexOf('<') >= 0 || translated.IndexOf('[') >= 0)
		{
			return translated;
		}
		string[] array = source.Replace(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aA(), _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa()).Replace('\r', '\n').Split('\n', (StringSplitOptions)0);
		List<int> val = new List<int>();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			int num = A(array2[i]);
			if (num > 0)
			{
				val.Add(num);
			}
		}
		if (val.Count < 2)
		{
			return translated;
		}
		string[] array3 = translated.Replace(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aA(), _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa()).Replace('\r', '\n').Split('\n', (StringSplitOptions)0);
		int num2 = 0;
		array2 = array3;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i].Trim().Length > 0)
			{
				num2++;
			}
		}
		if (num2 >= val.Count)
		{
			return translated;
		}
		char[] array4 = new char[5];
		RuntimeHelpers.InitializeArray((global::System.Array)array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		string[] array5 = translated.Split(array4, (StringSplitOptions)1);
		if (array5.Length < val.Count)
		{
			return translated;
		}
		List<string> val2 = WordsThatStayTogether.Units(array5);
		List<string> val3 = A((val2.Count >= val.Count) ? val2.ToArray() : array5, val);
		List<string> val4 = new List<string>();
		int num3 = 0;
		array2 = array;
		foreach (string text in array2)
		{
			val4.Add((A(text) > 0) ? val3[num3++] : _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.c());
		}
		return string.Join(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa(), val4.ToArray());
	}

	private static List<string> A(string[] P_0, List<int> P_1)
	{
		int num = 0;
		foreach (string text in P_0)
		{
			num += text.Length + 1;
		}
		int num2 = Enumerable.Sum((global::System.Collections.Generic.IEnumerable<int>)P_1);
		List<string> val = new List<string>();
		int j = 0;
		int num3 = 0;
		int num4 = 0;
		for (int k = 0; k < P_1.Count; k++)
		{
			num4 += P_1[k];
			bool flag = k == P_1.Count - 1;
			double num5 = (double)num * (double)num4 / (double)num2;
			List<string> val2 = new List<string>();
			for (; j < P_0.Length; j++)
			{
				int num6 = P_0.Length - j;
				int num7 = P_1.Count - 1 - k;
				if (!flag && num6 <= num7)
				{
					break;
				}
				int num8 = P_0[j].Length + 1;
				if (!flag && val2.Count > 0 && (double)num3 + (double)num8 / 2.0 > num5)
				{
					break;
				}
				val2.Add(P_0[j]);
				num3 += num8;
			}
			val.Add(string.Join(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aB(), val2.ToArray()));
		}
		return val;
	}

	private static int A(string P_0)
	{
		int num = 0;
		for (int i = 0; i < P_0.Length; i++)
		{
			if (char.IsLetterOrDigit(P_0[i]))
			{
				num++;
			}
		}
		return num;
	}
}
