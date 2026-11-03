using System;

namespace Miqbas.Core.Engines;

public interface ICanSayWhetherArabicWillDraw
{
	bool? TheFaceIsAdded => null;

	ValueTuple<bool?, string?> WillArabicDraw();
}
