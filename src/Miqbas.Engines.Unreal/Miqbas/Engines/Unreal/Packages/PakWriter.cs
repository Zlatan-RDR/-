using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using A;

namespace Miqbas.Engines.Unreal.Packages;

public static class PakWriter
{
	private sealed class A : IEquatable<A>
	{
		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(A);
			}
		}

		[field: CompilerGenerated]
		public string Path
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public long Offset
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public byte[] Hash
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int Length
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public A(string P_0, long P_1, byte[] P_2, int P_3)
		{
			Path = P_0;
			Offset = P_1;
			Hash = P_2;
			Length = P_3;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hl());
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aD());
			if (A(val))
			{
				val.Append(' ');
			}
			val.Append('}');
			return ((object)val).ToString();
		}

		[CompilerGenerated]
		private bool A(StringBuilder P_0)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.bz());
			P_0.Append((object)Path);
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ap());
			P_0.Append(((object)Offset).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HM());
			P_0.Append((object)Hash);
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aQ());
			P_0.Append(((object)Length).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(A? P_0, A? P_1)
		{
			return !(P_0 == P_1);
		}

		[CompilerGenerated]
		public static bool operator ==(A? P_0, A? P_1)
		{
			if ((object)P_0 != P_1)
			{
				return P_0?.Equals(P_1) ?? false;
			}
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<long>.Default.GetHashCode(Offset)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Hash)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Length);
		}

		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as A);
		}

		[CompilerGenerated]
		public bool Equals(A? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<long>.Default.Equals(Offset, other.Offset) && EqualityComparer<byte[]>.Default.Equals(Hash, other.Hash))
				{
					return EqualityComparer<int>.Default.Equals(Length, other.Length);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		public A A()
		{
			return new A(this);
		}

		[CompilerGenerated]
		private A(A P_0)
		{
			Path = P_0.Path;
			Offset = P_0.Offset;
			Hash = P_0.Hash;
			Length = P_0.Length;
		}

		[CompilerGenerated]
		public void A(out string P_0, out long P_1, out byte[] P_2, out int P_3)
		{
			P_0 = Path;
			P_1 = Offset;
			P_2 = Hash;
			P_3 = Length;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<KeyValuePair<string, byte[]>, string> _003C_003E9__9_0;

		public static Func<A, string> _003C_003E9__13_0;

		public static Func<IGrouping<string, A>, string> _003C_003E9__13_1;

		public static Func<A, string> _003C_003E9__13_2;

		internal string A(KeyValuePair<string, byte[]> P_0)
		{
			return P_0.Key;
		}

		internal string A(A P_0)
		{
			return PakWriter.A(P_0.Path);
		}

		internal string A(IGrouping<string, A> P_0)
		{
			return P_0.Key;
		}

		internal string a(A P_0)
		{
			return P_0.Path;
		}
	}

	public const int LegacyVersion = 3;

	public const int DirectoryIndexVersion = 11;

	private const int FirstDirectoryIndexVersion = 10;

	private const uint FooterMagic = 1517228769u;

	private const int CompressionMethodSlots = 5;

	private const int CompressionMethodNameLength = 32;

	private const ulong PathHashSeed = 5578114280830742065uL;

	public static int FormatFor(int gamePackageVersion)
	{
		if (gamePackageVersion < 10)
		{
			return 3;
		}
		return 11;
	}

	public static void Write(string destinationPath, string mountPoint, IReadOnlyDictionary<string, byte[]> files, int version = 11)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		ArgumentException.ThrowIfNullOrWhiteSpace(destinationPath, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CE());
		ArgumentException.ThrowIfNullOrWhiteSpace(mountPoint, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ce());
		ArgumentNullException.ThrowIfNull((object)files, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CF());
		if (((global::System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, byte[]>>)files).Count == 0)
		{
			throw new ArgumentException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cf(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CF());
		}
		string directoryName = Path.GetDirectoryName(destinationPath);
		if (!string.IsNullOrEmpty(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		FileStream val = new FileStream(destinationPath, (FileMode)2, (FileAccess)2, (FileShare)0);
		try
		{
			Write((Stream)(object)val, mountPoint, files, version);
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	public static void Write(Stream stream, string mountPoint, IReadOnlyDictionary<string, byte[]> files, int version = 11)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)stream, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CG());
		BinaryWriter val = new BinaryWriter(stream, Encoding.UTF8, true);
		try
		{
			List<KeyValuePair<string, byte[]>> obj = Enumerable.ToList<KeyValuePair<string, byte[]>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, byte[]>>)Enumerable.OrderBy<KeyValuePair<string, byte[]>, string>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, byte[]>>)files, (Func<KeyValuePair<string, byte[]>, string>)((KeyValuePair<string, byte[]> P_0) => P_0.Key), (IComparer<string>)(object)StringComparer.Ordinal));
			List<A> val2 = new List<A>(obj.Count);
			Enumerator<KeyValuePair<string, byte[]>> enumerator = obj.GetEnumerator();
			try
			{
				string text = default(string);
				byte[] array = default(byte[]);
				while (enumerator.MoveNext())
				{
					enumerator.Current.Deconstruct(ref text, ref array);
					string text2 = text;
					byte[] array2 = array;
					long position = stream.Position;
					byte[] array3 = SHA1.HashData(array2);
					A(val, 0L, array2.Length, array3);
					val.Write(array2);
					val2.Add(new A(B(text2), position, array3, array2.Length));
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			long position4;
			byte[] array7;
			if (version >= 10)
			{
				byte[] array4;
				IReadOnlyDictionary<string, int> val3;
				byte[] array5 = A((global::System.Collections.Generic.IReadOnlyList<A>)val2, out array4, out val3);
				long position2 = stream.Position;
				val.Write(array5);
				byte[] array6 = A((global::System.Collections.Generic.IReadOnlyList<A>)val2, val3);
				long position3 = stream.Position;
				val.Write(array6);
				position4 = stream.Position;
				array7 = A(mountPoint, (global::System.Collections.Generic.IReadOnlyList<A>)val2, position2, array5, position3, array6, array4);
			}
			else
			{
				position4 = stream.Position;
				array7 = A(mountPoint, (global::System.Collections.Generic.IReadOnlyList<A>)val2);
			}
			val.Write(array7);
			if (version >= 10)
			{
				val.Write(new byte[16]);
			}
			val.Write((byte)0);
			val.Write(1517228769u);
			val.Write(version);
			val.Write(position4);
			val.Write((long)array7.Length);
			val.Write(SHA1.HashData(array7));
			if (version >= 10)
			{
				val.Write(new byte[160]);
			}
			val.Flush();
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static byte[] A(string P_0, global::System.Collections.Generic.IReadOnlyList<A> P_1, long P_2, byte[] P_3, long P_4, byte[] P_5, byte[] P_6)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				global::A.C.A(val2, P_0);
				val2.Write(((global::System.Collections.Generic.IReadOnlyCollection<A>)P_1).Count);
				val2.Write(5578114280830742065uL);
				val2.Write(1);
				val2.Write(P_4);
				val2.Write((long)P_5.Length);
				val2.Write(SHA1.HashData(P_5));
				val2.Write(1);
				val2.Write(P_2);
				val2.Write((long)P_3.Length);
				val2.Write(SHA1.HashData(P_3));
				val2.Write(P_6.Length);
				val2.Write(P_6);
				val2.Write(0);
				val2.Flush();
				return val.ToArray();
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static byte[] A(global::System.Collections.Generic.IReadOnlyList<A> P_0, IReadOnlyDictionary<string, int> P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				val2.Write(((global::System.Collections.Generic.IReadOnlyCollection<A>)P_0).Count);
				global::System.Collections.Generic.IEnumerator<A> enumerator = ((global::System.Collections.Generic.IEnumerable<A>)P_0).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
					{
						A current = enumerator.Current;
						val2.Write(A(current.Path, 5578114280830742065uL));
						val2.Write(P_1[current.Path]);
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator)?.Dispose();
				}
				val2.Flush();
				return val.ToArray();
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	internal static ulong A(string P_0, ulong P_1)
	{
		ulong num = 14695981039346656037uL + P_1;
		byte[] bytes = Encoding.Unicode.GetBytes(P_0.ToLowerInvariant());
		foreach (byte b in bytes)
		{
			num = (num ^ b) * 1099511628211L;
		}
		return num;
	}

	private static byte[] A(global::System.Collections.Generic.IReadOnlyList<A> P_0, out byte[] P_1, out IReadOnlyDictionary<string, int> P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				Dictionary<string, int> val3 = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
				global::System.Collections.Generic.IEnumerator<A> enumerator = ((global::System.Collections.Generic.IEnumerable<A>)P_0).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
					{
						A current = enumerator.Current;
						val3[current.Path] = (int)((Stream)val).Position;
						A(val2, current);
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator)?.Dispose();
				}
				val2.Flush();
				P_1 = val.ToArray();
				P_2 = (IReadOnlyDictionary<string, int>)(object)val3;
				List<IGrouping<string, A>> val4 = Enumerable.ToList<IGrouping<string, A>>((global::System.Collections.Generic.IEnumerable<IGrouping<string, A>>)Enumerable.OrderBy<IGrouping<string, A>, string>(Enumerable.GroupBy<A, string>((global::System.Collections.Generic.IEnumerable<A>)P_0, (Func<A, string>)((A P_0) => A(P_0.Path)), (IEqualityComparer<string>)(object)StringComparer.Ordinal), (Func<IGrouping<string, A>, string>)((IGrouping<string, A> P_0) => P_0.Key), (IComparer<string>)(object)StringComparer.Ordinal));
				MemoryStream val5 = new MemoryStream();
				try
				{
					BinaryWriter val6 = new BinaryWriter((Stream)(object)val5, Encoding.UTF8, true);
					try
					{
						val6.Write(val4.Count);
						Enumerator<IGrouping<string, A>> enumerator2 = val4.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								IGrouping<string, A> current2 = enumerator2.Current;
								global::A.C.A(val6, current2.Key);
								val6.Write(Enumerable.Count<A>((global::System.Collections.Generic.IEnumerable<A>)current2));
								enumerator = ((global::System.Collections.Generic.IEnumerable<A>)Enumerable.OrderBy<A, string>((global::System.Collections.Generic.IEnumerable<A>)current2, (Func<A, string>)((A P_0) => P_0.Path), (IComparer<string>)(object)StringComparer.Ordinal)).GetEnumerator();
								try
								{
									while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
									{
										A current3 = enumerator.Current;
										global::A.C.A(val6, a(current3.Path));
										val6.Write(val3[current3.Path]);
									}
								}
								finally
								{
									((global::System.IDisposable)enumerator)?.Dispose();
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						val6.Flush();
						return val5.ToArray();
					}
					finally
					{
						((global::System.IDisposable)val6)?.Dispose();
					}
				}
				finally
				{
					((global::System.IDisposable)val5)?.Dispose();
				}
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static void A(BinaryWriter P_0, A P_1)
	{
		uint num = 536870912u;
		P_0.Write(num);
		P_0.Write(P_1.Offset);
		P_0.Write((long)P_1.Length);
	}

	private static string A(string P_0)
	{
		int num = P_0.LastIndexOf('/');
		if (num >= 0)
		{
			return P_0.Substring(0, num + 1);
		}
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg();
	}

	private static string a(string P_0)
	{
		int num = P_0.LastIndexOf('/');
		if (num >= 0)
		{
			int num2 = num + 1;
			return P_0.Substring(num2, P_0.Length - num2);
		}
		return P_0;
	}

	private static byte[] A(string P_0, global::System.Collections.Generic.IReadOnlyList<A> P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		try
		{
			BinaryWriter val2 = new BinaryWriter((Stream)(object)val, Encoding.UTF8, true);
			try
			{
				global::A.C.A(val2, P_0);
				val2.Write(((global::System.Collections.Generic.IReadOnlyCollection<A>)P_1).Count);
				global::System.Collections.Generic.IEnumerator<A> enumerator = ((global::System.Collections.Generic.IEnumerable<A>)P_1).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
					{
						A current = enumerator.Current;
						global::A.C.A(val2, current.Path);
						A(val2, current.Offset, current.Length, current.Hash);
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator)?.Dispose();
				}
				val2.Flush();
				return val.ToArray();
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	private static void A(BinaryWriter P_0, long P_1, long P_2, byte[] P_3)
	{
		P_0.Write(P_1);
		P_0.Write(P_2);
		P_0.Write(P_2);
		P_0.Write(0);
		P_0.Write(P_3);
		P_0.Write((byte)0);
		P_0.Write(0u);
	}

	private static string B(string P_0)
	{
		return P_0.Replace('\\', '/').TrimStart('/');
	}
}
