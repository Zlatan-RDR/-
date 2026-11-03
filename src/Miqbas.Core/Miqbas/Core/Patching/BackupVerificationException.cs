using System;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Patching;

public sealed class BackupVerificationException : InvalidOperationException
{
	[field: CompilerGenerated]
	public string RelativePath
	{
		[CompilerGenerated]
		get;
	}

	public BackupVerificationException(string relativePath, string message)
	{
		RelativePath = relativePath;
		((InvalidOperationException)this)._002Ector(message);
	}
}
