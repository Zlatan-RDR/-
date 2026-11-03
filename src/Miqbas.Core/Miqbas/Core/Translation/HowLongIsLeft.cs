using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class HowLongIsLeft
{
	public static readonly TimeSpan LongEnoughToJudge = TimeSpan.FromSeconds(30.0);

	private const double EnoughOfTheWork = 0.05;

	public static string Describe(TimeSpan elapsed, int completed, int total)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		TimeSpan? val = Estimate(elapsed, completed, total);
		if (val.HasValue)
		{
			TimeSpan valueOrDefault = val.GetValueOrDefault();
			double totalMinutes = ((TimeSpan)(ref valueOrDefault)).TotalMinutes;
			string text;
			if (!(totalMinutes < 1.0))
			{
				if (!(totalMinutes < 2.0))
				{
					if (!(totalMinutes < 60.0))
					{
						if (totalMinutes < 120.0)
						{
							text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ci();
						}
						else
						{
							System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(10, 1);
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ch());
							defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling(((TimeSpan)(ref valueOrDefault)).TotalHours));
							defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CJ());
							text = defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
					else
					{
						System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(10, 1);
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ch());
						defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling(((TimeSpan)(ref valueOrDefault)).TotalMinutes));
						defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CI());
						text = defaultInterpolatedStringHandler.ToStringAndClear();
					}
				}
				else
				{
					text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CH();
				}
			}
			else
			{
				text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cg();
			}
			string text2 = text;
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cj() + text2 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CK();
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
	}

	public static TimeSpan? Estimate(TimeSpan elapsed, int completed, int total)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (total <= 0 || completed <= 0 || completed >= total)
		{
			return null;
		}
		if (elapsed < LongEnoughToJudge || (double)completed < (double)total * 0.05)
		{
			return null;
		}
		if (elapsed <= TimeSpan.Zero)
		{
			return null;
		}
		return TimeSpan.FromSeconds(((TimeSpan)(ref elapsed)).TotalSeconds / (double)completed * (double)(total - completed));
	}
}
