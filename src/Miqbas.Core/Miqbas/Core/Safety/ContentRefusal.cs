using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public sealed class ContentRefusal : IEquatable<ContentRefusal>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ContentRefusal);
		}
	}

	[field: CompilerGenerated]
	public string Source
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Because
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string Message => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KP() + Source + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kp();

	public ContentRefusal(string Source, string Because)
	{
		this.Source = Source;
		this.Because = Because;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KQ());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FK());
		P_0.Append((object)Source);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HI());
		P_0.Append((object)Because);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eo());
		P_0.Append((object)Message);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ContentRefusal? left, ContentRefusal? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ContentRefusal? left, ContentRefusal? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Because);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ContentRefusal);
	}

	[CompilerGenerated]
	public bool Equals(ContentRefusal? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Source, other.Source))
			{
				return EqualityComparer<string>.Default.Equals(Because, other.Because);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ContentRefusal(ContentRefusal P_0)
	{
		Source = P_0.Source;
		Because = P_0.Because;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Source, out string Because)
	{
		Source = this.Source;
		Because = this.Because;
	}
}
