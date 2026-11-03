using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Booting;

public static class LoaderLogReader
{
	private const string ReadyMarker = "مقباس جاهز داخل";

	private const string FontInstalledMarker = "الخط العربي ر\u064fك\u0651ب";

	private const string FontFailedMarker = "تعذ\u0651ر إنشاء أصل الخط";

	private const string BannerlordReadyMarker = "[Miqbas] ready inside Bannerlord";

	private const string BannerlordFontGivenMarker = "[Miqbas] Arabic page given to the game";

	private const string BannerlordFontNotGivenMarker = "[Miqbas] Arabic page NOT given";

	private const string BannerlordModuleId = "MiqbasArabic";

	[GeneratedRegex("Command Args:[^\\r\\n]*?_MODULES_(?<list>[^\\r\\n]*?)_MODULES_")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex A()
	{
		return (Regex)(object)global::A.a.Instance;
	}

	[GeneratedRegex("مسح الاتجاه — بعد .*?:\\s*(?<labels>\\d+)\\s*لافتة.*?و(?<arabic>\\d+)\\s*فيها عربية")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex a()
	{
		return (Regex)(object)B.Instance;
	}

	public static LoaderSignals Read(string logText)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(logText))
		{
			return new LoaderSignals();
		}
		int labels = 0;
		int arabicLabels = 0;
		foreach (Match item in a().Matches(logText))
		{
			labels = int.Parse(((Capture)item.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.e()]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture);
			arabicLabels = int.Parse(((Capture)item.Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.E()]).Value, (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}
		bool flag = logText.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pX(), (StringComparison)4) || logText.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.px(), (StringComparison)4);
		LoaderSignals obj = new LoaderSignals
		{
			MiqbasIsReady = (logText.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pY(), (StringComparison)4) || logText.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.py(), (StringComparison)4)),
			FontInstalled = flag,
			FontFailed = ((logText.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pZ(), (StringComparison)4) || logText.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pz(), (StringComparison)4)) && !flag),
			Labels = labels,
			ArabicLabels = arabicLabels
		};
		MatchCollection val2 = A().Matches(logText);
		int startedWithoutOurModule;
		if (val2 != null && val2.Count > 0)
		{
			startedWithoutOurModule = ((!Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)((Capture)val2[val2.Count - 1].Groups[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.D()]).Value.Split('*', (StringSplitOptions)1), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QA(), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase)) ? 1 : 0);
		}
		else
		{
			startedWithoutOurModule = 0;
		}
		obj.StartedWithoutOurModule = (byte)startedWithoutOurModule != 0;
		return obj;
	}
}
