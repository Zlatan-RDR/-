using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public sealed class LegacyProperty : IEquatable<LegacyProperty>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LegacyProperty);
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
	public string Type
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Size
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ArrayIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Extra
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int TagStart
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ValueStart
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public byte BoolValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int SizeField => TagStart + 16;

	public LegacyProperty(string Name, string Type, int Size, int ArrayIndex, string? Extra, int TagStart, int ValueStart, byte BoolValue)
	{
		this.Name = Name;
		this.Type = Type;
		this.Size = Size;
		this.ArrayIndex = ArrayIndex;
		this.Extra = Extra;
		this.TagStart = TagStart;
		this.ValueStart = ValueStart;
		this.BoolValue = BoolValue;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BJ());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bj());
		P_0.Append((object)Name);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aP());
		P_0.Append((object)Type);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BK());
		P_0.Append(((object)Size).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bk());
		P_0.Append(((object)ArrayIndex).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BL());
		P_0.Append((object)Extra);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bl());
		P_0.Append(((object)TagStart).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BM());
		P_0.Append(((object)ValueStart).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bm());
		P_0.Append(((object)BoolValue).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BN());
		P_0.Append(((object)SizeField).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LegacyProperty? left, LegacyProperty? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LegacyProperty? left, LegacyProperty? right)
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
		return (((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Size)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ArrayIndex)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Extra)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(TagStart)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ValueStart)) * -1521134295 + EqualityComparer<byte>.Default.GetHashCode(BoolValue);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LegacyProperty);
	}

	[CompilerGenerated]
	public bool Equals(LegacyProperty? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<string>.Default.Equals(Type, other.Type) && EqualityComparer<int>.Default.Equals(Size, other.Size) && EqualityComparer<int>.Default.Equals(ArrayIndex, other.ArrayIndex) && EqualityComparer<string>.Default.Equals(Extra, other.Extra) && EqualityComparer<int>.Default.Equals(TagStart, other.TagStart) && EqualityComparer<int>.Default.Equals(ValueStart, other.ValueStart))
			{
				return EqualityComparer<byte>.Default.Equals(BoolValue, other.BoolValue);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LegacyProperty(LegacyProperty P_0)
	{
		Name = P_0.Name;
		Type = P_0.Type;
		Size = P_0.Size;
		ArrayIndex = P_0.ArrayIndex;
		Extra = P_0.Extra;
		TagStart = P_0.TagStart;
		ValueStart = P_0.ValueStart;
		BoolValue = P_0.BoolValue;
	}

	[CompilerGenerated]
	public void Deconstruct(out string Name, out string Type, out int Size, out int ArrayIndex, out string? Extra, out int TagStart, out int ValueStart, out byte BoolValue)
	{
		Name = this.Name;
		Type = this.Type;
		Size = this.Size;
		ArrayIndex = this.ArrayIndex;
		Extra = this.Extra;
		TagStart = this.TagStart;
		ValueStart = this.ValueStart;
		BoolValue = this.BoolValue;
	}
}
