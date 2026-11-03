using System;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace A;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class C : Regex
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

			private unsafe bool A(System.ReadOnlySpan<char> P_0)
			{
				int runtextpos = base.runtextpos;
				if (runtextpos <= P_0.Length - 8)
				{
					System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
					int num;
					for (num = 0; num < readOnlySpan.Length - 7; num++)
					{
						int num2 = MemoryExtensions.IndexOfAny<char>(readOnlySpan.Slice(num), f.s_ascii_20FF03FEFFFF87FEFFFF07);
						if (num2 < 0)
						{
							break;
						}
						num += num2;
						if ((uint)(num + 2) >= (uint)readOnlySpan.Length)
						{
							break;
						}
						char c2;
						if ((c2 = *(char*)readOnlySpan[num + 1]) < '{' && (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SS()[(int)c2 >> 4] & (1 << (c2 & 0xF))) != 0 && (c2 = *(char*)readOnlySpan[num + 2]) < '{' && (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SS()[(int)c2 >> 4] & (1 << (c2 & 0xF))) != 0)
						{
							base.runtextpos = runtextpos + num;
							return true;
						}
					}
				}
				base.runtextpos = P_0.Length;
				return false;
			}

			private unsafe bool a(System.ReadOnlySpan<char> P_0)
			{
				int runtextpos = base.runtextpos;
				int num = runtextpos;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				if (!f.A(P_0, runtextpos))
				{
					return false;
				}
				int num9 = runtextpos;
				if (f.s_hasTimeout)
				{
					((RegexRunner)this).CheckTimeout();
				}
				int num10 = num8;
				num2 = runtextpos;
				int num11 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, f.s_ascii_20FF03FEFFFF87FEFFFF07);
				if (num11 < 0)
				{
					num11 = readOnlySpan.Length;
				}
				readOnlySpan = readOnlySpan.Slice(num11);
				runtextpos += num11;
				num3 = runtextpos;
				while (readOnlySpan.IsEmpty || !char.IsDigit(*(char*)readOnlySpan[0]))
				{
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (num2 >= num3)
					{
						return false;
					}
					runtextpos = --num3;
					readOnlySpan = P_0.Slice(runtextpos);
				}
				num8 = num10;
				runtextpos = num9;
				readOnlySpan = P_0.Slice(runtextpos);
				int num12 = runtextpos;
				if (f.s_hasTimeout)
				{
					((RegexRunner)this).CheckTimeout();
				}
				int num13 = num8;
				num4 = runtextpos;
				int num14 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, f.s_ascii_20FF03FEFFFF87FEFFFF07);
				if (num14 < 0)
				{
					num14 = readOnlySpan.Length;
				}
				readOnlySpan = readOnlySpan.Slice(num14);
				runtextpos += num14;
				num5 = runtextpos;
				while (readOnlySpan.IsEmpty || !char.IsAsciiLetter(*(char*)readOnlySpan[0]))
				{
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (num4 >= num5 || (num5 = MemoryExtensions.LastIndexOfAny<char>(P_0.Slice(num4, num5 - num4), f.s_asciiLetters)) < 0)
					{
						return false;
					}
					num5 += num4;
					runtextpos = num5;
					readOnlySpan = P_0.Slice(runtextpos);
				}
				num8 = num13;
				runtextpos = num12;
				readOnlySpan = P_0.Slice(runtextpos);
				num6 = runtextpos;
				int num15 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, f.s_ascii_20FF03FEFFFF87FEFFFF07);
				if (num15 < 0)
				{
					num15 = readOnlySpan.Length;
				}
				if (num15 < 8)
				{
					return false;
				}
				readOnlySpan = readOnlySpan.Slice(num15);
				runtextpos += num15;
				num7 = runtextpos;
				num6 += 8;
				while (!f.A(P_0, runtextpos))
				{
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (num6 >= num7)
					{
						return false;
					}
					runtextpos = --num7;
					readOnlySpan = P_0.Slice(runtextpos);
				}
				base.runtextpos = runtextpos;
				((RegexRunner)this).Capture(0, num, runtextpos);
				return true;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)(object)new A();
		}
	}

	internal static readonly C Instance = new C();

	private C()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.f();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class c : Regex
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

			private unsafe bool A(System.ReadOnlySpan<char> P_0)
			{
				int runtextpos = base.runtextpos;
				if (runtextpos <= P_0.Length - 10)
				{
					System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
					int num;
					for (num = 0; num < readOnlySpan.Length - 9; num++)
					{
						int num2 = MemoryExtensions.IndexOf<char>(readOnlySpan.Slice(num + 1), ':');
						if (num2 < 0)
						{
							break;
						}
						num += num2;
						if ((uint)(num + 2) >= (uint)readOnlySpan.Length)
						{
							break;
						}
						char c2;
						if (((c2 = *(char*)readOnlySpan[num + 2]) == '/' || c2 == '\\') && (((c2 = *(char*)readOnlySpan[num]) < '\u0080') ? char.IsAsciiLetter(c2) : RegexRunner.CharInClass(c2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ss())))
						{
							base.runtextpos = runtextpos + num;
							return true;
						}
					}
				}
				base.runtextpos = P_0.Length;
				return false;
			}

			private unsafe bool a(System.ReadOnlySpan<char> P_0)
			{
				int runtextpos = base.runtextpos;
				int num = runtextpos;
				int num2 = 0;
				int num3 = 0;
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				char c2;
				if ((uint)readOnlySpan.Length < 2u || (((c2 = *(char*)readOnlySpan[0]) < '\u0080') ? (!char.IsAsciiLetter(c2)) : (!RegexRunner.CharInClass(c2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ss()))) || *(ushort*)readOnlySpan[1] != 58)
				{
					return false;
				}
				int num4 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan.Slice(2), '/', '\\');
				if (num4 < 0)
				{
					num4 = readOnlySpan.Length - 2;
				}
				if (num4 == 0)
				{
					return false;
				}
				readOnlySpan = readOnlySpan.Slice(num4);
				runtextpos += num4;
				if ((uint)readOnlySpan.Length < 7u || !MemoryExtensions.StartsWith(readOnlySpan.Slice(2), string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ST()), (StringComparison)5))
				{
					return false;
				}
				runtextpos += 7;
				readOnlySpan = P_0.Slice(runtextpos);
				num2 = runtextpos;
				int num5 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, '/', '\\');
				if (num5 < 0)
				{
					num5 = readOnlySpan.Length;
				}
				if (num5 == 0)
				{
					return false;
				}
				readOnlySpan = readOnlySpan.Slice(num5);
				runtextpos += num5;
				num3 = runtextpos;
				num2++;
				int l;
				while (true)
				{
					for (l = 0; (uint)l < (uint)readOnlySpan.Length; l++)
					{
						if ((((c2 = *(char*)readOnlySpan[l]) < '\u0080') ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SU()[(int)c2 >> 4] & (1 << (c2 & 0xF))) : (RegexRunner.CharInClass(c2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.St()) ? 1 : 0)) == 0)
						{
							break;
						}
					}
					if (l != 0)
					{
						break;
					}
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (num2 >= num3)
					{
						return false;
					}
					runtextpos = --num3;
					readOnlySpan = P_0.Slice(runtextpos);
				}
				readOnlySpan = readOnlySpan.Slice(l);
				((RegexRunner)this).Capture(0, num, base.runtextpos = runtextpos + l);
				return true;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)(object)new A();
		}
	}

	internal static readonly c Instance = new c();

	private c()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.G();
		base.roptions = (RegexOptions)1;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
