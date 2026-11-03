using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace A;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class B : Regex
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
				if (runtextpos <= P_0.Length - 37)
				{
					int num = MemoryExtensions.IndexOf<char>(P_0.Slice(runtextpos), string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sq()));
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
				int num7 = 0;
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				if (!MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sq())))
				{
					A(0);
					return false;
				}
				runtextpos += 18;
				readOnlySpan = P_0.Slice(runtextpos);
				num6 = runtextpos;
				while (true)
				{
					num4 = ((RegexRunner)this).Crawlpos();
					if (!readOnlySpan.IsEmpty && *(ushort*)readOnlySpan[0] == 58)
					{
						int l;
						for (l = 1; (uint)l < (uint)readOnlySpan.Length && char.IsWhiteSpace(*(char*)readOnlySpan[l]); l++)
						{
						}
						readOnlySpan = readOnlySpan.Slice(l);
						runtextpos += l;
						num2 = runtextpos;
						int m;
						for (m = 0; (uint)m < (uint)readOnlySpan.Length && char.IsDigit(*(char*)readOnlySpan[m]); m++)
						{
						}
						if (m != 0)
						{
							readOnlySpan = readOnlySpan.Slice(m);
							runtextpos += m;
							((RegexRunner)this).Capture(1, num2, runtextpos);
							int n;
							for (n = 0; (uint)n < (uint)readOnlySpan.Length && char.IsWhiteSpace(*(char*)readOnlySpan[n]); n++)
							{
							}
							readOnlySpan = readOnlySpan.Slice(n);
							runtextpos += n;
							if (MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SR())))
							{
								runtextpos += 5;
								readOnlySpan = P_0.Slice(runtextpos);
								num7 = runtextpos;
								while (true)
								{
									num5 = ((RegexRunner)this).Crawlpos();
									if (!readOnlySpan.IsEmpty && *(ushort*)readOnlySpan[0] == 1608)
									{
										runtextpos++;
										readOnlySpan = P_0.Slice(runtextpos);
										num3 = runtextpos;
										int num8;
										for (num8 = 0; (uint)num8 < (uint)readOnlySpan.Length && char.IsDigit(*(char*)readOnlySpan[num8]); num8++)
										{
										}
										if (num8 != 0)
										{
											readOnlySpan = readOnlySpan.Slice(num8);
											runtextpos += num8;
											((RegexRunner)this).Capture(2, num3, runtextpos);
											int num9;
											for (num9 = 0; (uint)num9 < (uint)readOnlySpan.Length && char.IsWhiteSpace(*(char*)readOnlySpan[num9]); num9++)
											{
											}
											readOnlySpan = readOnlySpan.Slice(num9);
											runtextpos += num9;
											if (MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sr())))
											{
												((RegexRunner)this).Capture(0, num, base.runtextpos = runtextpos + 10);
												return true;
											}
										}
									}
									A(num5);
									if (f.s_hasTimeout)
									{
										((RegexRunner)this).CheckTimeout();
									}
									runtextpos = num7;
									readOnlySpan = P_0.Slice(runtextpos);
									if (readOnlySpan.IsEmpty || *(ushort*)readOnlySpan[0] == 10)
									{
										break;
									}
									runtextpos++;
									readOnlySpan = P_0.Slice(runtextpos);
									num7 = MemoryExtensions.IndexOfAny<char>(readOnlySpan, '\n', 'و');
									if ((uint)num7 >= (uint)readOnlySpan.Length || *(ushort*)readOnlySpan[num7] == 10)
									{
										break;
									}
									runtextpos += num7;
									readOnlySpan = P_0.Slice(runtextpos);
									num7 = runtextpos;
								}
							}
						}
					}
					A(num4);
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					runtextpos = num6;
					readOnlySpan = P_0.Slice(runtextpos);
					if (readOnlySpan.IsEmpty || *(ushort*)readOnlySpan[0] == 10)
					{
						A(0);
						return false;
					}
					runtextpos++;
					readOnlySpan = P_0.Slice(runtextpos);
					num6 = MemoryExtensions.IndexOfAny<char>(readOnlySpan, '\n', ':');
					if ((uint)num6 >= (uint)readOnlySpan.Length || *(ushort*)readOnlySpan[num6] == 10)
					{
						break;
					}
					runtextpos += num6;
					readOnlySpan = P_0.Slice(runtextpos);
					num6 = runtextpos;
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

	internal static readonly B Instance = new B();

	private B()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.d();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		Hashtable val = new Hashtable();
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a(), (object)0);
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.E(), (object)2);
		val.Add((object)EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.e(), (object)1);
		((Regex)this).CapNames = (IDictionary)val;
		base.capslist = new string[3]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.e(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.E()
		};
		base.capsize = 3;
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class b : Regex
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
				if ((uint)runtextpos < (uint)P_0.Length)
				{
					int num = P_0.Slice(runtextpos).a();
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
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				int num6 = num5;
				int num7 = runtextpos;
				readOnlySpan = P_0.Slice(runtextpos);
				int num8 = runtextpos;
				if (f.s_hasTimeout)
				{
					((RegexRunner)this).CheckTimeout();
				}
				if ((uint)(runtextpos - 1) < P_0.Length && char.IsAsciiLetter(*(char*)P_0[runtextpos - 1]))
				{
					runtextpos--;
					goto IL_0176;
				}
				runtextpos = num8;
				readOnlySpan = P_0.Slice(runtextpos);
				num4 = 0;
				while (true)
				{
					f.A(ref base.runstack, ref num5, runtextpos);
					num4++;
					if (!MemoryExtensions.StartsWith<char>(readOnlySpan, string.op_Implicit(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qb())))
					{
						break;
					}
					runtextpos += 2;
					readOnlySpan = P_0.Slice(runtextpos);
					if (num4 == 0)
					{
						continue;
					}
					goto IL_00d8;
				}
				goto IL_00b2;
				IL_00b2:
				if (--num4 >= 0)
				{
					runtextpos = base.runstack[--num5];
					readOnlySpan = P_0.Slice(runtextpos);
					goto IL_00d8;
				}
				goto IL_0176;
				IL_01ac:
				num5 = num6;
				base.runtextpos = runtextpos;
				((RegexRunner)this).Capture(0, num, runtextpos);
				return true;
				IL_0176:
				runtextpos = num7;
				readOnlySpan = P_0.Slice(runtextpos);
				if (readOnlySpan.IsEmpty || !char.IsDigit(*(char*)readOnlySpan[0]))
				{
					return false;
				}
				runtextpos++;
				readOnlySpan = P_0.Slice(runtextpos);
				goto IL_01ac;
				IL_00d8:
				num2 = runtextpos;
				int num9 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, f.s_asciiHexDigits);
				if (num9 < 0)
				{
					num9 = readOnlySpan.Length;
				}
				if (num9 < 2)
				{
					goto IL_00b2;
				}
				readOnlySpan = readOnlySpan.Slice(num9);
				runtextpos += num9;
				num3 = runtextpos;
				num2 += 2;
				int num10;
				while (true)
				{
					readOnlySpan = P_0.Slice(runtextpos);
					num10 = runtextpos;
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (readOnlySpan.IsEmpty || !char.IsAsciiLetter(*(char*)readOnlySpan[0]))
					{
						break;
					}
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (num2 < num3)
					{
						runtextpos = --num3;
						readOnlySpan = P_0.Slice(runtextpos);
						continue;
					}
					goto IL_00b2;
				}
				runtextpos = num10;
				readOnlySpan = P_0.Slice(runtextpos);
				goto IL_01ac;
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return (RegexRunner)(object)new A();
		}
	}

	internal static readonly b Instance = new b();

	private b()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.F();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
