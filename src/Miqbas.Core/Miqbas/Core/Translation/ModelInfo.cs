using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class ModelInfo : IEquatable<ModelInfo>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ModelInfo);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string DisplayName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public ProviderTier Tier
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public decimal? InputPricePerMillionTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public decimal? OutputPricePerMillionTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool UsableWhileGameRunning
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? RequestsPerMinute
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? RequestsPerDay
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public TimeSpan? MinimumRequestGap
	{
		get
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			int? requestsPerMinute = RequestsPerMinute;
			if (!requestsPerMinute.HasValue || requestsPerMinute.GetValueOrDefault() <= 0)
			{
				return null;
			}
			return TimeSpan.FromSeconds(66.0 / (double)RequestsPerMinute.Value);
		}
	}

	[field: CompilerGenerated]
	public int? ContextWindowTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double? MeasuredStrength
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Unmeasured
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ck());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CL());
		P_0.Append((object)Id);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cl());
		P_0.Append((object)DisplayName);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CM());
		P_0.Append(((object)Tier).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cm());
		P_0.Append(((object)InputPricePerMillionTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CN());
		P_0.Append(((object)OutputPricePerMillionTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cn());
		P_0.Append(((object)UsableWhileGameRunning).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CO());
		P_0.Append(((object)RequestsPerMinute).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Co());
		P_0.Append(((object)RequestsPerDay).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CP());
		P_0.Append(((object)MinimumRequestGap).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cp());
		P_0.Append(((object)ContextWindowTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CQ());
		P_0.Append(((object)MeasuredStrength).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cq());
		P_0.Append(((object)Unmeasured).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ModelInfo? left, ModelInfo? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ModelInfo? left, ModelInfo? right)
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
		return ((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<ProviderTier>.Default.GetHashCode(Tier)) * -1521134295 + EqualityComparer<decimal?>.Default.GetHashCode(InputPricePerMillionTokens)) * -1521134295 + EqualityComparer<decimal?>.Default.GetHashCode(OutputPricePerMillionTokens)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(UsableWhileGameRunning)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(RequestsPerMinute)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(RequestsPerDay)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(ContextWindowTokens)) * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(MeasuredStrength)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Unmeasured);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ModelInfo);
	}

	[CompilerGenerated]
	public bool Equals(ModelInfo? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other.Id) && EqualityComparer<string>.Default.Equals(DisplayName, other.DisplayName) && EqualityComparer<ProviderTier>.Default.Equals(Tier, other.Tier) && EqualityComparer<decimal?>.Default.Equals(InputPricePerMillionTokens, other.InputPricePerMillionTokens) && EqualityComparer<decimal?>.Default.Equals(OutputPricePerMillionTokens, other.OutputPricePerMillionTokens) && EqualityComparer<bool>.Default.Equals(UsableWhileGameRunning, other.UsableWhileGameRunning) && EqualityComparer<int?>.Default.Equals(RequestsPerMinute, other.RequestsPerMinute) && EqualityComparer<int?>.Default.Equals(RequestsPerDay, other.RequestsPerDay) && EqualityComparer<int?>.Default.Equals(ContextWindowTokens, other.ContextWindowTokens) && EqualityComparer<double?>.Default.Equals(MeasuredStrength, other.MeasuredStrength))
			{
				return EqualityComparer<bool>.Default.Equals(Unmeasured, other.Unmeasured);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ModelInfo(ModelInfo P_0)
	{
		Id = P_0.Id;
		DisplayName = P_0.DisplayName;
		Tier = P_0.Tier;
		InputPricePerMillionTokens = P_0.InputPricePerMillionTokens;
		OutputPricePerMillionTokens = P_0.OutputPricePerMillionTokens;
		UsableWhileGameRunning = P_0.UsableWhileGameRunning;
		RequestsPerMinute = P_0.RequestsPerMinute;
		RequestsPerDay = P_0.RequestsPerDay;
		ContextWindowTokens = P_0.ContextWindowTokens;
		MeasuredStrength = P_0.MeasuredStrength;
		Unmeasured = P_0.Unmeasured;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ModelInfo()
	{
		UsableWhileGameRunning = true;
		base._002Ector();
	}
}
