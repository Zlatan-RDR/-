using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

[SupportedOSPlatform("windows")]
public static class TheKeysOnTheStacks
{
	private struct A
	{
		public uint Size;

		public uint Usage;

		public uint ThreadId;

		public uint OwnerProcessId;

		public int BasePri;

		public int DeltaPri;

		public uint Flags;
	}

	private struct a
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

	[CompilerGenerated]
	private sealed class B : global::System.Collections.Generic.IEnumerable<uint>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<uint>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private uint _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int processId;

		public int _003C_003E3__processId;

		private nint _003Csnap_003E5__2;

		private A _003Centry_003E5__3;

		uint global::System.Collections.Generic.IEnumerator<uint>.Current
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
		public B(int P_0)
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
			bool result;
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num == 1)
					{
						_003C_003E1__state = -3;
						goto IL_00bf;
					}
					result = false;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Csnap_003E5__2 = TheKeysOnTheStacks.A(4u, 0u);
					if (_003Csnap_003E5__2 == (nint)global::System.IntPtr.Zero || _003Csnap_003E5__2 == new global::System.IntPtr(-1))
					{
						result = false;
					}
					else
					{
						_003C_003E1__state = -3;
						_003Centry_003E5__3 = new A
						{
							Size = (uint)Marshal.SizeOf<A>()
						};
						if (TheKeysOnTheStacks.A(_003Csnap_003E5__2, ref _003Centry_003E5__3))
						{
							goto IL_0088;
						}
						result = false;
						a();
					}
				}
				goto end_IL_0000;
				IL_0088:
				if (_003Centry_003E5__3.OwnerProcessId != (uint)processId)
				{
					goto IL_00bf;
				}
				_003C_003E2__current = _003Centry_003E5__3.ThreadId;
				_003C_003E1__state = 1;
				result = true;
				goto end_IL_0000;
				IL_00bf:
				if (TheKeysOnTheStacks.a(_003Csnap_003E5__2, ref _003Centry_003E5__3))
				{
					goto IL_0088;
				}
				a();
				result = false;
				end_IL_0000:;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
			return result;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			TheKeysOnTheStacks.B(_003Csnap_003E5__2);
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
		private global::System.Collections.Generic.IEnumerator<uint> b()
		{
			B b;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				b = this;
			}
			else
			{
				b = new B(0);
			}
			b.processId = _003C_003E3__processId;
			return b;
		}

		global::System.Collections.Generic.IEnumerator<uint> global::System.Collections.Generic.IEnumerable<uint>.GetEnumerator()
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

	private const int MemCommit = 4096;

	private const int PageReadWrite = 4;

	private const int PageExecuteReadWrite = 64;

	private const int ProcessQueryInformation = 1024;

	private const int ProcessVmRead = 16;

	private const int ThreadGetContext = 8;

	private const int ThreadSuspendResume = 2;

	private const uint TH32CS_SNAPTHREAD = 4u;

	public static byte[]? SweepProcess(int processId, byte[] lockedIndex, ALockedIndex index, CancellationToken stopping = default(CancellationToken))
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)lockedIndex, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CK());
		nint num = A(1040, false, processId);
		if (num == (nint)global::System.IntPtr.Zero)
		{
			return null;
		}
		Aes val = Aes.Create();
		try
		{
			((SymmetricAlgorithm)val).Mode = (CipherMode)2;
			((SymmetricAlgorithm)val).Padding = (PaddingMode)1;
			try
			{
				global::System.Collections.Generic.IEnumerator<uint> enumerator = A(processId).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
					{
						uint current = enumerator.Current;
						((CancellationToken)(ref stopping)).ThrowIfCancellationRequested();
						nint num2 = A(10, false, current);
						if (num2 == (nint)global::System.IntPtr.Zero)
						{
							continue;
						}
						try
						{
							if (A(num2) == 4294967295u)
							{
								continue;
							}
							using AThreadsContext aThreadsContext = new AThreadsContext();
							if (!aThreadsContext.ReadRegisters(num2) || aThreadsContext.Rsp == 0L)
							{
								continue;
							}
							ValueTuple<nint, long> val2 = A(num, (nint)aThreadsContext.Rsp);
							if (val2.Item2 <= 0 || val2.Item2 > 2147483647)
							{
								continue;
							}
							byte[] array = new byte[val2.Item2];
							if (A(num, val2.Item1, array, array.Length, out var num3) && num3 > 0)
							{
								byte[] array2 = TheKeyOnTheStack.InWindow(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(array, 0, num3)), global::System.ReadOnlySpan<byte>.op_Implicit(lockedIndex), index);
								if (array2 != null)
								{
									return array2;
								}
							}
						}
						finally
						{
							a(num2);
							B(num2);
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				B(num);
			}
			return null;
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static ValueTuple<nint, long> A(nint P_0, nint P_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (A(P_0, P_1, out var a, Marshal.SizeOf<a>()) == 0)
		{
			return new ValueTuple<nint, long>((nint)global::System.IntPtr.Zero, 0L);
		}
		bool flag = (a.Protect & 0x44) != 0;
		if (a.State != 4096 || !flag)
		{
			return new ValueTuple<nint, long>((nint)global::System.IntPtr.Zero, 0L);
		}
		return new ValueTuple<nint, long>(a.BaseAddress, (long)a.RegionSize);
	}

	[IteratorStateMachine(typeof(B))]
	private static global::System.Collections.Generic.IEnumerable<uint> A(int P_0)
	{
		nint snap = A(4u, 0u);
		if (snap == (nint)global::System.IntPtr.Zero || snap == new global::System.IntPtr(-1))
		{
			yield break;
		}
		try
		{
			A entry = new A
			{
				Size = (uint)Marshal.SizeOf<A>()
			};
			if (!A(snap, ref entry))
			{
				yield break;
			}
			do
			{
				if (entry.OwnerProcessId == (uint)P_0)
				{
					yield return entry.ThreadId;
				}
			}
			while (a(snap, ref entry));
		}
		finally
		{
			B(snap);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
	private static extern nint A(int P_0, [MarshalAs(2)] bool P_1, int P_2);

	[DllImport("kernel32.dll", EntryPoint = "OpenThread", SetLastError = true)]
	private static extern nint A(int P_0, [MarshalAs(2)] bool P_1, uint P_2);

	[DllImport("kernel32.dll", EntryPoint = "SuspendThread", SetLastError = true)]
	private static extern uint A(nint P_0);

	[DllImport("kernel32.dll", EntryPoint = "ResumeThread", SetLastError = true)]
	private static extern uint a(nint P_0);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool B(nint P_0);

	[DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx", SetLastError = true)]
	private static extern int A(nint P_0, nint P_1, out a P_2, int P_3);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, nint P_1, byte[] P_2, int P_3, out int P_4);

	[DllImport("kernel32.dll", EntryPoint = "CreateToolhelp32Snapshot", SetLastError = true)]
	private static extern nint A(uint P_0, uint P_1);

	[DllImport("kernel32.dll", EntryPoint = "Thread32First", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, ref A P_1);

	[DllImport("kernel32.dll", EntryPoint = "Thread32Next", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool a(nint P_0, ref A P_1);
}
