using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public sealed class CleanRun : IEquatable<CleanRun>
{
	public static readonly CleanRun NotMeasured = new CleanRun();

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(CleanRun);
		}
	}

	[field: CompilerGenerated]
	public BootBaseline? Baseline
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? CrashLine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool ItCrashedBeforeWeTouchedIt => CrashLine != null;

	public static CleanRun Measured(BootBaseline baseline)
	{
		return new CleanRun
		{
			Baseline = baseline
		};
	}

	public static CleanRun Crashed(string crashLine)
	{
		return new CleanRun
		{
			CrashLine = crashLine
		};
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pP());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pp());
		P_0.Append((object)Baseline);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pQ());
		P_0.Append((object)CrashLine);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pq());
		P_0.Append(((object)ItCrashedBeforeWeTouchedIt).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(CleanRun? left, CleanRun? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(CleanRun? left, CleanRun? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<BootBaseline>.Default.GetHashCode(Baseline)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CrashLine);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as CleanRun);
	}

	[CompilerGenerated]
	public bool Equals(CleanRun? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<BootBaseline>.Default.Equals(Baseline, other.Baseline))
			{
				return EqualityComparer<string>.Default.Equals(CrashLine, other.CrashLine);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private CleanRun(CleanRun original)
	{
		Baseline = original.Baseline;
		CrashLine = original.CrashLine;
	}

	public CleanRun()
	{
	}
}
