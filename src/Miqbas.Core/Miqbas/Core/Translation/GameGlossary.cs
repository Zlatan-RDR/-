using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

public static class GameGlossary
{
	private sealed class A
	{
		private static readonly Regex Word = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RH(), (RegexOptions)8);

		private readonly Dictionary<string, List<int>> _lines = new Dictionary<string, List<int>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);

		public static A A(System.Collections.Generic.IReadOnlyList<SourceText> P_0)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			A a = new A();
			HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
			List<int> val2 = default(List<int>);
			for (int i = 0; i < ((System.Collections.Generic.IReadOnlyCollection<SourceText>)P_0).Count; i++)
			{
				val.Clear();
				foreach (Match item in Word.Matches(P_0[i].Value))
				{
					string text = ((Capture)item).Value.ToLowerInvariant();
					if (val.Add(text))
					{
						if (!a._lines.TryGetValue(text, ref val2))
						{
							val2 = (a._lines[text] = new List<int>());
						}
						val2.Add(i);
					}
				}
			}
			return a;
		}

		public System.Collections.Generic.IReadOnlyList<int> A(string P_0)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			System.Collections.Generic.IReadOnlyList<int> readOnlyList = null;
			List<int> val2 = default(List<int>);
			foreach (Match item in Word.Matches(P_0))
			{
				Match val = item;
				if (!_lines.TryGetValue(((Capture)val).Value.ToLowerInvariant(), ref val2))
				{
					return System.Array.Empty<int>();
				}
				if (readOnlyList == null || val2.Count < ((System.Collections.Generic.IReadOnlyCollection<int>)readOnlyList).Count)
				{
					readOnlyList = (System.Collections.Generic.IReadOnlyList<int>)val2;
				}
			}
			return readOnlyList ?? System.Array.Empty<int>();
		}
	}

	[CompilerGenerated]
	private static class a
	{
		public static Func<char, bool> _003C0_003E__IsLetter;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B
	{
		public static readonly B _003C_003E9 = new B();

		public static Func<ValueTuple<SourceText, int>, bool> _003C_003E9__6_1;

		public static Func<ValueTuple<SourceText, int>, int> _003C_003E9__6_2;

		public static Func<ValueTuple<SourceText, int>, string> _003C_003E9__6_3;

		public static Func<ValueTuple<SourceText, int>, SourceText> _003C_003E9__6_4;

		public static Func<GlossaryEntry, string> _003C_003E9__8_0;

		internal bool A(ValueTuple<SourceText, int> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return x.Item2 >= 3;
		}

		internal int a(ValueTuple<SourceText, int> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return x.Item2;
		}

		internal string B(ValueTuple<SourceText, int> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return x.Item1.Value;
		}

		internal SourceText b(ValueTuple<SourceText, int> x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return x.Item1;
		}

		internal string A(GlossaryEntry P_0)
		{
			return P_0.Term;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public System.Collections.Generic.IReadOnlyList<SourceText> sources;

		public A index;

		internal ValueTuple<SourceText, int> A(KeyValuePair<string, SourceText> P_0)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<SourceText, int>(P_0.Value, GameGlossary.A(P_0.Key, sources, index));
		}
	}

	private const int MinimumUses = 3;

	private const int MaximumLength = 24;

	private const int MinimumLength = 4;

	private const int MaximumTerms = 80;

	private static readonly HashSet<string> NotTerminology;

	private static readonly char[] NotInATerm;

	public static System.Collections.Generic.IReadOnlyList<SourceText> TermsIn(System.Collections.Generic.IReadOnlyList<SourceText> sources)
	{
		System.Collections.Generic.IReadOnlyList<SourceText> sources2 = sources;
		ArgumentNullException.ThrowIfNull((object)sources2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bn());
		Dictionary<string, SourceText> val = new Dictionary<string, SourceText>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		System.Collections.Generic.IEnumerator<SourceText> enumerator = ((System.Collections.Generic.IEnumerable<SourceText>)sources2).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				SourceText current = enumerator.Current;
				if (A(current.Value))
				{
					val.TryAdd(current.Value.Trim(), current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count == 0)
		{
			return System.Array.Empty<SourceText>();
		}
		A index = GameGlossary.A.A(sources2);
		return (System.Collections.Generic.IReadOnlyList<SourceText>)Enumerable.ToList<SourceText>(Enumerable.Select<ValueTuple<SourceText, int>, SourceText>(Enumerable.Take<ValueTuple<SourceText, int>>((System.Collections.Generic.IEnumerable<ValueTuple<SourceText, int>>)Enumerable.ThenBy<ValueTuple<SourceText, int>, string>(Enumerable.OrderByDescending<ValueTuple<SourceText, int>, int>(Enumerable.Where<ValueTuple<SourceText, int>>(Enumerable.Select<KeyValuePair<string, SourceText>, ValueTuple<SourceText, int>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, SourceText>>)val, (Func<KeyValuePair<string, SourceText>, ValueTuple<SourceText, int>>)((KeyValuePair<string, SourceText> P_0) => new ValueTuple<SourceText, int>(P_0.Value, A(P_0.Key, sources2, index)))), (Func<ValueTuple<SourceText, int>, bool>)((ValueTuple<SourceText, int> x) => x.Item2 >= 3)), (Func<ValueTuple<SourceText, int>, int>)((ValueTuple<SourceText, int> x) => x.Item2)), (Func<ValueTuple<SourceText, int>, string>)((ValueTuple<SourceText, int> x) => x.Item1.Value), (IComparer<string>)(object)StringComparer.Ordinal), 80), (Func<ValueTuple<SourceText, int>, SourceText>)((ValueTuple<SourceText, int> x) => x.Item1)));
	}

	public static System.Collections.Generic.IReadOnlyList<GlossaryEntry> EntriesFor(System.Collections.Generic.IEnumerable<SourceText> terms, Func<string, string?> translationOf)
	{
		ArgumentNullException.ThrowIfNull((object)terms, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BO());
		ArgumentNullException.ThrowIfNull((object)translationOf, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bo());
		List<GlossaryEntry> val = new List<GlossaryEntry>();
		System.Collections.Generic.IEnumerator<SourceText> enumerator = terms.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				SourceText current = enumerator.Current;
				string text = translationOf.Invoke(current.Value)?.Trim();
				if (!string.IsNullOrWhiteSpace(text) && !text.Equals(current.Value.Trim(), (StringComparison)5))
				{
					val.Add(new GlossaryEntry
					{
						Term = current.Value.Trim(),
						Translation = text,
						Kind = GlossaryKind.Item,
						Locked = false
					});
				}
			}
			return (System.Collections.Generic.IReadOnlyList<GlossaryEntry>)val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static System.Collections.Generic.IReadOnlyList<GlossaryEntry> Merge(System.Collections.Generic.IReadOnlyList<GlossaryEntry> owned, System.Collections.Generic.IReadOnlyList<GlossaryEntry> discovered)
	{
		ArgumentNullException.ThrowIfNull((object)owned, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BP());
		ArgumentNullException.ThrowIfNull((object)discovered, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bp());
		List<GlossaryEntry> val = Enumerable.ToList<GlossaryEntry>((System.Collections.Generic.IEnumerable<GlossaryEntry>)owned);
		HashSet<string> val2 = new HashSet<string>(Enumerable.Select<GlossaryEntry, string>((System.Collections.Generic.IEnumerable<GlossaryEntry>)owned, (Func<GlossaryEntry, string>)((GlossaryEntry P_0) => P_0.Term)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)discovered).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlossaryEntry current = enumerator.Current;
				if (val2.Add(current.Term))
				{
					val.Add(current);
				}
			}
			return (System.Collections.Generic.IReadOnlyList<GlossaryEntry>)val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static bool A(string P_0)
	{
		string text = P_0.Trim();
		if (text.Length < 4 || text.Length > 24)
		{
			return false;
		}
		if (text.IndexOfAny(NotInATerm) >= 0)
		{
			return false;
		}
		string[] array = text.Split(' ', (StringSplitOptions)1);
		int num = array.Length;
		if ((num > 2 || num == 0) ? true : false)
		{
			return false;
		}
		if (array.Length == 1 && NotTerminology.Contains(array[0]))
		{
			return false;
		}
		return Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsLetter);
	}

	private static int A(string P_0, System.Collections.Generic.IReadOnlyList<SourceText> P_1, A P_2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Regex val = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BQ() + Regex.Escape(P_0) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BQ(), (RegexOptions)1);
		int num = 0;
		System.Collections.Generic.IEnumerator<int> enumerator = ((System.Collections.Generic.IEnumerable<int>)P_2.A(P_0)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				int current = enumerator.Current;
				SourceText sourceText = P_1[current];
				if (!sourceText.Value.Trim().Equals(P_0, (StringComparison)5) && val.IsMatch(sourceText.Value))
				{
					num++;
				}
			}
			return num;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	static GameGlossary()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bq());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BR());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Br());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BS());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bs());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BT());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bt());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BU());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bu());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BV());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bv());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BW());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bw());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BX());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bx());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BY());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.By());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BZ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bz());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bA());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ba());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bB());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bb());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bC());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bc());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bD());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bd());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bE());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.be());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bF());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bf());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bG());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bg());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bH());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bh());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bI());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bi());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bJ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bj());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bK());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bk());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bL());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bl());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bM());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bm());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bN());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bn());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bO());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bo());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bP());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bp());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bQ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bq());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bR());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.br());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bS());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bs());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bT());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bt());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bU());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bu());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bV());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bv());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bW());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bw());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bX());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bx());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bY());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.by());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bZ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bz());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CA());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ca());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CB());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BY());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cb());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CC());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cc());
		NotTerminology = obj;
		NotInATerm = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CD().ToCharArray();
	}
}
