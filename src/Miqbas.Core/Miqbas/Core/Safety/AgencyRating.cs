using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public sealed class AgencyRating : IEquatable<AgencyRating>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(AgencyRating);
		}
	}

	[field: CompilerGenerated]
	public string Rating
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Descriptors
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public AgencyRating(string Rating, System.Collections.Generic.IReadOnlyList<string> Descriptors)
	{
		this.Rating = Rating;
		this.Descriptors = Descriptors;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kn());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KO());
		P_0.Append((object)Rating);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ko());
		P_0.Append((object)Descriptors);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(AgencyRating? left, AgencyRating? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(AgencyRating? left, AgencyRating? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Rating)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Descriptors);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as AgencyRating);
	}

	[CompilerGenerated]
	public bool Equals(AgencyRating? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Rating, other.Rating))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Descriptors, other.Descriptors);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private AgencyRating(AgencyRating P_0)
	{
		Rating = P_0.Rating;
		Descriptors = P_0.Descriptors;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Rating, out System.Collections.Generic.IReadOnlyList<string> Descriptors)
	{
		Rating = this.Rating;
		Descriptors = this.Descriptors;
	}
}
