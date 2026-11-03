using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Detection;

public static class UnityGameDetector
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, bool> _003C0_003E__LooksLikeUnityData;

		public static Func<string, string> _003C1_003E__GetFileName;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, string> _003C_003E9__8_0;

		public static Func<Match, string> _003C_003E9__9_0;

		public static Func<string, string> _003C_003E9__9_1;

		internal string A(string P_0)
		{
			return P_0;
		}

		internal string A(Match P_0)
		{
			return ((Capture)P_0.Groups[1]).Value;
		}

		internal string a(string P_0)
		{
			return P_0;
		}
	}

	private static readonly Regex VersionPattern = new Regex(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CB(), (RegexOptions)8);

	private static readonly Regex NamePattern = new Regex(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cb(), (RegexOptions)8);

	public static UnityGameInfo? Inspect(string gameRoot)
	{
		if (string.IsNullOrWhiteSpace(gameRoot) || !Directory.Exists(gameRoot))
		{
			return null;
		}
		string text = B(gameRoot);
		if (text == null || (!File.Exists(Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bY())) && !a(text)))
		{
			return null;
		}
		System.Collections.Generic.IReadOnlyList<string> readOnlyList = C(text);
		if (((System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count == 0)
		{
			readOnlyList = c(text);
		}
		return new UnityGameInfo
		{
			DataDirectory = text,
			Backend = A(gameRoot, text, readOnlyList),
			UnityVersion = D(text),
			BuildGuid = d(text),
			ProductName = A(text, 1),
			CompanyName = A(text, 0),
			ManagedAssemblies = readOnlyList,
			Bitness = A(text)
		};
	}

	private static GameBitness A(string P_0)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		string directoryName = Path.GetDirectoryName(P_0);
		string fileName = Path.GetFileName(P_0);
		if (directoryName == null || !fileName.EndsWith(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.l(), (StringComparison)4))
		{
			return GameBitness.Unknown;
		}
		string text = fileName;
		int length = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.l().Length;
		string text2 = Path.Combine(directoryName, text.Substring(0, text.Length - length) + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.M());
		if (!File.Exists(text2))
		{
			return GameBitness.Unknown;
		}
		try
		{
			FileStream val = File.OpenRead(text2);
			try
			{
				BinaryReader val2 = new BinaryReader((Stream)(object)val);
				try
				{
					((Stream)val).Seek(60L, (SeekOrigin)0);
					int num = val2.ReadInt32();
					if (num <= 0 || num + 6 > ((Stream)val).Length)
					{
						return GameBitness.Unknown;
					}
					((Stream)val).Seek((long)(num + 4), (SeekOrigin)0);
					return val2.ReadUInt16() switch
					{
						34404 => GameBitness.Bits64, 
						332 => GameBitness.Bits32, 
						_ => GameBitness.Unknown, 
					};
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
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return GameBitness.Unknown;
		}
	}

	private static bool a(string P_0)
	{
		string directoryName = Path.GetDirectoryName(P_0);
		string fileName = Path.GetFileName(P_0);
		if (directoryName != null && fileName.EndsWith(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.l(), (StringComparison)4))
		{
			string text = fileName;
			int length = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.l().Length;
			if (File.Exists(Path.Combine(directoryName, text.Substring(0, text.Length - length) + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.M())))
			{
				if (!File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.by())))
				{
					return File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bZ()));
				}
				return true;
			}
		}
		return false;
	}

	private static string? B(string P_0)
	{
		return Enumerable.FirstOrDefault<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderByDescending<string, bool>((System.Collections.Generic.IEnumerable<string>)UnityDataFolders.InOrder(P_0), (Func<string, bool>)b), (Func<string, bool>)b);
	}

	private static bool b(string P_0)
	{
		if (!File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bz())) && !File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.by())) && !File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bQ())))
		{
			return Directory.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aa()));
		}
		return true;
	}

	private static ScriptingBackend A(string P_0, string P_1, System.Collections.Generic.IReadOnlyList<string> P_2)
	{
		if (File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aI())) || Directory.Exists(Path.Combine(P_1, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bv())))
		{
			return ScriptingBackend.Il2Cpp;
		}
		if (((System.Collections.Generic.IReadOnlyCollection<string>)P_2).Count <= 0)
		{
			return ScriptingBackend.Unknown;
		}
		return ScriptingBackend.Mono;
	}

	private static System.Collections.Generic.IReadOnlyList<string> C(string P_0)
	{
		string text = Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aa());
		if (!Directory.Exists(text))
		{
			return System.Array.Empty<string>();
		}
		return (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.OfType<string>((System.Collections.IEnumerable)Enumerable.Select<string, string>(Directory.EnumerateFiles(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aB(), (SearchOption)0), (Func<string, string>)Path.GetFileName)), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
	}

	private static System.Collections.Generic.IReadOnlyList<string> c(string P_0)
	{
		string text = Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CA());
		if (!File.Exists(text))
		{
			return System.Array.Empty<string>();
		}
		try
		{
			return (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Distinct<string>(Enumerable.Select<Match, string>((System.Collections.Generic.IEnumerable<Match>)NamePattern.Matches(File.ReadAllText(text, Encoding.UTF8)), (Func<Match, string>)((Match P_0) => ((Capture)P_0.Groups[1]).Value)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		}
		catch (IOException)
		{
			return System.Array.Empty<string>();
		}
	}

	internal static string? D(string P_0)
	{
		string[] array = new string[2]
		{
			_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.by(),
			_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bQ()
		};
		foreach (string text in array)
		{
			string text2 = Path.Combine(P_0, text);
			if (File.Exists(text2))
			{
				Match val = VersionPattern.Match(a(text2, 256));
				if (((Group)val).Success)
				{
					return ((Capture)val.Groups[1]).Value;
				}
			}
		}
		return null;
	}

	internal static string? d(string P_0)
	{
		string text = Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bz());
		if (!File.Exists(text))
		{
			return null;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = File.ReadLines(text).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (current.StartsWith(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Ca(), (StringComparison)5))
				{
					string text2 = current;
					int length = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Ca().Length;
					string text3 = text2.Substring(length, text2.Length - length).Trim();
					return (text3.Length > 0) ? text3 : null;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	private static string? A(string P_0, int P_1)
	{
		string text = Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.L());
		if (!File.Exists(text))
		{
			return null;
		}
		string[] array = File.ReadAllLines(text, Encoding.UTF8);
		if (P_1 >= array.Length)
		{
			return null;
		}
		string text2 = array[P_1].Trim();
		if (text2.Length <= 0)
		{
			return null;
		}
		return text2;
	}

	private static string a(string P_0, int P_1)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		FileStream val = File.OpenRead(P_0);
		try
		{
			byte[] array = new byte[P_1];
			int num = ((Stream)val).ReadAtLeast(System.Span<byte>.op_Implicit(array), P_1, false);
			StringBuilder val2 = new StringBuilder(num);
			for (int i = 0; i < num; i++)
			{
				byte b = array[i];
				val2.Append((char)((b >= 32 && b < 127) ? array[i] : 32));
			}
			return ((object)val2).ToString();
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}
}
