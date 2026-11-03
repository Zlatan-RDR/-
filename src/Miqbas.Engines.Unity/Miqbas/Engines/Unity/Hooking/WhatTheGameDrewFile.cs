using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;

namespace Miqbas.Engines.Unity.Hooking;

public sealed class WhatTheGameDrewFile : IEquatable<WhatTheGameDrewFile>
{
	public const string FileName = "drawn-count.txt";

	[CompilerGenerated]
	private System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(WhatTheGameDrewFile);
		}
	}

	[field: CompilerGenerated]
	public int Drawn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public int Answered
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public bool AtLeast
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public int Gap
	{
		get
		{
			if (Drawn <= Answered)
			{
				return 0;
			}
			return Drawn - Answered;
		}
	}

	public WhatTheGameDrewFile(int Drawn, int Answered, bool AtLeast)
	{
		this.Drawn = Drawn;
		this.Answered = Answered;
		this.AtLeast = AtLeast;
		base._002Ector();
	}

	public static WhatTheGameDrewFile? ReadFrom(string gameRoot)
	{
		if (string.IsNullOrWhiteSpace(gameRoot))
		{
			return null;
		}
		string text = Path.Combine(UnityHook.WorkDirectoryIn(gameRoot), _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bq());
		string[] array;
		try
		{
			if (!File.Exists(text))
			{
				return null;
			}
			array = File.ReadAllLines(text);
		}
		catch (IOException)
		{
			return null;
		}
		catch (UnauthorizedAccessException)
		{
			return null;
		}
		int? num = null;
		int answered = 0;
		bool flag = false;
		bool flag2 = false;
		string[] array2 = array;
		int num4 = default(int);
		int num5 = default(int);
		foreach (string text2 in array2)
		{
			int num2 = text2.IndexOf('=');
			if (num2 <= 0)
			{
				continue;
			}
			string text3 = text2.Substring(0, num2).Trim();
			string text4 = text2;
			int num3 = num2 + 1;
			string text5 = text4.Substring(num3, text4.Length - num3).Trim();
			text4 = text3;
			if (!(text4 == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BR()))
			{
				if (!(text4 == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Br()))
				{
					if (!(text4 == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BS()))
					{
						if (text4 == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bs())
						{
							flag2 = text5 == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aY();
						}
					}
					else
					{
						flag = text5 == _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aY();
					}
				}
				else if (int.TryParse(text5, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref num4))
				{
					answered = num4;
				}
			}
			else if (int.TryParse(text5, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, ref num5))
			{
				num = num5;
			}
		}
		if (num.HasValue)
		{
			return new WhatTheGameDrewFile(num.Value, answered, flag || !flag2);
		}
		return null;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BT());
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
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bt());
		P_0.Append(((object)Drawn).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BU());
		P_0.Append(((object)Answered).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Bu());
		P_0.Append(((object)AtLeast).ToString());
		P_0.Append(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.BV());
		P_0.Append(((object)Gap).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(WhatTheGameDrewFile? left, WhatTheGameDrewFile? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(WhatTheGameDrewFile? left, WhatTheGameDrewFile? right)
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
		return ((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Drawn)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Answered)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AtLeast);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as WhatTheGameDrewFile);
	}

	[CompilerGenerated]
	public bool Equals(WhatTheGameDrewFile? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Drawn, other.Drawn) && EqualityComparer<int>.Default.Equals(Answered, other.Answered))
			{
				return EqualityComparer<bool>.Default.Equals(AtLeast, other.AtLeast);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	private WhatTheGameDrewFile(WhatTheGameDrewFile P_0)
	{
		Drawn = P_0.Drawn;
		Answered = P_0.Answered;
		AtLeast = P_0.AtLeast;
	}

	[CompilerGenerated]
	public void Deconstruct(out int Drawn, out int Answered, out bool AtLeast)
	{
		Drawn = this.Drawn;
		Answered = this.Answered;
		AtLeast = this.AtLeast;
	}
}
