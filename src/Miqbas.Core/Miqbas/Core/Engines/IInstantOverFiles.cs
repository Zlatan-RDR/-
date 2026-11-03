using System.Collections.Generic;

namespace Miqbas.Core.Engines;

public interface IInstantOverFiles
{
	System.Collections.Generic.IReadOnlyList<string> ReadAsked();

	void PublishOne(string source, string translation);
}
