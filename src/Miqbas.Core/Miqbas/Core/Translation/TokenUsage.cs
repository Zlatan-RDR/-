using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public sealed class TokenUsage : IEquatable<TokenUsage>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TokenUsage);
		}
	}

	[field: CompilerGenerated]
	public static TokenUsage Empty
	{
		[CompilerGenerated]
		get;
	} = new TokenUsage();


	[field: CompilerGenerated]
	public long InputTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long OutputTokens
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Requests
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool IsEmpty
	{
		get
		{
			if (InputTokens == 0L && OutputTokens == 0L)
			{
				return Requests == 0;
			}
			return false;
		}
	}

	public static TokenUsage Of(object? provider)
	{
		if (!(provider is IReportsTokenUsage reportsTokenUsage))
		{
			return Empty;
		}
		return reportsTokenUsage.Usage;
	}

	public TokenUsage Plus(TokenUsage other)
	{
		return new TokenUsage
		{
			InputTokens = InputTokens + other.InputTokens,
			OutputTokens = OutputTokens + other.OutputTokens,
			Requests = Requests + other.Requests
		};
	}

	public TokenUsage Since(TokenUsage earlier)
	{
		return new TokenUsage
		{
			InputTokens = Math.Max(0L, InputTokens - earlier.InputTokens),
			OutputTokens = Math.Max(0L, OutputTokens - earlier.OutputTokens),
			Requests = Math.Max(0, Requests - earlier.Requests)
		};
	}

	public decimal? CostUsd(ModelInfo model)
	{
		decimal? inputPricePerMillionTokens = model.InputPricePerMillionTokens;
		if (inputPricePerMillionTokens.HasValue)
		{
			decimal valueOrDefault = inputPricePerMillionTokens.GetValueOrDefault();
			inputPricePerMillionTokens = model.OutputPricePerMillionTokens;
			if (inputPricePerMillionTokens.HasValue)
			{
				decimal valueOrDefault2 = inputPricePerMillionTokens.GetValueOrDefault();
				return decimal.op_Implicit(InputTokens) / 1000000m * valueOrDefault + decimal.op_Implicit(OutputTokens) / 1000000m * valueOrDefault2;
			}
		}
		if (model.Tier != 0)
		{
			return null;
		}
		return 0m;
	}

	public string Summary(ModelInfo model)
	{
		System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(29, 4);
		defaultInterpolatedStringHandler.AppendFormatted<int>(Requests);
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fc());
		defaultInterpolatedStringHandler.AppendFormatted<long>(InputTokens + OutputTokens, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FD());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fd());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FE());
		defaultInterpolatedStringHandler.AppendFormatted<long>(InputTokens, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FD());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fe());
		defaultInterpolatedStringHandler.AppendFormatted<long>(OutputTokens, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FD());
		defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.z());
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		decimal? num = CostUsd(model);
		if (num.HasValue)
		{
			decimal valueOrDefault = num.GetValueOrDefault();
			if (valueOrDefault < 0.01m)
			{
				if (valueOrDefault == 0m)
				{
					return text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ff();
				}
				return text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FG();
			}
			decimal? num2 = num;
			defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(9, 2);
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ds());
			defaultInterpolatedStringHandler.AppendFormatted<decimal?>(num2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fg());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FH());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FF();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fh());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FI());
		P_0.Append(((object)InputTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fi());
		P_0.Append(((object)OutputTokens).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BE());
		P_0.Append(((object)Requests).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FJ());
		P_0.Append(((object)IsEmpty).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TokenUsage? left, TokenUsage? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TokenUsage? left, TokenUsage? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(InputTokens)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(OutputTokens)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Requests);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TokenUsage);
	}

	[CompilerGenerated]
	public bool Equals(TokenUsage? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<long>.Default.Equals(InputTokens, other.InputTokens) && EqualityComparer<long>.Default.Equals(OutputTokens, other.OutputTokens))
			{
				return EqualityComparer<int>.Default.Equals(Requests, other.Requests);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private TokenUsage(TokenUsage P_0)
	{
		InputTokens = P_0.InputTokens;
		OutputTokens = P_0.OutputTokens;
		Requests = P_0.Requests;
	}

	public TokenUsage()
	{
	}
}
