using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;
using Miqbas.Core.Engines;
using Miqbas.Core.Safety;
using Miqbas.Engines.Unreal.Detection;
using Miqbas.Engines.Unreal.Hooking;
using Miqbas.Engines.Unreal.Localization;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal;

public sealed class UnrealGameEngine : IGameEngine
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct A
	{
		public UnrealGameLayout layout;

		public UnrealGameEngine _003C_003E4__this;
	}

	private readonly UnrealEnvironment _environment = environment ?? new UnrealEnvironment();

	public string EngineId => _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.af();

	public string DisplayName => _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aG();

	public UnrealGameEngine(UnrealEnvironment? environment = null)
	{
	}

	public DetectionResult Detect(string gameRoot)
	{
		UnrealGameLayout unrealGameLayout = UnrealGameLayout.Read(gameRoot);
		if ((object)unrealGameLayout == null)
		{
			return DetectionResult.NoMatch;
		}
		return new DetectionResult
		{
			Matched = true,
			Confidence = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)unrealGameLayout.Packages).Count > 0) ? 1.0 : 0.4),
			EngineVersion = unrealGameLayout.EngineVersion(_environment.LocalAppData),
			Fingerprint = unrealGameLayout.Fingerprint(),
			GameName = unrealGameLayout.GameName()
		};
	}

	public ModeSupport<IFullMode> FullMode(string gameRoot)
	{
		UnrealGameLayout unrealGameLayout = UnrealGameLayout.Read(gameRoot);
		if ((object)unrealGameLayout == null)
		{
			return ModeSupport<IFullMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ag());
		}
		if (((global::System.Collections.Generic.IReadOnlyCollection<string>)unrealGameLayout.Packages).Count == 0 && !CookedTextRoad.Available(unrealGameLayout, _environment.PackageKeyFor?.Invoke(unrealGameLayout.GameRoot)))
		{
			return ModeSupport<IFullMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aH());
		}
		try
		{
			if (WhatOfThisGameCanBeRead.Of(unrealGameLayout, _environment.PackageKeyFor?.Invoke(gameRoot)).NothingOpens)
			{
				return ModeSupport<IFullMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ah());
			}
			if (!A(unrealGameLayout) && !CookedTextRoad.Available(unrealGameLayout, _environment.PackageKeyFor?.Invoke(unrealGameLayout.GameRoot)))
			{
				return ModeSupport<IFullMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aI());
			}
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			return ModeSupport<IFullMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ai());
		}
		return ModeSupport<IFullMode>.Of(new global::A.a(unrealGameLayout, _environment));
	}

	private bool A(UnrealGameLayout P_0)
	{
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)P_0.Packages).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					using PakArchive package = PakArchive.Open(current, _environment.PackageKeyFor?.Invoke(P_0.GameRoot));
					if (((global::System.Collections.Generic.IReadOnlyCollection<LocalizationTarget>)LocalizationTarget.FindIn(package, P_0.ProjectName)).Count > 0)
					{
						return true;
					}
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	public ModeSupport<IAdaptiveMode> AdaptiveMode(string gameRoot)
	{
		A a = default(A);
		a._003C_003E4__this = this;
		a.layout = UnrealGameLayout.Read(gameRoot);
		if ((object)a.layout == null)
		{
			return ModeSupport<IAdaptiveMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ag());
		}
		string executable = a.layout.Executable;
		string text = ((executable != null) ? Path.GetDirectoryName(executable) : null);
		if (text == null || !Directory.Exists(text))
		{
			return ModeSupport<IAdaptiveMode>.Unavailable(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aJ());
		}
		if (((global::System.Collections.Generic.IReadOnlyCollection<string>)a.layout.Packages).Count == 0)
		{
			return A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aj(), ref a);
		}
		string text2 = UnrealHook.WhyTheLoaderCannotWork(a.layout.EngineVersionAtLeast(_environment.LocalAppData));
		if (text2 != null)
		{
			return A(text2, ref a);
		}
		string text3 = UnrealHook.WhyTheLoaderCannotEnterAProtectedGame(ProtectionScanner.Scan(gameRoot).AnyAntiCheat);
		if (text3 != null)
		{
			return A(text3, ref a);
		}
		if (global::A.A.A(text) != null)
		{
			return A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aK(), ref a);
		}
		return ModeSupport<IAdaptiveMode>.Of(new global::A.A(a.layout, _environment));
	}

	[CompilerGenerated]
	private ModeSupport<IAdaptiveMode> A(string P_0, ref A P_1)
	{
		return ModeSupport<IAdaptiveMode>.Unavailable(P_0, new global::A.A(P_1.layout, _environment));
	}
}
