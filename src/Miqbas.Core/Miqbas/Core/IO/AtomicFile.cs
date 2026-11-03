using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Patching;

namespace Miqbas.Core.IO;

public static class AtomicFile
{
	[CompilerGenerated]
	private sealed class A
	{
		public string staged;

		public string path;

		internal void A()
		{
			File.Copy(staged, path, true);
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string staged;

		public string path;

		internal void A()
		{
			File.Move(staged, path, true);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string tempPath;

		public string path;

		internal void A()
		{
			File.Move(tempPath, path, true);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string tempPath;

		public string path;

		internal void A()
		{
			File.Move(tempPath, path, true);
		}
	}

	private static int _writes;

	private static readonly TimeSpan[] WaitsWhileHeld = (TimeSpan[])(object)new TimeSpan[3]
	{
		TimeSpan.FromMilliseconds(250.0),
		TimeSpan.FromMilliseconds(500.0),
		TimeSpan.FromMilliseconds(1000.0)
	};

	[field: CompilerGenerated]
	public static WriteFaults? Faults
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static int WritesSoFar => Volatile.Read(ref _writes);

	public static void CountFromZero()
	{
		Volatile.Write(ref _writes, 0);
	}

	public static void WriteAllText(string path, string contents)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		string path2 = path;
		NothingIsWrittenUnbacked.BeforeWriting(path2);
		a(path2);
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
		defaultInterpolatedStringHandler.AppendFormatted(path2);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
		defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LO());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lo());
		string tempPath = defaultInterpolatedStringHandler.ToStringAndClear();
		try
		{
			File.WriteAllText(tempPath, contents);
			A((Action)delegate
			{
				File.Move(tempPath, path2, true);
			});
		}
		catch
		{
			if (File.Exists(tempPath))
			{
				File.Delete(tempPath);
			}
			throw;
		}
	}

	public static void WriteAllBytes(string path, byte[] contents)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		string path2 = path;
		NothingIsWrittenUnbacked.BeforeWriting(path2);
		a(path2);
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
		defaultInterpolatedStringHandler.AppendFormatted(path2);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
		defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LO());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lo());
		string tempPath = defaultInterpolatedStringHandler.ToStringAndClear();
		try
		{
			File.WriteAllBytes(tempPath, contents);
			A((Action)delegate
			{
				File.Move(tempPath, path2, true);
			});
		}
		catch
		{
			if (File.Exists(tempPath))
			{
				File.Delete(tempPath);
			}
			throw;
		}
	}

	public static void CopyOver(string staged, string path)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string staged2 = staged;
		string path2 = path;
		NothingIsWrittenUnbacked.BeforeWriting(path2);
		A((Action)delegate
		{
			File.Copy(staged2, path2, true);
		});
	}

	public static void Replace(string staged, string path)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		string staged2 = staged;
		string path2 = path;
		NothingIsWrittenUnbacked.BeforeWriting(path2);
		a(path2);
		try
		{
			A((Action)delegate
			{
				File.Move(staged2, path2, true);
			});
		}
		catch
		{
			if (File.Exists(staged2))
			{
				File.Delete(staged2);
			}
			throw;
		}
	}

	private static void A(Action P_0)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		while (true)
		{
			try
			{
				P_0.Invoke();
				break;
			}
			catch (System.Exception ex) when (num < WaitsWhileHeld.Length && A(ex))
			{
				Thread.Sleep(WaitsWhileHeld[num]);
			}
			num++;
		}
	}

	private static bool A(System.Exception P_0)
	{
		if (!AFileSomebodyElseIsHolding.Is(P_0))
		{
			return P_0 is UnauthorizedAccessException;
		}
		return true;
	}

	public static int SweepWhatAKilledRunLeft(string gameRoot)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (!Directory.Exists(gameRoot))
		{
			return 0;
		}
		int num = 0;
		EnumerationOptions val = new EnumerationOptions
		{
			RecurseSubdirectories = true,
			IgnoreInaccessible = true,
			AttributesToSkip = (FileAttributes)1030
		};
		try
		{
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(gameRoot, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nc(), val).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					string text = A(current);
					if (text != null && File.Exists(text))
					{
						try
						{
							File.Delete(current);
							num++;
						}
						catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
						{
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		catch (System.Exception ex2) when (((ex2 is IOException || ex2 is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
		}
		return num;
	}

	private static string? A(string P_0)
	{
		string fileName = Path.GetFileName(P_0);
		int num = fileName.Length - EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lo().Length;
		if (num < 34 || fileName[num - 32 - 1] != '.')
		{
			return null;
		}
		for (int i = num - 32; i < num; i++)
		{
			bool flag;
			switch (fileName[i])
			{
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (!flag)
			{
				return null;
			}
		}
		return Path.Combine(Path.GetDirectoryName(P_0), fileName.Substring(0, num - 32 - 1));
	}

	private static void a(string P_0)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		WriteFaults faults = Faults;
		if ((object)faults != null && (faults.OnlyUnder.Length <= 0 || Path.GetFullPath(P_0).StartsWith(Path.GetFullPath(faults.OnlyUnder), (StringComparison)5)))
		{
			int num = Interlocked.Increment(ref _writes);
			if (faults.DelayEachWrite > TimeSpan.Zero)
			{
				Thread.Sleep(faults.DelayEachWrite);
			}
			if (faults.FailWriteNumber > 0 && num == faults.FailWriteNumber)
			{
				throw new IOException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ND() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LR(), -2147024784);
			}
		}
	}
}
