using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public static class AnotherToolWasHere
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<FileInfo, System.DateTime> _003C_003E9__3_0;

		public static Func<IGrouping<System.DateTime, FileInfo>, System.DateTime> _003C_003E9__3_2;

		public static Func<string, bool> _003C_003E9__5_0;

		public static Func<string, string> _003C_003E9__7_0;

		internal System.DateTime A(FileInfo P_0)
		{
			return new System.DateTime(((FileSystemInfo)P_0).LastWriteTimeUtc.Year, ((FileSystemInfo)P_0).LastWriteTimeUtc.Month, ((FileSystemInfo)P_0).LastWriteTimeUtc.Day, ((FileSystemInfo)P_0).LastWriteTimeUtc.Hour, 0, 0, (DateTimeKind)1);
		}

		internal System.DateTime A(IGrouping<System.DateTime, FileInfo> P_0)
		{
			return P_0.Key;
		}

		internal bool A(string P_0)
		{
			return Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)WhereTheGameWrites, P_0, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		}

		internal string a(string P_0)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.w() + P_0;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public double enough;

		internal bool A(IGrouping<System.DateTime, FileInfo> P_0)
		{
			return (double)Enumerable.Count<FileInfo>((System.Collections.Generic.IEnumerable<FileInfo>)P_0) >= enough;
		}
	}

	public const string OurOwn = ".miqbas-original";

	private const double AShareThatMeansTheGameArrived = 0.05;

	private static readonly string[] WhereTheGameWrites = new string[6]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jx(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JY(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bL(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jy(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JZ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jz()
	};

	public static System.Collections.Generic.IReadOnlyList<string> LeftoversIn(string gameRoot)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(gameRoot) || !Directory.Exists(gameRoot))
		{
			return System.Array.Empty<string>();
		}
		try
		{
			List<FileInfo> val = Enumerable.ToList<FileInfo>(new DirectoryInfo(gameRoot).EnumerateFiles(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (SearchOption)1));
			if (val.Count == 0)
			{
				return System.Array.Empty<string>();
			}
			System.DateTime? dateTime = A((System.Collections.Generic.IReadOnlyList<FileInfo>)val);
			List<string> val2 = new List<string>();
			Enumerator<FileInfo> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					FileInfo current = enumerator.Current;
					if (((FileSystemInfo)current).Name.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JV(), (StringComparison)5) || !NotAGameFile.IsABackup(((FileSystemInfo)current).Name) || IsWhereTheGameWrites(Path.GetRelativePath(gameRoot, ((FileSystemInfo)current).FullName)))
					{
						continue;
					}
					if (dateTime.HasValue)
					{
						System.DateTime valueOrDefault = dateTime.GetValueOrDefault();
						if (((FileSystemInfo)current).LastWriteTimeUtc <= valueOrDefault)
						{
							continue;
						}
					}
					val2.Add(Path.GetRelativePath(gameRoot, ((FileSystemInfo)current).FullName));
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			return (System.Collections.Generic.IReadOnlyList<string>)val2;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return System.Array.Empty<string>();
		}
	}

	private static System.DateTime? A(System.Collections.Generic.IReadOnlyList<FileInfo> P_0)
	{
		double enough = (double)((System.Collections.Generic.IReadOnlyCollection<FileInfo>)P_0).Count * 0.05;
		List<System.DateTime> val = Enumerable.ToList<System.DateTime>(Enumerable.Select<IGrouping<System.DateTime, FileInfo>, System.DateTime>(Enumerable.Where<IGrouping<System.DateTime, FileInfo>>(Enumerable.GroupBy<FileInfo, System.DateTime>((System.Collections.Generic.IEnumerable<FileInfo>)P_0, (Func<FileInfo, System.DateTime>)((FileInfo P_0) => new System.DateTime(((FileSystemInfo)P_0).LastWriteTimeUtc.Year, ((FileSystemInfo)P_0).LastWriteTimeUtc.Month, ((FileSystemInfo)P_0).LastWriteTimeUtc.Day, ((FileSystemInfo)P_0).LastWriteTimeUtc.Hour, 0, 0, (DateTimeKind)1))), (Func<IGrouping<System.DateTime, FileInfo>, bool>)((IGrouping<System.DateTime, FileInfo> P_0) => (double)Enumerable.Count<FileInfo>((System.Collections.Generic.IEnumerable<FileInfo>)P_0) >= enough)), (Func<IGrouping<System.DateTime, FileInfo>, System.DateTime>)((IGrouping<System.DateTime, FileInfo> P_0) => P_0.Key)));
		if (val.Count != 0)
		{
			return Enumerable.Max<System.DateTime>((System.Collections.Generic.IEnumerable<System.DateTime>)val).AddHours(1.0);
		}
		return null;
	}

	public static bool IsWhereTheGameWrites(string relativePath)
	{
		return Enumerable.Any<string>(Enumerable.SkipLast<string>((System.Collections.Generic.IEnumerable<string>)relativePath.Split(new char[2] { '/', '\\' }, (StringSplitOptions)1), 1), (Func<string, bool>)((string P_0) => Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)WhereTheGameWrites, P_0, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase)));
	}

	public static bool Any(string gameRoot)
	{
		return ((System.Collections.Generic.IReadOnlyCollection<string>)LeftoversIn(gameRoot)).Count > 0;
	}

	public static string Message(string gameRoot)
	{
		System.Collections.Generic.IReadOnlyList<string> readOnlyList = LeftoversIn(gameRoot);
		string text = string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bk(), Enumerable.Select<string, string>(Enumerable.Take<string>((System.Collections.Generic.IEnumerable<string>)readOnlyList, 10), (Func<string, string>)((string P_0) => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.w() + P_0)));
		string text2;
		if (((System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count <= 10)
		{
			text2 = string.Empty;
		}
		else
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jv());
			defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count - 10);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JW());
			text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string text3 = text2;
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jw() + text + text3 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JX();
	}
}
