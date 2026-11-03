using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;
using Miqbas.Core.Engines;
using Miqbas.Core.Translation;

namespace Miqbas.Core.Packages;

public static class MqbsPackage
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ZipArchiveEntry, bool> _003C_003E9__14_0;

		internal bool A(ZipArchiveEntry P_0)
		{
			return P_0.FullName.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lQ(), (StringComparison)4);
		}
	}

	public const string FileExtension = ".mqbs";

	private const string ManifestEntry = "manifest.json";

	private const string InstallEntry = "install.json";

	private const string TranslationsEntry = "translations.json";

	private const string GlossaryEntry = "glossary.json";

	private const string ShapesEntry = "shapes.json";

	public const int MostShapes = 1000;

	public const int MostShapesBytes = 4194304;

	private const string FontsPrefix = "fonts/";

	private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
	{
		WriteIndented = true,
		Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
		TypeInfoResolver = i.Default
	};

	private static readonly string[] ForbiddenExtensions = new string[13]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.LI(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lh(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lU(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lu(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lV(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lv(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lW(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lw(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lX(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lx(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lY(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ly(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lZ()
	};

	public static void Write(string packagePath, MqbsManifest manifest, System.Collections.Generic.IReadOnlyList<MqbsEntry> entries, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? glossary = null, System.Collections.Generic.IReadOnlyList<string>? fontPaths = null, MqbsInstall? install = null, System.Collections.Generic.IReadOnlyList<LearnedShape>? shapes = null)
	{
		ZipArchive val = ZipFile.Open(packagePath, (ZipArchiveMode)1);
		try
		{
			A(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ln(), manifest);
			A(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lO(), install ?? MqbsInstall.FullPatchFor(manifest.EngineId));
			A(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lo(), entries);
			if (glossary != null && ((System.Collections.Generic.IReadOnlyCollection<GlossaryEntry>)glossary).Count > 0)
			{
				A(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lP(), glossary);
			}
			if (shapes != null && ((System.Collections.Generic.IReadOnlyCollection<LearnedShape>)shapes).Count > 0)
			{
				A(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lp(), shapes);
			}
			System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)(fontPaths ?? System.Array.Empty<string>())).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					string current = enumerator.Current;
					string fileName = Path.GetFileName(current);
					A(fileName);
					ZipFileExtensions.CreateEntryFromFile(val, current, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lQ() + fileName);
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	public static MqbsContents Read(string packagePath)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		ZipArchive val = ZipFile.OpenRead(packagePath);
		try
		{
			MqbsManifest mqbsManifest = A<MqbsManifest>(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ln()) ?? throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lq());
			List<MqbsEntry> entries = A<List<MqbsEntry>>(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lo()) ?? throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lR());
			List<GlossaryEntry> glossary = A<List<GlossaryEntry>>(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lP()) ?? new List<GlossaryEntry>();
			System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = val.Entries.GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					A(enumerator.Current.FullName);
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return new MqbsContents
			{
				Manifest = mqbsManifest,
				Install = (A<MqbsInstall>(val, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lO()) ?? MqbsInstall.FullPatchFor(mqbsManifest.EngineId)),
				Entries = (System.Collections.Generic.IReadOnlyList<MqbsEntry>)entries,
				Glossary = (System.Collections.Generic.IReadOnlyList<GlossaryEntry>)glossary,
				Shapes = A(val)
			};
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static System.Collections.Generic.IReadOnlyList<LearnedShape> A(ZipArchive P_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ZipArchiveEntry entry = P_0.GetEntry(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lp());
		if (entry == null)
		{
			return System.Array.Empty<LearnedShape>();
		}
		Stream val = entry.Open();
		try
		{
			MemoryStream val2 = new MemoryStream();
			byte[] array = new byte[81920];
			int num;
			while ((num = val.Read(array, 0, array.Length)) > 0)
			{
				if (((Stream)val2).Length + num > 4194304)
				{
					return System.Array.Empty<LearnedShape>();
				}
				((Stream)val2).Write(array, 0, num);
			}
			JsonElement jsonElement;
			try
			{
				jsonElement = JsonSerializer.Deserialize(System.ReadOnlySpan<byte>.op_Implicit(val2.ToArray()), i.Default.JsonElement);
			}
			catch (JsonException)
			{
				return System.Array.Empty<LearnedShape>();
			}
			if (jsonElement.ValueKind != JsonValueKind.Array)
			{
				return System.Array.Empty<LearnedShape>();
			}
			List<LearnedShape> val3 = new List<LearnedShape>();
			System.Collections.Generic.IEnumerator<JsonElement> enumerator = Enumerable.Take<JsonElement>((System.Collections.Generic.IEnumerable<JsonElement>)jsonElement.EnumerateArray(), 1000).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					JsonElement current = enumerator.Current;
					try
					{
						LearnedShape learnedShape = current.Deserialize(J.Default.LearnedShape);
						if ((object)learnedShape != null)
						{
							val3.Add(learnedShape);
						}
					}
					catch (System.Exception ex2) when (((ex2 is JsonException || ex2 is ArgumentException || ex2 is InvalidOperationException || ex2 is NotSupportedException) ? 1 : 0) != 0)
					{
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return (System.Collections.Generic.IReadOnlyList<LearnedShape>)val3;
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	public static System.Collections.Generic.IReadOnlyList<string> ExtractFonts(string packagePath, string destinationDir)
	{
		ZipArchive val = ZipFile.OpenRead(packagePath);
		try
		{
			Directory.CreateDirectory(destinationDir);
			List<string> val2 = new List<string>();
			System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = Enumerable.Where<ZipArchiveEntry>((System.Collections.Generic.IEnumerable<ZipArchiveEntry>)val.Entries, (Func<ZipArchiveEntry, bool>)((ZipArchiveEntry P_0) => P_0.FullName.StartsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lQ(), (StringComparison)4))).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ZipArchiveEntry current = enumerator.Current;
					string fileName = Path.GetFileName(current.FullName);
					if (!string.IsNullOrEmpty(fileName))
					{
						A(fileName);
						string text = Path.Combine(destinationDir, fileName);
						ZipFileExtensions.ExtractToFile(current, text, true);
						val2.Add(text);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			return (System.Collections.Generic.IReadOnlyList<string>)val2;
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static void A(string P_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lr(), (StringComparison)4) || Path.IsPathRooted(P_0) || P_0.Contains(':'))
		{
			throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lS() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ls());
		}
		string extension = Path.GetExtension(P_0);
		if (Enumerable.Contains<string>((System.Collections.Generic.IEnumerable<string>)ForbiddenExtensions, extension, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase))
		{
			throw new InvalidDataException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lT() + P_0 + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lt());
		}
	}

	private static void A<T>(ZipArchive P_0, string P_1, T P_2)
	{
		Stream val = P_0.CreateEntry(P_1, (CompressionLevel)0).Open();
		try
		{
			JsonSerializer.Serialize(val, P_2, (JsonTypeInfo<T>)JsonOptions.GetTypeInfo(typeof(T)));
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	private static T? A<T>(ZipArchive P_0, string P_1)
	{
		ZipArchiveEntry entry = P_0.GetEntry(P_1);
		if (entry == null)
		{
			return default(T);
		}
		Stream val = entry.Open();
		try
		{
			return JsonSerializer.Deserialize(val, (JsonTypeInfo<T>)JsonOptions.GetTypeInfo(typeof(T)));
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}
}
