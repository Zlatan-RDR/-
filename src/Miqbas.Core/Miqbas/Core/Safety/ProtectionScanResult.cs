using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Safety;

[RequiredMember]
public sealed class ProtectionScanResult : IEquatable<ProtectionScanResult>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ProtectionSystem, bool> _003C_003E9__9_0;

		public static Func<ProtectionSystem, string> _003C_003E9__13_0;

		internal bool A(ProtectionSystem P_0)
		{
			return P_0.Kind == ProtectionKind.AntiCheat;
		}

		internal string a(ProtectionSystem P_0)
		{
			return P_0.DisplayName;
		}
	}

	public const string Title = "تنبيه: هذه اللعبة محمية";

	public const string Acknowledgement = "أقر\u0651 بأني قرأت التنبيه وأتحمل المسؤولية كاملة";

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(ProtectionScanResult);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public System.Collections.Generic.IReadOnlyList<ProtectionSystem> Found
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool AnyFound => ((System.Collections.Generic.IReadOnlyCollection<ProtectionSystem>)Found).Count > 0;

	public bool AnyAntiCheat => Enumerable.Any<ProtectionSystem>((System.Collections.Generic.IEnumerable<ProtectionSystem>)Found, (Func<ProtectionSystem, bool>)((ProtectionSystem P_0) => P_0.Kind == ProtectionKind.AntiCheat));

	public string WarningMessage
	{
		get
		{
			if (!AnyFound)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
			}
			string text = string.Join(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DT(), Enumerable.Select<ProtectionSystem, string>((System.Collections.Generic.IEnumerable<ProtectionSystem>)Found, (Func<ProtectionSystem, string>)((ProtectionSystem P_0) => P_0.DisplayName)));
			if (!AnyAntiCheat)
			{
				return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jE() + text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.je();
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jF() + text + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jf();
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jG());
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
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HX());
		P_0.Append((object)Found);
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jg());
		P_0.Append(((object)AnyFound).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jH());
		P_0.Append(((object)AnyAntiCheat).ToString());
		P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.jh());
		P_0.Append((object)WarningMessage);
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(ProtectionScanResult? left, ProtectionScanResult? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(ProtectionScanResult? left, ProtectionScanResult? right)
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
		return EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<System.Collections.Generic.IReadOnlyList<ProtectionSystem>>.Default.GetHashCode(Found);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as ProtectionScanResult);
	}

	[CompilerGenerated]
	public bool Equals(ProtectionScanResult? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract)
			{
				return EqualityComparer<System.Collections.Generic.IReadOnlyList<ProtectionSystem>>.Default.Equals(Found, other.Found);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private ProtectionScanResult(ProtectionScanResult P_0)
	{
		Found = P_0.Found;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public ProtectionScanResult()
	{
	}
}
