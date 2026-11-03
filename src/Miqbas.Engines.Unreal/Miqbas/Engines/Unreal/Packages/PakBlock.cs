using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public readonly struct PakBlock : IEquatable<PakBlock>
{
	[field: CompilerGenerated]
	public long Start
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long End
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int Length => checked((int)(End - Start));

	public PakBlock(long Start, long End)
	{
		this.Start = Start;
		this.End = End;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bx());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bY());
		P_0.Append(((object)Start).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.by());
		P_0.Append(((object)End).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aQ());
		P_0.Append(((object)Length).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(PakBlock left, PakBlock right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(PakBlock left, PakBlock right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return EqualityComparer<long>.Default.GetHashCode(Start) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(End);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is PakBlock)
		{
			return Equals((PakBlock)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(PakBlock other)
	{
		if (EqualityComparer<long>.Default.Equals(Start, other.Start))
		{
			return EqualityComparer<long>.Default.Equals(End, other.End);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out long Start, out long End)
	{
		Start = this.Start;
		End = this.End;
	}
}
