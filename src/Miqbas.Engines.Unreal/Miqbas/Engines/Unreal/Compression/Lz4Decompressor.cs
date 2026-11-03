using System;
using System.IO;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Compression;

public sealed class Lz4Decompressor : IPakDecompressor
{
	public const string MethodName = "LZ4";

	public bool Supports(string method)
	{
		return method.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hm(), (StringComparison)5);
	}

	public unsafe int Decompress(string method, global::System.ReadOnlySpan<byte> compressed, global::System.Span<byte> destination)
	{
		int num = 0;
		int num2 = 0;
		while (num < compressed.Length)
		{
			byte b = *(byte*)compressed[num++];
			int num3 = b >> 4;
			if (num3 == 15 && !A(compressed, ref num, ref num3))
			{
				throw A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hN());
			}
			if (num3 > 0)
			{
				if (num + num3 > compressed.Length || num2 + num3 > destination.Length)
				{
					throw A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hn());
				}
				global::System.ReadOnlySpan<byte> readOnlySpan = compressed.Slice(num, num3);
				int num4 = num2;
				readOnlySpan.CopyTo(destination.Slice(num4, destination.Length - num4));
				num += num3;
				num2 += num3;
			}
			if (num == compressed.Length)
			{
				break;
			}
			if (num + 2 > compressed.Length)
			{
				throw A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hO());
			}
			int num5 = *(byte*)compressed[num] | (*(byte*)compressed[num + 1] << 8);
			num += 2;
			if (num5 == 0 || num5 > num2)
			{
				throw A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hO());
			}
			int num6 = (b & 0xF) + 4;
			int num7 = b & 0xF;
			if (num7 == 15)
			{
				num7 = 15;
				if (!A(compressed, ref num, ref num7))
				{
					throw A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ho());
				}
				num6 = num7 + 4;
			}
			if (num2 + num6 > destination.Length)
			{
				throw A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hP());
			}
			int num8 = num2 - num5;
			for (int i = 0; i < num6; i++)
			{
				destination[num2 + i] = destination[num8 + i];
			}
			num2 += num6;
		}
		return num2;
	}

	private unsafe static bool A(global::System.ReadOnlySpan<byte> P_0, ref int P_1, ref int P_2)
	{
		do
		{
			if (P_1 >= P_0.Length)
			{
				return false;
			}
			byte b = *(byte*)P_0[P_1++];
			P_2 += b;
			if (b != 255)
			{
				return true;
			}
		}
		while (P_2 <= 67108864);
		return false;
	}

	private static InvalidDataException A(string P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		return new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hp() + P_0 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
	}
}
