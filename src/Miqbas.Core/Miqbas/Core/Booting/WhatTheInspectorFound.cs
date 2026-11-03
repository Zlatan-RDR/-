using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Booting;

public sealed class WhatTheInspectorFound : IEquatable<WhatTheInspectorFound>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(WhatTheInspectorFound);
		}
	}

	[field: CompilerGenerated]
	public bool Ran
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Drawn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Extracted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool AtLeast
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Why
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int Missing
	{
		get
		{
			if (Drawn <= Extracted)
			{
				return 0;
			}
			return Drawn - Extracted;
		}
	}

	public WhatTheInspectorFound(bool Ran, int Drawn, int Extracted, bool AtLeast = false, string? Why = null)
	{
		this.Ran = Ran;
		this.Drawn = Drawn;
		this.Extracted = Extracted;
		this.AtLeast = AtLeast;
		this.Why = Why;
		base._002Ector();
	}

	public static WhatTheInspectorFound NotMeasured(string why)
	{
		return new WhatTheInspectorFound(Ran: false, 0, 0, AtLeast: false, why);
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qt());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QU());
		P_0.Append(((object)Ran).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QK());
		P_0.Append(((object)Drawn).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Qu());
		P_0.Append(((object)Extracted).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QL());
		P_0.Append(((object)AtLeast).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.QV());
		P_0.Append((object)Why);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HJ());
		P_0.Append(((object)Missing).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(WhatTheInspectorFound? left, WhatTheInspectorFound? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(WhatTheInspectorFound? left, WhatTheInspectorFound? right)
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
		return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Ran)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Drawn)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Extracted)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AtLeast)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Why);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as WhatTheInspectorFound);
	}

	[CompilerGenerated]
	public bool Equals(WhatTheInspectorFound? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<bool>.Default.Equals(Ran, other.Ran) && EqualityComparer<int>.Default.Equals(Drawn, other.Drawn) && EqualityComparer<int>.Default.Equals(Extracted, other.Extracted) && EqualityComparer<bool>.Default.Equals(AtLeast, other.AtLeast))
			{
				return EqualityComparer<string>.Default.Equals(Why, other.Why);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private WhatTheInspectorFound(WhatTheInspectorFound original)
	{
		Ran = original.Ran;
		Drawn = original.Drawn;
		Extracted = original.Extracted;
		AtLeast = original.AtLeast;
		Why = original.Why;
	}

	[CompilerGenerated]
	public void Deconstruct(out bool Ran, out int Drawn, out int Extracted, out bool AtLeast, out string? Why)
	{
		Ran = this.Ran;
		Drawn = this.Drawn;
		Extracted = this.Extracted;
		AtLeast = this.AtLeast;
		Why = this.Why;
	}
}
