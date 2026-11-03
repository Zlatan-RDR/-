using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class ARowIsOneSentenceInManyLanguages
{
	[RequiredMember]
	public sealed class WhatTheRowsSaid : IEquatable<WhatTheRowsSaid>
	{
		[CompilerGenerated]
		private System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WhatTheRowsSaid);
			}
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public IReadOnlySet<string> Theirs
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public IReadOnlySet<string> OursInARow
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rr());
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
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rS());
			P_0.Append((object)Theirs);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rs());
			P_0.Append((object)OursInARow);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(WhatTheRowsSaid? left, WhatTheRowsSaid? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(WhatTheRowsSaid? left, WhatTheRowsSaid? right)
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
			return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<IReadOnlySet<string>>.Default.GetHashCode(Theirs)) * -1521134295 + EqualityComparer<IReadOnlySet<string>>.Default.GetHashCode(OursInARow);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as WhatTheRowsSaid);
		}

		[CompilerGenerated]
		public bool Equals(WhatTheRowsSaid? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<IReadOnlySet<string>>.Default.Equals(Theirs, other.Theirs))
				{
					return EqualityComparer<IReadOnlySet<string>>.Default.Equals(OursInARow, other.OursInARow);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		[SetsRequiredMembers]
		private WhatTheRowsSaid(WhatTheRowsSaid P_0)
		{
			Theirs = P_0.Theirs;
			OursInARow = P_0.OursInARow;
		}

		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WhatTheRowsSaid()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<ValueTuple<string, string>, int> _003C_003E9__1_0;

		public static Func<ValueTuple<string, string>, bool> _003C_003E9__1_2;

		internal int A(ValueTuple<string, string> s)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return Indices(s.Item1);
		}

		internal bool a(ValueTuple<string, string> c)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return SourceLanguage.IsTheSourceLanguage(c.Item2);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public int level;

		public Func<ValueTuple<string, string>, string> _003C_003E9__1;

		internal string A(ValueTuple<string, string> s)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return WithoutTheIndexAt(s.Item1, level);
		}
	}

	public static WhatTheRowsSaid Read(System.Collections.Generic.IReadOnlyCollection<ValueTuple<string, string>> strings)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)strings, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ht());
		HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		HashSet<string> val2 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		if (strings.Count >= 2)
		{
			int num = Enumerable.Max<ValueTuple<string, string>>((System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)strings, (Func<ValueTuple<string, string>, int>)((ValueTuple<string, string> s) => Indices(s.Item1)));
			int level;
			for (level = 0; level < num; level++)
			{
				System.Collections.Generic.IEnumerator<IGrouping<string, ValueTuple<string, string>>> enumerator = Enumerable.GroupBy<ValueTuple<string, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)strings, (Func<ValueTuple<string, string>, string>)((ValueTuple<string, string> s) => WithoutTheIndexAt(s.Item1, level)), (IEqualityComparer<string>)(object)StringComparer.Ordinal).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						List<ValueTuple<string, string>> val3 = Enumerable.ToList<ValueTuple<string, string>>((System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)enumerator.Current);
						if (val3.Count < 2)
						{
							continue;
						}
						List<ValueTuple<string, string>> val4 = Enumerable.ToList<ValueTuple<string, string>>(Enumerable.Where<ValueTuple<string, string>>((System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)val3, (Func<ValueTuple<string, string>, bool>)((ValueTuple<string, string> c) => SourceLanguage.IsTheSourceLanguage(c.Item2))));
						if (val4.Count == 0 || val4.Count == val3.Count)
						{
							continue;
						}
						val2.Add(val4[0].Item1);
						Enumerator<ValueTuple<string, string>> enumerator2 = val3.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								ValueTuple<string, string> current = enumerator2.Current;
								if (current.Item1 != val4[0].Item1)
								{
									val.Add(current.Item1);
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
			}
		}
		val2.ExceptWith((System.Collections.Generic.IEnumerable<string>)val);
		return new WhatTheRowsSaid
		{
			Theirs = (IReadOnlySet<string>)(object)val,
			OursInARow = (IReadOnlySet<string>)(object)val2
		};
	}

	public static HashSet<string> WhatTheOtherLanguagesHold(System.Collections.Generic.IReadOnlyCollection<ValueTuple<string, string>> strings)
	{
		HashSet<string> val = new HashSet<string>();
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)Read(strings).Theirs).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				val.Add(current);
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static int Indices(string path)
	{
		ArgumentNullException.ThrowIfNull((object)path, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HU());
		int num = 0;
		for (int i = 0; i < path.Length; i++)
		{
			if (path[i] == '[')
			{
				num++;
			}
		}
		return num;
	}

	public static string WithoutTheIndexAt(string path, int level)
	{
		ArgumentNullException.ThrowIfNull((object)path, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HU());
		int num = -1;
		for (int i = 0; i <= level; i++)
		{
			num = path.IndexOf('[', num + 1);
			if (num < 0)
			{
				return path;
			}
		}
		int num2 = path.IndexOf(']', num);
		if (num2 >= 0)
		{
			string text = path.Substring(0, num + 1);
			int num3 = num2;
			return text + path.Substring(num3, path.Length - num3);
		}
		return path;
	}
}
