using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Core.IO;

namespace Miqbas.Engines.Unreal.Compression;

public sealed class OodleLibrary
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct A : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string cacheDirectory;

		public global::System.Collections.Generic.IEnumerable<string> searchRoots;

		public OodleLibrary _003C_003E4__this;

		public IProgress<DownloadProgress> progress;

		public CancellationToken cancellationToken;

		private TaskAwaiter<string> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OodleLibrary oodleLibrary = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<string>);
					num = (_003C_003E1__state = -1);
					goto IL_010c;
				}
				ArgumentException.ThrowIfNullOrWhiteSpace(cacheDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gx());
				string text = FindLocally(cacheDirectory, searchRoots);
				if (text == null)
				{
					Directory.CreateDirectory(cacheDirectory);
					awaiter = oodleLibrary._003Cdownloader_003EP.DownloadAsync(new DownloadRequest
					{
						Url = Release.Url,
						DestinationPath = Path.Combine(cacheDirectory, Release.ArchiveFileName),
						SizeBytes = Release.ArchiveSizeBytes,
						Sha256 = Release.ArchiveSha256,
						Subject = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hS()
					}, progress, cancellationToken).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, A>(ref awaiter, ref this);
						return;
					}
					goto IL_010c;
				}
				result = text;
				goto end_IL_000e;
				IL_010c:
				result = A(awaiter.GetResult(), cacheDirectory);
				end_IL_000e:;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			_003C_003Et__builder.SetStateMachine(P_0);
		}
	}

	[CompilerGenerated]
	private sealed class a : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string root;

		public string _003C_003E3__root;

		private string fileName;

		public string _003C_003E3__fileName;

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
		public a(int P_0)
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
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
				{
					_003C_003E1__state = -1;
					EnumerationOptions val = new EnumerationOptions
					{
						RecurseSubdirectories = true,
						IgnoreInaccessible = true,
						MatchCasing = (MatchCasing)2,
						AttributesToSkip = (FileAttributes)1024
					};
					global::System.Collections.Generic.IEnumerable<string> enumerable;
					try
					{
						enumerable = Directory.EnumerateFiles(root, fileName, val);
					}
					catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
					{
						return false;
					}
					_003C_003E7__wrap1 = enumerable.GetEnumerator();
					_003C_003E1__state = -3;
					break;
				}
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				if (((global::System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
				{
					string current = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 1;
					return true;
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
			a a;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				a = this;
			}
			else
			{
				a = new a(0);
			}
			a.root = _003C_003E3__root;
			a.fileName = _003C_003E3__fileName;
			return a;
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
	private VerifiedDownloader _003Cdownloader_003EP;

	public const string LibraryFileName = "oodle-data-shared.dll";

	private static readonly string[] MachineFileNames = new string[3]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hd(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HE(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gY()
	};

	public const string UnavailableMessage = "لم يستطع مقباس الحصول على ملف فك\u0651 الضغط الذي تحتاجه ألعاب Unreal لقراءة نصوصها. تأكد من اتصالك بالإنترنت وأعد المحاولة، أو ضع الملف «oodle-data-shared.dll» في مجلد أدوات مقباس بنفسك.";

	[field: CompilerGenerated]
	public static OodleRelease Release
	{
		[CompilerGenerated]
		get;
	} = new OodleRelease
	{
		Version = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ha(),
		Url = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HB(),
		ArchiveFileName = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hb(),
		ArchiveSizeBytes = 5286990L,
		ArchiveSha256 = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HC(),
		EntryInArchive = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hc(),
		LibrarySizeBytes = 998400L,
		LibrarySha256 = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HD()
	};


	public OodleLibrary(VerifiedDownloader downloader)
	{
		_003Cdownloader_003EP = downloader;
		base._002Ector();
	}

	public static string? FindLocally(string cacheDirectory, global::System.Collections.Generic.IEnumerable<string>? searchRoots = null)
	{
		ArgumentNullException.ThrowIfNull((object)cacheDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gx());
		string text = Path.Combine(cacheDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gY());
		if (File.Exists(text))
		{
			return text;
		}
		global::System.Collections.Generic.IEnumerator<string> enumerator = (searchRoots ?? global::System.Array.Empty<string>()).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (!Directory.Exists(current))
				{
					continue;
				}
				string[] machineFileNames = MachineFileNames;
				foreach (string text2 in machineFileNames)
				{
					string text3 = Enumerable.FirstOrDefault<string>(a(current, text2));
					if (text3 != null)
					{
						return text3;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	[AsyncStateMachine(typeof(A))]
	public async global::System.Threading.Tasks.Task<string> AcquireAsync(string cacheDirectory, global::System.Collections.Generic.IEnumerable<string>? searchRoots = null, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		ArgumentException.ThrowIfNullOrWhiteSpace(cacheDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gx());
		string text = FindLocally(cacheDirectory, searchRoots);
		if (text != null)
		{
			return text;
		}
		Directory.CreateDirectory(cacheDirectory);
		return A(await _003Cdownloader_003EP.DownloadAsync(new DownloadRequest
		{
			Url = Release.Url,
			DestinationPath = Path.Combine(cacheDirectory, Release.ArchiveFileName),
			SizeBytes = Release.ArchiveSizeBytes,
			Sha256 = Release.ArchiveSha256,
			Subject = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hS()
		}, progress, cancellationToken), cacheDirectory);
	}

	internal static string A(string P_0, string P_1)
	{
		string text = Path.Combine(P_1, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gY());
		ZipArchive val = ZipFile.OpenRead(P_0);
		try
		{
			ZipArchiveEntry obj = val.GetEntry(Release.EntryInArchive) ?? throw new DownloadFailedException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gy() + Release.EntryInArchive + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gZ());
			string text2 = text + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gz();
			ZipFileExtensions.ExtractToFile(obj, text2, true);
			if (!string.Equals(Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(text2))).ToLowerInvariant(), Release.LibrarySha256, (StringComparison)4))
			{
				File.Delete(text2);
				throw new DownloadFailedException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HA());
			}
			File.Move(text2, text, true);
			return text;
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	[IteratorStateMachine(typeof(a))]
	private static global::System.Collections.Generic.IEnumerable<string> a(string P_0, string P_1)
	{
		EnumerationOptions val = new EnumerationOptions
		{
			RecurseSubdirectories = true,
			IgnoreInaccessible = true,
			MatchCasing = (MatchCasing)2,
			AttributesToSkip = (FileAttributes)1024
		};
		global::System.Collections.Generic.IEnumerable<string> enumerable;
		try
		{
			enumerable = Directory.EnumerateFiles(P_0, P_1, val);
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			yield break;
		}
		global::System.Collections.Generic.IEnumerator<string> enumerator = enumerable.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				yield return enumerator.Current;
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}
}
