using System;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Packages;

public static class DebugRegisters
{
	public enum Watch
	{
		Execute = 0,
		Write = 1,
		ReadWrite = 3
	}

	public const int Slots = 4;

	public static int FirstFreeSlot(ulong dr7)
	{
		for (int i = 0; i < 4; i++)
		{
			if ((dr7 & (ulong)(1L << i * 2)) == 0L)
			{
				return i;
			}
		}
		return -1;
	}

	public static ulong Arm(ulong dr7, int slot, Watch watch)
	{
		A(slot);
		dr7 |= (ulong)(1L << slot * 2);
		int num = 16 + slot * 4;
		dr7 &= (ulong)(~(15L << num));
		dr7 |= (ulong)((long)watch << num);
		return dr7;
	}

	public static ulong Disarm(ulong dr7, int slot)
	{
		A(slot);
		dr7 &= (ulong)(~(3L << slot * 2));
		dr7 &= (ulong)(~(15L << 16 + slot * 4));
		return dr7;
	}

	public static bool IsArmed(ulong dr7, int slot)
	{
		A(slot);
		return (dr7 & (ulong)(1L << slot * 2)) != 0;
	}

	public static int WhichFired(ulong dr6)
	{
		for (int i = 0; i < 4; i++)
		{
			if ((dr6 & (ulong)(1L << i)) != 0L)
			{
				return i;
			}
		}
		return -1;
	}

	private static void A(int P_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if ((P_0 < 0 || P_0 >= 4) ? true : false)
		{
			throw new ArgumentOutOfRangeException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ak(), (object)P_0, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aL());
		}
	}
}
