using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Baseline;

public static class SavedReadings
{
	[CompilerGenerated]
	private sealed class A
	{
		public Dictionary<string, string> now;

		internal bool A(KeyValuePair<string, string> P_0)
		{
			return now[P_0.Key] != P_0.Value;
		}
	}

	public static Dictionary<string, string> StampsOf(string gameRoot, System.Collections.Generic.IEnumerable<string> relativeFiles)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)relativeFiles, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rc());
		Dictionary<string, string> val = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<string> enumerator = relativeFiles.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				FileInfo val2 = new FileInfo(Path.Combine(gameRoot, current));
				string text;
				if (!((FileSystemInfo)val2).Exists)
				{
					text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RD();
				}
				else
				{
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<long>(val2.Length);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Rd());
					defaultInterpolatedStringHandler.AppendFormatted<long>(((FileSystemInfo)val2).LastWriteTimeUtc.Ticks);
					text = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				val[current] = text;
			}
			return val;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static bool ItsFilesChanged(string gameRoot, IReadOnlyDictionary<string, string> saved)
	{
		ArgumentNullException.ThrowIfNull((object)saved, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RE());
		if (((System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, string>>)saved).Count == 0)
		{
			return false;
		}
		Dictionary<string, string> now = StampsOf(gameRoot, saved.Keys);
		return Enumerable.Any<KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)saved, (Func<KeyValuePair<string, string>, bool>)((KeyValuePair<string, string> P_0) => now[P_0.Key] != P_0.Value));
	}
}
