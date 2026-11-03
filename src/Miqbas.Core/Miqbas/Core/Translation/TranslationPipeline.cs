using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

public sealed class TranslationPipeline
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, bool> _003C0_003E__IsAlreadyArabic;

		public static Func<char, bool> _003C1_003E__IsLetter;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<SourceText, string> _003C_003E9__46_0;

		public static Func<QualityIssue, string> _003C_003E9__55_7;

		public static Func<string, string> _003C_003E9__58_1;

		public static Func<SourceText, bool> _003C_003E9__61_0;

		public static Func<SourceText, string> _003C_003E9__61_1;

		public static Func<SourceText, string> _003C_003E9__61_4;

		public static Func<IGrouping<string, SourceText>, bool> _003C_003E9__61_2;

		public static Func<IGrouping<string, SourceText>, string> _003C_003E9__61_3;

		public static Func<QualityIssue, bool> _003C_003E9__66_0;

		public static Func<TranslationUnit, string> _003C_003E9__69_0;

		public static Func<string, string> _003C_003E9__74_1;

		public static Func<SourceText, int> _003C_003E9__83_0;

		internal string A(SourceText P_0)
		{
			return P_0.Value;
		}

		internal string A(QualityIssue P_0)
		{
			return P_0.Message;
		}

		internal string A(string P_0)
		{
			if (!ArabicScript.IsAlreadyArabic(P_0))
			{
				return P_0;
			}
			return StoryGods.Mend(P_0);
		}

		internal bool a(SourceText P_0)
		{
			if (TranslationPipeline.a(P_0.Value))
			{
				return ReadableKey.Of(P_0.Key) != null;
			}
			return false;
		}

		internal string B(SourceText P_0)
		{
			return P_0.Value;
		}

		internal bool A(IGrouping<string, SourceText> P_0)
		{
			return Enumerable.Any<string>(Enumerable.Skip<string>(Enumerable.Distinct<string>(Enumerable.Select<SourceText, string>((System.Collections.Generic.IEnumerable<SourceText>)P_0, (Func<SourceText, string>)((SourceText P_0) => P_0.Key)), (IEqualityComparer<string>)(object)StringComparer.Ordinal), 1));
		}

		internal string b(SourceText P_0)
		{
			return P_0.Key;
		}

		internal string a(IGrouping<string, SourceText> P_0)
		{
			return P_0.Key;
		}

		internal bool a(QualityIssue P_0)
		{
			return P_0.Kind == QualityIssueKind.Empty;
		}

		internal string A(TranslationUnit P_0)
		{
			return P_0.Masked.Masked;
		}

		internal string a(string P_0)
		{
			return P_0.Trim();
		}

		internal int C(SourceText P_0)
		{
			return P_0.Value.Length;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		[StructLayout(3)]
		private struct A : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>> _003C_003Et__builder;

			public B _003C_003E4__this;

			public System.Collections.Generic.IReadOnlyList<SourceText> chunk;

			private TaskAwaiter _003C_003Eu__1;

			private System.Collections.Generic.IReadOnlyList<SourceText> _003C_003E7__wrap1;

			private TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0065: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				//IL_0178: Unknown result type (might be due to invalid IL or missing references)
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0146: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_009d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				B CS_0024_003C_003E8__locals0 = _003C_003E4__this;
				ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>> result;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_007c;
						}
						awaiter = CS_0024_003C_003E8__locals0.gate.WaitAsync(CS_0024_003C_003E8__locals0.cancellationToken).GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, A>(ref awaiter, ref this);
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
					goto IL_007c;
					IL_007c:
					try
					{
						TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> awaiter2;
						if (num == 1)
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>>);
							num = (_003C_003E1__state = -1);
							goto IL_0194;
						}
						if (!CS_0024_003C_003E8__locals0._003C_003E4__this._providerRefusingEverything)
						{
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(27, 2);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rl());
							defaultInterpolatedStringHandler.AppendFormatted(TextCounts.AsObject(((System.Collections.Generic.IReadOnlyCollection<SourceText>)chunk).Count));
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rM());
							defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals0._003C_003E4__this._relay.Current.DisplayName);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Su());
							CS_0024_003C_003E8__locals0.A(defaultInterpolatedStringHandler.ToStringAndClear());
							_003C_003E7__wrap1 = chunk;
							awaiter2 = CS_0024_003C_003E8__locals0._003C_003E4__this.A(chunk, delegate(string P_0)
							{
								CS_0024_003C_003E8__locals0.progress?.Report(new TranslationProgress
								{
									Total = CS_0024_003C_003E8__locals0.pending.Count,
									Completed = CS_0024_003C_003E8__locals0.completedUnique,
									FromMemory = CS_0024_003C_003E8__locals0.answeredUpFront.Count,
									NeedsReview = CS_0024_003C_003E8__locals0.needsReview,
									NotReached = CS_0024_003C_003E8__locals0.notReached,
									Usage = TokenUsage.Of(CS_0024_003C_003E8__locals0._003C_003E4__this.provider).Since(CS_0024_003C_003E8__locals0.startingUsage),
									Note = P_0
								});
							}, CS_0024_003C_003E8__locals0.cancellationToken).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>>, A>(ref awaiter2, ref this);
								return;
							}
							goto IL_0194;
						}
						result = new ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>(chunk, (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)System.Array.Empty<TranslationOutcome>());
						goto end_IL_007c;
						IL_0194:
						System.Collections.Generic.IReadOnlyList<TranslationOutcome> result2 = awaiter2.GetResult();
						result = new ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>(_003C_003E7__wrap1, result2);
						end_IL_007c:;
					}
					finally
					{
						if (num < 0)
						{
							CS_0024_003C_003E8__locals0.gate.Release();
						}
					}
				}
				catch (System.Exception exception)
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

		[StructLayout(3)]
		private struct a : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<SourceText>> phase;

			public B _003C_003E4__this;

			private List<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>> _003CinFlight_003E5__2;

			private TaskAwaiter<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>> _003C_003Eu__1;

			private TaskAwaiter<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0109: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				B CS_0024_003C_003E8__locals0 = _003C_003E4__this;
				try
				{
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00b1;
						}
						_003CinFlight_003E5__2 = Enumerable.ToList<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>>(Enumerable.Select<System.Collections.Generic.IReadOnlyList<SourceText>, System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<SourceText>>)phase, (Func<System.Collections.Generic.IReadOnlyList<SourceText>, System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>>)([AsyncStateMachine(typeof(A))] async (System.Collections.Generic.IReadOnlyList<SourceText> P_0) =>
						{
							//IL_0002: Unknown result type (might be due to invalid IL or missing references)
							//IL_0007: Unknown result type (might be due to invalid IL or missing references)
							await CS_0024_003C_003E8__locals0.gate.WaitAsync(CS_0024_003C_003E8__locals0.cancellationToken);
							try
							{
								if (CS_0024_003C_003E8__locals0._003C_003E4__this._providerRefusingEverything)
								{
									return new ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>(P_0, (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)System.Array.Empty<TranslationOutcome>());
								}
								System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(27, 2);
								defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rl());
								defaultInterpolatedStringHandler2.AppendFormatted(TextCounts.AsObject(((System.Collections.Generic.IReadOnlyCollection<SourceText>)P_0).Count));
								defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rM());
								defaultInterpolatedStringHandler2.AppendFormatted(CS_0024_003C_003E8__locals0._003C_003E4__this._relay.Current.DisplayName);
								defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Su());
								CS_0024_003C_003E8__locals0.A(defaultInterpolatedStringHandler2.ToStringAndClear());
								return new ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>(P_0, await CS_0024_003C_003E8__locals0._003C_003E4__this.A(P_0, delegate(string P_0)
								{
									CS_0024_003C_003E8__locals0.progress?.Report(new TranslationProgress
									{
										Total = CS_0024_003C_003E8__locals0.pending.Count,
										Completed = CS_0024_003C_003E8__locals0.completedUnique,
										FromMemory = CS_0024_003C_003E8__locals0.answeredUpFront.Count,
										NeedsReview = CS_0024_003C_003E8__locals0.needsReview,
										NotReached = CS_0024_003C_003E8__locals0.notReached,
										Usage = TokenUsage.Of(CS_0024_003C_003E8__locals0._003C_003E4__this.provider).Since(CS_0024_003C_003E8__locals0.startingUsage),
										Note = P_0
									});
								}, CS_0024_003C_003E8__locals0.cancellationToken));
							}
							finally
							{
								CS_0024_003C_003E8__locals0.gate.Release();
							}
						})));
						goto IL_028e;
					}
					TaskAwaiter<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>> awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>>);
					num = (_003C_003E1__state = -1);
					goto IL_009b;
					IL_00b1:
					System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>> result = default(System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>);
					System.Collections.Generic.IReadOnlyList<SourceText> item;
					System.Collections.Generic.IReadOnlyList<TranslationOutcome> item2;
					try
					{
						TaskAwaiter<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>> awaiter2;
						if (num != 1)
						{
							awaiter2 = result.GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>, a>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>);
							num = (_003C_003E1__state = -1);
						}
						ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>> result2 = awaiter2.GetResult();
						item = result2.Item1;
						item2 = result2.Item2;
					}
					catch (OperationCanceledException)
					{
						CS_0024_003C_003E8__locals0._003C_003E4__this.StoppedEarly = true;
						goto IL_028e;
					}
					int num2 = 0;
					System.Collections.Generic.IEnumerator<TranslationOutcome> enumerator = ((System.Collections.Generic.IEnumerable<TranslationOutcome>)item2).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							TranslationOutcome current = enumerator.Current;
							CS_0024_003C_003E8__locals0.translatedByValue[CS_0024_003C_003E8__locals0._003C_003E4__this.A(current.Source)] = current;
							if (TranslationPipeline.A(current))
							{
								continue;
							}
							num2++;
							if (current.Status == TranslationStatus.NeedsReview)
							{
								CS_0024_003C_003E8__locals0.needsReview++;
								continue;
							}
							string value = current.Value;
							if (value != null && value.Length > 0 && !CS_0024_003C_003E8__locals0._003C_003E4__this.a(current.Source))
							{
								CS_0024_003C_003E8__locals0._003C_003E4__this.memory.Remember(current.Source.Value, value);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
					CS_0024_003C_003E8__locals0.completedUnique += num2;
					CS_0024_003C_003E8__locals0.notReached += ((System.Collections.Generic.IReadOnlyCollection<SourceText>)item).Count - num2;
					CS_0024_003C_003E8__locals0.finishedBatches++;
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 2);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SV());
					defaultInterpolatedStringHandler.AppendFormatted<int>(CS_0024_003C_003E8__locals0.finishedBatches);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
					defaultInterpolatedStringHandler.AppendFormatted<int>(CS_0024_003C_003E8__locals0.chunks.Count);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Sv());
					CS_0024_003C_003E8__locals0.A(defaultInterpolatedStringHandler.ToStringAndClear());
					goto IL_028e;
					IL_028e:
					if (_003CinFlight_003E5__2.Count > 0)
					{
						awaiter = System.Threading.Tasks.Task.WhenAny<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>((System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>>)_003CinFlight_003E5__2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>>>, a>(ref awaiter, ref this);
							return;
						}
						goto IL_009b;
					}
					goto end_IL_000e;
					IL_009b:
					result = awaiter.GetResult();
					_003CinFlight_003E5__2.Remove(result);
					goto IL_00b1;
					end_IL_000e:;
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003CinFlight_003E5__2 = null;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003CinFlight_003E5__2 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(P_0);
			}
		}

		public HashSet<string> termValues;

		public IProgress<TranslationProgress> progress;

		public List<SourceText> pending;

		public int completedUnique;

		public HashSet<string> answeredUpFront;

		public int needsReview;

		public int notReached;

		public TranslationPipeline _003C_003E4__this;

		public TokenUsage startingUsage;

		public SemaphoreSlim gate;

		public CancellationToken cancellationToken;

		public Dictionary<string, TranslationOutcome> translatedByValue;

		public int finishedBatches;

		public List<System.Collections.Generic.IReadOnlyList<SourceText>> chunks;

		internal bool A(SourceText P_0)
		{
			return termValues.Contains(P_0.Value);
		}

		internal bool a(SourceText P_0)
		{
			return !termValues.Contains(P_0.Value);
		}

		internal void A(string P_0)
		{
			progress?.Report(new TranslationProgress
			{
				Total = pending.Count,
				Completed = completedUnique,
				FromMemory = answeredUpFront.Count,
				NeedsReview = needsReview,
				NotReached = notReached,
				Usage = TokenUsage.Of(_003C_003E4__this.provider).Since(startingUsage),
				Note = P_0
			});
		}

		[AsyncStateMachine(typeof(a))]
		internal System.Threading.Tasks.Task A(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<SourceText>> P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			a a = default(a);
			a._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			a._003C_003E4__this = this;
			a.phase = P_0;
			a._003C_003E1__state = -1;
			((AsyncTaskMethodBuilder)(ref a._003C_003Et__builder)).Start<a>(ref a);
			return ((AsyncTaskMethodBuilder)(ref a._003C_003Et__builder)).Task;
		}

		[AsyncStateMachine(typeof(A))]
		internal async System.Threading.Tasks.Task<ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>> A(System.Collections.Generic.IReadOnlyList<SourceText> P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			await gate.WaitAsync(cancellationToken);
			try
			{
				if (_003C_003E4__this._providerRefusingEverything)
				{
					return new ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>(P_0, (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)System.Array.Empty<TranslationOutcome>());
				}
				B b = this;
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(27, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rl());
				defaultInterpolatedStringHandler.AppendFormatted(TextCounts.AsObject(((System.Collections.Generic.IReadOnlyCollection<SourceText>)P_0).Count));
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rM());
				defaultInterpolatedStringHandler.AppendFormatted(_003C_003E4__this._relay.Current.DisplayName);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Su());
				b.A(defaultInterpolatedStringHandler.ToStringAndClear());
				return new ValueTuple<System.Collections.Generic.IReadOnlyList<SourceText>, System.Collections.Generic.IReadOnlyList<TranslationOutcome>>(P_0, await _003C_003E4__this.A(P_0, delegate(string P_0)
				{
					progress?.Report(new TranslationProgress
					{
						Total = pending.Count,
						Completed = completedUnique,
						FromMemory = answeredUpFront.Count,
						NeedsReview = needsReview,
						NotReached = notReached,
						Usage = TokenUsage.Of(_003C_003E4__this.provider).Since(startingUsage),
						Note = P_0
					});
				}, cancellationToken));
			}
			finally
			{
				gate.Release();
			}
		}

		internal string? a(string P_0)
		{
			TranslationOutcome translationOutcome = default(TranslationOutcome);
			if (!translatedByValue.TryGetValue(P_0, ref translationOutcome) || translationOutcome.Status == TranslationStatus.NeedsReview)
			{
				return _003C_003E4__this.b(P_0);
			}
			return translationOutcome.Value;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public System.Exception e;

		internal bool A(string P_0)
		{
			return e.Message.Contains(P_0, (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public TranslationPipeline _003C_003E4__this;

		public List<TranslationUnit> units;

		public Dictionary<int, System.Collections.Generic.IReadOnlyList<QualityIssue>> refusalsByIndex;

		public HashSet<int> missingByIndex;

		public Dictionary<int, TranslationOutcome> results;

		public Predicate<int> _003C_003E9__1;

		public Func<int, TranslationUnit> _003C_003E9__2;

		public Func<int, TranslationUnit> _003C_003E9__3;

		public Func<int, SourceText> _003C_003E9__4;

		public Func<int, bool> _003C_003E9__5;

		public Func<int, ValueTuple<int, string, string>> _003C_003E9__6;

		internal bool A(int P_0)
		{
			if (_003C_003E4__this.B(units[P_0].Source))
			{
				return _003C_003E4__this.A(units[P_0].Source.Value, units[P_0].Source.Room) != null;
			}
			return false;
		}

		internal TranslationUnit a(int P_0)
		{
			System.Collections.Generic.IReadOnlyList<QualityIssue> previousRefusals = default(System.Collections.Generic.IReadOnlyList<QualityIssue>);
			if (!refusalsByIndex.TryGetValue(P_0, ref previousRefusals))
			{
				if (!missingByIndex.Contains(P_0))
				{
					return units[P_0];
				}
				TranslationUnit translationUnit = units[P_0]._003CClone_003E_0024();
				translationUnit.PreviousRefusals = new L<QualityIssue>(TheLineFellOut);
				return translationUnit;
			}
			TranslationUnit translationUnit2 = units[P_0]._003CClone_003E_0024();
			translationUnit2.PreviousRefusals = previousRefusals;
			return translationUnit2;
		}

		internal TranslationUnit B(int P_0)
		{
			return units[P_0];
		}

		internal SourceText b(int P_0)
		{
			return units[P_0].Source;
		}

		internal bool C(int P_0)
		{
			return !results.ContainsKey(P_0);
		}

		internal ValueTuple<int, string, string> c(int P_0)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<int, string, string>(P_0, units[P_0].Source.Value, results[P_0].Value ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
		}

		internal TranslationOutcome D(int P_0)
		{
			return results[P_0];
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public System.Collections.Generic.IReadOnlyList<TranslationUnit> units;

		public Dictionary<int, TranslationOutcome> results;

		public IReadOnlyDictionary<int, string> answeredWith;

		public Func<int, TranslationUnit> _003C_003E9__2;

		public Func<int, TranslationUnit> _003C_003E9__1;

		internal bool A(int P_0)
		{
			TextType textType = units[P_0].Source.TextType;
			bool flag = (uint)textType <= 1u;
			TranslationOutcome translationOutcome = default(TranslationOutcome);
			if (flag && results.TryGetValue(P_0, ref translationOutcome))
			{
				return translationOutcome.Status == TranslationStatus.Accepted;
			}
			return false;
		}

		internal TranslationUnit a(int P_0)
		{
			TranslationUnit translationUnit = units[P_0]._003CClone_003E_0024();
			translationUnit.UnderReview = answeredWith[P_0];
			return translationUnit;
		}

		internal TranslationUnit B(int P_0)
		{
			return units[P_0];
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public Dictionary<int, TranslationOutcome> mended;

		public c CS_0024_003C_003E8__locals1;

		public Func<int, ValueTuple<int, string, string>> _003C_003E9__3;

		internal ValueTuple<int, string, string> A(int P_0)
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			TranslationOutcome translationOutcome = default(TranslationOutcome);
			return new ValueTuple<int, string, string>(P_0, CS_0024_003C_003E8__locals1.units[P_0].Source.Value, (mended.TryGetValue(P_0, ref translationOutcome) ? translationOutcome : CS_0024_003C_003E8__locals1.results[P_0]).Value ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public TranslationUnit unit;

		public bool? faith;

		public int attempt;

		public TranslationPipeline _003C_003E4__this;

		internal string A(string P_0)
		{
			if (!ArabicScript.IsAlreadyArabic(P_0))
			{
				return P_0;
			}
			return NamesOnlyAllahBears.Mend(unit.Source.Value, P_0, faith);
		}

		internal bool A(QualityIssue P_0)
		{
			if (P_0.Blocking)
			{
				if (P_0.AcceptedOnLastAttempt)
				{
					return attempt < _003C_003E4__this.options.MaxAttempts;
				}
				return true;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public List<string> texts;

		internal bool A(GlossaryEntry P_0)
		{
			e CS_0024_003C_003E8__locals0 = new e
			{
				entry = P_0
			};
			return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)texts, (Func<string, bool>)((string P_0) => P_0.Contains(CS_0024_003C_003E8__locals0.entry.Term, TermMatch.ComparisonFor(CS_0024_003C_003E8__locals0.entry.Term))));
		}
	}

	[CompilerGenerated]
	private sealed class e
	{
		public GlossaryEntry entry;

		internal bool A(string P_0)
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			return P_0.Contains(entry.Term, TermMatch.ComparisonFor(entry.Term));
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct F : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public System.Collections.Generic.IReadOnlyList<TranslationUnit> units;

		public Dictionary<int, TranslationOutcome> results;

		public IReadOnlyDictionary<int, string> answeredWith;

		private c _003C_003E8__1;

		public TranslationPipeline _003C_003E4__this;

		public CancellationToken cancellationToken;

		public Action<string> say;

		private D _003C_003E8__2;

		private List<int> _003Clines_003E5__2;

		private int _003Ctries_003E5__3;

		private ModelInfo _003Csending_003E5__4;

		private IReadOnlyDictionary<int, string> _003Craw_003E5__5;

		private object _003C_003E7__wrap5;

		private int _003C_003E7__wrap6;

		private TaskAwaiter<IReadOnlyDictionary<int, string>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_059d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TranslationPipeline translationPipeline = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0209;
				}
				if (num == 1)
				{
					goto IL_035d;
				}
				_003C_003E8__1 = new c();
				_003C_003E8__1.units = units;
				_003C_003E8__1.results = results;
				_003C_003E8__1.answeredWith = answeredWith;
				_003Clines_003E5__2 = Enumerable.ToList<int>((System.Collections.Generic.IEnumerable<int>)Enumerable.Order<int>(Enumerable.Where<int>(_003C_003E8__1.answeredWith.Keys, (Func<int, bool>)delegate(int P_0)
				{
					TextType textType = _003C_003E8__1.units[P_0].Source.TextType;
					bool flag = (uint)textType <= 1u;
					TranslationOutcome translationOutcome6 = default(TranslationOutcome);
					return flag && _003C_003E8__1.results.TryGetValue(P_0, ref translationOutcome6) && translationOutcome6.Status == TranslationStatus.Accepted;
				})));
				_003Ctries_003E5__3 = 1;
				goto IL_0628;
				IL_035d:
				TimeSpan retryAfter = default(TimeSpan);
				try
				{
					TaskAwaiter awaiter;
					if (num != 1)
					{
						awaiter = System.Threading.Tasks.Task.Delay(retryAfter, cancellationToken).GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, F>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					((TaskAwaiter)(ref awaiter)).GetResult();
				}
				catch (OperationCanceledException)
				{
					translationPipeline.StoppedEarly = true;
					goto end_IL_000e;
				}
				_003Ctries_003E5__3++;
				goto IL_0628;
				IL_0209:
				ITranslationProvider item = default(ITranslationProvider);
				TranslationBatch translationBatch = default(TranslationBatch);
				try
				{
					TaskAwaiter<IReadOnlyDictionary<int, string>> awaiter2;
					if (num != 0)
					{
						awaiter2 = A((item ?? translationPipeline.provider).TranslateAsync(translationBatch, _003Csending_003E5__4, cancellationToken), ((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)translationBatch.Units).Count, _003Csending_003E5__4.DisplayName, 1, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rt(), say, cancellationToken, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RT()).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<IReadOnlyDictionary<int, string>>, F>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<IReadOnlyDictionary<int, string>>);
						num = (_003C_003E1__state = -1);
					}
					IReadOnlyDictionary<int, string> result = awaiter2.GetResult();
					_003Craw_003E5__5 = result;
				}
				catch (OperationCanceledException)
				{
					translationPipeline.StoppedEarly = true;
					goto end_IL_000e;
				}
				catch (System.Exception ex)
				{
					_003C_003E7__wrap5 = ex;
					_003C_003E7__wrap6 = 1;
				}
				int num2 = _003C_003E7__wrap6;
				if (num2 == 1)
				{
					System.Exception ex2 = (System.Exception)_003C_003E7__wrap5;
					if (_003Ctries_003E5__3 == 1 && !translationPipeline.options.NeverWaitForABusyService && ex2 is IAskedToWait askedToWait)
					{
						retryAfter = askedToWait.RetryAfter;
						string providerSaid = askedToWait.ProviderSaid;
						if (retryAfter <= LongestWaitWorthSitting && QuotaExhaustion.IsOurOwnPace(retryAfter, providerSaid))
						{
							goto IL_035d;
						}
					}
					Interlocked.Increment(ref translationPipeline._reviewRequestsLost);
				}
				else
				{
					_003C_003E7__wrap5 = null;
					Interlocked.Add(ref translationPipeline._reviewed, _003Clines_003E5__2.Count);
					_003C_003E8__2.mended = new Dictionary<int, TranslationOutcome>();
					string text = default(string);
					for (int i = 0; i < _003Clines_003E5__2.Count; i++)
					{
						int num3 = _003Clines_003E5__2[i];
						if (_003Craw_003E5__5.TryGetValue(i + 1, ref text) && !string.Equals(text.Trim(), _003C_003E8__2.CS_0024_003C_003E8__locals1.answeredWith[num3].Trim(), (StringComparison)4))
						{
							System.Collections.Generic.IReadOnlyList<QualityIssue> readOnlyList;
							TranslationOutcome translationOutcome = translationPipeline.A(_003C_003E8__2.CS_0024_003C_003E8__locals1.units[num3], text, _003C_003E8__2.CS_0024_003C_003E8__locals1.results[num3].Attempts, out readOnlyList);
							if ((object)translationOutcome != null)
							{
								Dictionary<int, TranslationOutcome> mended = _003C_003E8__2.mended;
								TranslationOutcome translationOutcome2 = translationOutcome._003CClone_003E_0024();
								translationOutcome2.ByModel = _003Csending_003E5__4.Id;
								mended[num3] = translationOutcome2;
							}
							else
							{
								Interlocked.Increment(ref translationPipeline._reviewRefused);
							}
						}
					}
					TranslationOutcome translationOutcome5 = default(TranslationOutcome);
					System.Collections.Generic.IEnumerator<int> enumerator = ((System.Collections.Generic.IEnumerable<int>)AnswersOfAnotherLine.In(Enumerable.Select<int, ValueTuple<int, string, string>>((System.Collections.Generic.IEnumerable<int>)_003Clines_003E5__2, (Func<int, ValueTuple<int, string, string>>)((int P_0) => new ValueTuple<int, string, string>(P_0, _003C_003E8__2.CS_0024_003C_003E8__locals1.units[P_0].Source.Value, (_003C_003E8__2.mended.TryGetValue(P_0, ref translationOutcome5) ? translationOutcome5 : _003C_003E8__2.CS_0024_003C_003E8__locals1.results[P_0]).Value ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()))))).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							int current = enumerator.Current;
							if (_003C_003E8__2.mended.Remove(current))
							{
								Interlocked.Increment(ref translationPipeline._reviewRefused);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
					Enumerator<int, TranslationOutcome> enumerator2 = _003C_003E8__2.mended.GetEnumerator();
					try
					{
						TranslationOutcome translationOutcome3 = default(TranslationOutcome);
						while (enumerator2.MoveNext())
						{
							enumerator2.Current.Deconstruct(ref num2, ref translationOutcome3);
							int num4 = num2;
							TranslationOutcome translationOutcome4 = translationOutcome3;
							_003C_003E8__2.CS_0024_003C_003E8__locals1.results[num4] = translationOutcome4;
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator2).Dispose();
						}
					}
					Interlocked.Add(ref translationPipeline._mendedOnReview, _003C_003E8__2.mended.Count);
				}
				goto end_IL_000e;
				IL_0628:
				if (_003Clines_003E5__2.Count > 0 && _003Ctries_003E5__3 <= 2)
				{
					_003C_003E8__2 = new D();
					_003C_003E8__2.CS_0024_003C_003E8__locals1 = _003C_003E8__1;
					ValueTuple<ModelInfo, ITranslationProvider> now = translationPipeline._relay.Now;
					_003Csending_003E5__4 = now.Item1;
					item = now.Item2;
					if (!translationPipeline._providerRefusingEverything && (item ?? translationPipeline.provider).FollowsInstructions)
					{
						if (!((CancellationToken)(ref cancellationToken)).IsCancellationRequested)
						{
							TranslationBatch translationBatch2 = new TranslationBatch();
							List<TranslationUnit> obj = new List<TranslationUnit>();
							obj.AddRange(Enumerable.Select<int, TranslationUnit>((System.Collections.Generic.IEnumerable<int>)_003Clines_003E5__2, (Func<int, TranslationUnit>)delegate(int P_0)
							{
								TranslationUnit translationUnit = _003C_003E8__2.CS_0024_003C_003E8__locals1.units[P_0]._003CClone_003E_0024();
								translationUnit.UnderReview = _003C_003E8__2.CS_0024_003C_003E8__locals1.answeredWith[P_0];
								return translationUnit;
							}));
							translationBatch2.Units = new k<TranslationUnit>(obj);
							translationBatch2.Style = translationPipeline.options.Style;
							translationBatch2.Glossary = translationPipeline.A(Enumerable.Select<int, TranslationUnit>((System.Collections.Generic.IEnumerable<int>)_003Clines_003E5__2, (Func<int, TranslationUnit>)((int P_0) => _003C_003E8__2.CS_0024_003C_003E8__locals1.units[P_0])));
							translationBatch2.GameContext = translationPipeline.options.GameContext;
							translationBatch = translationBatch2;
							say.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RT());
							_003C_003E7__wrap6 = 0;
							goto IL_0209;
						}
						translationPipeline.StoppedEarly = true;
					}
				}
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003Clines_003E5__2 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003Clines_003E5__2 = null;
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
	private struct f : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> _003C_003Et__builder;

		public IProgress<TranslationProgress> progress;

		public TranslationPipeline _003C_003E4__this;

		public CancellationToken cancellationToken;

		public System.Collections.Generic.IReadOnlyList<SourceText> sources;

		private B _003C_003E8__1;

		private List<TranslationOutcome> _003Coutcomes_003E5__2;

		private Dictionary<string, int?> _003CroomOf_003E5__3;

		private System.Collections.Generic.IReadOnlyList<SourceText> _003Cterms_003E5__4;

		private List<System.Collections.Generic.IReadOnlyList<SourceText>> _003CrestChunks_003E5__5;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_047c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0489: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_057c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0542: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Expected O, but got Unknown
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TranslationPipeline translationPipeline = _003C_003E4__this;
			System.Collections.Generic.IReadOnlyList<TranslationOutcome> result;
			try
			{
				TaskAwaiter awaiter;
				System.Collections.Generic.IEnumerator<SourceText> enumerator;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0593;
					}
					_003C_003E8__1 = new B();
					_003C_003E8__1.progress = progress;
					_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
					_003C_003E8__1.cancellationToken = cancellationToken;
					_003Coutcomes_003E5__2 = new List<TranslationOutcome>();
					translationPipeline._twoMeanings = WordsWithTwoMeanings(sources);
					_003C_003E8__1.pending = new List<SourceText>();
					HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					_003C_003E8__1.answeredUpFront = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					_003CroomOf_003E5__3 = translationPipeline.A(sources);
					enumerator = ((System.Collections.Generic.IEnumerable<SourceText>)sources).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							SourceText current = enumerator.Current;
							int? valueOrDefault = CollectionExtensions.GetValueOrDefault<string, int?>((IReadOnlyDictionary<string, int?>)(object)_003CroomOf_003E5__3, translationPipeline.A(current));
							if (translationPipeline.B(current) && translationPipeline.A(current.Value, valueOrDefault) != null)
							{
								_003C_003E8__1.answeredUpFront.Add(current.Value);
							}
							else if (val.Add(translationPipeline.A(current)))
							{
								List<SourceText> pending = _003C_003E8__1.pending;
								SourceText sourceText;
								if (valueOrDefault.HasValue)
								{
									sourceText = current._003CClone_003E_0024();
									sourceText.Room = valueOrDefault;
								}
								else
								{
									sourceText = current;
								}
								pending.Add(sourceText);
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
					_003C_003E8__1.translatedByValue = new Dictionary<string, TranslationOutcome>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					_003C_003E8__1.completedUnique = 0;
					for (int num2 = _003C_003E8__1.pending.Count - 1; num2 >= 0; num2--)
					{
						SourceText sourceText2 = _003C_003E8__1.pending[num2];
						if (A(sourceText2.Value))
						{
							_003C_003E8__1.translatedByValue[translationPipeline.A(sourceText2)] = new TranslationOutcome
							{
								Source = sourceText2,
								Value = sourceText2.Value,
								Status = TranslationStatus.Accepted
							};
							_003C_003E8__1.answeredUpFront.Add(sourceText2.Value);
							_003C_003E8__1.pending.RemoveAt(num2);
						}
						else
						{
							string text = translationPipeline.B(sourceText2.Value);
							if (text != null)
							{
								_003C_003E8__1.translatedByValue[translationPipeline.A(sourceText2)] = new TranslationOutcome
								{
									Source = sourceText2,
									Value = text,
									Status = TranslationStatus.Accepted
								};
								_003C_003E8__1.answeredUpFront.Add(sourceText2.Value);
								_003C_003E8__1.pending.RemoveAt(num2);
							}
						}
					}
					_003C_003E8__1.startingUsage = TokenUsage.Of(translationPipeline.provider);
					_003Cterms_003E5__4 = GameGlossary.TermsIn(sources);
					_003C_003E8__1.termValues = new HashSet<string>(Enumerable.Select<SourceText, string>((System.Collections.Generic.IEnumerable<SourceText>)_003Cterms_003E5__4, (Func<SourceText, string>)((SourceText P_0) => P_0.Value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
					List<SourceText> val2 = Enumerable.ToList<SourceText>(Enumerable.Where<SourceText>((System.Collections.Generic.IEnumerable<SourceText>)_003C_003E8__1.pending, (Func<SourceText, bool>)((SourceText P_0) => _003C_003E8__1.termValues.Contains(P_0.Value))));
					List<SourceText> val3 = Enumerable.ToList<SourceText>(Enumerable.Where<SourceText>((System.Collections.Generic.IEnumerable<SourceText>)_003C_003E8__1.pending, (Func<SourceText, bool>)((SourceText P_0) => !_003C_003E8__1.termValues.Contains(P_0.Value))));
					List<System.Collections.Generic.IReadOnlyList<SourceText>> val4 = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<SourceText>>(translationPipeline.a((System.Collections.Generic.IReadOnlyList<SourceText>)val2));
					_003CrestChunks_003E5__5 = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<SourceText>>(translationPipeline.a((System.Collections.Generic.IReadOnlyList<SourceText>)val3));
					_003C_003E8__1.chunks = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<SourceText>>(Enumerable.Concat<System.Collections.Generic.IReadOnlyList<SourceText>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<SourceText>>)val4, (System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<SourceText>>)_003CrestChunks_003E5__5));
					_003C_003E8__1.needsReview = 0;
					_003C_003E8__1.notReached = 0;
					_003C_003E8__1.finishedBatches = 0;
					_003C_003E8__1.gate = new SemaphoreSlim(translationPipeline.Concurrency, translationPipeline.Concurrency);
					if (val4.Count <= 0)
					{
						goto IL_049f;
					}
					B b = _003C_003E8__1;
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(58, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RU());
					defaultInterpolatedStringHandler.AppendFormatted<int>(val2.Count);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ru());
					b.A(defaultInterpolatedStringHandler.ToStringAndClear());
					awaiter = _003C_003E8__1.A((System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<SourceText>>)val4).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, f>(ref awaiter, ref this);
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
				goto IL_049f;
				IL_049f:
				if (((System.Collections.Generic.IReadOnlyCollection<SourceText>)_003Cterms_003E5__4).Count > 0)
				{
					TranslationOutcome translationOutcome3 = default(TranslationOutcome);
					translationPipeline._discovered = GameGlossary.EntriesFor((System.Collections.Generic.IEnumerable<SourceText>)_003Cterms_003E5__4, (string P_0) => (!_003C_003E8__1.translatedByValue.TryGetValue(P_0, ref translationOutcome3) || translationOutcome3.Status == TranslationStatus.NeedsReview) ? _003C_003E8__1._003C_003E4__this.b(P_0) : translationOutcome3.Value);
					if (((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)translationPipeline._discovered).Count > 0)
					{
						B b2 = _003C_003E8__1;
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 1);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RV());
						defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)translationPipeline._discovered).Count);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rv());
						b2.A(defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
				if (!translationPipeline.StoppedEarly)
				{
					awaiter = _003C_003E8__1.A((System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<SourceText>>)_003CrestChunks_003E5__5).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, f>(ref awaiter, ref this);
						return;
					}
					goto IL_0593;
				}
				goto IL_059a;
				IL_059a:
				if (!translationPipeline.StoppedEarly && translationPipeline.options.ReportTotalProviderFailure && !translationPipeline._answered)
				{
					System.Exception lastTransportFailure = translationPipeline._lastTransportFailure;
					if (lastTransportFailure != null && _003C_003E8__1.pending.Count > 0)
					{
						throw lastTransportFailure;
					}
				}
				enumerator = ((System.Collections.Generic.IEnumerable<SourceText>)sources).GetEnumerator();
				try
				{
					TranslationOutcome translationOutcome = default(TranslationOutcome);
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						SourceText current2 = enumerator.Current;
						string text2 = (translationPipeline.B(current2) ? translationPipeline.A(current2.Value, CollectionExtensions.GetValueOrDefault<string, int?>((IReadOnlyDictionary<string, int?>)(object)_003CroomOf_003E5__3, translationPipeline.A(current2))) : null);
						if (_003C_003E8__1.translatedByValue.TryGetValue(translationPipeline.A(current2), ref translationOutcome))
						{
							List<TranslationOutcome> obj = _003Coutcomes_003E5__2;
							TranslationOutcome translationOutcome2 = translationOutcome._003CClone_003E_0024();
							translationOutcome2.Source = current2;
							obj.Add(translationOutcome2);
						}
						else if (text2 != null)
						{
							_003Coutcomes_003E5__2.Add(new TranslationOutcome
							{
								Source = current2,
								Value = text2,
								Status = TranslationStatus.FromMemory
							});
						}
						else if (!translationPipeline.StoppedEarly)
						{
							_003Coutcomes_003E5__2.Add(new TranslationOutcome
							{
								Source = current2,
								Status = TranslationStatus.NeedsReview,
								Issues = new L<QualityIssue>(new QualityIssue
								{
									Kind = QualityIssueKind.Empty,
									Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RW()
								}),
								NoModelWasAsked = true
							});
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result = (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)_003Coutcomes_003E5__2;
				goto end_IL_000e;
				IL_0593:
				((TaskAwaiter)(ref awaiter)).GetResult();
				goto IL_059a;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003Coutcomes_003E5__2 = null;
				_003CroomOf_003E5__3 = null;
				_003Cterms_003E5__4 = null;
				_003CrestChunks_003E5__5 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003Coutcomes_003E5__2 = null;
			_003CroomOf_003E5__3 = null;
			_003Cterms_003E5__4 = null;
			_003CrestChunks_003E5__5 = null;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			_003C_003Et__builder.SetStateMachine(P_0);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct G : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> _003C_003Et__builder;

		public TranslationPipeline _003C_003E4__this;

		public System.Collections.Generic.IReadOnlyList<SourceText> chunk;

		private C _003C_003E8__1;

		public CancellationToken cancellationToken;

		public Action<string> say;

		public int splitsSoFar;

		private Dictionary<int, int> _003CattemptsByIndex_003E5__2;

		private string _003CtheServiceRefused_003E5__3;

		private Dictionary<int, string> _003CansweredWith_003E5__4;

		private List<int> _003Cremaining_003E5__5;

		private string _003CwhyAgain_003E5__6;

		private int _003Cattempt_003E5__7;

		private TranslationBatch _003Cbatch_003E5__8;

		private IReadOnlyDictionary<int, string> _003Craw_003E5__9;

		private ModelInfo _003Csending_003E5__10;

		private object _003C_003E7__wrap10;

		private int _003C_003E7__wrap11;

		private TaskAwaiter<IReadOnlyDictionary<int, string>> _003C_003Eu__1;

		private List<int>[] _003C_003E7__wrap12;

		private int _003C_003E7__wrap13;

		private List<int> _003Cpart_003E5__15;

		private TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0970: Unknown result type (might be due to invalid IL or missing references)
			//IL_0975: Unknown result type (might be due to invalid IL or missing references)
			//IL_097d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0493: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_064a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0656: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0706: Unknown result type (might be due to invalid IL or missing references)
			//IL_083b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0840: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Unknown result type (might be due to invalid IL or missing references)
			//IL_0844: Unknown result type (might be due to invalid IL or missing references)
			//IL_092e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0940: Unknown result type (might be due to invalid IL or missing references)
			//IL_0955: Unknown result type (might be due to invalid IL or missing references)
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TranslationPipeline translationPipeline = _003C_003E4__this;
			System.Collections.Generic.IReadOnlyList<TranslationOutcome> result3;
			try
			{
				ITranslationProvider item = default(ITranslationProvider);
				System.Exception ex2;
				int num4;
				TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> awaiter2;
				TaskAwaiter awaiter;
				System.Collections.Generic.IReadOnlyList<TranslationOutcome> result;
				bool flag4;
				int num6;
				List<int> obj3;
				switch (num)
				{
				default:
					_003C_003E8__1 = new C();
					_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
					_003C_003E8__1.units = Enumerable.ToList<TranslationUnit>(Enumerable.Select<SourceText, TranslationUnit>((System.Collections.Generic.IEnumerable<SourceText>)chunk, (Func<SourceText, TranslationUnit>)translationPipeline.b));
					_003C_003E8__1.results = new Dictionary<int, TranslationOutcome>();
					_003CattemptsByIndex_003E5__2 = new Dictionary<int, int>();
					_003C_003E8__1.refusalsByIndex = new Dictionary<int, System.Collections.Generic.IReadOnlyList<QualityIssue>>();
					_003CtheServiceRefused_003E5__3 = null;
					_003C_003E8__1.missingByIndex = new HashSet<int>();
					_003CansweredWith_003E5__4 = new Dictionary<int, string>();
					_003Cremaining_003E5__5 = Enumerable.ToList<int>(Enumerable.Range(0, _003C_003E8__1.units.Count));
					_003CwhyAgain_003E5__6 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rt();
					_003Cattempt_003E5__7 = 1;
					goto IL_0dd6;
				case 0:
				{
					try
					{
						TaskAwaiter<IReadOnlyDictionary<int, string>> awaiter3;
						if (num != 0)
						{
							awaiter3 = A((item ?? translationPipeline.provider).TranslateAsync(_003Cbatch_003E5__8, _003Csending_003E5__10, cancellationToken), ((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)_003Cbatch_003E5__8.Units).Count, _003Csending_003E5__10.DisplayName, _003Cattempt_003E5__7, _003CwhyAgain_003E5__6, say, cancellationToken).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IReadOnlyDictionary<int, string>>, G>(ref awaiter3, ref this);
								return;
							}
						}
						else
						{
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<IReadOnlyDictionary<int, string>>);
							num = (_003C_003E1__state = -1);
						}
						IReadOnlyDictionary<int, string> result2 = awaiter3.GetResult();
						_003Craw_003E5__9 = result2;
					}
					catch (OperationCanceledException)
					{
						throw;
					}
					catch (System.Exception ex)
					{
						_003C_003E7__wrap10 = ex;
						_003C_003E7__wrap11 = 1;
					}
					int num2 = _003C_003E7__wrap11;
					if (num2 == 1)
					{
						ex2 = (translationPipeline._lastTransportFailure = (System.Exception)_003C_003E7__wrap10);
						bool flag = B(ex2);
						bool flag2 = A(ex2) && (translationPipeline._answered || !a(ex2));
						bool flag3 = b(ex2) && translationPipeline._answered;
						if ((flag2 || flag || flag3) && _003Cremaining_003E5__5.Count > 1 && splitsSoFar < 9)
						{
							int num3 = _003Cremaining_003E5__5.Count / 2;
							if (flag2)
							{
								say.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rw() + TextCounts.AfterAWord(_003Cremaining_003E5__5.Count) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RX());
							}
							_003C_003E7__wrap12 = new List<int>[2]
							{
								Enumerable.ToList<int>(Enumerable.Take<int>((System.Collections.Generic.IEnumerable<int>)_003Cremaining_003E5__5, num3)),
								Enumerable.ToList<int>(Enumerable.Skip<int>((System.Collections.Generic.IEnumerable<int>)_003Cremaining_003E5__5, num3))
							};
							_003C_003E7__wrap13 = 0;
							goto IL_05a3;
						}
						_003CwhyAgain_003E5__6 = (C(ex2) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RY() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rx());
						if (ex2 is IAskedToWait { RetryAfter: var retryAfter } askedToWait)
						{
							string providerSaid = askedToWait.ProviderSaid;
							if (retryAfter <= LongestWaitWorthSitting)
							{
								num4 = (QuotaExhaustion.IsOurOwnPace(retryAfter, providerSaid) ? 1 : 0);
								goto IL_0662;
							}
						}
						num4 = 0;
						goto IL_0662;
					}
					_003C_003E7__wrap10 = null;
					translationPipeline._answered = true;
					Interlocked.Exchange(ref translationPipeline._failuresOnThisModel, 0);
					Interlocked.Exchange(ref translationPipeline._rateLimitWaits, 0);
					Interlocked.Exchange(ref translationPipeline._paceWaits, 0);
					_003CwhyAgain_003E5__6 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rt();
					List<int> val2 = new List<int>();
					List<int> val3 = new List<int>();
					string text = default(string);
					for (int j = 0; j < _003Cremaining_003E5__5.Count; j++)
					{
						int num5 = _003Cremaining_003E5__5[j];
						TranslationUnit translationUnit = _003C_003E8__1.units[num5];
						_003CattemptsByIndex_003E5__2[num5] = _003Cattempt_003E5__7;
						if (!_003Craw_003E5__9.TryGetValue(j + 1, ref text))
						{
							_003C_003E8__1.missingByIndex.Add(num5);
							val2.Add(num5);
							continue;
						}
						System.Collections.Generic.IReadOnlyList<QualityIssue> readOnlyList;
						TranslationOutcome translationOutcome = translationPipeline.A(translationUnit, text, _003Cattempt_003E5__7, out readOnlyList);
						if ((object)translationOutcome == null)
						{
							_003C_003E8__1.refusalsByIndex[num5] = readOnlyList;
							val2.Add(num5);
							continue;
						}
						Dictionary<int, TranslationOutcome> results = _003C_003E8__1.results;
						TranslationOutcome translationOutcome2 = translationOutcome._003CClone_003E_0024();
						translationOutcome2.ByModel = _003Csending_003E5__10.Id;
						results[num5] = translationOutcome2;
						_003CansweredWith_003E5__4[num5] = text;
						val3.Add(num5);
					}
					if (_003Cattempt_003E5__7 < translationPipeline.options.MaxAttempts)
					{
						System.Collections.Generic.IEnumerator<int> enumerator = ((System.Collections.Generic.IEnumerable<int>)AnswersOfAnotherLine.In(Enumerable.Select<int, ValueTuple<int, string, string>>((System.Collections.Generic.IEnumerable<int>)val3, (Func<int, ValueTuple<int, string, string>>)((int P_0) => new ValueTuple<int, string, string>(P_0, _003C_003E8__1.units[P_0].Source.Value, _003C_003E8__1.results[P_0].Value ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()))))).GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								int current = enumerator.Current;
								_003C_003E8__1.results.Remove(current);
								_003CansweredWith_003E5__4.Remove(current);
								_003C_003E8__1.refusalsByIndex[current] = new L<QualityIssue>(AnswersOfAnotherLine.Issue);
								val2.Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((System.IDisposable)enumerator)?.Dispose();
							}
						}
					}
					_003Cremaining_003E5__5 = val2;
					_003Cbatch_003E5__8 = null;
					_003Craw_003E5__9 = null;
					_003Csending_003E5__10 = null;
					goto IL_0dc4;
				}
				case 1:
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>>);
					num = (_003C_003E1__state = -1);
					goto IL_04e4;
				case 2:
					awaiter = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_098c;
				case 3:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0e9a;
					}
					IL_0dd6:
					if (_003Cattempt_003E5__7 <= translationPipeline.options.MaxAttempts && _003Cremaining_003E5__5.Count > 0)
					{
						if (translationPipeline.memory is IMayAnswerLater { MoreMayArrive: not false })
						{
							_003Cremaining_003E5__5.RemoveAll((Predicate<int>)((int P_0) => _003C_003E8__1._003C_003E4__this.B(_003C_003E8__1.units[P_0].Source) && _003C_003E8__1._003C_003E4__this.A(_003C_003E8__1.units[P_0].Source.Value, _003C_003E8__1.units[P_0].Source.Room) != null));
							if (_003Cremaining_003E5__5.Count == 0)
							{
								goto IL_0dfa;
							}
						}
						_003Cbatch_003E5__8 = new TranslationBatch
						{
							Units = (System.Collections.Generic.IReadOnlyList<TranslationUnit>)Enumerable.ToList<TranslationUnit>(Enumerable.Select<int, TranslationUnit>((System.Collections.Generic.IEnumerable<int>)_003Cremaining_003E5__5, (Func<int, TranslationUnit>)delegate(int P_0)
							{
								System.Collections.Generic.IReadOnlyList<QualityIssue> previousRefusals = default(System.Collections.Generic.IReadOnlyList<QualityIssue>);
								if (_003C_003E8__1.refusalsByIndex.TryGetValue(P_0, ref previousRefusals))
								{
									TranslationUnit translationUnit2 = _003C_003E8__1.units[P_0]._003CClone_003E_0024();
									translationUnit2.PreviousRefusals = previousRefusals;
									return translationUnit2;
								}
								if (_003C_003E8__1.missingByIndex.Contains(P_0))
								{
									TranslationUnit translationUnit3 = _003C_003E8__1.units[P_0]._003CClone_003E_0024();
									translationUnit3.PreviousRefusals = new L<QualityIssue>(TheLineFellOut);
									return translationUnit3;
								}
								return _003C_003E8__1.units[P_0];
							})),
							Style = translationPipeline.options.Style,
							Glossary = translationPipeline.A(Enumerable.Select<int, TranslationUnit>((System.Collections.Generic.IEnumerable<int>)_003Cremaining_003E5__5, (Func<int, TranslationUnit>)((int P_0) => _003C_003E8__1.units[P_0]))),
							GameContext = translationPipeline.options.GameContext
						};
						ValueTuple<ModelInfo, ITranslationProvider> now = translationPipeline._relay.Now;
						_003Csending_003E5__10 = now.Item1;
						item = now.Item2;
						_003C_003E7__wrap11 = 0;
						goto case 0;
					}
					goto IL_0dfa;
					IL_04e4:
					result = awaiter2.GetResult();
					for (int i = 0; i < _003Cpart_003E5__15.Count; i++)
					{
						if (result[i].Value != null)
						{
							_003C_003E8__1.results[_003Cpart_003E5__15[i]] = result[i];
							continue;
						}
						_003C_003E8__1.refusalsByIndex[_003Cpart_003E5__15[i]] = result[i].Issues;
						_003CattemptsByIndex_003E5__2[_003Cpart_003E5__15[i]] = _003Cattempt_003E5__7;
					}
					_003Cpart_003E5__15 = null;
					_003C_003E7__wrap13++;
					goto IL_05a3;
					IL_098c:
					((TaskAwaiter)(ref awaiter)).GetResult();
					_003Cattempt_003E5__7--;
					goto IL_0dc4;
					IL_0dfa:
					if (!translationPipeline.options.ReviewTheDialogue || _003CansweredWith_003E5__4.Count <= 0)
					{
						break;
					}
					awaiter = translationPipeline.A((System.Collections.Generic.IReadOnlyList<TranslationUnit>)_003C_003E8__1.units, _003C_003E8__1.results, (IReadOnlyDictionary<int, string>)(object)_003CansweredWith_003E5__4, say, cancellationToken).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, G>(ref awaiter, ref this);
						return;
					}
					goto IL_0e9a;
					IL_0662:
					flag4 = (byte)num4 != 0;
					num6 = (flag4 ? Volatile.Read(ref translationPipeline._failuresOnThisModel) : Interlocked.Increment(ref translationPipeline._failuresOnThisModel));
					if (ex2 is IModelIsGone)
					{
						if (!translationPipeline.A(say, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fc(), _003Csending_003E5__10))
						{
							say.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ry());
							_003CtheServiceRefused_003E5__3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RZ();
							translationPipeline._providerRefusingEverything = true;
							goto IL_0dfa;
						}
						_003Cattempt_003E5__7--;
					}
					else
					{
						if (ex2 is IAskedToWait { RetryAfter: var retryAfter2 } askedToWait2)
						{
							string providerSaid2 = askedToWait2.ProviderSaid;
							if (QuotaExhaustion.LooksDaily(retryAfter2, providerSaid2) || QuotaExhaustion.LooksSpent(providerSaid2))
							{
								if (translationPipeline.A(say, QuotaExhaustion.LooksSpent(providerSaid2) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rA() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rz(), _003Csending_003E5__10))
								{
									_003Cattempt_003E5__7--;
									goto IL_0dc4;
								}
								bool flag5 = QuotaExhaustion.LooksSpent(providerSaid2);
								say.Invoke(flag5 ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rB() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ra());
								_003CtheServiceRefused_003E5__3 = (flag5 ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rC() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rb());
								translationPipeline._providerRefusingEverything = true;
								goto IL_0dfa;
							}
						}
						if (translationPipeline.options.NeverWaitForABusyService && ex2 is IAskedToWait)
						{
							if (!translationPipeline.A(say, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rc(), _003Csending_003E5__10))
							{
								say.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rD());
								_003CtheServiceRefused_003E5__3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rd();
								translationPipeline._providerRefusingEverything = true;
								goto IL_0dfa;
							}
							_003Cattempt_003E5__7--;
						}
						else
						{
							if ((num6 <= 1 || !translationPipeline._relay.HasNext) && ex2 is IAskedToWait { RetryAfter: var retryAfter3 } && retryAfter3 <= LongestWaitWorthSitting && (flag4 ? (Interlocked.Increment(ref translationPipeline._paceWaits) <= 64) : (Interlocked.Increment(ref translationPipeline._rateLimitWaits) <= 6)))
							{
								Action<string> obj = say;
								System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 1);
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rE());
								defaultInterpolatedStringHandler.AppendFormatted<double>(((TimeSpan)(ref retryAfter3)).TotalSeconds, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a());
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nh());
								string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
								string text3;
								if (!(translationPipeline._relay.HasNext || flag4))
								{
									defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 2);
									defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.re());
									defaultInterpolatedStringHandler.AppendFormatted<int>(translationPipeline.RateLimitWaits);
									defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
									defaultInterpolatedStringHandler.AppendFormatted<int>(6);
									defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
									text3 = defaultInterpolatedStringHandler.ToStringAndClear();
								}
								else
								{
									text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iw();
								}
								obj.Invoke(text2 + text3);
								awaiter = System.Threading.Tasks.Task.Delay(retryAfter3, cancellationToken).GetAwaiter();
								if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, G>(ref awaiter, ref this);
									return;
								}
								goto IL_098c;
							}
							if (num6 > 1 && translationPipeline.A(say, c(ex2), _003Csending_003E5__10))
							{
								_003Cattempt_003E5__7--;
							}
							else
							{
								if (ex2 is IAskedToWait && !translationPipeline._answered)
								{
									_003CtheServiceRefused_003E5__3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rf();
									translationPipeline._providerRefusingEverything = true;
									goto IL_0dfa;
								}
								if (_003Cattempt_003E5__7 < translationPipeline.options.MaxAttempts)
								{
									Action<string> obj2 = say;
									string text4;
									if (!C(ex2))
									{
										if (!ex2.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fy(), (StringComparison)4))
										{
											System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(48, 2);
											defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rG());
											defaultInterpolatedStringHandler.AppendFormatted<int>(_003Cattempt_003E5__7 + 1);
											defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
											defaultInterpolatedStringHandler.AppendFormatted<int>(translationPipeline.options.MaxAttempts);
											defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
											text4 = defaultInterpolatedStringHandler.ToStringAndClear();
										}
										else
										{
											System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(24, 3);
											defaultInterpolatedStringHandler.AppendFormatted(ex2.Message);
											defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rg());
											defaultInterpolatedStringHandler.AppendFormatted<int>(_003Cattempt_003E5__7 + 1);
											defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
											defaultInterpolatedStringHandler.AppendFormatted<int>(translationPipeline.options.MaxAttempts);
											defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
											text4 = defaultInterpolatedStringHandler.ToStringAndClear();
										}
									}
									else
									{
										System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(47, 3);
										defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rH());
										defaultInterpolatedStringHandler.AppendFormatted(TextCounts.AfterAWord(((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)_003Cbatch_003E5__8.Units).Count));
										defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rh());
										defaultInterpolatedStringHandler.AppendFormatted<int>(_003Cattempt_003E5__7 + 1);
										defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
										defaultInterpolatedStringHandler.AppendFormatted<int>(translationPipeline.options.MaxAttempts);
										defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
										text4 = defaultInterpolatedStringHandler.ToStringAndClear();
									}
									obj2.Invoke(text4);
								}
							}
						}
					}
					goto IL_0dc4;
					IL_05a3:
					if (_003C_003E7__wrap13 < _003C_003E7__wrap12.Length)
					{
						_003Cpart_003E5__15 = _003C_003E7__wrap12[_003C_003E7__wrap13];
						awaiter2 = translationPipeline.A((System.Collections.Generic.IReadOnlyList<SourceText>)Enumerable.ToList<SourceText>(Enumerable.Select<int, SourceText>((System.Collections.Generic.IEnumerable<int>)_003Cpart_003E5__15, (Func<int, SourceText>)((int P_0) => _003C_003E8__1.units[P_0].Source))), say, cancellationToken, splitsSoFar + 1).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<System.Collections.Generic.IReadOnlyList<TranslationOutcome>>, G>(ref awaiter2, ref this);
							return;
						}
						goto IL_04e4;
					}
					_003C_003E7__wrap12 = null;
					obj3 = new List<int>();
					obj3.AddRange(Enumerable.Where<int>((System.Collections.Generic.IEnumerable<int>)_003Cremaining_003E5__5, (Func<int, bool>)((int P_0) => !_003C_003E8__1.results.ContainsKey(P_0))));
					_003Cremaining_003E5__5 = obj3;
					goto IL_0dfa;
					IL_0e9a:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_0dc4:
					_003Cattempt_003E5__7++;
					goto IL_0dd6;
				}
				Enumerator<int> enumerator2 = _003Cremaining_003E5__5.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						int current2 = enumerator2.Current;
						int valueOrDefault = CollectionExtensions.GetValueOrDefault<int, int>((IReadOnlyDictionary<int, int>)(object)_003CattemptsByIndex_003E5__2, current2, translationPipeline.options.MaxAttempts);
						System.Collections.Generic.IReadOnlyList<QualityIssue> valueOrDefault2 = CollectionExtensions.GetValueOrDefault<int, System.Collections.Generic.IReadOnlyList<QualityIssue>>((IReadOnlyDictionary<int, System.Collections.Generic.IReadOnlyList<QualityIssue>>)(object)_003C_003E8__1.refusalsByIndex, current2, (System.Collections.Generic.IReadOnlyList<QualityIssue>)System.Array.Empty<QualityIssue>());
						object obj4;
						if (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)valueOrDefault2).Count == 0 && _003CtheServiceRefused_003E5__3 != null)
						{
							string text5 = _003CtheServiceRefused_003E5__3;
							obj4 = new QualityIssue
							{
								Kind = QualityIssueKind.Empty,
								Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rk() + text5 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rL()
							};
						}
						else if (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)valueOrDefault2).Count != 0)
						{
							obj4 = new QualityIssue
							{
								Kind = valueOrDefault2[0].Kind
							};
							object obj5 = obj4;
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(47, 1);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rI());
							defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ri());
							((QualityIssue)obj5).Message = defaultInterpolatedStringHandler.ToStringAndClear() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DN(), Enumerable.Select<QualityIssue, string>((System.Collections.Generic.IEnumerable<QualityIssue>)valueOrDefault2, (Func<QualityIssue, string>)((QualityIssue P_0) => P_0.Message)));
						}
						else
						{
							obj4 = new QualityIssue
							{
								Kind = QualityIssueKind.Empty
							};
							object obj6 = obj4;
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(60, 1);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rJ());
							defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rj());
							((QualityIssue)obj6).Message = defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rK();
						}
						QualityIssue qualityIssue = (QualityIssue)obj4;
						_003C_003E8__1.results[current2] = new TranslationOutcome
						{
							Source = _003C_003E8__1.units[current2].Source,
							Status = TranslationStatus.NeedsReview,
							Attempts = valueOrDefault,
							Issues = new L<QualityIssue>(qualityIssue),
							NoModelWasAsked = (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)valueOrDefault2).Count == 0 && _003CtheServiceRefused_003E5__3 != null && !_003C_003E8__1.missingByIndex.Contains(current2))
						};
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
				result3 = (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)Enumerable.ToList<TranslationOutcome>(Enumerable.Select<int, TranslationOutcome>(Enumerable.Range(0, _003C_003E8__1.units.Count), (Func<int, TranslationOutcome>)((int P_0) => _003C_003E8__1.results[P_0])));
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003CattemptsByIndex_003E5__2 = null;
				_003CtheServiceRefused_003E5__3 = null;
				_003CansweredWith_003E5__4 = null;
				_003Cremaining_003E5__5 = null;
				_003CwhyAgain_003E5__6 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003CattemptsByIndex_003E5__2 = null;
			_003CtheServiceRefused_003E5__3 = null;
			_003CansweredWith_003E5__4 = null;
			_003Cremaining_003E5__5 = null;
			_003CwhyAgain_003E5__6 = null;
			_003C_003Et__builder.SetResult(result3);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			_003C_003Et__builder.SetStateMachine(P_0);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct g : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IReadOnlyDictionary<int, string>> _003C_003Et__builder;

		public System.Threading.Tasks.Task<IReadOnlyDictionary<int, string>> request;

		public CancellationToken cancellationToken;

		public Action<string> say;

		public string saying;

		public int texts;

		public string model;

		public int attempt;

		public string whyAgain;

		private Stopwatch _003Cwaiting_003E5__2;

		private TaskAwaiter<System.Threading.Tasks.Task> _003C_003Eu__1;

		private TaskAwaiter<IReadOnlyDictionary<int, string>> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			IReadOnlyDictionary<int, string> result;
			try
			{
				TaskAwaiter<IReadOnlyDictionary<int, string>> awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						_003Cwaiting_003E5__2 = Stopwatch.StartNew();
						goto IL_001c;
					}
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<IReadOnlyDictionary<int, string>>);
					num = (_003C_003E1__state = -1);
					goto IL_00eb;
				}
				TaskAwaiter<System.Threading.Tasks.Task> awaiter2 = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<System.Threading.Tasks.Task>);
				num = (_003C_003E1__state = -1);
				goto IL_0085;
				IL_001c:
				awaiter2 = System.Threading.Tasks.Task.WhenAny((System.Threading.Tasks.Task)request, System.Threading.Tasks.Task.Delay(SayWeAreWaitingEvery, cancellationToken)).GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					num = (_003C_003E1__state = 0);
					_003C_003Eu__1 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<System.Threading.Tasks.Task>, g>(ref awaiter2, ref this);
					return;
				}
				goto IL_0085;
				IL_0085:
				if (awaiter2.GetResult() == request)
				{
					awaiter = request.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IReadOnlyDictionary<int, string>>, g>(ref awaiter, ref this);
						return;
					}
					goto IL_00eb;
				}
				((CancellationToken)(ref cancellationToken)).ThrowIfCancellationRequested();
				Action<string> obj = say;
				TimeSpan elapsed;
				string text2;
				if (saying != null)
				{
					string text = saying;
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pm());
					elapsed = _003Cwaiting_003E5__2.Elapsed;
					defaultInterpolatedStringHandler.AppendFormatted<double>(((TimeSpan)(ref elapsed)).TotalSeconds, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a());
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rn());
					text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 2);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rl());
					defaultInterpolatedStringHandler.AppendFormatted(TextCounts.AsObject(texts));
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rM());
					defaultInterpolatedStringHandler.AppendFormatted(model);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PI());
					string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
					string text4;
					if (attempt <= 1)
					{
						text4 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
					}
					else
					{
						defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 2);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rm());
						defaultInterpolatedStringHandler.AppendFormatted<int>(attempt);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QE());
						defaultInterpolatedStringHandler.AppendFormatted(whyAgain);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
						text4 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(32, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rN());
					elapsed = _003Cwaiting_003E5__2.Elapsed;
					defaultInterpolatedStringHandler.AppendFormatted<double>(((TimeSpan)(ref elapsed)).TotalSeconds, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a());
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rn());
					text2 = text3 + text4 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
				obj.Invoke(text2);
				goto IL_001c;
				IL_00eb:
				result = awaiter.GetResult();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cwaiting_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cwaiting_003E5__2 = null;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine P_0)
		{
			_003C_003Et__builder.SetStateMachine(P_0);
		}
	}

	private readonly ITranslationProvider provider;

	private readonly ITranslationMemory memory;

	private readonly PipelineOptions options;

	private readonly ModelRelay _relay;

	private volatile System.Exception? _lastTransportFailure;

	private volatile bool _answered;

	private volatile bool _providerRefusingEverything;

	private volatile System.Collections.Generic.IReadOnlyList<GlossaryEntry> _discovered = System.Array.Empty<GlossaryEntry>();

	private int _rateLimitWaits;

	private int _paceWaits;

	private const int MaxPaceWaits = 64;

	private int _failuresOnThisModel;

	private const int MaxRateLimitWaits = 6;

	private static readonly TimeSpan LongestWaitWorthSitting = TimeSpan.FromMinutes(2.0);

	private const int FailuresBeforeMovingOn = 1;

	private int _reviewed;

	private int _mendedOnReview;

	private int _reviewRefused;

	private int _reviewRequestsLost;

	private const int MostInFlight = 16;

	private static readonly QualityIssue TheLineFellOut = new QualityIssue
	{
		Kind = QualityIssueKind.Empty,
		Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fh()
	};

	private static readonly TimeSpan SayWeAreWaitingEvery = TimeSpan.FromSeconds(5.0);

	private const int MostSplits = 9;

	private static readonly string[] ContentRefusalWords = new string[6]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fI(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fi(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FW(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fJ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fj(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fK()
	};

	public const string TheReviewIsUnderWay = "نراجع ترجمة الحوار…";

	private HashSet<string> _twoMeanings = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);

	private const string TheModelRefusedThem = "ما لم يقبله في المرة السابقة";

	private ModelInfo model => _relay.Current;

	private ITranslationProvider Provider => _relay.CurrentProvider ?? provider;

	public int ModelsRetired => _relay.Retired;

	public ModelInfo EndedOn => _relay.Current;

	public int RateLimitWaits => Volatile.Read(ref _rateLimitWaits);

	public string? TransportFailureReason => _lastTransportFailure?.Message;

	public System.Exception? TransportFailure => _lastTransportFailure;

	public bool WasAnswered => _answered;

	public ValueTuple<int, int, int, int> Review => new ValueTuple<int, int, int, int>(Volatile.Read(ref _reviewed), Volatile.Read(ref _mendedOnReview), Volatile.Read(ref _reviewRefused), Volatile.Read(ref _reviewRequestsLost));

	[field: CompilerGenerated]
	public bool StoppedEarly
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	private int Concurrency
	{
		get
		{
			int? requestsPerMinute = model.RequestsPerMinute;
			if (!requestsPerMinute.HasValue || requestsPerMinute.GetValueOrDefault() <= 1)
			{
				return 1;
			}
			return Math.Clamp(options.MaxConcurrentRequests, 1, 16);
		}
	}

	public TranslationPipeline(ITranslationProvider provider, ModelInfo model, ITranslationMemory memory, PipelineOptions options, System.Collections.Generic.IReadOnlyList<ModelInfo>? alternates = null, System.Collections.Generic.IReadOnlyList<ITranslationProvider?>? alternateProviders = null)
	{
		this.provider = provider;
		this.memory = memory;
		this.options = options;
		System.Collections.Generic.IReadOnlyList<ModelInfo> readOnlyList = alternates ?? System.Array.Empty<ModelInfo>();
		int num = 0;
		ModelInfo[] array = new ModelInfo[1 + ((System.Collections.Generic.IReadOnlyCollection<ModelInfo>)readOnlyList).Count];
		array[num] = model;
		num++;
		System.Collections.Generic.IEnumerator<ModelInfo> enumerator = ((System.Collections.Generic.IEnumerable<ModelInfo>)readOnlyList).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ModelInfo current = enumerator.Current;
				array[num] = current;
				num++;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IReadOnlyList<ModelInfo> models = new K<ModelInfo>(array);
		System.Collections.Generic.IReadOnlyList<ITranslationProvider> providers;
		if (alternateProviders == null)
		{
			providers = null;
		}
		else
		{
			ITranslationProvider translationProvider = null;
			int num2 = 0;
			ITranslationProvider[] array2 = new ITranslationProvider[1 + ((System.Collections.Generic.IReadOnlyCollection<ITranslationProvider>)alternateProviders).Count];
			array2[num2] = translationProvider;
			num2++;
			System.Collections.Generic.IEnumerator<ITranslationProvider> enumerator2 = ((System.Collections.Generic.IEnumerable<ITranslationProvider>)alternateProviders).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator2).MoveNext())
				{
					ITranslationProvider current2 = enumerator2.Current;
					array2[num2] = current2;
					num2++;
				}
			}
			finally
			{
				((System.IDisposable)enumerator2)?.Dispose();
			}
			providers = new K<ITranslationProvider>(array2);
		}
		_relay = new ModelRelay(models, providers);
	}

	[AsyncStateMachine(typeof(f))]
	public async System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> TranslateAsync(System.Collections.Generic.IReadOnlyList<SourceText> sources, IProgress<TranslationProgress>? progress = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		B CS_0024_003C_003E8__locals0 = new B();
		CS_0024_003C_003E8__locals0.progress = progress;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.cancellationToken = cancellationToken;
		List<TranslationOutcome> outcomes = new List<TranslationOutcome>();
		_twoMeanings = WordsWithTwoMeanings(sources);
		CS_0024_003C_003E8__locals0.pending = new List<SourceText>();
		HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		CS_0024_003C_003E8__locals0.answeredUpFront = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Dictionary<string, int?> roomOf = A(sources);
		System.Collections.Generic.IEnumerator<SourceText> enumerator = ((System.Collections.Generic.IEnumerable<SourceText>)sources).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				SourceText current = enumerator.Current;
				int? valueOrDefault = CollectionExtensions.GetValueOrDefault<string, int?>((IReadOnlyDictionary<string, int?>)(object)roomOf, A(current));
				if (B(current) && A(current.Value, valueOrDefault) != null)
				{
					CS_0024_003C_003E8__locals0.answeredUpFront.Add(current.Value);
				}
				else if (val.Add(A(current)))
				{
					List<SourceText> pending = CS_0024_003C_003E8__locals0.pending;
					SourceText sourceText;
					if (valueOrDefault.HasValue)
					{
						sourceText = current._003CClone_003E_0024();
						sourceText.Room = valueOrDefault;
					}
					else
					{
						sourceText = current;
					}
					pending.Add(sourceText);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		CS_0024_003C_003E8__locals0.translatedByValue = new Dictionary<string, TranslationOutcome>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		CS_0024_003C_003E8__locals0.completedUnique = 0;
		for (int num = CS_0024_003C_003E8__locals0.pending.Count - 1; num >= 0; num--)
		{
			SourceText sourceText2 = CS_0024_003C_003E8__locals0.pending[num];
			if (A(sourceText2.Value))
			{
				CS_0024_003C_003E8__locals0.translatedByValue[A(sourceText2)] = new TranslationOutcome
				{
					Source = sourceText2,
					Value = sourceText2.Value,
					Status = TranslationStatus.Accepted
				};
				CS_0024_003C_003E8__locals0.answeredUpFront.Add(sourceText2.Value);
				CS_0024_003C_003E8__locals0.pending.RemoveAt(num);
			}
			else
			{
				string text = B(sourceText2.Value);
				if (text != null)
				{
					CS_0024_003C_003E8__locals0.translatedByValue[A(sourceText2)] = new TranslationOutcome
					{
						Source = sourceText2,
						Value = text,
						Status = TranslationStatus.Accepted
					};
					CS_0024_003C_003E8__locals0.answeredUpFront.Add(sourceText2.Value);
					CS_0024_003C_003E8__locals0.pending.RemoveAt(num);
				}
			}
		}
		CS_0024_003C_003E8__locals0.startingUsage = TokenUsage.Of(provider);
		System.Collections.Generic.IReadOnlyList<SourceText> terms = GameGlossary.TermsIn(sources);
		CS_0024_003C_003E8__locals0.termValues = new HashSet<string>(Enumerable.Select<SourceText, string>((System.Collections.Generic.IEnumerable<SourceText>)terms, (Func<SourceText, string>)((SourceText P_0) => P_0.Value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		List<SourceText> val2 = Enumerable.ToList<SourceText>(Enumerable.Where<SourceText>((System.Collections.Generic.IEnumerable<SourceText>)CS_0024_003C_003E8__locals0.pending, (Func<SourceText, bool>)((SourceText P_0) => CS_0024_003C_003E8__locals0.termValues.Contains(P_0.Value))));
		List<SourceText> val3 = Enumerable.ToList<SourceText>(Enumerable.Where<SourceText>((System.Collections.Generic.IEnumerable<SourceText>)CS_0024_003C_003E8__locals0.pending, (Func<SourceText, bool>)((SourceText P_0) => !CS_0024_003C_003E8__locals0.termValues.Contains(P_0.Value))));
		List<System.Collections.Generic.IReadOnlyList<SourceText>> val4 = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<SourceText>>(a((System.Collections.Generic.IReadOnlyList<SourceText>)val2));
		List<System.Collections.Generic.IReadOnlyList<SourceText>> restChunks = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<SourceText>>(a((System.Collections.Generic.IReadOnlyList<SourceText>)val3));
		CS_0024_003C_003E8__locals0.chunks = Enumerable.ToList<System.Collections.Generic.IReadOnlyList<SourceText>>(Enumerable.Concat<System.Collections.Generic.IReadOnlyList<SourceText>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<SourceText>>)val4, (System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<SourceText>>)restChunks));
		CS_0024_003C_003E8__locals0.needsReview = 0;
		CS_0024_003C_003E8__locals0.notReached = 0;
		CS_0024_003C_003E8__locals0.finishedBatches = 0;
		CS_0024_003C_003E8__locals0.gate = new SemaphoreSlim(Concurrency, Concurrency);
		if (val4.Count > 0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(58, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RU());
			defaultInterpolatedStringHandler.AppendFormatted<int>(val2.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ru());
			CS_0024_003C_003E8__locals0.A(defaultInterpolatedStringHandler.ToStringAndClear());
			await CS_0024_003C_003E8__locals0.A((System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<SourceText>>)val4);
		}
		if (((System.Collections.Generic.IReadOnlyCollection<SourceText>)terms).Count > 0)
		{
			TranslationOutcome translationOutcome3 = default(TranslationOutcome);
			_discovered = GameGlossary.EntriesFor((System.Collections.Generic.IEnumerable<SourceText>)terms, (string P_0) => (!CS_0024_003C_003E8__locals0.translatedByValue.TryGetValue(P_0, ref translationOutcome3) || translationOutcome3.Status == TranslationStatus.NeedsReview) ? CS_0024_003C_003E8__locals0._003C_003E4__this.b(P_0) : translationOutcome3.Value);
			if (((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)_discovered).Count > 0)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RV());
				defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)_discovered).Count);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rv());
				CS_0024_003C_003E8__locals0.A(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		if (!StoppedEarly)
		{
			await CS_0024_003C_003E8__locals0.A((System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<SourceText>>)restChunks);
		}
		if (!StoppedEarly && options.ReportTotalProviderFailure && !_answered)
		{
			System.Exception lastTransportFailure = _lastTransportFailure;
			if (lastTransportFailure != null && CS_0024_003C_003E8__locals0.pending.Count > 0)
			{
				throw lastTransportFailure;
			}
		}
		enumerator = ((System.Collections.Generic.IEnumerable<SourceText>)sources).GetEnumerator();
		try
		{
			TranslationOutcome translationOutcome = default(TranslationOutcome);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				SourceText current2 = enumerator.Current;
				string text2 = (B(current2) ? A(current2.Value, CollectionExtensions.GetValueOrDefault<string, int?>((IReadOnlyDictionary<string, int?>)(object)roomOf, A(current2))) : null);
				if (CS_0024_003C_003E8__locals0.translatedByValue.TryGetValue(A(current2), ref translationOutcome))
				{
					TranslationOutcome translationOutcome2 = translationOutcome._003CClone_003E_0024();
					translationOutcome2.Source = current2;
					outcomes.Add(translationOutcome2);
				}
				else if (text2 != null)
				{
					outcomes.Add(new TranslationOutcome
					{
						Source = current2,
						Value = text2,
						Status = TranslationStatus.FromMemory
					});
				}
				else if (!StoppedEarly)
				{
					outcomes.Add(new TranslationOutcome
					{
						Source = current2,
						Status = TranslationStatus.NeedsReview,
						Issues = new L<QualityIssue>(new QualityIssue
						{
							Kind = QualityIssueKind.Empty,
							Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RW()
						}),
						NoModelWasAsked = true
					});
				}
			}
			return (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)outcomes;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	[AsyncStateMachine(typeof(g))]
	private static async System.Threading.Tasks.Task<IReadOnlyDictionary<int, string>> A(System.Threading.Tasks.Task<IReadOnlyDictionary<int, string>> P_0, int P_1, string P_2, int P_3, string P_4, Action<string> P_5, CancellationToken P_6, string? saying = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Stopwatch waiting = Stopwatch.StartNew();
		while (await System.Threading.Tasks.Task.WhenAny((System.Threading.Tasks.Task)P_0, System.Threading.Tasks.Task.Delay(SayWeAreWaitingEvery, P_6)) != P_0)
		{
			((CancellationToken)(ref P_6)).ThrowIfCancellationRequested();
			TimeSpan elapsed;
			string text;
			if (saying != null)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 2);
				defaultInterpolatedStringHandler.AppendFormatted(saying);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pm());
				elapsed = waiting.Elapsed;
				defaultInterpolatedStringHandler.AppendFormatted<double>(((TimeSpan)(ref elapsed)).TotalSeconds, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a());
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rn());
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rl());
				defaultInterpolatedStringHandler.AppendFormatted(TextCounts.AsObject(P_1));
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rM());
				defaultInterpolatedStringHandler.AppendFormatted(P_2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PI());
				string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				string text3;
				if (P_3 <= 1)
				{
					text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
				}
				else
				{
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 2);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rm());
					defaultInterpolatedStringHandler.AppendFormatted<int>(P_3);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QE());
					defaultInterpolatedStringHandler.AppendFormatted(P_4);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
					text3 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rN());
				elapsed = waiting.Elapsed;
				defaultInterpolatedStringHandler.AppendFormatted<double>(((TimeSpan)(ref elapsed)).TotalSeconds, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a());
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rn());
				text = text2 + text3 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			P_5.Invoke(text);
		}
		return await P_0;
	}

	private static bool A(System.Exception P_0)
	{
		if (!C(P_0) || (!P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FW(), (StringComparison)5) && !P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fw(), (StringComparison)5) && !P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FX(), (StringComparison)5) && !P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fx(), (StringComparison)5)))
		{
			return a(P_0);
		}
		return true;
	}

	private static bool a(System.Exception P_0)
	{
		System.Exception e = P_0;
		if (e.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FY(), (StringComparison)4))
		{
			return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)ContentRefusalWords, (Func<string, bool>)((string P_0) => e.Message.Contains(P_0, (StringComparison)5)));
		}
		return false;
	}

	private static bool B(System.Exception P_0)
	{
		return P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fy(), (StringComparison)4);
	}

	private static bool b(System.Exception P_0)
	{
		return P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FZ(), (StringComparison)4);
	}

	[AsyncStateMachine(typeof(G))]
	private async System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<TranslationOutcome>> A(System.Collections.Generic.IReadOnlyList<SourceText> P_0, Action<string> P_1, CancellationToken P_2, int P_3 = 0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		List<TranslationUnit> units = Enumerable.ToList<TranslationUnit>(Enumerable.Select<SourceText, TranslationUnit>((System.Collections.Generic.IEnumerable<SourceText>)P_0, (Func<SourceText, TranslationUnit>)b));
		Dictionary<int, TranslationOutcome> results = new Dictionary<int, TranslationOutcome>();
		Dictionary<int, int> attemptsByIndex = new Dictionary<int, int>();
		Dictionary<int, System.Collections.Generic.IReadOnlyList<QualityIssue>> refusalsByIndex = new Dictionary<int, System.Collections.Generic.IReadOnlyList<QualityIssue>>();
		string theServiceRefused = null;
		HashSet<int> missingByIndex = new HashSet<int>();
		Dictionary<int, string> answeredWith = new Dictionary<int, string>();
		List<int> remaining = Enumerable.ToList<int>(Enumerable.Range(0, units.Count));
		string whyAgain = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rt();
		string text4 = default(string);
		for (int attempt = 1; attempt <= options.MaxAttempts && remaining.Count > 0; attempt++)
		{
			if (memory is IMayAnswerLater { MoreMayArrive: not false })
			{
				remaining.RemoveAll((Predicate<int>)((int P_0) => B(units[P_0].Source) && A(units[P_0].Source.Value, units[P_0].Source.Room) != null));
				if (remaining.Count == 0)
				{
					break;
				}
			}
			TranslationBatch batch = new TranslationBatch
			{
				Units = (System.Collections.Generic.IReadOnlyList<TranslationUnit>)Enumerable.ToList<TranslationUnit>(Enumerable.Select<int, TranslationUnit>((System.Collections.Generic.IEnumerable<int>)remaining, (Func<int, TranslationUnit>)delegate(int P_0)
				{
					System.Collections.Generic.IReadOnlyList<QualityIssue> previousRefusals = default(System.Collections.Generic.IReadOnlyList<QualityIssue>);
					if (refusalsByIndex.TryGetValue(P_0, ref previousRefusals))
					{
						TranslationUnit translationUnit2 = units[P_0]._003CClone_003E_0024();
						translationUnit2.PreviousRefusals = previousRefusals;
						return translationUnit2;
					}
					if (missingByIndex.Contains(P_0))
					{
						TranslationUnit translationUnit3 = units[P_0]._003CClone_003E_0024();
						translationUnit3.PreviousRefusals = new L<QualityIssue>(TheLineFellOut);
						return translationUnit3;
					}
					return units[P_0];
				})),
				Style = options.Style,
				Glossary = A(Enumerable.Select<int, TranslationUnit>((System.Collections.Generic.IEnumerable<int>)remaining, (Func<int, TranslationUnit>)((int P_0) => units[P_0]))),
				GameContext = options.GameContext
			};
			ValueTuple<ModelInfo, ITranslationProvider> now = _relay.Now;
			ModelInfo sending = now.Item1;
			ITranslationProvider item = now.Item2;
			IReadOnlyDictionary<int, string> raw;
			try
			{
				raw = await A((item ?? provider).TranslateAsync(batch, sending, P_2), ((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)batch.Units).Count, sending.DisplayName, attempt, whyAgain, P_1, P_2);
			}
			catch (OperationCanceledException)
			{
				throw;
			}
			catch (System.Exception lastTransportFailure)
			{
				System.Exception ex = (_lastTransportFailure = lastTransportFailure);
				bool flag = B(ex);
				bool flag2 = A(ex) && (_answered || !a(ex));
				bool flag3 = b(ex) && _answered;
				if ((flag2 || flag || flag3) && remaining.Count > 1 && P_3 < 9)
				{
					int num = remaining.Count / 2;
					if (flag2)
					{
						P_1.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rw() + TextCounts.AfterAWord(remaining.Count) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RX());
					}
					List<int>[] array = new List<int>[2]
					{
						Enumerable.ToList<int>(Enumerable.Take<int>((System.Collections.Generic.IEnumerable<int>)remaining, num)),
						Enumerable.ToList<int>(Enumerable.Skip<int>((System.Collections.Generic.IEnumerable<int>)remaining, num))
					};
					foreach (List<int> part in array)
					{
						System.Collections.Generic.IReadOnlyList<TranslationOutcome> readOnlyList = await A((System.Collections.Generic.IReadOnlyList<SourceText>)Enumerable.ToList<SourceText>(Enumerable.Select<int, SourceText>((System.Collections.Generic.IEnumerable<int>)part, (Func<int, SourceText>)((int P_0) => units[P_0].Source))), P_1, P_2, P_3 + 1);
						for (int j = 0; j < part.Count; j++)
						{
							if (readOnlyList[j].Value != null)
							{
								results[part[j]] = readOnlyList[j];
								continue;
							}
							refusalsByIndex[part[j]] = readOnlyList[j].Issues;
							attemptsByIndex[part[j]] = attempt;
						}
					}
					List<int> obj = new List<int>();
					obj.AddRange(Enumerable.Where<int>((System.Collections.Generic.IEnumerable<int>)remaining, (Func<int, bool>)((int P_0) => !results.ContainsKey(P_0))));
					remaining = obj;
					break;
				}
				whyAgain = (C(ex) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RY() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rx());
				int num2;
				if (ex is IAskedToWait { RetryAfter: var retryAfter } askedToWait)
				{
					string providerSaid = askedToWait.ProviderSaid;
					if (retryAfter <= LongestWaitWorthSitting)
					{
						num2 = (QuotaExhaustion.IsOurOwnPace(retryAfter, providerSaid) ? 1 : 0);
						goto IL_0662;
					}
				}
				num2 = 0;
				goto IL_0662;
				IL_0662:
				bool flag4 = (byte)num2 != 0;
				int num3 = (flag4 ? Volatile.Read(ref _failuresOnThisModel) : Interlocked.Increment(ref _failuresOnThisModel));
				if (ex is IModelIsGone)
				{
					if (A(P_1, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fc(), sending))
					{
						attempt--;
						continue;
					}
					P_1.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ry());
					theServiceRefused = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RZ();
					_providerRefusingEverything = true;
					break;
				}
				if (ex is IAskedToWait { RetryAfter: var retryAfter2 } askedToWait2)
				{
					string providerSaid2 = askedToWait2.ProviderSaid;
					if (QuotaExhaustion.LooksDaily(retryAfter2, providerSaid2) || QuotaExhaustion.LooksSpent(providerSaid2))
					{
						if (A(P_1, QuotaExhaustion.LooksSpent(providerSaid2) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rA() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rz(), sending))
						{
							attempt--;
							continue;
						}
						bool flag5 = QuotaExhaustion.LooksSpent(providerSaid2);
						P_1.Invoke(flag5 ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rB() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ra());
						theServiceRefused = (flag5 ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rC() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rb());
						_providerRefusingEverything = true;
						break;
					}
				}
				if (options.NeverWaitForABusyService && ex is IAskedToWait)
				{
					if (A(P_1, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rc(), sending))
					{
						attempt--;
						continue;
					}
					P_1.Invoke(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rD());
					theServiceRefused = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rd();
					_providerRefusingEverything = true;
					break;
				}
				if ((num3 <= 1 || !_relay.HasNext) && ex is IAskedToWait { RetryAfter: var retryAfter3 } && retryAfter3 <= LongestWaitWorthSitting && (flag4 ? (Interlocked.Increment(ref _paceWaits) <= 64) : (Interlocked.Increment(ref _rateLimitWaits) <= 6)))
				{
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rE());
					defaultInterpolatedStringHandler.AppendFormatted<double>(((TimeSpan)(ref retryAfter3)).TotalSeconds, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.a());
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nh());
					string text = defaultInterpolatedStringHandler.ToStringAndClear();
					string text2;
					if (!(_relay.HasNext || flag4))
					{
						defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 2);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.re());
						defaultInterpolatedStringHandler.AppendFormatted<int>(RateLimitWaits);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
						defaultInterpolatedStringHandler.AppendFormatted<int>(6);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
						text2 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						text2 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iw();
					}
					P_1.Invoke(text + text2);
					await System.Threading.Tasks.Task.Delay(retryAfter3, P_2);
					attempt--;
					continue;
				}
				if (num3 > 1 && A(P_1, c(ex), sending))
				{
					attempt--;
					continue;
				}
				if (ex is IAskedToWait && !_answered)
				{
					theServiceRefused = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rf();
					_providerRefusingEverything = true;
					break;
				}
				if (attempt >= options.MaxAttempts)
				{
					continue;
				}
				string text3;
				if (!C(ex))
				{
					if (!ex.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fy(), (StringComparison)4))
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(48, 2);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rG());
						defaultInterpolatedStringHandler.AppendFormatted<int>(attempt + 1);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
						defaultInterpolatedStringHandler.AppendFormatted<int>(options.MaxAttempts);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
						text3 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(24, 3);
						defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rg());
						defaultInterpolatedStringHandler.AppendFormatted<int>(attempt + 1);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
						defaultInterpolatedStringHandler.AppendFormatted<int>(options.MaxAttempts);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
						text3 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
				else
				{
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(47, 3);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rH());
					defaultInterpolatedStringHandler.AppendFormatted(TextCounts.AfterAWord(((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)batch.Units).Count));
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rh());
					defaultInterpolatedStringHandler.AppendFormatted<int>(attempt + 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
					defaultInterpolatedStringHandler.AppendFormatted<int>(options.MaxAttempts);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rF());
					text3 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				P_1.Invoke(text3);
				continue;
			}
			_answered = true;
			Interlocked.Exchange(ref _failuresOnThisModel, 0);
			Interlocked.Exchange(ref _rateLimitWaits, 0);
			Interlocked.Exchange(ref _paceWaits, 0);
			whyAgain = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rt();
			List<int> val2 = new List<int>();
			List<int> val3 = new List<int>();
			for (int k = 0; k < remaining.Count; k++)
			{
				int num4 = remaining[k];
				TranslationUnit translationUnit = units[num4];
				attemptsByIndex[num4] = attempt;
				if (!raw.TryGetValue(k + 1, ref text4))
				{
					missingByIndex.Add(num4);
					val2.Add(num4);
					continue;
				}
				System.Collections.Generic.IReadOnlyList<QualityIssue> readOnlyList2;
				TranslationOutcome translationOutcome = A(translationUnit, text4, attempt, out readOnlyList2);
				if ((object)translationOutcome == null)
				{
					refusalsByIndex[num4] = readOnlyList2;
					val2.Add(num4);
					continue;
				}
				Dictionary<int, TranslationOutcome> obj2 = results;
				TranslationOutcome translationOutcome2 = translationOutcome._003CClone_003E_0024();
				translationOutcome2.ByModel = sending.Id;
				obj2[num4] = translationOutcome2;
				answeredWith[num4] = text4;
				val3.Add(num4);
			}
			if (attempt < options.MaxAttempts)
			{
				System.Collections.Generic.IEnumerator<int> enumerator = ((System.Collections.Generic.IEnumerable<int>)AnswersOfAnotherLine.In(Enumerable.Select<int, ValueTuple<int, string, string>>((System.Collections.Generic.IEnumerable<int>)val3, (Func<int, ValueTuple<int, string, string>>)((int P_0) => new ValueTuple<int, string, string>(P_0, units[P_0].Source.Value, results[P_0].Value ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()))))).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						int current = enumerator.Current;
						results.Remove(current);
						answeredWith.Remove(current);
						refusalsByIndex[current] = new L<QualityIssue>(AnswersOfAnotherLine.Issue);
						val2.Add(current);
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			remaining = val2;
		}
		if (options.ReviewTheDialogue && answeredWith.Count > 0)
		{
			await A((System.Collections.Generic.IReadOnlyList<TranslationUnit>)units, results, (IReadOnlyDictionary<int, string>)(object)answeredWith, P_1, P_2);
		}
		Enumerator<int> enumerator2 = remaining.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				int current2 = enumerator2.Current;
				int valueOrDefault = CollectionExtensions.GetValueOrDefault<int, int>((IReadOnlyDictionary<int, int>)(object)attemptsByIndex, current2, options.MaxAttempts);
				System.Collections.Generic.IReadOnlyList<QualityIssue> valueOrDefault2 = CollectionExtensions.GetValueOrDefault<int, System.Collections.Generic.IReadOnlyList<QualityIssue>>((IReadOnlyDictionary<int, System.Collections.Generic.IReadOnlyList<QualityIssue>>)(object)refusalsByIndex, current2, (System.Collections.Generic.IReadOnlyList<QualityIssue>)System.Array.Empty<QualityIssue>());
				object obj3;
				if (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)valueOrDefault2).Count == 0 && theServiceRefused != null)
				{
					string text5 = theServiceRefused;
					obj3 = new QualityIssue
					{
						Kind = QualityIssueKind.Empty,
						Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rk() + text5 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rL()
					};
				}
				else if (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)valueOrDefault2).Count != 0)
				{
					obj3 = new QualityIssue
					{
						Kind = valueOrDefault2[0].Kind
					};
					object obj4 = obj3;
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(47, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rI());
					defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ri());
					((QualityIssue)obj4).Message = defaultInterpolatedStringHandler.ToStringAndClear() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DN(), Enumerable.Select<QualityIssue, string>((System.Collections.Generic.IEnumerable<QualityIssue>)valueOrDefault2, (Func<QualityIssue, string>)((QualityIssue P_0) => P_0.Message)));
				}
				else
				{
					obj3 = new QualityIssue
					{
						Kind = QualityIssueKind.Empty
					};
					object obj5 = obj3;
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(60, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rJ());
					defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rj());
					((QualityIssue)obj5).Message = defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rK();
				}
				QualityIssue qualityIssue = (QualityIssue)obj3;
				results[current2] = new TranslationOutcome
				{
					Source = units[current2].Source,
					Status = TranslationStatus.NeedsReview,
					Attempts = valueOrDefault,
					Issues = new L<QualityIssue>(qualityIssue),
					NoModelWasAsked = (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)valueOrDefault2).Count == 0 && theServiceRefused != null && !missingByIndex.Contains(current2))
				};
			}
		}
		finally
		{
			((System.IDisposable)enumerator2).Dispose();
		}
		return (System.Collections.Generic.IReadOnlyList<TranslationOutcome>)Enumerable.ToList<TranslationOutcome>(Enumerable.Select<int, TranslationOutcome>(Enumerable.Range(0, units.Count), (Func<int, TranslationOutcome>)((int P_0) => results[P_0])));
	}

	[AsyncStateMachine(typeof(F))]
	private System.Threading.Tasks.Task A(System.Collections.Generic.IReadOnlyList<TranslationUnit> P_0, Dictionary<int, TranslationOutcome> P_1, IReadOnlyDictionary<int, string> P_2, Action<string> P_3, CancellationToken P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		F f = default(F);
		f._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		f._003C_003E4__this = this;
		f.units = P_0;
		f.results = P_1;
		f.answeredWith = P_2;
		f.say = P_3;
		f.cancellationToken = P_4;
		f._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref f._003C_003Et__builder)).Start<F>(ref f);
		return ((AsyncTaskMethodBuilder)(ref f._003C_003Et__builder)).Task;
	}

	private TranslationOutcome? A(TranslationUnit P_0, string P_1, int P_2, out System.Collections.Generic.IReadOnlyList<QualityIssue> P_3)
	{
		TranslationUnit unit = P_0;
		P_3 = System.Array.Empty<QualityIssue>();
		P_1 = HangingArticle.Mend(P_1);
		P_1 = EnglishPluralMark.Mend(unit.Source.Value, P_1);
		System.Collections.Generic.IReadOnlyList<string> readOnlyList = unit.Masked.Tokens;
		if (StoryGods.NamesAStoryGod(unit.Masked.Masked))
		{
			P_1 = StoryGods.Mend(P_1);
			List<string> obj = new List<string>();
			obj.AddRange(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)readOnlyList, (Func<string, string>)((string P_0) => (!ArabicScript.IsAlreadyArabic(P_0)) ? P_0 : StoryGods.Mend(P_0))));
			readOnlyList = new k<string>(obj);
		}
		bool? faith = options.TheGameSpeaksOfAHeavenlyFaith;
		P_1 = NamesOnlyAllahBears.Mend(unit.Source.Value, P_1, faith);
		List<string> obj2 = new List<string>();
		obj2.AddRange(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)readOnlyList, (Func<string, string>)((string P_0) => (!ArabicScript.IsAlreadyArabic(P_0)) ? P_0 : NamesOnlyAllahBears.Mend(unit.Source.Value, P_0, faith))));
		readOnlyList = new k<string>(obj2);
		System.Collections.Generic.IReadOnlyList<QualityIssue> readOnlyList2 = QualityChecker.Check(A(unit.Masked.Masked, readOnlyList), A(P_1, readOnlyList), options.Style, options.Glossary, unit.Source.Room);
		List<QualityIssue> val = Enumerable.ToList<QualityIssue>(Enumerable.Where<QualityIssue>((System.Collections.Generic.IEnumerable<QualityIssue>)readOnlyList2, (Func<QualityIssue, bool>)((QualityIssue P_0) => P_0.Blocking && (!P_0.AcceptedOnLastAttempt || P_2 < options.MaxAttempts))));
		if (val.Count > 0)
		{
			P_3 = (System.Collections.Generic.IReadOnlyList<QualityIssue>)val;
			return null;
		}
		string translatedMasked = LineWrapper.JoinLatinRuns(P_1);
		string text;
		try
		{
			text = VariableMasker.Unmask(translatedMasked, readOnlyList);
		}
		catch (MaskRestoreException)
		{
			P_3 = new L<QualityIssue>(new QualityIssue
			{
				Kind = QualityIssueKind.PlaceholderMismatch,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fz()
			});
			return null;
		}
		WrapResult wrapResult = null;
		WrapConstraints wrapping = options.Wrapping;
		FontMetrics metrics = default(FontMetrics);
		int num;
		if ((object)wrapping != null)
		{
			metrics = options.Metrics;
			num = ((metrics != null) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		bool flag = (byte)num != 0;
		if (flag)
		{
			TextType textType = unit.Source.TextType;
			bool flag2 = ((textType == TextType.Dialogue || textType == TextType.System) ? true : false);
			flag = flag2;
		}
		if (flag)
		{
			wrapResult = LineWrapper.Wrap(text, metrics, wrapping);
			text = wrapResult.ToText();
		}
		return new TranslationOutcome
		{
			Source = unit.Source,
			Value = text,
			Status = TranslationStatus.Accepted,
			Issues = readOnlyList2,
			Attempts = P_2,
			Wrapping = wrapResult
		};
	}

	private static bool A(string P_0)
	{
		if (!Untranslatable.Is(P_0))
		{
			return Untranslatable.IsFiller(P_0);
		}
		return true;
	}

	public static HashSet<string> WordsWithTwoMeanings(System.Collections.Generic.IReadOnlyList<SourceText> sources)
	{
		return Enumerable.ToHashSet<string>(Enumerable.Select<IGrouping<string, SourceText>, string>(Enumerable.Where<IGrouping<string, SourceText>>(Enumerable.GroupBy<SourceText, string>(Enumerable.Where<SourceText>((System.Collections.Generic.IEnumerable<SourceText>)sources, (Func<SourceText, bool>)((SourceText P_0) => a(P_0.Value) && ReadableKey.Of(P_0.Key) != null)), (Func<SourceText, string>)((SourceText P_0) => P_0.Value), (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<IGrouping<string, SourceText>, bool>)((IGrouping<string, SourceText> P_0) => Enumerable.Any<string>(Enumerable.Skip<string>(Enumerable.Distinct<string>(Enumerable.Select<SourceText, string>((System.Collections.Generic.IEnumerable<SourceText>)P_0, (Func<SourceText, string>)((SourceText P_0) => P_0.Key)), (IEqualityComparer<string>)(object)StringComparer.Ordinal), 1)))), (Func<IGrouping<string, SourceText>, string>)((IGrouping<string, SourceText> P_0) => P_0.Key)), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
	}

	private static bool a(string P_0)
	{
		return P_0.Split((char[])null, (StringSplitOptions)1).Length <= 2;
	}

	private string A(SourceText P_0)
	{
		if (!a(P_0))
		{
			return P_0.Value;
		}
		return P_0.Value + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fA() + P_0.Key;
	}

	private bool a(SourceText P_0)
	{
		if (_twoMeanings.Contains(P_0.Value))
		{
			return ReadableKey.Of(P_0.Key) != null;
		}
		return false;
	}

	private bool B(SourceText P_0)
	{
		if (a(P_0))
		{
			return options.TheMemoryAnswersWordsThatStandApart;
		}
		return true;
	}

	private static bool A(TranslationOutcome P_0)
	{
		if (P_0.Status == TranslationStatus.NeedsReview && ((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)P_0.Issues).Count > 0)
		{
			return Enumerable.All<QualityIssue>((System.Collections.Generic.IEnumerable<QualityIssue>)P_0.Issues, (Func<QualityIssue, bool>)((QualityIssue P_0) => P_0.Kind == QualityIssueKind.Empty));
		}
		return false;
	}

	private string? B(string P_0)
	{
		if (((System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, string>>)options.SettledTerms).Count == 0)
		{
			return null;
		}
		MaskedText maskedText = VariableMasker.Mask(P_0, maskNewlines: false, options.SettledTerms);
		if (((System.Collections.Generic.IReadOnlyCollection<string>)maskedText.Tokens).Count == 0 || !Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)maskedText.Tokens, (Func<string, bool>)ArabicScript.IsAlreadyArabic))
		{
			return null;
		}
		string[] array = maskedText.Masked.Split((char[])null, (StringSplitOptions)1);
		foreach (string text in array)
		{
			if (Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsLetter) && !text.StartsWith('⟦'))
			{
				return null;
			}
		}
		try
		{
			return VariableMasker.Unmask(maskedText.Masked, maskedText.Tokens);
		}
		catch (MaskRestoreException)
		{
			return null;
		}
	}

	private TranslationUnit b(SourceText P_0)
	{
		TranslationUnit obj = new TranslationUnit
		{
			Source = P_0,
			Masked = VariableMasker.Mask(P_0.Value, maskNewlines: false, options.SettledTerms, options.GameCodes)
		};
		string speaker = P_0.Speaker;
		obj.Speaker = ((speaker == null || speaker.Length <= 0) ? null : (CollectionExtensions.GetValueOrDefault<string, CharacterCard>(options.Characters, speaker) ?? new CharacterCard
		{
			Name = speaker
		}));
		return obj;
	}

	private System.Collections.Generic.IReadOnlyList<GlossaryEntry> A(System.Collections.Generic.IEnumerable<TranslationUnit> P_0)
	{
		List<string> texts = Enumerable.ToList<string>(Enumerable.Select<TranslationUnit, string>(P_0, (Func<TranslationUnit, string>)((TranslationUnit P_0) => P_0.Masked.Masked)));
		return (System.Collections.Generic.IReadOnlyList<GlossaryEntry>)Enumerable.ToList<GlossaryEntry>(Enumerable.Where<GlossaryEntry>((System.Collections.Generic.IEnumerable<GlossaryEntry>)GameGlossary.Merge(options.Glossary, _discovered), (Func<GlossaryEntry, bool>)((GlossaryEntry P_0) => Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)texts, (Func<string, bool>)((string P_0) => P_0.Contains(P_0.Term, TermMatch.ComparisonFor(P_0.Term)))))));
	}

	private string? A(string P_0, int? P_1)
	{
		string text = b(P_0);
		if (text == null || !TheRoomOfALine.Fits(text, P_1))
		{
			return null;
		}
		return text;
	}

	private Dictionary<string, int?> A(System.Collections.Generic.IReadOnlyList<SourceText> P_0)
	{
		Dictionary<string, int?> val = new Dictionary<string, int?>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<SourceText> enumerator = ((System.Collections.Generic.IEnumerable<SourceText>)P_0).GetEnumerator();
		try
		{
			int? num = default(int?);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				SourceText current = enumerator.Current;
				int? room = current.Room;
				if (room.HasValue)
				{
					int valueOrDefault = room.GetValueOrDefault();
					string text = A(current);
					int num2;
					if (val.TryGetValue(text, ref num) && num.HasValue)
					{
						int valueOrDefault2 = num.GetValueOrDefault();
						num2 = Math.Min(valueOrDefault2, valueOrDefault);
					}
					else
					{
						num2 = valueOrDefault;
					}
					val[text] = num2;
				}
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private string? b(string P_0)
	{
		string text = memory.Lookup(P_0);
		if (text == null || !QualityChecker.HonoursTheLockedTerms(P_0, text, options.Glossary) || !B(P_0, text) || !A(P_0, text))
		{
			return null;
		}
		return WithTheSourcesEdges(P_0, a(P_0, text));
	}

	public static string WithTheSourcesEdges(string source, string answer)
	{
		int i;
		for (i = 0; i < source.Length && char.IsWhiteSpace(source[i]); i++)
		{
		}
		if (i == source.Length)
		{
			return answer;
		}
		int num = source.Length;
		while (num > i && char.IsWhiteSpace(source[num - 1]))
		{
			num--;
		}
		string text = source.Substring(0, i);
		string text2 = answer.Trim();
		int num2 = num;
		return text + text2 + source.Substring(num2, source.Length - num2);
	}

	private bool A(string P_0, string P_1)
	{
		return Enumerable.SequenceEqual<string>(C(P_0), C(P_1), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
	}

	private string a(string P_0, string P_1)
	{
		MaskedText maskedText = VariableMasker.Mask(P_1);
		string text = HangingArticle.Mend(maskedText.Masked);
		string masked = VariableMasker.Mask(P_0).Masked;
		string text2 = StoryGods.Mend(text);
		if (!string.Equals(text2, text, (StringComparison)4) && StoryGods.NamesAStoryGod(masked))
		{
			text = text2;
		}
		text = NamesOnlyAllahBears.Mend(P_0, text, options.TheGameSpeaksOfAHeavenlyFaith);
		if (!string.Equals(text, maskedText.Masked, (StringComparison)4))
		{
			return VariableMasker.Unmask(text, maskedText.Tokens);
		}
		return P_1;
	}

	private bool B(string P_0, string P_1)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (((System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, string>>)options.SettledTerms).Count == 0)
		{
			return true;
		}
		System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)options.SettledTerms).GetEnumerator();
		try
		{
			string text = default(string);
			string text2 = default(string);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.Current.Deconstruct(ref text, ref text2);
				string text3 = text;
				string text4 = text2;
				if (P_0.Contains(text3, (StringComparison)5) && !P_1.Contains(text4, (StringComparison)4))
				{
					return false;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return true;
	}

	private static string A(string P_0, System.Collections.Generic.IReadOnlyList<string> P_1)
	{
		if (((System.Collections.Generic.IReadOnlyCollection<string>)P_1).Count == 0 || !Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)P_1, (Func<string, bool>)ArabicScript.IsAlreadyArabic))
		{
			return P_0;
		}
		string text = P_0;
		for (int i = 0; i < ((System.Collections.Generic.IReadOnlyCollection<string>)P_1).Count; i++)
		{
			if (ArabicScript.IsAlreadyArabic(P_1[i]))
			{
				string text2 = text;
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fa());
				defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fB());
				text = text2.Replace(defaultInterpolatedStringHandler.ToStringAndClear(), P_1[i], (StringComparison)4);
			}
		}
		return text;
	}

	private static bool C(System.Exception P_0)
	{
		if (!P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fb(), (StringComparison)5))
		{
			return P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fC(), (StringComparison)4);
		}
		return true;
	}

	private static string c(System.Exception P_0)
	{
		if (!(P_0 is IModelIsGone))
		{
			if (P_0 is IAskedToWait)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fD();
			}
			if (C(P_0))
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fd();
			}
			if (P_0.Message.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fE(), (StringComparison)5))
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fe();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fF();
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fc();
	}

	private bool A(Action<string> P_0, string P_1, ModelInfo P_2)
	{
		ModelInfo current = _relay.Current;
		if ((object)current != P_2 && !string.Equals(current.Id, P_2.Id, (StringComparison)4))
		{
			return true;
		}
		ModelInfo modelInfo = _relay.Retire(current);
		if ((object)modelInfo == null)
		{
			return false;
		}
		Interlocked.Exchange(ref _rateLimitWaits, 0);
		Interlocked.Exchange(ref _paceWaits, 0);
		Interlocked.Exchange(ref _failuresOnThisModel, 0);
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(26, 3);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW());
		defaultInterpolatedStringHandler.AppendFormatted(current.DisplayName);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ff());
		defaultInterpolatedStringHandler.AppendFormatted(P_1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fG());
		defaultInterpolatedStringHandler.AppendFormatted(modelInfo.DisplayName);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fg());
		P_0.Invoke(defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fH());
		return true;
	}

	private ValueTuple<int, int> A()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int?, int?> val = BatchLimits.ForContextWindow(_relay.SmallestContextWindow);
		int? item = val.Item1;
		int? item2 = val.Item2;
		return new ValueTuple<int, int>(item ?? options.BatchSize, item2 ?? options.MaxBatchCharacters);
	}

	private System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<SourceText>> a(System.Collections.Generic.IReadOnlyList<SourceText> P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<int, int> val = A();
		int item = val.Item1;
		int item2 = val.Item2;
		return BatchLimits.Plan((System.Collections.Generic.IEnumerable<SourceText>)P_0, item, item2, (SourceText P_0) => P_0.Value.Length);
	}

	[CompilerGenerated]
	private System.Collections.Generic.IEnumerable<string> C(string P_0)
	{
		return (System.Collections.Generic.IEnumerable<string>)Enumerable.Order<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)VariableMasker.Mask(P_0, maskNewlines: false, null, options.GameCodes).Tokens, (Func<string, string>)((string P_0) => P_0.Trim())), (IComparer<string>)(object)StringComparer.Ordinal);
	}
}
