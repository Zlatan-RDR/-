using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.MeshText;

public static class LetterPackage
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<LegacyProperty, bool> _003C_003E9__6_0;

		internal bool A(LegacyProperty P_0)
		{
			return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HR();
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public LegacyPackage template;

		internal bool A(LegacyExport P_0)
		{
			return template.ClassOf(P_0) == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hr();
		}
	}

	public static byte[] Write(LegacyPackage template, LetterModel model, int number)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		LegacyPackage template2 = template;
		ArgumentNullException.ThrowIfNull((object)template2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DA());
		ArgumentNullException.ThrowIfNull((object)model, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Da());
		if (((global::System.Collections.Generic.IReadOnlyCollection<LetterVertex>)model.Vertices).Count >= 65535)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(49, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DB());
			defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Collections.Generic.IReadOnlyCollection<LetterVertex>)model.Vertices).Count);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Db());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		LegacyExport legacyExport = Enumerable.Single<LegacyExport>((global::System.Collections.Generic.IEnumerable<LegacyExport>)template2.Exports, (Func<LegacyExport, bool>)((LegacyExport P_0) => template2.ClassOf(P_0) == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hr()));
		byte[] bytes = template2.Bytes;
		template2.PropertiesIn((int)legacyExport.SerialOffset, (int)(legacyExport.SerialOffset + legacyExport.SerialSize), out var end);
		int num = (int)(legacyExport.SerialOffset + legacyExport.SerialSize);
		int num2 = end;
		num2 += 38;
		int num3 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, num2)));
		num2 += 4;
		MemoryStream val = new MemoryStream();
		((Stream)val).Write(bytes, (int)legacyExport.SerialOffset, num2 - (int)legacyExport.SerialOffset);
		for (int i = 0; i < num3; i++)
		{
			num2 += 2;
			int num4 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, num2)));
			if (num4 != 1)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(36, 2);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DC());
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dc());
				defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DD());
				throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			int num5 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, num2 + 4)));
			int num6 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, num2 + 24)));
			int num7 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, num2 + 28)));
			num2 += 36;
			num2 = A(bytes, num2 + 8);
			num2 = A(bytes, num2 + 2 + 16);
			num2 += 2;
			int num8 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, num2 + 4)));
			num2 += 8;
			if (num8 > 0)
			{
				num2 = A(bytes, num2);
			}
			for (int j = 0; j < 3; j++)
			{
				num2 = A(bytes, num2 + 4);
			}
			A((Stream)(object)val, model, num5, num6, num7);
		}
		byte[] array = MemoryExtensions.AsSpan<byte>(bytes, num2, num - num2).ToArray();
		A(array, model);
		((Stream)val).Write(global::System.ReadOnlySpan<byte>.op_Implicit(array));
		LegacyPackage legacyPackage = template2.WithExport(legacyExport, global::System.ReadOnlySpan<byte>.op_Implicit(val.ToArray()));
		LegacyPackage legacyPackage2 = legacyPackage.WithExportNumber(legacyPackage.Exports[legacyExport.Index], number);
		return A(legacyPackage2, legacyPackage2.Exports[legacyExport.Index], model);
	}

	private static int A(byte[] P_0, int P_1)
	{
		int num = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, P_1)));
		int num2 = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, P_1 + 4)));
		return checked(P_1 + 8 + num * num2);
	}

	private static void A(Stream P_0, LetterModel P_1, int P_2, int P_3, int P_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		BinaryWriter val = new BinaryWriter(P_0);
		int count = ((global::System.Collections.Generic.IReadOnlyCollection<LetterVertex>)P_1.Vertices).Count;
		val.Write((byte)1);
		val.Write((byte)0);
		val.Write(1);
		val.Write(P_2);
		val.Write(0);
		val.Write(((global::System.Collections.Generic.IReadOnlyCollection<int>)P_1.Indices).Count / 3);
		val.Write(0);
		val.Write(count - 1);
		val.Write(P_3);
		val.Write(P_4);
		val.Write(0f);
		val.Write(12);
		val.Write(count);
		val.Write(12);
		val.Write(count);
		global::System.Collections.Generic.IEnumerator<LetterVertex> enumerator = ((global::System.Collections.Generic.IEnumerable<LetterVertex>)P_1.Vertices).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LetterVertex current = enumerator.Current;
				val.Write(current.X);
				val.Write(current.Y);
				val.Write(current.Z);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		val.Write((byte)1);
		val.Write((byte)0);
		val.Write(1);
		val.Write(12);
		val.Write(count);
		val.Write(0);
		val.Write(12);
		val.Write(count);
		enumerator = ((global::System.Collections.Generic.IEnumerable<LetterVertex>)P_1.Vertices).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LetterVertex current2 = enumerator.Current;
				A(val, current2.Tangent, 127);
				A(val, current2.Normal, 255);
				val.Write((Half)current2.U);
				val.Write((Half)current2.V);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		val.Write((byte)1);
		val.Write((byte)0);
		val.Write(0);
		val.Write(0);
		byte[] array = new byte[((global::System.Collections.Generic.IReadOnlyCollection<int>)P_1.Indices).Count * 2];
		for (int i = 0; i < ((global::System.Collections.Generic.IReadOnlyCollection<int>)P_1.Indices).Count; i++)
		{
			BinaryPrimitives.WriteUInt16LittleEndian(MemoryExtensions.AsSpan<byte>(array, 2 * i), (ushort)P_1.Indices[i]);
		}
		for (int j = 0; j < 2; j++)
		{
			val.Write(0);
			val.Write(1);
			val.Write(array.Length);
			val.Write(array);
		}
		val.Write(0);
		val.Write(1);
		val.Write(0);
		val.Flush();
	}

	private static void A(BinaryWriter w, ValueTuple<float, float, float> v, byte P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		w.Write(A(v.Item1));
		w.Write(A(v.Item2));
		w.Write(A(v.Item3));
		w.Write(P_2);
	}

	private static byte A(float P_0)
	{
		return (byte)Math.Clamp((int)Math.Round((double)P_0 * 127.5 + 127.5), 0, 255);
	}

	private static void A(byte[] P_0, LetterModel P_1)
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i + 28 <= P_0.Length; i++)
		{
			float num = BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, i + 16)));
			float num2 = BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, i + 12)));
			float num3 = BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_0, i + 20)));
			if ((double)Math.Abs(num - 2.5f) < 0.0001 && num2 > 0.5f && num3 > 0.5f && (double)num2 < 10000.0)
			{
				float num4 = (float)(P_1.Width / 2.0);
				float num5 = (float)(P_1.Height / 2.0);
				float num6 = num4;
				float[] array = new float[7]
				{
					0f,
					0f,
					0f,
					num6,
					2.5f,
					num5,
					MathF.Sqrt(num6 * num6 + 6.25f + num5 * num5)
				};
				for (int j = 0; j < array.Length; j++)
				{
					BinaryPrimitives.WriteSingleLittleEndian(MemoryExtensions.AsSpan<byte>(P_0, i + 4 * j), array[j]);
				}
				return;
			}
		}
		throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dd());
	}

	private static byte[] A(LegacyPackage P_0, LegacyExport P_1, LetterModel P_2)
	{
		byte[] array = (byte[])((global::System.Array)P_0.Bytes).Clone();
		LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)P_0.PropertiesOf(P_1), (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HR()));
		if ((object)legacyProperty == null)
		{
			return array;
		}
		float num = (float)(P_2.Width / 2.0);
		float num2 = (float)(P_2.Height / 2.0);
		int end;
		global::System.Collections.Generic.IEnumerator<LegacyProperty> enumerator = ((global::System.Collections.Generic.IEnumerable<LegacyProperty>)P_0.PropertiesIn(legacyProperty.ValueStart, legacyProperty.ValueStart + legacyProperty.Size, out end)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LegacyProperty current = enumerator.Current;
				global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(array, current.ValueStart);
				string name = current.Name;
				if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DE()))
				{
					if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.De()))
					{
						if (name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DF())
						{
							BinaryPrimitives.WriteSingleLittleEndian(span, MathF.Sqrt(num * num + 6.25f + num2 * num2));
						}
					}
					else
					{
						BinaryPrimitives.WriteSingleLittleEndian(span, num);
						ref global::System.Span<byte> reference = ref span;
						BinaryPrimitives.WriteSingleLittleEndian(reference.Slice(4, reference.Length - 4), 2.5f);
						reference = ref span;
						BinaryPrimitives.WriteSingleLittleEndian(reference.Slice(8, reference.Length - 8), num2);
					}
				}
				else
				{
					BinaryPrimitives.WriteSingleLittleEndian(span, 0f);
					ref global::System.Span<byte> reference = ref span;
					BinaryPrimitives.WriteSingleLittleEndian(reference.Slice(4, reference.Length - 4), 0f);
					reference = ref span;
					BinaryPrimitives.WriteSingleLittleEndian(reference.Slice(8, reference.Length - 8), 0f);
				}
			}
			return array;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}
}
