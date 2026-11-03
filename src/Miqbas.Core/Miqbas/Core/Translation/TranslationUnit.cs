using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class TranslationUnit : IEquatable<TranslationUnit>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TranslationUnit);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public SourceText Source
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public MaskedText Masked
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public CharacterCard? Speaker
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> NeighbouringLines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<QualityIssue> PreviousRefusals
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? UnderReview
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fP());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FK());
		P_0.Append((object)Source);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fp());
		P_0.Append((object)Masked);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fQ());
		P_0.Append((object)Speaker);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fq());
		P_0.Append((object)NeighbouringLines);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fR());
		P_0.Append((object)PreviousRefusals);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fr());
		P_0.Append((object)UnderReview);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TranslationUnit? left, TranslationUnit? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TranslationUnit? left, TranslationUnit? right)
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
		return (((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<SourceText>.Default.GetHashCode(Source)) * -1521134295 + EqualityComparer<MaskedText>.Default.GetHashCode(Masked)) * -1521134295 + EqualityComparer<CharacterCard>.Default.GetHashCode(Speaker)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(NeighbouringLines)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<QualityIssue>>.Default.GetHashCode(PreviousRefusals)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UnderReview);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TranslationUnit);
	}

	[CompilerGenerated]
	public bool Equals(TranslationUnit? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<SourceText>.Default.Equals(Source, other.Source) && EqualityComparer<MaskedText>.Default.Equals(Masked, other.Masked) && EqualityComparer<CharacterCard>.Default.Equals(Speaker, other.Speaker) && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(NeighbouringLines, other.NeighbouringLines) && EqualityComparer<System.Collections.Generic.IReadOnlyList<QualityIssue>>.Default.Equals(PreviousRefusals, other.PreviousRefusals))
			{
				return EqualityComparer<string>.Default.Equals(UnderReview, other.UnderReview);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TranslationUnit(TranslationUnit P_0)
	{
		Source = P_0.Source;
		Masked = P_0.Masked;
		Speaker = P_0.Speaker;
		NeighbouringLines = P_0.NeighbouringLines;
		PreviousRefusals = P_0.PreviousRefusals;
		UnderReview = P_0.UnderReview;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TranslationUnit()
	{
		NeighbouringLines = System.Array.Empty<string>();
		PreviousRefusals = System.Array.Empty<QualityIssue>();
		base._002Ector();
	}
}
