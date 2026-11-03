using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Miqbas.Engines.Unity.Plugin;

internal static class ArabicLettersOnALegacyLabel
{
	private sealed class Own
	{
		internal object Font;

		internal int? Size;

		internal object Renderer;

		internal object Material;
	}

	private const string TheLabel = "UnityEngine.UI.Text";

	private const string SuperTextMesh = "SuperTextMesh";

	private const string TheMeshLabel = "UnityEngine.TextMesh";

	private const string TheFont = "UnityEngine.Font";

	private static readonly Dictionary<Type, PropertyInfo> FontOf = new Dictionary<Type, PropertyInfo>();

	private static readonly Dictionary<object, bool> DrawsArabic = new Dictionary<object, bool>();

	private static readonly ConditionalWeakTable<object, Own> TheGamesOwn = new ConditionalWeakTable<object, Own>();

	private static object _windowsFont;

	private static bool _windowsFontAsked;

	private static bool _saidOnce;

	internal static Action<string> Say = delegate(string line)
	{
		MiqbasPlugin.Log(line);
	};

	internal static void Follow(object label, string shown)
	{
		if (label == null || shown == null)
		{
			return;
		}
		try
		{
			PropertyInfo propertyInfo = FontPropertyOf(label.GetType());
			if (propertyInfo == null)
			{
				return;
			}
			Own value3;
			if (ArabicDirection.ContainsArabic(shown))
			{
				object value = propertyInfo.GetValue(label, null);
				if (value == null || Draws(value))
				{
					return;
				}
				object obj = AWindowsFontWithArabic(propertyInfo.PropertyType);
				if (obj == null)
				{
					return;
				}
				bool flag = IsAMeshLabel(label.GetType());
				if (!TheGamesOwn.TryGetValue(label, out var value2))
				{
					PropertyInfo propertyInfo2 = SizeProperty(label.GetType());
					value2 = new Own
					{
						Font = value,
						Size = (int?)propertyInfo2?.GetValue(label, null)
					};
					if (flag)
					{
						value2.Renderer = RendererOf(label);
						value2.Material = MaterialOn(value2.Renderer);
					}
					TheGamesOwn.Add(label, value2);
					int? size = value2.Size;
					int? obj2;
					if (size.HasValue)
					{
						int valueOrDefault = size.GetValueOrDefault();
						obj2 = (flag ? TheSizeAMeshLabelDrawsAt(value, valueOrDefault) : TheHeightOfAPictureFont(value, valueOrDefault));
					}
					else
					{
						obj2 = null;
					}
					int? num = obj2;
					if (propertyInfo2 != null && num.HasValue)
					{
						int valueOrDefault2 = num.GetValueOrDefault();
						propertyInfo2.SetValue(label, valueOrDefault2, null);
					}
				}
				propertyInfo.SetValue(label, obj, null);
				if (flag && value2.Renderer != null)
				{
					SetMaterial(value2.Renderer, obj.GetType().GetProperty("material")?.GetValue(obj, null));
				}
				if (!_saidOnce)
				{
					_saidOnce = true;
					Say("خط\u0651 لافتة\u064d في اللعبة لا يحمل العربية — أ\u064fعطيت خط\u064b\u0651ا من ويندوز يحملها.");
				}
			}
			else if (shown.Length > 0 && TheGamesOwn.TryGetValue(label, out value3))
			{
				propertyInfo.SetValue(label, value3.Font, null);
				int? size = value3.Size;
				if (size.HasValue)
				{
					int valueOrDefault3 = size.GetValueOrDefault();
					SizeProperty(label.GetType())?.SetValue(label, valueOrDefault3, null);
				}
				if (value3.Renderer != null)
				{
					SetMaterial(value3.Renderer, value3.Material);
				}
				TheGamesOwn.Remove(label);
			}
		}
		catch
		{
		}
	}

	internal static PropertyInfo FontPropertyOf(Type type)
	{
		if (FontOf.TryGetValue(type, out var value))
		{
			return value;
		}
		PropertyInfo propertyInfo = null;
		Type type2 = type;
		while (type2 != null)
		{
			bool flag;
			switch (type2.FullName)
			{
			case "UnityEngine.UI.Text":
			case "SuperTextMesh":
			case "UnityEngine.TextMesh":
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (flag)
			{
				PropertyInfo property = type2.GetProperty("font", BindingFlags.Instance | BindingFlags.Public);
				propertyInfo = ((property != null && property.PropertyType.FullName == "UnityEngine.Font" && property.CanWrite) ? property : null);
				break;
			}
			type2 = type2.BaseType;
		}
		FontOf[type] = propertyInfo;
		return propertyInfo;
	}

	private static bool IsAMeshLabel(Type type)
	{
		Type type2 = type;
		while (type2 != null)
		{
			if (type2.FullName == "UnityEngine.TextMesh")
			{
				return true;
			}
			type2 = type2.BaseType;
		}
		return false;
	}

	internal static int? TheSizeAMeshLabelDrawsAt(object font, int labelSize)
	{
		Type type = font.GetType();
		bool flag = default(bool);
		int num;
		if (labelSize > 0)
		{
			object obj = type.GetProperty("dynamic")?.GetValue(font, null);
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
		if (((uint)num & (flag ? 1u : 0u)) != 0)
		{
			return null;
		}
		int num4 = ((type.GetProperty("fontSize")?.GetValue(font, null) is int num2 && num2 > 0) ? num2 : ((type.GetProperty("lineHeight")?.GetValue(font, null) is int num3 && num3 > 0) ? num3 : 0));
		if (num4 <= 0 || num4 == labelSize)
		{
			return null;
		}
		return num4;
	}

	private static object RendererOf(object label)
	{
		return label.GetType().GetMethod("GetComponent", new Type[1] { typeof(string) })?.Invoke(label, new object[1] { "MeshRenderer" });
	}

	private static object MaterialOn(object renderer)
	{
		return renderer?.GetType().GetProperty("sharedMaterial")?.GetValue(renderer, null);
	}

	private static void SetMaterial(object renderer, object material)
	{
		if (material != null)
		{
			renderer?.GetType().GetProperty("sharedMaterial")?.SetValue(renderer, material, null);
		}
	}

	private static PropertyInfo SizeProperty(Type type)
	{
		PropertyInfo property = type.GetProperty("fontSize", BindingFlags.Instance | BindingFlags.Public);
		if (!(property != null) || !(property.PropertyType == typeof(int)) || !property.CanWrite)
		{
			return null;
		}
		return property;
	}

	internal static int? TheHeightOfAPictureFont(object font, int labelSize)
	{
		Type type = font.GetType();
		object obj = type.GetProperty("dynamic")?.GetValue(font, null);
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
		if (((uint)num & (flag ? 1u : 0u)) != 0)
		{
			return null;
		}
		if (!(type.GetProperty("lineHeight")?.GetValue(font, null) is int num2) || num2 <= 0)
		{
			return null;
		}
		int num4 = ((!(type.GetProperty("fontSize")?.GetValue(font, null) is int num3) || num3 <= 0) ? 1 : num3);
		int num5 = (int)Math.Round((double)num2 * (double)Math.Max(1, labelSize) / (double)num4);
		if (num5 <= labelSize)
		{
			return null;
		}
		return num5;
	}

	private static bool Draws(object font)
	{
		if (DrawsArabic.TryGetValue(font, out var value))
		{
			return value;
		}
		MethodInfo method = font.GetType().GetMethod("HasCharacter", new Type[1] { typeof(char) });
		value = method == null || (bool)method.Invoke(font, new object[1] { 'ع' });
		DrawsArabic[font] = value;
		return value;
	}

	private static object AWindowsFontWithArabic(Type fontType)
	{
		if (_windowsFontAsked)
		{
			return _windowsFont;
		}
		_windowsFontAsked = true;
		MethodInfo method = fontType.GetMethod("CreateDynamicFontFromOSFont", BindingFlags.Static | BindingFlags.Public, null, new Type[2]
		{
			typeof(string),
			typeof(int)
		}, null);
		if (method == null)
		{
			Say("لا تتيح هذه اللعبة إنشاء خط\u0651 من ويندوز للافتات — ستبقى بخط\u0651 اللعبة.");
			return null;
		}
		string[] array = new string[3] { "Segoe UI", "Tahoma", "Arial" };
		foreach (string text in array)
		{
			try
			{
				object obj = method.Invoke(null, new object[2] { text, 16 });
				if (obj != null && Draws(obj))
				{
					KeepAcrossScenes(obj);
					_windowsFont = obj;
					return obj;
				}
			}
			catch
			{
			}
		}
		Say("لم ي\u064fوجد على هذا الجهاز خط\u064c\u0651 يحمل العربية للافتات — ستبقى بخط\u0651 اللعبة.");
		return null;
	}

	private static void KeepAcrossScenes(object font)
	{
		Type type = font.GetType();
		while (type != null)
		{
			MethodInfo method = type.GetMethod("DontDestroyOnLoad", BindingFlags.Static | BindingFlags.Public);
			if (method != null && method.GetParameters().Length == 1)
			{
				method.Invoke(null, new object[1] { font });
				break;
			}
			type = type.BaseType;
		}
	}
}
