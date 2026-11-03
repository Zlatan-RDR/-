using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Baseline;

public static class LibraryComparison
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<GameBaseline, string> _003C_003E9__0_0;

		public static Func<IGrouping<string, GameBaseline>, string> _003C_003E9__0_1;

		public static Func<IGrouping<string, GameBaseline>, GameBaseline> _003C_003E9__0_2;

		public static Func<GameBaseline, string> _003C_003E9__0_3;

		public static Func<IGrouping<string, GameBaseline>, string> _003C_003E9__0_4;

		public static Func<IGrouping<string, GameBaseline>, GameBaseline> _003C_003E9__0_5;

		public static Func<GameChange, bool> _003C_003E9__0_6;

		public static Func<GameChange, ChangeKind> _003C_003E9__0_7;

		public static Func<GameChange, string> _003C_003E9__0_8;

		public static Func<GameChange, bool> _003C_003E9__1_0;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__4_1;

		internal string A(GameBaseline P_0)
		{
			return LibraryComparison.A(P_0.Path);
		}

		internal string A(IGrouping<string, GameBaseline> P_0)
		{
			return P_0.Key;
		}

		internal GameBaseline a(IGrouping<string, GameBaseline> P_0)
		{
			return Enumerable.First<GameBaseline>((System.Collections.Generic.IEnumerable<GameBaseline>)P_0);
		}

		internal string a(GameBaseline P_0)
		{
			return LibraryComparison.A(P_0.Path);
		}

		internal string B(IGrouping<string, GameBaseline> P_0)
		{
			return P_0.Key;
		}

		internal GameBaseline b(IGrouping<string, GameBaseline> P_0)
		{
			return Enumerable.First<GameBaseline>((System.Collections.Generic.IEnumerable<GameBaseline>)P_0);
		}

		internal bool A(GameChange P_0)
		{
			if (P_0.Blocks)
			{
				return !P_0.Approved;
			}
			return false;
		}

		internal ChangeKind a(GameChange P_0)
		{
			return P_0.Kind;
		}

		internal string B(GameChange P_0)
		{
			return P_0.Name;
		}

		internal bool b(GameChange P_0)
		{
			if (P_0.Blocks)
			{
				return !P_0.Approved;
			}
			return false;
		}

		internal string A(KeyValuePair<string, string> P_0)
		{
			return P_0.Key;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public GameBaseline is_;

		public bool approved;

		internal GameChange A(ChangeKind P_0, bool P_1, string P_2)
		{
			return new GameChange(is_.Name, is_.Path, P_0, P_1, approved && P_1, P_2);
		}

		internal bool A(KeyValuePair<string, int> P_0)
		{
			int num = default(int);
			return (is_.SentencesByFile.TryGetValue(P_0.Key, ref num) ? num : 0) < P_0.Value;
		}

		internal string a(KeyValuePair<string, int> P_0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Key);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_0.Value);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SL());
			int num = default(int);
			defaultInterpolatedStringHandler.AppendFormatted<int>(is_.SentencesByFile.TryGetValue(P_0.Key, ref num) ? num : 0);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public GameBaseline is_;

		internal bool A(KeyValuePair<string, string> P_0)
		{
			string text = default(string);
			if (is_.FileStamps.TryGetValue(P_0.Key, ref text))
			{
				return !string.Equals(text, P_0.Value, (StringComparison)4);
			}
			return false;
		}
	}

	public static System.Collections.Generic.IReadOnlyList<GameChange> Compare(System.Collections.Generic.IReadOnlyList<GameBaseline> before, System.Collections.Generic.IReadOnlyList<GameBaseline> after, IReadOnlySet<string>? approvedPaths = null)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)before, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qN());
		ArgumentNullException.ThrowIfNull((object)after, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qn());
		if (approvedPaths == null)
		{
			approvedPaths = (IReadOnlySet<string>?)(object)new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		}
		Dictionary<string, GameBaseline> val = Enumerable.ToDictionary<IGrouping<string, GameBaseline>, string, GameBaseline>(Enumerable.GroupBy<GameBaseline, string>((System.Collections.Generic.IEnumerable<GameBaseline>)before, (Func<GameBaseline, string>)((GameBaseline P_0) => A(P_0.Path))), (Func<IGrouping<string, GameBaseline>, string>)((IGrouping<string, GameBaseline> P_0) => P_0.Key), (Func<IGrouping<string, GameBaseline>, GameBaseline>)((IGrouping<string, GameBaseline> P_0) => Enumerable.First<GameBaseline>((System.Collections.Generic.IEnumerable<GameBaseline>)P_0)));
		Dictionary<string, GameBaseline> val2 = Enumerable.ToDictionary<IGrouping<string, GameBaseline>, string, GameBaseline>(Enumerable.GroupBy<GameBaseline, string>((System.Collections.Generic.IEnumerable<GameBaseline>)after, (Func<GameBaseline, string>)((GameBaseline P_0) => A(P_0.Path))), (Func<IGrouping<string, GameBaseline>, string>)((IGrouping<string, GameBaseline> P_0) => P_0.Key), (Func<IGrouping<string, GameBaseline>, GameBaseline>)((IGrouping<string, GameBaseline> P_0) => Enumerable.First<GameBaseline>((System.Collections.Generic.IEnumerable<GameBaseline>)P_0)));
		List<GameChange> val3 = new List<GameChange>();
		Enumerator<string, GameBaseline> enumerator = val.GetEnumerator();
		string text = default(string);
		GameBaseline gameBaseline = default(GameBaseline);
		try
		{
			GameBaseline gameBaseline3 = default(GameBaseline);
			while (enumerator.MoveNext())
			{
				enumerator.Current.Deconstruct(ref text, ref gameBaseline);
				string text2 = text;
				GameBaseline gameBaseline2 = gameBaseline;
				if (!val2.TryGetValue(text2, ref gameBaseline3))
				{
					val3.Add(new GameChange(gameBaseline2.Name, gameBaseline2.Path, ChangeKind.GameGone, Blocks: false, Approved: false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qO()));
					continue;
				}
				bool flag = approvedPaths.Contains(text2) || approvedPaths.Contains(A(gameBaseline2.Name)) || approvedPaths.Contains(A(gameBaseline3.Name));
				GameChange gameChange = A(gameBaseline2, gameBaseline3, flag);
				if (gameChange.Blocks && !A(gameBaseline2, gameBaseline3))
				{
					List<string> val4 = a(gameBaseline2, gameBaseline3);
					if (val4 != null && val4.Count > 0)
					{
						GameChange gameChange2 = gameChange._003CClone_003E_0024();
						gameChange2.Kind = ChangeKind.FilesChanged;
						gameChange2.Blocks = false;
						gameChange2.Approved = false;
						string[] obj = new string[5]
						{
							EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qo(),
							string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DT(), Enumerable.Take<string>((System.Collections.Generic.IEnumerable<string>)val4, 3)),
							null,
							null,
							null
						};
						string text3;
						if (val4.Count <= 3)
						{
							text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
						}
						else
						{
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(9, 1);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qP());
							defaultInterpolatedStringHandler.AppendFormatted<int>(val4.Count - 3);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JW());
							text3 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						obj[2] = text3;
						obj[3] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qp();
						obj[4] = gameChange.Detail;
						gameChange2.Detail = string.Concat(obj);
						gameChange = gameChange2;
					}
				}
				val3.Add(gameChange);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.Deconstruct(ref text, ref gameBaseline);
				string text4 = text;
				GameBaseline gameBaseline4 = gameBaseline;
				if (!val.ContainsKey(text4))
				{
					val3.Add(new GameChange(gameBaseline4.Name, gameBaseline4.Path, ChangeKind.NewGame, Blocks: false, Approved: false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qQ()));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		List<GameChange> obj2 = new List<GameChange>();
		obj2.AddRange((System.Collections.Generic.IEnumerable<GameChange>)Enumerable.ThenBy<GameChange, string>(Enumerable.ThenBy<GameChange, ChangeKind>(Enumerable.OrderByDescending<GameChange, bool>((System.Collections.Generic.IEnumerable<GameChange>)val3, (Func<GameChange, bool>)((GameChange P_0) => P_0.Blocks && !P_0.Approved)), (Func<GameChange, ChangeKind>)((GameChange P_0) => P_0.Kind)), (Func<GameChange, string>)((GameChange P_0) => P_0.Name), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		return new k<GameChange>(obj2);
	}

	public static bool StopsTheBuild(System.Collections.Generic.IEnumerable<GameChange> changes)
	{
		return Enumerable.Any<GameChange>(changes, (Func<GameChange, bool>)((GameChange P_0) => P_0.Blocks && !P_0.Approved));
	}

	private static GameChange A(GameBaseline P_0, GameBaseline P_1, bool P_2)
	{
		a CS_0024_003C_003E8__locals0 = new a();
		CS_0024_003C_003E8__locals0.is_ = P_1;
		CS_0024_003C_003E8__locals0.approved = P_2;
		if (CS_0024_003C_003E8__locals0.is_.SetAside != null || P_0.SetAside != null)
		{
			return CS_0024_003C_003E8__locals0.A(ChangeKind.CouldNotMeasure, false, CS_0024_003C_003E8__locals0.is_.SetAside ?? P_0.SetAside);
		}
		if (P_0.Failure != null || CS_0024_003C_003E8__locals0.is_.Failure != null)
		{
			if (P_0.Failure != null && CS_0024_003C_003E8__locals0.is_.Failure != null)
			{
				return CS_0024_003C_003E8__locals0.A(ChangeKind.CouldNotMeasure, false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qq() + CS_0024_003C_003E8__locals0.is_.Failure);
			}
			if (P_0.Failure != null)
			{
				return CS_0024_003C_003E8__locals0.A(ChangeKind.NowMeasures, false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qR() + P_0.Failure);
			}
			return CS_0024_003C_003E8__locals0.A(ChangeKind.NowFails, true, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qr() + CS_0024_003C_003E8__locals0.is_.Failure);
		}
		if (!string.Equals(P_0.Fingerprint ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y(), CS_0024_003C_003E8__locals0.is_.Fingerprint ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y(), (StringComparison)4) && (!string.IsNullOrEmpty(P_0.Fingerprint) || !string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.is_.Fingerprint)))
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(70, 4);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qS());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Road ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qs());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals0.is_.Road ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qs());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DT());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qT());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Sentences?.ToString() ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qs());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals0.is_.Sentences?.ToString() ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qs());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
			return CS_0024_003C_003E8__locals0.A(ChangeKind.GameUpdated, false, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (!string.Equals(P_0.Engine, CS_0024_003C_003E8__locals0.is_.Engine, (StringComparison)4))
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qt());
			defaultInterpolatedStringHandler.AppendFormatted(P_0.Engine ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qU());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals0.is_.Engine ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qU());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
			return CS_0024_003C_003E8__locals0.A(ChangeKind.EngineChanged, true, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (P_0.FullAvailable && !CS_0024_003C_003E8__locals0.is_.FullAvailable)
		{
			return CS_0024_003C_003E8__locals0.A(ChangeKind.Closed, true, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qu() + CS_0024_003C_003E8__locals0.is_.FullUnavailableReason);
		}
		if (!P_0.FullAvailable && CS_0024_003C_003E8__locals0.is_.FullAvailable)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(40, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qV());
			defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals0.is_.Road);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DT());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(CS_0024_003C_003E8__locals0.is_.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qv());
			return CS_0024_003C_003E8__locals0.A(ChangeKind.Opened, false, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (!P_0.FullAvailable)
		{
			return CS_0024_003C_003E8__locals0.A(ChangeKind.Same, false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
		}
		if (!string.Equals(P_0.Road, CS_0024_003C_003E8__locals0.is_.Road, (StringComparison)4) || P_0.FaceIsAdded != CS_0024_003C_003E8__locals0.is_.FaceIsAdded)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(25, 4);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qW());
			defaultInterpolatedStringHandler.AppendFormatted(A(P_0));
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted(A(CS_0024_003C_003E8__locals0.is_));
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qw());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(P_0.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(CS_0024_003C_003E8__locals0.is_.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
			return CS_0024_003C_003E8__locals0.A(ChangeKind.RoadChanged, true, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		bool? arabicCanBeDrawn = P_0.ArabicCanBeDrawn;
		if (arabicCanBeDrawn.HasValue && arabicCanBeDrawn.GetValueOrDefault() && ((!CS_0024_003C_003E8__locals0.is_.ArabicCanBeDrawn) ?? true))
		{
			return CS_0024_003C_003E8__locals0.A(ChangeKind.DrawsNoMore, true, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qX() + (((!CS_0024_003C_003E8__locals0.is_.ArabicCanBeDrawn) ?? false) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qY() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qx()) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QE() + CS_0024_003C_003E8__locals0.is_.ArabicWillNotDrawBecause);
		}
		int num2 = default(int);
		List<string> val = Enumerable.ToList<string>(Enumerable.Select<KeyValuePair<string, int>, string>(Enumerable.Where<KeyValuePair<string, int>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, int>>)P_0.SentencesByFile, (Func<KeyValuePair<string, int>, bool>)((KeyValuePair<string, int> P_0) => (CS_0024_003C_003E8__locals0.is_.SentencesByFile.TryGetValue(P_0.Key, ref num2) ? num2 : 0) < P_0.Value)), (Func<KeyValuePair<string, int>, string>)delegate(KeyValuePair<string, int> P_0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler2.AppendFormatted(P_0.Key);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
			defaultInterpolatedStringHandler2.AppendFormatted<int>(P_0.Value);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SL());
			int num = default(int);
			defaultInterpolatedStringHandler2.AppendFormatted<int>(CS_0024_003C_003E8__locals0.is_.SentencesByFile.TryGetValue(P_0.Key, ref num) ? num : 0);
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}));
		if (CS_0024_003C_003E8__locals0.is_.Sentences.GetValueOrDefault() < P_0.Sentences.GetValueOrDefault() || val.Count > 0)
		{
			string text4;
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (val.Count != 0)
			{
				string text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qy();
				string text2 = string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DT(), Enumerable.Take<string>((System.Collections.Generic.IEnumerable<string>)val, 5));
				string text3;
				if (val.Count <= 5)
				{
					text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
				}
				else
				{
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qP());
					defaultInterpolatedStringHandler.AppendFormatted<int>(val.Count - 5);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qZ());
					text3 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				text4 = text + text2 + text3 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB();
			}
			else
			{
				text4 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
			}
			string text5 = text4;
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(11, 3);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qT());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(P_0.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(CS_0024_003C_003E8__locals0.is_.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			return CS_0024_003C_003E8__locals0.A(ChangeKind.TextShrank, true, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (((!P_0.ArabicCanBeDrawn) ?? true) && (CS_0024_003C_003E8__locals0.is_.ArabicCanBeDrawn ?? false))
		{
			return CS_0024_003C_003E8__locals0.A(ChangeKind.DrawsNow, false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qz());
		}
		if (CS_0024_003C_003E8__locals0.is_.Sentences.GetValueOrDefault() > P_0.Sentences.GetValueOrDefault())
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(30, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qT());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(P_0.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GV());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(CS_0024_003C_003E8__locals0.is_.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RA());
			return CS_0024_003C_003E8__locals0.A(ChangeKind.TextGrew, false, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (!string.Equals(P_0.SentencesHash, CS_0024_003C_003E8__locals0.is_.SentencesHash, (StringComparison)4))
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(45, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ra());
			defaultInterpolatedStringHandler.AppendFormatted<int?>(CS_0024_003C_003E8__locals0.is_.Sentences);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RB());
			return CS_0024_003C_003E8__locals0.A(ChangeKind.TextChanged, false, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return CS_0024_003C_003E8__locals0.A(ChangeKind.Same, false, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
	}

	private static bool A(GameBaseline P_0, GameBaseline P_1)
	{
		string road = P_0.Road;
		if (road != null && road.Length > 0)
		{
			string road2 = P_1.Road;
			if (road2 != null && road2.Length > 0)
			{
				return !string.Equals(road.Split('+', (StringSplitOptions)0)[0].Trim(), road2.Split('+', (StringSplitOptions)0)[0].Trim(), (StringComparison)4);
			}
		}
		return false;
	}

	private static List<string> a(GameBaseline P_0, GameBaseline P_1)
	{
		GameBaseline is_ = P_1;
		List<string> obj = new List<string>();
		string text = default(string);
		obj.AddRange(Enumerable.Select<KeyValuePair<string, string>, string>(Enumerable.Where<KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)P_0.FileStamps, (Func<KeyValuePair<string, string>, bool>)((KeyValuePair<string, string> P_0) => is_.FileStamps.TryGetValue(P_0.Key, ref text) && !string.Equals(text, P_0.Value, (StringComparison)4))), (Func<KeyValuePair<string, string>, string>)((KeyValuePair<string, string> P_0) => P_0.Key)));
		return obj;
	}

	private static string A(GameBaseline P_0)
	{
		string? obj = P_0.Road ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qs();
		bool? faceIsAdded = P_0.FaceIsAdded;
		string text = ((!faceIsAdded.HasValue) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y() : ((!faceIsAdded.GetValueOrDefault()) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RC() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rb()));
		return obj + text;
	}

	private static string A(string P_0)
	{
		return P_0.Replace('\\', '/').TrimEnd('/').ToLowerInvariant();
	}
}
