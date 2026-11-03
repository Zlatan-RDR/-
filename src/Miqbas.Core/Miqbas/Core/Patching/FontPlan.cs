using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

[RequiredMember]
public sealed class FontPlan : IEquatable<FontPlan>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(FontPlan);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string BodyFontPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? HeadingFontPath
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LX());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lx());
		P_0.Append((object)BodyFontPath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LY());
		P_0.Append((object)HeadingFontPath);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(FontPlan? left, FontPlan? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(FontPlan? left, FontPlan? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BodyFontPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HeadingFontPath);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as FontPlan);
	}

	[CompilerGenerated]
	public bool Equals(FontPlan? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(BodyFontPath, other.BodyFontPath))
			{
				return EqualityComparer<string>.Default.Equals(HeadingFontPath, other.HeadingFontPath);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private FontPlan(FontPlan P_0)
	{
		BodyFontPath = P_0.BodyFontPath;
		HeadingFontPath = P_0.HeadingFontPath;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public FontPlan()
	{
	}
}
