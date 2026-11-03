using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public readonly struct MemoryRegion : IEquatable<MemoryRegion>
{
	[field: CompilerGenerated]
	public ulong Base
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ulong Size
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Protect
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool IsPrivate => Type == 131072;

	public bool IsImage => Type == 16777216;

	public bool IsWritable
	{
		get
		{
			if ((Protect & 4) == 0 && (Protect & 8) == 0 && (Protect & 0x40) == 0)
			{
				return (Protect & 0x80) != 0;
			}
			return true;
		}
	}

	public MemoryRegion(ulong Base, ulong Size, int Protect, int Type)
	{
		this.Base = Base;
		this.Size = Size;
		this.Protect = Protect;
		this.Type = Type;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fj());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FK());
		P_0.Append(((object)Base).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BK());
		P_0.Append(((object)Size).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fk());
		P_0.Append(((object)Protect).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aP());
		P_0.Append(((object)Type).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FL());
		P_0.Append(((object)IsPrivate).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fl());
		P_0.Append(((object)IsImage).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FM());
		P_0.Append(((object)IsWritable).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(MemoryRegion left, MemoryRegion right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(MemoryRegion left, MemoryRegion right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<ulong>.Default.GetHashCode(Base) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(Size)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Protect)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Type);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is MemoryRegion)
		{
			return Equals((MemoryRegion)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(MemoryRegion other)
	{
		if (EqualityComparer<ulong>.Default.Equals(Base, other.Base) && EqualityComparer<ulong>.Default.Equals(Size, other.Size) && EqualityComparer<int>.Default.Equals(Protect, other.Protect))
		{
			return EqualityComparer<int>.Default.Equals(Type, other.Type);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out ulong Base, out ulong Size, out int Protect, out int Type)
	{
		Base = this.Base;
		Size = this.Size;
		Protect = this.Protect;
		Type = this.Type;
	}
}
