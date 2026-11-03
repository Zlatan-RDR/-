using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;

namespace Miqbas.Engines.Unity.Plugin;

internal static class ArabicDirection
{
	private static readonly Dictionary<Type, PropertyInfo> Properties = new Dictionary<Type, PropertyInfo>();

	private static readonly HashSet<string> Complained = new HashSet<string>();

	private static readonly ConditionalWeakTable<object, object> Owned = new ConditionalWeakTable<object, object>();

	private static readonly object OwnedMark = new object();

	private static readonly ConditionalWeakTable<object, object> LaidOut = new ConditionalWeakTable<object, object>();

	internal static Action<string> Log = delegate
	{
	};

	internal static bool ContainsArabic(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return false;
		}
		foreach (char c in value)
		{
			if ((c >= '\u0600' && c <= 'ۿ') || (c >= 'ݐ' && c <= 'ݿ') || (c >= 'ࢠ' && c <= '\u08ff') || (c >= 'ﭐ' && c <= '﷿') || (c >= 'ﹰ' && c <= '\ufeff'))
			{
				return true;
			}
		}
		return false;
	}

	internal static void FollowText(object component, string value)
	{
		if (!ContainsArabic(value))
		{
			Release(component);
		}
		else if (AlreadyLaidOut(value))
		{
			LayOutLeftToRight(component);
		}
		else
		{
			ApplyTo(component);
		}
	}

	internal static bool LayOutLeftToRight(object component)
	{
		if (component == null)
		{
			return false;
		}
		try
		{
			PropertyInfo propertyInfo = PropertyFor(component.GetType());
			if (propertyInfo == null)
			{
				return true;
			}
			Owned.Remove(component);
			if (!LaidOut.TryGetValue(component, out var _))
			{
				LaidOut.Add(component, OwnedMark);
			}
			if ((bool)propertyInfo.GetValue(component, null))
			{
				propertyInfo.SetValue(component, false, null);
			}
			return !(bool)propertyInfo.GetValue(component, null);
		}
		catch (Exception e)
		{
			Complain(component.GetType(), WhyItFailed.Line(e));
			return false;
		}
	}

	internal static bool AlreadyLaidOut(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return false;
		}
		foreach (char c in value)
		{
			if ((c >= 'ﭐ' && c <= '﷿') || (c >= 'ﹰ' && c <= '\ufeff'))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool? IsRightToLeft(object component)
	{
		if (component == null)
		{
			return null;
		}
		try
		{
			return PropertyFor(component.GetType())?.GetValue(component, null) as bool?;
		}
		catch (Exception)
		{
			return null;
		}
	}

	internal static bool ApplyTo(object component)
	{
		if (component == null)
		{
			return false;
		}
		try
		{
			PropertyInfo propertyInfo = PropertyFor(component.GetType());
			if (propertyInfo == null)
			{
				Complain(component.GetType(), "لا تملك إعداد الاتجاه");
				return false;
			}
			MarkOwned(component);
			if (!(bool)propertyInfo.GetValue(component, null))
			{
				propertyInfo.SetValue(component, true, null);
			}
			if ((bool)propertyInfo.GetValue(component, null))
			{
				return true;
			}
			Complain(component.GetType(), "رفضت إعداد الاتجاه");
			return false;
		}
		catch (Exception e)
		{
			Complain(component.GetType(), WhyItFailed.Line(e));
			return false;
		}
	}

	internal static bool IsOwned(object component)
	{
		object value;
		if (component != null)
		{
			return Owned.TryGetValue(component, out value);
		}
		return false;
	}

	internal static void Release(object component)
	{
		if (component == null || !Owned.TryGetValue(component, out var _))
		{
			return;
		}
		try
		{
			Owned.Remove(component);
			PropertyFor(component.GetType())?.SetValue(component, false, null);
		}
		catch (Exception)
		{
		}
	}

	internal static void DefendOwnership(object patcher)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		try
		{
			Type type = AccessTools.TypeByName("TMPro.TMP_Text");
			MethodInfo methodInfo = ((type == null) ? null : AccessTools.PropertySetter(type, "isRightToLeftText"));
			if (!(methodInfo == null))
			{
				((Harmony)patcher).Patch((MethodBase)methodInfo, new HarmonyMethod(typeof(ArabicDirection).GetMethod("BeforeDirectionCleared", BindingFlags.Static | BindingFlags.NonPublic)), (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
			}
		}
		catch (Exception)
		{
		}
	}

	private static bool BeforeDirectionCleared(object __instance, bool value)
	{
		try
		{
			if (__instance == null)
			{
				return true;
			}
			string value2 = TextRegistry.GetterFor(__instance.GetType())?.Invoke(__instance, null) as string;
			if (value && LaidOut.TryGetValue(__instance, out var value3))
			{
				return !AlreadyLaidOut(value2);
			}
			if (!value && Owned.TryGetValue(__instance, out value3))
			{
				return !ContainsArabic(value2);
			}
			return true;
		}
		catch (Exception)
		{
			return true;
		}
	}

	private static void MarkOwned(object component)
	{
		if (!Owned.TryGetValue(component, out var _))
		{
			Owned.Add(component, OwnedMark);
		}
	}

	private static void Complain(Type type, string reason)
	{
		lock (Complained)
		{
			if (!Complained.Add(type.FullName))
			{
				return;
			}
		}
		Log("اتجاه النص لن يضبط في " + type.FullName + ": " + reason);
	}

	private static PropertyInfo PropertyFor(Type type)
	{
		lock (Properties)
		{
			if (Properties.TryGetValue(type, out var value))
			{
				return value;
			}
			PropertyInfo propertyInfo = type.GetProperty("isRightToLeftText", BindingFlags.Instance | BindingFlags.Public);
			if (propertyInfo != null && (!propertyInfo.CanWrite || propertyInfo.PropertyType != typeof(bool)))
			{
				propertyInfo = null;
			}
			Properties[type] = propertyInfo;
			return propertyInfo;
		}
	}
}
