using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Hunting;

public static class ByteRanges
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ByteRange, bool> _003C_003E9__0_0;

		public static Func<ByteRange, long> _003C_003E9__0_1;

		internal bool A(ByteRange P_0)
		{
			return P_0.End > P_0.Start;
		}

		internal long a(ByteRange P_0)
		{
			return P_0.Start;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public long inFile;
	}

	[CompilerGenerated]
	private sealed class B
	{
		public long compressed;

		public a CS_0024_003C_003E8__locals1;

		internal bool A(ByteRange P_0)
		{
			return P_0.Overlaps(CS_0024_003C_003E8__locals1.inFile, CS_0024_003C_003E8__locals1.inFile + compressed);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public long start;

		public long end;

		internal bool A(ByteRange P_0)
		{
			return P_0.Overlaps(start, end);
		}
	}

	public static System.Collections.Generic.IReadOnlyList<ByteRange> Merge(System.Collections.Generic.IEnumerable<ByteRange> reads)
	{
		ArgumentNullException.ThrowIfNull((object)reads, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nq());
		List<ByteRange> val = new List<ByteRange>();
		System.Collections.Generic.IEnumerator<ByteRange> enumerator = ((System.Collections.Generic.IEnumerable<ByteRange>)Enumerable.OrderBy<ByteRange, long>(Enumerable.Where<ByteRange>(reads, (Func<ByteRange, bool>)((ByteRange P_0) => P_0.End > P_0.Start)), (Func<ByteRange, long>)((ByteRange P_0) => P_0.Start))).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ByteRange current = enumerator.Current;
				if (val.Count > 0)
				{
					if (current.Start <= val[val.Count - 1].End)
					{
						int num = val.Count - 1;
						ByteRange byteRange = val[val.Count - 1];
						byteRange.End = Math.Max(val[val.Count - 1].End, current.End);
						val[num] = byteRange;
						continue;
					}
				}
				val.Add(current);
			}
			return (System.Collections.Generic.IReadOnlyList<ByteRange>)val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static System.Collections.Generic.IReadOnlyList<ByteRange> ThroughBlocks(System.Collections.Generic.IReadOnlyList<ByteRange> fileReads, long dataStart, System.Collections.Generic.IReadOnlyList<ValueTuple<long, long>> blocks)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)fileReads, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NR());
		ArgumentNullException.ThrowIfNull((object)blocks, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nr());
		List<ByteRange> val = new List<ByteRange>();
		long inFile = dataStart;
		long num = 0L;
		System.Collections.Generic.IEnumerator<ValueTuple<long, long>> enumerator = ((System.Collections.Generic.IEnumerable<ValueTuple<long, long>>)blocks).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ValueTuple<long, long> current = enumerator.Current;
				long compressed = current.Item1;
				long item = current.Item2;
				if (Enumerable.Any<ByteRange>((System.Collections.Generic.IEnumerable<ByteRange>)fileReads, (Func<ByteRange, bool>)((ByteRange P_0) => P_0.Overlaps(inFile, inFile + compressed))))
				{
					val.Add(new ByteRange(num, num + item));
				}
				inFile += compressed;
				num += item;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return Merge((System.Collections.Generic.IEnumerable<ByteRange>)val);
	}

	public static bool Touch(System.Collections.Generic.IReadOnlyList<ByteRange> reads, long start, long end)
	{
		return Enumerable.Any<ByteRange>((System.Collections.Generic.IEnumerable<ByteRange>)reads, (Func<ByteRange, bool>)((ByteRange P_0) => P_0.Overlaps(start, end)));
	}
}
