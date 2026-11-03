using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.IO;

public sealed class WriteFaults : IEquatable<WriteFaults>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(WriteFaults);
		}
	}

	[field: CompilerGenerated]
	public int FailWriteNumber
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public TimeSpan DelayEachWrite
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string OnlyUnder
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public static WriteFaults? Parse(string? value)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(value))
		{
			return null;
		}
		int num = 0;
		TimeSpan val = TimeSpan.Zero;
		string onlyUnder = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		string[] array = value.Split(';', (StringSplitOptions)3);
		int num2 = default(int);
		int num3 = default(int);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=', 2, (StringSplitOptions)0);
			string text = ((array2.Length > 1) ? array2[1].Trim() : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y());
			string text2 = array2[0].Trim().ToLowerInvariant();
			if (!(text2 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mZ()))
			{
				if (!(text2 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mz()))
				{
					if (text2 == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NA() && text.Length > 0)
					{
						onlyUnder = text;
					}
				}
				else if (int.TryParse(text, ref num2) && num2 > 0)
				{
					val = TimeSpan.FromMilliseconds((double)Math.Clamp(num2, 0, 10000));
				}
			}
			else if (int.TryParse(text, ref num3) && num3 > 0)
			{
				num = num3;
			}
		}
		if (num != 0 || !(val == TimeSpan.Zero))
		{
			return new WriteFaults
			{
				FailWriteNumber = num,
				DelayEachWrite = val,
				OnlyUnder = onlyUnder
			};
		}
		return null;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Na());
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
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		RuntimeHelpers.EnsureSufficientExecutionStack();
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NB());
		P_0.Append(((object)FailWriteNumber).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Nb());
		TimeSpan delayEachWrite = DelayEachWrite;
		P_0.Append(((object)(TimeSpan)(ref delayEachWrite)).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.NC());
		P_0.Append((object)OnlyUnder);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(WriteFaults? left, WriteFaults? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(WriteFaults? left, WriteFaults? right)
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
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FailWriteNumber)) * -1521134295 + EqualityComparer<TimeSpan>.Default.GetHashCode(DelayEachWrite)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OnlyUnder);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as WriteFaults);
	}

	[CompilerGenerated]
	public bool Equals(WriteFaults? other)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(FailWriteNumber, other.FailWriteNumber) && EqualityComparer<TimeSpan>.Default.Equals(DelayEachWrite, other.DelayEachWrite))
			{
				return EqualityComparer<string>.Default.Equals(OnlyUnder, other.OnlyUnder);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private WriteFaults(WriteFaults P_0)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		FailWriteNumber = P_0.FailWriteNumber;
		DelayEachWrite = P_0.DelayEachWrite;
		OnlyUnder = P_0.OnlyUnder;
	}

	public WriteFaults()
	{
		OnlyUnder = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		base._002Ector();
	}
}
