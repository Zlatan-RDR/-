using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;
using Miqbas.Core.Engines;
using Miqbas.Core.IO;

namespace Miqbas.Core.Patching;

public static class FileBackup
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, long?> _003C0_003E__DiskFreeSpace;

		public static Action<string, string> _003C1_003E__TheSystemsCopy;

		public static Func<string, bool> _003C2_003E__Exists;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<BackupEntry, bool> _003C_003E9__26_0;

		public static Func<BackupEntry, string> _003C_003E9__27_1;

		public static Func<string, bool> _003C_003E9__32_0;

		internal bool A(BackupEntry P_0)
		{
			return P_0.Kind == BackupEntryKind.Added;
		}

		internal string a(BackupEntry P_0)
		{
			return P_0.RelativePath;
		}

		internal bool A(string P_0)
		{
			return Path.GetFileName(P_0).StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sa(), (StringComparison)5);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct B
	{
		public long needed;
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string projectRoot;

		internal string A(string P_0)
		{
			return Path.Combine(projectRoot, P_0);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public string relativePath;

		internal bool A(BackupEntry P_0)
		{
			return string.Equals(P_0.RelativePath, relativePath, (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public string target;

		internal void A()
		{
			DeletingWhatWillNotDelete.Delete(target);
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public string backupFile;

		public string target;

		internal void A()
		{
			File.Copy(backupFile, target, true);
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public System.Collections.Generic.IReadOnlyCollection<string> relativePaths;

		internal bool A(BackupEntry P_0)
		{
			return Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)relativePaths, P_0.RelativePath, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public BackupEntry entry;

		internal bool A(BackupEntry P_0)
		{
			return string.Equals(P_0.RelativePath, entry.RelativePath, (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class e
	{
		public System.Collections.Generic.IReadOnlyCollection<string> relativePaths;

		internal bool A(BackupEntry P_0)
		{
			return !Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)relativePaths, P_0.RelativePath, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		}
	}

	private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
	{
		WriteIndented = true
	};

	private const int SharingViolation = -2147024864;

	private const int LockViolation = -2147024863;

	private static readonly TimeSpan[] WaitsWhileHeld = (TimeSpan[])(object)new TimeSpan[2]
	{
		TimeSpan.FromSeconds(1.0),
		TimeSpan.FromSeconds(3.0)
	};

	private static readonly ConcurrentDictionary<string, BackupManifest> WrittenInThisRun = new ConcurrentDictionary<string, BackupManifest>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);

	[field: CompilerGenerated]
	public static Func<string, long?> FreeSpaceOn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = A;


	public static Func<string, long?> DefaultFreeSpaceOn => A;

	[field: CompilerGenerated]
	public static Action<string, string> CopyOneFile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = A;


	public static Action<string, string> DefaultCopyOneFile => A;

	private static void A(string P_0, string P_1)
	{
		File.Copy(P_0, P_1, true);
	}

	private static long? A(string P_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string pathRoot = Path.GetPathRoot(Path.GetFullPath(P_0));
			return (pathRoot != null && pathRoot.Length > 0) ? new long?(new DriveInfo(pathRoot).AvailableFreeSpace) : null;
		}
		catch (System.Exception ex) when (((ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return null;
		}
	}

	private static void A(string P_0, System.Collections.Generic.IReadOnlyList<string> P_1, string P_2)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		B b = default(B);
		b.needed = 0L;
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)P_1).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				b.needed += new FileInfo(current).Length;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (b.needed != 0L)
		{
			A(P_2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Li(), ref b);
			A(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LJ(), ref b);
		}
	}

	private static void A(System.Collections.Generic.IReadOnlyList<string> P_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)P_0).GetEnumerator();
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					FileStream val = new FileStream(current, (FileMode)3, (FileAccess)3, (FileShare)0);
					try
					{
					}
					finally
					{
						((System.IDisposable)val)?.Dispose();
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = ((obj is IOException) ? obj : null);
					return obj2 != null && (uint)(((System.Exception)obj2).HResult - -2147024864) <= 1u;
				}).Invoke())
				{
					throw new AFileIsHeldOpenException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lj() + Path.GetFileName(current) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LK(), current);
				}
				catch (System.Exception ex) when (((ex is UnauthorizedAccessException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static string A(long P_0)
	{
		return Math.Max(1L, P_0 / 1048576).ToString((IFormatProvider)(object)CultureInfo.InvariantCulture);
	}

	public static BackupManifest Create(string projectRoot, System.Collections.Generic.IEnumerable<string> relativePaths, string backupDir, CancellationToken stopping = default(CancellationToken))
	{
		string projectRoot2 = projectRoot;
		Directory.CreateDirectory(backupDir);
		List<BackupEntry> val = new List<BackupEntry>();
		object obj = ((object)(relativePaths as System.Collections.Generic.IReadOnlyList<string>)) ?? ((object)Enumerable.ToList<string>(relativePaths));
		List<string> val2 = Enumerable.ToList<string>(Enumerable.Where<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)obj, (Func<string, string>)((string P_0) => Path.Combine(projectRoot2, P_0))), (Func<string, bool>)File.Exists));
		A(projectRoot2, (System.Collections.Generic.IReadOnlyList<string>)val2, backupDir);
		A((System.Collections.Generic.IReadOnlyList<string>)val2);
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)obj).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				((CancellationToken)(ref stopping)).ThrowIfCancellationRequested();
				string text = Path.Combine(projectRoot2, current);
				if (File.Exists(text))
				{
					string text2 = Path.Combine(backupDir, current);
					Directory.CreateDirectory(Path.GetDirectoryName(text2));
					val.Add(new BackupEntry
					{
						RelativePath = current,
						Kind = BackupEntryKind.Modified,
						Sha256 = A(text, text2, current)
					});
				}
				else
				{
					val.Add(new BackupEntry
					{
						RelativePath = current,
						Kind = BackupEntryKind.Added
					});
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		BackupManifest backupManifest = new BackupManifest
		{
			Entries = (System.Collections.Generic.IReadOnlyList<BackupEntry>)val
		};
		A(backupDir, backupManifest);
		return backupManifest;
	}

	public static void AlsoBackUp(string projectRoot, string relativePath, string backupDir)
	{
		string relativePath2 = relativePath;
		ArgumentNullException.ThrowIfNull((object)projectRoot, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lk());
		ArgumentNullException.ThrowIfNull((object)relativePath2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LL());
		BackupManifest backupManifest = LoadManifest(backupDir);
		if (Enumerable.Any<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)backupManifest.Entries, (Func<BackupEntry, bool>)((BackupEntry P_0) => string.Equals(P_0.RelativePath, relativePath2, (StringComparison)5))))
		{
			NothingIsWrittenUnbacked.AlsoBackedUp(relativePath2);
			return;
		}
		string text = Path.Combine(projectRoot, relativePath2);
		BackupEntry backupEntry = new BackupEntry
		{
			RelativePath = relativePath2,
			Kind = BackupEntryKind.Added
		};
		if (File.Exists(text))
		{
			string text2 = Path.Combine(backupDir, relativePath2);
			Directory.CreateDirectory(Path.GetDirectoryName(text2));
			backupEntry = new BackupEntry
			{
				RelativePath = relativePath2,
				Kind = BackupEntryKind.Modified,
				Sha256 = A(text, text2, relativePath2)
			};
		}
		BackupManifest backupManifest2 = new BackupManifest();
		BackupManifest backupManifest3 = backupManifest2;
		System.Collections.Generic.IReadOnlyList<BackupEntry> entries = backupManifest.Entries;
		int num = 0;
		BackupEntry[] array = new BackupEntry[1 + ((System.Collections.Generic.IReadOnlyCollection<BackupEntry>)entries).Count];
		System.Collections.Generic.IEnumerator<BackupEntry> enumerator = ((System.Collections.Generic.IEnumerable<BackupEntry>)entries).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				BackupEntry current = enumerator.Current;
				array[num] = current;
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		array[num] = backupEntry;
		num++;
		backupManifest3.Entries = new K<BackupEntry>(array);
		BackupManifest backupManifest4 = backupManifest2;
		A(backupDir, backupManifest4);
		NothingIsWrittenUnbacked.AlsoBackedUp(relativePath2);
	}

	public static void Restore(string backupDir, string projectRoot)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		BackupManifest backupManifest = LoadManifest(backupDir);
		System.Collections.Generic.IEnumerator<BackupEntry> enumerator = ((System.Collections.Generic.IEnumerable<BackupEntry>)backupManifest.Entries).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				BackupEntry current = enumerator.Current;
				string target = Path.Combine(projectRoot, current.RelativePath);
				if (current.Kind == BackupEntryKind.Added)
				{
					if (File.Exists(target))
					{
						A((Action)delegate
						{
							DeletingWhatWillNotDelete.Delete(target);
						});
					}
				}
				else if (!B(target, current.Sha256))
				{
					string text = Path.Combine(backupDir, current.RelativePath);
					Directory.CreateDirectory(Path.GetDirectoryName(target));
					a(text, target);
					string text2 = B(target);
					if (text2 != current.Sha256)
					{
						string relativePath = current.RelativePath;
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(59, 3);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ll());
						defaultInterpolatedStringHandler.AppendFormatted(current.RelativePath);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LM());
						defaultInterpolatedStringHandler.AppendFormatted(current.Sha256);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lm());
						defaultInterpolatedStringHandler.AppendFormatted(text2);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
						throw new BackupVerificationException(relativePath, defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		A(backupManifest, projectRoot);
	}

	private static void a(string P_0, string P_1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		string backupFile = P_0;
		string target = P_1;
		A((Action)delegate
		{
			File.Copy(backupFile, target, true);
		});
	}

	private static void A(Action P_0)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		while (true)
		{
			try
			{
				P_0.Invoke();
				break;
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				obj2 = ((obj is IOException) ? obj : null);
				return obj2 != null && (uint)(((System.Exception)obj2).HResult - -2147024864) <= 1u && num < WaitsWhileHeld.Length;
			}).Invoke())
			{
				Thread.Sleep(WaitsWhileHeld[num]);
			}
			num++;
		}
	}

	private static void A(BackupManifest P_0, string P_1)
	{
		string text = Path.GetFullPath(P_1).TrimEnd(Path.DirectorySeparatorChar);
		System.Collections.Generic.IEnumerator<BackupEntry> enumerator = Enumerable.Where<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)P_0.Entries, (Func<BackupEntry, bool>)((BackupEntry P_0) => P_0.Kind == BackupEntryKind.Added)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				BackupEntry current = enumerator.Current;
				for (string directoryName = Path.GetDirectoryName(Path.GetFullPath(Path.Combine(P_1, current.RelativePath))); directoryName != null && !string.Equals(directoryName.TrimEnd(Path.DirectorySeparatorChar), text, (StringComparison)5) && directoryName.StartsWith(text, (StringComparison)5); directoryName = Path.GetDirectoryName(directoryName))
				{
					try
					{
						if (Enumerable.Any<string>(Directory.EnumerateFileSystemEntries(directoryName)))
						{
							break;
						}
						Directory.Delete(directoryName);
						continue;
					}
					catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
					{
					}
					break;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static void HandOver(string fromBackupDir, string toBackupDir, System.Collections.Generic.IReadOnlyCollection<string> relativePaths)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IReadOnlyCollection<string> relativePaths2 = relativePaths;
		ArgumentNullException.ThrowIfNull((object)relativePaths2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LN());
		List<BackupEntry> val = Enumerable.ToList<BackupEntry>(Enumerable.Where<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)LoadManifest(fromBackupDir).Entries, (Func<BackupEntry, bool>)((BackupEntry P_0) => Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)relativePaths2, P_0.RelativePath, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))));
		if (val.Count == 0)
		{
			return;
		}
		Directory.CreateDirectory(toBackupDir);
		System.Collections.Generic.IReadOnlyList<BackupEntry> readOnlyList2;
		if (!File.Exists(Path.Combine(toBackupDir, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ln())))
		{
			System.Collections.Generic.IReadOnlyList<BackupEntry> readOnlyList = System.Array.Empty<BackupEntry>();
			readOnlyList2 = readOnlyList;
		}
		else
		{
			readOnlyList2 = LoadManifest(toBackupDir).Entries;
		}
		List<BackupEntry> val2 = Enumerable.ToList<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)readOnlyList2);
		Enumerator<BackupEntry> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				BackupEntry entry = enumerator.Current;
				if (!Enumerable.Any<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)val2, (Func<BackupEntry, bool>)((BackupEntry P_0) => string.Equals(P_0.RelativePath, entry.RelativePath, (StringComparison)5))))
				{
					if (entry.Kind == BackupEntryKind.Modified)
					{
						string text = Path.Combine(toBackupDir, entry.RelativePath);
						Directory.CreateDirectory(Path.GetDirectoryName(text));
						File.Copy(Path.Combine(fromBackupDir, entry.RelativePath), text, true);
					}
					val2.Add(entry);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		A(toBackupDir, new BackupManifest
		{
			Entries = (System.Collections.Generic.IReadOnlyList<BackupEntry>)val2
		});
		LeaveOut(fromBackupDir, (System.Collections.Generic.IReadOnlyCollection<string>)Enumerable.ToList<string>(Enumerable.Select<BackupEntry, string>((System.Collections.Generic.IEnumerable<BackupEntry>)val, (Func<BackupEntry, string>)((BackupEntry P_0) => P_0.RelativePath))));
	}

	public static void LeaveOut(string backupDir, System.Collections.Generic.IReadOnlyCollection<string> relativePaths)
	{
		System.Collections.Generic.IReadOnlyCollection<string> relativePaths2 = relativePaths;
		ArgumentNullException.ThrowIfNull((object)relativePaths2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LN());
		if (relativePaths2.Count != 0)
		{
			BackupManifest backupManifest = LoadManifest(backupDir);
			BackupManifest backupManifest2 = new BackupManifest();
			List<BackupEntry> obj = new List<BackupEntry>();
			obj.AddRange(Enumerable.Where<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)backupManifest.Entries, (Func<BackupEntry, bool>)((BackupEntry P_0) => !Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)relativePaths2, P_0.RelativePath, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))));
			backupManifest2.Entries = new k<BackupEntry>(obj);
			BackupManifest backupManifest3 = backupManifest2;
			A(backupDir, backupManifest3);
		}
	}

	private static void A(string P_0, BackupManifest P_1)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		string text = Path.Combine(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ln());
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
		defaultInterpolatedStringHandler.AppendFormatted(text);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
		defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LO());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lo());
		string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		FileStream val = new FileStream(text2, (FileMode)1, (FileAccess)2, (FileShare)0);
		try
		{
			JsonSerializer.Serialize((Stream)(object)val, P_1, I.Default.BackupManifest);
			val.Flush(true);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
		File.Move(text2, text, true);
		WrittenInThisRun[Path.GetFullPath(P_0)] = P_1;
	}

	public static BackupManifest LoadManifest(string backupDir)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		string text = Path.Combine(backupDir, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ln());
		if (!File.Exists(text) && Directory.Exists(backupDir))
		{
			string text2 = a(backupDir);
			BackupManifest result = default(BackupManifest);
			if (NothingIsWrittenUnbacked.IsArmed && WrittenInThisRun.TryGetValue(Path.GetFullPath(backupDir), ref result))
			{
				EngineNotes.Say(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LP() + text2);
				return result;
			}
			EngineNotes.Say(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lp() + text2);
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(26, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LQ());
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lq());
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			throw new FileNotFoundException(defaultInterpolatedStringHandler.ToStringAndClear(), text);
		}
		return JsonSerializer.Deserialize(File.ReadAllText(text), I.Default.BackupManifest) ?? throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LR() + text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lr());
	}

	private static string a(string P_0)
	{
		try
		{
			List<string> val = Enumerable.ToList<string>(Directory.EnumerateFiles(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (SearchOption)1));
			int num = Enumerable.Count<string>((System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => Path.GetFileName(P_0).StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sa(), (StringComparison)5)));
			return System.FormattableString.Invariant(FormattableStringFactory.Create(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LS(), new object[3]
			{
				val.Count,
				num,
				Directory.GetLastWriteTimeUtc(P_0)
			}));
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ls() + ex.Message;
		}
	}

	private static bool B(string P_0, string P_1)
	{
		try
		{
			return File.Exists(P_0) && B(P_0) == P_1;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	private static string A(string P_0, string P_1, string P_2)
	{
		CopyOneFile.Invoke(P_0, P_1);
		string text = B(P_0);
		if (!string.Equals(B(P_1), text, (StringComparison)4))
		{
			throw new ABackupCopyThatDiffersException(P_2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LT() + Path.GetFileName(P_0) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lt());
		}
		return text;
	}

	private static string B(string P_0)
	{
		FileStream val = File.OpenRead(P_0);
		try
		{
			return Convert.ToHexString(SHA256.HashData((Stream)(object)val));
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	[CompilerGenerated]
	internal static void A(string P_0, string P_1, ref B P_2)
	{
		long? num = FreeSpaceOn.Invoke(P_0);
		if (num.HasValue)
		{
			long valueOrDefault = num.GetValueOrDefault();
			if (valueOrDefault < P_2.needed)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(68, 3);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LU());
				defaultInterpolatedStringHandler.AppendFormatted(P_1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lu());
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LV());
				defaultInterpolatedStringHandler.AppendFormatted(A(P_2.needed));
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lv());
				defaultInterpolatedStringHandler.AppendFormatted(A(valueOrDefault));
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LW());
				throw new NotEnoughSpaceException(defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lw());
			}
		}
	}
}
