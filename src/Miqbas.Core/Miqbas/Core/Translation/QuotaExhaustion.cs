using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Translation;

public static class QuotaExhaustion
{
	[CompilerGenerated]
	private sealed class A
	{
		public string said;

		internal bool A(string P_0)
		{
			return said.Contains(P_0, (StringComparison)4);
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string said;

		internal bool A(string P_0)
		{
			return said.Contains(P_0, (StringComparison)4);
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string said;

		internal bool A(string P_0)
		{
			return said.Contains(P_0, (StringComparison)4);
		}
	}

	private static readonly TimeSpan LongerThanAnyMinuteCeiling = TimeSpan.FromMinutes(2.0);

	private static readonly string[] NamesADay = new string[6]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cu(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CV(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cv(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CW(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cw(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CX()
	};

	private static readonly string[] NamesASpentBalance = new string[6]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cx(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CY(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cy(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CZ(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cz(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cA()
	};

	private static readonly string[] NamesOurOwnPace = new string[7]
	{
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ca(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cB(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cb(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cC(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cc(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cD(),
		EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.cd()
	};

	public static bool LooksSpent(string? providerSaid)
	{
		if (string.IsNullOrWhiteSpace(providerSaid))
		{
			return false;
		}
		string said = providerSaid.ToLowerInvariant();
		return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)NamesASpentBalance, (Func<string, bool>)((string P_0) => said.Contains(P_0, (StringComparison)4)));
	}

	public static bool IsOurOwnPace(TimeSpan retryAfter, string? providerSaid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (retryAfter <= TimeSpan.Zero || LooksSpent(providerSaid))
		{
			return false;
		}
		if (LooksDaily(retryAfter, providerSaid))
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(providerSaid))
		{
			return true;
		}
		string said = providerSaid.ToLowerInvariant();
		return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)NamesOurOwnPace, (Func<string, bool>)((string P_0) => said.Contains(P_0, (StringComparison)4)));
	}

	public static bool LooksDaily(TimeSpan retryAfter, string? providerSaid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (retryAfter >= LongerThanAnyMinuteCeiling)
		{
			return true;
		}
		if (string.IsNullOrWhiteSpace(providerSaid))
		{
			return false;
		}
		string said = providerSaid.ToLowerInvariant();
		return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)NamesADay, (Func<string, bool>)((string P_0) => said.Contains(P_0, (StringComparison)4)));
	}
}
