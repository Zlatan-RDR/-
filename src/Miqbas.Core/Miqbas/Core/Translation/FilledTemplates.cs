using System;
using System.Collections.Generic;
using System.Text;

namespace Miqbas.Core.Translation;

public sealed class FilledTemplates
{
	private sealed class A
	{
		internal string[] SourceParts = System.Array.Empty<string>();

		internal string[] SourceHoles = System.Array.Empty<string>();

		internal string[] TargetParts = System.Array.Empty<string>();

		internal string[] TargetHoles = System.Array.Empty<string>();

		internal int OwnCharacters;
	}

	private const int LeastOwnCharacters = 4;

	private const int MemoryCeiling = 4096;

	private readonly List<A> _templates = new List<A>();

	private readonly Dictionary<string, string> _answered = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);

	public int Count => _templates.Count;

	public void Learn(string source, string translation)
	{
		if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(translation) || !A(source, out string[] array, out string[] array2) || !A(translation, out string[] targetParts, out string[] array3) || !A(array2, array3))
		{
			return;
		}
		int num = 0;
		string[] array4 = array;
		foreach (string text in array4)
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
			_templates.Add(new A
			{
				SourceParts = array,
				SourceHoles = array2,
				TargetParts = targetParts,
				TargetHoles = array3,
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
		string result = default(string);
		if (_answered.TryGetValue(value, ref result))
		{
			return result;
		}
		if (_answered.Count >= 4096)
		{
			Forget();
		}
		string text = A(value);
		_answered[value] = text;
		return text;
	}

	private string? A(string P_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		int num = -1;
		bool flag = false;
		Dictionary<string, string> val = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Enumerator<A> enumerator = _templates.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				val.Clear();
				if (A(current, P_0, val))
				{
					string text2 = A(current, val);
					if (current.OwnCharacters > num)
					{
						text = text2;
						num = current.OwnCharacters;
						flag = false;
					}
					else if (current.OwnCharacters == num && !string.Equals(text2, text, (StringComparison)4))
					{
						flag = true;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (!flag)
		{
			return text;
		}
		return null;
	}

	private static bool A(A P_0, string P_1, Dictionary<string, string> P_2)
	{
		string[] sourceParts = P_0.SourceParts;
		string[] sourceHoles = P_0.SourceHoles;
		string text = sourceParts[0];
		if (P_1.Length < text.Length || string.CompareOrdinal(P_1, 0, text, 0, text.Length) != 0)
		{
			return false;
		}
		int num = text.Length;
		string text3 = default(string);
		string text4 = default(string);
		for (int i = 0; i < sourceHoles.Length; i++)
		{
			string text2 = sourceParts[i + 1];
			int num2;
			if (P_2.TryGetValue(sourceHoles[i], ref text3))
			{
				if (P_1.Length - num < text3.Length || string.CompareOrdinal(P_1, num, text3, 0, text3.Length) != 0)
				{
					return false;
				}
				num2 = num + text3.Length;
			}
			else if (text2.Length > 0)
			{
				num2 = P_1.IndexOf(text2, num, (StringComparison)4);
				if (num2 < 0)
				{
					return false;
				}
			}
			else if (i == sourceHoles.Length - 1)
			{
				num2 = P_1.Length;
			}
			else
			{
				if (!P_2.TryGetValue(sourceHoles[i + 1], ref text4))
				{
					return false;
				}
				num2 = P_1.IndexOf(text4, num, (StringComparison)4);
				if (num2 < 0)
				{
					return false;
				}
			}
			string text5 = P_1.Substring(num, num2 - num);
			if (text5.Length == 0 || text5.IndexOf('\n') >= 0)
			{
				return false;
			}
			P_2[sourceHoles[i]] = text5;
			if (P_1.Length - num2 < text2.Length || string.CompareOrdinal(P_1, num2, text2, 0, text2.Length) != 0)
			{
				return false;
			}
			num = num2 + text2.Length;
		}
		return num == P_1.Length;
	}

	private static string A(A P_0, Dictionary<string, string> P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		string[] targetParts = P_0.TargetParts;
		string[] targetHoles = P_0.TargetHoles;
		StringBuilder val = new StringBuilder();
		for (int i = 0; i < targetHoles.Length; i++)
		{
			val.Append(targetParts[i]);
			val.Append(P_1[targetHoles[i]]);
		}
		val.Append(targetParts[targetHoles.Length]);
		return ((object)val).ToString();
	}

	private static bool A(string P_0, out string[] P_1, out string[] P_2)
	{
		List<string> val = new List<string>();
		List<string> val2 = new List<string>();
		int num = 0;
		int num2 = 0;
		while (num2 < P_0.Length)
		{
			if (P_0[num2] != '{')
			{
				num2++;
				continue;
			}
			int num3 = P_0.IndexOf('}', num2 + 1);
			if (num3 < 0)
			{
				break;
			}
			string text = P_0.Substring(num2 + 1, num3 - num2 - 1);
			if (!a(text))
			{
				num2++;
				continue;
			}
			val.Add(P_0.Substring(num, num2 - num));
			val2.Add(text);
			num2 = num3 + 1;
			num = num2;
		}
		val.Add(P_0.Substring(num));
		P_1 = val.ToArray();
		P_2 = val2.ToArray();
		return val2.Count > 0;
	}

	private static bool a(string P_0)
	{
		if (P_0.Length == 0)
		{
			return false;
		}
		foreach (char c in P_0)
		{
			if (char.IsWhiteSpace(c) || c == '{' || c == '}')
			{
				return false;
			}
		}
		return true;
	}

	private static bool A(string[] P_0, string[] P_1)
	{
		string[] array = P_0;
		foreach (string text in array)
		{
			if (System.Array.IndexOf<string>(P_1, text) < 0)
			{
				return false;
			}
		}
		array = P_1;
		foreach (string text2 in array)
		{
			if (System.Array.IndexOf<string>(P_0, text2) < 0)
			{
				return false;
			}
		}
		return true;
	}
}
