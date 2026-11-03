using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity;

[RequiredMember]
public sealed class UnityHookEnvironment : IEquatable<UnityHookEnvironment>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(UnityHookEnvironment);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public HttpClient Http
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string HookCacheDirectory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public Func<System.Collections.Generic.IReadOnlyList<string>> PluginAssemblies
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public Func<System.Collections.Generic.IReadOnlyList<string>> Il2CppPluginAssemblies
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
	public string? WideFontPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? TypeDatabasePath
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
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.A());
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
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.B());
		P_0.Append((object)Http);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.b());
		P_0.Append((object)HookCacheDirectory);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.C());
		P_0.Append((object)PluginAssemblies);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.c());
		P_0.Append((object)Il2CppPluginAssemblies);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.D());
		P_0.Append((object)ArabicFontPath);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.d());
		P_0.Append((object)WideFontPath);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.E());
		P_0.Append((object)TypeDatabasePath);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(UnityHookEnvironment? left, UnityHookEnvironment? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(UnityHookEnvironment? left, UnityHookEnvironment? right)
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
		return ((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<HttpClient>.Default.GetHashCode(Http)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HookCacheDirectory)) * -1521134295 + EqualityComparer<Func<System.Collections.Generic.IReadOnlyList<string>>>.Default.GetHashCode(PluginAssemblies)) * -1521134295 + EqualityComparer<Func<System.Collections.Generic.IReadOnlyList<string>>>.Default.GetHashCode(Il2CppPluginAssemblies)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArabicFontPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WideFontPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TypeDatabasePath);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as UnityHookEnvironment);
	}

	[CompilerGenerated]
	public bool Equals(UnityHookEnvironment? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<HttpClient>.Default.Equals(Http, other.Http) && EqualityComparer<string>.Default.Equals(HookCacheDirectory, other.HookCacheDirectory) && EqualityComparer<Func<System.Collections.Generic.IReadOnlyList<string>>>.Default.Equals(PluginAssemblies, other.PluginAssemblies) && EqualityComparer<Func<System.Collections.Generic.IReadOnlyList<string>>>.Default.Equals(Il2CppPluginAssemblies, other.Il2CppPluginAssemblies) && EqualityComparer<string>.Default.Equals(ArabicFontPath, other.ArabicFontPath) && EqualityComparer<string>.Default.Equals(WideFontPath, other.WideFontPath))
			{
				return EqualityComparer<string>.Default.Equals(TypeDatabasePath, other.TypeDatabasePath);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private UnityHookEnvironment(UnityHookEnvironment P_0)
	{
		Http = P_0.Http;
		HookCacheDirectory = P_0.HookCacheDirectory;
		PluginAssemblies = P_0.PluginAssemblies;
		Il2CppPluginAssemblies = P_0.Il2CppPluginAssemblies;
		ArabicFontPath = P_0.ArabicFontPath;
		WideFontPath = P_0.WideFontPath;
		TypeDatabasePath = P_0.TypeDatabasePath;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public UnityHookEnvironment()
	{
	}
}
