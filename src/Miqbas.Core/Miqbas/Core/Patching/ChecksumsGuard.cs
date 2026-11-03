using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Patching;

public static class ChecksumsGuard
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ValueTuple<string, string>, ValueTuple<string, string>> _003C_003E9__2_2;

		public static Func<ValueTuple<string, string>, string> _003C_003E9__2_3;

		internal ValueTuple<string, string> A(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string>(f.Item1, f.Item2);
		}

		internal string a(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return f.Item2;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string root;

		internal ValueTuple<string, string> A(string P_0)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string>(P_0, Path.IsPathRooted(P_0) ? null : Path.GetFullPath(Path.Combine(root, P_0)));
		}

		internal bool A(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			if (f.Item2 != null)
			{
				return f.Item2.StartsWith(root, (StringComparison)5);
			}
			return false;
		}
	}

	private const long Largest = 52428800L;

	private static readonly HashSet<string> NotSearched;

	public static IReadOnlyDictionary<string, string> Find(string gameRoot, System.Collections.Generic.IReadOnlyCollection<string> files, string? saveFolder = null)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)files, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kz());
		Dictionary<string, string> val = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(Path.GetFullPath(gameRoot).TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		}));
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		string root = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref directorySeparatorChar));
		List<ValueTuple<string, string>> obj = Enumerable.ToList<ValueTuple<string, string>>(Enumerable.Select<ValueTuple<string, string>, ValueTuple<string, string>>(Enumerable.Where<ValueTuple<string, string>>(Enumerable.Select<string, ValueTuple<string, string>>((System.Collections.Generic.IEnumerable<string>)files, (Func<string, ValueTuple<string, string>>)((string P_0) => new ValueTuple<string, string>(P_0, Path.IsPathRooted(P_0) ? null : Path.GetFullPath(Path.Combine(root, P_0))))), (Func<ValueTuple<string, string>, bool>)((ValueTuple<string, string> f) => f.Item2 != null && f.Item2.StartsWith(root, (StringComparison)5))), (Func<ValueTuple<string, string>, ValueTuple<string, string>>)((ValueTuple<string, string> f) => new ValueTuple<string, string>(f.Item1, f.Item2))));
		HashSet<string> val2 = Enumerable.ToHashSet<string>(Enumerable.Select<ValueTuple<string, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)obj, (Func<ValueTuple<string, string>, string>)((ValueTuple<string, string> f) => f.Item2)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		List<ValueTuple<string, byte[]>> val3 = new List<ValueTuple<string, byte[]>>();
		Enumerator<ValueTuple<string, string>> enumerator = obj.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ValueTuple<string, string> current = enumerator.Current;
				string item = current.Item1;
				string item2 = current.Item2;
				if (File.Exists(item2))
				{
					ValueTuple<byte[], byte[], byte[], uint> val4 = A(item2);
					byte[] item3 = val4.Item1;
					byte[] item4 = val4.Item2;
					byte[] item5 = val4.Item3;
					uint item6 = val4.Item4;
					byte[][] array = new byte[3][] { item3, item4, item5 };
					foreach (byte[] array2 in array)
					{
						val3.Add(new ValueTuple<string, byte[]>(item, array2));
						val3.Add(new ValueTuple<string, byte[]>(item, Encoding.ASCII.GetBytes(Convert.ToHexString(array2))));
						val3.Add(new ValueTuple<string, byte[]>(item, Encoding.ASCII.GetBytes(Convert.ToHexString(array2).ToLowerInvariant())));
					}
					val3.Add(new ValueTuple<string, byte[]>(item, Encoding.ASCII.GetBytes(item6.ToString(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LA(), (IFormatProvider)(object)CultureInfo.InvariantCulture))));
					val3.Add(new ValueTuple<string, byte[]>(item, Encoding.ASCII.GetBytes(item6.ToString(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.La(), (IFormatProvider)(object)CultureInfo.InvariantCulture))));
					val3.Add(new ValueTuple<string, byte[]>(item, Encoding.ASCII.GetBytes(item6.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture))));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (val3.Count == 0)
		{
			return (IReadOnlyDictionary<string, string>)(object)val;
		}
		System.Collections.Generic.IEnumerable<string> enumerable = Directory.EnumerateFiles(gameRoot, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (SearchOption)1);
		System.Collections.Generic.IEnumerable<string> enumerable3;
		if (saveFolder == null || !Directory.Exists(saveFolder))
		{
			System.Collections.Generic.IEnumerable<string> enumerable2 = System.Array.Empty<string>();
			enumerable3 = enumerable2;
		}
		else
		{
			enumerable3 = Directory.EnumerateFiles(saveFolder, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (SearchOption)1);
		}
		System.Collections.Generic.IEnumerator<string> enumerator2 = Enumerable.Concat<string>(enumerable, enumerable3).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				string current2 = enumerator2.Current;
				if (val2.Contains(Path.GetFullPath(current2)) || NotSearched.Contains(Path.GetExtension(current2)))
				{
					continue;
				}
				byte[] array3;
				try
				{
					long length = new FileInfo(current2).Length;
					if ((length > 52428800 || length == 0L) ? true : false)
					{
						continue;
					}
					array3 = File.ReadAllBytes(current2);
					goto IL_0329;
				}
				catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
				{
				}
				continue;
				IL_0329:
				Enumerator<ValueTuple<string, byte[]>> enumerator3 = val3.GetEnumerator();
				try
				{
					while (enumerator3.MoveNext())
					{
						ValueTuple<string, byte[]> current3 = enumerator3.Current;
						string item7 = current3.Item1;
						byte[] item8 = current3.Item2;
						if (!val.ContainsKey(item7) && MemoryExtensions.IndexOf<byte>(MemoryExtensions.AsSpan<byte>(array3), System.ReadOnlySpan<byte>.op_Implicit(item8)) >= 0)
						{
							val[item7] = (current2.StartsWith(gameRoot, (StringComparison)5) ? Path.GetRelativePath(gameRoot, current2).Replace('\\', '/') : Path.GetFileName(current2));
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator3).Dispose();
				}
			}
			return (IReadOnlyDictionary<string, string>)(object)val;
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
	}

	private static ValueTuple<byte[], byte[], byte[], uint> A(string P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		IncrementalHash val = IncrementalHash.CreateHash(HashAlgorithmName.MD5);
		try
		{
			IncrementalHash val2 = IncrementalHash.CreateHash(HashAlgorithmName.SHA1);
			try
			{
				IncrementalHash val3 = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
				try
				{
					uint num = 4294967295u;
					byte[] array = new byte[1048576];
					FileStream val4 = File.OpenRead(P_0);
					try
					{
						int num2;
						while ((num2 = ((Stream)val4).Read(array, 0, array.Length)) > 0)
						{
							val.AppendData(array, 0, num2);
							val2.AppendData(array, 0, num2);
							val3.AppendData(array, 0, num2);
							num = A(num, System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(array, 0, num2)));
						}
						return new ValueTuple<byte[], byte[], byte[], uint>(val.GetHashAndReset(), val2.GetHashAndReset(), val3.GetHashAndReset(), ~num);
					}
					finally
					{
						((System.IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	public static uint Crc32(byte[] bytes)
	{
		return ~A(4294967295u, System.ReadOnlySpan<byte>.op_Implicit(bytes));
	}

	private unsafe static uint A(uint P_0, System.ReadOnlySpan<byte> P_1)
	{
		System.ReadOnlySpan<byte> readOnlySpan = P_1;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			byte b = *(byte*)readOnlySpan[i];
			P_0 ^= b;
			for (int j = 0; j < 8; j++)
			{
				P_0 = (((P_0 & (true ? 1u : 0u)) != 0) ? (0xEDB88320u ^ (P_0 >> 1)) : (P_0 >> 1));
			}
		}
		return P_0;
	}

	static ChecksumsGuard()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LB());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lb());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LC());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lc());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LD());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ld());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LE());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Le());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LF());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lf());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LG());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lg());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LH());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lh());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LI());
		NotSearched = obj;
	}
}
