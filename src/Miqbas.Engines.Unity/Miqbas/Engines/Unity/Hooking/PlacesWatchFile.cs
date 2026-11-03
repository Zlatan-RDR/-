using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using Miqbas.Core.Booting;

namespace Miqbas.Engines.Unity.Hooking;

public static class PlacesWatchFile
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, ValueTuple<string, bool>> _003C_003E9__3_0;

		public static Func<string, ValueTuple<string, bool>> _003C_003E9__3_1;

		internal ValueTuple<string, bool> A(string P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, bool>(P_0, false);
		}

		internal ValueTuple<string, bool> a(string P_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, bool>(P_0, true);
		}
	}

	public const string WatchFileName = "places-watch.txt";

	public const string SeenFileName = "places-seen.txt";

	public const int MostFingerprints = 200000;

	public static bool Write(string gameRoot, System.Collections.Generic.IReadOnlyList<ValueTuple<System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>>> places)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)places, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Y());
		string text = UnityHook.WorkDirectoryIn(gameRoot);
		if (((System.Collections.Generic.IReadOnlyCollection<ValueTuple<System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>>>)places).Count == 0 || !Directory.Exists(text))
		{
			return false;
		}
		StringBuilder val = new StringBuilder();
		int num = 0;
		for (int i = 0; i < ((System.Collections.Generic.IReadOnlyCollection<ValueTuple<System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>>>)places).Count; i++)
		{
			System.Collections.Generic.IEnumerator<ValueTuple<string, bool>> enumerator = Enumerable.Concat<ValueTuple<string, bool>>(Enumerable.Select<string, ValueTuple<string, bool>>(places[i].Item1, (Func<string, ValueTuple<string, bool>>)((string P_0) => new ValueTuple<string, bool>(P_0, false))), Enumerable.Select<string, ValueTuple<string, bool>>(places[i].Item2, (Func<string, ValueTuple<string, bool>>)((string P_0) => new ValueTuple<string, bool>(P_0, true)))).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ValueTuple<string, bool> current = enumerator.Current;
					string item = current.Item1;
					bool item2 = current.Item2;
					if (!string.IsNullOrEmpty(item) && num < 200000)
					{
						val.Append(i.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture)).Append('\t').Append(LineFingerprint.Of(item).ToString(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.y(), (IFormatProvider)(object)CultureInfo.InvariantCulture))
							.Append('\t')
							.Append(item2 ? 'a' : 'e')
							.Append('\n');
						num++;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		try
		{
			File.Delete(Path.Combine(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Z()));
			File.WriteAllText(Path.Combine(text, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.z()), ((object)val).ToString(), (Encoding)new UTF8Encoding(false));
			return true;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	public static IReadOnlyDictionary<int, PlaceOnScreen> ReadSeen(string gameRoot)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<int, PlaceOnScreen> val = new Dictionary<int, PlaceOnScreen>();
		string[] array;
		try
		{
			string text = Path.Combine(UnityHook.WorkDirectoryIn(gameRoot), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Z());
			if (!File.Exists(text) || new FileInfo(text).Length > 1048576)
			{
				return (IReadOnlyDictionary<int, PlaceOnScreen>)(object)val;
			}
			array = File.ReadAllLines(text);
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return (IReadOnlyDictionary<int, PlaceOnScreen>)(object)val;
		}
		string[] array2 = array;
		int num = default(int);
		for (int i = 0; i < array2.Length; i++)
		{
			string[] array3 = array2[i].Split('\t', (StringSplitOptions)0);
			if (array3.Length == 5 && int.TryParse(array3[0], (NumberStyles)0, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref num) && A(array3[1], out var num2) && A(array3[2], out var num3) && A(array3[3], out var num4))
			{
				string text2 = array3[4].Trim();
				int num5 = num;
				int english = num2;
				int arabic = num3;
				int missingLetters = Math.Min(num4, num3);
				int length = text2.Length;
				val[num5] = new PlaceOnScreen(english, arabic, missingLetters, (length > 0 && length <= 120) ? text2 : null);
			}
		}
		return (IReadOnlyDictionary<int, PlaceOnScreen>)(object)val;
	}

	public static void Clear(string gameRoot)
	{
		string text = UnityHook.WorkDirectoryIn(gameRoot);
		string[] array = new string[2]
		{
			_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.z(),
			_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Z()
		};
		foreach (string text2 in array)
		{
			try
			{
				File.Delete(Path.Combine(text, text2));
			}
			catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
			{
			}
		}
	}

	private static bool A(string P_0, out int P_1)
	{
		if (int.TryParse(P_0, (NumberStyles)0, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref P_1))
		{
			return P_1 <= 10000000;
		}
		return false;
	}
}
