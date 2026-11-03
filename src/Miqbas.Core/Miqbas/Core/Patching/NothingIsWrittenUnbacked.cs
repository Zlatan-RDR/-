using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

public static class NothingIsWrittenUnbacked
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
		public string GameRoot
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public HashSet<string> Backed
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public A(string P_0, HashSet<string> P_1)
		{
			GameRoot = P_0;
			Backed = P_1;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SB());
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
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sb());
			P_0.Append((object)GameRoot);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SC());
			P_0.Append((object)Backed);
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
			return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameRoot)) * -1521134295 + EqualityComparer<HashSet<string>>.Default.GetHashCode(Backed);
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
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(GameRoot, other.GameRoot))
				{
					return EqualityComparer<HashSet<string>>.Default.Equals(Backed, other.Backed);
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
			GameRoot = P_0.GameRoot;
			Backed = P_0.Backed;
		}

		[CompilerGenerated]
		public void A(out string P_0, out HashSet<string> P_1)
		{
			P_0 = GameRoot;
			P_1 = Backed;
		}
	}

	private sealed class a : System.IDisposable
	{
		public void Dispose()
		{
			_gate = null;
		}
	}

	[CompilerGenerated]
	private static class B
	{
		public static Func<string, string> _003C0_003E__Normalise;
	}

	[ThreadStatic]
	private static A? _gate;

	public static bool IsArmed => (object)_gate != null;

	public static System.IDisposable ArmFor(string gameRoot, System.Collections.Generic.IEnumerable<string> backedUpRelativePaths)
	{
		ArgumentNullException.ThrowIfNull((object)gameRoot, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lz());
		ArgumentNullException.ThrowIfNull((object)backedUpRelativePaths, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lA());
		_gate = new A(Path.GetFullPath(gameRoot), new HashSet<string>(Enumerable.Select<string, string>(backedUpRelativePaths, (Func<string, string>)A), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		return new a();
	}

	public static void AlsoBackedUp(string relativePath)
	{
		A gate = _gate;
		if ((object)gate != null && relativePath != null && relativePath.Length > 0)
		{
			gate.Backed.Add(A(relativePath));
		}
	}

	public static void BeforeWriting(string path)
	{
		A gate = _gate;
		if ((object)gate == null || string.IsNullOrWhiteSpace(path))
		{
			return;
		}
		string fullPath = Path.GetFullPath(path);
		System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(gate.GameRoot);
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		if (fullPath.StartsWith(string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref directorySeparatorChar)), (StringComparison)5) || string.Equals(fullPath, gate.GameRoot, (StringComparison)5))
		{
			string text = A(Path.GetRelativePath(gate.GameRoot, fullPath));
			if (!gate.Backed.Contains(text))
			{
				throw new AFileWithNoBackupException(text);
			}
		}
	}

	private static string A(string P_0)
	{
		return P_0.Replace('/', Path.DirectorySeparatorChar).TrimStart(new char[2]
		{
			'.',
			Path.DirectorySeparatorChar
		});
	}
}
