using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B78C53E54_002D85C4_002D4BB2_002DB75C_002D1FE345444E71_007D;

namespace Miqbas.Rendering.Arabic.Faces;

public sealed class ABakedFaceTable
{
	public const string FirstLine = "miqbas-baked-face 1";

	public float PointSize;

	public int Padding;

	public int Width;

	public int Height;

	public float LineHeight;

	public float Ascent;

	public float Descent;

	public List<ABakedLetter> Letters = new List<ABakedLetter>();

	public string Write()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder();
		val.Append(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aj()).Append('\n');
		val.Append(string.Join(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aB(), new string[7]
		{
			A(PointSize),
			Padding.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
			Width.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
			Height.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
			A(LineHeight),
			A(Ascent),
			A(Descent)
		})).Append('\n');
		Enumerator<ABakedLetter> enumerator = Letters.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ABakedLetter current = enumerator.Current;
				val.Append(string.Join(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aB(), new string[8]
				{
					current.Unicode.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
					current.X.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
					current.Y.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
					current.W.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
					current.H.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture),
					A(current.BearingX),
					A(current.BearingY),
					A(current.Advance)
				})).Append('\n');
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		return ((object)val).ToString();
	}

	public static ABakedFaceTable Read(string text)
	{
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		string[] array = text.Replace(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aA(), _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aa()).Split('\n', (StringSplitOptions)0);
		if (array.Length >= 3 && !(array[0] != _35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aj()))
		{
			string[] array2 = A(array[1], 7);
			if (array2 != null)
			{
				ABakedFaceTable aBakedFaceTable = new ABakedFaceTable();
				if (!A(array2[0], out aBakedFaceTable.PointSize) || !A(array2[1], out aBakedFaceTable.Padding) || !A(array2[2], out aBakedFaceTable.Width) || !A(array2[3], out aBakedFaceTable.Height) || !A(array2[4], out aBakedFaceTable.LineHeight) || !A(array2[5], out aBakedFaceTable.Ascent) || !A(array2[6], out aBakedFaceTable.Descent) || aBakedFaceTable.PointSize <= 0f || aBakedFaceTable.Width <= 0 || aBakedFaceTable.Height <= 0)
				{
					return null;
				}
				for (int i = 2; i < array.Length; i++)
				{
					if (array[i].Length != 0)
					{
						string[] array3 = A(array[i], 8);
						if (array3 == null)
						{
							return null;
						}
						ABakedLetter aBakedLetter = default(ABakedLetter);
						if (!A(array3[0], out aBakedLetter.Unicode) || !A(array3[1], out aBakedLetter.X) || !A(array3[2], out aBakedLetter.Y) || !A(array3[3], out aBakedLetter.W) || !A(array3[4], out aBakedLetter.H) || !A(array3[5], out aBakedLetter.BearingX) || !A(array3[6], out aBakedLetter.BearingY) || !A(array3[7], out aBakedLetter.Advance) || aBakedLetter.X < 0 || aBakedLetter.Y < 0 || aBakedLetter.W < 0 || aBakedLetter.H < 0 || aBakedLetter.X + aBakedLetter.W > aBakedFaceTable.Width || aBakedLetter.Y + aBakedLetter.H > aBakedFaceTable.Height)
						{
							return null;
						}
						aBakedFaceTable.Letters.Add(aBakedLetter);
					}
				}
				if (aBakedFaceTable.Letters.Count != 0)
				{
					return aBakedFaceTable;
				}
				return null;
			}
		}
		return null;
	}

	private static string[] A(string P_0, int P_1)
	{
		string[] array = P_0.Split(' ', (StringSplitOptions)0);
		if (array.Length != P_1)
		{
			return null;
		}
		return array;
	}

	private static bool A(string P_0, out int P_1)
	{
		return int.TryParse(P_0, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref P_1);
	}

	private static bool A(string P_0, out float P_1)
	{
		return float.TryParse(P_0, (NumberStyles)167, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref P_1);
	}

	private static string A(float P_0)
	{
		return P_0.ToString(_35B1EC98_002D2326_002D45B9_002D8AD2_002D9CA0549E886F.aK(), (IFormatProvider)(object)CultureInfo.InvariantCulture);
	}
}
