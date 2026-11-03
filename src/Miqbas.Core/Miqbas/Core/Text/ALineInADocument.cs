using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public sealed class ALineInADocument : IEquatable<ALineInADocument>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ALineInADocument);
		}
	}

	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Value
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ALineInADocument(string Path, string Value)
	{
		this.Path = Path;
		this.Value = Value;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iV());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@is());
		P_0.Append((object)Path);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fk());
		P_0.Append((object)Value);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ALineInADocument? left, ALineInADocument? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ALineInADocument? left, ALineInADocument? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ALineInADocument);
	}

	[CompilerGenerated]
	public bool Equals(ALineInADocument? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other.Path))
			{
				return EqualityComparer<string>.Default.Equals(Value, other.Value);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ALineInADocument(ALineInADocument P_0)
	{
		Path = P_0.Path;
		Value = P_0.Value;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Path, out string Value)
	{
		Path = this.Path;
		Value = this.Value;
	}
}
