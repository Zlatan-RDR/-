using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public sealed class TheBakedFaceRecord : IEquatable<TheBakedFaceRecord>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheBakedFaceRecord);
		}
	}

	[JsonPropertyName("pointSize")]
	[field: CompilerGenerated]
	public float PointSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("scale")]
	[field: CompilerGenerated]
	public float Scale
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("padding")]
	[field: CompilerGenerated]
	public int Padding
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("atlasWidth")]
	[field: CompilerGenerated]
	public int AtlasWidth
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("atlasHeight")]
	[field: CompilerGenerated]
	public int AtlasHeight
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("renderMode")]
	[field: CompilerGenerated]
	public int RenderMode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("lineHeight")]
	[field: CompilerGenerated]
	public float LineHeight
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("ascentLine")]
	[field: CompilerGenerated]
	public float AscentLine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("descentLine")]
	[field: CompilerGenerated]
	public float DescentLine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("baseline")]
	[field: CompilerGenerated]
	public float Baseline
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("glyphs")]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<ABakedGlyph> Glyphs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("characters")]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<ABakedCharacter> Characters
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iK());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ik());
		P_0.Append(((object)PointSize).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iL());
		P_0.Append(((object)Scale).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.il());
		P_0.Append(((object)Padding).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iM());
		P_0.Append(((object)AtlasWidth).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.im());
		P_0.Append(((object)AtlasHeight).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iN());
		P_0.Append(((object)RenderMode).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@in());
		P_0.Append(((object)LineHeight).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iO());
		P_0.Append(((object)AscentLine).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.io());
		P_0.Append(((object)DescentLine).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iP());
		P_0.Append(((object)Baseline).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ip());
		P_0.Append((object)Glyphs);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FP());
		P_0.Append((object)Characters);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheBakedFaceRecord? left, TheBakedFaceRecord? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheBakedFaceRecord? left, TheBakedFaceRecord? right)
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
		return (((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(PointSize)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Scale)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Padding)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AtlasWidth)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AtlasHeight)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RenderMode)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(LineHeight)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(AscentLine)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DescentLine)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Baseline)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<ABakedGlyph>>.Default.GetHashCode(Glyphs)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<ABakedCharacter>>.Default.GetHashCode(Characters);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheBakedFaceRecord);
	}

	[CompilerGenerated]
	public bool Equals(TheBakedFaceRecord? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<float>.Default.Equals(PointSize, other.PointSize) && EqualityComparer<float>.Default.Equals(Scale, other.Scale) && EqualityComparer<int>.Default.Equals(Padding, other.Padding) && EqualityComparer<int>.Default.Equals(AtlasWidth, other.AtlasWidth) && EqualityComparer<int>.Default.Equals(AtlasHeight, other.AtlasHeight) && EqualityComparer<int>.Default.Equals(RenderMode, other.RenderMode) && EqualityComparer<float>.Default.Equals(LineHeight, other.LineHeight) && EqualityComparer<float>.Default.Equals(AscentLine, other.AscentLine) && EqualityComparer<float>.Default.Equals(DescentLine, other.DescentLine) && EqualityComparer<float>.Default.Equals(Baseline, other.Baseline) && EqualityComparer<System.Collections.Generic.IReadOnlyList<ABakedGlyph>>.Default.Equals(Glyphs, other.Glyphs))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<ABakedCharacter>>.Default.Equals(Characters, other.Characters);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private TheBakedFaceRecord(TheBakedFaceRecord P_0)
	{
		PointSize = P_0.PointSize;
		Scale = P_0.Scale;
		Padding = P_0.Padding;
		AtlasWidth = P_0.AtlasWidth;
		AtlasHeight = P_0.AtlasHeight;
		RenderMode = P_0.RenderMode;
		LineHeight = P_0.LineHeight;
		AscentLine = P_0.AscentLine;
		DescentLine = P_0.DescentLine;
		Baseline = P_0.Baseline;
		Glyphs = P_0.Glyphs;
		Characters = P_0.Characters;
	}

	public TheBakedFaceRecord()
	{
		Scale = 1f;
		Glyphs = System.Array.Empty<ABakedGlyph>();
		Characters = System.Array.Empty<ABakedCharacter>();
		base._002Ector();
	}
}
