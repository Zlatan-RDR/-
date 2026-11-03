using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public readonly struct CalibrationScore : IEquatable<CalibrationScore>
{
	[field: CompilerGenerated]
	public string What
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Chosen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Agreed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Tried
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public double Share
	{
		get
		{
			if (Tried != 0)
			{
				return (double)Agreed / (double)Tried;
			}
			return 0.0;
		}
	}

	public CalibrationScore(string What, int Chosen, int Agreed, int Tried)
	{
		this.What = What;
		this.Chosen = Chosen;
		this.Agreed = Agreed;
		this.Tried = Tried;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ge());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GF());
		P_0.Append((object)What);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gf());
		P_0.Append(((object)Chosen).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GG());
		P_0.Append(((object)Agreed).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gg());
		P_0.Append(((object)Tried).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GH());
		P_0.Append(((object)Share).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(CalibrationScore left, CalibrationScore right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(CalibrationScore left, CalibrationScore right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<string>.Default.GetHashCode(What) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Chosen)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Agreed)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Tried);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is CalibrationScore)
		{
			return Equals((CalibrationScore)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(CalibrationScore other)
	{
		if (EqualityComparer<string>.Default.Equals(What, other.What) && EqualityComparer<int>.Default.Equals(Chosen, other.Chosen) && EqualityComparer<int>.Default.Equals(Agreed, other.Agreed))
		{
			return EqualityComparer<int>.Default.Equals(Tried, other.Tried);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out string What, out int Chosen, out int Agreed, out int Tried)
	{
		What = this.What;
		Chosen = this.Chosen;
		Agreed = this.Agreed;
		Tried = this.Tried;
	}
}
