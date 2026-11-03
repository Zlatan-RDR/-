namespace Miqbas.Core.Engines;

public interface IOffersItsCode
{
	bool TakeTheCodeOffer { get; set; }

	TheCodeOffer? CodeOffer { get; }
}
