using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using A;

namespace Miqbas.Engines.Unity.Hooking;

public static class TheLoadersBuiltFiles
{
	internal sealed class A
	{
		[JsonPropertyName("gameRoot")]
		[field: CompilerGenerated]
		public string GameRoot
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		} = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.f();


		[JsonPropertyName("game")]
		[field: CompilerGenerated]
		public string Game
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		} = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.f();


		[JsonPropertyName("loader")]
		[field: CompilerGenerated]
		public string Loader
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		} = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.f();


		[JsonPropertyName("miqbas")]
		[field: CompilerGenerated]
		public string? Miqbas
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[JsonPropertyName("at")]
		[field: CompilerGenerated]
		public System.DateTime At
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[JsonPropertyName("files")]
		[field: CompilerGenerated]
		public Dictionary<string, string> Files
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		} = new Dictionary<string, string>();

	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, long> _003C_003E9__10_3;

		public static Func<string, ValueTuple<string, long, System.DateTime>> _003C_003E9__10_0;

		public static Func<ValueTuple<string, long, System.DateTime>, System.DateTime> _003C_003E9__10_1;

		public static Func<ValueTuple<string, long, System.DateTime>, long> _003C_003E9__10_2;

		public static Func<string, bool> _003C_003E9__11_1;

		internal ValueTuple<string, long, System.DateTime> A(string P_0)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, long, System.DateTime>(P_0, Enumerable.Sum<string>(Directory.EnumerateFiles(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1), (Func<string, long>)((string P_0) => new FileInfo(P_0).Length)), Directory.GetLastWriteTimeUtc(P_0));
		}

		internal long a(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return new FileInfo(P_0).Length;
		}

		internal System.DateTime A(ValueTuple<string, long, System.DateTime> k)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return k.Item3;
		}

		internal long a(ValueTuple<string, long, System.DateTime> k)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return k.Item2;
		}

		internal bool B(string P_0)
		{
			return P_0 != _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ah();
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string folder;

		internal string A(string P_0)
		{
			return Path.GetRelativePath(folder, P_0).Replace('\\', '/');
		}

		internal bool A(KeyValuePair<string, string> P_0)
		{
			return !string.Equals(B(Path.Combine(folder, P_0.Key)), P_0.Value, (StringComparison)4);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string bepinex;

		internal bool A(string P_0)
		{
			return Directory.Exists(Path.Combine(bepinex, P_0));
		}
	}

	public static readonly System.Collections.Generic.IReadOnlyList<string> Built = new B<string>(new string[3]
	{
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ak(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aL(),
		_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.al()
	});

	public const long MostBytes = 2147483648L;

	private const string ManifestName = "manifest.json";

	[field: CompilerGenerated]
	public static string Store
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = Path.Combine(Environment.GetFolderPath((SpecialFolder)28), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aM(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.am());


	public static bool Keep(string gameRoot, string? miqbasVersion = null)
	{
		try
		{
			string bepinex = Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH());
			string text = A(gameRoot);
			if (text != null)
			{
				string text2 = a(gameRoot);
				if (text2 != null && Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)Built, (Func<string, bool>)((string P_0) => Directory.Exists(Path.Combine(bepinex, P_0)))))
				{
					string text3 = a(text, text2);
					A(gameRoot, text3);
					if (Directory.Exists(text3))
					{
						Directory.Delete(text3, true);
					}
					Dictionary<string, string> val = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)Built).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							string current = enumerator.Current;
							string text4 = Path.Combine(bepinex, current);
							if (!Directory.Exists(text4))
							{
								continue;
							}
							System.Collections.Generic.IEnumerator<string> enumerator2 = Directory.EnumerateFiles(text4, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1).GetEnumerator();
							try
							{
								while (((System.Collections.IEnumerator)enumerator2).MoveNext())
								{
									string current2 = enumerator2.Current;
									string text5 = Path.GetRelativePath(bepinex, current2).Replace('\\', '/');
									string text6 = Path.Combine(text3, text5);
									Directory.CreateDirectory(Path.GetDirectoryName(text6));
									File.Copy(current2, text6, true);
									val[text5] = B(text6);
								}
							}
							finally
							{
								((System.IDisposable)enumerator2)?.Dispose();
							}
						}
					}
					finally
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
					A value = new A
					{
						GameRoot = Path.GetFullPath(gameRoot),
						Game = text,
						Loader = text2,
						Miqbas = miqbasVersion,
						At = System.DateTime.UtcNow,
						Files = val
					};
					File.WriteAllText(Path.Combine(text3, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ah()), JsonSerializer.Serialize(value, global::A.A.Default.Manifest));
					Settle(2147483648L);
					return true;
				}
			}
			return false;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException || ex is JsonException || ex is InvalidOperationException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	public static bool PutBack(string gameRoot)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		try
		{
			string text2 = A(gameRoot);
			if (text2 != null)
			{
				string text3 = TheLoadersBuiltFiles.a(gameRoot);
				if (text3 != null)
				{
					text = TheLoadersBuiltFiles.a(text2, text3);
					A(gameRoot, text);
					if (!Directory.Exists(text))
					{
						return false;
					}
					if (!A(text, text2, text3, out A a))
					{
						Directory.Delete(text, true);
						return false;
					}
					string fullPath = Path.GetFullPath(Path.Combine(gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH()));
					Enumerator<string, string> enumerator = a.Files.Keys.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							string fullPath2 = Path.GetFullPath(Path.Combine(fullPath, current));
							System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(fullPath);
							char directorySeparatorChar = Path.DirectorySeparatorChar;
							if (!fullPath2.StartsWith(string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref directorySeparatorChar)), (StringComparison)5))
							{
								Directory.Delete(text, true);
								return false;
							}
							Directory.CreateDirectory(Path.GetDirectoryName(fullPath2));
							File.Copy(Path.Combine(text, current), fullPath2, true);
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					Directory.SetLastWriteTimeUtc(text, System.DateTime.UtcNow);
					return true;
				}
			}
			return false;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException || ex is JsonException || ex is InvalidOperationException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			b(text);
			return false;
		}
	}

	public static void Forget(string gameRoot)
	{
		A(gameRoot, null);
	}

	public static void Settle(long mostBytes = 2147483648L)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		if (!Directory.Exists(Store))
		{
			return;
		}
		List<ValueTuple<string, long, System.DateTime>> obj = Enumerable.ToList<ValueTuple<string, long, System.DateTime>>((System.Collections.Generic.IEnumerable<ValueTuple<string, long, System.DateTime>>)Enumerable.OrderBy<ValueTuple<string, long, System.DateTime>, System.DateTime>(Enumerable.Select<string, ValueTuple<string, long, System.DateTime>>(Directory.EnumerateDirectories(Store), (Func<string, ValueTuple<string, long, System.DateTime>>)((string P_0) => new ValueTuple<string, long, System.DateTime>(P_0, Enumerable.Sum<string>(Directory.EnumerateFiles(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1), (Func<string, long>)((string P_0) => new FileInfo(P_0).Length)), Directory.GetLastWriteTimeUtc(P_0)))), (Func<ValueTuple<string, long, System.DateTime>, System.DateTime>)((ValueTuple<string, long, System.DateTime> k) => k.Item3)));
		long num = Enumerable.Sum<ValueTuple<string, long, System.DateTime>>((System.Collections.Generic.IEnumerable<ValueTuple<string, long, System.DateTime>>)obj, (Func<ValueTuple<string, long, System.DateTime>, long>)((ValueTuple<string, long, System.DateTime> k) => k.Item2));
		Enumerator<ValueTuple<string, long, System.DateTime>> enumerator = obj.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ValueTuple<string, long, System.DateTime> current = enumerator.Current;
				if (num <= mostBytes)
				{
					break;
				}
				b(current.Item1);
				num -= current.Item2;
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private static bool A(string P_0, string P_1, string P_2, out A P_3)
	{
		string folder = P_0;
		P_3 = null;
		string text = Path.Combine(folder, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ah());
		if (File.Exists(text))
		{
			A a = JsonSerializer.Deserialize(File.ReadAllText(text), global::A.A.Default.Manifest);
			if (a != null && !(a.Game != P_1) && !(a.Loader != P_2) && a.Files != null)
			{
				if (!Enumerable.ToHashSet<string>(Enumerable.Where<string>(Enumerable.Select<string, string>(Directory.EnumerateFiles(folder, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.m(), (SearchOption)1), (Func<string, string>)((string P_0) => Path.GetRelativePath(folder, P_0).Replace('\\', '/'))), (Func<string, bool>)((string P_0) => P_0 != _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ah())), (IEqualityComparer<string>)(object)StringComparer.Ordinal).SetEquals((System.Collections.Generic.IEnumerable<string>)a.Files.Keys) || Enumerable.Any<KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)a.Files, (Func<KeyValuePair<string, string>, bool>)((KeyValuePair<string, string> P_0) => !string.Equals(B(Path.Combine(folder, P_0.Key)), P_0.Value, (StringComparison)4))))
				{
					return false;
				}
				P_3 = a;
				return true;
			}
		}
		return false;
	}

	private static void A(string P_0, string? keep)
	{
		if (!Directory.Exists(Store))
		{
			return;
		}
		string fullPath = Path.GetFullPath(P_0);
		System.Collections.Generic.IEnumerator<string> enumerator = Directory.EnumerateDirectories(Store).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				if (keep != null && string.Equals(Path.GetFullPath(current), Path.GetFullPath(keep), (StringComparison)5))
				{
					continue;
				}
				try
				{
					string text = Path.Combine(current, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ah());
					if (File.Exists(text))
					{
						A a = JsonSerializer.Deserialize(File.ReadAllText(text), global::A.A.Default.Manifest);
						if (a != null && string.Equals(a.GameRoot, fullPath, (StringComparison)5))
						{
							b(current);
						}
					}
				}
				catch (System.Exception ex) when (((ex is IOException || ex is JsonException || ex is InvalidOperationException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					b(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static string? A(string P_0)
	{
		string text = Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aI());
		string text2 = (Directory.Exists(P_0) ? Enumerable.FirstOrDefault<string>(Directory.EnumerateFiles(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ai(), (SearchOption)1)) : null);
		if (!File.Exists(text) || text2 == null)
		{
			return null;
		}
		return B(text) + B(text2);
	}

	private static string? a(string P_0)
	{
		string text = Path.Combine(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aJ()), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aj());
		if (!File.Exists(text))
		{
			return null;
		}
		return B(text);
	}

	private static string a(string P_0, string P_1)
	{
		return Path.Combine(Store, Convert.ToHexString(SHA256.HashData(Encoding.ASCII.GetBytes(P_0 + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aK() + P_1))).Substring(0, 32));
	}

	private static string B(string P_0)
	{
		FileStream val = File.OpenRead(P_0);
		try
		{
			return Convert.ToHexString(SHA256.HashData((Stream)(object)val));
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static void b(string? P_0)
	{
		try
		{
			if (P_0 != null && Directory.Exists(P_0))
			{
				Directory.Delete(P_0, true);
			}
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
		}
	}
}
