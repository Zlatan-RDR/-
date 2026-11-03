using System;

namespace Miqbas.Engines.Unreal.Packages;

public interface IPakDecompressor
{
	bool Supports(string method);

	int Decompress(string method, global::System.ReadOnlySpan<byte> compressed, global::System.Span<byte> destination);
}
