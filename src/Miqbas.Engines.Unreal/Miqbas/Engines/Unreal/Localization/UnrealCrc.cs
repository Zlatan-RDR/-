namespace Miqbas.Engines.Unreal.Localization;

public static class UnrealCrc
{
	private static readonly uint[] Table = A();

	private static uint[] A()
	{
		uint[] array = new uint[256];
		for (uint num = 0u; num < 256; num++)
		{
			uint num2 = num;
			for (int i = 0; i < 8; i++)
			{
				num2 = (((num2 & (true ? 1u : 0u)) != 0) ? (0xEDB88320u ^ (num2 >> 1)) : (num2 >> 1));
			}
			array[num] = num2;
		}
		return array;
	}

	public static uint StrCrc32(string value)
	{
		uint num = 4294967295u;
		foreach (uint num2 in value)
		{
			for (int j = 0; j < 32; j += 8)
			{
				num = (num >> 8) ^ Table[(num ^ ((num2 >> j) & 0xFF)) & 0xFF];
			}
		}
		return ~num;
	}
}
