using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Packages;

[RequiredMember]
public sealed class IoStoreContainer
{
	[Flags]
	public enum ContainerFlags : byte
	{
		None = 0,
		Compressed = 1,
		Encrypted = 2,
		Signed = 4,
		Indexed = 8
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<char, bool> _003C_003E9__60_0;

		internal bool A(char P_0)
		{
			if (P_0 >= ' ')
			{
				return P_0 <= '~';
			}
			return false;
		}
	}

	public static readonly byte[] MagicBytes = Encoding.ASCII.GetBytes(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aX());

	public const int HeaderSize = 144;

	public const int CurrentVersion = 8;

	private const int DirectoryIndexVersion = 2;

	private const int PerfectHashVersion = 4;

	private const int PerfectHashWithOverflowVersion = 5;

	private const int ChunkIdSize = 12;

	private const int OffsetAndLengthSize = 10;

	private const int CompressionBlockSize = 12;

	private const int CompressionMethodNameSize = 32;

	private const int MetaSize = 24;

	private const int SignatureHashSize = 20;

	public const ulong InvalidContainerId = 18446744073709551615uL;

	[RequiredMember]
	[field: CompilerGenerated]
	public int Version
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public ulong ContainerId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public ContainerFlags Flags
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int BlockSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<IoStoreChunk> Chunks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<string> CompressionMethods
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int CompressionBlockCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<IoStoreBlock> Blocks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string? MountPoint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long DescribedLength
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool IsLocked => ((global::System.Enum)Flags).HasFlag((global::System.Enum)ContainerFlags.Encrypted);

	public byte CookedAssetKind
	{
		get
		{
			if (Version >= 4)
			{
				return 1;
			}
			return 2;
		}
	}

	public static IoStoreContainer Open(string path, byte[]? key = null)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(path, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aT());
		return Read(File.ReadAllBytes(path), key);
	}

	public static bool KeyOpens(string tocPath, byte[] key)
	{
		try
		{
			IoStoreContainer ioStoreContainer = Open(tocPath, key);
			int result;
			if (ioStoreContainer != null && ioStoreContainer.IsLocked)
			{
				string mountPoint = ioStoreContainer.MountPoint;
				if (mountPoint != null)
				{
					result = (A(mountPoint) ? 1 : 0);
					goto IL_0026;
				}
			}
			result = 0;
			goto IL_0026;
			IL_0026:
			return (byte)result != 0;
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	private static bool A(string P_0)
	{
		int length = P_0.Length;
		if (length > 0 && length < 1024 && (P_0.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Y(), (StringComparison)4) || P_0.StartsWith('/')))
		{
			return Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= ' ' && P_0 <= '~'));
		}
		return false;
	}

	public static IoStoreContainer Read(byte[] bytes, byte[]? key = null)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		try
		{
			return A(bytes, key);
		}
		catch (global::System.Exception ex) when (((ex is ArgumentException || ex is OverflowException || ex is IndexOutOfRangeException || ex is EndOfStreamException || ex is CryptographicException) ? 1 : 0) != 0)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aU(), ex);
		}
	}

	private static IoStoreContainer A(byte[] P_0, byte[]? key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.Length < 144)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.au());
		}
		if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(P_0, 0, MagicBytes.Length), global::System.ReadOnlySpan<byte>.op_Implicit(MagicBytes)))
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aV());
		}
		byte b = P_0[16];
		int num = BitConverter.ToInt32(P_0, 20);
		if (num != 144)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(52, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.av());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aW());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		int num2 = BitConverter.ToInt32(P_0, 24);
		int num3 = BitConverter.ToInt32(P_0, 28);
		int num4 = BitConverter.ToInt32(P_0, 32);
		int num5 = BitConverter.ToInt32(P_0, 36);
		int num6 = BitConverter.ToInt32(P_0, 40);
		int blockSize = BitConverter.ToInt32(P_0, 44);
		int num7 = BitConverter.ToInt32(P_0, 48);
		ulong containerId = BitConverter.ToUInt64(P_0, 56);
		ContainerFlags containerFlags = (ContainerFlags)P_0[80];
		int num8 = BitConverter.ToInt32(P_0, 84);
		int num9 = BitConverter.ToInt32(P_0, 96);
		if (num4 != 12)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(54, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aw());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aW());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		int num10 = 144;
		global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(P_0, num10, num2 * 12);
		num10 += num2 * 12;
		global::System.Span<byte> span2 = MemoryExtensions.AsSpan<byte>(P_0, num10, num2 * 10);
		num10 += num2 * 10;
		if (b >= 4)
		{
			num10 += num8 * 4;
		}
		if (b >= 5)
		{
			num10 += num9 * 4;
		}
		List<IoStoreBlock> val = new List<IoStoreBlock>(Math.Max(num3, 0));
		for (int i = 0; i < num3; i++)
		{
			global::System.Span<byte> span3 = MemoryExtensions.AsSpan<byte>(P_0, num10 + i * 12, 12);
			val.Add(new IoStoreBlock((long)(span3[0] | ((ulong)span3[1] << 8) | ((ulong)span3[2] << 16) | ((ulong)span3[3] << 24) | ((ulong)span3[4] << 32)), span3[5] | (span3[6] << 8) | (span3[7] << 16), span3[8] | (span3[9] << 8) | (span3[10] << 16), span3[11]));
		}
		num10 += num3 * 12;
		List<string> val2 = new List<string>(Math.Max(num5, 0));
		for (int j = 0; j < num5; j++)
		{
			string text = Encoding.ASCII.GetString(P_0, num10 + j * num6, num6).TrimEnd('\0');
			if (text.Length > 0)
			{
				val2.Add(text);
			}
		}
		num10 += num5 * num6;
		if (((global::System.Enum)containerFlags).HasFlag((global::System.Enum)ContainerFlags.Signed))
		{
			int num11 = BitConverter.ToInt32(P_0, num10);
			num10 += 4 + 2 * num11 + num3 * 20;
		}
		string mountPoint = null;
		if (b >= 2 && num7 > 0)
		{
			global::System.Span<byte> span4 = MemoryExtensions.AsSpan<byte>(P_0, num10, num7);
			if (!((global::System.Enum)containerFlags).HasFlag((global::System.Enum)ContainerFlags.Encrypted))
			{
				mountPoint = a(global::System.Span<byte>.op_Implicit(span4));
			}
			else if (key != null && num7 % 16 == 0)
			{
				mountPoint = a(global::System.ReadOnlySpan<byte>.op_Implicit(A(global::System.Span<byte>.op_Implicit(span4), key)));
			}
		}
		num10 += num7;
		num10 += num2 * 24;
		List<IoStoreChunk> val3 = new List<IoStoreChunk>(num2);
		for (int k = 0; k < num2; k++)
		{
			global::System.Span<byte> span5 = span.Slice(k * 12, 12);
			global::System.Span<byte> span6 = span2.Slice(k * 10, 10);
			ulong id = BitConverter.ToUInt64(global::System.Span<byte>.op_Implicit(span5));
			ref global::System.Span<byte> reference = ref span5;
			ushort index = BitConverter.ToUInt16(global::System.Span<byte>.op_Implicit(reference.Slice(8, reference.Length - 8)));
			byte type = span5[11];
			long offset = A(global::System.Span<byte>.op_Implicit(span6));
			reference = ref span6;
			val3.Add(new IoStoreChunk(id, index, type, offset, A(global::System.Span<byte>.op_Implicit(reference.Slice(5, reference.Length - 5)))));
		}
		return new IoStoreContainer
		{
			Version = b,
			ContainerId = containerId,
			Flags = containerFlags,
			BlockSize = blockSize,
			Chunks = (global::System.Collections.Generic.IReadOnlyList<IoStoreChunk>)val3,
			CompressionMethods = (global::System.Collections.Generic.IReadOnlyList<string>)val2,
			CompressionBlockCount = num3,
			Blocks = (global::System.Collections.Generic.IReadOnlyList<IoStoreBlock>)val,
			MountPoint = mountPoint,
			DescribedLength = num10
		};
	}

	internal static byte[] A(global::System.ReadOnlySpan<byte> locked, byte[] P_1)
	{
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Key = P_1;
			return ((SymmetricAlgorithm)val).DecryptEcb(locked, (PaddingMode)1);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private unsafe static long A(global::System.ReadOnlySpan<byte> P_0)
	{
		return (long)(((ulong)(*(byte*)P_0[0]) << 32) | ((ulong)(*(byte*)P_0[1]) << 24) | ((ulong)(*(byte*)P_0[2]) << 16) | ((ulong)(*(byte*)P_0[3]) << 8) | *(byte*)P_0[4]);
	}

	private static string a(global::System.ReadOnlySpan<byte> P_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		MemoryStream val = new MemoryStream(P_0.ToArray(), false);
		try
		{
			BinaryReader val2 = new BinaryReader((Stream)(object)val, Encoding.UTF8);
			try
			{
				return global::A.C.A(val2);
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public IoStoreContainer()
	{
	}
}
