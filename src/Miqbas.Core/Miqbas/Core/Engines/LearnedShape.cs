using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

[RequiredMember]
public sealed class LearnedShape : IEquatable<LearnedShape>
{
	private readonly TextPlaceKind _kind;

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LearnedShape);
		}
	}

	[RequiredMember]
	[JsonPropertyName("file")]
	[field: CompilerGenerated]
	public string File
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("kind")]
	[JsonConverter(typeof(JsonStringEnumConverter<TextPlaceKind>))]
	public TextPlaceKind Kind
	{
		get
		{
			return _kind;
		}
		init
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			if (!((uint)value <= 2u))
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(46, 1);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oj());
				defaultInterpolatedStringHandler.AppendFormatted<TextPlaceKind>(value);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OK());
				throw new ArgumentException(defaultInterpolatedStringHandler.ToStringAndClear(), EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap());
			}
			_kind = value;
		}
	}

	[RequiredMember]
	[JsonPropertyName("what")]
	[field: CompilerGenerated]
	public string What
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("field")]
	[field: CompilerGenerated]
	public string Field
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("shape")]
	[field: CompilerGenerated]
	public ShapeDescriptor Shape
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("originalSize")]
	[field: CompilerGenerated]
	public long OriginalSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("originalSha256")]
	[field: CompilerGenerated]
	public string OriginalSha256
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("lines")]
	[field: CompilerGenerated]
	public int Lines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[JsonPropertyName("rulesVersion")]
	[field: CompilerGenerated]
	public int RulesVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonIgnore]
	public bool Known
	{
		get
		{
			if (Shape.Version == 1 && ShapeFamily.All.Contains(Shape.Family))
			{
				if (!(Shape.Family != EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ok()))
				{
					return JsonKeyOf(Shape) != null;
				}
				return true;
			}
			return false;
		}
	}

	public static string? JsonKeyOf(ShapeDescriptor shape)
	{
		ShapeDescriptor inner = shape.Inner;
		if ((object)inner != null && inner.Family == EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OL())
		{
			string keyPath = inner.KeyPath;
			if (keyPath != null && keyPath.Length > 0 && !keyPath.StartsWith('$'))
			{
				return keyPath;
			}
		}
		return null;
	}

	public string? PathIn(string gameRoot)
	{
		ArgumentException.ThrowIfNullOrEmpty(gameRoot, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Lz());
		string text = File.Split(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ol(), (StringSplitOptions)0)[0];
		if (text.Length == 0 || Path.IsPathRooted(text))
		{
			return null;
		}
		System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(Path.GetFullPath(gameRoot).TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		}));
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		string text2 = string.Concat(readOnlySpan, new System.ReadOnlySpan<char>(ref directorySeparatorChar));
		string fullPath = Path.GetFullPath(Path.Combine(text2, text));
		if (!fullPath.StartsWith(text2, (StringComparison)5))
		{
			return null;
		}
		return fullPath;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OM());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Om());
		P_0.Append((object)File);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aE());
		P_0.Append(((object)Kind).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ON());
		P_0.Append((object)What);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.On());
		P_0.Append((object)Field);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OO());
		P_0.Append((object)Shape);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Oo());
		P_0.Append(((object)OriginalSize).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OP());
		P_0.Append((object)OriginalSha256);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Op());
		P_0.Append(((object)Lines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.OQ());
		P_0.Append(((object)RulesVersion).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bm());
		P_0.Append(((object)Known).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LearnedShape? left, LearnedShape? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LearnedShape? left, LearnedShape? right)
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
		return ((((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(File)) * -1521134295 + EqualityComparer<TextPlaceKind>.Default.GetHashCode(_kind)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(What)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Field)) * -1521134295 + EqualityComparer<ShapeDescriptor>.Default.GetHashCode(Shape)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(OriginalSize)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OriginalSha256)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Lines)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RulesVersion);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LearnedShape);
	}

	[CompilerGenerated]
	public bool Equals(LearnedShape? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(File, other.File) && EqualityComparer<TextPlaceKind>.Default.Equals(_kind, other._kind) && EqualityComparer<string>.Default.Equals(What, other.What) && EqualityComparer<string>.Default.Equals(Field, other.Field) && EqualityComparer<ShapeDescriptor>.Default.Equals(Shape, other.Shape) && EqualityComparer<long>.Default.Equals(OriginalSize, other.OriginalSize) && EqualityComparer<string>.Default.Equals(OriginalSha256, other.OriginalSha256) && EqualityComparer<int>.Default.Equals(Lines, other.Lines))
			{
				return EqualityComparer<int>.Default.Equals(RulesVersion, other.RulesVersion);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private LearnedShape(LearnedShape P_0)
	{
		File = P_0.File;
		_kind = P_0._kind;
		What = P_0.What;
		Field = P_0.Field;
		Shape = P_0.Shape;
		OriginalSize = P_0.OriginalSize;
		OriginalSha256 = P_0.OriginalSha256;
		Lines = P_0.Lines;
		RulesVersion = P_0.RulesVersion;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public LearnedShape()
	{
	}
}
