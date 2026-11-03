using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

[RequiredMember]
public sealed class LocalizationTarget : IEquatable<LocalizationTarget>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, string> _003C_003E9__12_0;

		public static Func<string, bool> _003C_003E9__14_0;

		public static Func<string, bool> _003C_003E9__14_1;

		public static Func<string, bool> _003C_003E9__14_2;

		public static Func<string, string> _003C_003E9__14_3;

		public static Func<KeyValuePair<string, Dictionary<string, PakEntry>>, bool> _003C_003E9__15_0;

		public static Func<KeyValuePair<string, Dictionary<string, PakEntry>>, string> _003C_003E9__15_1;

		public static Func<KeyValuePair<string, Dictionary<string, PakEntry>>, LocalizationTarget> _003C_003E9__15_2;

		internal string A(string P_0)
		{
			return P_0;
		}

		internal bool a(string P_0)
		{
			return string.Equals(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.T(), (StringComparison)5);
		}

		internal bool B(string P_0)
		{
			return string.Equals(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.he(), (StringComparison)5);
		}

		internal bool b(string P_0)
		{
			return P_0.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.t(), (StringComparison)5);
		}

		internal string C(string P_0)
		{
			return P_0;
		}

		internal bool A(KeyValuePair<string, Dictionary<string, PakEntry>> P_0)
		{
			return P_0.Value.Count > 0;
		}

		internal string a(KeyValuePair<string, Dictionary<string, PakEntry>> P_0)
		{
			return P_0.Key;
		}

		internal LocalizationTarget B(KeyValuePair<string, Dictionary<string, PakEntry>> P_0)
		{
			return new LocalizationTarget
			{
				Name = P_0.Key,
				TablesByCulture = (IReadOnlyDictionary<string, PakEntry>)(object)P_0.Value
			};
		}
	}

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(LocalizationTarget);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public IReadOnlyDictionary<string, PakEntry> TablesByCulture
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public string SourceCulture => English ?? Enumerable.First<string>((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(TablesByCulture.Keys, (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase));

	public string? English => Enumerable.FirstOrDefault<string>(TablesByCulture.Keys, (Func<string, bool>)((string P_0) => string.Equals(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.T(), (StringComparison)5))) ?? Enumerable.FirstOrDefault<string>(TablesByCulture.Keys, (Func<string, bool>)((string P_0) => string.Equals(P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.he(), (StringComparison)5))) ?? Enumerable.FirstOrDefault<string>((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>(Enumerable.Where<string>(TablesByCulture.Keys, (Func<string, bool>)((string P_0) => P_0.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.t(), (StringComparison)5))), (Func<string, string>)((string P_0) => P_0), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase));

	public string PathFor(string culture)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(22, 3);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dU());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg());
		defaultInterpolatedStringHandler.AppendFormatted(culture);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg());
		defaultInterpolatedStringHandler.AppendFormatted(Name);
		defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.S());
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static global::System.Collections.Generic.IReadOnlyList<LocalizationTarget> FindIn(PakArchive package, string projectName)
	{
		ArgumentNullException.ThrowIfNull((object)package, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aM());
		ArgumentException.ThrowIfNullOrWhiteSpace(projectName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.du());
		string text = projectName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dV();
		Dictionary<string, Dictionary<string, PakEntry>> val = new Dictionary<string, Dictionary<string, PakEntry>>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		global::System.Collections.Generic.IEnumerator<PakEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<PakEntry>)package.Entries).GetEnumerator();
		try
		{
			Dictionary<string, PakEntry> val2 = default(Dictionary<string, PakEntry>);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PakEntry current = enumerator.Current;
				if (!current.Path.StartsWith(text, (StringComparison)5) || !current.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.S(), (StringComparison)5))
				{
					continue;
				}
				string path = current.Path;
				int length = text.Length;
				string[] array = path.Substring(length, path.Length - length).Split('/', (StringSplitOptions)0);
				if (array.Length == 3)
				{
					path = array[0];
					string text2 = array[1];
					string text3 = path;
					if (!val.TryGetValue(text3, ref val2))
					{
						val2 = (val[text3] = new Dictionary<string, PakEntry>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase));
					}
					val2[text2] = current;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return (global::System.Collections.Generic.IReadOnlyList<LocalizationTarget>)Enumerable.ToList<LocalizationTarget>(Enumerable.Select<KeyValuePair<string, Dictionary<string, PakEntry>>, LocalizationTarget>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, Dictionary<string, PakEntry>>>)Enumerable.OrderBy<KeyValuePair<string, Dictionary<string, PakEntry>>, string>(Enumerable.Where<KeyValuePair<string, Dictionary<string, PakEntry>>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, Dictionary<string, PakEntry>>>)val, (Func<KeyValuePair<string, Dictionary<string, PakEntry>>, bool>)((KeyValuePair<string, Dictionary<string, PakEntry>> P_0) => P_0.Value.Count > 0)), (Func<KeyValuePair<string, Dictionary<string, PakEntry>>, string>)((KeyValuePair<string, Dictionary<string, PakEntry>> P_0) => P_0.Key), (IComparer<string>)(object)StringComparer.OrdinalIgnoreCase), (Func<KeyValuePair<string, Dictionary<string, PakEntry>>, LocalizationTarget>)((KeyValuePair<string, Dictionary<string, PakEntry>> P_0) => new LocalizationTarget
		{
			Name = P_0.Key,
			TablesByCulture = (IReadOnlyDictionary<string, PakEntry>)(object)P_0.Value
		})));
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dv());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dW());
		P_0.Append((object)TablesByCulture);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dw());
		P_0.Append((object)SourceCulture);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dX());
		P_0.Append((object)English);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(LocalizationTarget? left, LocalizationTarget? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(LocalizationTarget? left, LocalizationTarget? right)
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
		return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<IReadOnlyDictionary<string, PakEntry>>.Default.GetHashCode(TablesByCulture);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as LocalizationTarget);
	}

	[CompilerGenerated]
	public bool Equals(LocalizationTarget? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other.Name))
			{
				return EqualityComparer<IReadOnlyDictionary<string, PakEntry>>.Default.Equals(TablesByCulture, other.TablesByCulture);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private LocalizationTarget(LocalizationTarget P_0)
	{
		Name = P_0.Name;
		TablesByCulture = P_0.TablesByCulture;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public LocalizationTarget()
	{
	}
}
