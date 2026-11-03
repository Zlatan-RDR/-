using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.IO;

public sealed class VerifiedDownloader
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct A : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public DownloadRequest request;

		public VerifiedDownloader _003C_003E4__this;

		public IProgress<DownloadProgress> progress;

		public CancellationToken cancellationToken;

		private string _003CpartialPath_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			VerifiedDownloader verifiedDownloader = _003C_003E4__this;
			string destinationPath;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_013a;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01e8;
				}
				if (!File.Exists(request.DestinationPath))
				{
					string directoryName = Path.GetDirectoryName(request.DestinationPath);
					if (!string.IsNullOrEmpty(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					_003CpartialPath_003E5__2 = request.DestinationPath + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sc();
					long num2 = (File.Exists(_003CpartialPath_003E5__2) ? new FileInfo(_003CpartialPath_003E5__2).Length : 0);
					if (num2 > request.SizeBytes)
					{
						File.Delete(_003CpartialPath_003E5__2);
						num2 = 0L;
					}
					if (num2 < request.SizeBytes)
					{
						awaiter = verifiedDownloader.A(request, _003CpartialPath_003E5__2, num2, progress, cancellationToken).GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, A>(ref awaiter, ref this);
							return;
						}
						goto IL_013a;
					}
					goto IL_0141;
				}
				destinationPath = request.DestinationPath;
				goto end_IL_000e;
				IL_013a:
				((TaskAwaiter)(ref awaiter)).GetResult();
				goto IL_0141;
				IL_01e8:
				((TaskAwaiter)(ref awaiter)).GetResult();
				File.Move(_003CpartialPath_003E5__2, request.DestinationPath, true);
				destinationPath = request.DestinationPath;
				goto end_IL_000e;
				IL_0141:
				progress?.Report(new DownloadProgress
				{
					BytesDownloaded = request.SizeBytes,
					TotalBytes = request.SizeBytes,
					IsVerifying = true
				});
				awaiter = A(request, _003CpartialPath_003E5__2, cancellationToken).GetAwaiter();
				if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, A>(ref awaiter, ref this);
					return;
				}
				goto IL_01e8;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CpartialPath_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CpartialPath_003E5__2 = null;
			_003C_003Et__builder.SetResult(destinationPath);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			_003C_003Et__builder.SetStateMachine(P_0);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct a : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DownloadRequest request;

		public long resumeFrom;

		public VerifiedDownloader _003C_003E4__this;

		public CancellationToken cancellationToken;

		public string partialPath;

		public IProgress<DownloadProgress> progress;

		private HttpRequestMessage _003Cmessage_003E5__2;

		private HttpResponseMessage _003Cresponse_003E5__3;

		private Stream _003Csource_003E5__4;

		private FileStream _003Cdestination_003E5__5;

		private byte[] _003Cbuffer_003E5__6;

		private long _003Cwritten_003E5__7;

		private Stopwatch _003CstartedAt_003E5__8;

		private long _003CbytesThisRun_003E5__9;

		private TimeSpan _003ClastReport_003E5__10;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private object _003C_003E7__wrap10;

		private int _003C_003E7__wrap11;

		private object _003C_003E7__wrap12;

		private int _003C_003E7__wrap13;

		private int _003C_003E7__wrap14;

		private System.Exception _003Ce_003E5__16;

		private int _003Cread_003E5__17;

		private ValueTaskAwaiter<int> _003C_003Eu__3;

		private ValueTaskAwaiter _003C_003Eu__4;

		private TaskAwaiter _003C_003Eu__5;

		private void MoveNext()
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0612: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_0788: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_079d: Unknown result type (might be due to invalid IL or missing references)
			//IL_079f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0595: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0565: Unknown result type (might be due to invalid IL or missing references)
			//IL_057a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_087b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Invalid comparison between Unknown and I4
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected I4, but got Unknown
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0700: Unknown result type (might be due to invalid IL or missing references)
			//IL_0708: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0651: Unknown result type (might be due to invalid IL or missing references)
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_065e: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_037e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Expected O, but got Unknown
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			VerifiedDownloader verifiedDownloader = _003C_003E4__this;
			try
			{
				if ((uint)num > 7u)
				{
					_003Cmessage_003E5__2 = new HttpRequestMessage(HttpMethod.Get, request.Url);
				}
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter;
					if (num != 0)
					{
						if ((uint)(num - 1) <= 6u)
						{
							goto IL_00eb;
						}
						if (resumeFrom > 0)
						{
							_003Cmessage_003E5__2.Headers.Range = new RangeHeaderValue((long?)resumeFrom, (long?)null);
						}
						awaiter = verifiedDownloader._003Chttp_003EP.SendAsync(_003Cmessage_003E5__2, (HttpCompletionOption)1, cancellationToken).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, a>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
						num = (_003C_003E1__state = -1);
					}
					HttpResponseMessage result = awaiter.GetResult();
					_003Cresponse_003E5__3 = result;
					goto IL_00eb;
					IL_00eb:
					try
					{
						TaskAwaiter<Stream> awaiter3;
						ValueTaskAwaiter awaiter2;
						Stream result4;
						object obj4;
						int result3;
						switch (num)
						{
						default:
							if (resumeFrom > 0 && (int)_003Cresponse_003E5__3.StatusCode != 206)
							{
								resumeFrom = 0L;
							}
							if (!_003Cresponse_003E5__3.IsSuccessStatusCode)
							{
								System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(62, 2);
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SD());
								defaultInterpolatedStringHandler.AppendFormatted(request.Subject);
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sd());
								defaultInterpolatedStringHandler.AppendFormatted<int>((int)_003Cresponse_003E5__3.StatusCode);
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SE());
								throw new DownloadFailedException(defaultInterpolatedStringHandler.ToStringAndClear())
								{
									WorthTryingAgain = A(_003Cresponse_003E5__3.StatusCode)
								};
							}
							awaiter3 = _003Cresponse_003E5__3.Content.ReadAsStreamAsync(cancellationToken).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, a>(ref awaiter3, ref this);
								return;
							}
							goto IL_021d;
						case 1:
							awaiter3 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<Stream>);
							num = (_003C_003E1__state = -1);
							goto IL_021d;
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							try
							{
								if ((uint)(num - 2) > 3u)
								{
									if (num == 6)
									{
										awaiter2 = _003C_003Eu__4;
										_003C_003Eu__4 = default(ValueTaskAwaiter);
										num = (_003C_003E1__state = -1);
										goto IL_0717;
									}
									FileStream val;
									IOException val2 = default(IOException);
									try
									{
										val = new FileStream(partialPath, (FileMode)((resumeFrom > 0) ? 6 : 2), (FileAccess)2, (FileShare)0, 1048576);
									}
									catch (object obj) when (((Func<bool>)delegate
									{
										// Could not convert BlockContainer to single expression
										object obj2 = ((obj is IOException) ? obj : null);
										System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
										if (obj2 == null)
										{
											result2 = 0;
										}
										else
										{
											val2 = (IOException)obj2;
											result2 = (AFileSomebodyElseIsHolding.IsOneOfTheCodes(((System.Exception)(object)val2).HResult) ? 1 : 0);
										}
										return (byte)result2 != 0;
									}).Invoke())
									{
										throw new DownloadFailedException(request.Subject + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Se(), (System.Exception?)(object)val2);
									}
									_003Cdestination_003E5__5 = val;
									_003C_003E7__wrap12 = null;
									_003C_003E7__wrap13 = 0;
								}
								try
								{
									TaskAwaiter awaiter4;
									switch (num)
									{
									default:
										_003Cbuffer_003E5__6 = new byte[1048576];
										_003Cwritten_003E5__7 = resumeFrom;
										_003CstartedAt_003E5__8 = Stopwatch.StartNew();
										_003CbytesThisRun_003E5__9 = 0L;
										_003ClastReport_003E5__10 = TimeSpan.Zero;
										_003C_003E7__wrap14 = 0;
										goto case 2;
									case 2:
									case 3:
										try
										{
											if (num != 2)
											{
												if (num != 3)
												{
													goto IL_0329;
												}
												awaiter2 = _003C_003Eu__4;
												_003C_003Eu__4 = default(ValueTaskAwaiter);
												num = (_003C_003E1__state = -1);
												goto IL_0433;
											}
											ValueTaskAwaiter<int> awaiter5 = _003C_003Eu__3;
											_003C_003Eu__3 = default(ValueTaskAwaiter<int>);
											num = (_003C_003E1__state = -1);
											goto IL_039a;
											IL_039a:
											result3 = awaiter5.GetResult();
											_003Cread_003E5__17 = result3;
											if (_003Cread_003E5__17 != 0)
											{
												awaiter2 = ((Stream)_003Cdestination_003E5__5).WriteAsync(System.Memory<byte>.op_Implicit(MemoryExtensions.AsMemory<byte>(_003Cbuffer_003E5__6, 0, _003Cread_003E5__17)), cancellationToken).GetAwaiter();
												if (!((ValueTaskAwaiter)(ref awaiter2)).IsCompleted)
												{
													num = (_003C_003E1__state = 3);
													_003C_003Eu__4 = awaiter2;
													((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter, a>(ref awaiter2, ref this);
													return;
												}
												goto IL_0433;
											}
											goto end_IL_031e;
											IL_0329:
											awaiter5 = _003Csource_003E5__4.ReadAsync(System.Memory<byte>.op_Implicit(_003Cbuffer_003E5__6), cancellationToken).GetAwaiter();
											if (!awaiter5.IsCompleted)
											{
												num = (_003C_003E1__state = 2);
												_003C_003Eu__3 = awaiter5;
												((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, a>(ref awaiter5, ref this);
												return;
											}
											goto IL_039a;
											IL_0433:
											((ValueTaskAwaiter)(ref awaiter2)).GetResult();
											_003Cwritten_003E5__7 += _003Cread_003E5__17;
											_003CbytesThisRun_003E5__9 += _003Cread_003E5__17;
											if (progress != null && _003CstartedAt_003E5__8.Elapsed - _003ClastReport_003E5__10 >= ProgressInterval)
											{
												_003ClastReport_003E5__10 = _003CstartedAt_003E5__8.Elapsed;
												progress.Report(A(_003Cwritten_003E5__7, request.SizeBytes, _003CbytesThisRun_003E5__9, _003CstartedAt_003E5__8.Elapsed));
											}
											goto IL_0329;
											end_IL_031e:;
										}
										catch (System.Exception ex) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											_003Ce_003E5__16 = ex;
											return ((_003Ce_003E5__16 is IOException || _003Ce_003E5__16 is HttpRequestException || _003Ce_003E5__16 is SocketException) ? 1 : 0) != 0;
										}).Invoke())
										{
											_003C_003E7__wrap14 = 1;
										}
										result3 = _003C_003E7__wrap14;
										if (result3 != 1)
										{
											_003Ce_003E5__16 = null;
											awaiter4 = ((Stream)_003Cdestination_003E5__5).FlushAsync(cancellationToken).GetAwaiter();
											if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
											{
												num = (_003C_003E1__state = 5);
												_003C_003Eu__5 = awaiter4;
												((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, a>(ref awaiter4, ref this);
												return;
											}
											break;
										}
										goto case 4;
									case 4:
										try
										{
											if (num != 4)
											{
												awaiter4 = ((Stream)_003Cdestination_003E5__5).FlushAsync(CancellationToken.None).GetAwaiter();
												if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
												{
													num = (_003C_003E1__state = 4);
													_003C_003Eu__5 = awaiter4;
													((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, a>(ref awaiter4, ref this);
													return;
												}
											}
											else
											{
												awaiter4 = _003C_003Eu__5;
												_003C_003Eu__5 = default(TaskAwaiter);
												num = (_003C_003E1__state = -1);
											}
											((TaskAwaiter)(ref awaiter4)).GetResult();
										}
										catch (System.Exception ex2) when (((ex2 is ObjectDisposedException || ex2 is IOException) ? 1 : 0) != 0)
										{
										}
										throw new DownloadFailedException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SF(), _003Ce_003E5__16)
										{
											WorthTryingAgain = true
										};
									case 5:
										awaiter4 = _003C_003Eu__5;
										_003C_003Eu__5 = default(TaskAwaiter);
										num = (_003C_003E1__state = -1);
										break;
									}
									((TaskAwaiter)(ref awaiter4)).GetResult();
									if (_003Cwritten_003E5__7 < request.SizeBytes)
									{
										throw new DownloadFailedException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SF())
										{
											WorthTryingAgain = true
										};
									}
									_003C_003E7__wrap13 = 1;
								}
								catch (object obj3)
								{
									_003C_003E7__wrap12 = obj3;
								}
								if (_003Cdestination_003E5__5 != null)
								{
									awaiter2 = ((Stream)_003Cdestination_003E5__5).DisposeAsync().GetAwaiter();
									if (!((ValueTaskAwaiter)(ref awaiter2)).IsCompleted)
									{
										num = (_003C_003E1__state = 6);
										_003C_003Eu__4 = awaiter2;
										((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter, a>(ref awaiter2, ref this);
										return;
									}
									goto IL_0717;
								}
								goto IL_071e;
								IL_071e:
								obj4 = _003C_003E7__wrap12;
								if (obj4 != null)
								{
									ExceptionDispatchInfo.Capture((obj4 as System.Exception) ?? throw obj4).Throw();
								}
								result3 = _003C_003E7__wrap13;
								if (result3 != 1)
								{
									_003C_003E7__wrap12 = null;
								}
								else
								{
									_003C_003E7__wrap11 = 1;
								}
								goto end_IL_023d;
								IL_0717:
								((ValueTaskAwaiter)(ref awaiter2)).GetResult();
								goto IL_071e;
								end_IL_023d:;
							}
							catch (object obj3)
							{
								_003C_003E7__wrap10 = obj3;
							}
							if (_003Csource_003E5__4 == null)
							{
								break;
							}
							awaiter2 = _003Csource_003E5__4.DisposeAsync().GetAwaiter();
							if (!((ValueTaskAwaiter)(ref awaiter2)).IsCompleted)
							{
								num = (_003C_003E1__state = 7);
								_003C_003Eu__4 = awaiter2;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter, a>(ref awaiter2, ref this);
								return;
							}
							goto IL_07d4;
						case 7:
							{
								awaiter2 = _003C_003Eu__4;
								_003C_003Eu__4 = default(ValueTaskAwaiter);
								num = (_003C_003E1__state = -1);
								goto IL_07d4;
							}
							IL_07d4:
							((ValueTaskAwaiter)(ref awaiter2)).GetResult();
							break;
							IL_021d:
							result4 = awaiter3.GetResult();
							_003Csource_003E5__4 = result4;
							_003C_003E7__wrap10 = null;
							_003C_003E7__wrap11 = 0;
							goto case 2;
						}
						obj4 = _003C_003E7__wrap10;
						if (obj4 != null)
						{
							ExceptionDispatchInfo.Capture((obj4 as System.Exception) ?? throw obj4).Throw();
						}
						result3 = _003C_003E7__wrap11;
						if (result3 != 1)
						{
							_003C_003E7__wrap10 = null;
							goto IL_084b;
						}
					}
					finally
					{
						if (num < 0 && _003Cresponse_003E5__3 != null)
						{
							((System.IDisposable)_003Cresponse_003E5__3).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && _003Cmessage_003E5__2 != null)
					{
						((System.IDisposable)_003Cmessage_003E5__2).Dispose();
					}
				}
				goto end_IL_000e;
				IL_084b:
				_003Cmessage_003E5__2 = null;
				_003Cresponse_003E5__3 = null;
				_003Csource_003E5__4 = null;
				_003Cdestination_003E5__5 = null;
				_003Cbuffer_003E5__6 = null;
				_003CstartedAt_003E5__8 = null;
				_003ClastReport_003E5__10 = default(TimeSpan);
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cmessage_003E5__2 = null;
				_003Cresponse_003E5__3 = null;
				_003Csource_003E5__4 = null;
				_003Cdestination_003E5__5 = null;
				_003Cbuffer_003E5__6 = null;
				_003CstartedAt_003E5__8 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cmessage_003E5__2 = null;
			_003Cresponse_003E5__3 = null;
			_003Csource_003E5__4 = null;
			_003Cdestination_003E5__5 = null;
			_003Cbuffer_003E5__6 = null;
			_003CstartedAt_003E5__8 = null;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(P_0);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct B : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VerifiedDownloader _003C_003E4__this;

		public DownloadRequest request;

		public string partialPath;

		public long resumeFrom;

		public IProgress<DownloadProgress> progress;

		public CancellationToken cancellationToken;

		private int _003Cattempt_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			VerifiedDownloader verifiedDownloader = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0022;
				}
				if (num != 1)
				{
					_003Cattempt_003E5__2 = 0;
					goto IL_001f;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = (_003C_003E1__state = -1);
				goto IL_014b;
				IL_00db:
				int num2;
				if (num2 == 1)
				{
					awaiter = System.Threading.Tasks.Task.Delay(WaitsBetweenTries[_003Cattempt_003E5__2], cancellationToken).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, B>(ref awaiter, ref this);
						return;
					}
					goto IL_014b;
				}
				goto IL_019f;
				IL_014b:
				((TaskAwaiter)(ref awaiter)).GetResult();
				resumeFrom = (File.Exists(partialPath) ? new FileInfo(partialPath).Length : 0);
				if (resumeFrom > request.SizeBytes)
				{
					File.Delete(partialPath);
					resumeFrom = 0L;
				}
				goto IL_019f;
				IL_019f:
				_003Cattempt_003E5__2++;
				goto IL_001f;
				IL_001f:
				num2 = 0;
				goto IL_0022;
				IL_0022:
				try
				{
					if (num != 0)
					{
						awaiter = verifiedDownloader.a(request, partialPath, resumeFrom, progress, cancellationToken).GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, B>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					((TaskAwaiter)(ref awaiter)).GetResult();
				}
				catch (DownloadFailedException ex) when (ex.WorthTryingAgain && _003Cattempt_003E5__2 < WaitsBetweenTries.Length)
				{
					num2 = 1;
					goto IL_00db;
				}
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(P_0);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct b : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string path;

		public CancellationToken cancellationToken;

		public DownloadRequest request;

		private string _003Cactual_003E5__2;

		private FileStream _003Cstream_003E5__3;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private ValueTaskAwaiter<byte[]> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			try
			{
				ValueTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ValueTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0125;
					}
					_003Cstream_003E5__3 = File.OpenRead(path);
					_003C_003E7__wrap3 = null;
					_003C_003E7__wrap4 = 0;
				}
				try
				{
					ValueTaskAwaiter<byte[]> awaiter2;
					if (num != 0)
					{
						awaiter2 = SHA256.HashDataAsync((Stream)(object)_003Cstream_003E5__3, cancellationToken).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter<byte[]>, b>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(ValueTaskAwaiter<byte[]>);
						num = (_003C_003E1__state = -1);
					}
					byte[] result = awaiter2.GetResult();
					_003Cactual_003E5__2 = Convert.ToHexString(result).ToLowerInvariant();
				}
				catch (object obj)
				{
					_003C_003E7__wrap3 = obj;
				}
				if (_003Cstream_003E5__3 != null)
				{
					awaiter = ((Stream)_003Cstream_003E5__3).DisposeAsync().GetAwaiter();
					if (!((ValueTaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter, b>(ref awaiter, ref this);
						return;
					}
					goto IL_0125;
				}
				goto IL_012c;
				IL_0125:
				((ValueTaskAwaiter)(ref awaiter)).GetResult();
				goto IL_012c;
				IL_012c:
				object obj2 = _003C_003E7__wrap3;
				if (obj2 != null)
				{
					ExceptionDispatchInfo.Capture((obj2 as System.Exception) ?? throw obj2).Throw();
				}
				_003C_003E7__wrap3 = null;
				_003Cstream_003E5__3 = null;
				if (!string.Equals(_003Cactual_003E5__2, request.Sha256, (StringComparison)5))
				{
					File.Delete(path);
					throw new DownloadFailedException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sf());
				}
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cactual_003E5__2 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cactual_003E5__2 = null;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(P_0);
		}
	}

	[CompilerGenerated]
	private HttpClient _003Chttp_003EP;

	private const int SharingViolation = -2147024864;

	private const int LockViolation = -2147024863;

	public const string PartialSuffix = ".part";

	private static readonly TimeSpan ProgressInterval = TimeSpan.FromMilliseconds(250.0);

	private const string Interrupted = "انقطع التنزيل قبل أن يكتمل. تأكد من اتصالك واضغط «تنزيل» مرة أخرى وسي\u064fكمل من حيث توقف.";

	private static readonly TimeSpan[] WaitsBetweenTries = (TimeSpan[])(object)new TimeSpan[2]
	{
		TimeSpan.FromSeconds(2.0),
		TimeSpan.FromSeconds(5.0)
	};

	public VerifiedDownloader(HttpClient http)
	{
		_003Chttp_003EP = http;
		base._002Ector();
	}

	[AsyncStateMachine(typeof(A))]
	public async System.Threading.Tasks.Task<string> DownloadAsync(DownloadRequest request, IProgress<DownloadProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(request.DestinationPath))
		{
			return request.DestinationPath;
		}
		string directoryName = Path.GetDirectoryName(request.DestinationPath);
		if (!string.IsNullOrEmpty(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		string partialPath = request.DestinationPath + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sc();
		long num = (File.Exists(partialPath) ? new FileInfo(partialPath).Length : 0);
		if (num > request.SizeBytes)
		{
			File.Delete(partialPath);
			num = 0L;
		}
		if (num < request.SizeBytes)
		{
			await A(request, partialPath, num, progress, cancellationToken);
		}
		progress?.Report(new DownloadProgress
		{
			BytesDownloaded = request.SizeBytes,
			TotalBytes = request.SizeBytes,
			IsVerifying = true
		});
		await A(request, partialPath, cancellationToken);
		File.Move(partialPath, request.DestinationPath, true);
		return request.DestinationPath;
	}

	private static bool A(HttpStatusCode P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		bool flag = (int)P_0 >= 500;
		if (!flag)
		{
			bool flag2 = (((int)P_0 == 408 || (int)P_0 == 429) ? true : false);
			flag = flag2;
		}
		return flag;
	}

	[AsyncStateMachine(typeof(B))]
	private System.Threading.Tasks.Task A(DownloadRequest P_0, string P_1, long P_2, IProgress<DownloadProgress>? progress, CancellationToken P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		B b = default(B);
		b._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		b._003C_003E4__this = this;
		b.request = P_0;
		b.partialPath = P_1;
		b.resumeFrom = P_2;
		b.progress = progress;
		b.cancellationToken = P_4;
		b._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref b._003C_003Et__builder)).Start<B>(ref b);
		return ((AsyncTaskMethodBuilder)(ref b._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(a))]
	private System.Threading.Tasks.Task a(DownloadRequest P_0, string P_1, long P_2, IProgress<DownloadProgress>? progress, CancellationToken P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		a a = default(a);
		a._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		a._003C_003E4__this = this;
		a.request = P_0;
		a.partialPath = P_1;
		a.resumeFrom = P_2;
		a.progress = progress;
		a.cancellationToken = P_4;
		a._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref a._003C_003Et__builder)).Start<a>(ref a);
		return ((AsyncTaskMethodBuilder)(ref a._003C_003Et__builder)).Task;
	}

	private static DownloadProgress A(long P_0, long P_1, long P_2, TimeSpan P_3)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		double? megabytesPerSecond = null;
		TimeSpan? remaining = null;
		if (((TimeSpan)(ref P_3)).TotalSeconds >= 1.0 && P_2 > 0)
		{
			double num = (double)P_2 / ((TimeSpan)(ref P_3)).TotalSeconds;
			megabytesPerSecond = num / 1024.0 / 1024.0;
			long num2 = P_1 - P_0;
			if (num > 0.0)
			{
				remaining = TimeSpan.FromSeconds((double)num2 / num);
			}
		}
		return new DownloadProgress
		{
			BytesDownloaded = P_0,
			TotalBytes = P_1,
			MegabytesPerSecond = megabytesPerSecond,
			Remaining = remaining
		};
	}

	[AsyncStateMachine(typeof(b))]
	private static System.Threading.Tasks.Task A(DownloadRequest P_0, string P_1, CancellationToken P_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		b b = default(b);
		b._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		b.request = P_0;
		b.path = P_1;
		b.cancellationToken = P_2;
		b._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref b._003C_003Et__builder)).Start<b>(ref b);
		return ((AsyncTaskMethodBuilder)(ref b._003C_003Et__builder)).Task;
	}
}
