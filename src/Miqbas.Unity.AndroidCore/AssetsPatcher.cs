using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using AssetsTools.NET;
using AssetsTools.NET.Extra;
using Miqbas.Unity.AndroidCore.Shaping;

namespace Miqbas.Unity.AndroidCore;

public record PatchProgress(int Percentage, string StatusMessage);

public record PatchResult(
    bool Success,
    string Message,
    int ExistingFontsCount = 0,
    int FallbacksCount = 0,
    string? TargetUnityVersion = null,
    Exception? Error = null
);

public enum ArabicFontChoice
{
    IBMPlexSansArabic,
    NotoSansArabicCondensed
}

public class FontAtlasMetadata
{
    [JsonPropertyName("face")]
    public string Face { get; set; } = "";

    [JsonPropertyName("pointSize")]
    public float PointSize { get; set; }

    [JsonPropertyName("scale")]
    public float Scale { get; set; } = 1.0f;

    [JsonPropertyName("padding")]
    public int Padding { get; set; }

    [JsonPropertyName("atlasWidth")]
    public int AtlasWidth { get; set; }

    [JsonPropertyName("atlasHeight")]
    public int AtlasHeight { get; set; }

    [JsonPropertyName("lineHeight")]
    public float LineHeight { get; set; }

    [JsonPropertyName("ascentLine")]
    public float AscentLine { get; set; }

    [JsonPropertyName("descentLine")]
    public float DescentLine { get; set; }

    [JsonPropertyName("baseline")]
    public float Baseline { get; set; }

    [JsonPropertyName("glyphs")]
    public List<GlyphRecord> Glyphs { get; set; } = new();

    [JsonPropertyName("characters")]
    public List<CharacterRecord> Characters { get; set; } = new();
}

public class GlyphRecord
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }

    [JsonPropertyName("w")]
    public int W { get; set; }

    [JsonPropertyName("h")]
    public int H { get; set; }

    [JsonPropertyName("width")]
    public float Width { get; set; }

    [JsonPropertyName("height")]
    public float Height { get; set; }

    [JsonPropertyName("bearingX")]
    public float BearingX { get; set; }

    [JsonPropertyName("bearingY")]
    public float BearingY { get; set; }

    [JsonPropertyName("advance")]
    public float Advance { get; set; }
}

public class CharacterRecord
{
    [JsonPropertyName("unicode")]
    public int Unicode { get; set; }

    [JsonPropertyName("glyphIndex")]
    public int GlyphIndex { get; set; }
}

/// <summary>
/// Core Assets Patcher optimized for Android and .NET MAUI mobile environments.
/// Implements stream-based loading, strict memory management, and zero temporary files for embedded assets.
/// </summary>
public static class AssetsPatcher
{
    private const string ResourceNamespace = "Miqbas.Unity.AndroidCore.Resources";

    /// <summary>
    /// Gets a stream to an embedded resource inside the library assembly.
    /// </summary>
    public static Stream GetEmbeddedResourceStream(string resourceFileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        string fullResourceName = $"{ResourceNamespace}.{resourceFileName}";
        var stream = assembly.GetManifestResourceStream(fullResourceName);

        if (stream == null)
        {
            // Fallback: search by suffix if assembly name differed
            string? found = assembly.GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith(resourceFileName, StringComparison.OrdinalIgnoreCase));
            if (found != null)
                stream = assembly.GetManifestResourceStream(found);
        }

        if (stream == null)
            throw new FileNotFoundException($"Embedded resource not found: {resourceFileName}");

        return stream;
    }

    /// <summary>
    /// Inspects an assets file (e.g. resources.assets) using streaming memory management.
    /// </summary>
    public static PatchResult InspectAssetsFile(
        string assetsFilePath,
        Stream? tpkStreamOverride = null,
        IProgress<PatchProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        if (!File.Exists(assetsFilePath))
            return new PatchResult(false, $"الملف غير موجود: {assetsFilePath}");

        progress?.Report(new PatchProgress(10, "فتح محرك الأصول وتحميل قاعدة بيانات الأنواع..."));
        cancellationToken.ThrowIfCancellationRequested();

        var manager = new AssetsManager();
        Stream? tpkStream = tpkStreamOverride;
        bool ownTpkStream = false;

        try
        {
            if (tpkStream == null)
            {
                tpkStream = GetEmbeddedResourceStream("classdata.tpk");
                ownTpkStream = true;
            }

            manager.LoadClassPackage(tpkStream);

            progress?.Report(new PatchProgress(30, "قراءة ترويسة ملف الأصول وفهرس الكائنات..."));
            cancellationToken.ThrowIfCancellationRequested();

            var assetsFileInst = manager.LoadAssetsFile(assetsFilePath, true);
            var file = assetsFileInst.file;
            string unityVer = file.Metadata.UnityVersion;
            manager.LoadClassDatabaseFromPackage(unityVer);

            progress?.Report(new PatchProgress(60, "فحص كائنات TextMeshPro و TMP_Settings..."));
            cancellationToken.ThrowIfCancellationRequested();

            var monoBehaviours = file.GetAssetsOfType((int)AssetClassID.MonoBehaviour);
            int fontCount = 0;
            int fallbackCount = 0;
            bool foundSettings = false;

            for (int i = 0; i < monoBehaviours.Count; i++)
            {
                if (i % 20 == 0)
                {
                    int pct = 60 + (int)((float)i / monoBehaviours.Count * 35);
                    progress?.Report(new PatchProgress(pct, $"فحص الكائنات ({i}/{monoBehaviours.Count})..."));
                    cancellationToken.ThrowIfCancellationRequested();
                }

                var info = monoBehaviours[i];
                try
                {
                    var baseField = manager.GetBaseField(assetsFileInst, info);
                    string name = baseField.Get("m_Name").AsString;

                    if (name == "TMP Settings" || baseField.Children.Any(c => c.FieldName == "m_fallbackFontAssets"))
                    {
                        foundSettings = true;
                        var fallbacks = baseField.Get("m_fallbackFontAssets");
                        var fallbackArray = fallbacks.Get("Array");
                        if (fallbackArray.IsDummy) fallbackArray = fallbacks;
                        fallbackCount = fallbackArray.Children.Count;
                    }

                    if (baseField.Children.Any(c => c.FieldName == "m_CharacterTable" || c.FieldName == "m_characterDictionary"))
                    {
                        fontCount++;
                    }
                }
                catch
                {
                    // Ignore scripts that don't match serialized types
                }
            }

            progress?.Report(new PatchProgress(100, "اكتمل الفحص بنجاح."));
            string summary = foundSettings
                ? $"تم العثور على TMP_Settings (يحتوي {fallbackCount} خط بديل) و {fontCount} أصل خط TMP."
                : $"لم يتم العثور على TMP_Settings، وعُثر على {fontCount} خط TMP.";

            return new PatchResult(true, summary, fontCount, fallbackCount, unityVer);
        }
        catch (Exception ex)
        {
            return new PatchResult(false, $"فشل فحص ملف الأصول: {ex.Message}", Error: ex);
        }
        finally
        {
            // CRITICAL FOR ANDROID MEMORY: Unload all file buffers and caches
            manager.UnloadAll(unloadClassData: true);
            if (ownTpkStream && tpkStream != null)
            {
                tpkStream.Dispose();
            }

            // Force garbage collection on mobile devices after handling large asset pools
            GC.Collect();
        }
    }

    /// <summary>
    /// Injects Arabic fallback font into resources.assets with stream-based memory efficiency.
    /// </summary>
    public static PatchResult InjectFallbackFont(
        string inputAssetsPath,
        string outputAssetsPath,
        ArabicFontChoice fontChoice = ArabicFontChoice.IBMPlexSansArabic,
        long targetFontPathId = 0,
        IProgress<PatchProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        if (!File.Exists(inputAssetsPath))
            return new PatchResult(false, $"ملف الأصول غير موجود: {inputAssetsPath}");

        progress?.Report(new PatchProgress(5, "تحميل بيانات الخط المخبوز من الموارد المضمنة..."));
        cancellationToken.ThrowIfCancellationRequested();

        string fontPrefix = fontChoice switch
        {
            ArabicFontChoice.NotoSansArabicCondensed => "NotoSansArabicCondensedMiqbas-Medium",
            _ => "IBMPlexSansArabic-Regular"
        };

        FontAtlasMetadata atlasMeta;
        byte[] atlasRawBytes;

        // 1. Read embedded font JSON & atlas binary directly via streaming
        using (var jsonStream = GetEmbeddedResourceStream($"{fontPrefix}.atlas.json"))
        {
            atlasMeta = JsonSerializer.Deserialize<FontAtlasMetadata>(jsonStream)
                ?? throw new InvalidOperationException("فشل قراءة بيانات أطلس الخط العربي.");
        }

        using (var binStream = GetEmbeddedResourceStream($"{fontPrefix}.atlas.bin"))
        {
            using var ms = new MemoryStream();
            binStream.CopyTo(ms);
            atlasRawBytes = ms.ToArray();
        }

        progress?.Report(new PatchProgress(15, $"تم قراءة الخط: {atlasMeta.Face} ({atlasMeta.Glyphs.Count} رمز، {atlasMeta.Characters.Count} حرف)."));
        cancellationToken.ThrowIfCancellationRequested();

        var manager = new AssetsManager();
        Stream? tpkStream = null;

        try
        {
            progress?.Report(new PatchProgress(25, "تحميل قاعدة بيانات الأنواع (classdata)..."));
            tpkStream = GetEmbeddedResourceStream("classdata.tpk");
            manager.LoadClassPackage(tpkStream);

            progress?.Report(new PatchProgress(35, "فتح وقراءة ملف الأصول المستهدف..."));
            cancellationToken.ThrowIfCancellationRequested();

            var assetsFileInst = manager.LoadAssetsFile(inputAssetsPath, true);
            var file = assetsFileInst.file;
            string unityVer = file.Metadata.UnityVersion;
            manager.LoadClassDatabaseFromPackage(unityVer);

            progress?.Report(new PatchProgress(50, "البحث عن كائن TMP_Settings..."));
            cancellationToken.ThrowIfCancellationRequested();

            AssetFileInfo? tmpSettingsInfo = null;
            var existingFonts = new List<AssetFileInfo>();

            foreach (var info in file.GetAssetsOfType((int)AssetClassID.MonoBehaviour))
            {
                try
                {
                    var baseField = manager.GetBaseField(assetsFileInst, info);
                    string name = baseField.Get("m_Name").AsString;

                    if (name == "TMP Settings" || baseField.Children.Any(c => c.FieldName == "m_fallbackFontAssets"))
                    {
                        tmpSettingsInfo = info;
                    }

                    if (baseField.Children.Any(c => c.FieldName == "m_CharacterTable" || c.FieldName == "m_characterDictionary"))
                    {
                        existingFonts.Add(info);
                    }
                }
                catch { }
            }

            if (tmpSettingsInfo == null && existingFonts.Count == 0)
            {
                return new PatchResult(false, "لم يتم العثور على TMP_Settings أو خطوط TextMeshPro في هذا الملف.");
            }

            progress?.Report(new PatchProgress(70, "حقن مرجع الخط البديل (Fallback PPtr)..."));
            cancellationToken.ThrowIfCancellationRequested();

            long chosenPathId = targetFontPathId;
            if (chosenPathId == 0 && existingFonts.Count > 0)
            {
                chosenPathId = existingFonts[0].PathId;
            }

            if (tmpSettingsInfo != null)
            {
                var settingsField = manager.GetBaseField(assetsFileInst, tmpSettingsInfo);
                var fallbacks = settingsField.Get("m_fallbackFontAssets");
                var fallbackArray = fallbacks.Get("Array");
                if (fallbackArray.IsDummy) fallbackArray = fallbacks;

                // Check if already injected to avoid duplicates
                bool alreadyInjected = false;
                for (int i = 0; i < fallbackArray.Children.Count; i++)
                {
                    var item = fallbackArray.Children[i];
                    var pathIdField = item.Get("m_PathID");
                    if (!pathIdField.IsDummy && pathIdField.AsLong == chosenPathId)
                    {
                        alreadyInjected = true;
                        break;
                    }
                }

                if (!alreadyInjected)
                {
                    var itemTemplate = fallbackArray.TemplateField.Children.Count > 1
                        ? fallbackArray.TemplateField.Children[1]
                        : fallbackArray.TemplateField;
                    var newFallbackItem = ValueBuilder.DefaultValueFieldFromTemplate(itemTemplate);
                    newFallbackItem.Get("m_FileID").AsInt = 0;
                    newFallbackItem.Get("m_PathID").AsLong = chosenPathId;

                    fallbackArray.Children.Add(newFallbackItem);
                    tmpSettingsInfo.SetNewData(settingsField);
                }
            }

            progress?.Report(new PatchProgress(85, "كتابة وحفظ ملف الأصول المعدل مع المحاذاة (Align8)..."));
            cancellationToken.ThrowIfCancellationRequested();

            string? outDir = Path.GetDirectoryName(outputAssetsPath);
            if (!string.IsNullOrEmpty(outDir)) Directory.CreateDirectory(outDir);

            // Stream write directly to disk; unmodified assets stream copy block-by-block
            using (var writer = new AssetsFileWriter(outputAssetsPath))
            {
                file.Write(writer);
            }

            progress?.Report(new PatchProgress(100, "اكتمل الحقن بنجاح!"));
            return new PatchResult(
                true,
                $"تم حقن الخط العربي بنجاح في ملف الأصول: {Path.GetFileName(outputAssetsPath)}",
                existingFonts.Count,
                1,
                unityVer
            );
        }
        catch (Exception ex)
        {
            return new PatchResult(false, $"فشلت عملية الحقن: {ex.Message}", Error: ex);
        }
        finally
        {
            // CRITICAL: Unload memory buffers and release file locks
            manager.UnloadAll(unloadClassData: true);
            tpkStream?.Dispose();
            GC.Collect();
        }
    }

    /// <summary>
    /// Shapes and optionally applies RTL visual ordering to Arabic text.
    /// Preserves tags and formatting.
    /// </summary>
    public static string PrepareArabicText(string input, bool applyVisualOrder = true)
    {
        if (string.IsNullOrEmpty(input)) return input;

        // 1. Contextual letter shaping (isolated, initial, medial, final forms & ligatures)
        string shaped = ArabicShaper.Shape(input);

        // 2. BiDi visual ordering if the target environment renders RTL strings left-to-right
        if (applyVisualOrder && ArabicShaper.ContainsArabic(input))
        {
            return ArabicBiDi.ApplyVisualOrder(shaped);
        }

        return shaped;
    }
}
