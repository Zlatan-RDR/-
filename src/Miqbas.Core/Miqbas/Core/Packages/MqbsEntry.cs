using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Packages;

[RequiredMember]
public sealed class MqbsEntry : IEquatable<MqbsEntry>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(MqbsEntry);
		}
	}

	[RequiredMember]
	[JsonPropertyName("key")]
	[field: CompilerGenerated]
	public string Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("source")]
	[field: CompilerGenerated]
	public string Source
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("target")]
	[field: CompilerGenerated]
	public string Target
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("reviewed")]
	[field: CompilerGenerated]
	public bool Reviewed
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lM());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hZ());
		P_0.Append((object)Key);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lm());
		P_0.Append((object)Source);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lN());
		P_0.Append((object)Target);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ln());
		P_0.Append(((object)Reviewed).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(MqbsEntry? left, MqbsEntry? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(MqbsEntry? left, MqbsEntry? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Target)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Reviewed);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as MqbsEntry);
	}

	[CompilerGenerated]
	public bool Equals(MqbsEntry? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Key, other.Key) && EqualityComparer<string>.Default.Equals(Source, other.Source) && EqualityComparer<string>.Default.Equals(Target, other.Target))
			{
				return EqualityComparer<bool>.Default.Equals(Reviewed, other.Reviewed);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private MqbsEntry(MqbsEntry P_0)
	{
		Key = P_0.Key;
		Source = P_0.Source;
		Target = P_0.Target;
		Reviewed = P_0.Reviewed;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MqbsEntry()
	{
	}
}
