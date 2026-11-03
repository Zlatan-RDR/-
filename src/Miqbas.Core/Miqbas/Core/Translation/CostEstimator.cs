using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Translation;

public static class CostEstimator
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, bool> _003C_003E9__3_0;

		public static Func<string, long> _003C_003E9__3_2;

		public static Func<string, int> _003C_003E9__3_3;

		public static Func<string, long> _003C_003E9__3_4;

		internal bool A(string P_0)
		{
			if (!Untranslatable.Is(P_0))
			{
				return !Untranslatable.IsFiller(P_0);
			}
			return false;
		}

		internal long a(string P_0)
		{
			return P_0.Length;
		}

		internal int B(string P_0)
		{
			return P_0.Length;
		}

		internal long b(string P_0)
		{
			return P_0.Length;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public ITranslationMemory memory;

		internal bool A(string P_0)
		{
			return memory.Lookup(P_0) == null;
		}
	}

	private const double SourceCharsPerToken = 3.5;

	private const double ArabicCharsPerToken = 2.2;

	private const int PromptOverheadTokensPerBatch = 900;

	public static CostEstimate Estimate(System.Collections.Generic.IReadOnlyList<string> sourceTexts, ModelInfo model, ITranslationMemory? memory = null, int batchSize = 20, double? measuredTextsPerMinute = null, System.Collections.Generic.IReadOnlyCollection<string>? reviewed = null)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		ITranslationMemory memory2 = memory;
		int count = ((System.Collections.Generic.IReadOnlyCollection<string>)sourceTexts).Count;
		List<string> obj = Enumerable.ToList<string>(Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)sourceTexts, (Func<string, bool>)((string P_0) => !Untranslatable.Is(P_0) && !Untranslatable.IsFiller(P_0))));
		List<string> val = Enumerable.ToList<string>(Enumerable.Distinct<string>((System.Collections.Generic.IEnumerable<string>)obj, (IEqualityComparer<string>)(object)StringComparer.Ordinal));
		int savedByDuplication = obj.Count - val.Count;
		List<string> val2 = ((memory2 == null) ? val : Enumerable.ToList<string>(Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => memory2.Lookup(P_0) == null))));
		int savedByMemory = val.Count - val2.Count;
		long num = Enumerable.Sum<string>((System.Collections.Generic.IEnumerable<string>)val2, (Func<string, long>)((string P_0) => P_0.Length));
		ValueTuple<int?, int?> val3 = BatchLimits.ForContextWindow(model.ContextWindowTokens);
		int? item = val3.Item1;
		int? item2 = val3.Item2;
		List<System.Collections.Generic.IReadOnlyList<string>> val4 = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<string>>(BatchLimits.Plan((System.Collections.Generic.IEnumerable<string>)val2, item.GetValueOrDefault(batchSize), item2.GetValueOrDefault(2000), (string P_0) => P_0.Length));
		int count2 = val4.Count;
		int num2 = (int)((double)num / 3.5) + count2 * 900;
		int num3 = (int)((double)num * 1.1 / 2.2);
		IReadOnlySet<string> val5 = (IReadOnlySet<string>)((reviewed != null && reviewed.Count > 0) ? (((object)(reviewed as IReadOnlySet<string>)) ?? ((object)new HashSet<string>((System.Collections.Generic.IEnumerable<string>)reviewed, (IEqualityComparer<string>)(object)StringComparer.Ordinal))) : null);
		int num4 = 0;
		int num5 = 0;
		long num6 = 0L;
		Enumerator<System.Collections.Generic.IReadOnlyList<string>> enumerator = ((val5 == null) ? new List<System.Collections.Generic.IReadOnlyList<string>>() : val4).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				List<string> val6 = Enumerable.ToList<string>(Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)enumerator.Current, (Func<string, bool>)val5.Contains));
				if (val6.Count > 0)
				{
					num4++;
					num5 += val6.Count;
					num6 += Enumerable.Sum<string>((System.Collections.Generic.IEnumerable<string>)val6, (Func<string, long>)((string P_0) => P_0.Length));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		num2 += (int)((double)num6 / 3.5 + (double)num6 * 1.1 / 2.2) + num4 * 900;
		num3 += (int)((double)num6 * 1.1 / 2.2);
		decimal? estimatedCostUsd = null;
		decimal? inputPricePerMillionTokens = model.InputPricePerMillionTokens;
		if (inputPricePerMillionTokens.HasValue)
		{
			decimal valueOrDefault = inputPricePerMillionTokens.GetValueOrDefault();
			inputPricePerMillionTokens = model.OutputPricePerMillionTokens;
			if (inputPricePerMillionTokens.HasValue)
			{
				decimal valueOrDefault2 = inputPricePerMillionTokens.GetValueOrDefault();
				estimatedCostUsd = decimal.op_Implicit(num2) / 1000000m * valueOrDefault + decimal.op_Implicit(num3) / 1000000m * valueOrDefault2;
			}
		}
		return new CostEstimate
		{
			Model = model,
			TotalStrings = count,
			BillableStrings = val2.Count,
			EstimatedInputTokens = num2,
			EstimatedOutputTokens = num3,
			EstimatedCostUsd = estimatedCostUsd,
			SavedByDuplication = savedByDuplication,
			SavedByMemory = savedByMemory,
			ReviewedStrings = num5,
			Requests = count2 + num4,
			MeasuredTextsPerMinute = measuredTextsPerMinute
		};
	}
}
