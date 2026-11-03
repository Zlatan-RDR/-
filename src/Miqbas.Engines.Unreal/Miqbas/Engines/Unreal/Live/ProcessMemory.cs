using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class ProcessMemory : global::System.IDisposable
{
	private struct A
	{
		public nint VirtualAddress;

		public nuint VirtualAttributes;
	}

	private struct a
	{
		public nint ExitStatus;

		public nint PebBaseAddress;

		public nint AffinityMask;

		public nint BasePriority;

		public nint UniqueProcessId;

		public nint InheritedFromUniqueProcessId;
	}

	private struct B
	{
		public nint BaseAddress;

		public nint AllocationBase;

		public int AllocationProtect;

		public int Alignment1;

		public nint RegionSize;

		public int State;

		public int Protect;

		public int Type;

		public int Alignment2;
	}

	[CompilerGenerated]
	private sealed class b : global::System.Collections.Generic.IEnumerable<MemoryRegion>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<MemoryRegion>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private MemoryRegion _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ProcessMemory _003C_003E4__this;

		private B _003Cinfo_003E5__2;

		private ulong _003Csize_003E5__3;

		MemoryRegion global::System.Collections.Generic.IEnumerator<MemoryRegion>.Current
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
		public b(int P_0)
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
			ProcessMemory processMemory = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_00d8;
			}
			_003C_003E1__state = -1;
			ulong num2 = 0uL;
			goto IL_00ec;
			IL_00d8:
			num2 = (ulong)_003Cinfo_003E5__2.BaseAddress + _003Csize_003E5__3;
			goto IL_00ec;
			IL_00ec:
			if (num2 < 140737488289792L)
			{
				if (ProcessMemory.A(processMemory._handle, (nint)num2, out _003Cinfo_003E5__2, Marshal.SizeOf<B>()) == 0)
				{
					return false;
				}
				_003Csize_003E5__3 = (ulong)_003Cinfo_003E5__2.RegionSize;
				if (_003Csize_003E5__3 == 0L)
				{
					return false;
				}
				if (_003Cinfo_003E5__2.State == 4096 && (_003Cinfo_003E5__2.Protect & 1) == 0 && (_003Cinfo_003E5__2.Protect & 0x100) == 0)
				{
					_003C_003E2__current = new MemoryRegion((ulong)_003Cinfo_003E5__2.BaseAddress, _003Csize_003E5__3, _003Cinfo_003E5__2.Protect, _003Cinfo_003E5__2.Type);
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00d8;
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
		private global::System.Collections.Generic.IEnumerator<MemoryRegion> B()
		{
			b result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new b(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		global::System.Collections.Generic.IEnumerator<MemoryRegion> global::System.Collections.Generic.IEnumerable<MemoryRegion>.GetEnumerator()
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

	private const int ProcessVmOperation = 8;

	private const int ProcessVmRead = 16;

	private const int ProcessVmWrite = 32;

	private const int ProcessQueryInformation = 1024;

	private readonly nint _handle;

	private ProcessMemory(nint P_0)
	{
		_handle = P_0;
	}

	public static ProcessMemory Open(int processId)
	{
		return Open(processId, forWriting: false);
	}

	public static ProcessMemory Open(int processId, bool forWriting)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		int num = 1040;
		if (forWriting)
		{
			num |= 0x28;
		}
		nint num2 = A(num, false, processId);
		if (num2 == 0)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fe());
			defaultInterpolatedStringHandler.AppendFormatted<int>(processId);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FF());
			defaultInterpolatedStringHandler.AppendFormatted<int>(lastWin32Error);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ff());
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear() + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FG());
		}
		return new ProcessMemory(num2);
	}

	public byte[] ReadBytes(ulong address, int count)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		byte[] array = new byte[count];
		if (!A(_handle, (nint)address, array, count, out var num) || num != count)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(32, 4);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fg());
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FH());
			defaultInterpolatedStringHandler.AppendFormatted<ulong>(address, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eq());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fh());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FI());
			defaultInterpolatedStringHandler.AppendFormatted<int>(lastWin32Error);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bo());
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return array;
	}

	public int TryReadBytes(ulong address, byte[] buffer)
	{
		if (!A(_handle, (nint)address, buffer, buffer.Length, out var result))
		{
			return 0;
		}
		return result;
	}

	public bool WriteBytes(ulong address, byte[] bytes)
	{
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		if (a(_handle, (nint)address, bytes, bytes.Length, out var num))
		{
			return num == bytes.Length;
		}
		return false;
	}

	public ulong ReadPointer(ulong address)
	{
		return BitConverter.ToUInt64(global::System.ReadOnlySpan<byte>.op_Implicit(ReadBytes(address, 8)));
	}

	public ulong ImageBase()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		a a = default(a);
		int num;
		int num2 = A(_handle, 0, ref a, Marshal.SizeOf<a>(), out num);
		if (num2 != 0 || a.PebBaseAddress == 0)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fi());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FJ());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bo());
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return ReadPointer((ulong)a.PebBaseAddress + 16uL);
	}

	public static string? PathOf(int processId)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		nint num = A(4096, false, processId);
		if (num == 0)
		{
			return null;
		}
		try
		{
			StringBuilder val = new StringBuilder(1024);
			int capacity = val.Capacity;
			return A(num, 0, val, ref capacity) ? ((object)val).ToString() : null;
		}
		finally
		{
			A(num);
		}
	}

	public int ReadInt32(ulong address)
	{
		return BitConverter.ToInt32(global::System.ReadOnlySpan<byte>.op_Implicit(ReadBytes(address, 4)));
	}

	[IteratorStateMachine(typeof(b))]
	public global::System.Collections.Generic.IEnumerable<MemoryRegion> ReadableRegions()
	{
		ulong num = 0uL;
		B info;
		while (num < 140737488289792L && A(_handle, (nint)num, out info, Marshal.SizeOf<B>()) != 0)
		{
			ulong size = (ulong)info.RegionSize;
			if (size == 0L)
			{
				break;
			}
			if (info.State == 4096 && (info.Protect & 1) == 0 && (info.Protect & 0x100) == 0)
			{
				yield return new MemoryRegion((ulong)info.BaseAddress, size, info.Protect, info.Type);
			}
			num = (ulong)info.BaseAddress + size;
		}
	}

	public global::System.Collections.Generic.IReadOnlyList<ValueTuple<ulong, ulong>>? ResidentRuns(MemoryRegion region)
	{
		return A(_handle, region.Base, region.Size);
	}

	internal static global::System.Collections.Generic.IReadOnlyList<ValueTuple<ulong, ulong>>? A(nint P_0, ulong P_1, ulong P_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<ulong, ulong> val = default(ValueTuple<ulong, ulong>);
		val._002Ector(P_1, P_2);
		List<ValueTuple<ulong, ulong>> val2 = new List<ValueTuple<ulong, ulong>>();
		ulong num = val.Item2 / 4096;
		A[] array = new A[4096];
		ulong num2 = 0uL;
		ulong num3 = 0uL;
		for (ulong num4 = 0uL; num4 < num; num4 += 4096)
		{
			int num5 = (int)Math.Min(4096uL, num - num4);
			for (int i = 0; i < num5; i++)
			{
				array[i] = new A
				{
					VirtualAddress = (nint)((long)val.Item1 + ((long)num4 + (long)i) * 4096)
				};
			}
			if (!A(P_0, array, num5 * Marshal.SizeOf<A>()))
			{
				return null;
			}
			for (int j = 0; j < num5; j++)
			{
				ulong num6 = val.Item1 + (ulong)(((long)num4 + (long)j) * 4096);
				if ((array[j].VirtualAttributes & 1) == 0)
				{
					continue;
				}
				if (num3 != 0 && num2 + num3 == num6)
				{
					num3 += 4096;
					continue;
				}
				if (num3 != 0)
				{
					val2.Add(new ValueTuple<ulong, ulong>(num2, num3));
				}
				num2 = num6;
				num3 = 4096uL;
			}
		}
		if (num3 != 0)
		{
			val2.Add(new ValueTuple<ulong, ulong>(num2, num3));
		}
		return (global::System.Collections.Generic.IReadOnlyList<ValueTuple<ulong, ulong>>?)val2;
	}

	public void Dispose()
	{
		if (_handle != 0)
		{
			A(_handle);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
	private static extern nint A(int P_0, bool P_1, int P_2);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, nint P_1, byte[] P_2, int P_3, out int P_4);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool a(nint P_0, nint P_1, byte[] P_2, int P_3, out int P_4);

	[DllImport("kernel32.dll", EntryPoint = "K32QueryWorkingSetEx", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, [In][Out] A[] P_1, int P_2);

	[DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx", SetLastError = true)]
	private static extern nint A(nint P_0, nint P_1, out B P_2, int P_3);

	[DllImport("kernel32.dll", CharSet = 3, EntryPoint = "QueryFullProcessImageName", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, int P_1, StringBuilder P_2, ref int P_3);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess")]
	private static extern int A(nint P_0, int P_1, ref a P_2, int P_3, out int P_4);
}
