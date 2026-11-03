using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public static class BootJudge
{
	public const string LookAndTellMe = "لعبتك أقلعت وتعمل. ولا أستطيع أن أرى شاشتها — انظر إليها وأخبرني: هل تقرأ العربية فيها، أم تظهر مرب\u0651عات فارغة؟";

	public const string EveryFontKeptForALanguage = "every font this game draws from was left alone rather than cost it a language: ";

	private const string NoCleanRunMessage = "شغ\u0651لت\u064f لعبتك، ولا أستطيع أن أحكم بنفسي: لم أقس تشغيلة\u064b نظيفة لها من قبل. انظر إليها وأخبرني — هل وصلت قائمتها، وهل تقرأ العربية فيها؟";

	private const string DidNotBootMessage = "لعبتك لم ت\u064fقلع بالتعريب — وقفت قبل أن تصل قائمتها. أعدت\u064f ملف\u0651اتها كما كانت تمام\u064bا، ولن أ\u064fعيد هذا الطريق عليها من نفسي. جر\u0651بها الآن: يجب أن تعمل كما كانت قبل التعريب.";

	private const string StalledMessage = "لعبتك عملت بالتعريب، لكن\u0651 سجل\u0651ها لم يكتب ما تكتبه حين تعمل سليمة — فشيء\u064c فيها تعط\u0651ل بالتعريب حتى لو ظهرت قائمتها. أعدت\u064f ملف\u0651اتها كما كانت تمام\u064bا، ولن أ\u064fعيد هذا الطريق عليها من نفسي. جر\u0651بها الآن: يجب أن تعمل كما كانت قبل التعريب.";

	private const string ShortLogMessage = "لعبتك تعمل بالتعريب، وسجل\u0651ها لم يكتب بعد\u064f كل\u064e\u0651 ما كتبه حين عملت سليمة — وقد يكون ذلك بطء\u064bا لا عطل\u064bا. انظر إليها أنت وأخبرني: هل وصلت قائمتها، وهل تقرأ العربية فيها؟";

	private const string UnconfirmedMessage = "لعبتك أقلعت، وأنت لم تر\u064e العربية في قوائمها ولم تتأك\u0651د مم\u0651ا رأيت. أبقيت\u064f التعريب كما وعدت\u064fك، ولم أ\u064fثبت أنه يعمل. جر\u0651بها، وإن بقيت إنجليزية فأزل التعريب من هنا وأخبرني.";

	private const string FontVerifiedMessage = "لعبتك أقلعت، والخط\u0651 العربي محق\u064e\u0651ق\u064c في ملف\u0651ها — قرأت\u064f الملف\u0651 الذي كتبت\u064fه فوجدت فيه صور الحروف العربية كل\u0651ها. يبقى شيء\u064c واحد لا أستطيع أن أراه بنفسي: الشاشة. انظر إليها مر\u0651ة\u064b واحدة وأخبرني هل تقرأ العربية — ولن أسألك عنها ثانية.";

	private const string NotDrawnMessage = "لعبتك أقلعت، والعربية مكتوبة في ملف\u0651اتها — ولكنها لا ت\u064fرس\u064eم على الشاشة، فتظهر مرب\u0651عات فارغة. والسبب أن هذه اللعبة لم تقبل الخط\u0651 العربي. أعدت\u064f ملف\u0651اتها كما كانت تمام\u064bا، ولن أ\u064fعيد هذا الطريق عليها من نفسي.";

	public static BootJudgement Judge(BootBaseline? baseline, BootSignals signals)
	{
		BootJudgement bootJudgement = A(baseline, signals);
		if (signals.UserCouldNotConfirm && signals.ProcessAlive && bootJudgement.RollBack)
		{
			return new BootJudgement
			{
				Verdict = BootVerdict.AskTheUser,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PE(),
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pe() + bootJudgement.Because + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z()
			};
		}
		return bootJudgement;
	}

	private static BootJudgement A(BootBaseline? baseline, BootSignals P_1)
	{
		bool? userSaysArabicIsDrawn = P_1.UserSaysArabicIsDrawn;
		if (userSaysArabicIsDrawn.HasValue)
		{
			bool valueOrDefault = userSaysArabicIsDrawn.GetValueOrDefault();
			if (P_1.ProcessAlive || a(baseline, P_1) || A(baseline))
			{
				if (!valueOrDefault)
				{
					return new BootJudgement
					{
						Verdict = BootVerdict.BootedButArabicNotDrawn,
						Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PF(),
						Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pf()
					};
				}
				return new BootJudgement
				{
					Verdict = BootVerdict.BootedAndArabicDrawn,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PG(),
					Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pg()
				};
			}
		}
		string text = ACrashInTheLog.In(P_1.LogText) ?? ACrashInTheLog.In(P_1.CrashReports);
		if (text != null)
		{
			return new BootJudgement
			{
				Verdict = BootVerdict.DidNotBoot,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PH(),
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ph() + text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PI()
			};
		}
		if (!P_1.ProcessAlive && !a(baseline, P_1))
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (A(baseline))
			{
				BootJudgement obj = new BootJudgement
				{
					Verdict = BootVerdict.AskTheUser,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pi()
				};
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(111, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PJ());
				defaultInterpolatedStringHandler.AppendFormatted<long>(P_1.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pj());
				obj.Because = defaultInterpolatedStringHandler.ToStringAndClear();
				obj.EndedUnseen = true;
				return obj;
			}
			BootJudgement obj2 = new BootJudgement
			{
				Verdict = BootVerdict.DidNotBoot,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PH()
			};
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(101, 3);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PK());
			defaultInterpolatedStringHandler.AppendFormatted(baseline.Milestone);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pk());
			defaultInterpolatedStringHandler.AppendFormatted<long>(P_1.LogBytes);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PL());
			defaultInterpolatedStringHandler.AppendFormatted<long>(baseline.LogBytes);
			obj2.Because = defaultInterpolatedStringHandler.ToStringAndClear();
			return obj2;
		}
		ArabicTheGameCouldNotDraw.Confession confession = ArabicTheGameCouldNotDraw.In(P_1.LogText);
		if ((object)confession != null && confession.IsBoxes)
		{
			BootJudgement obj3 = new BootJudgement
			{
				Verdict = BootVerdict.BootedButArabicNotDrawn,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PF()
			};
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(70, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pl());
			defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<int>)confession.Characters).Count);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PM());
			string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
			string font = confession.Font;
			string obj4 = ((font != null) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Di() + font + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DJ()) : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(36, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pm());
			defaultInterpolatedStringHandler.AppendFormatted<int>(confession.Lines);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PN());
			defaultInterpolatedStringHandler.AppendFormatted(confession.FirstFew);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pn());
			obj3.Because = text2 + obj4 + defaultInterpolatedStringHandler.ToStringAndClear();
			return obj3;
		}
		if ((object)baseline == null)
		{
			return new BootJudgement
			{
				Verdict = BootVerdict.AskTheUser,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pi(),
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PO()
			};
		}
		if (!a(baseline, P_1))
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (P_1.ProcessAlive && P_1.LogText.Length == 0)
			{
				BootJudgement obj5 = new BootJudgement
				{
					Verdict = BootVerdict.AskTheUser,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Po()
				};
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(114, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PP());
				defaultInterpolatedStringHandler.AppendFormatted<long>(baseline.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pp());
				obj5.Because = defaultInterpolatedStringHandler.ToStringAndClear();
				return obj5;
			}
			string milestone = baseline.Milestone;
			if (milestone == null || milestone.Length <= 0)
			{
				BootJudgement obj6 = new BootJudgement
				{
					Verdict = BootVerdict.AskTheUser,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PQ()
				};
				string text3 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pq();
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(58, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PR());
				defaultInterpolatedStringHandler.AppendFormatted<long>(P_1.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PL());
				defaultInterpolatedStringHandler.AppendFormatted<long>(baseline.LogBytes);
				obj6.Because = text3 + defaultInterpolatedStringHandler.ToStringAndClear();
				return obj6;
			}
			string text4 = AnExceptionInTheLog.NewIn(P_1.LogText, (System.Collections.Generic.IReadOnlyCollection<string>?)baseline.ThrowsOfTheCleanRun);
			if (text4 != null)
			{
				BootJudgement obj7 = new BootJudgement
				{
					Verdict = BootVerdict.DidNotBoot,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pr()
				};
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(131, 4);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PS());
				defaultInterpolatedStringHandler.AppendFormatted(text4);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ps());
				defaultInterpolatedStringHandler.AppendFormatted(baseline.Milestone);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PT());
				defaultInterpolatedStringHandler.AppendFormatted<long>(P_1.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pt());
				defaultInterpolatedStringHandler.AppendFormatted<long>(baseline.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
				obj7.Because = defaultInterpolatedStringHandler.ToStringAndClear();
				return obj7;
			}
			if (P_1.LogStillGrowing)
			{
				BootJudgement obj8 = new BootJudgement
				{
					Verdict = BootVerdict.AskTheUser,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Po()
				};
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(152, 3);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PU());
				defaultInterpolatedStringHandler.AppendFormatted(baseline.Milestone);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pu());
				defaultInterpolatedStringHandler.AppendFormatted<long>(P_1.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pt());
				defaultInterpolatedStringHandler.AppendFormatted<long>(baseline.LogBytes);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PV());
				obj8.Because = defaultInterpolatedStringHandler.ToStringAndClear();
				return obj8;
			}
			BootJudgement obj9 = new BootJudgement
			{
				Verdict = BootVerdict.DidNotBoot,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pr()
			};
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(117, 3);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pv());
			defaultInterpolatedStringHandler.AppendFormatted(baseline.Milestone);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PW());
			defaultInterpolatedStringHandler.AppendFormatted<long>(P_1.LogBytes);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pt());
			defaultInterpolatedStringHandler.AppendFormatted<long>(baseline.LogBytes);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			obj9.Because = defaultInterpolatedStringHandler.ToStringAndClear();
			return obj9;
		}
		if (P_1.UserCouldNotConfirm)
		{
			return new BootJudgement
			{
				Verdict = BootVerdict.AskTheUser,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PE(),
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pw()
			};
		}
		userSaysArabicIsDrawn = P_1.FontVerifiedInFile;
		if (userSaysArabicIsDrawn.HasValue)
		{
			bool valueOrDefault2 = userSaysArabicIsDrawn.GetValueOrDefault();
			if (!valueOrDefault2)
			{
				string? fontVerification = P_1.FontVerification;
				if (fontVerification != null && fontVerification.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PX(), (StringComparison)4))
				{
					return new BootJudgement
					{
						Verdict = BootVerdict.AskTheUser,
						Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Px(),
						Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PY() + P_1.FontVerification
					};
				}
			}
			if (!valueOrDefault2)
			{
				return new BootJudgement
				{
					Verdict = BootVerdict.BootedButArabicNotDrawn,
					Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PF(),
					Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Py() + (P_1.FontVerification ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PZ())
				};
			}
			return new BootJudgement
			{
				Verdict = BootVerdict.BootedAndFontVerifiedInFile,
				Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Pz(),
				Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pA() + (P_1.FontVerification ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pa())
			};
		}
		if (P_1.LoaderExpected)
		{
			LoaderSignals loader = P_1.Loader;
			if ((object)loader != null)
			{
				if (loader.FontFailed)
				{
					return new BootJudgement
					{
						Verdict = BootVerdict.BootedButArabicNotDrawn,
						Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PF(),
						Because = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pB()
					};
				}
				if (loader.SaidNothing)
				{
					return new BootJudgement
					{
						Verdict = BootVerdict.BootedButArabicNotDrawn,
						Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.PF(),
						Because = (loader.StartedWithoutOurModule ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pC() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pb())
					};
				}
				if (loader.FontInstalled && loader.ArabicLabels > 0)
				{
					BootJudgement obj10 = new BootJudgement
					{
						Verdict = BootVerdict.BootedAndArabicDrawn
					};
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(79, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pc());
					defaultInterpolatedStringHandler.AppendFormatted<int>(loader.ArabicLabels);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pD());
					obj10.Message = defaultInterpolatedStringHandler.ToStringAndClear();
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(41, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pd());
					defaultInterpolatedStringHandler.AppendFormatted<int>(loader.ArabicLabels);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pE());
					obj10.Because = defaultInterpolatedStringHandler.ToStringAndClear();
					return obj10;
				}
			}
		}
		return new BootJudgement
		{
			Verdict = BootVerdict.AskTheUser,
			Message = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Px(),
			Because = (P_1.LoaderExpected ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pF() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pe())
		};
	}

	private static bool a(BootBaseline? baseline, BootSignals P_1)
	{
		if ((object)baseline == null)
		{
			return false;
		}
		string milestone = baseline.Milestone;
		if (milestone != null && milestone.Length > 0)
		{
			return LogMilestone.Reached(milestone, P_1.LogText);
		}
		if (P_1.ProcessAlive)
		{
			return P_1.LogBytes >= baseline.LogBytes;
		}
		return false;
	}

	private static bool A(BootBaseline? P_0)
	{
		string text = P_0?.Milestone;
		return text == null || text.Length <= 0;
	}
}
