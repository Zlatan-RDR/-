using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Translation;

public static class BatchLimits
{
	[CompilerGenerated]
	private sealed class A<A> : System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<A>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.IReadOnlyList<A>>, System.Collections.IEnumerator, System.IDisposable
	{
		private int _003C_003E1__state;

		private System.Collections.Generic.IReadOnlyList<A> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private System.Collections.Generic.IEnumerable<A> items;

		public System.Collections.Generic.IEnumerable<A> _003C_003E3__items;

		private Func<A, int> lengthOf;

		public Func<A, int> _003C_003E3__lengthOf;

		private int maxLines;

		public int _003C_003E3__maxLines;

		private int maxCharacters;

		public int _003C_003E3__maxCharacters;

		private System.Collections.Generic.IEnumerator<A> _003C_003E7__wrap1;

		private A _003Citem_003E5__3;

		private int _003Clength_003E5__4;

		System.Collections.Generic.IReadOnlyList<A> System.Collections.Generic.IEnumerator<System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<A>>>.Current
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
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			try
			{
				List<A> val;
				int num;
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					val = new List<A>();
					num = 0;
					_003C_003E7__wrap1 = items.GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_00e2;
				case 1:
					_003C_003E1__state = -3;
					val = new List<A>();
					num = 0;
					goto IL_00c1;
				case 2:
					{
						_003C_003E1__state = -1;
						break;
					}
					IL_00e2:
					if (((System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
					{
						_003Citem_003E5__3 = _003C_003E7__wrap1.Current;
						_003Clength_003E5__4 = lengthOf.Invoke(_003Citem_003E5__3);
						if (val.Count > 0 && (val.Count >= maxLines || num + _003Clength_003E5__4 > maxCharacters))
						{
							_003C_003E2__current = (System.Collections.Generic.IReadOnlyList<A>)val;
							_003C_003E1__state = 1;
							return true;
						}
						goto IL_00c1;
					}
					a();
					_003C_003E7__wrap1 = null;
					if (val.Count > 0)
					{
						_003C_003E2__current = (System.Collections.Generic.IReadOnlyList<A>)val;
						_003C_003E1__state = 2;
						return true;
					}
					break;
					IL_00c1:
					val.Add(_003Citem_003E5__3);
					num += _003Clength_003E5__4;
					_003Citem_003E5__3 = default(A);
					goto IL_00e2;
				}
				return false;
			}
			catch
			{
				//try-fault
				this.A();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				((System.IDisposable)_003C_003E7__wrap1).Dispose();
			}
		}

		[DebuggerHidden]
		private void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<System.Collections.Generic.IReadOnlyList<A>> b()
		{
			A<A> a;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				a = this;
			}
			else
			{
				a = new A<A>(0);
			}
			a.items = _003C_003E3__items;
			a.maxLines = _003C_003E3__maxLines;
			a.maxCharacters = _003C_003E3__maxCharacters;
			a.lengthOf = _003C_003E3__lengthOf;
			return a;
		}

		System.Collections.Generic.IEnumerator<System.Collections.Generic.IReadOnlyList<A>> System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<A>>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator C()
		{
			return (System.Collections.IEnumerator)b();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}
	}

	public const int DefaultLines = 20;

	public const int DefaultCharacters = 2000;

	public static ValueTuple<int?, int?> ForContextWindow(int? contextWindowTokens)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (contextWindowTokens.HasValue)
		{
			int valueOrDefault = contextWindowTokens.GetValueOrDefault();
			if (valueOrDefault >= 64000)
			{
				if (valueOrDefault >= 500000)
				{
					return new ValueTuple<int?, int?>((int?)300, (int?)80000);
				}
				return new ValueTuple<int?, int?>((int?)400, (int?)8000);
			}
			if (valueOrDefault >= 16000)
			{
				return new ValueTuple<int?, int?>((int?)100, (int?)4000);
			}
			return new ValueTuple<int?, int?>((int?)null, (int?)null);
		}
		return new ValueTuple<int?, int?>((int?)null, (int?)null);
	}

	[IteratorStateMachine(typeof(A<>))]
	public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<T>> Plan<T>(System.Collections.Generic.IEnumerable<T> items, int maxLines, int maxCharacters, Func<T, int> lengthOf)
	{
		List<T> val = new List<T>();
		int num = 0;
		System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				T item = enumerator.Current;
				int length = lengthOf.Invoke(item);
				if (val.Count > 0 && (val.Count >= maxLines || num + length > maxCharacters))
				{
					yield return (System.Collections.Generic.IReadOnlyList<T>)val;
					val = new List<T>();
					num = 0;
				}
				val.Add(item);
				num += length;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count > 0)
		{
			yield return (System.Collections.Generic.IReadOnlyList<T>)val;
		}
	}
}
