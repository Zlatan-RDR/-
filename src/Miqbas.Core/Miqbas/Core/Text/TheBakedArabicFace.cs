using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Text;

public static class TheBakedArabicFace
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ABakedCharacter, int> _003C_003E9__4_0;

		public static Func<ABakedCharacter, int> _003C_003E9__5_0;

		public static Func<ABakedCharacter, int> _003C_003E9__5_1;

		public static Func<ABakedGlyph, int> _003C_003E9__5_2;

		internal int A(ABakedCharacter P_0)
		{
			return P_0.Unicode;
		}

		internal int a(ABakedCharacter P_0)
		{
			return P_0.Unicode;
		}

		internal int B(ABakedCharacter P_0)
		{
			return P_0.GlyphIndex;
		}

		internal int A(ABakedGlyph P_0)
		{
			return P_0.Index;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public HashSet<int> carried;

		internal bool A(int P_0)
		{
			return !carried.Contains(P_0);
		}
	}

	public static string TableBeside(string faceFilePath)
	{
		return Path.ChangeExtension(faceFilePath, (string)null) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iQ();
	}

	public static string PictureBeside(string faceFilePath)
	{
		return Path.ChangeExtension(faceFilePath, (string)null) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iq();
	}

	public static bool ShipsOneBeside(string faceFilePath)
	{
		if (File.Exists(TableBeside(faceFilePath)))
		{
			return File.Exists(PictureBeside(faceFilePath));
		}
		return false;
	}

	public static ValueTuple<TheBakedFaceRecord, byte[]>? Beside(string faceFilePath)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)faceFilePath, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iR());
		if (!ShipsOneBeside(faceFilePath))
		{
			return null;
		}
		try
		{
			TheBakedFaceRecord theBakedFaceRecord = JsonSerializer.Deserialize(File.ReadAllText(TableBeside(faceFilePath)), g.Default.TheBakedFaceRecord);
			if ((object)theBakedFaceRecord == null || ((System.Collections.Generic.IReadOnlyCollection<ABakedGlyph>)theBakedFaceRecord.Glyphs).Count == 0 || ((System.Collections.Generic.IReadOnlyCollection<ABakedCharacter>)theBakedFaceRecord.Characters).Count == 0)
			{
				return null;
			}
			byte[] array = File.ReadAllBytes(PictureBeside(faceFilePath));
			return (array.Length == theBakedFaceRecord.AtlasWidth * theBakedFaceRecord.AtlasHeight) ? new ValueTuple<TheBakedFaceRecord, byte[]>?(new ValueTuple<TheBakedFaceRecord, byte[]>(theBakedFaceRecord, array)) : null;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is JsonException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return null;
		}
	}

	public static System.Collections.Generic.IReadOnlyList<int> WhatItDoesNotCarry(TheBakedFaceRecord face, System.Collections.Generic.IEnumerable<int> mustBeDrawable)
	{
		ArgumentNullException.ThrowIfNull((object)face, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ir());
		ArgumentNullException.ThrowIfNull((object)mustBeDrawable, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hn());
		HashSet<int> carried = Enumerable.ToHashSet<int>(Enumerable.Select<ABakedCharacter, int>((System.Collections.Generic.IEnumerable<ABakedCharacter>)face.Characters, (Func<ABakedCharacter, int>)((ABakedCharacter P_0) => P_0.Unicode)));
		return (System.Collections.Generic.IReadOnlyList<int>)Enumerable.ToList<int>(Enumerable.Where<int>(mustBeDrawable, (Func<int, bool>)((int P_0) => !carried.Contains(P_0))));
	}

	public static System.Collections.Generic.IReadOnlyList<int> WhatItDrawsNothingFor(TheBakedFaceRecord face, System.Collections.Generic.IEnumerable<int> mustBeDrawable)
	{
		ArgumentNullException.ThrowIfNull((object)face, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ir());
		ArgumentNullException.ThrowIfNull((object)mustBeDrawable, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hn());
		Dictionary<int, int> val = Enumerable.ToDictionary<ABakedCharacter, int, int>((System.Collections.Generic.IEnumerable<ABakedCharacter>)face.Characters, (Func<ABakedCharacter, int>)((ABakedCharacter P_0) => P_0.Unicode), (Func<ABakedCharacter, int>)((ABakedCharacter P_0) => P_0.GlyphIndex));
		Dictionary<int, ABakedGlyph> val2 = Enumerable.ToDictionary<ABakedGlyph, int>((System.Collections.Generic.IEnumerable<ABakedGlyph>)face.Glyphs, (Func<ABakedGlyph, int>)((ABakedGlyph P_0) => P_0.Index));
		List<int> val3 = new List<int>();
		System.Collections.Generic.IEnumerator<int> enumerator = mustBeDrawable.GetEnumerator();
		try
		{
			int num = default(int);
			ABakedGlyph aBakedGlyph = default(ABakedGlyph);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				int current = enumerator.Current;
				if (val.TryGetValue(current, ref num) && val2.TryGetValue(num, ref aBakedGlyph) && (aBakedGlyph.W <= 0 || aBakedGlyph.H <= 0))
				{
					val3.Add(current);
				}
			}
			return (System.Collections.Generic.IReadOnlyList<int>)val3;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
