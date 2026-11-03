using System;
using System.Collections.Generic;

namespace Miqbas.Engines.Unreal.Live;

public static class NameBlock
{
	public const int SizeBytes = 131072;

	public const int BlockOffsetBits = 16;

	public const string FirstName = "None";

	public unsafe static List<string> NamesIn(global::System.ReadOnlySpan<byte> block, int startAt = 0)
	{
		List<string> val = new List<string>();
		ushort header;
		for (int i = startAt; i + 2 <= block.Length; i += NameEntry.StrideOf(header))
		{
			string text = NameEntry.ReadAt(block, i);
			if (text == null)
			{
				break;
			}
			val.Add(text);
			header = (ushort)(*(byte*)block[i] | (*(byte*)block[i + 1] << 8));
		}
		return val;
	}

	public unsafe static int RunLength(global::System.ReadOnlySpan<byte> block, int startAt = 0, int stopAfter = 2147483647)
	{
		int i = 0;
		int num = startAt;
		for (; i < stopAfter; i++)
		{
			if (num + 2 > block.Length)
			{
				break;
			}
			if (NameEntry.ReadAt(block, num) == null)
			{
				break;
			}
			ushort header = (ushort)(*(byte*)block[num] | (*(byte*)block[num + 1] << 8));
			num += NameEntry.StrideOf(header);
		}
		return i;
	}
}
