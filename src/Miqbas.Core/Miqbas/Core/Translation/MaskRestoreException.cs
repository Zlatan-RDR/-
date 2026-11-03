using System;

namespace Miqbas.Core.Translation;

public sealed class MaskRestoreException : System.Exception
{
	public MaskRestoreException(string message)
		: base(message)
	{
	}
}
