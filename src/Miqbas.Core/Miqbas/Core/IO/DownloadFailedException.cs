using System;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.IO;

public sealed class DownloadFailedException : System.Exception
{
	[field: CompilerGenerated]
	public bool WorthTryingAgain
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public DownloadFailedException(string message, System.Exception? inner = null)
		: base(message, inner)
	{
	}
}
