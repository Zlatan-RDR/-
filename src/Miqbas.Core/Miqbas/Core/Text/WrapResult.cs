using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class WrapResult : IEquatable<WrapResult>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(WrapResult);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Lines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool HasUnbreakableOverflow
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool ExceedsMaxLines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string ToText()
	{
		return string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bk(), (System.Collections.Generic.IEnumerable<string>)Lines);
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hC());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hc());
		P_0.Append((object)Lines);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hD());
		P_0.Append(((object)HasUnbreakableOverflow).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hd());
		P_0.Append(((object)ExceedsMaxLines).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(WrapResult? left, WrapResult? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(WrapResult? left, WrapResult? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Lines)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(HasUnbreakableOverflow)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ExceedsMaxLines);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as WrapResult);
	}

	[CompilerGenerated]
	public bool Equals(WrapResult? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Lines, other.Lines) && EqualityComparer<bool>.Default.Equals(HasUnbreakableOverflow, other.HasUnbreakableOverflow))
			{
				return EqualityComparer<bool>.Default.Equals(ExceedsMaxLines, other.ExceedsMaxLines);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private WrapResult(WrapResult P_0)
	{
		Lines = P_0.Lines;
		HasUnbreakableOverflow = P_0.HasUnbreakableOverflow;
		ExceedsMaxLines = P_0.ExceedsMaxLines;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public WrapResult()
	{
	}
}
