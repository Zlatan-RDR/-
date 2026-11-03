using System;
using System.Collections.Generic;
using System.Text;

namespace Miqbas.Unity.AndroidCore.Shaping;

public static class ArabicShaper
{
	private static readonly Dictionary<char, ValueTuple<char, char, char, char>> Forms = new Dictionary<char, ValueTuple<char, char, char, char>>
	{
		['ء'] = new ValueTuple<char, char, char, char>('ﺀ', '\0', '\0', '\0'),
		['آ'] = new ValueTuple<char, char, char, char>('ﺁ', 'ﺂ', '\0', '\0'),
		['أ'] = new ValueTuple<char, char, char, char>('ﺃ', 'ﺄ', '\0', '\0'),
		['ؤ'] = new ValueTuple<char, char, char, char>('ﺅ', 'ﺆ', '\0', '\0'),
		['إ'] = new ValueTuple<char, char, char, char>('ﺇ', 'ﺈ', '\0', '\0'),
		['ئ'] = new ValueTuple<char, char, char, char>('ﺉ', 'ﺊ', 'ﺋ', 'ﺌ'),
		['ا'] = new ValueTuple<char, char, char, char>('ﺍ', 'ﺎ', '\0', '\0'),
		['ب'] = new ValueTuple<char, char, char, char>('ﺏ', 'ﺐ', 'ﺑ', 'ﺒ'),
		['ة'] = new ValueTuple<char, char, char, char>('ﺓ', 'ﺔ', '\0', '\0'),
		['ت'] = new ValueTuple<char, char, char, char>('ﺕ', 'ﺖ', 'ﺗ', 'ﺘ'),
		['ث'] = new ValueTuple<char, char, char, char>('ﺙ', 'ﺚ', 'ﺛ', 'ﺜ'),
		['ج'] = new ValueTuple<char, char, char, char>('ﺝ', 'ﺞ', 'ﺟ', 'ﺠ'),
		['ح'] = new ValueTuple<char, char, char, char>('ﺡ', 'ﺢ', 'ﺣ', 'ﺤ'),
		['خ'] = new ValueTuple<char, char, char, char>('ﺥ', 'ﺦ', 'ﺧ', 'ﺨ'),
		['د'] = new ValueTuple<char, char, char, char>('ﺩ', 'ﺪ', '\0', '\0'),
		['ذ'] = new ValueTuple<char, char, char, char>('ﺫ', 'ﺬ', '\0', '\0'),
		['ر'] = new ValueTuple<char, char, char, char>('ﺭ', 'ﺮ', '\0', '\0'),
		['ز'] = new ValueTuple<char, char, char, char>('ﺯ', 'ﺰ', '\0', '\0'),
		['س'] = new ValueTuple<char, char, char, char>('ﺱ', 'ﺲ', 'ﺳ', 'ﺴ'),
		['ش'] = new ValueTuple<char, char, char, char>('ﺵ', 'ﺶ', 'ﺷ', 'ﺸ'),
		['ص'] = new ValueTuple<char, char, char, char>('ﺹ', 'ﺺ', 'ﺻ', 'ﺼ'),
		['ض'] = new ValueTuple<char, char, char, char>('ﺽ', 'ﺾ', 'ﺿ', 'ﻀ'),
		['ط'] = new ValueTuple<char, char, char, char>('ﻁ', 'ﻂ', 'ﻃ', 'ﻄ'),
		['ظ'] = new ValueTuple<char, char, char, char>('ﻅ', 'ﻆ', 'ﻇ', 'ﻈ'),
		['ع'] = new ValueTuple<char, char, char, char>('ﻉ', 'ﻊ', 'ﻋ', 'ﻌ'),
		['غ'] = new ValueTuple<char, char, char, char>('ﻍ', 'ﻎ', 'ﻏ', 'ﻐ'),
		['ف'] = new ValueTuple<char, char, char, char>('ﻑ', 'ﻒ', 'ﻓ', 'ﻔ'),
		['ق'] = new ValueTuple<char, char, char, char>('ﻕ', 'ﻖ', 'ﻗ', 'ﻘ'),
		['ك'] = new ValueTuple<char, char, char, char>('ﻙ', 'ﻚ', 'ﻛ', 'ﻜ'),
		['ل'] = new ValueTuple<char, char, char, char>('ﻝ', 'ﻞ', 'ﻟ', 'ﻠ'),
		['م'] = new ValueTuple<char, char, char, char>('ﻡ', 'ﻢ', 'ﻣ', 'ﻤ'),
		['ن'] = new ValueTuple<char, char, char, char>('ﻥ', 'ﻦ', 'ﻧ', 'ﻨ'),
		['ه'] = new ValueTuple<char, char, char, char>('ﻩ', 'ﻪ', 'ﻫ', 'ﻬ'),
		['و'] = new ValueTuple<char, char, char, char>('ﻭ', 'ﻮ', '\0', '\0'),
		['ى'] = new ValueTuple<char, char, char, char>('ﻯ', 'ﻰ', '\0', '\0'),
		['ي'] = new ValueTuple<char, char, char, char>('ﻱ', 'ﻲ', 'ﻳ', 'ﻴ')
	};

	private static readonly Dictionary<char, ValueTuple<char, char>> LamAlef = new Dictionary<char, ValueTuple<char, char>>
	{
		['آ'] = new ValueTuple<char, char>('ﻵ', 'ﻶ'),
		['أ'] = new ValueTuple<char, char>('ﻷ', 'ﻸ'),
		['إ'] = new ValueTuple<char, char>('ﻹ', 'ﻺ'),
		['ا'] = new ValueTuple<char, char>('ﻻ', 'ﻼ')
	};

	private const char Lam = 'ل';

	private const char Tatweel = 'ـ';

	public static global::System.Collections.Generic.IReadOnlyCollection<char> ShapesItCanEmit
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			SortedSet<char> val = new SortedSet<char>();
			foreach (var current in Forms)
			{
				val.Add(current.Key);
				char[] array = new char[4]
				{
					current.Value.Item1,
					current.Value.Item2,
					current.Value.Item3,
					current.Value.Item4
				};
				foreach (char c in array)
				{
					if (c != 0)
					{
						val.Add(c);
					}
				}
			}

			foreach (var current2 in LamAlef)
			{
				val.Add(current2.Value.Item1);
				val.Add(current2.Value.Item2);
			}

			val.Add('ل');
			val.Add('ـ');
			return (global::System.Collections.Generic.IReadOnlyCollection<char>)val;
		}
	}

	public static string Shape(string text)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (text == null)
		{
			return string.Empty;
		}
		if (text.Length == 0 || !ContainsArabic(text))
		{
			return text;
		}
		StringBuilder val = new StringBuilder(text.Length);
		ValueTuple<char, char> val2 = default(ValueTuple<char, char>);
		ValueTuple<char, char, char, char> forms = default(ValueTuple<char, char, char, char>);
		for (int i = 0; i < text.Length; i++)
		{
			char c = text[i];
			if (B(c))
			{
				val.Append(c);
				continue;
			}
			char c2 = A(text, i);
			int num;
			char c3 = A(text, i, out num);
			if (c == 'ل' && c3 != 0 && LamAlef.TryGetValue(c3, out val2))
			{
				val.Append(A(c2) ? val2.Item2 : val2.Item1);
				i = num;
			}
			else if (!Forms.TryGetValue(c, out forms))
			{
				val.Append(c);
			}
			else
			{
				val.Append(A(forms, A(c2), a(c3)));
			}
		}
		return val.ToString();
	}

	public static bool ContainsArabic(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		foreach (char c in text)
		{
			if (Forms.ContainsKey(c) || c == 'ـ')
			{
				return true;
			}
		}
		return false;
	}

	private static char A(ValueTuple<char, char, char, char> forms, bool P_1, bool P_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = P_2 && forms.Item3 != '\0';
		if (P_1 && flag && forms.Item4 != 0)
		{
			return forms.Item4;
		}
		if (P_1 && forms.Item2 != 0)
		{
			return forms.Item2;
		}
		if (flag)
		{
			return forms.Item3;
		}
		return forms.Item1;
	}

	private static bool A(char P_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 != 'ـ')
		{
			ValueTuple<char, char, char, char> val = default(ValueTuple<char, char, char, char>);
			if (Forms.TryGetValue(P_0, out val))
			{
				return val.Item3 != '\0';
			}
			return false;
		}
		return true;
	}

	private static bool a(char P_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 != 'ـ')
		{
			ValueTuple<char, char, char, char> val = default(ValueTuple<char, char, char, char>);
			if (Forms.TryGetValue(P_0, out val))
			{
				return val.Item2 != '\0';
			}
			return false;
		}
		return true;
	}

	private static char A(string P_0, int P_1)
	{
		for (int num = P_1 - 1; num >= 0; num--)
		{
			if (!B(P_0[num]))
			{
				return P_0[num];
			}
		}
		return '\0';
	}

	private static char A(string P_0, int P_1, out int P_2)
	{
		for (int i = P_1 + 1; i < P_0.Length; i++)
		{
			if (!B(P_0[i]))
			{
				P_2 = i;
				return P_0[i];
			}
		}
		P_2 = -1;
		return '\0';
	}

	private static bool B(char P_0)
	{
		if (P_0 < '\u064b' || P_0 > '\u065f')
		{
			switch (P_0)
			{
			default:
				return P_0 == '\u200d';
			case '\u0670':
			case '\u06d6':
			case '\u06d7':
			case '\u06d8':
			case '\u06d9':
			case '\u06da':
			case '\u06db':
			case '\u06dc':
			case '\u06dd':
			case '۞':
			case '\u06df':
			case '\u06e0':
			case '\u06e1':
			case '\u06e2':
			case '\u06e3':
			case '\u06e4':
			case 'ۥ':
			case 'ۦ':
			case '\u06e7':
			case '\u06e8':
			case '۩':
			case '\u06ea':
			case '\u06eb':
			case '\u06ec':
			case '\u06ed':
				break;
			}
		}
		return true;
	}
}
