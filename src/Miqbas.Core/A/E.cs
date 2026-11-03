using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace A;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class E : Regex
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
				if (runtextpos <= P_0.Length - 2)
				{
					int num = MemoryExtensions.IndexOfAny<char>(P_0.Slice(runtextpos), '<', '{');
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
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				if (readOnlySpan.IsEmpty)
				{
					return false;
				}
				switch ((char)(*(ushort*)readOnlySpan[0]))
				{
				case '<':
				{
					int num3 = MemoryExtensions.IndexOfAny<char>(readOnlySpan.Slice(1), '<', '>');
					if (num3 < 0)
					{
						num3 = readOnlySpan.Length - 1;
					}
					readOnlySpan = readOnlySpan.Slice(num3);
					runtextpos += num3;
					if ((uint)readOnlySpan.Length < 2u || *(ushort*)readOnlySpan[1] != 62)
					{
						return false;
					}
					runtextpos += 2;
					readOnlySpan = P_0.Slice(runtextpos);
					break;
				}
				case '{':
				{
					int num2 = MemoryExtensions.IndexOfAny<char>(readOnlySpan.Slice(1), '{', '}');
					if (num2 < 0)
					{
						num2 = readOnlySpan.Length - 1;
					}
					readOnlySpan = readOnlySpan.Slice(num2);
					runtextpos += num2;
					if ((uint)readOnlySpan.Length < 2u || *(ushort*)readOnlySpan[1] != 125)
					{
						return false;
					}
					runtextpos += 2;
					readOnlySpan = P_0.Slice(runtextpos);
					break;
				}
				default:
					return false;
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

	internal static readonly E Instance = new E();

	private E()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.h();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class e : Regex
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
				if (runtextpos <= P_0.Length - 3)
				{
					int num = MemoryExtensions.IndexOf<char>(P_0.Slice(runtextpos), '<');
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
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(num);
				if (readOnlySpan.IsEmpty || *(ushort*)readOnlySpan[0] != 60)
				{
					A(0);
					return false;
				}
				if ((uint)readOnlySpan.Length > 1u && *(ushort*)readOnlySpan[1] == 47)
				{
					readOnlySpan = readOnlySpan.Slice(1);
					num++;
				}
				if ((uint)readOnlySpan.Length < 2u || !char.IsAsciiLetter(*(char*)readOnlySpan[1]))
				{
					A(0);
					return false;
				}
				num += 2;
				readOnlySpan = P_0.Slice(num);
				num4 = num;
				int num10 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, f.s_ascii_20FF03FEFFFF07FEFFFF07);
				if (num10 < 0)
				{
					num10 = readOnlySpan.Length;
				}
				readOnlySpan = readOnlySpan.Slice(num10);
				num += num10;
				num5 = num;
				while (true)
				{
					num3 = ((RegexRunner)this).Crawlpos();
					num8 = 0;
					while (true)
					{
						f.A(ref base.runstack, ref num9, ((RegexRunner)this).Crawlpos(), num);
						num8++;
						int num11 = num;
						if (!readOnlySpan.IsEmpty && *(ushort*)readOnlySpan[0] == 61)
						{
							num++;
							readOnlySpan = P_0.Slice(num);
							num6 = num;
							int num12 = MemoryExtensions.IndexOfAny<char>(readOnlySpan, '<', '>');
							if (num12 < 0)
							{
								num12 = readOnlySpan.Length;
							}
							readOnlySpan = readOnlySpan.Slice(num12);
							num += num12;
							num7 = num;
							goto IL_01d0;
						}
						goto IL_0220;
						IL_01d0:
						f.A(ref base.runstack, ref num9, num6, num7, ((RegexRunner)this).Crawlpos());
						((RegexRunner)this).Capture(1, num11, num);
						f.A(ref base.runstack, ref num9, num11);
						if (num8 == 0)
						{
							continue;
						}
						goto IL_0272;
						IL_0220:
						if (--num8 < 0)
						{
							break;
						}
						num = base.runstack[--num9];
						A(base.runstack[--num9]);
						readOnlySpan = P_0.Slice(num);
						goto IL_0272;
						IL_0272:
						if (readOnlySpan.IsEmpty || *(ushort*)readOnlySpan[0] != 62)
						{
							if (f.s_hasTimeout)
							{
								((RegexRunner)this).CheckTimeout();
							}
							if (num8 != 0)
							{
								num11 = base.runstack[--num9];
								A(base.runstack[--num9]);
								f.A(base.runstack, ref num9, out num7, out num6);
								if (f.s_hasTimeout)
								{
									((RegexRunner)this).CheckTimeout();
								}
								if (num6 < num7)
								{
									num = --num7;
									readOnlySpan = P_0.Slice(num);
									goto IL_01d0;
								}
								goto IL_0220;
							}
							break;
						}
						((RegexRunner)this).Capture(0, num2, base.runtextpos = num + 1);
						return true;
					}
					A(num3);
					if (f.s_hasTimeout)
					{
						((RegexRunner)this).CheckTimeout();
					}
					if (num4 >= num5)
					{
						break;
					}
					num = --num5;
					readOnlySpan = P_0.Slice(num);
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

	internal static readonly e Instance = new e();

	private e()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.I();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 2;
	}
}
