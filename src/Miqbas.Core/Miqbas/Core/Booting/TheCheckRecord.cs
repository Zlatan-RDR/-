using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

[RequiredMember]
public sealed class TheCheckRecord : IEquatable<TheCheckRecord>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheCheckRecord);
		}
	}

	[RequiredMember]
	[JsonPropertyName("at")]
	[field: CompilerGenerated]
	public DateTimeOffset At
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("miqbas")]
	[field: CompilerGenerated]
	public string MiqbasVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("game")]
	[field: CompilerGenerated]
	public string Game
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("steamAppId")]
	[field: CompilerGenerated]
	public string? SteamAppId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("engine")]
	[field: CompilerGenerated]
	public string? Engine
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
	public string? EngineVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("road")]
	[field: CompilerGenerated]
	public string? Road
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("installed")]
	[field: CompilerGenerated]
	public int Installed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("drawn")]
	[field: CompilerGenerated]
	public int? Drawn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("answered")]
	[field: CompilerGenerated]
	public int? Answered
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("atLeast")]
	[field: CompilerGenerated]
	public bool AtLeast
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("verdict")]
	[field: CompilerGenerated]
	public string? Verdict
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("rolledBack")]
	[field: CompilerGenerated]
	public bool RolledBack
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("whatThePlayerSaw")]
	[field: CompilerGenerated]
	public WhatThePlayerSaw WhatThePlayerSaw
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("measuredBecause")]
	[field: CompilerGenerated]
	public string? MeasuredBecause
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("measuredVerdict")]
	[field: CompilerGenerated]
	public string? MeasuredVerdict
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonIgnore]
	public bool HeSawWhatTheMachineDenied
	{
		get
		{
			if (WhatThePlayerSaw == WhatThePlayerSaw.NotAsked && Verdict == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qf())
			{
				return MeasuredVerdict == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QG();
			}
			return false;
		}
	}

	[JsonPropertyName("tookTheCodeRoad")]
	[field: CompilerGenerated]
	public bool TookTheCodeRoad
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("codeRoadLines")]
	[field: CompilerGenerated]
	public int? CodeRoadLines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("askedOnReturn")]
	[field: CompilerGenerated]
	public bool AskedOnReturn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("heSawArabic")]
	[field: CompilerGenerated]
	public bool? HeSawArabic
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("writtenFiles")]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string>? WrittenFiles
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonIgnore]
	public int? Gap
	{
		get
		{
			int? drawn = Drawn;
			if (drawn.HasValue)
			{
				int valueOrDefault = drawn.GetValueOrDefault();
				drawn = Answered;
				if (drawn.HasValue)
				{
					int valueOrDefault2 = drawn.GetValueOrDefault();
					return (valueOrDefault > valueOrDefault2) ? (valueOrDefault - valueOrDefault2) : 0;
				}
			}
			return null;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qg());
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QH());
		DateTimeOffset at = At;
		P_0.Append(((object)(DateTimeOffset)(ref at)).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qh());
		P_0.Append((object)MiqbasVersion);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QI());
		P_0.Append((object)Game);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kK());
		P_0.Append((object)SteamAppId);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qi());
		P_0.Append((object)Engine);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ki());
		P_0.Append((object)Fingerprint);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kI());
		P_0.Append((object)EngineVersion);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QJ());
		P_0.Append((object)Road);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qj());
		P_0.Append(((object)Installed).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QK());
		P_0.Append(((object)Drawn).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qk());
		P_0.Append(((object)Answered).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QL());
		P_0.Append(((object)AtLeast).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ql());
		P_0.Append((object)Verdict);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QM());
		P_0.Append(((object)RolledBack).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qm());
		P_0.Append(((object)WhatThePlayerSaw).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QN());
		P_0.Append((object)MeasuredBecause);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qn());
		P_0.Append((object)MeasuredVerdict);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QO());
		P_0.Append(((object)HeSawWhatTheMachineDenied).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qo());
		P_0.Append(((object)TookTheCodeRoad).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kP());
		P_0.Append(((object)CodeRoadLines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QP());
		P_0.Append(((object)AskedOnReturn).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qp());
		P_0.Append(((object)HeSawArabic).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QQ());
		P_0.Append((object)WrittenFiles);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qq());
		P_0.Append(((object)Gap).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheCheckRecord? left, TheCheckRecord? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheCheckRecord? left, TheCheckRecord? right)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		return (((((((((((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(At)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiqbasVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Game)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SteamAppId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Engine)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fingerprint)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Road)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Installed)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Drawn)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Answered)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AtLeast)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Verdict)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(RolledBack)) * -1521134295 + EqualityComparer<WhatThePlayerSaw>.Default.GetHashCode(WhatThePlayerSaw)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MeasuredBecause)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MeasuredVerdict)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(TookTheCodeRoad)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(CodeRoadLines)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AskedOnReturn)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(HeSawArabic)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(WrittenFiles);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheCheckRecord);
	}

	[CompilerGenerated]
	public bool Equals(TheCheckRecord? other)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<DateTimeOffset>.Default.Equals(At, other.At) && EqualityComparer<string>.Default.Equals(MiqbasVersion, other.MiqbasVersion) && EqualityComparer<string>.Default.Equals(Game, other.Game) && EqualityComparer<string>.Default.Equals(SteamAppId, other.SteamAppId) && EqualityComparer<string>.Default.Equals(Engine, other.Engine) && EqualityComparer<string>.Default.Equals(Fingerprint, other.Fingerprint) && EqualityComparer<string>.Default.Equals(EngineVersion, other.EngineVersion) && EqualityComparer<string>.Default.Equals(Road, other.Road) && EqualityComparer<int>.Default.Equals(Installed, other.Installed) && EqualityComparer<int?>.Default.Equals(Drawn, other.Drawn) && EqualityComparer<int?>.Default.Equals(Answered, other.Answered) && EqualityComparer<bool>.Default.Equals(AtLeast, other.AtLeast) && EqualityComparer<string>.Default.Equals(Verdict, other.Verdict) && EqualityComparer<bool>.Default.Equals(RolledBack, other.RolledBack) && EqualityComparer<WhatThePlayerSaw>.Default.Equals(WhatThePlayerSaw, other.WhatThePlayerSaw) && EqualityComparer<string>.Default.Equals(MeasuredBecause, other.MeasuredBecause) && EqualityComparer<string>.Default.Equals(MeasuredVerdict, other.MeasuredVerdict) && EqualityComparer<bool>.Default.Equals(TookTheCodeRoad, other.TookTheCodeRoad) && EqualityComparer<int?>.Default.Equals(CodeRoadLines, other.CodeRoadLines) && EqualityComparer<bool>.Default.Equals(AskedOnReturn, other.AskedOnReturn) && EqualityComparer<bool?>.Default.Equals(HeSawArabic, other.HeSawArabic))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(WrittenFiles, other.WrittenFiles);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TheCheckRecord(TheCheckRecord original)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		At = original.At;
		MiqbasVersion = original.MiqbasVersion;
		Game = original.Game;
		SteamAppId = original.SteamAppId;
		Engine = original.Engine;
		Fingerprint = original.Fingerprint;
		EngineVersion = original.EngineVersion;
		Road = original.Road;
		Installed = original.Installed;
		Drawn = original.Drawn;
		Answered = original.Answered;
		AtLeast = original.AtLeast;
		Verdict = original.Verdict;
		RolledBack = original.RolledBack;
		WhatThePlayerSaw = original.WhatThePlayerSaw;
		MeasuredBecause = original.MeasuredBecause;
		MeasuredVerdict = original.MeasuredVerdict;
		TookTheCodeRoad = original.TookTheCodeRoad;
		CodeRoadLines = original.CodeRoadLines;
		AskedOnReturn = original.AskedOnReturn;
		HeSawArabic = original.HeSawArabic;
		WrittenFiles = original.WrittenFiles;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TheCheckRecord()
	{
	}
}
