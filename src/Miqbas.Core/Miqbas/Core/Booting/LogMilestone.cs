using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Booting;

public static class LogMilestone
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<char, bool> _003C0_003E__IsLetter;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<char, bool> _003C_003E9__12_0;

		public static Func<char, bool> _003C_003E9__13_0;

		internal bool A(char P_0)
		{
			bool flag = P_0 == '\ufffd';
			if (!flag)
			{
				bool flag2 = char.IsControl(P_0);
				if (flag2)
				{
					bool flag3;
					switch (P_0)
					{
					case '\t':
					case '\n':
					case '\r':
						flag3 = true;
						break;
					default:
						flag3 = false;
						break;
					}
					flag2 = !flag3;
				}
				flag = flag2;
			}
			return flag;
		}

		internal bool a(char P_0)
		{
			if (P_0 != '\ufffd')
			{
				if (char.IsControl(P_0))
				{
					return P_0 != '\t';
				}
				return false;
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string milestone;

		internal bool A(string P_0)
		{
			if (!(ShapeOf(P_0) == milestone))
			{
				return ShapeAsItWas(P_0) == milestone;
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class b : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string logText;

		public string _003C_003E3__logText;

		private string[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0082;
			}
			_003C_003E1__state = -1;
			if (string.IsNullOrEmpty(logText) || LogMilestone.B(logText))
			{
				return false;
			}
			_003C_003E7__wrap1 = logText.Split('\n', (StringSplitOptions)0);
			_003C_003E7__wrap2 = 0;
			goto IL_0090;
			IL_0082:
			_003C_003E7__wrap2++;
			goto IL_0090;
			IL_0090:
			if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
			{
				string line = _003C_003E7__wrap1[_003C_003E7__wrap2].Trim();
				if (!SaysNothingAboutProgress(line))
				{
					_003C_003E2__current = line;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0082;
			}
			_003C_003E7__wrap1 = null;
			return false;
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<string> B()
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
			b.logText = _003C_003E3__logText;
			return b;
		}

		System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator b()
		{
			return (System.Collections.IEnumerator)B();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}
	}

	[GeneratedRegex("(?<![A-Za-z])(?:0x)?[0-9A-Fa-f]{2,}(?![A-Za-z])|\\d")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex A()
	{
		return (Regex)(object)global::A.b.Instance;
	}

	[GeneratedRegex("\\b(?=[A-Za-z0-9_\\-]*\\d)(?=[A-Za-z0-9_\\-]*[A-Za-z])[A-Za-z0-9_\\-]{8,}\\b")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex a()
	{
		return (Regex)(object)global::A.C.Instance;
	}

	[GeneratedRegex(/*Could not decode attribute arguments.*/)]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex B()
	{
		return (Regex)(object)c.Instance;
	}

	[GeneratedRegex("\\s+")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex b()
	{
		return (Regex)(object)D.Instance;
	}

	[GeneratedRegex("#[#.,:]*#|#")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex C()
	{
		return (Regex)(object)d.Instance;
	}

	public static string ShapeOf(string line)
	{
		string text = B().Replace(line ?? string.Empty, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qa());
		return A(a().Replace(text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QB()));
	}

	public static string ShapeAsItWas(string line)
	{
		return A(line ?? string.Empty);
	}

	private static string A(string P_0)
	{
		string text = A().Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QB());
		string text2 = C().Replace(text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QB());
		return b().Replace(text2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()).Trim();
	}

	public static bool Reached(string? milestone, string logText)
	{
		string milestone2 = milestone;
		if (string.IsNullOrWhiteSpace(milestone2))
		{
			return false;
		}
		return Enumerable.Any<string>(a(logText), (Func<string, bool>)((string P_0) => ShapeOf(P_0) == milestone2 || ShapeAsItWas(P_0) == milestone2));
	}

	public static string? LastOf(string logText)
	{
		return LastOf(logText, null);
	}

	public static string? LastOf(string logText, Func<string, bool>? weCouldHaveWritten)
	{
		string text = null;
		System.Collections.Generic.IEnumerator<string> enumerator = a(logText).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (weCouldHaveWritten == null || !weCouldHaveWritten.Invoke(current))
				{
					text = current;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (text != null)
		{
			return ShapeOf(text);
		}
		return null;
	}

	[IteratorStateMachine(typeof(b))]
	private static System.Collections.Generic.IEnumerable<string> a(string P_0)
	{
		if (string.IsNullOrEmpty(P_0) || B(P_0))
		{
			yield break;
		}
		string[] array = P_0.Split('\n', (StringSplitOptions)0);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim();
			if (!SaysNothingAboutProgress(text))
			{
				yield return text;
			}
		}
	}

	private static bool B(string P_0)
	{
		return Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)delegate(char P_0)
		{
			bool flag = P_0 == '\ufffd';
			if (!flag)
			{
				bool flag2 = char.IsControl(P_0);
				if (flag2)
				{
					bool flag3;
					switch (P_0)
					{
					case '\t':
					case '\n':
					case '\r':
						flag3 = true;
						break;
					default:
						flag3 = false;
						break;
					}
					flag2 = !flag3;
				}
				flag = flag2;
			}
			return flag;
		}) * 20 > P_0.Length;
	}

	public static bool SaysNothingAboutProgress(string? line)
	{
		if (string.IsNullOrWhiteSpace(line))
		{
			return true;
		}
		string text = line.Trim();
		if (!text.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qb(), (StringComparison)4) && !text.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QC(), (StringComparison)4) && !text.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qc(), (StringComparison)4) && !text.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QD(), (StringComparison)4) && !text.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qd(), (StringComparison)4) && Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsLetter))
		{
			return Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)((char P_0) => P_0 == '\ufffd' || (char.IsControl(P_0) && P_0 != '\t')));
		}
		return true;
	}
}
