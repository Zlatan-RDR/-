namespace Miqbas.Rendering.Arabic;

public static class WorthTranslating
{
	public static bool TheLine(string? line)
	{
		if (string.IsNullOrWhiteSpace(line))
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		foreach (char c in line)
		{
			if (char.IsLetter(c))
			{
				num++;
			}
			else if (char.IsDigit(c))
			{
				num2++;
			}
		}
		if (num == 0)
		{
			return false;
		}
		return num2 <= num;
	}
}
