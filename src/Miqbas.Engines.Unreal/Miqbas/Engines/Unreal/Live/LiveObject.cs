using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public readonly struct LiveObject : IEquatable<LiveObject>
{
	[field: CompilerGenerated]
	public ulong Address
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string ClassName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ulong ClassAddress
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LiveObject(ulong Address, string Name, string ClassName, ulong ClassAddress = 0uL)
	{
		this.Address = Address;
		this.Name = Name;
		this.ClassName = ClassName;
		this.ClassAddress = ClassAddress;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gh());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FC());
		P_0.Append(((object)Address).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BG());
		P_0.Append((object)Name);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GI());
		P_0.Append((object)ClassName);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gi());
		P_0.Append(((object)ClassAddress).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LiveObject left, LiveObject right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LiveObject left, LiveObject right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<ulong>.Default.GetHashCode(Address) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClassName)) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(ClassAddress);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is LiveObject)
		{
			return Equals((LiveObject)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(LiveObject other)
	{
		if (EqualityComparer<ulong>.Default.Equals(Address, other.Address) && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<string>.Default.Equals(ClassName, other.ClassName))
		{
			return EqualityComparer<ulong>.Default.Equals(ClassAddress, other.ClassAddress);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out ulong Address, out string Name, out string ClassName, out ulong ClassAddress)
	{
		Address = this.Address;
		Name = this.Name;
		ClassName = this.ClassName;
		ClassAddress = this.ClassAddress;
	}
}
