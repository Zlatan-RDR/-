using System.IO;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Setup;

public static class WhereMiqbasWillLive
{
	public const string TheFolderName = "Miqbas";

	public const long RoomItReallyNeeds = 8589934592L;

	public static TheChosenFolder Judge(string? folder, bool isWritable, long? freeBytes, bool alreadyHasAnInstall, bool isSystemFolder)
	{
		if (string.IsNullOrWhiteSpace(folder))
		{
			return A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jo());
		}
		if (!SetupCommandLine.IsFullyQualified(folder))
		{
			return A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JP());
		}
		if (isSystemFolder)
		{
			return A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jp());
		}
		if (!isWritable)
		{
			return A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JQ());
		}
		if (alreadyHasAnInstall)
		{
			return a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jq());
		}
		if (freeBytes.HasValue)
		{
			long valueOrDefault = freeBytes.GetValueOrDefault();
			if (valueOrDefault < 8589934592L)
			{
				return a(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JR() + A(valueOrDefault) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jr());
			}
		}
		return new TheChosenFolder
		{
			CanInstall = true,
			InArabic = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JS()
		};
	}

	public static string[] TheArgumentsFor(string folder)
	{
		H.A(folder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jk());
		return new string[3]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JL(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jl(),
			folder
		};
	}

	public static string SuggestUnder(string parentFolder)
	{
		H.A(parentFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Js());
		return Path.Combine(parentFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JT());
	}

	private static TheChosenFolder A(string P_0)
	{
		return new TheChosenFolder
		{
			CanInstall = false,
			InArabic = P_0
		};
	}

	private static TheChosenFolder a(string P_0)
	{
		return new TheChosenFolder
		{
			CanInstall = true,
			InArabic = P_0,
			IsOnlyAWarning = true
		};
	}

	private static string A(long P_0)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 1);
		defaultInterpolatedStringHandler.AppendFormatted<double>((double)P_0 / 1024.0 / 1024.0 / 1024.0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jt());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JU());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
