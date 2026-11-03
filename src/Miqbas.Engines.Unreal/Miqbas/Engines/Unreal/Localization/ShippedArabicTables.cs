using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Localization;

[RequiredMember]
public sealed class ShippedArabicTables : IEquatable<ShippedArabicTables>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ShippedArabicTables);
		}
	}

	[field: CompilerGenerated]
	public static ShippedArabicTables None
	{
		[CompilerGenerated]
		get;
	} = new ShippedArabicTables
	{
		Targets = global::System.Array.Empty<string>(),
		Pairs = (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>()
	};


	[RequiredMember]
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<string> Targets
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, string> Pairs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool Found => ((global::System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, string>>)Pairs).Count > 0;

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ej());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EK());
		P_0.Append((object)Targets);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ek());
		P_0.Append((object)Pairs);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cj());
		P_0.Append(((object)Found).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ShippedArabicTables? left, ShippedArabicTables? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ShippedArabicTables? left, ShippedArabicTables? right)
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
		return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(Targets)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, string>>.Default.GetHashCode(Pairs);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ShippedArabicTables);
	}

	[CompilerGenerated]
	public bool Equals(ShippedArabicTables? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<global::System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(Targets, other.Targets))
			{
				return EqualityComparer<IReadOnlyDictionary<string, string>>.Default.Equals(Pairs, other.Pairs);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ShippedArabicTables(ShippedArabicTables P_0)
	{
		Targets = P_0.Targets;
		Pairs = P_0.Pairs;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ShippedArabicTables()
	{
	}
}
