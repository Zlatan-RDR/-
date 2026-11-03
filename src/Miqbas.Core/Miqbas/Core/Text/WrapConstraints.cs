using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class WrapConstraints : IEquatable<WrapConstraints>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(WrapConstraints);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public double MaxWidth
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public double FontSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? MaxLines
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hA());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ha());
		P_0.Append(((object)MaxWidth).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hB());
		P_0.Append(((object)FontSize).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hb());
		P_0.Append(((object)MaxLines).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(WrapConstraints? left, WrapConstraints? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(WrapConstraints? left, WrapConstraints? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(MaxWidth)) * -1521134295 + EqualityComparer<double>.Default.GetHashCode(FontSize)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(MaxLines);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as WrapConstraints);
	}

	[CompilerGenerated]
	public bool Equals(WrapConstraints? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<double>.Default.Equals(MaxWidth, other.MaxWidth) && EqualityComparer<double>.Default.Equals(FontSize, other.FontSize))
			{
				return EqualityComparer<int?>.Default.Equals(MaxLines, other.MaxLines);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private WrapConstraints(WrapConstraints P_0)
	{
		MaxWidth = P_0.MaxWidth;
		FontSize = P_0.FontSize;
		MaxLines = P_0.MaxLines;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public WrapConstraints()
	{
	}
}
