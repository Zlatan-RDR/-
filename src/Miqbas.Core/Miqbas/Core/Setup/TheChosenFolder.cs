using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Setup;

[RequiredMember]
public sealed class TheChosenFolder : IEquatable<TheChosenFolder>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheChosenFolder);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool CanInstall
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

	[field: CompilerGenerated]
	public bool IsOnlyAWarning
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JN());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jn());
		P_0.Append(((object)CanInstall).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GN());
		P_0.Append((object)InArabic);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JO());
		P_0.Append(((object)IsOnlyAWarning).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheChosenFolder? left, TheChosenFolder? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheChosenFolder? left, TheChosenFolder? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CanInstall)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InArabic)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsOnlyAWarning);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheChosenFolder);
	}

	[CompilerGenerated]
	public bool Equals(TheChosenFolder? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(CanInstall, other.CanInstall) && EqualityComparer<string>.Default.Equals(InArabic, other.InArabic))
			{
				return EqualityComparer<bool>.Default.Equals(IsOnlyAWarning, other.IsOnlyAWarning);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TheChosenFolder(TheChosenFolder P_0)
	{
		CanInstall = P_0.CanInstall;
		InArabic = P_0.InArabic;
		IsOnlyAWarning = P_0.IsOnlyAWarning;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TheChosenFolder()
	{
	}
}
