using System;
using System.Collections;
using System.Collections.Generic;
using Miqbas.Core.Text;

namespace Miqbas.Core.Packages;

public static class PackageImporter
{
	public static ImportResult Match(MqbsContents package, System.Collections.Generic.IReadOnlyList<SourceText> currentStrings, string? currentFingerprint = null)
	{
		Dictionary<string, MqbsEntry> val = new Dictionary<string, MqbsEntry>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		Dictionary<string, MqbsEntry> val2 = new Dictionary<string, MqbsEntry>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<MqbsEntry> enumerator = ((System.Collections.Generic.IEnumerable<MqbsEntry>)package.Entries).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				MqbsEntry current = enumerator.Current;
				val.TryAdd(current.Key, current);
				val2.TryAdd(current.Source, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		List<ImportMatch> val3 = new List<ImportMatch>(((System.Collections.Generic.IReadOnlyCollection<SourceText>)currentStrings).Count);
		System.Collections.Generic.IEnumerator<SourceText> enumerator2 = ((System.Collections.Generic.IEnumerable<SourceText>)currentStrings).GetEnumerator();
		try
		{
			MqbsEntry mqbsEntry = default(MqbsEntry);
			MqbsEntry mqbsEntry2 = default(MqbsEntry);
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				SourceText current2 = enumerator2.Current;
				if (val.TryGetValue(current2.Key, ref mqbsEntry) && mqbsEntry.Source == current2.Value)
				{
					val3.Add(new ImportMatch
					{
						Source = current2,
						Quality = MatchQuality.Exact,
						Translation = mqbsEntry.Target
					});
				}
				else if (val2.TryGetValue(current2.Value, ref mqbsEntry2))
				{
					val3.Add(new ImportMatch
					{
						Source = current2,
						Quality = MatchQuality.MovedButIdentical,
						Translation = mqbsEntry2.Target
					});
				}
				else
				{
					val3.Add(new ImportMatch
					{
						Source = current2,
						Quality = MatchQuality.Unmatched
					});
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
		return new ImportResult
		{
			Matches = (System.Collections.Generic.IReadOnlyList<ImportMatch>)val3,
			IsExactBuildMatch = (currentFingerprint != null && string.Equals(currentFingerprint, package.Manifest.GameFingerprint, (StringComparison)4))
		};
	}
}
