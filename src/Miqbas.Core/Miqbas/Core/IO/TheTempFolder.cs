using System;
using System.Security;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.IO;

public static class TheTempFolder
{
	public static void WithoutQuotes()
	{
		string[] array = new string[2]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nd(),
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NE()
		};
		foreach (string text in array)
		{
			try
			{
				string environmentVariable = Environment.GetEnvironmentVariable(text);
				if (environmentVariable != null && environmentVariable.Contains('"'))
				{
					Environment.SetEnvironmentVariable(text, environmentVariable.Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hu(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()).Trim());
				}
			}
			catch (SecurityException)
			{
			}
		}
	}
}
