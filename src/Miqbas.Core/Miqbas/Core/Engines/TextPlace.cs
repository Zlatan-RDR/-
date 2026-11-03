using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Engines;

public sealed class TextPlace : IEquatable<TextPlace>
{
	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(TextPlace);
		}
	}

	[field: CompilerGenerated]
	public string File
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public TextPlaceKind Kind
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string What
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string Field
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Lines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int AlreadyRead
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Inner
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public TextPlace(string File, TextPlaceKind Kind, string What, string Field, int Lines, int AlreadyRead)
	{
		this.File = File;
		this.Kind = Kind;
		this.What = What;
		this.Field = Field;
		this.Lines = Lines;
		this.AlreadyRead = AlreadyRead;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oo());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Op());
		P_0.Append(((object)Lines).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.oP());
		P_0.Append(((object)AlreadyRead).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ow());
		P_0.Append((object)Inner);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(TextPlace? left, TextPlace? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(TextPlace? left, TextPlace? right)
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
		return ((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(File)) * -1521134295 + EqualityComparer<TextPlaceKind>.Default.GetHashCode(Kind)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(What)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Field)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Lines)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AlreadyRead)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Inner);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as TextPlace);
	}

	[CompilerGenerated]
	public bool Equals(TextPlace? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(File, other.File) && EqualityComparer<TextPlaceKind>.Default.Equals(Kind, other.Kind) && EqualityComparer<string>.Default.Equals(What, other.What) && EqualityComparer<string>.Default.Equals(Field, other.Field) && EqualityComparer<int>.Default.Equals(Lines, other.Lines) && EqualityComparer<int>.Default.Equals(AlreadyRead, other.AlreadyRead))
			{
				return EqualityComparer<string>.Default.Equals(Inner, other.Inner);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private TextPlace(TextPlace P_0)
	{
		File = P_0.File;
		Kind = P_0.Kind;
		What = P_0.What;
		Field = P_0.Field;
		Lines = P_0.Lines;
		AlreadyRead = P_0.AlreadyRead;
		Inner = P_0.Inner;
	}

	[CompilerGenerated]
	public void Deconstruct(out string File, out TextPlaceKind Kind, out string What, out string Field, out int Lines, out int AlreadyRead)
	{
		File = this.File;
		Kind = this.Kind;
		What = this.What;
		Field = this.Field;
		Lines = this.Lines;
		AlreadyRead = this.AlreadyRead;
	}
}
