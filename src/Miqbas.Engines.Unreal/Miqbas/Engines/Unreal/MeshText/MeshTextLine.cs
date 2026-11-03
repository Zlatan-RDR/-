using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.MeshText;

public sealed class MeshTextLine : IEquatable<MeshTextLine>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(MeshTextLine);
		}
	}

	[field: CompilerGenerated]
	public string Package
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Layout
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Text
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public MeshTextLine(string Package, string Layout, string Text)
	{
		this.Package = Package;
		this.Layout = Layout;
		this.Text = Text;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Df());
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DG());
		P_0.Append((object)Package);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dg());
		P_0.Append((object)Layout);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DH());
		P_0.Append((object)Text);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(MeshTextLine? left, MeshTextLine? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(MeshTextLine? left, MeshTextLine? right)
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
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Package)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Layout)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as MeshTextLine);
	}

	[CompilerGenerated]
	public bool Equals(MeshTextLine? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Package, other.Package) && EqualityComparer<string>.Default.Equals(Layout, other.Layout))
			{
				return EqualityComparer<string>.Default.Equals(Text, other.Text);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private MeshTextLine(MeshTextLine P_0)
	{
		Package = P_0.Package;
		Layout = P_0.Layout;
		Text = P_0.Text;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Package, out string Layout, out string Text)
	{
		Package = this.Package;
		Layout = this.Layout;
		Text = this.Text;
	}
}
