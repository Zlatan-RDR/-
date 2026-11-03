namespace Miqbas.Core.Booting;

public enum BootVerdict
{
	DidNotBoot,
	BootedButArabicNotDrawn,
	BootedAndArabicDrawn,
	BootedAndFontVerifiedInFile,
	AskTheUser
}
