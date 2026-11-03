using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Localization;

[RequiredMember]
public sealed class LocResEntry : IEquatable<LocResEntry>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LocResEntry);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Namespace
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Value
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public uint NamespaceHash
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public uint KeyHash
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public uint SourceStringHash
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string Address => Namespace.Replace(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dx()) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p() + Key;

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dY());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dp());
		P_0.Append((object)Namespace);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DQ());
		P_0.Append((object)Key);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dy());
		P_0.Append((object)Value);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dZ());
		P_0.Append(((object)NamespaceHash).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dz());
		P_0.Append(((object)KeyHash).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EA());
		P_0.Append(((object)SourceStringHash).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ea());
		P_0.Append((object)Address);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LocResEntry? left, LocResEntry? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LocResEntry? left, LocResEntry? right)
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
		return (((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Namespace)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(NamespaceHash)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(KeyHash)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(SourceStringHash);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LocResEntry);
	}

	[CompilerGenerated]
	public bool Equals(LocResEntry? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Namespace, other.Namespace) && EqualityComparer<string>.Default.Equals(Key, other.Key) && EqualityComparer<string>.Default.Equals(Value, other.Value) && EqualityComparer<uint>.Default.Equals(NamespaceHash, other.NamespaceHash) && EqualityComparer<uint>.Default.Equals(KeyHash, other.KeyHash))
			{
				return EqualityComparer<uint>.Default.Equals(SourceStringHash, other.SourceStringHash);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private LocResEntry(LocResEntry P_0)
	{
		Namespace = P_0.Namespace;
		Key = P_0.Key;
		Value = P_0.Value;
		NamespaceHash = P_0.NamespaceHash;
		KeyHash = P_0.KeyHash;
		SourceStringHash = P_0.SourceStringHash;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public LocResEntry()
	{
	}
}
