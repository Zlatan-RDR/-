using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Hunting;

public readonly struct ByteRange : IEquatable<ByteRange>
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

	public long Length => End - Start;

	public ByteRange(long Start, long End)
	{
		this.Start = Start;
		this.End = End;
	}

	public bool Overlaps(long start, long end)
	{
		if (Start < end)
		{
			return start < End;
		}
		return false;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NP());
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.o());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Np());
		P_0.Append(((object)Start).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NQ());
		P_0.Append(((object)End).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.it());
		P_0.Append(((object)Length).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ByteRange left, ByteRange right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ByteRange left, ByteRange right)
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
		if (obj is ByteRange)
		{
			return Equals((ByteRange)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(ByteRange other)
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
