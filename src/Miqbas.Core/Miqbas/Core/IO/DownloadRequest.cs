using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.IO;

[RequiredMember]
public sealed class DownloadRequest : IEquatable<DownloadRequest>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(DownloadRequest);
		}
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
	public string DestinationPath
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

	[field: CompilerGenerated]
	public string Subject
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NM());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nm());
		P_0.Append((object)Url);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NN());
		P_0.Append((object)DestinationPath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nn());
		P_0.Append(((object)SizeBytes).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kY());
		P_0.Append((object)Sha256);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NO());
		P_0.Append((object)Subject);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(DownloadRequest? left, DownloadRequest? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(DownloadRequest? left, DownloadRequest? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Url)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DestinationPath)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(SizeBytes)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sha256)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Subject);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as DownloadRequest);
	}

	[CompilerGenerated]
	public bool Equals(DownloadRequest? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Url, other.Url) && EqualityComparer<string>.Default.Equals(DestinationPath, other.DestinationPath) && EqualityComparer<long>.Default.Equals(SizeBytes, other.SizeBytes) && EqualityComparer<string>.Default.Equals(Sha256, other.Sha256))
			{
				return EqualityComparer<string>.Default.Equals(Subject, other.Subject);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private DownloadRequest(DownloadRequest P_0)
	{
		Url = P_0.Url;
		DestinationPath = P_0.DestinationPath;
		SizeBytes = P_0.SizeBytes;
		Sha256 = P_0.Sha256;
		Subject = P_0.Subject;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public DownloadRequest()
	{
		Subject = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.No();
		base._002Ector();
	}
}
