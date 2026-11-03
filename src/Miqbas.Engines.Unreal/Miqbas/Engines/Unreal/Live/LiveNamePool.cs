using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class LiveNamePool : IEquatable<LiveNamePool>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LiveNamePool);
		}
	}

	[field: CompilerGenerated]
	public ulong BlocksAddress
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<ulong> Blocks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int EntryOffset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LiveNamePool(ulong BlocksAddress, global::System.Collections.Generic.IReadOnlyList<ulong> Blocks, int EntryOffset)
	{
		this.BlocksAddress = BlocksAddress;
		this.Blocks = Blocks;
		this.EntryOffset = EntryOffset;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eX());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ex());
		P_0.Append(((object)BlocksAddress).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CD());
		P_0.Append((object)Blocks);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eY());
		P_0.Append(((object)EntryOffset).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LiveNamePool? left, LiveNamePool? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LiveNamePool? left, LiveNamePool? right)
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
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(BlocksAddress)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<ulong>>.Default.GetHashCode(Blocks)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(EntryOffset);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LiveNamePool);
	}

	[CompilerGenerated]
	public bool Equals(LiveNamePool? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<ulong>.Default.Equals(BlocksAddress, other.BlocksAddress) && EqualityComparer<global::System.Collections.Generic.IReadOnlyList<ulong>>.Default.Equals(Blocks, other.Blocks))
			{
				return EqualityComparer<int>.Default.Equals(EntryOffset, other.EntryOffset);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LiveNamePool(LiveNamePool P_0)
	{
		BlocksAddress = P_0.BlocksAddress;
		Blocks = P_0.Blocks;
		EntryOffset = P_0.EntryOffset;
	}

	[CompilerGenerated]
	public void Deconstruct(out ulong BlocksAddress, out global::System.Collections.Generic.IReadOnlyList<ulong> Blocks, out int EntryOffset)
	{
		BlocksAddress = this.BlocksAddress;
		Blocks = this.Blocks;
		EntryOffset = this.EntryOffset;
	}
}
