using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Compression;

public sealed class CombinedDecompressor : IPakDecompressor, global::System.IDisposable
{
	[CompilerGenerated]
	private sealed class A
	{
		public string method;

		internal bool A(IPakDecompressor P_0)
		{
			return P_0.Supports(method);
		}
	}

	[CompilerGenerated]
	private global::System.Collections.Generic.IReadOnlyList<IPakDecompressor> _003Cparts_003EP;

	public CombinedDecompressor(global::System.Collections.Generic.IReadOnlyList<IPakDecompressor> parts)
	{
		_003Cparts_003EP = parts;
		base._002Ector();
	}

	public bool Supports(string method)
	{
		string method2 = method;
		return Enumerable.Any<IPakDecompressor>((global::System.Collections.Generic.IEnumerable<IPakDecompressor>)_003Cparts_003EP, (Func<IPakDecompressor, bool>)((IPakDecompressor P_0) => P_0.Supports(method2)));
	}

	public int Decompress(string method, global::System.ReadOnlySpan<byte> compressed, global::System.Span<byte> destination)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		global::System.Collections.Generic.IEnumerator<IPakDecompressor> enumerator = ((global::System.Collections.Generic.IEnumerable<IPakDecompressor>)_003Cparts_003EP).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IPakDecompressor current = enumerator.Current;
				if (current.Supports(method))
				{
					return current.Decompress(method, compressed, destination);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		throw new NotSupportedException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hl() + method + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hM());
	}

	public void Dispose()
	{
		global::System.Collections.Generic.IEnumerator<IPakDecompressor> enumerator = ((global::System.Collections.Generic.IEnumerable<IPakDecompressor>)_003Cparts_003EP).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				(enumerator.Current as global::System.IDisposable)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}
}
