using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Core.Engines;
using Miqbas.Core.IO;
using Miqbas.Core.Patching;
using Miqbas.Core.Runtime;
using Miqbas.Core.Text;
using Miqbas.Engines.Unreal;
using Miqbas.Engines.Unreal.Detection;
using Miqbas.Engines.Unreal.Hooking;
using Miqbas.Engines.Unreal.Localization;
using Miqbas.Engines.Unreal.MeshText;
using Miqbas.Engines.Unreal.Packages;
using Miqbas.Rendering.Arabic.Shaping;

namespace A;

internal sealed class A : IAdaptiveMode, IInstantOverFiles
{
	[CompilerGenerated]
	private UnrealGameLayout _003Clayout_003EP;

	[CompilerGenerated]
	private UnrealEnvironment _003Cenvironment_003EP;

	public const string FontPackageFileName = "Miqbas_2_P.pak";

	private const string FontPackageBaseName = "Miqbas_2_P";

	public const string FontPackageContainerFileName = "Miqbas_2_P.utoc";

	public const string FontPackageStoreFileName = "Miqbas_2_P.ucas";

	private readonly string _binaries;

	[field: CompilerGenerated]
	public AdaptiveRequirements Requirements
	{
		[CompilerGenerated]
		get;
	}

	public bool IsInstalled => UnrealHook.IsInstalled(_binaries);

	public bool AnythingOfOursIsHere
	{
		get
		{
			if (!IsInstalled)
			{
				return UnrealHook.OurLoaderIsHere(_binaries);
			}
			return true;
		}
	}

	public string WorkDirectory => UnrealHook.WorkDirectoryIn(_binaries);

	public string FontPackageRelativePath => B(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.I());

	public global::System.Collections.Generic.IReadOnlyList<string> FontPackageRelativePaths => new d<string>(new string[3]
	{
		B(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.I()),
		B(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.i()),
		B(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.J())
	});

	public A(UnrealGameLayout P_0, UnrealEnvironment P_1)
	{
		_003Clayout_003EP = P_0;
		_003Cenvironment_003EP = P_1;
		_binaries = Path.GetDirectoryName(_003Clayout_003EP.Executable) ?? Path.Combine(_003Clayout_003EP.ProjectDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.A(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.a());
		Requirements = new AdaptiveRequirements
		{
			NeedsInternetOnce = false,
			AppliesOnGameRestart = false,
			Note = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.B()
		};
		base._002Ector();
	}

	public static string? A(string P_0)
	{
		if (UnrealHook.IsInstalled(P_0) || !UnrealHook.LoaderIsPresent(P_0))
		{
			return null;
		}
		return a(P_0);
	}

	public string? WhyTheLayerIsNotRunning()
	{
		if (!IsInstalled)
		{
			return null;
		}
		return a(_binaries);
	}

	private static string? a(string P_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		string text = Path.Combine(UnrealHook.LoaderDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.b());
		if (!File.Exists(text))
		{
			return null;
		}
		try
		{
			bool flag = Enumerable.Any<string>(Directory.EnumerateFiles(UnrealHook.LoaderDirectoryIn(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.C()));
			bool flag2 = global::System.DateTime.UtcNow - File.GetLastWriteTimeUtc(text) > TimeSpan.FromMinutes(3.0);
			return A(File.ReadAllText(text), flag, flag2);
		}
		catch
		{
			return null;
		}
	}

	public static string? A(string P_0, bool P_1 = false, bool P_2 = false)
	{
		if (P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.c(), (StringComparison)4))
		{
			return ((P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.D(), (StringComparison)4) || P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.d(), (StringComparison)4)) ? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.e() : _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.E()) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.F();
		}
		if (P_1)
		{
			return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.f();
		}
		bool num = P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.G(), (StringComparison)4);
		bool flag = P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.g(), (StringComparison)4) && P_0.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.H(), (StringComparison)4);
		if (num && !flag && P_2)
		{
			return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.h();
		}
		return null;
	}

	private string B(string P_0)
	{
		return Path.Combine(_003Clayout_003EP.ProjectName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.K(), P_0).Replace('\\', '/');
	}

	public global::System.Threading.Tasks.Task InstallAsync(IReadOnlyDictionary<string, string> seedTranslations, string backupDir, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		string text = UnrealHook.WhyTheLoaderCannotWork(_003Clayout_003EP.EngineVersionAtLeast(_003Cenvironment_003EP.LocalAppData));
		if (text != null)
		{
			throw new InvalidOperationException(text);
		}
		string loaderArchivePath = UnrealAssets.Require(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.k());
		string scriptPath = UnrealAssets.Require(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.L());
		List<string> relativePaths = Enumerable.ToList<string>(Enumerable.Concat<string>((global::System.Collections.Generic.IEnumerable<string>)UnrealHook.EditedFiles(_003Clayout_003EP.GameRoot, _binaries), (global::System.Collections.Generic.IEnumerable<string>)FontPackageRelativePaths));
		FileBackup.Create(_003Clayout_003EP.GameRoot, (global::System.Collections.Generic.IEnumerable<string>)relativePaths, backupDir);
		try
		{
			new UnrealHook().Install(_binaries, loaderArchivePath, scriptPath, new LayerPayload
			{
				Translations = seedTranslations
			});
			A();
		}
		catch
		{
			b(backupDir);
			throw;
		}
		return global::System.Threading.Tasks.Task.CompletedTask;
	}

	public global::System.Collections.Generic.IReadOnlyList<string> ReadObserved()
	{
		return ObservedTextFile.ReadFrom(WorkDirectory)?.Strings ?? global::System.Array.Empty<string>();
	}

	public global::System.Collections.Generic.IReadOnlyList<string> ReadReported()
	{
		return ReportedTextFile.ReadFrom(WorkDirectory)?.Strings ?? global::System.Array.Empty<string>();
	}

	public global::System.Collections.Generic.IReadOnlyList<string> ReadAsked()
	{
		return AskedTextFile.ReadFrom(WorkDirectory)?.Strings ?? global::System.Array.Empty<string>();
	}

	public void PublishTranslations(IReadOnlyDictionary<string, string> translations)
	{
		UnrealHook.WriteTranslations(_binaries, translations);
	}

	public void PublishOne(string source, string translation)
	{
		UnrealHook.AppendTranslation(_binaries, source, translation);
	}

	public void Uninstall(string backupDir)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		string text = UnrealHook.ModsListIn(_binaries);
		string text2 = ((UnrealHook.Remove(_binaries) && File.Exists(text)) ? File.ReadAllText(text) : null);
		if (File.Exists(Path.Combine(backupDir, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.l())))
		{
			FileBackup.Restore(backupDir, _003Clayout_003EP.GameRoot);
		}
		if (text2 != null)
		{
			File.WriteAllText(text, text2, (Encoding)new UTF8Encoding(false));
			return;
		}
		string[] array = new string[3]
		{
			_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.I(),
			_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.i(),
			_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.J()
		};
		foreach (string text3 in array)
		{
			string text4 = Path.Combine(_003Clayout_003EP.PaksDirectory, text3);
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
		}
	}

	private void A()
	{
		if (((global::System.Collections.Generic.IReadOnlyCollection<string>)_003Clayout_003EP.Packages).Count == 0)
		{
			return;
		}
		Dictionary<string, byte[]> val = new Dictionary<string, byte[]>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		int version;
		using (PakArchive pakArchive = PakArchive.OpenTheFirstThatOpens(global::A.a.A(_003Clayout_003EP.Packages)))
		{
			version = PakWriter.FormatFor(pakArchive.Version);
			if (global::A.b.A(pakArchive, _003Cenvironment_003EP.ArabicFontPath, val) == 0)
			{
				return;
			}
		}
		PakWriter.Write(Path.Combine(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.I()), _003Clayout_003EP.RootMountPoint, (IReadOnlyDictionary<string, byte[]>)(object)val, version);
		if (IoStoreWriter.GameUsesContainers(_003Clayout_003EP.PaksDirectory))
		{
			int? num = IoStoreWriter.GameContainerVersion(_003Clayout_003EP.PaksDirectory);
			if (num.HasValue)
			{
				int valueOrDefault = num.GetValueOrDefault();
				IoStoreWriter.Write(Path.Combine(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.i()), Path.Combine(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.J()), valueOrDefault);
			}
		}
	}

	private void b(string P_0)
	{
		try
		{
			Uninstall(P_0);
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException || ex is InvalidOperationException) ? 1 : 0) != 0)
		{
		}
	}
}
[RoadName("UnrealFullMode")]
internal sealed class a : IFullMode, IShipsItsOwnArabic, ICarriesAnArabicFace, ISaysWhatItCouldNotReach, ITellsHowToLaunchForArabic
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, bool> _003C0_003E__SpokenLine;

		public static Func<string, bool> _003C1_003E__IsDialocKey;

		public static Func<string, bool> _003C2_003E__IsMeshTextKey;

		public static Func<string, bool> _003C3_003E__IsASplitPart;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<ValueTuple<string, byte[]>, global::System.Collections.Generic.IEnumerable<SourceText>> _003C_003E9__21_0;

		public static Func<CookedText, SourceText> _003C_003E9__25_0;

		public static Func<MeshTextLine, SourceText> _003C_003E9__26_0;

		public static Func<string, string> _003C_003E9__28_0;

		public static Func<Translated, bool> _003C_003E9__34_0;

		public static Func<Translated, string> _003C_003E9__34_1;

		public static Func<Translated, string> _003C_003E9__34_2;

		public static Func<string, string> _003C_003E9__34_4;

		public static Func<Translated, bool> _003C_003E9__34_5;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__34_9;

		public static Func<Translated, bool> _003C_003E9__34_3;

		public static Func<PakEntry, bool> _003C_003E9__36_0;

		public static Func<string, bool> _003C_003E9__46_2;

		public static Func<string, bool> _003C_003E9__46_3;

		public static Func<char, bool> _003C_003E9__50_0;

		internal global::System.Collections.Generic.IEnumerable<SourceText> A(ValueTuple<string, byte[]> file)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return (global::System.Collections.Generic.IEnumerable<SourceText>)DialocDatabase.Read(file.Item2, file.Item1);
		}

		internal SourceText A(CookedText P_0)
		{
			return new SourceText
			{
				Key = CookedTextRoad.AddressOf(P_0.Namespace, P_0.Key),
				File = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.s(),
				Value = P_0.Source,
				TextType = global::A.a.A(P_0),
				Context = ((P_0.Namespace.Length > 0) ? P_0.Namespace : null)
			};
		}

		internal SourceText A(MeshTextLine P_0)
		{
			return new SourceText
			{
				Key = MeshTextRoad.KeyOf(P_0),
				File = P_0.Package,
				Value = P_0.Text.Replace('\r', ' ').Replace(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HJ(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.V()).Trim(),
				TextType = TextType.Dialogue
			};
		}

		internal string A(string P_0)
		{
			return P_0;
		}

		internal bool A(Translated P_0)
		{
			return !string.IsNullOrWhiteSpace(P_0.Value);
		}

		internal string a(Translated P_0)
		{
			return P_0.Source.Key;
		}

		internal string B(Translated P_0)
		{
			return P_0.Value;
		}

		internal string a(string P_0)
		{
			return ArabicVisualOrder.ToVisual(ArabicShaper.Shape(P_0));
		}

		internal bool b(Translated P_0)
		{
			return CookedTextRoad.IsCookedAddress(P_0.Source.Key);
		}

		internal string A(KeyValuePair<string, string> P_0)
		{
			return P_0.Value;
		}

		internal bool C(Translated P_0)
		{
			return LanguageColumnsAsset.IsLanguageColumnsKey(P_0.Source.Key);
		}

		internal bool A(PakEntry P_0)
		{
			return P_0.Path.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hj(), (StringComparison)5);
		}

		internal bool B(string P_0)
		{
			return !D(P_0);
		}

		internal bool b(string P_0)
		{
			return !c(P_0);
		}

		internal bool A(char P_0)
		{
			if (!Uri.IsHexDigit(P_0))
			{
				return P_0 == '-';
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public List<SourceText> tables;

		internal void A(string P_0, IoStoreChunk P_1, byte[] P_2)
		{
			tables.AddRange(global::A.a.A(P_0, P_1, P_2));
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public PakArchive package;
	}

	[CompilerGenerated]
	private sealed class C
	{
		public LocalizationTarget target;

		public string slot;

		public b CS_0024_003C_003E8__locals1;

		public Func<string, bool> _003C_003E9__6;

		internal bool A(string P_0)
		{
			if (P_0 != slot && a(P_0))
			{
				return CS_0024_003C_003E8__locals1.package.CanRead(target.TablesByCulture[P_0]);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public string prefix;

		internal bool A(KeyValuePair<string, string> P_0)
		{
			return P_0.Key.StartsWith(prefix, (StringComparison)4);
		}

		internal string a(KeyValuePair<string, string> P_0)
		{
			string key = P_0.Key;
			int length = prefix.Length;
			return key.Substring(length, key.Length - length);
		}
	}

	[CompilerGenerated]
	private sealed class D : global::System.Collections.Generic.IEnumerable<PakArchive>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<PakArchive>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private PakArchive _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public global::A.a _003C_003E4__this;

		private byte[] _003Ckey_003E5__2;

		private global::System.Collections.Generic.IEnumerator<string> _003C_003E7__wrap2;

		PakArchive global::System.Collections.Generic.IEnumerator<PakArchive>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public D(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				global::A.a a2 = _003C_003E4__this;
				switch (num)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003Ckey_003E5__2 = a2._003Cenvironment_003EP.PackageKeyFor?.Invoke(a2._003Clayout_003EP.GameRoot);
					_003C_003E7__wrap2 = ((global::System.Collections.Generic.IEnumerable<string>)a2._003Clayout_003EP.Packages).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (((global::System.Collections.IEnumerator)_003C_003E7__wrap2).MoveNext())
				{
					string current = _003C_003E7__wrap2.Current;
					PakArchive pakArchive = null;
					try
					{
						pakArchive = PakArchive.Open(current, _003Ckey_003E5__2);
					}
					catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
					{
					}
					if (pakArchive != null)
					{
						_003C_003E2__current = pakArchive;
						_003C_003E1__state = 1;
						return true;
					}
				}
				a();
				_003C_003E7__wrap2 = null;
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap2 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap2).Dispose();
			}
		}

		[DebuggerHidden]
		private void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<PakArchive> b()
		{
			D result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new D(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		global::System.Collections.Generic.IEnumerator<PakArchive> global::System.Collections.Generic.IEnumerable<PakArchive>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator C()
		{
			return (global::System.Collections.IEnumerator)b();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}
	}

	[CompilerGenerated]
	private sealed class d : global::System.Collections.Generic.IEnumerable<SourceText>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<SourceText>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private SourceText _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private byte[] bytes;

		public byte[] _003C_003E3__bytes;

		private IoStoreChunk chunk;

		public IoStoreChunk _003C_003E3__chunk;

		private string container;

		public string _003C_003E3__container;

		private LanguageColumnsAsset.Table _003Ctable_003E5__2;

		private string _003Cname_003E5__3;

		private HashSet<string> _003Cseen_003E5__4;

		private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IReadOnlyList<LanguageColumnsAsset.Cell>> _003C_003E7__wrap4;

		SourceText global::System.Collections.Generic.IEnumerator<SourceText>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public d(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003Ctable_003E5__2 = LanguageColumnsAsset.Read(bytes);
					if ((object)_003Ctable_003E5__2 == null)
					{
						return false;
					}
					_003Cname_003E5__3 = LanguageColumnsAsset.ChunkName(chunk);
					_003Cseen_003E5__4 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					_003C_003E7__wrap4 = ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<LanguageColumnsAsset.Cell>>)_003Ctable_003E5__2.Rows).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (((global::System.Collections.IEnumerator)_003C_003E7__wrap4).MoveNext())
				{
					global::System.Collections.Generic.IReadOnlyList<LanguageColumnsAsset.Cell> current = _003C_003E7__wrap4.Current;
					string value = current[_003Ctable_003E5__2.English].Value;
					if (string.IsNullOrWhiteSpace(value) || !_003Cseen_003E5__4.Add(value))
					{
						continue;
					}
					string text = ((_003Ctable_003E5__2.English != 0) ? current[0].Value : null);
					SourceText obj = new SourceText
					{
						Key = LanguageColumnsAsset.KeyOf(_003Cname_003E5__3, value),
						File = Path.GetFileName(container) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p() + _003Cname_003E5__3,
						Value = value,
						TextType = UnrealTextKinds.Of(text ?? string.Empty, value)
					};
					object context;
					if (text != null)
					{
						int length = text.Length;
						if (length > 0 && length <= 40)
						{
							context = text;
							goto IL_0155;
						}
					}
					context = null;
					goto IL_0155;
					IL_0155:
					obj.Context = (string?)context;
					_003C_003E2__current = obj;
					_003C_003E1__state = 1;
					return true;
				}
				a();
				_003C_003E7__wrap4 = null;
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap4 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap4).Dispose();
			}
		}

		[DebuggerHidden]
		private void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<SourceText> b()
		{
			d d2;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				d2 = this;
			}
			else
			{
				d2 = new d(0);
			}
			d2.container = _003C_003E3__container;
			d2.chunk = _003C_003E3__chunk;
			d2.bytes = _003C_003E3__bytes;
			return d2;
		}

		global::System.Collections.Generic.IEnumerator<SourceText> global::System.Collections.Generic.IEnumerable<SourceText>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator C()
		{
			return (global::System.Collections.IEnumerator)b();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}
	}

	[CompilerGenerated]
	private sealed class E : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private global::System.Collections.Generic.IReadOnlyList<string> packages;

		public global::System.Collections.Generic.IReadOnlyList<string> _003C_003E3__packages;

		private global::System.Collections.Generic.IEnumerator<string> _003C_003E7__wrap1;

		string global::System.Collections.Generic.IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public E(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 2)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					if (((global::System.Collections.Generic.IReadOnlyCollection<string>)packages).Count == 0)
					{
						return false;
					}
					_003C_003E2__current = packages[0];
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = ((global::System.Collections.Generic.IEnumerable<string>)global::A.a.a(packages)).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 2:
					_003C_003E1__state = -3;
					break;
				}
				while (((global::System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
				{
					string current = _003C_003E7__wrap1.Current;
					if (!string.Equals(current, packages[0], (StringComparison)5))
					{
						_003C_003E2__current = current;
						_003C_003E1__state = 2;
						return true;
					}
				}
				a();
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap1).Dispose();
			}
		}

		[DebuggerHidden]
		private void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<string> b()
		{
			E e2;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				e2 = this;
			}
			else
			{
				e2 = new E(0);
			}
			e2.packages = _003C_003E3__packages;
			return e2;
		}

		global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator C()
		{
			return (global::System.Collections.IEnumerator)b();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}
	}

	[CompilerGenerated]
	private UnrealGameLayout _003Clayout_003EP;

	[CompilerGenerated]
	private UnrealEnvironment _003Cenvironment_003EP;

	private const string PatchBaseName = "Miqbas_1_P";

	public const string PatchFileName = "Miqbas_1_P.pak";

	public const string PatchContainerFileName = "Miqbas_1_P.utoc";

	public const string PatchStoreFileName = "Miqbas_1_P.ucas";

	private const int FirstFormatNeedingContainer = 12;

	private const string SignedPatchSuffix = "_ProductionMOD";

	public string PatchRelativePath => A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.M());

	private string PatchContainerRelativePath => A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.m());

	private string PatchStoreRelativePath => A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.N());

	public string? ArabicLaunchArgument
	{
		get
		{
			string text = A();
			if (text == null || !File.Exists(Path.Combine(_003Clayout_003EP.PaksDirectory, text + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.o())))
			{
				return null;
			}
			return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.P();
		}
	}

	public a(UnrealGameLayout P_0, UnrealEnvironment P_1)
	{
		_003Clayout_003EP = P_0;
		_003Cenvironment_003EP = P_1;
		base._002Ector();
	}

	private string A(string P_0)
	{
		return Path.Combine(_003Clayout_003EP.ProjectName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.K(), P_0).Replace('\\', '/');
	}

	internal string? A()
	{
		if (!Directory.Exists(_003Clayout_003EP.PaksDirectory))
		{
			return null;
		}
		global::System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.n()).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(enumerator.Current);
				if (File.Exists(Path.Combine(_003Clayout_003EP.PaksDirectory, fileNameWithoutExtension + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.O())))
				{
					return fileNameWithoutExtension;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	private string A(PatchPlan P_0)
	{
		if (P_0.UseSignedPakWorkaround && !IoStoreWriter.GameUsesContainers(_003Clayout_003EP.PaksDirectory))
		{
			string text = A();
			if (text != null)
			{
				return text + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.o();
			}
		}
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.M();
	}

	public global::System.Collections.Generic.IReadOnlyList<SourceText> Extract()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		List<SourceText> val = new List<SourceText>();
		IPakDecompressor pakDecompressor = _003Cenvironment_003EP.Decompressor?.Invoke();
		using (pakDecompressor as global::System.IDisposable)
		{
			List<LocalizationTarget> val2;
			using PakArchive pakArchive = A(out val2);
			if (val2.Count == 0)
			{
				List<SourceText> obj = new List<SourceText>();
				obj.AddRange((global::System.Collections.Generic.IEnumerable<SourceText>)a(pakDecompressor));
				obj.AddRange(A(pakDecompressor));
				obj.AddRange((global::System.Collections.Generic.IEnumerable<SourceText>)B(pakDecompressor));
				return new E<SourceText>(obj);
			}
			HashSet<string> val3 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
			int num = 0;
			Enumerator<LocalizationTarget> enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					LocalizationTarget current = enumerator.Current;
					string sourceCulture = current.SourceCulture;
					if (!pakArchive.CanRead(current.TablesByCulture[sourceCulture]))
					{
						continue;
					}
					LocResFile locResFile;
					try
					{
						locResFile = A(pakArchive, current.TablesByCulture[sourceCulture], pakDecompressor);
					}
					catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is EndOfStreamException || ex is IOException) ? 1 : 0) != 0)
					{
						num++;
						continue;
					}
					global::System.Collections.Generic.IEnumerator<LocResEntry> enumerator2 = ((global::System.Collections.Generic.IEnumerable<LocResEntry>)locResFile.Entries).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							LocResEntry current2 = enumerator2.Current;
							val3.Add(CookedTextRoad.AddressOf(current2.Namespace, current2.Key));
							if (!string.IsNullOrWhiteSpace(current2.Value))
							{
								val.Add(new SourceText
								{
									Key = current.Name + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p() + current2.Address,
									File = current.PathFor(sourceCulture),
									Value = current2.Value,
									TextType = a(current2),
									Context = A(current2)
								});
							}
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2)?.Dispose();
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			if (val.Count == 0 && num == val2.Count && num > 0)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(70, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Q());
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.q());
				throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			global::System.Collections.Generic.IEnumerator<SourceText> enumerator3 = ((global::System.Collections.Generic.IEnumerable<SourceText>)a(pakDecompressor)).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator3).MoveNext())
				{
					SourceText current3 = enumerator3.Current;
					if (!val3.Contains(current3.Key))
					{
						val.Add(current3);
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator3)?.Dispose();
			}
			val.AddRange(A(pakDecompressor));
			val.AddRange((global::System.Collections.Generic.IEnumerable<SourceText>)B(pakDecompressor));
			return (global::System.Collections.Generic.IReadOnlyList<SourceText>)val;
		}
	}

	private global::System.Collections.Generic.IEnumerable<SourceText> A(IPakDecompressor? decompressor)
	{
		return (global::System.Collections.Generic.IEnumerable<SourceText>)Enumerable.ToList<SourceText>(Enumerable.SelectMany<ValueTuple<string, byte[]>, SourceText>(DialocDatabase.FindIn((global::System.Collections.Generic.IEnumerable<string>)a(_003Clayout_003EP.Packages), _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot), decompressor), (Func<ValueTuple<string, byte[]>, global::System.Collections.Generic.IEnumerable<SourceText>>)((ValueTuple<string, byte[]> file) => (global::System.Collections.Generic.IEnumerable<SourceText>)DialocDatabase.Read(file.Item2, file.Item1))));
	}

	private void A(PakArchive P_0, PatchPlan P_1, IReadOnlyDictionary<string, string> P_2, IDictionary<string, byte[]> P_3)
	{
		if (!P_0.IndexEncrypted || ((global::System.Collections.Generic.IReadOnlyCollection<LocalizationTarget>)LocalizationTarget.FindIn(P_0, _003Clayout_003EP.ProjectName)).Count > 0)
		{
			return;
		}
		global::System.Collections.Generic.IReadOnlyList<ATargetFoundInTheBytes> readOnlyList = WhenTheIndexIsLocked.TargetsIn(_003Clayout_003EP.Packages[0]);
		if (((global::System.Collections.Generic.IReadOnlyCollection<ATargetFoundInTheBytes>)readOnlyList).Count == 0)
		{
			return;
		}
		List<CookedText> val = new List<CookedText>();
		global::System.Collections.Generic.IEnumerator<Translated> enumerator = ((global::System.Collections.Generic.IEnumerable<Translated>)P_1.Translations).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Translated current = enumerator.Current;
				if (CookedTextRoad.TryParseAddress(current.Source.Key, out string space, out string key))
				{
					val.Add(new CookedText(space, key, current.Source.Value, 0u));
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count == 0)
		{
			return;
		}
		byte[] array = CookedTextRoad.BuildTable(global::System.Array.Empty<LocResEntry>(), (global::System.Collections.Generic.IReadOnlyList<CookedText>)val, P_2);
		global::System.Collections.Generic.IEnumerator<ATargetFoundInTheBytes> enumerator2 = ((global::System.Collections.Generic.IEnumerable<ATargetFoundInTheBytes>)readOnlyList).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				ATargetFoundInTheBytes current2 = enumerator2.Current;
				if (!string.Equals(current2.Name, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.R(), (StringComparison)5))
				{
					string text = string.Join('/', new string[6]
					{
						_003Clayout_003EP.ProjectName,
						_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(),
						_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.r(),
						current2.Name,
						current2.Culture,
						current2.Name + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.S()
					});
					P_3[text] = array;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator2)?.Dispose();
		}
	}

	private void A(PakArchive P_0, IPakDecompressor? decompressor, PatchPlan P_2, IReadOnlyDictionary<string, string> P_3, IDictionary<string, byte[]> P_4)
	{
		List<CookedText> val = new List<CookedText>();
		global::System.Collections.Generic.IEnumerator<Translated> enumerator = ((global::System.Collections.Generic.IEnumerable<Translated>)P_2.Translations).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Translated current = enumerator.Current;
				if (CookedTextRoad.TryParseAddress(current.Source.Key, out string space, out string key))
				{
					val.Add(new CookedText(space, key, current.Source.Value, 0u));
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count == 0)
		{
			return;
		}
		global::System.Collections.Generic.IReadOnlyList<LocResEntry> readOnlyList = CookedTextRoad.ReadEngineTable(P_0, decompressor);
		if (((global::System.Collections.Generic.IReadOnlyCollection<LocResEntry>)readOnlyList).Count == 0)
		{
			global::System.Collections.Generic.IEnumerator<PakArchive> enumerator2 = B().GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					PakArchive current2 = enumerator2.Current;
					using (current2)
					{
						readOnlyList = CookedTextRoad.ReadEngineTable(current2, decompressor);
					}
					if (((global::System.Collections.Generic.IReadOnlyCollection<LocResEntry>)readOnlyList).Count > 0)
					{
						break;
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator2)?.Dispose();
			}
		}
		P_4[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.s()] = CookedTextRoad.BuildTable(readOnlyList, (global::System.Collections.Generic.IReadOnlyList<CookedText>)val, P_3);
	}

	internal static bool a(string P_0)
	{
		if (!P_0.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.T(), (StringComparison)5) && !P_0.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.t(), (StringComparison)5))
		{
			return P_0.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.U(), (StringComparison)5);
		}
		return true;
	}

	private global::System.Collections.Generic.IReadOnlyList<SourceText> a(IPakDecompressor? decompressor)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot);
		if (!CookedTextRoad.Available(_003Clayout_003EP, array))
		{
			return global::System.Array.Empty<SourceText>();
		}
		List<SourceText> tables = new List<SourceText>();
		UnrealGameLayout layout = _003Clayout_003EP;
		byte[] key = array;
		return (global::System.Collections.Generic.IReadOnlyList<SourceText>)Enumerable.ToList<SourceText>(Enumerable.Concat<SourceText>(Enumerable.Select<CookedText, SourceText>((global::System.Collections.Generic.IEnumerable<CookedText>)CookedTextRoad.Read(layout, decompressor, default(CancellationToken), delegate(string P_0, IoStoreChunk P_1, byte[] P_2)
		{
			tables.AddRange(A(P_0, P_1, P_2));
		}, key), (Func<CookedText, SourceText>)((CookedText P_0) => new SourceText
		{
			Key = CookedTextRoad.AddressOf(P_0.Namespace, P_0.Key),
			File = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.s(),
			Value = P_0.Source,
			TextType = A(P_0),
			Context = ((P_0.Namespace.Length > 0) ? P_0.Namespace : null)
		})), (global::System.Collections.Generic.IEnumerable<SourceText>)tables));
	}

	private global::System.Collections.Generic.IReadOnlyList<SourceText> B(IPakDecompressor? decompressor)
	{
		if (MeshTextRoad.Available(_003Clayout_003EP))
		{
			return (global::System.Collections.Generic.IReadOnlyList<SourceText>)Enumerable.ToList<SourceText>(Enumerable.Select<MeshTextLine, SourceText>((global::System.Collections.Generic.IEnumerable<MeshTextLine>)MeshTextRoad.Read(_003Clayout_003EP, decompressor), (Func<MeshTextLine, SourceText>)((MeshTextLine P_0) => new SourceText
			{
				Key = MeshTextRoad.KeyOf(P_0),
				File = P_0.Package,
				Value = P_0.Text.Replace('\r', ' ').Replace(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HJ(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.V()).Trim(),
				TextType = TextType.Dialogue
			})));
		}
		return (global::System.Collections.Generic.IReadOnlyList<SourceText>)new List<SourceText>();
	}

	[IteratorStateMachine(typeof(d))]
	private static global::System.Collections.Generic.IEnumerable<SourceText> A(string P_0, IoStoreChunk P_1, byte[] P_2)
	{
		LanguageColumnsAsset.Table table = LanguageColumnsAsset.Read(P_2);
		if ((object)table == null)
		{
			yield break;
		}
		string name = LanguageColumnsAsset.ChunkName(P_1);
		HashSet<string> seen = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IReadOnlyList<LanguageColumnsAsset.Cell>> enumerator = ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<LanguageColumnsAsset.Cell>>)table.Rows).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				global::System.Collections.Generic.IReadOnlyList<LanguageColumnsAsset.Cell> current = enumerator.Current;
				string value = current[table.English].Value;
				if (string.IsNullOrWhiteSpace(value) || !seen.Add(value))
				{
					continue;
				}
				string text = ((table.English != 0) ? current[0].Value : null);
				SourceText obj = new SourceText
				{
					Key = LanguageColumnsAsset.KeyOf(name, value),
					File = Path.GetFileName(P_0) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p() + name,
					Value = value,
					TextType = UnrealTextKinds.Of(text ?? string.Empty, value)
				};
				object context;
				if (text != null)
				{
					int length = text.Length;
					if (length > 0 && length <= 40)
					{
						context = text;
						goto IL_0155;
					}
				}
				context = null;
				goto IL_0155;
				IL_0155:
				obj.Context = (string?)context;
				yield return obj;
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private List<ValueTuple<IoStoreChunk, byte[]>> a(PatchPlan P_0)
	{
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, Dictionary<string, string>> val = new Dictionary<string, Dictionary<string, string>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		global::System.Collections.Generic.IEnumerator<Translated> enumerator = ((global::System.Collections.Generic.IEnumerable<Translated>)P_0.Translations).GetEnumerator();
		try
		{
			Dictionary<string, string> val2 = default(Dictionary<string, string>);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Translated current = enumerator.Current;
				if (string.IsNullOrWhiteSpace(current.Value))
				{
					continue;
				}
				string text = LanguageColumnsAsset.ChunkOf(current.Source.Key);
				if (text != null)
				{
					if (!val.TryGetValue(text, ref val2))
					{
						val2 = (val[text] = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal));
					}
					val2[current.Source.Value] = current.Value;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		List<ValueTuple<IoStoreChunk, byte[]>> val4 = new List<ValueTuple<IoStoreChunk, byte[]>>();
		if (val.Count == 0)
		{
			return val4;
		}
		IPakDecompressor pakDecompressor = _003Cenvironment_003EP.Decompressor?.Invoke();
		using (pakDecompressor as global::System.IDisposable)
		{
			global::System.Collections.Generic.IEnumerator<string> enumerator2 = ((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>((global::System.Collections.Generic.IEnumerable<string>)Directory.GetFiles(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u()), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase)).GetEnumerator();
			try
			{
				Dictionary<string, string> arabicByEnglish = default(Dictionary<string, string>);
				while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					string current2 = enumerator2.Current;
					if (Path.GetFileName(current2).Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.m(), (StringComparison)5))
					{
						continue;
					}
					IoStoreReader ioStoreReader;
					try
					{
						ioStoreReader = IoStoreReader.Open(current2, pakDecompressor, _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot));
					}
					catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
					{
						continue;
					}
					using (ioStoreReader)
					{
						global::System.Collections.Generic.IEnumerator<IoStoreChunk> enumerator3 = ((global::System.Collections.Generic.IEnumerable<IoStoreChunk>)ioStoreReader.Chunks).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator3).MoveNext())
							{
								IoStoreChunk current3 = enumerator3.Current;
								if (!val.TryGetValue(LanguageColumnsAsset.ChunkName(current3), ref arabicByEnglish))
								{
									continue;
								}
								byte[] array = ioStoreReader.Read(current3);
								if (array != null)
								{
									byte[] array2 = LanguageColumnsAsset.WithEnglish(array, (IReadOnlyDictionary<string, string>)(object)arabicByEnglish);
									if (array2 != null)
									{
										val4.Add(new ValueTuple<IoStoreChunk, byte[]>(current3, array2));
										val.Remove(LanguageColumnsAsset.ChunkName(current3));
									}
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator3)?.Dispose();
						}
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator2)?.Dispose();
			}
			return val4;
		}
	}

	private static TextType A(CookedText P_0)
	{
		return UnrealTextKinds.Of(P_0.Namespace + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.V() + P_0.Key, P_0.Source);
	}

	public IReadOnlyDictionary<string, string> OwnArabicPairs()
	{
		try
		{
			List<LocalizationTarget> val;
			using PakArchive package = A(out val);
			IPakDecompressor pakDecompressor = _003Cenvironment_003EP.Decompressor?.Invoke();
			using (pakDecompressor as global::System.IDisposable)
			{
				return ShippedArabicReader.Read(package, _003Clayout_003EP.ProjectName, pakDecompressor).Pairs;
			}
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			return (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>();
		}
	}

	public void Apply(PatchPlan plan, string backupDir, CancellationToken stopping = default(CancellationToken))
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)plan, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.v());
		Dictionary<string, byte[]> files = B(plan);
		int num = C();
		int? num2 = A(num);
		List<ValueTuple<IoStoreChunk, byte[]>> chunks = (List<ValueTuple<IoStoreChunk, byte[]>>)((!num2.HasValue) ? ((object)new List<ValueTuple<IoStoreChunk, byte[]>>()) : ((object)a(plan)));
		string text = A(plan);
		string[] relativePaths = (num2.HasValue ? new string[3] { PatchRelativePath, PatchContainerRelativePath, PatchStoreRelativePath } : new string[1] { A(text) });
		FileBackup.Create(_003Clayout_003EP.GameRoot, relativePaths, backupDir, stopping);
		try
		{
			((CancellationToken)(ref stopping)).ThrowIfCancellationRequested();
			PakWriter.Write(Path.Combine(_003Clayout_003EP.PaksDirectory, text), _003Clayout_003EP.RootMountPoint, (IReadOnlyDictionary<string, byte[]>)(object)files, PakWriter.FormatFor(num));
			if (num2.HasValue)
			{
				int valueOrDefault = num2.GetValueOrDefault();
				((CancellationToken)(ref stopping)).ThrowIfCancellationRequested();
				IoStoreWriter.Write(Path.Combine(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.m()), Path.Combine(_003Clayout_003EP.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.N()), valueOrDefault, (global::System.Collections.Generic.IReadOnlyList<ValueTuple<IoStoreChunk, byte[]>>)chunks);
			}
		}
		catch
		{
			FileBackup.Restore(backupDir, _003Clayout_003EP.GameRoot);
			throw;
		}
	}

	internal int? A(int P_0)
	{
		if (!IoStoreWriter.GameUsesContainers(_003Clayout_003EP.PaksDirectory))
		{
			return null;
		}
		return IoStoreWriter.GameContainerVersion(_003Clayout_003EP.PaksDirectory);
	}

	public void Remove(string backupDir)
	{
		FileBackup.Restore(backupDir, _003Clayout_003EP.GameRoot);
	}

	private Dictionary<string, byte[]> B(PatchPlan P_0)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, string> val = Enumerable.ToDictionary<Translated, string, string>(Enumerable.Where<Translated>((global::System.Collections.Generic.IEnumerable<Translated>)P_0.Translations, (Func<Translated, bool>)((Translated P_0) => !string.IsNullOrWhiteSpace(P_0.Value))), (Func<Translated, string>)((Translated P_0) => P_0.Source.Key), (Func<Translated, string>)((Translated P_0) => P_0.Value), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Dictionary<string, byte[]> val2 = new Dictionary<string, byte[]>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		if (a())
		{
			Enumerator<string> enumerator = Enumerable.ToList<string>(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)val.Keys, (Func<string, bool>)B)).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					val[current] = string.Join<string>('\n', Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)val[current].Split('\n', (StringSplitOptions)0), (Func<string, string>)((string P_0) => ArabicVisualOrder.ToVisual(ArabicShaper.Shape(P_0)))));
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}
		List<LocalizationTarget> val3;
		PakArchive package = A(out val3);
		try
		{
			IPakDecompressor pakDecompressor = _003Cenvironment_003EP.Decompressor?.Invoke();
			using (pakDecompressor as global::System.IDisposable)
			{
				if (Enumerable.Any<Translated>((global::System.Collections.Generic.IEnumerable<Translated>)P_0.Translations, (Func<Translated, bool>)((Translated P_0) => CookedTextRoad.IsCookedAddress(P_0.Source.Key))))
				{
					A(package, pakDecompressor, P_0, (IReadOnlyDictionary<string, string>)(object)val, (IDictionary<string, byte[]>)(object)val2);
					A(package, P_0, (IReadOnlyDictionary<string, string>)(object)val, (IDictionary<string, byte[]>)(object)val2);
				}
				Enumerator<LocalizationTarget> enumerator2 = val3.GetEnumerator();
				try
				{
					string text = default(string);
					while (enumerator2.MoveNext())
					{
						LocalizationTarget target = enumerator2.Current;
						if (!package.CanRead(target.TablesByCulture[target.SourceCulture]))
						{
							continue;
						}
						LocResFile locResFile = A(package, target.TablesByCulture[target.SourceCulture], pakDecompressor);
						Dictionary<string, string> val4 = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
						global::System.Collections.Generic.IEnumerator<LocResEntry> enumerator3 = ((global::System.Collections.Generic.IEnumerable<LocResEntry>)locResFile.Entries).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator3).MoveNext())
							{
								LocResEntry current2 = enumerator3.Current;
								if (val.TryGetValue(target.Name + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p() + current2.Address, ref text))
								{
									val4[current2.Address] = text;
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator3)?.Dispose();
						}
						if (val4.Count == 0)
						{
							continue;
						}
						byte[] array = locResFile.WithValues((IReadOnlyDictionary<string, string>)(object)val4).ToBytes();
						string slot = target.English;
						if (slot == null)
						{
							continue;
						}
						val2[_003Clayout_003EP.ContentPrefix + target.PathFor(slot)] = array;
						global::System.Collections.Generic.IEnumerator<string> enumerator4 = Enumerable.Where<string>(target.TablesByCulture.Keys, (Func<string, bool>)((string P_0) => P_0 != slot && a(P_0) && package.CanRead(target.TablesByCulture[P_0]))).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator4).MoveNext())
							{
								string current3 = enumerator4.Current;
								try
								{
									LocResFile locResFile2 = A(package, target.TablesByCulture[current3], pakDecompressor);
									val2[_003Clayout_003EP.ContentPrefix + target.PathFor(current3)] = locResFile2.WithValues((IReadOnlyDictionary<string, string>)(object)val4).ToBytes();
								}
								catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is EndOfStreamException || ex is IOException) ? 1 : 0) != 0)
								{
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator4)?.Dispose();
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator2).Dispose();
				}
				if (Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)val.Keys, (Func<string, bool>)DialocDatabase.IsDialocKey))
				{
					global::System.Collections.Generic.IEnumerator<ValueTuple<string, byte[]>> enumerator5 = DialocDatabase.FindIn((global::System.Collections.Generic.IEnumerable<string>)a(_003Clayout_003EP.Packages), _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot), pakDecompressor).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator5).MoveNext())
						{
							ValueTuple<string, byte[]> current4 = enumerator5.Current;
							string item = current4.Item1;
							byte[] item2 = current4.Item2;
							string prefix = DialocDatabase.KeyOf(item, string.Empty);
							Dictionary<string, string> val5 = Enumerable.ToDictionary<KeyValuePair<string, string>, string, string>(Enumerable.Where<KeyValuePair<string, string>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)val, (Func<KeyValuePair<string, string>, bool>)((KeyValuePair<string, string> P_0) => P_0.Key.StartsWith(prefix, (StringComparison)4))), (Func<KeyValuePair<string, string>, string>)delegate(KeyValuePair<string, string> P_0)
							{
								string key = P_0.Key;
								int length = prefix.Length;
								return key.Substring(length, key.Length - length);
							}, (Func<KeyValuePair<string, string>, string>)((KeyValuePair<string, string> P_0) => P_0.Value), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
							if (val5.Count > 0)
							{
								val2[item] = DialocDatabase.WithEnglish(item2, (IReadOnlyDictionary<string, string>)(object)val5, out var _);
							}
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator5)?.Dispose();
					}
				}
				FontPlan fonts = P_0.Fonts;
				if ((object)fonts != null)
				{
					A(package, val2, fonts);
					if (Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)val.Keys, (Func<string, bool>)MeshTextRoad.IsMeshTextKey))
					{
						Enumerator<string, byte[]> enumerator6 = MeshTextRoad.Write(_003Clayout_003EP, pakDecompressor, (IReadOnlyDictionary<string, string>)(object)val, fonts.BodyFontPath).GetEnumerator();
						try
						{
							string text2 = default(string);
							byte[] array2 = default(byte[]);
							while (enumerator6.MoveNext())
							{
								enumerator6.Current.Deconstruct(ref text2, ref array2);
								string text3 = text2;
								byte[] array3 = array2;
								val2[text3] = array3;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator6).Dispose();
						}
					}
				}
			}
		}
		finally
		{
			if (package != null)
			{
				((global::System.IDisposable)package).Dispose();
			}
		}
		if (val2.Count == 0)
		{
			if (!Enumerable.Any<Translated>((global::System.Collections.Generic.IEnumerable<Translated>)P_0.Translations, (Func<Translated, bool>)((Translated P_0) => LanguageColumnsAsset.IsLanguageColumnsKey(P_0.Source.Key))))
			{
				throw new InvalidOperationException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.W());
			}
			val2[_003Clayout_003EP.ContentPrefix + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.w()] = Encoding.UTF8.GetBytes(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.X());
		}
		return val2;
	}

	private void A(PakArchive P_0, Dictionary<string, byte[]> P_1, FontPlan P_2)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		global::A.b.A(P_0, P_2.BodyFontPath, P_1);
		global::System.Collections.Generic.IEnumerator<PakArchive> enumerator = B().GetEnumerator();
		try
		{
			string text2 = default(string);
			byte[] array = default(byte[]);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PakArchive current = enumerator.Current;
				using (current)
				{
					Dictionary<string, byte[]> val = new Dictionary<string, byte[]>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
					global::A.b.A(current, P_2.BodyFontPath, val);
					string text = b(current.MountPoint);
					Enumerator<string, byte[]> enumerator2 = val.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.Deconstruct(ref text2, ref array);
							string text3 = text2;
							byte[] array2 = array;
							P_1.TryAdd(text + text3, array2);
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private bool a()
	{
		global::System.Collections.Generic.IEnumerator<PakArchive> enumerator = B().GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PakArchive current = enumerator.Current;
				using (current)
				{
					if (Enumerable.Any<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)current.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hj(), (StringComparison)5))))
					{
						return true;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	internal static bool B(string P_0)
	{
		if (CookedTextRoad.TryParseAddress(P_0, out string _, out string key))
		{
			return Regex.IsMatch(key, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.x());
		}
		return false;
	}

	[IteratorStateMachine(typeof(D))]
	private global::System.Collections.Generic.IEnumerable<PakArchive> B()
	{
		byte[] key = _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot);
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)_003Clayout_003EP.Packages).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				PakArchive pakArchive = null;
				try
				{
					pakArchive = PakArchive.Open(current, key);
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
				}
				if (pakArchive != null)
				{
					yield return pakArchive;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	internal static string b(string P_0)
	{
		string text = P_0.Replace('\\', '/');
		while (text.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Y(), (StringComparison)4))
		{
			string text2 = text;
			text = text2.Substring(3, text2.Length - 3);
		}
		return text.TrimStart('/');
	}

	public string? WhatItCouldNotReach()
	{
		if (!WhatOfThisGameCanBeRead.Of(_003Clayout_003EP, _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot)).SomeIsLocked)
		{
			return null;
		}
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.y();
	}

	public bool AKeyWouldOpenMore()
	{
		return WhatOfThisGameCanBeRead.Of(_003Clayout_003EP, _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot)).AKeyWouldOpenMore;
	}

	public string? WhyArabicMayNotBeDrawable(string? fontPath)
	{
		if (string.IsNullOrEmpty(fontPath) || !File.Exists(fontPath))
		{
			return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Z();
		}
		try
		{
			byte[] key = _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot);
			int num = 0;
			global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)a(_003Clayout_003EP.Packages)).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					try
					{
						using PakArchive pakArchive = PakArchive.Open(current, key);
						num += global::A.b.A(pakArchive);
					}
					catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
					{
					}
					if (num > 0)
					{
						break;
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			return (num > 0) ? null : _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.z();
		}
		catch (global::System.Exception)
		{
			return null;
		}
	}

	private PakArchive b()
	{
		return PakArchive.OpenTheFirstThatOpens(A(_003Clayout_003EP.Packages), _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot));
	}

	[IteratorStateMachine(typeof(E))]
	internal static global::System.Collections.Generic.IEnumerable<string> A(global::System.Collections.Generic.IReadOnlyList<string> P_0)
	{
		if (((global::System.Collections.Generic.IReadOnlyCollection<string>)P_0).Count == 0)
		{
			yield break;
		}
		yield return P_0[0];
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)a(P_0)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (!string.Equals(current, P_0[0], (StringComparison)5))
				{
					yield return current;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private PakArchive A(out List<LocalizationTarget> P_0)
	{
		byte[] key = _003Cenvironment_003EP.PackageKeyFor?.Invoke(_003Clayout_003EP.GameRoot);
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)a(_003Clayout_003EP.Packages)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				PakArchive pakArchive;
				try
				{
					pakArchive = PakArchive.Open(current, key);
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					continue;
				}
				List<LocalizationTarget> val = Enumerable.ToList<LocalizationTarget>((global::System.Collections.Generic.IEnumerable<LocalizationTarget>)LocalizationTarget.FindIn(pakArchive, _003Clayout_003EP.ProjectName));
				if (val.Count > 0)
				{
					P_0 = val;
					return pakArchive;
				}
				pakArchive.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		P_0 = new List<LocalizationTarget>();
		return b();
	}

	internal static global::System.Collections.Generic.IReadOnlyList<string> a(global::System.Collections.Generic.IReadOnlyList<string> P_0)
	{
		ArgumentNullException.ThrowIfNull((object)P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aA());
		List<string> val = Enumerable.ToList<string>(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)P_0, (Func<string, bool>)((string P_0) => !D(P_0))));
		List<string> obj = new List<string>();
		obj.AddRange(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)((string P_0) => !c(P_0))));
		obj.AddRange(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, bool>)([CompilerGenerated] (string P_0) => Regex.IsMatch(Path.GetFileNameWithoutExtension(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ab(), (RegexOptions)1, TimeSpan.FromSeconds(1.0)))));
		return new E<string>(obj);
	}

	internal int C()
	{
		using PakArchive pakArchive = PakArchive.OpenTheFirstThatOpens(A(_003Clayout_003EP.Packages));
		return pakArchive.Version;
	}

	private static LocResFile A(PakArchive P_0, PakEntry P_1, IPakDecompressor? decompressor)
	{
		return PackagedTable.Read(P_0, P_1, decompressor);
	}

	private static string? A(LocResEntry P_0)
	{
		string text = C(P_0.Key);
		string @namespace = P_0.Namespace;
		if (@namespace == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa())
		{
			if (text == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa())
			{
				return null;
			}
			return text;
		}
		if (text == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa())
		{
			return @namespace;
		}
		return @namespace + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aB() + text;
	}

	private static string C(string P_0)
	{
		int length = P_0.Length;
		bool flag = ((length > 60 || length == 0) ? true : false);
		if (flag || Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => Uri.IsHexDigit(P_0) || P_0 == '-')))
		{
			return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa();
		}
		return P_0.Replace('_', ' ').Replace('.', ' ').Trim();
	}

	private static TextType a(LocResEntry P_0)
	{
		return UnrealTextKinds.Of(P_0.Namespace + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.V() + P_0.Key, P_0.Value);
	}

	private static bool A(string P_0, string P_1)
	{
		return P_0.Contains(P_1, (StringComparison)5);
	}

	[CompilerGenerated]
	internal static bool c(string P_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		return Regex.IsMatch(Path.GetFileNameWithoutExtension(P_0), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ab(), (RegexOptions)1, TimeSpan.FromSeconds(1.0));
	}

	[CompilerGenerated]
	internal static bool D(string P_0)
	{
		return Path.GetFileName(P_0).StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aC(), (StringComparison)5);
	}
}
