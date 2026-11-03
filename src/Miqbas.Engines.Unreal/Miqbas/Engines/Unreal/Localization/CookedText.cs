using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Localization;

public readonly struct CookedText : IEquatable<CookedText>
{
	[field: CompilerGenerated]
	public string Namespace
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Source
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public uint Flags
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool CultureInvariant => (Flags & 2) != 0;

	public bool FromString => (Flags & 0x10) != 0;

	public CookedText(string Namespace, string Key, string Source, uint Flags)
	{
		this.Namespace = Namespace;
		this.Key = Key;
		this.Source = Source;
		this.Flags = Flags;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DP());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dp());
		P_0.Append((object)Namespace);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DQ());
		P_0.Append((object)Key);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dq());
		P_0.Append((object)Source);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DR());
		P_0.Append(((object)Flags).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dr());
		P_0.Append(((object)CultureInvariant).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DS());
		P_0.Append(((object)FromString).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(CookedText left, CookedText right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(CookedText left, CookedText right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<string>.Default.GetHashCode(Namespace) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(Flags);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is CookedText)
		{
			return Equals((CookedText)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(CookedText other)
	{
		if (EqualityComparer<string>.Default.Equals(Namespace, other.Namespace) && EqualityComparer<string>.Default.Equals(Key, other.Key) && EqualityComparer<string>.Default.Equals(Source, other.Source))
		{
			return EqualityComparer<uint>.Default.Equals(Flags, other.Flags);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Namespace, out string Key, out string Source, out uint Flags)
	{
		Namespace = this.Namespace;
		Key = this.Key;
		Source = this.Source;
		Flags = this.Flags;
	}
}
