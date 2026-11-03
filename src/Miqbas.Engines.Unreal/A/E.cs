using System;
using System.Collections;
using System.Collections.Generic;

namespace A;

internal sealed class E<A> : global::System.Collections.IEnumerable, global::System.Collections.ICollection, global::System.Collections.IList, global::System.Collections.Generic.IEnumerable<A>, global::System.Collections.Generic.IReadOnlyCollection<A>, global::System.Collections.Generic.IReadOnlyList<A>, global::System.Collections.Generic.ICollection<A>, global::System.Collections.Generic.IList<A>
{
	int global::System.Collections.ICollection.Count => _items.Count;

	bool global::System.Collections.ICollection.IsSynchronized => false;

	object global::System.Collections.ICollection.SyncRoot => this;

	object? global::System.Collections.IList.this[int P_0]
	{
		get
		{
			return _items[P_0];
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}
	}

	bool global::System.Collections.IList.IsFixedSize => true;

	bool global::System.Collections.IList.IsReadOnly => true;

	int global::System.Collections.Generic.IReadOnlyCollection<A>.Count => _items.Count;

	A global::System.Collections.Generic.IReadOnlyList<A>.this[int P_0] => _items[P_0];

	int global::System.Collections.Generic.ICollection<A>.Count => _items.Count;

	bool global::System.Collections.Generic.ICollection<A>.IsReadOnly => true;

	A global::System.Collections.Generic.IList<A>.this[int P_0]
	{
		get
		{
			return _items[P_0];
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}
	}

	public E(List<A> P_0)
	{
		_items = P_0;
	}

	private global::System.Collections.IEnumerator A()
	{
		return ((global::System.Collections.IEnumerable)_items).GetEnumerator();
	}

	global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A();
	}

	private void A(global::System.Array array, int P_1)
	{
		((global::System.Collections.ICollection)_items).CopyTo(array, P_1);
	}

	void global::System.Collections.ICollection.CopyTo(global::System.Array array, int P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(array, P_1);
	}

	private int A(object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	int global::System.Collections.IList.Add(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A(value);
	}

	private void a()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		this.a();
	}

	private bool a(object? value)
	{
		return ((global::System.Collections.IList)_items).Contains(value);
	}

	bool global::System.Collections.IList.Contains(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(value);
	}

	private int B(object? value)
	{
		return ((global::System.Collections.IList)_items).IndexOf(value);
	}

	int global::System.Collections.IList.IndexOf(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B(value);
	}

	private void A(int P_0, object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.Insert(int P_0, object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0, value);
	}

	private void b(object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.Remove(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b(value);
	}

	private void A(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.RemoveAt(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0);
	}

	private global::System.Collections.Generic.IEnumerator<A> B()
	{
		return ((global::System.Collections.Generic.IEnumerable<A>)_items).GetEnumerator();
	}

	global::System.Collections.Generic.IEnumerator<A> global::System.Collections.Generic.IEnumerable<A>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B();
	}

	private void A(A P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.ICollection<A>.Add(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0);
	}

	private void b()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.ICollection<A>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b();
	}

	private bool a(A P_0)
	{
		return _items.Contains(P_0);
	}

	bool global::System.Collections.Generic.ICollection<A>.Contains(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0);
	}

	private void A(A[] array, int P_1)
	{
		_items.CopyTo(array, P_1);
	}

	void global::System.Collections.Generic.ICollection<A>.CopyTo(A[] array, int P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(array, P_1);
	}

	private bool B(A P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	bool global::System.Collections.Generic.ICollection<A>.Remove(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B(P_0);
	}

	private int b(A P_0)
	{
		return _items.IndexOf(P_0);
	}

	int global::System.Collections.Generic.IList<A>.IndexOf(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		return this.b(P_0);
	}

	private void A(int P_0, A P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.IList<A>.Insert(int P_0, A P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0, P_1);
	}

	private void a(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.IList<A>.RemoveAt(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		this.a(P_0);
	}
}
internal sealed class e<A> : global::System.Collections.IEnumerable, global::System.Collections.ICollection, global::System.Collections.IList, global::System.Collections.Generic.IEnumerable<A>, global::System.Collections.Generic.IReadOnlyCollection<A>, global::System.Collections.Generic.IReadOnlyList<A>, global::System.Collections.Generic.ICollection<A>, global::System.Collections.Generic.IList<A>
{
	private sealed class A : global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<A>
	{
		object global::System.Collections.IEnumerator.Current => _item;

		A global::System.Collections.Generic.IEnumerator<A>.Current => _item;

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

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			return this.A();
		}

		private void a()
		{
			_moveNextCalled = false;
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		private void B()
		{
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}
	}

	int global::System.Collections.ICollection.Count => 1;

	bool global::System.Collections.ICollection.IsSynchronized => false;

	object global::System.Collections.ICollection.SyncRoot => this;

	object? global::System.Collections.IList.this[int P_0]
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

	bool global::System.Collections.IList.IsFixedSize => true;

	bool global::System.Collections.IList.IsReadOnly => true;

	int global::System.Collections.Generic.IReadOnlyCollection<A>.Count => 1;

	A global::System.Collections.Generic.IReadOnlyList<A>.this[int P_0]
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

	int global::System.Collections.Generic.ICollection<A>.Count => 1;

	bool global::System.Collections.Generic.ICollection<A>.IsReadOnly => true;

	A global::System.Collections.Generic.IList<A>.this[int P_0]
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

	public e(A P_0)
	{
		_item = P_0;
	}

	private global::System.Collections.IEnumerator A()
	{
		return new e<A>.A(_item);
	}

	global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A();
	}

	private void A(global::System.Array array, int P_1)
	{
		array.SetValue((object)_item, P_1);
	}

	void global::System.Collections.ICollection.CopyTo(global::System.Array array, int P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(array, P_1);
	}

	private int A(object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	int global::System.Collections.IList.Add(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A(value);
	}

	private void a()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		this.a();
	}

	private bool a(object? value)
	{
		return EqualityComparer<A>.Default.Equals(_item, (A)value);
	}

	bool global::System.Collections.IList.Contains(object? value)
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

	int global::System.Collections.IList.IndexOf(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B(value);
	}

	private void A(int P_0, object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.Insert(int P_0, object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0, value);
	}

	private void b(object? value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.Remove(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b(value);
	}

	private void A(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.IList.RemoveAt(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0);
	}

	private global::System.Collections.Generic.IEnumerator<A> B()
	{
		return new e<A>.A(_item);
	}

	global::System.Collections.Generic.IEnumerator<A> global::System.Collections.Generic.IEnumerable<A>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in B
		return this.B();
	}

	private void A(A P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.ICollection<A>.Add(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0);
	}

	private void b()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.ICollection<A>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		this.b();
	}

	private bool a(A P_0)
	{
		return EqualityComparer<A>.Default.Equals(_item, P_0);
	}

	bool global::System.Collections.Generic.ICollection<A>.Contains(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0);
	}

	private void A(A[] array, int P_1)
	{
		array[P_1] = _item;
	}

	void global::System.Collections.Generic.ICollection<A>.CopyTo(A[] array, int P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(array, P_1);
	}

	private bool B(A P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	bool global::System.Collections.Generic.ICollection<A>.Remove(A P_0)
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

	int global::System.Collections.Generic.IList<A>.IndexOf(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in b
		return this.b(P_0);
	}

	private void A(int P_0, A P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.IList<A>.Insert(int P_0, A P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		this.A(P_0, P_1);
	}

	private void a(int P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException();
	}

	void global::System.Collections.Generic.IList<A>.RemoveAt(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		this.a(P_0);
	}
}
