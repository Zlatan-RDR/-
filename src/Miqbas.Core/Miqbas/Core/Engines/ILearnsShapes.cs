using System.Collections.Generic;

namespace Miqbas.Core.Engines;

public interface ILearnsShapes
{
	System.Collections.Generic.IReadOnlyList<LearnedShape> LearnedShapes { get; set; }

	System.Collections.Generic.IReadOnlyList<ShapeOutcome> ShapeOutcomes { get; }
}
