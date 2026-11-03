using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Engines;
using Miqbas.Core.Translation;

namespace Miqbas.Core.Packages;

[RequiredMember]
public sealed class MqbsContents : IEquatable<MqbsContents>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(MqbsContents);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public MqbsManifest Manifest
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public MqbsInstall Install
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<MqbsEntry> Entries
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<GlossaryEntry> Glossary
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<LearnedShape> Shapes
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lz());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MA());
		P_0.Append((object)Manifest);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ma());
		P_0.Append((object)Install);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MB());
		P_0.Append((object)Entries);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fo());
		P_0.Append((object)Glossary);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mb());
		P_0.Append((object)Shapes);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(MqbsContents? left, MqbsContents? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(MqbsContents? left, MqbsContents? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<MqbsManifest>.Default.GetHashCode(Manifest)) * -1521134295 + EqualityComparer<MqbsInstall>.Default.GetHashCode(Install)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<MqbsEntry>>.Default.GetHashCode(Entries)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>.Default.GetHashCode(Glossary)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<LearnedShape>>.Default.GetHashCode(Shapes);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as MqbsContents);
	}

	[CompilerGenerated]
	public bool Equals(MqbsContents? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<MqbsManifest>.Default.Equals(Manifest, other.Manifest) && EqualityComparer<MqbsInstall>.Default.Equals(Install, other.Install) && EqualityComparer<System.Collections.Generic.IReadOnlyList<MqbsEntry>>.Default.Equals(Entries, other.Entries) && EqualityComparer<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>.Default.Equals(Glossary, other.Glossary))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<LearnedShape>>.Default.Equals(Shapes, other.Shapes);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private MqbsContents(MqbsContents P_0)
	{
		Manifest = P_0.Manifest;
		Install = P_0.Install;
		Entries = P_0.Entries;
		Glossary = P_0.Glossary;
		Shapes = P_0.Shapes;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public MqbsContents()
	{
		Glossary = System.Array.Empty<GlossaryEntry>();
		Shapes = System.Array.Empty<LearnedShape>();
		base._002Ector();
	}
}
