using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class TranslationOutcome : IEquatable<TranslationOutcome>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TranslationOutcome);
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

	[field: CompilerGenerated]
	public string? Value
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public TranslationStatus Status
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<QualityIssue> Issues
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Attempts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public WrapResult? Wrapping
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool NoModelWasAsked
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ByModel
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fj());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fk());
		P_0.Append((object)Value);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FL());
		P_0.Append(((object)Status).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fl());
		P_0.Append((object)Issues);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FM());
		P_0.Append(((object)Attempts).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fm());
		P_0.Append((object)Wrapping);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FN());
		P_0.Append(((object)NoModelWasAsked).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BM());
		P_0.Append((object)ByModel);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TranslationOutcome? left, TranslationOutcome? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TranslationOutcome? left, TranslationOutcome? right)
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
		return (((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<SourceText>.Default.GetHashCode(Source)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value)) * -1521134295 + EqualityComparer<TranslationStatus>.Default.GetHashCode(Status)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<QualityIssue>>.Default.GetHashCode(Issues)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Attempts)) * -1521134295 + EqualityComparer<WrapResult>.Default.GetHashCode(Wrapping)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(NoModelWasAsked)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ByModel);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TranslationOutcome);
	}

	[CompilerGenerated]
	public bool Equals(TranslationOutcome? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<SourceText>.Default.Equals(Source, other.Source) && EqualityComparer<string>.Default.Equals(Value, other.Value) && EqualityComparer<TranslationStatus>.Default.Equals(Status, other.Status) && EqualityComparer<System.Collections.Generic.IReadOnlyList<QualityIssue>>.Default.Equals(Issues, other.Issues) && EqualityComparer<int>.Default.Equals(Attempts, other.Attempts) && EqualityComparer<WrapResult>.Default.Equals(Wrapping, other.Wrapping) && EqualityComparer<bool>.Default.Equals(NoModelWasAsked, other.NoModelWasAsked))
			{
				return EqualityComparer<string>.Default.Equals(ByModel, other.ByModel);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TranslationOutcome(TranslationOutcome original)
	{
		Source = original.Source;
		Value = original.Value;
		Status = original.Status;
		Issues = original.Issues;
		Attempts = original.Attempts;
		Wrapping = original.Wrapping;
		NoModelWasAsked = original.NoModelWasAsked;
		ByModel = original.ByModel;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TranslationOutcome()
	{
		Issues = System.Array.Empty<QualityIssue>();
		base._002Ector();
	}
}
