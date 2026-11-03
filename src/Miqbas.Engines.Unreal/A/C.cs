using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace A;

internal static class C
{
	public static string A(BinaryReader P_0)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cn());
		int num = P_0.ReadInt32();
		if (num == 0)
		{
			return string.Empty;
		}
		bool num2 = num < 0;
		long num3 = (num2 ? (-num * 2) : num);
		long? num4 = a(P_0);
		if (num4.HasValue)
		{
			long valueOrDefault = num4.GetValueOrDefault();
			if (num3 > valueOrDefault)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(68, 2);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CO());
				defaultInterpolatedStringHandler.AppendFormatted<long>(num3);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Co());
				defaultInterpolatedStringHandler.AppendFormatted<long>(valueOrDefault);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CP());
				throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		if (!num2)
		{
			return A(P_0, (int)num3);
		}
		return a(P_0, (int)(num3 / 2));
	}

	private static long? a(BinaryReader P_0)
	{
		try
		{
			Stream baseStream = P_0.BaseStream;
			return baseStream.CanSeek ? new long?(baseStream.Length - baseStream.Position) : null;
		}
		catch (NotSupportedException)
		{
			return null;
		}
		catch (ObjectDisposedException)
		{
			return null;
		}
	}

	public static void A(BinaryWriter P_0, string P_1)
	{
		if (P_1.Length == 0)
		{
			P_0.Write(0);
		}
		else if (A(P_1))
		{
			P_0.Write(P_1.Length + 1);
			foreach (char c2 in P_1)
			{
				P_0.Write((byte)c2);
			}
			P_0.Write((byte)0);
		}
		else
		{
			P_0.Write(-(P_1.Length + 1));
			P_0.Write(Encoding.Unicode.GetBytes(P_1));
			P_0.Write((ushort)0);
		}
	}

	private static bool A(string P_0)
	{
		for (int l = 0; l < P_0.Length; l++)
		{
			if (P_0[l] > '\u007f')
			{
				return false;
			}
		}
		return true;
	}

	private static string A(BinaryReader P_0, int P_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = P_0.ReadBytes(P_1);
		if (array.Length != P_1)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cp());
		}
		int num = ((P_1 > 0 && array[P_1 - 1] == 0) ? (P_1 - 1) : P_1);
		return Encoding.Latin1.GetString(array, 0, num);
	}

	private static string a(BinaryReader P_0, int P_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = P_0.ReadBytes(P_1 * 2);
		if (array.Length != P_1 * 2)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cp());
		}
		string @string = Encoding.Unicode.GetString(array);
		if (@string.Length > 0)
		{
			if (@string[@string.Length - 1] == '\0')
			{
				string text = @string;
				return text.Substring(0, text.Length - 1);
			}
		}
		return @string;
	}
}
internal static class c
{
	public static bool A(string P_0)
	{
		foreach (char c2 in P_0)
		{
			bool flag;
			switch (c2)
			{
			case '\t':
			case '\n':
			case '\r':
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (!flag && (char.IsControl(c2) || char.IsSurrogate(c2) || c2 == '\ufffd'))
			{
				return false;
			}
		}
		return true;
	}
}
