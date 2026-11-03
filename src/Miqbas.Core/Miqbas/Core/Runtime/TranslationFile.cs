using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Runtime;

public static class TranslationFile
{
	private const string Header = "# ترجمات مقباس لهذه اللعبة. سطر لكل نص: الأصل ثم فاصل جدولة ثم الترجمة.\n# يمكنك تعديل هذا الملف بنفسك، وسيقرؤه مقباس عند تشغيل اللعبة.\n";

	public static string Write(IReadOnlyDictionary<string, string> translations)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ka());
		System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)translations).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				KeyValuePair<string, string> current = enumerator.Current;
				if (!string.IsNullOrEmpty(current.Key) && !string.IsNullOrEmpty(current.Value))
				{
					val.Append(A(current.Key)).Append('\t').Append(A(current.Value))
						.Append('\n');
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return ((object)val).ToString();
	}

	public static IReadOnlyDictionary<string, string> Read(string text)
	{
		Dictionary<string, string> val = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		string[] array = text.Split('\n', (StringSplitOptions)0);
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i].TrimEnd('\r');
			if (text2.Length != 0 && text2[0] != '#')
			{
				int num = text2.IndexOf('\t');
				if (num > 0 && num != text2.Length - 1)
				{
					string text3 = a(text2.Substring(0, num));
					string text4 = text2;
					int num2 = num + 1;
					val[text3] = a(text4.Substring(num2, text4.Length - num2));
				}
			}
		}
		return (IReadOnlyDictionary<string, string>)(object)val;
	}

	internal static string A(string P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		StringBuilder val = new StringBuilder(P_0.Length);
		foreach (char c in P_0)
		{
			switch (c)
			{
			case '\\':
				val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kB());
				break;
			case '\r':
				val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kb());
				break;
			case '\n':
				val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gf());
				break;
			case '\t':
				val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kC());
				break;
			default:
				val.Append(c);
				break;
			}
		}
		return ((object)val).ToString();
	}

	internal static string a(string P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		StringBuilder val = new StringBuilder(P_0.Length);
		for (int i = 0; i < P_0.Length; i++)
		{
			if (P_0[i] != '\\' || i + 1 >= P_0.Length)
			{
				val.Append(P_0[i]);
				continue;
			}
			i++;
			switch (P_0[i])
			{
			case '\\':
				val.Append('\\');
				break;
			case 'r':
				val.Append('\r');
				break;
			case 'n':
				val.Append('\n');
				break;
			case 't':
				val.Append('\t');
				break;
			default:
				val.Append('\\').Append(P_0[i]);
				break;
			}
		}
		return ((object)val).ToString();
	}
}
