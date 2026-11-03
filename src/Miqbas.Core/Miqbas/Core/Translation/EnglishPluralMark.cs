using System;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class EnglishPluralMark
{
	private static readonly Regex InTheEnglish = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BG(), (RegexOptions)512, TimeSpan.FromSeconds(1.0));

	private static readonly Regex InTheArabic = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bg(), (RegexOptions)512, TimeSpan.FromSeconds(1.0));

	public static string Mend(string english, string arabic)
	{
		ArgumentNullException.ThrowIfNull((object)arabic, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.E());
		if (english == null || english.Length <= 0 || !InTheEnglish.IsMatch(english))
		{
			return arabic;
		}
		return InTheArabic.Replace(arabic, string.Empty);
	}
}
