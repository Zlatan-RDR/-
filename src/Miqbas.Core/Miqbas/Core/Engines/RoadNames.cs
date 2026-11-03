using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public static class RoadNames
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<char, bool> _003C0_003E__IsAsciiLetter;
	}

	public const string Bannerlord = "BannerlordFullMode";

	public const string RenPy = "FullMode";

	public const string RpgMaker = "FullMode";

	public const string UnityBundles = "UnityBundlesFullMode";

	public const string UnityCodeText = "UnityCodeTextFullMode";

	public const string UnityLocaleFiles = "UnityLocaleFilesFullMode";

	public const string UnitySceneText = "UnitySceneTextFullMode";

	public const string UnityXPatch = "UnityXPatchFullMode";

	public const string RimWorldLanguage = "RimWorldLanguageFullMode";

	public const string OniLanguage = "OniLanguageFullMode";

	public const string ColossalLocale = "ColossalLocaleFullMode";

	public const string AceAttorney = "AceAttorneyFullMode";

	public const string Unreal = "UnrealFullMode";

	public const string Paradox = "ParadoxFullMode";

	public const string ParadoxClassic = "ParadoxClassicFullMode";

	public const string StardewLanguage = "StardewLanguageFullMode";

	public const string AgeStrings = "AgeStringsFullMode";

	public const string IsaacStrings = "IsaacStringsFullMode";

	public const string EssenceLocale = "EssenceLocaleFullMode";

	public const string RetiredUnityAssets = "UnityAssetsFullMode";

	private static readonly IReadOnlyDictionary<string, int> Writings = (IReadOnlyDictionary<string, int>)(object)new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal)
	{
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oF()] = 4,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.of()] = 3,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oG()] = 2,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.og()] = 1,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oH()] = 1,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oh()] = 1,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oI()] = 1,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oi()] = 1,
		[EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oJ()] = 1
	};

	[field: CompilerGenerated]
	public static IReadOnlySet<string> Known
	{
		[CompilerGenerated]
		get;
	}

	public static int WritingOf(string stored)
	{
		return CollectionExtensions.GetValueOrDefault<string, int>(Writings, TextRoadOf(stored));
	}

	public static string Of(IFullMode mode)
	{
		ArgumentNullException.ThrowIfNull((object)mode, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oE());
		if (mode is INamesItsRoad namesItsRoad)
		{
			return namesItsRoad.RoadName;
		}
		System.Type type = ((object)mode).GetType();
		return CustomAttributeExtensions.GetCustomAttribute<RoadNameAttribute>((MemberInfo)(object)type, false)?.Name ?? ((MemberInfo)type).Name;
	}

	public static string WithFace(IFullMode mode)
	{
		if (!(mode is ILendsArabicFont lendsArabicFont))
		{
			return Of(mode);
		}
		return WithFace(Of(mode), lendsArabicFont.WhereTheFaceComesFrom);
	}

	public static string WithFace(string road, FontRoad face)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(5, 2);
		defaultInterpolatedStringHandler.AppendFormatted(road);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NW());
		defaultInterpolatedStringHandler.AppendFormatted<FontRoad>(face);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oe());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string TextRoadOf(string stored)
	{
		int num = stored.IndexOf('+');
		if (num >= 0)
		{
			return stored.Substring(0, num);
		}
		return stored;
	}

	public static string FaceOf(string stored)
	{
		int num = stored.IndexOf('+');
		if (num >= 0)
		{
			int num2 = num;
			return stored.Substring(num2, stored.Length - num2);
		}
		return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
	}

	public static bool IsKnown(string stored)
	{
		return Known.Contains(TextRoadOf(stored));
	}

	public static bool DidNotLast(string stored)
	{
		string text = TextRoadOf(stored);
		int length = text.Length;
		if (length >= 1 && length <= 4 && Enumerable.All<char>((System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsAsciiLetter))
		{
			return !Known.Contains(text);
		}
		return false;
	}

	static RoadNames()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oi());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oj());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.of());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oH());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.og());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oF());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oG());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oK());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oh());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ok());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oL());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ol());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oM());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.om());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oI());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oJ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oN());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.on());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oO());
		Known = (IReadOnlySet<string>)(object)obj;
	}
}
