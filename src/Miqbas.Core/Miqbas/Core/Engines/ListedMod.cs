using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public sealed class ListedMod : IEquatable<ListedMod>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ListedMod);
		}
	}

	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool FromTheWorkshop
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ListedMod(string Path, string Name, bool FromTheWorkshop)
	{
		this.Path = Path;
		this.Name = Name;
		this.FromTheWorkshop = FromTheWorkshop;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OC());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@is());
		P_0.Append((object)Path);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kg());
		P_0.Append((object)Name);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oc());
		P_0.Append(((object)FromTheWorkshop).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ListedMod? left, ListedMod? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ListedMod? left, ListedMod? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(FromTheWorkshop);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ListedMod);
	}

	[CompilerGenerated]
	public bool Equals(ListedMod? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<string>.Default.Equals(Name, other.Name))
			{
				return EqualityComparer<bool>.Default.Equals(FromTheWorkshop, other.FromTheWorkshop);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ListedMod(ListedMod P_0)
	{
		Path = P_0.Path;
		Name = P_0.Name;
		FromTheWorkshop = P_0.FromTheWorkshop;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Path, out string Name, out bool FromTheWorkshop)
	{
		Path = this.Path;
		Name = this.Name;
		FromTheWorkshop = this.FromTheWorkshop;
	}
}
