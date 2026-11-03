using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

public sealed class ContentRating : IEquatable<ContentRating>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ContentRating);
		}
	}

	[field: CompilerGenerated]
	public string AppId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<int> DescriptorIds
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public AgencyRating? Esrb
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public AgencyRating? Pegi
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ContentRating(string AppId, System.Collections.Generic.IReadOnlyList<int> DescriptorIds, AgencyRating? Esrb, AgencyRating? Pegi)
	{
		this.AppId = AppId;
		this.DescriptorIds = DescriptorIds;
		this.Esrb = Esrb;
		this.Pegi = Pegi;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KL());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Kl());
		P_0.Append((object)AppId);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KM());
		P_0.Append((object)DescriptorIds);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Km());
		P_0.Append((object)Esrb);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.KN());
		P_0.Append((object)Pegi);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ContentRating? left, ContentRating? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ContentRating? left, ContentRating? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AppId)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.GetHashCode(DescriptorIds)) * -1521134295 + EqualityComparer<AgencyRating>.Default.GetHashCode(Esrb)) * -1521134295 + EqualityComparer<AgencyRating>.Default.GetHashCode(Pegi);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ContentRating);
	}

	[CompilerGenerated]
	public bool Equals(ContentRating? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(AppId, other.AppId) && EqualityComparer<System.Collections.Generic.IReadOnlyList<int>>.Default.Equals(DescriptorIds, other.DescriptorIds) && EqualityComparer<AgencyRating>.Default.Equals(Esrb, other.Esrb))
			{
				return EqualityComparer<AgencyRating>.Default.Equals(Pegi, other.Pegi);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ContentRating(ContentRating P_0)
	{
		AppId = P_0.AppId;
		DescriptorIds = P_0.DescriptorIds;
		Esrb = P_0.Esrb;
		Pegi = P_0.Pegi;
	}

	[CompilerGenerated]
	public void Deconstruct(out string AppId, out System.Collections.Generic.IReadOnlyList<int> DescriptorIds, out AgencyRating? Esrb, out AgencyRating? Pegi)
	{
		AppId = this.AppId;
		DescriptorIds = this.DescriptorIds;
		Esrb = this.Esrb;
		Pegi = this.Pegi;
	}
}
