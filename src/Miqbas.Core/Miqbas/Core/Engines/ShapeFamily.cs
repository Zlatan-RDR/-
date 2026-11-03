using System;
using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public static class ShapeFamily
{
	public const string ComponentField = "component-field";

	public const string ComponentFieldJson = "component-field-json";

	public const string Json = "json";

	public static readonly IReadOnlySet<string> All;

	static ShapeFamily()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OX());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ok());
		All = (IReadOnlySet<string>)(object)obj;
	}
}
