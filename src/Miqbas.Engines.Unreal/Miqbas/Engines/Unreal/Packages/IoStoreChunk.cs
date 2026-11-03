using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public readonly struct IoStoreChunk : IEquatable<IoStoreChunk>
{
	[field: CompilerGenerated]
	public ulong Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ushort Index
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public byte Type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long Offset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long Length
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public IoStoreChunk(ulong Id, ushort Index, byte Type, long Offset, long Length)
	{
		this.Id = Id;
		this.Index = Index;
		this.Type = Type;
		this.Offset = Offset;
		this.Length = Length;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.an());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aO());
		P_0.Append(((object)Id).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ao());
		P_0.Append(((object)Index).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aP());
		P_0.Append(((object)Type).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ap());
		P_0.Append(((object)Offset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aQ());
		P_0.Append(((object)Length).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(IoStoreChunk left, IoStoreChunk right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(IoStoreChunk left, IoStoreChunk right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((EqualityComparer<ulong>.Default.GetHashCode(Id) * -1521134295 + EqualityComparer<ushort>.Default.GetHashCode(Index)) * -1521134295 + EqualityComparer<byte>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Offset)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Length);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is IoStoreChunk)
		{
			return Equals((IoStoreChunk)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(IoStoreChunk other)
	{
		if (EqualityComparer<ulong>.Default.Equals(Id, other.Id) && EqualityComparer<ushort>.Default.Equals(Index, other.Index) && EqualityComparer<byte>.Default.Equals(Type, other.Type) && EqualityComparer<long>.Default.Equals(Offset, other.Offset))
		{
			return EqualityComparer<long>.Default.Equals(Length, other.Length);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out ulong Id, out ushort Index, out byte Type, out long Offset, out long Length)
	{
		Id = this.Id;
		Index = this.Index;
		Type = this.Type;
		Offset = this.Offset;
		Length = this.Length;
	}
}
