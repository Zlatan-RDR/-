using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public readonly struct IoStoreBlock : IEquatable<IoStoreBlock>
{
	[field: CompilerGenerated]
	public long Offset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int CompressedSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int UncompressedSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public byte Method
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public IoStoreBlock(long Offset, int CompressedSize, int UncompressedSize, byte Method)
	{
		this.Offset = Offset;
		this.CompressedSize = CompressedSize;
		this.UncompressedSize = UncompressedSize;
		this.Method = Method;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aq());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aR());
		P_0.Append(((object)Offset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ar());
		P_0.Append(((object)CompressedSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aS());
		P_0.Append(((object)UncompressedSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.@as());
		P_0.Append(((object)Method).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(IoStoreBlock left, IoStoreBlock right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(IoStoreBlock left, IoStoreBlock right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<long>.Default.GetHashCode(Offset) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CompressedSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(UncompressedSize)) * -1521134295 + EqualityComparer<byte>.Default.GetHashCode(Method);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is IoStoreBlock)
		{
			return Equals((IoStoreBlock)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(IoStoreBlock other)
	{
		if (EqualityComparer<long>.Default.Equals(Offset, other.Offset) && EqualityComparer<int>.Default.Equals(CompressedSize, other.CompressedSize) && EqualityComparer<int>.Default.Equals(UncompressedSize, other.UncompressedSize))
		{
			return EqualityComparer<byte>.Default.Equals(Method, other.Method);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out long Offset, out int CompressedSize, out int UncompressedSize, out byte Method)
	{
		Offset = this.Offset;
		CompressedSize = this.CompressedSize;
		UncompressedSize = this.UncompressedSize;
		Method = this.Method;
	}
}
