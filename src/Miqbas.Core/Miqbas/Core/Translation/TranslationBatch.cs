using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class TranslationBatch : IEquatable<TranslationBatch>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TranslationBatch);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<TranslationUnit> Units
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public StyleProfile Style
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
	public string? GameContext
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fS());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fs());
		P_0.Append((object)Units);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fT());
		P_0.Append((object)Style);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fo());
		P_0.Append((object)Glossary);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fp());
		P_0.Append((object)GameContext);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TranslationBatch? left, TranslationBatch? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TranslationBatch? left, TranslationBatch? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<TranslationUnit>>.Default.GetHashCode(Units)) * -1521134295 + EqualityComparer<StyleProfile>.Default.GetHashCode(Style)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>.Default.GetHashCode(Glossary)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameContext);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TranslationBatch);
	}

	[CompilerGenerated]
	public bool Equals(TranslationBatch? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<TranslationUnit>>.Default.Equals(Units, other.Units) && EqualityComparer<StyleProfile>.Default.Equals(Style, other.Style) && EqualityComparer<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>.Default.Equals(Glossary, other.Glossary))
			{
				return EqualityComparer<string>.Default.Equals(GameContext, other.GameContext);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TranslationBatch(TranslationBatch P_0)
	{
		Units = P_0.Units;
		Style = P_0.Style;
		Glossary = P_0.Glossary;
		GameContext = P_0.GameContext;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TranslationBatch()
	{
		Glossary = System.Array.Empty<GlossaryEntry>();
		base._002Ector();
	}
}
