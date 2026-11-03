using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;

namespace Miqbas.Engines.Unity.Plugin;

internal static class Hotkeys
{
	internal sealed class KeyReader
	{
		public string Name { get; }

		public bool IsTheNewSystem { get; }

		public Func<bool> AltHeld { get; }

		public Func<string, bool> Pressed { get; }

		public KeyReader(string name, Func<bool> altHeld, Func<string, bool> pressed, bool isTheNewSystem = false)
		{
			Name = name;
			AltHeld = altHeld;
			Pressed = pressed;
			IsTheNewSystem = isTheNewSystem;
		}
	}

	private const string ToggleKey = "T";

	private const string ReportKey = "B";

	private static KeyReader _reader;

	private static MethodInfo _keyboardNow;

	private static MethodInfo _altKey;

	private static MethodInfo _toggleKey;

	private static MethodInfo _reportKey;

	private static bool _resolved;

	private static bool _readsKeys;

	private static bool _unavailable;

	private static string _lastTranslatedSource;

	internal static void NoteTranslated(string sourceText)
	{
		_lastTranslatedSource = sourceText;
	}

	internal static void Poll()
	{
		if (_unavailable)
		{
			return;
		}
		try
		{
			if (Resolve() && _reader.AltHeld())
			{
				if (_reader.Pressed("T"))
				{
					Toggle();
				}
				else if (_reader.Pressed("B"))
				{
					Report();
				}
			}
		}
		catch (Exception e)
		{
			_unavailable = true;
			MiqbasPlugin.Log("مفاتيح مقباس لا تعمل في هذه اللعبة: " + WhyItFailed.Line(e));
		}
	}

	private static void Toggle()
	{
		MiqbasPlugin.ShowOriginal = !MiqbasPlugin.ShowOriginal;
		TextRegistry.Reapply();
		MiqbasPlugin.Log(MiqbasPlugin.ShowOriginal ? "ع\u064fرض النص الأصلي (Alt+T للعودة إلى الترجمة)." : "ع\u064fرضت الترجمة (Alt+T لعرض الأصل).");
	}

	private static void Report()
	{
		string lastTranslatedSource = _lastTranslatedSource;
		if (string.IsNullOrEmpty(lastTranslatedSource))
		{
			MiqbasPlugin.Log("لا سطر مترج\u064eم بعد لتبل\u0651غ عنه.");
			return;
		}
		MiqbasPlugin.Reports?.Record(lastTranslatedSource);
		MiqbasPlugin.Log("س\u064fج\u0651ل بلاغك عن الترجمة. سيعرضه مقباس في محرر المراجعة.");
	}

	private static bool Resolve()
	{
		if (_resolved)
		{
			return _readsKeys;
		}
		_resolved = true;
		_reader = TheFirstThatAnswers(Readers(), MiqbasPlugin.Log);
		if (_reader != null)
		{
			_readsKeys = true;
			MiqbasPlugin.Log(_reader.IsTheNewSystem ? "مفاتيح مقباس: نظام الإدخال الجديد." : "مفاتيح مقباس: نظام الإدخال القديم.");
			return true;
		}
		MiqbasPlugin.Log("هذه اللعبة لا تتيح قراءة لوحة المفاتيح — مفاتيح مقباس معط\u0651لة.");
		return false;
	}

	internal static KeyReader TheFirstThatAnswers(IEnumerable<KeyReader> readers, Action<string> log)
	{
		foreach (KeyReader reader in readers)
		{
			try
			{
				reader.AltHeld();
				return reader;
			}
			catch (Exception e)
			{
				log("مفاتيح مقباس: «" + reader.Name + "» لم ي\u064fجب — " + WhyItFailed.Line(e));
			}
		}
		return null;
	}

	private static IEnumerable<KeyReader> Readers()
	{
		Type input = AccessTools.TypeByName("UnityEngine.Input");
		Type type = AccessTools.TypeByName("UnityEngine.KeyCode");
		if (input != null && type != null)
		{
			KeyReader keyReader = TheOldSystemByCode(input, type);
			if (keyReader != null)
			{
				yield return keyReader;
			}
			KeyReader keyReader2 = TheOldSystemByName(input);
			if (keyReader2 != null)
			{
				yield return keyReader2;
			}
		}
		if (ResolveTheNewInputSystem())
		{
			yield return new KeyReader("نظام الإدخال الجديد", () => TheNewSystemSays(_altKey, "isPressed"), (string key) => TheNewSystemSays((key == "T") ? _toggleKey : _reportKey, "wasPressedThisFrame"), isTheNewSystem: true);
		}
	}

	private static KeyReader TheOldSystemByCode(Type input, Type keyCode)
	{
		MethodInfo getKeyDown = AccessTools.Method(input, "GetKeyDown", new Type[1] { keyCode }, (Type[])null);
		MethodInfo getKey = AccessTools.Method(input, "GetKey", new Type[1] { keyCode }, (Type[])null);
		if (getKeyDown == null || getKey == null)
		{
			return null;
		}
		object leftAlt;
		object rightAlt;
		object toggle;
		object report;
		try
		{
			leftAlt = Enum.Parse(keyCode, "LeftAlt");
			rightAlt = Enum.Parse(keyCode, "RightAlt");
			toggle = Enum.Parse(keyCode, "T");
			report = Enum.Parse(keyCode, "B");
		}
		catch (Exception)
		{
			return null;
		}
		return new KeyReader("نظام الإدخال القديم", () => (bool)getKey.Invoke(null, new object[1] { leftAlt }) || (bool)getKey.Invoke(null, new object[1] { rightAlt }), (string key) => (bool)getKeyDown.Invoke(null, new object[1] { (key == "T") ? toggle : report }));
	}

	private static KeyReader TheOldSystemByName(Type input)
	{
		MethodInfo getKeyDown = AccessTools.Method(input, "GetKeyDown", new Type[1] { typeof(string) }, (Type[])null);
		MethodInfo getKey = AccessTools.Method(input, "GetKey", new Type[1] { typeof(string) }, (Type[])null);
		if (getKeyDown == null || getKey == null)
		{
			return null;
		}
		return new KeyReader("نظام الإدخال القديم بالاسم", () => (bool)getKey.Invoke(null, new object[1] { "left alt" }) || (bool)getKey.Invoke(null, new object[1] { "right alt" }), (string key) => (bool)getKeyDown.Invoke(null, new object[1] { key.ToLowerInvariant() }));
	}

	private static bool ResolveTheNewInputSystem()
	{
		Type type = AccessTools.TypeByName("UnityEngine.InputSystem.Keyboard");
		if (type == null)
		{
			return false;
		}
		_keyboardNow = AccessTools.Property(type, "current")?.GetGetMethod();
		_altKey = AccessTools.Property(type, "altKey")?.GetGetMethod();
		_toggleKey = AccessTools.Property(type, "T".ToLowerInvariant() + "Key")?.GetGetMethod();
		_reportKey = AccessTools.Property(type, "B".ToLowerInvariant() + "Key")?.GetGetMethod();
		if (_keyboardNow != null && _altKey != null && _toggleKey != null)
		{
			return _reportKey != null;
		}
		return false;
	}

	private static bool TheNewSystemSays(MethodInfo control, string question)
	{
		if (_keyboardNow == null || control == null)
		{
			return false;
		}
		object obj = _keyboardNow.Invoke(null, null);
		if (obj == null)
		{
			return false;
		}
		object obj2 = control.Invoke(obj, null);
		if (obj2 == null)
		{
			return false;
		}
		object obj3 = AccessTools.Property(obj2.GetType(), question)?.GetGetMethod()?.Invoke(obj2, null);
		bool flag = default(bool);
		int num;
		if (obj3 is bool)
		{
			flag = (bool)obj3;
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)((uint)num & (flag ? 1u : 0u)) != 0;
	}
}
