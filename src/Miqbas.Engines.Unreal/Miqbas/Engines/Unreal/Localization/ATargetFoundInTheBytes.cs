using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Localization;

public readonly struct ATargetFoundInTheBytes : IEquatable<ATargetFoundInTheBytes>
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
	public string Culture
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ATargetFoundInTheBytes(string Name, string Culture)
	{
		this.Name = Name;
		this.Culture = Culture;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eM());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.em());
		P_0.Append((object)Culture);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ATargetFoundInTheBytes left, ATargetFoundInTheBytes right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ATargetFoundInTheBytes left, ATargetFoundInTheBytes right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Culture);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is ATargetFoundInTheBytes)
		{
			return Equals((ATargetFoundInTheBytes)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(ATargetFoundInTheBytes other)
	{
		if (EqualityComparer<string>.Default.Equals(Name, other.Name))
		{
			return EqualityComparer<string>.Default.Equals(Culture, other.Culture);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Name, out string Culture)
	{
		Name = this.Name;
		Culture = this.Culture;
	}
}
