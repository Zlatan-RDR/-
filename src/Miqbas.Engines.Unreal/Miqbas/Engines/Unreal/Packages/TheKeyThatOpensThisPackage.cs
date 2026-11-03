using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Packages;

public static class TheKeyThatOpensThisPackage
{
	private const int BlockSize = 16;

	public const int KeyLength = 32;

	private const int LongestMountPoint = 512;

	private static readonly byte[] FooterMarker;

	private const int FooterSearchWindow = 256;

	public static bool ThereIsAShortRoad => global::A.B.IsAvailable;

	public static ALockedIndex? LockedIndexOf(string packagePath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		ArgumentException.ThrowIfNullOrWhiteSpace(packagePath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cl());
		try
		{
			FileStream val = new FileStream(packagePath, (FileMode)3, (FileAccess)1, (FileShare)7);
			try
			{
				int num = (int)Math.Min(((Stream)val).Length, 256L);
				if (num < FooterMarker.Length + 44)
				{
					return null;
				}
				byte[] array = new byte[num];
				((Stream)val).Seek((long)(-num), (SeekOrigin)2);
				if (((Stream)val).Read(array, 0, num) != num)
				{
					return null;
				}
				int num2 = MemoryExtensions.LastIndexOf<byte>(MemoryExtensions.AsSpan<byte>(array), global::System.ReadOnlySpan<byte>.op_Implicit(FooterMarker));
				if (num2 <= 0 || num2 + 44 > array.Length)
				{
					return null;
				}
				if (array[num2 - 1] == 0)
				{
					return null;
				}
				long num3 = BitConverter.ToInt64(array, num2 + 8);
				long num4 = BitConverter.ToInt64(array, num2 + 16);
				if (num3 <= 0 || num4 < 16 || num3 + num4 > ((Stream)val).Length || num4 > 2147483647)
				{
					return null;
				}
				return new ALockedIndex(num3, (int)num4, array[global::System.Index.op_Implicit(num2 + 24)..global::System.Index.op_Implicit(num2 + 44)]);
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

	public static byte[]? ReadLockedIndex(string packagePath, ALockedIndex index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		ArgumentException.ThrowIfNullOrWhiteSpace(packagePath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cl());
		try
		{
			FileStream val = new FileStream(packagePath, (FileMode)3, (FileAccess)1, (FileShare)7);
			try
			{
				byte[] array = new byte[index.Length];
				((Stream)val).Seek(index.Offset, (SeekOrigin)0);
				return (((Stream)val).ReadAtLeast(global::System.Span<byte>.op_Implicit(array), index.Length, false) == index.Length) ? array : null;
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

	public static bool CouldBeTheKey(global::System.ReadOnlySpan<byte> lockedIndex, global::System.ReadOnlySpan<byte> key)
	{
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Mode = (CipherMode)2;
			((SymmetricAlgorithm)val).Padding = (PaddingMode)1;
			return CouldBeTheKey(val, lockedIndex, key);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	public static bool CouldBeTheKey(Aes cipher, global::System.ReadOnlySpan<byte> lockedIndex, global::System.ReadOnlySpan<byte> key)
	{
		ArgumentNullException.ThrowIfNull((object)cipher, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CM());
		if (key.Length != 32 || lockedIndex.Length < 16)
		{
			return false;
		}
		global::System.Span<byte> span = stackalloc byte[16];
		if (global::A.B.IsAvailable)
		{
			global::A.B.A(lockedIndex, key, span);
		}
		else
		{
			((SymmetricAlgorithm)cipher).Key = key.ToArray();
			((SymmetricAlgorithm)cipher).DecryptEcb(lockedIndex.Slice(0, 16), span, (PaddingMode)1);
		}
		int num = BitConverter.ToInt32(global::System.Span<byte>.op_Implicit(span));
		if (num > -2)
		{
			if (num < 2 || num > 512)
			{
				goto IL_0088;
			}
		}
		else if (num < -512)
		{
			goto IL_0088;
		}
		bool flag = false;
		goto IL_008e;
		IL_0088:
		flag = true;
		goto IL_008e;
		IL_008e:
		if (flag)
		{
			return false;
		}
		byte b = span[4];
		if (b >= 32)
		{
			return b <= 126;
		}
		return false;
	}

	public static void UnlockFirstBlockOnTheProcessor(global::System.ReadOnlySpan<byte> locked, global::System.ReadOnlySpan<byte> key, global::System.Span<byte> into)
	{
		global::A.B.A(locked, key, into);
	}

	public static bool Opens(global::System.ReadOnlySpan<byte> lockedIndex, ALockedIndex index, global::System.ReadOnlySpan<byte> key)
	{
		ArgumentNullException.ThrowIfNull((object)index.Fingerprint, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cm());
		if (key.Length != 32 || lockedIndex.Length != index.Length || !CouldBeTheKey(lockedIndex, key))
		{
			return false;
		}
		byte[] array = new byte[index.Length];
		A(lockedIndex, key, global::System.Span<byte>.op_Implicit(array));
		return MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(SHA1.HashData(array)), global::System.ReadOnlySpan<byte>.op_Implicit(index.Fingerprint));
	}

	public static byte[]? Unlocked(global::System.ReadOnlySpan<byte> lockedIndex, ALockedIndex index, global::System.ReadOnlySpan<byte> key)
	{
		if (!Opens(lockedIndex, index, key))
		{
			return null;
		}
		byte[] array = new byte[index.Length];
		A(lockedIndex, key, global::System.Span<byte>.op_Implicit(array));
		return array;
	}

	private static void A(global::System.ReadOnlySpan<byte> P_0, global::System.ReadOnlySpan<byte> P_1, global::System.Span<byte> P_2)
	{
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Key = P_1.ToArray();
			((SymmetricAlgorithm)val).Mode = (CipherMode)2;
			((SymmetricAlgorithm)val).Padding = (PaddingMode)1;
			int num = P_0.Length - P_0.Length % 16;
			((SymmetricAlgorithm)val).DecryptEcb(P_0.Slice(0, num), P_2.Slice(0, num), (PaddingMode)1);
			int num2 = num;
			global::System.ReadOnlySpan<byte> readOnlySpan = P_0.Slice(num2, P_0.Length - num2);
			int num3 = num;
			readOnlySpan.CopyTo(P_2.Slice(num3, P_2.Length - num3));
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	static TheKeyThatOpensThisPackage()
	{
		byte[] array = new byte[4];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		FooterMarker = array;
	}
}
