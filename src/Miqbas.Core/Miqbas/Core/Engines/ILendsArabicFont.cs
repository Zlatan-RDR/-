using Miqbas.Core.Text;

namespace Miqbas.Core.Engines;

public interface ILendsArabicFont
{
	string? FontProblem { get; }

	bool TheLettersCanOnlyComeFromTheLoader => false;

	bool FontIsOurs { get; }

	FontRoad WhereTheFaceComesFrom { get; }

	void LendArabicFont();

	FaceVerification? VerifyTheArabicFace();
}
