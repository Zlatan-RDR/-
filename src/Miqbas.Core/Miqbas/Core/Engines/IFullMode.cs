using System.Collections.Generic;
using System.Threading;
using Miqbas.Core.Patching;
using Miqbas.Core.Text;

namespace Miqbas.Core.Engines;

public interface IFullMode
{
	System.Collections.Generic.IReadOnlyList<SourceText> Extract();

	void Apply(PatchPlan plan, string backupDir, CancellationToken stopping = default(CancellationToken));

	void Remove(string backupDir);
}
