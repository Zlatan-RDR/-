using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace A;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class A : Regex
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
				if (runtextpos <= P_0.Length - 48)
				{
					System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
					int num;
					for (num = 0; num < readOnlySpan.Length - 47; num++)
					{
						int num2 = MemoryExtensions.IndexOfAny<char>(readOnlySpan.Slice(num + 8), f.s_ascii_10400000104000);
						if (num2 < 0)
						{
							break;
						}
						num += num2;
						ulong num3;
						if ((long)((ulong)(-9079256846597881856L << (int)(num3 = (uint)(*(ushort*)readOnlySpan[num + 2] - 67))) & (num3 - 64)) < 0L && (long)((ulong)(-9079256846597881856L << (int)(num3 = (uint)(*(ushort*)readOnlySpan[num + 3] - 67))) & (num3 - 64)) < 0L)
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
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				if (readOnlySpan.IsEmpty)
				{
					A(0);
					return false;
				}
				switch ((char)(*(ushort*)readOnlySpan[0]))
				{
				case 'U':
				case 'u':
				{
					if ((uint)readOnlySpan.Length < 16u || !MemoryExtensions.StartsWith(readOnlySpan.Slice(1), string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SN()), (StringComparison)5))
					{
						A(0);
						return false;
					}
					runtextpos += 16;
					readOnlySpan = P_0.Slice(runtextpos);
					num2 = runtextpos;
					int m;
					for (m = 0; m < 5 && (uint)m < (uint)readOnlySpan.Length && char.IsAsciiHexDigit(*(char*)readOnlySpan[m]); m++)
					{
					}
					if (m < 4)
					{
						A(0);
						return false;
					}
					readOnlySpan = readOnlySpan.Slice(m);
					runtextpos += m;
					((RegexRunner)this).Capture(1, num2, runtextpos);
					break;
				}
				case 'A':
				case 'a':
				{
					if ((uint)readOnlySpan.Length < 15u || !MemoryExtensions.StartsWith(readOnlySpan.Slice(1), string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sn()), (StringComparison)5))
					{
						A(0);
						return false;
					}
					runtextpos += 15;
					readOnlySpan = P_0.Slice(runtextpos);
					num3 = runtextpos;
					int l;
					for (l = 0; l < 6 && (uint)l < (uint)readOnlySpan.Length && char.IsDigit(*(char*)readOnlySpan[l]); l++)
					{
					}
					if (l == 0)
					{
						A(0);
						return false;
					}
					readOnlySpan = readOnlySpan.Slice(l);
					runtextpos += l;
					((RegexRunner)this).Capture(2, num3, runtextpos);
					break;
				}
				default:
					A(0);
					return false;
				}
				int n;
				for (n = 0; (uint)n < (uint)readOnlySpan.Length && char.IsWhiteSpace(*(char*)readOnlySpan[n]); n++)
				{
				}
				if (n == 0)
				{
					A(0);
					return false;
				}
				readOnlySpan = readOnlySpan.Slice(n);
				runtextpos += n;
				if ((uint)readOnlySpan.Length < 21u || !MemoryExtensions.StartsWith(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SO()), (StringComparison)5))
				{
					A(0);
					return false;
				}
				if ((uint)readOnlySpan.Length < 22u)
				{
					A(0);
					return false;
				}
				switch ((char)(*(ushort*)readOnlySpan[21]))
				{
				case '[':
				{
					runtextpos += 22;
					readOnlySpan = P_0.Slice(runtextpos);
					num4 = runtextpos;
					int num5 = MemoryExtensions.IndexOfAny<char>(readOnlySpan, '\n', '\r', ']');
					if (num5 < 0)
					{
						num5 = readOnlySpan.Length;
					}
					readOnlySpan = readOnlySpan.Slice(num5);
					runtextpos += num5;
					((RegexRunner)this).Capture(3, num4, runtextpos);
					if ((uint)readOnlySpan.Length < 12u || !MemoryExtensions.StartsWith(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.So()), (StringComparison)5))
					{
						A(0);
						return false;
					}
					runtextpos += 12;
					readOnlySpan = P_0.Slice(runtextpos);
					break;
				}
				case 'F':
				case 'f':
					if ((uint)readOnlySpan.Length < 31u || !MemoryExtensions.StartsWith(readOnlySpan.Slice(22), string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SP()), (StringComparison)5))
					{
						A(0);
						return false;
					}
					runtextpos += 31;
					readOnlySpan = P_0.Slice(runtextpos);
					break;
				default:
					A(0);
					return false;
				}
				base.runtextpos = runtextpos;
				((RegexRunner)this).Capture(0, num, runtextpos);
				return true;
			}

			[MethodImpl(256)]
			[CompilerGenerated]
			private void A(int P_0)
			{
				while (((RegexRunner)this).Crawlpos() > P_0)
				{
					((RegexRunner)this).Uncapture();
				}
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)(object)new A();
		}
	}

	internal static readonly global::A.A Instance = new global::A.A();

	private A()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.A();
		base.roptions = (RegexOptions)1;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		Hashtable val = new Hashtable();
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a(), (object)0);
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.B(), (object)2);
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.b(), (object)3);
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.C(), (object)1);
		((Regex)this).CapNames = (IDictionary)val;
		base.capslist = new string[4]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.C(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.B(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.b()
		};
		base.capsize = 4;
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class a : Regex
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
				if (runtextpos <= P_0.Length - 31)
				{
					int num = MemoryExtensions.IndexOf<char>(P_0.Slice(runtextpos), string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sp()));
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
				int runtextpos = base.runtextpos;
				int num = runtextpos;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				if (!MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sp())))
				{
					A(0);
					return false;
				}
				runtextpos += 13;
				readOnlySpan = P_0.Slice(runtextpos);
				num5 = runtextpos;
				while (true)
				{
					num3 = ((RegexRunner)this).Crawlpos();
					char c2;
					if (MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SQ())))
					{
						runtextpos += 9;
						readOnlySpan = P_0.Slice(runtextpos);
						num2 = runtextpos;
						num6 = runtextpos;
						while (true)
						{
							num4 = ((RegexRunner)this).Crawlpos();
							((RegexRunner)this).Capture(1, num2, runtextpos);
							if (!MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SQ())))
							{
								A(num4);
								if (f.s_hasTimeout)
								{
									((RegexRunner)this).CheckTimeout();
								}
								runtextpos = num6;
								readOnlySpan = P_0.Slice(runtextpos);
								if (readOnlySpan.IsEmpty || (c2 = *(char*)readOnlySpan[0]) == '\n' || c2 == '\r')
								{
									break;
								}
								runtextpos++;
								readOnlySpan = P_0.Slice(runtextpos);
								num6 = runtextpos;
								continue;
							}
							((RegexRunner)this).Capture(0, num, base.runtextpos = runtextpos + 9);
							return true;
						}
					}
					A(num3);
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					runtextpos = num5;
					readOnlySpan = P_0.Slice(runtextpos);
					if (readOnlySpan.IsEmpty || (c2 = *(char*)readOnlySpan[0]) == '\n' || c2 == '\r')
					{
						break;
					}
					runtextpos++;
					readOnlySpan = P_0.Slice(runtextpos);
					num5 = runtextpos;
				}
				A(0);
				return false;
			}

			[MethodImpl(256)]
			[CompilerGenerated]
			private void A(int P_0)
			{
				while (((RegexRunner)this).Crawlpos() > P_0)
				{
					((RegexRunner)this).Uncapture();
				}
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)(object)new A();
		}
	}

	internal static readonly a Instance = new a();

	private a()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.c();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		Hashtable val = new Hashtable();
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a(), (object)0);
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.D(), (object)1);
		((Regex)this).CapNames = (IDictionary)val;
		base.capslist = new string[2]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.D()
		};
		base.capsize = 2;
	}
}
