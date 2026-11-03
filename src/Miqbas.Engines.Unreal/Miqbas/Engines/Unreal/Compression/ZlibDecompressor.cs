using System;
using System.IO;
using System.IO.Compression;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Compression;

public sealed class ZlibDecompressor : IPakDecompressor
{
	public const string MethodName = "Zlib";

	public bool Supports(string method)
	{
		return method.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bg(), (StringComparison)5);
	}

	public int Decompress(string method, global::System.ReadOnlySpan<byte> compressed, global::System.Span<byte> destination)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		MemoryStream val = new MemoryStream(compressed.ToArray(), false);
		try
		{
			ZLibStream val2 = new ZLibStream((Stream)(object)val, (CompressionMode)0);
			try
			{
				byte[] array = new byte[destination.Length];
				int i;
				int num;
				for (i = 0; i < array.Length; i += num)
				{
					num = ((Stream)val2).Read(array, i, array.Length - i);
					if (num == 0)
					{
						break;
					}
				}
				MemoryExtensions.AsSpan<byte>(array, 0, i).CopyTo(destination);
				return i;
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}
}
