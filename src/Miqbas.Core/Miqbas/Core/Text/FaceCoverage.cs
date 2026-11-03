using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class FaceCoverage : IEquatable<FaceCoverage>
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<int, string> _003C0_003E__Of;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<string, string> _003C_003E9__17_0;

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
			return typeof(FaceCoverage);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Original
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<int> Lost
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<int> MissingArabic
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool LosesNothing
	{
		get
		{
			if (((System.Collections.Generic.IReadOnlyCollection<int>)Lost).Count == 0)
			{
				return ((System.Collections.Generic.IReadOnlyCollection<int>)MissingArabic).Count == 0;
			}
			return false;
		}
	}

	public System.Collections.Generic.IReadOnlyList<string> LanguagesThatWouldBreak => (System.Collections.Generic.IReadOnlyList<string>)Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Distinct<string>(Enumerable.Select<int, string>((System.Collections.Generic.IEnumerable<int>)Lost, (Func<int, string>)ScriptNames.Of), (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.Ordinal));

	public string InArabic
	{
		get
		{
			if (!LosesNothing)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (((System.Collections.Generic.IReadOnlyCollection<int>)MissingArabic).Count <= 0 || ((System.Collections.Generic.IReadOnlyCollection<int>)Lost).Count != 0)
				{
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(68, 3);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW());
					defaultInterpolatedStringHandler.AppendFormatted(Original);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GH());
					defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<int>)Lost).Count);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gh());
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GI());
					defaultInterpolatedStringHandler.AppendFormatted(string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aa(), (System.Collections.Generic.IEnumerable<string>)LanguagesThatWouldBreak));
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EB());
					return defaultInterpolatedStringHandler.ToStringAndClear();
				}
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(48, 2);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW());
				defaultInterpolatedStringHandler.AppendFormatted(Original);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gi());
				defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<int>)MissingArabic).Count);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GJ());
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dW() + Original + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gj();
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GK());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gk());
		P_0.Append((object)Original);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GL());
		P_0.Append((object)Lost);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gl());
		P_0.Append((object)MissingArabic);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GM());
		P_0.Append(((object)LosesNothing).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gm());
		P_0.Append((object)LanguagesThatWouldBreak);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GN());
		P_0.Append((object)InArabic);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(FaceCoverage? left, FaceCoverage? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(FaceCoverage? left, FaceCoverage? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Original)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(Lost)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(MissingArabic);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as FaceCoverage);
	}

	[CompilerGenerated]
	public bool Equals(FaceCoverage? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Original, other.Original) && EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(Lost, other.Lost))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(MissingArabic, other.MissingArabic);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private FaceCoverage(FaceCoverage P_0)
	{
		Original = P_0.Original;
		Lost = P_0.Lost;
		MissingArabic = P_0.MissingArabic;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public FaceCoverage()
	{
	}
}
