using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Packages;

[RequiredMember]
public sealed class MqbsManifest : IEquatable<MqbsManifest>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(MqbsManifest);
		}
	}

	[JsonPropertyName("mqbsVersion")]
	[field: CompilerGenerated]
	public int MqbsVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("gameFingerprint")]
	[field: CompilerGenerated]
	public string GameFingerprint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("gameName")]
	[field: CompilerGenerated]
	public string? GameName
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

	[JsonPropertyName("engineVersion")]
	[field: CompilerGenerated]
	public string? EngineVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("coverage")]
	[field: CompilerGenerated]
	public double Coverage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("translatedCount")]
	[field: CompilerGenerated]
	public int TranslatedCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("humanReviewed")]
	[field: CompilerGenerated]
	public double HumanReviewed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("author")]
	[field: CompilerGenerated]
	public string? Author
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("createdAt")]
	[field: CompilerGenerated]
	public DateTimeOffset CreatedAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("sourceLang")]
	[field: CompilerGenerated]
	public string SourceLang
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("styleProfile")]
	[field: CompilerGenerated]
	public string StyleProfile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("fonts")]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Fonts
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lI());
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
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.li());
		P_0.Append(((object)MqbsVersion).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lJ());
		P_0.Append((object)GameFingerprint);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lj());
		P_0.Append((object)GameName);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kh());
		P_0.Append((object)EngineId);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kI());
		P_0.Append((object)EngineVersion);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lK());
		P_0.Append(((object)Coverage).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lk());
		P_0.Append(((object)TranslatedCount).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lL());
		P_0.Append(((object)HumanReviewed).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ll());
		P_0.Append((object)Author);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kS());
		DateTimeOffset createdAt = CreatedAt;
		P_0.Append(((object)(DateTimeOffset)(ref createdAt)).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kJ());
		P_0.Append((object)SourceLang);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kj());
		P_0.Append((object)StyleProfile);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lD());
		P_0.Append((object)Fonts);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(MqbsManifest? left, MqbsManifest? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(MqbsManifest? left, MqbsManifest? right)
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
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		return ((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MqbsVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameFingerprint)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineVersion)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Coverage)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(TranslatedCount)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(HumanReviewed)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Author)) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(CreatedAt)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SourceLang)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StyleProfile)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Fonts);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as MqbsManifest);
	}

	[CompilerGenerated]
	public bool Equals(MqbsManifest? other)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(MqbsVersion, other.MqbsVersion) && EqualityComparer<string>.Default.Equals(GameFingerprint, other.GameFingerprint) && EqualityComparer<string>.Default.Equals(GameName, other.GameName) && EqualityComparer<string>.Default.Equals(EngineId, other.EngineId) && EqualityComparer<string>.Default.Equals(EngineVersion, other.EngineVersion) && EqualityComparer<double>.Default.Equals(Coverage, other.Coverage) && EqualityComparer<int>.Default.Equals(TranslatedCount, other.TranslatedCount) && EqualityComparer<double>.Default.Equals(HumanReviewed, other.HumanReviewed) && EqualityComparer<string>.Default.Equals(Author, other.Author) && EqualityComparer<DateTimeOffset>.Default.Equals(CreatedAt, other.CreatedAt) && EqualityComparer<string>.Default.Equals(SourceLang, other.SourceLang) && EqualityComparer<string>.Default.Equals(StyleProfile, other.StyleProfile))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Fonts, other.Fonts);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private MqbsManifest(MqbsManifest P_0)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		MqbsVersion = P_0.MqbsVersion;
		GameFingerprint = P_0.GameFingerprint;
		GameName = P_0.GameName;
		EngineId = P_0.EngineId;
		EngineVersion = P_0.EngineVersion;
		Coverage = P_0.Coverage;
		TranslatedCount = P_0.TranslatedCount;
		HumanReviewed = P_0.HumanReviewed;
		Author = P_0.Author;
		CreatedAt = P_0.CreatedAt;
		SourceLang = P_0.SourceLang;
		StyleProfile = P_0.StyleProfile;
		Fonts = P_0.Fonts;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MqbsManifest()
	{
		MqbsVersion = 1;
		SourceLang = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CB();
		StyleProfile = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fb();
		Fonts = System.Array.Empty<string>();
		base._002Ector();
	}
}
