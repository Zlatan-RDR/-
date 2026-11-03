using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B78C53E54_002D85C4_002D4BB2_002DB75C_002D1FE345444E71_007D;

namespace Miqbas.Rendering.Arabic.Shaping;

public static class ArabicVisualOrder
{
	private sealed class A
	{
		internal string Text = _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.c();

		internal string Open = _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.c();

		internal string Close = _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.c();

		internal List<A>? Children;
	}

	[CompilerGenerated]
	private static class a
	{
		public static Func<char, bool> _003C0_003E__IsSurrogate;

		public static Func<A, bool> _003C1_003E__ReadsLeftToRightOnly;

		public static Func<A, bool> _003C2_003E__HasStrongLeftToRight;

		public static Func<char, bool> _003C3_003E__ReadsLeftToRight;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct B
	{
		public Stack<ValueTuple<string, string, List<A>>> open;

		public List<A> root;

		public StringBuilder text;
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string name;

		internal bool A(ValueTuple<string, string, List<A>> e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return string.Equals(e.Item1, name, (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public char c;

		internal bool A(char P_0)
		{
			return P_0 == c;
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public string name;

		internal bool A(ValueTuple<string, int> e)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return string.Equals(e.Item1, name, (StringComparison)5);
		}
	}

	private static readonly HashSet<string> TheRenderersOwnTags;

	public static string ForARendererThatTurnsItRound(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return text ?? string.Empty;
		}
		string text2 = ToVisual(text);
		if (text2 == text || string.Equals(text2, text, (StringComparison)4))
		{
			return text;
		}
		return A(text2);
	}

	public static string FromARendererThatTurnsItRound(string handed)
	{
		if (!string.IsNullOrEmpty(handed))
		{
			return A(handed);
		}
		return handed ?? string.Empty;
	}

	private static string A(string P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder(P_0.Length);
		int num = 0;
		for (int i = 0; i <= P_0.Length; i++)
		{
			if (i < P_0.Length && P_0[i] != '\n')
			{
				continue;
			}
			int num2 = i;
			if (num2 > num && P_0[num2 - 1] == '\r')
			{
				num2--;
			}
			string text = P_0.Substring(num, num2 - num);
			int num3 = 0;
			while (true)
			{
				ValueTuple<int, int>? val2 = a(text, num3);
				if (!val2.HasValue)
				{
					break;
				}
				ValueTuple<int, int> valueOrDefault = val2.GetValueOrDefault();
				A(text.Substring(num3, valueOrDefault.Item1 - num3), val);
				val.Append(text, valueOrDefault.Item1, valueOrDefault.Item2);
				num3 = valueOrDefault.Item1 + valueOrDefault.Item2;
			}
			A(text.Substring(num3), val);
			if (i < P_0.Length)
			{
				val.Append(P_0, num2, i - num2 + 1);
			}
			num = i + 1;
		}
		return ((object)val).ToString();
	}

	private static void A(string P_0, StringBuilder P_1)
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.Length == 0)
		{
			return;
		}
		if (P_0.IndexOf('<') < 0 && P_0.IndexOf('{') < 0 && !Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsSurrogate))
		{
			char[] array = P_0.ToCharArray();
			global::System.Array.Reverse<char>(array);
			P_1.Append(array);
			return;
		}
		List<ValueTuple<int, int>> val = new List<ValueTuple<int, int>>(P_0.Length);
		List<ValueTuple<string, int>> val2 = new List<ValueTuple<string, int>>();
		HashSet<string> val3 = b(P_0);
		int num = 0;
		while (num < P_0.Length)
		{
			int? num2 = P_0[num] switch
			{
				'<' => A(P_0, num, (global::System.Collections.Generic.ICollection<string>)val3), 
				'{' => A(P_0, num), 
				_ => null, 
			};
			if (num2.HasValue)
			{
				int valueOrDefault = num2.GetValueOrDefault();
				string text = P_0.Substring(num, valueOrDefault);
				string name = d(text);
				int count = val.Count;
				val.Add(new ValueTuple<int, int>(num, valueOrDefault));
				num += valueOrDefault;
				if (!text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A(), (StringComparison)4) && !text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), (StringComparison)4))
				{
					val2.Add(new ValueTuple<string, int>(name, count));
					continue;
				}
				int num3 = val2.FindLastIndex((Predicate<ValueTuple<string, int>>)((ValueTuple<string, int> e) => string.Equals(e.Item1, name, (StringComparison)5)));
				if (num3 >= 0)
				{
					int item = val2[num3].Item2;
					val2.RemoveRange(num3, val2.Count - num3);
					List<ValueTuple<int, int>> val4 = val;
					int num4 = item;
					int num5 = count;
					ValueTuple<int, int> val5 = val[count];
					ValueTuple<int, int> val6 = val[item];
					val4[num4] = val5;
					val[num5] = val6;
				}
			}
			else
			{
				int num6 = ((!char.IsHighSurrogate(P_0[num]) || num + 1 >= P_0.Length || !char.IsLowSurrogate(P_0[num + 1])) ? 1 : 2);
				val.Add(new ValueTuple<int, int>(num, num6));
				num += num6;
			}
		}
		for (int num7 = val.Count - 1; num7 >= 0; num7--)
		{
			P_1.Append(P_0, val[num7].Item1, val[num7].Item2);
		}
	}

	public static bool HasMarkup(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		int num = text.IndexOf('<');
		if (num >= 0 && text.IndexOf('>', num) > num)
		{
			return true;
		}
		for (int num2 = text.IndexOf('{'); num2 >= 0; num2 = text.IndexOf('{', num2 + 1))
		{
			if (A(text, num2).HasValue && text[num2 + 1] != '/')
			{
				return true;
			}
		}
		return false;
	}

	internal static int? A(string P_0, int P_1)
	{
		int num = P_0.IndexOf('}', P_1 + 1);
		bool flag = P_1 + 1 < P_0.Length && P_0[P_1 + 1] == '/';
		int num2 = P_1 + ((!flag) ? 1 : 2);
		if (num <= num2)
		{
			return null;
		}
		for (int i = num2; i < num; i++)
		{
			if (!char.IsLetter(P_0[i]) && P_0[i] != '_')
			{
				return null;
			}
		}
		if (!flag && P_0.IndexOf(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a() + P_0.Substring(num2, num - num2) + _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.B(), num + 1, (StringComparison)4) < 0)
		{
			return null;
		}
		return num - P_1 + 1;
	}

	public static string ToVisual(string text)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (string.IsNullOrEmpty(text))
		{
			return text ?? string.Empty;
		}
		if (!a(text))
		{
			return text;
		}
		StringBuilder val = new StringBuilder(text.Length);
		int num = 0;
		for (int i = 0; i <= text.Length; i++)
		{
			if (i >= text.Length || text[i] == '\n')
			{
				int num2 = i;
				if (num2 > num && text[num2 - 1] == '\r')
				{
					num2--;
				}
				val.Append(B(text.Substring(num, num2 - num)));
				if (i < text.Length)
				{
					val.Append(text, num2, i - num2 + 1);
				}
				num = i + 1;
			}
		}
		return ((object)val).ToString();
	}

	private static bool a(string P_0)
	{
		foreach (char c in P_0)
		{
			if (c >= 'יִ')
			{
				if (c >= 'ﹰ')
				{
					if (c <= '\ufeff')
					{
						goto IL_0042;
					}
				}
				else if (c <= '﷿')
				{
					goto IL_0042;
				}
			}
			else if (c >= '\u0590' && c <= '\u08ff')
			{
				goto IL_0042;
			}
			bool flag = false;
			goto IL_0048;
			IL_0042:
			flag = true;
			goto IL_0048;
			IL_0048:
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	private static string B(string P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder(P_0.Length);
		int num = 0;
		while (true)
		{
			ValueTuple<int, int>? val2 = a(P_0, num);
			if (!val2.HasValue)
			{
				break;
			}
			ValueTuple<int, int> valueOrDefault = val2.GetValueOrDefault();
			val.Append(C(P_0.Substring(num, valueOrDefault.Item1 - num)));
			val.Append(P_0.Substring(valueOrDefault.Item1, valueOrDefault.Item2));
			num = valueOrDefault.Item1 + valueOrDefault.Item2;
		}
		val.Append(C(P_0.Substring(num)));
		return ((object)val).ToString();
	}

	internal static HashSet<string> b(string P_0)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		if (string.IsNullOrEmpty(P_0) || P_0.IndexOf(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A(), (StringComparison)4) < 0)
		{
			return val;
		}
		HashSet<string> val2 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		HashSet<string> val3 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		for (int num = P_0.IndexOf('<'); num >= 0; num = P_0.IndexOf('<', num + 1))
		{
			int? num2 = b(P_0, num);
			if (num2.HasValue)
			{
				int valueOrDefault = num2.GetValueOrDefault();
				string text = d(P_0.Substring(num, valueOrDefault));
				if (text != null && text.Length > 0)
				{
					((P_0[num + 1] == '/') ? val3 : val2).Add(text);
				}
			}
		}
		Enumerator<string> enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (val3.Contains(current))
				{
					val.Add(current);
				}
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	internal static int? A(string P_0, int P_1, global::System.Collections.Generic.ICollection<string> P_2)
	{
		int? num = b(P_0, P_1);
		if (num.HasValue)
		{
			int valueOrDefault = num.GetValueOrDefault();
			string text = d(P_0.Substring(P_1, valueOrDefault));
			if (text.Length <= 0 || (text[0] != '#' && !TheRenderersOwnTags.Contains(text) && !P_2.Contains(text)))
			{
				return null;
			}
			return valueOrDefault;
		}
		return null;
	}

	internal static ValueTuple<int, int>? a(string P_0, int P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = P_1; i < P_0.Length; i++)
		{
			int? num = B(P_0, i);
			if (num.HasValue)
			{
				int valueOrDefault = num.GetValueOrDefault();
				return new ValueTuple<int, int>(i, valueOrDefault);
			}
			if (P_0[i] != '<')
			{
				continue;
			}
			num = b(P_0, i);
			if (num.HasValue)
			{
				int valueOrDefault2 = num.GetValueOrDefault();
				string text = d(P_0.Substring(i, valueOrDefault2));
				if (string.Equals(text, _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.b(), (StringComparison)5) || string.Equals(text, _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.C(), (StringComparison)5))
				{
					return new ValueTuple<int, int>(i, valueOrDefault2);
				}
			}
		}
		return null;
	}

	private static int? B(string P_0, int P_1)
	{
		if (P_0[P_1] != '\\' || P_1 + 1 >= P_0.Length || (P_1 > 0 && P_0[P_1 - 1] == '\\'))
		{
			return null;
		}
		if (P_0[P_1 + 1] == 'n')
		{
			return 2;
		}
		if (P_0[P_1 + 1] != 'r' || P_1 + 3 >= P_0.Length || P_0[P_1 + 2] != '\\' || P_0[P_1 + 3] != 'n')
		{
			return null;
		}
		return 4;
	}

	private static string C(string P_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (P_0.Length == 0)
		{
			return P_0;
		}
		if (!HasMarkup(P_0))
		{
			return E(P_0);
		}
		StringBuilder val = new StringBuilder(P_0.Length);
		A(c(P_0), val);
		return ((object)val).ToString();
	}

	private static List<A> c(string P_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		B b = default(B);
		b.root = new List<A>();
		b.open = new Stack<ValueTuple<string, string, List<A>>>();
		b.text = new StringBuilder();
		int num = 0;
		while (num < P_0.Length)
		{
			int? num2 = P_0[num] switch
			{
				'<' => ArabicVisualOrder.b(P_0, num), 
				'{' => A(P_0, num), 
				_ => null, 
			};
			if (!num2.HasValue)
			{
				b.text.Append(P_0[num]);
				num++;
				continue;
			}
			string text = P_0.Substring(num, num2.Value);
			string name = d(text);
			a(ref b);
			if (!text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A(), (StringComparison)4) && !text.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), (StringComparison)4))
			{
				b.open.Push(new ValueTuple<string, string, List<A>>(name, text, new List<A>()));
			}
			else if (Enumerable.Any<ValueTuple<string, string, List<A>>>((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string, List<A>>>)b.open, (Func<ValueTuple<string, string, List<A>>, bool>)((ValueTuple<string, string, List<A>> e) => string.Equals(e.Item1, name, (StringComparison)5))))
			{
				while (!string.Equals(b.open.Peek().Item1, name, (StringComparison)5))
				{
					A(b.open.Pop(), (b.open.Count == 0) ? b.root : b.open.Peek().Item3);
				}
				ValueTuple<string, string, List<A>> val = b.open.Pop();
				((b.open.Count == 0) ? b.root : b.open.Peek().Item3).Add(new A
				{
					Open = val.Item2,
					Close = text,
					Children = val.Item3
				});
			}
			else
			{
				A(ref b).Add(new A
				{
					Open = text
				});
			}
			num += num2.Value;
		}
		a(ref b);
		while (b.open.Count > 0)
		{
			A(b.open.Pop(), (b.open.Count == 0) ? b.root : b.open.Peek().Item3);
		}
		return b.root;
	}

	private static void A(ValueTuple<string, string, List<A>> element, List<A> P_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		P_1.Add(new A
		{
			Open = element.Item2
		});
		P_1.AddRange((global::System.Collections.Generic.IEnumerable<A>)element.Item3);
	}

	private static void A(List<A> P_0, StringBuilder P_1)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		int num = P_0.Count - 1;
		while (num >= 0)
		{
			int num2 = num;
			while (num2 >= 0 && A(P_0[num2]))
			{
				num2--;
			}
			num2++;
			if (num2 <= num && A(P_0, num2, num))
			{
				StringBuilder val = new StringBuilder();
				for (int i = num2; i <= num; i++)
				{
					a(P_0[i], val);
				}
				P_1.Append(D(((object)val).ToString()));
				num = num2 - 1;
			}
			else
			{
				A(P_0[num], P_1);
				num--;
			}
		}
	}

	private static string D(string P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		StringBuilder val2 = new StringBuilder();
		string text = P_0;
		while (true)
		{
			bool flag = text.Length > 0;
			if (flag)
			{
				char c = text[text.Length - 1];
				bool flag2 = ((c == ')' || c == ']' || c == '»') ? true : false);
				flag = flag2;
			}
			if (flag && A(text, D(text[text.Length - 1])) < A(text, text[text.Length - 1]))
			{
				val.Insert(0, D(text[text.Length - 1]));
				text = text.Substring(0, text.Length - 1);
				continue;
			}
			break;
		}
		while (true)
		{
			bool flag = text.Length > 0;
			if (flag)
			{
				char c = text[0];
				bool flag2 = ((c == '(' || c == '[' || c == '«') ? true : false);
				flag = flag2;
			}
			if (!flag || A(text, D(text[0])) >= A(text, text[0]))
			{
				break;
			}
			val2.Append(D(text[0]));
			text = text.Substring(1);
		}
		if (val.Length != 0 || val2.Length != 0)
		{
			return ((object)val)?.ToString() + text + (object)val2;
		}
		return P_0;
	}

	private static void A(A P_0, StringBuilder P_1)
	{
		List<A> children = P_0.Children;
		if (children != null)
		{
			P_1.Append(P_0.Open);
			A(children, P_1);
			P_1.Append(P_0.Close);
		}
		else if (P_0.Open.Length > 0)
		{
			P_1.Append(P_0.Open);
		}
		else
		{
			P_1.Append(E(P_0.Text));
		}
	}

	private static void a(A P_0, StringBuilder P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		List<A> children = P_0.Children;
		if (children != null)
		{
			P_1.Append(P_0.Open);
			Enumerator<A> enumerator = children.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					a(enumerator.Current, P_1);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			P_1.Append(P_0.Close);
		}
		else if (P_0.Open.Length > 0)
		{
			P_1.Append(P_0.Open);
		}
		else
		{
			P_1.Append(P_0.Text);
		}
	}

	private static bool A(A P_0)
	{
		List<A> children = P_0.Children;
		if (children != null)
		{
			return Enumerable.All<A>((global::System.Collections.Generic.IEnumerable<A>)children, (Func<A, bool>)A);
		}
		if (P_0.Open.Length <= 0)
		{
			return !a(P_0.Text);
		}
		return true;
	}

	private static bool A(List<A> P_0, int P_1, int P_2)
	{
		for (int i = P_1; i <= P_2; i++)
		{
			if (a(P_0[i]))
			{
				return true;
			}
		}
		return false;
	}

	private static bool a(A P_0)
	{
		List<A> children = P_0.Children;
		if (children != null)
		{
			return Enumerable.Any<A>((global::System.Collections.Generic.IEnumerable<A>)children, (Func<A, bool>)a);
		}
		if (P_0.Open.Length == 0)
		{
			return Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0.Text, (Func<char, bool>)a);
		}
		return false;
	}

	internal static int? b(string P_0, int P_1)
	{
		int num = P_0.IndexOf('>', P_1 + 1);
		if (num < 0 || num == P_1 + 1)
		{
			return null;
		}
		int num2 = P_0.IndexOf('<', P_1 + 1);
		if (num2 < 0 || num2 >= num)
		{
			return num - P_1 + 1;
		}
		return null;
	}

	internal static string d(string P_0)
	{
		int num = ((!P_0.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.A(), (StringComparison)4) && !P_0.StartsWith(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.a(), (StringComparison)4)) ? 1 : 2);
		int num2 = num;
		while (true)
		{
			bool flag = num < P_0.Length;
			if (flag)
			{
				bool flag2;
				switch (P_0[num])
				{
				case ' ':
				case '/':
				case '=':
				case '>':
				case '}':
					flag2 = true;
					break;
				default:
					flag2 = false;
					break;
				}
				flag = !flag2;
			}
			if (!flag)
			{
				break;
			}
			num++;
		}
		return ((P_0[0] == '{') ? _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.D() : _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.c()) + P_0.Substring(num2, num - num2);
	}

	private static string E(string P_0)
	{
		if (P_0.Length == 0)
		{
			return P_0;
		}
		char[] array = e(P_0);
		int num = 0;
		while (num < array.Length)
		{
			if (!a(array[num]))
			{
				num++;
				continue;
			}
			int num2 = num;
			int i = num;
			for (int j = num; j < array.Length; j++)
			{
				if (a(array[j]))
				{
					i = j;
				}
				else if (!C(array[j]))
				{
					break;
				}
			}
			while (num2 > 0 && c(array[num2 - 1]))
			{
				num2--;
			}
			for (; i + 1 < array.Length && c(array[i + 1]); i++)
			{
			}
			global::System.Array.Reverse<char>(array, num2, i - num2 + 1);
			for (int k = num2; k <= i; k++)
			{
				array[k] = D(array[k]);
			}
			num = i + 1;
		}
		return new string(array);
	}

	private static char[] e(string P_0)
	{
		char[] array = new char[P_0.Length];
		int num = 0;
		for (int num2 = P_0.Length - 1; num2 >= 0; num2--)
		{
			int num3 = num2;
			while (num2 > 0 && A(P_0[num2]))
			{
				num2--;
			}
			if (num2 > 0 && char.IsLowSurrogate(P_0[num2]) && char.IsHighSurrogate(P_0[num2 - 1]))
			{
				num2--;
			}
			for (int i = num2; i <= num3; i++)
			{
				array[num++] = D(P_0[i]);
			}
		}
		return array;
	}

	public static string WithMarksBeforeTheirLetters(string laidOut)
	{
		if (string.IsNullOrEmpty(laidOut))
		{
			return laidOut ?? string.Empty;
		}
		char[] array = laidOut.ToCharArray();
		int num = 0;
		while (num < array.Length)
		{
			if (!b(array[num]) || A(array[num]))
			{
				num++;
				continue;
			}
			int i;
			for (i = num + 1; i < array.Length && A(array[i]) && b(array[i]); i++)
			{
			}
			if (i > num + 1)
			{
				char c = array[num];
				global::System.Array.Copy((global::System.Array)array, num + 1, (global::System.Array)array, num, i - num - 1);
				array[i - 1] = c;
			}
			num = i;
		}
		return new string(array);
	}

	private static bool A(char P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(P_0);
		if (unicodeCategory - 5 <= 2)
		{
			return true;
		}
		return false;
	}

	private static bool a(char P_0)
	{
		if ((!char.IsLetterOrDigit(P_0) || b(P_0)) && !B(P_0))
		{
			if (P_0 >= '\u0300')
			{
				return P_0 <= '\u036f';
			}
			return false;
		}
		return true;
	}

	private static bool B(char P_0)
	{
		switch (P_0)
		{
		case '٠':
		case '١':
		case '٢':
		case '٣':
		case '٤':
		case '٥':
		case '٦':
		case '٧':
		case '٨':
		case '٩':
		case '۰':
		case '۱':
		case '۲':
		case '۳':
		case '۴':
		case '۵':
		case '۶':
		case '۷':
		case '۸':
		case '۹':
			return true;
		default:
			return false;
		}
	}

	private static bool b(char P_0)
	{
		if ((P_0 < '\u0590' || P_0 > '\u08ff') && (P_0 < 'יִ' || P_0 > '﷿'))
		{
			if (P_0 >= 'ﹰ')
			{
				return P_0 <= '\ufeff';
			}
			return false;
		}
		return true;
	}

	private static bool C(char P_0)
	{
		if (!char.IsWhiteSpace(P_0))
		{
			return c(P_0);
		}
		return true;
	}

	private static bool c(char P_0)
	{
		switch (P_0)
		{
		case '#':
		case '$':
		case '%':
		case '&':
		case '\'':
		case '+':
		case ',':
		case '-':
		case '.':
		case '/':
		case ':':
		case '@':
		case '_':
		case '{':
		case '}':
		case '٫':
		case '٬':
			return true;
		default:
			return false;
		}
	}

	private static char D(char P_0)
	{
		return P_0 switch
		{
			'(' => ')', 
			')' => '(', 
			'[' => ']', 
			']' => '[', 
			'{' => '}', 
			'}' => '{', 
			'<' => '>', 
			'>' => '<', 
			'«' => '»', 
			'»' => '«', 
			_ => P_0, 
		};
	}

	static ArabicVisualOrder()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.d());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.E());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.e());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.F());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.f());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.G());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.b());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.g());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.H());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.h());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.I());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.i());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.J());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.j());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.K());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.k());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.L());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.l());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.M());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.m());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.N());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.n());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.O());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.o());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.P());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.p());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.C());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.Q());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.q());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.R());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.r());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.S());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.s());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.T());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.t());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.U());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.u());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.V());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.v());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.W());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.w());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.X());
		obj.Add(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.x());
		TheRenderersOwnTags = obj;
	}

	[CompilerGenerated]
	internal static List<A> A(ref B P_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.open.Count != 0)
		{
			return P_0.open.Peek().Item3;
		}
		return P_0.root;
	}

	[CompilerGenerated]
	internal static void a(ref B P_0)
	{
		if (P_0.text.Length != 0)
		{
			A(ref P_0).Add(new A
			{
				Text = ((object)P_0.text).ToString()
			});
			P_0.text.Clear();
		}
	}

	[CompilerGenerated]
	internal static int A(string P_0, char P_1)
	{
		return Enumerable.Count<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 == P_1));
	}
}
