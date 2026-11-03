using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Packages;

public static class MqbsInstallMethods
{
	public const string FullPatch = "full-patch";

	public const string RuntimeLayer = "runtime-layer";

	public static bool IsKnown(string method)
	{
		if (method == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lf() || method == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lG())
		{
			return true;
		}
		return false;
	}
}
