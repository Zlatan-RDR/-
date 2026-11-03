using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class LiveObjectArray : IEquatable<LiveObjectArray>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LiveObjectArray);
		}
	}

	[field: CompilerGenerated]
	public ulong Address
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<ulong> Chunks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Count
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Capacity
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ItemStride
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LiveObjectArray(ulong Address, global::System.Collections.Generic.IReadOnlyList<ulong> Chunks, int Count, int Capacity, int ItemStride)
	{
		this.Address = Address;
		this.Chunks = Chunks;
		this.Count = Count;
		this.Capacity = Capacity;
		this.ItemStride = ItemStride;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fb());
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
		if (A(val))
		{
			val.Append(' ');
		}
		val.Append('}');
		return ((object)val).ToString();
	}

	[CompilerGenerated]
	private bool A(StringBuilder P_0)
	{
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FC());
		P_0.Append(((object)Address).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fc());
		P_0.Append((object)Chunks);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FD());
		P_0.Append(((object)Count).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fd());
		P_0.Append(((object)Capacity).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FE());
		P_0.Append(((object)ItemStride).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LiveObjectArray? left, LiveObjectArray? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LiveObjectArray? left, LiveObjectArray? right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(Address)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<ulong>>.Default.GetHashCode(Chunks)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Count)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Capacity)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ItemStride);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LiveObjectArray);
	}

	[CompilerGenerated]
	public bool Equals(LiveObjectArray? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<ulong>.Default.Equals(Address, other.Address) && EqualityComparer<global::System.Collections.Generic.IReadOnlyList<ulong>>.Default.Equals(Chunks, other.Chunks) && EqualityComparer<int>.Default.Equals(Count, other.Count) && EqualityComparer<int>.Default.Equals(Capacity, other.Capacity))
			{
				return EqualityComparer<int>.Default.Equals(ItemStride, other.ItemStride);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LiveObjectArray(LiveObjectArray P_0)
	{
		Address = P_0.Address;
		Chunks = P_0.Chunks;
		Count = P_0.Count;
		Capacity = P_0.Capacity;
		ItemStride = P_0.ItemStride;
	}

	[CompilerGenerated]
	public void Deconstruct(out ulong Address, out global::System.Collections.Generic.IReadOnlyList<ulong> Chunks, out int Count, out int Capacity, out int ItemStride)
	{
		Address = this.Address;
		Chunks = this.Chunks;
		Count = this.Count;
		Capacity = this.Capacity;
		ItemStride = this.ItemStride;
	}
}
