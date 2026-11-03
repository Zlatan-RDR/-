using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

[RequiredMember]
public sealed class BootBaseline : IEquatable<BootBaseline>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(BootBaseline);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public DateTimeOffset TakenAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int SecondsToMenu
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? LogPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long LogBytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Milestone
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? LastLogLine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? LocalizationErrors
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string>? ThrowsOfTheCleanRun
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int PatienceSeconds => Math.Max(30, SecondsToMenu * 2);

	public bool IsItselfACrash
	{
		get
		{
			if (ACrashInTheLog.In(Milestone) == null)
			{
				return ACrashInTheLog.In(LastLogLine) != null;
			}
			return true;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ow());
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oX());
		DateTimeOffset takenAt = TakenAt;
		P_0.Append(((object)(DateTimeOffset)(ref takenAt)).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ox());
		P_0.Append(((object)SecondsToMenu).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oY());
		P_0.Append((object)LogPath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oy());
		P_0.Append(((object)LogBytes).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oZ());
		P_0.Append((object)Milestone);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oz());
		P_0.Append((object)LastLogLine);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PA());
		P_0.Append(((object)LocalizationErrors).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pa());
		P_0.Append((object)ThrowsOfTheCleanRun);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PB());
		P_0.Append(((object)PatienceSeconds).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pb());
		P_0.Append(((object)IsItselfACrash).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(BootBaseline? left, BootBaseline? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(BootBaseline? left, BootBaseline? right)
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		return (((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<DateTimeOffset>.Default.GetHashCode(TakenAt)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SecondsToMenu)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LogPath)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(LogBytes)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Milestone)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastLogLine)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(LocalizationErrors)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(ThrowsOfTheCleanRun);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BootBaseline);
	}

	[CompilerGenerated]
	public bool Equals(BootBaseline? other)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<DateTimeOffset>.Default.Equals(TakenAt, other.TakenAt) && EqualityComparer<int>.Default.Equals(SecondsToMenu, other.SecondsToMenu) && EqualityComparer<string>.Default.Equals(LogPath, other.LogPath) && EqualityComparer<long>.Default.Equals(LogBytes, other.LogBytes) && EqualityComparer<string>.Default.Equals(Milestone, other.Milestone) && EqualityComparer<string>.Default.Equals(LastLogLine, other.LastLogLine) && EqualityComparer<int?>.Default.Equals(LocalizationErrors, other.LocalizationErrors))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(ThrowsOfTheCleanRun, other.ThrowsOfTheCleanRun);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private BootBaseline(BootBaseline original)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		TakenAt = original.TakenAt;
		SecondsToMenu = original.SecondsToMenu;
		LogPath = original.LogPath;
		LogBytes = original.LogBytes;
		Milestone = original.Milestone;
		LastLogLine = original.LastLogLine;
		LocalizationErrors = original.LocalizationErrors;
		ThrowsOfTheCleanRun = original.ThrowsOfTheCleanRun;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BootBaseline()
	{
	}
}
