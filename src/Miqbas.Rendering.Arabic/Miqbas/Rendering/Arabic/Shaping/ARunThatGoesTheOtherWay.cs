using System.Text;

namespace Miqbas.Rendering.Arabic.Shaping;

public static class ARunThatGoesTheOtherWay
{
	public static string Reversed(string text)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (string.IsNullOrEmpty(text))
		{
			return text ?? string.Empty;
		}
		StringBuilder val = new StringBuilder(text.Length);
		int num = 0;
		while (num < text.Length)
		{
			if (text[num] == '<')
			{
				int num2 = text.IndexOf('>', num);
				if (num2 > num)
				{
					val.Append(text, num, num2 - num + 1);
					num = num2 + 1;
					continue;
				}
			}
			if (!A(text[num]))
			{
				val.Append(text[num]);
				num++;
				continue;
			}
			int i = num;
			for (int j = num; j < text.Length && text[j] != '<'; j++)
			{
				if (A(text[j]))
				{
					i = j;
				}
				else if (!a(text[j]))
				{
					break;
				}
			}
			for (; i + 1 < text.Length && B(text[i + 1]); i++)
			{
			}
			for (int num3 = i; num3 >= num; num3--)
			{
				val.Append(b(text[num3]));
			}
			num = i + 1;
		}
		return ((object)val).ToString();
	}

	private static bool A(char P_0)
	{
		if (P_0 >= 'a')
		{
			if (P_0 >= 'À')
			{
				if (P_0 <= 'ɏ')
				{
					goto IL_0034;
				}
			}
			else if (P_0 <= 'z')
			{
				goto IL_0034;
			}
		}
		else if (P_0 >= 'A')
		{
			if (P_0 <= 'Z')
			{
				goto IL_0034;
			}
		}
		else if (P_0 >= '0' && P_0 <= '9')
		{
			goto IL_0034;
		}
		return false;
		IL_0034:
		return true;
	}

	private static bool a(char P_0)
	{
		switch (P_0)
		{
		case '%':
		case '\'':
		case '+':
		case ',':
		case '-':
		case '.':
		case '/':
		case ':':
		case '·':
		case '×':
			return true;
		default:
			return false;
		}
	}

	private static bool B(char P_0)
	{
		switch (P_0)
		{
		case '$':
		case '%':
		case '£':
		case '¥':
		case '°':
		case '٪':
		case '€':
			return true;
		default:
			return false;
		}
	}

	private static char b(char P_0)
	{
		return P_0 switch
		{
			'(' => ')', 
			')' => '(', 
			'[' => ']', 
			']' => '[', 
			'{' => '}', 
			'}' => '{', 
			'<' => '>', 
			'>' => '<', 
			_ => P_0, 
		};
	}
}
