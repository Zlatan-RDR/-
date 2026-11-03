using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class ScriptNames
{
	public static string Of(int codepoint)
	{
		if (codepoint >= 12352)
		{
			if (codepoint >= 44032)
			{
				if (codepoint >= 64336)
				{
					if (codepoint <= 65279)
					{
						return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GS();
					}
				}
				else if (codepoint <= 55215)
				{
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GR();
				}
			}
			else if (codepoint >= 13312)
			{
				if (codepoint <= 40959)
				{
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gq();
				}
			}
			else if (codepoint <= 12543)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GQ();
			}
		}
		else if (codepoint <= 1535)
		{
			if (codepoint >= 1024)
			{
				if (codepoint <= 1327)
				{
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gn();
				}
				if (codepoint >= 1424)
				{
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Go();
				}
			}
			else if (codepoint <= 591)
			{
				if (codepoint >= 256)
				{
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gr();
				}
			}
			else if (codepoint >= 880)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GO();
			}
		}
		else if (codepoint >= 3584)
		{
			if (codepoint >= 4352)
			{
				if (codepoint <= 4607)
				{
					return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GR();
				}
			}
			else if (codepoint <= 3711)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gp();
			}
		}
		else if (codepoint >= 2304)
		{
			if (codepoint <= 2431)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GP();
			}
		}
		else if (codepoint <= 1791)
		{
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GS();
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gs();
	}
}
