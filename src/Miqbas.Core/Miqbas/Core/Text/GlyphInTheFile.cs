using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public readonly struct GlyphInTheFile : IEquatable<GlyphInTheFile>
{
	[field: CompilerGenerated]
	public int Codepoint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int InkPixels
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public GlyphInTheFile(int Codepoint, int InkPixels)
	{
		this.Codepoint = Codepoint;
		this.InkPixels = InkPixels;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HF());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hf());
		P_0.Append(((object)Codepoint).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HG());
		P_0.Append(((object)InkPixels).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GlyphInTheFile left, GlyphInTheFile right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GlyphInTheFile left, GlyphInTheFile right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return EqualityComparer<int>.Default.GetHashCode(Codepoint) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(InkPixels);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is GlyphInTheFile)
		{
			return Equals((GlyphInTheFile)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(GlyphInTheFile other)
	{
		if (EqualityComparer<int>.Default.Equals(Codepoint, other.Codepoint))
		{
			return EqualityComparer<int>.Default.Equals(InkPixels, other.InkPixels);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out int Codepoint, out int InkPixels)
	{
		Codepoint = this.Codepoint;
		InkPixels = this.InkPixels;
	}
}
