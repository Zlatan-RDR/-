using System;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public static class TheSignatureOfAComplaint
{
	public const string Mark = "[تعريب]";

	public const string CodeRoadMark = "+GameCode";

	public const string HeSawItTheMachineDidNot = "العربية ظاهرة — ومقباس قاس العكس";

	public static string For(TheCheckRecord record)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c4: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)record, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QR());
		StringBuilder val = new StringBuilder(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qr());
		val.Append(' ').Append(record.HeSawWhatTheMachineDenied ? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QS() : WhatThePlayerSawText.Of(record.WhatThePlayerSaw));
		A(val, record.Engine);
		A(val, record.EngineVersion);
		A(val, record.TookTheCodeRoad ? (record.Road + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qs()) : record.Road);
		A(val, record.Game);
		string steamAppId = record.SteamAppId;
		A(val, (steamAppId != null && steamAppId.Length > 0) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QT() + steamAppId) : null);
		A(val, A(record.Fingerprint));
		return ((object)val).ToString();
	}

	public static string For(WhatThePlayerSaw saw, string? game, string? engine)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return ((object)new StringBuilder(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qr()).Append(' ').Append(WhatThePlayerSawText.Of(saw)).Append((engine != null && engine.Length > 0) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aa() + engine) : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y())
			.Append((game != null && game.Length > 0) ? (EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aa() + game) : EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y())).ToString();
	}

	private static void A(StringBuilder P_0, string? value)
	{
		if (value != null && value.Length > 0)
		{
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aa()).Append(value);
		}
	}

	private static string? A(string? P_0)
	{
		if (P_0 == null || P_0.Length <= 8)
		{
			return P_0;
		}
		return P_0.Substring(0, 8);
	}
}
