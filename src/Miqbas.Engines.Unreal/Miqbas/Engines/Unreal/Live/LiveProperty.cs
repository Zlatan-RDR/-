using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public readonly struct LiveProperty : IEquatable<LiveProperty>
{
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ValueOffset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
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
	public int ElementSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LiveProperty(string Name, string Type, int ValueOffset, ulong Address = 0uL, int ElementSize = 0)
	{
		this.Name = Name;
		this.Type = Type;
		this.ValueOffset = ValueOffset;
		this.Address = Address;
		this.ElementSize = ElementSize;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GJ());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bj());
		P_0.Append((object)Name);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aP());
		P_0.Append((object)Type);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GC());
		P_0.Append(((object)ValueOffset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ea());
		P_0.Append(((object)Address).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gc());
		P_0.Append(((object)ElementSize).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LiveProperty left, LiveProperty right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LiveProperty left, LiveProperty right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ValueOffset)) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(Address)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ElementSize);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is LiveProperty)
		{
			return Equals((LiveProperty)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(LiveProperty other)
	{
		if (EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<string>.Default.Equals(Type, other.Type) && EqualityComparer<int>.Default.Equals(ValueOffset, other.ValueOffset) && EqualityComparer<ulong>.Default.Equals(Address, other.Address))
		{
			return EqualityComparer<int>.Default.Equals(ElementSize, other.ElementSize);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Name, out string Type, out int ValueOffset, out ulong Address, out int ElementSize)
	{
		Name = this.Name;
		Type = this.Type;
		ValueOffset = this.ValueOffset;
		Address = this.Address;
		ElementSize = this.ElementSize;
	}
}
