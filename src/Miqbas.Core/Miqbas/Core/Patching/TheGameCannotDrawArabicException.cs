using System;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

public sealed class TheGameCannotDrawArabicException : InvalidOperationException
{
	public TheGameCannotDrawArabicException(string message)
		: base(message)
	{
	}

	public static TheGameCannotDrawArabicException Because(string why)
	{
		return new TheGameCannotDrawArabicException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.le() + why + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lF());
	}
}
