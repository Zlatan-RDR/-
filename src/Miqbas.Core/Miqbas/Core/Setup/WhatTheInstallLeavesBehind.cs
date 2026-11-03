using System.IO;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Setup;

public static class WhatTheInstallLeavesBehind
{
	public const string ShortcutName = "مقباس.lnk";

	public const string TheLauncher = "Miqbas.exe";

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

	public static string TheProgramToOpen(string installFolder)
	{
		H.A(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JG());
		return Path.Combine(installFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JM());
	}

	public static string? TheDesktopShortcut(string desktopFolder)
	{
		if (!string.IsNullOrWhiteSpace(desktopFolder))
		{
			return Path.Combine(desktopFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jm());
		}
		return null;
	}
}
