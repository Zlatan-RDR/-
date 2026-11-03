using System.IO;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Patching;

public sealed class ABackupCopyThatDiffersException : IOException
{
	[field: CompilerGenerated]
	public string RelativePath
	{
		[CompilerGenerated]
		get;
	}

	public ABackupCopyThatDiffersException(string relativePath, string message)
	{
		RelativePath = relativePath;
		((IOException)this)._002Ector(message);
	}
}
