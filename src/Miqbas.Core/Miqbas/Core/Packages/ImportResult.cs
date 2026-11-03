using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Packages;

[RequiredMember]
public sealed class ImportResult : IEquatable<ImportResult>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ImportMatch, bool> _003C_003E9__7_0;

		public static Func<ImportMatch, bool> _003C_003E9__9_0;

		public static Func<ImportMatch, bool> _003C_003E9__11_0;

		internal bool A(ImportMatch P_0)
		{
			return P_0.Quality == MatchQuality.Exact;
		}

		internal bool a(ImportMatch P_0)
		{
			return P_0.Quality == MatchQuality.MovedButIdentical;
		}

		internal bool B(ImportMatch P_0)
		{
			return P_0.Quality == MatchQuality.Unmatched;
		}
	}

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ImportResult);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<ImportMatch> Matches
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int ExactCount => Enumerable.Count<ImportMatch>((System.Collections.Generic.IEnumerable<ImportMatch>)Matches, (Func<ImportMatch, bool>)((ImportMatch P_0) => P_0.Quality == MatchQuality.Exact));

	public int MovedCount => Enumerable.Count<ImportMatch>((System.Collections.Generic.IEnumerable<ImportMatch>)Matches, (Func<ImportMatch, bool>)((ImportMatch P_0) => P_0.Quality == MatchQuality.MovedButIdentical));

	public int UnmatchedCount => Enumerable.Count<ImportMatch>((System.Collections.Generic.IEnumerable<ImportMatch>)Matches, (Func<ImportMatch, bool>)((ImportMatch P_0) => P_0.Quality == MatchQuality.Unmatched));

	public double Coverage
	{
		get
		{
			if (((System.Collections.Generic.IReadOnlyCollection<ImportMatch>)Matches).Count != 0)
			{
				return (double)(ExactCount + MovedCount) / (double)((System.Collections.Generic.IReadOnlyCollection<ImportMatch>)Matches).Count;
			}
			return 0.0;
		}
	}

	[field: CompilerGenerated]
	public bool IsExactBuildMatch
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mQ());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mq());
		P_0.Append((object)Matches);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mR());
		P_0.Append(((object)ExactCount).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mr());
		P_0.Append(((object)MovedCount).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mS());
		P_0.Append(((object)UnmatchedCount).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.lK());
		P_0.Append(((object)Coverage).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ms());
		P_0.Append(((object)IsExactBuildMatch).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ImportResult? left, ImportResult? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ImportResult? left, ImportResult? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<ImportMatch>>.Default.GetHashCode(Matches)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsExactBuildMatch);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ImportResult);
	}

	[CompilerGenerated]
	public bool Equals(ImportResult? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<ImportMatch>>.Default.Equals(Matches, other.Matches))
			{
				return EqualityComparer<bool>.Default.Equals(IsExactBuildMatch, other.IsExactBuildMatch);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ImportResult(ImportResult P_0)
	{
		Matches = P_0.Matches;
		IsExactBuildMatch = P_0.IsExactBuildMatch;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ImportResult()
	{
	}
}
