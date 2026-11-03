using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Localization;

public static class WhenTheIndexIsLocked
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<char, bool> _003C_003E9__7_0;

		internal bool A(char P_0)
		{
			switch (P_0)
			{
			case '-':
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
			case '_':
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
				return true;
			default:
				return false;
			}
		}
	}

	private static readonly byte[] LocMetaMagic;

	private const int LongestSensibleString = 260;

	public static global::System.Collections.Generic.IReadOnlyList<ATargetFoundInTheBytes> TargetsIn(string packagePath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		ArgumentException.ThrowIfNullOrWhiteSpace(packagePath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cl());
		try
		{
			FileStream val = new FileStream(packagePath, (FileMode)3, (FileAccess)1, (FileShare)7);
			try
			{
				byte[] array = new byte[8389648];
				List<ATargetFoundInTheBytes> val2 = new List<ATargetFoundInTheBytes>();
				HashSet<string> val3 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
				int num = 0;
				while (true)
				{
					int num2 = ((Stream)val).Read(array, num, 8388608);
					if (num2 <= 0)
					{
						break;
					}
					int num3 = num + num2;
					A(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(array, 0, num3)), val2, val3);
					num = Math.Min(1040, num3);
					global::System.Array.Copy((global::System.Array)array, num3 - num, (global::System.Array)array, 0, num);
				}
				return (global::System.Collections.Generic.IReadOnlyList<ATargetFoundInTheBytes>)val2;
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException || ex is OutOfMemoryException) ? 1 : 0) != 0)
		{
			return global::System.Array.Empty<ATargetFoundInTheBytes>();
		}
	}

	public static global::System.Collections.Generic.IReadOnlyList<ATargetFoundInTheBytes> TargetsIn(byte[] package)
	{
		ArgumentNullException.ThrowIfNull((object)package, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		List<ATargetFoundInTheBytes> val = new List<ATargetFoundInTheBytes>();
		A(global::System.ReadOnlySpan<byte>.op_Implicit(package), val, new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		return (global::System.Collections.Generic.IReadOnlyList<ATargetFoundInTheBytes>)val;
	}

	private static void A(global::System.ReadOnlySpan<byte> window, List<ATargetFoundInTheBytes> P_1, HashSet<string> P_2)
	{
		int num = 0;
		while (num < window.Length)
		{
			int num2 = num;
			int num3 = MemoryExtensions.IndexOf<byte>(window.Slice(num2, window.Length - num2), global::System.ReadOnlySpan<byte>.op_Implicit(LocMetaMagic));
			if (num3 < 0)
			{
				break;
			}
			num += num3 + LocMetaMagic.Length;
			ATargetFoundInTheBytes? aTargetFoundInTheBytes = A(window, num);
			if (aTargetFoundInTheBytes.HasValue)
			{
				ATargetFoundInTheBytes valueOrDefault = aTargetFoundInTheBytes.GetValueOrDefault();
				if (P_2.Add(valueOrDefault.Name + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DI() + valueOrDefault.Culture))
				{
					P_1.Add(valueOrDefault);
				}
			}
		}
	}

	private static ATargetFoundInTheBytes? A(global::System.ReadOnlySpan<byte> P_0, int P_1)
	{
		if (P_1 >= P_0.Length)
		{
			return null;
		}
		P_1++;
		string text = A(P_0, ref P_1);
		if (text != null && text.Length > 0)
		{
			string text2 = A(P_0, ref P_1);
			if (text2 != null && text2.Length > 0)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text2.Replace('\\', '/'));
				if (fileNameWithoutExtension.Length == 0 || !text2.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.S(), (StringComparison)5) || !A(fileNameWithoutExtension) || !A(text))
				{
					return null;
				}
				return new ATargetFoundInTheBytes(fileNameWithoutExtension, text);
			}
		}
		return null;
	}

	private unsafe static string? A(global::System.ReadOnlySpan<byte> P_0, ref int P_1)
	{
		if (P_1 + 4 > P_0.Length)
		{
			return null;
		}
		int num = P_1;
		int num2 = BitConverter.ToInt32(P_0.Slice(num, P_0.Length - num));
		P_1 += 4;
		if (num2 == 0 || Math.Abs(num2) > 260)
		{
			return null;
		}
		if (num2 > 0)
		{
			if (P_1 + num2 > P_0.Length || *(bool*)P_0[P_1 + num2 - 1])
			{
				return null;
			}
			string @string = Encoding.UTF8.GetString(P_0.Slice(P_1, num2 - 1));
			P_1 += num2;
			return @string;
		}
		int num3 = -num2 * 2;
		if (P_1 + num3 > P_0.Length || *(bool*)P_0[P_1 + num3 - 2] || *(bool*)P_0[P_1 + num3 - 1])
		{
			return null;
		}
		string string2 = Encoding.Unicode.GetString(P_0.Slice(P_1, num3 - 2));
		P_1 += num3;
		return string2;
	}

	private static bool A(string P_0)
	{
		return Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)delegate(char P_0)
		{
			switch (P_0)
			{
			case '-':
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
			case '_':
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
				return true;
			default:
				return false;
			}
		});
	}

	static WhenTheIndexIsLocked()
	{
		byte[] array = new byte[16];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		LocMetaMagic = array;
	}
}
