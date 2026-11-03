using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Booting;

public static class WhatThePlayerSawText
{
	[CompilerGenerated]
	private sealed class A
	{
		public WhatThePlayerSaw saw;

		internal bool A(ValueTuple<WhatThePlayerSaw, string> c)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return c.Item1 == saw;
		}
	}

	[field: CompilerGenerated]
	public static System.Collections.Generic.IReadOnlyList<ValueTuple<WhatThePlayerSaw, string>> Choices
	{
		[CompilerGenerated]
		get;
	} = new K<ValueTuple<WhatThePlayerSaw, string>>(new ValueTuple<WhatThePlayerSaw, string>[6]
	{
		new ValueTuple<WhatThePlayerSaw, string>(WhatThePlayerSaw.EmptyBoxes, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qA()),
		new ValueTuple<WhatThePlayerSaw, string>(WhatThePlayerSaw.StillEnglish, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qa()),
		new ValueTuple<WhatThePlayerSaw, string>(WhatThePlayerSaw.PartlyArabic, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qB()),
		new ValueTuple<WhatThePlayerSaw, string>(WhatThePlayerSaw.TheTextVanished, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qb()),
		new ValueTuple<WhatThePlayerSaw, string>(WhatThePlayerSaw.ArabicButWrongWayRound, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qC()),
		new ValueTuple<WhatThePlayerSaw, string>(WhatThePlayerSaw.SomethingElse, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qc())
	});


	public static string Of(WhatThePlayerSaw saw)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		return saw switch
		{
			WhatThePlayerSaw.NotAsked => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qv(), 
			WhatThePlayerSaw.TheGameDidNotOpen => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QW(), 
			_ => Enumerable.FirstOrDefault<ValueTuple<WhatThePlayerSaw, string>>((System.Collections.Generic.IEnumerable<ValueTuple<WhatThePlayerSaw, string>>)Choices, (Func<ValueTuple<WhatThePlayerSaw, string>, bool>)((ValueTuple<WhatThePlayerSaw, string> c) => c.Item1 == saw)).Item2 ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qv(), 
		};
	}

	public static bool MeansTheGameGoesBack(WhatThePlayerSaw saw)
	{
		bool flag = ((saw == WhatThePlayerSaw.NotAsked || saw == WhatThePlayerSaw.TheGameDidNotOpen) ? true : false);
		return !flag;
	}

	public static string WhatWeWillSayAboutIt(WhatThePlayerSaw saw)
	{
		return saw switch
		{
			WhatThePlayerSaw.EmptyBoxes => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qw(), 
			WhatThePlayerSaw.StillEnglish => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QX(), 
			WhatThePlayerSaw.PartlyArabic => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qx(), 
			WhatThePlayerSaw.TheTextVanished => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QY(), 
			WhatThePlayerSaw.ArabicButWrongWayRound => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qy(), 
			WhatThePlayerSaw.TheGameDidNotOpen => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QZ(), 
			_ => EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qz(), 
		};
	}
}
