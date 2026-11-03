using System;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

public static class PackagedTable
{
	public static LocResFile Read(PakArchive package, PakEntry entry, IPakDecompressor? decompressor)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)package, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		ArgumentNullException.ThrowIfNull((object)entry, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bA());
		try
		{
			return LocResFile.Read(package.Read(entry, decompressor));
		}
		catch (object obj) when (obj is NotSupportedException && entry.IsCompressed && A(entry, decompressor))
		{
			throw new InvalidOperationException(entry.CompressionMethod.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bh(), (StringComparison)5) ? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EJ() : (_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EI() + entry.CompressionMethod + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ei()));
		}
	}

	private static bool A(PakEntry P_0, IPakDecompressor? decompressor)
	{
		if (decompressor != null)
		{
			return !decompressor.Supports(P_0.CompressionMethod);
		}
		return true;
	}
}
