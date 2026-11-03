using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace Miqbas.Engines.Unity.Plugin;

[BepInPlugin("com.miqbas.unity", "Miqbas", "0.1.0")]
public sealed class MiqbasPlugin : BaseUnityPlugin
{
	public const string PluginId = "com.miqbas.unity";

	public const string HandshakeFileName = "miqbas-hook.txt";

	public const string TranslationsFileName = "translations.txt";

	public const string DisplayRepairedFileName = "display-repaired.txt";

	public const string ReportedFileName = "reported-text.txt";

	public const string TheGamesOwnArabicFileName = "arabic-is-the-games-own.txt";

	public const string WatchOnlyFileName = "watch-only.txt";

	private static TranslationReloader _reloader;

	internal static readonly Dictionary<string, string> ArrivedThisSession = new Dictionary<string, string>(StringComparer.Ordinal);

	private const int DrawnEverySeconds = 3;

	internal static TextObserver Observer { get; private set; }

	internal static WhereTheLineCameFrom CameFrom { get; private set; }

	internal static WhatTheGameDrew Drew { get; private set; }

	internal static PlacesOnScreen Places { get; private set; }

	internal static bool WatchOnly { get; private set; }

	internal static bool SweepsDirection => true;

	internal static TranslationTable Translations { get; private set; }

	internal static ReportLog Reports { get; private set; }

	internal static InstantTranslator Instant { get; private set; }

	internal static bool ShowOriginal { get; set; }

	internal static Action<string> Log { get; private set; } = delegate
	{
	};


	internal static string WorkDirectory { get; private set; }

	internal static bool FilesRepaired { get; private set; }

	internal static Harmony Patcher { get; private set; }

	internal static SelfPortrait Portrait { get; private set; }

	internal static bool Quitting { get; private set; }

	private void Awake()
	{
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		try
		{
			Log = delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			};
			ArabicDirection.Log = Log;
			string text = Path.Combine(Paths.PluginPath, "miqbas");
			Directory.CreateDirectory(text);
			WorkDirectory = text;
			FilesRepaired = File.Exists(Path.Combine(text, "display-repaired.txt"));
			Observer = new TextObserver(Path.Combine(text, "observed-text.txt"));
			CameFrom = new WhereTheLineCameFrom(Path.Combine(text, "observed-source.txt"));
			Drew = new WhatTheGameDrew(Path.Combine(text, "drawn-count.txt"));
			Places = PlacesOnScreen.Load(text);
			if (Places != null)
			{
				Log("أماكن مقباس تحت المراقبة: " + Places.Watched + " بصمة.");
			}
			StartTheDrawnHeartbeat();
			Reports = new ReportLog(Path.Combine(text, "reported-text.txt"));
			Instant = new InstantTranslator(text, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			});
			string path = Path.Combine(text, "translations.txt");
			WatchOnly = File.Exists(Path.Combine(text, "watch-only.txt"));
			Translations = ((WatchOnly || File.Exists(Path.Combine(text, "arabic-is-the-games-own.txt"))) ? TranslationTable.Load("") : TranslationTable.Load(path, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}));
			_reloader = (WatchOnly ? null : new TranslationReloader(path));
			Log(FilesRepaired ? "ملفات لغة هذه اللعبة م\u064fصل\u064eحة — الطبقة لن تشك\u0651ل ولن تقلب، وتمنع اللافتات من القلب." : "ملفات لغة هذه اللعبة كما هي — الطبقة تشك\u0651ل العربية وتضبط اتجاهها.");
			HashSet<string> termsAsked = new HashSet<string>(StringComparer.Ordinal);
			TranslationTable.TermMissing = delegate(string term)
			{
				if (!ShowOriginal && TextObserver.IsWorthTranslating(term) && termsAsked.Add(term))
				{
					Observer?.Record(term);
					Instant?.Request(term);
				}
			};
			Patcher = new Harmony("com.miqbas.unity");
			int hooked = (WatchOnly ? TextHooks.ApplyWatching(Patcher, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}) : (File.Exists(Path.Combine(text, "klei-arabic.txt")) ? KleiArabic.Apply(Patcher, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}) : (TextHooks.Apply(Patcher, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}) + TextMeshFonts.Apply(Patcher, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}) + AnOldTextMeshProFace.Apply(Patcher, text, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}))));
			Portrait = (WatchOnly ? null : SelfPortrait.TryCreate(text, delegate(string message)
			{
				((BaseUnityPlugin)this).Logger.LogInfo((object)message);
			}));
			WriteHandshake(text, hooked);
			((BaseUnityPlugin)this).Logger.LogInfo((object)("مقباس جاهز داخل اللعبة. نقاط التعل\u0651ق: " + hooked + "، والترجمات: " + Translations.Count + "."));
		}
		catch (Exception ex)
		{
			((BaseUnityPlugin)this).Logger.LogError((object)("تعذ\u0651ر تشغيل مقباس داخل اللعبة، وستعمل اللعبة بلا ترجمة: " + ex));
		}
	}

	internal static void ReloadTranslationsIfChanged()
	{
		try
		{
			if (_reloader != null && !Quitting && _reloader.HasChanged(DateTime.UtcNow))
			{
				TranslationTable translationTable = TranslationTable.Load(_reloader.Path);
				int num;
				lock (ArrivedThisSession)
				{
					num = translationTable.AddMissing(ArrivedThisSession);
				}
				Translations = translationTable;
				int num2 = ImmediateModeHooks.ForgetRewrites();
				int num3 = TextRegistry.Reapply();
				Log("وصلت ترقية\u064c من مقباس: أ\u064fعيد تحميل " + Translations.Count + " ترجمة (منها " + num + " وصلت بعد كتابة الملف\u0651 فأ\u064fبقيت)، وأ\u064fعيدت الكلمات إلى " + num2 + " أمر\u064e رسم\u064d و" + num3 + " لافتة.");
			}
		}
		catch (Exception e)
		{
			Log("تعذ\u0651ر إعادة تحميل الترجمات: " + WhyItFailed.Line(e));
		}
	}

	private static void StartTheDrawnHeartbeat()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				Thread.Sleep(3000);
				try
				{
					Drew?.SaveIfChanged();
					Places?.SaveIfChanged();
				}
				catch (Exception)
				{
				}
			}
		});
		thread.IsBackground = true;
		thread.Name = "miqbas-drawn";
		thread.Start();
	}

	private void Update()
	{
		Hotkeys.Poll();
		TextHooks.DrainInstantTranslations();
	}

	private void OnDestroy()
	{
		Observer?.Flush();
		CameFrom?.Flush();
		Log("كائن الطبقة أ\u064fتلف — تستمر\u0651 الطبقة عبر نقاط تعل\u0651قها.");
	}

	private void OnApplicationQuit()
	{
		Quitting = true;
		Observer?.Flush();
		CameFrom?.Flush();
		Drew?.Save(final: true);
		Places?.Save();
		string text = Drew?.SayIt(1);
		if (text != null)
		{
			Log(text);
		}
		Instant?.Stop();
	}

	private void WriteHandshake(string workDirectory, int hooked)
	{
		string contents = "plugin=com.miqbas.unity" + Environment.NewLine + "version=0.1.0" + Environment.NewLine + "hooks=" + hooked + Environment.NewLine + "translations=" + Translations.Count + Environment.NewLine + "unity=" + Application.unityVersion + Environment.NewLine + "product=" + Application.productName + Environment.NewLine;
		File.WriteAllText(Path.Combine(workDirectory, "miqbas-hook.txt"), contents);
	}
}
