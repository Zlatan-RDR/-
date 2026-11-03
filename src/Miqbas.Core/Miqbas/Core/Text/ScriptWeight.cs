using System;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class ScriptWeight
{
	public const double PerCjkCharacter = 2.5;

	public static bool IsCjk(char c)
	{
		if (c >= '一')
		{
			if (c >= '豈')
			{
				if (c >= '\uff00')
				{
					if (c <= '\uffef')
					{
						goto IL_006a;
					}
				}
				else if (c <= '\ufaff')
				{
					goto IL_006a;
				}
			}
			else if (c >= '가')
			{
				if (c <= '\ud7af')
				{
					goto IL_006a;
				}
			}
			else if (c <= '鿿')
			{
				goto IL_006a;
			}
		}
		else if (c >= '㐀')
		{
			if (c <= '䶿')
			{
				goto IL_006a;
			}
		}
		else if (c >= '\u3000' && c <= 'ヿ')
		{
			goto IL_006a;
		}
		return false;
		IL_006a:
		return true;
	}

	public static double Weigh(string text)
	{
		ArgumentNullException.ThrowIfNull((object)text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HT());
		double num = 0.0;
		foreach (char c in text)
		{
			num += (IsCjk(c) ? 2.5 : 1.0);
		}
		return num;
	}

	public static bool IsMostlyCjk(string text)
	{
		ArgumentNullException.ThrowIfNull((object)text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HT());
		int num = 0;
		int num2 = 0;
		foreach (char c in text)
		{
			if (IsCjk(c))
			{
				num++;
				num2++;
			}
			else if (char.IsLetter(c))
			{
				num2++;
			}
		}
		if (num2 > 0)
		{
			return num * 2 > num2;
		}
		return false;
	}
}
