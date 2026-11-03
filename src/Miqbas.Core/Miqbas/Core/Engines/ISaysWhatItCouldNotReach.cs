namespace Miqbas.Core.Engines;

public interface ISaysWhatItCouldNotReach
{
	string? WhatItCouldNotReach();

	bool AKeyWouldOpenMore()
	{
		return WhatItCouldNotReach() != null;
	}
}
