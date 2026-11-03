using System;
using System.Text;

namespace Miqbas.Engines.Unreal.Live;

public static class NameEntry
{
	public const int HeaderSize = 2;

	public const int MaxSaneLength = 1024;

	public static int LengthOf(ushort header)
	{
		return header >> 6;
	}

	public static bool IsWide(ushort header)
	{
		return (header & 1) != 0;
	}

	public static int StrideOf(ushort header)
	{
		int num = LengthOf(header);
		int num2 = (IsWide(header) ? (num * 2) : num);
		return (2 + num2 + 1) & -2;
	}

	public unsafe static string? ReadAt(global::System.ReadOnlySpan<byte> block, int offset)
	{
		if (offset < 0 || offset + 2 > block.Length)
		{
			return null;
		}
		ushort header = (ushort)(*(byte*)block[offset] | (*(byte*)block[offset + 1] << 8));
		int num = LengthOf(header);
		if ((num > 1024 || num == 0) ? true : false)
		{
			return null;
		}
		bool flag = IsWide(header);
		int num2 = (flag ? (num * 2) : num);
		int num3 = offset + 2;
		if (num3 + num2 > block.Length)
		{
			return null;
		}
		global::System.ReadOnlySpan<byte> readOnlySpan = block.Slice(num3, num2);
		string text = (flag ? Encoding.Unicode.GetString(readOnlySpan) : Encoding.ASCII.GetString(readOnlySpan));
		if (!IsNameLike(text))
		{
			return null;
		}
		return text;
	}

	public static bool IsNameLike(string text)
	{
		if (text.Length == 0)
		{
			return false;
		}
		foreach (char c in text)
		{
			if (c < ' ' || c == '\u007f')
			{
				return false;
			}
		}
		return true;
	}
}
