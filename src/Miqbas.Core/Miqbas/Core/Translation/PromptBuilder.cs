using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;

namespace Miqbas.Core.Translation;

public static class PromptBuilder
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<TranslationUnit, bool> _003C_003E9__0_0;

		public static Func<TranslationUnit, bool> _003C_003E9__0_1;

		public static Func<TranslationUnit, bool> _003C_003E9__0_2;

		public static Func<TranslationUnit, TextType> _003C_003E9__1_0;

		public static Func<TranslationUnit, bool> _003C_003E9__1_1;

		public static Func<QualityIssue, string> _003C_003E9__1_2;

		public static Func<TranslationUnit, CharacterCard> _003C_003E9__3_0;

		public static Func<CharacterCard, bool> _003C_003E9__3_1;

		public static Func<CharacterCard, string> _003C_003E9__3_2;

		internal bool A(TranslationUnit P_0)
		{
			return ScriptWeight.IsMostlyCjk(P_0.Source.Value);
		}

		internal bool a(TranslationUnit P_0)
		{
			return ((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)P_0.PreviousRefusals).Count > 0;
		}

		internal bool B(TranslationUnit P_0)
		{
			return P_0.UnderReview != null;
		}

		internal TextType b(TranslationUnit P_0)
		{
			return P_0.Source.TextType;
		}

		internal bool C(TranslationUnit P_0)
		{
			return P_0.UnderReview != null;
		}

		internal string A(QualityIssue P_0)
		{
			return P_0.Message;
		}

		internal CharacterCard c(TranslationUnit P_0)
		{
			return P_0.Speaker;
		}

		internal bool A(CharacterCard P_0)
		{
			if ((object)P_0 != null)
			{
				if (P_0.Gender == Gender.Unknown && P_0.AddresseeGender == Gender.Unknown)
				{
					return P_0.Tone != null;
				}
				return true;
			}
			return false;
		}

		internal string a(CharacterCard P_0)
		{
			return P_0.Name;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public bool locked;

		internal bool A(GlossaryEntry P_0)
		{
			return P_0.Locked == locked;
		}
	}

	public static string BuildSystemPrompt(TranslationBatch batch)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		StyleProfile style = batch.Style;
		StringBuilder val = new StringBuilder();
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cp());
		val.AppendLine();
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cQ());
		StringBuilder val2 = val;
		StringBuilder obj = val2;
		AppendInterpolatedStringHandler val3 = default(AppendInterpolatedStringHandler);
		((AppendInterpolatedStringHandler)(ref val3))._002Ector(25, 1, val2);
		((AppendInterpolatedStringHandler)(ref val3)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cq());
		((AppendInterpolatedStringHandler)(ref val3)).AppendFormatted(style.RegisterInstruction);
		((AppendInterpolatedStringHandler)(ref val3)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cR());
		obj.AppendLine(ref val3);
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cr());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cS());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cs());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cT());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ct());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cU());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cu());
		string text;
		if (((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)batch.Units).Count <= 0 || !Enumerable.All<TranslationUnit>((System.Collections.Generic.IEnumerable<TranslationUnit>)batch.Units, (Func<TranslationUnit, bool>)((TranslationUnit P_0) => ScriptWeight.IsMostlyCjk(P_0.Source.Value))))
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(97, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cV());
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)((style.MaxLengthRatio - 1.0) * 100.0));
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cv());
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			text = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cW();
		}
		val.AppendLine(text);
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cw());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cX());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cx());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cY());
		val.AppendLine((style.Numerals == NumeralStyle.ArabicIndic) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cZ() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cy());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cz());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DA());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Da());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DB());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Db());
		val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DC());
		if (Enumerable.Any<TranslationUnit>((System.Collections.Generic.IEnumerable<TranslationUnit>)batch.Units, (Func<TranslationUnit, bool>)((TranslationUnit P_0) => ((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)P_0.PreviousRefusals).Count > 0)))
		{
			val.AppendLine();
			val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dc());
			val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DD());
		}
		if (Enumerable.Any<TranslationUnit>((System.Collections.Generic.IEnumerable<TranslationUnit>)batch.Units, (Func<TranslationUnit, bool>)((TranslationUnit P_0) => P_0.UnderReview != null)))
		{
			val.AppendLine();
			val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dd());
			val.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DE());
		}
		if (batch.GameContext != null)
		{
			val.AppendLine();
			val2 = val;
			StringBuilder obj2 = val2;
			((AppendInterpolatedStringHandler)(ref val3))._002Ector(13, 1, val2);
			((AppendInterpolatedStringHandler)(ref val3)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.De());
			((AppendInterpolatedStringHandler)(ref val3)).AppendFormatted(batch.GameContext);
			obj2.AppendLine(ref val3);
		}
		A(val, batch.Glossary);
		A(val, batch.Units);
		A(val);
		return ((object)val).ToString();
	}

	public static string BuildUserPrompt(TranslationBatch batch)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder();
		List<TextType> val2 = Enumerable.ToList<TextType>(Enumerable.Distinct<TextType>(Enumerable.Select<TranslationUnit, TextType>((System.Collections.Generic.IEnumerable<TranslationUnit>)batch.Units, (Func<TranslationUnit, TextType>)((TranslationUnit P_0) => P_0.Source.TextType))));
		bool flag = val2.Count == 1 && ((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)batch.Units).Count > 1;
		string text = (Enumerable.Any<TranslationUnit>((System.Collections.Generic.IEnumerable<TranslationUnit>)batch.Units, (Func<TranslationUnit, bool>)((TranslationUnit P_0) => P_0.UnderReview != null)) ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Df() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DF());
		AppendInterpolatedStringHandler val4 = default(AppendInterpolatedStringHandler);
		if (flag)
		{
			StringBuilder val3 = val;
			StringBuilder obj = val3;
			((AppendInterpolatedStringHandler)(ref val4))._002Ector(31, 2, val3);
			((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(text);
			((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DG());
			((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(A(val2[0]));
			obj.AppendLine(ref val4);
		}
		else
		{
			StringBuilder val3 = val;
			StringBuilder obj2 = val3;
			((AppendInterpolatedStringHandler)(ref val4))._002Ector(46, 1, val3);
			((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(text);
			((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dg());
			obj2.AppendLine(ref val4);
			Enumerator<TextType> enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TextType current = enumerator.Current;
					val3 = val;
					StringBuilder obj3 = val3;
					val4 = new AppendInterpolatedStringHandler(3, 2, val3);
					((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DH());
					((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(a(current));
					((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dh());
					((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(A(current));
					obj3.AppendLine(ref val4);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		val.AppendLine();
		for (int i = 0; i < ((System.Collections.Generic.IReadOnlyCollection<TranslationUnit>)batch.Units).Count; i++)
		{
			TranslationUnit translationUnit = batch.Units[i];
			string text2;
			if (!flag)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(7, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DI());
				defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Di());
				defaultInterpolatedStringHandler.AppendFormatted(a(translationUnit.Source.TextType));
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DJ());
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DI());
				defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
				text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			val.AppendLine(text2);
			int? room = translationUnit.Source.Room;
			StringBuilder val3;
			if (room.HasValue)
			{
				int valueOrDefault = room.GetValueOrDefault();
				val3 = val;
				StringBuilder obj4 = val3;
				((AppendInterpolatedStringHandler)(ref val4))._002Ector(35, 1, val3);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dj());
				((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted<int>(valueOrDefault);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DK());
				obj4.AppendLine(ref val4);
			}
			if ((object)translationUnit.Speaker != null)
			{
				val3 = val;
				StringBuilder obj5 = val3;
				((AppendInterpolatedStringHandler)(ref val4))._002Ector(9, 1, val3);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dk());
				((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(translationUnit.Speaker.Name);
				obj5.AppendLine(ref val4);
			}
			if (((System.Collections.Generic.IReadOnlyCollection<string>)translationUnit.NeighbouringLines).Count > 0)
			{
				val3 = val;
				StringBuilder obj6 = val3;
				((AppendInterpolatedStringHandler)(ref val4))._002Ector(13, 1, val3);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DL());
				((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dl(), (System.Collections.Generic.IEnumerable<string>)translationUnit.NeighbouringLines));
				obj6.AppendLine(ref val4);
			}
			string text3 = ReadableKey.Of(translationUnit.Source.Key);
			if (text3 != null)
			{
				val3 = val;
				StringBuilder obj7 = val3;
				((AppendInterpolatedStringHandler)(ref val4))._002Ector(18, 1, val3);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DM());
				((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(text3);
				obj7.AppendLine(ref val4);
			}
			if (((System.Collections.Generic.IReadOnlyCollection<QualityIssue>)translationUnit.PreviousRefusals).Count > 0)
			{
				val3 = val;
				StringBuilder obj8 = val3;
				((AppendInterpolatedStringHandler)(ref val4))._002Ector(18, 1, val3);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dm());
				((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DN(), Enumerable.Select<QualityIssue, string>((System.Collections.Generic.IEnumerable<QualityIssue>)translationUnit.PreviousRefusals, (Func<QualityIssue, string>)((QualityIssue P_0) => P_0.Message))));
				obj8.AppendLine(ref val4);
			}
			val3 = val;
			StringBuilder obj9 = val3;
			((AppendInterpolatedStringHandler)(ref val4))._002Ector(6, 1, val3);
			((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dn());
			((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(translationUnit.Masked.Masked);
			obj9.AppendLine(ref val4);
			string underReview = translationUnit.UnderReview;
			if (underReview != null)
			{
				val3 = val;
				StringBuilder obj10 = val3;
				((AppendInterpolatedStringHandler)(ref val4))._002Ector(16, 1, val3);
				((AppendInterpolatedStringHandler)(ref val4)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DO());
				((AppendInterpolatedStringHandler)(ref val4)).AppendFormatted(underReview);
				obj10.AppendLine(ref val4);
			}
		}
		return ((object)val).ToString();
	}

	private static void A(StringBuilder P_0, System.Collections.Generic.IReadOnlyList<GlossaryEntry> P_1)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)P_1).Count == 0)
		{
			return;
		}
		bool[] array = new bool[2] { true, false };
		foreach (bool locked in array)
		{
			List<GlossaryEntry> val = Enumerable.ToList<GlossaryEntry>(Enumerable.Where<GlossaryEntry>((System.Collections.Generic.IEnumerable<GlossaryEntry>)P_1, (Func<GlossaryEntry, bool>)((GlossaryEntry P_0) => P_0.Locked == locked)));
			if (val.Count == 0)
			{
				continue;
			}
			P_0.AppendLine();
			P_0.AppendLine(locked ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DP() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Do());
			Enumerator<GlossaryEntry> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					GlossaryEntry current = enumerator.Current;
					AppendInterpolatedStringHandler val2 = new AppendInterpolatedStringHandler(5, 2, P_0);
					((AppendInterpolatedStringHandler)(ref val2)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dp());
					((AppendInterpolatedStringHandler)(ref val2)).AppendFormatted(current.Term);
					((AppendInterpolatedStringHandler)(ref val2)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DQ());
					((AppendInterpolatedStringHandler)(ref val2)).AppendFormatted(current.Translation);
					P_0.AppendLine(ref val2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
	}

	private static void A(StringBuilder P_0, System.Collections.Generic.IReadOnlyList<TranslationUnit> P_1)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		List<CharacterCard> val = Enumerable.ToList<CharacterCard>(Enumerable.DistinctBy<CharacterCard, string>(Enumerable.Where<CharacterCard>(Enumerable.Select<TranslationUnit, CharacterCard>((System.Collections.Generic.IEnumerable<TranslationUnit>)P_1, (Func<TranslationUnit, CharacterCard>)((TranslationUnit P_0) => P_0.Speaker)), (Func<CharacterCard, bool>)((CharacterCard P_0) => (object)P_0 != null && (P_0.Gender != 0 || P_0.AddresseeGender != 0 || P_0.Tone != null))), (Func<CharacterCard, string>)((CharacterCard P_0) => P_0.Name)));
		if (val.Count == 0)
		{
			return;
		}
		P_0.AppendLine();
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dq());
		Enumerator<CharacterCard> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CharacterCard current = enumerator.Current;
				List<string> obj = new List<string>();
				obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DR() + A(current.Gender));
				List<string> val2 = obj;
				if (current.AddresseeGender != 0)
				{
					val2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dr() + A(current.AddresseeGender));
				}
				if (current.Tone != null)
				{
					val2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DS() + current.Tone);
				}
				AppendInterpolatedStringHandler val3 = new AppendInterpolatedStringHandler(5, 2, P_0);
				((AppendInterpolatedStringHandler)(ref val3)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dp());
				((AppendInterpolatedStringHandler)(ref val3)).AppendFormatted(current.Name);
				((AppendInterpolatedStringHandler)(ref val3)).AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ds());
				((AppendInterpolatedStringHandler)(ref val3)).AppendFormatted(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DT(), (System.Collections.Generic.IEnumerable<string>)val2));
				P_0.AppendLine(ref val3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	private static void A(StringBuilder P_0)
	{
		P_0.AppendLine();
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dt());
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DU());
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Du());
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DV());
		P_0.AppendLine();
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dv());
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DW());
		P_0.AppendLine(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dw());
	}

	private static string A(TextType P_0)
	{
		return P_0 switch
		{
			TextType.Dialogue => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DX(), 
			TextType.Choice => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dx(), 
			TextType.Ui => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DY(), 
			TextType.Item => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dy(), 
			TextType.Name => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DZ(), 
			TextType.System => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Dz(), 
			_ => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dA(), 
		};
	}

	private static string a(TextType P_0)
	{
		return P_0 switch
		{
			TextType.Dialogue => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.da(), 
			TextType.Choice => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dB(), 
			TextType.Ui => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.db(), 
			TextType.Item => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dC(), 
			TextType.Name => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dc(), 
			TextType.System => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dD(), 
			_ => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dd(), 
		};
	}

	private static string A(Gender P_0)
	{
		return P_0 switch
		{
			Gender.Male => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dE(), 
			Gender.Female => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.de(), 
			_ => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dF(), 
		};
	}
}
