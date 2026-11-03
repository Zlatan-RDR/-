namespace Miqbas.Core.Engines;

public interface IBreaksLongLines
{
	LineLength LineLength { get; set; }

	int? OwnWidth { get; set; }
}
