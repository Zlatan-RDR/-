using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using A;
using Miqbas.Core.Translation;

namespace Miqbas.Core.Text;

public static class ALineAPlayerReads
{
	private static readonly HashSet<string> UnitysOwnFields;

	private static readonly HashSet<string> WordsThatBindASentence;

	public static NotALine Judge(string value, string fieldName)
	{
		ArgumentNullException.ThrowIfNull((object)value, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gv());
		if (fieldName != null && UnitysOwnFields.Contains(fieldName))
		{
			return NotALine.AFieldUnityOwns;
		}
		if (fieldName != null && (fieldName.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GW(), (StringComparison)5) || fieldName.EndsWith(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gw(), (StringComparison)5)))
		{
			return NotALine.AnEventTheGameSendsByName;
		}
		if (A(value))
		{
			return NotALine.ATypeTheEngineNames;
		}
		if (a(value))
		{
			return NotALine.ADocumentNotALine;
		}
		if (B(value))
		{
			return NotALine.ACallNotASentence;
		}
		if (b(value))
		{
			return NotALine.APathNotASentence;
		}
		if (C(value))
		{
			return NotALine.AnIdentifierNotASentence;
		}
		if (!D(value))
		{
			return NotALine.ANameNotASentence;
		}
		return NotALine.No;
	}

	public static bool Is(string value, string fieldName)
	{
		return Judge(value, fieldName) == NotALine.No;
	}

	private static bool A(string P_0)
	{
		if (P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GX(), (StringComparison)4))
		{
			if (!P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dx(), (StringComparison)4))
			{
				return P_0.Contains(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.dY(), (StringComparison)4);
			}
			return true;
		}
		return false;
	}

	private unsafe static bool a(string P_0)
	{
		System.ReadOnlySpan<char> readOnlySpan = MemoryExtensions.Trim(MemoryExtensions.AsSpan(P_0));
		if (readOnlySpan.Length < 2 || (*(ushort*)readOnlySpan[0] != 123 && *(ushort*)readOnlySpan[0] != 91))
		{
			return false;
		}
		if (*(ushort*)readOnlySpan[readOnlySpan.Length - 1] != 125)
		{
			if (*(ushort*)readOnlySpan[readOnlySpan.Length - 1] != 93)
			{
				return false;
			}
		}
		try
		{
			using JsonDocument jsonDocument = JsonDocument.Parse(P_0);
			JsonValueKind valueKind = jsonDocument.RootElement.ValueKind;
			return valueKind - 1 <= JsonValueKind.Object;
		}
		catch (JsonException)
		{
			return false;
		}
	}

	private static bool B(string P_0)
	{
		for (int i = 1; i < P_0.Length; i++)
		{
			if (P_0[i] == '(' && (char.IsLetterOrDigit(P_0[i - 1]) || P_0[i - 1] == '_') && P_0.IndexOf(')', i) > i)
			{
				return true;
			}
		}
		return false;
	}

	[GeneratedRegex("</?[A-Za-z][A-Za-z0-9\\-]*(=[^<>]*)?>")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "8.0.10.36612")]
	private static Regex A()
	{
		return (Regex)(object)e.Instance;
	}

	private static bool b(string P_0)
	{
		P_0 = A().Replace(P_0, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.X());
		int num = 0;
		for (int i = 1; i < P_0.Length - 1; i++)
		{
			if (P_0[i] == '/' && P_0[i - 1] != ' ' && P_0[i + 1] != ' ')
			{
				num++;
			}
		}
		if (num >= 2)
		{
			return true;
		}
		if (num == 1)
		{
			string text = P_0;
			char[] array = new char[6];
			RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			return text.IndexOfAny(array) < 0;
		}
		return false;
	}

	private static bool C(string P_0)
	{
		string masked = VariableMasker.Mask(P_0).Masked;
		char[] array = new char[4];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		string[] array2 = masked.Split(array, (StringSplitOptions)1);
		foreach (string obj in array2)
		{
			char[] array3 = new char[14];
			RuntimeHelpers.InitializeArray((System.Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			string text = obj.Trim(array3);
			if (text.Length >= 3 && c(text))
			{
				return true;
			}
		}
		return false;
	}

	private static bool c(string P_0)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < P_0.Length; i++)
		{
			char c = P_0[i];
			if (c == '_')
			{
				num++;
			}
			else if (char.IsDigit(c))
			{
				num2++;
			}
			if (i != 0)
			{
				char c2 = P_0[i - 1];
				if (char.IsLower(c2) && char.IsUpper(c))
				{
					return true;
				}
				if ((c == '@' || c == '#') && char.IsLetterOrDigit(c2) && i + 1 < P_0.Length && char.IsLetterOrDigit(P_0[i + 1]))
				{
					return true;
				}
			}
		}
		if (num >= 2 || (num == 1 && num2 > 0))
		{
			return true;
		}
		for (int j = 1; j < P_0.Length - 1; j++)
		{
			if (P_0[j] == '.' && char.IsLetter(P_0[j - 1]) && char.IsLower(P_0[j + 1]))
			{
				return true;
			}
		}
		return false;
	}

	private static bool D(string P_0)
	{
		string text = P_0.Trim();
		if (text.Length < 4)
		{
			return false;
		}
		if (text.Contains('\n') || text.Contains('\r'))
		{
			return true;
		}
		if (!text.Contains(' '))
		{
			return false;
		}
		char[] array = new char[8];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		if (text.IndexOfAny(array) >= 0)
		{
			return true;
		}
		char[] array2 = new char[7];
		RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		string[] array3 = text.Split(array2, (StringSplitOptions)1);
		foreach (string text2 in array3)
		{
			if (WordsThatBindASentence.Contains(text2))
			{
				return true;
			}
		}
		return false;
	}

	static ALineAPlayerReads()
	{
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gx());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GY());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gy());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.GZ());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Gz());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gA());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ga());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gB());
		obj.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gb());
		UnitysOwnFields = obj;
		HashSet<string> obj2 = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ey());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.EZ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@do());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gC());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gc());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gD());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gd());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gE());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ge());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gF());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gf());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gG());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gg());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gH());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gh());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gI());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gi());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gJ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gj());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bR());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bq());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gK());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gk());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gL());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bs());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gl());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gM());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gm());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gN());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gn());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gO());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bT());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.go());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gP());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gp());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gQ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gq());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gR());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gr());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.br());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bS());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gS());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gs());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bQ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.bp());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gT());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gt());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gU());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gu());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gV());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gv());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gW());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gw());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gX());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gx());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gY());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gy());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gZ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gz());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HA());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ha());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HB());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hb());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Bx());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HC());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hc());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.BZ());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.CC());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Cc());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HD());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hd());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HE());
		obj2.Add(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.He());
		WordsThatBindASentence = obj2;
	}
}
