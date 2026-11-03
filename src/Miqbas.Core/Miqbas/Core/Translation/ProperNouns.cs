using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Translation;

public static class ProperNouns
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<char, bool> _003C_003E9__5_0;

		public static Func<char, bool> _003C_003E9__6_0;

		internal bool A(char P_0)
		{
			switch (P_0)
			{
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
				return true;
			default:
				return false;
			}
		}

		internal bool a(char P_0)
		{
			if (P_0 >= '\u0600')
			{
				return P_0 <= 'ۿ';
			}
			return false;
		}
	}

	private static readonly HashSet<string> TooCommonToLock;

	[field: CompilerGenerated]
	public static System.Collections.Generic.IReadOnlyList<GlossaryEntry> Gaming
	{
		[CompilerGenerated]
		get;
	} = new K<GlossaryEntry>(new GlossaryEntry[7]
	{
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.df(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dG(),
			Kind = GlossaryKind.Item,
			Locked = false
		},
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dg(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dH(),
			Kind = GlossaryKind.Item,
			Locked = false
		},
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dh(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dI(),
			Kind = GlossaryKind.Item,
			Locked = false
		},
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.di(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dJ(),
			Kind = GlossaryKind.Item
		},
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dj(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dj(),
			Kind = GlossaryKind.Abbreviation
		},
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dK(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dK(),
			Kind = GlossaryKind.Abbreviation
		},
		new GlossaryEntry
		{
			Term = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dk(),
			Translation = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dk(),
			Kind = GlossaryKind.Abbreviation
		}
	});


	public static System.Collections.Generic.IReadOnlyList<GlossaryEntry> ForGameNamed(string? gameName)
	{
		string text = gameName?.Trim();
		if (text == null || text.Length <= 2 || !A(text) || a(text))
		{
			return Gaming;
		}
		char[] array = new char[3];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		string[] array2 = text.Split(array, (StringSplitOptions)3);
		if (array2.Length != 0)
		{
			HashSet<string> tooCommonToLock = TooCommonToLock;
			if (!Enumerable.All<string>((System.Collections.Generic.IEnumerable<string>)array2, (Func<string, bool>)tooCommonToLock.Contains))
			{
				GlossaryEntry glossaryEntry = new GlossaryEntry
				{
					Term = text,
					Translation = text,
					Kind = GlossaryKind.Name,
					Locked = true
				};
				System.Collections.Generic.IReadOnlyList<GlossaryEntry> gaming = Gaming;
				int num = 0;
				GlossaryEntry[] array3 = new GlossaryEntry[1 + ((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)gaming).Count];
				array3[num] = glossaryEntry;
				num++;
				System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)gaming).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						GlossaryEntry current = enumerator.Current;
						array3[num] = current;
						num++;
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
				return new K<GlossaryEntry>(array3);
			}
		}
		return Gaming;
	}

	private static bool A(string P_0)
	{
		return Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)delegate(char P_0)
		{
			switch (P_0)
			{
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
				return true;
			default:
				return false;
			}
		});
	}

	private static bool a(string P_0)
	{
		return Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, bool>)((char P_0) => P_0 >= '\u0600' && P_0 <= 'ۿ'));
	}

	static ProperNouns()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dL());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aS());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dl());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dM());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bt());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dm());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dN());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dn());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bM());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dO());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.By());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@do());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dP());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dp());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dQ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dq());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dR());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dr());
		TooCommonToLock = obj;
	}
}
