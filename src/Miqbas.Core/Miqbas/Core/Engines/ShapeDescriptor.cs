using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

[RequiredMember]
public sealed class ShapeDescriptor : IEquatable<ShapeDescriptor>
{
	public const int CurrentVersion = 1;

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ShapeDescriptor);
		}
	}

	[JsonPropertyName("v")]
	[field: CompilerGenerated]
	public int Version
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("family")]
	[field: CompilerGenerated]
	public string Family
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("class")]
	[field: CompilerGenerated]
	public string? Class
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("fieldPath")]
	[field: CompilerGenerated]
	public string? FieldPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("encoding")]
	[field: CompilerGenerated]
	public string? Encoding
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("newline")]
	[field: CompilerGenerated]
	public string? Newline
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("separator")]
	[field: CompilerGenerated]
	public string? Separator
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("hasHeader")]
	[field: CompilerGenerated]
	public bool? HasHeader
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("column")]
	[field: CompilerGenerated]
	public int? Column
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("keyPath")]
	[field: CompilerGenerated]
	public string? KeyPath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("quoted")]
	[field: CompilerGenerated]
	public bool? Quoted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("inner")]
	[field: CompilerGenerated]
	public ShapeDescriptor? Inner
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oq());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OR());
		P_0.Append(((object)Version).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Or());
		P_0.Append((object)Family);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OS());
		P_0.Append((object)Class);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Os());
		P_0.Append((object)FieldPath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OT());
		P_0.Append((object)Encoding);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ot());
		P_0.Append((object)Newline);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OU());
		P_0.Append((object)Separator);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ou());
		P_0.Append(((object)HasHeader).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OV());
		P_0.Append(((object)Column).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ov());
		P_0.Append((object)KeyPath);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OW());
		P_0.Append(((object)Quoted).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ow());
		P_0.Append((object)Inner);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ShapeDescriptor? left, ShapeDescriptor? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ShapeDescriptor? left, ShapeDescriptor? right)
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
		return (((((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Version)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Family)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Class)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FieldPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Encoding)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Newline)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Separator)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(HasHeader)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Column)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(KeyPath)) * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(Quoted)) * -1521134295 + EqualityComparer<ShapeDescriptor>.Default.GetHashCode(Inner);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ShapeDescriptor);
	}

	[CompilerGenerated]
	public bool Equals(ShapeDescriptor? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Version, other.Version) && EqualityComparer<string>.Default.Equals(Family, other.Family) && EqualityComparer<string>.Default.Equals(Class, other.Class) && EqualityComparer<string>.Default.Equals(FieldPath, other.FieldPath) && EqualityComparer<string>.Default.Equals(Encoding, other.Encoding) && EqualityComparer<string>.Default.Equals(Newline, other.Newline) && EqualityComparer<string>.Default.Equals(Separator, other.Separator) && EqualityComparer<bool?>.Default.Equals(HasHeader, other.HasHeader) && EqualityComparer<int?>.Default.Equals(Column, other.Column) && EqualityComparer<string>.Default.Equals(KeyPath, other.KeyPath) && EqualityComparer<bool?>.Default.Equals(Quoted, other.Quoted))
			{
				return EqualityComparer<ShapeDescriptor>.Default.Equals(Inner, other.Inner);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ShapeDescriptor(ShapeDescriptor original)
	{
		Version = original.Version;
		Family = original.Family;
		Class = original.Class;
		FieldPath = original.FieldPath;
		Encoding = original.Encoding;
		Newline = original.Newline;
		Separator = original.Separator;
		HasHeader = original.HasHeader;
		Column = original.Column;
		KeyPath = original.KeyPath;
		Quoted = original.Quoted;
		Inner = original.Inner;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShapeDescriptor()
	{
		Version = 1;
		base._002Ector();
	}
}
