using System;
using System.Collections.Generic;
using System.Text;

namespace Miqbas.Core.Translation;

public sealed class FilledTemplates
{
	private sealed class Template
	{
		internal string[] SourceParts = Array.Empty<string>();

		internal string[] SourceHoles = Array.Empty<string>();

		internal string[] TargetParts = Array.Empty<string>();

		internal string[] TargetHoles = Array.Empty<string>();

		internal int OwnCharacters;
	}

	private const int LeastOwnCharacters = 4;

	private const int MemoryCeiling = 4096;

	private readonly List<Template> _templates = new List<Template>();

	private readonly Dictionary<string, string> _answered = new Dictionary<string, string>(StringComparer.Ordinal);

	public int Count => _templates.Count;

	public void Learn(string source, string translation)
	{
		if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(translation) || !Split(source, out string[] parts, out string[] holes) || !Split(translation, out string[] parts2, out string[] holes2) || !SameNames(holes, holes2))
		{
			return;
		}
		int num = 0;
		string[] array = parts;
		foreach (string text in array)
		{
			for (int j = 0; j < text.Length; j++)
			{
				if (!char.IsWhiteSpace(text[j]))
				{
					num++;
				}
			}
		}
		if (num >= 4)
		{
			_templates.Add(new Template
			{
				SourceParts = parts,
				SourceHoles = holes,
				TargetParts = parts2,
				TargetHoles = holes2,
				OwnCharacters = num
			});
			Forget();
		}
	}

	public void Forget()
	{
		_answered.Clear();
	}

	public string? Find(string value)
	{
		if (string.IsNullOrEmpty(value) || _templates.Count == 0)
		{
			return null;
		}
		if (_answered.TryGetValue(value, out string value2))
		{
			return value2;
		}
		if (_answered.Count >= 4096)
		{
			Forget();
		}
		string text = Resolve(value);
		_answered[value] = text;
		return text;
	}

	private string? Resolve(string value)
	{
		string text = null;
		int num = -1;
		bool flag = false;
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		foreach (Template template in _templates)
		{
			dictionary.Clear();
			if (TryFill(template, value, dictionary))
			{
				string text2 = Rebuild(template, dictionary);
				if (template.OwnCharacters > num)
				{
					text = text2;
					num = template.OwnCharacters;
					flag = false;
				}
				else if (template.OwnCharacters == num && !string.Equals(text2, text, StringComparison.Ordinal))
				{
					flag = true;
				}
			}
		}
		if (!flag)
		{
			return text;
		}
		return null;
	}

	private static bool TryFill(Template template, string value, Dictionary<string, string> filled)
	{
		string[] sourceParts = template.SourceParts;
		string[] sourceHoles = template.SourceHoles;
		string text = sourceParts[0];
		if (value.Length < text.Length || string.CompareOrdinal(value, 0, text, 0, text.Length) != 0)
		{
			return false;
		}
		int num = text.Length;
		for (int i = 0; i < sourceHoles.Length; i++)
		{
			string text2 = sourceParts[i + 1];
			int num2;
			if (filled.TryGetValue(sourceHoles[i], out string value2))
			{
				if (value.Length - num < value2.Length || string.CompareOrdinal(value, num, value2, 0, value2.Length) != 0)
				{
					return false;
				}
				num2 = num + value2.Length;
			}
			else if (text2.Length > 0)
			{
				num2 = value.IndexOf(text2, num, StringComparison.Ordinal);
				if (num2 < 0)
				{
					return false;
				}
			}
			else if (i == sourceHoles.Length - 1)
			{
				num2 = value.Length;
			}
			else
			{
				if (!filled.TryGetValue(sourceHoles[i + 1], out string value3))
				{
					return false;
				}
				num2 = value.IndexOf(value3, num, StringComparison.Ordinal);
				if (num2 < 0)
				{
					return false;
				}
			}
			string text3 = value.Substring(num, num2 - num);
			if (text3.Length == 0 || text3.IndexOf('\n') >= 0)
			{
				return false;
			}
			filled[sourceHoles[i]] = text3;
			if (value.Length - num2 < text2.Length || string.CompareOrdinal(value, num2, text2, 0, text2.Length) != 0)
			{
				return false;
			}
			num = num2 + text2.Length;
		}
		return num == value.Length;
	}

	private static string Rebuild(Template template, Dictionary<string, string> filled)
	{
		string[] targetParts = template.TargetParts;
		string[] targetHoles = template.TargetHoles;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < targetHoles.Length; i++)
		{
			stringBuilder.Append(targetParts[i]);
			stringBuilder.Append(filled[targetHoles[i]]);
		}
		stringBuilder.Append(targetParts[targetHoles.Length]);
		return stringBuilder.ToString();
	}

	private static bool Split(string text, out string[] parts, out string[] holes)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		int num = 0;
		int num2 = 0;
		while (num2 < text.Length)
		{
			if (text[num2] != '{')
			{
				num2++;
				continue;
			}
			int num3 = text.IndexOf('}', num2 + 1);
			if (num3 < 0)
			{
				break;
			}
			string text2 = text.Substring(num2 + 1, num3 - num2 - 1);
			if (!IsAHoleName(text2))
			{
				num2++;
				continue;
			}
			list.Add(text.Substring(num, num2 - num));
			list2.Add(text2);
			num2 = num3 + 1;
			num = num2;
		}
		list.Add(text.Substring(num));
		parts = list.ToArray();
		holes = list2.ToArray();
		return list2.Count > 0;
	}

	private static bool IsAHoleName(string name)
	{
		if (name.Length == 0)
		{
			return false;
		}
		foreach (char c in name)
		{
			if (char.IsWhiteSpace(c) || c == '{' || c == '}')
			{
				return false;
			}
		}
		return true;
	}

	private static bool SameNames(string[] left, string[] right)
	{
		string[] array = left;
		foreach (string value in array)
		{
			if (Array.IndexOf(right, value) < 0)
			{
				return false;
			}
		}
		array = right;
		foreach (string value2 in array)
		{
			if (Array.IndexOf(left, value2) < 0)
			{
				return false;
			}
		}
		return true;
	}
}
