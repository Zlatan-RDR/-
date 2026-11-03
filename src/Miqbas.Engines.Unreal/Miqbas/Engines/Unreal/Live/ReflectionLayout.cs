using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class ReflectionLayout : IEquatable<ReflectionLayout>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ReflectionLayout);
		}
	}

	[field: CompilerGenerated]
	public int SuperStruct
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ChildProperties
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int PropertiesSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int FieldClass
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int FieldNext
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int FieldName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ValueOffset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ElementSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Contained
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool Fields
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<CalibrationScore> Scores
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public ReflectionLayout(int SuperStruct, int ChildProperties, int PropertiesSize, int FieldClass, int FieldNext, int FieldName, int ValueOffset, int ElementSize, int Contained, bool Fields)
	{
		this.SuperStruct = SuperStruct;
		this.ChildProperties = ChildProperties;
		this.PropertiesSize = PropertiesSize;
		this.FieldClass = FieldClass;
		this.FieldNext = FieldNext;
		this.FieldName = FieldName;
		this.ValueOffset = ValueOffset;
		this.ElementSize = ElementSize;
		this.Contained = Contained;
		this.Fields = Fields;
		Scores = global::System.Array.Empty<CalibrationScore>();
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fy());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fZ());
		P_0.Append(((object)SuperStruct).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fz());
		P_0.Append(((object)ChildProperties).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GA());
		P_0.Append(((object)PropertiesSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ga());
		P_0.Append(((object)FieldClass).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GB());
		P_0.Append(((object)FieldNext).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gb());
		P_0.Append(((object)FieldName).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GC());
		P_0.Append(((object)ValueOffset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gc());
		P_0.Append(((object)ElementSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GD());
		P_0.Append(((object)Contained).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gd());
		P_0.Append(((object)Fields).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GE());
		P_0.Append((object)Scores);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ReflectionLayout? left, ReflectionLayout? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ReflectionLayout? left, ReflectionLayout? right)
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
		return ((((((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SuperStruct)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ChildProperties)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PropertiesSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FieldClass)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FieldNext)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FieldName)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ValueOffset)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ElementSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Contained)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Fields)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<CalibrationScore>>.Default.GetHashCode(Scores);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ReflectionLayout);
	}

	[CompilerGenerated]
	public bool Equals(ReflectionLayout? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(SuperStruct, other.SuperStruct) && EqualityComparer<int>.Default.Equals(ChildProperties, other.ChildProperties) && EqualityComparer<int>.Default.Equals(PropertiesSize, other.PropertiesSize) && EqualityComparer<int>.Default.Equals(FieldClass, other.FieldClass) && EqualityComparer<int>.Default.Equals(FieldNext, other.FieldNext) && EqualityComparer<int>.Default.Equals(FieldName, other.FieldName) && EqualityComparer<int>.Default.Equals(ValueOffset, other.ValueOffset) && EqualityComparer<int>.Default.Equals(ElementSize, other.ElementSize) && EqualityComparer<int>.Default.Equals(Contained, other.Contained) && EqualityComparer<bool>.Default.Equals(Fields, other.Fields))
			{
				return EqualityComparer<global::System.Collections.Generic.IReadOnlyList<CalibrationScore>>.Default.Equals(Scores, other.Scores);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private ReflectionLayout(ReflectionLayout P_0)
	{
		SuperStruct = P_0.SuperStruct;
		ChildProperties = P_0.ChildProperties;
		PropertiesSize = P_0.PropertiesSize;
		FieldClass = P_0.FieldClass;
		FieldNext = P_0.FieldNext;
		FieldName = P_0.FieldName;
		ValueOffset = P_0.ValueOffset;
		ElementSize = P_0.ElementSize;
		Contained = P_0.Contained;
		Fields = P_0.Fields;
		Scores = P_0.Scores;
	}

	[CompilerGenerated]
	public void Deconstruct(out int SuperStruct, out int ChildProperties, out int PropertiesSize, out int FieldClass, out int FieldNext, out int FieldName, out int ValueOffset, out int ElementSize, out int Contained, out bool Fields)
	{
		SuperStruct = this.SuperStruct;
		ChildProperties = this.ChildProperties;
		PropertiesSize = this.PropertiesSize;
		FieldClass = this.FieldClass;
		FieldNext = this.FieldNext;
		FieldName = this.FieldName;
		ValueOffset = this.ValueOffset;
		ElementSize = this.ElementSize;
		Contained = this.Contained;
		Fields = this.Fields;
	}
}
