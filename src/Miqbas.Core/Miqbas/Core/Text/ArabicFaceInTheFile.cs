using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class ArabicFaceInTheFile
{
	[CompilerGenerated]
	private sealed class A
	{
		public FontMetrics font;

		internal GlyphInTheFile A(int P_0)
		{
			return new GlyphInTheFile(P_0, font.OutlineBytesOf(P_0));
		}
	}

	public static System.Collections.Generic.IReadOnlyList<int> WhatMustBeDrawable(System.Collections.Generic.IEnumerable<char> shapesTheShaperEmits)
	{
		ArgumentNullException.ThrowIfNull((object)shapesTheShaperEmits, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hk());
		SortedSet<int> val = new SortedSet<int>();
		System.Collections.Generic.IEnumerator<char> enumerator = shapesTheShaperEmits.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				char current = enumerator.Current;
				val.Add((int)current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		for (int i = 1611; i <= 1619; i++)
		{
			val.Add(i);
		}
		val.Add(1648);
		val.Add(1548);
		val.Add(1563);
		val.Add(1567);
		for (int j = 1642; j <= 1645; j++)
		{
			val.Add(j);
		}
		for (int k = 1632; k <= 1641; k++)
		{
			val.Add(k);
		}
		for (int l = 32; l <= 126; l++)
		{
			val.Add(l);
		}
		val.Remove(32);
		val.Remove(160);
		val.Remove(8204);
		val.Remove(8205);
		return (System.Collections.Generic.IReadOnlyList<int>)Enumerable.ToList<int>((System.Collections.Generic.IEnumerable<int>)val);
	}

	public static string? WhyTheseNumbersCannotDraw(float fontSize, float pixelScale)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (pixelScale <= 0f)
		{
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(70, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HL());
			defaultInterpolatedStringHandler.AppendFormatted<float>(pixelScale);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hl());
			return defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HM();
		}
		if (!(fontSize <= 0f))
		{
			return null;
		}
		defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(87, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hm());
		defaultInterpolatedStringHandler.AppendFormatted<float>(fontSize);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HN());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static FaceVerification VerifyASourceFont(FontMetrics font, System.Collections.Generic.IReadOnlyCollection<int> mustBeDrawable)
	{
		FontMetrics font2 = font;
		ArgumentNullException.ThrowIfNull((object)font2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.b());
		ArgumentNullException.ThrowIfNull((object)mustBeDrawable, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hn());
		if (!font2.OutlinesAreReadable)
		{
			return new FaceVerification
			{
				Verified = false,
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HO(),
				Wanted = mustBeDrawable.Count,
				Missing = System.Array.Empty<int>(),
				Blank = System.Array.Empty<int>()
			};
		}
		FontMetrics fontMetrics = font2;
		return Verify((System.Collections.Generic.IReadOnlyCollection<GlyphInTheFile>)Enumerable.ToList<GlyphInTheFile>(Enumerable.Select<int, GlyphInTheFile>(Enumerable.Where<int>((System.Collections.Generic.IEnumerable<int>)mustBeDrawable, (Func<int, bool>)fontMetrics.Has), (Func<int, GlyphInTheFile>)((int P_0) => new GlyphInTheFile(P_0, font2.OutlineBytesOf(P_0))))), mustBeDrawable);
	}

	public static FaceVerification Verify(System.Collections.Generic.IReadOnlyCollection<GlyphInTheFile> table, System.Collections.Generic.IReadOnlyCollection<int> mustBeDrawable)
	{
		ArgumentNullException.ThrowIfNull((object)table, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ho());
		ArgumentNullException.ThrowIfNull((object)mustBeDrawable, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hn());
		Dictionary<int, int> val = new Dictionary<int, int>();
		System.Collections.Generic.IEnumerator<GlyphInTheFile> enumerator = ((System.Collections.Generic.IEnumerable<GlyphInTheFile>)table).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlyphInTheFile current = enumerator.Current;
				val[current.Codepoint] = current.InkPixels;
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		List<int> val2 = new List<int>();
		List<int> val3 = new List<int>();
		System.Collections.Generic.IEnumerator<int> enumerator2 = ((System.Collections.Generic.IEnumerable<int>)mustBeDrawable).GetEnumerator();
		try
		{
			int num = default(int);
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				int current2 = enumerator2.Current;
				if (!val.TryGetValue(current2, ref num))
				{
					val2.Add(current2);
				}
				else if (num <= 0)
				{
					val3.Add(current2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
		if (mustBeDrawable.Count == 0)
		{
			return new FaceVerification
			{
				Verified = false,
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HP(),
				Wanted = 0,
				Missing = System.Array.Empty<int>(),
				Blank = System.Array.Empty<int>()
			};
		}
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (val2.Count == 0 && val3.Count == 0)
		{
			FaceVerification obj = new FaceVerification
			{
				Verified = true
			};
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(61, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hp());
			defaultInterpolatedStringHandler.AppendFormatted<int>(mustBeDrawable.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HQ());
			obj.Because = defaultInterpolatedStringHandler.ToStringAndClear();
			obj.Wanted = mustBeDrawable.Count;
			obj.Missing = System.Array.Empty<int>();
			obj.Blank = System.Array.Empty<int>();
			return obj;
		}
		List<string> val4 = new List<string>();
		if (val2.Count > 0)
		{
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(30, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(val2.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hq());
			defaultInterpolatedStringHandler.AppendFormatted(FaceVerification.Name((System.Collections.Generic.IReadOnlyList<int>)val2));
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			val4.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (val3.Count > 0)
		{
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(31, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(val3.Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HR());
			defaultInterpolatedStringHandler.AppendFormatted(FaceVerification.Name((System.Collections.Generic.IReadOnlyList<int>)val3));
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			val4.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		FaceVerification obj2 = new FaceVerification
		{
			Verified = false
		};
		defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hr());
		defaultInterpolatedStringHandler.AppendFormatted<int>(mustBeDrawable.Count);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HS());
		obj2.Because = defaultInterpolatedStringHandler.ToStringAndClear() + string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hs(), (System.Collections.Generic.IEnumerable<string>)val4);
		obj2.Wanted = mustBeDrawable.Count;
		obj2.Missing = (System.Collections.Generic.IReadOnlyList<int>)val2;
		obj2.Blank = (System.Collections.Generic.IReadOnlyList<int>)val3;
		return obj2;
	}
}
