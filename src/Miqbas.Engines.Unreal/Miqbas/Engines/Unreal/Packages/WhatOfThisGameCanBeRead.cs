using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Engines.Unreal.Detection;

namespace Miqbas.Engines.Unreal.Packages;

[RequiredMember]
public sealed class WhatOfThisGameCanBeRead : IEquatable<WhatOfThisGameCanBeRead>
{
	private const int ChunksBeforeAContainerCounts = 100;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[CompilerGenerated]
		get
		{
			return typeof(WhatOfThisGameCanBeRead);
		}
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Open
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[RequiredMember]
	[field: CompilerGenerated]
	public int Locked
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool NothingOpens
	{
		get
		{
			if (Open == 0)
			{
				return Locked > 0;
			}
			return false;
		}
	}

	public bool SomeIsLocked
	{
		get
		{
			if (Open > 0)
			{
				return Locked > 0;
			}
			return false;
		}
	}

	[field: CompilerGenerated]
	public int LockedPackages
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public bool AKeyWouldOpenMore => LockedPackages > 0;

	public static WhatOfThisGameCanBeRead Of(UnrealGameLayout layout, byte[]? key = null)
	{
		ArgumentNullException.ThrowIfNull((object)layout, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CQ());
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		global::System.Collections.Generic.IEnumerator<string> enumerator;
		if (Directory.Exists(layout.PaksDirectory))
		{
			enumerator = Directory.EnumerateFiles(layout.PaksDirectory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.u()).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					bool? flag = A(enumerator.Current, key);
					if (flag.HasValue)
					{
						if (flag.GetValueOrDefault())
						{
							num++;
						}
						else
						{
							num2++;
						}
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
		}
		enumerator = ((global::System.Collections.Generic.IEnumerable<string>)layout.Packages).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					using PakArchive pakArchive = PakArchive.Open(current, key);
					if (pakArchive.IndexEncrypted)
					{
						num2++;
						num3++;
						continue;
					}
					num++;
					if (pakArchive.SomeFilesAreLocked)
					{
						num2++;
						num3++;
					}
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return new WhatOfThisGameCanBeRead
		{
			Open = num,
			Locked = num2,
			LockedPackages = num3
		};
	}

	private static bool? A(string P_0, byte[]? key)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		try
		{
			FileStream val = new FileStream(P_0, (FileMode)3, (FileAccess)1, (FileShare)7);
			try
			{
				byte[] array = new byte[144];
				if (((Stream)val).Read(array, 0, array.Length) != array.Length || !MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(array, 0, IoStoreContainer.MagicBytes.Length), global::System.ReadOnlySpan<byte>.op_Implicit(IoStoreContainer.MagicBytes)))
				{
					return null;
				}
				if (BitConverter.ToInt32(array, 24) < 100)
				{
					return null;
				}
				IoStoreContainer.ContainerFlags containerFlags = (IoStoreContainer.ContainerFlags)array[80];
				return !((global::System.Enum)containerFlags).HasFlag((global::System.Enum)IoStoreContainer.ContainerFlags.Encrypted) || (key != null && IoStoreContainer.KeyOpens(P_0, key));
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (IOException)
		{
			return null;
		}
	}

	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cq());
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
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CR());
		P_0.Append(((object)Open).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cr());
		P_0.Append(((object)Locked).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CS());
		P_0.Append(((object)NothingOpens).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cs());
		P_0.Append(((object)SomeIsLocked).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CT());
		P_0.Append(((object)LockedPackages).ToString());
		P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ct());
		P_0.Append(((object)AKeyWouldOpenMore).ToString());
		return true;
	}

	[CompilerGenerated]
	public static bool operator !=(WhatOfThisGameCanBeRead? left, WhatOfThisGameCanBeRead? right)
	{
		return !(left == right);
	}

	[CompilerGenerated]
	public static bool operator ==(WhatOfThisGameCanBeRead? left, WhatOfThisGameCanBeRead? right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Open)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Locked)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(LockedPackages);
	}

	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as WhatOfThisGameCanBeRead);
	}

	[CompilerGenerated]
	public bool Equals(WhatOfThisGameCanBeRead? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<int>.Default.Equals(Open, other.Open) && EqualityComparer<int>.Default.Equals(Locked, other.Locked))
			{
				return EqualityComparer<int>.Default.Equals(LockedPackages, other.LockedPackages);
			}
			return false;
		}
		return true;
	}

	[CompilerGenerated]
	[SetsRequiredMembers]
	private WhatOfThisGameCanBeRead(WhatOfThisGameCanBeRead P_0)
	{
		Open = P_0.Open;
		Locked = P_0.Locked;
		LockedPackages = P_0.LockedPackages;
	}

	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public WhatOfThisGameCanBeRead()
	{
	}
}
