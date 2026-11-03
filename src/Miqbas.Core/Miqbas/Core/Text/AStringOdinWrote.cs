using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class AStringOdinWrote : IEquatable<AStringOdinWrote>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(AStringOdinWrote);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Value
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Start
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Length
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iS());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@is());
		P_0.Append((object)Path);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fk());
		P_0.Append((object)Value);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iT());
		P_0.Append(((object)Start).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.it());
		P_0.Append(((object)Length).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(AStringOdinWrote? left, AStringOdinWrote? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(AStringOdinWrote? left, AStringOdinWrote? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Start)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Length);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as AStringOdinWrote);
	}

	[CompilerGenerated]
	public bool Equals(AStringOdinWrote? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<string>.Default.Equals(Value, other.Value) && EqualityComparer<int>.Default.Equals(Start, other.Start))
			{
				return EqualityComparer<int>.Default.Equals(Length, other.Length);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private AStringOdinWrote(AStringOdinWrote P_0)
	{
		Path = P_0.Path;
		Value = P_0.Value;
		Start = P_0.Start;
		Length = P_0.Length;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public AStringOdinWrote()
	{
	}
}
