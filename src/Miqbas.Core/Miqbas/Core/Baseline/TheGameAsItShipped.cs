using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Patching;

namespace Miqbas.Core.Baseline;

public static class TheGameAsItShipped
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__3_0;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__3_1;

		public static Func<BackupEntry, string> _003C_003E9__3_3;

		public static Func<BackupEntry, bool> _003C_003E9__3_5;

		public static Func<BackupEntry, string> _003C_003E9__3_6;

		internal string A(KeyValuePair<string, string> P_0)
		{
			return TheGameAsItShipped.A(P_0.Key);
		}

		internal string a(KeyValuePair<string, string> P_0)
		{
			return P_0.Value;
		}

		internal string A(BackupEntry P_0)
		{
			return TheGameAsItShipped.A(P_0.RelativePath);
		}

		internal bool a(BackupEntry P_0)
		{
			return P_0.Kind == BackupEntryKind.Added;
		}

		internal string B(BackupEntry P_0)
		{
			return TheGameAsItShipped.A(P_0.RelativePath);
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string backupDir;

		public string readRoot;

		public Dictionary<string, string> ours;

		internal bool A(BackupEntry P_0)
		{
			if (P_0.Kind == BackupEntryKind.Modified && File.Exists(Path.Combine(backupDir, P_0.RelativePath)))
			{
				return TheGameAsItShipped.A(readRoot, TheGameAsItShipped.A(P_0.RelativePath), ours);
			}
			return false;
		}

		internal string a(BackupEntry P_0)
		{
			return Path.Combine(backupDir, P_0.RelativePath);
		}
	}

	public const double TaintedShare = 0.1;

	public const string SetAside = "ق\u064fرئت ترجمتنا لا اللعبة، ولا نسخة احتياطية لأصلها: تحتاج تنزيل\u064bا جديد\u064bا.";

	public static bool IsTainted(int lines, int? arabicLines)
	{
		if (lines > 0 && arabicLines.HasValue)
		{
			int valueOrDefault = arabicLines.GetValueOrDefault();
			return (double)valueOrDefault / (double)lines >= 0.1;
		}
		return false;
	}

	public static string? View(string readRoot, string backupDir, IReadOnlyDictionary<string, string>? written = null)
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		string backupDir2 = backupDir;
		string readRoot2 = readRoot;
		ArgumentNullException.ThrowIfNull((object)readRoot2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Re());
		ArgumentNullException.ThrowIfNull((object)backupDir2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RF());
		if (!Directory.Exists(readRoot2) || !File.Exists(Path.Combine(backupDir2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ln())))
		{
			return null;
		}
		BackupManifest backupManifest = FileBackup.LoadManifest(backupDir2);
		Dictionary<string, string> ours = ((written != null) ? Enumerable.ToDictionary<KeyValuePair<string, string>, string, string>((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)written, (Func<KeyValuePair<string, string>, string>)((KeyValuePair<string, string> P_0) => A(P_0.Key)), (Func<KeyValuePair<string, string>, string>)((KeyValuePair<string, string> P_0) => P_0.Value), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase) : null);
		Dictionary<string, string> val = Enumerable.ToDictionary<BackupEntry, string, string>(Enumerable.Where<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)backupManifest.Entries, (Func<BackupEntry, bool>)((BackupEntry P_0) => P_0.Kind == BackupEntryKind.Modified && File.Exists(Path.Combine(backupDir2, P_0.RelativePath)) && A(readRoot2, A(P_0.RelativePath), ours))), (Func<BackupEntry, string>)((BackupEntry P_0) => A(P_0.RelativePath)), (Func<BackupEntry, string>)((BackupEntry P_0) => Path.Combine(backupDir2, P_0.RelativePath)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		HashSet<string> val2 = Enumerable.ToHashSet<string>(Enumerable.Select<BackupEntry, string>(Enumerable.Where<BackupEntry>((System.Collections.Generic.IEnumerable<BackupEntry>)backupManifest.Entries, (Func<BackupEntry, bool>)((BackupEntry P_0) => P_0.Kind == BackupEntryKind.Added)), (Func<BackupEntry, string>)((BackupEntry P_0) => A(P_0.RelativePath))), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		if (val.Count == 0 && val2.Count == 0)
		{
			return null;
		}
		string pathRoot = Path.GetPathRoot(Path.GetFullPath(readRoot2));
		string text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rf();
		Guid val3 = Guid.NewGuid();
		string text2 = Path.Combine(pathRoot, text, ((Guid)(ref val3)).ToString(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LO()).Substring(0, 12));
		try
		{
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(readRoot2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (SearchOption)1).GetEnumerator();
			try
			{
				string text5 = default(string);
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					string text3 = A(Path.GetRelativePath(readRoot2, current));
					if (!val2.Contains(text3))
					{
						string text4 = Path.Combine(text2, text3);
						Directory.CreateDirectory(Path.GetDirectoryName(text4));
						if (val.Remove(text3, ref text5))
						{
							File.Copy(text5, text4);
						}
						else if (!A(text4, current))
						{
							Drop(text2);
							return null;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			Enumerator<string, string> enumerator2 = val.GetEnumerator();
			try
			{
				string text6 = default(string);
				string text7 = default(string);
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Deconstruct(ref text6, ref text7);
					string text8 = text6;
					string text9 = text7;
					string text10 = Path.Combine(text2, text8);
					Directory.CreateDirectory(Path.GetDirectoryName(text10));
					File.Copy(text9, text10);
				}
			}
			finally
			{
				((System.IDisposable)enumerator2).Dispose();
			}
			return text2;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			Drop(text2);
			return null;
		}
	}

	public static void Drop(string? view)
	{
		if (view == null || !Directory.Exists(view))
		{
			return;
		}
		try
		{
			Directory.Delete(view, true);
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
		}
	}

	private static bool A(string P_0, string P_1, Dictionary<string, string>? ours)
	{
		string text = default(string);
		if (ours == null || !ours.TryGetValue(P_1, ref text))
		{
			return true;
		}
		string text2 = Path.Combine(P_0, P_1);
		if (!File.Exists(text2))
		{
			return true;
		}
		FileStream val = File.OpenRead(text2);
		try
		{
			return string.Equals(Convert.ToHexString(SHA256.HashData((Stream)(object)val)), text, (StringComparison)5);
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static string A(string P_0)
	{
		return P_0.Replace('/', Path.DirectorySeparatorChar);
	}

	private static bool A(string P_0, string P_1)
	{
		if (OperatingSystem.IsWindows())
		{
			return A(P_0, P_1, System.IntPtr.Zero);
		}
		return false;
	}

	[DllImport("kernel32.dll", CharSet = 3, EntryPoint = "CreateHardLinkW", SetLastError = true)]
	private static extern bool A(string P_0, string P_1, nint P_2);
}
