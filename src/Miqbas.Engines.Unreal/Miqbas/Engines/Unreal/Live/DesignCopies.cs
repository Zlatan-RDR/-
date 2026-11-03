using System;
using System.Collections;
using System.Collections.Generic;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class DesignCopies
{
	public const string NamePrefix = "Default__";

	private readonly HashSet<uint> _designNames;

	private readonly HashSet<ulong> _ruledOut = new HashSet<ulong>();

	public int NamesKnown => _designNames.Count;

	public int RuledOut => _ruledOut.Count;

	public DesignCopies(IReadOnlyDictionary<uint, string> namesById)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)namesById, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eN());
		_designNames = new HashSet<uint>();
		global::System.Collections.Generic.IEnumerator<KeyValuePair<uint, string>> enumerator = ((global::System.Collections.Generic.IEnumerable<KeyValuePair<uint, string>>)namesById).GetEnumerator();
		try
		{
			uint num = default(uint);
			string text = default(string);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.Current.Deconstruct(ref num, ref text);
				uint num2 = num;
				if (text.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.en(), (StringComparison)4))
				{
					_designNames.Add(num2);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	public void StartFrom(global::System.Collections.Generic.IEnumerable<LiveObject> everything)
	{
		ArgumentNullException.ThrowIfNull((object)everything, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eO());
		_ruledOut.Clear();
		global::System.Collections.Generic.IEnumerator<LiveObject> enumerator = everything.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LiveObject current = enumerator.Current;
				if (!IsOne(current))
				{
					_ruledOut.Add(current.Address);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static bool IsOne(LiveObject live)
	{
		return live.Name.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.en(), (StringComparison)4);
	}

	public List<LiveObject> Find(ProcessMemory memory, UnrealObjects reader, LiveObjectArray array)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)reader, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cn());
		ArgumentNullException.ThrowIfNull((object)array, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bv());
		List<LiveObject> val = new List<LiveObject>();
		global::System.Collections.Generic.IEnumerator<ulong> enumerator = reader.Pointers(memory, array).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ulong current = enumerator.Current;
				if (_ruledOut.Contains(current))
				{
					continue;
				}
				uint? num = UnrealObjects.NameIdOf(memory, current);
				if (!num.HasValue)
				{
					continue;
				}
				if (!_designNames.Contains(num.Value))
				{
					_ruledOut.Add(current);
					continue;
				}
				LiveObject? liveObject = reader.Describe(memory, current);
				if (liveObject.HasValue)
				{
					LiveObject valueOrDefault = liveObject.GetValueOrDefault();
					if (IsOne(valueOrDefault))
					{
						val.Add(valueOrDefault);
					}
				}
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}
}
