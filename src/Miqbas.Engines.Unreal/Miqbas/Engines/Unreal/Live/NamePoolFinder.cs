using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public static class NamePoolFinder
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<MemoryRegion, bool> _003C_003E9__3_0;

		public static Func<MemoryRegion, long> _003C_003E9__3_1;

		public static Func<LiveNamePool, int> _003C_003E9__3_2;

		internal bool A(MemoryRegion P_0)
		{
			if (P_0.IsImage)
			{
				return P_0.IsWritable;
			}
			return false;
		}

		internal long a(MemoryRegion P_0)
		{
			return (long)P_0.Size;
		}

		internal int A(LiveNamePool P_0)
		{
			return ((global::System.Collections.Generic.IReadOnlyCollection<ulong>)P_0.Blocks).Count;
		}
	}

	private const int MaxBlocks = 8192;

	private const int ConvincingRun = 64;

	private static readonly int[] EntryOffsets = new int[2] { 0, 4 };

	private const int ChunkSize = 65536;

	private const int Overlap = 32;

	public static LiveNamePool? Find(ProcessMemory memory, Action<string>? say = null, Func<MemoryRegion, bool>? where = null)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		if (where == null)
		{
			where = (MemoryRegion P_0) => P_0.IsImage && P_0.IsWritable;
		}
		List<MemoryRegion> val = Enumerable.ToList<MemoryRegion>(Enumerable.Where<MemoryRegion>(memory.ReadableRegions(), where));
		long num = Enumerable.Sum<MemoryRegion>((global::System.Collections.Generic.IEnumerable<MemoryRegion>)val, (Func<MemoryRegion, long>)((MemoryRegion P_0) => (long)P_0.Size));
		if (say != null)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(37, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ey());
			defaultInterpolatedStringHandler.AppendFormatted<int>(val.Count, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eZ());
			defaultInterpolatedStringHandler.AppendFormatted<long>(num / 1048576, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ez());
			say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		List<LiveNamePool> val2 = new List<LiveNamePool>();
		Enumerator<MemoryRegion> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MemoryRegion current = enumerator.Current;
				val2.AddRange((global::System.Collections.Generic.IEnumerable<LiveNamePool>)A(memory, current));
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		if (val2.Count == 0)
		{
			return null;
		}
		if (val2.Count > 1 && say != null)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(38, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FA());
			defaultInterpolatedStringHandler.AppendFormatted<int>(val2.Count);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fa());
			say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return Enumerable.First<LiveNamePool>((global::System.Collections.Generic.IEnumerable<LiveNamePool>)Enumerable.OrderByDescending<LiveNamePool, int>((global::System.Collections.Generic.IEnumerable<LiveNamePool>)val2, (Func<LiveNamePool, int>)((LiveNamePool P_0) => ((global::System.Collections.Generic.IReadOnlyCollection<ulong>)P_0.Blocks).Count)));
	}

	private static List<LiveNamePool> A(ProcessMemory P_0, MemoryRegion P_1)
	{
		byte[] array = new byte[65536];
		List<LiveNamePool> val = new List<LiveNamePool>();
		for (ulong num = 0uL; num < P_1.Size; num += 65504)
		{
			int num2 = (int)Math.Min(65536uL, P_1.Size - num);
			byte[] array2 = ((num2 == 65536) ? array : new byte[num2]);
			int num3 = P_0.TryReadBytes(P_1.Base + num, array2);
			if (num3 > 0)
			{
				val.AddRange((global::System.Collections.Generic.IEnumerable<LiveNamePool>)A(P_0, P_1.Base + num, array2, num3));
			}
		}
		return val;
	}

	private static List<LiveNamePool> A(ProcessMemory P_0, ulong P_1, byte[] P_2, int P_3)
	{
		List<LiveNamePool> val = new List<LiveNamePool>();
		for (int i = 8; i + 16 <= P_3; i += 8)
		{
			uint num = BitConverter.ToUInt32(P_2, i - 8);
			uint num2 = BitConverter.ToUInt32(P_2, i - 4);
			if (num < 8192 && num2 <= 131072 && A(BitConverter.ToUInt64(P_2, i)))
			{
				LiveNamePool liveNamePool = VerifyAt(P_0, P_1 + (ulong)i);
				if ((object)liveNamePool != null)
				{
					val.Add(liveNamePool);
				}
			}
		}
		return val;
	}

	public static LiveNamePool? VerifyAt(ProcessMemory memory, ulong blocksAddress)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		if (blocksAddress < 8)
		{
			return null;
		}
		byte[] array = new byte[8];
		if (memory.TryReadBytes(blocksAddress - 8, array) != array.Length)
		{
			return null;
		}
		uint num = BitConverter.ToUInt32(array, 0);
		uint num2 = BitConverter.ToUInt32(array, 4);
		if (num >= 8192 || num2 > 131072)
		{
			return null;
		}
		byte[] array2 = new byte[(num + 2) * 8];
		if (memory.TryReadBytes(blocksAddress, array2) != array2.Length)
		{
			return null;
		}
		List<ulong> val = new List<ulong>((int)(num + 1));
		for (int i = 0; i <= num; i++)
		{
			ulong num3 = BitConverter.ToUInt64(array2, i * 8);
			if (!A(num3))
			{
				return null;
			}
			val.Add(num3);
		}
		if (BitConverter.ToUInt64(array2, (int)((num + 1) * 8)) != 0L)
		{
			return null;
		}
		byte[] array3 = new byte[4096];
		if (memory.TryReadBytes(val[0], array3) != array3.Length)
		{
			return null;
		}
		int[] entryOffsets = EntryOffsets;
		foreach (int num4 in entryOffsets)
		{
			if (!(NameEntry.ReadAt(global::System.ReadOnlySpan<byte>.op_Implicit(array3), num4) != _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ay()) && NameBlock.RunLength(global::System.ReadOnlySpan<byte>.op_Implicit(array3), num4, 64) >= 64)
			{
				return new LiveNamePool(blocksAddress, (global::System.Collections.Generic.IReadOnlyList<ulong>)val, num4);
			}
		}
		return null;
	}

	private static bool A(ulong P_0)
	{
		if (P_0 > 65536 && P_0 < 140737488355327L)
		{
			return (P_0 & 7) == 0;
		}
		return false;
	}

	public static Dictionary<uint, string> NamesById(ProcessMemory memory, LiveNamePool pool)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)pool, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FB());
		Dictionary<uint, string> val = new Dictionary<uint, string>();
		for (int i = 0; i < ((global::System.Collections.Generic.IReadOnlyCollection<ulong>)pool.Blocks).Count; i++)
		{
			byte[] array = A(memory, pool.Blocks[i]);
			ushort header;
			for (int j = pool.EntryOffset; j + 2 <= array.Length; j += NameEntry.StrideOf(header))
			{
				string text = NameEntry.ReadAt(global::System.ReadOnlySpan<byte>.op_Implicit(array), j);
				if (text == null)
				{
					break;
				}
				uint num = (uint)((i << 16) | (j / 2));
				val[num] = text;
				header = (ushort)(array[j] | (array[j + 1] << 8));
			}
		}
		return val;
	}

	public static List<string> ReadAllNames(ProcessMemory memory, LiveNamePool pool)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)pool, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FB());
		List<string> val = new List<string>();
		global::System.Collections.Generic.IEnumerator<ulong> enumerator = ((global::System.Collections.Generic.IEnumerable<ulong>)pool.Blocks).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ulong current = enumerator.Current;
				byte[] array = A(memory, current);
				if (array.Length != 0)
				{
					val.AddRange((global::System.Collections.Generic.IEnumerable<string>)NameBlock.NamesIn(global::System.ReadOnlySpan<byte>.op_Implicit(array), pool.EntryOffset));
				}
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static byte[] A(ProcessMemory P_0, ulong P_1)
	{
		byte[] array = new byte[131072];
		if (P_0.TryReadBytes(P_1, array) == array.Length)
		{
			return array;
		}
		byte[] array2 = new byte[4096];
		List<byte> val = new List<byte>(4096);
		for (int i = 0; i < 131072 && P_0.TryReadBytes(P_1 + (ulong)i, array2) == 4096; i += 4096)
		{
			val.AddRange((global::System.Collections.Generic.IEnumerable<byte>)array2);
		}
		return val.ToArray();
	}
}
