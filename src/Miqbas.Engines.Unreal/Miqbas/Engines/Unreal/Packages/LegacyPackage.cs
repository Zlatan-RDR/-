using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public sealed class LegacyPackage
{
	private sealed class A
	{
		[CompilerGenerated]
		private byte[] _003Cbytes_003EP;

		[field: CompilerGenerated]
		public long Position
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			set;
		}

		public A(byte[] P_0)
		{
			_003Cbytes_003EP = P_0;
			base._002Ector();
		}

		public uint A()
		{
			return BinaryPrimitives.ReadUInt32LittleEndian(a(4L));
		}

		public int a()
		{
			return BinaryPrimitives.ReadInt32LittleEndian(a(4L));
		}

		public long B()
		{
			return BinaryPrimitives.ReadInt64LittleEndian(a(8L));
		}

		public unsafe byte b()
		{
			return *(byte*)a(1L)[0];
		}

		public void A(long P_0)
		{
			a(P_0);
		}

		public string C()
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			int num = a();
			if (num == 0)
			{
				return string.Empty;
			}
			if (num > 0)
			{
				global::System.ReadOnlySpan<byte> readOnlySpan = a(num);
				return Encoding.Latin1.GetString(readOnlySpan).TrimEnd('\0');
			}
			if (num == -2147483648)
			{
				throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hk());
			}
			global::System.ReadOnlySpan<byte> readOnlySpan2 = a(-2L * (long)num);
			return Encoding.Unicode.GetString(readOnlySpan2).TrimEnd('\0');
		}

		private global::System.ReadOnlySpan<byte> a(long P_0)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			if (P_0 < 0 || Position + P_0 > _003Cbytes_003EP.Length)
			{
				throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HL());
			}
			global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>(_003Cbytes_003EP, (int)Position, (int)P_0);
			Position += P_0;
			return global::System.Span<byte>.op_Implicit(span);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<char, bool> _003C_003E9__32_0;

		internal bool A(char P_0)
		{
			return P_0 < '\u0080';
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct B
	{
		public List<string> names;
	}

	private const uint Tag = 2653586369u;

	private const int InnerArrayTagVersion = 500;

	private const int PropertyGuidVersion = 503;

	private const int NameHashesVersion = 504;

	private const int LargeExportsVersion = 511;

	private readonly int _bulkDataStartField;

	[field: CompilerGenerated]
	public byte[] Bytes
	{
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public int FileVersion
	{
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<string> Names
	{
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<ValueTuple<string, string>> Imports
	{
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<LegacyExport> Exports
	{
		[CompilerGenerated]
		get;
	}

	private LegacyPackage(byte[] P_0, int P_1, List<string> P_2, List<ValueTuple<string, string>> imports, List<LegacyExport> P_4, int P_5)
	{
		Bytes = P_0;
		FileVersion = P_1;
		Names = (global::System.Collections.Generic.IReadOnlyList<string>)P_2;
		Imports = (global::System.Collections.Generic.IReadOnlyList<ValueTuple<string, string>>)imports;
		Exports = (global::System.Collections.Generic.IReadOnlyList<LegacyExport>)P_4;
		_bulkDataStartField = P_5;
	}

	public static bool LooksLikeOne(global::System.ReadOnlySpan<byte> bytes)
	{
		if (bytes.Length >= 4)
		{
			return BinaryPrimitives.ReadUInt32LittleEndian(bytes) == 2653586369u;
		}
		return false;
	}

	public static LegacyPackage Read(byte[] bytes)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		A a = new A(bytes);
		if (a.A() != 2653586369u)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bn());
		}
		int num = a.a();
		switch (num)
		{
		default:
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(42, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BO());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bo());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		case -7:
		case -6:
		case -5:
		case -3:
		case -2:
		case -1:
			a.a();
			break;
		case -4:
			break;
		}
		int num2 = a.a();
		a.a();
		if (num2 <= 0)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BP());
		}
		int num3 = a.a();
		a.A(20L * (long)Math.Max(num3, 0));
		a.a();
		a.C();
		a.A();
		int num4 = a.a();
		int num5 = a.a();
		if (num2 >= 459)
		{
			a.a();
			a.a();
		}
		int num6 = a.a();
		int num7 = a.a();
		int num8 = a.a();
		int num9 = a.a();
		a.a();
		if (num2 >= 384)
		{
			a.a();
			a.a();
		}
		if (num2 >= 510)
		{
			a.a();
		}
		a.a();
		a.A(16L);
		int num10 = a.a();
		a.A(8L * (long)Math.Max(num10, 0));
		a.A(10L);
		a.C();
		if (num2 >= 444)
		{
			a.A(10L);
			a.C();
		}
		a.A();
		int num11 = a.a();
		a.A(16L * (long)Math.Max(num11, 0));
		a.A();
		int num12 = a.a();
		for (int i = 0; i < num12; i++)
		{
			a.C();
		}
		if (num > -7)
		{
			a.a();
		}
		a.a();
		long position = a.Position;
		B b = default(B);
		b.names = new List<string>(A(num4, bytes));
		a.Position = num5;
		for (int j = 0; j < num4; j++)
		{
			b.names.Add(a.C());
			if (num2 >= 504)
			{
				a.A(4L);
			}
		}
		List<ValueTuple<string, string>> val = new List<ValueTuple<string, string>>(A(num8, bytes));
		a.Position = num9;
		for (int k = 0; k < num8; k++)
		{
			a.A(8L);
			string text = A(a.a(), a.a(), ref b);
			a.a();
			string text2 = A(a.a(), a.a(), ref b);
			val.Add(new ValueTuple<string, string>(text, text2));
		}
		List<LegacyExport> val2 = new List<LegacyExport>(A(num6, bytes));
		a.Position = num7;
		for (int l = 0; l < num6; l++)
		{
			long position2 = a.Position;
			int classIndex = a.a();
			a.a();
			int outerIndex = a.a();
			int num13 = a.a();
			int num14 = a.a();
			a.A();
			long num15;
			long num16;
			if (num2 >= 511)
			{
				num15 = a.B();
				num16 = a.B();
			}
			else
			{
				num15 = a.a();
				num16 = a.a();
			}
			a.A(32L);
			if (num2 >= 365)
			{
				a.A(4L);
			}
			if (num2 >= 485)
			{
				a.A(4L);
			}
			if (num2 >= 507)
			{
				a.A(20L);
			}
			if (num16 < 0 || num15 < 0 || num16 + num15 > bytes.Length)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bp());
				defaultInterpolatedStringHandler.AppendFormatted<int>(l);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BQ());
				throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			val2.Add(new LegacyExport(l, classIndex, outerIndex, A(num13, num14, ref b), num13, num14, num16, num15, (int)position2));
		}
		return new LegacyPackage(bytes, num2, b.names, val, val2, (int)position);
	}

	public string ClassOf(LegacyExport export)
	{
		return ObjectName(export.ClassIndex);
	}

	public string ObjectName(int reference)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (reference >= 0)
		{
			if (reference > 0 && reference - 1 < ((global::System.Collections.Generic.IReadOnlyCollection<LegacyExport>)Exports).Count)
			{
				return Exports[reference - 1].Name;
			}
		}
		else if (-reference - 1 < ((global::System.Collections.Generic.IReadOnlyCollection<ValueTuple<string, string>>)Imports).Count)
		{
			return Imports[-reference - 1].Item2;
		}
		return string.Empty;
	}

	public global::System.Collections.Generic.IReadOnlyList<LegacyProperty> PropertiesOf(LegacyExport export)
	{
		int end;
		return PropertiesIn((int)export.SerialOffset, (int)(export.SerialOffset + export.SerialSize), out end);
	}

	public global::System.Collections.Generic.IReadOnlyList<LegacyProperty> PropertiesIn(int start, int limit, out int end)
	{
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		A a = new A(Bytes)
		{
			Position = start
		};
		List<LegacyProperty> val = new List<LegacyProperty>();
		while (a.Position < limit)
		{
			int tagStart = (int)a.Position;
			string text = A(a);
			if (text == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ay())
			{
				break;
			}
			string text2 = A(a);
			int num = a.a();
			int arrayIndex = a.a();
			string extra = null;
			byte boolValue = 0;
			if (text2 != null)
			{
				switch (text2.Length)
				{
				case 12:
				{
					char c = text2[1];
					if (c != 'n')
					{
						if (c == 'o')
						{
							if (text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BR())
							{
								boolValue = a.b();
							}
							break;
						}
						if (c != 'y' || !(text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Br()))
						{
							break;
						}
					}
					else if (!(text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BS()))
					{
						break;
					}
					goto IL_017f;
				}
				case 11:
				{
					char c = text2[0];
					if (c != 'M')
					{
						if (c != 'S' || !(text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BT()))
						{
							break;
						}
						goto IL_017f;
					}
					if (text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bt())
					{
						extra = A(a) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BU() + A(a);
					}
					break;
				}
				case 14:
					if (text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq())
					{
						extra = A(a);
						if (FileVersion >= 441)
						{
							a.A(16L);
						}
					}
					break;
				case 13:
					{
						if (!(text2 == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bs()))
						{
							break;
						}
						goto IL_017f;
					}
					IL_017f:
					extra = A(a);
					break;
				}
			}
			if (FileVersion >= 503 && a.b() != 0)
			{
				a.A(16L);
			}
			int num2 = (int)a.Position;
			if (num < 0 || (long)num2 + (long)num > limit)
			{
				throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bu() + text + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BV());
			}
			val.Add(new LegacyProperty(text, text2, num, arrayIndex, extra, tagStart, num2, boolValue));
			a.Position = num2 + num;
		}
		end = (int)a.Position;
		return (global::System.Collections.Generic.IReadOnlyList<LegacyProperty>)val;
	}

	public global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>> StructArray(LegacyProperty array)
	{
		ArgumentNullException.ThrowIfNull((object)array, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bv());
		int num = BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(Bytes, array.ValueStart)));
		int end = array.ValueStart + 4;
		int limit = array.ValueStart + array.Size;
		if (FileVersion >= 500)
		{
			A a = new A(Bytes)
			{
				Position = end
			};
			A(a);
			A(a);
			a.A(8L);
			A(a);
			a.A(16L);
			if (FileVersion >= 503 && a.b() != 0)
			{
				a.A(16L);
			}
			end = (int)a.Position;
		}
		List<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>> val = new List<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>>(A(num, Bytes));
		for (int i = 0; i < num; i++)
		{
			val.Add(PropertiesIn(end, limit, out end));
		}
		return (global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>>)val;
	}

	public string StringAt(int position)
	{
		return new A(Bytes)
		{
			Position = position
		}.C();
	}

	public LegacyPackage WithExport(LegacyExport export, global::System.ReadOnlySpan<byte> newBytes)
	{
		ArgumentNullException.ThrowIfNull((object)export, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BW());
		long num = newBytes.Length - export.SerialSize;
		byte[] array = new byte[Bytes.Length + num];
		int num2 = (int)export.SerialOffset;
		int num3 = (int)(export.SerialOffset + export.SerialSize);
		MemoryExtensions.AsSpan<byte>(Bytes, 0, num2).CopyTo(global::System.Span<byte>.op_Implicit(array));
		newBytes.CopyTo(MemoryExtensions.AsSpan<byte>(array, num2));
		MemoryExtensions.AsSpan<byte>(Bytes, num3).CopyTo(MemoryExtensions.AsSpan<byte>(array, num2 + newBytes.Length));
		bool flag = FileVersion >= 511;
		global::System.Collections.Generic.IEnumerator<LegacyExport> enumerator = ((global::System.Collections.Generic.IEnumerable<LegacyExport>)Exports).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LegacyExport current = enumerator.Current;
				int num4 = current.TablePosition + 24;
				int num5 = num4 + (flag ? 8 : 4);
				if (current.Index == export.Index)
				{
					A(array, num4, newBytes.Length, flag);
				}
				if (current.SerialOffset > export.SerialOffset)
				{
					A(array, num5, current.SerialOffset + num, flag);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		long num6 = BinaryPrimitives.ReadInt64LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(array, _bulkDataStartField)));
		if (num6 > export.SerialOffset)
		{
			BinaryPrimitives.WriteInt64LittleEndian(MemoryExtensions.AsSpan<byte>(array, _bulkDataStartField), num6 + num);
		}
		return Read(array);
	}

	public LegacyPackage WithExportNumber(LegacyExport export, int number)
	{
		ArgumentNullException.ThrowIfNull((object)export, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BW());
		byte[] obj = (byte[])((global::System.Array)Bytes).Clone();
		BinaryPrimitives.WriteInt32LittleEndian(MemoryExtensions.AsSpan<byte>(obj, export.TablePosition + 16), number + 1);
		return Read(obj);
	}

	public static byte[] EncodeString(string value)
	{
		ArgumentNullException.ThrowIfNull((object)value, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bw());
		bool flag = Enumerable.All<char>((global::System.Collections.Generic.IEnumerable<char>)value, (Func<char, bool>)((char P_0) => P_0 < '\u0080'));
		byte[] array = (flag ? Encoding.ASCII.GetBytes(value + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BX()) : Encoding.Unicode.GetBytes(value + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BX()));
		byte[] array2 = new byte[4 + array.Length];
		BinaryPrimitives.WriteInt32LittleEndian(global::System.Span<byte>.op_Implicit(array2), flag ? array.Length : (-(array.Length / 2)));
		((global::System.Array)array).CopyTo((global::System.Array)array2, 4);
		return array2;
	}

	private static void A(byte[] P_0, int P_1, long P_2, bool P_3)
	{
		if (P_3)
		{
			BinaryPrimitives.WriteInt64LittleEndian(MemoryExtensions.AsSpan<byte>(P_0, P_1), P_2);
		}
		else
		{
			BinaryPrimitives.WriteInt32LittleEndian(MemoryExtensions.AsSpan<byte>(P_0, P_1), checked((int)P_2));
		}
	}

	private string A(A P_0)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		int num = P_0.a();
		int num2 = P_0.a();
		if ((uint)num >= (uint)((global::System.Collections.Generic.IReadOnlyCollection<string>)Names).Count)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(37, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bx());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BY());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (num2 != 0)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(Names[num]);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.By());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2 - 1);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return Names[num];
	}

	private static int A(int P_0, byte[] P_1)
	{
		return Math.Clamp(P_0, 0, P_1.Length / 4);
	}

	[CompilerGenerated]
	internal static string A(int P_0, int P_1, ref B P_2)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((uint)P_0 >= (uint)P_2.names.Count)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(37, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bx());
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BY());
			throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (P_1 != 0)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(P_2.names[P_0]);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.By());
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_1 - 1);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return P_2.names[P_0];
	}
}
