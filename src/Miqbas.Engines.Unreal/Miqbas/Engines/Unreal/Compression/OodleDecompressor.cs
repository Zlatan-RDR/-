using System;
using System.IO;
using System.Runtime.InteropServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Compression;

public sealed class OodleDecompressor : IPakDecompressor, global::System.IDisposable
{
	[UnmanagedFunctionPointer(/*Could not decode attribute arguments.*/)]
	private delegate long A(nint P_0, long P_1, nint P_2, long P_3, int P_4, int P_5, int P_6, nint P_7, long P_8, nint P_9, nint P_10, nint P_11, long P_12, int P_13);

	public const string MethodName = "Oodle";

	private const int FuzzSafeNo = 0;

	private const int CheckCrcNo = 0;

	private const int VerbosityNone = 0;

	private const int ThreadPhaseAll = 3;

	private readonly nint _handle;

	private readonly A _decompress;

	private bool _disposed;

	private OodleDecompressor(nint P_0, A P_1)
	{
		_handle = P_0;
		_decompress = P_1;
	}

	public static OodleDecompressor Load(string libraryPath)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		ArgumentException.ThrowIfNullOrWhiteSpace(libraryPath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hQ());
		if (!File.Exists(libraryPath))
		{
			throw new FileNotFoundException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hq(), libraryPath);
		}
		nint num = NativeLibrary.Load(libraryPath);
		try
		{
			nint export = NativeLibrary.GetExport((global::System.IntPtr)num, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hR());
			return new OodleDecompressor(num, Marshal.GetDelegateForFunctionPointer<A>((global::System.IntPtr)export));
		}
		catch
		{
			NativeLibrary.Free((global::System.IntPtr)num);
			throw;
		}
	}

	public bool Supports(string method)
	{
		return string.Equals(method, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bh(), (StringComparison)5);
	}

	public int Decompress(string method, global::System.ReadOnlySpan<byte> compressed, global::System.Span<byte> destination)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		ObjectDisposedException.ThrowIf(_disposed, (object)this);
		byte[] array = compressed.ToArray();
		byte[] array2 = new byte[destination.Length];
		GCHandle val = GCHandle.Alloc((object)array, (GCHandleType)3);
		GCHandle val2 = GCHandle.Alloc((object)array2, (GCHandleType)3);
		try
		{
			long num = _decompress(((GCHandle)(ref val)).AddrOfPinnedObject(), array.Length, ((GCHandle)(ref val2)).AddrOfPinnedObject(), array2.Length, 0, 0, 0, global::System.IntPtr.Zero, 0L, global::System.IntPtr.Zero, global::System.IntPtr.Zero, global::System.IntPtr.Zero, 0L, 3);
			if (num <= 0)
			{
				throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hr());
			}
			int num2 = (int)Math.Min(num, (long)array2.Length);
			MemoryExtensions.AsSpan<byte>(array2, 0, num2).CopyTo(destination);
			return num2;
		}
		finally
		{
			((GCHandle)(ref val)).Free();
			((GCHandle)(ref val2)).Free();
		}
	}

	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
			NativeLibrary.Free((global::System.IntPtr)_handle);
		}
	}
}
