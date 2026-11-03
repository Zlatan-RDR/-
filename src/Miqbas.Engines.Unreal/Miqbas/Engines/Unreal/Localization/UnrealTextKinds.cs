using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Core.Text;

namespace Miqbas.Engines.Unreal.Localization;

public static class UnrealTextKinds
{
	[CompilerGenerated]
	private sealed class A
	{
		public string haystack;

		public Func<string, bool> _003C_003E9__0;

		internal bool A(string P_0)
		{
			return haystack.Contains(P_0, (StringComparison)4);
		}
	}

	private static readonly string[] Dialogue = new string[13]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.En(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EO(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eo(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EP(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ep(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EQ(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eq(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ER(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Er(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ES(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Es(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ET(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Et()
	};

	private static readonly string[] Item = new string[14]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EU(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eu(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EV(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ev(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EW(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ew(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EX(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ex(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EY(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ey(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EZ(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ez(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eA(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ea()
	};

	private static readonly string[] Name = new string[6]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eB(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eb(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eC(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ec(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eD(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ed()
	};

	private static readonly string[] Ui = new string[16]
	{
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eE(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ee(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eF(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ef(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eG(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eg(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eH(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eh(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eI(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ei(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eJ(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ej(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eK(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ek(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eL(),
		_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.el()
	};

	public static TextType Of(string? where, string source, out KindEvidence evidence)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		string haystack = (where ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa()).ToLowerInvariant();
		ValueTuple<string[], TextType>[] array = new ValueTuple<string[], TextType>[4]
		{
			new ValueTuple<string[], TextType>(Name, TextType.Name),
			new ValueTuple<string[], TextType>(Dialogue, TextType.Dialogue),
			new ValueTuple<string[], TextType>(Item, TextType.Item),
			new ValueTuple<string[], TextType>(Ui, TextType.Ui)
		};
		for (int i = 0; i < array.Length; i++)
		{
			ValueTuple<string[], TextType> val = array[i];
			string[] item = val.Item1;
			TextType item2 = val.Item2;
			if (Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)item, (Func<string, bool>)((string P_0) => haystack.Contains(P_0, (StringComparison)4))))
			{
				evidence = KindEvidence.ByPlace;
				return item2;
			}
		}
		evidence = KindEvidence.ByLength;
		if (source.Length <= 60)
		{
			return TextType.Ui;
		}
		return TextType.Dialogue;
	}

	public static TextType Of(string? where, string source)
	{
		KindEvidence evidence;
		return Of(where, source, out evidence);
	}

	public static ValueTuple<int, int> Measure(global::System.Collections.Generic.IEnumerable<ValueTuple<string?, string>> lines)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		global::System.Collections.Generic.IEnumerator<ValueTuple<string, string>> enumerator = lines.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ValueTuple<string, string> current = enumerator.Current;
				string item = current.Item1;
				string item2 = current.Item2;
				Of(item, item2, out var evidence);
				if (evidence == KindEvidence.ByPlace)
				{
					num++;
				}
				else
				{
					num2++;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return new ValueTuple<int, int>(num, num2);
	}
}
