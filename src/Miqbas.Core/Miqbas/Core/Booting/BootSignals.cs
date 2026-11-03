using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

[RequiredMember]
public sealed class BootSignals : IEquatable<BootSignals>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(BootSignals);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool ProcessAlive
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
	public string? LastLogLine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string LogText
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string CrashReports
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
	public bool LoaderExpected
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public LoaderSignals? Loader
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? FontVerifiedInFile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? FontVerification
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? UserSaysArabicIsDrawn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool UserCouldNotConfirm
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool LogStillGrowing
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pj());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pK());
		P_0.Append(((object)ProcessAlive).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oy());
		P_0.Append(((object)LogBytes).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oz());
		P_0.Append((object)LastLogLine);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pk());
		P_0.Append((object)LogText);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pL());
		P_0.Append((object)CrashReports);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PA());
		P_0.Append(((object)LocalizationErrors).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pl());
		P_0.Append(((object)LoaderExpected).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pM());
		P_0.Append((object)Loader);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pm());
		P_0.Append(((object)FontVerifiedInFile).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pN());
		P_0.Append((object)FontVerification);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pn());
		P_0.Append(((object)UserSaysArabicIsDrawn).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pO());
		P_0.Append(((object)UserCouldNotConfirm).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.po());
		P_0.Append(((object)LogStillGrowing).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(BootSignals? left, BootSignals? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(BootSignals? left, BootSignals? right)
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
		return ((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ProcessAlive)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(LogBytes)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastLogLine)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LogText)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CrashReports)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(LocalizationErrors)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(LoaderExpected)) * -1521134295 + EqualityComparer<LoaderSignals>.Default.GetHashCode(Loader)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(FontVerifiedInFile)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FontVerification)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(UserSaysArabicIsDrawn)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(UserCouldNotConfirm)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(LogStillGrowing);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BootSignals);
	}

	[CompilerGenerated]
	public bool Equals(BootSignals? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(ProcessAlive, other.ProcessAlive) && EqualityComparer<long>.Default.Equals(LogBytes, other.LogBytes) && EqualityComparer<string>.Default.Equals(LastLogLine, other.LastLogLine) && EqualityComparer<string>.Default.Equals(LogText, other.LogText) && EqualityComparer<string>.Default.Equals(CrashReports, other.CrashReports) && EqualityComparer<int?>.Default.Equals(LocalizationErrors, other.LocalizationErrors) && EqualityComparer<bool>.Default.Equals(LoaderExpected, other.LoaderExpected) && EqualityComparer<LoaderSignals>.Default.Equals(Loader, other.Loader) && EqualityComparer<bool?>.Default.Equals(FontVerifiedInFile, other.FontVerifiedInFile) && EqualityComparer<string>.Default.Equals(FontVerification, other.FontVerification) && EqualityComparer<bool?>.Default.Equals(UserSaysArabicIsDrawn, other.UserSaysArabicIsDrawn) && EqualityComparer<bool>.Default.Equals(UserCouldNotConfirm, other.UserCouldNotConfirm))
			{
				return EqualityComparer<bool>.Default.Equals(LogStillGrowing, other.LogStillGrowing);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private BootSignals(BootSignals original)
	{
		ProcessAlive = original.ProcessAlive;
		LogBytes = original.LogBytes;
		LastLogLine = original.LastLogLine;
		LogText = original.LogText;
		CrashReports = original.CrashReports;
		LocalizationErrors = original.LocalizationErrors;
		LoaderExpected = original.LoaderExpected;
		Loader = original.Loader;
		FontVerifiedInFile = original.FontVerifiedInFile;
		FontVerification = original.FontVerification;
		UserSaysArabicIsDrawn = original.UserSaysArabicIsDrawn;
		UserCouldNotConfirm = original.UserCouldNotConfirm;
		LogStillGrowing = original.LogStillGrowing;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BootSignals()
	{
		LogText = string.Empty;
		CrashReports = string.Empty;
		base._002Ector();
	}
}
