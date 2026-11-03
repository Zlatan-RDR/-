using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Live;

namespace Miqbas.Engines.Unreal.Packages;

public static class TheKeyInTheGamesMemory
{
	private readonly struct A : IEquatable<A>
	{
		[field: CompilerGenerated]
		public nint At
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public long Size
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public A(nint P_0, long P_1)
		{
			At = P_0;
			Size = P_1;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hm());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HN());
			P_0.Append(((object)At).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BK());
			P_0.Append(((object)Size).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(A P_0, A P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(A P_0, A P_1)
		{
			return P_0.Equals(P_1);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<nint>.Default.GetHashCode(At) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Size);
		}

		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			if (obj is A)
			{
				return Equals((A)obj);
			}
			return false;
		}

		[CompilerGenerated]
		public bool Equals(A other)
		{
			if (EqualityComparer<nint>.Default.Equals(At, other.At))
			{
				return EqualityComparer<long>.Default.Equals(Size, other.Size);
			}
			return false;
		}

		[CompilerGenerated]
		public void A(out nint P_0, out long P_1)
		{
			P_0 = At;
			P_1 = Size;
		}
	}

	private sealed class a : global::System.IDisposable
	{
		private readonly Aes _cipher = Aes.Create();

		private readonly byte[] _window = new byte[4194304];

		public a()
		{
			((SymmetricAlgorithm)_cipher).Mode = (CipherMode)2;
			((SymmetricAlgorithm)_cipher).Padding = (PaddingMode)1;
		}

		public byte[]? A(nint P_0, A P_1, byte[] P_2, ALockedIndex P_3)
		{
			int num3;
			for (long num = 0L; num < P_1.Size; num += Math.Max(4, num3 - 32 + 4))
			{
				int num2 = (int)Math.Min(4194304L, P_1.Size - num);
				if (!TheKeyInTheGamesMemory.A(P_0, new global::System.IntPtr(P_1.At + num), _window, num2, out num3) || num3 < 32)
				{
					return null;
				}
				int num4 = num3 - 32;
				for (int i = 0; i <= num4; i += 4)
				{
					global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(_window, i, 32);
					if (TheKeyThatOpensThisPackage.CouldBeTheKey(_cipher, global::System.ReadOnlySpan<byte>.op_Implicit(P_2), global::System.Span<byte>.op_Implicit(span)) && TheKeyThatOpensThisPackage.Opens(global::System.ReadOnlySpan<byte>.op_Implicit(P_2), P_3, global::System.Span<byte>.op_Implicit(span)))
					{
						return span.ToArray();
					}
				}
			}
			return null;
		}

		public void Dispose()
		{
			((SymmetricAlgorithm)_cipher).Dispose();
		}
	}

	private struct B
	{
		public nint BaseAddress;

		public nint AllocationBase;

		public int AllocationProtect;

		public int Padding;

		public nint RegionSize;

		public int State;

		public int Protect;

		public int Type;

		public int MorePadding;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class b
	{
		public static readonly b _003C_003E9 = new b();

		public static Func<A, long> _003C_003E9__9_0;

		public static Func<a> _003C_003E9__9_1;

		public static Action<a> _003C_003E9__9_3;

		internal long A(A P_0)
		{
			return P_0.Size;
		}

		internal a A()
		{
			return new a();
		}

		internal void A(a P_0)
		{
			P_0.Dispose();
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public nint game;

		public byte[] lockedIndex;

		public ALockedIndex index;

		public IProgress<double> progress;

		public byte[] found;

		public long done;

		public long total;

		internal a A(A P_0, ParallelLoopState state, a P_2)
		{
			if (found != null || state.ShouldExitCurrentIteration)
			{
				return P_2;
			}
			byte[] array = P_2.A(game, P_0, lockedIndex, index);
			if (array != null)
			{
				Interlocked.CompareExchange<byte[]>(ref found, array, (byte[])null);
				state.Stop();
			}
			long num = Interlocked.Add(ref done, P_0.Size);
			progress?.Report((total <= 0) ? 0.0 : Math.Min(1.0, (double)num / (double)total));
			return P_2;
		}
	}

	[CompilerGenerated]
	private sealed class c : global::System.Collections.Generic.IEnumerable<A>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<A>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private A _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private global::System.Collections.Generic.IEnumerable<A> regions;

		public global::System.Collections.Generic.IEnumerable<A> _003C_003E3__regions;

		private nint game;

		public nint _003C_003E3__game;

		private long _003Cunasked_003E5__2;

		private global::System.Collections.Generic.IEnumerator<A> _003C_003E7__wrap2;

		private global::System.Collections.Generic.IEnumerator<ValueTuple<ulong, ulong>> _003C_003E7__wrap3;

		A global::System.Collections.Generic.IEnumerator<A>.Current
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
		public c(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) > 1u && (uint)(num - 1) > 1u)
			{
				return;
			}
			try
			{
				if (num != -4 && num != 2)
				{
					return;
				}
				try
				{
				}
				finally
				{
					B();
				}
			}
			finally
			{
				a();
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				global::System.Collections.Generic.IReadOnlyList<ValueTuple<ulong, ulong>> readOnlyList;
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003Cunasked_003E5__2 = 0L;
					_003C_003E7__wrap2 = regions.GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_013e;
				case 1:
					_003C_003E1__state = -3;
					goto IL_013e;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_0124;
					}
					IL_013e:
					while (true)
					{
						if (((global::System.Collections.IEnumerator)_003C_003E7__wrap2).MoveNext())
						{
							A current = _003C_003E7__wrap2.Current;
							readOnlyList = ProcessMemory.A(game, (ulong)current.At, (ulong)current.Size);
							if (readOnlyList != null)
							{
								break;
							}
							if (_003Cunasked_003E5__2 + current.Size <= 268435456)
							{
								_003Cunasked_003E5__2 += current.Size;
								_003C_003E2__current = current;
								_003C_003E1__state = 1;
								return true;
							}
							continue;
						}
						a();
						_003C_003E7__wrap2 = null;
						return false;
					}
					_003C_003E7__wrap3 = ((global::System.Collections.Generic.IEnumerable<ValueTuple<ulong, ulong>>)readOnlyList).GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_0124;
					IL_0124:
					while (((global::System.Collections.IEnumerator)_003C_003E7__wrap3).MoveNext())
					{
						ValueTuple<ulong, ulong> current2 = _003C_003E7__wrap3.Current;
						ulong item = current2.Item1;
						ulong item2 = current2.Item2;
						if ((long)item2 >= 32L)
						{
							_003C_003E2__current = new A(new global::System.IntPtr((long)item), (long)item2);
							_003C_003E1__state = 2;
							return true;
						}
					}
					B();
					_003C_003E7__wrap3 = null;
					goto IL_013e;
				}
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

		private void B()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap3 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap3).Dispose();
			}
		}

		[DebuggerHidden]
		private void b()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			this.b();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<A> C()
		{
			c c;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				c = this;
			}
			else
			{
				c = new c(0);
			}
			c.game = _003C_003E3__game;
			c.regions = _003C_003E3__regions;
			return c;
		}

		global::System.Collections.Generic.IEnumerator<A> global::System.Collections.Generic.IEnumerable<A>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator c()
		{
			return (global::System.Collections.IEnumerator)C();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in c
			return this.c();
		}
	}

	[CompilerGenerated]
	private sealed class D : global::System.Collections.Generic.IEnumerable<A>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<A>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private A _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private nint game;

		public nint _003C_003E3__game;

		private nint _003Chighest_003E5__2;

		private B _003Cabout_003E5__3;

		private long _003Csize_003E5__4;

		A global::System.Collections.Generic.IEnumerator<A>.Current
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
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_00fc;
			}
			_003C_003E1__state = -1;
			nint num2 = global::System.IntPtr.Zero;
			_003Chighest_003E5__2 = new global::System.IntPtr(140737488355327L);
			goto IL_0116;
			IL_00fc:
			num2 = new global::System.IntPtr(_003Cabout_003E5__3.BaseAddress + _003Csize_003E5__4);
			goto IL_0116;
			IL_0116:
			if ((long)num2 < (long)_003Chighest_003E5__2)
			{
				if (TheKeyInTheGamesMemory.A(game, num2, out _003Cabout_003E5__3, Marshal.SizeOf<B>()) == 0)
				{
					return false;
				}
				_003Csize_003E5__4 = _003Cabout_003E5__3.RegionSize;
				if (_003Csize_003E5__4 <= 0)
				{
					return false;
				}
				bool flag = ((uint)_003Cabout_003E5__3.Protect & 0x44u) != 0 && (_003Cabout_003E5__3.Protect & 0x100) == 0;
				if (_003Cabout_003E5__3.State == 4096 && _003Cabout_003E5__3.Type == 131072 && flag && _003Csize_003E5__4 >= 32)
				{
					_003C_003E2__current = new A(_003Cabout_003E5__3.BaseAddress, _003Csize_003E5__4);
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00fc;
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<A> B()
		{
			D d;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				d = this;
			}
			else
			{
				d = new D(0);
			}
			d.game = _003C_003E3__game;
			return d;
		}

		global::System.Collections.Generic.IEnumerator<A> global::System.Collections.Generic.IEnumerable<A>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator b()
		{
			return (global::System.Collections.IEnumerator)B();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}
	}

	private const int WhereAKeyCanStart = 4;

	private const int WindowSize = 4194304;

	private const int MemCommit = 4096;

	private const int MemPrivate = 131072;

	private const int PageReadWrite = 4;

	private const int PageExecuteReadWrite = 64;

	private const int PageGuard = 256;

	private const int ProcessQueryInformation = 1024;

	private const int ProcessVmRead = 16;

	private const long UnaskedAtMost = 268435456L;

	public static AKeySearch Find(int processId, byte[] lockedIndex, ALockedIndex index, IProgress<double>? progress = null, CancellationToken stopping = default(CancellationToken))
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		byte[] lockedIndex2 = lockedIndex;
		IProgress<double> progress2 = progress;
		ArgumentNullException.ThrowIfNull((object)lockedIndex2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CK());
		Stopwatch val = Stopwatch.StartNew();
		nint game = A(1040, false, processId);
		if (game == (nint)global::System.IntPtr.Zero)
		{
			return new AKeySearch(null, 0L, val.Elapsed, CouldNotOpen: true);
		}
		try
		{
			List<A> val2 = Enumerable.ToList<A>(A(game, A(game)));
			long total = Enumerable.Sum<A>((global::System.Collections.Generic.IEnumerable<A>)val2, (Func<A, long>)((A P_0) => P_0.Size));
			long done = 0L;
			byte[] found = null;
			int maxDegreeOfParallelism = Math.Max(1, Environment.ProcessorCount / 2);
			try
			{
				Parallel.ForEach<A, a>((global::System.Collections.Generic.IEnumerable<A>)val2, new ParallelOptions
				{
					MaxDegreeOfParallelism = maxDegreeOfParallelism,
					CancellationToken = stopping
				}, (Func<a>)(() => new a()), (Func<A, ParallelLoopState, a, a>)delegate(A P_0, ParallelLoopState state, a P_2)
				{
					if (found != null || state.ShouldExitCurrentIteration)
					{
						return P_2;
					}
					byte[] array = P_2.A(game, P_0, lockedIndex2, index);
					if (array != null)
					{
						Interlocked.CompareExchange<byte[]>(ref found, array, (byte[])null);
						state.Stop();
					}
					long num = Interlocked.Add(ref done, P_0.Size);
					progress2?.Report((total <= 0) ? 0.0 : Math.Min(1.0, (double)num / (double)total));
					return P_2;
				}, (Action<a>)delegate(a P_0)
				{
					P_0.Dispose();
				});
			}
			catch (OperationCanceledException)
			{
			}
			return new AKeySearch(found, done, val.Elapsed);
		}
		finally
		{
			a(game);
		}
	}

	[IteratorStateMachine(typeof(c))]
	private static global::System.Collections.Generic.IEnumerable<A> A(nint P_0, global::System.Collections.Generic.IEnumerable<A> P_1)
	{
		long unasked = 0L;
		global::System.Collections.Generic.IEnumerator<A> enumerator = P_1.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				A current = enumerator.Current;
				global::System.Collections.Generic.IReadOnlyList<ValueTuple<ulong, ulong>> readOnlyList = ProcessMemory.A(P_0, (ulong)current.At, (ulong)current.Size);
				if (readOnlyList == null)
				{
					if (unasked + current.Size <= 268435456)
					{
						unasked += current.Size;
						yield return current;
					}
					continue;
				}
				global::System.Collections.Generic.IEnumerator<ValueTuple<ulong, ulong>> enumerator2 = ((global::System.Collections.Generic.IEnumerable<ValueTuple<ulong, ulong>>)readOnlyList).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ValueTuple<ulong, ulong> current2 = enumerator2.Current;
						ulong item = current2.Item1;
						ulong item2 = current2.Item2;
						if ((long)item2 >= 32L)
						{
							yield return new A(new global::System.IntPtr((long)item), (long)item2);
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
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[IteratorStateMachine(typeof(D))]
	private static global::System.Collections.Generic.IEnumerable<A> A(nint P_0)
	{
		nint num = global::System.IntPtr.Zero;
		nint highest = new global::System.IntPtr(140737488355327L);
		B about;
		while ((long)num < (long)highest && A(P_0, num, out about, Marshal.SizeOf<B>()) != 0)
		{
			long size = about.RegionSize;
			if (size <= 0)
			{
				break;
			}
			bool flag = ((uint)about.Protect & 0x44u) != 0 && (about.Protect & 0x100) == 0;
			if (about.State == 4096 && about.Type == 131072 && flag && size >= 32)
			{
				yield return new A(about.BaseAddress, size);
			}
			num = new global::System.IntPtr(about.BaseAddress + size);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
	private static extern nint A(int P_0, [MarshalAs(2)] bool P_1, int P_2);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool a(nint P_0);

	[DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx", SetLastError = true)]
	private static extern int A(nint P_0, nint P_1, out B P_2, int P_3);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, nint P_1, byte[] P_2, int P_3, out int P_4);
}
