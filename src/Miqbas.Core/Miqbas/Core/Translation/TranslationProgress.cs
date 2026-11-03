using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class TranslationProgress : IEquatable<TranslationProgress>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TranslationProgress);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Total
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Completed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int FromMemory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int NeedsReview
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int NotReached
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public TokenUsage Usage
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

	[field: CompilerGenerated]
	public ValueTuple<int, int>? AskingTheCommunity
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fk());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fL());
		P_0.Append(((object)Total).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fl());
		P_0.Append(((object)Completed).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fM());
		P_0.Append(((object)FromMemory).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fm());
		P_0.Append(((object)NeedsReview).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fN());
		P_0.Append(((object)NotReached).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fn());
		P_0.Append((object)Usage);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fO());
		P_0.Append((object)Note);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fo());
		P_0.Append(((object)AskingTheCommunity).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TranslationProgress? left, TranslationProgress? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TranslationProgress? left, TranslationProgress? right)
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
		return (((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Total)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Completed)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FromMemory)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NeedsReview)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NotReached)) * -1521134295 + EqualityComparer<TokenUsage>.Default.GetHashCode(Usage)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Note)) * -1521134295 + EqualityComparer<ValueTuple<int, int>?>.Default.GetHashCode(AskingTheCommunity);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TranslationProgress);
	}

	[CompilerGenerated]
	public bool Equals(TranslationProgress? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Total, other.Total) && EqualityComparer<int>.Default.Equals(Completed, other.Completed) && EqualityComparer<int>.Default.Equals(FromMemory, other.FromMemory) && EqualityComparer<int>.Default.Equals(NeedsReview, other.NeedsReview) && EqualityComparer<int>.Default.Equals(NotReached, other.NotReached) && EqualityComparer<TokenUsage>.Default.Equals(Usage, other.Usage) && EqualityComparer<string>.Default.Equals(Note, other.Note))
			{
				return EqualityComparer<ValueTuple<int, int>?>.Default.Equals(AskingTheCommunity, other.AskingTheCommunity);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TranslationProgress(TranslationProgress P_0)
	{
		Total = P_0.Total;
		Completed = P_0.Completed;
		FromMemory = P_0.FromMemory;
		NeedsReview = P_0.NeedsReview;
		NotReached = P_0.NotReached;
		Usage = P_0.Usage;
		Note = P_0.Note;
		AskingTheCommunity = P_0.AskingTheCommunity;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TranslationProgress()
	{
		Usage = TokenUsage.Empty;
		base._002Ector();
	}
}
