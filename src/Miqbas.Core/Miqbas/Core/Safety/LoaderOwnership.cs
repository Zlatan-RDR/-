using System.IO;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public static class LoaderOwnership
{
	public const string NoteFileName = "loader-installed-by-miqbas";

	public static bool TheNoteIsBeside(string? backupDir)
	{
		if (backupDir != null && backupDir.Length > 0)
		{
			return File.Exists(Path.Combine(backupDir, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jA()));
		}
		return false;
	}
}
