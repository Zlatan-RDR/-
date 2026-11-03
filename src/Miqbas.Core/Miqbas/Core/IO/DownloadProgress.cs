using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.IO;

[RequiredMember]
public sealed class DownloadProgress : IEquatable<DownloadProgress>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(DownloadProgress);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long BytesDownloaded
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long TotalBytes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int Percent
	{
		get
		{
			if (TotalBytes != 0L)
			{
				return (int)(BytesDownloaded * 100 / TotalBytes);
			}
			return 0;
		}
	}

	[field: CompilerGenerated]
	public double? MegabytesPerSecond
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public TimeSpan? Remaining
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool IsVerifying
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string Summary
	{
		get
		{
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			if (IsVerifying)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ne();
			}
			double num = (double)BytesDownloaded / 1024.0 / 1024.0 / 1024.0;
			double num2 = (double)TotalBytes / 1024.0 / 1024.0 / 1024.0;
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NF());
			defaultInterpolatedStringHandler.AppendFormatted<double>(num, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nf());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NG());
			defaultInterpolatedStringHandler.AppendFormatted<double>(num2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nf());
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.JU());
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			double? megabytesPerSecond = MegabytesPerSecond;
			if (megabytesPerSecond.HasValue)
			{
				double valueOrDefault = megabytesPerSecond.GetValueOrDefault();
				string text2 = text;
				defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ds());
				defaultInterpolatedStringHandler.AppendFormatted<double>(valueOrDefault, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Jt());
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ng());
				text = text2 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			TimeSpan? remaining = Remaining;
			if (remaining.HasValue)
			{
				TimeSpan valueOrDefault2 = remaining.GetValueOrDefault();
				string text3 = text;
				string text4;
				if (!(((TimeSpan)(ref valueOrDefault2)).TotalMinutes >= 1.0))
				{
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NH());
					defaultInterpolatedStringHandler.AppendFormatted<int>((int)((TimeSpan)(ref valueOrDefault2)).TotalSeconds);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nh());
					text4 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				else
				{
					defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NH());
					defaultInterpolatedStringHandler.AppendFormatted<int>((int)((TimeSpan)(ref valueOrDefault2)).TotalMinutes);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CI());
					text4 = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				text = text3 + text4;
			}
			return text;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NI());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ni());
		P_0.Append(((object)BytesDownloaded).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NJ());
		P_0.Append(((object)TotalBytes).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nj());
		P_0.Append(((object)Percent).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NK());
		P_0.Append(((object)MegabytesPerSecond).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nk());
		P_0.Append(((object)Remaining).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NL());
		P_0.Append(((object)IsVerifying).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nl());
		P_0.Append((object)Summary);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(DownloadProgress? left, DownloadProgress? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(DownloadProgress? left, DownloadProgress? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(BytesDownloaded)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(TotalBytes)) * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(MegabytesPerSecond)) * -1521134295 + EqualityComparer<TimeSpan?>.Default.GetHashCode(Remaining)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsVerifying);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as DownloadProgress);
	}

	[CompilerGenerated]
	public bool Equals(DownloadProgress? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<long>.Default.Equals(BytesDownloaded, other.BytesDownloaded) && EqualityComparer<long>.Default.Equals(TotalBytes, other.TotalBytes) && EqualityComparer<double?>.Default.Equals(MegabytesPerSecond, other.MegabytesPerSecond) && EqualityComparer<TimeSpan?>.Default.Equals(Remaining, other.Remaining))
			{
				return EqualityComparer<bool>.Default.Equals(IsVerifying, other.IsVerifying);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private DownloadProgress(DownloadProgress P_0)
	{
		BytesDownloaded = P_0.BytesDownloaded;
		TotalBytes = P_0.TotalBytes;
		MegabytesPerSecond = P_0.MegabytesPerSecond;
		Remaining = P_0.Remaining;
		IsVerifying = P_0.IsVerifying;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public DownloadProgress()
	{
	}
}
