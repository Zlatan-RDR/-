using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AssetsTools.NET;
using AssetsTools.NET.Extra;
using Miqbas.Unity.AndroidCore;

namespace Miqbas.UnityPatcher.Cli;

public class MockAssetsBuilder
{
    private class StringBufferBuilder
    {
        private readonly MemoryStream _ms = new();
        private readonly Dictionary<string, uint> _offsets = new();

        public uint Add(string str)
        {
            if (_offsets.TryGetValue(str, out uint offset)) return offset;
            offset = (uint)_ms.Position;
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            _ms.Write(bytes, 0, bytes.Length);
            _ms.WriteByte(0); // null terminator
            _offsets[str] = offset;
            return offset;
        }

        public byte[] ToByteArray() => _ms.ToArray();
    }

    public static TypeTreeType BuildTypeTreeType(int typeId, ushort scriptIndex, (byte level, string name, string type, int byteSize, TypeTreeNodeFlags flags, uint metaFlags)[] nodeDefs)
    {
        var sb = new StringBufferBuilder();
        var nodes = new List<TypeTreeNode>();

        for (uint i = 0; i < nodeDefs.Length; i++)
        {
            var def = nodeDefs[i];
            nodes.Add(new TypeTreeNode
            {
                Version = 1,
                Level = def.level,
                TypeFlags = def.flags,
                TypeStrOffset = sb.Add(def.type),
                NameStrOffset = sb.Add(def.name),
                ByteSize = def.byteSize,
                Index = i,
                MetaFlags = def.metaFlags
            });
        }

        var blob = new TypeTreeBlob
        {
            Nodes = nodes,
            StringBufferBytes = sb.ToByteArray()
        };

        return new TypeTreeType
        {
            TypeId = typeId,
            ScriptTypeIndex = scriptIndex,
            TypeBlobIsDefinition = true,
            TypeBlob = blob,
            Nodes = nodes,
            StringBufferBytes = blob.StringBufferBytes,
            ScriptIdHash = Hash128.NewBlankHash(),
            TypeHash = Hash128.NewBlankHash(),
            TypeDependencies = Array.Empty<int>()
        };
    }

    public static void CreateMockResourcesAssets(string outputPath)
    {
        var file = new AssetsFile();
        file.Header = new AssetsFileHeader { Version = 22, Endianness = false };
        file.Metadata = new AssetsFileMetadata
        {
            UnityVersion = "2020.3.0f1",
            TargetPlatform = 13,
            TypeTreeEnabled = true,
            TypeTreeTypes = new List<TypeTreeType>(),
            AssetInfos = new List<AssetFileInfo>(),
            ScriptTypes = new List<AssetPPtr>(),
            Externals = new List<AssetsFileExternal>(),
            RefTypes = new List<TypeTreeType>(),
            UserInformation = ""
        };

        // TypeTree for TMP_Settings (scriptIndex = 0)
        var settingsNodes = new (byte, string, string, int, TypeTreeNodeFlags, uint)[]
        {
            (0, "Base", "MonoBehaviour", -1, 0, 0),
            (1, "m_GameObject", "PPtr<GameObject>", 12, 0, 0),
            (2, "m_FileID", "int", 4, 0, 0),
            (2, "m_PathID", "SInt64", 8, 0, 0),
            (1, "m_Enabled", "UInt8", 1, 0, 0),
            (1, "m_Script", "PPtr<MonoScript>", 12, 0, 0),
            (2, "m_FileID", "int", 4, 0, 0),
            (2, "m_PathID", "SInt64", 8, 0, 0),
            (1, "m_Name", "string", -1, 0, 0),
            (2, "Array", "Array", -1, TypeTreeNodeFlags.Array, 0),
            (3, "size", "int", 4, 0, 0),
            (3, "data", "char", 1, 0, 0),
            (1, "m_fallbackFontAssets", "vector", -1, 0, 0),
            (2, "Array", "Array", -1, TypeTreeNodeFlags.Array, 0),
            (3, "size", "int", 4, 0, 0),
            (3, "data", "PPtr<TMP_FontAsset>", 12, 0, 0),
            (4, "m_FileID", "int", 4, 0, 0),
            (4, "m_PathID", "SInt64", 8, 0, 0),
        };
        var settingsType = BuildTypeTreeType(114, 0, settingsNodes);
        file.Metadata.TypeTreeTypes.Add(settingsType);

        // TypeTree for FontAsset (scriptIndex = 1)
        var fontNodes = new (byte, string, string, int, TypeTreeNodeFlags, uint)[]
        {
            (0, "Base", "MonoBehaviour", -1, 0, 0),
            (1, "m_GameObject", "PPtr<GameObject>", 12, 0, 0),
            (2, "m_FileID", "int", 4, 0, 0),
            (2, "m_PathID", "SInt64", 8, 0, 0),
            (1, "m_Enabled", "UInt8", 1, 0, 0),
            (1, "m_Script", "PPtr<MonoScript>", 12, 0, 0),
            (2, "m_FileID", "int", 4, 0, 0),
            (2, "m_PathID", "SInt64", 8, 0, 0),
            (1, "m_Name", "string", -1, 0, 0),
            (2, "Array", "Array", -1, TypeTreeNodeFlags.Array, 0),
            (3, "size", "int", 4, 0, 0),
            (3, "data", "char", 1, 0, 0),
            (1, "m_CharacterTable", "vector", -1, 0, 0),
            (2, "Array", "Array", -1, TypeTreeNodeFlags.Array, 0),
            (3, "size", "int", 4, 0, 0),
            (3, "data", "UInt32", 4, 0, 0),
        };
        var fontType = BuildTypeTreeType(114, 1, fontNodes);
        file.Metadata.TypeTreeTypes.Add(fontType);

        // Build template fields from TypeTree
        var settingsTemplate = new AssetTypeTemplateField();
        settingsTemplate.FromTypeTree(settingsType);

        var fontTemplate = new AssetTypeTemplateField();
        fontTemplate.FromTypeTree(fontType);

        // Instantiate values
        var settingsVal = ValueBuilder.DefaultValueFieldFromTemplate(settingsTemplate);
        settingsVal.Get("m_Name").AsString = "TMP Settings";
        var settingsBytes = settingsVal.WriteToByteArray();

        var fontVal = ValueBuilder.DefaultValueFieldFromTemplate(fontTemplate);
        fontVal.Get("m_Name").AsString = "LiberationSans SDF";
        var fontBytes = fontVal.WriteToByteArray();

        // Create AssetFileInfo
        var settingsInfo = AssetFileInfo.Create(file, 1001, 114, 0);
        settingsInfo.SetNewData(settingsBytes);

        var fontInfo = AssetFileInfo.Create(file, 1002, 114, 1);
        fontInfo.SetNewData(fontBytes);

        file.Metadata.AssetInfos.Add(settingsInfo);
        file.Metadata.AssetInfos.Add(fontInfo);

        using var writer = new AssetsFileWriter(outputPath);
        file.Write(writer);
    }
}

public static class AssetsValidator
{
    public static void Run()
    {
        string mockPath = "/workspace/clever-kalam/test_mock_resources.assets";
        string patchedPath = "/workspace/clever-kalam/test_mock_patched.assets";

        Console.WriteLine($"[1] Generating clean mock resources.assets at: {mockPath}...");
        MockAssetsBuilder.CreateMockResourcesAssets(mockPath);
        Console.WriteLine($"    Generated file size: {new FileInfo(mockPath).Length} bytes.");

        Console.WriteLine("\n[2] Inspecting original mock assets...");
        var inspectRes = AssetsPatcher.InspectAssetsFile(mockPath);
        Console.WriteLine($"    Success:         {inspectRes.Success}");
        Console.WriteLine($"    Message:         {inspectRes.Message}");
        Console.WriteLine($"    Unity Version:   {inspectRes.TargetUnityVersion}");
        Console.WriteLine($"    Existing Fonts:  {inspectRes.ExistingFontsCount}");
        Console.WriteLine($"    Fallbacks Count: {inspectRes.FallbacksCount}");

        Console.WriteLine("\n[3] Injecting IBM Plex Sans Arabic fallback font...");
        var injectRes = AssetsPatcher.InjectFallbackFont(mockPath, patchedPath, ArabicFontChoice.IBMPlexSansArabic);
        Console.WriteLine($"    Success:         {injectRes.Success}");
        Console.WriteLine($"    Message:         {injectRes.Message}");
        if (injectRes.Error != null)
        {
            Console.WriteLine($"    Error:           {injectRes.Error}");
        }

        Console.WriteLine("\n[4] Inspecting patched assets to verify injection...");
        var verifyRes = AssetsPatcher.InspectAssetsFile(patchedPath);
        Console.WriteLine($"    Success:         {verifyRes.Success}");
        Console.WriteLine($"    Message:         {verifyRes.Message}");
        Console.WriteLine($"    Existing Fonts:  {verifyRes.ExistingFontsCount}");
        Console.WriteLine($"    Fallbacks Count: {verifyRes.FallbacksCount}");

        Console.WriteLine("\n[5] Verifying 64-bit Memory Alignment (Align8) in patched assets...");
        var mgr = new AssetsManager();
        var fileInst = mgr.LoadAssetsFile(patchedPath, true);
        var file = fileInst.file;
        Console.WriteLine($"    Header Version:     {file.Header.Version}");
        Console.WriteLine($"    Data Offset:        0x{file.Header.DataOffset:X8} ({file.Header.DataOffset} bytes)");
        Console.WriteLine($"    Data Offset % 8:    {file.Header.DataOffset % 8} (Must be 0)");

        bool allAligned = (file.Header.DataOffset % 8) == 0;
        foreach (var info in file.Metadata.AssetInfos)
        {
            long absOffset = info.GetAbsoluteByteOffset(file);
            long relOffset = info.ByteOffset;
            bool relAligned = (relOffset % 8) == 0;
            Console.WriteLine($"    Asset PathId={info.PathId}: RelOffset=0x{relOffset:X8} (RelOffset%8={relOffset % 8}), AbsOffset=0x{absOffset:X8}, Size={info.ByteSize} bytes, Aligned={relAligned}");
            if (!relAligned) allAligned = false;
        }

        Console.WriteLine($"\n[✓] ALL ALIGNMENT CHECKS PASSED: {allAligned}");
        mgr.UnloadAll(true);
    }
}
