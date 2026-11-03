using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Localization;

public static class CookedTextScan
{
	[CompilerGenerated]
	private sealed class A : global::System.Collections.Generic.IEnumerable<CookedText>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<CookedText>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private CookedText _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private byte[] bytes;

		public byte[] _003C_003E3__bytes;

		private int _003Cposition_003E5__2;

		CookedText global::System.Collections.Generic.IEnumerator<CookedText>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public A(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			int num2;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				num2 = _003Cposition_003E5__2 - 1;
				goto IL_008d;
			}
			_003C_003E1__state = -1;
			ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
			num2 = 0;
			goto IL_0091;
			IL_008d:
			num2++;
			goto IL_0091;
			IL_0091:
			if (num2 + 6 < bytes.Length)
			{
				if (CookedTextScan.A(bytes, num2, out CookedText cookedText, out _003Cposition_003E5__2))
				{
					if (cookedText.Namespace.Length == 0 && CookedTextScan.A(bytes, num2 + 4, out CookedText cookedText2, out int num3))
					{
						cookedText = cookedText2;
						_003Cposition_003E5__2 = num3;
					}
					_003C_003E2__current = cookedText;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_008d;
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<CookedText> B()
		{
			A a;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				a = this;
			}
			else
			{
				a = new A(0);
			}
			a.bytes = _003C_003E3__bytes;
			return a;
		}

		global::System.Collections.Generic.IEnumerator<CookedText> global::System.Collections.Generic.IEnumerable<CookedText>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator b()
		{
			return (global::System.Collections.IEnumerator)B();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}
	}

	private const byte BaseHistory = 0;

	private const int MaxKeyLength = 200;

	private const int MaxSourceLength = 16384;

	[IteratorStateMachine(typeof(A))]
	public static global::System.Collections.Generic.IEnumerable<CookedText> In(byte[] bytes)
	{
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		for (int i = 0; i + 6 < bytes.Length; i++)
		{
			if (A(bytes, i, out var cookedText, out var position))
			{
				if (cookedText.Namespace.Length == 0 && A(bytes, i + 4, out var cookedText2, out var num))
				{
					cookedText = cookedText2;
					position = num;
				}
				yield return cookedText;
				i = position - 1;
			}
		}
	}

	private static bool A(byte[] P_0, int P_1, out CookedText P_2, out int P_3)
	{
		P_2 = default(CookedText);
		P_3 = P_1 + 5;
		if (P_1 + 6 >= P_0.Length || P_0[P_1 + 4] != 0)
		{
			return false;
		}
		uint num = BitConverter.ToUInt32(P_0, P_1);
		if (num > 255 || !A(P_0, ref P_3, 0, 200, out string @namespace) || !A(P_0, ref P_3, 1, 200, out string key) || !A(P_0, ref P_3, 1, 16384, out string source))
		{
			return false;
		}
		P_2 = new CookedText(@namespace, key, source, num);
		return true;
	}

	private static bool A(byte[] P_0, ref int P_1, int P_2, int P_3, out string P_4)
	{
		P_4 = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa();
		if (P_1 + 4 > P_0.Length)
		{
			return false;
		}
		int num = BitConverter.ToInt32(P_0, P_1);
		P_1 += 4;
		if (num == 0)
		{
			return P_2 == 0;
		}
		if (num > 0)
		{
			if (num > P_3 + 1 || P_1 + num > P_0.Length || P_0[P_1 + num - 1] != 0)
			{
				return false;
			}
			P_4 = Encoding.UTF8.GetString(P_0, P_1, num - 1);
			P_1 += num;
		}
		else
		{
			int num2 = -num;
			if (num2 > P_3 + 1 || P_1 + num2 * 2 > P_0.Length || P_0[P_1 + num2 * 2 - 2] != 0 || P_0[P_1 + num2 * 2 - 1] != 0)
			{
				return false;
			}
			P_4 = Encoding.Unicode.GetString(P_0, P_1, (num2 - 1) * 2);
			P_1 += num2 * 2;
		}
		if (P_4.Length >= P_2)
		{
			return global::A.c.A(P_4);
		}
		return false;
	}
}
