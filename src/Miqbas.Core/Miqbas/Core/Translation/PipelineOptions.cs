using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

public sealed class PipelineOptions : IEquatable<PipelineOptions>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(PipelineOptions);
		}
	}

	[field: CompilerGenerated]
	public StyleProfile Style
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<GlossaryEntry> Glossary
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, CharacterCard> Characters
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? GameContext
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int BatchSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int MaxBatchCharacters
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int MaxAttempts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool ReportTotalProviderFailure
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool NeverWaitForABusyService
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int MaxConcurrentRequests
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, string> SettledTerms
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyCollection<string> GameCodes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? TheGameSpeaksOfAHeavenlyFaith
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool TheMemoryAnswersWordsThatStandApart
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool ReviewTheDialogue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public WrapConstraints? Wrapping
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public FontMetrics? Metrics
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fn());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FO());
		P_0.Append((object)Style);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fo());
		P_0.Append((object)Glossary);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FP());
		P_0.Append((object)Characters);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fp());
		P_0.Append((object)GameContext);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FQ());
		P_0.Append(((object)BatchSize).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fq());
		P_0.Append(((object)MaxBatchCharacters).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FR());
		P_0.Append(((object)MaxAttempts).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fr());
		P_0.Append(((object)ReportTotalProviderFailure).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FS());
		P_0.Append(((object)NeverWaitForABusyService).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fs());
		P_0.Append(((object)MaxConcurrentRequests).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FT());
		P_0.Append((object)SettledTerms);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ft());
		P_0.Append((object)GameCodes);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FU());
		P_0.Append(((object)TheGameSpeaksOfAHeavenlyFaith).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fu());
		P_0.Append(((object)TheMemoryAnswersWordsThatStandApart).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FV());
		P_0.Append(((object)ReviewTheDialogue).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fm());
		P_0.Append((object)Wrapping);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fv());
		P_0.Append((object)Metrics);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(PipelineOptions? left, PipelineOptions? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(PipelineOptions? left, PipelineOptions? right)
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
		return ((((((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<StyleProfile>.Default.GetHashCode(Style)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>.Default.GetHashCode(Glossary)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, CharacterCard>>.Default.GetHashCode(Characters)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameContext)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BatchSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxBatchCharacters)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxAttempts)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ReportTotalProviderFailure)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(NeverWaitForABusyService)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxConcurrentRequests)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, string>>.Default.GetHashCode(SettledTerms)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyCollection<string>>.Default.GetHashCode(GameCodes)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(TheGameSpeaksOfAHeavenlyFaith)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(TheMemoryAnswersWordsThatStandApart)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ReviewTheDialogue)) * -1521134295 + EqualityComparer<WrapConstraints>.Default.GetHashCode(Wrapping)) * -1521134295 + EqualityComparer<FontMetrics>.Default.GetHashCode(Metrics);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as PipelineOptions);
	}

	[CompilerGenerated]
	public bool Equals(PipelineOptions? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<StyleProfile>.Default.Equals(Style, other.Style) && EqualityComparer<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>.Default.Equals(Glossary, other.Glossary) && EqualityComparer<IReadOnlyDictionary<string, CharacterCard>>.Default.Equals(Characters, other.Characters) && EqualityComparer<string>.Default.Equals(GameContext, other.GameContext) && EqualityComparer<int>.Default.Equals(BatchSize, other.BatchSize) && EqualityComparer<int>.Default.Equals(MaxBatchCharacters, other.MaxBatchCharacters) && EqualityComparer<int>.Default.Equals(MaxAttempts, other.MaxAttempts) && EqualityComparer<bool>.Default.Equals(ReportTotalProviderFailure, other.ReportTotalProviderFailure) && EqualityComparer<bool>.Default.Equals(NeverWaitForABusyService, other.NeverWaitForABusyService) && EqualityComparer<int>.Default.Equals(MaxConcurrentRequests, other.MaxConcurrentRequests) && EqualityComparer<IReadOnlyDictionary<string, string>>.Default.Equals(SettledTerms, other.SettledTerms) && EqualityComparer<System.Collections.Generic.IReadOnlyCollection<string>>.Default.Equals(GameCodes, other.GameCodes) && EqualityComparer<bool?>.Default.Equals(TheGameSpeaksOfAHeavenlyFaith, other.TheGameSpeaksOfAHeavenlyFaith) && EqualityComparer<bool>.Default.Equals(TheMemoryAnswersWordsThatStandApart, other.TheMemoryAnswersWordsThatStandApart) && EqualityComparer<bool>.Default.Equals(ReviewTheDialogue, other.ReviewTheDialogue) && EqualityComparer<WrapConstraints>.Default.Equals(Wrapping, other.Wrapping))
			{
				return EqualityComparer<FontMetrics>.Default.Equals(Metrics, other.Metrics);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private PipelineOptions(PipelineOptions P_0)
	{
		Style = P_0.Style;
		Glossary = P_0.Glossary;
		Characters = P_0.Characters;
		GameContext = P_0.GameContext;
		BatchSize = P_0.BatchSize;
		MaxBatchCharacters = P_0.MaxBatchCharacters;
		MaxAttempts = P_0.MaxAttempts;
		ReportTotalProviderFailure = P_0.ReportTotalProviderFailure;
		NeverWaitForABusyService = P_0.NeverWaitForABusyService;
		MaxConcurrentRequests = P_0.MaxConcurrentRequests;
		SettledTerms = P_0.SettledTerms;
		GameCodes = P_0.GameCodes;
		TheGameSpeaksOfAHeavenlyFaith = P_0.TheGameSpeaksOfAHeavenlyFaith;
		TheMemoryAnswersWordsThatStandApart = P_0.TheMemoryAnswersWordsThatStandApart;
		ReviewTheDialogue = P_0.ReviewTheDialogue;
		Wrapping = P_0.Wrapping;
		Metrics = P_0.Metrics;
	}

	public PipelineOptions()
	{
		Style = StyleProfile.Default;
		Glossary = System.Array.Empty<GlossaryEntry>();
		Characters = (IReadOnlyDictionary<string, CharacterCard>)(object)new Dictionary<string, CharacterCard>();
		BatchSize = 20;
		MaxBatchCharacters = 2000;
		MaxAttempts = 3;
		ReportTotalProviderFailure = true;
		MaxConcurrentRequests = 1;
		SettledTerms = (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>();
		GameCodes = (System.Collections.Generic.IReadOnlyCollection<string>)(object)System.Array.Empty<string>();
		base._002Ector();
	}
}
