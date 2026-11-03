using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using Miqbas.Core.Text;
using Miqbas.Rendering.Arabic.Faces;

namespace Miqbas.Engines.Unity.Hooking;

public static class TheFaceForTheGamesOwnTextMeshPro
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ABakedGlyph, int> _003C_003E9__7_0;

		public static Func<IGrouping<int, ABakedGlyph>, int> _003C_003E9__7_1;

		public static Func<IGrouping<int, ABakedGlyph>, ABakedGlyph> _003C_003E9__7_2;

		internal int A(ABakedGlyph P_0)
		{
			return P_0.Index;
		}

		internal int A(IGrouping<int, ABakedGlyph> P_0)
		{
			return P_0.Key;
		}

		internal ABakedGlyph a(IGrouping<int, ABakedGlyph> P_0)
		{
			return Enumerable.First<ABakedGlyph>((System.Collections.Generic.IEnumerable<ABakedGlyph>)P_0);
		}
	}

	public const string PageFile = "font.atlas.bin";

	public const string TableFile = "font.atlas.txt";

	private static readonly byte[] TheOldCopy = Encoding.ASCII.GetBytes(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aF());

	private static readonly byte[] AFontAsset = Encoding.ASCII.GetBytes(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.af());

	private static readonly byte[] ReadsAPage = Encoding.ASCII.GetBytes(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aG());

	private static readonly byte[] MakesAFace = Encoding.ASCII.GetBytes(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ag());

	public static bool IsCarriedBy(string gameRoot)
	{
		ArgumentNullException.ThrowIfNull((object)gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aA());
		try
		{
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateDirectories(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.k()).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string text = Path.Combine(enumerator.Current, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aa());
					if (!Directory.Exists(text))
					{
						continue;
					}
					System.Collections.Generic.IEnumerator<string> enumerator2 = Directory.EnumerateFiles(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aB()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							string current = enumerator2.Current;
							string fileName = Path.GetFileName(current);
							if (fileName == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ab() || fileName.StartsWith(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aC(), (StringComparison)5) || fileName.StartsWith(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ac(), (StringComparison)5))
							{
								System.Span<byte> span = MemoryExtensions.AsSpan<byte>(File.ReadAllBytes(current));
								if (MemoryExtensions.IndexOf<byte>(span, System.ReadOnlySpan<byte>.op_Implicit(TheOldCopy)) >= 0 || (MemoryExtensions.IndexOf<byte>(span, System.ReadOnlySpan<byte>.op_Implicit(AFontAsset)) >= 0 && MemoryExtensions.IndexOf<byte>(span, System.ReadOnlySpan<byte>.op_Implicit(ReadsAPage)) >= 0 && MemoryExtensions.IndexOf<byte>(span, System.ReadOnlySpan<byte>.op_Implicit(MakesAFace)) < 0))
								{
									return true;
								}
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
		}
		return false;
	}

	public static bool WriteInto(string workDirectory, string fontPath)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)workDirectory, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aD());
		ArgumentNullException.ThrowIfNull((object)fontPath, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ad());
		ValueTuple<TheBakedFaceRecord, byte[]>? val = TheBakedArabicFace.Beside(fontPath);
		if (val.HasValue)
		{
			ValueTuple<TheBakedFaceRecord, byte[]> valueOrDefault = val.GetValueOrDefault();
			ABakedFaceTable aBakedFaceTable = new ABakedFaceTable
			{
				PointSize = valueOrDefault.Item1.PointSize,
				Padding = valueOrDefault.Item1.Padding,
				Width = valueOrDefault.Item1.AtlasWidth,
				Height = valueOrDefault.Item1.AtlasHeight,
				LineHeight = valueOrDefault.Item1.LineHeight,
				Ascent = valueOrDefault.Item1.AscentLine,
				Descent = valueOrDefault.Item1.DescentLine
			};
			Dictionary<int, ABakedGlyph> val2 = Enumerable.ToDictionary<IGrouping<int, ABakedGlyph>, int, ABakedGlyph>(Enumerable.GroupBy<ABakedGlyph, int>((System.Collections.Generic.IEnumerable<ABakedGlyph>)valueOrDefault.Item1.Glyphs, (Func<ABakedGlyph, int>)((ABakedGlyph P_0) => P_0.Index)), (Func<IGrouping<int, ABakedGlyph>, int>)((IGrouping<int, ABakedGlyph> P_0) => P_0.Key), (Func<IGrouping<int, ABakedGlyph>, ABakedGlyph>)((IGrouping<int, ABakedGlyph> P_0) => Enumerable.First<ABakedGlyph>((System.Collections.Generic.IEnumerable<ABakedGlyph>)P_0)));
			System.Collections.Generic.IEnumerator<ABakedCharacter> enumerator = ((System.Collections.Generic.IEnumerable<ABakedCharacter>)valueOrDefault.Item1.Characters).GetEnumerator();
			try
			{
				ABakedGlyph aBakedGlyph = default(ABakedGlyph);
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ABakedCharacter current = enumerator.Current;
					if (val2.TryGetValue(current.GlyphIndex, ref aBakedGlyph))
					{
						aBakedFaceTable.Letters.Add(new ABakedLetter
						{
							Unicode = current.Unicode,
							X = aBakedGlyph.X,
							Y = aBakedGlyph.Y,
							W = aBakedGlyph.W,
							H = aBakedGlyph.H,
							BearingX = aBakedGlyph.BearingX,
							BearingY = aBakedGlyph.BearingY,
							Advance = aBakedGlyph.Advance
						});
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			Directory.CreateDirectory(workDirectory);
			File.WriteAllBytes(Path.Combine(workDirectory, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aE()), valueOrDefault.Item2);
			File.WriteAllText(Path.Combine(workDirectory, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ae()), aBakedFaceTable.Write(), (Encoding)new UTF8Encoding(false));
			return true;
		}
		return false;
	}
}
