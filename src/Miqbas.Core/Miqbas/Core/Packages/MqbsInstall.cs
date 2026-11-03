using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Packages;

[RequiredMember]
public sealed class MqbsInstall : IEquatable<MqbsInstall>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(MqbsInstall);
		}
	}

	[RequiredMember]
	[JsonPropertyName("method")]
	[field: CompilerGenerated]
	public string Method
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("engineId")]
	[field: CompilerGenerated]
	public string EngineId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool IsRuntimeLayer => Method == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lG();

	public static MqbsInstall FullPatchFor(string engineId)
	{
		return new MqbsInstall
		{
			Method = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lf(),
			EngineId = engineId
		};
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lg());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lH());
		P_0.Append((object)Method);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kh());
		P_0.Append((object)EngineId);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lh());
		P_0.Append(((object)IsRuntimeLayer).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(MqbsInstall? left, MqbsInstall? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(MqbsInstall? left, MqbsInstall? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Method)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineId);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as MqbsInstall);
	}

	[CompilerGenerated]
	public bool Equals(MqbsInstall? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Method, other.Method))
			{
				return EqualityComparer<string>.Default.Equals(EngineId, other.EngineId);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private MqbsInstall(MqbsInstall P_0)
	{
		Method = P_0.Method;
		EngineId = P_0.EngineId;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MqbsInstall()
	{
	}
}
