using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Hooking;

public sealed class LayerPayload : IEquatable<LayerPayload>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LayerPayload);
		}
	}

	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, string> Translations
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
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gE());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ge());
		P_0.Append((object)Translations);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LayerPayload? left, LayerPayload? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LayerPayload? left, LayerPayload? right)
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
		return EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, string>>.Default.GetHashCode(Translations);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LayerPayload);
	}

	[CompilerGenerated]
	public bool Equals(LayerPayload? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract)
			{
				return EqualityComparer<IReadOnlyDictionary<string, string>>.Default.Equals(Translations, other.Translations);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private LayerPayload(LayerPayload P_0)
	{
		Translations = P_0.Translations;
	}

	public LayerPayload()
	{
		Translations = (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		base._002Ector();
	}
}
