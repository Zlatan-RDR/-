using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Miqbas.Core.IO;

namespace Miqbas.Core.Engines;

public interface IAdaptiveMode
{
	AdaptiveRequirements Requirements { get; }

	bool IsInstalled { get; }

	bool AnythingOfOursIsHere => IsInstalled;

	string WorkDirectory { get; }

	bool RefreshLayerFiles()
	{
		return false;
	}

	string? WhyTheLayerIsNotRunning()
	{
		return null;
	}

	System.Threading.Tasks.Task InstallAsync(IReadOnlyDictionary<string, string> seedTranslations, string backupDir, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken));

	System.Collections.Generic.IReadOnlyList<string> ReadObserved();

	System.Collections.Generic.IReadOnlyList<string> ReadReported();

	void PublishTranslations(IReadOnlyDictionary<string, string> translations);

	void Uninstall(string backupDir);
}
