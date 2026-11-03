using System;
using System.Reflection;
using HarmonyLib;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Engines.Unity.Plugin;

internal static class KleiArabic
{
	internal const string MarkerFileName = "klei-arabic.txt";

	private static MethodInfo _fixup;

	private static Func<bool> _rightToLeft;

	internal static int Apply(Harmony harmony, Action<string> log)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		Type type = AccessTools.TypeByName("Localization");
		Type type2 = AccessTools.TypeByName("LocText");
		_fixup = ((type == null) ? null : AccessTools.Method(type, "Fixup", new Type[1] { typeof(string) }, (Type[])null));
		MethodInfo rtl = ((type == null) ? null : AccessTools.PropertyGetter(type, "IsRightToLeft"));
		if (_fixup == null || rtl == null || type2 == null)
		{
			log("لم ي\u064fوجد مشك\u0651ل اللعبة العربي (Localization.Fixup) — لا شيء ي\u064fعل\u064e\u0651ق.");
			return 0;
		}
		_rightToLeft = () => (bool)rtl.Invoke(null, null);
		int num = 0;
		try
		{
			harmony.Patch((MethodBase)_fixup, new HarmonyMethod(typeof(KleiArabic).GetMethod("BeforeFixup", BindingFlags.Static | BindingFlags.NonPublic)), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
			num++;
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر الوقوف أمام Localization.Fixup: " + WhyItFailed.Line(e));
			return 0;
		}
		num += Patch(harmony, type2, AccessTools.PropertySetter(type2, "text"), "BeforeTheSetter", log);
		num += Patch(harmony, type2, AccessTools.Method(type2, "SetText", new Type[1] { typeof(string) }, (Type[])null), "BeforeSetText", log);
		log("عربية اللعبة نفسها: الطبقة تمر\u0651ر نص وقت اللعب على مشك\u0651لها (" + num + " نقاط تعل\u0651ق).");
		return num;
	}

	private static int Patch(Harmony harmony, Type locText, MethodInfo target, string prefix, Action<string> log)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (target == null || target.DeclaringType != locText)
		{
			return 0;
		}
		try
		{
			harmony.Patch((MethodBase)target, new HarmonyMethod(typeof(KleiArabic).GetMethod(prefix, BindingFlags.Static | BindingFlags.NonPublic)), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
			return 1;
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر الوقوف أمام LocText." + target.Name + ": " + WhyItFailed.Line(e));
			return 0;
		}
	}

	internal static bool IsJoinedAlready(string text)
	{
		if (!string.IsNullOrEmpty(text) && ArabicDirection.AlreadyLaidOut(text))
		{
			return !ArabicShaper.ContainsArabic(text);
		}
		return false;
	}

	internal static bool WaitsForTheJoiner(string text)
	{
		if (!string.IsNullOrEmpty(text) && ArabicShaper.ContainsArabic(text))
		{
			return !ArabicDirection.AlreadyLaidOut(text);
		}
		return false;
	}

	private static bool BeforeFixup(string text, ref string __result)
	{
		try
		{
			if (IsJoinedAlready(text))
			{
				__result = text;
				return false;
			}
		}
		catch
		{
		}
		return true;
	}

	internal static string Finished(string value)
	{
		if (!WaitsForTheJoiner(value) || _fixup == null || !_rightToLeft())
		{
			return value;
		}
		return (string)_fixup.Invoke(null, new object[1] { value });
	}

	private static void BeforeTheSetter(ref string value)
	{
		try
		{
			value = Finished(value);
		}
		catch
		{
		}
	}

	private static void BeforeSetText(ref string text)
	{
		try
		{
			text = Finished(text);
		}
		catch
		{
		}
	}
}
