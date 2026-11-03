using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;
using Miqbas.Engines.Unreal.Detection;
using Miqbas.Engines.Unreal.Localization;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Mods;

public static class ModsPatch
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<string, bool> _003C0_003E__IsAnEngineFace;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<LocResEntry, ValueTuple<string, string, string, string>> _003C_003E9__5_0;

		internal ValueTuple<string, string, string, string> A(LocResEntry P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string, string, string>(P_0.Namespace, P_0.Key, P_0.Value, P_0.Value);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public Func<CookedText, string> targetFor;

		internal ValueTuple<string, string, string, string> A(CookedText P_0)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string, string, string>(P_0.Namespace, P_0.Key, P_0.Source, targetFor.Invoke(P_0));
		}

		internal ValueTuple<string, string, string, string> a(CookedText P_0)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string, string, string>(P_0.Namespace, P_0.Key, P_0.Source, targetFor.Invoke(P_0));
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public UnrealGameLayout layout;

		internal string A(string P_0)
		{
			return Path.GetRelativePath(layout.GameRoot, Path.Combine(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cu() + P_0));
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public UnrealGameLayout layout;

		internal bool A(string P_0)
		{
			return File.Exists(Path.Combine(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cu() + P_0));
		}
	}

	public const string Name = "MiqbasMods_2_P";

	private const string GamePatchName = "Miqbas_1_P";

	private const string EngineTable = "Engine/Content/Localization/Engine/en/Engine.locres";

	private const string ArabicEngineTable = "Engine/Content/Localization/Engine/ar/Engine.locres";

	private static readonly string[] Parts = new string[3]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.O(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cO(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ax()
	};

	public static bool IsOneOfOurs(string path)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
		if (!fileNameWithoutExtension.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cu(), (StringComparison)5))
		{
			return fileNameWithoutExtension.Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CV(), (StringComparison)5);
		}
		return true;
	}

	public static void Write(UnrealGameLayout layout, string gameRoot, IPakDecompressor? decompressor, global::System.Collections.Generic.IReadOnlyList<CookedText> lines, Func<CookedText, string> targetFor, Action<string> say, string? arabicFontPath = null)
	{
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		Func<CookedText, string> targetFor2 = targetFor;
		global::System.Collections.Generic.IReadOnlyList<LocResEntry> readOnlyList = A(layout, decompressor, say);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(40, 1);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cv());
		defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Collections.Generic.IReadOnlyCollection<LocResEntry>)readOnlyList).Count, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cw());
		say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		List<ValueTuple<string, string, string, string>> obj = new List<ValueTuple<string, string, string, string>>();
		obj.AddRange(Enumerable.Concat<ValueTuple<string, string, string, string>>(Enumerable.Select<LocResEntry, ValueTuple<string, string, string, string>>((global::System.Collections.Generic.IEnumerable<LocResEntry>)readOnlyList, (Func<LocResEntry, ValueTuple<string, string, string, string>>)((LocResEntry P_0) => new ValueTuple<string, string, string, string>(P_0.Namespace, P_0.Key, P_0.Value, P_0.Value))), Enumerable.Select<CookedText, ValueTuple<string, string, string, string>>((global::System.Collections.Generic.IEnumerable<CookedText>)lines, (Func<CookedText, ValueTuple<string, string, string, string>>)((CookedText P_0) => new ValueTuple<string, string, string, string>(P_0.Namespace, P_0.Key, P_0.Source, targetFor2.Invoke(P_0))))));
		LocResFile locResFile = LocResFile.FromScratch(new E<ValueTuple<string, string, string, string>>(obj));
		List<ValueTuple<string, string, string, string>> obj2 = new List<ValueTuple<string, string, string, string>>();
		obj2.AddRange(Enumerable.Select<CookedText, ValueTuple<string, string, string, string>>((global::System.Collections.Generic.IEnumerable<CookedText>)lines, (Func<CookedText, ValueTuple<string, string, string, string>>)((CookedText P_0) => new ValueTuple<string, string, string, string>(P_0.Namespace, P_0.Key, P_0.Source, targetFor2.Invoke(P_0)))));
		LocResFile locResFile2 = LocResFile.FromScratch(new E<ValueTuple<string, string, string, string>>(obj2));
		Dictionary<string, byte[]> val = new Dictionary<string, byte[]>((IEqualityComparer<string>)(object)StringComparer.Ordinal)
		{
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.s()] = locResFile.ToBytes(),
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CX()] = locResFile.ToBytes(),
			[layout.ProjectName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cx()] = locResFile2.ToBytes()
		};
		int num = 0;
		if (arabicFontPath != null && arabicFontPath.Length > 0 && File.Exists(arabicFontPath))
		{
			string[] files = Directory.GetFiles(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CY());
			foreach (string text2 in files)
			{
				if (IsOneOfOurs(text2))
				{
					continue;
				}
				using PakArchive pakArchive = A(text2, say);
				if (pakArchive != null)
				{
					num += global::A.b.A(pakArchive, arabicFontPath, val, global::A.b.A);
				}
			}
		}
		string text3 = Path.Combine(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cy());
		PakWriter.Write(text3, layout.RootMountPoint, (IReadOnlyDictionary<string, byte[]>)(object)val, PakWriter.FormatFor(A(layout, say)));
		say.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa());
		defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(22, 2);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CZ());
		defaultInterpolatedStringHandler.AppendFormatted(Path.GetFileName(text3));
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cz());
		defaultInterpolatedStringHandler.AppendFormatted<long>(new FileInfo(text3).Length, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cA());
		say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		Enumerator<string, byte[]> enumerator = val.Keys.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				say.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ca() + current);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cB());
		defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Collections.Generic.IReadOnlyCollection<CookedText>)lines).Count, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cb());
		say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		string text4;
		if (num <= 0)
		{
			text4 = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cC();
		}
		else
		{
			defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(63, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cc());
			defaultInterpolatedStringHandler.AppendFormatted(Path.GetFileNameWithoutExtension(arabicFontPath));
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cD());
			defaultInterpolatedStringHandler.AppendFormatted<int>(num, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cd());
			text4 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		say.Invoke(text4);
		A(layout, gameRoot, say);
	}

	private static void A(UnrealGameLayout P_0, string P_1, Action<string> P_2)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (!IoStoreWriter.GameUsesContainers(P_0.PaksDirectory))
		{
			return;
		}
		int? num = IoStoreWriter.GameContainerVersion(P_0.PaksDirectory);
		string text = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cE();
		if (!num.HasValue)
		{
			Enumerator<string> enumerator = ModContainers.Under(P_1).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					try
					{
						num = IoStoreContainer.Open(current).Version;
						text = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ce();
					}
					catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is NotSupportedException || ex is IOException) ? 1 : 0) != 0)
					{
						continue;
					}
					break;
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}
		if (num.HasValue)
		{
			int valueOrDefault = num.GetValueOrDefault();
			IoStoreWriter.Write(Path.Combine(P_0.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cF()), Path.Combine(P_0.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cf()), valueOrDefault);
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(85, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cG());
			defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cg());
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cH());
			P_2.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		else
		{
			P_2.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ch());
			P_2.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cI());
			P_2.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ci());
		}
	}

	public static global::System.Collections.Generic.IReadOnlyList<string> FilesFor(UnrealGameLayout layout)
	{
		UnrealGameLayout layout2 = layout;
		List<string> obj = new List<string>();
		obj.AddRange(Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)Parts, (Func<string, string>)((string P_0) => Path.GetRelativePath(layout2.GameRoot, Path.Combine(layout2.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cu() + P_0)))));
		return new E<string>(obj);
	}

	public static int Remove(string gameRoot, global::System.Collections.Generic.IReadOnlyList<string> files, Action<string>? say = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)files, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CF());
		UnrealGameLayout unrealGameLayout = UnrealGameLayout.Read(gameRoot) ?? throw new InvalidOperationException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cJ());
		int num = 0;
		global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)files).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				string fullPath = Path.GetFullPath(Path.Combine(unrealGameLayout.GameRoot, current));
				if (!fullPath.StartsWith(Path.GetFullPath(unrealGameLayout.GameRoot), (StringComparison)5) || !Path.GetFileNameWithoutExtension(fullPath).Equals(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cu(), (StringComparison)5))
				{
					say?.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cj() + current);
				}
				else if (File.Exists(fullPath))
				{
					File.Delete(fullPath);
					say?.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cK() + Path.GetFileName(fullPath));
					num++;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (say != null)
		{
			string text;
			if (num != 0)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(55, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ck());
				defaultInterpolatedStringHandler.AppendFormatted<int>(num, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cL());
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cl();
			}
			say.Invoke(text);
		}
		return num;
	}

	public static bool FilesArePresent(string gameRoot)
	{
		UnrealGameLayout layout = UnrealGameLayout.Read(gameRoot);
		if ((object)layout == null)
		{
			return false;
		}
		return Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)Parts, (Func<string, bool>)((string P_0) => File.Exists(Path.Combine(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cu() + P_0))));
	}

	private static PakArchive? A(string P_0, Action<string>? say)
	{
		try
		{
			return PakArchive.Open(P_0);
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			say?.Invoke(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cM() + Path.GetFileName(P_0) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cm() + ex.Message);
			return null;
		}
	}

	private static global::System.Collections.Generic.IReadOnlyList<LocResEntry> A(UnrealGameLayout P_0, IPakDecompressor? decompressor, Action<string>? say = null)
	{
		string[] files = Directory.GetFiles(P_0.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CY());
		foreach (string text in files)
		{
			if (IsOneOfOurs(text))
			{
				continue;
			}
			using PakArchive pakArchive = A(text, say);
			if (pakArchive == null)
			{
				continue;
			}
			global::System.Collections.Generic.IEnumerator<PakEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<PakEntry>)pakArchive.Entries).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					PakEntry current = enumerator.Current;
					if (current.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cN(), (StringComparison)5))
					{
						return PackagedTable.Read(pakArchive, current, decompressor).Entries;
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
		}
		return global::System.Array.Empty<LocResEntry>();
	}

	private static int A(UnrealGameLayout P_0, Action<string>? say = null)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		string[] files = Directory.GetFiles(P_0.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CY());
		foreach (string text in files)
		{
			if (IsOneOfOurs(text))
			{
				continue;
			}
			using PakArchive pakArchive = A(text, say);
			if (pakArchive == null)
			{
				continue;
			}
			return pakArchive.Version;
		}
		throw new InvalidOperationException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cn());
	}
}
