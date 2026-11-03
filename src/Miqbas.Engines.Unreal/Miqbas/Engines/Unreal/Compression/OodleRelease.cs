using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Compression;

[RequiredMember]
public sealed class OodleRelease : IEquatable<OodleRelease>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(OodleRelease);
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
	public string ArchiveFileName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long ArchiveSizeBytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string ArchiveSha256
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string EntryInArchive
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long LibrarySizeBytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string LibrarySha256
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
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.He());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HF());
		P_0.Append((object)Version);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hf());
		P_0.Append((object)Url);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HG());
		P_0.Append((object)ArchiveFileName);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hg());
		P_0.Append(((object)ArchiveSizeBytes).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HH());
		P_0.Append((object)ArchiveSha256);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hh());
		P_0.Append((object)EntryInArchive);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HI());
		P_0.Append(((object)LibrarySizeBytes).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hi());
		P_0.Append((object)LibrarySha256);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(OodleRelease? left, OodleRelease? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(OodleRelease? left, OodleRelease? right)
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
		return (((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Version)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Url)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArchiveFileName)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(ArchiveSizeBytes)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArchiveSha256)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EntryInArchive)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(LibrarySizeBytes)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LibrarySha256);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as OodleRelease);
	}

	[CompilerGenerated]
	public bool Equals(OodleRelease? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Version, other.Version) && EqualityComparer<string>.Default.Equals(Url, other.Url) && EqualityComparer<string>.Default.Equals(ArchiveFileName, other.ArchiveFileName) && EqualityComparer<long>.Default.Equals(ArchiveSizeBytes, other.ArchiveSizeBytes) && EqualityComparer<string>.Default.Equals(ArchiveSha256, other.ArchiveSha256) && EqualityComparer<string>.Default.Equals(EntryInArchive, other.EntryInArchive) && EqualityComparer<long>.Default.Equals(LibrarySizeBytes, other.LibrarySizeBytes))
			{
				return EqualityComparer<string>.Default.Equals(LibrarySha256, other.LibrarySha256);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private OodleRelease(OodleRelease P_0)
	{
		Version = P_0.Version;
		Url = P_0.Url;
		ArchiveFileName = P_0.ArchiveFileName;
		ArchiveSizeBytes = P_0.ArchiveSizeBytes;
		ArchiveSha256 = P_0.ArchiveSha256;
		EntryInArchive = P_0.EntryInArchive;
		LibrarySizeBytes = P_0.LibrarySizeBytes;
		LibrarySha256 = P_0.LibrarySha256;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public OodleRelease()
	{
	}
}
