using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Miqbas.Engines.Unity.Plugin;

internal static class KeptAlive
{
	private const int DontUnloadUnusedAsset = 32;

	private static readonly Dictionary<IntPtr, IntPtr> Held = new Dictionary<IntPtr, IntPtr>();

	private static string HandleMakerFailure = "";

	internal static int HeldCount
	{
		get
		{
			lock (Held)
			{
				return Held.Count;
			}
		}
	}

	internal static string LastFailure { get; private set; } = "";


	internal static bool InTheGamesCollector(object value)
	{
		return InTheGamesCollector(value, TheGamesOwnHandleMaker());
	}

	internal static bool InTheGamesCollector(object value, Func<IntPtr, bool, IntPtr> newHandle)
	{
		if (value == null || newHandle == null)
		{
			LastFailure = ((value == null) ? "no object" : ("no handle maker: " + HandleMakerFailure));
			return false;
		}
		try
		{
			PropertyInfo property = value.GetType().GetProperty("Pointer", BindingFlags.Instance | BindingFlags.Public);
			if (property == null || property.PropertyType != typeof(IntPtr))
			{
				LastFailure = ((property == null) ? ("no Pointer on " + value.GetType().FullName) : ("Pointer is " + property.PropertyType.FullName));
				return false;
			}
			IntPtr intPtr = (IntPtr)property.GetValue(value, null);
			if (intPtr == IntPtr.Zero)
			{
				LastFailure = "Pointer is zero";
				return false;
			}
			lock (Held)
			{
				if (!Held.ContainsKey(intPtr))
				{
					Held[intPtr] = newHandle(intPtr, arg2: false);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			LastFailure = (ex.InnerException ?? ex).GetType().Name + ": " + (ex.InnerException ?? ex).Message;
			return false;
		}
	}

	internal static Func<IntPtr, bool, IntPtr> HandleMakerFrom(MethodInfo method)
	{
		return delegate(IntPtr at, bool pinned)
		{
			object obj = method.Invoke(null, new object[2] { at, pinned });
			if (obj is IntPtr result)
			{
				return result;
			}
			return (obj is uint num) ? new IntPtr(num) : new IntPtr(Convert.ToInt64(obj));
		};
	}

	internal static bool NeverUnloadedAsUnused(object value)
	{
		try
		{
			PropertyInfo propertyInfo = value?.GetType().GetProperty("hideFlags", BindingFlags.Instance | BindingFlags.Public);
			if (propertyInfo == null || !propertyInfo.CanRead || !propertyInfo.CanWrite)
			{
				return false;
			}
			int num = Convert.ToInt32(propertyInfo.GetValue(value, null));
			propertyInfo.SetValue(value, Enum.ToObject(propertyInfo.PropertyType, num | 0x20), null);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static Func<IntPtr, bool, IntPtr> TheGamesOwnHandleMaker()
	{
		List<string> list = new List<string>();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			try
			{
				Type type = assembly.GetType("Il2CppInterop.Runtime.IL2CPP", throwOnError: false);
				if (type == null)
				{
					continue;
				}
				List<MethodInfo> source = (from m in type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
					where m.Name == "il2cpp_gchandle_new"
					select m).ToList();
				list.Add(assembly.GetName().Name + ": " + string.Join(" | ", source.Select((MethodInfo m) => (m.IsPublic ? "public " : "non-public ") + "(" + string.Join(", ", from p in m.GetParameters()
					select p.ParameterType.Name) + ")")));
				MethodInfo methodInfo = source.FirstOrDefault(delegate(MethodInfo m)
				{
					ParameterInfo[] parameters = m.GetParameters();
					return parameters.Length == 2 && parameters[0].ParameterType == typeof(IntPtr) && parameters[1].ParameterType == typeof(bool);
				});
				if (!(methodInfo != null))
				{
					continue;
				}
				return HandleMakerFrom(methodInfo);
			}
			catch (Exception ex)
			{
				list.Add(assembly.GetName().Name + " threw " + ex.GetType().Name);
			}
		}
		HandleMakerFailure = ((list.Count == 0) ? "no assembly carries Il2CppInterop.Runtime.IL2CPP" : string.Join("; ", list));
		return null;
	}
}
