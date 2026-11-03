using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class CostEstimate : IEquatable<CostEstimate>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(CostEstimate);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public ModelInfo Model
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int TotalStrings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int BillableStrings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int EstimatedInputTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int EstimatedOutputTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public decimal? EstimatedCostUsd
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int SavedByDuplication
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int SavedByMemory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ReviewedStrings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool IsFree
	{
		get
		{
			decimal? estimatedCostUsd = EstimatedCostUsd;
			if (!estimatedCostUsd.HasValue || estimatedCostUsd.GetValueOrDefault() == 0m)
			{
				return true;
			}
			return false;
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Requests
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool ExceedsDailyAllowance
	{
		get
		{
			int? requestsPerDay = Model.RequestsPerDay;
			if (requestsPerDay.HasValue)
			{
				int valueOrDefault = requestsPerDay.GetValueOrDefault();
				return Requests > valueOrDefault;
			}
			return false;
		}
	}

	[field: CompilerGenerated]
	public double? MeasuredTextsPerMinute
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public TimeSpan? EstimatedDuration => RunTime.For(BillableStrings + ReviewedStrings, Requests, Model.MinimumRequestGap, MeasuredTextsPerMinute);

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ay());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aZ());
		P_0.Append((object)Model);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.az());
		P_0.Append(((object)TotalStrings).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BA());
		P_0.Append(((object)BillableStrings).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ba());
		P_0.Append(((object)EstimatedInputTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BB());
		P_0.Append(((object)EstimatedOutputTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bb());
		P_0.Append(((object)EstimatedCostUsd).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BC());
		P_0.Append(((object)SavedByDuplication).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bc());
		P_0.Append(((object)SavedByMemory).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BD());
		P_0.Append(((object)ReviewedStrings).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bd());
		P_0.Append(((object)IsFree).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BE());
		P_0.Append(((object)Requests).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Be());
		P_0.Append(((object)ExceedsDailyAllowance).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BF());
		P_0.Append(((object)MeasuredTextsPerMinute).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bf());
		P_0.Append(((object)EstimatedDuration).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(CostEstimate? left, CostEstimate? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(CostEstimate? left, CostEstimate? right)
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
		return ((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ModelInfo>.Default.GetHashCode(Model)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(TotalStrings)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BillableStrings)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(EstimatedInputTokens)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(EstimatedOutputTokens)) * -1521134295 + EqualityComparer<decimal?>.Default.GetHashCode(EstimatedCostUsd)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SavedByDuplication)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SavedByMemory)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ReviewedStrings)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Requests)) * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(MeasuredTextsPerMinute);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as CostEstimate);
	}

	[CompilerGenerated]
	public bool Equals(CostEstimate? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<ModelInfo>.Default.Equals(Model, other.Model) && EqualityComparer<int>.Default.Equals(TotalStrings, other.TotalStrings) && EqualityComparer<int>.Default.Equals(BillableStrings, other.BillableStrings) && EqualityComparer<int>.Default.Equals(EstimatedInputTokens, other.EstimatedInputTokens) && EqualityComparer<int>.Default.Equals(EstimatedOutputTokens, other.EstimatedOutputTokens) && EqualityComparer<decimal?>.Default.Equals(EstimatedCostUsd, other.EstimatedCostUsd) && EqualityComparer<int>.Default.Equals(SavedByDuplication, other.SavedByDuplication) && EqualityComparer<int>.Default.Equals(SavedByMemory, other.SavedByMemory) && EqualityComparer<int>.Default.Equals(ReviewedStrings, other.ReviewedStrings) && EqualityComparer<int>.Default.Equals(Requests, other.Requests))
			{
				return EqualityComparer<double?>.Default.Equals(MeasuredTextsPerMinute, other.MeasuredTextsPerMinute);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private CostEstimate(CostEstimate P_0)
	{
		Model = P_0.Model;
		TotalStrings = P_0.TotalStrings;
		BillableStrings = P_0.BillableStrings;
		EstimatedInputTokens = P_0.EstimatedInputTokens;
		EstimatedOutputTokens = P_0.EstimatedOutputTokens;
		EstimatedCostUsd = P_0.EstimatedCostUsd;
		SavedByDuplication = P_0.SavedByDuplication;
		SavedByMemory = P_0.SavedByMemory;
		ReviewedStrings = P_0.ReviewedStrings;
		Requests = P_0.Requests;
		MeasuredTextsPerMinute = P_0.MeasuredTextsPerMinute;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CostEstimate()
	{
	}
}
