using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Detection;

public sealed class TheKindOfUnityGame : IEquatable<TheKindOfUnityGame>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheKindOfUnityGame);
		}
	}

	[field: CompilerGenerated]
	public string? UnityVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ScriptingBackend Backend
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public GameBitness Bitness
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public WhereTheWordsAre Words
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public HowTheAssetsAreLaidOut Assets
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public WhatDrawsTheLetters Letters
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool CarriesALoaderAlready
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ManagedAssemblies
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string Key
	{
		get
		{
			string text = MajorVersion ?? _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bw();
			string text2 = Backend switch
			{
				ScriptingBackend.Mono => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BX(), 
				ScriptingBackend.Il2Cpp => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bx(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bw(), 
			};
			string text3 = Words switch
			{
				WhereTheWordsAre.PlainLanguageFiles => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BY(), 
				WhereTheWordsAre.StringTables => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.By(), 
				WhereTheWordsAre.InsideTheScenes => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BZ(), 
				WhereTheWordsAre.InsideTheCode => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bz(), 
				WhereTheWordsAre.OutOfReach => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bA(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bw(), 
			};
			string text4 = Assets switch
			{
				HowTheAssetsAreLaidOut.Loose => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ba(), 
				HowTheAssetsAreLaidOut.Packed => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bB(), 
				HowTheAssetsAreLaidOut.Addressables => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bb(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bw(), 
			};
			string text5 = Letters switch
			{
				WhatDrawsTheLetters.TextMeshPro => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bC(), 
				WhatDrawsTheLetters.AnOlderTextMeshPro => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bc(), 
				WhatDrawsTheLetters.TheOlderUnityLabel => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bD(), 
				WhatDrawsTheLetters.NoFontOfItsOwn => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bd(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bw(), 
			};
			return string.Join('·', new string[6]
			{
				_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.e(),
				text,
				text2,
				text3,
				text4,
				text5
			});
		}
	}

	public string Sentence
	{
		get
		{
			string text = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bE() + (UnityVersion ?? _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bw());
			string text2 = Backend switch
			{
				ScriptingBackend.Mono => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.be(), 
				ScriptingBackend.Il2Cpp => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bF(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bf(), 
			};
			string text3 = Words switch
			{
				WhereTheWordsAre.PlainLanguageFiles => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bG(), 
				WhereTheWordsAre.StringTables => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bg(), 
				WhereTheWordsAre.InsideTheScenes => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bH(), 
				WhereTheWordsAre.InsideTheCode => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bh(), 
				WhereTheWordsAre.OutOfReach => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bI(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bi(), 
			};
			string text4 = Assets switch
			{
				HowTheAssetsAreLaidOut.Loose => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bJ(), 
				HowTheAssetsAreLaidOut.Packed => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bj(), 
				HowTheAssetsAreLaidOut.Addressables => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bK(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bk(), 
			};
			string text5 = Letters switch
			{
				WhatDrawsTheLetters.TextMeshPro => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bL(), 
				WhatDrawsTheLetters.AnOlderTextMeshPro => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bl(), 
				WhatDrawsTheLetters.TheOlderUnityLabel => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bM(), 
				WhatDrawsTheLetters.NoFontOfItsOwn => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bm(), 
				_ => _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bN(), 
			};
			return string.Join(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bn(), new string[6]
			{
				text,
				text2,
				text3,
				text4,
				text5,
				CarriesALoaderAlready ? _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bo() : _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bO()
			});
		}
	}

	private string? MajorVersion
	{
		get
		{
			string unityVersion = UnityVersion;
			if (unityVersion == null || unityVersion.Length <= 0)
			{
				return null;
			}
			string[] array = unityVersion.Split('.', (StringSplitOptions)0);
			if (array.Length < 2)
			{
				return unityVersion;
			}
			return array[0] + _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bP() + array[1];
		}
	}

	public static TheKindOfUnityGame FromTheFolder(UnityGameInfo info, string gameRoot)
	{
		ArgumentNullException.ThrowIfNull((object)info, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bp());
		ArgumentNullException.ThrowIfNull((object)gameRoot, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aA());
		return new TheKindOfUnityGame
		{
			UnityVersion = info.UnityVersion,
			Backend = info.Backend,
			Bitness = info.Bitness,
			ManagedAssemblies = ((System.Collections.Generic.IReadOnlyCollection<string>)info.ManagedAssemblies).Count,
			CarriesALoaderAlready = A(gameRoot),
			Assets = a(info.DataDirectory),
			Words = B(gameRoot)
		};
	}

	public TheKindOfUnityGame AndWhatTheAssetsSay(WhatDrawsTheLetters letters)
	{
		TheKindOfUnityGame theKindOfUnityGame = _003CClone_003E_0024();
		theKindOfUnityGame.Letters = letters;
		return theKindOfUnityGame;
	}

	private static bool A(string P_0)
	{
		try
		{
			return Directory.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aH())) || File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aX())) || File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bm())) || File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BN()));
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	private static HowTheAssetsAreLaidOut a(string P_0)
	{
		try
		{
			if (!Directory.Exists(P_0))
			{
				return HowTheAssetsAreLaidOut.NotLookedAt;
			}
			if (File.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bQ())))
			{
				return HowTheAssetsAreLaidOut.Packed;
			}
			if (Directory.Exists(Path.Combine(P_0, _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bq(), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bR())))
			{
				return HowTheAssetsAreLaidOut.Addressables;
			}
			return HowTheAssetsAreLaidOut.Loose;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return HowTheAssetsAreLaidOut.NotLookedAt;
		}
	}

	private static WhereTheWordsAre B(string P_0)
	{
		try
		{
			return WhereTheWordsAre.NotLookedAt;
		}
		catch (System.Exception ex) when (((ex is IOException || ex is UnauthorizedAccessException) ? 1 : 0) != 0)
		{
			return WhereTheWordsAre.NotLookedAt;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.br());
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.a());
		if (A(val))
		{
			val.Append(' ');
		}
		val.Append('}');
		return ((object)val).ToString();
	}

	[CompilerGenerated]
	private bool A(StringBuilder P_0)
	{
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bS());
		P_0.Append((object)UnityVersion);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bs());
		P_0.Append(((object)Backend).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bT());
		P_0.Append(((object)Bitness).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bt());
		P_0.Append(((object)Words).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bU());
		P_0.Append(((object)Assets).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bu());
		P_0.Append(((object)Letters).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bV());
		P_0.Append(((object)CarriesALoaderAlready).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bv());
		P_0.Append(((object)ManagedAssemblies).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bW());
		P_0.Append((object)Key);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bw());
		P_0.Append((object)Sentence);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheKindOfUnityGame? left, TheKindOfUnityGame? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheKindOfUnityGame? left, TheKindOfUnityGame? right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UnityVersion)) * -1521134295 + EqualityComparer<ScriptingBackend>.Default.GetHashCode(Backend)) * -1521134295 + EqualityComparer<GameBitness>.Default.GetHashCode(Bitness)) * -1521134295 + EqualityComparer<WhereTheWordsAre>.Default.GetHashCode(Words)) * -1521134295 + EqualityComparer<HowTheAssetsAreLaidOut>.Default.GetHashCode(Assets)) * -1521134295 + EqualityComparer<WhatDrawsTheLetters>.Default.GetHashCode(Letters)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CarriesALoaderAlready)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ManagedAssemblies);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheKindOfUnityGame);
	}

	[CompilerGenerated]
	public bool Equals(TheKindOfUnityGame? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(UnityVersion, other.UnityVersion) && EqualityComparer<ScriptingBackend>.Default.Equals(Backend, other.Backend) && EqualityComparer<GameBitness>.Default.Equals(Bitness, other.Bitness) && EqualityComparer<WhereTheWordsAre>.Default.Equals(Words, other.Words) && EqualityComparer<HowTheAssetsAreLaidOut>.Default.Equals(Assets, other.Assets) && EqualityComparer<WhatDrawsTheLetters>.Default.Equals(Letters, other.Letters) && EqualityComparer<bool>.Default.Equals(CarriesALoaderAlready, other.CarriesALoaderAlready))
			{
				return EqualityComparer<int>.Default.Equals(ManagedAssemblies, other.ManagedAssemblies);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	public TheKindOfUnityGame _003CClone_003E_0024()
	{
		return new TheKindOfUnityGame(this);
	}

	[CompilerGenerated]
	private TheKindOfUnityGame(TheKindOfUnityGame P_0)
	{
		UnityVersion = P_0.UnityVersion;
		Backend = P_0.Backend;
		Bitness = P_0.Bitness;
		Words = P_0.Words;
		Assets = P_0.Assets;
		Letters = P_0.Letters;
		CarriesALoaderAlready = P_0.CarriesALoaderAlready;
		ManagedAssemblies = P_0.ManagedAssemblies;
	}

	public TheKindOfUnityGame()
	{
	}
}
