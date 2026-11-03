using System;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class ArabicMarks
{
	public static string Without(string text)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HT());
		string text2 = text.Normalize((NormalizationForm)1);
		StringBuilder val = new StringBuilder(text2.Length);
		string text3 = text2;
		foreach (char c in text3)
		{
			if (!IsAMark(c))
			{
				val.Append(c);
			}
		}
		return ((object)val).ToString();
	}

	public static bool IsAMark(char c)
	{
		switch (c)
		{
		case '\u064b':
		case '\u064c':
		case '\u064d':
		case '\u064e':
		case '\u064f':
		case '\u0650':
		case '\u0651':
		case '\u0652':
		case '\u0653':
		case '\u0654':
		case '\u0655':
		case '\u0656':
		case '\u0657':
		case '\u0658':
		case '\u0659':
		case '\u065a':
		case '\u065b':
		case '\u065c':
		case '\u065d':
		case '\u065e':
		case '\u065f':
		case '\u0670':
			return true;
		default:
			return false;
		}
	}
}
