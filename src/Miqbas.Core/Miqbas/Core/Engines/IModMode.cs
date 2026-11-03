using System.Collections.Generic;
using Miqbas.Core.Patching;
using Miqbas.Core.Text;

namespace Miqbas.Core.Engines;

public interface IModMode
{
	ModPatchShape Shape => ModPatchShape.InsideTheMods;

	System.Collections.Generic.IReadOnlyList<SourceText> Extract();

	void Apply(PatchPlan plan, string backupDir);

	void Remove(string backupDir);
}
