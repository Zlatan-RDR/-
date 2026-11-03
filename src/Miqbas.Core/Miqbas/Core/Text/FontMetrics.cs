using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public sealed class FontMetrics : IDrawSomeCharacters
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Predicate<ValueTuple<double, double, bool>> _003C_003E9__34_0;

		internal bool A(ValueTuple<double, double, bool> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return p.Item3;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public ValueTuple<double, double, double, double, double, double> m;

		public Func<ValueTuple<double, double>, ValueTuple<double, double>> _003C_003E9__0;

		internal ValueTuple<double, double> A(ValueTuple<double, double> p)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<double, double>(m.Item1 * p.Item1 + m.Item3 * p.Item2 + m.Item5, m.Item2 * p.Item1 + m.Item4 * p.Item2 + m.Item6);
		}
	}

	private readonly Dictionary<int, int> _codepointToGlyph;

	private readonly int[] _advanceWidths;

	private readonly int _unitsPerEm;

	private readonly int[]? _glyphOutlineOffsets;

	private readonly byte[]? _sfnt;

	private readonly int _glyfOffset;

	public int UnitsPerEm => _unitsPerEm;

	[field: CompilerGenerated]
	public int Ascender
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	[field: CompilerGenerated]
	public int Descender
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	[field: CompilerGenerated]
	public int LineGap
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	public System.Collections.Generic.IReadOnlyCollection<int> Characters => (System.Collections.Generic.IReadOnlyCollection<int>)_codepointToGlyph.Keys;

	public bool OutlinesAreReadable => _glyphOutlineOffsets != null;

	[field: CompilerGenerated]
	public bool? AMarkIsDrawnRightOfWhereItStands
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	private FontMetrics(Dictionary<int, int> P_0, int[] P_1, int P_2, int[]? glyphOutlineOffsets, byte[]? sfnt = null, int P_5 = 0)
	{
		_codepointToGlyph = P_0;
		_advanceWidths = P_1;
		_unitsPerEm = P_2;
		_glyphOutlineOffsets = glyphOutlineOffsets;
		_sfnt = sfnt;
		_glyfOffset = P_5;
	}

	public static FontMetrics Load(string fontPath)
	{
		return A(File.ReadAllBytes(fontPath));
	}

	public static FontMetrics Read(byte[] fontFile)
	{
		return A(fontFile);
	}

	public double Measure(string text, double fontSize)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		double num = 0.0;
		StringRuneEnumerator val = text.EnumerateRunes();
		StringRuneEnumerator enumerator = ((StringRuneEnumerator)(ref val)).GetEnumerator();
		try
		{
			while (((StringRuneEnumerator)(ref enumerator)).MoveNext())
			{
				Rune current = ((StringRuneEnumerator)(ref enumerator)).Current;
				num += A(((Rune)(ref current)).Value);
			}
		}
		finally
		{
			((System.IDisposable)(StringRuneEnumerator)(ref enumerator)).Dispose();
		}
		return num * fontSize / (double)_unitsPerEm;
	}

	private double A(int P_0)
	{
		int num = default(int);
		if (!_codepointToGlyph.TryGetValue(P_0, ref num) || num >= _advanceWidths.Length)
		{
			int num2;
			if (_advanceWidths.Length == 0)
			{
				num2 = 0;
			}
			else
			{
				int[] advanceWidths = _advanceWidths;
				num2 = advanceWidths[advanceWidths.Length - 1];
			}
			return num2;
		}
		return _advanceWidths[num];
	}

	public bool Has(int codepoint)
	{
		return _codepointToGlyph.ContainsKey(codepoint);
	}

	public ValueTuple<float, float, float> AsUnityWritesThemAt(float pointSize)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (_unitsPerEm <= 0)
		{
			return new ValueTuple<float, float, float>(0f, 0f, 0f);
		}
		float num = pointSize / (float)_unitsPerEm;
		return new ValueTuple<float, float, float>((float)Ascender * num, (float)Descender * num, (float)(Ascender - Descender + LineGap) * num);
	}

	public int OutlineBytesOf(int codepoint)
	{
		if (_glyphOutlineOffsets == null)
		{
			return -1;
		}
		int num = default(int);
		if (!_codepointToGlyph.TryGetValue(codepoint, ref num) || num < 0 || num + 1 >= _glyphOutlineOffsets.Length)
		{
			return 0;
		}
		return Math.Max(0, _glyphOutlineOffsets[num + 1] - _glyphOutlineOffsets[num]);
	}

	public int AdvanceUnitsOf(int codepoint)
	{
		return (int)A(codepoint);
	}

	public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>> Outline(int codepoint, int stepsPerCurve = 4)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		if (_sfnt == null || _glyphOutlineOffsets == null || !_codepointToGlyph.TryGetValue(codepoint, ref num))
		{
			return System.Array.Empty<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>>();
		}
		List<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>> val = new List<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>>();
		A(num, new ValueTuple<double, double, double, double, double, double>(1.0, 0.0, 0.0, 1.0, 0.0, 0.0), val, Math.Max(1, stepsPerCurve), 0);
		return (System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>>)val;
	}

	private void A(int P_0, ValueTuple<double, double, double, double, double, double> m, List<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>> contours, int P_3, int P_4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (P_4 > 8 || P_0 < 0 || P_0 + 1 >= _glyphOutlineOffsets.Length)
		{
			return;
		}
		int num = _glyphOutlineOffsets[P_0];
		if (_glyphOutlineOffsets[P_0 + 1] - num <= 0)
		{
			return;
		}
		System.Span<byte> span = MemoryExtensions.AsSpan<byte>(_sfnt, _glyfOffset + num);
		short num2 = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(span));
		ref System.Span<byte> reference;
		if (num2 < 0)
		{
			reference = ref span;
			A(System.Span<byte>.op_Implicit(reference.Slice(10, reference.Length - 10)), m, contours, P_3, P_4);
			return;
		}
		int[] array = new int[num2];
		int num4;
		for (int i = 0; i < num2; i++)
		{
			int num3 = i;
			reference = ref span;
			num4 = 10 + 2 * i;
			array[num3] = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(reference.Slice(num4, reference.Length - num4)));
		}
		int num5;
		if (num2 != 0)
		{
			num5 = array[array.Length - 1] + 1;
		}
		else
		{
			num5 = 0;
		}
		int num6 = num5;
		int num7 = 10 + 2 * num2;
		int num8 = num7;
		reference = ref span;
		num4 = num7;
		num7 = num8 + (2 + BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(reference.Slice(num4, reference.Length - num4))));
		byte[] array2 = new byte[num6];
		int num9 = 0;
		while (num9 < num6)
		{
			byte b = span[num7++];
			array2[num9++] = b;
			if ((b & 8) == 0)
			{
				continue;
			}
			byte b2 = span[num7++];
			for (int j = 0; j < b2; j++)
			{
				if (num9 >= num6)
				{
					break;
				}
				array2[num9++] = b;
			}
		}
		int[] array3 = new int[num6];
		int[] array4 = new int[num6];
		num7 = A(System.Span<byte>.op_Implicit(span), num7, array2, array3, 2, 16);
		A(System.Span<byte>.op_Implicit(span), num7, array2, array4, 4, 32);
		int num10 = 0;
		int[] array5 = array;
		foreach (int num11 in array5)
		{
			List<ValueTuple<double, double, bool>> val = new List<ValueTuple<double, double, bool>>();
			for (int k = num10; k <= num11; k++)
			{
				val.Add(new ValueTuple<double, double, bool>((double)array3[k], (double)array4[k], (array2[k] & 1) != 0));
			}
			num10 = num11 + 1;
			List<ValueTuple<double, double>> val2 = A(val, P_3);
			if (val2.Count > 2)
			{
				contours.Add((System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)Enumerable.ToList<ValueTuple<double, double>>(Enumerable.Select<ValueTuple<double, double>, ValueTuple<double, double>>((System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)val2, (Func<ValueTuple<double, double>, ValueTuple<double, double>>)((ValueTuple<double, double> p) => new ValueTuple<double, double>(m.Item1 * p.Item1 + m.Item3 * p.Item2 + m.Item5, m.Item2 * p.Item1 + m.Item4 * p.Item2 + m.Item6)))));
			}
		}
	}

	private unsafe static int A(System.ReadOnlySpan<byte> data, int P_1, byte[] P_2, int[] P_3, int P_4, int P_5)
	{
		int num = 0;
		for (int i = 0; i < P_2.Length; i++)
		{
			byte b = P_2[i];
			if ((b & P_4) != 0)
			{
				byte b2 = *(byte*)data[P_1++];
				num += (((b & P_5) != 0) ? b2 : (-b2));
			}
			else if ((b & P_5) == 0)
			{
				int num2 = num;
				int num3 = P_1;
				num = num2 + BinaryPrimitives.ReadInt16BigEndian(data.Slice(num3, data.Length - num3));
				P_1 += 2;
			}
			P_3[i] = num;
		}
		return P_1;
	}

	private static List<ValueTuple<double, double>> A(List<ValueTuple<double, double, bool>> points, int P_1)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		List<ValueTuple<double, double>> val = new List<ValueTuple<double, double>>();
		if (points.Count == 0)
		{
			return val;
		}
		int num = points.FindIndex((Predicate<ValueTuple<double, double, bool>>)((ValueTuple<double, double, bool> p) => p.Item3));
		ValueTuple<double, double> val2 = default(ValueTuple<double, double>);
		if (num < 0)
		{
			val2 = new ValueTuple<double, double>((points[0].Item1 + points[1 % points.Count].Item1) / 2.0, (points[0].Item2 + points[1 % points.Count].Item2) / 2.0);
			num = 0;
		}
		else
		{
			val2._002Ector(points[num].Item1, points[num].Item2);
			num++;
		}
		val.Add(val2);
		ValueTuple<double, double> from = val2;
		ValueTuple<double, double>? val3 = null;
		ValueTuple<double, double> val5 = default(ValueTuple<double, double>);
		for (int i = 0; i < points.Count; i++)
		{
			ValueTuple<double, double, bool> val4 = points[(num + i) % points.Count];
			if (val4.Item3)
			{
				if (val3.HasValue)
				{
					ValueTuple<double, double> valueOrDefault = val3.GetValueOrDefault();
					A(val, from, valueOrDefault, new ValueTuple<double, double>(val4.Item1, val4.Item2), P_1);
					val3 = null;
				}
				else
				{
					val.Add(new ValueTuple<double, double>(val4.Item1, val4.Item2));
				}
				from._002Ector(val4.Item1, val4.Item2);
			}
			else if (val3.HasValue)
			{
				ValueTuple<double, double> valueOrDefault2 = val3.GetValueOrDefault();
				val5._002Ector((valueOrDefault2.Item1 + val4.Item1) / 2.0, (valueOrDefault2.Item2 + val4.Item2) / 2.0);
				A(val, from, valueOrDefault2, val5, P_1);
				from = val5;
				val3 = new ValueTuple<double, double>(val4.Item1, val4.Item2);
			}
			else
			{
				val3 = new ValueTuple<double, double>(val4.Item1, val4.Item2);
			}
		}
		if (val3.HasValue)
		{
			ValueTuple<double, double> valueOrDefault3 = val3.GetValueOrDefault();
			A(val, from, valueOrDefault3, val2, P_1);
		}
		if (val.Count > 1)
		{
			ValueTuple<double, double> val6 = val[0];
			ValueTuple<double, double> val7 = val[val.Count - 1];
			if (val6.Item1 == val7.Item1 && val6.Item2 == val7.Item2)
			{
				val.RemoveAt(val.Count - 1);
			}
		}
		return val;
	}

	private static void A(List<ValueTuple<double, double>> output, ValueTuple<double, double> from, ValueTuple<double, double> control, ValueTuple<double, double> to, int P_4)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i <= P_4; i++)
		{
			double num = (double)i / (double)P_4;
			double num2 = 1.0 - num;
			output.Add(new ValueTuple<double, double>(num2 * num2 * from.Item1 + 2.0 * num2 * num * control.Item1 + num * num * to.Item1, num2 * num2 * from.Item2 + 2.0 * num2 * num * control.Item2 + num * num * to.Item2));
		}
	}

	private unsafe void A(System.ReadOnlySpan<byte> P_0, ValueTuple<double, double, double, double, double, double> m, List<System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>> contours, int P_3, int P_4)
	{
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		ushort num3;
		ValueTuple<double, double, double, double, double, double> m2 = default(ValueTuple<double, double, double, double, double, double>);
		do
		{
			ref System.ReadOnlySpan<byte> reference = ref P_0;
			int num2 = num;
			num3 = BinaryPrimitives.ReadUInt16BigEndian(reference.Slice(num2, reference.Length - num2));
			reference = ref P_0;
			num2 = num + 2;
			ushort num4 = BinaryPrimitives.ReadUInt16BigEndian(reference.Slice(num2, reference.Length - num2));
			num += 4;
			double num5;
			double num6;
			if (((uint)num3 & (true ? 1u : 0u)) != 0)
			{
				reference = ref P_0;
				num2 = num;
				num5 = BinaryPrimitives.ReadInt16BigEndian(reference.Slice(num2, reference.Length - num2));
				reference = ref P_0;
				num2 = num + 2;
				num6 = BinaryPrimitives.ReadInt16BigEndian(reference.Slice(num2, reference.Length - num2));
				num += 4;
			}
			else
			{
				num5 = (sbyte)(*(byte*)P_0[num]);
				num6 = (sbyte)(*(byte*)P_0[num + 1]);
				num += 2;
			}
			double num7 = 1.0;
			double num8 = 0.0;
			double num9 = 0.0;
			double num10 = 1.0;
			if ((num3 & 8u) != 0)
			{
				reference = ref P_0;
				num2 = num;
				num7 = (num10 = A(reference.Slice(num2, reference.Length - num2)));
				num += 2;
			}
			else if ((num3 & 0x40u) != 0)
			{
				reference = ref P_0;
				num2 = num;
				num7 = A(reference.Slice(num2, reference.Length - num2));
				reference = ref P_0;
				num2 = num + 2;
				num10 = A(reference.Slice(num2, reference.Length - num2));
				num += 4;
			}
			else if ((num3 & 0x80u) != 0)
			{
				reference = ref P_0;
				num2 = num;
				num7 = A(reference.Slice(num2, reference.Length - num2));
				reference = ref P_0;
				num2 = num + 2;
				num8 = A(reference.Slice(num2, reference.Length - num2));
				reference = ref P_0;
				num2 = num + 4;
				num9 = A(reference.Slice(num2, reference.Length - num2));
				reference = ref P_0;
				num2 = num + 6;
				num10 = A(reference.Slice(num2, reference.Length - num2));
				num += 8;
			}
			if ((num3 & 2) == 0)
			{
				num5 = (num6 = 0.0);
			}
			m2._002Ector(m.Item1 * num7 + m.Item3 * num8, m.Item2 * num7 + m.Item4 * num8, m.Item1 * num9 + m.Item3 * num10, m.Item2 * num9 + m.Item4 * num10, m.Item1 * num5 + m.Item3 * num6 + m.Item5, m.Item2 * num5 + m.Item4 * num6 + m.Item6);
			A(num4, m2, contours, P_3, P_4 + 1);
		}
		while ((num3 & 0x20u) != 0);
	}

	private static double A(System.ReadOnlySpan<byte> P_0)
	{
		return (double)BinaryPrimitives.ReadInt16BigEndian(P_0) / 16384.0;
	}

	public bool CanRender(string text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Enumerable.All<Rune>((System.Collections.Generic.IEnumerable<Rune>)(object)text.EnumerateRunes(), (Func<Rune, bool>)([CompilerGenerated] (Rune P_0) => Rune.IsWhiteSpace(P_0) || _codepointToGlyph.ContainsKey(((Rune)(ref P_0)).Value)));
	}

	internal static FontMetrics A(byte[] P_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = (a(P_0) ? B(P_0) : P_0);
		Dictionary<string, ValueTuple<int, int>> val = b(array);
		int num = a(array, val);
		ValueTuple<int, int, int, int> val2 = B(array, val);
		int item = val2.Item1;
		int item2 = val2.Item2;
		int item3 = val2.Item3;
		int item4 = val2.Item4;
		int[] array2 = A(array, val, item);
		Dictionary<int, int> val3 = b(array, val);
		int[] array3 = A(array, val);
		ValueTuple<int, int> val4 = default(ValueTuple<int, int>);
		return new FontMetrics(val3, array2, num, array3, array, val.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rT(), ref val4) ? val4.Item1 : 0)
		{
			Ascender = item2,
			Descender = item3,
			LineGap = item4,
			AMarkIsDrawnRightOfWhereItStands = A(array, val, val3, array3)
		};
	}

	private static bool? A(byte[] P_0, Dictionary<string, ValueTuple<int, int>> tables, Dictionary<int, int> P_2, int[]? outlines)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = default(ValueTuple<int, int>);
		int num = default(int);
		if (outlines == null || !tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rT(), ref val) || !P_2.TryGetValue(1614, ref num) || num < 0 || num + 1 >= outlines.Length || outlines[num + 1] - outlines[num] < 10)
		{
			return null;
		}
		int num2 = val.Item1 + outlines[num];
		short num3 = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 2)));
		short num4 = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 6)));
		return num3 + num4 > 0 && num3 >= 0;
	}

	private static int[]? A(byte[] P_0, Dictionary<string, ValueTuple<int, int>> tables)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = default(ValueTuple<int, int>);
		ValueTuple<int, int> val2 = default(ValueTuple<int, int>);
		ValueTuple<int, int> val3 = default(ValueTuple<int, int>);
		if (!tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rt(), ref val) || !tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rU(), ref val2) || !tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ru(), ref val3) || !tables.ContainsKey(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rT()))
		{
			return null;
		}
		bool flag = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val2.Item1 + 50))) == 1;
		int num = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val3.Item1 + 4))) + 1;
		if (val.Item2 < num * (flag ? 4 : 2))
		{
			return null;
		}
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = (flag ? ((int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val.Item1 + i * 4)))) : (BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val.Item1 + i * 2))) * 2));
		}
		return array;
	}

	private static bool a(byte[] P_0)
	{
		if (P_0.Length > 4 && P_0[0] == 119 && P_0[1] == 79 && P_0[2] == 70)
		{
			return P_0[3] == 70;
		}
		return false;
	}

	private static byte[] B(byte[] P_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		ushort num = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, 12)));
		MemoryStream val = new MemoryStream();
		List<ValueTuple<uint, uint, uint>> val2 = new List<ValueTuple<uint, uint, uint>>();
		((Stream)val).Write(System.ReadOnlySpan<byte>.op_Implicit(new byte[12 + num * 16]));
		for (int i = 0; i < num; i++)
		{
			int num2 = 44 + i * 20;
			uint num3 = BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2)));
			uint num4 = BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 4)));
			uint num5 = BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 8)));
			uint num6 = BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 12)));
			byte[] array = ((num5 == num6) ? MemoryExtensions.AsSpan<byte>(P_0, (int)num4, (int)num6).ToArray() : A(P_0, (int)num4, (int)num5, (int)num6));
			while (((Stream)val).Length % 4 != 0L)
			{
				((Stream)val).WriteByte((byte)0);
			}
			val2.Add(new ValueTuple<uint, uint, uint>(num3, (uint)((Stream)val).Position, num6));
			((Stream)val).Write(System.ReadOnlySpan<byte>.op_Implicit(array));
		}
		byte[] array2 = val.ToArray();
		BinaryPrimitives.WriteUInt32BigEndian(MemoryExtensions.AsSpan<byte>(array2, 0), 65536u);
		BinaryPrimitives.WriteUInt16BigEndian(MemoryExtensions.AsSpan<byte>(array2, 4), num);
		for (int j = 0; j < val2.Count; j++)
		{
			int num7 = 12 + j * 16;
			BinaryPrimitives.WriteUInt32BigEndian(MemoryExtensions.AsSpan<byte>(array2, num7), val2[j].Item1);
			BinaryPrimitives.WriteUInt32BigEndian(MemoryExtensions.AsSpan<byte>(array2, num7 + 8), val2[j].Item2);
			BinaryPrimitives.WriteUInt32BigEndian(MemoryExtensions.AsSpan<byte>(array2, num7 + 12), val2[j].Item3);
		}
		return array2;
	}

	private static byte[] A(byte[] P_0, int P_1, int P_2, int P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		MemoryStream val = new MemoryStream(P_0, P_1, P_2);
		try
		{
			ZLibStream val2 = new ZLibStream((Stream)(object)val, (CompressionMode)0);
			try
			{
				byte[] array = new byte[P_3];
				int num;
				for (int i = 0; i < P_3; i += num)
				{
					num = ((Stream)val2).Read(array, i, P_3 - i);
					if (num == 0)
					{
						break;
					}
				}
				return array;
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static Dictionary<string, ValueTuple<int, int>> b(byte[] P_0)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		ushort num = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, 4)));
		Dictionary<string, ValueTuple<int, int>> val = new Dictionary<string, ValueTuple<int, int>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		for (int i = 0; i < num; i++)
		{
			int num2 = 12 + i * 16;
			string @string = Encoding.ASCII.GetString(P_0, num2, 4);
			int num3 = (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 8)));
			int num4 = (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 12)));
			val[@string] = new ValueTuple<int, int>(num3, num4);
		}
		return val;
	}

	private static int a(byte[] P_0, Dictionary<string, ValueTuple<int, int>> tables)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = default(ValueTuple<int, int>);
		if (!tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rU(), ref val))
		{
			throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rV());
		}
		return BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val.Item1 + 18)));
	}

	private static ValueTuple<int, int, int, int> B(byte[] sfnt, Dictionary<string, ValueTuple<int, int>> tables)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = default(ValueTuple<int, int>);
		if (!tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rv(), ref val))
		{
			throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rW());
		}
		short num = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(sfnt, val.Item1 + 4)));
		short num2 = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(sfnt, val.Item1 + 6)));
		short num3 = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(sfnt, val.Item1 + 8)));
		return new ValueTuple<int, int, int, int>((int)BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(sfnt, val.Item1 + 34))), (int)num, (int)num2, (int)num3);
	}

	private static int[] A(byte[] P_0, Dictionary<string, ValueTuple<int, int>> tables, int P_2)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = default(ValueTuple<int, int>);
		if (!tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rw(), ref val))
		{
			throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rX());
		}
		int[] array = new int[P_2];
		for (int i = 0; i < P_2; i++)
		{
			array[i] = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val.Item1 + i * 4)));
		}
		return array;
	}

	private static Dictionary<int, int> b(byte[] P_0, Dictionary<string, ValueTuple<int, int>> tables)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = default(ValueTuple<int, int>);
		if (!tables.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rx(), ref val))
		{
			throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rY());
		}
		Dictionary<int, int> val2 = new Dictionary<int, int>();
		ushort num = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, val.Item1 + 2)));
		for (int i = 0; i < num; i++)
		{
			int num2 = val.Item1 + 4 + i * 8;
			int num3 = val.Item1 + (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 4)));
			switch (BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num3))))
			{
			case 4:
				A(P_0, num3, val2);
				break;
			case 12:
				a(P_0, num3, val2);
				break;
			}
		}
		return val2;
	}

	private static void A(byte[] P_0, int P_1, Dictionary<int, int> P_2)
	{
		ushort num = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, P_1 + 6)));
		int num2 = num / 2;
		int num3 = P_1 + 14;
		int num4 = num3 + num + 2;
		int num5 = num4 + num;
		int num6 = num5 + num;
		for (int i = 0; i < num2; i++)
		{
			ushort num7 = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num3 + i * 2)));
			ushort num8 = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num4 + i * 2)));
			short num9 = BinaryPrimitives.ReadInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num5 + i * 2)));
			ushort num10 = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num6 + i * 2)));
			if (num8 == 65535)
			{
				continue;
			}
			for (ushort num11 = num8; num11 <= num7 && num11 != 65535; num11++)
			{
				int num12;
				if (num10 == 0)
				{
					num12 = (num11 + num9) & 0xFFFF;
				}
				else
				{
					int num13 = num6 + i * 2 + num10 + (num11 - num8) * 2;
					if (num13 + 1 >= P_0.Length)
					{
						continue;
					}
					num12 = BinaryPrimitives.ReadUInt16BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num13)));
					if (num12 != 0)
					{
						num12 = (num12 + num9) & 0xFFFF;
					}
				}
				if (num12 != 0)
				{
					P_2[(int)num11] = num12;
				}
			}
		}
	}

	private static void a(byte[] P_0, int P_1, Dictionary<int, int> P_2)
	{
		int num = (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, P_1 + 12)));
		for (int i = 0; i < num; i++)
		{
			int num2 = P_1 + 16 + i * 12;
			int num3 = (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2)));
			int num4 = (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 4)));
			int num5 = (int)BinaryPrimitives.ReadUInt32BigEndian(System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, num2 + 8)));
			for (int j = num3; j <= num4; j++)
			{
				P_2[j] = num5 + (j - num3);
			}
		}
	}

	[CompilerGenerated]
	private bool A(Rune P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (!Rune.IsWhiteSpace(P_0))
		{
			return _codepointToGlyph.ContainsKey(((Rune)(ref P_0)).Value);
		}
		return true;
	}
}
