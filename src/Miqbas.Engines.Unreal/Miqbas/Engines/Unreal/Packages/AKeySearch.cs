using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public readonly struct AKeySearch : IEquatable<AKeySearch>
{
	[field: CompilerGenerated]
	public byte[]? Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long BytesSearched
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public TimeSpan Took
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool CouldNotOpen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool Found => Key != null;

	public AKeySearch(byte[]? Key, long BytesSearched, TimeSpan Took, bool CouldNotOpen = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		this.Key = Key;
		this.BytesSearched = BytesSearched;
		this.Took = Took;
		this.CouldNotOpen = CouldNotOpen;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CH());
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ch());
		P_0.Append((object)Key);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CI());
		P_0.Append(((object)BytesSearched).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ci());
		TimeSpan took = Took;
		P_0.Append(((object)(TimeSpan)(ref took)).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CJ());
		P_0.Append(((object)CouldNotOpen).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cj());
		P_0.Append(((object)Found).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(AKeySearch left, AKeySearch right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(AKeySearch left, AKeySearch right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return ((EqualityComparer<byte[]>.Default.GetHashCode(Key) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(BytesSearched)) * -1521134295 + EqualityComparer<TimeSpan>.Default.GetHashCode(Took)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CouldNotOpen);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is AKeySearch)
		{
			return Equals((AKeySearch)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(AKeySearch other)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (EqualityComparer<byte[]>.Default.Equals(Key, other.Key) && EqualityComparer<long>.Default.Equals(BytesSearched, other.BytesSearched) && EqualityComparer<TimeSpan>.Default.Equals(Took, other.Took))
		{
			return EqualityComparer<bool>.Default.Equals(CouldNotOpen, other.CouldNotOpen);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out byte[]? Key, out long BytesSearched, out TimeSpan Took, out bool CouldNotOpen)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		Key = this.Key;
		BytesSearched = this.BytesSearched;
		Took = this.Took;
		CouldNotOpen = this.CouldNotOpen;
	}
}
