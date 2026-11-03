using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using Miqbas.Core.Engines;
using Miqbas.Core.IO;
using Miqbas.Core.Runtime;
using Miqbas.Engines.Unity.Detection;
using Miqbas.Engines.Unity.Hooking;

namespace Miqbas.Engines.Unity;

public sealed class UnityAdaptiveMode : IAdaptiveMode
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct A : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UnityAdaptiveMode _003C_003E4__this;

		public IProgress<DownloadProgress> progress;

		public CancellationToken cancellationToken;

		public IReadOnlyDictionary<string, string> seedTranslations;

		public string backupDir;

		private bool _003CthereWasALoader_003E5__2;

		private UnityHook _003Chook_003E5__3;

		private TaskAwaiter<string> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UnityAdaptiveMode unityAdaptiveMode = _003C_003E4__this;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					_003CthereWasALoader_003E5__2 = UnityHook.IsInstalled(unityAdaptiveMode._003CgameRoot_003EP);
					_003Chook_003E5__3 = new UnityHook(new VerifiedDownloader(unityAdaptiveMode._003Cenvironment_003EP.Http));
					HookRelease release = ((unityAdaptiveMode._003Cbackend_003EP == ScriptingBackend.Il2Cpp) ? UnityHook.Il2CppReleaseForGame(unityAdaptiveMode._003CgameRoot_003EP) : UnityHook.MonoReleaseForGame(unityAdaptiveMode._003CgameRoot_003EP));
					awaiter = _003Chook_003E5__3.AcquireAsync(release, unityAdaptiveMode._003Cenvironment_003EP.HookCacheDirectory, progress, cancellationToken).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<string>, A>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<string>);
					num = (_003C_003E1__state = -1);
				}
				string result = awaiter.GetResult();
				_003Chook_003E5__3.Install(unityAdaptiveMode._003CgameRoot_003EP, result, new PluginPayload
				{
					PluginAssemblies = ((unityAdaptiveMode._003Cbackend_003EP == ScriptingBackend.Il2Cpp) ? unityAdaptiveMode._003Cenvironment_003EP.Il2CppPluginAssemblies.Invoke() : unityAdaptiveMode._003Cenvironment_003EP.PluginAssemblies.Invoke()),
					ArabicFontPath = unityAdaptiveMode._003Cenvironment_003EP.ArabicFontPath,
					Translations = seedTranslations
				});
				if (!_003CthereWasALoader_003E5__2)
				{
					UnityHook.NoteTheLoaderIsOursBeside(backupDir);
				}
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Chook_003E5__3 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Chook_003E5__3 = null;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(P_0);
		}
	}

	[CompilerGenerated]
	private string _003CgameRoot_003EP;

	[CompilerGenerated]
	private ScriptingBackend _003Cbackend_003EP;

	[CompilerGenerated]
	private UnityHookEnvironment _003Cenvironment_003EP;

	[field: CompilerGenerated]
	public AdaptiveRequirements Requirements
	{
		[CompilerGenerated]
		get;
	}

	public bool IsInstalled => UnityHook.IsInstalled(_003CgameRoot_003EP);

	public string WorkDirectory => UnityHook.WorkDirectoryIn(_003CgameRoot_003EP);

	public UnityAdaptiveMode(string gameRoot, ScriptingBackend backend, UnityHookEnvironment environment)
	{
		_003CgameRoot_003EP = gameRoot;
		_003Cbackend_003EP = backend;
		_003Cenvironment_003EP = environment;
		Requirements = new AdaptiveRequirements
		{
			NeedsInternetOnce = true,
			AppliesOnGameRestart = true,
			Note = ((_003Cbackend_003EP == ScriptingBackend.Il2Cpp) ? _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.K() : null)
		};
		base._002Ector();
	}

	[AsyncStateMachine(typeof(A))]
	public System.Threading.Tasks.Task InstallAsync(IReadOnlyDictionary<string, string> seedTranslations, string backupDir, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		A a = default(A);
		a._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		a._003C_003E4__this = this;
		a.seedTranslations = seedTranslations;
		a.backupDir = backupDir;
		a.progress = progress;
		a.cancellationToken = cancellationToken;
		a._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref a._003C_003Et__builder)).Start<A>(ref a);
		return ((AsyncTaskMethodBuilder)(ref a._003C_003Et__builder)).Task;
	}

	public bool RefreshLayerFiles()
	{
		if (!IsInstalled)
		{
			return false;
		}
		List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>((System.Collections.Generic.IEnumerable<string>)((_003Cbackend_003EP == ScriptingBackend.Il2Cpp) ? _003Cenvironment_003EP.Il2CppPluginAssemblies.Invoke() : _003Cenvironment_003EP.PluginAssemblies.Invoke()), (Func<string, bool>)([CompilerGenerated] (string P_0) =>
		{
			string text = UnityHook.WhereItGoes(_003CgameRoot_003EP, P_0);
			return File.Exists(P_0) && (!File.Exists(text) || !A(P_0, text));
		})));
		if (val.Count == 0)
		{
			return false;
		}
		try
		{
			UnityHook.RefreshMiqbasPluginFiles(_003CgameRoot_003EP, (System.Collections.Generic.IReadOnlyList<string>)val, _003Cenvironment_003EP.ArabicFontPath);
			return true;
		}
		catch (IOException)
		{
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
	}

	private static bool A(string P_0, string P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		FileInfo val = new FileInfo(P_0);
		FileInfo val2 = new FileInfo(P_1);
		if (val.Length == val2.Length)
		{
			return MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(File.ReadAllBytes(P_0)), System.ReadOnlySpan<byte>.op_Implicit(File.ReadAllBytes(P_1)));
		}
		return false;
	}

	public System.Collections.Generic.IReadOnlyList<string> ReadObserved()
	{
		return ObservedTextFile.ReadFrom(UnityHook.WorkDirectoryIn(_003CgameRoot_003EP))?.Strings ?? System.Array.Empty<string>();
	}

	public System.Collections.Generic.IReadOnlyList<string> ReadReported()
	{
		return ReportedTextFile.ReadFrom(UnityHook.WorkDirectoryIn(_003CgameRoot_003EP))?.Strings ?? System.Array.Empty<string>();
	}

	public void PublishTranslations(IReadOnlyDictionary<string, string> translations)
	{
		UnityHook.WriteTranslations(_003CgameRoot_003EP, translations);
	}

	public void Uninstall(string backupDir)
	{
		if (!UnityHook.TheLoaderIsOurs(_003CgameRoot_003EP, backupDir))
		{
			UnityHook.RemoveOnlyOurs(_003CgameRoot_003EP);
			return;
		}
		if (_003Cbackend_003EP == ScriptingBackend.Il2Cpp)
		{
			TheLoadersBuiltFiles.Keep(_003CgameRoot_003EP);
		}
		UnityHook.Remove(_003CgameRoot_003EP, (_003Cbackend_003EP == ScriptingBackend.Il2Cpp) ? UnityHook.Il2CppInstalledEntries : UnityHook.InstalledEntries);
		UnityHook.ForgetTheNoteBeside(backupDir);
	}

	[CompilerGenerated]
	private bool A(string P_0)
	{
		string text = UnityHook.WhereItGoes(_003CgameRoot_003EP, P_0);
		if (File.Exists(P_0))
		{
			if (File.Exists(text))
			{
				return !A(P_0, text);
			}
			return true;
		}
		return false;
	}
}
