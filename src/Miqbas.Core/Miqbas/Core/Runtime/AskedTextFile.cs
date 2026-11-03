using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;

namespace Miqbas.Core.Runtime;

[RequiredMember]
public sealed class AskedTextFile : IEquatable<AskedTextFile>
{
	public const string FileName = "instant-ask.txt";

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(AskedTextFile);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> Strings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public static AskedTextFile? ReadFrom(string workDirectory)
	{
		System.Collections.Generic.IReadOnlyList<string> readOnlyList = h.A(Path.Combine(workDirectory, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kF()));
		if (readOnlyList != null)
		{
			return new AskedTextFile
			{
				Strings = readOnlyList
			};
		}
		return null;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kf());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kd());
		P_0.Append((object)Strings);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(AskedTextFile? left, AskedTextFile? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(AskedTextFile? left, AskedTextFile? right)
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
		return EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Strings);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as AskedTextFile);
	}

	[CompilerGenerated]
	public bool Equals(AskedTextFile? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract)
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Strings, other.Strings);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private AskedTextFile(AskedTextFile P_0)
	{
		Strings = P_0.Strings;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public AskedTextFile()
	{
	}
}
