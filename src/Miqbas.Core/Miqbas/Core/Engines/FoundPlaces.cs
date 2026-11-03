using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public sealed class FoundPlaces : IEquatable<FoundPlaces>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(FoundPlaces);
		}
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<TextPlace> Places
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool NotAllSearched
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public FoundPlaces(System.Collections.Generic.IReadOnlyList<TextPlace> Places, bool NotAllSearched)
	{
		this.Places = Places;
		this.NotAllSearched = NotAllSearched;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.op());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oQ());
		P_0.Append((object)Places);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oq());
		P_0.Append(((object)NotAllSearched).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(FoundPlaces? left, FoundPlaces? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(FoundPlaces? left, FoundPlaces? right)
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
		return (EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<TextPlace>>.Default.GetHashCode(Places)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(NotAllSearched);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as FoundPlaces);
	}

	[CompilerGenerated]
	public bool Equals(FoundPlaces? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<System.Collections.Generic.IReadOnlyList<TextPlace>>.Default.Equals(Places, other.Places))
			{
				return EqualityComparer<bool>.Default.Equals(NotAllSearched, other.NotAllSearched);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private FoundPlaces(FoundPlaces P_0)
	{
		Places = P_0.Places;
		NotAllSearched = P_0.NotAllSearched;
	}

	[CompilerGenerated]
	public void Deconstruct(out System.Collections.Generic.IReadOnlyList<TextPlace> Places, out bool NotAllSearched)
	{
		Places = this.Places;
		NotAllSearched = this.NotAllSearched;
	}
}
