using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Baseline;

[RequiredMember]
public sealed class GameBaseline : IEquatable<GameBaseline>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, string> _003C_003E9__94_0;

		internal string A(string P_0)
		{
			return P_0;
		}
	}

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(GameBaseline);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Engine
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? EngineVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Fingerprint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Protection
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool FullAvailable
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? FullUnavailableReason
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Road
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? Lines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? Sentences
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? SentencesHash
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, int> SentencesByFile
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, string> FileStamps
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? ArabicLines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? ArabicCanBeDrawn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ArabicWillNotDrawBecause
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool? FaceIsAdded
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Failure
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool ReadAsShipped
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? SetAside
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public double Seconds
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long PeakMegabytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public static string HashOf(System.Collections.Generic.IEnumerable<string> sentences)
	{
		ArgumentNullException.ThrowIfNull((object)sentences, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qD());
		IOrderedEnumerable<string> val = Enumerable.OrderBy<string, string>(Enumerable.Distinct<string>(sentences, (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.Ordinal);
		return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(string.Join<string>('\n', (System.Collections.Generic.IEnumerable<string>)val)))).Substring(0, 16);
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qd());
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.o());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.P());
		P_0.Append((object)Name);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kt());
		P_0.Append((object)Path);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qi());
		P_0.Append((object)Engine);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kI());
		P_0.Append((object)EngineVersion);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ki());
		P_0.Append((object)Fingerprint);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qE());
		P_0.Append((object)Protection);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qe());
		P_0.Append(((object)FullAvailable).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qF());
		P_0.Append((object)FullUnavailableReason);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QJ());
		P_0.Append((object)Road);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Op());
		P_0.Append(((object)Lines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qf());
		P_0.Append(((object)Sentences).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qG());
		P_0.Append((object)SentencesHash);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qg());
		P_0.Append((object)SentencesByFile);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qH());
		P_0.Append((object)FileStamps);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qh());
		P_0.Append(((object)ArabicLines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kp());
		P_0.Append(((object)ArabicCanBeDrawn).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qI());
		P_0.Append((object)ArabicWillNotDrawBecause);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qi());
		P_0.Append(((object)FaceIsAdded).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qJ());
		P_0.Append((object)Failure);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qj());
		P_0.Append(((object)ReadAsShipped).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qK());
		P_0.Append((object)SetAside);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qk());
		P_0.Append(((object)Seconds).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qL());
		P_0.Append(((object)PeakMegabytes).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GameBaseline? left, GameBaseline? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GameBaseline? left, GameBaseline? right)
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
		return ((((((((((((((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Engine)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngineVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fingerprint)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Protection)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(FullAvailable)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FullUnavailableReason)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Road)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Lines)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Sentences)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SentencesHash)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, int>>.Default.GetHashCode(SentencesByFile)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, string>>.Default.GetHashCode(FileStamps)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(ArabicLines)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(ArabicCanBeDrawn)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ArabicWillNotDrawBecause)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(FaceIsAdded)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Failure)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ReadAsShipped)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SetAside)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(Seconds)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(PeakMegabytes);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as GameBaseline);
	}

	[CompilerGenerated]
	public bool Equals(GameBaseline? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<string>.Default.Equals(Engine, other.Engine) && EqualityComparer<string>.Default.Equals(EngineVersion, other.EngineVersion) && EqualityComparer<string>.Default.Equals(Fingerprint, other.Fingerprint) && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Protection, other.Protection) && EqualityComparer<bool>.Default.Equals(FullAvailable, other.FullAvailable) && EqualityComparer<string>.Default.Equals(FullUnavailableReason, other.FullUnavailableReason) && EqualityComparer<string>.Default.Equals(Road, other.Road) && EqualityComparer<int?>.Default.Equals(Lines, other.Lines) && EqualityComparer<int?>.Default.Equals(Sentences, other.Sentences) && EqualityComparer<string>.Default.Equals(SentencesHash, other.SentencesHash) && EqualityComparer<IReadOnlyDictionary<string, int>>.Default.Equals(SentencesByFile, other.SentencesByFile) && EqualityComparer<IReadOnlyDictionary<string, string>>.Default.Equals(FileStamps, other.FileStamps) && EqualityComparer<int?>.Default.Equals(ArabicLines, other.ArabicLines) && EqualityComparer<bool?>.Default.Equals(ArabicCanBeDrawn, other.ArabicCanBeDrawn) && EqualityComparer<string>.Default.Equals(ArabicWillNotDrawBecause, other.ArabicWillNotDrawBecause) && EqualityComparer<bool?>.Default.Equals(FaceIsAdded, other.FaceIsAdded) && EqualityComparer<string>.Default.Equals(Failure, other.Failure) && EqualityComparer<bool>.Default.Equals(ReadAsShipped, other.ReadAsShipped) && EqualityComparer<string>.Default.Equals(SetAside, other.SetAside) && EqualityComparer<double>.Default.Equals(Seconds, other.Seconds))
			{
				return EqualityComparer<long>.Default.Equals(PeakMegabytes, other.PeakMegabytes);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private GameBaseline(GameBaseline original)
	{
		Name = original.Name;
		Path = original.Path;
		Engine = original.Engine;
		EngineVersion = original.EngineVersion;
		Fingerprint = original.Fingerprint;
		Protection = original.Protection;
		FullAvailable = original.FullAvailable;
		FullUnavailableReason = original.FullUnavailableReason;
		Road = original.Road;
		Lines = original.Lines;
		Sentences = original.Sentences;
		SentencesHash = original.SentencesHash;
		SentencesByFile = original.SentencesByFile;
		FileStamps = original.FileStamps;
		ArabicLines = original.ArabicLines;
		ArabicCanBeDrawn = original.ArabicCanBeDrawn;
		ArabicWillNotDrawBecause = original.ArabicWillNotDrawBecause;
		FaceIsAdded = original.FaceIsAdded;
		Failure = original.Failure;
		ReadAsShipped = original.ReadAsShipped;
		SetAside = original.SetAside;
		Seconds = original.Seconds;
		PeakMegabytes = original.PeakMegabytes;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public GameBaseline()
	{
		Protection = System.Array.Empty<string>();
		SentencesByFile = (IReadOnlyDictionary<string, int>)(object)new Dictionary<string, int>();
		FileStamps = (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>();
		base._002Ector();
	}
}
