using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Booting;

public static class ArabicTheGameCouldNotDraw
{
	public sealed class Confession : IEquatable<Confession>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A _003C_003E9 = new A();

			public static Func<int, string> _003C_003E9__18_0;

			internal string A(int P_0)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rq());
				defaultInterpolatedStringHandler.AppendFormatted<int>(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rR());
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		[CompilerGenerated]
		private System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Confession);
			}
		}

		[field: CompilerGenerated]
		public int Lines
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public System.Collections.Generic.IReadOnlyList<int> Characters
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public string? Font
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public bool IsBoxes => ((System.Collections.Generic.IReadOnlyCollection<int>)Characters).Count >= 10;

		public string FirstFew => string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X(), Enumerable.Select<int, string>(Enumerable.Take<int>((System.Collections.Generic.IEnumerable<int>)Characters, 6), (Func<int, string>)delegate(int P_0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rq());
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rR());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		})) + ((((System.Collections.Generic.IReadOnlyCollection<int>)Characters).Count > 6) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SJ() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());

		public Confession(int Lines, System.Collections.Generic.IReadOnlyList<int> Characters, string? Font)
		{
			this.Lines = Lines;
			this.Characters = Characters;
			this.Font = Font;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sj());
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
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hc());
			P_0.Append(((object)Lines).ToString());
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FP());
			P_0.Append((object)Characters);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pU());
			P_0.Append((object)Font);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SK());
			P_0.Append(((object)IsBoxes).ToString());
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sk());
			P_0.Append((object)FirstFew);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(Confession? left, Confession? right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(Confession? left, Confession? right)
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
			return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Lines)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(Characters)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Font);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as Confession);
		}

		[CompilerGenerated]
		public bool Equals(Confession? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Lines, other.Lines) && EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(Characters, other.Characters))
				{
					return EqualityComparer<string>.Default.Equals(Font, other.Font);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		private Confession(Confession P_0)
		{
			Lines = P_0.Lines;
			Characters = P_0.Characters;
			Font = P_0.Font;
		}

		[CompilerGenerated]
		public void Deconstruct(out int Lines, out System.Collections.Generic.IReadOnlyList<int> Characters, out string? Font)
		{
			Lines = this.Lines;
			Characters = this.Characters;
			Font = this.Font;
		}
	}

	public const int ManyEnoughToBeBoxes = 10;

	[GeneratedRegex(/*Could not decode attribute arguments.*/)]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex A()
	{
		return (Regex)(object)global::A.A.Instance;
	}

	public static Confession? In(string? logText)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(logText))
		{
			return null;
		}
		int num = 0;
		SortedSet<int> val = new SortedSet<int>();
		string text = null;
		foreach (Match item in A().Matches(logText))
		{
			Match val2 = item;
			int num2 = (val2.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.C()].Success ? int.Parse(((Capture)val2.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.C()]).Value, (NumberStyles)515, (IFormatProvider)(object)CultureInfo.InvariantCulture) : int.Parse(((Capture)val2.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.B()]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture));
			if (!A(num2))
			{
				continue;
			}
			num++;
			val.Add(num2);
			if (text != null)
			{
				continue;
			}
			Group val3 = val2.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.b()];
			object obj;
			if (val3 != null && val3.Success)
			{
				string value = ((Capture)val3).Value;
				if (value != null && value.Length > 0)
				{
					obj = ((Capture)val3).Value;
					goto IL_00f2;
				}
			}
			obj = null;
			goto IL_00f2;
			IL_00f2:
			text = (string)obj;
		}
		if (num == 0)
		{
			return null;
		}
		int lines = num;
		int num3 = 0;
		int[] array = new int[val.Count];
		Enumerator<int> enumerator2 = val.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				int current = enumerator2.Current;
				array[num3] = current;
				num3++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		return new Confession(lines, new K<int>(array), text);
	}

	private static bool A(int P_0)
	{
		if (P_0 >= 64336)
		{
			if (P_0 >= 65136)
			{
				if (P_0 <= 65279)
				{
					goto IL_0058;
				}
			}
			else if (P_0 <= 65023)
			{
				goto IL_0058;
			}
		}
		else if (P_0 >= 1872)
		{
			if (P_0 >= 2208)
			{
				if (P_0 <= 2303)
				{
					goto IL_0058;
				}
			}
			else if (P_0 <= 1919)
			{
				goto IL_0058;
			}
		}
		else if (P_0 >= 1536 && P_0 <= 1791)
		{
			goto IL_0058;
		}
		return false;
		IL_0058:
		return true;
	}
}
