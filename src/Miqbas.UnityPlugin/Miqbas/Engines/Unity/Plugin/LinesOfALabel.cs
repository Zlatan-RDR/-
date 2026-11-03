using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Miqbas.Rendering.Arabic.Layout;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Engines.Unity.Plugin;

internal static class LinesOfALabel
{
	private static readonly Dictionary<string, string> Broken = new Dictionary<string, string>(StringComparer.Ordinal);

	private const int Remembered = 2048;

	private static AFacesWidths _face;

	private static bool _faceRead;

	private static readonly Dictionary<string, (string Logical, double Width, double Size, int Again)> LaidOut = new Dictionary<string, (string, double, double, int)>(StringComparer.Ordinal);

	private const int MostTimesAgain = 2;

	internal static string ForItsBox(object component, string logical, AFacesWidths measuredWith = null)
	{
		double width;
		double size;
		return ForItsBox(component, logical, out width, out size, measuredWith);
	}

	internal static string ForItsBox(object component, string logical, out double width, out double size, AFacesWidths measuredWith = null)
	{
		width = 0.0;
		size = 0.0;
		if (component != null && !string.IsNullOrEmpty(logical) && logical.IndexOf(' ') >= 0 && TheBoxOf(component, out width, out size))
		{
			AFacesWidths aFacesWidths = measuredWith ?? Face();
			if (aFacesWidths != null)
			{
				string key = Math.Round(width) + "|" + Math.Round(size, 1) + "|" + logical;
				if (Broken.TryGetValue(key, out var value))
				{
					return value;
				}
				string text = ParagraphLines.Break(logical, width * 0.94, size, null, aFacesWidths.Measure);
				if (Broken.Count >= 2048)
				{
					Broken.Clear();
				}
				Broken[key] = text;
				return text;
			}
		}
		return logical;
	}

	internal static string WrittenLineOnItsBox(object component, string visual, AFacesWidths measuredWith = null)
	{
		if (component == null || string.IsNullOrEmpty(visual) || visual.IndexOf(' ') < 0 || !ArabicDirection.AlreadyLaidOut(visual))
		{
			return visual;
		}
		string text = ArabicVisualOrder.ToVisual(visual);
		if (!string.Equals(ArabicVisualOrder.ToVisual(text), visual, StringComparison.Ordinal))
		{
			return visual;
		}
		double width;
		double size;
		string text2 = ForItsBox(component, text, out width, out size, measuredWith);
		string text3 = (string.Equals(text2, text, StringComparison.Ordinal) ? visual : ArabicVisualOrder.ToVisual(text2));
		Remember(component, text3, text, width, size);
		return text3;
	}

	internal static void Remember(object component, string handed, string logical, double width, double size)
	{
		if (!string.IsNullOrEmpty(handed) && logical.IndexOf(' ') >= 0 && Wraps(component))
		{
			(string, double, double, int) value;
			int item = (LaidOut.TryGetValue(handed, out value) ? value.Item4 : 0);
			if (LaidOut.Count >= 2048)
			{
				LaidOut.Clear();
			}
			LaidOut[handed] = (logical, width, size, item);
		}
	}

	internal static string AgainOnItsBox(object component, string shown, Func<string, string> layOut)
	{
		if (component == null || string.IsNullOrEmpty(shown) || !LaidOut.TryGetValue(shown, out (string, double, double, int) value) || value.Item4 >= 2 || !TheBoxOf(component, out var width, out var size) || (Math.Abs(width - value.Item2) < 2.0 && Math.Abs(size - value.Item3) < 0.5))
		{
			return null;
		}
		string text = layOut(value.Item1);
		if (string.IsNullOrEmpty(text) || text == shown)
		{
			return null;
		}
		LaidOut[text] = (value.Item1, width, size, value.Item4 + 1);
		return text;
	}

	private static bool Wraps(object component)
	{
		if (component == null)
		{
			return false;
		}
		bool flag = IsA(component.GetType(), "TextMeshProUGUI");
		if (!flag && !IsA(component.GetType(), "UnityEngine.UI.Text"))
		{
			return false;
		}
		if (flag)
		{
			object obj = Get(component, "enableWordWrapping") ?? Get(component, "textWrappingMode");
			bool flag3;
			if (obj is bool flag2)
			{
				flag3 = !flag2;
			}
			else
			{
				bool flag4 = obj != null;
				if (flag4)
				{
					int num = Convert.ToInt32(obj);
					bool flag5 = ((num == 0 || num == 3) ? true : false);
					flag4 = flag5;
				}
				flag3 = flag4;
			}
			return !flag3;
		}
		object obj2 = Get(component, "horizontalOverflow");
		if (obj2 != null)
		{
			return Convert.ToInt32(obj2) == 0;
		}
		return true;
	}

	internal static bool TheBoxOf(object component, out double width, out double size)
	{
		width = 0.0;
		size = 0.0;
		bool flag = IsA(component.GetType(), "TextMeshProUGUI");
		if (!flag && !IsA(component.GetType(), "UnityEngine.UI.Text"))
		{
			return false;
		}
		if (TheLayoutSetsItsWidth(component))
		{
			return false;
		}
		width = Number(Get(Get(Get(component, "rectTransform"), "rect"), "width"));
		size = Number(Get(component, "fontSize"));
		if (flag)
		{
			object obj = Get(component, "margin");
			if (obj != null)
			{
				width -= Number(Get(obj, "x")) + Number(Get(obj, "z"));
			}
			object obj2 = Get(component, "enableWordWrapping") ?? Get(component, "textWrappingMode");
			bool flag3;
			if (obj2 is bool flag2)
			{
				flag3 = !flag2;
			}
			else
			{
				bool flag4 = obj2 != null;
				if (flag4)
				{
					int num = Convert.ToInt32(obj2);
					bool flag5 = ((num == 0 || num == 3) ? true : false);
					flag4 = flag5;
				}
				flag3 = flag4;
			}
			if (flag3)
			{
				return false;
			}
			object obj3 = Get(component, "enableAutoSizing");
			bool flag6 = default(bool);
			int num2;
			if (obj3 is bool)
			{
				flag6 = (bool)obj3;
				num2 = 1;
			}
			else
			{
				num2 = 0;
			}
			if (((uint)num2 & (flag6 ? 1u : 0u)) != 0)
			{
				size = Number(Get(component, "fontSizeMax"));
			}
		}
		else
		{
			object obj4 = Get(component, "horizontalOverflow");
			if (obj4 != null && Convert.ToInt32(obj4) != 0)
			{
				return false;
			}
			object obj3 = Get(component, "resizeTextForBestFit");
			bool flag7 = default(bool);
			int num3;
			if (obj3 is bool)
			{
				flag7 = (bool)obj3;
				num3 = 1;
			}
			else
			{
				num3 = 0;
			}
			if (((uint)num3 & (flag7 ? 1u : 0u)) != 0)
			{
				size = Number(Get(component, "resizeTextMaxSize"));
			}
		}
		if (width > 0.0)
		{
			return size > 0.0;
		}
		return false;
	}

	internal static bool TheLayoutSetsItsWidth(object component)
	{
		object obj = Get(component, "transform");
		bool flag = default(bool);
		for (int i = 0; i < 3; i++)
		{
			if (obj == null)
			{
				break;
			}
			if (i < 2)
			{
				object obj2 = ComponentNamed(obj, "ContentSizeFitter");
				if (obj2 != null)
				{
					object obj3 = Get(obj2, "horizontalFit");
					if (obj3 != null && Convert.ToInt32(obj3) != 0)
					{
						return true;
					}
				}
			}
			if (i > 0)
			{
				string[] array = new string[2] { "HorizontalLayoutGroup", "VerticalLayoutGroup" };
				foreach (string className in array)
				{
					object obj4 = ComponentNamed(obj, className);
					int num;
					if (obj4 != null)
					{
						object obj5 = Get(obj4, "childControlWidth");
						if (obj5 is bool)
						{
							flag = (bool)obj5;
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
						return true;
					}
				}
			}
			obj = Get(obj, "parent");
		}
		return false;
	}

	private static object ComponentNamed(object holder, string className)
	{
		try
		{
			object obj = holder.GetType().GetMethod("GetComponent", BindingFlags.Instance | BindingFlags.Public, null, new Type[1] { typeof(string) }, null)?.Invoke(holder, new object[1] { className });
			return (obj == null || obj.Equals(null)) ? null : obj;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static AFacesWidths Face()
	{
		if (!_faceRead)
		{
			_faceRead = true;
			try
			{
				string path = Path.Combine(MiqbasPlugin.WorkDirectory ?? "", "font.ttf");
				if (File.Exists(path))
				{
					_face = AFacesWidths.Read(File.ReadAllBytes(path));
				}
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		return _face;
	}

	private static bool IsA(Type type, string name)
	{
		Type type2 = type;
		while (type2 != null)
		{
			if ((name.IndexOf('.') >= 0) ? (type2.FullName == name) : (type2.Name == name))
			{
				return true;
			}
			type2 = type2.BaseType;
		}
		return false;
	}

	private static object Get(object target, string name)
	{
		if (target == null)
		{
			return null;
		}
		try
		{
			Type type = target.GetType();
			PropertyInfo property = type.GetProperty(name, BindingFlags.Instance | BindingFlags.Public);
			if (property != null)
			{
				return property.GetValue(target, null);
			}
			return type.GetField(name, BindingFlags.Instance | BindingFlags.Public)?.GetValue(target);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static double Number(object value)
	{
		try
		{
			return (value == null) ? 0.0 : Convert.ToDouble(value);
		}
		catch (Exception)
		{
			return 0.0;
		}
	}
}
