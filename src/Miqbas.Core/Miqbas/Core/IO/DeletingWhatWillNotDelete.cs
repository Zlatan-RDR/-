using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.IO;

public static class DeletingWhatWillNotDelete
{
	public static void Delete(string path)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(path, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HU());
		if (Directory.Exists(path))
		{
			A(Directory.EnumerateFiles(path, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ju(), (SearchOption)1));
			Directory.Delete(path, true);
		}
		else if (File.Exists(path))
		{
			A(new L<string>(path));
			File.Delete(path);
		}
	}

	private static void A(System.Collections.Generic.IEnumerable<string> P_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<string> enumerator = P_0.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					FileAttributes attributes = File.GetAttributes(current);
					if ((attributes & 1) != 0)
					{
						File.SetAttributes(current, (FileAttributes)(attributes & -2));
					}
				}
				catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
				{
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
