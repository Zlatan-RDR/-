using System;

namespace Miqbas.Core.Patching;

public sealed class ATranslationOnANameException : InvalidOperationException
{
	public ATranslationOnANameException(string message)
		: base(message)
	{
	}
}
