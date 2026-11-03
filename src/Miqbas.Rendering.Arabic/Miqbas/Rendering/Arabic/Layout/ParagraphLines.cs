using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B78C53E54_002D85C4_002D4BB2_002DB75C_002D1FE345444E71_007D;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Rendering.Arabic.Layout;

public static class ParagraphLines
{
	private sealed class A
	{
		private readonly HashSet<string> _paired;

		private readonly HashSet<string> _braces;

		internal A(string P_0)
		{
			_paired = ArabicVisualOrder.b(P_0);
			_braces = ParagraphLines.A(P_0);
		}

		internal int? A(string P_0, int P_1)
		{
			int? result;
			switch (P_0[P_1])
			{
			case '<':
				return ArabicVisualOrder.A(P_0, P_1, (global::System.Collections.Generic.ICollection<string>)_paired);
			case '{':
			{
				int? num = ParagraphLines.A(P_0, P_1);
				if (num.HasValue)
				{
					int valueOrDefault = num.GetValueOrDefault();
					if (_braces.Contains(ArabicVisualOrder.d(P_0.Substring(P_1, valueOrDefault))))
					{
						result = valueOrDefault;
						goto IL_0068;
					}
				}
				result = null;
				goto IL_0068;
			}
			default:
				{
					return null;
				}
				IL_0068:
				return result;
			}
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, bool> _003C_003E9__7_0;

		public static Func<ValueTuple<string, string>, string> _003C_003E9__7_1;

		public static Func<ValueTuple<string, string>, string> _003C_003E9__7_2;

		internal bool A(string P_0)
		{
			if (P_0.IndexOf('<') < 0)
			{
				return P_0.IndexOf('{') >= 0;
			}
			return true;
		}

		internal string A(ValueTuple<string, string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return t.Item2;
		}

		internal string a(ValueTuple<string, string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return ParagraphLines.a(t.Item1);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public double room;

		public double size;

		public int? mostLines;

		public Func<string, double, double> measure;

		internal string A(string P_0)
		{
			return ParagraphLines.A(P_0, room, size, mostLines, measure);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public Func<string, double, double> measure;

		public A tags;

		public double size;

		public int lines;

		public bool capped;

		public double whole;

		public double room;

		internal double A(string P_0)
		{
			return measure.Invoke(ArabicShaper.Shape(ParagraphLines.a(P_0, tags)), size);
		}

		internal List<string> A(global::System.Collections.Generic.IList<string> P_0)
		{
			return ParagraphLines.A(P_0, lines, capped ? whole : room, (Func<string, double>)((string P_0) => measure.Invoke(ArabicShaper.Shape(ParagraphLines.a(P_0, tags)), size)));
		}

		internal bool a(string P_0)
		{
			return A(P_0) <= room;
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public string name;

		internal bool A(ValueTuple<string, string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return string.Equals(t.Item1, name, (StringComparison)5);
		}

		internal bool a(ValueTuple<string, string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return string.Equals(t.Item1, name, (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class c : global::System.Collections.Generic.IEnumerable<ValueTuple<string, string, bool>>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<ValueTuple<string, string, bool>>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private ValueTuple<string, string, bool> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string line;

		public string _003C_003E3__line;

		private A tags;

		public A _003C_003E3__tags;

		private int _003Ci_003E5__2;

		private int _003Ctag_003E5__3;

		ValueTuple<string, string, bool> global::System.Collections.Generic.IEnumerator<ValueTuple<string, string, bool>>.Current
		{
			[DebuggerHidden]
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public c(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				_003Ci_003E5__2 += _003Ctag_003E5__3 - 1;
				goto IL_00e9;
			}
			_003C_003E1__state = -1;
			_003Ci_003E5__2 = 0;
			goto IL_00fb;
			IL_00e9:
			_003Ci_003E5__2++;
			goto IL_00fb;
			IL_00fb:
			if (_003Ci_003E5__2 < line.Length)
			{
				char c = line[_003Ci_003E5__2];
				if ((c == '<' || c == '{') ? true : false)
				{
					int? num2 = tags.A(line, _003Ci_003E5__2);
					if (num2.HasValue)
					{
						_003Ctag_003E5__3 = num2.GetValueOrDefault();
						string text = line.Substring(_003Ci_003E5__2, _003Ctag_003E5__3);
						_003C_003E2__current = new ValueTuple<string, string, bool>(ArabicVisualOrder.d(text), text, text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A(), (StringComparison)4) || text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), (StringComparison)4));
						_003C_003E1__state = 1;
						return true;
					}
				}
				goto IL_00e9;
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<ValueTuple<string, string, bool>> B()
		{
			c c;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				c = this;
			}
			else
			{
				c = new c(0);
			}
			c.line = _003C_003E3__line;
			c.tags = _003C_003E3__tags;
			return c;
		}

		global::System.Collections.Generic.IEnumerator<ValueTuple<string, string, bool>> global::System.Collections.Generic.IEnumerable<ValueTuple<string, string, bool>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator b()
		{
			return (global::System.Collections.IEnumerator)B();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}
	}

	public const double Room = 0.94;

	public static string Break(string sentence, double room, double size, int? mostLines, Func<string, double, double> measure)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (sentence == null)
		{
			throw new ArgumentNullException(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ab());
		}
		if (measure == null)
		{
			throw new ArgumentNullException(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aC());
		}
		return string.Join(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa(), Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)sentence.Replace(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aA(), _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa()).Split('\n', (StringSplitOptions)0), (Func<string, string>)((string P_0) => A(P_0, room, size, mostLines, measure))));
	}

	private static string A(string P_0, double P_1, double P_2, int? P_3, Func<string, double, double> P_4)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		A a = new A(P_0);
		List<string> val = new List<string>();
		List<string> val2 = new List<string>();
		int num = 0;
		while (true)
		{
			ValueTuple<int, int>? val3 = ArabicVisualOrder.a(P_0, num);
			if (!val3.HasValue)
			{
				break;
			}
			ValueTuple<int, int> valueOrDefault = val3.GetValueOrDefault();
			val.Add(P_0.Substring(num, valueOrDefault.Item1 - num));
			val2.Add(P_0.Substring(valueOrDefault.Item1, valueOrDefault.Item2));
			num = valueOrDefault.Item1 + valueOrDefault.Item2;
		}
		val.Add(P_0.Substring(num));
		int? num2;
		if (P_3.HasValue)
		{
			int valueOrDefault2 = P_3.GetValueOrDefault();
			if (val.Count > 1)
			{
				num2 = Math.Max(1, valueOrDefault2 - (val.Count - 1));
				goto IL_00bd;
			}
		}
		num2 = P_3;
		goto IL_00bd;
		IL_00bd:
		int? num3 = num2;
		List<string> val4 = new List<string>();
		List<string> val5 = new List<string>();
		bool flag = false;
		for (int i = 0; i < val.Count; i++)
		{
			if (i > 0)
			{
				val5.Add(val2[i - 1]);
			}
			List<string> val6 = A(val[i], P_1, P_2, num3, P_4, a);
			flag |= val6.Count > 1;
			for (int j = 0; j < val6.Count; j++)
			{
				if (j > 0)
				{
					val5.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa());
				}
				val4.Add(val6[j]);
			}
		}
		if (!flag)
		{
			return P_0;
		}
		List<string> val7 = A(val4, a);
		StringBuilder val8 = new StringBuilder(val7[0]);
		for (int k = 1; k < val7.Count; k++)
		{
			val8.Append(val5[k - 1]).Append(val7[k]);
		}
		return ((object)val8).ToString();
	}

	private static List<string> A(string P_0, double P_1, double P_2, int? P_3, Func<string, double, double> P_4, A P_5)
	{
		b CS_0024_003C_003E8__locals0 = new b();
		CS_0024_003C_003E8__locals0.measure = P_4;
		CS_0024_003C_003E8__locals0.tags = P_5;
		CS_0024_003C_003E8__locals0.size = P_2;
		CS_0024_003C_003E8__locals0.room = P_1;
		CS_0024_003C_003E8__locals0.whole = CS_0024_003C_003E8__locals0.A(P_0);
		CS_0024_003C_003E8__locals0.lines = (int)Math.Ceiling(CS_0024_003C_003E8__locals0.whole / CS_0024_003C_003E8__locals0.room);
		int capped;
		if (P_3.HasValue)
		{
			int valueOrDefault = P_3.GetValueOrDefault();
			capped = ((CS_0024_003C_003E8__locals0.lines > valueOrDefault) ? 1 : 0);
		}
		else
		{
			capped = 0;
		}
		CS_0024_003C_003E8__locals0.capped = (byte)capped != 0;
		if (CS_0024_003C_003E8__locals0.capped)
		{
			CS_0024_003C_003E8__locals0.lines = P_3.Value;
		}
		List<string> val = A(P_0, CS_0024_003C_003E8__locals0.tags);
		if (CS_0024_003C_003E8__locals0.lines <= 1 || val.Count < 2)
		{
			List<string> obj = new List<string>();
			obj.Add(P_0);
			return obj;
		}
		return WordsThatStayTogether.Break((global::System.Collections.Generic.IList<string>)val, (global::System.Collections.Generic.IList<string> P_0) => A(P_0, CS_0024_003C_003E8__locals0.lines, CS_0024_003C_003E8__locals0.capped ? CS_0024_003C_003E8__locals0.whole : CS_0024_003C_003E8__locals0.room, (string P_0) => CS_0024_003C_003E8__locals0.measure.Invoke(ArabicShaper.Shape(a(P_0, CS_0024_003C_003E8__locals0.tags)), CS_0024_003C_003E8__locals0.size)), (string P_0) => CS_0024_003C_003E8__locals0.A(P_0) <= CS_0024_003C_003E8__locals0.room);
	}

	private static List<string> A(string P_0, A P_1)
	{
		List<string> val = new List<string>();
		int num = 0;
		int num2 = 0;
		while (num2 <= P_0.Length)
		{
			if (num2 < P_0.Length && P_0[num2] == '<')
			{
				int? num3 = P_1.A(P_0, num2);
				if (num3.HasValue)
				{
					int valueOrDefault = num3.GetValueOrDefault();
					num2 += valueOrDefault;
					continue;
				}
			}
			if (num2 == P_0.Length || P_0[num2] == ' ')
			{
				if (num2 > num)
				{
					val.Add(P_0.Substring(num, num2 - num));
				}
				num = num2 + 1;
			}
			num2++;
		}
		return val;
	}

	private static string a(string P_0, A P_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (P_0.IndexOf('<') < 0 && P_0.IndexOf('{') < 0)
		{
			return P_0;
		}
		StringBuilder val = new StringBuilder(P_0.Length);
		int num = 0;
		while (num < P_0.Length)
		{
			int? num2 = P_1.A(P_0, num);
			if (num2.HasValue)
			{
				int valueOrDefault = num2.GetValueOrDefault();
				if (string.Equals(ArabicVisualOrder.d(P_0.Substring(num, valueOrDefault)), _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.t(), (StringComparison)5))
				{
					val.Append(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.ac());
				}
				num += valueOrDefault;
			}
			else
			{
				val.Append(P_0[num]);
				num++;
			}
		}
		return ((object)val).ToString();
	}

	private static List<string> A(List<string> P_0, A P_1)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.Count < 2 || !Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)P_0, (Func<string, bool>)((string P_0) => P_0.IndexOf('<') >= 0 || P_0.IndexOf('{') >= 0)))
		{
			return P_0;
		}
		Dictionary<string, int> val = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		Enumerator<string> enumerator = P_0.GetEnumerator();
		try
		{
			int num = default(int);
			while (enumerator.MoveNext())
			{
				global::System.Collections.Generic.IEnumerator<ValueTuple<string, string, bool>> enumerator2 = B(enumerator.Current, P_1).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ValueTuple<string, string, bool> current = enumerator2.Current;
						string item = current.Item1;
						if (current.Item3)
						{
							val[item] = (val.TryGetValue(item, ref num) ? num : 0) + 1;
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		List<string> val2 = new List<string>(P_0.Count);
		List<ValueTuple<string, string>> val3 = new List<ValueTuple<string, string>>();
		int num4 = default(int);
		for (int i = 0; i < P_0.Count; i++)
		{
			List<ValueTuple<string, string>> val4 = new List<ValueTuple<string, string>>((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)val3);
			global::System.Collections.Generic.IEnumerator<ValueTuple<string, string, bool>> enumerator2 = B(P_0[i], P_1).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					ValueTuple<string, string, bool> current2 = enumerator2.Current;
					string name = current2.Item1;
					string item2 = current2.Item2;
					if (current2.Item3)
					{
						string text = name;
						int num2 = val[text];
						val[text] = num2 - 1;
						int num3 = val4.FindLastIndex((Predicate<ValueTuple<string, string>>)((ValueTuple<string, string> t) => string.Equals(t.Item1, name, (StringComparison)5)));
						if (num3 >= 0)
						{
							val4.RemoveAt(num3);
						}
					}
					else if (val.TryGetValue(name, ref num4) && num4 > Enumerable.Count<ValueTuple<string, string>>((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)val4, (Func<ValueTuple<string, string>, bool>)((ValueTuple<string, string> t) => string.Equals(t.Item1, name, (StringComparison)5))))
					{
						val4.Add(new ValueTuple<string, string>(name, item2));
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator2)?.Dispose();
			}
			string text2 = string.Concat(string.Concat(Enumerable.Select<ValueTuple<string, string>, string>((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)val3, (Func<ValueTuple<string, string>, string>)((ValueTuple<string, string> t) => t.Item2))), P_0[i]);
			if (i < P_0.Count - 1)
			{
				text2 = string.Concat(text2, string.Concat(Enumerable.Select<ValueTuple<string, string>, string>(Enumerable.Reverse<ValueTuple<string, string>>((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)val4), (Func<ValueTuple<string, string>, string>)((ValueTuple<string, string> t) => a(t.Item1)))));
			}
			val2.Add(text2);
			val3 = val4;
		}
		return val2;
	}

	[IteratorStateMachine(typeof(c))]
	private static global::System.Collections.Generic.IEnumerable<ValueTuple<string, string, bool>> B(string P_0, A P_1)
	{
		for (int i = 0; i < P_0.Length; i++)
		{
			char c = P_0[i];
			if ((c == '<' || c == '{') ? true : false)
			{
				int? num = P_1.A(P_0, i);
				if (num.HasValue)
				{
					int tag = num.GetValueOrDefault();
					string text = P_0.Substring(i, tag);
					yield return new ValueTuple<string, string, bool>(ArabicVisualOrder.d(text), text, text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A(), (StringComparison)4) || text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), (StringComparison)4));
					i += tag - 1;
				}
			}
		}
	}

	private static HashSet<string> A(string P_0)
	{
		HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		for (int num = P_0.IndexOf(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), (StringComparison)4); num >= 0; num = P_0.IndexOf(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), num + 1, (StringComparison)4))
		{
			int? num2 = A(P_0, num);
			if (num2.HasValue)
			{
				int valueOrDefault = num2.GetValueOrDefault();
				val.Add(ArabicVisualOrder.d(P_0.Substring(num, valueOrDefault)));
			}
		}
		return val;
	}

	private static int? A(string P_0, int P_1)
	{
		int num = ((P_1 + 1 < P_0.Length && P_0[P_1 + 1] == '/') ? (P_1 + 2) : (P_1 + 1));
		int i;
		for (i = num; i < P_0.Length && (char.IsLetter(P_0[i]) || P_0[i] == '_'); i++)
		{
		}
		if (i <= num || i >= P_0.Length || P_0[i] != '}')
		{
			return null;
		}
		return i - P_1 + 1;
	}

	private static string a(string P_0)
	{
		if (!P_0.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.D(), (StringComparison)4))
		{
			return _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A() + P_0 + _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aD();
		}
		return _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a() + P_0.Substring(1) + _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.B();
	}

	private static List<string> A(global::System.Collections.Generic.IList<string> P_0, int P_1, double P_2, Func<string, double> P_3)
	{
		double num = Enumerable.Max<string>((global::System.Collections.Generic.IEnumerable<string>)P_0, P_3);
		double num2 = Math.Max(num, P_2);
		for (int i = 0; i < 24; i++)
		{
			if (!(num2 - num > 0.5))
			{
				break;
			}
			double num3 = (num + num2) / 2.0;
			if (A(P_0, num3, P_3).Count <= P_1)
			{
				num2 = num3;
			}
			else
			{
				num = num3;
			}
		}
		return A(P_0, num2, P_3);
	}

	private static List<string> A(global::System.Collections.Generic.IList<string> P_0, double P_1, Func<string, double> P_2)
	{
		List<string> val = new List<string>();
		string text = _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.c();
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)P_0).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string text2 = ((text.Length == 0) ? current : (text + _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aB() + current));
				if (text.Length > 0 && P_2.Invoke(text2) > P_1)
				{
					val.Add(text);
					text = current;
				}
				else
				{
					text = text2;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (text.Length > 0)
		{
			val.Add(text);
		}
		return val;
	}
}
