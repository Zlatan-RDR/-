using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

[RequiredMember]
public sealed class BackupManifest : IEquatable<BackupManifest>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(BackupManifest);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<BackupEntry> Entries
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ky());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kZ());
		P_0.Append((object)Entries);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(BackupManifest? left, BackupManifest? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(BackupManifest? left, BackupManifest? right)
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
		return EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<BackupEntry>>.Default.GetHashCode(Entries);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BackupManifest);
	}

	[CompilerGenerated]
	public bool Equals(BackupManifest? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract)
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<BackupEntry>>.Default.Equals(Entries, other.Entries);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private BackupManifest(BackupManifest P_0)
	{
		Entries = P_0.Entries;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BackupManifest()
	{
	}
}
