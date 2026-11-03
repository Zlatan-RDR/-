using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public sealed class PlaceOnScreen : IEquatable<PlaceOnScreen>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(PlaceOnScreen);
		}
	}

	[field: CompilerGenerated]
	public int English
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Arabic
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int MissingLetters
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Font
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public PlaceOnScreen(int English, int Arabic, int MissingLetters, string? Font)
	{
		this.English = English;
		this.Arabic = Arabic;
		this.MissingLetters = MissingLetters;
		this.Font = Font;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pS());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ps());
		P_0.Append(((object)English).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pT());
		P_0.Append(((object)Arabic).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pt());
		P_0.Append(((object)MissingLetters).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pU());
		P_0.Append((object)Font);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(PlaceOnScreen? left, PlaceOnScreen? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(PlaceOnScreen? left, PlaceOnScreen? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(English)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Arabic)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MissingLetters)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Font);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as PlaceOnScreen);
	}

	[CompilerGenerated]
	public bool Equals(PlaceOnScreen? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(English, other.English) && EqualityComparer<int>.Default.Equals(Arabic, other.Arabic) && EqualityComparer<int>.Default.Equals(MissingLetters, other.MissingLetters))
			{
				return EqualityComparer<string>.Default.Equals(Font, other.Font);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private PlaceOnScreen(PlaceOnScreen original)
	{
		English = original.English;
		Arabic = original.Arabic;
		MissingLetters = original.MissingLetters;
		Font = original.Font;
	}

	[CompilerGenerated]
	public void Deconstruct(out int English, out int Arabic, out int MissingLetters, out string? Font)
	{
		English = this.English;
		Arabic = this.Arabic;
		MissingLetters = this.MissingLetters;
		Font = this.Font;
	}
}
