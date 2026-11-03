using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal;

public sealed class UnrealEnvironment : IEquatable<UnrealEnvironment>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(UnrealEnvironment);
		}
	}

	[field: CompilerGenerated]
	public Func<IPakDecompressor?>? Decompressor
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
	public Func<string, byte[]?>? PackageKeyFor
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? LocalAppData
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
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ac());
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ad());
		P_0.Append((object)Decompressor);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aE());
		P_0.Append((object)ArabicFontPath);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ae());
		P_0.Append((object)PackageKeyFor);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aF());
		P_0.Append((object)LocalAppData);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(UnrealEnvironment? left, UnrealEnvironment? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(UnrealEnvironment? left, UnrealEnvironment? right)
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
		return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Func<IPakDecompressor>>.Default.GetHashCode(Decompressor)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArabicFontPath)) * -1521134295 + EqualityComparer<Func<string, byte[]>>.Default.GetHashCode(PackageKeyFor)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LocalAppData);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as UnrealEnvironment);
	}

	[CompilerGenerated]
	public bool Equals(UnrealEnvironment? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<Func<IPakDecompressor>>.Default.Equals(Decompressor, other.Decompressor) && EqualityComparer<string>.Default.Equals(ArabicFontPath, other.ArabicFontPath) && EqualityComparer<Func<string, byte[]>>.Default.Equals(PackageKeyFor, other.PackageKeyFor))
			{
				return EqualityComparer<string>.Default.Equals(LocalAppData, other.LocalAppData);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private UnrealEnvironment(UnrealEnvironment original)
	{
		Decompressor = original.Decompressor;
		ArabicFontPath = original.ArabicFontPath;
		PackageKeyFor = original.PackageKeyFor;
		LocalAppData = original.LocalAppData;
	}

	public UnrealEnvironment()
	{
	}
}
