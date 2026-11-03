using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public sealed class ShapeOutcome : IEquatable<ShapeOutcome>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ShapeOutcome);
		}
	}

	[field: CompilerGenerated]
	public LearnedShape Shape
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public LearnedShapeStatus Status
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public ShapeRefusal? Refusal
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? WrittenSha256
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ShapeOutcome(LearnedShape Shape, LearnedShapeStatus Status, ShapeRefusal? Refusal, string? WrittenSha256)
	{
		this.Shape = Shape;
		this.Status = Status;
		this.Refusal = Refusal;
		this.WrittenSha256 = WrittenSha256;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OA());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oa());
		P_0.Append((object)Shape);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.FL());
		P_0.Append(((object)Status).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OB());
		P_0.Append(((object)Refusal).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ob());
		P_0.Append((object)WrittenSha256);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ShapeOutcome? left, ShapeOutcome? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ShapeOutcome? left, ShapeOutcome? right)
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
		return (((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<LearnedShape>.Default.GetHashCode(Shape)) * -1521134295 + EqualityComparer<LearnedShapeStatus>.Default.GetHashCode(Status)) * -1521134295 + EqualityComparer<ShapeRefusal?>.Default.GetHashCode(Refusal)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WrittenSha256);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ShapeOutcome);
	}

	[CompilerGenerated]
	public bool Equals(ShapeOutcome? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<LearnedShape>.Default.Equals(Shape, other.Shape) && EqualityComparer<LearnedShapeStatus>.Default.Equals(Status, other.Status) && EqualityComparer<ShapeRefusal?>.Default.Equals(Refusal, other.Refusal))
			{
				return EqualityComparer<string>.Default.Equals(WrittenSha256, other.WrittenSha256);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ShapeOutcome(ShapeOutcome P_0)
	{
		Shape = P_0.Shape;
		Status = P_0.Status;
		Refusal = P_0.Refusal;
		WrittenSha256 = P_0.WrittenSha256;
	}

	[CompilerGenerated]
	public void Deconstruct(out LearnedShape Shape, out LearnedShapeStatus Status, out ShapeRefusal? Refusal, out string? WrittenSha256)
	{
		Shape = this.Shape;
		Status = this.Status;
		Refusal = this.Refusal;
		WrittenSha256 = this.WrittenSha256;
	}
}
