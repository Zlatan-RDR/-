using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

public sealed class NothingMatchedTheGameException : InvalidOperationException
{
	public NothingMatchedTheGameException(string message)
		: base(message)
	{
	}

	public static NothingMatchedTheGameException BecauseNoKeyMatched(int held)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(90, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.la());
		defaultInterpolatedStringHandler.AppendFormatted<int>(held);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lB());
		return new NothingMatchedTheGameException(defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lb());
	}
}
