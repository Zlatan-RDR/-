using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public readonly struct GameProcessCandidate : IEquatable<GameProcessCandidate>
{
	[field: CompilerGenerated]
	public int Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string? ExecutablePath
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public string ProcessName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	public long WorkingSet
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public GameProcessCandidate(int Id, string? ExecutablePath, string ProcessName, long WorkingSet)
	{
		this.Id = Id;
		this.ExecutablePath = ExecutablePath;
		this.ProcessName = ProcessName;
		this.WorkingSet = WorkingSet;
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eV());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aO());
		P_0.Append(((object)Id).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ev());
		P_0.Append((object)ExecutablePath);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eW());
		P_0.Append((object)ProcessName);
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ew());
		P_0.Append(((object)WorkingSet).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(GameProcessCandidate left, GameProcessCandidate right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(GameProcessCandidate left, GameProcessCandidate right)
	{
		return left.Equals(right);
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<int>.Default.GetHashCode(Id) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ExecutablePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProcessName)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(WorkingSet);
	}

	[CompilerGenerated]
	public override bool Equals(object obj)
	{
		if (obj is GameProcessCandidate)
		{
			return Equals((GameProcessCandidate)obj);
		}
		return false;
	}

	[CompilerGenerated]
	public bool Equals(GameProcessCandidate other)
	{
		if (EqualityComparer<int>.Default.Equals(Id, other.Id) && EqualityComparer<string>.Default.Equals(ExecutablePath, other.ExecutablePath) && EqualityComparer<string>.Default.Equals(ProcessName, other.ProcessName))
		{
			return EqualityComparer<long>.Default.Equals(WorkingSet, other.WorkingSet);
		}
		return false;
	}

	[CompilerGenerated]
	public void Deconstruct(out int Id, out string? ExecutablePath, out string ProcessName, out long WorkingSet)
	{
		Id = this.Id;
		ExecutablePath = this.ExecutablePath;
		ProcessName = this.ProcessName;
		WorkingSet = this.WorkingSet;
	}
}
