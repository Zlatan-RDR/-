using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class TheWordsArray : IEquatable<TheWordsArray>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheWordsArray);
		}
	}

	[field: CompilerGenerated]
	public string? Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> LeftAlone
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string InArabic
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool Found => Name != null;

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iY());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iy());
		P_0.Append((object)LeftAlone);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GN());
		P_0.Append((object)InArabic);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iZ());
		P_0.Append(((object)Found).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheWordsArray? left, TheWordsArray? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheWordsArray? left, TheWordsArray? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(LeftAlone)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InArabic);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheWordsArray);
	}

	[CompilerGenerated]
	public bool Equals(TheWordsArray? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(LeftAlone, other.LeftAlone))
			{
				return EqualityComparer<string>.Default.Equals(InArabic, other.InArabic);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TheWordsArray(TheWordsArray P_0)
	{
		Name = P_0.Name;
		LeftAlone = P_0.LeftAlone;
		InArabic = P_0.InArabic;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TheWordsArray()
	{
		LeftAlone = System.Array.Empty<string>();
		base._002Ector();
	}
}
