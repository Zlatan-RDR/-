using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Hooking;

[RequiredMember]
public sealed class PluginPayload : IEquatable<PluginPayload>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(PluginPayload);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> PluginAssemblies
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ArabicFontPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, string> Translations
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
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BP());
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.a());
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
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bp());
		P_0.Append((object)PluginAssemblies);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.D());
		P_0.Append((object)ArabicFontPath);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BQ());
		P_0.Append((object)Translations);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(PluginPayload? left, PluginPayload? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(PluginPayload? left, PluginPayload? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(PluginAssemblies)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArabicFontPath)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, string>>.Default.GetHashCode(Translations);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as PluginPayload);
	}

	[CompilerGenerated]
	public bool Equals(PluginPayload? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(PluginAssemblies, other.PluginAssemblies) && EqualityComparer<string>.Default.Equals(ArabicFontPath, other.ArabicFontPath))
			{
				return EqualityComparer<IReadOnlyDictionary<string, string>>.Default.Equals(Translations, other.Translations);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private PluginPayload(PluginPayload P_0)
	{
		PluginAssemblies = P_0.PluginAssemblies;
		ArabicFontPath = P_0.ArabicFontPath;
		Translations = P_0.Translations;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PluginPayload()
	{
		Translations = (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		base._002Ector();
	}
}
