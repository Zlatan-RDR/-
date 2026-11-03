using System;
using System.IO;
using System.Security.Cryptography;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public static class ThePackagesIdentity
{
	private const int TheBlockItIsTiedTo = 16;

	public static string? Of(string packagePath)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ALockedIndex? aLockedIndex = TheKeyThatOpensThisPackage.LockedIndexOf(packagePath);
		if (aLockedIndex.HasValue)
		{
			ALockedIndex valueOrDefault = aLockedIndex.GetValueOrDefault();
			try
			{
				FileStream val = new FileStream(packagePath, (FileMode)3, (FileAccess)1, (FileShare)7);
				try
				{
					byte[] array = new byte[16];
					((Stream)val).Seek(valueOrDefault.Offset, (SeekOrigin)0);
					if (((Stream)val).ReadAtLeast(global::System.Span<byte>.op_Implicit(array), array.Length, false) != array.Length)
					{
						return null;
					}
					return Of(global::System.ReadOnlySpan<byte>.op_Implicit(valueOrDefault.Fingerprint), valueOrDefault.Length, global::System.ReadOnlySpan<byte>.op_Implicit(array));
				}
				finally
				{
					((global::System.IDisposable)val)?.Dispose();
				}
			}
			catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
			{
				return null;
			}
		}
		return null;
	}

	public static string Of(global::System.ReadOnlySpan<byte> fingerprint, int indexLength, global::System.ReadOnlySpan<byte> firstLockedBlock)
	{
		byte[] array = new byte[fingerprint.Length + 4 + firstLockedBlock.Length];
		fingerprint.CopyTo(global::System.Span<byte>.op_Implicit(array));
		BitConverter.TryWriteBytes(MemoryExtensions.AsSpan<byte>(array, fingerprint.Length, 4), indexLength);
		firstLockedBlock.CopyTo(MemoryExtensions.AsSpan<byte>(array, fingerprint.Length + 4));
		return Convert.ToHexString(SHA256.HashData(array)).ToLowerInvariant();
	}

	public static bool Opens(string packagePath, byte[] key)
	{
		ArgumentNullException.ThrowIfNull((object)key, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CN());
		ALockedIndex? aLockedIndex = TheKeyThatOpensThisPackage.LockedIndexOf(packagePath);
		if (aLockedIndex.HasValue)
		{
			ALockedIndex valueOrDefault = aLockedIndex.GetValueOrDefault();
			byte[] array = TheKeyThatOpensThisPackage.ReadLockedIndex(packagePath, valueOrDefault);
			if (array != null)
			{
				return TheKeyThatOpensThisPackage.Opens(global::System.ReadOnlySpan<byte>.op_Implicit(array), valueOrDefault, global::System.ReadOnlySpan<byte>.op_Implicit(key));
			}
		}
		return false;
	}
}
