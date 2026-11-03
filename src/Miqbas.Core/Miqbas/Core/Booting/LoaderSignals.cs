using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public sealed class LoaderSignals : IEquatable<LoaderSignals>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LoaderSignals);
		}
	}

	[field: CompilerGenerated]
	public bool MiqbasIsReady
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Labels
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ArabicLabels
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool FontInstalled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool FontFailed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool StartedWithoutOurModule
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool SaidNothing
	{
		get
		{
			if (!MiqbasIsReady && Labels == 0 && !FontInstalled)
			{
				return !FontFailed;
			}
			return false;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pf());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pG());
		P_0.Append(((object)MiqbasIsReady).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pg());
		P_0.Append(((object)Labels).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pH());
		P_0.Append(((object)ArabicLabels).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ph());
		P_0.Append(((object)FontInstalled).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pI());
		P_0.Append(((object)FontFailed).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pi());
		P_0.Append(((object)StartedWithoutOurModule).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pJ());
		P_0.Append(((object)SaidNothing).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LoaderSignals? left, LoaderSignals? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LoaderSignals? left, LoaderSignals? right)
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
		return (((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(MiqbasIsReady)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Labels)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ArabicLabels)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(FontInstalled)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(FontFailed)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(StartedWithoutOurModule);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LoaderSignals);
	}

	[CompilerGenerated]
	public bool Equals(LoaderSignals? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(MiqbasIsReady, other.MiqbasIsReady) && EqualityComparer<int>.Default.Equals(Labels, other.Labels) && EqualityComparer<int>.Default.Equals(ArabicLabels, other.ArabicLabels) && EqualityComparer<bool>.Default.Equals(FontInstalled, other.FontInstalled) && EqualityComparer<bool>.Default.Equals(FontFailed, other.FontFailed))
			{
				return EqualityComparer<bool>.Default.Equals(StartedWithoutOurModule, other.StartedWithoutOurModule);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LoaderSignals(LoaderSignals P_0)
	{
		MiqbasIsReady = P_0.MiqbasIsReady;
		Labels = P_0.Labels;
		ArabicLabels = P_0.ArabicLabels;
		FontInstalled = P_0.FontInstalled;
		FontFailed = P_0.FontFailed;
		StartedWithoutOurModule = P_0.StartedWithoutOurModule;
	}

	public LoaderSignals()
	{
	}
}
