namespace Miqbas.Core.Text;

public static class ArabicScript
{
	public static bool IsArabicLetter(char c)
	{
		if (c >= 'ݐ')
		{
			if (c >= 'ﭐ')
			{
				if (c >= 'ﹰ')
				{
					if (c <= 'ﻼ')
					{
						goto IL_006a;
					}
				}
				else if (c <= '﷿')
				{
					goto IL_006a;
				}
			}
			else if (c >= 'ࡰ')
			{
				if (c <= '\u08ff')
				{
					goto IL_006a;
				}
			}
			else if (c <= 'ݿ')
			{
				goto IL_006a;
			}
		}
		else if (c >= 'ٮ')
		{
			if (c <= 'ۯ')
			{
				goto IL_006a;
			}
		}
		else if (c >= 'ؠ' && c <= '\u065f')
		{
			goto IL_006a;
		}
		return false;
		IL_006a:
		return true;
	}

	private static bool A(char P_0)
	{
		switch (P_0)
		{
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

	public static bool ContainsArabic(string text)
	{
		for (int i = 0; i < text.Length; i++)
		{
			if (IsArabicLetter(text[i]))
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsAlreadyArabic(string text)
	{
		int num = 0;
		int num2 = 0;
		foreach (char c in text)
		{
			if (IsArabicLetter(c))
			{
				num++;
			}
			else if (A(c))
			{
				num2++;
			}
		}
		if (num > 0)
		{
			return num > num2;
		}
		return false;
	}
}
