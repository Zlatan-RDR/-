using System.Text;

namespace Miqbas.Engines.Unity.Plugin;

internal static class TextEscaping
{
	internal static string Escape(string value)
	{
		StringBuilder stringBuilder = new StringBuilder(value.Length);
		foreach (char c in value)
		{
			switch (c)
			{
			case '\\':
				stringBuilder.Append("\\\\");
				break;
			case '\r':
				stringBuilder.Append("\\r");
				break;
			case '\n':
				stringBuilder.Append("\\n");
				break;
			case '\t':
				stringBuilder.Append("\\t");
				break;
			default:
				stringBuilder.Append(c);
				break;
			}
		}
		return stringBuilder.ToString();
	}

	internal static string Unescape(string value)
	{
		StringBuilder stringBuilder = new StringBuilder(value.Length);
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] != '\\' || i + 1 >= value.Length)
			{
				stringBuilder.Append(value[i]);
				continue;
			}
			i++;
			switch (value[i])
			{
			case '\\':
				stringBuilder.Append('\\');
				break;
			case 'r':
				stringBuilder.Append('\r');
				break;
			case 'n':
				stringBuilder.Append('\n');
				break;
			case 't':
				stringBuilder.Append('\t');
				break;
			default:
				stringBuilder.Append('\\').Append(value[i]);
				break;
			}
		}
		return stringBuilder.ToString();
	}
}
