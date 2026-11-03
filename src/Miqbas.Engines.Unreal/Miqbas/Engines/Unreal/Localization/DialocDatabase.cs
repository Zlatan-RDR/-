using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Core.Text;
using Miqbas.Engines.Unreal.Packages;

namespace Miqbas.Engines.Unreal.Localization;

public static class DialocDatabase
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<string, bool> _003C_003E9__7_0;

		public static Func<PakEntry, bool> _003C_003E9__9_0;

		internal bool A(string P_0)
		{
			return !string.IsNullOrWhiteSpace(P_0);
		}

		internal bool A(PakEntry P_0)
		{
			return P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hC(), (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class a : global::System.Collections.Generic.IEnumerable<ValueTuple<string, byte[]>>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<ValueTuple<string, byte[]>>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private ValueTuple<string, byte[]> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private global::System.Collections.Generic.IEnumerable<string> packages;

		public global::System.Collections.Generic.IEnumerable<string> _003C_003E3__packages;

		private byte[] key;

		public byte[] _003C_003E3__key;

		private IPakDecompressor decompressor;

		public IPakDecompressor _003C_003E3__decompressor;

		private global::System.Collections.Generic.IEnumerator<string> _003C_003E7__wrap1;

		private PakArchive _003Carchive_003E5__3;

		private PakArchive _003C_003E7__wrap3;

		private global::System.Collections.Generic.IEnumerator<PakEntry> _003C_003E7__wrap4;

		ValueTuple<string, byte[]> global::System.Collections.Generic.IEnumerator<ValueTuple<string, byte[]>>.Current
		{
			[DebuggerHidden]
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public a(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -5) > 2u && num != 1)
			{
				return;
			}
			try
			{
				if ((uint)(num - -5) > 1u && num != 1)
				{
					return;
				}
				try
				{
					if (num != -5 && num != 1)
					{
						return;
					}
					try
					{
					}
					finally
					{
						b();
					}
				}
				finally
				{
					B();
				}
			}
			finally
			{
				a();
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -5;
					goto IL_0196;
				}
				_003C_003E1__state = -1;
				_003C_003E7__wrap1 = packages.GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_01c7;
				IL_0196:
				while (((global::System.Collections.IEnumerator)_003C_003E7__wrap4).MoveNext())
				{
					PakEntry current = _003C_003E7__wrap4.Current;
					byte[] array;
					try
					{
						array = _003Carchive_003E5__3.Read(current, decompressor);
					}
					catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
					{
						continue;
					}
					if (Is(global::System.ReadOnlySpan<byte>.op_Implicit(array)))
					{
						_003C_003E2__current = new ValueTuple<string, byte[]>(DialocDatabase.A(_003Carchive_003E5__3.MountPoint, current.Path), array);
						_003C_003E1__state = 1;
						return true;
					}
				}
				b();
				_003C_003E7__wrap4 = null;
				B();
				_003C_003E7__wrap3 = null;
				_003Carchive_003E5__3 = null;
				goto IL_01c7;
				IL_01c7:
				while (true)
				{
					if (((global::System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
					{
						string current2 = _003C_003E7__wrap1.Current;
						try
						{
							_003Carchive_003E5__3 = PakArchive.Open(current2, key);
						}
						catch (global::System.Exception ex2) when (((ex2 is IOException || ex2 is InvalidDataException || ex2 is NotSupportedException) ? 1 : 0) != 0)
						{
							continue;
						}
						break;
					}
					a();
					_003C_003E7__wrap1 = null;
					return false;
				}
				_003C_003E7__wrap3 = _003Carchive_003E5__3;
				_003C_003E1__state = -4;
				_003C_003E7__wrap4 = Enumerable.Where<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)_003Carchive_003E5__3.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hC(), (StringComparison)5))).GetEnumerator();
				_003C_003E1__state = -5;
				goto IL_0196;
			}
			catch
			{
				//try-fault
				A();
				throw;
			}
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void a()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap1).Dispose();
			}
		}

		private void B()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap3 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap3).Dispose();
			}
		}

		private void b()
		{
			_003C_003E1__state = -4;
			if (_003C_003E7__wrap4 != null)
			{
				((global::System.IDisposable)_003C_003E7__wrap4).Dispose();
			}
		}

		[DebuggerHidden]
		private void C()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in C
			this.C();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<ValueTuple<string, byte[]>> c()
		{
			a a;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				a = this;
			}
			else
			{
				a = new a(0);
			}
			a.packages = _003C_003E3__packages;
			a.key = _003C_003E3__key;
			a.decompressor = _003C_003E3__decompressor;
			return a;
		}

		global::System.Collections.Generic.IEnumerator<ValueTuple<string, byte[]>> global::System.Collections.Generic.IEnumerable<ValueTuple<string, byte[]>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in c
			return this.c();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator D()
		{
			return (global::System.Collections.IEnumerator)c();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in D
			return this.D();
		}
	}

	public const string KeyPrefix = "dloc:";

	private static readonly TimeSpan Patience = TimeSpan.FromSeconds(30.0);

	private static readonly Regex Line = new Regex(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dB(), (RegexOptions)528, Patience);

	private static readonly Regex Source = new Regex(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.db(), (RegexOptions)528, Patience);

	public static bool Is(global::System.ReadOnlySpan<byte> bytes)
	{
		return MemoryExtensions.IndexOf<byte>(bytes.Slice(0, Math.Min(bytes.Length, 1024)), "<dloc_database"u8) >= 0;
	}

	public static bool IsDialocKey(string key)
	{
		return key.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ds(), (StringComparison)4);
	}

	public static string KeyOf(string filePath, string lineId)
	{
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ds() + Path.GetFileNameWithoutExtension(filePath) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.p() + lineId;
	}

	public static global::System.Collections.Generic.IReadOnlyList<SourceText> Read(byte[] bytes, string filePath)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		List<SourceText> val = new List<SourceText>();
		bool flag;
		foreach (Match item in Line.Matches(A(bytes, out flag)))
		{
			string value = ((Capture)item.Groups[1]).Value;
			string text = a(value, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DT());
			if (text == null || text.Length <= 0)
			{
				continue;
			}
			Match val2 = Source.Match(value);
			if (val2 == null || !((Group)val2).Success)
			{
				continue;
			}
			string text2 = WebUtility.HtmlDecode(((Capture)val2.Groups[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dt()]).Value);
			if (!string.IsNullOrWhiteSpace(text2))
			{
				string text3 = a(value, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DU()) ?? string.Empty;
				string text4 = A(value);
				string text5 = a(value, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Du());
				string text6 = ((text5 != null && text5.Length > 0) ? WebUtility.HtmlDecode(text5) : null);
				bool flag2 = text4 != null || value.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DV(), (StringComparison)4);
				val.Add(new SourceText
				{
					Key = KeyOf(filePath, text),
					File = filePath,
					Value = text2,
					TextType = ((!flag2) ? UnrealTextKinds.Of(text3, text2) : TextType.Dialogue),
					Speaker = text4,
					Context = string.Join(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dv(), Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)new string[2] { text3, text6 }, (Func<string, bool>)((string P_0) => !string.IsNullOrWhiteSpace(P_0)))),
					InTheSourceLanguage = true
				});
			}
		}
		return (global::System.Collections.Generic.IReadOnlyList<SourceText>)val;
	}

	public static byte[] WithEnglish(byte[] bytes, IReadOnlyDictionary<string, string> arabicById, out int written)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)bytes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.at());
		ArgumentNullException.ThrowIfNull((object)arabicById, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DW());
		bool flag;
		string text = A(bytes, out flag);
		StringBuilder val = new StringBuilder(text.Length + text.Length / 8);
		int num = 0;
		written = 0;
		string text3 = default(string);
		foreach (Match item in Line.Matches(text))
		{
			Group val2 = item.Groups[1];
			string text2 = a(((Capture)val2).Value, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DT());
			if (text2 != null && arabicById.TryGetValue(text2, ref text3))
			{
				Match val3 = Source.Match(((Capture)val2).Value);
				if (val3 != null && ((Group)val3).Success)
				{
					int num2 = ((Capture)val2).Index + ((Capture)val3.Groups[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dt()]).Index;
					val.Append(text, num, num2 - num).Append(a(text3));
					num = num2 + ((Capture)val3.Groups[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dt()]).Length;
					written++;
				}
			}
		}
		val.Append(text, num, text.Length - num);
		byte[] bytes2 = Encoding.UTF8.GetBytes(((object)val).ToString());
		if (!flag)
		{
			return bytes2;
		}
		global::System.ReadOnlySpan<byte> preamble = Encoding.UTF8.Preamble;
		byte[] array = bytes2;
		int num3 = 0;
		byte[] array2 = new byte[preamble.Length + array.Length];
		preamble.CopyTo(new global::System.Span<byte>(array2).Slice(num3, preamble.Length));
		num3 += preamble.Length;
		global::System.ReadOnlySpan<byte> readOnlySpan = new global::System.ReadOnlySpan<byte>(array);
		readOnlySpan.CopyTo(new global::System.Span<byte>(array2).Slice(num3, readOnlySpan.Length));
		num3 += readOnlySpan.Length;
		return array2;
	}

	[IteratorStateMachine(typeof(a))]
	public static global::System.Collections.Generic.IEnumerable<ValueTuple<string, byte[]>> FindIn(global::System.Collections.Generic.IEnumerable<string> packages, byte[]? key, IPakDecompressor? decompressor)
	{
		global::System.Collections.Generic.IEnumerator<string> enumerator = packages.GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				PakArchive archive;
				try
				{
					archive = PakArchive.Open(current, key);
				}
				catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
				{
					continue;
				}
				using (archive)
				{
					global::System.Collections.Generic.IEnumerator<PakEntry> enumerator2 = Enumerable.Where<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)archive.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hC(), (StringComparison)5))).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							PakEntry current2 = enumerator2.Current;
							byte[] array;
							try
							{
								array = archive.Read(current2, decompressor);
							}
							catch (global::System.Exception ex2) when (((ex2 is IOException || ex2 is InvalidDataException || ex2 is NotSupportedException) ? 1 : 0) != 0)
							{
								continue;
							}
							if (Is(global::System.ReadOnlySpan<byte>.op_Implicit(array)))
							{
								yield return new ValueTuple<string, byte[]>(A(archive.MountPoint, current2.Path), array);
							}
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2)?.Dispose();
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	internal static string A(string P_0, string P_1)
	{
		string text = (P_0 + P_1).Replace('\\', '/');
		while (text.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Y(), (StringComparison)4))
		{
			string text2 = text;
			text = text2.Substring(3, text2.Length - 3);
		}
		return text.TrimStart('/');
	}

	private static string A(byte[] P_0, out bool P_1)
	{
		P_1 = MemoryExtensions.StartsWith<byte>(MemoryExtensions.AsSpan<byte>(P_0), Encoding.UTF8.Preamble);
		return Encoding.UTF8.GetString(P_0, P_1 ? 3 : 0, P_0.Length - (P_1 ? 3 : 0));
	}

	private static string? a(string P_0, string P_1)
	{
		string text = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dw() + P_1 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DX();
		int num = P_0.IndexOf(text, (StringComparison)4);
		if (num < 0)
		{
			return null;
		}
		num += text.Length;
		int num2 = P_0.IndexOf(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dx() + P_1 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DX(), num, (StringComparison)4);
		if (num2 >= 0)
		{
			int num3 = num;
			return P_0.Substring(num3, num2 - num3).Trim();
		}
		return null;
	}

	private static string? A(string P_0)
	{
		int num = P_0.LastIndexOf(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DY(), (StringComparison)4);
		string text;
		if (num >= 0)
		{
			int num2 = num;
			text = P_0.Substring(num2, P_0.Length - num2);
		}
		else
		{
			text = P_0;
		}
		string text2 = a(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dy());
		if (text2 == null || text2.Length <= 0)
		{
			return null;
		}
		return WebUtility.HtmlDecode(text2);
	}

	private static string a(string P_0)
	{
		return P_0.Replace(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DZ(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dz(), (StringComparison)4).Replace(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dw(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.dA(), (StringComparison)4).Replace(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DX(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.da(), (StringComparison)4);
	}
}
