using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

[RequiredMember]
public sealed class TheCodeOffer : IEquatable<TheCodeOffer>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TheCodeOffer);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Lines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Sentence
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Detail
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public static TheCodeOffer Of(int lines)
	{
		TheCodeOffer obj = new TheCodeOffer
		{
			Lines = lines
		};
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(44, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OD());
		defaultInterpolatedStringHandler.AppendFormatted<int>(lines, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FD());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Od());
		obj.Sentence = defaultInterpolatedStringHandler.ToStringAndClear() + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OE();
		obj.Detail = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oe();
		return obj;
	}

	public static bool MostOfTheGameIsIn(int codeLines, int readWithoutIt)
	{
		return codeLines > readWithoutIt;
	}

	public static string MostOfItSentence(int lines)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(60, 1);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OF());
		defaultInterpolatedStringHandler.AppendFormatted<int>(lines, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FD());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Of());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OG());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hc());
		P_0.Append(((object)Lines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Og());
		P_0.Append((object)Sentence);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OH());
		P_0.Append((object)Detail);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TheCodeOffer? left, TheCodeOffer? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TheCodeOffer? left, TheCodeOffer? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Lines)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sentence)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Detail);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TheCodeOffer);
	}

	[CompilerGenerated]
	public bool Equals(TheCodeOffer? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Lines, other.Lines) && EqualityComparer<string>.Default.Equals(Sentence, other.Sentence))
			{
				return EqualityComparer<string>.Default.Equals(Detail, other.Detail);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private TheCodeOffer(TheCodeOffer P_0)
	{
		Lines = P_0.Lines;
		Sentence = P_0.Sentence;
		Detail = P_0.Detail;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public TheCodeOffer()
	{
	}
}
