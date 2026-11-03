using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using A;

namespace Miqbas.Core.Translation;

public static class ReadableKey
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<char, bool> _003C_003E9__2_0;

		internal bool A(char P_0)
		{
			bool flag = char.IsAsciiLetterOrDigit(P_0);
			if (!flag)
			{
				bool flag2 = ((P_0 == '-' || P_0 == '.' || P_0 == '_') ? true : false);
				flag = flag2;
			}
			return !flag;
		}
	}

	private const int LongestId = 64;

	[GeneratedRegex("[A-Z]?[a-z]{4,}")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex A()
	{
		return (Regex)(object)F.Instance;
	}

	public static string? Of(string? key)
	{
		if (string.IsNullOrWhiteSpace(key) || key.Length > 64)
		{
			return null;
		}
		if (Enumerable.Any<char>((System.Collections.Generic.IEnumerable<char>)key, (Func<char, bool>)delegate(char P_0)
		{
			bool flag = char.IsAsciiLetterOrDigit(P_0);
			if (!flag)
			{
				bool flag2 = ((P_0 == '-' || P_0 == '.' || P_0 == '_') ? true : false);
				flag = flag2;
			}
			return !flag;
		}))
		{
			return null;
		}
		if (!A().IsMatch(key))
		{
			return null;
		}
		return key;
	}
}
