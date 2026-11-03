using System.IO;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Patching;

public sealed class AFileIsHeldOpenException : IOException
{
	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
	}

	public AFileIsHeldOpenException(string message, string path)
	{
		Path = path;
		((IOException)this)._002Ector(message);
	}
}
