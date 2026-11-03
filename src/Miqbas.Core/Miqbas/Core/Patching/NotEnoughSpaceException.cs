using System.IO;

namespace Miqbas.Core.Patching;

public sealed class NotEnoughSpaceException : IOException
{
	public NotEnoughSpaceException(string message)
		: base(message)
	{
	}
}
