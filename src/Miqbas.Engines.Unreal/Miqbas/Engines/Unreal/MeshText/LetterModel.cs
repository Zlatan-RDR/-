using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Core.Text;

namespace Miqbas.Engines.Unreal.MeshText;

public sealed class LetterModel : IEquatable<LetterModel>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<List<ValueTuple<double, double>>, bool> _003C_003E9__40_1;

		public static Func<ValueTuple<double, double>, double> _003C_003E9__40_8;

		public static Func<List<ValueTuple<double, double>>, double> _003C_003E9__40_2;

		public static Func<ValueTuple<double, double>, double> _003C_003E9__40_9;

		public static Func<List<ValueTuple<double, double>>, double> _003C_003E9__40_3;

		public static Func<ValueTuple<double, double>, double> _003C_003E9__40_10;

		public static Func<List<ValueTuple<double, double>>, double> _003C_003E9__40_4;

		public static Func<ValueTuple<double, double>, double> _003C_003E9__40_11;

		public static Func<List<ValueTuple<double, double>>, double> _003C_003E9__40_5;

		internal bool A(List<ValueTuple<double, double>> c)
		{
			if (c.Count >= 3)
			{
				return Math.Abs(LetterModel.A((global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)c)) > 1E-09;
			}
			return false;
		}

		internal double a(List<ValueTuple<double, double>> c)
		{
			return Enumerable.Min<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item1));
		}

		internal double A(ValueTuple<double, double> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return p.Item1;
		}

		internal double B(List<ValueTuple<double, double>> c)
		{
			return Enumerable.Max<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item1));
		}

		internal double a(ValueTuple<double, double> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return p.Item1;
		}

		internal double b(List<ValueTuple<double, double>> c)
		{
			return Enumerable.Min<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item2));
		}

		internal double B(ValueTuple<double, double> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return p.Item2;
		}

		internal double C(List<ValueTuple<double, double>> c)
		{
			return Enumerable.Max<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item2));
		}

		internal double b(ValueTuple<double, double> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return p.Item2;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public double scale;

		public List<List<ValueTuple<double, double>>> contours;

		public Func<ValueTuple<double, double>, ValueTuple<double, double>> _003C_003E9__7;

		internal List<ValueTuple<double, double>> A(global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>> c)
		{
			return Enumerable.ToList<ValueTuple<double, double>>(Enumerable.Select<ValueTuple<double, double>, ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, ValueTuple<double, double>>)((ValueTuple<double, double> p) => new ValueTuple<double, double>(p.Item1 * scale, p.Item2 * scale))));
		}

		internal ValueTuple<double, double> A(ValueTuple<double, double> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<double, double>(p.Item1 * scale, p.Item2 * scale);
		}

		internal int A(List<ValueTuple<double, double>> c, int P_1)
		{
			B CS_0024_003C_003E8__locals0 = new B
			{
				i = P_1,
				c = c
			};
			return Enumerable.Count<List<ValueTuple<double, double>>>(Enumerable.Where<List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, int, bool>)((List<ValueTuple<double, double>> o, int P_1) => P_1 != CS_0024_003C_003E8__locals0.i && LetterModel.A(CS_0024_003C_003E8__locals0.c[0], (global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)o))));
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public int i;

		public List<ValueTuple<double, double>> c;

		internal bool A(List<ValueTuple<double, double>> o, int P_1)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			if (P_1 != i)
			{
				return LetterModel.A(c[0], (global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)o);
			}
			return false;
		}
	}

	public const float HalfDepth = 2.5f;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LetterModel);
		}
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<LetterVertex> Vertices
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<int> Indices
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Left
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Right
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Bottom
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Top
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Advance
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public double Width => Right - Left;

	public double Height => Top - Bottom;

	public double CentreX => (Left + Right) / 2.0;

	public double CentreY => (Bottom + Top) / 2.0;

	public LetterModel(global::System.Collections.Generic.IReadOnlyList<LetterVertex> Vertices, global::System.Collections.Generic.IReadOnlyList<int> Indices, double Left, double Right, double Bottom, double Top, double Advance)
	{
		this.Vertices = Vertices;
		this.Indices = Indices;
		this.Left = Left;
		this.Right = Right;
		this.Bottom = Bottom;
		this.Top = Top;
		this.Advance = Advance;
		base._002Ector();
	}

	public static LetterModel? Of(FontMetrics font, int codepoint, double scale)
	{
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)font, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ct());
		List<List<ValueTuple<double, double>>> contours = Enumerable.ToList<List<ValueTuple<double, double>>>(Enumerable.Where<List<ValueTuple<double, double>>>(Enumerable.Select<global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>, List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>>)font.Outline(codepoint), (Func<global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>, List<ValueTuple<double, double>>>)((global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>> c) => Enumerable.ToList<ValueTuple<double, double>>(Enumerable.Select<ValueTuple<double, double>, ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, ValueTuple<double, double>>)((ValueTuple<double, double> p) => new ValueTuple<double, double>(p.Item1 * scale, p.Item2 * scale)))))), (Func<List<ValueTuple<double, double>>, bool>)((List<ValueTuple<double, double>> c) => c.Count >= 3 && Math.Abs(A((global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)c)) > 1E-09)));
		if (contours.Count == 0)
		{
			return null;
		}
		double num = Enumerable.Min<List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, double>)((List<ValueTuple<double, double>> c) => Enumerable.Min<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item1))));
		double num2 = Enumerable.Max<List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, double>)((List<ValueTuple<double, double>> c) => Enumerable.Max<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item1))));
		double num3 = Enumerable.Min<List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, double>)((List<ValueTuple<double, double>> c) => Enumerable.Min<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item2))));
		double num4 = Enumerable.Max<List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, double>)((List<ValueTuple<double, double>> c) => Enumerable.Max<ValueTuple<double, double>>((global::System.Collections.Generic.IEnumerable<ValueTuple<double, double>>)c, (Func<ValueTuple<double, double>, double>)((ValueTuple<double, double> p) => p.Item2))));
		double num5 = (num + num2) / 2.0;
		double num6 = (num3 + num4) / 2.0;
		double num7 = Math.Max(num2 - num, 1E-06);
		double num8 = Math.Max(num4 - num3, 1E-06);
		List<LetterVertex> val = new List<LetterVertex>();
		List<int> val2 = new List<int>();
		List<int> val3 = Enumerable.ToList<int>(Enumerable.Select<List<ValueTuple<double, double>>, int>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, int, int>)((List<ValueTuple<double, double>> c, int P_1) => Enumerable.Count<List<ValueTuple<double, double>>>(Enumerable.Where<List<ValueTuple<double, double>>>((global::System.Collections.Generic.IEnumerable<List<ValueTuple<double, double>>>)contours, (Func<List<ValueTuple<double, double>>, int, bool>)((List<ValueTuple<double, double>> o, int P_1) => P_1 != P_1 && A(c[0], (global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)o)))))));
		ValueTuple<float, float, float> normal = default(ValueTuple<float, float, float>);
		Enumerator<List<ValueTuple<double, double>>> enumerator;
		for (int i = 0; i < contours.Count; i++)
		{
			if (val3[i] % 2 != 0)
			{
				continue;
			}
			List<List<ValueTuple<double, double>>> obj = new List<List<ValueTuple<double, double>>>();
			obj.Add(contours[i]);
			List<List<ValueTuple<double, double>>> val4 = obj;
			for (int j = 0; j < contours.Count; j++)
			{
				if (val3[j] == val3[i] + 1 && A(contours[j][0], (global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)contours[i]))
				{
					val4.Add(contours[j]);
				}
			}
			List<double> val5 = new List<double>();
			List<int> val6 = new List<int>();
			enumerator = val4.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					List<ValueTuple<double, double>> current = enumerator.Current;
					if (val5.Count > 0)
					{
						val6.Add(val5.Count / 2);
					}
					Enumerator<ValueTuple<double, double>> enumerator2 = current.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							ValueTuple<double, double> current2 = enumerator2.Current;
							double item = current2.Item1;
							double item2 = current2.Item2;
							val5.Add(item);
							val5.Add(item2);
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			List<int> val7 = Earcut.Triangulate((global::System.Collections.Generic.IReadOnlyList<double>)val5, (global::System.Collections.Generic.IReadOnlyList<int>)val6);
			float[] array = new float[2] { 2.5f, -2.5f };
			foreach (float num9 in array)
			{
				normal._002Ector(0f, (num9 > 0f) ? 1f : (-1f), 0f);
				int count = val.Count;
				for (int l = 0; l < val5.Count; l += 2)
				{
					val.Add(new LetterVertex((float)(val5[l] - num5), num9, (float)(val5[l + 1] - num6), new ValueTuple<float, float, float>(1f, 0f, 0f), normal, (float)((val5[l] - num) / num7), (float)(1.0 - (val5[l + 1] - num3) / num8)));
				}
				for (int m = 0; m < val7.Count; m += 3)
				{
					A(val, val2, count + val7[m], count + val7[m + 1], count + val7[m + 2], normal);
				}
			}
		}
		enumerator = contours.GetEnumerator();
		try
		{
			ValueTuple<float, float, float> normal2 = default(ValueTuple<float, float, float>);
			ValueTuple<float, float, float> tangent = default(ValueTuple<float, float, float>);
			while (enumerator.MoveNext())
			{
				List<ValueTuple<double, double>> current3 = enumerator.Current;
				bool flag = A((global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>>)current3) > 0.0;
				for (int n = 0; n < current3.Count; n++)
				{
					ValueTuple<double, double> val8 = current3[n];
					double item3 = val8.Item1;
					double item4 = val8.Item2;
					ValueTuple<double, double> val9 = current3[(n + 1) % current3.Count];
					double item5 = val9.Item1;
					double item6 = val9.Item2;
					double num10 = item5 - item3;
					double num11 = item6 - item4;
					double num12 = Math.Sqrt(num10 * num10 + num11 * num11);
					if (!(num12 < 1E-09))
					{
						double num15;
						double num16;
						if (!flag)
						{
							double num13 = (0.0 - num11) / num12;
							double num14 = num10 / num12;
							num15 = num14;
							num16 = num13;
						}
						else
						{
							double num17 = num11 / num12;
							double num14 = (0.0 - num10) / num12;
							num15 = num14;
							num16 = num17;
						}
						normal2._002Ector((float)num16, 0f, (float)num15);
						tangent._002Ector((float)(num10 / num12), 0f, (float)(num11 / num12));
						int count2 = val.Count;
						val.Add(new LetterVertex((float)(item3 - num5), 2.5f, (float)(item4 - num6), tangent, normal2, 0f, 0f));
						val.Add(new LetterVertex((float)(item5 - num5), 2.5f, (float)(item6 - num6), tangent, normal2, 1f, 0f));
						val.Add(new LetterVertex((float)(item5 - num5), -2.5f, (float)(item6 - num6), tangent, normal2, 1f, 1f));
						val.Add(new LetterVertex((float)(item3 - num5), -2.5f, (float)(item4 - num6), tangent, normal2, 0f, 1f));
						A(val, val2, count2, count2 + 1, count2 + 2, normal2);
						A(val, val2, count2, count2 + 2, count2 + 3, normal2);
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		return new LetterModel((global::System.Collections.Generic.IReadOnlyList<LetterVertex>)val, (global::System.Collections.Generic.IReadOnlyList<int>)val2, num, num2, num3, num4, (double)font.AdvanceUnitsOf(codepoint) * scale);
	}

	private static void A(List<LetterVertex> P_0, List<int> P_1, int P_2, int P_3, int P_4, ValueTuple<float, float, float> normal)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		float x = P_0[P_2].X;
		float y = P_0[P_2].Y;
		float z = P_0[P_2].Z;
		float num = y;
		float num2 = x;
		float num3 = P_0[P_3].X - num2;
		float num4 = P_0[P_3].Y - num;
		float num5 = P_0[P_3].Z - z;
		float num6 = num4;
		float num7 = num3;
		float num8 = P_0[P_4].X - num2;
		float num9 = P_0[P_4].Y - num;
		float num10 = P_0[P_4].Z - z;
		float num11 = num9;
		float num12 = num8;
		float num13 = (num6 * num10 - num5 * num11) * normal.Item1 + (num5 * num12 - num7 * num10) * normal.Item2 + (num7 * num11 - num6 * num12) * normal.Item3;
		P_1.Add(P_2);
		if (num13 > 0f)
		{
			P_1.Add(P_4);
			P_1.Add(P_3);
		}
		else
		{
			P_1.Add(P_3);
			P_1.Add(P_4);
		}
	}

	private static double A(global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>> c)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		double num = 0.0;
		for (int i = 0; i < ((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<double, double>>)c).Count; i++)
		{
			ValueTuple<double, double> val = c[i];
			double item = val.Item1;
			double item2 = val.Item2;
			ValueTuple<double, double> val2 = c[(i + 1) % ((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<double, double>>)c).Count];
			double item3 = val2.Item1;
			double item4 = val2.Item2;
			num += item * item4 - item3 * item2;
		}
		return num / 2.0;
	}

	private static bool A(ValueTuple<double, double> point, global::System.Collections.Generic.IReadOnlyList<ValueTuple<double, double>> contour)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		int num = 0;
		int num2 = ((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<double, double>>)contour).Count - 1;
		while (num < ((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<double, double>>)contour).Count)
		{
			ValueTuple<double, double> val = contour[num];
			double item = val.Item1;
			double item2 = val.Item2;
			ValueTuple<double, double> val2 = contour[num2];
			double item3 = val2.Item1;
			double item4 = val2.Item2;
			if (item2 > point.Item2 != item4 > point.Item2 && point.Item1 < (item3 - item) * (point.Item2 - item2) / (item4 - item2) + item)
			{
				flag = !flag;
			}
			num2 = num++;
		}
		return flag;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cU());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cu());
		P_0.Append((object)Vertices);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cV());
		P_0.Append((object)Indices);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cv());
		P_0.Append(((object)Left).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cW());
		P_0.Append(((object)Right).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cw());
		P_0.Append(((object)Bottom).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cX());
		P_0.Append(((object)Top).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cx());
		P_0.Append(((object)Advance).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cY());
		P_0.Append(((object)Width).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cy());
		P_0.Append(((object)Height).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cZ());
		P_0.Append(((object)CentreX).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cz());
		P_0.Append(((object)CentreY).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LetterModel? left, LetterModel? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LetterModel? left, LetterModel? right)
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
		return ((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<LetterVertex>>.Default.GetHashCode(Vertices)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(Indices)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Left)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Right)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Bottom)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Top)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Advance);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LetterModel);
	}

	[CompilerGenerated]
	public bool Equals(LetterModel? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<global::System.Collections.Generic.IReadOnlyList<LetterVertex>>.Default.Equals(Vertices, other.Vertices) && EqualityComparer<global::System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(Indices, other.Indices) && EqualityComparer<double>.Default.Equals(Left, other.Left) && EqualityComparer<double>.Default.Equals(Right, other.Right) && EqualityComparer<double>.Default.Equals(Bottom, other.Bottom) && EqualityComparer<double>.Default.Equals(Top, other.Top))
			{
				return EqualityComparer<double>.Default.Equals(Advance, other.Advance);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LetterModel(LetterModel P_0)
	{
		Vertices = P_0.Vertices;
		Indices = P_0.Indices;
		Left = P_0.Left;
		Right = P_0.Right;
		Bottom = P_0.Bottom;
		Top = P_0.Top;
		Advance = P_0.Advance;
	}

	[CompilerGenerated]
	public void Deconstruct(out global::System.Collections.Generic.IReadOnlyList<LetterVertex> Vertices, out global::System.Collections.Generic.IReadOnlyList<int> Indices, out double Left, out double Right, out double Bottom, out double Top, out double Advance)
	{
		Vertices = this.Vertices;
		Indices = this.Indices;
		Left = this.Left;
		Right = this.Right;
		Bottom = this.Bottom;
		Top = this.Top;
		Advance = this.Advance;
	}
}
