using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public sealed class LegacyExport : IEquatable<LegacyExport>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LegacyExport);
		}
	}

	[field: CompilerGenerated]
	public int Index
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int ClassIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int OuterIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
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
	public int NameIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int NameNumber
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long SerialOffset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long SerialSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int TablePosition
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LegacyExport(int Index, int ClassIndex, int OuterIndex, string Name, int NameIndex, int NameNumber, long SerialOffset, long SerialSize, int TablePosition)
	{
		this.Index = Index;
		this.ClassIndex = ClassIndex;
		this.OuterIndex = OuterIndex;
		this.Name = Name;
		this.NameIndex = NameIndex;
		this.NameNumber = NameNumber;
		this.SerialOffset = SerialOffset;
		this.SerialSize = SerialSize;
		this.TablePosition = TablePosition;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BE());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Be());
		P_0.Append(((object)Index).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BF());
		P_0.Append(((object)ClassIndex).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bf());
		P_0.Append(((object)OuterIndex).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BG());
		P_0.Append((object)Name);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bg());
		P_0.Append(((object)NameIndex).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BH());
		P_0.Append(((object)NameNumber).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bh());
		P_0.Append(((object)SerialOffset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BI());
		P_0.Append(((object)SerialSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bi());
		P_0.Append(((object)TablePosition).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LegacyExport? left, LegacyExport? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LegacyExport? left, LegacyExport? right)
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
		return ((((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Index)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ClassIndex)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(OuterIndex)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NameIndex)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NameNumber)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(SerialOffset)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(SerialSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(TablePosition);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LegacyExport);
	}

	[CompilerGenerated]
	public bool Equals(LegacyExport? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Index, other.Index) && EqualityComparer<int>.Default.Equals(ClassIndex, other.ClassIndex) && EqualityComparer<int>.Default.Equals(OuterIndex, other.OuterIndex) && EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<int>.Default.Equals(NameIndex, other.NameIndex) && EqualityComparer<int>.Default.Equals(NameNumber, other.NameNumber) && EqualityComparer<long>.Default.Equals(SerialOffset, other.SerialOffset) && EqualityComparer<long>.Default.Equals(SerialSize, other.SerialSize))
			{
				return EqualityComparer<int>.Default.Equals(TablePosition, other.TablePosition);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LegacyExport(LegacyExport P_0)
	{
		Index = P_0.Index;
		ClassIndex = P_0.ClassIndex;
		OuterIndex = P_0.OuterIndex;
		Name = P_0.Name;
		NameIndex = P_0.NameIndex;
		NameNumber = P_0.NameNumber;
		SerialOffset = P_0.SerialOffset;
		SerialSize = P_0.SerialSize;
		TablePosition = P_0.TablePosition;
	}

	[CompilerGenerated]
	public void Deconstruct(out int Index, out int ClassIndex, out int OuterIndex, out string Name, out int NameIndex, out int NameNumber, out long SerialOffset, out long SerialSize, out int TablePosition)
	{
		Index = this.Index;
		ClassIndex = this.ClassIndex;
		OuterIndex = this.OuterIndex;
		Name = this.Name;
		NameIndex = this.NameIndex;
		NameNumber = this.NameNumber;
		SerialOffset = this.SerialOffset;
		SerialSize = this.SerialSize;
		TablePosition = this.TablePosition;
	}
}
