using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class TheBlobOdinWrote
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<AStringOdinWrote, int> _003C_003E9__1_1;

		public static Func<char, bool> _003C_003E9__3_0;

		internal int A(AStringOdinWrote P_0)
		{
			return P_0.Start;
		}

		internal bool A(char P_0)
		{
			return P_0 > 'ÿ';
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public IReadOnlyDictionary<string, string> byPath;

		internal bool A(AStringOdinWrote P_0)
		{
			return byPath.ContainsKey(P_0.Path);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string path;

		internal bool A(AStringOdinWrote P_0)
		{
			return P_0.Path == path;
		}
	}

	public static System.Collections.Generic.IReadOnlyList<AStringOdinWrote>? StringsIn(byte[] blob)
	{
		ArgumentNullException.ThrowIfNull((object)blob, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iU());
		List<AStringOdinWrote> val = new List<AStringOdinWrote>();
		List<string> val2 = new List<string>();
		int num = 0;
		int num2 = 0;
		while (num < blob.Length)
		{
			byte b = blob[num++];
			int num4;
			int num3;
			string text;
			bool flag;
			switch (b)
			{
			case 49:
				return (System.Collections.Generic.IReadOnlyList<AStringOdinWrote>?)val;
			case 5:
				if (val2.Count > 0)
				{
					val2.RemoveAt(val2.Count - 1);
				}
				continue;
			case 6:
				if (A(blob, ref num, 8L))
				{
					continue;
				}
				return null;
			case 1:
			case 3:
			{
				if (!A(blob, ref num, out string text2, out num4, out num3))
				{
					return null;
				}
				val2.Add(text2);
				if (A(blob, ref num) && (b != 1 || A(blob, ref num, 4L)))
				{
					continue;
				}
				return null;
			}
			case 2:
			case 4:
			{
				string text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DH();
				num3 = num2++;
				val2.Add(text3 + num3 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DJ());
				if (A(blob, ref num) && (b != 2 || A(blob, ref num, 4L)))
				{
					continue;
				}
				return null;
			}
			case 8:
			{
				if (num + 8 > blob.Length)
				{
					return null;
				}
				long num5 = BitConverter.ToInt32(blob, num);
				long num6 = BitConverter.ToInt32(blob, num + 4);
				num += 8;
				if (num5 >= 0 && num6 >= 0 && A(blob, ref num, num5 * num6))
				{
					continue;
				}
				return null;
			}
			case 47:
				if (A(blob, ref num, 4L) && A(blob, ref num, out text, out num3, out num4))
				{
					continue;
				}
				return null;
			case 48:
				if (A(blob, ref num, 4L))
				{
					continue;
				}
				return null;
			default:
				flag = true;
				break;
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 50:
			case 51:
				flag = false;
				break;
			case 7:
				continue;
			}
			if (flag)
			{
				return null;
			}
			string empty = string.Empty;
			if ((b & 1) == 1 && !A(blob, ref num, out empty, out num4, out num3))
			{
				return null;
			}
			if ((uint)(b - 39) <= 1u)
			{
				if (!A(blob, ref num, out string value, out int start, out int length))
				{
					return null;
				}
				string text5;
				if (empty.Length <= 0)
				{
					string text4 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DH();
					num3 = num2++;
					text5 = text4 + num3 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DJ();
				}
				else
				{
					text5 = empty;
				}
				string text6 = text5;
				val.Add(new AStringOdinWrote
				{
					Path = ((val2.Count == 0) ? text6 : (string.Join<string>('.', (System.Collections.Generic.IEnumerable<string>)val2) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB() + text6)),
					Value = value,
					Start = start,
					Length = length
				});
				continue;
			}
			if ((uint)(b - 50) <= 1u)
			{
				if (A(blob, ref num, out text, out num3, out num4))
				{
					continue;
				}
				return null;
			}
			int? num7 = A(b);
			if (num7.HasValue)
			{
				int valueOrDefault = num7.GetValueOrDefault();
				if (A(blob, ref num, valueOrDefault))
				{
					continue;
				}
			}
			return null;
		}
		return (System.Collections.Generic.IReadOnlyList<AStringOdinWrote>?)val;
	}

	public static byte[]? Write(byte[] blob, IReadOnlyDictionary<string, string> byPath)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		IReadOnlyDictionary<string, string> byPath2 = byPath;
		ArgumentNullException.ThrowIfNull((object)blob, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iU());
		ArgumentNullException.ThrowIfNull((object)byPath2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iu());
		System.Collections.Generic.IReadOnlyList<AStringOdinWrote> readOnlyList = StringsIn(blob);
		if (readOnlyList == null)
		{
			return null;
		}
		List<AStringOdinWrote> val = Enumerable.ToList<AStringOdinWrote>((System.Collections.Generic.IEnumerable<AStringOdinWrote>)Enumerable.OrderBy<AStringOdinWrote, int>(Enumerable.Where<AStringOdinWrote>((System.Collections.Generic.IEnumerable<AStringOdinWrote>)readOnlyList, (Func<AStringOdinWrote, bool>)((AStringOdinWrote P_0) => byPath2.ContainsKey(P_0.Path))), (Func<AStringOdinWrote, int>)((AStringOdinWrote P_0) => P_0.Start)));
		if (val.Count == 0)
		{
			return blob;
		}
		List<byte> val2 = new List<byte>(blob.Length + val.Count * 8);
		int num = 0;
		Enumerator<AStringOdinWrote> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				AStringOdinWrote current = enumerator.Current;
				val2.AddRange((System.Collections.Generic.IEnumerable<byte>)(object)new ArraySegment<byte>(blob, num, current.Start - num));
				val2.AddRange((System.Collections.Generic.IEnumerable<byte>)AsOdinWroteIt(byPath2[current.Path]));
				num = current.Start + current.Length;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		val2.AddRange((System.Collections.Generic.IEnumerable<byte>)(object)new ArraySegment<byte>(blob, num, blob.Length - num));
		return val2.ToArray();
	}

	public static string? WhatIsAt(byte[] blob, string path)
	{
		string path2 = path;
		ArgumentNullException.ThrowIfNull((object)path2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HU());
		System.Collections.Generic.IReadOnlyList<AStringOdinWrote>? readOnlyList = StringsIn(blob);
		if (readOnlyList == null)
		{
			return null;
		}
		return Enumerable.FirstOrDefault<AStringOdinWrote>((System.Collections.Generic.IEnumerable<AStringOdinWrote>)readOnlyList, (Func<AStringOdinWrote, bool>)((AStringOdinWrote P_0) => P_0.Path == path2))?.Value;
	}

	public static byte[] AsOdinWroteIt(string value)
	{
		ArgumentNullException.ThrowIfNull((object)value, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gv());
		bool flag = Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)value, (Func<char, bool>)((char P_0) => P_0 > 'ÿ'));
		List<byte> obj = new List<byte>(value.Length * ((!flag) ? 1 : 2) + 5);
		obj.Add(flag ? ((byte)1) : ((byte)0));
		List<byte> val = obj;
		val.AddRange((System.Collections.Generic.IEnumerable<byte>)BitConverter.GetBytes(value.Length));
		foreach (char c in value)
		{
			val.Add((byte)(c & 0xFFu));
			if (flag)
			{
				val.Add((byte)((int)c >> 8));
			}
		}
		return val.ToArray();
	}

	private static bool A(byte[] P_0, ref int P_1, out string P_2, out int P_3, out int P_4)
	{
		P_2 = string.Empty;
		P_3 = P_1;
		P_4 = 0;
		if (P_1 >= P_0.Length)
		{
			return false;
		}
		byte b = P_0[P_1++];
		if (b > 1 || P_1 + 4 > P_0.Length)
		{
			return false;
		}
		int num = BitConverter.ToInt32(P_0, P_1);
		P_1 += 4;
		if (num < 0)
		{
			return false;
		}
		long num2 = ((b == 1) ? ((long)num * 2L) : num);
		if (P_1 + num2 > P_0.Length)
		{
			return false;
		}
		if (b == 1)
		{
			P_2 = Encoding.Unicode.GetString(P_0, P_1, (int)num2);
		}
		else
		{
			char[] array = new char[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (char)P_0[P_1 + i];
			}
			P_2 = new string(array);
		}
		P_1 += (int)num2;
		P_4 = P_1 - P_3;
		return true;
	}

	private static bool A(byte[] P_0, ref int P_1)
	{
		if (P_1 >= P_0.Length)
		{
			return false;
		}
		int num = P_1++;
		switch (P_0[num])
		{
		case 45:
		case 46:
			return true;
		case 48:
			return A(P_0, ref P_1, 4L);
		case 47:
		{
			string text;
			int num2;
			return A(P_0, ref P_1, 4L) && A(P_0, ref P_1, out text, out num, out num2);
		}
		default:
			return false;
		}
	}

	private static bool A(byte[] P_0, ref int P_1, long P_2)
	{
		if (P_2 < 0 || P_1 + P_2 > P_0.Length)
		{
			return false;
		}
		P_1 += (int)P_2;
		return true;
	}

	private static int? A(byte P_0)
	{
		switch (P_0)
		{
		case 15:
		case 16:
		case 17:
		case 18:
			return 1;
		case 43:
		case 44:
			return 1;
		case 19:
		case 20:
		case 21:
		case 22:
		case 37:
		case 38:
			return 2;
		case 9:
		case 10:
		case 11:
		case 12:
			return 4;
		case 23:
		case 24:
		case 25:
		case 26:
		case 31:
		case 32:
			return 4;
		case 27:
		case 28:
		case 29:
		case 30:
		case 33:
		case 34:
			return 8;
		case 13:
		case 14:
		case 35:
		case 36:
		case 41:
		case 42:
			return 16;
		case 45:
		case 46:
			return 0;
		default:
			return null;
		}
	}
}
