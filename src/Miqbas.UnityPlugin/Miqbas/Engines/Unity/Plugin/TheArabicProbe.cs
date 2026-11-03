using System;
using System.Linq;
using System.Reflection;

namespace Miqbas.Engines.Unity.Plugin;

internal static class TheArabicProbe
{
	internal static MethodInfo? Of(Type fontAssetType)
	{
		return (from m in fontAssetType.GetMethods(BindingFlags.Instance | BindingFlags.Public)
			where m.Name == "TryAddCharacters" && m.ReturnType == typeof(bool)
			select (Method: m, Parameters: m.GetParameters()) into x
			where x.Parameters.Length >= 1 && x.Parameters[0].ParameterType == typeof(string) && x.Parameters.Skip(1).All((ParameterInfo p) => p.IsOut || p.IsOptional || p.ParameterType == typeof(bool))
			orderby x.Parameters.Length
			select x.Method).FirstOrDefault();
	}

	internal static object?[] Arguments(MethodInfo probe, string letters)
	{
		ParameterInfo[] parameters = probe.GetParameters();
		object[] array = new object[parameters.Length];
		array[0] = letters;
		for (int i = 1; i < parameters.Length; i++)
		{
			array[i] = (parameters[i].IsOut ? null : (parameters[i].HasDefaultValue ? parameters[i].DefaultValue : ((parameters[i].ParameterType == typeof(bool)) ? ((object)false) : null)));
		}
		return array;
	}
}
