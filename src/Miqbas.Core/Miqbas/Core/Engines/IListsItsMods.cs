using System.Collections.Generic;

namespace Miqbas.Core.Engines;

public interface IListsItsMods
{
	System.Collections.Generic.IReadOnlyList<ListedMod> ListMods(string gameRoot);
}
