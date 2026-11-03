using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

[RequiredMember]
public sealed class SourceText : IEquatable<SourceText>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(SourceText);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Key
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string File
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Value
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public TextType TextType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Speaker
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Context
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool InTheSourceLanguage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int? Room
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
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hy());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hZ());
		P_0.Append((object)Key);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.hz());
		P_0.Append((object)File);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fk());
		P_0.Append((object)Value);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IA());
		P_0.Append(((object)TextType).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.fQ());
		P_0.Append((object)Speaker);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ia());
		P_0.Append((object)Context);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IB());
		P_0.Append(((object)InTheSourceLanguage).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ib());
		P_0.Append(((object)Room).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(SourceText? left, SourceText? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(SourceText? left, SourceText? right)
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
		return (((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Key)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(File)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value)) * -1521134295 + EqualityComparer<TextType>.Default.GetHashCode(TextType)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Speaker)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Context)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(InTheSourceLanguage)) * -1521134295 + EqualityComparer<int?>.Default.GetHashCode(Room);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as SourceText);
	}

	[CompilerGenerated]
	public bool Equals(SourceText? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Key, other.Key) && EqualityComparer<string>.Default.Equals(File, other.File) && EqualityComparer<string>.Default.Equals(Value, other.Value) && EqualityComparer<TextType>.Default.Equals(TextType, other.TextType) && EqualityComparer<string>.Default.Equals(Speaker, other.Speaker) && EqualityComparer<string>.Default.Equals(Context, other.Context) && EqualityComparer<bool>.Default.Equals(InTheSourceLanguage, other.InTheSourceLanguage))
			{
				return EqualityComparer<int?>.Default.Equals(Room, other.Room);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private SourceText(SourceText P_0)
	{
		Key = P_0.Key;
		File = P_0.File;
		Value = P_0.Value;
		TextType = P_0.TextType;
		Speaker = P_0.Speaker;
		Context = P_0.Context;
		InTheSourceLanguage = P_0.InTheSourceLanguage;
		Room = P_0.Room;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public SourceText()
	{
	}
}
