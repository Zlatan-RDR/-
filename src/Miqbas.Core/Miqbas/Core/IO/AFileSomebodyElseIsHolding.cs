using System;
using System.IO;

namespace Miqbas.Core.IO;

public static class AFileSomebodyElseIsHolding
{
	public const int SharingViolation = -2147024864;

	public const int LockViolation = -2147024863;

	public const int AccessDenied = -2147024891;

	public static bool Is(System.Exception? exception)
	{
		IOException val = (IOException)(object)((exception is IOException) ? exception : null);
		if (val != null && !(val is FileNotFoundException) && !(val is DirectoryNotFoundException))
		{
			return IsOneOfTheCodes(exception.HResult);
		}
		return false;
	}

	public static bool IsOneOfTheCodes(int hresult)
	{
		if (hresult == -2147024891 || (uint)(hresult - -2147024864) <= 1u)
		{
			return true;
		}
		return false;
	}
}
