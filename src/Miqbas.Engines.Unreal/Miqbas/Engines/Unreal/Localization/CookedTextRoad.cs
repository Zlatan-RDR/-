using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Detection;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

public static class CookedTextRoad
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<PakEntry, bool> _003C_003E9__3_0;

		public static Func<string, string> _003C_003E9__4_0;

		internal bool A(PakEntry P_0)
		{
			if (!P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn(), (StringComparison)5))
			{
				return P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DO(), (StringComparison)5);
			}
			return true;
		}

		internal string A(string P_0)
		{
			return P_0;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public byte[] key;

		internal bool A(string P_0)
		{
			return CookedTextRoad.A(P_0, key);
		}
	}

	public const string EngineTablePath = "Engine/Content/Localization/Engine/en/Engine.locres";

	public const string KeyPrefix = "cooked#";

	public static bool Available(UnrealGameLayout layout, byte[]? key = null)
	{
		byte[] key2 = key;
		if (!Directory.Exists(layout.PaksDirectory))
		{
			return false;
		}
		if (Enumerable.Any<string>(Directory.EnumerateFiles(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u())))
		{
			return true;
		}
		return Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)layout.Packages, (Func<string, bool>)((string P_0) => A(P_0, key2)));
	}

	private static bool A(string P_0, byte[]? key)
	{
		try
		{
			using PakArchive pakArchive = PakArchive.Open(P_0, key);
			return !pakArchive.IndexEncrypted && Enumerable.Any<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)pakArchive.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn(), (StringComparison)5) || P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DO(), (StringComparison)5)));
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	public static global::System.Collections.Generic.IReadOnlyList<CookedText> Read(UnrealGameLayout layout, IPakDecompressor? decompressor, CancellationToken cancellationToken = default(CancellationToken), Action<string, IoStoreChunk, byte[]>? everyAsset = null, byte[]? key = null)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, CookedText> val = new Dictionary<string, CookedText>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>((global::System.Collections.Generic.IEnumerable<string>)Directory.GetFiles(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u()), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				IoStoreReader ioStoreReader;
				try
				{
					ioStoreReader = IoStoreReader.Open(current, decompressor, key);
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					continue;
				}
				using (ioStoreReader)
				{
					global::System.Collections.Generic.IEnumerator<IoStoreChunk> enumerator2 = ((global::System.Collections.Generic.IEnumerable<IoStoreChunk>)ioStoreReader.Chunks).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							IoStoreChunk current2 = enumerator2.Current;
							((CancellationToken)(ref cancellationToken)).ThrowIfCancellationRequested();
							if (current2.Type == ioStoreReader.Container.CookedAssetKind)
							{
								byte[] array = ioStoreReader.Read(current2);
								if (array != null)
								{
									A(array, val);
									everyAsset?.Invoke(current, current2, array);
								}
							}
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2)?.Dispose();
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count == 0)
		{
			A(layout, decompressor, key, val, cancellationToken);
		}
		return (global::System.Collections.Generic.IReadOnlyList<CookedText>)Enumerable.ToList<CookedText>((global::System.Collections.Generic.IEnumerable<CookedText>)val.Values);
	}

	private static void A(UnrealGameLayout P_0, IPakDecompressor? decompressor, byte[]? key, Dictionary<string, CookedText> P_3, CancellationToken P_4)
	{
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)P_0.Packages).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				PakArchive pakArchive;
				try
				{
					pakArchive = PakArchive.Open(current, key);
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					continue;
				}
				using (pakArchive)
				{
					if (pakArchive.IndexEncrypted)
					{
						continue;
					}
					global::System.Collections.Generic.IEnumerator<PakEntry> enumerator2 = ((global::System.Collections.Generic.IEnumerable<PakEntry>)pakArchive.Entries).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							PakEntry current2 = enumerator2.Current;
							((CancellationToken)(ref P_4)).ThrowIfCancellationRequested();
							bool flag = current2.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DN(), (StringComparison)5);
							if (!flag && !current2.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn(), (StringComparison)5) && !current2.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DO(), (StringComparison)5))
							{
								continue;
							}
							try
							{
								byte[] array = pakArchive.Read(current2, flag ? decompressor : null);
								if (array != null)
								{
									A(array, P_3);
								}
							}
							catch (global::System.Exception ex2) when (((ex2 is IOException || ex2 is InvalidDataException || ex2 is NotSupportedException) ? 1 : 0) != 0)
							{
							}
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2)?.Dispose();
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static void A(byte[] P_0, Dictionary<string, CookedText> P_1)
	{
		global::System.Collections.Generic.IEnumerator<CookedText> enumerator = CookedTextScan.In(P_0).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				CookedText current = enumerator.Current;
				if (!current.CultureInvariant && !current.FromString && current.Source.Length != 0)
				{
					P_1.TryAdd(AddressOf(current.Namespace, current.Key), current);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		enumerator = ((global::System.Collections.Generic.IEnumerable<CookedText>)StringTableScan.In(P_0)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				CookedText current2 = enumerator.Current;
				if (current2.Source.Length > 0)
				{
					P_1.TryAdd(AddressOf(current2.Namespace, current2.Key), current2);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static string AddressOf(string space, string key)
	{
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Do() + space + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DI() + key;
	}

	public static bool TryParseAddress(string address, out string space, out string key)
	{
		space = string.Empty;
		key = string.Empty;
		if (!IsCookedAddress(address))
		{
			return false;
		}
		string text = address;
		int length = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Do().Length;
		string text2 = text.Substring(length, text.Length - length);
		int num = text2.IndexOf('|');
		if (num < 0)
		{
			return false;
		}
		space = text2.Substring(0, num);
		text = text2;
		length = num + 1;
		key = text.Substring(length, text.Length - length);
		return true;
	}

	public static bool IsCookedAddress(string key)
	{
		return key.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Do(), (StringComparison)4);
	}

	public static byte[] BuildTable(global::System.Collections.Generic.IReadOnlyList<LocResEntry> engineTable, global::System.Collections.Generic.IReadOnlyList<CookedText> texts, IReadOnlyDictionary<string, string> translationsByAddress)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		List<ValueTuple<string, string, string, string>> val = new List<ValueTuple<string, string, string, string>>();
		global::System.Collections.Generic.IEnumerator<LocResEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<LocResEntry>)engineTable).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LocResEntry current = enumerator.Current;
				val.Add(new ValueTuple<string, string, string, string>(current.Namespace, current.Key, current.Value, current.Value));
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		global::System.Collections.Generic.IEnumerator<CookedText> enumerator2 = ((global::System.Collections.Generic.IEnumerable<CookedText>)texts).GetEnumerator();
		try
		{
			string text = default(string);
			while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				CookedText current2 = enumerator2.Current;
				if (translationsByAddress.TryGetValue(AddressOf(current2.Namespace, current2.Key), ref text) && !string.IsNullOrWhiteSpace(text))
				{
					val.Add(new ValueTuple<string, string, string, string>(current2.Namespace, current2.Key, current2.Source, text));
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator2)?.Dispose();
		}
		return LocResFile.FromScratch((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string, string, string>>)val).ToBytes();
	}

	public static global::System.Collections.Generic.IReadOnlyList<LocResEntry> ReadEngineTable(PakArchive package, IPakDecompressor? decompressor)
	{
		ArgumentNullException.ThrowIfNull((object)package, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		global::System.Collections.Generic.IEnumerator<PakEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<PakEntry>)package.Entries).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PakEntry current = enumerator.Current;
				if (current.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cN(), (StringComparison)5))
				{
					return PackagedTable.Read(package, current, decompressor).Entries;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return global::System.Array.Empty<LocResEntry>();
	}
}
