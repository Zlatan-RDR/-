using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class QualityIssue : IEquatable<QualityIssue>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(QualityIssue);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public QualityIssueKind Kind
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Message
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Blocking
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool AcceptedOnLastAttempt
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.en());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eO());
		P_0.Append(((object)Kind).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eo());
		P_0.Append((object)Message);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eP());
		P_0.Append(((object)Blocking).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ep());
		P_0.Append(((object)AcceptedOnLastAttempt).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(QualityIssue? left, QualityIssue? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(QualityIssue? left, QualityIssue? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<QualityIssueKind>.Default.GetHashCode(Kind)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Blocking)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AcceptedOnLastAttempt);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as QualityIssue);
	}

	[CompilerGenerated]
	public bool Equals(QualityIssue? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<QualityIssueKind>.Default.Equals(Kind, other.Kind) && EqualityComparer<string>.Default.Equals(Message, other.Message) && EqualityComparer<bool>.Default.Equals(Blocking, other.Blocking))
			{
				return EqualityComparer<bool>.Default.Equals(AcceptedOnLastAttempt, other.AcceptedOnLastAttempt);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private QualityIssue(QualityIssue P_0)
	{
		Kind = P_0.Kind;
		Message = P_0.Message;
		Blocking = P_0.Blocking;
		AcceptedOnLastAttempt = P_0.AcceptedOnLastAttempt;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public QualityIssue()
	{
		Blocking = true;
		base._002Ector();
	}
}
