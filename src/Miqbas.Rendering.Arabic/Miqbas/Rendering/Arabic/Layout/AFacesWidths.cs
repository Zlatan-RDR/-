using System;
using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007B78C53E54_002D85C4_002D4BB2_002DB75C_002D1FE345444E71_007D;

namespace Miqbas.Rendering.Arabic.Layout;

public sealed class AFacesWidths
{
	private readonly Dictionary<int, int> _glyphOf;

	private readonly int[] _advances;

	private readonly int _unitsPerEm;

	private AFacesWidths(Dictionary<int, int> P_0, int[] P_1, int P_2)
	{
		_glyphOf = P_0;
		_advances = P_1;
		_unitsPerEm = P_2;
	}

	public static AFacesWidths Read(byte[] face)
	{
		try
		{
			return A(face);
		}
		catch (IndexOutOfRangeException)
		{
			return null;
		}
		catch (ArgumentOutOfRangeException)
		{
			return null;
		}
	}

	public double Measure(string text, double size)
	{
		long num = 0L;
		for (int i = 0; i < text.Length; i++)
		{
			int num2 = text[i];
			if (char.IsHighSurrogate(text[i]) && i + 1 < text.Length && char.IsLowSurrogate(text[i + 1]))
			{
				num2 = char.ConvertToUtf32(text[i], text[i + 1]);
				i++;
			}
			num += A(num2);
		}
		return (double)num * size / (double)_unitsPerEm;
	}

	private int A(int P_0)
	{
		int num = default(int);
		if (!_glyphOf.TryGetValue(P_0, ref num))
		{
			return _advances[_advances.Length - 1];
		}
		if (num >= _advances.Length)
		{
			return _advances[_advances.Length - 1];
		}
		return _advances[num];
	}

	private static AFacesWidths A(byte[] P_0)
	{
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		int num5 = a(P_0, 4);
		for (int i = 0; i < num5; i++)
		{
			int num6 = 12 + i * 16;
			char c = (char)P_0[num6];
			global::System.ReadOnlySpan<char> readOnlySpan = new global::System.ReadOnlySpan<char>(ref c);
			char c2 = (char)P_0[num6 + 1];
			global::System.ReadOnlySpan<char> readOnlySpan2 = new global::System.ReadOnlySpan<char>(ref c2);
			char c3 = (char)P_0[num6 + 2];
			global::System.ReadOnlySpan<char> readOnlySpan3 = new global::System.ReadOnlySpan<char>(ref c3);
			char c4 = (char)P_0[num6 + 3];
			string text = string.Concat(readOnlySpan, readOnlySpan2, readOnlySpan3, new global::System.ReadOnlySpan<char>(ref c4));
			int num7 = (int)B(P_0, num6 + 8);
			if (!(text == _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.Y()))
			{
				if (!(text == _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.y()))
				{
					if (!(text == _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.Z()))
					{
						if (text == _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.z())
						{
							num4 = num7;
						}
					}
					else
					{
						num3 = num7;
					}
				}
				else
				{
					num2 = num7;
				}
			}
			else
			{
				num = num7;
			}
		}
		if (num < 0 || num2 < 0 || num3 < 0 || num4 < 0)
		{
			return null;
		}
		int num8 = a(P_0, num + 18);
		int num9 = a(P_0, num2 + 34);
		if (num8 == 0 || num9 == 0)
		{
			return null;
		}
		int[] array = new int[num9];
		for (int j = 0; j < num9; j++)
		{
			array[j] = a(P_0, num3 + j * 4);
		}
		Dictionary<int, int> val = A(P_0, num4);
		if (val != null)
		{
			return new AFacesWidths(val, array, num8);
		}
		return null;
	}

	private static Dictionary<int, int> A(byte[] P_0, int P_1)
	{
		int num = -1;
		int num2 = -1;
		int num3 = a(P_0, P_1 + 2);
		for (int i = 0; i < num3; i++)
		{
			int num4 = P_1 + 4 + i * 8;
			int num5 = a(P_0, num4);
			int num6 = a(P_0, num4 + 2);
			int num7 = P_1 + (int)B(P_0, num4 + 4);
			int num8 = a(P_0, num7);
			if (num8 == 12 && ((num5 == 3 && num6 == 10) || num5 == 0))
			{
				num2 = num7;
			}
			else if (num8 == 4 && ((num5 == 3 && num6 == 1) || num5 == 0) && num < 0)
			{
				num = num7;
			}
		}
		Dictionary<int, int> val = new Dictionary<int, int>();
		if (num2 >= 0)
		{
			int num9 = (int)B(P_0, num2 + 12);
			for (int j = 0; j < num9; j++)
			{
				int num10 = num2 + 16 + j * 12;
				int num11 = (int)B(P_0, num10);
				int num12 = (int)B(P_0, num10 + 4);
				int num13 = (int)B(P_0, num10 + 8);
				for (int k = num11; k <= num12 && k <= 1114111; k++)
				{
					val[k] = num13 + (k - num11);
				}
			}
			return val;
		}
		if (num < 0)
		{
			return null;
		}
		int num14 = a(P_0, num + 6) / 2;
		int num15 = num + 14;
		int num16 = num15 + num14 * 2 + 2;
		int num17 = num16 + num14 * 2;
		int num18 = num17 + num14 * 2;
		for (int l = 0; l < num14; l++)
		{
			int num19 = a(P_0, num15 + l * 2);
			int num20 = a(P_0, num16 + l * 2);
			short num21 = (short)a(P_0, num17 + l * 2);
			int num22 = num18 + l * 2;
			int num23 = a(P_0, num22);
			for (int m = num20; m <= num19 && m != 65535; m++)
			{
				int num24;
				if (num23 == 0)
				{
					num24 = (m + num21) & 0xFFFF;
				}
				else
				{
					int num25 = num22 + num23 + (m - num20) * 2;
					num24 = a(P_0, num25);
					if (num24 != 0)
					{
						num24 = (num24 + num21) & 0xFFFF;
					}
				}
				if (num24 != 0)
				{
					val[m] = num24;
				}
			}
		}
		return val;
	}

	private static int a(byte[] P_0, int P_1)
	{
		return (P_0[P_1] << 8) | P_0[P_1 + 1];
	}

	private static uint B(byte[] P_0, int P_1)
	{
		return (uint)((P_0[P_1] << 24) | (P_0[P_1 + 1] << 16) | (P_0[P_1 + 2] << 8) | P_0[P_1 + 3]);
	}
}
