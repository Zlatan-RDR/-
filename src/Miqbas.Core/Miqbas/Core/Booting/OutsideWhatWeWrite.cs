using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public static class OutsideWhatWeWrite
{
	[CompilerGenerated]
	private sealed class A : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string line;

		public string _003C_003E3__line;

		private string _003Cwhole_003E5__2;

		private string[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private string _003Cjoint_003E5__5;

		private int _003Cat_003E5__6;

		string System.Collections.Generic.IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object System.Collections.IEnumerator.Current
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

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			int num;
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Cwhole_003E5__2 = (line ?? string.Empty).Trim();
				_003C_003E2__current = _003Cwhole_003E5__2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E7__wrap2 = Joints;
				_003C_003E7__wrap3 = 0;
				goto IL_014b;
			case 2:
			{
				_003C_003E1__state = -1;
				string text = _003Cwhole_003E5__2;
				int num2 = _003Cat_003E5__6 + _003Cjoint_003E5__5.Length;
				_003C_003E2__current = text.Substring(num2, text.Length - num2).Trim();
				_003C_003E1__state = 3;
				return true;
			}
			case 3:
				{
					_003C_003E1__state = -1;
					num = _003Cat_003E5__6 + _003Cjoint_003E5__5.Length;
					goto IL_0088;
				}
				IL_014b:
				if (_003C_003E7__wrap3 < _003C_003E7__wrap2.Length)
				{
					_003Cjoint_003E5__5 = _003C_003E7__wrap2[_003C_003E7__wrap3];
					num = 0;
					goto IL_0088;
				}
				_003C_003E7__wrap2 = null;
				return false;
				IL_0088:
				_003Cat_003E5__6 = _003Cwhole_003E5__2.IndexOf(_003Cjoint_003E5__5, num, (StringComparison)4);
				if (_003Cat_003E5__6 >= 0)
				{
					_003C_003E2__current = _003Cwhole_003E5__2.Substring(0, _003Cat_003E5__6).Trim();
					_003C_003E1__state = 2;
					return true;
				}
				_003Cjoint_003E5__5 = null;
				_003C_003E7__wrap3++;
				goto IL_014b;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
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

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<string> B()
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
			a.line = _003C_003E3__line;
			return a;
		}

		System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator b()
		{
			return (System.Collections.IEnumerator)B();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}
	}

	private static readonly string[] Joints = new string[6]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QE(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DQ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qe(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hs(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ol(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QF()
	};

	private const int ShortestFieldWorthMatching = 2;

	public static bool CouldBeOurs(string? line, IReadOnlySet<string>? whatTheGameSays)
	{
		if (whatTheGameSays == null || ((System.Collections.Generic.IReadOnlyCollection<string>)whatTheGameSays).Count == 0 || string.IsNullOrWhiteSpace(line))
		{
			return false;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = FieldsOf(line).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (current.Length >= 2 && whatTheGameSays.Contains(current))
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	[IteratorStateMachine(typeof(A))]
	public static System.Collections.Generic.IEnumerable<string> FieldsOf(string line)
	{
		string whole = (line ?? string.Empty).Trim();
		yield return whole;
		string[] joints = Joints;
		foreach (string joint in joints)
		{
			int num = 0;
			while (true)
			{
				int at = whole.IndexOf(joint, num, (StringComparison)4);
				if (at < 0)
				{
					break;
				}
				yield return whole.Substring(0, at).Trim();
				string text = whole;
				int num2 = at + joint.Length;
				yield return text.Substring(num2, text.Length - num2).Trim();
				num = at + joint.Length;
			}
		}
	}
}
