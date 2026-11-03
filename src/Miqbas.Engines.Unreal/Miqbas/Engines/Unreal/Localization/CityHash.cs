using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Localization;

public static class CityHash
{
	private readonly struct A : IEquatable<A>
	{
		[field: CompilerGenerated]
		public ulong First
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public ulong Second
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public A(ulong P_0, ulong P_1)
		{
			First = P_0;
			Second = P_1;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ha());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hB());
			P_0.Append(((object)First).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hb());
			P_0.Append(((object)Second).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(A P_0, A P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(A P_0, A P_1)
		{
			return P_0.Equals(P_1);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<ulong>.Default.GetHashCode(First) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(Second);
		}

		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			if (obj is A)
			{
				return Equals((A)obj);
			}
			return false;
		}

		[CompilerGenerated]
		public bool Equals(A other)
		{
			if (EqualityComparer<ulong>.Default.Equals(First, other.First))
			{
				return EqualityComparer<ulong>.Default.Equals(Second, other.Second);
			}
			return false;
		}

		[CompilerGenerated]
		public void A(out ulong P_0, out ulong P_1)
		{
			P_0 = First;
			P_1 = Second;
		}
	}

	private const ulong K0 = 14097894508562428199uL;

	private const ulong K1 = 13011662864482103923uL;

	private const ulong K2 = 11160318154034397263uL;

	public static ulong Of(global::System.ReadOnlySpan<byte> data)
	{
		int length = data.Length;
		if (length <= 32)
		{
			if (length > 16)
			{
				return D(data);
			}
			return c(data);
		}
		if (length <= 64)
		{
			return d(data);
		}
		ref global::System.ReadOnlySpan<byte> reference = ref data;
		int num = length - 40;
		ulong num2 = b(reference.Slice(num, reference.Length - num));
		reference = ref data;
		num = length - 16;
		ulong num3 = b(reference.Slice(num, reference.Length - num));
		reference = ref data;
		num = length - 56;
		ulong num4 = num3 + b(reference.Slice(num, reference.Length - num));
		reference = ref data;
		num = length - 48;
		long num5 = (long)b(reference.Slice(num, reference.Length - num)) + (long)length;
		reference = ref data;
		num = length - 24;
		ulong num6 = A((ulong)num5, b(reference.Slice(num, reference.Length - num)));
		reference = ref data;
		num = length - 64;
		A a = A(reference.Slice(num, reference.Length - num), (ulong)length, num6);
		reference = ref data;
		num = length - 32;
		A a2 = A(reference.Slice(num, reference.Length - num), num4 + 13011662864482103923uL, num2);
		num2 = (ulong)((long)num2 * -5435081209227447693L) + b(data);
		int num7 = 0;
		int num8 = (length - 1) & -64;
		do
		{
			reference = ref data;
			num = num7;
			global::System.ReadOnlySpan<byte> readOnlySpan = reference.Slice(num, reference.Length - num);
			ulong num9 = num2 + num4 + a.First;
			reference = ref readOnlySpan;
			num2 = A(num9 + b(reference.Slice(8, reference.Length - 8)), 37) * 13011662864482103923uL;
			ulong num10 = num4 + a.Second;
			reference = ref readOnlySpan;
			num4 = A(num10 + b(reference.Slice(48, reference.Length - 48)), 42) * 13011662864482103923uL;
			num2 ^= a2.Second;
			ulong num11 = num4;
			ulong first = a.First;
			reference = ref readOnlySpan;
			num4 = num11 + (first + b(reference.Slice(40, reference.Length - 40)));
			num6 = A(num6 + a2.First, 33) * 13011662864482103923uL;
			a = A(readOnlySpan, a.Second * 13011662864482103923uL, num2 + a2.First);
			reference = ref readOnlySpan;
			global::System.ReadOnlySpan<byte> readOnlySpan2 = reference.Slice(32, reference.Length - 32);
			ulong num12 = num6 + a2.Second;
			ulong num13 = num4;
			reference = ref readOnlySpan;
			a2 = A(readOnlySpan2, num12, num13 + b(reference.Slice(16, reference.Length - 16)));
			ulong num14 = num2;
			num2 = num6;
			num6 = num14;
			num7 += 64;
			num8 -= 64;
		}
		while (num8 != 0);
		return A((ulong)((long)A(a.First, a2.First) + (long)A(num4) * -5435081209227447693L) + num6, A(a.Second, a2.Second) + num2);
	}

	public static uint Of32(global::System.ReadOnlySpan<byte> data)
	{
		uint length = (uint)data.Length;
		switch (length)
		{
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
			return B(data);
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
			return a(data);
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
			return A(data);
		default:
		{
			uint num = length;
			uint num2 = 3432918353u * length;
			uint num3 = num2;
			ref global::System.ReadOnlySpan<byte> reference = ref data;
			int num4 = (int)(length - 4);
			uint num5 = A(C(reference.Slice(num4, reference.Length - num4)) * 3432918353u, 17) * 461845907;
			reference = ref data;
			num4 = (int)(length - 8);
			uint num6 = A(C(reference.Slice(num4, reference.Length - num4)) * 3432918353u, 17) * 461845907;
			reference = ref data;
			num4 = (int)(length - 16);
			uint num7 = A(C(reference.Slice(num4, reference.Length - num4)) * 3432918353u, 17) * 461845907;
			reference = ref data;
			num4 = (int)(length - 12);
			uint num8 = A(C(reference.Slice(num4, reference.Length - num4)) * 3432918353u, 17) * 461845907;
			reference = ref data;
			num4 = (int)(length - 20);
			uint num9 = A(C(reference.Slice(num4, reference.Length - num4)) * 3432918353u, 17) * 461845907;
			num ^= num5;
			num = A(num, 19) * 5 + 3864292196u;
			num ^= num7;
			num = A(num, 19) * 5 + 3864292196u;
			num2 ^= num6;
			num2 = A(num2, 19) * 5 + 3864292196u;
			num2 ^= num8;
			num2 = A(num2, 19) * 5 + 3864292196u;
			num3 += num9;
			num3 = A(num3, 19) * 5 + 3864292196u;
			uint num10 = (length - 1) / 20;
			int num11 = 0;
			do
			{
				reference = ref data;
				num4 = num11;
				global::System.ReadOnlySpan<byte> readOnlySpan = reference.Slice(num4, reference.Length - num4);
				uint num12 = A(C(readOnlySpan) * 3432918353u, 17) * 461845907;
				reference = ref readOnlySpan;
				uint num13 = C(reference.Slice(4, reference.Length - 4));
				reference = ref readOnlySpan;
				uint num14 = A(C(reference.Slice(8, reference.Length - 8)) * 3432918353u, 17) * 461845907;
				reference = ref readOnlySpan;
				uint num15 = A(C(reference.Slice(12, reference.Length - 12)) * 3432918353u, 17) * 461845907;
				reference = ref readOnlySpan;
				uint num16 = C(reference.Slice(16, reference.Length - 16));
				num ^= num12;
				num = A(num, 18) * 5 + 3864292196u;
				num3 += num13;
				num3 = A(num3, 19) * 3432918353u;
				num2 += num14;
				num2 = A(num2, 18) * 5 + 3864292196u;
				num ^= num15 + num13;
				num = A(num, 19) * 5 + 3864292196u;
				num2 ^= num16;
				num2 = BinaryPrimitives.ReverseEndianness(num2) * 5;
				num += num16 * 5;
				num = BinaryPrimitives.ReverseEndianness(num);
				num3 += num12;
				uint num17 = num;
				num = num3;
				num3 = num17;
				uint num18 = num2;
				num2 = num3;
				num3 = num18;
				num11 += 20;
			}
			while (--num10 != 0);
			num2 = A(num2, 11) * 3432918353u;
			num2 = A(num2, 17) * 3432918353u;
			num3 = A(num3, 11) * 3432918353u;
			num3 = A(num3, 17) * 3432918353u;
			num = A(num + num2, 19);
			num = num * 5 + 3864292196u;
			num = A(num, 17) * 3432918353u;
			num = A(num + num3, 19);
			num = num * 5 + 3864292196u;
			return A(num, 17) * 3432918353u;
		}
		}
	}

	private static uint A(uint P_0, int P_1)
	{
		if (P_1 != 0)
		{
			return (P_0 >> P_1) | (P_0 << 32 - P_1);
		}
		return P_0;
	}

	private static uint A(uint P_0)
	{
		P_0 ^= P_0 >> 16;
		P_0 *= 2246822507u;
		P_0 ^= P_0 >> 13;
		P_0 *= 3266489909u;
		P_0 ^= P_0 >> 16;
		return P_0;
	}

	private static uint A(uint P_0, uint P_1)
	{
		P_0 *= 3432918353u;
		P_0 = A(P_0, 17);
		P_0 *= 461845907;
		P_1 ^= P_0;
		P_1 = A(P_1, 19);
		return P_1 * 5 + 3864292196u;
	}

	private unsafe static uint A(global::System.ReadOnlySpan<byte> P_0)
	{
		uint num = 0u;
		uint num2 = 9u;
		global::System.ReadOnlySpan<byte> readOnlySpan = P_0;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			byte b = *(byte*)readOnlySpan[i];
			num = (uint)((int)num * -862048943 + (sbyte)b);
			num2 ^= num;
		}
		return A(A(num, A((uint)P_0.Length, num2)));
	}

	private static uint a(global::System.ReadOnlySpan<byte> P_0)
	{
		uint length = (uint)P_0.Length;
		uint num = length;
		uint num2 = length * 5;
		uint num3 = num2;
		num += C(P_0);
		uint num4 = num2;
		ref global::System.ReadOnlySpan<byte> reference = ref P_0;
		int num5 = (int)(length - 4);
		num2 = num4 + C(reference.Slice(num5, reference.Length - num5));
		reference = ref P_0;
		num5 = (int)((length >> 1) & 4);
		return A(A(9 + C(reference.Slice(num5, reference.Length - num5)), A(num2, A(num, num3))));
	}

	private static uint B(global::System.ReadOnlySpan<byte> P_0)
	{
		int length = P_0.Length;
		ref global::System.ReadOnlySpan<byte> reference = ref P_0;
		int num = (length >> 1) - 4;
		uint num2 = C(reference.Slice(num, reference.Length - num));
		reference = ref P_0;
		uint num3 = C(reference.Slice(4, reference.Length - 4));
		reference = ref P_0;
		num = length - 8;
		uint num4 = C(reference.Slice(num, reference.Length - num));
		reference = ref P_0;
		num = length >> 1;
		uint num5 = C(reference.Slice(num, reference.Length - num));
		uint num6 = C(P_0);
		reference = ref P_0;
		num = length - 4;
		return A(A(C(reference.Slice(num, reference.Length - num)), A(num6, A(num5, A(num4, A(num3, A(num2, (uint)length)))))));
	}

	private static ulong b(global::System.ReadOnlySpan<byte> P_0)
	{
		return BitConverter.ToUInt64(P_0);
	}

	private static uint C(global::System.ReadOnlySpan<byte> P_0)
	{
		return BitConverter.ToUInt32(P_0);
	}

	private static ulong A(ulong P_0, int P_1)
	{
		if (P_1 != 0)
		{
			return (P_0 >> P_1) | (P_0 << 64 - P_1);
		}
		return P_0;
	}

	private static ulong A(ulong P_0)
	{
		return P_0 ^ (P_0 >> 47);
	}

	private static ulong A(ulong P_0, ulong P_1, ulong P_2)
	{
		ulong num = (P_0 ^ P_1) * P_2;
		num ^= num >> 47;
		ulong num2 = (P_1 ^ num) * P_2;
		return (num2 ^ (num2 >> 47)) * P_2;
	}

	private static ulong A(ulong P_0, ulong P_1)
	{
		ulong num = (P_0 ^ P_1) * 11376068507788127593uL;
		num ^= num >> 47;
		long num2 = (long)(P_1 ^ num) * -7070675565921424023L;
		return (ulong)((num2 ^ (num2 >>> 47)) * -7070675565921424023L);
	}

	private unsafe static ulong c(global::System.ReadOnlySpan<byte> P_0)
	{
		int length = P_0.Length;
		if (length >= 8)
		{
			ulong num = (ulong)(-7286425919675154353L + (long)length * 2L);
			ulong num2 = CityHash.b(P_0) + 11160318154034397263uL;
			ref global::System.ReadOnlySpan<byte> reference = ref P_0;
			int num3 = length - 8;
			ulong num4 = CityHash.b(reference.Slice(num3, reference.Length - num3));
			ulong num5 = A(num4, 37) * num + num2;
			ulong num6 = (A(num2, 25) + num4) * num;
			return A(num5, num6, num);
		}
		if (length >= 4)
		{
			ulong num7 = (ulong)(-7286425919675154353L + (long)length * 2L);
			ulong num8 = C(P_0);
			long num9 = (long)length + (long)(num8 << 3);
			ref global::System.ReadOnlySpan<byte> reference = ref P_0;
			int num3 = length - 4;
			return A((ulong)num9, C(reference.Slice(num3, reference.Length - num3)), num7);
		}
		if (length > 0)
		{
			byte num10 = *(byte*)P_0[0];
			byte b = *(byte*)P_0[length >> 1];
			byte b2 = *(byte*)P_0[length - 1];
			int num11 = num10 + (b << 8);
			uint num12 = (uint)(length + (b2 << 2));
			return A((ulong)(((uint)num11 * -7286425919675154353L) ^ (num12 * -4348849565147123417L))) * 11160318154034397263uL;
		}
		return 11160318154034397263uL;
	}

	private static ulong D(global::System.ReadOnlySpan<byte> P_0)
	{
		int length = P_0.Length;
		ulong num = (ulong)(-7286425919675154353L + (long)length * 2L);
		ulong num2 = b(P_0) * 13011662864482103923uL;
		ref global::System.ReadOnlySpan<byte> reference = ref P_0;
		ulong num3 = b(reference.Slice(8, reference.Length - 8));
		reference = ref P_0;
		int num4 = length - 8;
		ulong num5 = b(reference.Slice(num4, reference.Length - num4)) * num;
		reference = ref P_0;
		num4 = length - 16;
		ulong num6 = b(reference.Slice(num4, reference.Length - num4)) * 11160318154034397263uL;
		return A(A(num2 + num3, 43) + A(num5, 30) + num6, num2 + A(num3 + 11160318154034397263uL, 18) + num5, num);
	}

	private static ulong d(global::System.ReadOnlySpan<byte> P_0)
	{
		int length = P_0.Length;
		ulong num = (ulong)(-7286425919675154353L + (long)length * 2L);
		ulong num2 = b(P_0) * 11160318154034397263uL;
		ref global::System.ReadOnlySpan<byte> reference = ref P_0;
		ulong num3 = b(reference.Slice(8, reference.Length - 8));
		reference = ref P_0;
		int num4 = length - 24;
		ulong num5 = b(reference.Slice(num4, reference.Length - num4));
		reference = ref P_0;
		num4 = length - 32;
		ulong num6 = b(reference.Slice(num4, reference.Length - num4));
		reference = ref P_0;
		long num7 = (long)b(reference.Slice(16, reference.Length - 16)) * -7286425919675154353L;
		reference = ref P_0;
		ulong num8 = b(reference.Slice(24, reference.Length - 24)) * 9;
		reference = ref P_0;
		num4 = length - 8;
		ulong num9 = b(reference.Slice(num4, reference.Length - num4));
		reference = ref P_0;
		num4 = length - 16;
		ulong num10 = b(reference.Slice(num4, reference.Length - num4)) * num;
		ulong num11 = A(num2 + num9, 43) + (A(num3, 30) + num5) * 9;
		ulong num12 = ((num2 + num9) ^ num6) + num8 + 1;
		ulong num13 = a((num11 + num12) * num) + num10;
		ulong num14 = A((ulong)num7 + num8, 42) + num5;
		ulong num15 = (a((num12 + num13) * num) + num9) * num;
		ulong num16 = (ulong)(num7 + (long)num8) + num5;
		num2 = a((num14 + num16) * num + num15) + num3;
		num3 = A((num16 + num2) * num + num6 + num10) * num;
		return num3 + num14;
	}

	private static ulong a(ulong P_0)
	{
		return BinaryPrimitives.ReverseEndianness(P_0);
	}

	private static A A(ulong P_0, ulong P_1, ulong P_2, ulong P_3, ulong P_4, ulong P_5)
	{
		P_4 += P_0;
		P_5 = A(P_5 + P_4 + P_3, 21);
		ulong num = P_4;
		P_4 += P_1;
		P_4 += P_2;
		P_5 += A(P_4, 44);
		return new A(P_4 + P_3, P_5 + num);
	}

	private static A A(global::System.ReadOnlySpan<byte> P_0, ulong P_1, ulong P_2)
	{
		ulong num = b(P_0);
		ref global::System.ReadOnlySpan<byte> reference = ref P_0;
		ulong num2 = b(reference.Slice(8, reference.Length - 8));
		reference = ref P_0;
		ulong num3 = b(reference.Slice(16, reference.Length - 16));
		reference = ref P_0;
		return A(num, num2, num3, b(reference.Slice(24, reference.Length - 24)), P_1, P_2);
	}
}
