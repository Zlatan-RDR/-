using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace Miqbas.Engines.Unity.Plugin;

internal static class ImmediateModeHooks
{
	private struct Slots
	{
		internal int Content;

		internal int Contents;

		internal int Style;

		internal int Rect;
	}

	private struct StyleChange
	{
		private GUIStyle _style;

		private bool _wordWrap;

		private TextAnchor _alignment;

		private int _paddingRight;

		internal void Make(GUIStyle style, bool wrapOff, bool alignRight)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			if (style != null && _style == null && (wrapOff || alignRight))
			{
				_style = style;
				_wordWrap = style.wordWrap;
				_alignment = style.alignment;
				_paddingRight = style.padding.right;
				if (wrapOff)
				{
					style.wordWrap = false;
					RectOffset padding = style.padding;
					padding.right += 3;
				}
				if (alignRight)
				{
					style.alignment = ToTheRight(style.alignment);
				}
			}
		}

		internal void Undo()
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			if (_style != null)
			{
				_style.wordWrap = _wordWrap;
				_style.alignment = _alignment;
				_style.padding.right = _paddingRight;
				_style = null;
			}
		}
	}

	private struct LayoutKey : IEquatable<LayoutKey>
	{
		internal string Text;

		internal int Width;

		internal int Font;

		internal int Size;

		internal int Style;

		public bool Equals(LayoutKey other)
		{
			if (Width == other.Width && Font == other.Font && Size == other.Size && Style == other.Style)
			{
				return string.Equals(Text, other.Text, StringComparison.Ordinal);
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj is LayoutKey other)
			{
				return Equals(other);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (((((((((Text != null) ? StringComparer.Ordinal.GetHashCode(Text) : 0) * 397) ^ Width) * 397) ^ Font) * 397) ^ Size) * 397) ^ Style;
		}
	}

	private static readonly HashSet<string> GuiCommands = new HashSet<string>(StringComparer.Ordinal) { "Label", "Button", "RepeatButton", "Toggle", "Box", "Window", "ModalWindow", "SelectionGrid", "Toolbar", "BeginGroup" };

	private static readonly HashSet<string> LayoutCommands = new HashSet<string>(StringComparer.Ordinal) { "DoLabel", "DoButton", "DoRepeatButton", "DoToggle", "DoBox", "DoSelectionGrid", "DoToolbar", "DoWindow", "BeginArea" };

	private static readonly HashSet<string> Measures = new HashSet<string>(StringComparer.Ordinal) { "CalcSize", "CalcHeight", "CalcMinMaxWidth", "CalcScreenSize" };

	private static readonly Dictionary<MethodBase, Slots> SlotsOf = new Dictionary<MethodBase, Slots>();

	private static readonly Dictionary<GUIContent, string> Originals = new Dictionary<GUIContent, string>();

	private static readonly Dictionary<int, Font> ArabicFonts = new Dictionary<int, Font>();

	private static readonly HashSet<GUIStyle> StylesGivenAFont = new HashSet<GUIStyle>();

	private static readonly string[] WindowsFontsWithArabic = new string[3] { "Segoe UI", "Tahoma", "Arial" };

	private static readonly HashSet<string> Translated = new HashSet<string>(StringComparer.Ordinal);

	private static readonly HashSet<string> Asked = new HashSet<string>(StringComparer.Ordinal);

	private static bool _fontFailureSaid;

	private static int _lastFrame = -1;

	private const int Breathing = 3;

	private static readonly Dictionary<string, string> LaidOutFrom = new Dictionary<string, string>(StringComparer.Ordinal);

	private static readonly Dictionary<LayoutKey, ImmediateModeText.LaidOut> Layouts = new Dictionary<LayoutKey, ImmediateModeText.LaidOut>();

	private static readonly GUIContent Probe = new GUIContent();

	[ThreadStatic]
	private static bool _measuringOurselves;

	private static readonly Dictionary<long, bool> MarksBefore = new Dictionary<long, bool>();

	internal static int ForgetRewrites()
	{
		int num = 0;
		List<KeyValuePair<GUIContent, string>> list;
		lock (Originals)
		{
			list = new List<KeyValuePair<GUIContent, string>>(Originals);
			Originals.Clear();
		}
		foreach (KeyValuePair<GUIContent, string> item in list)
		{
			try
			{
				if (item.Key != null && item.Value != null && item.Key.text != item.Value)
				{
					item.Key.text = item.Value;
					num++;
				}
			}
			catch
			{
			}
		}
		return num;
	}

	private static void RememberOriginal(GUIContent content, string original)
	{
		lock (Originals)
		{
			if (Originals.Count >= 1024)
			{
				Originals.Clear();
			}
			Originals[content] = original;
		}
	}

	internal static int Apply(Harmony harmony, Action<string> log)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		Type type = AccessTools.TypeByName("UnityEngine.GUI");
		if (type == null)
		{
			log("لا يوجد طريق الرسم القديم (IMGUI) في هذه اللعبة — ي\u064fتخط\u0651ى.");
			return 0;
		}
		HarmonyMethod prefix = new HarmonyMethod(typeof(ImmediateModeHooks).GetMethod("BeforeDrawing", BindingFlags.Static | BindingFlags.NonPublic));
		HarmonyMethod prefix2 = new HarmonyMethod(typeof(ImmediateModeHooks).GetMethod("BeforeMeasuring", BindingFlags.Static | BindingFlags.NonPublic));
		HarmonyMethod byName = new HarmonyMethod(typeof(ImmediateModeHooks).GetMethod("BeforeMeasuringByName", BindingFlags.Static | BindingFlags.NonPublic));
		HarmonyMethod after = new HarmonyMethod(typeof(ImmediateModeHooks).GetMethod("StyleBack", BindingFlags.Static | BindingFlags.NonPublic));
		int num = 0;
		num += PatchAll(harmony, type, GuiCommands, prefix, log, null, after);
		num += PatchAll(harmony, AccessTools.TypeByName("UnityEngine.GUILayout"), LayoutCommands, prefix, log, null, after);
		num += PatchAll(harmony, AccessTools.TypeByName("UnityEngine.GUIStyle"), Measures, prefix2, log, byName, after);
		log((num == 0) ? "طريق الرسم القديم: لم ت\u064fوجد أوامر\u064f رسم\u064d ت\u064fعل\u064e\u0651ق عليها." : ("طريق الرسم القديم (IMGUI): الطبقة أمام " + num + " أمر\u064e رسم\u064d وقياس."));
		return num;
	}

	private static int PatchAll(Harmony harmony, Type type, HashSet<string> names, HarmonyMethod prefix, Action<string> log, HarmonyMethod byName = null, HarmonyMethod after = null)
	{
		if (type == null)
		{
			return 0;
		}
		int num = 0;
		MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if (!names.Contains(methodInfo.Name))
			{
				continue;
			}
			Slots value = FindSlots(methodInfo);
			if (value.Content >= 0 || value.Contents >= 0)
			{
				try
				{
					SlotsOf[methodInfo] = value;
					bool flag = byName != null && TakesItsWordsByName(methodInfo, typeof(GUIContent));
					harmony.Patch((MethodBase)methodInfo, flag ? byName : prefix, flag ? null : after, (HarmonyMethod)null, (HarmonyMethod)null, (HarmonyMethod)null);
					num++;
				}
				catch (Exception e)
				{
					SlotsOf.Remove(methodInfo);
					log("تعذ\u0651ر الوقوف أمام " + type.Name + "." + methodInfo.Name + ": " + WhyItFailed.Line(e));
				}
			}
		}
		return num;
	}

	internal static bool TakesItsWordsByName(MethodInfo method, Type contentType)
	{
		ParameterInfo[] parameters = method.GetParameters();
		bool flag = false;
		bool flag2 = false;
		ParameterInfo[] array = parameters;
		foreach (ParameterInfo parameterInfo in array)
		{
			flag |= parameterInfo.ParameterType.IsByRef;
			flag2 |= parameterInfo.ParameterType == contentType && parameterInfo.Name == "content";
		}
		return flag && flag2;
	}

	private static Slots FindSlots(MethodBase method)
	{
		Slots slots = default(Slots);
		slots.Content = -1;
		slots.Contents = -1;
		slots.Style = -1;
		slots.Rect = -1;
		Slots result = slots;
		ParameterInfo[] parameters = method.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			Type parameterType = parameters[i].ParameterType;
			if (parameterType == typeof(GUIContent) && result.Content < 0)
			{
				result.Content = i;
			}
			else if (parameterType == typeof(GUIContent[]) && result.Contents < 0)
			{
				result.Contents = i;
			}
			else if (parameterType == typeof(GUIStyle) && result.Style < 0)
			{
				result.Style = i;
			}
			else if (parameterType == typeof(Rect) && result.Rect < 0)
			{
				result.Rect = i;
			}
		}
		return result;
	}

	private static void OncePerFrame()
	{
		if (MiqbasPlugin.Quitting)
		{
			return;
		}
		int frameCount = Time.frameCount;
		if (frameCount == _lastFrame)
		{
			return;
		}
		_lastFrame = frameCount;
		try
		{
			Hotkeys.Poll();
		}
		catch
		{
		}
		try
		{
			TextHooks.DrainInstantTranslations();
		}
		catch
		{
		}
	}

	private static void BeforeDrawing(object[] __args, MethodBase __originalMethod, out StyleChange __state)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		__state = default(StyleChange);
		try
		{
			OncePerFrame();
			if (!SlotsOf.TryGetValue(__originalMethod, out var value))
			{
				return;
			}
			GUIStyle style = (GUIStyle)((value.Style >= 0) ? /*isinst with value type is only supported in some contexts*/: null);
			if (value.Content >= 0)
			{
				float width = ((value.Rect >= 0 && __args[value.Rect] is Rect val) ? WrapWidth(style, ((Rect)(ref val)).width) : 0f);
				object obj = __args[value.Content];
				Rewrite((GUIContent)((obj is GUIContent) ? obj : null), style, width, drawing: true, ref __state);
			}
			if (value.Contents >= 0 && __args[value.Contents] is GUIContent[] array)
			{
				StyleChange change = default(StyleChange);
				GUIContent[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					Rewrite(array2[i], style, 0f, drawing: false, ref change);
				}
			}
		}
		catch
		{
		}
	}

	private static void BeforeMeasuring(object[] __args, MethodBase __originalMethod, GUIStyle __instance, out StyleChange __state)
	{
		__state = default(StyleChange);
		if (_measuringOurselves)
		{
			return;
		}
		try
		{
			if (SlotsOf.TryGetValue(__originalMethod, out var value) && value.Content >= 0)
			{
				float width2 = ((__originalMethod.Name == "CalcHeight" && __args.Length > 1 && __args[1] is float width) ? WrapWidth(__instance, width) : 0f);
				object obj = __args[value.Content];
				Rewrite((GUIContent)((obj is GUIContent) ? obj : null), __instance, width2, drawing: false, ref __state);
			}
		}
		catch
		{
		}
	}

	private static void BeforeMeasuringByName(GUIContent content, GUIStyle __instance)
	{
		if (_measuringOurselves)
		{
			return;
		}
		try
		{
			StyleChange change = default(StyleChange);
			Rewrite(content, __instance, 0f, drawing: false, ref change);
		}
		catch
		{
		}
	}

	private static void StyleBack(StyleChange __state)
	{
		try
		{
			__state.Undo();
		}
		catch
		{
		}
	}

	private static TextAnchor ToTheRight(TextAnchor anchor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((int)anchor != 0)
		{
			if ((int)anchor != 3)
			{
				if ((int)anchor == 6)
				{
					return (TextAnchor)8;
				}
				return anchor;
			}
			return (TextAnchor)5;
		}
		return (TextAnchor)2;
	}

	private static float WrapWidth(GUIStyle style, float width)
	{
		if (style == null || !style.wordWrap || !(width > 0f))
		{
			return 0f;
		}
		return Math.Max(1f, width - (float)style.padding.horizontal - 3f);
	}

	private static ImmediateModeText.LaidOut LayOut(string arabic, GUIStyle style, float width)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		GUIStyle obj = style;
		object obj2 = ((obj != null) ? obj.font : null);
		if (obj2 == null)
		{
			GUISkin skin = GUI.skin;
			obj2 = ((skin != null) ? skin.font : null);
		}
		Font font = (Font)obj2;
		LayoutKey layoutKey = default(LayoutKey);
		layoutKey.Text = arabic;
		layoutKey.Width = (int)Math.Round(width * 4f);
		layoutKey.Font = (((Object)(object)font != (Object)null) ? ((Object)font).GetInstanceID() : 0);
		layoutKey.Size = ((style != null) ? style.fontSize : 0);
		layoutKey.Style = ((style != null) ? ((style.fontStyle << 1) | style.richText) : 0);
		LayoutKey key = layoutKey;
		lock (LaidOutFrom)
		{
			if (Layouts.TryGetValue(key, out var value))
			{
				return value;
			}
		}
		Func<string, float> widthOf = null;
		if (style != null && width > 0f)
		{
			widthOf = delegate(string shaped)
			{
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				_measuringOurselves = true;
				try
				{
					if ((Object)(object)font != (Object)null && font.dynamic)
					{
						font.RequestCharactersInTexture(shaped, (style.fontSize > 0) ? style.fontSize : font.fontSize, style.fontStyle);
					}
					Probe.text = shaped;
					return style.CalcSize(Probe).x - (float)style.padding.horizontal;
				}
				finally
				{
					_measuringOurselves = false;
				}
			};
		}
		ImmediateModeText.LaidOut laidOut = ImmediateModeText.LayOut(arabic, width, widthOf, style == null || style.richText, MarksGoBeforeTheirLetters(font, style));
		lock (LaidOutFrom)
		{
			if (Layouts.Count >= 4096)
			{
				Layouts.Clear();
			}
			if (LaidOutFrom.Count >= 4096)
			{
				LaidOutFrom.Clear();
			}
			Layouts[key] = laidOut;
			LaidOutFrom[laidOut.Text] = arabic;
			return laidOut;
		}
	}

	private static bool MarksGoBeforeTheirLetters(Font font, GUIStyle style)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)font == (Object)null)
		{
			return true;
		}
		int num = ((style != null && style.fontSize > 0) ? style.fontSize : font.fontSize);
		FontStyle val = (FontStyle)((style != null) ? ((int)style.fontStyle) : 0);
		long key = ((long)((Object)font).GetInstanceID() << 24) ^ ((long)num << 4) ^ (long)val;
		lock (MarksBefore)
		{
			if (MarksBefore.TryGetValue(key, out var value))
			{
				return value;
			}
		}
		bool flag = true;
		string text = "لم ي\u064fقس";
		try
		{
			font.RequestCharactersInTexture('\u064e'.ToString(), num, val);
			CharacterInfo val2 = default(CharacterInfo);
			if (font.GetCharacterInfo('\u064e', ref val2, num, val) && ((CharacterInfo)(ref val2)).maxX > ((CharacterInfo)(ref val2)).minX)
			{
				flag = ((CharacterInfo)(ref val2)).minX + ((CharacterInfo)(ref val2)).maxX > 0;
				text = "حدود الفتحة " + ((CharacterInfo)(ref val2)).minX + " إلى " + ((CharacterInfo)(ref val2)).maxX;
			}
		}
		catch
		{
		}
		MiqbasPlugin.Log("حركات الخط " + ((Object)font).name + " بحجم " + num + ": " + (flag ? "قبل حروفها" : "بعد حروفها") + " (" + text + ").");
		lock (MarksBefore)
		{
			MarksBefore[key] = flag;
			return flag;
		}
	}

	private static void PutDown(GUIContent content, GUIStyle style, string arabic, float width, bool drawing, ref StyleChange change)
	{
		GiveArabicLetters(style);
		ImmediateModeText.LaidOut laidOut = LayOut(arabic, style, width);
		content.text = laidOut.Text;
		change.Make(style, width > 0f, drawing && laidOut.Lines > 1);
	}

	private static void Rewrite(GUIContent content, GUIStyle style, float width, bool drawing, ref StyleChange change)
	{
		if (content == null)
		{
			return;
		}
		string text = content.text;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		if (MiqbasPlugin.ShowOriginal)
		{
			string value;
			lock (Originals)
			{
				Originals.TryGetValue(content, out value);
			}
			if (value != null && value != text)
			{
				content.text = value;
			}
			return;
		}
		string value2;
		lock (LaidOutFrom)
		{
			LaidOutFrom.TryGetValue(text, out value2);
		}
		if (value2 != null)
		{
			PutDown(content, style, value2, width, drawing, ref change);
			return;
		}
		if (ImmediateModeText.IsTheGamesOwnArabic(text))
		{
			PutDown(content, style, text, width, drawing, ref change);
			return;
		}
		ImmediateModeText.Verdict verdict = ImmediateModeText.Decide(text, MiqbasPlugin.Translations, showOriginal: false);
		if (verdict.Replacement != null)
		{
			RememberOriginal(content, text);
			Hotkeys.NoteTranslated(text);
			PutDown(content, style, verdict.Arabic ?? text, width, drawing, ref change);
			NoteTranslated(text);
			MiqbasPlugin.Portrait?.Trigger();
		}
		else
		{
			if (!verdict.WorthAsking)
			{
				return;
			}
			MiqbasPlugin.Observer?.Record(text);
			if (Asked.Add(text))
			{
				MiqbasPlugin.Instant?.Request(text);
				if (Asked.Count <= 3)
				{
					MiqbasPlugin.Log("طريق الرسم القديم يسأل عن: «" + text + "».");
				}
			}
		}
	}

	private static void NoteTranslated(string source)
	{
		if (!Translated.Add(source))
		{
			return;
		}
		if (Translated.Count == 1)
		{
			MiqbasPlugin.Log("أو\u0651ل سطر\u064d ع\u064fر\u0651ب على طريق الرسم القديم: «" + source + "».");
			return;
		}
		int count = Translated.Count;
		if ((count == 10 || count == 100 || count == 1000) ? true : false)
		{
			MiqbasPlugin.Log("ع\u064fر\u0651ب " + Translated.Count + " سطر\u064bا مختلف\u064bا على طريق الرسم القديم.");
		}
	}

	private static void GiveArabicLetters(GUIStyle style)
	{
		if (style == null || StylesGivenAFont.Contains(style))
		{
			return;
		}
		StylesGivenAFont.Add(style);
		object obj = style.font;
		if (obj == null)
		{
			GUISkin skin = GUI.skin;
			obj = ((skin != null) ? skin.font : null);
		}
		Font val = (Font)obj;
		if (!((Object)(object)val != (Object)null) || !val.HasCharacter('ع'))
		{
			Font val2 = ArabicFontOfSize((style.fontSize > 0) ? style.fontSize : (((Object)(object)val != (Object)null) ? val.fontSize : 0));
			if (!((Object)(object)val2 == (Object)null))
			{
				style.font = val2;
			}
		}
	}

	private static Font ArabicFontOfSize(int size)
	{
		if (ArabicFonts.TryGetValue(size, out var value))
		{
			return value;
		}
		Font val = null;
		string[] windowsFontsWithArabic = WindowsFontsWithArabic;
		foreach (string text in windowsFontsWithArabic)
		{
			try
			{
				val = Font.CreateDynamicFontFromOSFont(text, (size > 0) ? size : 14);
			}
			catch
			{
				val = null;
			}
			if ((Object)(object)val != (Object)null && val.HasCharacter('ع'))
			{
				Object.DontDestroyOnLoad((Object)(object)val);
				MiqbasPlugin.Log("خط\u064f\u0651 طريق الرسم القديم: " + text + " بحجم " + ((size > 0) ? size.ToString() : "الخط\u0651 نفسه") + ".");
				break;
			}
			val = null;
		}
		if ((Object)(object)val == (Object)null && !_fontFailureSaid)
		{
			_fontFailureSaid = true;
			MiqbasPlugin.Log("لم ي\u064fوجد على هذا الجهاز خط\u064c\u0651 يحمل العربية لطريق الرسم القديم — ستظهر مرب\u0651عات.");
		}
		ArabicFonts[size] = val;
		return val;
	}
}
