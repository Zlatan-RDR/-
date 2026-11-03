using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class Untranslatable
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<char, bool> _003C0_003E__IsWhiteSpace;

		public static Func<char, bool> _003C1_003E__IsLetter;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<char, bool> _003C_003E9__1_0;

		internal bool A(char P_0)
		{
			bool flag = char.IsLetter(P_0);
			if (flag)
			{
				bool flag2 = ((P_0 == 'X' || P_0 == 'x') ? true : false);
				flag = !flag2;
			}
			return flag;
		}
	}

	public static bool IsFiller(string value)
	{
		return value.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ft(), (StringComparison)5);
	}

	public static bool Is(string value)
	{
		string masked = VariableMasker.Mask(value).Masked;
		if (Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)masked, (Func<char, bool>)delegate(char P_0)
		{
			bool flag = char.IsLetter(P_0);
			if (flag)
			{
				bool flag2 = ((P_0 == 'X' || P_0 == 'x') ? true : false);
				flag = !flag2;
			}
			return flag;
		}) && !a(masked) && !IsAlreadyArabic(masked))
		{
			return A(value);
		}
		return true;
	}

	private static bool A(string P_0)
	{
		if (P_0.Length >= 6 && P_0[0] == '/' && !Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)char.IsWhiteSpace))
		{
			char[] array = new char[6];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			if (P_0.IndexOfAny(array) < 0)
			{
				if (MemoryExtensions.IndexOfAny<char>(MemoryExtensions.AsSpan(P_0, 1), '/', '.') >= 0)
				{
					return Enumerable.Any<char>(Enumerable.Skip<char>((System.Collections.Generic.IEnumerable<char>)P_0, 1), (Func<char, bool>)char.IsLetter);
				}
				return false;
			}
		}
		return false;
	}

	private static bool a(string P_0)
	{
		string text = P_0.Trim();
		if (text.Length == 1)
		{
			return char.IsLetter(text[0]);
		}
		return false;
	}

	public static bool IsAlreadyArabic(string masked)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (char c in masked)
		{
			if (c >= '\u0600' && c <= 'ۿ')
			{
				num++;
				num2 = 0;
			}
			else if (char.IsAsciiLetter(c))
			{
				num3 = Math.Max(num3, ++num2);
			}
			else
			{
				num2 = 0;
			}
		}
		if (num > 0)
		{
			return num3 <= 2;
		}
		return false;
	}
}
