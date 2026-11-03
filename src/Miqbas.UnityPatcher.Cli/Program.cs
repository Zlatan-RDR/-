using System;
using System.IO;
using Miqbas.Unity.AndroidCore;

namespace Miqbas.UnityPatcher.Cli;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=================================================");
        Console.WriteLine("  Miqbas Unity Asset & Font Patcher (Android CLI) ");
        Console.WriteLine("=================================================");

        if (args.Length == 0 || args[0] == "-h" || args[0] == "--help")
        {
            PrintUsage();
            return;
        }

        string cmd = args[0].ToLowerInvariant();

        try
        {
            switch (cmd)
            {
                case "test":
                case "validate":
                case "test-reflect":
                    AssetsValidator.Run();
                    return;

                case "shape":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Usage: Miqbas.UnityPatcher.Cli shape \"النص العربي\"");
                        return;
                    }
                    string text = args[1];
                    Console.WriteLine($"Original Text:      {text}");
                    string shaped = AssetsPatcher.PrepareArabicText(text, applyVisualOrder: false);
                    Console.WriteLine($"Shaped (Connected): {shaped}");
                    string visual = AssetsPatcher.PrepareArabicText(text, applyVisualOrder: true);
                    Console.WriteLine($"Visual RTL Order:   {visual}");
                    break;

                case "shape-file":
                    if (args.Length < 3)
                    {
                        Console.WriteLine("Usage: Miqbas.UnityPatcher.Cli shape-file <input.txt> <output.txt>");
                        return;
                    }
                    string inputPath = args[1];
                    string outputPath = args[2];
                    if (!File.Exists(inputPath))
                    {
                        Console.WriteLine($"Error: Input file not found: {inputPath}");
                        return;
                    }
                    string[] lines = File.ReadAllLines(inputPath);
                    string[] shapedLines = new string[lines.Length];
                    for (int i = 0; i < lines.Length; i++)
                    {
                        shapedLines[i] = AssetsPatcher.PrepareArabicText(lines[i], applyVisualOrder: true);
                    }
                    File.WriteAllLines(outputPath, shapedLines);
                    Console.WriteLine($"[✓] Processed {lines.Length} lines. Output saved to: {outputPath}");
                    break;

                case "inspect":
                    if (args.Length < 2)
                    {
                        Console.WriteLine("Usage: Miqbas.UnityPatcher.Cli inspect <resources.assets>");
                        return;
                    }
                    string inspectPath = args[1];
                    var progressInspect = new Progress<PatchProgress>(p =>
                    {
                        Console.WriteLine($"[{p.Percentage}%] {p.StatusMessage}");
                    });

                    var inspectResult = AssetsPatcher.InspectAssetsFile(inspectPath, progress: progressInspect);
                    if (inspectResult.Success)
                    {
                        Console.WriteLine($"\n[✓] {inspectResult.Message}");
                        Console.WriteLine($"    Unity Version: {inspectResult.TargetUnityVersion}");
                        Console.WriteLine($"    Fonts Count: {inspectResult.ExistingFontsCount}");
                        Console.WriteLine($"    Fallbacks Count: {inspectResult.FallbacksCount}");
                    }
                    else
                    {
                        Console.WriteLine($"\n[!] {inspectResult.Message}");
                    }
                    break;

                case "inject":
                    if (args.Length < 3)
                    {
                        Console.WriteLine("Usage: Miqbas.UnityPatcher.Cli inject <resources.assets> <output.assets> [ibm|noto]");
                        return;
                    }
                    string targetAssets = args[1];
                    string outAssets = args[2];
                    ArabicFontChoice font = ArabicFontChoice.IBMPlexSansArabic;
                    if (args.Length > 3 && args[3].Equals("noto", StringComparison.OrdinalIgnoreCase))
                    {
                        font = ArabicFontChoice.NotoSansArabicCondensed;
                    }

                    var progressInject = new Progress<PatchProgress>(p =>
                    {
                        Console.WriteLine($"[{p.Percentage}%] {p.StatusMessage}");
                    });

                    var injectResult = AssetsPatcher.InjectFallbackFont(
                        targetAssets,
                        outAssets,
                        fontChoice: font,
                        progress: progressInject
                    );

                    if (injectResult.Success)
                    {
                        Console.WriteLine($"\n[✓] {injectResult.Message}");
                    }
                    else
                    {
                        Console.WriteLine($"\n[!] {injectResult.Message}");
                    }
                    break;

                default:
                    Console.WriteLine($"Unknown command: {cmd}");
                    PrintUsage();
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[!] Error: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }

    private static void PrintUsage()
    {
        Console.WriteLine("\nCommands:");
        Console.WriteLine("  test                              Run end-to-end self-test & alignment validation");
        Console.WriteLine("  shape <text>                      Test Arabic shaping on a single string");
        Console.WriteLine("  shape-file <input> <output>       Batch-shape a full translation text file");
        Console.WriteLine("  inspect <resources.assets>        Inspect Unity assets file for TMP_Settings & Fonts");
        Console.WriteLine("  inject <input.assets> <output>    Inject Arabic fallback font into resources.assets");
        Console.WriteLine("\nExamples:");
        Console.WriteLine("  ./run.sh test");
        Console.WriteLine("  ./run.sh shape \"مرحبا بك في اللعبة\"");
        Console.WriteLine("  ./run.sh shape-file texts.txt texts_arabic.txt");
        Console.WriteLine("  ./run.sh inspect /path/to/resources.assets");
        Console.WriteLine("  ./run.sh inject /path/to/resources.assets /path/to/patched_resources.assets");
    }
}
