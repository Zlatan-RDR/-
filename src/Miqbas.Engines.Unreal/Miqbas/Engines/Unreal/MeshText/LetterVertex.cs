using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.MeshText;

public readonly struct LetterVertex : IEquatable<LetterVertex>
{
	[field: CompilerGenerated]
	public float X
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public float Y
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public float Z
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ValueTuple<float, float, float> Tangent
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ValueTuple<float, float, float> Normal
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public float U
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public float V
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LetterVertex(float X, float Y, float Z, ValueTuple<float, float, float> Tangent, ValueTuple<float, float, float> Normal, float U, float V)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		this.X = X;
		this.Y = Y;
		this.Z = Z;
		this.Tangent = Tangent;
		this.Normal = Normal;
		this.U = U;
		this.V = V;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cp());
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
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cQ());
		P_0.Append(((object)X).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cq());
		P_0.Append(((object)Y).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cR());
		P_0.Append(((object)Z).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cr());
		P_0.Append(((object)Tangent).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cS());
		P_0.Append(((object)Normal).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cs());
		P_0.Append(((object)U).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cT());
		P_0.Append(((object)V).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LetterVertex left, LetterVertex right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LetterVertex left, LetterVertex right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		return (((((EqualityComparer<float>.Default.GetHashCode(X) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Y)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Z)) * -1521134295 + EqualityComparer<ValueTuple<float, float, float>>.Default.GetHashCode(Tangent)) * -1521134295 + EqualityComparer<ValueTuple<float, float, float>>.Default.GetHashCode(Normal)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(U)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(V);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is LetterVertex)
		{
			return Equals((LetterVertex)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(LetterVertex other)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (EqualityComparer<float>.Default.Equals(X, other.X) && EqualityComparer<float>.Default.Equals(Y, other.Y) && EqualityComparer<float>.Default.Equals(Z, other.Z) && EqualityComparer<ValueTuple<float, float, float>>.Default.Equals(Tangent, other.Tangent) && EqualityComparer<ValueTuple<float, float, float>>.Default.Equals(Normal, other.Normal) && EqualityComparer<float>.Default.Equals(U, other.U))
		{
			return EqualityComparer<float>.Default.Equals(V, other.V);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out float X, out float Y, out float Z, out ValueTuple<float, float, float> Tangent, out ValueTuple<float, float, float> Normal, out float U, out float V)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		X = this.X;
		Y = this.Y;
		Z = this.Z;
		Tangent = this.Tangent;
		Normal = this.Normal;
		U = this.U;
		V = this.V;
	}
}
