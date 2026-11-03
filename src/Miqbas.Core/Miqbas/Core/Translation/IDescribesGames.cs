using System.Threading;
using System.Threading.Tasks;

namespace Miqbas.Core.Translation;

public interface IDescribesGames
{
	string? WhyTheLastWasNotDescribed => null;

	System.Threading.Tasks.Task<GameDescription?> DescribeAsync(string gameName, CancellationToken cancellationToken = default(CancellationToken));
}
