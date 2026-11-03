using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Hooking;

[RequiredMember]
public sealed class HookRelease : IEquatable<HookRelease>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(HookRelease);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Version
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Url
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long SizeBytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Sha256
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string FileName
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
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aT());
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
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.at());
		P_0.Append((object)Version);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aU());
		P_0.Append((object)Url);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.au());
		P_0.Append(((object)SizeBytes).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aV());
		P_0.Append((object)Sha256);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.av());
		P_0.Append((object)FileName);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(HookRelease? left, HookRelease? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(HookRelease? left, HookRelease? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Version)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Url)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(SizeBytes)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sha256)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileName);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as HookRelease);
	}

	[CompilerGenerated]
	public bool Equals(HookRelease? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Version, other.Version) && EqualityComparer<string>.Default.Equals(Url, other.Url) && EqualityComparer<long>.Default.Equals(SizeBytes, other.SizeBytes) && EqualityComparer<string>.Default.Equals(Sha256, other.Sha256))
			{
				return EqualityComparer<string>.Default.Equals(FileName, other.FileName);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private HookRelease(HookRelease P_0)
	{
		Version = P_0.Version;
		Url = P_0.Url;
		SizeBytes = P_0.SizeBytes;
		Sha256 = P_0.Sha256;
		FileName = P_0.FileName;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public HookRelease()
	{
	}
}
