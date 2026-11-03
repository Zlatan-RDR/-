using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal static class TheShapeOfALine
{
	internal static string Of(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		bool flag = false;
		string text = value;
		for (int i = 0; i < text.Length; i++)
		{
			if (char.IsDigit(text[i]))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return value;
		}
		StringBuilder stringBuilder = new StringBuilder(value.Length);
		bool flag2 = false;
		text = value;
		foreach (char c in text)
		{
			if (char.IsDigit(c))
			{
				if (!flag2)
				{
					stringBuilder.Append('#');
					flag2 = true;
				}
			}
			else
			{
				flag2 = false;
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}
}
