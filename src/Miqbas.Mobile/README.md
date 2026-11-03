# Miqbas Mobile (.NET MAUI Android)

تطبيق أندرويد متكامل بواجهة مستخدم حديثة مبني بتقنية **.NET MAUI**، مخصص لتعريب ألعاب Unity على نظام أندرويد عبر حقن الخطوط العربية في كائنات TextMeshPro داخل ملفات الأصول (`resources.assets`).

## مميزات التطبيق

1. **منتقي ملفات الأصول (File Picker):** اختيار ملف `resources.assets` من ذاكرة الجهاز بكل سهولة.
2. **قائمة اختيار الخطوط (Font Picker):**
   - `IBM Plex Sans Arabic`: خط قياسي متوازن ومريح للقراءة (موصى به لمعظم الألعاب).
   - `Noto Sans Arabic Condensed`: خط مكثف مخصص للألعاب ذات المساحات الضيقة والقوائم المعقدة.
3. **معاينة حية للتشكيل والـ BiDi:** تجربة كتابة أي نص عربي لمشاهدة ناتج التشكيل وتعديل الاتجاه (Right-to-Left) لحظياً مع الحفاظ على وسوم Unity الغنية (`<color=...>`, `<b>`, `{0}`).
4. **متابعة حية للتقدم (Real-time Progress):** شريط تقدم متصل بواجهة `IProgress<PatchProgress>` لعرض النسبة المئوية ومرحلة المعالجة.
5. **حقن وحفظ بضغطة زر واحدة:** يتم قراءة وتعديل الأصول بنمط التدفق الذاكري (Streaming Memory Management) مع ضمان محاذاة الذاكرة 64-bit Align8 لمنع أي انهيار في نظام أندرويد (ARM64).

## هيكل المشروع

```text
src/Miqbas.Mobile/
├── App.xaml / App.xaml.cs                 # الموارد والتهيئة العامة
├── AppShell.xaml / AppShell.xaml.cs       # هيكل التنقل العام
├── MainPage.xaml / MainPage.xaml.cs       # الواجهة الرئيسية وتفاعلات المستخدم
├── MauiProgram.cs                         # نقطة الدخول وتهيئة الخدمات
├── Miqbas.Mobile.csproj                   # ملف تعريف المشروع وإعدادات MAUI
├── Platforms/
│   └── Android/
│       ├── MainActivity.cs                # نشاط أندرويد الرئيسي
│       ├── MainApplication.cs            # تطبيق أندرويد
│       └── AndroidManifest.xml           # أذونات الوصول للذاكرة والتخزين
└── Resources/
    ├── AppIcon/                           # أيقونة التطبيق (SVG)
    ├── Splash/                            # شاشة البداية (SVG)
    └── Styles/                            # القوالب والألوان الموحدة
```

## بناء حزمة التطبيق (APK)

### عبر Visual Studio 2022:
1. افتح المشروع في Visual Studio 2022 مع تثبيت حزمة **.NET Multi-platform App UI development**.
2. اختر الهدف `net8.0-android` وجهاز Android متصل أو محاكي.
3. اضغط **Build > Publish** أو **Deploy**.

### عبر سطر الأوامر (dotnet CLI):
```bash
dotnet publish -f net8.0-android -c Release -p:AndroidPackageFormat=apk
```
