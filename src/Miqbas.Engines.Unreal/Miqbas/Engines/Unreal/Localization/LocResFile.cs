using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Localization;

public sealed class LocResFile
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<ValueTuple<string, string, string, string>, LocResEntry> _003C_003E9__8_0;

		internal LocResEntry A(ValueTuple<string, string, string, string> line)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			return new LocResEntry
			{
				Namespace = line.Item1,
				Key = line.Item2,
				Value = line.Item4,
				NamespaceHash = UnrealCrc.StrCrc32(line.Item1),
				KeyHash = UnrealCrc.StrCrc32(line.Item2),
				SourceStringHash = UnrealCrc.StrCrc32(line.Item3)
			};
		}
	}

	private static readonly byte[] Magic;

	[field: CompilerGenerated]
	public LocResVersion Version
	{
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<LocResEntry> Entries
	{
		[CompilerGenerated]
		get;
	}

	private LocResFile(LocResVersion P_0, global::System.Collections.Generic.IReadOnlyList<LocResEntry> P_1)
	{
		Version = P_0;
		Entries = P_1;
	}

	public static LocResFile FromScratch(global::System.Collections.Generic.IEnumerable<ValueTuple<string, string, string, string>> lines, LocResVersion version = LocResVersion.Compact)
	{
		return new LocResFile(version, (global::System.Collections.Generic.IReadOnlyList<LocResEntry>)Enumerable.ToList<LocResEntry>(Enumerable.Select<ValueTuple<string, string, string, string>, LocResEntry>(lines, (Func<ValueTuple<string, string, string, string>, LocResEntry>)((ValueTuple<string, string, string, string> line) => new LocResEntry
		{
			Namespace = line.Item1,
			Key = line.Item2,
			Value = line.Item4,
			NamespaceHash = UnrealCrc.StrCrc32(line.Item1),
			KeyHash = UnrealCrc.StrCrc32(line.Item2),
			SourceStringHash = UnrealCrc.StrCrc32(line.Item3)
		}))));
	}

	public static LocResFile Read(byte[] bytes)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		MemoryStream val = new MemoryStream(bytes, false);
		try
		{
			return Read((Stream)(object)val);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	public static LocResFile Read(Stream stream)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)stream, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CG());
		BinaryReader val = new BinaryReader(stream, Encoding.UTF8, true);
		try
		{
			if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(val.ReadBytes(Magic.Length)), global::System.ReadOnlySpan<byte>.op_Implicit(Magic)))
			{
				throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EB());
			}
			LocResVersion locResVersion = (LocResVersion)val.ReadByte();
			if (((int)locResVersion < 1 || (int)locResVersion > 3) ? true : false)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(52, 1);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eb());
				defaultInterpolatedStringHandler.AppendFormatted<byte>((byte)locResVersion);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EC());
				throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			long num = val.ReadInt64();
			List<string> val2 = A(stream, val, locResVersion, num);
			if ((int)locResVersion >= 2)
			{
				val.ReadUInt32();
			}
			uint num2 = val.ReadUInt32();
			List<LocResEntry> val3 = new List<LocResEntry>();
			for (int i = 0; i < num2; i++)
			{
				uint namespaceHash = (((int)locResVersion >= 2) ? val.ReadUInt32() : 0u);
				string text = global::A.C.A(val);
				uint num3 = val.ReadUInt32();
				for (int j = 0; j < num3; j++)
				{
					uint keyHash = (((int)locResVersion >= 2) ? val.ReadUInt32() : 0u);
					string text2 = global::A.C.A(val);
					uint sourceStringHash = val.ReadUInt32();
					int num4 = val.ReadInt32();
					if (num4 < 0 || num4 >= val2.Count)
					{
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(49, 4);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ec());
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg());
						defaultInterpolatedStringHandler.AppendFormatted(text2);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ED());
						defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ed());
						defaultInterpolatedStringHandler.AppendFormatted<int>(val2.Count);
						defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC());
						throw new InvalidDataException(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					val3.Add(new LocResEntry
					{
						Namespace = text,
						Key = text2,
						Value = val2[num4],
						NamespaceHash = namespaceHash,
						KeyHash = keyHash,
						SourceStringHash = sourceStringHash
					});
				}
			}
			return new LocResFile(locResVersion, (global::System.Collections.Generic.IReadOnlyList<LocResEntry>)val3);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	public LocResFile WithValues(IReadOnlyDictionary<string, string> valuesByAddress)
	{
		ArgumentNullException.ThrowIfNull((object)valuesByAddress, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EE());
		List<LocResEntry> val = new List<LocResEntry>(((global::System.Collections.Generic.IReadOnlyCollection<LocResEntry>)Entries).Count);
		global::System.Collections.Generic.IEnumerator<LocResEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<LocResEntry>)Entries).GetEnumerator();
		try
		{
			string text = default(string);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LocResEntry current = enumerator.Current;
				LocResEntry locResEntry;
				if (!valuesByAddress.TryGetValue(current.Address, ref text) || text == null)
				{
					locResEntry = current;
				}
				else
				{
					locResEntry = current._003CClone_003E_0024();
					locResEntry.Value = text;
				}
				val.Add(locResEntry);
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return new LocResFile(Version, (global::System.Collections.Generic.IReadOnlyList<LocResEntry>)val);
	}

	public byte[] ToBytes()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				val2.Write(Magic);
				val2.Write((byte)Version);
				long position = ((Stream)val).Position;
				val2.Write(0L);
				if ((int)Version >= 2)
				{
					val2.Write((uint)((global::System.Collections.Generic.IReadOnlyCollection<LocResEntry>)Entries).Count);
				}
				Dictionary<string, int> val3 = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
				List<string> val4 = new List<string>();
				List<int> val5 = new List<int>();
				List<ValueTuple<string, uint, List<LocResEntry>>> val6 = A();
				val2.Write((uint)val6.Count);
				Enumerator<ValueTuple<string, uint, List<LocResEntry>>> enumerator = val6.GetEnumerator();
				try
				{
					int count = default(int);
					while (enumerator.MoveNext())
					{
						ValueTuple<string, uint, List<LocResEntry>> current = enumerator.Current;
						if ((int)Version >= 2)
						{
							val2.Write(current.Item2);
						}
						global::A.C.A(val2, current.Item1);
						val2.Write((uint)current.Item3.Count);
						Enumerator<LocResEntry> enumerator2 = current.Item3.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								LocResEntry current2 = enumerator2.Current;
								if ((int)Version >= 2)
								{
									val2.Write(current2.KeyHash);
								}
								global::A.C.A(val2, current2.Key);
								val2.Write(current2.SourceStringHash);
								if (!val3.TryGetValue(current2.Value, ref count))
								{
									count = val4.Count;
									val3[current2.Value] = count;
									val4.Add(current2.Value);
									val5.Add(0);
								}
								int num = count;
								int num2 = val5[num];
								val5[num] = num2 + 1;
								val2.Write(count);
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				long position2 = ((Stream)val).Position;
				val2.Write(val4.Count);
				for (int i = 0; i < val4.Count; i++)
				{
					global::A.C.A(val2, val4[i]);
					if ((int)Version >= 2)
					{
						val2.Write(val5[i]);
					}
				}
				val2.Flush();
				((Stream)val).Position = position;
				val2.Write(position2);
				val2.Flush();
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
			return val.ToArray();
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private List<ValueTuple<string, uint, List<LocResEntry>>> A()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		List<ValueTuple<string, uint, List<LocResEntry>>> val = new List<ValueTuple<string, uint, List<LocResEntry>>>();
		Dictionary<string, int> val2 = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		global::System.Collections.Generic.IEnumerator<LocResEntry> enumerator = ((global::System.Collections.Generic.IEnumerable<LocResEntry>)Entries).GetEnumerator();
		try
		{
			int count = default(int);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LocResEntry current = enumerator.Current;
				if (!val2.TryGetValue(current.Namespace, ref count))
				{
					count = val.Count;
					val2[current.Namespace] = count;
					val.Add(new ValueTuple<string, uint, List<LocResEntry>>(current.Namespace, current.NamespaceHash, new List<LocResEntry>()));
				}
				val[count].Item3.Add(current);
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static List<string> A(Stream P_0, BinaryReader P_1, LocResVersion P_2, long P_3)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		List<string> val = new List<string>();
		if (P_3 < 0)
		{
			return val;
		}
		if (P_3 > P_0.Length)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ee());
		}
		long position = P_0.Position;
		P_0.Position = P_3;
		int num = P_1.ReadInt32();
		if (num < 0)
		{
			throw new InvalidDataException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.EF());
		}
		val.Capacity = num;
		for (int i = 0; i < num; i++)
		{
			val.Add(global::A.C.A(P_1));
			if ((int)P_2 >= 2)
			{
				P_1.ReadInt32();
			}
		}
		P_0.Position = position;
		return val;
	}

	static LocResFile()
	{
		byte[] array = new byte[16];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		Magic = array;
	}
}
