using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

[RequiredMember]
public sealed class AdaptiveRequirements : IEquatable<AdaptiveRequirements>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(AdaptiveRequirements);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool NeedsInternetOnce
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool AppliesOnGameRestart
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Note
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ny());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nZ());
		P_0.Append(((object)NeedsInternetOnce).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nz());
		P_0.Append(((object)AppliesOnGameRestart).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fO());
		P_0.Append((object)Note);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(AdaptiveRequirements? left, AdaptiveRequirements? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(AdaptiveRequirements? left, AdaptiveRequirements? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(NeedsInternetOnce)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AppliesOnGameRestart)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Note);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as AdaptiveRequirements);
	}

	[CompilerGenerated]
	public bool Equals(AdaptiveRequirements? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(NeedsInternetOnce, other.NeedsInternetOnce) && EqualityComparer<bool>.Default.Equals(AppliesOnGameRestart, other.AppliesOnGameRestart))
			{
				return EqualityComparer<string>.Default.Equals(Note, other.Note);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private AdaptiveRequirements(AdaptiveRequirements original)
	{
		NeedsInternetOnce = original.NeedsInternetOnce;
		AppliesOnGameRestart = original.AppliesOnGameRestart;
		Note = original.Note;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public AdaptiveRequirements()
	{
	}
}
