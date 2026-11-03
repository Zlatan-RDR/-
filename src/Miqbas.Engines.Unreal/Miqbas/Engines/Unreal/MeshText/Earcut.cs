using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.MeshText;

public static class Earcut
{
	private sealed class A
	{
		public readonly int I;

		public readonly double X;

		public readonly double Y;

		public A Prev;

		public A Next;

		public int Z;

		public A? PrevZ;

		public A? NextZ;

		public bool Steiner;

		public A(int P_0, double P_1, double P_2)
		{
			I = P_0;
			X = P_1;
			Y = P_2;
			base._002Ector();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Comparison<A> _003C_003E9__10_0;

		internal int A(A P_0, A P_1)
		{
			if (P_0.X == P_1.X)
			{
				return P_0.Y.CompareTo(P_1.Y);
			}
			return P_0.X.CompareTo(P_1.X);
		}
	}

	public static List<int> Triangulate(global::System.Collections.Generic.IReadOnlyList<double> coordinates, global::System.Collections.Generic.IReadOnlyList<int> holeStarts)
	{
		ArgumentNullException.ThrowIfNull((object)coordinates, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.co());
		ArgumentNullException.ThrowIfNull((object)holeStarts, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cP());
		List<int> val = new List<int>();
		bool flag = ((global::System.Collections.Generic.IReadOnlyCollection<int>)holeStarts).Count > 0;
		int num = (flag ? (holeStarts[0] * 2) : ((global::System.Collections.Generic.IReadOnlyCollection<double>)coordinates).Count);
		A a = A(coordinates, 0, num, true);
		if (a == null || a.Next == a.Prev)
		{
			return val;
		}
		if (flag)
		{
			a = A(coordinates, holeStarts, a);
		}
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		if (((global::System.Collections.Generic.IReadOnlyCollection<double>)coordinates).Count > 160)
		{
			num2 = 1.7976931348623157E+308;
			num3 = 1.7976931348623157E+308;
			double num5 = -1.7976931348623157E+308;
			double num6 = -1.7976931348623157E+308;
			for (int i = 0; i < num; i += 2)
			{
				num2 = Math.Min(num2, coordinates[i]);
				num3 = Math.Min(num3, coordinates[i + 1]);
				num5 = Math.Max(num5, coordinates[i]);
				num6 = Math.Max(num6, coordinates[i + 1]);
			}
			num4 = Math.Max(num5 - num2, num6 - num3);
			num4 = ((num4 != 0.0) ? (32767.0 / num4) : 0.0);
		}
		A(a, val, num2, num3, num4, 0);
		return val;
	}

	private static A? A(global::System.Collections.Generic.IReadOnlyList<double> P_0, int P_1, int P_2, bool P_3)
	{
		A a = null;
		if (P_3 == A(P_0, P_1, P_2) > 0.0)
		{
			for (int i = P_1; i < P_2; i += 2)
			{
				a = A(i / 2, P_0[i], P_0[i + 1], a);
			}
		}
		else
		{
			for (int num = P_2 - 2; num >= P_1; num -= 2)
			{
				a = A(num / 2, P_0[num], P_0[num + 1], a);
			}
		}
		if (a != null && c(a, a.Next))
		{
			b(a);
			a = a.Next;
		}
		return a;
	}

	private static A? A(A? P_0, A? P_1 = null)
	{
		if (P_0 == null)
		{
			return P_0;
		}
		if (P_1 == null)
		{
			P_1 = P_0;
		}
		A a = P_0;
		bool flag;
		do
		{
			flag = false;
			if (!a.Steiner && (c(a, a.Next) || A(a.Prev, a, a.Next) == 0.0))
			{
				b(a);
				a = (P_1 = a.Prev);
				if (a == a.Next)
				{
					break;
				}
				flag = true;
			}
			else
			{
				a = a.Next;
			}
		}
		while (flag || a != P_1);
		return P_1;
	}

	private static void A(A? ear, List<int> P_1, double P_2, double P_3, double P_4, int P_5)
	{
		if (ear == null)
		{
			return;
		}
		if (P_5 == 0 && P_4 != 0.0)
		{
			Earcut.a(ear, P_2, P_3, P_4);
		}
		A a = ear;
		while (ear.Prev != ear.Next)
		{
			A prev = ear.Prev;
			A next = ear.Next;
			if ((P_4 != 0.0) ? A(ear, P_2, P_3, P_4) : A(ear))
			{
				P_1.Add(prev.I);
				P_1.Add(ear.I);
				P_1.Add(next.I);
				b(ear);
				ear = next.Next;
				a = next.Next;
				continue;
			}
			ear = next;
			if (ear != a)
			{
				continue;
			}
			switch (P_5)
			{
			case 0:
				A(A(ear, (A?)null), P_1, P_2, P_3, P_4, 1);
				break;
			case 1:
				ear = A(A(ear, (A?)null), P_1);
				A(ear, P_1, P_2, P_3, P_4, 2);
				break;
			case 2:
				A(ear, P_1, P_2, P_3, P_4);
				break;
			}
			break;
		}
	}

	private static bool A(A P_0)
	{
		A prev = P_0.Prev;
		A next = P_0.Next;
		if (A(prev, P_0, next) >= 0.0)
		{
			return false;
		}
		double num = Math.Min(prev.X, Math.Min(P_0.X, next.X));
		double num2 = Math.Min(prev.Y, Math.Min(P_0.Y, next.Y));
		double num3 = Math.Max(prev.X, Math.Max(P_0.X, next.X));
		double num4 = Math.Max(prev.Y, Math.Max(P_0.Y, next.Y));
		for (A next2 = next.Next; next2 != prev; next2 = next2.Next)
		{
			if (next2.X >= num && next2.X <= num3 && next2.Y >= num2 && next2.Y <= num4 && A(prev.X, prev.Y, P_0.X, P_0.Y, next.X, next.Y, next2.X, next2.Y) && A(next2.Prev, next2, next2.Next) >= 0.0)
			{
				return false;
			}
		}
		return true;
	}

	private static bool A(A P_0, double P_1, double P_2, double P_3)
	{
		A prev = P_0.Prev;
		A next = P_0.Next;
		if (A(prev, P_0, next) >= 0.0)
		{
			return false;
		}
		double num = Math.Min(prev.X, Math.Min(P_0.X, next.X));
		double num2 = Math.Min(prev.Y, Math.Min(P_0.Y, next.Y));
		double num3 = Math.Max(prev.X, Math.Max(P_0.X, next.X));
		double num4 = Math.Max(prev.Y, Math.Max(P_0.Y, next.Y));
		int num5 = A(num, num2, P_1, P_2, P_3);
		int num6 = A(num3, num4, P_1, P_2, P_3);
		A prevZ = P_0.PrevZ;
		A nextZ = P_0.NextZ;
		while (prevZ != null && prevZ.Z >= num5 && nextZ != null && nextZ.Z <= num6)
		{
			if (A(prevZ, prev, P_0, next, num, num2, num3, num4))
			{
				return false;
			}
			prevZ = prevZ.PrevZ;
			if (A(nextZ, prev, P_0, next, num, num2, num3, num4))
			{
				return false;
			}
			nextZ = nextZ.NextZ;
		}
		while (prevZ != null && prevZ.Z >= num5)
		{
			if (A(prevZ, prev, P_0, next, num, num2, num3, num4))
			{
				return false;
			}
			prevZ = prevZ.PrevZ;
		}
		while (nextZ != null && nextZ.Z <= num6)
		{
			if (A(nextZ, prev, P_0, next, num, num2, num3, num4))
			{
				return false;
			}
			nextZ = nextZ.NextZ;
		}
		return true;
	}

	private static bool A(A P_0, A P_1, A P_2, A P_3, double P_4, double P_5, double P_6, double P_7)
	{
		if (P_0 != P_1 && P_0 != P_3 && P_0.X >= P_4 && P_0.X <= P_6 && P_0.Y >= P_5 && P_0.Y <= P_7 && A(P_1.X, P_1.Y, P_2.X, P_2.Y, P_3.X, P_3.Y, P_0.X, P_0.Y))
		{
			return A(P_0.Prev, P_0, P_0.Next) >= 0.0;
		}
		return false;
	}

	private static A A(A P_0, List<int> P_1)
	{
		A a = P_0;
		do
		{
			A prev = a.Prev;
			A next = a.Next.Next;
			if (!c(prev, next) && A(prev, a, a.Next, next) && d(prev, next) && d(next, prev))
			{
				P_1.Add(prev.I);
				P_1.Add(a.I);
				P_1.Add(next.I);
				b(a);
				b(a.Next);
				a = (P_0 = next);
			}
			a = a.Next;
		}
		while (a != P_0);
		return A(a, (A?)null);
	}

	private static void A(A P_0, List<int> P_1, double P_2, double P_3, double P_4)
	{
		A a = P_0;
		do
		{
			for (A next = a.Next.Next; next != a.Prev; next = next.Next)
			{
				if (a.I != next.I && C(a, next))
				{
					A obj = e(a, next);
					a = A(a, a.Next);
					A? ear = A(obj, obj.Next);
					A(a, P_1, P_2, P_3, P_4, 0);
					A(ear, P_1, P_2, P_3, P_4, 0);
					return;
				}
			}
			a = a.Next;
		}
		while (a != P_0);
	}

	private static A A(global::System.Collections.Generic.IReadOnlyList<double> P_0, global::System.Collections.Generic.IReadOnlyList<int> P_1, A P_2)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		List<A> val = new List<A>();
		for (int i = 0; i < ((global::System.Collections.Generic.IReadOnlyCollection<int>)P_1).Count; i++)
		{
			int num = P_1[i] * 2;
			int num2 = ((i < ((global::System.Collections.Generic.IReadOnlyCollection<int>)P_1).Count - 1) ? (P_1[i + 1] * 2) : ((global::System.Collections.Generic.IReadOnlyCollection<double>)P_0).Count);
			A a = A(P_0, num, num2, false);
			if (a != null)
			{
				if (a == a.Next)
				{
					a.Steiner = true;
				}
				val.Add(B(a));
			}
		}
		val.Sort((Comparison<A>)((A P_0, A P_1) => (P_0.X == P_1.X) ? P_0.Y.CompareTo(P_1.Y) : P_0.X.CompareTo(P_1.X)));
		Enumerator<A> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				P_2 = Earcut.a(enumerator.Current, P_2);
			}
			return P_2;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	private static A a(A P_0, A P_1)
	{
		A a = B(P_0, P_1);
		if (a == null)
		{
			return P_1;
		}
		A obj = e(a, P_0);
		A(obj, obj.Next);
		return A(a, a.Next);
	}

	private static A? B(A P_0, A P_1)
	{
		A a = P_1;
		double x = P_0.X;
		double y = P_0.Y;
		double num = -1.0 / 0.0;
		A a2 = null;
		do
		{
			if (y <= a.Y && y >= a.Next.Y && a.Next.Y != a.Y)
			{
				double num2 = a.X + (y - a.Y) * (a.Next.X - a.X) / (a.Next.Y - a.Y);
				if (num2 <= x && num2 > num)
				{
					num = num2;
					a2 = ((a.X < a.Next.X) ? a : a.Next);
					if (num2 == x)
					{
						return a2;
					}
				}
			}
			a = a.Next;
		}
		while (a != P_1);
		if (a2 == null)
		{
			return null;
		}
		A a3 = a2;
		double x2 = a2.X;
		double y2 = a2.Y;
		double num3 = 1.0 / 0.0;
		a = a2;
		do
		{
			if (x >= a.X && a.X >= x2 && x != a.X && A((y < y2) ? x : num, y, x2, y2, (y < y2) ? num : x, y, a.X, a.Y))
			{
				double num4 = Math.Abs(y - a.Y) / (x - a.X);
				if (d(a, P_0) && (num4 < num3 || (num4 == num3 && (a.X > a2.X || (a.X == a2.X && b(a2, a))))))
				{
					a2 = a;
					num3 = num4;
				}
			}
			a = a.Next;
		}
		while (a != a3);
		return a2;
	}

	private static bool b(A P_0, A P_1)
	{
		if (A(P_0.Prev, P_0, P_1.Prev) < 0.0)
		{
			return A(P_1.Next, P_0, P_0.Next) < 0.0;
		}
		return false;
	}

	private static void a(A P_0, double P_1, double P_2, double P_3)
	{
		A a = P_0;
		do
		{
			if (a.Z == 0)
			{
				a.Z = A(a.X, a.Y, P_1, P_2, P_3);
			}
			a.PrevZ = a.Prev;
			a.NextZ = a.Next;
			a = a.Next;
		}
		while (a != P_0);
		a.PrevZ.NextZ = null;
		a.PrevZ = null;
		Earcut.a(a);
	}

	private static void a(A P_0)
	{
		int num = 1;
		A a = P_0;
		int num2;
		do
		{
			A a2 = a;
			a = null;
			A a3 = null;
			num2 = 0;
			while (a2 != null)
			{
				num2++;
				A a4 = a2;
				int num3 = 0;
				for (int i = 0; i < num; i++)
				{
					num3++;
					a4 = a4.NextZ;
					if (a4 == null)
					{
						break;
					}
				}
				int num4 = num;
				while (num3 > 0 || (num4 > 0 && a4 != null))
				{
					A a5;
					if (num3 != 0 && (num4 == 0 || a4 == null || a2.Z <= a4.Z))
					{
						a5 = a2;
						a2 = a2.NextZ;
						num3--;
					}
					else
					{
						a5 = a4;
						a4 = a4.NextZ;
						num4--;
					}
					if (a3 != null)
					{
						a3.NextZ = a5;
					}
					else
					{
						a = a5;
					}
					a5.PrevZ = a3;
					a3 = a5;
				}
				a2 = a4;
			}
			a3.NextZ = null;
			num *= 2;
		}
		while (num2 > 1);
	}

	private static int A(double P_0, double P_1, double P_2, double P_3, double P_4)
	{
		int num = (int)((P_0 - P_2) * P_4);
		int num2 = (int)((P_1 - P_3) * P_4);
		int num3 = (num | (num << 8)) & 0xFF00FF;
		int num4 = (num3 | (num3 << 4)) & 0xF0F0F0F;
		int num5 = (num4 | (num4 << 2)) & 0x33333333;
		int num6 = (num5 | (num5 << 1)) & 0x55555555;
		num2 = (num2 | (num2 << 8)) & 0xFF00FF;
		num2 = (num2 | (num2 << 4)) & 0xF0F0F0F;
		num2 = (num2 | (num2 << 2)) & 0x33333333;
		num2 = (num2 | (num2 << 1)) & 0x55555555;
		return num6 | (num2 << 1);
	}

	private static A B(A P_0)
	{
		A a = P_0;
		A a2 = P_0;
		do
		{
			if (a.X < a2.X || (a.X == a2.X && a.Y < a2.Y))
			{
				a2 = a;
			}
			a = a.Next;
		}
		while (a != P_0);
		return a2;
	}

	private static bool A(double P_0, double P_1, double P_2, double P_3, double P_4, double P_5, double P_6, double P_7)
	{
		if ((P_4 - P_6) * (P_1 - P_7) >= (P_0 - P_6) * (P_5 - P_7) && (P_0 - P_6) * (P_3 - P_7) >= (P_2 - P_6) * (P_1 - P_7))
		{
			return (P_2 - P_6) * (P_5 - P_7) >= (P_4 - P_6) * (P_3 - P_7);
		}
		return false;
	}

	private static bool C(A P_0, A P_1)
	{
		if (P_0.Next.I != P_1.I && P_0.Prev.I != P_1.I && !D(P_0, P_1))
		{
			if (!d(P_0, P_1) || !d(P_1, P_0) || !E(P_0, P_1) || (A(P_0.Prev, P_0, P_1.Prev) == 0.0 && A(P_0, P_1.Prev, P_1) == 0.0))
			{
				if (c(P_0, P_1) && A(P_0.Prev, P_0, P_0.Next) > 0.0)
				{
					return A(P_1.Prev, P_1, P_1.Next) > 0.0;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private static double A(A P_0, A P_1, A P_2)
	{
		return (P_1.Y - P_0.Y) * (P_2.X - P_1.X) - (P_1.X - P_0.X) * (P_2.Y - P_1.Y);
	}

	private static bool c(A P_0, A P_1)
	{
		if (P_0.X == P_1.X)
		{
			return P_0.Y == P_1.Y;
		}
		return false;
	}

	private static bool A(A P_0, A P_1, A P_2, A P_3)
	{
		int num = Math.Sign(A(P_0, P_1, P_2));
		int num2 = Math.Sign(A(P_0, P_1, P_3));
		int num3 = Math.Sign(A(P_2, P_3, P_0));
		int num4 = Math.Sign(A(P_2, P_3, P_1));
		if (num != num2 && num3 != num4)
		{
			return true;
		}
		if ((num != 0 || !a(P_0, P_2, P_1)) && (num2 != 0 || !a(P_0, P_3, P_1)) && (num3 != 0 || !a(P_2, P_0, P_3)))
		{
			if (num4 == 0)
			{
				return a(P_2, P_1, P_3);
			}
			return false;
		}
		return true;
	}

	private static bool a(A P_0, A P_1, A P_2)
	{
		if (P_1.X <= Math.Max(P_0.X, P_2.X) && P_1.X >= Math.Min(P_0.X, P_2.X) && P_1.Y <= Math.Max(P_0.Y, P_2.Y))
		{
			return P_1.Y >= Math.Min(P_0.Y, P_2.Y);
		}
		return false;
	}

	private static bool D(A P_0, A P_1)
	{
		A a = P_0;
		do
		{
			if (a.I != P_0.I && a.Next.I != P_0.I && a.I != P_1.I && a.Next.I != P_1.I && A(a, a.Next, P_0, P_1))
			{
				return true;
			}
			a = a.Next;
		}
		while (a != P_0);
		return false;
	}

	private static bool d(A P_0, A P_1)
	{
		if (!(A(P_0.Prev, P_0, P_0.Next) < 0.0))
		{
			if (!(A(P_0, P_1, P_0.Prev) < 0.0))
			{
				return A(P_0, P_0.Next, P_1) < 0.0;
			}
			return true;
		}
		if (A(P_0, P_1, P_0.Next) >= 0.0)
		{
			return A(P_0, P_0.Prev, P_1) >= 0.0;
		}
		return false;
	}

	private static bool E(A P_0, A P_1)
	{
		A a = P_0;
		bool flag = false;
		double num = (P_0.X + P_1.X) / 2.0;
		double num2 = (P_0.Y + P_1.Y) / 2.0;
		do
		{
			if (a.Y > num2 != a.Next.Y > num2 && a.Next.Y != a.Y && num < (a.Next.X - a.X) * (num2 - a.Y) / (a.Next.Y - a.Y) + a.X)
			{
				flag = !flag;
			}
			a = a.Next;
		}
		while (a != P_0);
		return flag;
	}

	private static A e(A P_0, A P_1)
	{
		A a = new A(P_0.I, P_0.X, P_0.Y);
		A a2 = new A(P_1.I, P_1.X, P_1.Y);
		A next = P_0.Next;
		A prev = P_1.Prev;
		P_0.Next = P_1;
		P_1.Prev = P_0;
		a.Next = next;
		next.Prev = a;
		a2.Next = a;
		a.Prev = a2;
		prev.Next = a2;
		a2.Prev = prev;
		return a2;
	}

	private static A A(int P_0, double P_1, double P_2, A? last)
	{
		A a = new A(P_0, P_1, P_2);
		if (last == null)
		{
			a.Prev = a;
			a.Next = a;
		}
		else
		{
			a.Next = last.Next;
			a.Prev = last;
			last.Next.Prev = a;
			last.Next = a;
		}
		return a;
	}

	private static void b(A P_0)
	{
		P_0.Next.Prev = P_0.Prev;
		P_0.Prev.Next = P_0.Next;
		if (P_0.PrevZ != null)
		{
			P_0.PrevZ.NextZ = P_0.NextZ;
		}
		if (P_0.NextZ != null)
		{
			P_0.NextZ.PrevZ = P_0.PrevZ;
		}
	}

	private static double A(global::System.Collections.Generic.IReadOnlyList<double> P_0, int P_1, int P_2)
	{
		double num = 0.0;
		int i = P_1;
		int num2 = P_2 - 2;
		for (; i < P_2; i += 2)
		{
			num += (P_0[num2] - P_0[i]) * (P_0[i + 1] + P_0[num2 + 1]);
			num2 = i;
		}
		return num;
	}
}
