using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public static class NotAGameFile
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, bool> _003C_003E9__2_0;

		internal bool A(string P_0)
		{
			return !IsABackup(P_0);
		}
	}

	private static readonly string[] BackupSuffixes = new string[8]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JV(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ja(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jB(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jb(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jC(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jc(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jD(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jd()
	};

	public static bool IsABackup(string path)
	{
		if (string.IsNullOrWhiteSpace(path))
		{
			return false;
		}
		string text = Path.GetFileName(path.TrimEnd(new char[2] { '/', '\\' }));
		if (text.Length == 0)
		{
			text = path;
		}
		string[] backupSuffixes = BackupSuffixes;
		foreach (string text2 in backupSuffixes)
		{
			if (text.EndsWith(text2, (StringComparison)5))
			{
				return true;
			}
		}
		return false;
	}

	public static System.Collections.Generic.IEnumerable<string> TheGamesOwn(System.Collections.Generic.IEnumerable<string> paths)
	{
		return Enumerable.Where<string>(paths, (Func<string, bool>)((string P_0) => !IsABackup(P_0)));
	}
}
