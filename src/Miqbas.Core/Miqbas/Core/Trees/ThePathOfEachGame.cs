using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Trees;

public static class ThePathOfEachGame
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<AGameCard, string> _003C_003E9__0_0;

		public static Func<IGrouping<string, AGameCard>, string> _003C_003E9__0_1;

		public static Func<IGrouping<string, AGameCard>, string> _003C_003E9__0_2;

		public static Func<KeyValuePair<string, List<TreeNode>>, string> _003C_003E9__0_3;

		public static Func<IGrouping<string, KeyValuePair<string, List<TreeNode>>>, int> _003C_003E9__0_4;

		public static Func<IGrouping<string, KeyValuePair<string, List<TreeNode>>>, string> _003C_003E9__0_5;

		public static Func<KeyValuePair<string, List<TreeNode>>, string> _003C_003E9__0_6;

		internal string A(AGameCard P_0)
		{
			return P_0.Name;
		}

		internal string A(IGrouping<string, AGameCard> P_0)
		{
			return P_0.Key;
		}

		internal string a(IGrouping<string, AGameCard> P_0)
		{
			return Enumerable.First<AGameCard>((System.Collections.Generic.IEnumerable<AGameCard>)P_0).Line;
		}

		internal string A(KeyValuePair<string, List<TreeNode>> P_0)
		{
			List<TreeNode> value = P_0.Value;
			return value[value.Count - 1].Label;
		}

		internal int A(IGrouping<string, KeyValuePair<string, List<TreeNode>>> P_0)
		{
			return Enumerable.Count<KeyValuePair<string, List<TreeNode>>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, List<TreeNode>>>)P_0);
		}

		internal string a(IGrouping<string, KeyValuePair<string, List<TreeNode>>> P_0)
		{
			return P_0.Key;
		}

		internal string a(KeyValuePair<string, List<TreeNode>> P_0)
		{
			return P_0.Key;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public KeyValuePair<string, List<TreeNode>> game;

		internal bool A(string P_0)
		{
			return !string.Equals(P_0, game.Key, (StringComparison)4);
		}
	}

	public static string Write(TreeNode tree, System.DateTime takenAt, int scanned, System.Collections.Generic.IReadOnlyList<AGameCard>? cards = null)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)tree, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Q());
		Dictionary<string, List<TreeNode>> val = new Dictionary<string, List<TreeNode>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		A(tree, new List<TreeNode>(), val);
		Dictionary<string, string> val2 = Enumerable.ToDictionary<IGrouping<string, AGameCard>, string, string>(Enumerable.GroupBy<AGameCard, string>((System.Collections.Generic.IEnumerable<AGameCard>)(cards ?? System.Array.Empty<AGameCard>()), (Func<AGameCard, string>)((AGameCard P_0) => P_0.Name), (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<IGrouping<string, AGameCard>, string>)((IGrouping<string, AGameCard> P_0) => P_0.Key), (Func<IGrouping<string, AGameCard>, string>)((IGrouping<string, AGameCard> P_0) => Enumerable.First<AGameCard>((System.Collections.Generic.IEnumerable<AGameCard>)P_0).Line), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		StringBuilder val3 = new StringBuilder();
		val3.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.q());
		val3.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.R());
		val3.AppendLine();
		StringBuilder val4 = val3;
		StringBuilder obj = val4;
		AppendInterpolatedStringHandler val5 = default(AppendInterpolatedStringHandler);
		((AppendInterpolatedStringHandler)(ref val5))._002Ector(23, 2, val4);
		((AppendInterpolatedStringHandler)(ref val5)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.r());
		((AppendInterpolatedStringHandler)(ref val5)).AppendFormatted<System.DateTime>(takenAt.ToLocalTime(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.S());
		((AppendInterpolatedStringHandler)(ref val5)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.s());
		((AppendInterpolatedStringHandler)(ref val5)).AppendFormatted<int>(scanned);
		((AppendInterpolatedStringHandler)(ref val5)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.T());
		obj.AppendLine(ref val5);
		val3.AppendLine();
		val3.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.t());
		val3.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.U());
		val3.AppendLine();
		System.Collections.Generic.IEnumerator<IGrouping<string, KeyValuePair<string, List<TreeNode>>>> enumerator = ((System.Collections.Generic.IEnumerable<IGrouping<string, KeyValuePair<string, List<TreeNode>>>>)Enumerable.ThenBy<IGrouping<string, KeyValuePair<string, List<TreeNode>>>, string>(Enumerable.OrderByDescending<IGrouping<string, KeyValuePair<string, List<TreeNode>>>, int>(Enumerable.GroupBy<KeyValuePair<string, List<TreeNode>>, string>((System.Collections.Generic.IEnumerable<KeyValuePair<string, List<TreeNode>>>)val, (Func<KeyValuePair<string, List<TreeNode>>, string>)delegate(KeyValuePair<string, List<TreeNode>> P_0)
		{
			List<TreeNode> value2 = P_0.Value;
			return value2[value2.Count - 1].Label;
		}, (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<IGrouping<string, KeyValuePair<string, List<TreeNode>>>, int>)((IGrouping<string, KeyValuePair<string, List<TreeNode>>> P_0) => Enumerable.Count<KeyValuePair<string, List<TreeNode>>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, List<TreeNode>>>)P_0))), (Func<IGrouping<string, KeyValuePair<string, List<TreeNode>>>, string>)((IGrouping<string, KeyValuePair<string, List<TreeNode>>> P_0) => P_0.Key), (IComparer<string>)(object)StringComparer.Ordinal)).GetEnumerator();
		try
		{
			string text = default(string);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IGrouping<string, KeyValuePair<string, List<TreeNode>>> current = enumerator.Current;
				val3.AppendLine();
				val3.AppendLine(new string('═', 76));
				val4 = val3;
				StringBuilder obj2 = val4;
				val5 = new AppendInterpolatedStringHandler(22, 2, val4);
				((AppendInterpolatedStringHandler)(ref val5)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.u());
				((AppendInterpolatedStringHandler)(ref val5)).AppendFormatted(current.Key);
				((AppendInterpolatedStringHandler)(ref val5)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.V());
				((AppendInterpolatedStringHandler)(ref val5)).AppendFormatted<int>(Enumerable.Count<KeyValuePair<string, List<TreeNode>>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, List<TreeNode>>>)current));
				((AppendInterpolatedStringHandler)(ref val5)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.T());
				obj2.AppendLine(ref val5);
				val3.AppendLine(new string('═', 76));
				System.Collections.Generic.IEnumerator<KeyValuePair<string, List<TreeNode>>> enumerator2 = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, List<TreeNode>>>)Enumerable.OrderBy<KeyValuePair<string, List<TreeNode>>, string>((System.Collections.Generic.IEnumerable<KeyValuePair<string, List<TreeNode>>>)current, (Func<KeyValuePair<string, List<TreeNode>>, string>)((KeyValuePair<string, List<TreeNode>> P_0) => P_0.Key), (IComparer<string>)(object)StringComparer.Ordinal)).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						KeyValuePair<string, List<TreeNode>> game = enumerator2.Current;
						List<TreeNode> value = game.Value;
						val3.AppendLine();
						val3.AppendLine((val2.TryGetValue(game.Key, ref text) && text != null && text.Length > 0) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.v() + game.Key + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.s() + text) : (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.v() + game.Key));
						for (int i = 0; i < value.Count; i++)
						{
							string text2 = ((i == 0) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.W() : value[i - 1].Label);
							if (i <= 0 || A(text2))
							{
								string label = value[i].Label;
								val3.AppendLine(A(label) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.w() + a(text2) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.x()) : (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.w() + a(text2) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X() + label));
							}
						}
						string text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Y();
						string label2 = value[value.Count - 1].Label;
						string sub = value[value.Count - 1].Sub;
						val3.AppendLine(text3 + label2 + ((sub != null && sub.Length > 0) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Z() + sub + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z()) : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()));
						List<string> val6 = Enumerable.ToList<string>(Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)(value[value.Count - 1].Games ?? System.Array.Empty<string>()), (Func<string, bool>)((string P_0) => !string.Equals(P_0, game.Key, (StringComparison)4))));
						val3.AppendLine((val6.Count == 0) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aB() : (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aA() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aa(), (System.Collections.Generic.IEnumerable<string>)val6)));
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return ((object)val3).ToString();
	}

	private static bool A(string? P_0)
	{
		if (P_0 != null && P_0.Length > 0)
		{
			return P_0.TrimEnd().EndsWith('؟');
		}
		return false;
	}

	private static string a(string? question)
	{
		string text = (question ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Trim();
		if (text.Length < 46)
		{
			return text + new string(' ', 46 - text.Length) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ab();
		}
		return text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ab();
	}

	private static void A(TreeNode P_0, List<TreeNode> P_1, Dictionary<string, List<TreeNode>> P_2)
	{
		System.Collections.Generic.IEnumerator<TreeNode> enumerator = ((System.Collections.Generic.IEnumerable<TreeNode>)(P_0.Kids ?? System.Array.Empty<TreeNode>())).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				TreeNode current = enumerator.Current;
				List<TreeNode> obj = new List<TreeNode>((System.Collections.Generic.IEnumerable<TreeNode>)P_1);
				obj.Add(current);
				List<TreeNode> val = obj;
				if (((System.Collections.Generic.IReadOnlyCollection<TreeNode>)(current.Kids ?? System.Array.Empty<TreeNode>())).Count == 0)
				{
					System.Collections.Generic.IEnumerator<string> enumerator2 = ((System.Collections.Generic.IEnumerable<string>)(current.Games ?? System.Array.Empty<string>())).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							string current2 = enumerator2.Current;
							P_2.TryAdd(current2, val);
						}
					}
					finally
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
				}
				else
				{
					A(current, val, P_2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
