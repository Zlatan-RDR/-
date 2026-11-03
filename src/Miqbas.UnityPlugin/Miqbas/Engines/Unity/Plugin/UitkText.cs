using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using HarmonyLib;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Engines.Unity.Plugin;

internal static class UitkText
{
	private const string TextElementName = "UnityEngine.UIElements.TextElement";

	internal const char Isolate = '\u2067';

	internal const char IsolateEnd = '\u2069';

	private const int MostTurned = 20000;

	private static readonly HashSet<string> Turned = new HashSet<string>(StringComparer.Ordinal);

	private static Type _textElement;

	private static MethodInfo _isAdvanced;

	private static MethodInfo _setRendered;

	private static MemberInfo _rendered;

	private static PropertyInfo _elementOfContext;

	private static MemberInfo _isInputField;

	private static MethodInfo _castToTextElement;

	private static int _translated;

	private static int _turnedCount;

	internal static int Apply(Harmony harmony, Action<string> log)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		_textElement = UiToolkitType("UnityEngine.UIElements.TextElement");
		if (_textElement == null)
		{
			log("لا يوجد UI Toolkit في هذه اللعبة — ي\u064fتخط\u0651ى.");
			return 0;
		}
		_isInputField = MemberNamed(_textElement, "isInputField");
		int num = 0;
		MethodInfo methodInfo = AccessTools.PropertySetter(_textElement, "text");
		if (methodInfo == null)
		{
			log("و\u064fجد UnityEngine.UIElements.TextElement بلا خاصية نص — ي\u064fتخط\u0651ى.");
		}
		else
		{
			try
			{
				harmony.Patch((MethodBase)methodInfo, new HarmonyMethod(typeof(UitkText).GetMethod("OnAssigned", BindingFlags.Static | BindingFlags.NonPublic)), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				log("نقطة تعل\u0651ق: UnityEngine.UIElements.TextElement.text");
				num++;
			}
			catch (Exception e)
			{
				log("تعذ\u0651ر التعل\u0651ق بـUnityEngine.UIElements.TextElement: " + WhyItFailed.Line(e));
			}
		}
		return num + WatchTheAdvancedGenerator(harmony, log);
	}

	private static int WatchTheAdvancedGenerator(Harmony harmony, Action<string> log)
	{
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		Type type = UiToolkitType("UnityEngine.UIElements.TextUtilities");
		_isAdvanced = ((type == null) ? null : AccessTools.Method(type, "IsAdvancedTextEnabledForElement", (Type[])null, (Type[])null));
		if (_isAdvanced == null)
		{
			return 0;
		}
		_setRendered = AccessTools.Method(_textElement, "SetRenderedText", new Type[1] { typeof(string) }, (Type[])null);
		_rendered = MemberNamed(_textElement, "m_RenderedText");
		MethodInfo methodInfo = AccessTools.Method(_textElement, "OnGenerateVisualContent", (Type[])null, (Type[])null);
		Type type2 = UiToolkitType("UnityEngine.UIElements.MeshGenerationContext");
		_elementOfContext = ((type2 == null) ? null : AccessTools.Property(type2, "visualElement"));
		if (_setRendered == null || _rendered == null || methodInfo == null || _elementOfContext == null)
		{
			log("مول\u0651د النص المتقد\u0651م موجود ولم أجد ما ي\u064fرت\u064e\u0651ب به:" + ((_setRendered == null) ? " SetRenderedText" : "") + ((_rendered == null) ? " m_RenderedText" : "") + ((methodInfo == null) ? " OnGenerateVisualContent" : "") + ((_elementOfContext == null) ? " visualElement" : ""));
			return 0;
		}
		try
		{
			string name = (methodInfo.IsStatic ? "BeforeDrawingFromContext" : "BeforeDrawingItself");
			harmony.Patch((MethodBase)methodInfo, new HarmonyMethod(typeof(UitkText).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic)), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
			log("نقطة تعل\u0651ق: رسم UI Toolkit (المول\u0651د المتقد\u0651م)");
			return 1;
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر التعل\u0651ق برسم UI Toolkit: " + WhyItFailed.Line(e));
			return 0;
		}
	}

	private static void OnAssigned(object __instance, ref string value)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			WhenAssigned(__instance, ref value);
		}
		finally
		{
			FrameCost.Shared.Leave(started, "إسناد\u064f نص\u0651 UI Toolkit");
		}
	}

	private static void WhenAssigned(object element, ref string value)
	{
		try
		{
			if (string.IsNullOrEmpty(value) || IsTypedByThePlayer(element))
			{
				return;
			}
			Hotkeys.Poll();
			TextHooks.DrainInstantTranslations();
			string text = MiqbasPlugin.Translations?.Find(value);
			string text2 = MiqbasPlugin.Drew?.Record(value, text != null || ArabicDirection.ContainsArabic(value));
			if (text2 != null)
			{
				MiqbasPlugin.Log(text2);
			}
			MiqbasPlugin.Places?.Saw(value, text, null);
			if (text != null)
			{
				TextRegistry.Remember(element, value);
				if (!MiqbasPlugin.ShowOriginal)
				{
					Hotkeys.NoteTranslated(value);
					value = Laid(text);
					NoteTranslated();
				}
			}
			else if (!ArabicDirection.ContainsArabic(value))
			{
				MiqbasPlugin.Observer?.Record(value);
				MiqbasPlugin.CameFrom?.Record(value);
				if (!MiqbasPlugin.ShowOriginal)
				{
					TextRegistry.Remember(element, value);
					MiqbasPlugin.Instant?.Request(value);
				}
			}
			else if (!HandedWords.IsOurVisual(value) && !IsTurned(value) && !MiqbasPlugin.FilesRepaired && !IsAdvanced(element))
			{
				value = Laid(value);
			}
		}
		catch
		{
		}
	}

	internal static string Laid(string arabic)
	{
		string text = ArabicVisualOrder.ToVisual(ArabicShaper.Shape(arabic));
		HandedWords.NoteVisual(text);
		return text;
	}

	internal static string ForTheAdvancedGenerator(string drawn)
	{
		if (string.IsNullOrEmpty(drawn) || IsTurned(drawn) || !HasShapedArabic(drawn))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(drawn.Length + 8);
		int num = 0;
		for (int i = 0; i <= drawn.Length; i++)
		{
			if (i >= drawn.Length || drawn[i] == '\n')
			{
				int num2 = i;
				if (num2 > num && drawn[num2 - 1] == '\r')
				{
					num2--;
				}
				string text = drawn.Substring(num, num2 - num);
				if (HasShapedArabic(text))
				{
					stringBuilder.Append('\u2067').Append(ArabicVisualOrder.ToVisual(text)).Append('\u2069');
				}
				else
				{
					stringBuilder.Append(text);
				}
				if (i < drawn.Length)
				{
					stringBuilder.Append(drawn, num2, i - num2 + 1);
				}
				num = i + 1;
			}
		}
		return stringBuilder.ToString();
	}

	internal static bool TurnTheDrawnCopy(object element, MemberInfo rendered, MethodInfo setRendered)
	{
		if (Read(rendered, element) is string drawn)
		{
			string text = ForTheAdvancedGenerator(drawn);
			if (text != null)
			{
				setRendered.Invoke(element, new object[1] { text });
				lock (Turned)
				{
					if (Turned.Count < 20000)
					{
						Turned.Add(text);
					}
				}
				return true;
			}
		}
		return false;
	}

	private static void BeforeDrawingFromContext(object __0)
	{
		object element = null;
		try
		{
			element = ((__0 == null) ? null : _elementOfContext.GetValue(__0, null));
		}
		catch
		{
		}
		BeforeDrawing(element);
	}

	private static void BeforeDrawingItself(object __instance)
	{
		BeforeDrawing(__instance);
	}

	private static void BeforeDrawing(object element)
	{
		long started = FrameCost.Shared.Enter();
		try
		{
			if (element != null && IsAdvanced(element))
			{
				object obj = AsTextElement(element);
				if (obj != null && TurnTheDrawnCopy(obj, _rendered, _setRendered))
				{
					NoteTurned();
				}
			}
		}
		catch
		{
		}
		finally
		{
			FrameCost.Shared.Leave(started, "رسم\u064f UI Toolkit");
		}
	}

	private static bool IsAdvanced(object element)
	{
		if (_isAdvanced == null || element == null)
		{
			return false;
		}
		try
		{
			object obj = _isAdvanced.Invoke(null, new object[1] { element });
			bool flag = default(bool);
			int num;
			if (obj is bool)
			{
				flag = (bool)obj;
				num = 1;
			}
			else
			{
				num = 0;
			}
			return (byte)((uint)num & (flag ? 1u : 0u)) != 0;
		}
		catch
		{
			return false;
		}
	}

	private static bool IsTypedByThePlayer(object element)
	{
		try
		{
			bool flag = default(bool);
			int num;
			if (_isInputField != null)
			{
				object obj = Read(_isInputField, element);
				if (obj is bool)
				{
					flag = (bool)obj;
					num = 1;
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
			}
			return (byte)((uint)num & (flag ? 1u : 0u)) != 0;
		}
		catch
		{
			return false;
		}
	}

	private static object AsTextElement(object element)
	{
		if (element == null || _textElement == null)
		{
			return null;
		}
		if (_textElement.IsInstanceOfType(element))
		{
			return element;
		}
		try
		{
			if (_castToTextElement == null)
			{
				MethodInfo method = element.GetType().GetMethod("TryCast", BindingFlags.Instance | BindingFlags.Public);
				if (method == null || !method.IsGenericMethodDefinition)
				{
					return null;
				}
				_castToTextElement = method.MakeGenericMethod(_textElement);
			}
			return _castToTextElement.Invoke(element, null);
		}
		catch
		{
			return null;
		}
	}

	internal static bool HasShapedArabic(string text)
	{
		foreach (char c in text)
		{
			if ((c >= 'ﭐ' && c <= '﷿') || (c >= 'ﹰ' && c <= '\ufefe'))
			{
				return true;
			}
		}
		return false;
	}

	private static bool IsTurned(string text)
	{
		if (text.Length > 0 && text[0] == '\u2067')
		{
			return true;
		}
		lock (Turned)
		{
			return Turned.Contains(text);
		}
	}

	private static void NoteTurned()
	{
		_turnedCount++;
		bool flag;
		switch (_turnedCount)
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
			MiqbasPlugin.Log($"UI Toolkit: ر\u064fت\u0651ب {_turnedCount} سطر\u064bا للمول\u0651د المتقد\u0651م.");
		}
	}

	private static void NoteTranslated()
	{
		_translated++;
		bool flag;
		switch (_translated)
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
			MiqbasPlugin.Log($"UI Toolkit: ع\u064fر\u0651ب {_translated} سطر\u064bا.");
		}
	}

	private static Type UiToolkitType(string name)
	{
		return Type.GetType(name + ", UnityEngine.UIElementsModule", throwOnError: false) ?? AccessTools.TypeByName(name);
	}

	private static MemberInfo MemberNamed(Type type, string name)
	{
		return (MemberInfo)(((object)AccessTools.Property(type, name)) ?? ((object)AccessTools.Field(type, name)));
	}

	private static object Read(MemberInfo member, object target)
	{
		if (!(member is PropertyInfo propertyInfo))
		{
			if (member is FieldInfo fieldInfo)
			{
				return fieldInfo.GetValue(target);
			}
			return null;
		}
		return propertyInfo.GetValue(target, null);
	}
}
