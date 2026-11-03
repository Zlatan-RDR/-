using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

[RequiredMember]
public sealed class DetectionResult : IEquatable<DetectionResult>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(DetectionResult);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool Matched
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Confidence
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? EngineVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Fingerprint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? GameName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public static DetectionResult NoMatch
	{
		[CompilerGenerated]
		get;
	} = new DetectionResult
	{
		Matched = false
	};


	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NS());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ns());
		P_0.Append(((object)Matched).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NT());
		P_0.Append(((object)Confidence).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kI());
		P_0.Append((object)EngineVersion);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ki());
		P_0.Append((object)Fingerprint);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lj());
		P_0.Append((object)GameName);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(DetectionResult? left, DetectionResult? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(DetectionResult? left, DetectionResult? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Matched)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Confidence)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fingerprint)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameName);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as DetectionResult);
	}

	[CompilerGenerated]
	public bool Equals(DetectionResult? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(Matched, other.Matched) && EqualityComparer<double>.Default.Equals(Confidence, other.Confidence) && EqualityComparer<string>.Default.Equals(EngineVersion, other.EngineVersion) && EqualityComparer<string>.Default.Equals(Fingerprint, other.Fingerprint))
			{
				return EqualityComparer<string>.Default.Equals(GameName, other.GameName);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private DetectionResult(DetectionResult original)
	{
		Matched = original.Matched;
		Confidence = original.Confidence;
		EngineVersion = original.EngineVersion;
		Fingerprint = original.Fingerprint;
		GameName = original.GameName;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public DetectionResult()
	{
	}
}
