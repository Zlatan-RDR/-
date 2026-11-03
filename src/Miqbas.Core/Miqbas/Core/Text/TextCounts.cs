using System;
using System.Globalization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class TextCounts
{
	public static string Nominative(int count)
	{
		return count switch
		{
			1 => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IC(), 
			2 => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ic(), 
			_ => A(count), 
		};
	}

	public static string AfterAWord(int count)
	{
		return count switch
		{
			1 => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IC(), 
			2 => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ID(), 
			_ => A(count), 
		};
	}

	public static string AsObject(int count)
	{
		return count switch
		{
			1 => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Id(), 
			2 => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ID(), 
			_ => A(count), 
		};
	}

	private static string A(int P_0)
	{
		if (P_0 < 3 || P_0 > 10)
		{
			return P_0.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IE();
		}
		return P_0.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ie();
	}
}
