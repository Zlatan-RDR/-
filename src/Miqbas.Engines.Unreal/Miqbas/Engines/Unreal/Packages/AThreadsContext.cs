using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Miqbas.Engines.Unreal.Packages;

[SupportedOSPlatform("windows")]
public sealed class AThreadsContext : global::System.IDisposable
{
	private const int OffContextFlags = 48;

	private const int OffDr0 = 72;

	private const int OffDr6 = 104;

	private const int OffDr7 = 112;

	private const int OffRsp = 152;

	private const int OffRsi = 168;

	private const int OffRdi = 176;

	private const int OffRip = 248;

	private const int ContextSize = 1232;

	private const int ContextDebugRegisters = 1048592;

	private const int ContextControlInteger = 1048579;

	private readonly nint _raw;

	private readonly nint _ctx;

	public ulong Dr0
	{
		get
		{
			return (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 72);
		}
		set
		{
			Marshal.WriteInt64((global::System.IntPtr)_ctx, 72, (long)value);
		}
	}

	public ulong Dr6
	{
		get
		{
			return (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 104);
		}
		set
		{
			Marshal.WriteInt64((global::System.IntPtr)_ctx, 104, (long)value);
		}
	}

	public ulong Dr7
	{
		get
		{
			return (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 112);
		}
		set
		{
			Marshal.WriteInt64((global::System.IntPtr)_ctx, 112, (long)value);
		}
	}

	public ulong Rip => (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 248);

	public ulong Rsp => (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 152);

	public ulong Rsi => (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 168);

	public ulong Rdi => (ulong)Marshal.ReadInt64((global::System.IntPtr)_ctx, 176);

	public AThreadsContext()
	{
		_raw = Marshal.AllocHGlobal(1248);
		long num = ((long)_raw + 15L) & -16;
		_ctx = (nint)num;
	}

	public void Dispose()
	{
		Marshal.FreeHGlobal((global::System.IntPtr)_raw);
	}

	public bool ReadRegisters(nint thread)
	{
		A();
		Marshal.WriteInt32((global::System.IntPtr)_ctx, 48, 1048579);
		return A(thread, _ctx);
	}

	public bool ReadDebugRegisters(nint thread)
	{
		A();
		Marshal.WriteInt32((global::System.IntPtr)_ctx, 48, 1048592);
		return A(thread, _ctx);
	}

	public bool WriteDebugRegisters(nint thread)
	{
		Marshal.WriteInt32((global::System.IntPtr)_ctx, 48, 1048592);
		return a(thread, _ctx);
	}

	private void A()
	{
		for (int i = 0; i < 1232; i += 8)
		{
			Marshal.WriteInt64((global::System.IntPtr)_ctx, i, 0L);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "GetThreadContext", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool A(nint P_0, nint P_1);

	[DllImport("kernel32.dll", EntryPoint = "SetThreadContext", SetLastError = true)]
	[return: MarshalAs(2)]
	private static extern bool a(nint P_0, nint P_1);
}
