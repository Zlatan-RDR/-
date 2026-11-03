using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public readonly struct LoadedImage : IEquatable<LoadedImage>
{
	[field: CompilerGenerated]
	public bool IsWindows64BitImage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? Why
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Sections
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public uint SizeOfImage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public LoadedImage(bool IsWindows64BitImage, string? Why, int Sections, uint SizeOfImage)
	{
		this.IsWindows64BitImage = IsWindows64BitImage;
		this.Why = Why;
		this.Sections = Sections;
		this.SizeOfImage = SizeOfImage;
	}

	internal static LoadedImage A(string P_0)
	{
		return new LoadedImage(IsWindows64BitImage: false, P_0, 0, 0u);
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.es());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eT());
		P_0.Append(((object)IsWindows64BitImage).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.et());
		P_0.Append((object)Why);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eU());
		P_0.Append(((object)Sections).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eu());
		P_0.Append(((object)SizeOfImage).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LoadedImage left, LoadedImage right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LoadedImage left, LoadedImage right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<bool>.Default.GetHashCode(IsWindows64BitImage) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Why)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Sections)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(SizeOfImage);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is LoadedImage)
		{
			return Equals((LoadedImage)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(LoadedImage other)
	{
		if (EqualityComparer<bool>.Default.Equals(IsWindows64BitImage, other.IsWindows64BitImage) && EqualityComparer<string>.Default.Equals(Why, other.Why) && EqualityComparer<int>.Default.Equals(Sections, other.Sections))
		{
			return EqualityComparer<uint>.Default.Equals(SizeOfImage, other.SizeOfImage);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out bool IsWindows64BitImage, out string? Why, out int Sections, out uint SizeOfImage)
	{
		IsWindows64BitImage = this.IsWindows64BitImage;
		Why = this.Why;
		Sections = this.Sections;
		SizeOfImage = this.SizeOfImage;
	}
}
