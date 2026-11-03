using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using Miqbas.Core.Engines;
using Miqbas.Engines.Unity.Detection;

namespace Miqbas.Engines.Unity;

public sealed class UnityGameEngine : IGameEngine, ITranslatesItsMods
{
	[CompilerGenerated]
	private UnityHookEnvironment _003Cenvironment_003EP;

	public string EngineId => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.e();

	public string DisplayName => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.F();

	public UnityGameEngine(UnityHookEnvironment environment)
	{
		_003Cenvironment_003EP = environment;
		base._002Ector();
	}

	public DetectionResult Detect(string gameRoot)
	{
		UnityGameInfo unityGameInfo = UnityGameDetector.Inspect(gameRoot);
		if ((object)unityGameInfo == null)
		{
			return DetectionResult.NoMatch;
		}
		return new DetectionResult
		{
			Matched = true,
			Confidence = 1.0,
			EngineVersion = unityGameInfo.UnityVersion,
			Fingerprint = (unityGameInfo.BuildGuid ?? _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.f()),
			GameName = unityGameInfo.ProductName
		};
	}

	public ModeSupport<IFullMode> FullMode(string gameRoot)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.G());
	}

	internal System.Collections.Generic.IReadOnlyList<ValueTuple<string, IFullMode>> A(string P_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.G());
	}

	public ModeSupport<IModMode> ModMode(string gameRoot, System.Collections.Generic.IReadOnlyList<string> modFolders)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.g());
	}

	public ModeSupport<IAdaptiveMode> AdaptiveMode(string gameRoot)
	{
		UnityGameInfo unityGameInfo = UnityGameDetector.Inspect(gameRoot);
		if ((object)unityGameInfo == null)
		{
			return ModeSupport<IAdaptiveMode>.Unavailable(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.H());
		}
		if (unityGameInfo.Backend == ScriptingBackend.Il2Cpp && Il2CppMetadata.IsNewerThanTheLoaderReads(unityGameInfo.DataDirectory))
		{
			string text = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.h();
			string unityVersion = unityGameInfo.UnityVersion;
			return ModeSupport<IAdaptiveMode>.Unavailable(text + ((unityVersion != null && unityVersion.Length > 0) ? (_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.I() + unityVersion + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.i()) : _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.f()) + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.J(), new UnityAdaptiveMode(gameRoot, unityGameInfo.Backend, _003Cenvironment_003EP));
		}
		ScriptingBackend backend = unityGameInfo.Backend;
		if ((uint)(backend - 1) <= 1u)
		{
			return ModeSupport<IAdaptiveMode>.Of(new UnityAdaptiveMode(gameRoot, unityGameInfo.Backend, _003Cenvironment_003EP));
		}
		return ModeSupport<IAdaptiveMode>.Unavailable(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.j());
	}
}
