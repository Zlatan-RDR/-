using System;
using System.Security.Cryptography;

namespace Miqbas.Engines.Unreal.Packages;

public static class TheKeyOnTheStack
{
	private const int WhereAKeyCanStart = 4;

	public static byte[]? InWindow(global::System.ReadOnlySpan<byte> stackWindow, global::System.ReadOnlySpan<byte> lockedIndex, ALockedIndex index)
	{
		if (stackWindow.Length < 32 || lockedIndex.Length < 32)
		{
			return null;
		}
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Mode = (CipherMode)2;
			((SymmetricAlgorithm)val).Padding = (PaddingMode)1;
			int num = stackWindow.Length - 32;
			for (int i = 0; i <= num; i += 4)
			{
				global::System.ReadOnlySpan<byte> key = stackWindow.Slice(i, 32);
				if (TheKeyThatOpensThisPackage.CouldBeTheKey(val, lockedIndex, key) && TheKeyThatOpensThisPackage.Opens(lockedIndex, index, key))
				{
					return key.ToArray();
				}
			}
			return null;
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}
}
