using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Detection;

namespace Miqbas.Engines.Unreal.Live;

public static class LiveGame
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<Process, GameProcessCandidate> _003C_003E9__1_0;

		public static Func<GameProcessCandidate, long> _003C_003E9__2_0;

		internal GameProcessCandidate A(Process P_0)
		{
			return new GameProcessCandidate(P_0.Id, ProcessMemory.PathOf(P_0.Id), P_0.ProcessName, P_0.WorkingSet64);
		}

		internal long A(GameProcessCandidate P_0)
		{
			return P_0.WorkingSet;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public GameProcessCandidate? pick;

		public Process chosen;

		public Func<Process, bool> _003C_003E9__2;

		internal bool A(Process P_0)
		{
			return P_0.Id == pick.Value.Id;
		}

		internal bool a(Process P_0)
		{
			return P_0 != chosen;
		}
	}

	public static global::System.Collections.Generic.IReadOnlyList<Process> FindAll(UnrealGameLayout layout)
	{
		string text = Path.GetFullPath(layout.GameRoot).TrimEnd(Path.DirectorySeparatorChar);
		List<Process> val = new List<Process>();
		Process[] processes = Process.GetProcesses();
		foreach (Process val2 in processes)
		{
			string text2 = ProcessMemory.PathOf(val2.Id);
			if (text2 != null)
			{
				global::System.ReadOnlySpan<char> readOnlySpan = string.op_Implicit(text);
				char directorySeparatorChar = Path.DirectorySeparatorChar;
				if (text2.StartsWith(string.Concat(readOnlySpan, new global::System.ReadOnlySpan<char>(ref directorySeparatorChar)), (StringComparison)5))
				{
					val.Add(val2);
					continue;
				}
			}
			((Component)val2).Dispose();
		}
		return (global::System.Collections.Generic.IReadOnlyList<Process>)val;
	}

	public static Process? Find(UnrealGameLayout layout)
	{
		global::System.Collections.Generic.IReadOnlyList<Process> readOnlyList = FindAll(layout);
		if (((global::System.Collections.Generic.IReadOnlyCollection<Process>)readOnlyList).Count == 0)
		{
			return null;
		}
		List<GameProcessCandidate> candidates = Enumerable.ToList<GameProcessCandidate>(Enumerable.Select<Process, GameProcessCandidate>((global::System.Collections.Generic.IEnumerable<Process>)readOnlyList, (Func<Process, GameProcessCandidate>)((Process P_0) => new GameProcessCandidate(P_0.Id, ProcessMemory.PathOf(P_0.Id), P_0.ProcessName, P_0.WorkingSet64))));
		GameProcessCandidate? pick = ChooseTheEngine((global::System.Collections.Generic.IReadOnlyList<GameProcessCandidate>)candidates, layout.Executable);
		Process chosen = Enumerable.First<Process>((global::System.Collections.Generic.IEnumerable<Process>)readOnlyList, (Func<Process, bool>)((Process P_0) => P_0.Id == pick.Value.Id));
		global::System.Collections.Generic.IEnumerator<Process> enumerator = Enumerable.Where<Process>((global::System.Collections.Generic.IEnumerable<Process>)readOnlyList, (Func<Process, bool>)((Process P_0) => P_0 != chosen)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				((Component)enumerator.Current).Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return chosen;
	}

	public static GameProcessCandidate? ChooseTheEngine(global::System.Collections.Generic.IReadOnlyList<GameProcessCandidate> candidates, string? knownExecutable)
	{
		if (((global::System.Collections.Generic.IReadOnlyCollection<GameProcessCandidate>)candidates).Count == 0)
		{
			return null;
		}
		global::System.Collections.Generic.IEnumerator<GameProcessCandidate> enumerator = ((global::System.Collections.Generic.IEnumerable<GameProcessCandidate>)candidates).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GameProcessCandidate current = enumerator.Current;
				if (A(current.ExecutablePath, knownExecutable))
				{
					return current;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		enumerator = ((global::System.Collections.Generic.IEnumerable<GameProcessCandidate>)candidates).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GameProcessCandidate current2 = enumerator.Current;
				if (current2.ProcessName.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eP(), (StringComparison)5))
				{
					return current2;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return Enumerable.First<GameProcessCandidate>((global::System.Collections.Generic.IEnumerable<GameProcessCandidate>)Enumerable.OrderByDescending<GameProcessCandidate, long>((global::System.Collections.Generic.IEnumerable<GameProcessCandidate>)candidates, (Func<GameProcessCandidate, long>)((GameProcessCandidate P_0) => P_0.WorkingSet)));
	}

	private static bool A(string? P_0, string? P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			return string.Equals(Path.GetFullPath(P_0), Path.GetFullPath(P_1), (StringComparison)5);
		}
		return false;
	}

	public static LoadedImage ReadImage(ProcessMemory memory, ulong baseAddress)
	{
		byte[] array = memory.ReadBytes(baseAddress, 64);
		if (array[0] != 77 || array[1] != 90)
		{
			return LoadedImage.A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ep());
		}
		uint num = (uint)BitConverter.ToInt32(array, 60);
		if ((num > 4096 || num == 0) ? true : false)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(31, 1);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eQ());
			defaultInterpolatedStringHandler.AppendFormatted<uint>(num, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eq());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
			return LoadedImage.A(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		byte[] array2 = memory.ReadBytes(baseAddress + num, 120);
		if (array2[0] != 80 || array2[1] != 69 || array2[2] != 0 || array2[3] != 0)
		{
			return LoadedImage.A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eR());
		}
		ushort num2 = BitConverter.ToUInt16(array2, 4);
		ushort sections = BitConverter.ToUInt16(array2, 6);
		ushort num3 = BitConverter.ToUInt16(array2, 24);
		uint sizeOfImage = BitConverter.ToUInt32(array2, 80);
		if (num2 != 34404 || num3 != 523)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(38, 2);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.er());
			defaultInterpolatedStringHandler.AppendFormatted<ushort>(num2, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dD());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eS());
			defaultInterpolatedStringHandler.AppendFormatted<ushort>(num3, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eq());
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
			return LoadedImage.A(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return new LoadedImage(IsWindows64BitImage: true, null, sections, sizeOfImage);
	}
}
