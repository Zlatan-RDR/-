using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public sealed class LoadFault : IEquatable<LoadFault>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LoadFault);
		}
	}

	[field: CompilerGenerated]
	public string File
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Words
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LoadFault(string File, string Words)
	{
		this.File = File;
		this.Words = Words;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pR());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Om());
		P_0.Append((object)File);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pr());
		P_0.Append((object)Words);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LoadFault? left, LoadFault? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LoadFault? left, LoadFault? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(File)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Words);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LoadFault);
	}

	[CompilerGenerated]
	public bool Equals(LoadFault? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(File, other.File))
			{
				return EqualityComparer<string>.Default.Equals(Words, other.Words);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LoadFault(LoadFault P_0)
	{
		File = P_0.File;
		Words = P_0.Words;
	}

	[CompilerGenerated]
	public void Deconstruct(out string File, out string Words)
	{
		File = this.File;
		Words = this.Words;
	}
}
