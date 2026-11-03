using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class TheSourceBlock : IEquatable<TheSourceBlock>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheSourceBlock);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool Found
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Languages
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int BlockSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int TakeFirst
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string InArabic
	{
		get
		{
			if (!Found)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HV();
			}
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(30, 3);
			defaultInterpolatedStringHandler.AppendFormatted<int>(Languages);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hv());
			defaultInterpolatedStringHandler.AppendFormatted<int>(BlockSize);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HW());
			defaultInterpolatedStringHandler.AppendFormatted<int>(TakeFirst);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hw());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HX());
		P_0.Append(((object)Found).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hx());
		P_0.Append(((object)Languages).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HY());
		P_0.Append(((object)BlockSize).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hy());
		P_0.Append(((object)TakeFirst).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GN());
		P_0.Append((object)InArabic);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheSourceBlock? left, TheSourceBlock? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheSourceBlock? left, TheSourceBlock? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Found)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Languages)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BlockSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(TakeFirst);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheSourceBlock);
	}

	[CompilerGenerated]
	public bool Equals(TheSourceBlock? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(Found, other.Found) && EqualityComparer<int>.Default.Equals(Languages, other.Languages) && EqualityComparer<int>.Default.Equals(BlockSize, other.BlockSize))
			{
				return EqualityComparer<int>.Default.Equals(TakeFirst, other.TakeFirst);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TheSourceBlock(TheSourceBlock P_0)
	{
		Found = P_0.Found;
		Languages = P_0.Languages;
		BlockSize = P_0.BlockSize;
		TakeFirst = P_0.TakeFirst;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TheSourceBlock()
	{
	}
}
