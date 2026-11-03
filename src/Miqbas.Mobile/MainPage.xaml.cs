using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Miqbas.Unity.AndroidCore;

namespace Miqbas.Mobile;

public partial class MainPage : ContentPage
{
    private string? _selectedAssetsPath;
    private ArabicFontChoice _selectedFont = ArabicFontChoice.IBMPlexSansArabic;
    private readonly StringBuilder _logBuilder = new();

    public MainPage()
    {
        InitializeComponent();
        UpdateArabicPreview(TestArabicEntry.Text);
    }

    private void AppendLog(string message)
    {
        string timestamp = DateTime.Now.ToString("HH:mm:ss");
        _logBuilder.AppendLine($"[{timestamp}] {message}");
        MainThread.BeginInvokeOnMainThread(() =>
        {
            LogOutputLabel.Text = _logBuilder.ToString();
        });
    }

    private async void OnBrowseFileClicked(object sender, EventArgs e)
    {
        try
        {
            var customFileType = new FilePickerFileType(
                new Dictionary<DevicePlatform, IEnumerable<string>>
                {
                    { DevicePlatform.Android, new[] { "*/*" } },
                    { DevicePlatform.iOS, new[] { "public.data" } },
                    { DevicePlatform.WinUI, new[] { ".assets" } },
                    { DevicePlatform.MacCatalyst, new[] { "assets" } }
                });

            var options = new PickOptions
            {
                PickerTitle = "اختر ملف resources.assets الخاص باللعبة",
                FileTypes = customFileType
            };

            var result = await FilePicker.Default.PickAsync(options);
            if (result != null)
            {
                _selectedAssetsPath = result.FullPath;
                FilePathEntry.Text = _selectedAssetsPath;

                var fileInfo = new FileInfo(_selectedAssetsPath);
                double mb = fileInfo.Length / (1024.0 * 1024.0);
                FileInfoLabel.Text = $"الحجم: {mb:F2} ميغابايت | الاسم: {fileInfo.Name}";

                AppendLog($"تم تحديد الملف: {fileInfo.Name} ({mb:F2} MB)");
            }
        }
        catch (Exception ex)
        {
            AppendLog($"خطأ في منتقي الملفات: {ex.Message}");
            await DisplayAlert("تنبيه", $"تعذر فتح منتقي الملفات: {ex.Message}", "حسناً");
        }
    }

    private void OnFontSelectionChanged(object sender, EventArgs e)
    {
        _selectedFont = FontChoicePicker.SelectedIndex switch
        {
            1 => ArabicFontChoice.NotoSansArabicCondensed,
            _ => ArabicFontChoice.IBMPlexSansArabic
        };

        AppendLog($"تم تغيير الخط المختار إلى: {_selectedFont}");
    }

    private void OnTestArabicTextChanged(object sender, TextChangedEventArgs e)
    {
        UpdateArabicPreview(e.NewTextValue);
    }

    private void UpdateArabicPreview(string? text)
    {
        if (string.IsNullOrEmpty(text))
        {
            TestArabicPreviewLabel.Text = "";
            return;
        }

        try
        {
            // Prepare text with shaping and BiDi visual ordering:
            string preview = AssetsPatcher.PrepareArabicText(text, applyVisualOrder: true);
            TestArabicPreviewLabel.Text = preview;
        }
        catch (Exception ex)
        {
            TestArabicPreviewLabel.Text = $"[خطأ تشكيل]: {ex.Message}";
        }
    }

    private async void OnInspectAssetsClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_selectedAssetsPath) || !File.Exists(_selectedAssetsPath))
        {
            await DisplayAlert("خطأ", "يرجى تحديد ملف resources.assets صالح أولاً.", "حسناً");
            return;
        }

        SetUiBusy(true);
        AppendLog("بدء فحص محتويات ملف الأصول...");

        var progress = new Progress<PatchProgress>(p =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                PatchProgressBar.Progress = p.Percentage / 100.0;
                PercentageLabel.Text = $"{p.Percentage}%";
                StatusMessageLabel.Text = p.StatusMessage;
            });
        });

        try
        {
            var inspectResult = await Task.Run(() => AssetsPatcher.InspectAssetsFile(_selectedAssetsPath, progress: progress));

            if (inspectResult.Success)
            {
                AppendLog($"[✓] {inspectResult.Message}");
                AppendLog($"    إصدار Unity: {inspectResult.TargetUnityVersion}");
                AppendLog($"    الخطوط الموجودة: {inspectResult.ExistingFontsCount}");
                AppendLog($"    الخطوط البديلة: {inspectResult.FallbacksCount}");

                await DisplayAlert("نتائج الفحص",
                    $"إصدار Unity: {inspectResult.TargetUnityVersion}\n" +
                    $"عدد خطوط TMP: {inspectResult.ExistingFontsCount}\n" +
                    $"الخطوط البديلة الحالية: {inspectResult.FallbacksCount}\n\n" +
                    inspectResult.Message,
                    "حسناً");
            }
            else
            {
                AppendLog($"[!] فشل الفحص: {inspectResult.Message}");
                await DisplayAlert("فشل الفحص", inspectResult.Message, "إغلاق");
            }
        }
        catch (Exception ex)
        {
            AppendLog($"استثناء أثناء الفحص: {ex.Message}");
            await DisplayAlert("خطأ غير متوقع", ex.Message, "إغلاق");
        }
        finally
        {
            SetUiBusy(false);
        }
    }

    private async void OnPatchAssetsClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_selectedAssetsPath) || !File.Exists(_selectedAssetsPath))
        {
            await DisplayAlert("خطأ", "يرجى تحديد ملف resources.assets أولاً.", "حسناً");
            return;
        }

        bool confirm = await DisplayAlert(
            "تأكيد الحقن",
            $"هل تريد حقن خط {_selectedFont} داخل ملف الأصول المحدد؟\nسيتم حفظ نسخة معربة جديدة إلى جانب الملف الأصلي.",
            "نعم، ابدأ الحقن",
            "إلغاء");

        if (!confirm) return;

        SetUiBusy(true);
        string inputPath = _selectedAssetsPath;
        string outputPath = Path.Combine(
            Path.GetDirectoryName(inputPath) ?? "",
            Path.GetFileNameWithoutExtension(inputPath) + "_arabic.assets"
        );

        AppendLog($"بدء عملية الحقن إلى: {Path.GetFileName(outputPath)}");

        var progress = new Progress<PatchProgress>(p =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                PatchProgressBar.Progress = p.Percentage / 100.0;
                PercentageLabel.Text = $"{p.Percentage}%";
                StatusMessageLabel.Text = p.StatusMessage;
            });
        });

        try
        {
            var patchResult = await Task.Run(() => AssetsPatcher.InjectFallbackFont(
                inputPath,
                outputPath,
                fontChoice: _selectedFont,
                progress: progress
            ));

            if (patchResult.Success)
            {
                AppendLog($"[✓] {patchResult.Message}");
                AppendLog($"    مسار الملف المعرب: {outputPath}");

                await DisplayAlert(
                    "اكتملت العملية بنجاح! 🎉",
                    $"تم حقن الخط العربي بنجاح داخل ملف الأصول!\n\n" +
                    $"الملف المعرب: {Path.GetFileName(outputPath)}\n" +
                    $"إصدار Unity: {patchResult.TargetUnityVersion}\n" +
                    $"المحاذاة: 64-bit Align8 متوافقة مع أندرويد ARM64.",
                    "ممتاز");
            }
            else
            {
                AppendLog($"[!] فشل الحقن: {patchResult.Message}");
                await DisplayAlert("فشل التعريب", patchResult.Message, "إغلاق");
            }
        }
        catch (Exception ex)
        {
            AppendLog($"استثناء أثناء الحقن: {ex.Message}");
            await DisplayAlert("خطأ غير متوقع", ex.Message, "إغلاق");
        }
        finally
        {
            SetUiBusy(false);
        }
    }

    private void SetUiBusy(bool isBusy)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            InspectButton.IsEnabled = !isBusy;
            PatchButton.IsEnabled = !isBusy;
            FontChoicePicker.IsEnabled = !isBusy;
        });
    }
}
