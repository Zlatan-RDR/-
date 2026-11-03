using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Runtime;

namespace A;

internal static class H
{
	public static void A(string? value, string P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			throw new ArgumentNullException(P_1);
		}
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new ArgumentException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JF(), P_1);
		}
	}

	public static void A(object? value, string P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			throw new ArgumentNullException(P_1);
		}
	}
}
internal static class h
{
	internal static System.Collections.Generic.IReadOnlyList<string>? A(string P_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(P_0) || new FileInfo(P_0).Length > 16777216)
		{
			return null;
		}
		HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		List<string> val2 = new List<string>();
		string[] array = File.ReadAllLines(P_0, Encoding.UTF8);
		foreach (string text in array)
		{
			if (text.Length != 0 && text.Length <= 4096)
			{
				string text2 = TranslationFile.a(text);
				if (text2.Length > 0 && val.Add(text2))
				{
					val2.Add(text2);
				}
			}
		}
		return (System.Collections.Generic.IReadOnlyList<string>?)val2;
	}
}
