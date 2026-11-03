using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Packages;

public sealed class PakArchive : global::System.IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<PakEntry, bool> _003C_003E9__35_0;

		internal bool A(PakEntry P_0)
		{
			return P_0.Encrypted;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string wanted;

		internal bool A(PakEntry P_0)
		{
			return string.Equals(P_0.Path, wanted, (StringComparison)5);
		}
	}

	private static readonly byte[] FooterMagic;

	private const int FooterSearchWindow = 1024;

	private const int PathHashIndexVersion = 10;

	private const int FrozenIndexVersion = 9;

	private const int NamedMethodsVersion = 8;

	private const int RelativeBlocksVersion = 5;

	private readonly FileStream _stream;

	private readonly BinaryReader _reader;

	private const string ZlibMethod = "Zlib";

	private const string GzipMethod = "Gzip";

	private const string OodleMethod = "Oodle";

	[field: CompilerGenerated]
	public int Version
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	[field: CompilerGenerated]
	public string MountPoint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	} = string.Empty;


	[field: CompilerGenerated]
	public bool IndexEncrypted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<string> CompressionMethods
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	} = global::System.Array.Empty<string>();


	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<PakEntry> Entries
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	} = global::System.Array.Empty<PakEntry>();


	[field: CompilerGenerated]
	private byte[]? Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool SomeFilesAreLocked
	{
		get
		{
			if (Key == null)
			{
				return Enumerable.Any<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Encrypted));
			}
			return false;
		}
	}

	private PakArchive(FileStream P_0, BinaryReader P_1)
	{
		_stream = P_0;
		_reader = P_1;
	}

	public bool CanRead(PakEntry entry)
	{
		if ((object)entry == null || entry.Encrypted)
		{
			return Key != null;
		}
		return true;
	}

	public static PakArchive Open(string path)
	{
		return Open(path, null);
	}

	public static PakArchive OpenTheFirstThatOpens(global::System.Collections.Generic.IEnumerable<string> paths, byte[]? key = null)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)paths, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BZ());
		ExceptionDispatchInfo val = null;
		global::System.Collections.Generic.IEnumerator<string> enumerator = paths.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					return Open(current, key);
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					if (val == null)
					{
						val = ExceptionDispatchInfo.Capture(ex);
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (val != null)
		{
			val.Throw();
		}
		throw new FileNotFoundException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bz());
	}

	public static PakArchive Open(string path, byte[]? key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ArgumentException.ThrowIfNullOrWhiteSpace(path, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aT());
		FileStream val = new FileStream(path, (FileMode)3, (FileAccess)1, (FileShare)7);
		try
		{
			BinaryReader val2 = new BinaryReader((Stream)(object)val, Encoding.UTF8, true);
			return A(val, val2, path, key);
		}
		catch
		{
			((Stream)val).Dispose();
			throw;
		}
	}

	public PakEntry? Find(string path)
	{
		ArgumentNullException.ThrowIfNull((object)path, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aT());
		string wanted = path.Replace('\\', '/');
		return Enumerable.FirstOrDefault<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)Entries, (Func<PakEntry, bool>)((PakEntry P_0) => string.Equals(P_0.Path, wanted, (StringComparison)5)));
	}

	public byte[] Read(PakEntry entry, IPakDecompressor? decompressor = null)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)entry, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bA());
		if (entry.Encrypted && Key == null)
		{
			throw new NotSupportedException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba() + entry.Path + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bB());
		}
		if (entry.UncompressedSize > global::System.Array.MaxLength)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(45, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
			defaultInterpolatedStringHandler.AppendFormatted(entry.Path);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bb());
			defaultInterpolatedStringHandler.AppendFormatted<long>(entry.UncompressedSize);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bC());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		byte[] array = new byte[entry.UncompressedSize];
		if (!entry.IsCompressed)
		{
			((Stream)_stream).Position = entry.DataOffset;
			if (!entry.Encrypted)
			{
				a(array, 0, array.Length);
				return array;
			}
			byte[] array2 = new byte[A(array.Length)];
			a(array2, 0, array2.Length);
			A(array2, Key);
			MemoryExtensions.AsSpan<byte>(array2, 0, array.Length).CopyTo(global::System.Span<byte>.op_Implicit(array));
			return array;
		}
		if (decompressor == null || !decompressor.Supports(entry.CompressionMethod))
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(64, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
			defaultInterpolatedStringHandler.AppendFormatted(entry.Path);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bc());
			defaultInterpolatedStringHandler.AppendFormatted(entry.CompressionMethod);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bD());
			throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		int num = 0;
		global::System.Collections.Generic.IEnumerator<PakBlock> enumerator = ((global::System.Collections.Generic.IEnumerable<PakBlock>)entry.Blocks).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PakBlock current = enumerator.Current;
				byte[] array3 = new byte[entry.Encrypted ? A(current.Length) : current.Length];
				((Stream)_stream).Position = entry.Offset + current.Start;
				a(array3, 0, array3.Length);
				if (entry.Encrypted)
				{
					A(array3, Key);
				}
				int num2 = Math.Min(entry.CompressionBlockSize, array.Length - num);
				int num3 = decompressor.Decompress(entry.CompressionMethod, global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(array3, 0, current.Length)), MemoryExtensions.AsSpan<byte>(array, num, num2));
				if (num3 != num2)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(52, 3);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
					defaultInterpolatedStringHandler.AppendFormatted(entry.Path);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bd());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bE());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.be());
					throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				num += num3;
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (num != array.Length)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(44, 3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
			defaultInterpolatedStringHandler.AppendFormatted(entry.Path);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bF());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bE());
			defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.be());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return array;
	}

	public void Dispose()
	{
		_reader.Dispose();
		((Stream)_stream).Dispose();
	}

	private static PakArchive A(FileStream P_0, BinaryReader P_1, string P_2, byte[]? key)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		int num = (int)Math.Min(1024L, ((Stream)P_0).Length);
		byte[] array = new byte[num];
		((Stream)P_0).Position = ((Stream)P_0).Length - num;
		A((Stream)(object)P_0, array, 0, num);
		int num2 = B(array, FooterMagic);
		if (num2 < 0)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bf());
		}
		int num3 = (int)BitConverter.ToUInt32(array, num2 + 4);
		long num4 = BitConverter.ToInt64(array, num2 + 8);
		long num5 = BitConverter.ToInt64(array, num2 + 16);
		bool num6 = num3 >= 4 && num2 >= 1 && array[num2 - 1] != 0;
		List<string> val = A(array, num2, num3);
		if (num4 < 0 || num4 >= ((Stream)P_0).Length || num5 <= 0)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bG());
		}
		byte[] array2 = null;
		if (num6)
		{
			array2 = A(P_2, key);
			if (array2 == null)
			{
				return new PakArchive(P_0, P_1)
				{
					Version = num3,
					IndexEncrypted = true,
					CompressionMethods = (global::System.Collections.Generic.IReadOnlyList<string>)val
				};
			}
		}
		ValueTuple<string, List<PakEntry>> val2 = A(P_0, P_1, num3, num4, num5, (global::System.Collections.Generic.IReadOnlyList<string>)val, array2);
		string item = val2.Item1;
		List<PakEntry> item2 = val2.Item2;
		return new PakArchive(P_0, P_1)
		{
			Version = num3,
			MountPoint = item,
			IndexEncrypted = false,
			CompressionMethods = (global::System.Collections.Generic.IReadOnlyList<string>)val,
			Entries = (global::System.Collections.Generic.IReadOnlyList<PakEntry>)item2,
			Key = array2
		};
	}

	private static List<string> A(byte[] P_0, int P_1, int P_2)
	{
		if (P_2 < 8)
		{
			int num = 4;
			List<string> obj = new List<string>(num);
			CollectionsMarshal.SetCount<string>(obj, num);
			global::System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj);
			int num2 = 0;
			span[num2] = string.Empty;
			num2++;
			span[num2] = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bg();
			num2++;
			span[num2] = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bH();
			num2++;
			span[num2] = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bh();
			num2++;
			return obj;
		}
		List<string> obj2 = new List<string>();
		obj2.Add(string.Empty);
		List<string> val = obj2;
		for (int i = P_1 + 44 + ((P_2 == 9) ? 1 : 0); i + 32 <= P_0.Length; i += 32)
		{
			string text = Encoding.ASCII.GetString(P_0, i, 32).Trim('\0');
			if (text.Length > 0)
			{
				val.Add(text);
			}
		}
		return val;
	}

	private static byte[]? A(string path, byte[]? P_1)
	{
		if (P_1 != null)
		{
			ALockedIndex? aLockedIndex = TheKeyThatOpensThisPackage.LockedIndexOf(path);
			if (aLockedIndex.HasValue)
			{
				ALockedIndex valueOrDefault = aLockedIndex.GetValueOrDefault();
				byte[] array = TheKeyThatOpensThisPackage.ReadLockedIndex(path, valueOrDefault);
				if (array == null || !TheKeyThatOpensThisPackage.Opens(global::System.ReadOnlySpan<byte>.op_Implicit(array), valueOrDefault, global::System.ReadOnlySpan<byte>.op_Implicit(P_1)))
				{
					return null;
				}
				return P_1;
			}
		}
		return null;
	}

	private static int A(int P_0)
	{
		return (P_0 + 15) & -16;
	}

	private static void A(byte[] P_0, byte[] P_1)
	{
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Key = P_1;
			((SymmetricAlgorithm)val).Mode = (CipherMode)2;
			((SymmetricAlgorithm)val).Padding = (PaddingMode)1;
			((SymmetricAlgorithm)val).DecryptEcb(global::System.ReadOnlySpan<byte>.op_Implicit(P_0), global::System.Span<byte>.op_Implicit(P_0), (PaddingMode)1);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static byte[] a(byte[] P_0, byte[]? key)
	{
		if (key == null || P_0.Length < 16)
		{
			return P_0;
		}
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Key = key;
			((SymmetricAlgorithm)val).Mode = (CipherMode)2;
			((SymmetricAlgorithm)val).Padding = (PaddingMode)1;
			int num = P_0.Length - P_0.Length % 16;
			byte[] array = new byte[P_0.Length];
			((SymmetricAlgorithm)val).DecryptEcb(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, 0, num)), MemoryExtensions.AsSpan<byte>(array, 0, num), (PaddingMode)1);
			MemoryExtensions.AsSpan<byte>(P_0, num).CopyTo(MemoryExtensions.AsSpan<byte>(array, num));
			return array;
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static ValueTuple<string, List<PakEntry>> A(FileStream P_0, BinaryReader P_1, int P_2, long P_3, long P_4, global::System.Collections.Generic.IReadOnlyList<string> P_5, byte[]? key = null)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		if (P_4 <= 0 || P_4 > ((Stream)P_0).Length || P_3 > ((Stream)P_0).Length - P_4)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(42, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bI());
			defaultInterpolatedStringHandler.AppendFormatted<long>(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bi());
			defaultInterpolatedStringHandler.AppendFormatted<long>(((Stream)P_0).Length);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		((Stream)P_0).Position = P_3;
		byte[] array = new byte[P_4];
		A((Stream)(object)P_0, array, 0, array.Length);
		array = a(array, key);
		MemoryStream val = new MemoryStream(array, false);
		try
		{
			BinaryReader val2 = new BinaryReader((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				string text = global::A.C.A(val2);
				int num = val2.ReadInt32();
				if (num < 0 || num > ((Stream)P_0).Length)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(31, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bJ());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bj());
					defaultInterpolatedStringHandler.AppendFormatted<long>(((Stream)P_0).Length);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bK());
					throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				List<ValueTuple<string, long>> obj = ((P_2 >= 10) ? A(P_0, val2, num, key) : A(val2, num));
				List<PakEntry> val3 = new List<PakEntry>(obj.Count);
				int num2 = 0;
				Enumerator<ValueTuple<string, long>> enumerator = obj.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ValueTuple<string, long> current = enumerator.Current;
						string item = current.Item1;
						long item2 = current.Item2;
						try
						{
							val3.Add(A(P_0, P_1, P_2, P_5, item, item2));
						}
						catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is EndOfStreamException || ex is IOException) ? 1 : 0) != 0)
						{
							num2++;
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				if (val3.Count == 0 && num2 > 0)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(77, 1);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bk());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bL());
					throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				return new ValueTuple<string, List<PakEntry>>(text, val3);
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

	private static List<ValueTuple<string, long>> A(FileStream P_0, BinaryReader P_1, int P_2, byte[]? key = null)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		P_1.ReadUInt64();
		if (P_1.ReadInt32() != 0)
		{
			P_1.ReadInt64();
			P_1.ReadInt64();
			P_1.ReadBytes(20);
		}
		if (P_1.ReadInt32() == 0)
		{
			throw new NotSupportedException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bl());
		}
		long num = P_1.ReadInt64();
		long num2 = P_1.ReadInt64();
		P_1.ReadBytes(20);
		int num3 = P_1.ReadInt32();
		if (num3 < 0 || num3 > ((Stream)P_0).Length)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(40, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bM());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bm());
			defaultInterpolatedStringHandler.AppendFormatted<long>(((Stream)P_0).Length);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		byte[] array = P_1.ReadBytes(num3);
		List<long> val = new List<long>();
		if (P_1.BaseStream.Position + 4 <= P_1.BaseStream.Length)
		{
			int num4 = P_1.ReadInt32();
			for (int i = 0; i < num4; i++)
			{
				if (num4 > P_2)
				{
					break;
				}
				val.Add(P_1.ReadInt64());
				P_1.ReadInt64();
				P_1.ReadInt64();
				uint num5 = P_1.ReadUInt32();
				P_1.ReadBytes(20);
				if (num5 != 0)
				{
					int num6 = P_1.ReadInt32();
					if (num6 < 0 || num6 > P_1.BaseStream.Length / 16)
					{
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(50, 1);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bN());
						defaultInterpolatedStringHandler.AppendFormatted<int>(num6);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bn());
						throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					P_1.ReadBytes(16 * num6);
				}
				P_1.ReadByte();
				P_1.ReadUInt32();
			}
		}
		if (num <= 0 || num2 <= 0 || num2 > ((Stream)P_0).Length || num > ((Stream)P_0).Length - num2)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bO());
		}
		((Stream)P_0).Position = num;
		byte[] array2 = new byte[num2];
		A((Stream)(object)P_0, array2, 0, array2.Length);
		array2 = a(array2, key);
		MemoryStream val2 = new MemoryStream(array2, false);
		try
		{
			BinaryReader val3 = new BinaryReader((Stream)(object)val2, Encoding.UTF8, true);
			try
			{
				List<ValueTuple<string, long>> val4 = new List<ValueTuple<string, long>>();
				int num7 = val3.ReadInt32();
				if (num7 < 0 || num7 > array2.Length)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(36, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bo());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num7);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bP());
					defaultInterpolatedStringHandler.AppendFormatted<int>(array2.Length);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bK());
					throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				for (int j = 0; j < num7; j++)
				{
					string text = global::A.C.A(val3).TrimStart('/');
					int num8 = val3.ReadInt32();
					if (num8 < 0 || num8 > array2.Length)
					{
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(32, 3);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bp());
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bQ());
						defaultInterpolatedStringHandler.AppendFormatted<int>(num8);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bq());
						defaultInterpolatedStringHandler.AppendFormatted<int>(array2.Length);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bK());
						throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					for (int k = 0; k < num8; k++)
					{
						string text2 = global::A.C.A(val3);
						int num9 = val3.ReadInt32();
						if (num9 < 0)
						{
							if (-num9 - 1 < val.Count)
							{
								val4.Add(new ValueTuple<string, long>(text + text2, val[-num9 - 1]));
							}
						}
						else
						{
							val4.Add(new ValueTuple<string, long>(text + text2, A(array, num9)));
						}
					}
				}
				return val4;
			}
			finally
			{
				((global::System.IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val2)?.Dispose();
		}
	}

	internal static long A(byte[] P_0, int P_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 + 4 > P_0.Length)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bR());
		}
		uint num = BitConverter.ToUInt32(P_0, P_1);
		bool flag = (num & 0x80000000u) != 0;
		int num2 = P_1 + 4 + (((num & 0x3F) == 63) ? 4 : 0);
		if (num2 + (flag ? 4 : 8) > P_0.Length)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bR());
		}
		if (!flag)
		{
			return BitConverter.ToInt64(P_0, num2);
		}
		return BitConverter.ToUInt32(P_0, num2);
	}

	private static List<ValueTuple<string, long>> A(BinaryReader P_0, int P_1)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		List<ValueTuple<string, long>> val = new List<ValueTuple<string, long>>();
		for (int i = 0; i < P_1; i++)
		{
			string text = global::A.C.A(P_0).Replace('\\', '/').TrimStart('/');
			long num = P_0.ReadInt64();
			val.Add(new ValueTuple<string, long>(text, num));
			P_0.ReadInt64();
			P_0.ReadInt64();
			int num2 = P_0.ReadInt32();
			P_0.ReadBytes(20);
			if (num2 != 0)
			{
				int num3 = P_0.ReadInt32();
				if (num3 < 0 || (long)num3 * 16L > P_0.BaseStream.Length)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.br());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bS());
					throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				P_0.ReadBytes(num3 * 16);
			}
			P_0.ReadByte();
			P_0.ReadUInt32();
		}
		return val;
	}

	private static PakEntry A(FileStream P_0, BinaryReader P_1, int P_2, global::System.Collections.Generic.IReadOnlyList<string> P_3, string P_4, long P_5)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		if (P_5 < 0 || P_5 >= ((Stream)P_0).Length)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bs());
			defaultInterpolatedStringHandler.AppendFormatted<long>(P_5);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bT());
			defaultInterpolatedStringHandler.AppendFormatted<long>(((Stream)P_0).Length);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bK());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		((Stream)P_0).Position = P_5;
		P_1.ReadInt64();
		long num = P_1.ReadInt64();
		long num2 = P_1.ReadInt64();
		int num3 = P_1.ReadInt32();
		if (P_2 < 8)
		{
			num3 = a(num3);
		}
		if (num < 0 || num2 < 0 || num > ((Stream)P_0).Length || num2 > 2147483647 || ((num3 == 0) ? (num2 > ((Stream)P_0).Length) : (num2 > Math.Max(num, 1L) * 1000)))
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(45, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bt());
			defaultInterpolatedStringHandler.AppendFormatted<long>(num2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bU());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (num3 < 0 || num3 >= ((global::System.Collections.Generic.IReadOnlyCollection<string>)P_3).Count)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(50, 3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
			defaultInterpolatedStringHandler.AppendFormatted(P_4);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bu());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bV());
			defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Collections.Generic.IReadOnlyCollection<string>)P_3).Count);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bv());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (P_2 <= 1)
		{
			P_1.ReadInt64();
		}
		P_1.ReadBytes(20);
		List<PakBlock> val = new List<PakBlock>();
		byte b = 0;
		int compressionBlockSize = 0;
		if (P_2 >= 3)
		{
			if (num3 != 0)
			{
				int num4 = P_1.ReadInt32();
				if ((num4 < 0 || num4 > 1000000) ? true : false)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(31, 2);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ba());
					defaultInterpolatedStringHandler.AppendFormatted(P_4);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bW());
					defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bn());
					throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				long num5 = ((P_2 < 5) ? P_5 : 0);
				for (int i = 0; i < num4; i++)
				{
					val.Add(new PakBlock(P_1.ReadInt64() - num5, P_1.ReadInt64() - num5));
				}
			}
			b = P_1.ReadByte();
			compressionBlockSize = (int)P_1.ReadUInt32();
		}
		long num6 = ((Stream)P_0).Position - P_5;
		PakEntry obj = new PakEntry
		{
			Path = P_4,
			Offset = P_5,
			DataOffset = P_5 + num6,
			StoredSize = num,
			UncompressedSize = num2,
			CompressionMethodIndex = num3
		};
		string compressionMethod;
		if (num3 <= 0 || num3 >= ((global::System.Collections.Generic.IReadOnlyCollection<string>)P_3).Count)
		{
			if (num3 != 0)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bw());
				defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
				compressionMethod = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				compressionMethod = string.Empty;
			}
		}
		else
		{
			compressionMethod = P_3[num3];
		}
		obj.CompressionMethod = compressionMethod;
		obj.Encrypted = (b & 1) != 0;
		obj.CompressionBlockSize = compressionBlockSize;
		obj.Blocks = (global::System.Collections.Generic.IReadOnlyList<PakBlock>)val;
		return obj;
	}

	private static int a(int P_0)
	{
		switch (P_0 & -49)
		{
		case 0:
			return 0;
		case 1:
			return 1;
		case 2:
			return 2;
		case 4:
		case 16384:
			return 3;
		default:
			return -1;
		}
	}

	private static int B(byte[] P_0, byte[] P_1)
	{
		for (int num = P_0.Length - P_1.Length; num >= 0; num--)
		{
			bool flag = true;
			for (int i = 0; i < P_1.Length; i++)
			{
				if (P_0[num + i] != P_1[i])
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return num;
			}
		}
		return -1;
	}

	private void a(byte[] P_0, int P_1, int P_2)
	{
		A((Stream)(object)_stream, P_0, P_1, P_2);
	}

	private static void A(Stream P_0, byte[] P_1, int P_2, int P_3)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		int num;
		for (int i = 0; i < P_3; i += num)
		{
			num = P_0.Read(P_1, P_2 + i, P_3 - i);
			if (num <= 0)
			{
				throw new EndOfStreamException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bX());
			}
		}
	}

	static PakArchive()
	{
		byte[] array = new byte[4];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		FooterMagic = array;
	}
}
