using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

[RequiredMember]
public sealed class BootJudgement : IEquatable<BootJudgement>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(BootJudgement);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public BootVerdict Verdict
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

	[RequiredMember]
	[field: CompilerGenerated]
	public string Because
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool EndedUnseen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool RollBack
	{
		get
		{
			BootVerdict verdict = Verdict;
			if ((uint)verdict <= 1u)
			{
				return true;
			}
			return false;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PC());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pc());
		P_0.Append(((object)Verdict).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eo());
		P_0.Append((object)Message);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HI());
		P_0.Append((object)Because);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PD());
		P_0.Append(((object)EndedUnseen).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pd());
		P_0.Append(((object)RollBack).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(BootJudgement? left, BootJudgement? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(BootJudgement? left, BootJudgement? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<BootVerdict>.Default.GetHashCode(Verdict)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Because)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(EndedUnseen);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BootJudgement);
	}

	[CompilerGenerated]
	public bool Equals(BootJudgement? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<BootVerdict>.Default.Equals(Verdict, other.Verdict) && EqualityComparer<string>.Default.Equals(Message, other.Message) && EqualityComparer<string>.Default.Equals(Because, other.Because))
			{
				return EqualityComparer<bool>.Default.Equals(EndedUnseen, other.EndedUnseen);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private BootJudgement(BootJudgement P_0)
	{
		Verdict = P_0.Verdict;
		Message = P_0.Message;
		Because = P_0.Because;
		EndedUnseen = P_0.EndedUnseen;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BootJudgement()
	{
	}
}
