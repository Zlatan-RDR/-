using System;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace A;

[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class D : Regex
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
					int num = P_0.Slice(runtextpos).A();
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
				int l;
				for (l = 0; (uint)l < (uint)readOnlySpan.Length && char.IsWhiteSpace(*(char*)readOnlySpan[l]); l++)
				{
				}
				if (l == 0)
				{
					return false;
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

	internal static readonly D Instance = new D();

	private D()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.g();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
internal sealed class d : Regex
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
					int num = MemoryExtensions.IndexOf<char>(P_0.Slice(runtextpos), '#');
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
				System.ReadOnlySpan<char> readOnlySpan = P_0.Slice(runtextpos);
				if (readOnlySpan.IsEmpty || *(ushort*)readOnlySpan[0] != 35)
				{
					return false;
				}
				int num5 = num4;
				int num6 = runtextpos;
				runtextpos++;
				readOnlySpan = P_0.Slice(runtextpos);
				num2 = runtextpos;
				int num7 = MemoryExtensions.IndexOfAnyExcept<char>(readOnlySpan, f.s_ascii_85000040000000000000000);
				if (num7 < 0)
				{
					num7 = readOnlySpan.Length;
				}
				readOnlySpan = readOnlySpan.Slice(num7);
				runtextpos += num7;
				num3 = runtextpos;
				while (true)
				{
					if (readOnlySpan.IsEmpty || *(ushort*)readOnlySpan[0] != 35)
					{
						if (f.s_hasTimeout)
						{
							((RegexRunner)this).CheckTimeout();
						}
						if (num2 < num3 && (num3 = MemoryExtensions.LastIndexOf<char>(P_0.Slice(num2, num3 - num2), '#')) >= 0)
						{
							num3 += num2;
							runtextpos = num3;
							readOnlySpan = P_0.Slice(runtextpos);
							continue;
						}
						runtextpos = num6;
						readOnlySpan = P_0.Slice(runtextpos);
						runtextpos++;
						readOnlySpan = P_0.Slice(runtextpos);
						break;
					}
					runtextpos++;
					readOnlySpan = P_0.Slice(runtextpos);
					break;
				}
				num4 = num5;
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

	internal static readonly d Instance = new d();

	private d()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		base.pattern = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.H();
		base.roptions = (RegexOptions)0;
		Regex.ValidateMatchTimeout(f.s_defaultTimeout);
		base.internalMatchTimeout = f.s_defaultTimeout;
		base.factory = (RegexRunnerFactory)(object)new A();
		base.capsize = 1;
	}
}
