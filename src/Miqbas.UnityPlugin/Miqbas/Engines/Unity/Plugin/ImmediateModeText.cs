using System;
using System.Collections.Generic;
using System.Text;
using Miqbas.Rendering.Arabic.Layout;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Engines.Unity.Plugin;

internal static class ImmediateModeText
{
	internal readonly struct Verdict
	{
		internal static readonly Verdict LeaveAlone = new Verdict(null, worthAsking: false);

		internal string Replacement { get; }

		internal string Arabic { get; }

		internal bool WorthAsking { get; }

		internal Verdict(string replacement, bool worthAsking, string arabic = null)
		{
			Replacement = replacement;
			WorthAsking = worthAsking;
			Arabic = arabic;
		}
	}

	internal readonly struct LaidOut
	{
		internal string Text { get; }

		internal int Lines { get; }

		internal LaidOut(string text, int lines)
		{
			Text = text;
			Lines = lines;
		}
	}

	private sealed class OpenTag
	{
		internal string Name { get; }

		internal string Raw { get; }

		internal OpenTag(string name, string raw)
		{
			Name = name;
			Raw = raw;
		}
	}

	private static readonly string[] RichTextTags = new string[6] { "b", "i", "size", "color", "material", "quad" };

	internal static Verdict Decide(string text, TranslationTable table, bool showOriginal)
	{
		if (string.IsNullOrEmpty(text) || showOriginal || table == null)
		{
			return Verdict.LeaveAlone;
		}
		if (ArabicDirection.ContainsArabic(text))
		{
			return Verdict.LeaveAlone;
		}
		string text2 = table.Find(text);
		if (text2 == null)
		{
			return new Verdict(null, TextObserver.IsWorthTranslating(text));
		}
		return new Verdict(Present(text2), worthAsking: false, text2);
	}

	internal static string Present(string arabic)
	{
		string text = ArabicShaper.Shape(arabic);
		if (!ArabicShaper.ContainsArabic(arabic))
		{
			return text;
		}
		return ArabicVisualOrder.ToVisual(text);
	}

	internal static bool IsTheGamesOwnArabic(string text)
	{
		if (!string.IsNullOrEmpty(text) && ArabicShaper.ContainsArabic(text))
		{
			return !ArabicDirection.AlreadyLaidOut(text);
		}
		return false;
	}

	internal static LaidOut LayOut(string arabic, float width, Func<string, float> widthOf, bool tagsAreMarkup = true, bool marksBeforeLetters = false)
	{
		List<string> list = new List<string>();
		float? num = null;
		string[] array = arabic.Split(new char[1] { '\n' });
		foreach (string text in array)
		{
			string text2 = (text.EndsWith("\r", StringComparison.Ordinal) ? text.Substring(0, text.Length - 1) : text);
			if (width <= 0f || widthOf == null || WidthOf(text2, widthOf, tagsAreMarkup) <= width)
			{
				list.Add(text2);
				continue;
			}
			float valueOrDefault = num.GetValueOrDefault();
			if (!num.HasValue)
			{
				valueOrDefault = Math.Max(0f, widthOf("x x") - widthOf("xx"));
				num = valueOrDefault;
			}
			BreakInto(text2, width, num.Value, widthOf, tagsAreMarkup, list);
		}
		if (tagsAreMarkup)
		{
			CloseTagsOnEveryLine(list);
		}
		string text3 = Present(string.Join("\n", list));
		return new LaidOut(marksBeforeLetters ? ArabicVisualOrder.WithMarksBeforeTheirLetters(text3) : text3, list.Count);
	}

	private static void BreakInto(string paragraph, float width, float space, Func<string, float> widthOf, bool tagsAreMarkup, List<string> lines)
	{
		lines.AddRange(WordsThatStayTogether.Break(paragraph.Split(new char[1] { ' ' }), (IList<string> words) => BreakWords(words, width, space, widthOf, tagsAreMarkup), (string word) => WidthOf(word, widthOf, tagsAreMarkup) <= width));
	}

	private static List<string> BreakWords(IList<string> words, float width, float space, Func<string, float> widthOf, bool tagsAreMarkup)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		float num = 0f;
		foreach (string word in words)
		{
			float num2 = WidthOf(word, widthOf, tagsAreMarkup);
			if (stringBuilder.Length > 0 && num + space + num2 > width)
			{
				list.Add(stringBuilder.ToString());
				stringBuilder.Clear();
				num = 0f;
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(' ');
				num += space;
			}
			stringBuilder.Append(word);
			num += num2;
		}
		list.Add(stringBuilder.ToString());
		if (list.Exists((string candidate) => candidate.IndexOf(' ') >= 0 && WidthOf(candidate, widthOf, tagsAreMarkup) > width))
		{
			list.Clear();
			stringBuilder.Clear();
			foreach (string word2 in words)
			{
				string text = ((stringBuilder.Length == 0) ? word2 : (stringBuilder?.ToString() + " " + word2));
				if (stringBuilder.Length > 0 && WidthOf(text, widthOf, tagsAreMarkup) > width)
				{
					list.Add(stringBuilder.ToString());
					stringBuilder.Clear().Append(word2);
				}
				else
				{
					stringBuilder.Clear().Append(text);
				}
			}
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	private static float WidthOf(string text, Func<string, float> widthOf, bool tagsAreMarkup)
	{
		if (text.Length != 0)
		{
			return widthOf(ArabicShaper.Shape(tagsAreMarkup ? WithoutTags(text) : text));
		}
		return 0f;
	}

	private static int TagAt(string text, int at, out string name, out bool closes)
	{
		name = null;
		closes = false;
		if (text[at] != '<')
		{
			return 0;
		}
		int num = text.IndexOf('>', at + 1);
		if (num < 0)
		{
			return 0;
		}
		string text2 = text.Substring(at + 1, num - at - 1);
		closes = text2.StartsWith("/", StringComparison.Ordinal);
		if (closes)
		{
			text2 = text2.Substring(1);
		}
		int num2 = text2.IndexOf('=');
		string a = ((num2 >= 0) ? text2.Substring(0, num2) : text2).Trim();
		string[] richTextTags = RichTextTags;
		foreach (string text3 in richTextTags)
		{
			if (string.Equals(a, text3, StringComparison.OrdinalIgnoreCase))
			{
				name = text3;
				return num - at + 1;
			}
		}
		return 0;
	}

	internal static string WithoutTags(string text)
	{
		if (text.IndexOf('<') < 0)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		int num = 0;
		while (num < text.Length)
		{
			string name;
			bool closes;
			int num2 = TagAt(text, num, out name, out closes);
			if (num2 > 0)
			{
				num += num2;
				continue;
			}
			stringBuilder.Append(text[num]);
			num++;
		}
		return stringBuilder.ToString();
	}

	private static void CloseTagsOnEveryLine(List<string> lines)
	{
		List<OpenTag> list = new List<OpenTag>();
		for (int i = 0; i < lines.Count; i++)
		{
			string text = lines[i];
			if (list.Count == 0 && text.IndexOf('<') < 0)
			{
				continue;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (OpenTag item in list)
			{
				stringBuilder.Append(item.Raw);
			}
			int num = 0;
			while (num < text.Length)
			{
				string name;
				bool closes;
				int num2 = TagAt(text, num, out name, out closes);
				if (num2 == 0)
				{
					stringBuilder.Append(text[num]);
					num++;
					continue;
				}
				string text2 = text.Substring(num, num2);
				stringBuilder.Append(text2);
				num += num2;
				if (!closes)
				{
					if (name != "quad" && !text2.EndsWith("/>", StringComparison.Ordinal))
					{
						list.Add(new OpenTag(name, text2));
					}
					continue;
				}
				for (int num3 = list.Count - 1; num3 >= 0; num3--)
				{
					if (list[num3].Name == name)
					{
						list.RemoveRange(num3, list.Count - num3);
						break;
					}
				}
			}
			for (int num4 = list.Count - 1; num4 >= 0; num4--)
			{
				stringBuilder.Append("</").Append(list[num4].Name).Append('>');
			}
			lines[i] = stringBuilder.ToString();
		}
	}
}
