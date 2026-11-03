using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public static class ObjectArrayFinder
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<MemoryRegion, bool> _003C_003E9__6_0;

		public static Func<LiveObjectArray, int> _003C_003E9__6_1;

		internal bool A(MemoryRegion P_0)
		{
			if (P_0.IsImage)
			{
				return P_0.IsWritable;
			}
			return false;
		}

		internal int A(LiveObjectArray P_0)
		{
			return P_0.Count;
		}
	}

	public const int ItemsPerChunk = 65536;

	private static readonly int[] ItemStrides;

	private const int ConvincingObjects = 32;

	private const int MaxSaneObjects = 200000000;

	private const int ChunkSize = 65536;

	private const int Overlap = 64;

	public static LiveObjectArray? Find(ProcessMemory memory, UnrealObjects reader, Action<string>? say = null, Func<MemoryRegion, bool>? where = null)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)reader, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cn());
		if (where == null)
		{
			where = (MemoryRegion P_0) => P_0.IsImage && P_0.IsWritable;
		}
		List<MemoryRegion> val = Enumerable.ToList<MemoryRegion>(Enumerable.Where<MemoryRegion>(memory.ReadableRegions(), where));
		if (say != null)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ey());
			defaultInterpolatedStringHandler.AppendFormatted<int>(val.Count, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
			say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		List<LiveObjectArray> val2 = new List<LiveObjectArray>();
		Enumerator<MemoryRegion> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				MemoryRegion current = enumerator.Current;
				val2.AddRange((global::System.Collections.Generic.IEnumerable<LiveObjectArray>)A(memory, reader, current));
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
		return Enumerable.First<LiveObjectArray>((global::System.Collections.Generic.IEnumerable<LiveObjectArray>)Enumerable.OrderByDescending<LiveObjectArray, int>((global::System.Collections.Generic.IEnumerable<LiveObjectArray>)val2, (Func<LiveObjectArray, int>)((LiveObjectArray P_0) => P_0.Count)));
	}

	private static List<LiveObjectArray> A(ProcessMemory P_0, UnrealObjects P_1, MemoryRegion P_2)
	{
		byte[] array = new byte[65536];
		List<LiveObjectArray> val = new List<LiveObjectArray>();
		for (ulong num = 0uL; num < P_2.Size; num += 65472)
		{
			int num2 = (int)Math.Min(65536uL, P_2.Size - num);
			byte[] array2 = ((num2 == 65536) ? array : new byte[num2]);
			int num3 = P_0.TryReadBytes(P_2.Base + num, array2);
			if (num3 <= 0)
			{
				continue;
			}
			for (int i = 0; i + 32 <= num3; i += 8)
			{
				if (A(array2, i))
				{
					LiveObjectArray liveObjectArray = VerifyAt(P_0, P_1, P_2.Base + num + (ulong)i);
					if ((object)liveObjectArray != null)
					{
						val.Add(liveObjectArray);
					}
				}
			}
		}
		return val;
	}

	private static bool A(byte[] P_0, int P_1)
	{
		ulong num = BitConverter.ToUInt64(P_0, P_1);
		if (num <= 65536 || num >= 140737488355327L || (num & 7) != 0L)
		{
			return false;
		}
		int num2 = BitConverter.ToInt32(P_0, P_1 + 16);
		int num3 = BitConverter.ToInt32(P_0, P_1 + 20);
		int num4 = BitConverter.ToInt32(P_0, P_1 + 24);
		int num5 = BitConverter.ToInt32(P_0, P_1 + 28);
		if (num2 > 0 && num2 <= 200000000 && num3 > 0 && num3 <= num2 && num4 > 0 && num5 > 0 && num5 <= num4 && num2 == num4 * 65536)
		{
			return num5 >= (num3 + 65536 - 1) / 65536;
		}
		return false;
	}

	public static LiveObjectArray? VerifyAt(ProcessMemory memory, UnrealObjects reader, ulong address)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)reader, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cn());
		byte[] array = new byte[32];
		if (memory.TryReadBytes(address, array) != array.Length || !A(array, 0))
		{
			return null;
		}
		ulong address2 = BitConverter.ToUInt64(array, 0);
		int capacity = BitConverter.ToInt32(array, 16);
		int count = BitConverter.ToInt32(array, 20);
		int num = BitConverter.ToInt32(array, 28);
		byte[] array2 = new byte[num * 8];
		if (memory.TryReadBytes(address2, array2) != array2.Length)
		{
			return null;
		}
		List<ulong> val = new List<ulong>(num);
		for (int i = 0; i < num; i++)
		{
			ulong num2 = BitConverter.ToUInt64(array2, i * 8);
			if (num2 <= 65536 || num2 >= 140737488355327L)
			{
				return null;
			}
			val.Add(num2);
		}
		int[] itemStrides = ItemStrides;
		foreach (int num3 in itemStrides)
		{
			if (A(memory, reader, val[0], num3))
			{
				return new LiveObjectArray(address, (global::System.Collections.Generic.IReadOnlyList<ulong>)val, count, capacity, num3);
			}
		}
		return null;
	}

	private static bool A(ProcessMemory P_0, UnrealObjects P_1, ulong P_2, int P_3)
	{
		int num = 0;
		for (int i = 0; i < 64; i++)
		{
			if (num >= 32)
			{
				break;
			}
			ulong address = P_2 + (ulong)(i * P_3);
			byte[] array = new byte[8];
			if (P_0.TryReadBytes(address, array) != array.Length)
			{
				return false;
			}
			ulong num2 = BitConverter.ToUInt64(array, 0);
			if (num2 == 0L)
			{
				continue;
			}
			LiveObject? liveObject = P_1.Describe(P_0, num2);
			if (!liveObject.HasValue)
			{
				continue;
			}
			LiveObject valueOrDefault = liveObject.GetValueOrDefault();
			string name = valueOrDefault.Name;
			if (name != null && name.Length > 0)
			{
				string className = valueOrDefault.ClassName;
				if (className != null && className.Length > 0)
				{
					num++;
				}
			}
		}
		return num >= 32;
	}

	static ObjectArrayFinder()
	{
		int[] array = new int[5];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		ItemStrides = array;
	}
}
