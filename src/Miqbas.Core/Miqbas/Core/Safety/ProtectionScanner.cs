using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Engines;

namespace Miqbas.Core.Safety;

public static class ProtectionScanner
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ProtectionSystem, System.Collections.Generic.IEnumerable<string>> _003C_003E9__3_1;

		public static Func<string, bool> _003C_003E9__3_3;

		public static Func<ProtectionSystem, bool> _003C_003E9__3_4;

		internal System.Collections.Generic.IEnumerable<string> A(ProtectionSystem P_0)
		{
			return (System.Collections.Generic.IEnumerable<string>)P_0.Markers;
		}

		internal bool A(string P_0)
		{
			return P_0.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rZ(), (StringComparison)5);
		}

		internal bool a(ProtectionSystem P_0)
		{
			return P_0.Id != EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jO();
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public HashSet<string> names;

		public HashSet<string> claimed;

		internal bool A(ProtectionSystem P_0)
		{
			System.Collections.Generic.IReadOnlyList<string> markers = P_0.Markers;
			HashSet<string> obj = names;
			return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)markers, (Func<string, bool>)obj.Contains);
		}

		internal bool A(string P_0)
		{
			if (P_0.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rz(), (StringComparison)5))
			{
				return !claimed.Contains(P_0);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public ProtectionSystem system;

		internal bool A(ProtectionSystem P_0)
		{
			return P_0.Id != system.Id;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public string id;

		internal bool A(ProtectionSystem P_0)
		{
			return P_0.Id == id;
		}
	}

	[CompilerGenerated]
	private sealed class C : System.Collections.Generic.IEnumerable<ProtectionSystem>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<ProtectionSystem>, System.Collections.IEnumerator, System.IDisposable
	{
		private int _003C_003E1__state;

		private ProtectionSystem _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private System.Collections.Generic.IReadOnlyList<string> files;

		public System.Collections.Generic.IReadOnlyList<string> _003C_003E3__files;

		private System.Collections.Generic.IReadOnlyList<ProtectionSystem> systems;

		public System.Collections.Generic.IReadOnlyList<ProtectionSystem> _003C_003E3__systems;

		private Enumerator<string, List<string>> _003C_003E7__wrap1;

		ProtectionSystem System.Collections.Generic.IEnumerator<ProtectionSystem>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public C(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					a();
				}
			}
		}

		void System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				string current2 = default(string);
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
				{
					_003C_003E1__state = -1;
					FileNameRules steamDbAntiCheats = FileNameRules.SteamDbAntiCheats;
					Dictionary<string, List<string>> val = new Dictionary<string, List<string>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)files).GetEnumerator();
					try
					{
						List<string> val2 = default(List<string>);
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							string current = enumerator.Current;
							System.Collections.Generic.IEnumerator<string> enumerator2 = ((System.Collections.Generic.IEnumerable<string>)steamDbAntiCheats.RulesMatching(current)).GetEnumerator();
							try
							{
								while (((System.Collections.IEnumerator)enumerator2).MoveNext())
								{
									current2 = enumerator2.Current;
									int length = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW().Length;
									string text = current2.Substring(length, current2.Length - length);
									if (!val.TryGetValue(text, ref val2))
									{
										val2 = (val[text] = new List<string>());
									}
									val2.Add(Path.GetFileName(current));
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
					_003C_003E7__wrap1 = val.GetEnumerator();
					_003C_003E1__state = -3;
					break;
				}
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				if (_003C_003E7__wrap1.MoveNext())
				{
					List<string> val4 = default(List<string>);
					_003C_003E7__wrap1.Current.Deconstruct(ref current2, ref val4);
					string text2 = current2;
					List<string> val5 = val4;
					b CS_0024_003C_003E8__locals0 = new b();
					ProtectionSystem protectionSystem = (SteamDbNamesWeKnow.TryGetValue(text2, ref CS_0024_003C_003E8__locals0.id) ? Enumerable.FirstOrDefault<ProtectionSystem>((System.Collections.Generic.IEnumerable<ProtectionSystem>)systems, (Func<ProtectionSystem, bool>)((ProtectionSystem P_0) => P_0.Id == CS_0024_003C_003E8__locals0.id)) : null);
					_003C_003E2__current = protectionSystem ?? new ProtectionSystem
					{
						Id = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SA() + text2.ToLowerInvariant(),
						DisplayName = (CollectionExtensions.GetValueOrDefault<string, string>((IReadOnlyDictionary<string, string>)(object)DisplayNames, text2) ?? text2.Replace('_', ' ')),
						Kind = ProtectionKind.AntiCheat,
						Markers = (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Distinct<string>((System.Collections.Generic.IEnumerable<string>)val5, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))
					};
					_003C_003E1__state = 1;
					return true;
				}
				a();
				_003C_003E7__wrap1 = default(Enumerator<string, List<string>>);
				return false;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			((System.IDisposable)_003C_003E7__wrap1).Dispose();
		}

		[DebuggerHidden]
		private void B()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			this.B();
		}

		[DebuggerHidden]
		private System.Collections.Generic.IEnumerator<ProtectionSystem> b()
		{
			C c;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				c = this;
			}
			else
			{
				c = new C(0);
			}
			c.files = _003C_003E3__files;
			c.systems = _003C_003E3__systems;
			return c;
		}

		System.Collections.Generic.IEnumerator<ProtectionSystem> System.Collections.Generic.IEnumerable<ProtectionSystem>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}

		[DebuggerHidden]
		private System.Collections.IEnumerator C()
		{
			return (System.Collections.IEnumerator)b();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			return this.C();
		}
	}

	private const int MaxDepth = 4;

	private static readonly string[] AlwaysLookInside = new string[4]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ji(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jJ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jj(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jK()
	};

	private static readonly Dictionary<string, string> SteamDbNamesWeKnow = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal)
	{
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jk()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jL(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jl()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jM(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jm()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jN(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jn()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jO(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jo()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jP()
	};

	private static readonly Dictionary<string, string> DisplayNames = new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal)
	{
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jp()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jQ(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jq()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jR(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jr()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jS(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.js()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jT(),
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jt()] = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jU()
	};

	public static ProtectionScanResult Scan(string gameRoot)
	{
		return A(gameRoot, KnownProtectionSystems.All);
	}

	internal static ProtectionScanResult A(string P_0, System.Collections.Generic.IReadOnlyList<ProtectionSystem> P_1)
	{
		if (!Directory.Exists(P_0))
		{
			return new ProtectionScanResult
			{
				Found = System.Array.Empty<ProtectionSystem>()
			};
		}
		HashSet<string> names = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		List<string> val = new List<string>();
		A(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y(), 4, names, val);
		List<ProtectionSystem> val2 = Enumerable.ToList<ProtectionSystem>(Enumerable.Where<ProtectionSystem>((System.Collections.Generic.IEnumerable<ProtectionSystem>)P_1, (Func<ProtectionSystem, bool>)delegate(ProtectionSystem P_0)
		{
			System.Collections.Generic.IReadOnlyList<string> markers = P_0.Markers;
			HashSet<string> obj = names;
			return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)markers, (Func<string, bool>)obj.Contains);
		}));
		System.Collections.Generic.IEnumerator<ProtectionSystem> enumerator = A((System.Collections.Generic.IReadOnlyList<string>)val, P_1).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ProtectionSystem system = enumerator.Current;
				if (Enumerable.All<ProtectionSystem>((System.Collections.Generic.IEnumerable<ProtectionSystem>)val2, (Func<ProtectionSystem, bool>)((ProtectionSystem P_0) => P_0.Id != system.Id)))
				{
					val2.Add(system);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		HashSet<string> claimed = Enumerable.ToHashSet<string>(Enumerable.SelectMany<ProtectionSystem, string>((System.Collections.Generic.IEnumerable<ProtectionSystem>)val2, (Func<ProtectionSystem, System.Collections.Generic.IEnumerable<string>>)((ProtectionSystem P_0) => (System.Collections.Generic.IEnumerable<string>)P_0.Markers)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		if (Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)names, (Func<string, bool>)((string P_0) => P_0.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rz(), (StringComparison)5) && !claimed.Contains(P_0))))
		{
			val2.Add(KnownProtectionSystems.UnnamedDriver);
		}
		if (Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)names, (Func<string, bool>)((string P_0) => P_0.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rZ(), (StringComparison)5))) && Enumerable.All<ProtectionSystem>((System.Collections.Generic.IEnumerable<ProtectionSystem>)val2, (Func<ProtectionSystem, bool>)((ProtectionSystem P_0) => P_0.Id != EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jO())))
		{
			val2.Add(KnownProtectionSystems.Xigncode);
		}
		return new ProtectionScanResult
		{
			Found = (System.Collections.Generic.IReadOnlyList<ProtectionSystem>)val2
		};
	}

	[IteratorStateMachine(typeof(C))]
	private static System.Collections.Generic.IEnumerable<ProtectionSystem> A(System.Collections.Generic.IReadOnlyList<string> P_0, System.Collections.Generic.IReadOnlyList<ProtectionSystem> P_1)
	{
		FileNameRules steamDbAntiCheats = FileNameRules.SteamDbAntiCheats;
		Dictionary<string, List<string>> val = new Dictionary<string, List<string>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)P_0).GetEnumerator();
		string current2 = default(string);
		try
		{
			List<string> val2 = default(List<string>);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				System.Collections.Generic.IEnumerator<string> enumerator2 = ((System.Collections.Generic.IEnumerable<string>)steamDbAntiCheats.RulesMatching(current)).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						current2 = enumerator2.Current;
						int length = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.nW().Length;
						string text = current2.Substring(length, current2.Length - length);
						if (!val.TryGetValue(text, ref val2))
						{
							val2 = (val[text] = new List<string>());
						}
						val2.Add(Path.GetFileName(current));
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
		Enumerator<string, List<string>> enumerator3 = val.GetEnumerator();
		try
		{
			List<string> val4 = default(List<string>);
			string id = default(string);
			while (enumerator3.MoveNext())
			{
				enumerator3.Current.Deconstruct(ref current2, ref val4);
				string text2 = current2;
				List<string> val5 = val4;
				ProtectionSystem protectionSystem = (SteamDbNamesWeKnow.TryGetValue(text2, ref id) ? Enumerable.FirstOrDefault<ProtectionSystem>((System.Collections.Generic.IEnumerable<ProtectionSystem>)P_1, (Func<ProtectionSystem, bool>)((ProtectionSystem P_0) => P_0.Id == id)) : null);
				yield return protectionSystem ?? new ProtectionSystem
				{
					Id = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.SA() + text2.ToLowerInvariant(),
					DisplayName = (CollectionExtensions.GetValueOrDefault<string, string>((IReadOnlyDictionary<string, string>)(object)DisplayNames, text2) ?? text2.Replace('_', ' ')),
					Kind = ProtectionKind.AntiCheat,
					Markers = (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>(Enumerable.Distinct<string>((System.Collections.Generic.IEnumerable<string>)val5, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))
				};
			}
		}
		finally
		{
			((System.IDisposable)enumerator3).Dispose();
		}
	}

	private static void A(string P_0, string P_1, int P_2, HashSet<string> P_3, List<string> P_4)
	{
		System.Collections.Generic.IEnumerable<string> enumerable;
		try
		{
			enumerable = Directory.EnumerateFileSystemEntries(P_0);
		}
		catch (System.Exception ex) when (((ex is UnauthorizedAccessException || ex is DirectoryNotFoundException || ex is IOException) ? 1 : 0) != 0)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<string> enumerator = enumerable.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				P_3.Add(Path.GetFileName(current));
				string text = ((P_1.Length == 0) ? Path.GetFileName(current) : (P_1 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jI() + Path.GetFileName(current)));
				if (!Directory.Exists(current))
				{
					P_4.Add(text);
					continue;
				}
				string fileName = Path.GetFileName(current);
				int num = (Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)AlwaysLookInside, fileName, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase) ? Math.Max(P_2, 3) : (P_2 - 1));
				if (num > 0)
				{
					A(current, text, num, P_3, P_4);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
