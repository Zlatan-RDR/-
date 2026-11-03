namespace Miqbas.Core.Engines;

public interface IGameEngine
{
	string EngineId { get; }

	string DisplayName { get; }

	DetectionResult Detect(string gameRoot);

	ModeSupport<IFullMode> FullMode(string gameRoot);

	ModeSupport<IAdaptiveMode> AdaptiveMode(string gameRoot);
}
