using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public readonly struct ALockedIndex : IEquatable<ALockedIndex>
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
	public int Length
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public byte[] Fingerprint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ALockedIndex(long Offset, int Length, byte[] Fingerprint)
	{
		this.Offset = Offset;
		this.Length = Length;
		this.Fingerprint = Fingerprint;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ck());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aQ());
		P_0.Append(((object)Length).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CL());
		P_0.Append((object)Fingerprint);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ALockedIndex left, ALockedIndex right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ALockedIndex left, ALockedIndex right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (EqualityComparer<long>.Default.GetHashCode(Offset) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Length)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Fingerprint);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is ALockedIndex)
		{
			return Equals((ALockedIndex)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(ALockedIndex other)
	{
		if (EqualityComparer<long>.Default.Equals(Offset, other.Offset) && EqualityComparer<int>.Default.Equals(Length, other.Length))
		{
			return EqualityComparer<byte[]>.Default.Equals(Fingerprint, other.Fingerprint);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out long Offset, out int Length, out byte[] Fingerprint)
	{
		Offset = this.Offset;
		Length = this.Length;
		Fingerprint = this.Fingerprint;
	}
}
