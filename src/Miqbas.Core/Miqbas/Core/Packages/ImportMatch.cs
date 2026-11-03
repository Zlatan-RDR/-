using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Packages;

[RequiredMember]
public sealed class ImportMatch : IEquatable<ImportMatch>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ImportMatch);
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
	public MatchQuality Quality
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Translation
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mP());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mp());
		P_0.Append(((object)Quality).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ce());
		P_0.Append((object)Translation);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ImportMatch? left, ImportMatch? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ImportMatch? left, ImportMatch? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<SourceText>.Default.GetHashCode(Source)) * -1521134295 + EqualityComparer<MatchQuality>.Default.GetHashCode(Quality)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Translation);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ImportMatch);
	}

	[CompilerGenerated]
	public bool Equals(ImportMatch? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<SourceText>.Default.Equals(Source, other.Source) && EqualityComparer<MatchQuality>.Default.Equals(Quality, other.Quality))
			{
				return EqualityComparer<string>.Default.Equals(Translation, other.Translation);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ImportMatch(ImportMatch P_0)
	{
		Source = P_0.Source;
		Quality = P_0.Quality;
		Translation = P_0.Translation;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ImportMatch()
	{
	}
}
