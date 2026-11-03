using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Miqbas.Core.Translation;

namespace Miqbas.Engines.Unity.Plugin;

internal sealed class TranslationTable
{
	private readonly Dictionary<string, string> _exact = new Dictionary<string, string>(StringComparer.Ordinal);

	private readonly Dictionary<string, string> _trimmed = new Dictionary<string, string>(StringComparer.Ordinal);

	private readonly FilledTemplates _templates = new FilledTemplates();

	internal int Count => _exact.Count;

	internal int TemplateCount => _templates.Count;

	internal static Action<string> TermMissing { get; set; }

	internal static TranslationTable Load(string path, Action<string> log = null)
	{
		TranslationTable translationTable = new TranslationTable();
		if (!File.Exists(path))
		{
			log?.Invoke("لا يوجد ملف ترجمات بعد — ست\u064fعرض اللعبة بلغتها الأصلية.");
			return translationTable;
		}
		int num = 0;
		string[] array = ReadWhileWritten.Lines(path);
		foreach (string text in array)
		{
			if (text.Length == 0 || text[0] == '#')
			{
				continue;
			}
			int num2 = text.IndexOf('\t');
			if (num2 <= 0 || num2 == text.Length - 1)
			{
				num++;
				continue;
			}
			string text2 = TextEscaping.Unescape(text.Substring(0, num2));
			string text3 = TextEscaping.Unescape(text.Substring(num2 + 1));
			if (text2.Length == 0 || text3.Length == 0)
			{
				num++;
			}
			else
			{
				translationTable.Add(text2, text3);
			}
		}
		log?.Invoke((num == 0) ? ("ح\u064fم\u0651لت " + translationTable.Count + " ترجمة.") : ("ح\u064fم\u0651لت " + translationTable.Count + " ترجمة، وت\u064fخط\u0651ي " + num + " سطر\u064bا غير مفهوم."));
		return translationTable;
	}

	internal void Add(string source, string translation)
	{
		_exact[source] = translation;
		string text = source.Trim();
		if (text.Length > 0)
		{
			_trimmed[text] = translation;
		}
		_templates.Learn(source, translation);
	}

	internal int AddMissing(IEnumerable<KeyValuePair<string, string>> pairs)
	{
		int num = 0;
		foreach (KeyValuePair<string, string> pair in pairs)
		{
			if (!_exact.ContainsKey(pair.Key))
			{
				Add(pair.Key, pair.Value);
				num++;
			}
		}
		return num;
	}

	internal string Find(string value)
	{
		string text = FindStored(value);
		if (text != null && text.IndexOf('<') >= 0)
		{
			return FillTaggedTerms(text);
		}
		return text;
	}

	internal string FillTaggedTerms(string translation)
	{
		if (string.IsNullOrEmpty(translation) || translation.IndexOf('<') < 0)
		{
			return translation;
		}
		StringBuilder stringBuilder = new StringBuilder(translation.Length);
		int num = 0;
		while (num < translation.Length)
		{
			int num2 = translation.IndexOf('<', num);
			if (num2 < 0)
			{
				stringBuilder.Append(translation, num, translation.Length - num);
				break;
			}
			stringBuilder.Append(translation, num, num2 - num);
			if (!TryReadElement(translation, num2, out var _, out var openLength, out var closeStart, out var closeLength))
			{
				stringBuilder.Append(translation[num2]);
				num = num2 + 1;
				continue;
			}
			string text = translation.Substring(num2 + openLength, closeStart - num2 - openLength);
			string text2 = StripTags(text);
			string text3 = PlainSpaces(text2).Trim();
			string text4 = null;
			if (text3.Length > 0 && !ArabicDirection.ContainsArabic(text3) && HasLetters(text3))
			{
				text4 = FindStored(text3);
				if (text4 != null && !ArabicDirection.ContainsArabic(text4))
				{
					text4 = null;
				}
				if (text4 == null && text.IndexOf('<') < 0)
				{
					TermMissing?.Invoke(text3);
				}
			}
			stringBuilder.Append(translation, num2, openLength);
			stringBuilder.Append((text4 != null) ? ReplaceInsideTheInnermostWrapper(text, text2.Substring(0, text2.Length - text2.TrimStart(Array.Empty<char>()).Length) + text4 + text2.Substring(text2.TrimEnd(Array.Empty<char>()).Length)) : FillTaggedTerms(text));
			stringBuilder.Append(translation, closeStart, closeLength);
			num = closeStart + closeLength;
		}
		return stringBuilder.ToString();
	}

	private static string ReplaceInsideTheInnermostWrapper(string content, string replacement)
	{
		string text = content.Trim();
		if (text.Length > 0 && text[0] == '<' && TryReadElement(text, 0, out var _, out var openLength, out var closeStart, out var closeLength) && closeStart + closeLength == text.Length)
		{
			return text.Substring(0, openLength) + ReplaceInsideTheInnermostWrapper(text.Substring(openLength, closeStart - openLength), replacement) + text.Substring(closeStart, closeLength);
		}
		return replacement;
	}

	private static string PlainSpaces(string text)
	{
		if (text.IndexOf('\u00a0') < 0 && text.IndexOf('\u2009') < 0 && text.IndexOf('\u202f') < 0)
		{
			return text;
		}
		return text.Replace('\u00a0', ' ').Replace('\u2009', ' ').Replace('\u202f', ' ');
	}

	private static bool HasLetters(string text)
	{
		for (int i = 0; i < text.Length; i++)
		{
			if (char.IsLetter(text[i]))
			{
				return true;
			}
		}
		return false;
	}

	private static string StripTags(string text)
	{
		if (text.IndexOf('<') < 0)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		int num = 0;
		while (num < text.Length)
		{
			if (text[num] == '<')
			{
				int? num2 = TagLengthAt(text, num);
				if (num2.HasValue)
				{
					int valueOrDefault = num2.GetValueOrDefault();
					num += valueOrDefault;
					continue;
				}
			}
			stringBuilder.Append(text[num]);
			num++;
		}
		return stringBuilder.ToString();
	}

	private static int? TagLengthAt(string text, int at)
	{
		int num = text.IndexOf('>', at + 1);
		if (num < 0 || num == at + 1)
		{
			return null;
		}
		int num2 = text.IndexOf('<', at + 1);
		if (num2 < 0 || num2 >= num)
		{
			return num - at + 1;
		}
		return null;
	}

	private static string TagName(string text, int at, int length)
	{
		int i = at + ((text.Length <= at + 1 || text[at + 1] != '/') ? 1 : 2);
		int num = i;
		for (; i < at + length && text[i] != '>' && text[i] != ' ' && text[i] != '=' && text[i] != '/'; i++)
		{
		}
		return text.Substring(num, i - num);
	}

	private static bool TryReadElement(string text, int open, out string name, out int openLength, out int closeStart, out int closeLength)
	{
		name = null;
		closeStart = -1;
		closeLength = 0;
		openLength = 0;
		int? num = TagLengthAt(text, open);
		if (num.HasValue)
		{
			int valueOrDefault = num.GetValueOrDefault();
			if (text[open + 1] != '/')
			{
				openLength = valueOrDefault;
				name = TagName(text, open, valueOrDefault);
				if (name.Length == 0)
				{
					return false;
				}
				int num2 = 1;
				int num3 = open + valueOrDefault;
				while (num3 < text.Length)
				{
					if (text[num3] == '<')
					{
						num = TagLengthAt(text, num3);
						if (num.HasValue)
						{
							int valueOrDefault2 = num.GetValueOrDefault();
							if (string.Equals(TagName(text, num3, valueOrDefault2), name, StringComparison.OrdinalIgnoreCase))
							{
								num2 += ((text[num3 + 1] != '/') ? 1 : (-1));
								if (num2 == 0)
								{
									closeStart = num3;
									closeLength = valueOrDefault2;
									return true;
								}
							}
							num3 += valueOrDefault2;
							continue;
						}
					}
					num3++;
				}
				return false;
			}
		}
		return false;
	}

	private string FindStored(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		if (_exact.TryGetValue(value, out var value2))
		{
			return value2;
		}
		string text = value.Trim();
		bool flag = text.Length != value.Length;
		if (flag && _trimmed.TryGetValue(text, out var value3))
		{
			return Repad(value, text, value3);
		}
		if (ArabicDirection.ContainsArabic(value))
		{
			return null;
		}
		string text2 = _templates.Find(value);
		if (text2 != null)
		{
			return text2;
		}
		if (flag)
		{
			string text3 = _templates.Find(text);
			if (text3 != null)
			{
				return Repad(value, text, text3);
			}
		}
		string text4 = NumbersBesideAKnownWord(value);
		if (text4 != null)
		{
			return text4;
		}
		if (value.IndexOf('\n') >= 0)
		{
			string text5 = FindStored(value.Replace("\n", "\\n"));
			if (text5 != null)
			{
				return text5.Replace("\\n", "\n");
			}
		}
		return null;
	}

	private string NumbersBesideAKnownWord(string value)
	{
		string[] array = value.Split(new char[1] { ' ' });
		int i = 0;
		int num;
		for (num = array.Length - 1; i <= num && IsANumber(array[i]); i++)
		{
		}
		while (num >= i && IsANumber(array[num]))
		{
			num--;
		}
		if (i > num || (i == 0 && num == array.Length - 1))
		{
			return null;
		}
		for (int j = i; j <= num; j++)
		{
			if (array[j].Length == 0 || IsANumber(array[j]))
			{
				return null;
			}
		}
		string text = string.Join(" ", array, i, num - i + 1);
		if (!HasLetters(text) || ArabicDirection.ContainsArabic(text) || !_exact.TryGetValue(text, out var value2) || !ArabicDirection.ContainsArabic(value2))
		{
			return null;
		}
		string text2 = string.Join(" ", array, 0, i);
		string text3 = string.Join(" ", array, num + 1, array.Length - num - 1);
		return ((text2.Length > 0) ? (text2 + " ") : "") + value2 + ((text3.Length > 0) ? (" " + text3) : "");
	}

	private static bool IsANumber(string token)
	{
		bool result = false;
		foreach (char c in token)
		{
			if (char.IsDigit(c))
			{
				result = true;
			}
			else if (".,:/%+-$".IndexOf(c) < 0)
			{
				return false;
			}
		}
		return result;
	}

	private static string Repad(string value, string trimmed, string translation)
	{
		int num = value.IndexOf(trimmed[0]);
		return value.Substring(0, num) + translation + value.Substring(num + trimmed.Length);
	}
}
