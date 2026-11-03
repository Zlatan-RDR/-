using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

public static class ModContainers
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, bool> _003C0_003E__IsAMod;

		public static Func<char, bool> _003C1_003E__IsLetter;

		public static Func<char, bool> _003C2_003E__IsLower;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, string> _003C_003E9__1_0;

		public static Predicate<string> _003C_003E9__5_0;

		public static Func<IoStoreChunk, bool> _003C_003E9__7_0;

		internal string A(string P_0)
		{
			return P_0;
		}

		internal bool a(string P_0)
		{
			return string.Equals(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), (StringComparison)5);
		}

		internal bool A(IoStoreChunk P_0)
		{
			return P_0.Type == 1;
		}
	}

	private const byte ExportBundleData = 1;

	public static List<string> Under(string gameRoot)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(gameRoot, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ef());
		if (!Directory.Exists(gameRoot))
		{
			return new List<string>();
		}
		List<string> obj = new List<string>();
		obj.AddRange((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Where<string>(Directory.EnumerateFiles(gameRoot, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u(), (SearchOption)1), (Func<string, bool>)IsAMod), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
		return obj;
	}

	public static List<string> UnderAny(global::System.Collections.Generic.IEnumerable<string> roots)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)roots, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EG());
		SortedSet<string> val = new SortedSet<string>((IComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		global::System.Collections.Generic.IEnumerator<string> enumerator = roots.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (string.IsNullOrWhiteSpace(current) || !Directory.Exists(current))
				{
					continue;
				}
				bool flag = Directory.Exists(Path.Combine(current, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.K()));
				global::System.Collections.Generic.IEnumerator<string> enumerator2 = A(current).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						string current2 = enumerator2.Current;
						if (!flag || IsAMod(current2))
						{
							val.Add(current2);
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		int count = val.Count;
		List<string> val2 = new List<string>(count);
		CollectionsMarshal.SetCount<string>(val2, count);
		global::System.Span<string> span = CollectionsMarshal.AsSpan<string>(val2);
		int num = 0;
		Enumerator<string> enumerator3 = val.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				string current3 = enumerator3.Current;
				span[num] = current3;
				num++;
			}
			return val2;
		}
		finally
		{
			((global::System.IDisposable)enumerator3).Dispose();
		}
	}

	private static global::System.Collections.Generic.IEnumerable<string> A(string P_0)
	{
		try
		{
			return Directory.EnumerateFiles(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u(), (SearchOption)1);
		}
		catch (global::System.Exception)
		{
			return global::System.Array.Empty<string>();
		}
	}

	public static bool IsAMod(string containerPath)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(containerPath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eg());
		return !(Path.GetDirectoryName(containerPath) ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa()).EndsWith(Path.Combine(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.K()), (StringComparison)5);
	}

	public static string NameOf(string gameRoot, string containerPath)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(gameRoot, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ef());
		ArgumentException.ThrowIfNullOrWhiteSpace(containerPath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eg());
		string relativePath = Path.GetRelativePath(gameRoot, containerPath);
		string[] array = relativePath.Split(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		});
		int num = global::System.Array.FindIndex<string>(array, (Predicate<string>)((string P_0) => string.Equals(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.j(), (StringComparison)5)));
		if (num <= 0)
		{
			return relativePath;
		}
		return array[num - 1];
	}

	public static Dictionary<string, CookedText> TextIn(string gameRoot, IPakDecompressor decompressor, Action<string>? say = null)
	{
		return TextInAny(new e<string>(gameRoot), gameRoot, decompressor, say);
	}

	public static Dictionary<string, CookedText> TextInAny(global::System.Collections.Generic.IReadOnlyList<string> roots, string gameRoot, IPakDecompressor decompressor, Action<string>? say = null)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)decompressor, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EH());
		Dictionary<string, CookedText> val = new Dictionary<string, CookedText>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Enumerator<string> enumerator = UnderAny((global::System.Collections.Generic.IEnumerable<string>)roots).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					using IoStoreReader ioStoreReader = IoStoreReader.Open(current, decompressor);
					global::System.Collections.Generic.IEnumerator<IoStoreChunk> enumerator2 = Enumerable.Where<IoStoreChunk>((global::System.Collections.Generic.IEnumerable<IoStoreChunk>)ioStoreReader.Chunks, (Func<IoStoreChunk, bool>)((IoStoreChunk P_0) => P_0.Type == 1)).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							IoStoreChunk current2 = enumerator2.Current;
							byte[] array = ioStoreReader.Read(current2);
							if (array == null)
							{
								continue;
							}
							global::System.Collections.Generic.IEnumerator<CookedText> enumerator3 = CookedTextScan.In(array).GetEnumerator();
							try
							{
								while (((global::System.Collections.IEnumerator)enumerator3).MoveNext())
								{
									CookedText current3 = enumerator3.Current;
									val.TryAdd(Identity(current3), current3);
								}
							}
							finally
							{
								((global::System.IDisposable)enumerator3)?.Dispose();
							}
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2)?.Dispose();
					}
				}
				catch (global::System.Exception ex)
				{
					say?.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cM() + NameOf(gameRoot, current) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cm() + ex.Message);
				}
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	public static string Identity(CookedText text)
	{
		return text.Namespace + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DI() + text.Key;
	}

	public static bool LooksLikePlayerText(CookedText text)
	{
		string source = text.Source;
		if (source.Length < 3 || source.StartsWith('/') || source.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eh(), (StringComparison)4))
		{
			return false;
		}
		if (Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)source, (Func<char, bool>)char.IsLetter))
		{
			return Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)source, (Func<char, bool>)char.IsLower);
		}
		return false;
	}
}
