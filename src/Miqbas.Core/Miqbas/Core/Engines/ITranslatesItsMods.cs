using System.Collections.Generic;

namespace Miqbas.Core.Engines;

public interface ITranslatesItsMods
{
	ModeSupport<IModMode> ModMode(string gameRoot, System.Collections.Generic.IReadOnlyList<string> modFolders);
}
