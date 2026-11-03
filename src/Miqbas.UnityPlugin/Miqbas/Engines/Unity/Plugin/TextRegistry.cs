using System;
using System.Collections.Generic;
using System.Reflection;

namespace Miqbas.Engines.Unity.Plugin;

internal static class TextRegistry
{
	private const int Capacity = 256;

	private static readonly WeakReference[] Components = new WeakReference[256];

	private static readonly string[] Originals = new string[256];

	private static readonly Dictionary<Type, MethodInfo> Setters = new Dictionary<Type, MethodInfo>();

	private static readonly Dictionary<Type, MethodInfo> Getters = new Dictionary<Type, MethodInfo>();

	private static readonly object Gate = new object();

	private static int _next;

	internal static void Remember(object component, string original)
	{
		if (component == null || string.IsNullOrEmpty(original))
		{
			return;
		}
		lock (Gate)
		{
			for (int i = 0; i < 256; i++)
			{
				if (Components[i] != null && Components[i].Target == component)
				{
					Originals[i] = original;
					return;
				}
			}
			Components[_next] = new WeakReference(component);
			Originals[_next] = original;
			_next = (_next + 1) % 256;
		}
	}

	internal static string OriginalOf(object component)
	{
		if (component == null)
		{
			return null;
		}
		lock (Gate)
		{
			for (int i = 0; i < 256; i++)
			{
				if (Components[i] != null && Components[i].Target == component)
				{
					return Originals[i];
				}
			}
		}
		return null;
	}

	internal static int Reapply()
	{
		int num = 0;
		object[] array;
		string[] array2;
		lock (Gate)
		{
			array = new object[256];
			array2 = new string[256];
			for (int i = 0; i < 256; i++)
			{
				array[i] = Components[i]?.Target;
				array2[i] = Originals[i];
			}
		}
		for (int j = 0; j < 256; j++)
		{
			if (array[j] == null || string.IsNullOrEmpty(array2[j]))
			{
				continue;
			}
			try
			{
				MethodInfo methodInfo = GetterFor(array[j].GetType());
				MethodInfo methodInfo2 = SetterFor(array[j].GetType());
				if (!(methodInfo == null) && !(methodInfo2 == null) && methodInfo.Invoke(array[j], null) is string showing && MayWriteTo(showing, array2[j]))
				{
					methodInfo2.Invoke(array[j], new object[1] { array2[j] });
					num++;
				}
			}
			catch
			{
			}
		}
		return num;
	}

	private static bool MayWriteTo(string showing, string original)
	{
		if (string.IsNullOrEmpty(showing))
		{
			return true;
		}
		if (!string.Equals(showing, original, StringComparison.Ordinal))
		{
			return ArabicDirection.ContainsArabic(showing);
		}
		return true;
	}

	internal static string WhatIsRemembered()
	{
		int num = 0;
		lock (Gate)
		{
			for (int i = 0; i < 256; i++)
			{
				if (Components[i]?.Target != null)
				{
					num++;
				}
			}
		}
		return num + " من " + 256;
	}

	internal static MethodInfo GetterFor(Type type)
	{
		lock (Gate)
		{
			if (Getters.TryGetValue(type, out var value))
			{
				return value;
			}
			MethodInfo methodInfo = type.GetProperty("text", BindingFlags.Instance | BindingFlags.Public)?.GetGetMethod();
			Getters[type] = methodInfo;
			return methodInfo;
		}
	}

	internal static MethodInfo SetterFor(Type type)
	{
		lock (Gate)
		{
			if (Setters.TryGetValue(type, out var value))
			{
				return value;
			}
			MethodInfo methodInfo = type.GetProperty("text", BindingFlags.Instance | BindingFlags.Public)?.GetSetMethod();
			Setters[type] = methodInfo;
			return methodInfo;
		}
	}
}
