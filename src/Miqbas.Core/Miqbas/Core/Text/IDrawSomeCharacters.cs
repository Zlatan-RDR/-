using System.Collections.Generic;

namespace Miqbas.Core.Text;

public interface IDrawSomeCharacters
{
	System.Collections.Generic.IReadOnlyCollection<int> Characters { get; }

	bool OutlinesAreReadable { get; }

	bool Has(int codepoint);

	int OutlineBytesOf(int codepoint);
}
