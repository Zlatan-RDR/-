using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Localization;

public static class TooLittleForItsSize
{
	internal const double AtLeastPerGigabyte = 5.0;

	internal const long BigEnoughToJudge = 1073741824L;

	public const string Sentence = "ما وصل مقباس لكلام هذي اللعبة — قرأ منها {0} بس، وهي لعبة كبيرة، فتعريبها من ملفاتها ما راح يغطيها. جر\u0651ب «عر\u0651بها وأنت تلعب».";

	public static bool Is(int textsRead, long dataBytes)
	{
		if (dataBytes >= 1073741824)
		{
			return (double)textsRead < 5.0 * (double)dataBytes / 1073741824.0;
		}
		return false;
	}

	public static string? WhatToTell(string gameRoot, int textsRead)
	{
		if (textsRead > 0)
		{
			return WhatToTell(textsRead, DataBytesOf(gameRoot));
		}
		return null;
	}

	public static string? WhatToTell(int textsRead, long? dataBytes)
	{
		if (textsRead > 0 && dataBytes.HasValue)
		{
			long valueOrDefault = dataBytes.GetValueOrDefault();
			if (Is(textsRead, valueOrDefault))
			{
				return string.Format((IFormatProvider)(object)CultureInfo.InvariantCulture, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.v(), (object)A(textsRead));
			}
		}
		return null;
	}

	internal static string A(int P_0)
	{
		switch (P_0)
		{
		case 1:
			return _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.W();
		case 2:
			return _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.w();
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		{
			IFormatProvider invariantCulture = (IFormatProvider)(object)CultureInfo.InvariantCulture;
			IFormatProvider obj2 = invariantCulture;
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 1, invariantCulture);
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.X());
			return string.Create(obj2, ref defaultInterpolatedStringHandler);
		}
		default:
		{
			IFormatProvider invariantCulture = (IFormatProvider)(object)CultureInfo.InvariantCulture;
			IFormatProvider obj = invariantCulture;
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(3, 1, invariantCulture);
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.x());
			return string.Create(obj, ref defaultInterpolatedStringHandler);
		}
		}
	}

	public static long? DataBytesOf(string gameRoot)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(gameRoot) || !Directory.Exists(gameRoot))
		{
			return null;
		}
		try
		{
			string text = Enumerable.FirstOrDefault<string>((System.Collections.Generic.IEnumerable<string>)UnityDataFolders.InOrder(gameRoot));
			if (text == null)
			{
				return null;
			}
			long num = 0L;
			System.Collections.Generic.IEnumerator<FileInfo> enumerator = new DirectoryInfo(text).EnumerateFiles(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					FileInfo current = enumerator.Current;
					num += current.Length;
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return num;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return null;
		}
	}
}
