using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Translation;

public static class CodesTheGameWrites
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<Match, string> _003C_003E9__4_0;

		public static Func<string, bool> _003C_003E9__4_1;

		public static Func<Match, string> _003C_003E9__4_2;

		public static Func<Match, string> _003C_003E9__4_3;

		public static Func<Match, string> _003C_003E9__4_4;

		public static Func<KeyValuePair<string, int>, bool> _003C_003E9__4_5;

		public static Func<KeyValuePair<string, int>, string> _003C_003E9__4_6;

		public static Func<ValueTuple<int, HashSet<string>>, bool> _003C_003E9__4_7;

		public static Func<ValueTuple<int, HashSet<string>>, System.Collections.Generic.IEnumerable<string>> _003C_003E9__4_8;

		public static Func<KeyValuePair<string, int>, bool> _003C_003E9__4_9;

		public static Func<KeyValuePair<string, int>, string> _003C_003E9__4_10;

		internal string A(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal bool A(string P_0)
		{
			return Enumerable.Count<char>(Enumerable.Distinct<char>((System.Collections.Generic.IEnumerable<char>)P_0)) >= 2;
		}

		internal string a(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal string B(Match P_0)
		{
			return ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bc()]).Value;
		}

		internal string b(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal bool A(KeyValuePair<string, int> P_0)
		{
			return P_0.Value >= 5;
		}

		internal string a(KeyValuePair<string, int> P_0)
		{
			return P_0.Key;
		}

		internal bool A(ValueTuple<int, HashSet<string>> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return f.Item1 >= 5;
		}

		internal System.Collections.Generic.IEnumerable<string> a(ValueTuple<int, HashSet<string>> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return (System.Collections.Generic.IEnumerable<string>)f.Item2;
		}

		internal bool B(KeyValuePair<string, int> P_0)
		{
			return P_0.Value >= 5;
		}

		internal string b(KeyValuePair<string, int> P_0)
		{
			return P_0.Key;
		}
	}

	public const int AtLeastLines = 5;

	private static readonly Regex Candidate = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aX(), (RegexOptions)512);

	private static readonly Regex SymbolRun = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ax(), (RegexOptions)512);

	private static readonly Regex HashCode = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aY(), (RegexOptions)512);

	public static System.Collections.Generic.IReadOnlyList<string> In(System.Collections.Generic.IEnumerable<string> lines)
	{
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, int> val = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Dictionary<string, ValueTuple<int, HashSet<string>>> val2 = new Dictionary<string, ValueTuple<int, HashSet<string>>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Dictionary<string, int> val3 = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<string> enumerator = lines.GetEnumerator();
		try
		{
			ValueTuple<int, HashSet<string>> val4 = default(ValueTuple<int, HashSet<string>>);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				System.Collections.Generic.IEnumerator<string> enumerator2 = Enumerable.Distinct<string>(Enumerable.Where<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)SymbolRun.Matches(current), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (Func<string, bool>)((string P_0) => Enumerable.Count<char>(Enumerable.Distinct<char>((System.Collections.Generic.IEnumerable<char>)P_0)) >= 2)), (IEqualityComparer<string>)(object)StringComparer.Ordinal).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						string current2 = enumerator2.Current;
						val3[current2] = CollectionExtensions.GetValueOrDefault<string, int>((IReadOnlyDictionary<string, int>)(object)val3, current2) + 1;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
				enumerator2 = Enumerable.Distinct<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)Candidate.Matches(current), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						string current3 = enumerator2.Current;
						val[current3] = CollectionExtensions.GetValueOrDefault<string, int>((IReadOnlyDictionary<string, int>)(object)val, current3) + 1;
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
				System.Collections.Generic.IEnumerator<IGrouping<string, Match>> enumerator3 = Enumerable.GroupBy<Match, string>((System.Collections.Generic.IEnumerable<Match>)HashCode.Matches(current), (Func<Match, string>)((Match P_0) => ((Capture)P_0.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bc()]).Value), (IEqualityComparer<string>)(object)StringComparer.Ordinal).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator3).MoveNext())
					{
						IGrouping<string, Match> current4 = enumerator3.Current;
						if (!val2.TryGetValue(current4.Key, ref val4))
						{
							val4 = (val2[current4.Key] = new ValueTuple<int, HashSet<string>>(0, new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal)));
						}
						val4.Item2.UnionWith(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)current4, (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)));
						val2[current4.Key] = new ValueTuple<int, HashSet<string>>(val4.Item1 + 1, val4.Item2);
					}
				}
				finally
				{
					((System.IDisposable)enumerator3)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		List<string> obj = new List<string>();
		obj.AddRange((System.Collections.Generic.IEnumerable<string>)Enumerable.Order<string>(Enumerable.Concat<string>(Enumerable.Concat<string>(Enumerable.Select<KeyValuePair<string, int>, string>(Enumerable.Where<KeyValuePair<string, int>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, int>>)val, (Func<KeyValuePair<string, int>, bool>)((KeyValuePair<string, int> P_0) => P_0.Value >= 5)), (Func<KeyValuePair<string, int>, string>)((KeyValuePair<string, int> P_0) => P_0.Key)), Enumerable.SelectMany<ValueTuple<int, HashSet<string>>, string>(Enumerable.Where<ValueTuple<int, HashSet<string>>>((System.Collections.Generic.IEnumerable<ValueTuple<int, HashSet<string>>>)val2.Values, (Func<ValueTuple<int, HashSet<string>>, bool>)((ValueTuple<int, HashSet<string>> f) => f.Item1 >= 5)), (Func<ValueTuple<int, HashSet<string>>, System.Collections.Generic.IEnumerable<string>>)((ValueTuple<int, HashSet<string>> f) => (System.Collections.Generic.IEnumerable<string>)f.Item2))), Enumerable.Select<KeyValuePair<string, int>, string>(Enumerable.Where<KeyValuePair<string, int>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, int>>)val3, (Func<KeyValuePair<string, int>, bool>)((KeyValuePair<string, int> P_0) => P_0.Value >= 5)), (Func<KeyValuePair<string, int>, string>)((KeyValuePair<string, int> P_0) => P_0.Key))), (IComparer<string>)(object)StringComparer.Ordinal));
		return new k<string>(obj);
	}
}
