using System;
using System.Collections;
using System.Collections.Generic;

namespace A;

internal sealed class L<A> : System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.IList, System.Collections.Generic.IEnumerable<A>, System.Collections.Generic.IReadOnlyCollection<A>, System.Collections.Generic.IReadOnlyList<A>, System.Collections.Generic.ICollection<A>, System.Collections.Generic.IList<A>
{
	private sealed class A : System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<A>
	{
		object System.Collections.IEnumerator.Current => _item;

		A System.Collections.Generic.IEnumerator<A>.Current => _item;

		public A(A P_0)
		{
			_item = P_0;
		}

		private bool A()
		{
			if (!_moveNextCalled)
			{
				return _moveNextCalled = true;
			}
			return false;
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			return this.A();
		}

		private void a()
		{
			_moveNextCalled = false;
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		private void B()
		{
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}
	}

	int System.Collections.ICollection.Count => 1;

	bool System.Collections.ICollection.IsSynchronized => false;

	object System.Collections.ICollection.SyncRoot => this;

	object? System.Collections.IList.this[int P_0]
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _item;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}
	}

	bool System.Collections.IList.IsFixedSize => true;

	bool System.Collections.IList.IsReadOnly => true;

	int System.Collections.Generic.IReadOnlyCollection<A>.Count => 1;

	A System.Collections.Generic.IReadOnlyList<A>.this[int P_0]
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _item;
		}
	}

	int System.Collections.Generic.ICollection<A>.Count => 1;

	bool System.Collections.Generic.ICollection<A>.IsReadOnly => true;

	A System.Collections.Generic.IList<A>.this[int P_0]
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _item;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}
	}

	public L(A P_0)
	{
		_item = P_0;
	}

	private System.Collections.IEnumerator A()
	{
		return new L<A>.A(_item);
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A();
	}

	private void A(System.Array array, int P_1)
	{
		array.SetValue((object)_item, P_1);
	}

	void System.Collections.ICollection.CopyTo(System.Array array, int P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(array, P_1);
	}

	private int A(object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	int System.Collections.IList.Add(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A(value);
	}

	private void a()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.IList.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		this.a();
	}

	private bool a(object? value)
	{
		return EqualityComparer<A>.Default.Equals(_item, (A)value);
	}

	bool System.Collections.IList.Contains(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(value);
	}

	private int B(object? value)
	{
		if (!EqualityComparer<A>.Default.Equals(_item, (A)value))
		{
			return -1;
		}
		return 0;
	}

	int System.Collections.IList.IndexOf(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B(value);
	}

	private void A(int P_0, object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.IList.Insert(int P_0, object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0, value);
	}

	private void b(object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.IList.Remove(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b(value);
	}

	private void A(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.IList.RemoveAt(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0);
	}

	private System.Collections.Generic.IEnumerator<A> B()
	{
		return new L<A>.A(_item);
	}

	System.Collections.Generic.IEnumerator<A> System.Collections.Generic.IEnumerable<A>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B();
	}

	private void A(A P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.Generic.ICollection<A>.Add(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0);
	}

	private void b()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.Generic.ICollection<A>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b();
	}

	private bool a(A P_0)
	{
		return EqualityComparer<A>.Default.Equals(_item, P_0);
	}

	bool System.Collections.Generic.ICollection<A>.Contains(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0);
	}

	private void A(A[] array, int P_1)
	{
		array[P_1] = _item;
	}

	void System.Collections.Generic.ICollection<A>.CopyTo(A[] array, int P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(array, P_1);
	}

	private bool B(A P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	bool System.Collections.Generic.ICollection<A>.Remove(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B(P_0);
	}

	private int b(A P_0)
	{
		if (!EqualityComparer<A>.Default.Equals(_item, P_0))
		{
			return -1;
		}
		return 0;
	}

	int System.Collections.Generic.IList<A>.IndexOf(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		return this.b(P_0);
	}

	private void A(int P_0, A P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.Generic.IList<A>.Insert(int P_0, A P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0, P_1);
	}

	private void a(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void System.Collections.Generic.IList<A>.RemoveAt(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		this.a(P_0);
	}
}
