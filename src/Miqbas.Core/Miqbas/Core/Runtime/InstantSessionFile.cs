using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Runtime;

public static class InstantSessionFile
{
	public const string FileName = "instant.txt";

	public const string TranslatePath = "/translate";

	public const string TranslateManyPath = "/translate-many";

	public const char BetweenLines = '\u001e';

	public const string TokenHeader = "X-Miqbas-Token";

	public static string Write(int port, string token, int lanes = 1)
	{
		string[] obj = new string[6]
		{
			EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KX(),
			null,
			null,
			null,
			null,
			null
		};
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(6, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kx());
		defaultInterpolatedStringHandler.AppendFormatted<int>(port);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bk());
		obj[1] = defaultInterpolatedStringHandler.ToStringAndClear();
		obj[2] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KY();
		obj[3] = token;
		obj[4] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bk();
		defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ky());
		defaultInterpolatedStringHandler.AppendFormatted<int>(lanes);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bk());
		obj[5] = defaultInterpolatedStringHandler.ToStringAndClear();
		return string.Concat(obj);
	}

	public static ValueTuple<int, string>? Read(string workDirectory)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		string text = Path.Combine(workDirectory, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KZ());
		if (!File.Exists(text))
		{
			return null;
		}
		int? num = null;
		string text2 = null;
		string[] array = File.ReadAllLines(text, Encoding.UTF8);
		int num4 = default(int);
		for (int i = 0; i < array.Length; i++)
		{
			string text3 = array[i].Trim();
			if (text3.Length == 0 || text3[0] == '#')
			{
				continue;
			}
			int num2 = text3.IndexOf('=');
			if (num2 > 0)
			{
				string text4 = text3.Substring(0, num2).Trim();
				string text5 = text3;
				int num3 = num2 + 1;
				string text6 = text5.Substring(num3, text5.Length - num3).Trim();
				if (text4 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kz() && int.TryParse(text6, ref num4))
				{
					num = num4;
				}
				else if (text4 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kA())
				{
					text2 = text6;
				}
			}
		}
		if (!num.HasValue || num.GetValueOrDefault() <= 0 || text2 == null || text2.Length <= 0)
		{
			return null;
		}
		return new ValueTuple<int, string>(num.Value, text2);
	}
}
