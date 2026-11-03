using System;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public static class LineFingerprint
{
	public static ulong Of(string line)
	{
		ArgumentNullException.ThrowIfNull((object)line, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pu());
		ulong num = 14695981039346656037uL;
		foreach (char c in line)
		{
			num ^= c;
			num *= 1099511628211L;
		}
		return num;
	}
}
