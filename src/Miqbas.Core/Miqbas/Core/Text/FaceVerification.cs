using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class FaceVerification : IEquatable<FaceVerification>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<int, string> _003C_003E9__26_0;

		internal string A(int P_0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rq());
			defaultInterpolatedStringHandler.AppendFormatted<int>(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rR());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(FaceVerification);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool Verified
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Because
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Wanted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<int> Missing
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<int> Blank
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Measured
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public static string Name(System.Collections.Generic.IReadOnlyList<int> codepoints)
	{
		string text = string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dZ(), Enumerable.Select<int, string>(Enumerable.Take<int>((System.Collections.Generic.IEnumerable<int>)codepoints, 8), (Func<int, string>)delegate(int P_0)
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler2.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rq());
			defaultInterpolatedStringHandler2.AppendFormatted<int>(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.rR());
			return defaultInterpolatedStringHandler2.ToStringAndClear();
		}));
		string text2;
		if (((System.Collections.Generic.IReadOnlyCollection<int>)codepoints).Count <= 8)
		{
			text2 = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		}
		else
		{
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hg());
			defaultInterpolatedStringHandler.AppendFormatted<int>(((System.Collections.Generic.IReadOnlyCollection<int>)codepoints).Count - 8);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
			text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text + text2;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HH());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hh());
		P_0.Append(((object)Verified).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HI());
		P_0.Append((object)Because);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hi());
		P_0.Append(((object)Wanted).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HJ());
		P_0.Append((object)Missing);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hj());
		P_0.Append((object)Blank);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HK());
		P_0.Append(((object)Measured).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(FaceVerification? left, FaceVerification? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(FaceVerification? left, FaceVerification? right)
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
		return (((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Verified)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Because)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Wanted)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(Missing)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(Blank)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Measured);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as FaceVerification);
	}

	[CompilerGenerated]
	public bool Equals(FaceVerification? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(Verified, other.Verified) && EqualityComparer<string>.Default.Equals(Because, other.Because) && EqualityComparer<int>.Default.Equals(Wanted, other.Wanted) && EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(Missing, other.Missing) && EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(Blank, other.Blank))
			{
				return EqualityComparer<bool>.Default.Equals(Measured, other.Measured);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private FaceVerification(FaceVerification P_0)
	{
		Verified = P_0.Verified;
		Because = P_0.Because;
		Wanted = P_0.Wanted;
		Missing = P_0.Missing;
		Blank = P_0.Blank;
		Measured = P_0.Measured;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public FaceVerification()
	{
		Measured = true;
		base._002Ector();
	}
}
