using System;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Engines;

public static class PlainLine
{
	public static string Of(string? line)
	{
		return a().Replace(A().Replace((line ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oA(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hu(), (StringComparison)4).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oa(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oB(), (StringComparison)4).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ob(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oC(), (StringComparison)4)
			.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oc(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hu(), (StringComparison)4)
			.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oD(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.od(), (StringComparison)4), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X()).Trim();
	}

	[GeneratedRegex("<[^<>]*>|\\{[^{}]*\\}")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex A()
	{
		return (Regex)(object)E.Instance;
	}

	[GeneratedRegex("\\s+")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex a()
	{
		return (Regex)(object)D.Instance;
	}
}
