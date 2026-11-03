using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

public static class LanguageColumnsAsset
{
	public sealed class Cell : IEquatable<Cell>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Cell);
			}
		}

		[field: CompilerGenerated]
		public int At
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int Length
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public string Value
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public Cell(int At, int Length, string Value)
		{
			this.At = At;
			this.Length = Length;
			this.Value = Value;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hc());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
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
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HN());
			P_0.Append(((object)At).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aQ());
			P_0.Append(((object)Length).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dy());
			P_0.Append((object)Value);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Cell? left, Cell? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(Cell? left, Cell? right)
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
			return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(At)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Length)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Cell);
		}

		[CompilerGenerated]
		public bool Equals(Cell? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(At, other.At) && EqualityComparer<int>.Default.Equals(Length, other.Length))
				{
					return EqualityComparer<string>.Default.Equals(Value, other.Value);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private Cell(Cell P_0)
		{
			At = P_0.At;
			Length = P_0.Length;
			Value = P_0.Value;
		}

		[CompilerGenerated]
		public void Deconstruct(out int At, out int Length, out string Value)
		{
			At = this.At;
			Length = this.Length;
			Value = this.Value;
		}
	}

	public sealed class Table : IEquatable<Table>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Table);
			}
		}

		[field: CompilerGenerated]
		public int Columns
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int English
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>> Rows
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public Table(int Columns, int English, global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>> Rows)
		{
			this.Columns = Columns;
			this.English = English;
			this.Rows = Rows;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hD());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
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
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hd());
			P_0.Append(((object)Columns).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dX());
			P_0.Append(((object)English).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hE());
			P_0.Append((object)Rows);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Table? left, Table? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(Table? left, Table? right)
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
			return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Columns)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(English)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>>>.Default.GetHashCode(Rows);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Table);
		}

		[CompilerGenerated]
		public bool Equals(Table? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Columns, other.Columns) && EqualityComparer<int>.Default.Equals(English, other.English))
				{
					return EqualityComparer<global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>>>.Default.Equals(Rows, other.Rows);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private Table(Table P_0)
		{
			Columns = P_0.Columns;
			English = P_0.English;
			Rows = P_0.Rows;
		}

		[CompilerGenerated]
		public void Deconstruct(out int Columns, out int English, out global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>> Rows)
		{
			Columns = this.Columns;
			English = this.English;
			Rows = this.Rows;
		}
	}

	private enum B
	{
		None,
		Kana,
		Hangul,
		Han,
		Cyrillic,
		Arabic,
		AccentedLatin,
		PlainLatin
	}

	[CompilerGenerated]
	private static class b
	{
		public static Func<char, bool> _003C0_003E__IsLetter;

		public static Func<string, bool> _003C1_003E__LooksLikeLanguage;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class C
	{
		public static readonly C _003C_003E9 = new C();

		public static Func<List<Cell>, bool> _003C_003E9__13_0;

		public static Func<List<Cell>, object> _003C_003E9__13_1;

		public static Func<Cell, bool> _003C_003E9__13_11;

		public static Func<List<Cell>, bool> _003C_003E9__13_4;

		public static Func<List<Cell>, global::System.Collections.Generic.IEnumerable<int>> _003C_003E9__13_5;

		public static Func<ValueTuple<int, int>, int> _003C_003E9__13_7;

		public static Func<ValueTuple<int, int>, int> _003C_003E9__13_8;

		public static Func<B, bool> _003C_003E9__13_14;

		public static Func<B, B> _003C_003E9__13_15;

		public static Func<IGrouping<B, B>, int> _003C_003E9__13_16;

		public static Func<IGrouping<B, B>, B> _003C_003E9__13_17;

		public static Func<Cell, bool> _003C_003E9__13_21;

		public static Func<int, int> _003C_003E9__13_20;

		public static Func<char, bool> _003C_003E9__16_0;

		public static Func<char, bool> _003C_003E9__16_1;

		public static Func<char, bool> _003C_003E9__16_2;

		public static Func<char, bool> _003C_003E9__16_3;

		public static Func<char, bool> _003C_003E9__16_4;

		public static Func<char, bool> _003C_003E9__16_5;

		public static Func<char, bool> _003C_003E9__19_0;

		public static Func<string, bool> _003C_003E9__20_1;

		public static Func<char, bool> _003C_003E9__20_4;

		public static Func<string, bool> _003C_003E9__20_2;

		public static Func<char, bool> _003C_003E9__20_5;

		public static Func<string, bool> _003C_003E9__20_3;

		public static Func<string, bool> _003C_003E9__21_1;

		public static Func<char, bool> _003C_003E9__21_4;

		public static Func<string, bool> _003C_003E9__21_2;

		public static Func<Match, string> _003C_003E9__21_5;

		public static Func<string, global::System.Collections.Generic.IEnumerable<string>> _003C_003E9__21_3;

		public static Func<char, bool> _003C_003E9__22_0;

		internal bool A(List<Cell> P_0)
		{
			return P_0.Count >= 4;
		}

		internal object a(List<Cell> P_0)
		{
			return P_0;
		}

		internal bool A(Cell P_0)
		{
			return P_0.Value.Length == 0;
		}

		internal bool B(List<Cell> P_0)
		{
			return P_0.Count >= 4;
		}

		internal global::System.Collections.Generic.IEnumerable<int> b(List<Cell> P_0)
		{
			return new int[3]
			{
				P_0.Count,
				P_0.Count + 1,
				P_0.Count + 2
			};
		}

		internal int A(ValueTuple<int, int> c)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return c.Item2;
		}

		internal int a(ValueTuple<int, int> c)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return c.Item1;
		}

		internal bool A(B P_0)
		{
			return P_0 != LanguageColumnsAsset.B.None;
		}

		internal B a(B P_0)
		{
			return P_0;
		}

		internal int A(IGrouping<B, B> P_0)
		{
			return Enumerable.Count<B>((global::System.Collections.Generic.IEnumerable<B>)P_0);
		}

		internal B a(IGrouping<B, B> P_0)
		{
			return P_0.Key;
		}

		internal bool a(Cell P_0)
		{
			return P_0.Value.Length == 0;
		}

		internal int A(int P_0)
		{
			return P_0;
		}

		internal bool A(char P_0)
		{
			if (P_0 >= '\u3040')
			{
				return P_0 <= 'ヿ';
			}
			return false;
		}

		internal bool a(char P_0)
		{
			if (P_0 >= '가')
			{
				return P_0 <= '\ud7af';
			}
			return false;
		}

		internal bool B(char P_0)
		{
			if (P_0 >= '一')
			{
				return P_0 <= '鿿';
			}
			return false;
		}

		internal bool b(char P_0)
		{
			if (P_0 >= 'Ѐ')
			{
				return P_0 <= 'ӿ';
			}
			return false;
		}

		internal bool C(char P_0)
		{
			if (P_0 >= '\u0600')
			{
				return P_0 <= 'ۿ';
			}
			return false;
		}

		internal bool c(char P_0)
		{
			if (char.IsLetter(P_0))
			{
				if (P_0 > '\u007f')
				{
					return P_0 <= 'ɏ';
				}
				return false;
			}
			return false;
		}

		internal bool D(char P_0)
		{
			bool flag = char.IsControl(P_0);
			if (flag)
			{
				bool flag2;
				switch (P_0)
				{
				case '\t':
				case '\n':
				case '\r':
					flag2 = true;
					break;
				default:
					flag2 = false;
					break;
				}
				flag = !flag2;
			}
			return flag;
		}

		internal bool A(string P_0)
		{
			return P_0.Length > 0;
		}

		internal bool a(string P_0)
		{
			return Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => char.IsLetter(P_0) && P_0 > 'ɏ'));
		}

		internal bool d(char P_0)
		{
			if (char.IsLetter(P_0))
			{
				return P_0 > 'ɏ';
			}
			return false;
		}

		internal bool B(string P_0)
		{
			return Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => char.IsLetter(P_0) && P_0 > '\u007f' && P_0 <= 'ɏ'));
		}

		internal bool E(char P_0)
		{
			if (char.IsLetter(P_0))
			{
				if (P_0 > '\u007f')
				{
					return P_0 <= 'ɏ';
				}
				return false;
			}
			return false;
		}

		internal bool b(string P_0)
		{
			return P_0.Length > 0;
		}

		internal bool C(string P_0)
		{
			return Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 <= '\u007f'));
		}

		internal bool e(char P_0)
		{
			return P_0 <= '\u007f';
		}

		internal global::System.Collections.Generic.IEnumerable<string> c(string P_0)
		{
			return Enumerable.Select<Match, string>((global::System.Collections.Generic.IEnumerable<Match>)AWord.Matches(P_0), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value));
		}

		internal string A(Match P_0)
		{
			return ((Capture)P_0).Value;
		}

		internal bool F(char P_0)
		{
			return !char.IsUpper(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public byte[] package;

		public Dictionary<List<Cell>, int> startOf;

		public Dictionary<object, int> emptiesBefore;

		public List<List<Cell>> runs;

		public int columns;

		public List<List<Cell>> plain;

		public B[] scriptOf;

		internal int A(List<Cell> P_0)
		{
			return LanguageColumnsAsset.A(package, P_0[0].At, startOf[P_0]);
		}

		internal int A(List<Cell> P_0, int P_1)
		{
			if (P_0.Count != P_1)
			{
				if (P_0.Count >= P_1 || P_0.Count + emptiesBefore[(object)P_0] < P_1)
				{
					if (P_0.Count <= P_1 || !Enumerable.All<Cell>(Enumerable.Skip<Cell>((global::System.Collections.Generic.IEnumerable<Cell>)P_0, P_1), (Func<Cell, bool>)((Cell P_0) => P_0.Value.Length == 0)))
					{
						return -2147483648;
					}
					return P_1 - P_0.Count;
				}
				return P_1 - P_0.Count;
			}
			return 0;
		}

		internal ValueTuple<int, int> A(int P_0)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			D CS_0024_003C_003E8__locals0 = new D
			{
				CS_0024_003C_003E8__locals1 = this,
				width = P_0
			};
			return new ValueTuple<int, int>(CS_0024_003C_003E8__locals0.width, Enumerable.Count<List<Cell>>((global::System.Collections.Generic.IEnumerable<List<Cell>>)runs, (Func<List<Cell>, bool>)((List<Cell> P_0) => CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.A(P_0, CS_0024_003C_003E8__locals0.width) != -2147483648)));
		}

		internal bool a(List<Cell> P_0)
		{
			if (P_0.Count == columns)
			{
				return emptiesBefore[(object)P_0] == 0;
			}
			return false;
		}

		internal B a(int P_0)
		{
			d CS_0024_003C_003E8__locals0 = new d
			{
				c = P_0
			};
			return Enumerable.FirstOrDefault<B>(Enumerable.Select<IGrouping<B, B>, B>((global::System.Collections.Generic.IEnumerable<IGrouping<B, B>>)Enumerable.OrderByDescending<IGrouping<B, B>, int>(Enumerable.GroupBy<B, B>(Enumerable.Where<B>(Enumerable.Select<List<Cell>, B>((global::System.Collections.Generic.IEnumerable<List<Cell>>)plain, (Func<List<Cell>, B>)((List<Cell> P_0) => LanguageColumnsAsset.a(P_0[CS_0024_003C_003E8__locals0.c].Value))), (Func<B, bool>)((B P_0) => P_0 != LanguageColumnsAsset.B.None)), (Func<B, B>)((B P_0) => P_0)), (Func<IGrouping<B, B>, int>)((IGrouping<B, B> P_0) => Enumerable.Count<B>((global::System.Collections.Generic.IEnumerable<B>)P_0))), (Func<IGrouping<B, B>, B>)((IGrouping<B, B> P_0) => P_0.Key)));
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public int width;

		public c CS_0024_003C_003E8__locals1;

		internal bool A(List<Cell> P_0)
		{
			return CS_0024_003C_003E8__locals1.A(P_0, width) != -2147483648;
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public int c;

		internal B A(List<Cell> P_0)
		{
			return a(P_0[c].Value);
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public List<Cell> run;

		public c CS_0024_003C_003E8__locals2;

		internal bool A(int P_0)
		{
			if (run.Count + P_0 >= CS_0024_003C_003E8__locals2.columns)
			{
				return Enumerable.All<Cell>(Enumerable.Skip<Cell>((global::System.Collections.Generic.IEnumerable<Cell>)run, CS_0024_003C_003E8__locals2.columns - P_0), (Func<Cell, bool>)((Cell P_0) => P_0.Value.Length == 0));
			}
			return false;
		}

		internal int a(int P_0)
		{
			e CS_0024_003C_003E8__locals0 = new e
			{
				CS_0024_003C_003E8__locals3 = this,
				before = P_0
			};
			return Enumerable.Count<int>(Enumerable.Range(0, CS_0024_003C_003E8__locals2.columns), (Func<int, bool>)delegate(int P_0)
			{
				if (P_0 >= CS_0024_003C_003E8__locals0.before)
				{
					B b = LanguageColumnsAsset.a(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.run[P_0 - CS_0024_003C_003E8__locals0.before].Value);
					if (b != 0)
					{
						return b == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.scriptOf[P_0];
					}
				}
				return false;
			});
		}
	}

	[CompilerGenerated]
	private sealed class e
	{
		public int before;

		public E CS_0024_003C_003E8__locals3;

		internal bool A(int P_0)
		{
			if (P_0 >= before)
			{
				B b = a(CS_0024_003C_003E8__locals3.run[P_0 - before].Value);
				if (b != 0)
				{
					return b == CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2.scriptOf[P_0];
				}
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class F
	{
		public int column;

		internal string A(global::System.Collections.Generic.IReadOnlyList<Cell> P_0)
		{
			return P_0[column].Value;
		}
	}

	[CompilerGenerated]
	private sealed class f
	{
		public int column;

		internal string A(global::System.Collections.Generic.IReadOnlyList<Cell> P_0)
		{
			return P_0[column].Value;
		}
	}

	public const string KeyPrefix = "ucols#";

	private const int FewestColumns = 4;

	private const int FewestRows = 3;

	private const int LongestCell = 8192;

	private static readonly HashSet<string> EnglishWords;

	private static readonly Regex AWord;

	public static string KeyOf(string chunk, string english)
	{
		IFormatProvider invariantCulture = (IFormatProvider)(object)CultureInfo.InvariantCulture;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(1, 3, invariantCulture);
		defaultInterpolatedStringHandler.AppendFormatted(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dC());
		defaultInterpolatedStringHandler.AppendFormatted(chunk);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p());
		defaultInterpolatedStringHandler.AppendFormatted<ulong>(A(english), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dc());
		return string.Create(invariantCulture, ref defaultInterpolatedStringHandler);
	}

	public static bool IsLanguageColumnsKey(string key)
	{
		return key.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dC(), (StringComparison)4);
	}

	public static string? ChunkOf(string key)
	{
		if (!IsLanguageColumnsKey(key))
		{
			return null;
		}
		int length = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dC().Length;
		string text = key.Substring(length, key.Length - length);
		int num = text.LastIndexOf('#');
		if (num <= 0)
		{
			return null;
		}
		return text.Substring(0, num);
	}

	private static ulong A(string P_0)
	{
		ulong num = 14695981039346656037uL;
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		foreach (byte b in bytes)
		{
			num = (num ^ b) * 1099511628211L;
		}
		return num;
	}

	public static string ChunkName(IoStoreChunk chunk)
	{
		IFormatProvider invariantCulture = (IFormatProvider)(object)CultureInfo.InvariantCulture;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(0, 3, invariantCulture);
		defaultInterpolatedStringHandler.AppendFormatted<ulong>(chunk.Id, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dc());
		defaultInterpolatedStringHandler.AppendFormatted<ushort>(chunk.Index, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dD());
		defaultInterpolatedStringHandler.AppendFormatted<byte>(chunk.Type, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dd());
		return string.Create(invariantCulture, ref defaultInterpolatedStringHandler);
	}

	public static Table? Read(byte[] package)
	{
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		byte[] package2 = package;
		ArgumentNullException.ThrowIfNull((object)package2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		ZenPackage.Layout layout = ZenPackage.Read(global::System.ReadOnlySpan<byte>.op_Implicit(package2));
		if ((object)layout == null)
		{
			return null;
		}
		List<List<Cell>> runs = new List<List<Cell>>();
		Dictionary<List<Cell>, int> startOf = new Dictionary<List<Cell>, int>((IEqualityComparer<List<Cell>>)(object)ReferenceEqualityComparer.Instance);
		global::System.Collections.Generic.IEnumerator<ZenPackage.Export> enumerator = ((global::System.Collections.Generic.IEnumerable<ZenPackage.Export>)layout.Exports).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ZenPackage.Export current = enumerator.Current;
				List<Cell> val = null;
				int num = current.DataAt;
				int num2 = current.DataAt + (int)current.Size;
				while (num + 4 <= num2)
				{
					if (A(package2, num, num2, val != null, out Cell cell))
					{
						if (val == null)
						{
							val = new List<Cell>();
							runs.Add(val);
							startOf[val] = current.DataAt;
						}
						val.Add(cell);
						num += cell.Length;
					}
					else
					{
						val = null;
						num++;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (Enumerable.Count<List<Cell>>((global::System.Collections.Generic.IEnumerable<List<Cell>>)runs, (Func<List<Cell>, bool>)((List<Cell> P_0) => P_0.Count >= 4)) < 3)
		{
			return null;
		}
		Dictionary<object, int> emptiesBefore = Enumerable.ToDictionary<List<Cell>, object, int>((global::System.Collections.Generic.IEnumerable<List<Cell>>)runs, (Func<List<Cell>, object>)((List<Cell> P_0) => P_0), (Func<List<Cell>, int>)((List<Cell> P_0) => A(package2, P_0[0].At, startOf[P_0])), (IEqualityComparer<object>)(object)ReferenceEqualityComparer.Instance);
		c CS_0024_003C_003E8__locals0;
		int columns = Enumerable.First<ValueTuple<int, int>>((global::System.Collections.Generic.IEnumerable<ValueTuple<int, int>>)Enumerable.ThenBy<ValueTuple<int, int>, int>(Enumerable.OrderByDescending<ValueTuple<int, int>, int>(Enumerable.Select<int, ValueTuple<int, int>>(Enumerable.Distinct<int>(Enumerable.SelectMany<List<Cell>, int>(Enumerable.Where<List<Cell>>((global::System.Collections.Generic.IEnumerable<List<Cell>>)runs, (Func<List<Cell>, bool>)((List<Cell> P_0) => P_0.Count >= 4)), (Func<List<Cell>, global::System.Collections.Generic.IEnumerable<int>>)((List<Cell> P_0) => new int[3]
		{
			P_0.Count,
			P_0.Count + 1,
			P_0.Count + 2
		}))), (Func<int, ValueTuple<int, int>>)((int P_0) => new ValueTuple<int, int>(P_0, Enumerable.Count<List<Cell>>((global::System.Collections.Generic.IEnumerable<List<Cell>>)runs, (Func<List<Cell>, bool>)((List<Cell> P_0) => CS_0024_003C_003E8__locals0.A(P_0, P_0) != -2147483648))))), (Func<ValueTuple<int, int>, int>)((ValueTuple<int, int> c) => c.Item2)), (Func<ValueTuple<int, int>, int>)((ValueTuple<int, int> c) => c.Item1))).Item1;
		List<List<Cell>> plain = Enumerable.ToList<List<Cell>>(Enumerable.Where<List<Cell>>((global::System.Collections.Generic.IEnumerable<List<Cell>>)runs, (Func<List<Cell>, bool>)((List<Cell> P_0) => P_0.Count == columns && emptiesBefore[(object)P_0] == 0)));
		B[] scriptOf = Enumerable.ToArray<B>(Enumerable.Select<int, B>(Enumerable.Range(0, columns), (Func<int, B>)((int P_0) => Enumerable.FirstOrDefault<B>(Enumerable.Select<IGrouping<B, B>, B>((global::System.Collections.Generic.IEnumerable<IGrouping<B, B>>)Enumerable.OrderByDescending<IGrouping<B, B>, int>(Enumerable.GroupBy<B, B>(Enumerable.Where<B>(Enumerable.Select<List<Cell>, B>((global::System.Collections.Generic.IEnumerable<List<Cell>>)plain, (Func<List<Cell>, B>)((List<Cell> P_0) => a(P_0[P_0].Value))), (Func<B, bool>)((B P_0) => P_0 != LanguageColumnsAsset.B.None)), (Func<B, B>)((B P_0) => P_0)), (Func<IGrouping<B, B>, int>)((IGrouping<B, B> P_0) => Enumerable.Count<B>((global::System.Collections.Generic.IEnumerable<B>)P_0))), (Func<IGrouping<B, B>, B>)((IGrouping<B, B> P_0) => P_0.Key))))));
		List<global::System.Collections.Generic.IReadOnlyList<Cell>> val2 = new List<global::System.Collections.Generic.IReadOnlyList<Cell>>();
		Enumerator<List<Cell>> enumerator2 = runs.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				List<Cell> run = enumerator2.Current;
				if (CS_0024_003C_003E8__locals0.A(run, columns) == -2147483648)
				{
					continue;
				}
				int num3 = Enumerable.First<int>((global::System.Collections.Generic.IEnumerable<int>)Enumerable.ThenBy<int, int>(Enumerable.OrderByDescending<int, int>((global::System.Collections.Generic.IEnumerable<int>)Enumerable.ToList<int>(Enumerable.Where<int>(Enumerable.Range(0, emptiesBefore[(object)run] + 1), (Func<int, bool>)((int P_0) => run.Count + P_0 >= columns && Enumerable.All<Cell>(Enumerable.Skip<Cell>((global::System.Collections.Generic.IEnumerable<Cell>)run, columns - P_0), (Func<Cell, bool>)((Cell P_0) => P_0.Value.Length == 0))))), (Func<int, int>)((int P_0) => Enumerable.Count<int>(Enumerable.Range(0, columns), (Func<int, bool>)delegate(int P_0)
				{
					if (P_0 >= P_0)
					{
						B b = a(run[P_0 - P_0].Value);
						if (b != 0)
						{
							return b == scriptOf[P_0];
						}
					}
					return false;
				}))), (Func<int, int>)((int P_0) => P_0)));
				int num4 = run.Count + num3 - columns;
				if (num4 > 0)
				{
					run.RemoveRange(run.Count - num4, num4);
				}
				int num5 = run[0].At;
				for (int i = 0; i < num3; i++)
				{
					num5 -= 4;
					run.Insert(0, new Cell(num5, 4, string.Empty));
				}
				val2.Add((global::System.Collections.Generic.IReadOnlyList<Cell>)run);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator2).Dispose();
		}
		if (val2.Count < 3 || !A((global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>>)val2, columns))
		{
			return null;
		}
		int num6 = a((global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>>)val2, columns);
		if (num6 >= 0)
		{
			return new Table(columns, num6, (global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>>)val2);
		}
		return null;
	}

	public static byte[]? WithEnglish(byte[] package, IReadOnlyDictionary<string, string> arabicByEnglish)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)arabicByEnglish, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dE());
		Table table = Read(package);
		if ((object)table == null)
		{
			return null;
		}
		List<ValueTuple<int, int, byte[]>> val = new List<ValueTuple<int, int, byte[]>>();
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IReadOnlyList<Cell>> enumerator = ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<Cell>>)table.Rows).GetEnumerator();
		try
		{
			string text = default(string);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Cell cell = enumerator.Current[table.English];
				if (cell.Value.Length > 0 && arabicByEnglish.TryGetValue(cell.Value, ref text) && !string.IsNullOrEmpty(text))
				{
					val.Add(new ValueTuple<int, int, byte[]>(cell.At, cell.Length, B(text)));
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count != 0)
		{
			return ZenPackage.Splice(package, (global::System.Collections.Generic.IReadOnlyList<ValueTuple<int, int, byte[]>>)val);
		}
		return null;
	}

	private static B a(string P_0)
	{
		if (P_0.Length != 0 && Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsLetter))
		{
			if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= '\u3040' && P_0 <= 'ヿ')))
			{
				if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= '가' && P_0 <= '\ud7af')))
				{
					if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= '一' && P_0 <= '鿿')))
					{
						if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= 'Ѐ' && P_0 <= 'ӿ')))
						{
							if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= '\u0600' && P_0 <= 'ۿ')))
							{
								if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => char.IsLetter(P_0) && P_0 > '\u007f' && P_0 <= 'ɏ')))
								{
									return LanguageColumnsAsset.B.PlainLatin;
								}
								return LanguageColumnsAsset.B.AccentedLatin;
							}
							return LanguageColumnsAsset.B.Arabic;
						}
						return LanguageColumnsAsset.B.Cyrillic;
					}
					return LanguageColumnsAsset.B.Han;
				}
				return LanguageColumnsAsset.B.Hangul;
			}
			return LanguageColumnsAsset.B.Kana;
		}
		return LanguageColumnsAsset.B.None;
	}

	private static int A(byte[] P_0, int P_1, int P_2)
	{
		int num = 0;
		while (num < 2 && P_1 - 4 >= P_2 && BitConverter.ToInt32(P_0, P_1 - 4) == 0)
		{
			num++;
			P_1 -= 4;
		}
		return num;
	}

	private static byte[] B(string P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				global::A.C.A(val2, P_0);
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
			return val.ToArray();
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static bool A(byte[] P_0, int P_1, int P_2, bool P_3, out Cell P_4)
	{
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		P_4 = null;
		int num = BitConverter.ToInt32(P_0, P_1);
		if (num == 0)
		{
			if (!P_3)
			{
				return false;
			}
			P_4 = new Cell(P_1, 4, string.Empty);
			return true;
		}
		if (num > 1 && num <= 8192 && P_1 + 4 + num <= P_2)
		{
			global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(P_0, P_1 + 4, num);
			if (span[span.Length - 1] != 0)
			{
				return false;
			}
			ref global::System.Span<byte> reference = ref span;
			global::System.Span<byte> span2 = reference.Slice(0, reference.Length - 1);
			for (int i = 0; i < span2.Length; i++)
			{
				byte b = span2[i];
				bool flag = ((b < 32 || b > 126) ? true : false);
				bool flag2 = flag;
				if (flag2)
				{
					bool flag3 = (((uint)(b - 9) <= 1u || b == 13) ? true : false);
					flag2 = !flag3;
				}
				if (flag2)
				{
					return false;
				}
			}
			Encoding aSCII = Encoding.ASCII;
			reference = ref span;
			string @string = aSCII.GetString(global::System.Span<byte>.op_Implicit(reference.Slice(0, reference.Length - 1)));
			if (!P_3 && !Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)@string, (Func<char, bool>)char.IsLetter))
			{
				return false;
			}
			P_4 = new Cell(P_1, 4 + num, @string);
			return true;
		}
		if (num < -1 && num >= -8192 && P_1 + 4 + -2L * (long)num <= P_2)
		{
			int num2 = -num;
			global::System.Span<byte> span3 = MemoryExtensions.AsSpan<byte>(P_0, P_1 + 4, 2 * num2);
			if (span3[span3.Length - 1] == 0)
			{
				if (span3[span3.Length - 2] == 0)
				{
					string string2;
					try
					{
						UnicodeEncoding val = new UnicodeEncoding(false, false, true);
						ref global::System.Span<byte> reference = ref span3;
						string2 = ((Encoding)val).GetString(global::System.Span<byte>.op_Implicit(reference.Slice(0, reference.Length - 2)));
					}
					catch (ArgumentException)
					{
						return false;
					}
					if ((!P_3 && !Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)string2, (Func<char, bool>)char.IsLetter)) || Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)string2, (Func<char, bool>)delegate(char P_0)
					{
						bool flag4 = char.IsControl(P_0);
						if (flag4)
						{
							bool flag5;
							switch (P_0)
							{
							case '\t':
							case '\n':
							case '\r':
								flag5 = true;
								break;
							default:
								flag5 = false;
								break;
							}
							flag4 = !flag5;
						}
						return flag4;
					}))
					{
						return false;
					}
					P_4 = new Cell(P_1, 4 + 2 * num2, string2);
					return true;
				}
			}
			return false;
		}
		return false;
	}

	private static bool A(global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>> P_0, int P_1)
	{
		int num = 0;
		int column;
		for (column = 0; column < P_1; column++)
		{
			List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>(Enumerable.Select<global::System.Collections.Generic.IReadOnlyList<Cell>, string>((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<Cell>>)P_0, (Func<global::System.Collections.Generic.IReadOnlyList<Cell>, string>)((global::System.Collections.Generic.IReadOnlyList<Cell> P_0) => P_0[column].Value)), (Func<string, bool>)((string P_0) => P_0.Length > 0)));
			if (val.Count == 0)
			{
				continue;
			}
			double num2 = (double)Enumerable.Count<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => char.IsLetter(P_0) && P_0 > 'ɏ')))) / (double)val.Count;
			double num3 = (double)Enumerable.Count<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => char.IsLetter(P_0) && P_0 > '\u007f' && P_0 <= 'ɏ')))) / (double)val.Count;
			if (num2 >= 0.5 || num3 >= 0.2)
			{
				num++;
			}
		}
		return num >= 2;
	}

	private static int a(global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<Cell>> P_0, int P_1)
	{
		int result = -1;
		double num = 0.0;
		int column;
		for (column = 0; column < P_1; column++)
		{
			List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>(Enumerable.Select<global::System.Collections.Generic.IReadOnlyList<Cell>, string>((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<Cell>>)P_0, (Func<global::System.Collections.Generic.IReadOnlyList<Cell>, string>)((global::System.Collections.Generic.IReadOnlyList<Cell> P_0) => P_0[column].Value)), (Func<string, bool>)((string P_0) => P_0.Length > 0)));
			if (val.Count < 3 || (double)Enumerable.Count<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 <= '\u007f')))) / (double)val.Count < 0.9)
			{
				continue;
			}
			double num2 = (double)val.Count / (double)((global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.IReadOnlyList<Cell>>)P_0).Count;
			double num3 = (double)Enumerable.Count<string>(Enumerable.Distinct<string>((global::System.Collections.Generic.IEnumerable<string>)val, (IEqualityComparer<string>)(object)StringComparer.Ordinal)) / (double)val.Count;
			double num4 = (double)Enumerable.Count<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)b) / (double)val.Count;
			List<string> val2 = Enumerable.ToList<string>(Enumerable.SelectMany<string, string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, global::System.Collections.Generic.IEnumerable<string>>)((string P_0) => Enumerable.Select<Match, string>((global::System.Collections.Generic.IEnumerable<Match>)AWord.Matches(P_0), (Func<Match, string>)((Match P_0) => ((Capture)P_0).Value)))));
			double num5;
			if (val2.Count != 0)
			{
				HashSet<string> englishWords = EnglishWords;
				num5 = (double)Enumerable.Count<string>((global::System.Collections.Generic.IEnumerable<string>)val2, (Func<string, bool>)englishWords.Contains) / (double)val2.Count;
			}
			else
			{
				num5 = 0.0;
			}
			double num6 = num5;
			double num7 = num2 * num3 * num4 * (1.0 + 4.0 * num6);
			if (num7 > num)
			{
				num = num7;
				result = column;
			}
		}
		if (!(num >= 0.3))
		{
			return -1;
		}
		return result;
	}

	private static bool b(string P_0)
	{
		if (!P_0.Contains('_'))
		{
			if (!P_0.Trim().Contains(' '))
			{
				if (P_0.Length > 1 && char.IsUpper(P_0[0]))
				{
					return Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)P_0.Substring(1, P_0.Length - 1), (Func<char, bool>)((char P_0) => !char.IsUpper(P_0)));
				}
				return false;
			}
			return true;
		}
		return false;
	}

	static LanguageColumnsAsset()
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.de());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dF());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.df());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dG());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dg());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dH());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dh());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dI());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.di());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dJ());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dj());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dK());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dk());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dL());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dl());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dM());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dm());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dN());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dn());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dO());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.@do());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dP());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dp());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dQ());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dq());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dR());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dr());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dS());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ds());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dT());
		EnglishWords = obj;
		AWord = new Regex(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dt(), (RegexOptions)512);
	}
}
