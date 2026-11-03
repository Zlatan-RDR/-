using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Safety;

namespace Miqbas.Core.Text;

public static class WhatAReadingKeeps
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<SourceText, bool> _003C0_003E__Keeps;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<SourceText, bool> _003C_003E9__2_0;

		public static Func<SourceText, string> _003C_003E9__2_1;

		internal bool A(SourceText P_0)
		{
			return !string.IsNullOrWhiteSpace(P_0.Value);
		}

		internal string a(SourceText P_0)
		{
			return P_0.Value;
		}
	}

	public static LineVerdict Judge(SourceText text)
	{
		ArgumentNullException.ThrowIfNull((object)text, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HT());
		if (NotAGameFile.IsABackup(text.File) || NotAGameFile.IsABackup(FilePartOf(text.Key)))
		{
			return LineVerdict.FromABackupOfOurs;
		}
		NotTheSourceLanguage notTheSourceLanguage = SourceLanguage.Judge(text.Value, text.Context ?? FilePartOf(text.Key));
		if (text.InTheSourceLanguage && notTheSourceLanguage != NotTheSourceLanguage.AnotherScript)
		{
			return LineVerdict.Kept;
		}
		return notTheSourceLanguage switch
		{
			NotTheSourceLanguage.AnotherScript => LineVerdict.AnotherScript, 
			NotTheSourceLanguage.AContainerThatNamesItsLanguage => LineVerdict.AContainerThatNamesItsLanguage, 
			NotTheSourceLanguage.AnotherLatinLanguage => LineVerdict.AnotherLatinLanguage, 
			_ => LineVerdict.Kept, 
		};
	}

	public static bool Keeps(SourceText text)
	{
		return Judge(text) == LineVerdict.Kept;
	}

	public static IReadOnlySet<string> DistinctSentencesOf(System.Collections.Generic.IEnumerable<SourceText> lines)
	{
		ArgumentNullException.ThrowIfNull((object)lines, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.he());
		return (IReadOnlySet<string>)(object)Enumerable.ToHashSet<string>(Enumerable.Select<SourceText, string>(Enumerable.Where<SourceText>(Enumerable.Where<SourceText>(lines, (Func<SourceText, bool>)((SourceText P_0) => !string.IsNullOrWhiteSpace(P_0.Value))), (Func<SourceText, bool>)Keeps), (Func<SourceText, string>)((SourceText P_0) => P_0.Value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
	}

	public static string FilePartOf(string key)
	{
		int num = key.IndexOf('#', (StringComparison)4);
		if (num >= 0)
		{
			return key.Substring(0, num);
		}
		return key;
	}
}
