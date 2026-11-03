using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace A;

internal static class B
{
	[field: CompilerGenerated]
	public static bool IsAvailable
	{
		[CompilerGenerated]
		get;
	} = Aes.IsSupported && Sse2.IsSupported;


	public static void A(global::System.ReadOnlySpan<byte> P_0, global::System.ReadOnlySpan<byte> P_1, global::System.Span<byte> P_2)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		global::System.Span<Vector128<byte>> span = stackalloc Vector128<byte>[15];
		A(P_1, span);
		Vector128<byte> val = Vector128.Create<byte>(P_0.Slice(0, 16));
		val ^= span[0];
		for (int l = 1; l <= 13; l++)
		{
			val = Aes.Decrypt(val, span[l]);
		}
		Vector128.CopyTo<byte>(Aes.DecryptLast(val, span[14]), P_2);
	}

	private static void A(global::System.ReadOnlySpan<byte> P_0, global::System.Span<Vector128<byte>> P_1)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		global::System.Span<Vector128<byte>> span = stackalloc Vector128<byte>[15];
		a(P_0, span);
		P_1[0] = span[14];
		for (int l = 1; l <= 13; l++)
		{
			P_1[l] = Aes.InverseMixColumns(span[14 - l]);
		}
		P_1[14] = span[0];
	}

	private static void a(global::System.ReadOnlySpan<byte> P_0, global::System.Span<Vector128<byte>> P_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		Vector128<byte> val = Vector128.Create<byte>(P_0.Slice(0, 16));
		Vector128<byte> val2 = Vector128.Create<byte>(P_0.Slice(16, 16));
		P_1[0] = val;
		P_1[1] = val2;
		int num = 2;
		byte[] array = new byte[7];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte[] array2 = array;
		for (int l = 0; l < array2.Length; l++)
		{
			val = A(val, a(A(val2, array2[l]), 3));
			P_1[num++] = val;
			if (num <= 14)
			{
				val2 = A(val2, a(A(val, (byte)0), 2));
				P_1[num++] = val2;
				continue;
			}
			break;
		}
	}

	private static Vector128<byte> A(Vector128<byte> P_0, byte P_1)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		return (Vector128<byte>)(P_1 switch
		{
			0 => Aes.KeygenAssist(P_0, (byte)0), 
			1 => Aes.KeygenAssist(P_0, (byte)1), 
			2 => Aes.KeygenAssist(P_0, (byte)2), 
			4 => Aes.KeygenAssist(P_0, (byte)4), 
			8 => Aes.KeygenAssist(P_0, (byte)8), 
			16 => Aes.KeygenAssist(P_0, (byte)16), 
			32 => Aes.KeygenAssist(P_0, (byte)32), 
			_ => Aes.KeygenAssist(P_0, (byte)64), 
		});
	}

	[MethodImpl(256)]
	private static Vector128<byte> a(Vector128<byte> P_0, byte P_1)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 != 3)
		{
			return Vector128.AsByte<uint>(Sse2.Shuffle(Vector128.AsUInt32<byte>(P_0), (byte)170));
		}
		return Vector128.AsByte<uint>(Sse2.Shuffle(Vector128.AsUInt32<byte>(P_0), (byte)255));
	}

	[MethodImpl(256)]
	private static Vector128<byte> A(Vector128<byte> P_0, Vector128<byte> P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		P_0 ^= Sse2.ShiftLeftLogical128BitLane(P_0, (byte)4);
		P_0 ^= Sse2.ShiftLeftLogical128BitLane(P_0, (byte)4);
		P_0 ^= Sse2.ShiftLeftLogical128BitLane(P_0, (byte)4);
		return P_0 ^ P_1;
	}
}
internal static class b
{
	[CompilerGenerated]
	private sealed class A
	{
		public Func<string, bool> only;

		internal bool A(PakEntry P_0)
		{
			if (P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.al(), (StringComparison)5) && !a(P_0.Path))
			{
				if (only != null)
				{
					return only.Invoke(P_0.Path);
				}
				return true;
			}
			return false;
		}
	}

	public static int A(PakArchive P_0, string? fontPath, Dictionary<string, byte[]> P_2, Func<string, bool>? only = null)
	{
		if (string.IsNullOrEmpty(fontPath) || !File.Exists(fontPath))
		{
			return 0;
		}
		byte[] array = File.ReadAllBytes(fontPath);
		int num = 0;
		global::System.Collections.Generic.IEnumerator<PakEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<PakEntry>)P_0.Entries).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PakEntry current = enumerator.Current;
				if (current.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.al(), (StringComparison)5) && !a(current.Path) && (only == null || only.Invoke(current.Path)))
				{
					P_2[current.Path] = array;
					num++;
				}
			}
			return num;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static int A(PakArchive P_0, Func<string, bool>? only = null)
	{
		Func<string, bool> only2 = only;
		ArgumentNullException.ThrowIfNull((object)P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		return Enumerable.Count<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)P_0.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.al(), (StringComparison)5) && !a(P_0.Path) && (only2 == null || only2.Invoke(P_0.Path))));
	}

	public static bool A(string P_0)
	{
		return P_0.Replace('\\', '/').Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.am(), (StringComparison)5);
	}

	private static bool a(string P_0)
	{
		return Path.GetFileNameWithoutExtension(P_0).Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aN(), (StringComparison)5);
	}
}
