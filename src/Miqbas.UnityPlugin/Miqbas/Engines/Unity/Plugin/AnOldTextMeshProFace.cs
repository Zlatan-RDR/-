using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Miqbas.Rendering.Arabic.Faces;

namespace Miqbas.Engines.Unity.Plugin;

internal static class AnOldTextMeshProFace
{
	private sealed class ACopy
	{
		internal string Namespace;

		internal Type FontAsset;

		internal object Face;

		internal bool Failed;

		internal int HungIn;
	}

	private static readonly string[] Namespaces = new string[2] { "TMProOld", "TMPro" };

	private static readonly List<ACopy> Copies = new List<ACopy>();

	private static string _workDirectory;

	private static Action<string> _log;

	private static bool _building;

	internal static int Apply(Harmony harmony, string workDirectory, Action<string> log)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		try
		{
			if (!File.Exists(Path.Combine(workDirectory, "font.atlas.txt")))
			{
				return 0;
			}
			_workDirectory = workDirectory;
			_log = log;
			HarmonyMethod val = new HarmonyMethod(typeof(AnOldTextMeshProFace).GetMethod("OnFontLoaded", BindingFlags.Static | BindingFlags.NonPublic));
			string[] namespaces = Namespaces;
			foreach (string text in namespaces)
			{
				Type type = AccessTools.TypeByName(text + ".TMP_FontAsset");
				if (type == null || !OfTheBakedGeneration(type))
				{
					continue;
				}
				MethodInfo methodInfo = AccessTools.Method(type, "OnEnable", (Type[])null, (Type[])null);
				if (methodInfo == null)
				{
					log("في اللعبة TextMeshPro قديم (" + text + ") ولا ي\u064fعرف متى ت\u064fحم\u064e\u0651ل خطوطه — لن ي\u064fعطى وجه\u064bا عربي\u064b\u0651ا.");
					continue;
				}
				ACopy aCopy = new ACopy
				{
					Namespace = text,
					FontAsset = type
				};
				Copies.Add(aCopy);
				harmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, val, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
				log("نقطة تعل\u0651ق: " + text + ".TMP_FontAsset.OnEnable (وجه عربي من الصفحة المخبوزة)");
				foreach (object item in AllLoaded(type))
				{
					HangIn(aCopy, item);
				}
			}
			return Copies.Count;
		}
		catch (Exception e)
		{
			log("تعذ\u0651ر الوجه العربي لـTextMeshPro القديم: " + WhyItFailed.Line(e));
			return 0;
		}
	}

	internal static bool OfTheBakedGeneration(Type fontAsset)
	{
		if (fontAsset.GetMethod("AddGlyphInfo") == null || fontAsset.GetMethod("ReadFontDefinition") == null)
		{
			return false;
		}
		MethodInfo[] methods = fontAsset.GetMethods(BindingFlags.Static | BindingFlags.Public);
		for (int i = 0; i < methods.Length; i++)
		{
			if (methods[i].Name == "CreateFontAsset")
			{
				return false;
			}
		}
		return true;
	}

	private static void OnFontLoaded(object __instance)
	{
		try
		{
			foreach (ACopy copy in Copies)
			{
				if (copy.FontAsset.IsInstanceOfType(__instance))
				{
					HangIn(copy, __instance);
					break;
				}
			}
		}
		catch
		{
		}
	}

	private static void HangIn(ACopy copy, object font)
	{
		if (font == null || copy.Failed || _building || font == copy.Face || (copy.Face == null && Build(copy, font) == null))
		{
			return;
		}
		FieldInfo field = copy.FontAsset.GetField("fallbackFontAssets", BindingFlags.Instance | BindingFlags.Public);
		if (field == null)
		{
			return;
		}
		IList list = field.GetValue(font) as IList;
		if (list == null)
		{
			list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(copy.FontAsset));
			field.SetValue(font, list);
		}
		if (!list.Contains(copy.Face))
		{
			list.Add(copy.Face);
			copy.HungIn++;
			int hungIn = copy.HungIn;
			if ((hungIn == 1 || hungIn == 10 || hungIn == 50) ? true : false)
			{
				_log("الوجه العربي ع\u064fل\u0651ق في " + copy.HungIn + " من خطوط " + copy.Namespace + ".");
			}
		}
	}

	private static object Build(ACopy copy, object source)
	{
		object obj = copy.FontAsset.GetField("material", BindingFlags.Instance | BindingFlags.Public)?.GetValue(source);
		if (obj == null)
		{
			return null;
		}
		_building = true;
		try
		{
			ABakedFaceTable aBakedFaceTable = ABakedFaceTable.Read(File.ReadAllText(Path.Combine(_workDirectory, "font.atlas.txt")));
			byte[] array = File.ReadAllBytes(Path.Combine(_workDirectory, "font.atlas.bin"));
			if (aBakedFaceTable == null || array.Length != aBakedFaceTable.Width * aBakedFaceTable.Height)
			{
				copy.Failed = true;
				_log("صفحة الحروف المخبوزة بجانب الطبقة لا تطابق جدولها — لن ي\u064fبنى الوجه العربي لـ" + copy.Namespace + ".");
				return null;
			}
			object texture = APage(aBakedFaceTable, array);
			object material = AMaterial(obj, texture, aBakedFaceTable);
			copy.Face = AFace(copy, aBakedFaceTable, texture, material);
			GlobalFallbacks(copy)?.Add(copy.Face);
			_log("وجه\u064c عربي ب\u064fني لخطوط " + copy.Namespace + " من الصفحة المخبوزة: " + aBakedFaceTable.Letters.Count + " حرف\u064bا.");
			return copy.Face;
		}
		catch (Exception e)
		{
			copy.Failed = true;
			copy.Face = null;
			_log("تعذ\u0651ر بناء الوجه العربي لـ" + copy.Namespace + ": " + WhyItFailed.Line(e));
			return null;
		}
		finally
		{
			_building = false;
		}
	}

	private static object APage(ABakedFaceTable table, byte[] page)
	{
		Type type = AccessTools.TypeByName("UnityEngine.Texture2D");
		object obj = Enum.Parse(AccessTools.TypeByName("UnityEngine.TextureFormat"), "Alpha8");
		object obj2 = Activator.CreateInstance(type, table.Width, table.Height, obj, false);
		type.GetMethod("LoadRawTextureData", new Type[1] { typeof(byte[]) }).Invoke(obj2, new object[1] { page });
		type.GetProperty("wrapMode")?.SetValue(obj2, Enum.Parse(type.GetProperty("wrapMode").PropertyType, "Clamp"), null);
		type.GetMethod("Apply", new Type[2]
		{
			typeof(bool),
			typeof(bool)
		}).Invoke(obj2, new object[2] { false, true });
		Named(obj2, "Miqbas Arabic Atlas");
		return obj2;
	}

	private static object AMaterial(object source, object texture, ABakedFaceTable table)
	{
		Type type = source.GetType();
		object obj = Activator.CreateInstance(type, source);
		Type type2 = AccessTools.TypeByName("UnityEngine.Texture");
		type.GetMethod("SetTexture", new Type[2]
		{
			typeof(string),
			type2
		}).Invoke(obj, new object[2] { "_MainTex", texture });
		MethodInfo method = type.GetMethod("SetFloat", new Type[2]
		{
			typeof(string),
			typeof(float)
		});
		method.Invoke(obj, new object[2]
		{
			"_TextureWidth",
			(float)table.Width
		});
		method.Invoke(obj, new object[2]
		{
			"_TextureHeight",
			(float)table.Height
		});
		method.Invoke(obj, new object[2]
		{
			"_GradientScale",
			(float)(table.Padding + 1)
		});
		Named(obj, "Miqbas Arabic Material");
		return obj;
	}

	private static object AFace(ACopy copy, ABakedFaceTable table, object texture, object material)
	{
		object obj = Activator.CreateInstance(AccessTools.TypeByName(copy.Namespace + ".FaceInfo"));
		Set(obj, "Name", "Miqbas Arabic");
		Set(obj, "PointSize", table.PointSize);
		Set(obj, "Scale", 1f);
		Set(obj, "LineHeight", table.LineHeight);
		Set(obj, "Baseline", 0f);
		Set(obj, "Ascender", table.Ascent);
		Set(obj, "Descender", table.Descent);
		Set(obj, "CapHeight", table.Ascent * 0.72f);
		Set(obj, "CenterLine", table.Ascent * 0.52f);
		Set(obj, "SuperscriptOffset", table.Ascent);
		Set(obj, "SubscriptOffset", table.Descent);
		Set(obj, "SubSize", 0.5f);
		Set(obj, "Underline", table.Descent * 0.67f);
		Set(obj, "UnderlineThickness", Math.Max(1f, table.PointSize * 0.05f));
		Set(obj, "Padding", (float)table.Padding);
		Set(obj, "AtlasWidth", (float)table.Width);
		Set(obj, "AtlasHeight", (float)table.Height);
		Type type = AccessTools.TypeByName(copy.Namespace + ".TMP_Glyph");
		Array array = Array.CreateInstance(type, table.Letters.Count);
		for (int i = 0; i < table.Letters.Count; i++)
		{
			ABakedLetter letter = table.Letters[i];
			object obj2 = Activator.CreateInstance(type);
			Set(obj2, "id", letter.Unicode);
			Set(obj2, "x", (float)letter.X);
			Set(obj2, "y", (float)FromTheTop(letter, table.Height));
			Set(obj2, "width", (float)letter.W);
			Set(obj2, "height", (float)letter.H);
			Set(obj2, "xOffset", letter.BearingX);
			Set(obj2, "yOffset", letter.BearingY);
			Set(obj2, "xAdvance", letter.Advance);
			Set(obj2, "scale", 1f);
			array.SetValue(obj2, i);
		}
		object obj3 = AccessTools.Method(AccessTools.TypeByName("UnityEngine.ScriptableObject"), "CreateInstance", new Type[1] { typeof(Type) }, (Type[])null).Invoke(null, new object[1] { copy.FontAsset });
		Named(obj3, "Miqbas Arabic SDF");
		Type fontAsset = copy.FontAsset;
		FieldInfo field = fontAsset.GetField("fontAssetType", BindingFlags.Instance | BindingFlags.Public);
		field?.SetValue(obj3, Enum.Parse(field.FieldType, "SDF"));
		fontAsset.GetMethod("AddFaceInfo").Invoke(obj3, new object[1] { obj });
		fontAsset.GetMethod("AddGlyphInfo").Invoke(obj3, new object[1] { array });
		fontAsset.GetMethod("AddKerningInfo").Invoke(obj3, new object[1] { AKerningTable(copy) });
		fontAsset.GetField("atlas", BindingFlags.Instance | BindingFlags.Public).SetValue(obj3, texture);
		fontAsset.GetField("material", BindingFlags.Instance | BindingFlags.Public).SetValue(obj3, material);
		fontAsset.GetField("fallbackFontAssets", BindingFlags.Instance | BindingFlags.Public)?.SetValue(obj3, Activator.CreateInstance(typeof(List<>).MakeGenericType(fontAsset)));
		fontAsset.GetMethod("ReadFontDefinition").Invoke(obj3, null);
		return obj3;
	}

	internal static int FromTheTop(ABakedLetter letter, int pageHeight)
	{
		return pageHeight - letter.Y - letter.H;
	}

	private static object AKerningTable(ACopy copy)
	{
		Type type = AccessTools.TypeByName(copy.Namespace + ".KerningTable");
		object obj = Activator.CreateInstance(type);
		FieldInfo field = type.GetField("kerningPairs", BindingFlags.Instance | BindingFlags.Public);
		if (field != null && field.GetValue(obj) == null)
		{
			field.SetValue(obj, Activator.CreateInstance(field.FieldType));
		}
		return obj;
	}

	private static IList GlobalFallbacks(ACopy copy)
	{
		try
		{
			return AccessTools.Property(AccessTools.TypeByName(copy.Namespace + ".TMP_Settings"), "fallbackFontAssets")?.GetValue(null, null) as IList;
		}
		catch
		{
			return null;
		}
	}

	private static IEnumerable AllLoaded(Type fontAsset)
	{
		return ((AccessTools.TypeByName("UnityEngine.Resources")?.GetMethod("FindObjectsOfTypeAll", BindingFlags.Static | BindingFlags.Public, null, new Type[1] { typeof(Type) }, null))?.Invoke(null, new object[1] { fontAsset }) as IEnumerable) ?? Array.Empty<object>();
	}

	private static void Named(object unityObject, string name)
	{
		Type type = unityObject.GetType();
		type.GetProperty("name")?.SetValue(unityObject, name, null);
		PropertyInfo property = type.GetProperty("hideFlags");
		property?.SetValue(unityObject, Enum.ToObject(property.PropertyType, 32), null);
	}

	private static void Set(object target, string field, object value)
	{
		target.GetType().GetField(field, BindingFlags.Instance | BindingFlags.Public)?.SetValue(target, value);
	}
}
