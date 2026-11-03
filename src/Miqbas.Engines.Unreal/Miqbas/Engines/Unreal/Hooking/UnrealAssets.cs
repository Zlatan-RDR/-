using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Hooking;

public static class UnrealAssets
{
	[CompilerGenerated]
	private sealed class A : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		string global::System.Collections.Generic.IEnumerator<string>.Current
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
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = Path.Combine(AppContext.BaseDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hj());
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				for (string text = AppContext.BaseDirectory; text != null; text = Path.GetDirectoryName(text))
				{
					string text2 = Path.Combine(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hK(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hk(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hj());
					if (Directory.Exists(text2))
					{
						_003C_003E2__current = text2;
						_003C_003E1__state = 2;
						return true;
					}
				}
				return false;
			}
			case 2:
				_003C_003E1__state = -1;
				return false;
			}
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
		private global::System.Collections.Generic.IEnumerator<string> B()
		{
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				return this;
			}
			return new A(0);
		}

		global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator()
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

	public static string? Find(string fileName)
	{
		global::System.Collections.Generic.IEnumerator<string> enumerator = A().GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string text = Path.Combine(enumerator.Current, fileName);
				if (File.Exists(text))
				{
					return text;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	public static string Require(string fileName)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		return Find(fileName) ?? throw new InvalidOperationException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gF() + fileName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gf());
	}

	[IteratorStateMachine(typeof(A))]
	private static global::System.Collections.Generic.IEnumerable<string> A()
	{
		yield return Path.Combine(AppContext.BaseDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hj());
		for (string text = AppContext.BaseDirectory; text != null; text = Path.GetDirectoryName(text))
		{
			string text2 = Path.Combine(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hK(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hk(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hj());
			if (Directory.Exists(text2))
			{
				yield return text2;
				break;
			}
		}
	}
}
