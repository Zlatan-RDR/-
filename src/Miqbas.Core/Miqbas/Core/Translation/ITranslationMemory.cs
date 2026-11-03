namespace Miqbas.Core.Translation;

public interface ITranslationMemory
{
	string? Lookup(string sourceText);

	void Remember(string sourceText, string translation);
}
