using System;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public static class ACrashInTheLog
{
	private static readonly string[] TheWordsOfACrash = new string[8]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.or(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oS(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.os(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oT(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ot(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oU(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ou(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oV()
	};

	public const string ItCrashedBeforeWeTouchedIt = "لعبتك لا تعمل قبل أن ألمسها — شغ\u0651لت\u064fها كما هي فانهارت. فلن أكتب فيها شيئ\u064bا. افتح ستيم، ثم يمين على اللعبة ← Properties ← Installed Files ← Verify integrity of game files، فيعيد تنزيل الملف\u0651 التالف. ثم ارجع إلي\u0651.";

	private static bool A(string P_0)
	{
		if (P_0.StartsWith('*'))
		{
			return P_0.TrimEnd('/').EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oR(), (StringComparison)4);
		}
		return false;
	}

	public static string? In(string? logText)
	{
		if (string.IsNullOrWhiteSpace(logText))
		{
			return null;
		}
		string[] array = logText.Split('\n', (StringSplitOptions)0);
		foreach (string text in array)
		{
			if (A(text.Trim()))
			{
				return text.Trim();
			}
			string[] theWordsOfACrash = TheWordsOfACrash;
			foreach (string text2 in theWordsOfACrash)
			{
				if (text.Contains(text2, (StringComparison)4))
				{
					return text.Trim();
				}
			}
		}
		return null;
	}
}
