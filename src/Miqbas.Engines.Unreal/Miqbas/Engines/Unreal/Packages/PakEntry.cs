using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

[RequiredMember]
public sealed class PakEntry : IEquatable<PakEntry>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(PakEntry);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Path
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long Offset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long DataOffset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long StoredSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public long UncompressedSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int CompressionMethodIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string CompressionMethod
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public bool Encrypted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int CompressionBlockSize
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<PakBlock> Blocks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool IsCompressed => CompressionMethodIndex != 0;

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bZ());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bz());
		P_0.Append((object)Path);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ap());
		P_0.Append(((object)Offset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CA());
		P_0.Append(((object)DataOffset).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ca());
		P_0.Append(((object)StoredSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aS());
		P_0.Append(((object)UncompressedSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CB());
		P_0.Append(((object)CompressionMethodIndex).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cb());
		P_0.Append((object)CompressionMethod);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CC());
		P_0.Append(((object)Encrypted).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cc());
		P_0.Append(((object)CompressionBlockSize).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CD());
		P_0.Append((object)Blocks);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cd());
		P_0.Append(((object)IsCompressed).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(PakEntry? left, PakEntry? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(PakEntry? left, PakEntry? right)
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
		return (((((((((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Offset)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(DataOffset)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(StoredSize)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(UncompressedSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CompressionMethodIndex)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CompressionMethod)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Encrypted)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CompressionBlockSize)) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<PakBlock>>.Default.GetHashCode(Blocks);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as PakEntry);
	}

	[CompilerGenerated]
	public bool Equals(PakEntry? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<long>.Default.Equals(Offset, other.Offset) && EqualityComparer<long>.Default.Equals(DataOffset, other.DataOffset) && EqualityComparer<long>.Default.Equals(StoredSize, other.StoredSize) && EqualityComparer<long>.Default.Equals(UncompressedSize, other.UncompressedSize) && EqualityComparer<int>.Default.Equals(CompressionMethodIndex, other.CompressionMethodIndex) && EqualityComparer<string>.Default.Equals(CompressionMethod, other.CompressionMethod) && EqualityComparer<bool>.Default.Equals(Encrypted, other.Encrypted) && EqualityComparer<int>.Default.Equals(CompressionBlockSize, other.CompressionBlockSize))
			{
				return EqualityComparer<global::System.Collections.Generic.IReadOnlyList<PakBlock>>.Default.Equals(Blocks, other.Blocks);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private PakEntry(PakEntry P_0)
	{
		Path = P_0.Path;
		Offset = P_0.Offset;
		DataOffset = P_0.DataOffset;
		StoredSize = P_0.StoredSize;
		UncompressedSize = P_0.UncompressedSize;
		CompressionMethodIndex = P_0.CompressionMethodIndex;
		CompressionMethod = P_0.CompressionMethod;
		Encrypted = P_0.Encrypted;
		CompressionBlockSize = P_0.CompressionBlockSize;
		Blocks = P_0.Blocks;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PakEntry()
	{
	}
}
