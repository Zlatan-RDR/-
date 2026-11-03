using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using HarmonyLib;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Engines.Unity.Plugin;

internal static class TextHooks
{
	private static readonly string[] TextTypes = new string[3] { "TMPro.TMP_Text", "UnityEngine.UI.Text", "SuperTextMesh" };

	private static readonly string[] FrameTicks = new string[3] { "TMPro.TMP_UpdateManager:DoRebuilds", "UnityEngine.UI.CanvasUpdateRegistry:PerformUpdate", "UnityEngine.Canvas:SendWillRenderCanvases" };

	private static readonly string[] ShownTypes = new string[4] { "TMPro.TextMeshProUGUI", "TMPro.TextMeshPro", "UnityEngine.UI.Text", "SuperTextMesh" };

	private static int _straightened;

	private static long _lastFrame;

	private static int _handedBack;

	internal const int MostLabelsInOneFrame = 120;

	internal const int MostFramesForOneSweep = 30;

	private static IEnumerator _sweepAt;

	private static int _sweepFrames;

	private static int _sweptWritten;

	private static HashSet<string> _sweepOnScreen;

	private static int _sweepAsked;

	private static readonly Dictionary<Type, Func<object, bool>> _isDrawn = new Dictionary<Type, Func<object, bool>>();

	private const int MostFastSweepsInARow = 8;

	private static int _fastSweepsInARow;

	private static readonly TimeSpan WhenItIsSettled = TimeSpan.FromSeconds(1.0);

	private static readonly TimeSpan WhileTheScreenIsChanging = TimeSpan.FromMilliseconds(120.0);

	private static TimeSpan _catchUpGap = WhenItIsSettled;

	private const int MostToAskPerSweep = 8;

	private static HashSet<string> _lastSeenOnScreen = new HashSet<string>(StringComparer.Ordinal);

	private static bool _screenKnown;

	private static int _noticedThisSession;

	private static DateTime _lastCatchUp = DateTime.MinValue;

	[ThreadStatic]
	private static bool _draining;

	private static void NoteStraightened()
	{
		_straightened++;
		bool flag;
		switch (_straightened)
		{
		case 1:
		case 10:
		case 100:
		case 500:
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			MiqbasPlugin.Log($"اتجاه العربية أ\u064fصلح على {_straightened} لافتة.");
		}
	}

	internal static string WithoutMarks(string arabic)
	{
		if (string.IsNullOrEmpty(arabic))
		{
			return arabic;
		}
		string text = arabic.Normalize(NormalizationForm.FormC);
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		string text2 = text;
		foreach (char c in text2)
		{
			if ((c < '\u064b' || c > '\u065f') && c != '\u0670')
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	private static string PresentArabic(object component, string arabic)
	{
		arabic = WithoutMarks(arabic);
		string text = ArabicShaper.Shape(arabic);
		if (!ArabicDirection.ContainsArabic(arabic))
		{
			return text;
		}
		if (MiqbasPlugin.FilesRepaired)
		{
			if (!ArabicDirection.LayOutLeftToRight(component))
			{
				return text;
			}
			return LaidOutInItsLines(component, arabic, text);
		}
		if (HandedWords.FlagHolds && ArabicDirection.ApplyTo(component))
		{
			string text2 = ArabicVisualOrder.ForARendererThatTurnsItRound(text);
			HandedWords.NoteLogical(text2);
			return text2;
		}
		if (!ArabicDirection.LayOutLeftToRight(component))
		{
			string text3 = ArabicVisualOrder.ForARendererThatTurnsItRound(text);
			HandedWords.NoteLogical(text3);
			return text3;
		}
		string text4 = LaidOutInItsLines(component, arabic, text);
		HandedWords.NoteVisual(text4);
		return text4;
	}

	private static string LaidOutInItsLines(object component, string logical, string shaped)
	{
		double width;
		double size;
		string text = LinesOfALabel.ForItsBox(component, logical, out width, out size);
		string text2 = ArabicVisualOrder.ToVisual(((object)text == logical) ? shaped : ArabicShaper.Shape(text));
		LinesOfALabel.Remember(component, text2, logical, width, size);
		return text2;
	}

	private static string AgainOnItsBox(object label, string shown)
	{
		return LinesOfALabel.AgainOnItsBox(label, shown, delegate(string logical)
		{
			string text = LaidOutInItsLines(label, logical, ArabicShaper.Shape(logical));
			HandedWords.NoteVisual(text);
			return text;
		});
	}

	internal static int ApplyWatching(Harmony harmony, Action<string> log)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		HarmonyMethod val = new HarmonyMethod(typeof(TextHooks).GetMethod("OnTextAssignedWatching", BindingFlags.Static | BindingFlags.NonPublic));
		HarmonyMethod val2 = new HarmonyMethod(typeof(TextHooks).GetMethod("OnTextFilledWatching", BindingFlags.Static | BindingFlags.NonPublic));
		int num = 0;
		foreach (MethodBase item in FindTextSetters(log))
		{
			try
			{
				harmony.Patch(item, val, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				num++;
			}
			catch (Exception e)
			{
				log("تعذ\u0651ر التعل\u0651ق بـ" + item.DeclaringType?.FullName + ": " + WhyItFailed.Line(e));
			}
		}
		foreach (MethodBase item2 in FindTextFillers(log))
		{
			try
			{
				harmony.Patch(item2, (HarmonyMethod)null, val2, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				num++;
			}
			catch (Exception e2)
			{
				log("تعذ\u0651رت القراءة من SetText: " + WhyItFailed.Line(e2));
			}
		}
		return num + GiveTheLayerAClock(harmony, log, "OnFrameWatching");
	}

	private static void OnFrameWatching()
	{
		long num = FrameCost.Shared.Enter();
		try
		{
			MiqbasPlugin.Places?.AskTheFonts();
		}
		catch
		{
		}
		FrameCost.Shared.Leave(num, "نبضة\u064f الشاهد");
		CountTheFrame(num);
	}

	private static void OnTextAssignedWatching(object __instance, ref string value)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			Watch(__instance, value);
		}
		catch
		{
		}
		finally
		{
			FrameCost.Shared.Leave(started, "شاهد\u064f إسناد");
		}
	}

	private static void OnTextFilledWatching(object __instance)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			if (__instance != null)
			{
				MethodInfo methodInfo = TextRegistry.GetterFor(__instance.GetType());
				if ((object)methodInfo != null && methodInfo.Invoke(__instance, null) is string value)
				{
					Watch(__instance, value);
				}
			}
		}
		catch
		{
		}
		finally
		{
			FrameCost.Shared.Leave(started, "شاهد\u064f تعبئة");
		}
	}

	private static void Watch(object label, string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			MiqbasPlugin.Places?.AskTheFonts();
			string text = MiqbasPlugin.Drew?.Record(value, ArabicDirection.ContainsArabic(value));
			if (text != null)
			{
				MiqbasPlugin.Log(text);
			}
			MiqbasPlugin.Places?.Saw(value, null, label);
		}
	}

	internal static int Apply(Harmony harmony, Action<string> log)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		HarmonyMethod val = new HarmonyMethod(typeof(TextHooks).GetMethod("OnTextAssigned", BindingFlags.Static | BindingFlags.NonPublic));
		HarmonyMethod val2 = new HarmonyMethod(typeof(TextHooks).GetMethod("OnTextShown", BindingFlags.Static | BindingFlags.NonPublic));
		ArabicDirection.DefendOwnership(harmony);
		int num = 0;
		foreach (MethodBase item in FindTextSetters(log))
		{
			try
			{
				harmony.Patch(item, val, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				num++;
			}
			catch (Exception e)
			{
				log("تعذ\u0651ر التعل\u0651ق بـ" + item.DeclaringType?.FullName + ": " + WhyItFailed.Line(e));
			}
		}
		foreach (MethodBase item2 in FindShownMethods(log))
		{
			try
			{
				harmony.Patch(item2, (HarmonyMethod)null, val2, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				num++;
			}
			catch (Exception e2)
			{
				log("تعذ\u0651ر التعل\u0651ق بظهور " + item2.DeclaringType?.FullName + ": " + WhyItFailed.Line(e2));
			}
		}
		HarmonyMethod val3 = new HarmonyMethod(typeof(TextHooks).GetMethod("OnTextFilled", BindingFlags.Static | BindingFlags.NonPublic));
		foreach (MethodBase item3 in FindTextFillers(log))
		{
			try
			{
				harmony.Patch(item3, (HarmonyMethod)null, val3, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				num++;
			}
			catch (Exception e3)
			{
				log("تعذ\u0651رت القراءة من SetText: " + WhyItFailed.Line(e3));
			}
		}
		try
		{
			num += UitkText.Apply(harmony, log);
		}
		catch (Exception e4)
		{
			log("تعذ\u0651ر طريق UI Toolkit: " + WhyItFailed.Line(e4));
		}
		num += GiveTheLayerAClock(harmony, log);
		try
		{
			num += ImmediateModeHooks.Apply(harmony, log);
		}
		catch (Exception e5)
		{
			log("تعذ\u0651ر طريق الرسم القديم: " + WhyItFailed.Line(e5));
		}
		return num;
	}

	private static int GiveTheLayerAClock(Harmony harmony, Action<string> log, string onFrame = "OnFrame")
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		HarmonyMethod val = new HarmonyMethod(typeof(TextHooks).GetMethod(onFrame, BindingFlags.Static | BindingFlags.NonPublic));
		string[] frameTicks = FrameTicks;
		foreach (string text in frameTicks)
		{
			int num = text.IndexOf(':');
			Type type = AccessTools.TypeByName(text.Substring(0, num));
			if (type == null)
			{
				continue;
			}
			MethodInfo methodInfo = AccessTools.Method(type, text.Substring(num + 1), (Type[])null, (Type[])null);
			if (!(methodInfo == null))
			{
				try
				{
					harmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, val, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
					log("نبضة\u064f الطبقة: " + text);
					return 1;
				}
				catch (Exception e)
				{
					log("تعذ\u0651رت النبضة على " + text + ": " + WhyItFailed.Line(e));
				}
			}
		}
		log("لا نبضة في هذه اللعبة — لن تظهر ترجمة\u064c تصل أثناء اللعب إلا حين ت\u064fسن\u064eد النصوص من جديد.");
		return 0;
	}

	private static void OnFrame()
	{
		long num = FrameCost.Shared.Enter();
		long started = FrameCost.Start();
		try
		{
			Hotkeys.Poll();
		}
		catch
		{
		}
		FrameCost.Shared.Piece("المفاتيح", started);
		started = FrameCost.Start();
		try
		{
			DrainInstantTranslations();
			CatchUpOnWhatIsKnown();
		}
		catch
		{
		}
		FrameCost.Shared.Piece("تسليم\u064f الترجمات والمسحة", started);
		started = FrameCost.Start();
		try
		{
			DirectionSweep.MaybeRun();
		}
		catch
		{
		}
		FrameCost.Shared.Piece("مسح\u064f الات\u0651جاه", started);
		FrameCost.Shared.Leave(num, "نبضة\u064f الإطار");
		CountTheFrame(num);
	}

	private static void CountTheFrame(long now)
	{
		try
		{
			long lastFrame = _lastFrame;
			_lastFrame = now;
			if (lastFrame != 0L)
			{
				string text = FrameCost.Shared.Frame(FrameCost.Milliseconds(now - lastFrame));
				if (text != null)
				{
					MiqbasPlugin.Log(text);
				}
			}
		}
		catch
		{
		}
	}

	private static void OnTextFilled(object __instance)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			WhenTextFilled(__instance);
		}
		finally
		{
			FrameCost.Shared.Leave(started, "تعبئة\u064f نص\u0651");
		}
	}

	private static void OnTextAssigned(object __instance, ref string value)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			WhenTextAssigned(__instance, ref value);
			ArabicLettersOnALegacyLabel.Follow(__instance, value);
		}
		finally
		{
			FrameCost.Shared.Leave(started, "إسناد\u064f نص\u0651");
		}
	}

	private static void OnTextShown(object __instance)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			WhenTextShown(__instance);
		}
		finally
		{
			FrameCost.Shared.Leave(started, "إظهار\u064f لافتة");
		}
	}

	private static IEnumerable<MethodBase> FindTextSetters(Action<string> log)
	{
		string[] textTypes = TextTypes;
		foreach (string text in textTypes)
		{
			Type type = AccessTools.TypeByName(text);
			if (type == null)
			{
				log("لا يوجد " + text + " في هذه اللعبة — ي\u064fتخط\u0651ى.");
				continue;
			}
			MethodInfo methodInfo = AccessTools.PropertySetter(type, "text");
			if (methodInfo == null)
			{
				log("و\u064fجد " + text + " بلا خاصية نص — ي\u064fتخط\u0651ى.");
				continue;
			}
			log("نقطة تعل\u0651ق: " + text + ".text");
			yield return methodInfo;
		}
	}

	private static IEnumerable<MethodBase> FindTextFillers(Action<string> log)
	{
		Type type = AccessTools.TypeByName("TMPro.TMP_Text");
		if (type == null)
		{
			yield break;
		}
		MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
		foreach (MethodInfo methodInfo in methods)
		{
			if (!(methodInfo.Name != "SetText"))
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();
				if (parameters.Length == 1 && !(parameters[0].ParameterType != typeof(string)))
				{
					log("نقطة قراءة: TMP_Text.SetText(نص)");
					yield return methodInfo;
				}
			}
		}
	}

	private static void WhenTextFilled(object __instance)
	{
		try
		{
			if (__instance == null)
			{
				return;
			}
			MethodInfo methodInfo = TextRegistry.GetterFor(__instance.GetType());
			if ((object)methodInfo == null || !(methodInfo.Invoke(__instance, null) is string text))
			{
				return;
			}
			if (IsHandedBackForTranslation(text, MiqbasPlugin.ShowOriginal, (string s) => MiqbasPlugin.Translations?.Find(s)))
			{
				MethodInfo methodInfo2 = TextRegistry.SetterFor(__instance.GetType());
				if ((object)methodInfo2 != null)
				{
					methodInfo2.Invoke(__instance, new object[1] { text });
					NoteHandedBack();
				}
				return;
			}
			string text2 = ((text.Length <= 0) ? null : MiqbasPlugin.Translations?.Find(text));
			if (text.Length > 0)
			{
				string text3 = MiqbasPlugin.Drew?.Record(text, text2 != null || ArabicDirection.ContainsArabic(text));
				if (text3 != null)
				{
					MiqbasPlugin.Log(text3);
				}
			}
			MiqbasPlugin.Places?.Saw(text, text2, __instance);
			if (!MiqbasPlugin.ShowOriginal && text.Length != 0 && !ArabicDirection.ContainsArabic(text))
			{
				MiqbasPlugin.Observer?.Record(text);
				MiqbasPlugin.CameFrom?.Record(text);
				MiqbasPlugin.Instant?.Request(text);
			}
		}
		catch
		{
		}
	}

	private static void NoteHandedBack()
	{
		_handedBack++;
		bool flag;
		switch (_handedBack)
		{
		case 1:
		case 10:
		case 100:
		case 500:
			flag = true;
			break;
		default:
			flag = false;
			break;
		}
		if (flag)
		{
			MiqbasPlugin.Log($"أ\u064fعيد عبر الخاصي\u0651ة {_handedBack} سطر\u064bا وصل عبر SetText.");
		}
	}

	internal static bool IsHandedBackForTranslation(string shown, bool showOriginal, Func<string, string> find)
	{
		if (!showOriginal && !string.IsNullOrEmpty(shown) && !ArabicDirection.ContainsArabic(shown))
		{
			return find(shown) != null;
		}
		return false;
	}

	private static IEnumerable<MethodBase> FindShownMethods(Action<string> log)
	{
		string[] shownTypes = ShownTypes;
		foreach (string text in shownTypes)
		{
			Type type = AccessTools.TypeByName(text);
			if (!(type == null))
			{
				MethodInfo methodInfo = AccessTools.DeclaredMethod(type, "OnEnable", (Type[])null, (Type[])null);
				if (methodInfo == null)
				{
					log("لا يوجد لحظة ظهور في " + text + " — ي\u064fتخط\u0651ى.");
					continue;
				}
				log("نقطة تعل\u0651ق: " + text + ".OnEnable");
				yield return methodInfo;
			}
		}
	}

	private static void WhenTextAssigned(object __instance, ref string value)
	{
		try
		{
			long started = FrameCost.Start();
			MiqbasPlugin.Portrait?.Trigger();
			FrameCost.Shared.Piece("الصورة", started);
			started = FrameCost.Start();
			Hotkeys.Poll();
			FrameCost.Shared.Piece("المفاتيح", started);
			started = FrameCost.Start();
			DrainInstantTranslations();
			FrameCost.Shared.Piece("تسليم\u064f الترجمات", started);
			MiqbasPlugin.Places?.AskTheFonts();
			started = FrameCost.Start();
			DirectionSweep.MaybeRun();
			FrameCost.Shared.Piece("مسح\u064f الات\u0651جاه", started);
			started = FrameCost.Start();
			ArabicFont.EnsureInstalled(MiqbasPlugin.WorkDirectory, MiqbasPlugin.Patcher, MiqbasPlugin.Log);
			FrameCost.Shared.Piece("تركيب\u064f الخط", started);
			string text = MiqbasPlugin.Translations?.Find(value);
			string text2 = MiqbasPlugin.Drew?.Record(value, text != null || (value != null && ArabicDirection.ContainsArabic(value)));
			if (text2 != null)
			{
				MiqbasPlugin.Log(text2);
			}
			string text3 = ArabicTheHooksSaw.Note(__instance, value, text != null);
			if (text3 != null)
			{
				MiqbasPlugin.Log(text3);
			}
			MiqbasPlugin.Places?.Saw(value, text, __instance);
			if (text != null)
			{
				TextRegistry.Remember(__instance, value);
				if (!MiqbasPlugin.ShowOriginal)
				{
					Hotkeys.NoteTranslated(value);
					started = FrameCost.Start();
					value = PresentArabic(__instance, text);
					FrameCost.Shared.Piece("تشكيل\u064f العربية", started);
				}
				return;
			}
			if (HandedWords.IsOurVisual(value))
			{
				ArabicDirection.LayOutLeftToRight(__instance);
				return;
			}
			if (HandedWords.IsOurLogical(value))
			{
				if (!HandedWords.FlagHolds || !ArabicDirection.ApplyTo(__instance))
				{
					ArabicDirection.LayOutLeftToRight(__instance);
					string text4 = ArabicVisualOrder.FromARendererThatTurnsItRound(value);
					HandedWords.NoteVisual(text4);
					value = text4;
				}
				return;
			}
			ArabicDirection.FollowText(__instance, value);
			if (ArabicDirection.ContainsArabic(value))
			{
				if (MiqbasPlugin.FilesRepaired)
				{
					if (ArabicDirection.LayOutLeftToRight(__instance))
					{
						value = LinesOfALabel.WrittenLineOnItsBox(__instance, value);
					}
				}
				else
				{
					value = PresentArabic(__instance, value);
					NoteStraightened();
				}
			}
			else
			{
				MiqbasPlugin.Observer?.Record(value);
				MiqbasPlugin.CameFrom?.Record(value);
				if (!MiqbasPlugin.ShowOriginal)
				{
					TextRegistry.Remember(__instance, value);
					MiqbasPlugin.Instant?.Request(value);
				}
			}
		}
		catch
		{
		}
	}

	private static void WhenTextShown(object __instance)
	{
		try
		{
			if (__instance == null)
			{
				return;
			}
			Type type = __instance.GetType();
			MethodInfo methodInfo = TextRegistry.GetterFor(type);
			if ((object)methodInfo == null)
			{
				return;
			}
			MethodInfo methodInfo2 = TextRegistry.SetterFor(type);
			if ((object)methodInfo2 == null)
			{
				return;
			}
			string text = TextRegistry.OriginalOf(__instance);
			if (text == null)
			{
				if (!(methodInfo.Invoke(__instance, null) is string { Length: not 0 } text2))
				{
					return;
				}
				if (ArabicDirection.ContainsArabic(text2))
				{
					ArabicDirection.FollowText(__instance, text2);
					ArabicLettersOnALegacyLabel.Follow(__instance, text2);
					NoteStraightened();
					return;
				}
				text = text2;
			}
			methodInfo2.Invoke(__instance, new object[1] { text });
		}
		catch
		{
		}
	}

	internal static void DrainInstantTranslations()
	{
		if (_draining)
		{
			return;
		}
		long started = FrameCost.Start();
		MiqbasPlugin.ReloadTranslationsIfChanged();
		FrameCost.Shared.Piece("إعادة\u064f تحميل الترجمات", started);
		List<KeyValuePair<string, string>> list = MiqbasPlugin.Instant?.TakeArrived();
		if (list == null || list.Count == 0)
		{
			return;
		}
		_draining = true;
		try
		{
			foreach (KeyValuePair<string, string> item in list)
			{
				MiqbasPlugin.Translations?.Add(item.Key, item.Value);
				lock (MiqbasPlugin.ArrivedThisSession)
				{
					MiqbasPlugin.ArrivedThisSession[item.Key] = item.Value;
				}
			}
			started = FrameCost.Start();
			int num = PutOnLiveLabels();
			FrameCost.Shared.Piece("كتابة\u064f ما وصل على اللافتات", started);
			MiqbasPlugin.Log("وصلت " + DescribeArrivals(list) + " أثناء اللعب — أ\u064fعيدت الكتابة على " + num + " لافتة، والمحفوظ منها " + TextRegistry.WhatIsRemembered() + ".");
		}
		catch
		{
		}
		finally
		{
			_draining = false;
		}
	}

	internal static string DescribeArrivals(List<KeyValuePair<string, string>> arrived)
	{
		if (arrived == null || arrived.Count == 0)
		{
			return "0 ترجمة";
		}
		if (arrived.Count > 3)
		{
			return arrived.Count + " ترجمة";
		}
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, string> item in arrived)
		{
			list.Add("«" + Shorten(item.Key) + "» ← «" + Shorten(item.Value) + "»");
		}
		return ((arrived.Count == 1) ? "ترجمة " : (arrived.Count + " ترجمة: ")) + string.Join("، ", list.ToArray());
	}

	private static string Shorten(string line)
	{
		if (line != null)
		{
			if (line.Length > 30)
			{
				return line.Substring(0, 30) + "…";
			}
			return line;
		}
		return "";
	}

	private static int PutOnLiveLabels()
	{
		TranslationTable translations = MiqbasPlugin.Translations;
		if (translations == null)
		{
			return 0;
		}
		if (_sweepAt == null)
		{
			IEnumerable enumerable = DirectionSweep.LiveLabels();
			if (enumerable == null)
			{
				return 0;
			}
			_sweepAt = enumerable.GetEnumerator();
			_sweptWritten = 0;
			_sweepAsked = 0;
			_sweepFrames = 0;
			_sweepOnScreen = new HashSet<string>(StringComparer.Ordinal);
		}
		if (++_sweepFrames > 30)
		{
			_sweepAt = null;
			_sweepOnScreen = null;
			return 0;
		}
		int num = _sweptWritten;
		HashSet<string> sweepOnScreen = _sweepOnScreen;
		int num2 = _sweepAsked;
		int num3 = 0;
		while (true)
		{
			if (num3 >= 120)
			{
				_sweptWritten = num;
				_sweepAsked = num2;
				return -1;
			}
			object current;
			try
			{
				if (!_sweepAt.MoveNext())
				{
					break;
				}
				current = _sweepAt.Current;
				goto IL_00ba;
			}
			catch
			{
			}
			break;
			IL_00ba:
			num3++;
			if (current == null)
			{
				continue;
			}
			try
			{
				Type type = current.GetType();
				MethodInfo methodInfo = TextRegistry.GetterFor(type);
				if ((object)methodInfo == null)
				{
					continue;
				}
				MethodInfo methodInfo2 = TextRegistry.SetterFor(type);
				if ((object)methodInfo2 == null || !(methodInfo.Invoke(current, null) is string { Length: not 0 } text))
				{
					continue;
				}
				string text2 = AgainOnItsBox(current, text);
				if (text2 != null)
				{
					NoteWhatIsOnScreen(text2, sweepOnScreen, num2, current);
					methodInfo2.Invoke(current, new object[1] { text2 });
					num++;
				}
				else if (translations.Find(text) == null)
				{
					if (NoteWhatIsOnScreen(text, sweepOnScreen, num2, current) && !MiqbasPlugin.ShowOriginal)
					{
						MiqbasPlugin.Observer?.Record(text);
						MiqbasPlugin.CameFrom?.Record(text);
						MiqbasPlugin.Instant?.Request(text);
						num2++;
					}
				}
				else
				{
					NoteWhatIsOnScreen(text, sweepOnScreen, num2, current);
					methodInfo2.Invoke(current, new object[1] { text });
					num++;
				}
			}
			catch
			{
			}
		}
		_sweepAt = null;
		_sweepOnScreen = null;
		if (num2 > 0)
		{
			_noticedThisSession += num2;
			MiqbasPlugin.Log("لاحظت\u064f " + num2 + " سطر\u064bا كتب\u064eته اللعبة للتو\u0651 (على الشاشة " + sweepOnScreen.Count + " سطر\u064bا، ومجموع ما لوحظ هذه الجلسة " + _noticedThisSession + ").");
		}
		_lastSeenOnScreen = sweepOnScreen;
		_screenKnown = true;
		return num;
	}

	internal static bool NoteWhatIsOnScreen(string shown, HashSet<string> onScreen, int asked, object label = null)
	{
		onScreen.Add(shown);
		if (!_screenKnown || asked >= 8 || ArabicDirection.ContainsArabic(shown) || !HasAWordInIt(shown))
		{
			return false;
		}
		if (!_lastSeenOnScreen.Contains(shown))
		{
			return true;
		}
		if (label != null && BeingDrawnNow(label))
		{
			return NothingHasItYet(shown);
		}
		return false;
	}

	internal static bool BeingDrawnNow(object label)
	{
		if (label == null)
		{
			return false;
		}
		try
		{
			Type type = label.GetType();
			if (!_isDrawn.TryGetValue(type, out var value))
			{
				value = ReaderOfDrawnFor(type);
				_isDrawn[type] = value;
			}
			return value?.Invoke(label) ?? false;
		}
		catch
		{
			return false;
		}
	}

	private static bool NothingHasItYet(string shown)
	{
		InstantTranslator instant = MiqbasPlugin.Instant;
		if (instant == null)
		{
			return false;
		}
		return !instant.AlreadyInHand(shown);
	}

	private static Func<object, bool> ReaderOfDrawnFor(Type type)
	{
		PropertyInfo enabled = type.GetProperty("isActiveAndEnabled");
		PropertyInfo renderer = type.GetProperty("canvasRenderer");
		if (enabled == null)
		{
			return null;
		}
		PropertyInfo cull = renderer?.PropertyType.GetProperty("cull");
		return delegate(object label)
		{
			object value = enabled.GetValue(label, null);
			if (!(value is bool) || !(bool)value)
			{
				return false;
			}
			if (renderer == null || cull == null)
			{
				return true;
			}
			object value2 = renderer.GetValue(label, null);
			if (value2 != null)
			{
				value = cull.GetValue(value2, null);
				return !(value is bool) || !(bool)value;
			}
			return false;
		};
	}

	private static bool HasAWordInIt(string shown)
	{
		for (int i = 0; i < shown.Length; i++)
		{
			if (char.IsLetter(shown[i]))
			{
				return true;
			}
		}
		return false;
	}

	internal static void CatchUpOnWhatIsKnown()
	{
		DateTime utcNow = DateTime.UtcNow;
		if (utcNow - _lastCatchUp < _catchUpGap)
		{
			return;
		}
		_lastCatchUp = utcNow;
		if (_draining)
		{
			return;
		}
		_draining = true;
		try
		{
			int num = PutOnLiveLabels();
			if (num < 0)
			{
				_catchUpGap = TimeSpan.Zero;
				return;
			}
			_fastSweepsInARow = ((num > 0 && _fastSweepsInARow < 8) ? (_fastSweepsInARow + 1) : 0);
			_catchUpGap = GapAfter(_fastSweepsInARow);
		}
		catch
		{
			_catchUpGap = WhenItIsSettled;
			_fastSweepsInARow = 0;
		}
		finally
		{
			_draining = false;
		}
	}

	internal static TimeSpan GapAfter(int fastSweepsInARow)
	{
		if (fastSweepsInARow <= 0)
		{
			return WhenItIsSettled;
		}
		return WhileTheScreenIsChanging;
	}
}
