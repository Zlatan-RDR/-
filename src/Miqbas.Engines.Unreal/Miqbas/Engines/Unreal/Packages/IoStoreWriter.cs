using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Packages;

public static class IoStoreWriter
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, bool> _003C_003E9__7_0;

		public static Func<string, long> _003C_003E9__7_1;

		internal bool A(string P_0)
		{
			return Path.GetFileNameWithoutExtension(P_0).Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HK(), (StringComparison)5);
		}

		internal long a(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return new FileInfo(P_0).Length;
		}
	}

	public const string MountPoint = "../../../";

	private const int BlockSize = 65536;

	private const int CompressionMethodNameLength = 32;

	private const int CompressionBlockEntrySize = 12;

	private const int OldestVersion = 3;

	private const uint NoEntry = 4294967295u;

	private const int ChunkMetaSize = 24;

	private const int PerfectHashWithOverflowVersion = 5;

	public static bool GameUsesContainers(string paksDirectory)
	{
		if (Directory.Exists(paksDirectory))
		{
			return Enumerable.Any<string>(Directory.EnumerateFiles(paksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u(), (SearchOption)0));
		}
		return false;
	}

	public static int? GameContainerVersion(string paksDirectory)
	{
		if (!Directory.Exists(paksDirectory))
		{
			return null;
		}
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)Enumerable.ThenByDescending<string, long>(Enumerable.OrderBy<string, bool>(Directory.EnumerateFiles(paksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u(), (SearchOption)0), (Func<string, bool>)((string P_0) => Path.GetFileNameWithoutExtension(P_0).Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HK(), (StringComparison)5))), (Func<string, long>)((string P_0) => new FileInfo(P_0).Length))).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					int version = IoStoreContainer.Open(current).Version;
					if (version >= 3)
					{
						return version;
					}
				}
				catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is NotSupportedException || ex is IOException) ? 1 : 0) != 0)
				{
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	public static void Write(string tocPath, string storePath, int version = 8)
	{
		Write(tocPath, storePath, version, global::System.Array.Empty<ValueTuple<IoStoreChunk, byte[]>>());
	}

	public static void Write(string tocPath, string storePath, int version, global::System.Collections.Generic.IReadOnlyList<ValueTuple<IoStoreChunk, byte[]>> chunks)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		ArgumentException.ThrowIfNullOrWhiteSpace(tocPath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aZ());
		ArgumentException.ThrowIfNullOrWhiteSpace(storePath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.az());
		ArgumentNullException.ThrowIfNull((object)chunks, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BA());
		if (version < 3 || version > 8)
		{
			string text = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ba();
			object obj = version;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(36, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BB());
			defaultInterpolatedStringHandler.AppendFormatted<int>(3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bb());
			defaultInterpolatedStringHandler.AppendFormatted<int>(8);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
			throw new ArgumentOutOfRangeException(text, obj, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		string directoryName = Path.GetDirectoryName(tocPath);
		if (!string.IsNullOrEmpty(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		byte[] store;
		byte[] array = Build(A(Path.GetFileNameWithoutExtension(tocPath)), version, chunks, out store);
		File.WriteAllBytes(storePath, store);
		File.WriteAllBytes(tocPath, array);
	}

	public static byte[] Build(ulong containerId, int version = 8)
	{
		byte[] store;
		return Build(containerId, version, global::System.Array.Empty<ValueTuple<IoStoreChunk, byte[]>>(), out store);
	}

	public static byte[] Build(ulong containerId, int version, global::System.Collections.Generic.IReadOnlyList<ValueTuple<IoStoreChunk, byte[]>> chunks, out byte[] store)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)chunks, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BA());
		byte[] array = A();
		List<ValueTuple<long, long>> val = new List<ValueTuple<long, long>>(((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<IoStoreChunk, byte[]>>)chunks).Count);
		List<ValueTuple<long, int>> val2 = new List<ValueTuple<long, int>>();
		MemoryStream val3 = new MemoryStream();
		try
		{
			global::System.Collections.Generic.IEnumerator<ValueTuple<IoStoreChunk, byte[]>> enumerator = ((global::System.Collections.Generic.IEnumerable<ValueTuple<IoStoreChunk, byte[]>>)chunks).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					byte[] item = enumerator.Current.Item2;
					val.Add(new ValueTuple<long, long>((long)val2.Count * 65536L, (long)item.Length));
					for (int i = 0; i < item.Length; i += 65536)
					{
						int num = Math.Min(65536, item.Length - i);
						val2.Add(new ValueTuple<long, int>(((Stream)val3).Position, num));
						((Stream)val3).Write(item, i, num);
						((Stream)val3).Write(global::System.ReadOnlySpan<byte>.op_Implicit(new byte[(16 - num % 16) % 16]));
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			store = val3.ToArray();
			MemoryStream val4 = new MemoryStream();
			try
			{
				BinaryWriter val5 = new BinaryWriter((Stream)(object)val4, Encoding.UTF8, true);
				try
				{
					val5.Write(IoStoreContainer.MagicBytes);
					val5.Write((byte)version);
					val5.Write((byte)0);
					val5.Write((ushort)0);
					val5.Write(144);
					val5.Write(((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<IoStoreChunk, byte[]>>)chunks).Count);
					val5.Write(val2.Count);
					val5.Write(12);
					val5.Write(0);
					val5.Write(32);
					val5.Write(65536);
					val5.Write(array.Length);
					val5.Write(1);
					val5.Write(containerId);
					val5.Write(new byte[16]);
					val5.Write((byte)8);
					val5.Write((byte)0);
					val5.Write((ushort)0);
					val5.Write(0);
					val5.Write(18446744073709551615uL);
					int num2 = ((version >= 5) ? ((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<IoStoreChunk, byte[]>>)chunks).Count : 0);
					val5.Write(num2);
					val5.Write(0);
					val5.Write(new byte[40]);
					if (((Stream)val4).Length != 144)
					{
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(43, 2);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bc());
						defaultInterpolatedStringHandler.AppendFormatted<long>(((Stream)val4).Length);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BD());
						defaultInterpolatedStringHandler.AppendFormatted<int>(144);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
						throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					enumerator = ((global::System.Collections.Generic.IEnumerable<ValueTuple<IoStoreChunk, byte[]>>)chunks).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
						{
							IoStoreChunk item2 = enumerator.Current.Item1;
							val5.Write(item2.Id);
							val5.Write(item2.Index);
							val5.Write((byte)0);
							val5.Write(item2.Type);
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator)?.Dispose();
					}
					Enumerator<ValueTuple<long, long>> enumerator2 = val.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ValueTuple<long, long> current = enumerator2.Current;
							long item3 = current.Item1;
							long item4 = current.Item2;
							val5.Write(A(item3));
							val5.Write(A(item4));
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					for (int j = 0; j < num2; j++)
					{
						val5.Write(j);
					}
					Enumerator<ValueTuple<long, int>> enumerator3 = val2.GetEnumerator();
					try
					{
						while (enumerator3.MoveNext())
						{
							ValueTuple<long, int> current2 = enumerator3.Current;
							long item5 = current2.Item1;
							int item6 = current2.Item2;
							val5.Write(a(item5));
							val5.Write(A(item6));
							val5.Write(A(item6));
							val5.Write((byte)0);
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator3).Dispose();
					}
					val5.Write(array);
					enumerator = ((global::System.Collections.Generic.IEnumerable<ValueTuple<IoStoreChunk, byte[]>>)chunks).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
						{
							_ = enumerator.Current;
							val5.Write(new byte[24]);
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator)?.Dispose();
					}
					val5.Flush();
					return val4.ToArray();
				}
				finally
				{
					((global::System.IDisposable)val5)?.Dispose();
				}
			}
			finally
			{
				((global::System.IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val3)?.Dispose();
		}
	}

	private static byte[] A(long P_0)
	{
		return new byte[5]
		{
			(byte)(P_0 >> 32),
			(byte)(P_0 >> 24),
			(byte)(P_0 >> 16),
			(byte)(P_0 >> 8),
			(byte)P_0
		};
	}

	private static byte[] a(long P_0)
	{
		return new byte[5]
		{
			(byte)P_0,
			(byte)(P_0 >> 8),
			(byte)(P_0 >> 16),
			(byte)(P_0 >> 24),
			(byte)(P_0 >> 32)
		};
	}

	private static byte[] A(int P_0)
	{
		return new byte[3]
		{
			(byte)P_0,
			(byte)(P_0 >> 8),
			(byte)(P_0 >> 16)
		};
	}

	private static byte[] A()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				global::A.C.A(val2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bd());
				val2.Write(1);
				val2.Write(4294967295u);
				val2.Write(4294967295u);
				val2.Write(4294967295u);
				val2.Write(4294967295u);
				val2.Write(0);
				val2.Write(0);
				val2.Flush();
				return val.ToArray();
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

	internal static ulong A(string P_0)
	{
		ulong num = 14695981039346656037uL;
		byte[] bytes = Encoding.Unicode.GetBytes(P_0.ToLowerInvariant());
		foreach (byte b in bytes)
		{
			num = (num ^ b) * 1099511628211L;
		}
		if (num != 18446744073709551615uL)
		{
			return num;
		}
		return num - 1;
	}
}
