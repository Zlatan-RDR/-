using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public sealed class ABakedGlyph : IEquatable<ABakedGlyph>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ABakedGlyph);
		}
	}

	[JsonPropertyName("index")]
	[field: CompilerGenerated]
	public int Index
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("x")]
	[field: CompilerGenerated]
	public int X
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("y")]
	[field: CompilerGenerated]
	public int Y
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("w")]
	[field: CompilerGenerated]
	public int W
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("h")]
	[field: CompilerGenerated]
	public int H
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("width")]
	[field: CompilerGenerated]
	public float Width
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("height")]
	[field: CompilerGenerated]
	public float Height
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("bearingX")]
	[field: CompilerGenerated]
	public float BearingX
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("bearingY")]
	[field: CompilerGenerated]
	public float BearingY
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("advance")]
	[field: CompilerGenerated]
	public float Advance
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IF());
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
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.If());
		P_0.Append(((object)Index).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IG());
		P_0.Append(((object)X).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ig());
		P_0.Append(((object)Y).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IH());
		P_0.Append(((object)W).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ih());
		P_0.Append(((object)H).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.II());
		P_0.Append(((object)Width).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ii());
		P_0.Append(((object)Height).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IJ());
		P_0.Append(((object)BearingX).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ij());
		P_0.Append(((object)BearingY).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IK());
		P_0.Append(((object)Advance).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ABakedGlyph? left, ABakedGlyph? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ABakedGlyph? left, ABakedGlyph? right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Index)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(X)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Y)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(W)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(H)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Width)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Height)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BearingX)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BearingY)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Advance);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ABakedGlyph);
	}

	[CompilerGenerated]
	public bool Equals(ABakedGlyph? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Index, other.Index) && EqualityComparer<int>.Default.Equals(X, other.X) && EqualityComparer<int>.Default.Equals(Y, other.Y) && EqualityComparer<int>.Default.Equals(W, other.W) && EqualityComparer<int>.Default.Equals(H, other.H) && EqualityComparer<float>.Default.Equals(Width, other.Width) && EqualityComparer<float>.Default.Equals(Height, other.Height) && EqualityComparer<float>.Default.Equals(BearingX, other.BearingX) && EqualityComparer<float>.Default.Equals(BearingY, other.BearingY))
			{
				return EqualityComparer<float>.Default.Equals(Advance, other.Advance);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ABakedGlyph(ABakedGlyph P_0)
	{
		Index = P_0.Index;
		X = P_0.X;
		Y = P_0.Y;
		W = P_0.W;
		H = P_0.H;
		Width = P_0.Width;
		Height = P_0.Height;
		BearingX = P_0.BearingX;
		BearingY = P_0.BearingY;
		Advance = P_0.Advance;
	}

	public ABakedGlyph()
	{
	}
}
