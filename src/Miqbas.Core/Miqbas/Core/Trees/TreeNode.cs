using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Trees;

public sealed class TreeNode : IEquatable<TreeNode>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TreeNode);
		}
	}

	[JsonPropertyName("label")]
	[field: CompilerGenerated]
	public string Label
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("sub")]
	[field: CompilerGenerated]
	public string? Sub
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("n")]
	[field: CompilerGenerated]
	public int Count
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("kind")]
	[field: CompilerGenerated]
	public string Kind
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("accept")]
	[field: CompilerGenerated]
	public string? Accept
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("games")]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Games
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("kids")]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<TreeNode> Kids
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aC());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ac());
		P_0.Append((object)Label);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aD());
		P_0.Append((object)Sub);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ad());
		P_0.Append(((object)Count).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aE());
		P_0.Append((object)Kind);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ae());
		P_0.Append((object)Accept);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aF());
		P_0.Append((object)Games);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.af());
		P_0.Append((object)Kids);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TreeNode? left, TreeNode? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TreeNode? left, TreeNode? right)
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
		return ((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Label)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sub)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Count)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Kind)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Accept)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Games)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<TreeNode>>.Default.GetHashCode(Kids);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TreeNode);
	}

	[CompilerGenerated]
	public bool Equals(TreeNode? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Label, other.Label) && EqualityComparer<string>.Default.Equals(Sub, other.Sub) && EqualityComparer<int>.Default.Equals(Count, other.Count) && EqualityComparer<string>.Default.Equals(Kind, other.Kind) && EqualityComparer<string>.Default.Equals(Accept, other.Accept) && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Games, other.Games))
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<TreeNode>>.Default.Equals(Kids, other.Kids);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private TreeNode(TreeNode P_0)
	{
		Label = P_0.Label;
		Sub = P_0.Sub;
		Count = P_0.Count;
		Kind = P_0.Kind;
		Accept = P_0.Accept;
		Games = P_0.Games;
		Kids = P_0.Kids;
	}

	public TreeNode()
	{
		Label = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		Kind = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aG();
		Games = System.Array.Empty<string>();
		Kids = System.Array.Empty<TreeNode>();
		base._002Ector();
	}
}
