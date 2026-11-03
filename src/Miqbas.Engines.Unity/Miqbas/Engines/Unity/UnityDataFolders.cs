using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using A;

namespace Miqbas.Engines.Unity;

public static class UnityDataFolders
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, ValueTuple<string, string>> _003C_003E9__0_0;

		public static Func<ValueTuple<string, string>, bool> _003C_003E9__0_1;

		public static Func<ValueTuple<string, string>, bool> _003C_003E9__0_2;

		public static Func<ValueTuple<string, string>, int> _003C_003E9__0_3;

		public static Func<ValueTuple<string, string>, string> _003C_003E9__0_4;

		public static Func<ValueTuple<string, string>, string> _003C_003E9__0_5;

		internal ValueTuple<string, string> A(string P_0)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string>(P_0, UnityDataFolders.A(P_0));
		}

		internal bool A(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return f.Item2 != null;
		}

		internal bool a(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			if (f.Item2 != null)
			{
				return UnityDataFolders.a(f.Item2);
			}
			return false;
		}

		internal int B(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return Path.GetFileName(f.Item1).Length;
		}

		internal string b(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return Path.GetFileName(f.Item1);
		}

		internal string C(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return f.Item1;
		}

		internal string A()
		{
			return Path.Combine(Environment.GetFolderPath((SpecialFolder)40), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cf(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CG());
		}
	}

	[field: CompilerGenerated]
	public static Func<string> LocalLow
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = () => Path.Combine(Environment.GetFolderPath((SpecialFolder)40), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cf(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CG());


	public static System.Collections.Generic.IReadOnlyList<string> InOrder(string gameRoot)
	{
		string[] array;
		try
		{
			array = (Directory.Exists(gameRoot) ? Directory.GetDirectories(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.k(), (SearchOption)0) : System.Array.Empty<string>());
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return System.Array.Empty<string>();
		}
		if (array.Length < 2)
		{
			return array;
		}
		List<string> obj = new List<string>();
		obj.AddRange(Enumerable.Select<ValueTuple<string, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)Enumerable.ThenBy<ValueTuple<string, string>, string>(Enumerable.ThenBy<ValueTuple<string, string>, int>(Enumerable.ThenByDescending<ValueTuple<string, string>, bool>(Enumerable.OrderByDescending<ValueTuple<string, string>, bool>(Enumerable.Select<string, ValueTuple<string, string>>((System.Collections.Generic.IEnumerable<string>)array, (Func<string, ValueTuple<string, string>>)((string P_0) => new ValueTuple<string, string>(P_0, A(P_0)))), (Func<ValueTuple<string, string>, bool>)((ValueTuple<string, string> f) => f.Item2 != null)), (Func<ValueTuple<string, string>, bool>)((ValueTuple<string, string> f) => f.Item2 != null && a(f.Item2))), (Func<ValueTuple<string, string>, int>)((ValueTuple<string, string> f) => Path.GetFileName(f.Item1).Length)), (Func<ValueTuple<string, string>, string>)((ValueTuple<string, string> f) => Path.GetFileName(f.Item1)), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase), (Func<ValueTuple<string, string>, string>)((ValueTuple<string, string> f) => f.Item1)));
		return new b<string>(obj);
	}

	public static string? Main(string gameRoot)
	{
		return Enumerable.FirstOrDefault<string>((System.Collections.Generic.IEnumerable<string>)InOrder(gameRoot));
	}

	public static string? PersistentFolderOf(string gameRoot)
	{
		if (!Directory.Exists(gameRoot))
		{
			return null;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)InOrder(gameRoot)).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string text = Path.Combine(enumerator.Current, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.L());
				if (File.Exists(text))
				{
					string[] array = File.ReadAllLines(text);
					if (array.Length >= 2 && array[0].Trim().Length != 0 && array[1].Trim().Length != 0)
					{
						string text2 = Path.Combine(LocalLow.Invoke(), array[0].Trim(), array[1].Trim());
						return Directory.Exists(text2) ? text2 : null;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	private static string? A(string P_0)
	{
		string fileName = Path.GetFileName(P_0);
		string obj = Path.GetDirectoryName(P_0) ?? string.Empty;
		string text = fileName;
		int length = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.l().Length;
		string text2 = Path.Combine(obj, text.Substring(0, text.Length - length) + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.M());
		if (!File.Exists(text2))
		{
			return null;
		}
		return text2;
	}

	internal static bool a(string P_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		try
		{
			FileStream val = File.OpenRead(P_0);
			try
			{
				BinaryReader val2 = new BinaryReader((Stream)(object)val);
				try
				{
					if (((Stream)val).Length < 64 || val2.ReadUInt16() != 23117)
					{
						return false;
					}
					((Stream)val).Position = 60L;
					int num = val2.ReadInt32();
					if (num < 0 || num + 6 > ((Stream)val).Length)
					{
						return false;
					}
					((Stream)val).Position = num;
					if (val2.ReadUInt32() != 17744)
					{
						return false;
					}
					ushort num2 = val2.ReadUInt16();
					return (num2 == 34404 || num2 == 43620) ? true : false;
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
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return false;
		}
	}
}
