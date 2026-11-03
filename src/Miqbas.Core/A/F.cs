using System;
using System.Buffers;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace A;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class F : Regex
{
	private sealed class A : RegexRunnerFactory
	{
		private sealed class A : RegexRunner
		{
			protected override void Scan(System.ReadOnlySpan<char> inputSpan)
			{
				while (A(inputSpan) && !a(inputSpan) && base.runtextpos != inputSpan.Length)
				{
					base.runtextpos++;
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
				}
			}

			private bool A(System.ReadOnlySpan<char> P_0)
			{
				int runtextpos = base.runtextpos;
				if (runtextpos <= P_0.Length - 4)
				{
					int num = MemoryExtensions.IndexOfAny<char>(P_0.Slice(runtextpos), f.s_asciiLetters);
					if (num >= 0)
					{
						base.runtextpos = runtextpos + num;
						return true;
					}
				}
				base.runtextpos = P_0.Length;
				return false;
			}

			private unsafe bool a(System.ReadOnlySpan<char> P_0)
			{
				int num = base.runtextpos;
				int num2 = num;
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(num);
				if (!readOnlySpan.IsEmpty && char.IsAsciiLetterUpper(*(char*)readOnlySpan[0]))
				{
					readOnlySpan = readOnlySpan.Slice(1);
					num++;
				}
				int num3 = MemoryExtensions.IndexOfAnyExceptInRange<char>(readOnlySpan, 'a', 'z');
				if (num3 < 0)
				{
					num3 = readOnlySpan.Length;
				}
				if (num3 < 4)
				{
					return false;
				}
				readOnlySpan = readOnlySpan.Slice(num3);
				((RegexRunner)this).Capture(0, num2, base.runtextpos = num + num3);
				return true;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)(object)new A();
		}
	}

	internal static readonly F Instance = new F();

	private F()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.i();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal static class f
{
	internal static readonly TimeSpan s_defaultTimeout = ((AppContext.GetData(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.j()) is TimeSpan val) ? val : Regex.InfiniteMatchTimeout);

	internal static readonly bool s_hasTimeout = s_defaultTimeout != Regex.InfiniteMatchTimeout;

	internal static readonly SearchValues<char> s_asciiExceptWhiteSpace = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.K()));

	internal static readonly SearchValues<char> s_asciiHexDigits = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.k()));

	internal static readonly SearchValues<char> s_asciiLetters = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.L()));

	internal static readonly SearchValues<char> s_ascii_10400000104000 = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.l()));

	internal static readonly SearchValues<char> s_ascii_20FF03FEFFFF07FEFFFF07 = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.M()));

	internal static readonly SearchValues<char> s_ascii_20FF03FEFFFF87FEFFFF07 = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.m()));

	internal static readonly SearchValues<char> s_ascii_85000040000000000000000 = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.N()));

	internal static readonly SearchValues<char> s_ascii_FFFFFFFFFFFF00FC81FFFFFF81FFFFFF = SearchValues.Create(string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.n()));

	[MethodImpl(256)]
	internal unsafe static int A(this System.ReadOnlySpan<char> P_0)
	{
		int num = MemoryExtensions.IndexOfAnyExcept<char>(P_0, s_asciiExceptWhiteSpace);
		if ((uint)num < (uint)P_0.Length)
		{
			if (char.IsAscii(*(char*)P_0[num]))
			{
				return num;
			}
			do
			{
				if (char.IsWhiteSpace(*(char*)P_0[num]))
				{
					return num;
				}
				num++;
			}
			while ((uint)num < (uint)P_0.Length);
		}
		return -1;
	}

	[MethodImpl(256)]
	internal unsafe static int a(this System.ReadOnlySpan<char> P_0)
	{
		int num = MemoryExtensions.IndexOfAnyExcept<char>(P_0, s_ascii_FFFFFFFFFFFF00FC81FFFFFF81FFFFFF);
		if ((uint)num < (uint)P_0.Length)
		{
			if (char.IsAscii(*(char*)P_0[num]))
			{
				return num;
			}
			do
			{
				char c2;
				if (((c2 = *(char*)P_0[num]) < '\u0080') ? char.IsAsciiHexDigit(c2) : RegexRunner.CharInClass(c2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.J()))
				{
					return num;
				}
				num++;
			}
			while ((uint)num < (uint)P_0.Length);
		}
		return -1;
	}

	[MethodImpl(256)]
	internal unsafe static bool A(System.ReadOnlySpan<char> P_0, int P_1)
	{
		int num = P_1 - 1;
		return ((uint)num < (uint)P_0.Length && a(*(char*)P_0[num])) != ((uint)P_1 < (uint)P_0.Length && a(*(char*)P_0[P_1]));
	}

	[MethodImpl(256)]
	internal unsafe static bool A(char P_0)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		System.ReadOnlySpan<byte> readOnlySpan = (System.ReadOnlySpan<byte>)new byte[16]
		{
			0, 0, 0, 0, 0, 0, 255, 3, 254, 255,
			255, 135, 254, 255, 255, 7
		};
		int num = (int)P_0 >> 3;
		if ((uint)num >= (uint)readOnlySpan.Length)
		{
			return (0x4013F & (1 << (int)CharUnicodeInfo.GetUnicodeCategory(P_0))) != 0;
		}
		return (*(byte*)readOnlySpan[num] & (1 << (P_0 & 7))) != 0;
	}

	[MethodImpl(256)]
	internal static void A(int[] P_0, ref int P_1, out int P_2, out int P_3)
	{
		P_2 = P_0[--P_1];
		P_3 = P_0[--P_1];
	}

	[MethodImpl(256)]
	internal static void A(ref int[] P_0, ref int P_1, int P_2)
	{
		int[] array = P_0;
		int num = P_1;
		if ((uint)num < (uint)array.Length)
		{
			array[num] = P_2;
			P_1++;
		}
		else
		{
			a(ref P_0, ref P_1, P_2);
		}
	}

	[MethodImpl(256)]
	internal static void A(ref int[] P_0, ref int P_1, int P_2, int P_3)
	{
		int[] array = P_0;
		int num = P_1;
		if ((uint)(num + 1) < (uint)array.Length)
		{
			array[num] = P_2;
			array[num + 1] = P_3;
			P_1 += 2;
		}
		else
		{
			a(ref P_0, ref P_1, P_2, P_3);
		}
	}

	[MethodImpl(256)]
	internal static void A(ref int[] P_0, ref int P_1, int P_2, int P_3, int P_4)
	{
		int[] array = P_0;
		int num = P_1;
		if ((uint)(num + 2) < (uint)array.Length)
		{
			array[num] = P_2;
			array[num + 1] = P_3;
			array[num + 2] = P_4;
			P_1 += 3;
		}
		else
		{
			a(ref P_0, ref P_1, P_2, P_3, P_4);
		}
	}

	[CompilerGenerated]
	internal static bool a(char P_0)
	{
		if (!A(P_0))
		{
			return P_0 == '\u200c' || P_0 == '\u200d';
		}
		return true;
	}

	[MethodImpl(8)]
	[CompilerGenerated]
	internal static void a(ref int[] P_0, ref int P_1, int P_2)
	{
		System.Array.Resize<int>(ref P_0, P_1 * 2);
		A(ref P_0, ref P_1, P_2);
	}

	[MethodImpl(8)]
	[CompilerGenerated]
	internal static void a(ref int[] P_0, ref int P_1, int P_2, int P_3)
	{
		System.Array.Resize<int>(ref P_0, (P_1 + 1) * 2);
		A(ref P_0, ref P_1, P_2, P_3);
	}

	[MethodImpl(8)]
	[CompilerGenerated]
	internal static void a(ref int[] P_0, ref int P_1, int P_2, int P_3, int P_4)
	{
		System.Array.Resize<int>(ref P_0, (P_1 + 2) * 2);
		A(ref P_0, ref P_1, P_2, P_3, P_4);
	}
}
