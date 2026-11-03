namespace Miqbas.Core.Text;

public static class ArabicPresentationForms
{
	public static bool AreIn(string? text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		foreach (char c in text)
		{
			if ((c >= 'ﭐ' && c <= '﷿') || (c >= 'ﹰ' && c <= '\ufefe'))
			{
				return true;
			}
		}
		return false;
	}
}
