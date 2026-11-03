using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Baseline;

public sealed class GameChange : IEquatable<GameChange>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(GameChange);
		}
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
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ChangeKind Kind
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Blocks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Approved
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Detail
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public GameChange(string Name, string Path, ChangeKind Kind, bool Blocks, bool Approved, string Detail)
	{
		this.Name = Name;
		this.Path = Path;
		this.Kind = Kind;
		this.Blocks = Blocks;
		this.Approved = Approved;
		this.Detail = Detail;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ql());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.P());
		P_0.Append((object)Name);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kt());
		P_0.Append((object)Path);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aE());
		P_0.Append(((object)Kind).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qM());
		P_0.Append(((object)Blocks).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.qm());
		P_0.Append(((object)Approved).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OH());
		P_0.Append((object)Detail);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GameChange? left, GameChange? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GameChange? left, GameChange? right)
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
		return (((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<ChangeKind>.Default.GetHashCode(Kind)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Blocks)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Approved)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Detail);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as GameChange);
	}

	[CompilerGenerated]
	public bool Equals(GameChange? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<ChangeKind>.Default.Equals(Kind, other.Kind) && EqualityComparer<bool>.Default.Equals(Blocks, other.Blocks) && EqualityComparer<bool>.Default.Equals(Approved, other.Approved))
			{
				return EqualityComparer<string>.Default.Equals(Detail, other.Detail);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private GameChange(GameChange P_0)
	{
		Name = P_0.Name;
		Path = P_0.Path;
		Kind = P_0.Kind;
		Blocks = P_0.Blocks;
		Approved = P_0.Approved;
		Detail = P_0.Detail;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Name, out string Path, out ChangeKind Kind, out bool Blocks, out bool Approved, out string Detail)
	{
		Name = this.Name;
		Path = this.Path;
		Kind = this.Kind;
		Blocks = this.Blocks;
		Approved = this.Approved;
		Detail = this.Detail;
	}
}
