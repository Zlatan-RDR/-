using System;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Engines;

public static class EngineNotes
{
	public const string Prefix = "miqbas-note: ";

	[field: CompilerGenerated]
	public static Action<string>? Heard
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public static Action<string>? Doing
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static void Now(string what)
	{
		try
		{
			Doing?.Invoke(what);
		}
		catch (System.Exception)
		{
		}
	}

	public static void Say(string note)
	{
		try
		{
			Heard?.Invoke(note);
		}
		catch (System.Exception)
		{
		}
	}
}
