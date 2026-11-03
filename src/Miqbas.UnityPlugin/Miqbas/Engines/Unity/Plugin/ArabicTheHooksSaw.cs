using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Miqbas.Engines.Unity.Plugin;

public static class ArabicTheHooksSaw
{
	private const int MostRemembered = 10000;

	private static readonly HashSet<int> Labels = new HashSet<int>();

	private static readonly Dictionary<string, int> ByKind = new Dictionary<string, int>(StringComparer.Ordinal);

	private static readonly Dictionary<Type, MethodInfo?> InstanceIds = new Dictionary<Type, MethodInfo>();

	private static int _nextSaid = 1;

	public static int Count => Labels.Count;

	public static string? Note(object label, string? value, bool ours)
	{
		if (label == null || Labels.Count >= 10000 || (!ours && (value == null || !ArabicDirection.ContainsArabic(value))))
		{
			return null;
		}
		if (!Labels.Add(IdOf(label)))
		{
			return null;
		}
		string name = label.GetType().Name;
		ByKind[name] = ((!ByKind.TryGetValue(name, out var value2)) ? 1 : (value2 + 1));
		if (Labels.Count < _nextSaid)
		{
			return null;
		}
		_nextSaid *= 10;
		return "الخطافات رأت عربية في " + Labels.Count + " لافتة: " + string.Join("، ", from k in ByKind
			orderby k.Value descending
			select k.Key + " " + k.Value);
	}

	public static void Forget()
	{
		Labels.Clear();
		ByKind.Clear();
		_nextSaid = 1;
	}

	private static int IdOf(object label)
	{
		Type type = label.GetType();
		if (!InstanceIds.TryGetValue(type, out MethodInfo value))
		{
			value = type.GetMethod("GetInstanceID", BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
			InstanceIds[type] = value;
		}
		if (value != null)
		{
			object obj = value.Invoke(label, null);
			if (obj is int)
			{
				return (int)obj;
			}
		}
		return RuntimeHelpers.GetHashCode(label);
	}
}
