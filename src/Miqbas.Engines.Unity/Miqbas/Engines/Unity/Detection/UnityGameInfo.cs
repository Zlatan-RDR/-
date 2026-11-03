using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Detection;

[RequiredMember]
public sealed class UnityGameInfo : IEquatable<UnityGameInfo>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, bool> _003C_003E9__35_0;

		internal bool A(string P_0)
		{
			return P_0.Contains(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ac(), (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(UnityGameInfo);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public string DataDirectory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public ScriptingBackend Backend
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? UnityVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ProductName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? CompanyName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? BuildGuid
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<string> ManagedAssemblies
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public GameBitness Bitness
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool UsesTextMeshPro => Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)ManagedAssemblies, (Func<string, bool>)((string P_0) => P_0.Contains(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ac(), (StringComparison)5)));

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CC());
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.a());
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
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cc());
		P_0.Append((object)DataDirectory);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bs());
		P_0.Append(((object)Backend).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CD());
		P_0.Append((object)UnityVersion);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cd());
		P_0.Append((object)ProductName);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CE());
		P_0.Append((object)CompanyName);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Ce());
		P_0.Append((object)BuildGuid);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bv());
		P_0.Append((object)ManagedAssemblies);
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.bT());
		P_0.Append(((object)Bitness).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.CF());
		P_0.Append(((object)UsesTextMeshPro).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(UnityGameInfo? left, UnityGameInfo? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(UnityGameInfo? left, UnityGameInfo? right)
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
		return (((((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DataDirectory)) * -1521134295 + EqualityComparer<ScriptingBackend>.Default.GetHashCode(Backend)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UnityVersion)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CompanyName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BuildGuid)) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.GetHashCode(ManagedAssemblies)) * -1521134295 + EqualityComparer<GameBitness>.Default.GetHashCode(Bitness);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as UnityGameInfo);
	}

	[CompilerGenerated]
	public bool Equals(UnityGameInfo? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(DataDirectory, other.DataDirectory) && EqualityComparer<ScriptingBackend>.Default.Equals(Backend, other.Backend) && EqualityComparer<string>.Default.Equals(UnityVersion, other.UnityVersion) && EqualityComparer<string>.Default.Equals(ProductName, other.ProductName) && EqualityComparer<string>.Default.Equals(CompanyName, other.CompanyName) && EqualityComparer<string>.Default.Equals(BuildGuid, other.BuildGuid) && EqualityComparer<System.Collections.Generic.IReadOnlyList<string>>.Default.Equals(ManagedAssemblies, other.ManagedAssemblies))
			{
				return EqualityComparer<GameBitness>.Default.Equals(Bitness, other.Bitness);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private UnityGameInfo(UnityGameInfo original)
	{
		DataDirectory = original.DataDirectory;
		Backend = original.Backend;
		UnityVersion = original.UnityVersion;
		ProductName = original.ProductName;
		CompanyName = original.CompanyName;
		BuildGuid = original.BuildGuid;
		ManagedAssemblies = original.ManagedAssemblies;
		Bitness = original.Bitness;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public UnityGameInfo()
	{
		ManagedAssemblies = System.Array.Empty<string>();
		base._002Ector();
	}
}
