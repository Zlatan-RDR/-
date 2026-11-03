using System;

namespace Miqbas.Core.Translation;

public interface IAskedToWait
{
	TimeSpan RetryAfter { get; }

	string? ProviderSaid => null;
}
