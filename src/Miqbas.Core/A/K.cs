using System;
using System.Collections;
using System.Collections.Generic;

namespace A;

internal sealed class K<A> : System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.IList, System.Collections.Generic.IEnumerable<A>, System.Collections.Generic.IReadOnlyCollection<A>, System.Collections.Generic.IReadOnlyList<A>, System.Collections.Generic.ICollection<A>, System.Collections.Generic.IList<A>
{
	int System.Collections.ICollection.Count => _items.Length;

	bool System.Collections.ICollection.IsSynchronized => false;

	object System.Collections.ICollection.SyncRoot => this;

	object? System.Collections.IList.this[int P_0]
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

	bool System.Collections.IList.IsFixedSize => true;

	bool System.Collections.IList.IsReadOnly => true;

	int System.Collections.Generic.IReadOnlyCollection<A>.Count => _items.Length;

	A System.Collections.Generic.IReadOnlyList<A>.this[int P_0] => _items[P_0];

	int System.Collections.Generic.ICollection<A>.Count => _items.Length;

	bool System.Collections.Generic.ICollection<A>.IsReadOnly => true;

	A System.Collections.Generic.IList<A>.this[int P_0]
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

	public K(A[] P_0)
	{
		_items = P_0;
	}

	private System.Collections.IEnumerator A()
	{
		return ((System.Collections.IEnumerable)(object)_items).GetEnumerator();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A();
	}

	private void A(System.Array array, int P_1)
	{
		((System.Collections.ICollection)(object)_items).CopyTo(array, P_1);
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
		return ((System.Collections.IList)(object)_items).Contains(value);
	}

	bool System.Collections.IList.Contains(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(value);
	}

	private int B(object? value)
	{
		return ((System.Collections.IList)(object)_items).IndexOf(value);
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
		return ((System.Collections.Generic.IEnumerable<A>)_items).GetEnumerator();
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
		return ((System.Collections.Generic.ICollection<A>)_items).Contains(P_0);
	}

	bool System.Collections.Generic.ICollection<A>.Contains(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0);
	}

	private void A(A[] array, int P_1)
	{
		((System.Collections.Generic.ICollection<A>)_items).CopyTo(array, P_1);
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
		return ((System.Collections.Generic.IList<A>)_items).IndexOf(P_0);
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
internal sealed class k<A> : System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.IList, System.Collections.Generic.IEnumerable<A>, System.Collections.Generic.IReadOnlyCollection<A>, System.Collections.Generic.IReadOnlyList<A>, System.Collections.Generic.ICollection<A>, System.Collections.Generic.IList<A>
{
	int System.Collections.ICollection.Count => _items.Count;

	bool System.Collections.ICollection.IsSynchronized => false;

	object System.Collections.ICollection.SyncRoot => this;

	object? System.Collections.IList.this[int P_0]
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

	bool System.Collections.IList.IsFixedSize => true;

	bool System.Collections.IList.IsReadOnly => true;

	int System.Collections.Generic.IReadOnlyCollection<A>.Count => _items.Count;

	A System.Collections.Generic.IReadOnlyList<A>.this[int P_0] => _items[P_0];

	int System.Collections.Generic.ICollection<A>.Count => _items.Count;

	bool System.Collections.Generic.ICollection<A>.IsReadOnly => true;

	A System.Collections.Generic.IList<A>.this[int P_0]
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

	public k(List<A> P_0)
	{
		_items = P_0;
	}

	private System.Collections.IEnumerator A()
	{
		return ((System.Collections.IEnumerable)_items).GetEnumerator();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A();
	}

	private void A(System.Array array, int P_1)
	{
		((System.Collections.ICollection)_items).CopyTo(array, P_1);
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
		return ((System.Collections.IList)_items).Contains(value);
	}

	bool System.Collections.IList.Contains(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(value);
	}

	private int B(object? value)
	{
		return ((System.Collections.IList)_items).IndexOf(value);
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
		return ((System.Collections.Generic.IEnumerable<A>)_items).GetEnumerator();
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
		return _items.Contains(P_0);
	}

	bool System.Collections.Generic.ICollection<A>.Contains(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0);
	}

	private void A(A[] array, int P_1)
	{
		_items.CopyTo(array, P_1);
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
		return _items.IndexOf(P_0);
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
