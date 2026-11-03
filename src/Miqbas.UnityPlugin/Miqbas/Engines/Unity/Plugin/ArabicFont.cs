using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace Miqbas.Engines.Unity.Plugin;

internal static class ArabicFont
{
	private static readonly string[] WindowsFallbacks = new string[3] { "C:\\Windows\\Fonts\\segoeui.ttf", "C:\\Windows\\Fonts\\tahoma.ttf", "C:\\Windows\\Fonts\\arial.ttf" };

	private static bool _attempted;

	private static byte[] _fontData;

	private const string ArabicProbe = "ابجد";

	private static readonly Dictionary<MethodBase, MethodInfo> LoadFromBytes = new Dictionary<MethodBase, MethodInfo>();

	internal static Font Token { get; private set; }

	internal static bool Installed { get; private set; }

	internal static void EnsureInstalled(string workDirectory, Harmony harmony, Action<string> log)
	{
		if (_attempted)
		{
			return;
		}
		_attempted = true;
		try
		{
			Installed = Install(workDirectory, harmony, log);
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر تركيب الخط العربي: " + WhyItFailed.Line(e));
		}
	}

	private static bool Install(string workDirectory, Harmony harmony, Action<string> log)
	{
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		Type fontAssetType = AccessTools.TypeByName("TMPro.TMP_FontAsset");
		if (fontAssetType == null)
		{
			log("لا يوجد TextMeshPro في هذه اللعبة — لا حاجة لخط بديل.");
			return false;
		}
		string text = FindFontFile(workDirectory, log);
		if (text == null)
		{
			return false;
		}
		_fontData = File.ReadAllBytes(text);
		log("ملف الخط: " + text + " (" + _fontData.Length / 1024 + " كيلوبايت).");
		Token = Font.CreateDynamicFontFromOSFont("Segoe UI", 42);
		if ((Object)(object)Token == (Object)null)
		{
			log("تعذ\u0651ر إنشاء كائن الخط.");
			return false;
		}
		Object.DontDestroyOnLoad((Object)(object)Token);
		if (!InterceptFontDataReads(harmony, log))
		{
			return false;
		}
		MethodInfo create = AccessTools.Method(fontAssetType, "CreateFontAsset", new Type[1] { typeof(Font) }, (Type[])null);
		if (create == null)
		{
			log("نسخة TextMeshPro هنا لا تتيح إنشاء خط وقت التشغيل.");
			return false;
		}
		object obj = TheFirstThatAnswers(() => create.Invoke(null, new object[1] { Token }), () => CreateTheLongWay(fontAssetType, log), log);
		if (obj == null)
		{
			Type type = fontAssetType.Assembly.GetType("TMPro.TMP_Settings");
			if ((object)type != null && GiveItSettingsIfItHasNone(type, (Type t) => ScriptableObject.CreateInstance(t), log))
			{
				obj = TheFirstThatAnswers(() => create.Invoke(null, new object[1] { Token }), () => CreateTheLongWay(fontAssetType, log), log);
			}
		}
		if (obj == null)
		{
			log("تعذ\u0651ر إنشاء أصل الخط.");
			return false;
		}
		if (!CanDrawArabic(obj, log))
		{
			log("الخط المبني لا يرسم العربية — ت\u064fرك خط اللعبة كما هو.");
			return false;
		}
		Object.DontDestroyOnLoad((Object)obj);
		int num = RegisterGlobally(obj, log) + RegisterOnEveryLoadedFont(fontAssetType, obj, log);
		log("الخط العربي ر\u064fك\u0651ب، وس\u064fج\u0651ل في " + num + " موضع\u064bا.");
		return num > 0;
	}

	internal static MethodInfo? TheProbeOf(Type fontAssetType)
	{
		return TheArabicProbe.Of(fontAssetType);
	}

	private static bool CanDrawArabic(object asset, Action<string> log)
	{
		try
		{
			MethodInfo methodInfo = TheProbeOf(asset.GetType());
			if (methodInfo == null)
			{
				return true;
			}
			return Convert.ToBoolean(methodInfo.Invoke(asset, TheArabicProbe.Arguments(methodInfo, "ابجد")));
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر فحص الخط المبني: " + WhyItFailed.Line(e));
			return true;
		}
	}

	internal static object TheFirstThatAnswers(Func<object> shortForm, Func<object> longWay, Action<string> log)
	{
		try
		{
			object obj = shortForm();
			if (obj != null)
			{
				return obj;
			}
		}
		catch (Exception e)
		{
			log("باب الخط «CreateFontAsset(خط)» مقفل: " + WhyItFailed.Line(e));
		}
		return longWay();
	}

	internal static bool GiveItSettingsIfItHasNone(Type settings, Func<Type, object> make, Action<string> log)
	{
		try
		{
			FieldInfo fieldInfo = settings.GetField("s_Instance", BindingFlags.Static | BindingFlags.NonPublic) ?? settings.GetFields(BindingFlags.Static | BindingFlags.NonPublic).FirstOrDefault((FieldInfo f) => f.FieldType == settings);
			if (fieldInfo == null || fieldInfo.GetValue(null) != null)
			{
				return false;
			}
			fieldInfo.SetValue(null, make(settings));
			log("اللعبة لم تحم\u0651ل إعدادات TextMeshPro (" + settings.Name + ") — أ\u064fعطيت إعدادات فارغة في الذاكرة لبناء الخط.");
			return true;
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر إعطاء إعدادات TextMeshPro: " + WhyItFailed.Line(e));
			return false;
		}
	}

	private static object CreateTheLongWay(Type fontAssetType, Action<string> log)
	{
		MethodInfo[] methods = fontAssetType.GetMethods(BindingFlags.Static | BindingFlags.Public);
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name != "CreateFontAsset")
			{
				continue;
			}
			ParameterInfo[] parameters = methodInfo.GetParameters();
			if (parameters.Length < 5 || parameters[0].ParameterType != typeof(Font))
			{
				continue;
			}
			try
			{
				object[] array = new object[parameters.Length];
				array[0] = Token;
				for (int j = 1; j < parameters.Length; j++)
				{
					array[j] = ArgumentFor(parameters[j]);
				}
				object obj = methodInfo.Invoke(null, array);
				if (obj != null)
				{
					log("أصل الخط أ\u064fنشئ بالطريق الطويل.");
					return obj;
				}
			}
			catch (Exception e)
			{
				log("الطريق الطويل لإنشاء الخط لم ينجح: " + WhyItFailed.Line(e));
			}
		}
		return null;
	}

	private static object ArgumentFor(ParameterInfo parameter)
	{
		if (parameter.ParameterType.IsEnum)
		{
			int value = ((!(parameter.ParameterType.Name == "GlyphRenderMode")) ? 1 : 4161);
			return Enum.ToObject(parameter.ParameterType, value);
		}
		if (parameter.ParameterType == typeof(bool))
		{
			return true;
		}
		return parameter.Name switch
		{
			"samplingPointSize" => 90, 
			"atlasPadding" => 9, 
			"atlasWidth" => 1024, 
			"atlasHeight" => 1024, 
			_ => parameter.HasDefaultValue ? parameter.DefaultValue : ((object)0), 
		};
	}

	private static string FindFontFile(string workDirectory, Action<string> log)
	{
		string text = Path.Combine(workDirectory, "font.ttf");
		if (File.Exists(text))
		{
			return text;
		}
		string[] windowsFallbacks = WindowsFallbacks;
		foreach (string text2 in windowsFallbacks)
		{
			if (File.Exists(text2))
			{
				return text2;
			}
		}
		log("لم ي\u064fعثر على أي ملف خط عربي على هذا الجهاز.");
		return null;
	}

	private static bool InterceptFontDataReads(Harmony harmony, Action<string> log)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		Type type = FindLoadedType("UnityEngine.TextCore.LowLevel.FontEngine");
		if (type == null)
		{
			log("لا يوجد محر\u0651ك خطوط (FontEngine) في هذه اللعبة — قد يفشل بناء الخط.");
			return false;
		}
		HarmonyMethod val = new HarmonyMethod(AccessTools.Method(typeof(ArabicFont), "BeforeLoadFontFace", (Type[])null, (Type[])null));
		MethodInfo[] array = (from m in type.GetMethods(BindingFlags.Static | BindingFlags.Public)
			where m.Name == "LoadFontFace"
			select m).ToArray();
		int num = 0;
		MethodInfo[] array2 = array;
		foreach (MethodInfo methodInfo in array2)
		{
			ParameterInfo[] parameters = methodInfo.GetParameters();
			if (parameters.Length != 0 && !(parameters[0].ParameterType != typeof(Font)))
			{
				MethodInfo methodInfo2 = array.FirstOrDefault((MethodInfo candidate) => TakesTheFileInstead(candidate, parameters, typeof(Font), typeof(byte[])));
				if (!(methodInfo2 == null))
				{
					LoadFromBytes[methodInfo] = methodInfo2;
					harmony.Patch((MethodBase)methodInfo, val, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
					num++;
				}
			}
		}
		if (num == 0)
		{
			log("لم ي\u064fعثر على نقطة تحميل الخط — قد يفشل بناء الخط.");
			return false;
		}
		log("نقاط قراءة الخط المعتر\u064eضة: " + num + ".");
		return true;
	}

	internal static bool TakesTheFileInstead(MethodInfo candidate, ParameterInfo[] wanted, Type fontType, Type bytesType)
	{
		ParameterInfo[] parameters = candidate.GetParameters();
		if (wanted.Length == 0 || wanted[0].ParameterType != fontType)
		{
			return false;
		}
		if (parameters.Length != wanted.Length || parameters[0].ParameterType != bytesType)
		{
			return false;
		}
		for (int i = 1; i < parameters.Length; i++)
		{
			if (parameters[i].ParameterType != wanted[i].ParameterType)
			{
				return false;
			}
		}
		return true;
	}

	private static bool BeforeLoadFontFace(MethodBase __originalMethod, object[] __args, ref object __result)
	{
		try
		{
			if (_fontData == null || __args == null || __args.Length == 0 || __args[0] != Token || !LoadFromBytes.TryGetValue(__originalMethod, out var value))
			{
				return true;
			}
			object[] array = new object[__args.Length];
			array[0] = _fontData;
			for (int i = 1; i < __args.Length; i++)
			{
				array[i] = __args[i];
			}
			return Convert.ToInt32(__result = value.Invoke(null, array)) != 0;
		}
		catch (Exception)
		{
			return true;
		}
	}

	private static Type FindLoadedType(string fullName)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			Type[] source;
			try
			{
				source = assembly.GetTypes();
			}
			catch (ReflectionTypeLoadException ex)
			{
				source = ex.Types.Where((Type t) => t != null).ToArray();
			}
			catch
			{
				continue;
			}
			Type type = source.FirstOrDefault((Type t) => t.FullName == fullName);
			if (type != null)
			{
				return type;
			}
		}
		return null;
	}

	private static int RegisterGlobally(object asset, Action<string> log)
	{
		Type type = AccessTools.TypeByName("TMPro.TMP_Settings");
		if (type != null)
		{
			IList list = TheGlobalFallbackList(type, log);
			if (list != null)
			{
				list.Insert(0, asset);
				return 1;
			}
		}
		log("لا توجد قائمة خطوط احتياطية عامة — ي\u064fكتفى بالخطوط المحم\u0651لة.");
		return 0;
	}

	internal static IList? TheGlobalFallbackList(Type settingsType, Action<string> log)
	{
		if (settingsType.GetProperty("fallbackFontAssets", BindingFlags.Static | BindingFlags.Public)?.GetValue(null, null) is IList result)
		{
			return result;
		}
		object obj = (settingsType.GetField("s_Instance", BindingFlags.Static | BindingFlags.NonPublic) ?? settingsType.GetFields(BindingFlags.Static | BindingFlags.NonPublic).FirstOrDefault((FieldInfo f) => f.FieldType == settingsType))?.GetValue(null);
		FieldInfo field = settingsType.GetField("m_fallbackFontAssets", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (obj == null || field == null || !typeof(IList).IsAssignableFrom(field.FieldType) || field.FieldType.IsAbstract)
		{
			return null;
		}
		if (field.GetValue(obj) is IList result2)
		{
			return result2;
		}
		IList list = (IList)Activator.CreateInstance(field.FieldType);
		field.SetValue(obj, list);
		log("قائمة الخطوط الاحتياطية العامة كانت فارغة الإعدادات — أ\u064fنشئت لي\u064fسج\u064e\u0651ل فيها الخط العربي.");
		return list;
	}

	private static int RegisterOnEveryLoadedFont(Type fontAssetType, object asset, Action<string> log)
	{
		FieldInfo fieldInfo = AccessTools.Field(fontAssetType, "m_FallbackFontAssetTable") ?? AccessTools.Field(fontAssetType, "fallbackFontAssetTable");
		PropertyInfo propertyInfo = AccessTools.Property(fontAssetType, "fallbackFontAssetTable");
		int num = 0;
		Object[] array = Resources.FindObjectsOfTypeAll(fontAssetType);
		foreach (Object val in array)
		{
			if (val == asset)
			{
				continue;
			}
			try
			{
				if (((fieldInfo != null) ? fieldInfo.GetValue(val) : ((propertyInfo == null) ? null : propertyInfo.GetValue(val))) is IList list && !list.Contains(asset))
				{
					list.Insert(0, asset);
					num++;
				}
			}
			catch (Exception)
			{
			}
		}
		return num;
	}
}
