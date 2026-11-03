using System.Collections.Generic;

namespace Miqbas.Core.Engines;

public interface IKnowsWhatTheGameReadsItself
{
	IReadOnlySet<string> WhatTheGameReadsItself(System.Collections.Generic.IEnumerable<string> sourceLines);
}
