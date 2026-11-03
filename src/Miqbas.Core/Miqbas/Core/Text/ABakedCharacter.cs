using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public sealed class ABakedCharacter : IEquatable<ABakedCharacter>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ABakedCharacter);
		}
	}

	[JsonPropertyName("unicode")]
	[field: CompilerGenerated]
	public int Unicode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("glyphIndex")]
	[field: CompilerGenerated]
	public int GlyphIndex
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ik());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IL());
		P_0.Append(((object)Unicode).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Il());
		P_0.Append(((object)GlyphIndex).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ABakedCharacter? left, ABakedCharacter? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ABakedCharacter? left, ABakedCharacter? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Unicode)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(GlyphIndex);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ABakedCharacter);
	}

	[CompilerGenerated]
	public bool Equals(ABakedCharacter? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Unicode, other.Unicode))
			{
				return EqualityComparer<int>.Default.Equals(GlyphIndex, other.GlyphIndex);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ABakedCharacter(ABakedCharacter P_0)
	{
		Unicode = P_0.Unicode;
		GlyphIndex = P_0.GlyphIndex;
	}

	public ABakedCharacter()
	{
	}
}
