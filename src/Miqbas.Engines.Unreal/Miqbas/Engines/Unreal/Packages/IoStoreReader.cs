using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public sealed class IoStoreReader : global::System.IDisposable
{
	private readonly IoStoreContainer _container;

	private readonly FileStream _store;

	private readonly IPakDecompressor? _decompressor;

	private readonly byte[]? _key;

	private readonly Aes? _aes;

	public const long LargestChunkRead = 268435456L;

	public bool Opens
	{
		get
		{
			if (_container.IsLocked)
			{
				return _key != null;
			}
			return true;
		}
	}

	public IoStoreContainer Container => _container;

	public global::System.Collections.Generic.IReadOnlyList<IoStoreChunk> Chunks => _container.Chunks;

	private IoStoreReader(IoStoreContainer P_0, FileStream P_1, IPakDecompressor? decompressor, byte[]? key)
	{
		_container = P_0;
		_store = P_1;
		_decompressor = decompressor;
		_key = key;
		if (key != null)
		{
			_aes = Aes.Create();
			((SymmetricAlgorithm)_aes).Key = key;
		}
	}

	public static IoStoreReader Open(string tocPath, IPakDecompressor? decompressor, byte[]? key = null)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		IoStoreContainer ioStoreContainer = IoStoreContainer.Open(tocPath);
		if (ioStoreContainer.IsLocked && key != null)
		{
			if (IoStoreContainer.KeyOpens(tocPath, key))
			{
				ioStoreContainer = IoStoreContainer.Open(tocPath, key);
			}
			else
			{
				key = null;
			}
		}
		string text = Path.ChangeExtension(tocPath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ax());
		if (!File.Exists(text))
		{
			throw new FileNotFoundException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aY() + Path.GetFileName(text));
		}
		return new IoStoreReader(ioStoreContainer, File.Open(text, (FileMode)3, (FileAccess)1, (FileShare)1), decompressor, ioStoreContainer.IsLocked ? key : null);
	}

	public byte[]? Read(IoStoreChunk chunk)
	{
		int blockSize = _container.BlockSize;
		if (blockSize <= 0 || chunk.Length <= 0 || chunk.Length > 268435456 || !Opens)
		{
			return null;
		}
		int num = (int)(chunk.Offset / blockSize);
		int num2 = (int)((chunk.Offset + chunk.Length - 1) / blockSize);
		if (num < 0 || num2 >= ((global::System.Collections.Generic.IReadOnlyCollection<IoStoreBlock>)_container.Blocks).Count)
		{
			return null;
		}
		byte[] array = new byte[(long)(num2 - num + 1) * (long)blockSize];
		int num3 = 0;
		for (int i = num; i <= num2; i++)
		{
			IoStoreBlock ioStoreBlock = _container.Blocks[i];
			byte[] array2 = new byte[(_key == null) ? ioStoreBlock.CompressedSize : ((ioStoreBlock.CompressedSize + 15) & -16)];
			((Stream)_store).Position = ioStoreBlock.Offset;
			((Stream)_store).ReadExactly(array2, 0, array2.Length);
			if (_aes != null)
			{
				array2 = ((SymmetricAlgorithm)_aes).DecryptEcb(array2, (PaddingMode)1)[..global::System.Index.op_Implicit(ioStoreBlock.CompressedSize)];
			}
			string text = ((ioStoreBlock.Method == 0) ? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ay() : A(ioStoreBlock.Method));
			global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(array, num3, ioStoreBlock.UncompressedSize);
			if (string.Equals(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ay(), (StringComparison)5))
			{
				MemoryExtensions.AsSpan<byte>(array2, 0, ioStoreBlock.UncompressedSize).CopyTo(span);
			}
			else
			{
				if (_decompressor == null)
				{
					return null;
				}
				try
				{
					if (_decompressor.Decompress(text, global::System.ReadOnlySpan<byte>.op_Implicit(array2), span) != ioStoreBlock.UncompressedSize)
					{
						return null;
					}
				}
				catch (global::System.Exception ex) when (!(ex is OutOfMemoryException))
				{
					return null;
				}
			}
			num3 += ioStoreBlock.UncompressedSize;
		}
		int num4 = (int)(chunk.Offset - (long)num * (long)blockSize);
		if (num4 + chunk.Length > num3)
		{
			return null;
		}
		return MemoryExtensions.AsSpan<byte>(array, num4, (int)chunk.Length).ToArray();
	}

	private string A(byte P_0)
	{
		if (P_0 - 1 >= ((global::System.Collections.Generic.IReadOnlyCollection<string>)_container.CompressionMethods).Count || P_0 < 1)
		{
			return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ay();
		}
		return _container.CompressionMethods[P_0 - 1];
	}

	public void Dispose()
	{
		Aes? aes = _aes;
		if (aes != null)
		{
			((SymmetricAlgorithm)aes).Dispose();
		}
		((Stream)_store).Dispose();
	}
}
