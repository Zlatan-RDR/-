using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;
using Miqbas.Core.IO;
using Miqbas.Core.Runtime;

namespace Miqbas.Engines.Unreal.Hooking;

public sealed class UnrealHook
{
	public sealed class TheAntivirusTookItException : IOException
	{
		public TheAntivirusTookItException(string fileName, global::System.Exception inner)
			: base(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hI() + fileName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hi(), inner)
		{
		}
	}

	[CompilerGenerated]
	private static class a
	{
		public static Func<string, bool> _003C0_003E__SomethingElseHasItOpen;

		public static Func<string, string> _003C1_003E__GetFileName;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B
	{
		public static readonly B _003C_003E9 = new B();

		public static Func<char, bool> _003C_003E9__7_0;

		public static Predicate<string> _003C_003E9__26_0;

		public static Func<string, bool> _003C_003E9__30_0;

		public static Func<string, bool> _003C_003E9__37_0;

		public static Func<string, bool> _003C_003E9__38_0;

		public static Predicate<string> _003C_003E9__44_0;

		public static Predicate<string> _003C_003E9__44_1;

		internal bool A(char P_0)
		{
			return P_0 == '.';
		}

		internal bool A(string P_0)
		{
			return P_0.Trim().Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gr(), (StringComparison)5);
		}

		internal bool a(string P_0)
		{
			if (P_0.Length > 0)
			{
				return P_0[0] != '#';
			}
			return false;
		}

		internal bool B(string P_0)
		{
			if (!P_0.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)5))
			{
				return !ModsTheLoaderArrivedWith.Contains(P_0);
			}
			return false;
		}

		internal bool b(string P_0)
		{
			if (P_0.TrimStart().StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)5))
			{
				return !P_0.Contains(':', (StringComparison)4);
			}
			return true;
		}

		internal bool C(string P_0)
		{
			if (P_0.TrimStart().StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)5))
			{
				return P_0.Contains(':', (StringComparison)4);
			}
			return false;
		}

		internal bool c(string P_0)
		{
			if (P_0.TrimStart().StartsWith(';'))
			{
				return P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hJ(), (StringComparison)5);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string binariesDirectory;

		internal bool A(string P_0)
		{
			string text = Path.Combine(binariesDirectory, P_0);
			if (!Directory.Exists(text))
			{
				return File.Exists(text);
			}
			return true;
		}
	}

	public const string ModName = "MiqbasTranslation";

	public const string LoaderAsset = "ue4ss-3.0.1-1028-gd7e7826d.zip";

	public const string ScriptAsset = "miqbas_adaptive.lua";

	public const string NewestEngineTheLoaderReaches = "5.5";

	public const string TheRoadDoesNotWorkHere = "لا يعمل هذا الطريق على هذه اللعبة الآن.";

	public const string ProxyDll = "dwmapi.dll";

	internal const string OwnershipMarker = "miqbas-installed-the-loader.txt";

	public const string CloseTheGameFirst = "أغلق اللعبة أول\u064bا، ثم أعد المحاولة.";

	public const string TheRemovalDidNotFinish = "لم تكتمل إزالة الطبقة. أغلق اللعبة ثم أعد المحاولة.";

	internal static readonly IReadOnlySet<string> ModsTheLoaderArrivedWith = (IReadOnlySet<string>)(object)new HashSet<string>((global::System.Collections.Generic.IEnumerable<string>)new d<string>(new string[9]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gz(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gA(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ga(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gB(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gb(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gC(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gc(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gD(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gd()
	}), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);

	[field: CompilerGenerated]
	public static global::System.Collections.Generic.IReadOnlyList<string> LoaderEntries
	{
		[CompilerGenerated]
		get;
	} = new d<string>(new string[2]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GQ(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gm()
	});


	public static string? WhyTheLoaderCannotEnterAProtectedGame(bool theGameRunsAnAntiCheat)
	{
		if (!theGameRunsAnAntiCheat)
		{
			return null;
		}
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aK();
	}

	public static string? WhyTheLoaderCannotWork(string? engineVersion)
	{
		Version val = default(Version);
		Version val2 = default(Version);
		if (engineVersion == null || !Version.TryParse(A(engineVersion), ref val) || !Version.TryParse(A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GL()), ref val2) || val <= val2)
		{
			return null;
		}
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aK();
	}

	private static string A(string P_0)
	{
		if (Enumerable.Count<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 == '.')) != 1)
		{
			return P_0;
		}
		return P_0 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gl();
	}

	private static string a(string P_0)
	{
		return Path.Combine(LoaderDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GM());
	}

	private static string B(string P_0)
	{
		return Path.Combine(ModDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GM());
	}

	private static bool b(string P_0)
	{
		if (!File.Exists(a(P_0)))
		{
			return File.Exists(B(P_0));
		}
		return true;
	}

	public static string LoaderDirectoryIn(string binariesDirectory)
	{
		return Path.Combine(binariesDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gm());
	}

	public static string ModDirectoryIn(string binariesDirectory)
	{
		return Path.Combine(LoaderDirectoryIn(binariesDirectory), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GN(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g());
	}

	public static string WorkDirectoryIn(string binariesDirectory)
	{
		return Path.Combine(ModDirectoryIn(binariesDirectory), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gn());
	}

	public static string ScriptPathIn(string binariesDirectory)
	{
		return Path.Combine(ModDirectoryIn(binariesDirectory), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GO(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Go());
	}

	public static string ModsListIn(string binariesDirectory)
	{
		return Path.Combine(LoaderDirectoryIn(binariesDirectory), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GN(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GP());
	}

	public static bool IsInstalled(string binariesDirectory)
	{
		return File.Exists(ScriptPathIn(binariesDirectory));
	}

	public static bool OurLoaderIsHere(string binariesDirectory)
	{
		if (LoaderIsPresent(binariesDirectory))
		{
			return b(binariesDirectory);
		}
		return false;
	}

	public static bool LoaderIsPresent(string binariesDirectory)
	{
		return File.Exists(Path.Combine(LoaderDirectoryIn(binariesDirectory), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gp()));
	}

	public static global::System.Collections.Generic.IReadOnlyList<string> EditedFiles(string gameRoot, string binariesDirectory)
	{
		return new e<string>(Path.GetRelativePath(gameRoot, ModsListIn(binariesDirectory)).Replace('\\', '/'));
	}

	public void Install(string binariesDirectory, string loaderArchivePath, string scriptPath, LayerPayload payload)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(binariesDirectory))
		{
			throw new DirectoryNotFoundException(binariesDirectory);
		}
		bool flag = !LoaderIsPresent(binariesDirectory);
		if (flag && File.Exists(Path.Combine(binariesDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GQ())))
		{
			throw new InvalidOperationException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gq());
		}
		if (flag)
		{
			A(binariesDirectory, loaderArchivePath);
		}
		A(binariesDirectory, scriptPath, flag);
		B(binariesDirectory, flag);
		WritePayload(binariesDirectory, payload);
	}

	public static bool NameTheEngine(string binariesDirectory, int major, int minor)
	{
		string text = Path.Combine(LoaderDirectoryIn(binariesDirectory), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GR());
		if (!File.Exists(text))
		{
			return false;
		}
		List<string> val = Enumerable.ToList<string>((global::System.Collections.Generic.IEnumerable<string>)File.ReadAllLines(text));
		int num = val.FindIndex((Predicate<string>)((string P_0) => P_0.Trim().Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gr(), (StringComparison)5)));
		if (num < 0)
		{
			val.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa());
			val.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gr());
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GS());
			defaultInterpolatedStringHandler.AppendFormatted<int>(major);
			val.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gs());
			defaultInterpolatedStringHandler.AppendFormatted<int>(minor);
			val.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		else
		{
			A(val, num, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GT(), major);
			A(val, num, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gt(), minor);
		}
		File.WriteAllLines(text, (global::System.Collections.Generic.IEnumerable<string>)val);
		return true;
	}

	private static void A(List<string> P_0, int P_1, string P_2, int P_3)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		for (int i = P_1 + 1; i < P_0.Count && !P_0[i].TrimStart().StartsWith('['); i++)
		{
			if (P_0[i].TrimStart().StartsWith(P_2, (StringComparison)5))
			{
				int num = i;
				defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GU());
				defaultInterpolatedStringHandler.AppendFormatted<int>(P_3);
				P_0[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				return;
			}
		}
		int num2 = P_1 + 1;
		defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendFormatted(P_2);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GU());
		defaultInterpolatedStringHandler.AppendFormatted<int>(P_3);
		P_0.Insert(num2, defaultInterpolatedStringHandler.ToStringAndClear());
	}

	public static void WritePayload(string binariesDirectory, LayerPayload payload)
	{
		Directory.CreateDirectory(WorkDirectoryIn(binariesDirectory));
		WriteTranslations(binariesDirectory, payload.Translations);
	}

	public static void WriteTranslations(string binariesDirectory, IReadOnlyDictionary<string, string> translations)
	{
		string text = WorkDirectoryIn(binariesDirectory);
		Directory.CreateDirectory(text);
		AtomicFile.WriteAllText(Path.Combine(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gu()), TranslationFile.Write(translations));
	}

	public static void AppendTranslation(string binariesDirectory, string source, string translation)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		string text2 = Enumerable.FirstOrDefault<string>((global::System.Collections.Generic.IEnumerable<string>)TranslationFile.Write((IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal) { [source] = translation }).Split('\n', (StringSplitOptions)0), (Func<string, bool>)((string P_0) => P_0.Length > 0 && P_0[0] != '#'));
		if (text2 != null)
		{
			string text3 = WorkDirectoryIn(binariesDirectory);
			Directory.CreateDirectory(text3);
			File.AppendAllText(Path.Combine(text3, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gu()), text2 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GV(), (Encoding)new UTF8Encoding(false));
		}
	}

	public static bool Remove(string binariesDirectory)
	{
		bool flag = b(binariesDirectory);
		A(binariesDirectory, flag);
		if (flag && ((global::System.Collections.Generic.IReadOnlyCollection<string>)c(binariesDirectory)).Count > 0)
		{
			d(ModDirectoryIn(binariesDirectory));
			D(binariesDirectory);
			d(a(binariesDirectory));
			d(B(binariesDirectory));
			a(binariesDirectory, false);
			return true;
		}
		if (flag)
		{
			d(Path.Combine(binariesDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GQ()));
		}
		d(ModDirectoryIn(binariesDirectory));
		if (flag)
		{
			d(LoaderDirectoryIn(binariesDirectory));
		}
		a(binariesDirectory, flag);
		return false;
	}

	private static void A(string P_0, bool P_1)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		List<string> obj = new List<string>(num);
		CollectionsMarshal.SetCount<string>(obj, num);
		global::System.Span<string> span = CollectionsMarshal.AsSpan<string>(obj);
		int num2 = 0;
		span[num2] = ScriptPathIn(P_0);
		num2++;
		List<string> val = obj;
		if (P_1)
		{
			val.Add(Path.Combine(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GQ()));
			val.Add(Path.Combine(LoaderDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gp()));
		}
		if (Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)C))
		{
			throw new IOException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gv());
		}
	}

	private static bool C(string P_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		if (!File.Exists(P_0))
		{
			return false;
		}
		try
		{
			FileStream val = new FileStream(P_0, (FileMode)3, (FileAccess)3, (FileShare)0);
			try
			{
				return false;
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return true;
		}
	}

	internal static global::System.Collections.Generic.IReadOnlyList<string> c(string P_0)
	{
		string text = Path.Combine(LoaderDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GN());
		if (!Directory.Exists(text))
		{
			return global::System.Array.Empty<string>();
		}
		return (global::System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Where<string>(Enumerable.OfType<string>((global::System.Collections.IEnumerable)Enumerable.Select<string, string>(Directory.EnumerateDirectories(text), (Func<string, string>)Path.GetFileName)), (Func<string, bool>)((string P_0) => !P_0.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)5) && !ModsTheLoaderArrivedWith.Contains(P_0))));
	}

	private static void D(string P_0)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		string text = ModsListIn(P_0);
		if (File.Exists(text))
		{
			List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)File.ReadAllLines(text, Encoding.UTF8), (Func<string, bool>)((string P_0) => !P_0.TrimStart().StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)5) || !P_0.Contains(':', (StringComparison)4))));
			File.WriteAllText(text, string.Join<string>('\n', (global::System.Collections.Generic.IEnumerable<string>)val) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GV(), (Encoding)new UTF8Encoding(false));
		}
	}

	private static void d(string P_0)
	{
		if (Directory.Exists(P_0))
		{
			Directory.Delete(P_0, true);
		}
		else if (File.Exists(P_0))
		{
			File.Delete(P_0);
		}
	}

	private static void a(string P_0, bool P_1)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		string binariesDirectory = P_0;
		bool flag = Directory.Exists(ModDirectoryIn(binariesDirectory));
		if (P_1)
		{
			flag |= Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)LoaderEntries, (Func<string, bool>)delegate(string P_0)
			{
				string text = Path.Combine(binariesDirectory, P_0);
				return Directory.Exists(text) || File.Exists(text);
			});
		}
		if (flag)
		{
			throw new IOException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GW());
		}
	}

	private static void A(string P_0, string P_1)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		string fullPath = Path.GetFullPath(P_0);
		ZipArchive val = ZipFile.OpenRead(P_1);
		try
		{
			global::System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val.Entries.GetEnumerator();
			try
			{
				global::System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
				global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
				IOException val2 = default(IOException);
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ZipArchiveEntry current = enumerator.Current;
					string fullPath2 = Path.GetFullPath(Path.Combine(fullPath, current.FullName));
					global::System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(fullPath);
					char directorySeparatorChar = Path.DirectorySeparatorChar;
					if (!fullPath2.StartsWith(string.Concat(readOnlySpan, new global::System.ReadOnlySpan<char>(ref directorySeparatorChar)), (StringComparison)5))
					{
						throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gw() + current.FullName);
					}
					if (current.Name.Length == 0)
					{
						Directory.CreateDirectory(fullPath2);
						continue;
					}
					Directory.CreateDirectory(Path.GetDirectoryName(fullPath2));
					try
					{
						ZipFileExtensions.ExtractToFile(current, fullPath2, true);
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = ((obj is IOException) ? obj : null);
						if (obj2 == null)
						{
							result = 0;
						}
						else
						{
							val2 = (IOException)obj2;
							result = ((((global::System.Exception)(object)val2).Message.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GX(), (StringComparison)5) || ((global::System.Exception)(object)val2).Message.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gx(), (StringComparison)5)) ? 1 : 0);
						}
						return (byte)result != 0;
					}).Invoke())
					{
						throw new TheAntivirusTookItException(Path.GetFileName(fullPath2), (global::System.Exception)(object)val2);
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static void A(string P_0, string P_1, bool P_2)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Directory.CreateDirectory(Path.Combine(ModDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GO()));
		Directory.CreateDirectory(WorkDirectoryIn(P_0));
		File.Copy(P_1, ScriptPathIn(P_0), true);
		string text = a(P_0);
		string text2 = B(P_0);
		if (P_2)
		{
			File.WriteAllText(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GY(), (Encoding)new UTF8Encoding(false));
		}
		else
		{
			d(text2);
		}
	}

	private static void B(string P_0, bool P_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		string text = ModsListIn(P_0);
		Directory.CreateDirectory(Path.GetDirectoryName(text));
		if (P_1)
		{
			File.WriteAllText(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gy(), (Encoding)new UTF8Encoding(false));
			return;
		}
		List<string> val = (File.Exists(text) ? Enumerable.ToList<string>((global::System.Collections.Generic.IEnumerable<string>)File.ReadAllLines(text, Encoding.UTF8)) : new List<string>());
		string text2 = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GZ();
		int num = val.FindIndex((Predicate<string>)((string P_0) => P_0.TrimStart().StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)5) && P_0.Contains(':', (StringComparison)4)));
		if (num >= 0)
		{
			val[num] = text2;
		}
		else
		{
			int num2 = val.FindIndex((Predicate<string>)((string P_0) => P_0.TrimStart().StartsWith(';') && P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hJ(), (StringComparison)5)));
			if (num2 >= 0)
			{
				val.Insert(num2, text2);
			}
			else
			{
				val.Add(text2);
			}
		}
		File.WriteAllText(text, string.Join<string>('\n', (global::System.Collections.Generic.IEnumerable<string>)val) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GV(), (Encoding)new UTF8Encoding(false));
	}
}
