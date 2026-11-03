using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace A;

[CompilerGenerated]
internal sealed class D
{
	[StructLayout(2, Pack = 1, Size = 7)]
	internal struct A
	{
	}

	[StructLayout(2, Pack = 1, Size = 12)]
	internal struct a
	{
	}

	[StructLayout(2, Pack = 1, Size = 15)]
	internal struct B
	{
	}

	[StructLayout(2, Pack = 1, Size = 16)]
	internal struct b
	{
	}

	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct C
	{
	}

	[StructLayout(2, Pack = 1, Size = 28)]
	internal struct c
	{
	}

	[StructLayout(2, Pack = 1, Size = 36)]
	internal struct D
	{
	}

	internal static readonly b _178CF4164715469CE47A2C6E0AE19FAF75284D4C754269DE6922DE7B009ACEFE/* Not supported: data(4F EE 4C A1 68 48 55 83 6C 4C 46 BD 70 DA 50 7C) */;

	internal static readonly A _20DE0851304D160FA0D927397EBF0152821404BB12B8E0FF532EE5231E000817/* Not supported: data(01 02 04 08 10 20 40) */;

	internal static readonly C _2A0D42AC0A92A793F493D1048EEFFBAC68B04A8159748C69453B0BBAB5B70B0C/* Not supported: data(18 00 00 00 20 00 00 00 10 00 00 00 28 00 00 00 30 00 00 00) */;

	internal static readonly a _2E5C9862856B0C6F8E0CEA23282DC6A269BAD2A2CC34AA0668A8EEAE66326835/* Not supported: data(08 00 00 00 10 00 00 00 18 00 00 00) */;

	internal static readonly b _69F2AE7CC2E623F5B7AD7D119BC561F4290D9ADD9BE1138B736A3DBC7EEE99F1/* Not supported: data(18 00 00 00 20 00 00 00 28 00 00 00 30 00 00 00) */;

	internal static readonly D _7726A7327581C10ED06C51158A0988B9D1BD7A2753588CCC756A3AA683359FE7/* Not supported: data(38 00 00 00 3C 00 00 00 40 00 00 00 44 00 00 00 48 00 00 00 4C 00 00 00 50 00 00 00 54 00 00 00 58 00 00 00) */;

	internal static readonly int _7E68BF29C62A29D16F2280CA66EC6659235ECDE5C9A6E234BE3CDF3EA7C0B8A2/* Not supported: data(E1 12 6F 5A) */;

	internal static readonly c _9D0300A8247F1A821AEE408E46E987046B42F388F286FC401FB19180748A64F4/* Not supported: data(30 00 00 00 34 00 00 00 38 00 00 00 3C 00 00 00 40 00 00 00 44 00 00 00 48 00 00 00) */;

	internal static readonly b A0C65E1B0B6E35ABB0100EF05CA52FB62F4C407C843F854FD531EDE679430653/* Not supported: data(0E 14 74 75 67 4A 03 FC 4A 15 90 9D C3 37 7F 1B) */;

	internal static readonly B B2512F627D177BC6A36C057265479892CB24DAAFB2DE98E634C0DEEBAD4CFFA8/* Not supported: data(3C 64 6C 6F 63 5F 64 61 74 61 62 61 73 65 00) */;

	internal static readonly C DFAC86C353368ED76F5A7AF46C9F130B3DDC365443C0364914AC0E41E50B4C39/* Not supported: data(18 00 00 00 20 00 00 00 28 00 00 00 30 00 00 00 38 00 00 00) */;
}
internal sealed class d<A> : global::System.Collections.IEnumerable, global::System.Collections.ICollection, global::System.Collections.IList, global::System.Collections.Generic.IEnumerable<A>, global::System.Collections.Generic.IReadOnlyCollection<A>, global::System.Collections.Generic.IReadOnlyList<A>, global::System.Collections.Generic.ICollection<A>, global::System.Collections.Generic.IList<A>
{
	int global::System.Collections.ICollection.Count => _items.Length;

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

	int global::System.Collections.Generic.IReadOnlyCollection<A>.Count => _items.Length;

	A global::System.Collections.Generic.IReadOnlyList<A>.this[int P_0] => _items[P_0];

	int global::System.Collections.Generic.ICollection<A>.Count => _items.Length;

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

	public d(A[] P_0)
	{
		_items = P_0;
	}

	private global::System.Collections.IEnumerator A()
	{
		return ((global::System.Collections.IEnumerable)(object)_items).GetEnumerator();
	}

	global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A
		return this.A();
	}

	private void A(global::System.Array array, int P_1)
	{
		((global::System.Collections.ICollection)(object)_items).CopyTo(array, P_1);
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
		return ((global::System.Collections.IList)(object)_items).Contains(value);
	}

	bool global::System.Collections.IList.Contains(object? value)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(value);
	}

	private int B(object? value)
	{
		return ((global::System.Collections.IList)(object)_items).IndexOf(value);
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
		return ((global::System.Collections.Generic.ICollection<A>)_items).Contains(P_0);
	}

	bool global::System.Collections.Generic.ICollection<A>.Contains(A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0);
	}

	private void A(A[] array, int P_1)
	{
		((global::System.Collections.Generic.ICollection<A>)_items).CopyTo(array, P_1);
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
		return ((global::System.Collections.Generic.IList<A>)_items).IndexOf(P_0);
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
