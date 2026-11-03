using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Localization;

public static class TextWeCanSeeButCannotRead
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, bool> _003C0_003E__Exists;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, string> _003C_003E9__2_0;

		public static Func<string, bool> _003C_003E9__2_1;

		public static Func<string, bool> _003C_003E9__2_2;

		internal string A(string P_0)
		{
			return Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bq());
		}

		internal bool a(string P_0)
		{
			return Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)ClosedKinds, Path.GetExtension(P_0), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		}

		internal bool B(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return new FileInfo(P_0).Length > 0;
		}
	}

	private static readonly string[] FoldersThatHoldText = new string[9]
	{
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.O(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.o(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.P(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.p(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Q(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.q(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.R(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.r(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.S()
	};

	private static readonly string[] ClosedKinds = new string[6]
	{
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.s(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.T(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.t(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.U(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.u(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.V()
	};

	internal const int EnoughToBeAGame = 200;

	public static System.Collections.Generic.IReadOnlyList<string> In(string gameRoot)
	{
		if (string.IsNullOrWhiteSpace(gameRoot) || !Directory.Exists(gameRoot))
		{
			return System.Array.Empty<string>();
		}
		List<string> val = new List<string>();
		try
		{
			string text = Enumerable.FirstOrDefault<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)UnityDataFolders.InOrder(gameRoot), (Func<string, string>)((string P_0) => Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bq()))), (Func<string, bool>)Directory.Exists);
			if (text == null)
			{
				return (System.Collections.Generic.IReadOnlyList<string>)val;
			}
			System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateDirectories(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					if (Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)FoldersThatHoldText, Path.GetFileName(current), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))
					{
						val.AddRange(Enumerable.Where<string>(Enumerable.Where<string>(Directory.EnumerateFiles(current, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1), (Func<string, bool>)((string P_0) => Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)ClosedKinds, Path.GetExtension(P_0), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))), (Func<string, bool>)((string P_0) => new FileInfo(P_0).Length > 0)));
					}
				}
				return (System.Collections.Generic.IReadOnlyList<string>)val;
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return (System.Collections.Generic.IReadOnlyList<string>)val;
		}
	}

	public static string? WhatToTell(string gameRoot, int linesRead)
	{
		if (linesRead >= 200)
		{
			return null;
		}
		System.Collections.Generic.IReadOnlyList<string> readOnlyList = In(gameRoot);
		if (readOnlyList == null || ((System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count <= 0)
		{
			return null;
		}
		string fileName = Path.GetFileName(readOnlyList[0]);
		return _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.N() + fileName + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.n();
	}
}
