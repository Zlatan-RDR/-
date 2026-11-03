using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Detection;

public static class WhatTheFilesSayAboutTheEngine
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<char, bool> _003C_003E9__10_0;

		internal bool A(char P_0)
		{
			return P_0 == '.';
		}
	}

	private static readonly ValueTuple<int, string>[] ContainerFloors = new ValueTuple<int, string>[9]
	{
		new ValueTuple<int, string>(2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gs()),
		new ValueTuple<int, string>(3, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gT()),
		new ValueTuple<int, string>(4, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gt()),
		new ValueTuple<int, string>(5, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gt()),
		new ValueTuple<int, string>(6, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gU()),
		new ValueTuple<int, string>(7, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gU()),
		new ValueTuple<int, string>(8, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GL()),
		new ValueTuple<int, string>(9, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gu()),
		new ValueTuple<int, string>(10, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gu())
	};

	private static readonly ValueTuple<int, string>[] PackageFloors = new ValueTuple<int, string>[8]
	{
		new ValueTuple<int, string>(3, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gV()),
		new ValueTuple<int, string>(5, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gv()),
		new ValueTuple<int, string>(6, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gW()),
		new ValueTuple<int, string>(8, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gw()),
		new ValueTuple<int, string>(9, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gs()),
		new ValueTuple<int, string>(10, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gX()),
		new ValueTuple<int, string>(11, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gT()),
		new ValueTuple<int, string>(12, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gU())
	};

	public static string? EngineFloorIn(string paksDirectory)
	{
		if (string.IsNullOrWhiteSpace(paksDirectory) || !Directory.Exists(paksDirectory))
		{
			return null;
		}
		string text = null;
		string[] array = new string[2]
		{
			A(paksDirectory),
			a(paksDirectory)
		};
		foreach (string text2 in array)
		{
			if (text2 != null && (text == null || A(text2, text) > 0))
			{
				text = text2;
			}
		}
		return text;
	}

	private static string? A(string P_0)
	{
		int num = 0;
		global::System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u()).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (Path.GetFileName(current).StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gS(), (StringComparison)5))
				{
					continue;
				}
				int? num2 = B(current);
				if (num2.HasValue)
				{
					int valueOrDefault = num2.GetValueOrDefault();
					if (valueOrDefault > num)
					{
						num = valueOrDefault;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return A(num, ContainerFloors);
	}

	private static string? a(string P_0)
	{
		int num = 0;
		global::System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateFiles(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CY()).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (Path.GetFileName(current).StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gS(), (StringComparison)5))
				{
					continue;
				}
				int? num2 = b(current);
				if (num2.HasValue)
				{
					int valueOrDefault = num2.GetValueOrDefault();
					if (valueOrDefault > num)
					{
						num = valueOrDefault;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return A(num, PackageFloors);
	}

	private static int? B(string P_0)
	{
		try
		{
			FileStream val = C(P_0);
			try
			{
				byte[] array = new byte[17];
				if (((Stream)val).Read(array, 0, array.Length) != array.Length || !MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(array, 0, IoStoreContainer.MagicBytes.Length), global::System.ReadOnlySpan<byte>.op_Implicit(IoStoreContainer.MagicBytes)))
				{
					return null;
				}
				return (int)array[16];
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (IOException)
		{
			return null;
		}
	}

	private static int? b(string P_0)
	{
		global::System.ReadOnlySpan<byte> readOnlySpan = (global::System.ReadOnlySpan<byte>)new byte[4] { 225, 18, 111, 90 };
		try
		{
			FileStream val = C(P_0);
			try
			{
				int num = (int)Math.Min(((Stream)val).Length, 256L);
				if (num < readOnlySpan.Length + 4)
				{
					return null;
				}
				byte[] array = new byte[num];
				((Stream)val).Seek((long)(-num), (SeekOrigin)2);
				if (((Stream)val).Read(array, 0, num) != num)
				{
					return null;
				}
				for (int num2 = num - readOnlySpan.Length - 4; num2 >= 0; num2--)
				{
					if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(array, num2, readOnlySpan.Length), readOnlySpan))
					{
						return BitConverter.ToInt32(array, num2 + readOnlySpan.Length);
					}
				}
				return null;
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (IOException)
		{
			return null;
		}
	}

	private static FileStream C(string P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		return new FileStream(P_0, (FileMode)3, (FileAccess)1, (FileShare)7);
	}

	private static string? A(int P_0, ValueTuple<int, string>[] table)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 <= 0)
		{
			return null;
		}
		string result = null;
		for (int i = 0; i < table.Length; i++)
		{
			ValueTuple<int, string> val = table[i];
			int item = val.Item1;
			string item2 = val.Item2;
			if (P_0 >= item)
			{
				result = item2;
			}
		}
		return result;
	}

	private static int A(string P_0, string P_1)
	{
		Version val = default(Version);
		Version val2 = default(Version);
		if (!Version.TryParse(c(P_0), ref val) || !Version.TryParse(c(P_1), ref val2))
		{
			return string.CompareOrdinal(P_0, P_1);
		}
		return val.CompareTo(val2);
	}

	private static string c(string P_0)
	{
		if (Enumerable.Count<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 == '.')) != 1)
		{
			return P_0;
		}
		return P_0 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gl();
	}
}
