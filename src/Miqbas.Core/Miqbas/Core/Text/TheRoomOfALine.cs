using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class TheRoomOfALine
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<char, bool> _003C_003E9__1_0;

		internal bool A(char P_0)
		{
			bool flag;
			switch (P_0)
			{
			case 'ـ':
			case '\u064b':
			case '\u064c':
			case '\u064d':
			case '\u064e':
			case '\u064f':
			case '\u0650':
			case '\u0651':
			case '\u0652':
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return !flag;
		}
	}

	private static readonly Regex NotDrawn = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iX(), (RegexOptions)512);

	public static int Letters(string text)
	{
		ArgumentNullException.ThrowIfNull((object)text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HT());
		return Enumerable.Count<char>((System.Collections.Generic.IEnumerable<char>)NotDrawn.Replace(text, string.Empty).Replace(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iW(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iw(), (StringComparison)4), (Func<char, bool>)delegate(char P_0)
		{
			bool flag;
			switch (P_0)
			{
			case 'ـ':
			case '\u064b':
			case '\u064c':
			case '\u064d':
			case '\u064e':
			case '\u064f':
			case '\u0650':
			case '\u0651':
			case '\u0652':
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return !flag;
		});
	}

	public static bool Fits(string text, int? room)
	{
		if (room.HasValue)
		{
			int valueOrDefault = room.GetValueOrDefault();
			return Letters(text) <= valueOrDefault;
		}
		return true;
	}
}
