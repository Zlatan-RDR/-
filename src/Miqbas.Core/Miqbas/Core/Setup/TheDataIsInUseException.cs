using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Setup;

public sealed class TheDataIsInUseException : System.Exception
{
	[field: CompilerGenerated]
	public string DataFolder
	{
		[CompilerGenerated]
		get;
	}

	public TheDataIsInUseException(string dataFolder, System.Exception inner)
	{
		DataFolder = dataFolder;
		base._002Ector(A(dataFolder), inner);
	}

	private static string A(string P_0)
	{
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jf() + P_0;
	}
}
