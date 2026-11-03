using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Setup;

public static class SetupCommandLine
{
	public static string Join(System.Collections.Generic.IEnumerable<string> arguments)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		H.A(arguments, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Je());
		StringBuilder val = new StringBuilder();
		System.Collections.Generic.IEnumerator<string> enumerator = arguments.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (val.Length > 0)
				{
					val.Append(' ');
				}
				A(val, current ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return ((object)val).ToString();
	}

	private static void A(StringBuilder P_0, string P_1)
	{
		if (P_1.Length > 0)
		{
			char[] array = new char[5];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			if (P_1.IndexOfAny(array) < 0)
			{
				P_0.Append(P_1);
				return;
			}
		}
		P_0.Append('"');
		int num = 0;
		foreach (char c in P_1)
		{
			switch (c)
			{
			case '\\':
				num++;
				continue;
			case '"':
				P_0.Append('\\', num * 2 + 1).Append('"');
				break;
			default:
				P_0.Append('\\', num).Append(c);
				break;
			}
			num = 0;
		}
		P_0.Append('\\', num * 2).Append('"');
	}

	public static bool IsFullyQualified(string? path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return false;
		}
		if (path.Length >= 2 && A(path[0]) && A(path[1]))
		{
			return true;
		}
		if (path.Length >= 3 && char.IsLetter(path[0]) && path[1] == ':')
		{
			return A(path[2]);
		}
		return false;
	}

	[CompilerGenerated]
	internal static bool A(char P_0)
	{
		if (P_0 == '/' || P_0 == '\\')
		{
			return true;
		}
		return false;
	}
}
