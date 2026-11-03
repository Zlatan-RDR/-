using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Engines;

public sealed class FileNameRules
{
	private sealed class A : IEquatable<A>
	{
		[CompilerGenerated]
		private System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(A);
			}
		}

		[field: CompilerGenerated]
		public string Id
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public Regex Pattern
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public A(string P_0, Regex P_1)
		{
			Id = P_0;
			Pattern = P_1;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SG());
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
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CL());
			P_0.Append((object)Id);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sg());
			P_0.Append((object)Pattern);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(A? P_0, A? P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(A? P_0, A? P_1)
		{
			if ((object)P_0 != P_1)
			{
				return P_0?.Equals(P_1) ?? false;
			}
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<Regex>.Default.GetHashCode(Pattern);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as A);
		}

		[CompilerGenerated]
		public bool Equals(A? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other.Id))
				{
					return EqualityComparer<Regex>.Default.Equals(Pattern, other.Pattern);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		public A A()
		{
			return new A(this);
		}

		[CompilerGenerated]
		private A(A P_0)
		{
			Id = P_0.Id;
			Pattern = P_0.Pattern;
		}

		[CompilerGenerated]
		public void A(out string P_0, out Regex P_1)
		{
			P_0 = Id;
			P_1 = Pattern;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<List<A>, int> _003C_003E9__10_0;

		public static Func<KeyValuePair<string, int>, bool> _003C_003E9__20_0;

		public static Func<KeyValuePair<string, int>, string> _003C_003E9__20_1;

		public static Func<KeyValuePair<string, int>, int> _003C_003E9__20_2;

		public static Func<string, bool> _003C_003E9__25_0;

		internal int A(List<A> P_0)
		{
			return P_0.Count;
		}

		internal bool A(KeyValuePair<string, int> P_0)
		{
			return !P_0.Key.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SH(), (StringComparison)4);
		}

		internal string a(KeyValuePair<string, int> P_0)
		{
			return P_0.Key;
		}

		internal int B(KeyValuePair<string, int> P_0)
		{
			return P_0.Value;
		}

		internal bool A(string P_0)
		{
			return Path.GetFileName(P_0).Equals(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sh(), (StringComparison)5);
		}

		internal FileNameRules A()
		{
			return Parse(FileNameRules.A());
		}

		internal FileNameRules a()
		{
			return Parse(FileNameRules.A(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SI());
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public Dictionary<string, int> matches;

		internal bool A(string P_0)
		{
			return matches.ContainsKey(P_0);
		}

		internal int A(string[] P_0)
		{
			return Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)P_0, (Func<string, bool>)((string P_0) => matches.ContainsKey(P_0)));
		}
	}

	[CompilerGenerated]
	private sealed class b : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private List<A> rules;

		public List<A> _003C_003E3__rules;

		private string path;

		public string _003C_003E3__path;

		private Enumerator<A> _003C_003E7__wrap1;

		string System.Collections.Generic.IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public b(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = rules.GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (_003C_003E7__wrap1.MoveNext())
				{
					A current = _003C_003E7__wrap1.Current;
					bool flag;
					try
					{
						flag = current.Pattern.IsMatch(path);
					}
					catch (RegexMatchTimeoutException)
					{
						continue;
					}
					if (flag)
					{
						_003C_003E2__current = current.Id;
						_003C_003E1__state = 1;
						return true;
					}
				}
				a();
				_003C_003E7__wrap1 = default(Enumerator<A>);
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			((System.IDisposable)_003C_003E7__wrap1).Dispose();
		}

		[DebuggerHidden]
		private void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<string> b()
		{
			b b;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				b = this;
			}
			else
			{
				b = new b(0);
			}
			b.rules = _003C_003E3__rules;
			b.path = _003C_003E3__path;
			return b;
		}

		System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator C()
		{
			return (System.Collections.IEnumerator)b();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}
	}

	private const string AnyExtension = "";

	private static readonly Lazy<FileNameRules> TheSteamDbRules = new Lazy<FileNameRules>((Func<FileNameRules>)(() => Parse(A())));

	private static readonly Lazy<FileNameRules> TheSteamDbAntiCheats = new Lazy<FileNameRules>((Func<FileNameRules>)(() => Parse(A(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SI())));

	private readonly Dictionary<string, List<A>> _byExtension;

	private static readonly Regex SimpleExtension = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nv(), (RegexOptions)512);

	public static FileNameRules SteamDb => TheSteamDbRules.Value;

	public static FileNameRules SteamDbAntiCheats => TheSteamDbAntiCheats.Value;

	public int Count => Enumerable.Sum<List<A>>((System.Collections.Generic.IEnumerable<List<A>>)_byExtension.Values, (Func<List<A>, int>)((List<A> P_0) => P_0.Count));

	[field: CompilerGenerated]
	public int Skipped
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private init;
	}

	private FileNameRules(Dictionary<string, List<A>> P_0)
	{
		_byExtension = P_0;
	}

	public static FileNameRules Parse(string ini, string? onlySection = null)
	{
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		Dictionary<string, List<A>> val = new Dictionary<string, List<A>>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		string text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		int num = 0;
		string[] array = ini.Split('\n', (StringSplitOptions)0);
		List<A> val3 = default(List<A>);
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i].Trim();
			if (text2.Length == 0 || text2[0] == ';')
			{
				continue;
			}
			string text3;
			if (text2[0] == '[')
			{
				if (text2[text2.Length - 1] == ']')
				{
					text3 = text2;
					text = text3.Substring(1, text3.Length - 1 - 1);
					continue;
				}
			}
			int num2 = text2.IndexOf(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DQ(), (StringComparison)4);
			if (num2 <= 0 || text.Length == 0 || (onlySection != null && text != onlySection))
			{
				continue;
			}
			string text4 = text2.Substring(0, num2).Trim();
			if (text4.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nt(), (StringComparison)4))
			{
				text3 = text4;
				text4 = text3.Substring(0, text3.Length - 2);
			}
			text3 = text2;
			int num3 = num2 + 3;
			string text5 = text3.Substring(num3, text3.Length - num3);
			int num4 = text5.IndexOf(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NU(), (StringComparison)4);
			if (num4 >= 0)
			{
				text5 = text5.Substring(0, num4);
			}
			text5 = A(text5.Trim());
			A a;
			try
			{
				a = new A(text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB() + text4, new Regex(text5, (RegexOptions)513, TimeSpan.FromSeconds(1.0)));
			}
			catch (ArgumentException)
			{
				num++;
				continue;
			}
			System.Collections.Generic.IEnumerator<string> enumerator = FileNameRules.a(text5).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					if (!val.TryGetValue(current, ref val3))
					{
						val3 = (val[current] = new List<A>());
					}
					val3.Add(a);
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		return new FileNameRules(val)
		{
			Skipped = num
		};
	}

	private static string A(string P_0)
	{
		return P_0.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nu(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NV(), (StringComparison)4).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nv(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NW(), (StringComparison)4).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nw(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (StringComparison)4)
			.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NX(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nx(), (StringComparison)4);
	}

	private static System.Collections.Generic.IEnumerable<string> a(string P_0)
	{
		Match val = SimpleExtension.Match(P_0);
		if (!((Group)val).Success)
		{
			return new L<string>(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
		}
		if (!val.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NY()].Success)
		{
			return new string[1] { ((Capture)val.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ny()]).Value };
		}
		return ((Capture)val.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NY()]).Value.Split('|', (StringSplitOptions)0);
	}

	public IReadOnlyDictionary<string, int> Match(System.Collections.Generic.IReadOnlyList<string> relativePaths)
	{
		Dictionary<string, int> val = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)relativePaths).GetEnumerator();
		try
		{
			List<A> val2 = default(List<A>);
			List<A> val3 = default(List<A>);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string text = Path.GetExtension(current).TrimStart('.');
				if (text.Length > 0 && _byExtension.TryGetValue(text, ref val2))
				{
					A(val2, current, val);
				}
				if (_byExtension.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y(), ref val3))
				{
					A(val3, current, val);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count > 0)
		{
			string text2 = A(relativePaths, val);
			if (text2 != null)
			{
				val[text2] = 1;
			}
		}
		return (IReadOnlyDictionary<string, int>)(object)Enumerable.ToDictionary<KeyValuePair<string, int>, string, int>(Enumerable.Where<KeyValuePair<string, int>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, int>>)val, (Func<KeyValuePair<string, int>, bool>)((KeyValuePair<string, int> P_0) => !P_0.Key.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SH(), (StringComparison)4))), (Func<KeyValuePair<string, int>, string>)((KeyValuePair<string, int> P_0) => P_0.Key), (Func<KeyValuePair<string, int>, int>)((KeyValuePair<string, int> P_0) => P_0.Value), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
	}

	private static void A(List<A> P_0, string P_1, Dictionary<string, int> P_2)
	{
		System.Collections.Generic.IEnumerator<string> enumerator = A(P_0, P_1).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				P_2[current] = CollectionExtensions.GetValueOrDefault<string, int>((IReadOnlyDictionary<string, int>)(object)P_2, current) + 1;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	[IteratorStateMachine(typeof(b))]
	private static System.Collections.Generic.IEnumerable<string> A(List<A> P_0, string P_1)
	{
		Enumerator<A> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				bool flag;
				try
				{
					flag = current.Pattern.IsMatch(P_1);
				}
				catch (RegexMatchTimeoutException)
				{
					continue;
				}
				if (flag)
				{
					yield return current.Id;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public System.Collections.Generic.IReadOnlyList<string> RulesMatching(string relativePath)
	{
		string text = Path.GetExtension(relativePath).TrimStart('.');
		List<A> val = default(List<A>);
		System.Collections.Generic.IEnumerable<string> enumerable2;
		if (text.Length <= 0 || !_byExtension.TryGetValue(text, ref val))
		{
			System.Collections.Generic.IEnumerable<string> enumerable = System.Array.Empty<string>();
			enumerable2 = enumerable;
		}
		else
		{
			enumerable2 = A(val, relativePath);
		}
		List<A> val2 = default(List<A>);
		System.Collections.Generic.IEnumerable<string> enumerable3;
		if (!_byExtension.TryGetValue(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y(), ref val2))
		{
			System.Collections.Generic.IEnumerable<string> enumerable = System.Array.Empty<string>();
			enumerable3 = enumerable;
		}
		else
		{
			enumerable3 = A(val2, relativePath);
		}
		System.Collections.Generic.IEnumerable<string> enumerable4 = enumerable3;
		return (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Concat<string>(enumerable2, enumerable4), (IEqualityComparer<string>)(object)StringComparer.Ordinal));
	}

	private static string? A(System.Collections.Generic.IReadOnlyList<string> P_0, Dictionary<string, int> P_1)
	{
		B b = new B();
		b.matches = P_1;
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NZ()) && b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nz()))
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nA();
		}
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.na()) && b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nB()))
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nb();
		}
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nC()) && !b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nc()))
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nD();
		}
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nd()))
		{
			if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nE()))
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ne();
			}
			if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nF()) || (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nf()) && b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nG())))
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ng();
			}
		}
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nH()) && !b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nd()))
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nh();
		}
		if (b.A(new string[2]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nI(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ni()
		}) > 1)
		{
			if (!b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nJ()) && !b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nj()))
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nK();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nk();
		}
		if (b.A(new string[3]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nL(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nl(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nM()
		}) > 1)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nm();
		}
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nN()) && b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nn()))
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nO();
		}
		if (b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.no()) && A(P_0))
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nP();
		}
		if (!b.A(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.np()))
		{
			return null;
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ng();
	}

	private static bool A(System.Collections.Generic.IReadOnlyList<string> P_0)
	{
		List<string> val = new List<string>();
		HashSet<string> val2 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		string[] array = new string[4]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nQ(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nq(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nR(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nr()
		};
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)P_0).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string text = Path.GetExtension(current).TrimStart('.');
				if (text.Equals(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nS(), (StringComparison)5))
				{
					val.Add(current);
				}
				else if (text.Length == 0)
				{
					val2.Add(current.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ns(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nT(), (StringComparison)5) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nt());
				}
				else if (Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)array, text, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))
				{
					string text2 = current;
					int length = text.Length;
					val2.Add(text2.Substring(0, text2.Length - length) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nU());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count > 0)
		{
			if (!Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)val2.Contains))
			{
				return Enumerable.All<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => Path.GetFileName(P_0).Equals(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sh(), (StringComparison)5)));
			}
			return true;
		}
		return false;
	}

	private static string A()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		Stream val = Assembly.GetExecutingAssembly().GetManifestResourceStream(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nu()) ?? throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nV());
		try
		{
			StreamReader val2 = new StreamReader(val);
			try
			{
				return ((TextReader)val2).ReadToEnd();
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}
}
