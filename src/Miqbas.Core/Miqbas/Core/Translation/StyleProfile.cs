using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public sealed class StyleProfile : IEquatable<StyleProfile>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(StyleProfile);
		}
	}

	[field: CompilerGenerated]
	public static StyleProfile Default
	{
		[CompilerGenerated]
		get;
	} = new StyleProfile();


	[field: CompilerGenerated]
	public string Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string RegisterInstruction
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public NumeralStyle Numerals
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double MaxLengthRatio
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public Gender DefaultGender
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eZ());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CL());
		P_0.Append((object)Id);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ez());
		P_0.Append((object)RegisterInstruction);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FA());
		P_0.Append(((object)Numerals).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fa());
		P_0.Append(((object)MaxLengthRatio).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FB());
		P_0.Append(((object)DefaultGender).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(StyleProfile? left, StyleProfile? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(StyleProfile? left, StyleProfile? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RegisterInstruction)) * -1521134295 + EqualityComparer<NumeralStyle>.Default.GetHashCode(Numerals)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(MaxLengthRatio)) * -1521134295 + EqualityComparer<Gender>.Default.GetHashCode(DefaultGender);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as StyleProfile);
	}

	[CompilerGenerated]
	public bool Equals(StyleProfile? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other.Id) && EqualityComparer<string>.Default.Equals(RegisterInstruction, other.RegisterInstruction) && EqualityComparer<NumeralStyle>.Default.Equals(Numerals, other.Numerals) && EqualityComparer<double>.Default.Equals(MaxLengthRatio, other.MaxLengthRatio))
			{
				return EqualityComparer<Gender>.Default.Equals(DefaultGender, other.DefaultGender);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private StyleProfile(StyleProfile P_0)
	{
		Id = P_0.Id;
		RegisterInstruction = P_0.RegisterInstruction;
		Numerals = P_0.Numerals;
		MaxLengthRatio = P_0.MaxLengthRatio;
		DefaultGender = P_0.DefaultGender;
	}

	public StyleProfile()
	{
		Id = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fb();
		RegisterInstruction = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FC();
		MaxLengthRatio = 1.5;
		DefaultGender = Gender.Male;
		base._002Ector();
	}
}
