using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Engines;

[RequiredMember]
public sealed class GameTechnology : IEquatable<GameTechnology>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, bool> _003C_003E9__19_0;

		public static Func<string, bool> _003C_003E9__19_1;

		public static Func<string, bool> _003C_003E9__19_2;

		public static Func<string, string> _003C_003E9__19_4;

		public static Func<string, bool> _003C_003E9__19_5;

		public static Func<string, string> _003C_003E9__19_6;

		internal bool A(string P_0)
		{
			return P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW(), (StringComparison)4);
		}

		internal bool a(string P_0)
		{
			return P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW(), (StringComparison)4);
		}

		internal bool B(string P_0)
		{
			return P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Si(), (StringComparison)4);
		}

		internal string b(string P_0)
		{
			int length = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Si().Length;
			return P_0.Substring(length, P_0.Length - length).Replace('_', ' ');
		}

		internal bool C(string P_0)
		{
			if (!P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Si(), (StringComparison)4))
			{
				return !P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW(), (StringComparison)4);
			}
			return false;
		}

		internal string c(string P_0)
		{
			return P_0;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string gameRoot;

		internal string A(string P_0)
		{
			return Path.GetRelativePath(gameRoot, P_0).Replace('\\', '/');
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public IReadOnlyDictionary<string, int> matches;

		internal int A(string P_0)
		{
			return matches[P_0];
		}
	}

	public const int MostFilesWorthNaming = 60000;

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(GameTechnology);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Engines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>> AntiCheats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Others
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public static GameTechnology Nothing
	{
		[CompilerGenerated]
		get;
	} = new GameTechnology
	{
		Engines = System.Array.Empty<string>(),
		AntiCheats = (IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>>)(object)new Dictionary<string, System.Collections.Generic.IReadOnlyList<string>>(),
		Others = System.Array.Empty<string>()
	};


	public static GameTechnology Of(string gameRoot, int mostFiles = 60000)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		string gameRoot2 = gameRoot;
		if (!Directory.Exists(gameRoot2))
		{
			return Nothing;
		}
		List<string> relativePaths;
		try
		{
			relativePaths = Enumerable.ToList<string>(Enumerable.Select<string, string>(Enumerable.Take<string>(Directory.EnumerateFiles(gameRoot2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), new EnumerationOptions
			{
				RecurseSubdirectories = true,
				IgnoreInaccessible = true,
				AttributesToSkip = (FileAttributes)1024
			}), mostFiles), (Func<string, string>)((string P_0) => Path.GetRelativePath(gameRoot2, P_0).Replace('\\', '/'))));
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return Nothing;
		}
		return Of((System.Collections.Generic.IReadOnlyList<string>)relativePaths);
	}

	public static GameTechnology Of(System.Collections.Generic.IReadOnlyList<string> relativePaths)
	{
		FileNameRules steamDb = FileNameRules.SteamDb;
		IReadOnlyDictionary<string, int> matches = steamDb.Match(relativePaths);
		Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> val = new Dictionary<string, System.Collections.Generic.IReadOnlyList<string>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		if (Enumerable.Any<string>(matches.Keys, (Func<string, bool>)((string P_0) => P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW(), (StringComparison)4))))
		{
			System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)relativePaths).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					System.Collections.Generic.IEnumerator<string> enumerator2 = Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)steamDb.RulesMatching(current), (Func<string, bool>)((string P_0) => P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW(), (StringComparison)4))).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							string current2 = enumerator2.Current;
							int length = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW().Length;
							string text = current2.Substring(length, current2.Length - length);
							Dictionary<string, System.Collections.Generic.IReadOnlyList<string>> val2 = val;
							current2 = text;
							System.Collections.Generic.IReadOnlyList<string> readOnlyList = CollectionExtensions.GetValueOrDefault<string, System.Collections.Generic.IReadOnlyList<string>>((IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>>)(object)val, text) ?? System.Array.Empty<string>();
							length = 0;
							string[] array = new string[1 + ((System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count];
							System.Collections.Generic.IEnumerator<string> enumerator3 = ((System.Collections.Generic.IEnumerable<string>)readOnlyList).GetEnumerator();
							try
							{
								while (((System.Collections.IEnumerator)enumerator3).MoveNext())
								{
									string current3 = enumerator3.Current;
									array[length] = current3;
									length++;
								}
							}
							finally
							{
								((System.IDisposable)enumerator3)?.Dispose();
							}
							array[length] = current;
							length++;
							val2[current2] = new K<string>(array);
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
		}
		return new GameTechnology
		{
			Engines = (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderByDescending<string, int>(Enumerable.Where<string>(matches.Keys, (Func<string, bool>)((string P_0) => P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Si(), (StringComparison)4))), (Func<string, int>)((string P_0) => matches[P_0])), (Func<string, string>)delegate(string P_0)
			{
				int length2 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Si().Length;
				return P_0.Substring(length2, P_0.Length - length2).Replace('_', ' ');
			})),
			AntiCheats = (IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>>)(object)val,
			Others = (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Where<string>(matches.Keys, (Func<string, bool>)((string P_0) => !P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Si(), (StringComparison)4) && !P_0.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW(), (StringComparison)4))), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.Ordinal))
		};
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nw());
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.o());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nX());
		P_0.Append((object)Engines);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nx());
		P_0.Append((object)AntiCheats);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nY());
		P_0.Append((object)Others);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GameTechnology? left, GameTechnology? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GameTechnology? left, GameTechnology? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Engines)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>>>.Default.GetHashCode(AntiCheats)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Others);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as GameTechnology);
	}

	[CompilerGenerated]
	public bool Equals(GameTechnology? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Engines, other.Engines) && EqualityComparer<IReadOnlyDictionary<string, System.Collections.Generic.IReadOnlyList<string>>>.Default.Equals(AntiCheats, other.AntiCheats))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Others, other.Others);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private GameTechnology(GameTechnology P_0)
	{
		Engines = P_0.Engines;
		AntiCheats = P_0.AntiCheats;
		Others = P_0.Others;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public GameTechnology()
	{
	}
}
