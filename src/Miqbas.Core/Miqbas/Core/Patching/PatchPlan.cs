using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Patching;

[RequiredMember]
public sealed class PatchPlan : IEquatable<PatchPlan>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(PatchPlan);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<Translated> Translations
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public FontPlan? Fonts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? PluginSourcePath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool UseSignedPakWorkaround
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lC());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lc());
		P_0.Append((object)Translations);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lD());
		P_0.Append((object)Fonts);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ld());
		P_0.Append((object)PluginSourcePath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lE());
		P_0.Append(((object)UseSignedPakWorkaround).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(PatchPlan? left, PatchPlan? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(PatchPlan? left, PatchPlan? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<Translated>>.Default.GetHashCode(Translations)) * -1521134295 + EqualityComparer<FontPlan>.Default.GetHashCode(Fonts)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PluginSourcePath)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(UseSignedPakWorkaround);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as PatchPlan);
	}

	[CompilerGenerated]
	public bool Equals(PatchPlan? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<Translated>>.Default.Equals(Translations, other.Translations) && EqualityComparer<FontPlan>.Default.Equals(Fonts, other.Fonts) && EqualityComparer<string>.Default.Equals(PluginSourcePath, other.PluginSourcePath))
			{
				return EqualityComparer<bool>.Default.Equals(UseSignedPakWorkaround, other.UseSignedPakWorkaround);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private PatchPlan(PatchPlan original)
	{
		Translations = original.Translations;
		Fonts = original.Fonts;
		PluginSourcePath = original.PluginSourcePath;
		UseSignedPakWorkaround = original.UseSignedPakWorkaround;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PatchPlan()
	{
	}
}
