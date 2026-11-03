using System;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Text;

public static class APageForAWholeAlphabet
{
	private static readonly int[] Pages;

	private const double TallestLetterAgainstPointSize = 1.35;

	private const double RoomToSpare = 1.5;

	public static int ACellFor(float pointSize, int padding, float lineHeight = 0f)
	{
		double num = ((lineHeight > 0f) ? ((double)lineHeight) : ((double)pointSize * 1.35));
		return (int)Math.Ceiling(Math.Max(1.0, num)) + 2 * Math.Max(0, padding);
	}

	public static int LettersThatFitIn(int page, float pointSize, int padding, float lineHeight = 0f)
	{
		int num = page / ACellFor(pointSize, padding, lineHeight);
		if (num > 0)
		{
			return num * num;
		}
		return 0;
	}

	public static int Holding(int letters, float pointSize, int padding, float lineHeight = 0f)
	{
		int num = (int)Math.Ceiling((double)letters * 1.5);
		int[] pages = Pages;
		foreach (int num2 in pages)
		{
			if (LettersThatFitIn(num2, pointSize, padding, lineHeight) >= num)
			{
				return num2;
			}
		}
		int[] pages2 = Pages;
		return pages2[pages2.Length - 1];
	}

	static APageForAWholeAlphabet()
	{
		int[] array = new int[4];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		Pages = array;
	}
}
