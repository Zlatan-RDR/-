using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

[RequiredMember]
public sealed class BackupEntry : IEquatable<BackupEntry>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(BackupEntry);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string RelativePath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public BackupEntryKind Kind
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Sha256
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kX());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kx());
		P_0.Append((object)RelativePath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aE());
		P_0.Append(((object)Kind).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kY());
		P_0.Append((object)Sha256);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(BackupEntry? left, BackupEntry? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(BackupEntry? left, BackupEntry? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RelativePath)) * -1521134295 + EqualityComparer<BackupEntryKind>.Default.GetHashCode(Kind)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sha256);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BackupEntry);
	}

	[CompilerGenerated]
	public bool Equals(BackupEntry? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(RelativePath, other.RelativePath) && EqualityComparer<BackupEntryKind>.Default.Equals(Kind, other.Kind))
			{
				return EqualityComparer<string>.Default.Equals(Sha256, other.Sha256);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private BackupEntry(BackupEntry P_0)
	{
		RelativePath = P_0.RelativePath;
		Kind = P_0.Kind;
		Sha256 = P_0.Sha256;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BackupEntry()
	{
	}
}
