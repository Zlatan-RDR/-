using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public sealed class TheGameNeeds : IEquatable<TheGameNeeds>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheGameNeeds);
		}
	}

	[field: CompilerGenerated]
	public string Sentence
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Button
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Address
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public TheGameNeeds(string Sentence, string? Button = null, string? Address = null)
	{
		this.Sentence = Sentence;
		this.Button = Button;
		this.Address = Address;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oh());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OI());
		P_0.Append((object)Sentence);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oi());
		P_0.Append((object)Button);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OJ());
		P_0.Append((object)Address);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheGameNeeds? left, TheGameNeeds? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheGameNeeds? left, TheGameNeeds? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sentence)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Button)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheGameNeeds);
	}

	[CompilerGenerated]
	public bool Equals(TheGameNeeds? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Sentence, other.Sentence) && EqualityComparer<string>.Default.Equals(Button, other.Button))
			{
				return EqualityComparer<string>.Default.Equals(Address, other.Address);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private TheGameNeeds(TheGameNeeds original)
	{
		Sentence = original.Sentence;
		Button = original.Button;
		Address = original.Address;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Sentence, out string? Button, out string? Address)
	{
		Sentence = this.Sentence;
		Button = this.Button;
		Address = this.Address;
	}
}
