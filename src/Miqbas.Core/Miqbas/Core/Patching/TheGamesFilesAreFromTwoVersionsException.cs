using System;

namespace Miqbas.Core.Patching;

public sealed class TheGamesFilesAreFromTwoVersionsException : InvalidOperationException
{
	public TheGamesFilesAreFromTwoVersionsException(string message)
		: base(message)
	{
	}
}
