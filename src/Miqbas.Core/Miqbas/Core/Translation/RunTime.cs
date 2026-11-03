using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class RunTime
{
	public static TimeSpan? For(int billableLines, int requests, TimeSpan? pacePerRequest, double? measuredTextsPerMinute)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (billableLines <= 0 || requests <= 0)
		{
			return TimeSpan.Zero;
		}
		TimeSpan? obj;
		if (pacePerRequest.HasValue)
		{
			TimeSpan valueOrDefault = pacePerRequest.GetValueOrDefault();
			obj = valueOrDefault * (double)requests;
		}
		else
		{
			obj = null;
		}
		TimeSpan? val = obj;
		TimeSpan? result = ((measuredTextsPerMinute.HasValue && measuredTextsPerMinute.GetValueOrDefault() > 0.0) ? new TimeSpan?(TimeSpan.FromMinutes((double)billableLines / measuredTextsPerMinute.Value)) : null);
		if (val.HasValue)
		{
			TimeSpan valueOrDefault2 = val.GetValueOrDefault();
			if (result.HasValue)
			{
				TimeSpan valueOrDefault3 = result.GetValueOrDefault();
				return (valueOrDefault2 > valueOrDefault3) ? valueOrDefault2 : valueOrDefault3;
			}
			return valueOrDefault2;
		}
		return result;
	}

	public static string Describe(TimeSpan? estimate, bool carriesOverToTomorrow = false, bool mayBeMuchLess = false)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (estimate.HasValue)
		{
			TimeSpan valueOrDefault = estimate.GetValueOrDefault();
			if (carriesOverToTomorrow)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eQ();
			}
			double totalMinutes = ((TimeSpan)(ref valueOrDefault)).TotalMinutes;
			string text;
			if (!(totalMinutes < 1.0))
			{
				if (!(totalMinutes < 2.0))
				{
					if (!(totalMinutes < 60.0))
					{
						if (!(totalMinutes < 120.0))
						{
							if (totalMinutes < 1440.0)
							{
								System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(10, 1);
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ch());
								defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling(((TimeSpan)(ref valueOrDefault)).TotalHours));
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CJ());
								text = defaultInterpolatedStringHandler.ToStringAndClear();
							}
							else
							{
								System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(9, 1);
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ch());
								defaultInterpolatedStringHandler.AppendFormatted<int>((int)Math.Ceiling(((TimeSpan)(ref valueOrDefault)).TotalDays));
								defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eq());
								text = defaultInterpolatedStringHandler.ToStringAndClear();
							}
						}
						else
						{
							text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ci();
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
			if (((TimeSpan)(ref valueOrDefault)).TotalMinutes < 2.0)
			{
				return text2;
			}
			if (!mayBeMuchLess)
			{
				return text2 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eR();
			}
			return text2 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.er();
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
	}
}
