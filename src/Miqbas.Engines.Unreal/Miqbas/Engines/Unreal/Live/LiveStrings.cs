using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public static class LiveStrings
{
	public readonly struct FoundString : IEquatable<FoundString>
	{
		[field: CompilerGenerated]
		public ulong Field
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public ulong Data
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int Capacity
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public string Text
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public FoundString(ulong Field, ulong Data, int Capacity, string Text)
		{
			this.Field = Field;
			this.Data = Data;
			this.Capacity = Capacity;
			this.Text = Text;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hF());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hf());
			P_0.Append(((object)Field).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hG());
			P_0.Append(((object)Data).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fd());
			P_0.Append(((object)Capacity).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DH());
			P_0.Append((object)Text);
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(FoundString left, FoundString right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(FoundString left, FoundString right)
		{
			return left.Equals(right);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<ulong>.Default.GetHashCode(Field) * -1521134295 + EqualityComparer<ulong>.Default.GetHashCode(Data)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Capacity)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
		}

		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			if (obj is FoundString)
			{
				return Equals((FoundString)obj);
			}
			return false;
		}

		[CompilerGenerated]
		public bool Equals(FoundString other)
		{
			if (EqualityComparer<ulong>.Default.Equals(Field, other.Field) && EqualityComparer<ulong>.Default.Equals(Data, other.Data) && EqualityComparer<int>.Default.Equals(Capacity, other.Capacity))
			{
				return EqualityComparer<string>.Default.Equals(Text, other.Text);
			}
			return false;
		}

		[CompilerGenerated]
		public void Deconstruct(out ulong Field, out ulong Data, out int Capacity, out string Text)
		{
			Field = this.Field;
			Data = this.Data;
			Capacity = this.Capacity;
			Text = this.Text;
		}
	}

	public const int ObjectWindow = 1024;

	private const int BehindPointer = 128;

	private const int TextRecord = 48;

	private const int MaxCharacters = 4096;

	public static List<string> In(ProcessMemory memory, ulong address)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		List<string> val = new List<string>();
		byte[] array = new byte[1024];
		int num = memory.TryReadBytes(address, array);
		if (num <= 0)
		{
			num = A(memory, address, array);
			if (num <= 0)
			{
				return val;
			}
		}
		byte[] array2 = new byte[128];
		for (int i = 0; i + 16 <= num; i += 8)
		{
			string text = A(memory, array, i);
			if (text != null)
			{
				A(val, text);
				continue;
			}
			ulong num2 = BitConverter.ToUInt64(array, i);
			if (!A(num2) || memory.TryReadBytes(num2, array2) != array2.Length)
			{
				continue;
			}
			for (int j = 0; j + 16 <= array2.Length; j += 8)
			{
				string text2 = A(memory, array2, j);
				if (text2 != null)
				{
					A(val, text2);
				}
			}
		}
		return val;
	}

	private static void A(List<string> P_0, string P_1)
	{
		if (!Enumerable.Contains<string>((global::System.Collections.Generic.IEnumerable<string>)P_0, P_1, (IEqualityComparer<string>)(object)StringComparer.Ordinal))
		{
			P_0.Add(P_1);
		}
	}

	private static string? A(ProcessMemory P_0, byte[] P_1, int P_2)
	{
		ulong num = BitConverter.ToUInt64(P_1, P_2);
		int num2 = BitConverter.ToInt32(P_1, P_2 + 8);
		int num3 = BitConverter.ToInt32(P_1, P_2 + 12);
		if (!A(num) || num2 <= 1 || num3 < num2 || num3 > 4096)
		{
			return null;
		}
		byte[] array = new byte[num2 * 2];
		if (P_0.TryReadBytes(num, array) != array.Length)
		{
			return null;
		}
		if (array[array.Length - 1] == 0)
		{
			if (array[array.Length - 2] == 0)
			{
				string @string = Encoding.Unicode.GetString(array, 0, array.Length - 2);
				if (!A(@string))
				{
					return null;
				}
				return @string;
			}
		}
		return null;
	}

	private static bool A(string P_0)
	{
		bool result = false;
		foreach (char c in P_0)
		{
			if (char.IsControl(c) && c != '\n' && c != '\r' && c != '\t')
			{
				return false;
			}
			if (!A(c))
			{
				return false;
			}
			if (char.IsLetterOrDigit(c))
			{
				result = true;
			}
		}
		return result;
	}

	private static bool A(char P_0)
	{
		switch (P_0)
		{
		case '\t':
		case '\n':
		case '\r':
		case '\u00a0':
			return true;
		case ' ':
		case '!':
		case '"':
		case '#':
		case '$':
		case '%':
		case '&':
		case '\'':
		case '(':
		case ')':
		case '*':
		case '+':
		case ',':
		case '-':
		case '.':
		case '/':
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
		case ':':
		case ';':
		case '<':
		case '=':
		case '>':
		case '?':
		case '@':
		case 'A':
		case 'B':
		case 'C':
		case 'D':
		case 'E':
		case 'F':
		case 'G':
		case 'H':
		case 'I':
		case 'J':
		case 'K':
		case 'L':
		case 'M':
		case 'N':
		case 'O':
		case 'P':
		case 'Q':
		case 'R':
		case 'S':
		case 'T':
		case 'U':
		case 'V':
		case 'W':
		case 'X':
		case 'Y':
		case 'Z':
		case '[':
		case '\\':
		case ']':
		case '^':
		case '_':
		case '`':
		case 'a':
		case 'b':
		case 'c':
		case 'd':
		case 'e':
		case 'f':
		case 'g':
		case 'h':
		case 'i':
		case 'j':
		case 'k':
		case 'l':
		case 'm':
		case 'n':
		case 'o':
		case 'p':
		case 'q':
		case 'r':
		case 's':
		case 't':
		case 'u':
		case 'v':
		case 'w':
		case 'x':
		case 'y':
		case 'z':
		case '{':
		case '|':
		case '}':
		case '~':
			return true;
		default:
			if ((P_0 >= '\u0600' && P_0 <= 'ۿ') || (P_0 >= 'ﹰ' && P_0 <= '\ufeff'))
			{
				return true;
			}
			if (P_0 < '\u200e' || P_0 > '\u200f')
			{
				if (P_0 >= '\u2066')
				{
					return P_0 <= '\u2069';
				}
				return false;
			}
			return true;
		}
	}

	public static List<FoundString> FindIn(ProcessMemory memory, ulong address, int window = 1024)
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		Dictionary<ulong, FoundString> val = new Dictionary<ulong, FoundString>();
		byte[] array = new byte[Math.Clamp(window, 16, 1024)];
		if (memory.TryReadBytes(address, array) <= 0)
		{
			return new List<FoundString>();
		}
		byte[] array2 = new byte[128];
		for (int i = 0; i + 16 <= array.Length; i += 8)
		{
			FoundString? foundString = A(memory, array, i, address + (ulong)i);
			if (foundString.HasValue)
			{
				FoundString valueOrDefault = foundString.GetValueOrDefault();
				val[valueOrDefault.Field] = valueOrDefault;
				continue;
			}
			ulong num = BitConverter.ToUInt64(array, i);
			if (!A(num) || memory.TryReadBytes(num, array2) != array2.Length)
			{
				continue;
			}
			for (int j = 0; j + 16 <= array2.Length; j += 8)
			{
				foundString = A(memory, array2, j, num + (ulong)j);
				if (foundString.HasValue)
				{
					FoundString valueOrDefault2 = foundString.GetValueOrDefault();
					val[valueOrDefault2.Field] = valueOrDefault2;
				}
			}
		}
		ValueCollection<ulong, FoundString> values = val.Values;
		int count = values.Count;
		List<FoundString> val2 = new List<FoundString>(count);
		CollectionsMarshal.SetCount<FoundString>(val2, count);
		global::System.Span<FoundString> span = CollectionsMarshal.AsSpan<FoundString>(val2);
		int num2 = 0;
		Enumerator<ulong, FoundString> enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				FoundString current = enumerator.Current;
				span[num2] = current;
				num2++;
			}
			return val2;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	public static FoundString? At(ProcessMemory memory, ulong address)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		byte[] array = new byte[16];
		if (memory.TryReadBytes(address, array) != array.Length)
		{
			return null;
		}
		return A(memory, array, 0, address);
	}

	public static List<FoundString> BehindText(ProcessMemory memory, ulong address, int window = 48)
	{
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		Dictionary<ulong, FoundString> val = new Dictionary<ulong, FoundString>();
		byte[] array = new byte[8];
		if (memory.TryReadBytes(address, array) != array.Length)
		{
			return new List<FoundString>();
		}
		ulong num = BitConverter.ToUInt64(global::System.ReadOnlySpan<byte>.op_Implicit(array));
		if (!A(num))
		{
			return new List<FoundString>();
		}
		byte[] array2 = new byte[Math.Clamp(window, 16, 128)];
		if (memory.TryReadBytes(num, array2) != array2.Length)
		{
			return new List<FoundString>();
		}
		byte[] array3 = new byte[32];
		for (int i = 0; i + 16 <= array2.Length; i += 8)
		{
			FoundString? foundString = A(memory, array2, i, num + (ulong)i);
			if (foundString.HasValue)
			{
				FoundString valueOrDefault = foundString.GetValueOrDefault();
				val[valueOrDefault.Field] = valueOrDefault;
				continue;
			}
			ulong num2 = BitConverter.ToUInt64(array2, i);
			if (A(num2) && memory.TryReadBytes(num2, array3) == array3.Length)
			{
				foundString = A(memory, array3, 0, num2);
				if (foundString.HasValue)
				{
					FoundString valueOrDefault2 = foundString.GetValueOrDefault();
					val[valueOrDefault2.Field] = valueOrDefault2;
				}
			}
		}
		ValueCollection<ulong, FoundString> values = val.Values;
		int count = values.Count;
		List<FoundString> val2 = new List<FoundString>(count);
		CollectionsMarshal.SetCount<FoundString>(val2, count);
		global::System.Span<FoundString> span = CollectionsMarshal.AsSpan<FoundString>(val2);
		int num3 = 0;
		Enumerator<ulong, FoundString> enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				FoundString current = enumerator.Current;
				span[num3] = current;
				num3++;
			}
			return val2;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	private static FoundString? A(ProcessMemory P_0, byte[] P_1, int P_2, ulong P_3)
	{
		string text = A(P_0, P_1, P_2);
		if (text != null)
		{
			return new FoundString(P_3, BitConverter.ToUInt64(P_1, P_2), BitConverter.ToInt32(P_1, P_2 + 12), text);
		}
		return null;
	}

	public static bool Overwrite(ProcessMemory memory, FoundString found, string text)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dt());
		if (!Fits(found, text))
		{
			return false;
		}
		FoundString? foundString = At(memory, found.Field);
		if (!foundString.HasValue || foundString.Value.Data != found.Data || foundString.Value.Capacity != found.Capacity || !string.Equals(foundString.Value.Text, found.Text, (StringComparison)4))
		{
			return false;
		}
		byte[] bytes = Encoding.Unicode.GetBytes(text + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BX());
		if (!memory.WriteBytes(found.Data, bytes))
		{
			return false;
		}
		return memory.WriteBytes(found.Field + 8, BitConverter.GetBytes(text.Length + 1));
	}

	public static bool Fits(FoundString found, string text)
	{
		ArgumentNullException.ThrowIfNull((object)text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dt());
		return text.Length + 1 <= found.Capacity;
	}

	private static bool A(ulong P_0)
	{
		if (P_0 > 65536 && P_0 < 140737488355327L)
		{
			return (P_0 & 1) == 0;
		}
		return false;
	}

	private static int A(ProcessMemory P_0, ulong P_1, byte[] P_2)
	{
		byte[] array = new byte[64];
		int i;
		for (i = 0; i + array.Length <= P_2.Length && P_0.TryReadBytes(P_1 + (ulong)i, array) == array.Length; i += array.Length)
		{
			((global::System.Array)array).CopyTo((global::System.Array)P_2, i);
		}
		return i;
	}
}
