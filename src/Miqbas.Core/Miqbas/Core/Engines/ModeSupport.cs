using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public sealed class ModeSupport<TMode> : IEquatable<ModeSupport<TMode>> where TMode : class
{
	private readonly TMode? _onlyToTakeOut;

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ModeSupport<TMode>);
		}
	}

	public TMode? Mode
	{
		[CompilerGenerated]
		get;
	}

	public string? UnavailableReason
	{
		[CompilerGenerated]
		get;
	}

	[MemberNotNullWhen(true, "Mode")]
	[MemberNotNullWhen(false, "UnavailableReason")]
	public bool Available
	{
		[MemberNotNullWhen(true, "Mode")]
		[MemberNotNullWhen(false, "UnavailableReason")]
		get
		{
			return Mode != null;
		}
	}

	public TMode? ToTakeOut => Mode ?? _onlyToTakeOut;

	private ModeSupport(TMode? P_0, string? P_1, TMode? P_2 = null)
	{
		Mode = P_0;
		UnavailableReason = P_1;
		_onlyToTakeOut = P_2;
	}

	public static ModeSupport<TMode> Of(TMode mode)
	{
		return new ModeSupport<TMode>(mode, null);
	}

	public static ModeSupport<TMode> Unavailable(string reason, TMode? stillToTakeOut = null)
	{
		return new ModeSupport<TMode>(null, reason, stillToTakeOut);
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ox());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OY());
		P_0.Append((object)Mode);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oy());
		P_0.Append((object)UnavailableReason);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OZ());
		P_0.Append(((object)Available).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oz());
		P_0.Append((object)ToTakeOut);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ModeSupport<TMode>? left, ModeSupport<TMode>? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ModeSupport<TMode>? left, ModeSupport<TMode>? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<TMode>.Default.GetHashCode(_onlyToTakeOut)) * -1521134295 + EqualityComparer<TMode>.Default.GetHashCode(Mode)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UnavailableReason);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ModeSupport<TMode>);
	}

	[CompilerGenerated]
	public bool Equals(ModeSupport<TMode>? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<TMode>.Default.Equals(_onlyToTakeOut, other._onlyToTakeOut) && EqualityComparer<TMode>.Default.Equals(Mode, other.Mode))
			{
				return EqualityComparer<string>.Default.Equals(UnavailableReason, other.UnavailableReason);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ModeSupport(ModeSupport<TMode> original)
	{
		_onlyToTakeOut = original._onlyToTakeOut;
		Mode = original.Mode;
		UnavailableReason = original.UnavailableReason;
	}
}
