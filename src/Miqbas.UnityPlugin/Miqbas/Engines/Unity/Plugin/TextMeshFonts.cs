using System;
using System.Reflection;
using HarmonyLib;

namespace Miqbas.Engines.Unity.Plugin;

internal static class TextMeshFonts
{
	internal static int Apply(Harmony harmony, Action<string> log)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		try
		{
			Type type = AccessTools.TypeByName("UnityEngine.TextMesh");
			MethodInfo methodInfo = ((type == null) ? null : AccessTools.PropertySetter(type, "text"));
			if (methodInfo == null)
			{
				return 0;
			}
			harmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, new HarmonyMethod(typeof(TextMeshFonts).GetMethod("OnTextSet", BindingFlags.Static | BindingFlags.NonPublic)), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
			log("نقطة تعل\u0651ق: UnityEngine.TextMesh.text (خط\u0651 العربية وحده)");
			return 1;
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر التعل\u0651ق بـUnityEngine.TextMesh: " + WhyItFailed.Line(e));
			return 0;
		}
	}

	private static void OnTextSet(object __instance, string value)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			ArabicLettersOnALegacyLabel.Follow(__instance, value);
		}
		finally
		{
			FrameCost.Shared.Leave(started, "خط\u064f\u0651 TextMesh");
		}
	}
}
