using System;
using System.Runtime.CompilerServices;

namespace Miqbas.Core.Engines;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public sealed class RoadNameAttribute : System.Attribute
{
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
	}

	public RoadNameAttribute(string name)
	{
		Name = name;
		base._002Ector();
	}
}
