using System;
using System.IO;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Detection;

public static class Il2CppMetadata
{
	private const uint Marker = 4205910959u;

	public const int HighestVersionTheLoaderReads = 106;

	private const int HigherThanAnyRealVersion = 1000;

	public static string PathIn(string dataDirectory)
	{
		return Path.Combine(dataDirectory, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bv(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BW(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ai());
	}

	public static int? VersionIn(string dataDirectory)
	{
		if (string.IsNullOrWhiteSpace(dataDirectory))
		{
			return null;
		}
		try
		{
			string text = PathIn(dataDirectory);
			if (!File.Exists(text))
			{
				return null;
			}
			FileStream val = File.OpenRead(text);
			try
			{
				System.Span<byte> span = stackalloc byte[8];
				if (((Stream)val).Read(span) < span.Length)
				{
					return null;
				}
				if (BitConverter.ToUInt32(System.Span<byte>.op_Implicit(span.Slice(0, 4))) != 4205910959u)
				{
					return null;
				}
				int num = BitConverter.ToInt32(System.Span<byte>.op_Implicit(span.Slice(4, span.Length - 4)));
				return (num > 0 && num < 1000) ? new int?(num) : null;
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return null;
		}
	}

	public static bool IsNewerThanTheLoaderReads(string dataDirectory)
	{
		int? num = VersionIn(dataDirectory);
		if (num.HasValue)
		{
			int valueOrDefault = num.GetValueOrDefault();
			return valueOrDefault > 106;
		}
		return false;
	}
}
