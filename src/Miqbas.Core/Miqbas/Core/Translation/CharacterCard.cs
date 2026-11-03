using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

[RequiredMember]
public sealed class CharacterCard : IEquatable<CharacterCard>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(CharacterCard);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public Gender Gender
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public Gender AddresseeGender
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Tone
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aV());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.P());
		P_0.Append((object)Name);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.av());
		P_0.Append(((object)Gender).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aW());
		P_0.Append(((object)AddresseeGender).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aw());
		P_0.Append((object)Tone);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(CharacterCard? left, CharacterCard? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(CharacterCard? left, CharacterCard? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<Gender>.Default.GetHashCode(Gender)) * -1521134295 + EqualityComparer<Gender>.Default.GetHashCode(AddresseeGender)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tone);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as CharacterCard);
	}

	[CompilerGenerated]
	public bool Equals(CharacterCard? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<Gender>.Default.Equals(Gender, other.Gender) && EqualityComparer<Gender>.Default.Equals(AddresseeGender, other.AddresseeGender))
			{
				return EqualityComparer<string>.Default.Equals(Tone, other.Tone);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private CharacterCard(CharacterCard P_0)
	{
		Name = P_0.Name;
		Gender = P_0.Gender;
		AddresseeGender = P_0.AddresseeGender;
		Tone = P_0.Tone;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public CharacterCard()
	{
	}
}
