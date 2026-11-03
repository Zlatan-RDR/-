using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public static class SexualContent
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, string> _003C_003E9__2_0;

		internal string A(string P_0)
		{
			return P_0.Trim();
		}
	}

	public const string Sentence = "هذه الألعاب فيها محتوى جنسي ولا يقدم مقباس خدمة ترجمتها";

	public static ContentRefusal? Judge(ContentRating? rating)
	{
		if ((object)rating == null)
		{
			return null;
		}
		if (Enumerable.Contains<int>((System.Collections.Generic.IEnumerable<int>)rating.DescriptorIds, 3) || Enumerable.Contains<int>((System.Collections.Generic.IEnumerable<int>)rating.DescriptorIds, 4))
		{
			return new ContentRefusal(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kq(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KR() + string.Join<int>(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kr(), (System.Collections.Generic.IEnumerable<int>)rating.DescriptorIds) + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DJ());
		}
		AgencyRating esrb = rating.Esrb;
		if ((object)esrb != null)
		{
			HashSet<string> val = A(esrb);
			if (val.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KS()))
			{
				return new ContentRefusal(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ks(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KT());
			}
			if (val.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kt()) && val.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KU()))
			{
				return new ContentRefusal(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ks(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ku());
			}
		}
		AgencyRating pegi = rating.Pegi;
		if ((object)pegi != null && pegi.Rating.Trim() == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KV() && A(pegi).Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kv()))
		{
			return new ContentRefusal(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KW(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kw());
		}
		return null;
	}

	private static HashSet<string> A(AgencyRating P_0)
	{
		return new HashSet<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)P_0.Descriptors, (Func<string, string>)((string P_0) => P_0.Trim())), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
	}
}
