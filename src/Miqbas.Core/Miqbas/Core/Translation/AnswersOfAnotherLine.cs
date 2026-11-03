using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class AnswersOfAnotherLine
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ValueTuple<int, string, string>, ValueTuple<int, HashSet<string>, string>> _003C_003E9__5_0;

		public static Func<ValueTuple<int, HashSet<string>, string>, bool> _003C_003E9__5_1;

		public static Func<ValueTuple<int, HashSet<string>, string>, string> _003C_003E9__5_2;

		public static Func<IGrouping<string, ValueTuple<int, HashSet<string>, string>>, bool> _003C_003E9__5_3;

		internal ValueTuple<int, HashSet<string>, string> A(ValueTuple<int, string, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<int, HashSet<string>, string>(a.Item1, AnswersOfAnotherLine.a(a.Item2), AnswersOfAnotherLine.A(a.Item3));
		}

		internal bool A(ValueTuple<int, HashSet<string>, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item3.Length >= 8;
		}

		internal string a(ValueTuple<int, HashSet<string>, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item3;
		}

		internal bool A(IGrouping<string, ValueTuple<int, HashSet<string>, string>> g)
		{
			return Enumerable.Count<ValueTuple<int, HashSet<string>, string>>((System.Collections.Generic.IEnumerable<ValueTuple<int, HashSet<string>, string>>)g) > 1;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public ValueTuple<int, HashSet<string>, string> one;

		internal bool A(ValueTuple<int, HashSet<string>, string> other)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			if (other.Item1 != one.Item1)
			{
				return !other.Item2.Overlaps((System.Collections.Generic.IEnumerable<string>)one.Item2);
			}
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct B
	{
		public StringBuilder word;

		public HashSet<string> words;
	}

	private const int FewestLetters = 8;

	private const int AWord = 4;

	[field: CompilerGenerated]
	public static QualityIssue Issue
	{
		[CompilerGenerated]
		get;
	} = new QualityIssue
	{
		Kind = QualityIssueKind.AnswerOfAnotherLine,
		Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.au(),
		AcceptedOnLastAttempt = true
	};


	public static System.Collections.Generic.IReadOnlyCollection<int> In(System.Collections.Generic.IEnumerable<ValueTuple<int, string, string>> answers)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		HashSet<int> val = new HashSet<int>();
		List<ValueTuple<int, HashSet<string>, string>> val2 = Enumerable.ToList<ValueTuple<int, HashSet<string>, string>>(Enumerable.Select<ValueTuple<int, string, string>, ValueTuple<int, HashSet<string>, string>>(answers, (Func<ValueTuple<int, string, string>, ValueTuple<int, HashSet<string>, string>>)((ValueTuple<int, string, string> a) => new ValueTuple<int, HashSet<string>, string>(a.Item1, AnswersOfAnotherLine.a(a.Item2), A(a.Item3)))));
		System.Collections.Generic.IEnumerator<IGrouping<string, ValueTuple<int, HashSet<string>, string>>> enumerator = Enumerable.Where<IGrouping<string, ValueTuple<int, HashSet<string>, string>>>(Enumerable.GroupBy<ValueTuple<int, HashSet<string>, string>, string>(Enumerable.Where<ValueTuple<int, HashSet<string>, string>>((System.Collections.Generic.IEnumerable<ValueTuple<int, HashSet<string>, string>>)val2, (Func<ValueTuple<int, HashSet<string>, string>, bool>)((ValueTuple<int, HashSet<string>, string> a) => a.Item3.Length >= 8)), (Func<ValueTuple<int, HashSet<string>, string>, string>)((ValueTuple<int, HashSet<string>, string> a) => a.Item3), (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<IGrouping<string, ValueTuple<int, HashSet<string>, string>>, bool>)((IGrouping<string, ValueTuple<int, HashSet<string>, string>> g) => Enumerable.Count<ValueTuple<int, HashSet<string>, string>>((System.Collections.Generic.IEnumerable<ValueTuple<int, HashSet<string>, string>>)g) > 1)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				List<ValueTuple<int, HashSet<string>, string>> val3 = Enumerable.ToList<ValueTuple<int, HashSet<string>, string>>((System.Collections.Generic.IEnumerable<ValueTuple<int, HashSet<string>, string>>)enumerator.Current);
				Enumerator<ValueTuple<int, HashSet<string>, string>> enumerator2 = val3.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						ValueTuple<int, HashSet<string>, string> one = enumerator2.Current;
						if (Enumerable.Any<ValueTuple<int, HashSet<string>, string>>((System.Collections.Generic.IEnumerable<ValueTuple<int, HashSet<string>, string>>)val3, (Func<ValueTuple<int, HashSet<string>, string>, bool>)((ValueTuple<int, HashSet<string>, string> other) => other.Item1 != one.Item1 && !other.Item2.Overlaps((System.Collections.Generic.IEnumerable<string>)one.Item2))))
						{
							val.Add(one.Item1);
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2).Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count * 2 < val2.Count)
		{
			return (System.Collections.Generic.IReadOnlyCollection<int>)val;
		}
		return (System.Collections.Generic.IReadOnlyCollection<int>)new HashSet<int>();
	}

	private static string A(string P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		StringBuilder val = new StringBuilder(P_0.Length);
		int num = 0;
		foreach (char c in P_0)
		{
			switch (c)
			{
			case '<':
			case '[':
			case '{':
			case '⟦':
				num++;
				continue;
			case '>':
			case ']':
			case '}':
			case '⟧':
				num = Math.Max(0, num - 1);
				continue;
			}
			bool flag = num == 0;
			bool flag2;
			if (flag)
			{
				if (c >= 'ٱ')
				{
					if (c <= 'ۓ')
					{
						goto IL_00b2;
					}
				}
				else if (c >= 'ء' && c <= 'ي')
				{
					goto IL_00b2;
				}
				flag2 = false;
				goto IL_00ba;
			}
			goto IL_00be;
			IL_00be:
			if (flag)
			{
				val.Append(c);
			}
			continue;
			IL_00ba:
			flag = flag2;
			goto IL_00be;
			IL_00b2:
			flag2 = true;
			goto IL_00ba;
		}
		return ((object)val).ToString();
	}

	private static HashSet<string> a(string P_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		B b = default(B);
		b.words = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		b.word = new StringBuilder();
		int num = 0;
		foreach (char c in P_0)
		{
			switch (c)
			{
			case '<':
			case '[':
			case '{':
				A(ref b);
				num++;
				continue;
			case '>':
			case ']':
			case '}':
				num = Math.Max(0, num - 1);
				continue;
			}
			if (num == 0 && char.IsLetter(c))
			{
				b.word.Append(c);
			}
			else
			{
				A(ref b);
			}
		}
		A(ref b);
		return b.words;
	}

	[CompilerGenerated]
	internal static void A(ref B P_0)
	{
		if (P_0.word.Length >= 4)
		{
			string text = ((object)P_0.word).ToString().ToLowerInvariant();
			P_0.words.Add((text.Length > 5) ? text.Substring(0, 5) : text);
		}
		P_0.word.Clear();
	}
}
