using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class GlossaryEntry : IEquatable<GlossaryEntry>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(GlossaryEntry);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Term
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Translation
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public GlossaryKind Kind
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Locked
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cd());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CE());
		P_0.Append((object)Term);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ce());
		P_0.Append((object)Translation);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aE());
		P_0.Append(((object)Kind).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CF());
		P_0.Append(((object)Locked).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GlossaryEntry? left, GlossaryEntry? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GlossaryEntry? left, GlossaryEntry? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Term)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Translation)) * -1521134295 + EqualityComparer<GlossaryKind>.Default.GetHashCode(Kind)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Locked);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as GlossaryEntry);
	}

	[CompilerGenerated]
	public bool Equals(GlossaryEntry? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Term, other.Term) && EqualityComparer<string>.Default.Equals(Translation, other.Translation) && EqualityComparer<GlossaryKind>.Default.Equals(Kind, other.Kind))
			{
				return EqualityComparer<bool>.Default.Equals(Locked, other.Locked);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private GlossaryEntry(GlossaryEntry P_0)
	{
		Term = P_0.Term;
		Translation = P_0.Translation;
		Kind = P_0.Kind;
		Locked = P_0.Locked;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public GlossaryEntry()
	{
		Locked = true;
		base._002Ector();
	}
}
