using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

public static class ShippedArabicReader
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<LocResEntry, string> _003C_003E9__2_0;

		public static Func<LocResEntry, string> _003C_003E9__2_1;

		internal string A(LocResEntry P_0)
		{
			return P_0.Address;
		}

		internal string a(LocResEntry P_0)
		{
			return P_0.Value;
		}
	}

	private static readonly string[] ArabicCultures = new string[4]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EL(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.El(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EM(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Em()
	};

	private const int MinimumPairs = 50;

	public static ShippedArabicTables Read(PakArchive package, string projectName, IPakDecompressor? decompressor)
	{
		ArgumentNullException.ThrowIfNull((object)package, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		Dictionary<string, string> val = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		List<string> val2 = new List<string>();
		global::System.Collections.Generic.IEnumerator<LocalizationTarget> enumerator = ((global::System.Collections.Generic.IEnumerable<LocalizationTarget>)LocalizationTarget.FindIn(package, projectName)).GetEnumerator();
		try
		{
			PakEntry entry = default(PakEntry);
			string text2 = default(string);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LocalizationTarget current = enumerator.Current;
				string[] arabicCultures = ArabicCultures;
				IReadOnlyDictionary<string, PakEntry> tablesByCulture = current.TablesByCulture;
				string text = Enumerable.FirstOrDefault<string>((global::System.Collections.Generic.IEnumerable<string>)arabicCultures, (Func<string, bool>)tablesByCulture.ContainsKey);
				if (text == null || !current.TablesByCulture.TryGetValue(current.SourceCulture, ref entry))
				{
					continue;
				}
				LocResFile locResFile;
				LocResFile locResFile2;
				try
				{
					locResFile = LocResFile.Read(package.Read(entry, decompressor));
					locResFile2 = LocResFile.Read(package.Read(current.TablesByCulture[text], decompressor));
				}
				catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					continue;
				}
				Dictionary<string, string> val3 = Enumerable.ToDictionary<LocResEntry, string, string>((global::System.Collections.Generic.IEnumerable<LocResEntry>)locResFile2.Entries, (Func<LocResEntry, string>)((LocResEntry P_0) => P_0.Address), (Func<LocResEntry, string>)((LocResEntry P_0) => P_0.Value), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
				int num = 0;
				global::System.Collections.Generic.IEnumerator<LocResEntry> enumerator2 = ((global::System.Collections.Generic.IEnumerable<LocResEntry>)locResFile.Entries).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						LocResEntry current2 = enumerator2.Current;
						if (!string.IsNullOrWhiteSpace(current2.Value) && val3.TryGetValue(current2.Address, ref text2) && !string.IsNullOrWhiteSpace(text2) && !string.Equals(text2, current2.Value, (StringComparison)4))
						{
							val[current2.Value] = text2;
							num++;
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator2)?.Dispose();
				}
				if (num > 0)
				{
					val2.Add(current.Name);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (val.Count >= 50)
		{
			return new ShippedArabicTables
			{
				Targets = (global::System.Collections.Generic.IReadOnlyList<string>)val2,
				Pairs = (IReadOnlyDictionary<string, string>)(object)val
			};
		}
		return ShippedArabicTables.None;
	}
}
