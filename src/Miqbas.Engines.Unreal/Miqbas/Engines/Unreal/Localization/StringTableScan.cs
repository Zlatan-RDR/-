using System;
using System.Collections.Generic;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Localization;

public static class StringTableScan
{
	private const int LongestName = 200;

	private const int LongestLine = 16384;

	private const int MostLinesInATable = 100000;

	private const int FewestLinesWorthBelieving = 2;

	public static global::System.Collections.Generic.IReadOnlyList<CookedText> In(byte[] asset)
	{
		ArgumentNullException.ThrowIfNull((object)asset, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EN());
		if (asset.Length < 8)
		{
			return global::System.Array.Empty<CookedText>();
		}
		uint num = BitConverter.ToUInt32(asset, 4);
		if (num >= asset.Length)
		{
			return global::System.Array.Empty<CookedText>();
		}
		List<CookedText> val = new List<CookedText>();
		int num2 = Math.Max(0, (int)(num - 16));
		int num3 = Math.Min(asset.Length - 1, (int)(num + 128));
		for (int i = num2; i <= num3; i++)
		{
			List<CookedText> val2 = A(asset, i);
			if (val2.Count > val.Count)
			{
				val = val2;
			}
		}
		if (val.Count < 2)
		{
			return (global::System.Collections.Generic.IReadOnlyList<CookedText>)new List<CookedText>();
		}
		return (global::System.Collections.Generic.IReadOnlyList<CookedText>)val;
	}

	private static List<CookedText> A(byte[] P_0, int P_1)
	{
		List<CookedText> val = new List<CookedText>();
		if (!A(P_0, ref P_1, 1, 200, out string @namespace) || P_1 + 4 > P_0.Length)
		{
			return val;
		}
		int num = BitConverter.ToInt32(P_0, P_1);
		P_1 += 4;
		if ((num <= 0 || num > 100000) ? true : false)
		{
			return val;
		}
		for (int i = 0; i < num; i++)
		{
			if (!A(P_0, ref P_1, 1, 200, out string key))
			{
				break;
			}
			if (!A(P_0, ref P_1, 0, 16384, out string text))
			{
				break;
			}
			if (text.Length > 0)
			{
				val.Add(new CookedText(@namespace, key, text, 0u));
			}
		}
		return val;
	}

	private static bool A(byte[] P_0, ref int P_1, int P_2, int P_3, out string P_4)
	{
		P_4 = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa();
		if (P_1 + 4 > P_0.Length)
		{
			return false;
		}
		int num = BitConverter.ToInt32(P_0, P_1);
		P_1 += 4;
		if (num == 0)
		{
			return P_2 == 0;
		}
		if (num > 0)
		{
			if (num - 1 < P_2 || num - 1 > P_3 || P_1 + num > P_0.Length || P_0[P_1 + num - 1] != 0)
			{
				return false;
			}
			P_4 = Encoding.UTF8.GetString(P_0, P_1, num - 1);
			P_1 += num;
			return global::A.c.A(P_4);
		}
		int num2 = -num;
		int num3 = num2 * 2;
		if (num2 - 1 < P_2 || num2 - 1 > P_3 || P_1 + num3 > P_0.Length || P_0[P_1 + num3 - 2] != 0 || P_0[P_1 + num3 - 1] != 0)
		{
			return false;
		}
		P_4 = Encoding.Unicode.GetString(P_0, P_1, num3 - 2);
		P_1 += num3;
		return global::A.c.A(P_4);
	}
}
