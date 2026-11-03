using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;
using Miqbas.Core.Engines;

namespace Miqbas.Core.Booting;

public static class LearnedPlacesAtBoot
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, ValueTuple<string, string>> _003C_003E9__3_0;

		public static Func<ValueTuple<string, string>, bool> _003C_003E9__3_1;

		internal ValueTuple<string, string> A(string P_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			string[] array = P_0.Replace('\\', '/').Split('/', (StringSplitOptions)0);
			return new ValueTuple<string, string>(P_0, array[array.Length - 1]);
		}

		internal bool A(ValueTuple<string, string> f)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return f.Item2.Length > 0;
		}
	}

	private static readonly Regex AFailedLoad = new Regex(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pw(), (RegexOptions)512, TimeSpan.FromSeconds(1.0));

	public static PlaceLoad Judge(System.Collections.Generic.IEnumerable<string> writtenArabic, System.Collections.Generic.IEnumerable<string> english, IReadOnlySet<string> held)
	{
		ArgumentNullException.ThrowIfNull((object)held, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pV());
		if (Enumerable.Any<string>(writtenArabic, (Func<string, bool>)held.Contains))
		{
			return PlaceLoad.LoadedArabic;
		}
		if (!Enumerable.Any<string>(english, (Func<string, bool>)held.Contains))
		{
			return PlaceLoad.NotLoaded;
		}
		return PlaceLoad.LoadedEnglish;
	}

	public static ShapeRefusal? WhyItFailed(PlaceLoad load, bool aLoadFault, WhatThePlayerSaw saw, PlaceOnScreen? seen = null)
	{
		if ((object)seen == null || seen.Arabic <= 0)
		{
			if ((object)seen == null || seen.English <= 0)
			{
				if (load != PlaceLoad.LoadedEnglish)
				{
					if (!aLoadFault)
					{
						return null;
					}
					return ShapeRefusal.LoadFault;
				}
				return ShapeRefusal.LoadedEnglish;
			}
			return ShapeRefusal.DrawnEnglish;
		}
		return null;
	}

	public static System.Collections.Generic.IReadOnlyList<LoadFault> LoadFaultsIn(string? log, System.Collections.Generic.IEnumerable<string> relativeFiles)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(log))
		{
			return System.Array.Empty<LoadFault>();
		}
		List<ValueTuple<string, string>> val = Enumerable.ToList<ValueTuple<string, string>>(Enumerable.Where<ValueTuple<string, string>>(Enumerable.Select<string, ValueTuple<string, string>>(relativeFiles, (Func<string, ValueTuple<string, string>>)delegate(string P_0)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			string[] array2 = P_0.Replace('\\', '/').Split('/', (StringSplitOptions)0);
			return new ValueTuple<string, string>(P_0, array2[array2.Length - 1]);
		}), (Func<ValueTuple<string, string>, bool>)((ValueTuple<string, string> f) => f.Item2.Length > 0)));
		List<LoadFault> val2 = new List<LoadFault>();
		string[] array = log.Split('\n', (StringSplitOptions)0);
		foreach (string text in array)
		{
			Match val3 = AFailedLoad.Match(text);
			if (val3 == null || !((Group)val3).Success)
			{
				continue;
			}
			string text2 = text.Replace('\\', '/');
			Enumerator<ValueTuple<string, string>> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ValueTuple<string, string> current = enumerator.Current;
					string item = current.Item1;
					string item2 = current.Item2;
					if (Regex.IsMatch(text2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pv() + Regex.Escape(item2) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.pW(), (RegexOptions)512, TimeSpan.FromSeconds(1.0)))
					{
						val2.Add(new LoadFault(item, ((Capture)val3).Value));
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		List<LoadFault> obj = new List<LoadFault>();
		obj.AddRange(Enumerable.Distinct<LoadFault>((System.Collections.Generic.IEnumerable<LoadFault>)val2));
		return new k<LoadFault>(obj);
	}
}
