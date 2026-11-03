using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Engines;

namespace Miqbas.Core.Projects;

[RequiredMember]
public sealed class GameProject : IEquatable<GameProject>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(GameProject);
		}
	}

	[field: CompilerGenerated]
	public long Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string GamePath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string EngineId
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

	[RequiredMember]
	[field: CompilerGenerated]
	public string Fingerprint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string SourceLang
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string StyleProfile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? SteamAppId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public DateTimeOffset? JourneyLeftAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? JourneySkipped
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool GameLaysOutArabic
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ReadBy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool TakeTheCodeRoad
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public LineLength LineLength
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? LineWidth
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ArabicFace ArabicFace
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? VerifyOwedSince
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? CodeRoadLines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? ArabicCanBeDrawn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ArabicCannotBeDrawnBecause
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? OwnArabicConfirmed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool KeyAwaited
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long? DataBytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public DateTimeOffset CreatedAt
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kG());
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
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CL());
		P_0.Append(((object)Id).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kg());
		P_0.Append((object)Name);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kH());
		P_0.Append((object)GamePath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kh());
		P_0.Append((object)EngineId);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kI());
		P_0.Append((object)EngineVersion);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ki());
		P_0.Append((object)Fingerprint);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kJ());
		P_0.Append((object)SourceLang);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kj());
		P_0.Append((object)StyleProfile);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kK());
		P_0.Append((object)SteamAppId);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kk());
		P_0.Append(((object)JourneyLeftAt).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kL());
		P_0.Append((object)JourneySkipped);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kl());
		P_0.Append(((object)GameLaysOutArabic).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kM());
		P_0.Append((object)ReadBy);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.km());
		P_0.Append(((object)TakeTheCodeRoad).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kN());
		P_0.Append(((object)LineLength).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kn());
		P_0.Append(((object)LineWidth).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kO());
		P_0.Append(((object)ArabicFace).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ko());
		P_0.Append((object)VerifyOwedSince);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kP());
		P_0.Append(((object)CodeRoadLines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kp());
		P_0.Append(((object)ArabicCanBeDrawn).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kQ());
		P_0.Append((object)ArabicCannotBeDrawnBecause);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kq());
		P_0.Append(((object)OwnArabicConfirmed).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kR());
		P_0.Append(((object)KeyAwaited).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kr());
		P_0.Append(((object)DataBytes).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kS());
		DateTimeOffset createdAt = CreatedAt;
		P_0.Append(((object)(DateTimeOffset)(ref createdAt)).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GameProject? left, GameProject? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GameProject? left, GameProject? right)
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
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		return ((((((((((((((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GamePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fingerprint)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SourceLang)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StyleProfile)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SteamAppId)) * -1521134295 + EqualityComparer<DateTimeOffset?>.Default.GetHashCode(JourneyLeftAt)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JourneySkipped)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(GameLaysOutArabic)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReadBy)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(TakeTheCodeRoad)) * -1521134295 + EqualityComparer<LineLength>.Default.GetHashCode(LineLength)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(LineWidth)) * -1521134295 + EqualityComparer<ArabicFace>.Default.GetHashCode(ArabicFace)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VerifyOwedSince)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(CodeRoadLines)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(ArabicCanBeDrawn)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArabicCannotBeDrawnBecause)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(OwnArabicConfirmed)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(KeyAwaited)) * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(DataBytes)) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(CreatedAt);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as GameProject);
	}

	[CompilerGenerated]
	public bool Equals(GameProject? other)
	{
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<long>.Default.Equals(Id, other.Id) && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<string>.Default.Equals(GamePath, other.GamePath) && EqualityComparer<string>.Default.Equals(EngineId, other.EngineId) && EqualityComparer<string>.Default.Equals(EngineVersion, other.EngineVersion) && EqualityComparer<string>.Default.Equals(Fingerprint, other.Fingerprint) && EqualityComparer<string>.Default.Equals(SourceLang, other.SourceLang) && EqualityComparer<string>.Default.Equals(StyleProfile, other.StyleProfile) && EqualityComparer<string>.Default.Equals(SteamAppId, other.SteamAppId) && EqualityComparer<DateTimeOffset?>.Default.Equals(JourneyLeftAt, other.JourneyLeftAt) && EqualityComparer<string>.Default.Equals(JourneySkipped, other.JourneySkipped) && EqualityComparer<bool>.Default.Equals(GameLaysOutArabic, other.GameLaysOutArabic) && EqualityComparer<string>.Default.Equals(ReadBy, other.ReadBy) && EqualityComparer<bool>.Default.Equals(TakeTheCodeRoad, other.TakeTheCodeRoad) && EqualityComparer<LineLength>.Default.Equals(LineLength, other.LineLength) && EqualityComparer<int?>.Default.Equals(LineWidth, other.LineWidth) && EqualityComparer<ArabicFace>.Default.Equals(ArabicFace, other.ArabicFace) && EqualityComparer<string>.Default.Equals(VerifyOwedSince, other.VerifyOwedSince) && EqualityComparer<int?>.Default.Equals(CodeRoadLines, other.CodeRoadLines) && EqualityComparer<bool?>.Default.Equals(ArabicCanBeDrawn, other.ArabicCanBeDrawn) && EqualityComparer<string>.Default.Equals(ArabicCannotBeDrawnBecause, other.ArabicCannotBeDrawnBecause) && EqualityComparer<bool?>.Default.Equals(OwnArabicConfirmed, other.OwnArabicConfirmed) && EqualityComparer<bool>.Default.Equals(KeyAwaited, other.KeyAwaited) && EqualityComparer<long?>.Default.Equals(DataBytes, other.DataBytes))
			{
				return EqualityComparer<DateTimeOffset>.Default.Equals(CreatedAt, other.CreatedAt);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private GameProject(GameProject P_0)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		Id = P_0.Id;
		Name = P_0.Name;
		GamePath = P_0.GamePath;
		EngineId = P_0.EngineId;
		EngineVersion = P_0.EngineVersion;
		Fingerprint = P_0.Fingerprint;
		SourceLang = P_0.SourceLang;
		StyleProfile = P_0.StyleProfile;
		SteamAppId = P_0.SteamAppId;
		JourneyLeftAt = P_0.JourneyLeftAt;
		JourneySkipped = P_0.JourneySkipped;
		GameLaysOutArabic = P_0.GameLaysOutArabic;
		ReadBy = P_0.ReadBy;
		TakeTheCodeRoad = P_0.TakeTheCodeRoad;
		LineLength = P_0.LineLength;
		LineWidth = P_0.LineWidth;
		ArabicFace = P_0.ArabicFace;
		VerifyOwedSince = P_0.VerifyOwedSince;
		CodeRoadLines = P_0.CodeRoadLines;
		ArabicCanBeDrawn = P_0.ArabicCanBeDrawn;
		ArabicCannotBeDrawnBecause = P_0.ArabicCannotBeDrawnBecause;
		OwnArabicConfirmed = P_0.OwnArabicConfirmed;
		KeyAwaited = P_0.KeyAwaited;
		DataBytes = P_0.DataBytes;
		CreatedAt = P_0.CreatedAt;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public GameProject()
	{
		SourceLang = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CB();
		StyleProfile = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fb();
		base._002Ector();
	}
}
