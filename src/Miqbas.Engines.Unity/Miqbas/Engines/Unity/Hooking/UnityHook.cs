using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using A;
using Miqbas.Core.IO;
using Miqbas.Core.Runtime;
using Miqbas.Core.Safety;
using Miqbas.Engines.Unity.Detection;

namespace Miqbas.Engines.Unity.Hooking;

public sealed class UnityHook
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, string> _003C0_003E__GetFileName;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<ZipArchiveEntry, string> _003C_003E9__37_0;

		internal string A(ZipArchiveEntry P_0)
		{
			return Enumerable.FirstOrDefault<string>((System.Collections.Generic.IEnumerable<string>)P_0.FullName.Replace('\\', '/').Split('/', (StringSplitOptions)1));
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string root;

		internal bool A(string P_0)
		{
			if (!File.Exists(Path.Combine(root, P_0)))
			{
				return !Directory.Exists(Path.Combine(root, P_0));
			}
			return false;
		}
	}

	[CompilerGenerated]
	private VerifiedDownloader _003Cdownloader_003EP;

	public const string MonoFacade = "netstandard.dll";

	public const string OwnershipMarker = "loader-is-ours.txt";

	public const string TheRuntimeIsTooOld = "لعبتك مبنية بنسخة قديمة من يونتي، وأداة مقباس ما تشتغل عليها للحين.";

	private const int TriesBeforeSayingItIsHeld = 3;

	private static readonly TimeSpan WaitBetweenTries = TimeSpan.FromMilliseconds(400.0);

	private static readonly string[] DroppedByTheLoader = new string[1] { _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bo() };

	[field: CompilerGenerated]
	public static HookRelease Release
	{
		[CompilerGenerated]
		get;
	} = new HookRelease
	{
		Version = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BF(),
		Url = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bf(),
		SizeBytes = 639118L,
		Sha256 = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BG(),
		FileName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bg()
	};


	[field: CompilerGenerated]
	public static HookRelease Release32
	{
		[CompilerGenerated]
		get;
	} = new HookRelease
	{
		Version = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BF(),
		Url = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BH(),
		SizeBytes = 638544L,
		Sha256 = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bh(),
		FileName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BI()
	};


	[field: CompilerGenerated]
	public static HookRelease Il2CppRelease
	{
		[CompilerGenerated]
		get;
	} = new HookRelease
	{
		Version = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bi(),
		Url = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BJ(),
		SizeBytes = 34335572L,
		Sha256 = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bj(),
		FileName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BK()
	};


	[field: CompilerGenerated]
	public static HookRelease Il2CppReleaseForUnity6
	{
		[CompilerGenerated]
		get;
	} = new HookRelease
	{
		Version = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bk(),
		Url = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BL(),
		SizeBytes = 34336405L,
		Sha256 = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bl(),
		FileName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BM()
	};


	[field: CompilerGenerated]
	public static System.Collections.Generic.IReadOnlyList<string> InstalledEntries
	{
		[CompilerGenerated]
		get;
	} = new B<string>(new string[5]
	{
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aX(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bm(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BN(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bn()
	});


	[field: CompilerGenerated]
	public static System.Collections.Generic.IReadOnlyList<string> Il2CppInstalledEntries
	{
		[CompilerGenerated]
		get;
	} = new B<string>(new string[6]
	{
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BO(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aX(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bm(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BN(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bn()
	});


	public UnityHook(VerifiedDownloader downloader)
	{
		_003Cdownloader_003EP = downloader;
		base._002Ector();
	}

	public static HookRelease MonoReleaseFor(GameBitness bitness)
	{
		if (bitness != GameBitness.Bits32)
		{
			return Release;
		}
		return Release32;
	}

	public static HookRelease MonoReleaseForGame(string gameRoot)
	{
		return MonoReleaseFor(UnityGameDetector.Inspect(gameRoot)?.Bitness ?? GameBitness.Unknown);
	}

	public static HookRelease Il2CppReleaseForGame(string gameRoot)
	{
		if (!A(gameRoot))
		{
			return Il2CppRelease;
		}
		return Il2CppReleaseForUnity6;
	}

	internal static bool A(string P_0)
	{
		string text = UnityGameDetector.Inspect(P_0)?.UnityVersion;
		if (text != null && text.Length > 0)
		{
			string text2 = text.Split('.', (StringSplitOptions)0)[0];
			int num = default(int);
			if (text2 != null && text2.Length > 0 && int.TryParse(text2, ref num))
			{
				return num >= 6000;
			}
		}
		return false;
	}

	public static string WorkDirectoryIn(string gameRoot)
	{
		return Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aW(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ap());
	}

	public static string WhereItGoes(string gameRoot, string assembly)
	{
		if (!string.Equals(Path.GetFileName(assembly), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aw(), (StringComparison)5))
		{
			return Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aW(), Path.GetFileName(assembly));
		}
		return Path.Combine(WorkDirectoryIn(gameRoot), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aw());
	}

	public static bool IsInstalled(string gameRoot)
	{
		if (File.Exists(Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aX())))
		{
			return Directory.Exists(Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aJ()));
		}
		return false;
	}

	public static void NoteTheLoaderIsOursBeside(string? backupDir)
	{
		if (backupDir != null && backupDir.Length > 0)
		{
			Directory.CreateDirectory(backupDir);
			File.WriteAllText(Path.Combine(backupDir, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ax()), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aY());
		}
	}

	public static void ForgetTheNoteBeside(string? backupDir)
	{
		if (backupDir != null && backupDir.Length > 0 && File.Exists(Path.Combine(backupDir, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ax())))
		{
			File.Delete(Path.Combine(backupDir, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ax()));
		}
	}

	public static bool TheLoaderIsOurs(string gameRoot, string? backupDir = null)
	{
		string text = WorkDirectoryIn(gameRoot);
		if (!File.Exists(Path.Combine(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ay())) && !File.Exists(Path.Combine(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aZ())) && !LoaderOwnership.TheNoteIsBeside(backupDir))
		{
			return a(gameRoot);
		}
		return true;
	}

	private static bool a(string P_0)
	{
		string text = Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aW());
		if (!Directory.Exists(text))
		{
			return false;
		}
		try
		{
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFileSystemEntries(text).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string fileName = Path.GetFileName(enumerator.Current);
					if (!fileName.Equals(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ap(), (StringComparison)5) && !fileName.StartsWith(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.az(), (StringComparison)5))
					{
						return false;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return Directory.Exists(WorkDirectoryIn(P_0));
		}
		catch (IOException)
		{
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
	}

	public System.Threading.Tasks.Task<string> AcquireAsync(string cacheDirectory, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return AcquireAsync(Release, cacheDirectory, progress, cancellationToken);
	}

	public System.Threading.Tasks.Task<string> AcquireAsync(HookRelease release, string cacheDirectory, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		return _003Cdownloader_003EP.DownloadAsync(new DownloadRequest
		{
			Url = release.Url,
			DestinationPath = Path.Combine(cacheDirectory, release.FileName),
			SizeBytes = release.SizeBytes,
			Sha256 = release.Sha256,
			Subject = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BA()
		}, progress, cancellationToken);
	}

	public void Install(string gameRoot, string hookArchivePath, PluginPayload payload)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(gameRoot))
		{
			throw new DirectoryNotFoundException(gameRoot);
		}
		string fullPath = Path.GetFullPath(gameRoot);
		if (!TheRuntimeAGameCarries.CanLoadOurPlugin(fullPath))
		{
			throw new NotSupportedException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Ba());
		}
		bool flag = IsInstalled(fullPath);
		bool flag2 = !flag || TheLoaderIsOurs(fullPath);
		List<string> val = (List<string>)(flag ? ((object)new List<string>()) : ((object)A(fullPath, hookArchivePath)));
		try
		{
			if (flag2)
			{
				ZipArchive val2 = ZipFile.OpenRead(hookArchivePath);
				try
				{
					System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val2.Entries.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							ZipArchiveEntry current = enumerator.Current;
							string fullPath2 = Path.GetFullPath(Path.Combine(fullPath, current.FullName));
							System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(fullPath);
							char directorySeparatorChar = Path.DirectorySeparatorChar;
							if (!fullPath2.StartsWith(string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref directorySeparatorChar)), (StringComparison)5))
							{
								throw new InvalidDataException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BB() + current.FullName);
							}
							if (current.Name.Length == 0)
							{
								Directory.CreateDirectory(fullPath2);
								continue;
							}
							Directory.CreateDirectory(Path.GetDirectoryName(fullPath2));
							ZipFileExtensions.ExtractToFile(current, fullPath2, true);
						}
					}
					finally
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			WritePayload(fullPath, payload);
			if (flag2 && File.Exists(Path.Combine(fullPath, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aI())))
			{
				TheLoadersBuiltFiles.PutBack(fullPath);
			}
			if (!flag)
			{
				File.WriteAllText(Path.Combine(WorkDirectoryIn(fullPath), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ay()), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bb() + Environment.NewLine, (Encoding)new UTF8Encoding(false));
			}
		}
		catch
		{
			A(fullPath, (System.Collections.Generic.IReadOnlyList<string>)val);
			throw;
		}
	}

	private static List<string> A(string P_0, string P_1)
	{
		string root = P_0;
		ZipArchive val = ZipFile.OpenRead(P_1);
		try
		{
			return Enumerable.ToList<string>(Enumerable.Where<string>(Enumerable.Distinct<string>(Enumerable.Append<string>(Enumerable.OfType<string>((System.Collections.IEnumerable)Enumerable.Select<ZipArchiveEntry, string>((System.Collections.Generic.IEnumerable<ZipArchiveEntry>)val.Entries, (Func<ZipArchiveEntry, string>)((ZipArchiveEntry P_0) => Enumerable.FirstOrDefault<string>((System.Collections.Generic.IEnumerable<string>)P_0.FullName.Replace('\\', '/').Split('/', (StringSplitOptions)1))))), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH()), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase), (Func<string, bool>)((string P_0) => !File.Exists(Path.Combine(root, P_0)) && !Directory.Exists(Path.Combine(root, P_0)))));
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static void A(string P_0, System.Collections.Generic.IReadOnlyList<string> P_1)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)P_1).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string text = Path.Combine(P_0, current);
				try
				{
					FileAttributes attributes = File.GetAttributes(text);
					if (((System.Enum)attributes).HasFlag((System.Enum)(object)(FileAttributes)16))
					{
						Directory.Delete(text, !((System.Enum)attributes).HasFlag((System.Enum)(object)(FileAttributes)1024));
					}
					else
					{
						File.Delete(text);
					}
				}
				catch (FileNotFoundException)
				{
				}
				catch (DirectoryNotFoundException)
				{
				}
				catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
				{
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static void RefreshMiqbasPluginFiles(string gameRoot, System.Collections.Generic.IReadOnlyList<string> pluginAssemblies, string? arabicFontPath)
	{
		if (!Directory.Exists(Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aW())))
		{
			return;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)pluginAssemblies).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (File.Exists(current))
				{
					string text = WhereItGoes(gameRoot, current);
					Directory.CreateDirectory(Path.GetDirectoryName(text));
					File.Copy(current, text, true);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (arabicFontPath != null && arabicFontPath.Length > 0)
		{
			if (File.Exists(arabicFontPath))
			{
				string text2 = WorkDirectoryIn(gameRoot);
				Directory.CreateDirectory(text2);
				File.Copy(arabicFontPath, Path.Combine(text2, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BC()), true);
				A(gameRoot, text2, arabicFontPath);
			}
		}
	}

	public void WritePayload(string gameRoot, PluginPayload payload)
	{
		string text = WorkDirectoryIn(gameRoot);
		Directory.CreateDirectory(text);
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)payload.PluginAssemblies).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				File.Copy(current, WhereItGoes(gameRoot, current), true);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		string arabicFontPath = payload.ArabicFontPath;
		if (arabicFontPath != null && arabicFontPath.Length > 0 && File.Exists(arabicFontPath))
		{
			File.Copy(arabicFontPath, Path.Combine(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BC()), true);
			A(gameRoot, text, arabicFontPath);
		}
		WriteTranslations(gameRoot, payload.Translations);
	}

	private static void A(string P_0, string P_1, string P_2)
	{
		if (TheFaceForTheGamesOwnTextMeshPro.IsCarriedBy(P_0))
		{
			TheFaceForTheGamesOwnTextMeshPro.WriteInto(P_1, P_2);
		}
	}

	public static void WriteTranslations(string gameRoot, IReadOnlyDictionary<string, string> translations)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		string text = WorkDirectoryIn(gameRoot);
		Directory.CreateDirectory(text);
		File.WriteAllText(Path.Combine(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bc()), TranslationFile.Write(translations), (Encoding)new UTF8Encoding(false));
	}

	public static ObservedTextFile? Remove(string gameRoot)
	{
		return Remove(gameRoot, InstalledEntries);
	}

	public static ObservedTextFile? Remove(string gameRoot, System.Collections.Generic.IReadOnlyList<string> installedEntries)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		ObservedTextFile result = ObservedTextFile.ReadFrom(WorkDirectoryIn(gameRoot));
		List<string> val = new List<string>();
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)installedEntries).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (!B(Path.Combine(gameRoot, current)))
				{
					val.Add(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		SweepWhatTheLoaderDropped(gameRoot);
		if (val.Count > 0)
		{
			throw new IOException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BD() + string.Join(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bd(), Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, string>)Path.GetFileName)) + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BE());
		}
		return result;
	}

	public static ObservedTextFile? RemoveOnlyOurs(string gameRoot)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		ObservedTextFile result = ObservedTextFile.ReadFrom(WorkDirectoryIn(gameRoot));
		List<string> val = new List<string>();
		if (!B(WorkDirectoryIn(gameRoot)))
		{
			val.Add(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ap());
		}
		string text = Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aW());
		if (Directory.Exists(text))
		{
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Be()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					if (!B(current))
					{
						val.Add(Path.GetFileName(current));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		if (val.Count > 0)
		{
			throw new IOException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BD() + string.Join(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bd(), (System.Collections.Generic.IEnumerable<string>)val) + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BE());
		}
		return result;
	}

	private static bool B(string P_0)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		while (true)
		{
			try
			{
				DeletingWhatWillNotDelete.Delete(P_0);
				return true;
			}
			catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
			{
				if (num >= 3)
				{
					return false;
				}
				Thread.Sleep(WaitBetweenTries);
			}
			num++;
		}
	}

	public static System.Collections.Generic.IReadOnlyList<string> SweepWhatTheLoaderDropped(string gameRoot)
	{
		List<string> val = new List<string>();
		if (!Directory.Exists(gameRoot))
		{
			return (System.Collections.Generic.IReadOnlyList<string>)val;
		}
		string[] droppedByTheLoader = DroppedByTheLoader;
		foreach (string text in droppedByTheLoader)
		{
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(gameRoot, text, (SearchOption)0).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					try
					{
						File.Delete(current);
						val.Add(Path.GetFileName(current));
					}
					catch (IOException)
					{
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		return (System.Collections.Generic.IReadOnlyList<string>)val;
	}
}
