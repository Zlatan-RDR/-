using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public static class ZenPackage
{
	public sealed class Export : IEquatable<Export>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Export);
			}
		}

		[field: CompilerGenerated]
		public int Index
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int DataAt
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public long Size
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int MapEntryAt
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public Export(int Index, int DataAt, long Size, int MapEntryAt)
		{
			this.Index = Index;
			this.DataAt = DataAt;
			this.Size = Size;
			this.MapEntryAt = MapEntryAt;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hn());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Be());
			P_0.Append(((object)Index).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HO());
			P_0.Append(((object)DataAt).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BK());
			P_0.Append(((object)Size).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ho());
			P_0.Append(((object)MapEntryAt).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Export? left, Export? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(Export? left, Export? right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Index)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DataAt)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Size)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MapEntryAt);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Export);
		}

		[CompilerGenerated]
		public bool Equals(Export? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Index, other.Index) && EqualityComparer<int>.Default.Equals(DataAt, other.DataAt) && EqualityComparer<long>.Default.Equals(Size, other.Size))
				{
					return EqualityComparer<int>.Default.Equals(MapEntryAt, other.MapEntryAt);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private Export(Export P_0)
		{
			Index = P_0.Index;
			DataAt = P_0.DataAt;
			Size = P_0.Size;
			MapEntryAt = P_0.MapEntryAt;
		}

		[CompilerGenerated]
		public void Deconstruct(out int Index, out int DataAt, out long Size, out int MapEntryAt)
		{
			Index = this.Index;
			DataAt = this.DataAt;
			Size = this.Size;
			MapEntryAt = this.MapEntryAt;
		}
	}

	public sealed class Layout : IEquatable<Layout>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A _003C_003E9 = new A();

			public static Func<Export, int> _003C_003E9__12_0;

			internal int A(Export P_0)
			{
				return P_0.DataAt + (int)P_0.Size;
			}
		}

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Layout);
			}
		}

		[field: CompilerGenerated]
		public int HeaderSize
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public global::System.Collections.Generic.IReadOnlyList<Export> Exports
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public int DataEnd
		{
			get
			{
				if (((global::System.Collections.Generic.IReadOnlyCollection<Export>)Exports).Count != 0)
				{
					return Enumerable.Max<Export>((global::System.Collections.Generic.IEnumerable<Export>)Exports, (Func<Export, int>)((Export P_0) => P_0.DataAt + (int)P_0.Size));
				}
				return HeaderSize;
			}
		}

		public Layout(int HeaderSize, global::System.Collections.Generic.IReadOnlyList<Export> Exports)
		{
			this.HeaderSize = HeaderSize;
			this.Exports = Exports;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HP());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hp());
			P_0.Append(((object)HeaderSize).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HQ());
			P_0.Append((object)Exports);
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hq());
			P_0.Append(((object)DataEnd).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Layout? left, Layout? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(Layout? left, Layout? right)
		{
			if ((object)left != right)
			{
				return left?.Equals(right) ?? false;
			}
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(HeaderSize)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<Export>>.Default.GetHashCode(Exports);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Layout);
		}

		[CompilerGenerated]
		public bool Equals(Layout? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(HeaderSize, other.HeaderSize))
				{
					return EqualityComparer<global::System.Collections.Generic.IReadOnlyList<Export>>.Default.Equals(Exports, other.Exports);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private Layout(Layout P_0)
		{
			HeaderSize = P_0.HeaderSize;
			Exports = P_0.Exports;
		}

		[CompilerGenerated]
		public void Deconstruct(out int HeaderSize, out global::System.Collections.Generic.IReadOnlyList<Export> Exports)
		{
			HeaderSize = this.HeaderSize;
			Exports = this.Exports;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B
	{
		public static readonly B _003C_003E9 = new B();

		public static Func<ValueTuple<int, int, byte[]>, int> _003C_003E9__7_0;

		public static Func<Export, int> _003C_003E9__7_1;

		public static Func<Export, long> _003C_003E9__7_2;

		internal int A(ValueTuple<int, int, byte[]> e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return e.Item1;
		}

		internal int A(Export P_0)
		{
			return P_0.Index;
		}

		internal long a(Export P_0)
		{
			return 0L;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public int at;

		public int length;

		internal bool A(Export P_0)
		{
			if (at >= P_0.DataAt)
			{
				return at + length <= P_0.DataAt + P_0.Size;
			}
			return false;
		}
	}

	private const int ExportMapEntrySize = 72;

	private const int BundleEntrySize = 8;

	private const uint Serialize = 1u;

	private static readonly int[] AllowedTail = new int[2] { 0, 4 };

	public static Layout? Read(global::System.ReadOnlySpan<byte> bytes)
	{
		if (bytes.Length < 64)
		{
			return null;
		}
		uint num = BitConverter.ToUInt32(bytes.Slice(0, 4));
		int num2 = BitConverter.ToInt32(bytes.Slice(4, 4));
		int num3 = BitConverter.ToInt32(bytes.Slice(32, 4));
		int num4 = BitConverter.ToInt32(bytes.Slice(36, 4));
		int num5 = BitConverter.ToInt32(bytes.Slice(40, 4));
		if (num != 0 || num2 <= 0 || num2 > bytes.Length || num3 <= 0 || num4 < num3 || num5 < num4 || num5 > num2 || (num4 - num3) % 72 != 0 || (num5 - num4) % 8 != 0)
		{
			return null;
		}
		int num6 = (num4 - num3) / 72;
		long[] array = new long[num6];
		for (int i = 0; i < num6; i++)
		{
			array[i] = BitConverter.ToInt64(bytes.Slice(num3 + i * 72 + 8, 8));
			if (array[i] < 0 || array[i] > bytes.Length)
			{
				return null;
			}
		}
		List<Export> val = new List<Export>(num6);
		HashSet<int> val2 = new HashSet<int>();
		long num7 = num2;
		for (int j = num4; j < num5; j += 8)
		{
			int num8 = BitConverter.ToInt32(bytes.Slice(j, 4));
			if (BitConverter.ToUInt32(bytes.Slice(j + 4, 4)) == 1)
			{
				if (num8 < 0 || num8 >= num6 || !val2.Add(num8))
				{
					return null;
				}
				val.Add(new Export(num8, (int)num7, array[num8], num3 + num8 * 72));
				num7 += array[num8];
			}
		}
		if (!Enumerable.Contains<int>((global::System.Collections.Generic.IEnumerable<int>)AllowedTail, (int)(bytes.Length - num7)))
		{
			return null;
		}
		return new Layout(num2, (global::System.Collections.Generic.IReadOnlyList<Export>)val);
	}

	public static byte[]? Splice(byte[] bytes, global::System.Collections.Generic.IReadOnlyList<ValueTuple<int, int, byte[]>> edits)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		ArgumentNullException.ThrowIfNull((object)edits, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CU());
		Layout layout = Read(global::System.ReadOnlySpan<byte>.op_Implicit(bytes));
		if ((object)layout == null)
		{
			return null;
		}
		List<ValueTuple<int, int, byte[]>> val = Enumerable.ToList<ValueTuple<int, int, byte[]>>((global::System.Collections.Generic.IEnumerable<ValueTuple<int, int, byte[]>>)Enumerable.OrderBy<ValueTuple<int, int, byte[]>, int>((global::System.Collections.Generic.IEnumerable<ValueTuple<int, int, byte[]>>)edits, (Func<ValueTuple<int, int, byte[]>, int>)((ValueTuple<int, int, byte[]> e) => e.Item1)));
		for (int i = 0; i < val.Count; i++)
		{
			ValueTuple<int, int, byte[]> val2 = val[i];
			if (val2.Item2 < 0 || (i > 0 && val2.Item1 < val[i - 1].Item1 + val[i - 1].Item2) || (object)A(layout, val2.Item1, val2.Item2) == null)
			{
				return null;
			}
		}
		Dictionary<int, long> val3 = Enumerable.ToDictionary<Export, int, long>((global::System.Collections.Generic.IEnumerable<Export>)layout.Exports, (Func<Export, int>)((Export P_0) => P_0.Index), (Func<Export, long>)((Export P_0) => 0L));
		MemoryStream val4 = new MemoryStream(bytes.Length + 1024);
		try
		{
			int num = 0;
			Enumerator<ValueTuple<int, int, byte[]>> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ValueTuple<int, int, byte[]> current = enumerator.Current;
					int item = current.Item1;
					int item2 = current.Item2;
					byte[] item3 = current.Item3;
					((Stream)val4).Write(bytes, num, item - num);
					((Stream)val4).Write(global::System.ReadOnlySpan<byte>.op_Implicit(item3));
					num = item + item2;
					Dictionary<int, long> val5 = val3;
					int index = A(layout, item, item2).Index;
					val5[index] += item3.Length - item2;
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			((Stream)val4).Write(bytes, num, bytes.Length - num);
			byte[] array = val4.ToArray();
			long num2 = 0L;
			global::System.Collections.Generic.IEnumerator<Export> enumerator2 = ((global::System.Collections.Generic.IEnumerable<Export>)layout.Exports).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					Export current2 = enumerator2.Current;
					int mapEntryAt = current2.MapEntryAt;
					if (num2 != 0L)
					{
						long num3 = BitConverter.ToInt64(array, mapEntryAt) + num2;
						BitConverter.TryWriteBytes(MemoryExtensions.AsSpan<byte>(array, mapEntryAt, 8), num3);
					}
					long num4 = val3[current2.Index];
					if (num4 != 0L)
					{
						BitConverter.TryWriteBytes(MemoryExtensions.AsSpan<byte>(array, mapEntryAt + 8, 8), current2.Size + num4);
						num2 += num4;
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator2)?.Dispose();
			}
			return ((object)Read(global::System.ReadOnlySpan<byte>.op_Implicit(array)) == null) ? null : array;
		}
		finally
		{
			((global::System.IDisposable)val4)?.Dispose();
		}
	}

	private static Export? A(Layout P_0, int P_1, int P_2)
	{
		return Enumerable.FirstOrDefault<Export>((global::System.Collections.Generic.IEnumerable<Export>)P_0.Exports, (Func<Export, bool>)((Export P_0) => P_1 >= P_0.DataAt && P_1 + P_2 <= P_0.DataAt + P_0.Size));
	}
}
