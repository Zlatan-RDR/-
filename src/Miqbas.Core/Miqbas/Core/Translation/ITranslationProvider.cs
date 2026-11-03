using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Miqbas.Core.Translation;

public interface ITranslationProvider
{
	string ProviderId { get; }

	string DisplayName { get; }

	bool FollowsInstructions => true;

	int InstantLanes => 1;

	System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<ModelInfo>> ListModelsAsync(CancellationToken cancellationToken = default(CancellationToken));

	System.Threading.Tasks.Task<IReadOnlyDictionary<int, string>> TranslateAsync(TranslationBatch batch, ModelInfo model, CancellationToken cancellationToken = default(CancellationToken));
}
