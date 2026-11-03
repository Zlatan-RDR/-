using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;
using Miqbas.Core.Engines;
using Miqbas.Core.Text;
using Miqbas.Engines.Unreal.Detection;
using Miqbas.Engines.Unreal.Packages;
using Miqbas.Rendering.Arabic.Shaping;

namespace Miqbas.Engines.Unreal.MeshText;

public static class MeshTextRoad
{
	private sealed class A
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A _003C_003E9 = new A();

			public static Func<ValueTuple<int, string>, int> _003C_003E9__5_1;

			public static Func<ValueTuple<int, string>, string> _003C_003E9__28_1;

			public static Func<string, bool> _003C_003E9__28_2;

			public static Func<LegacyProperty, bool> _003C_003E9__33_0;

			public static Func<KeyValuePair<int, LetterModel>, int> _003C_003E9__33_1;

			public static Func<LegacyProperty, int> _003C_003E9__34_0;

			public static Func<LegacyProperty, bool> _003C_003E9__35_0;

			public static Func<LegacyProperty, bool> _003C_003E9__35_1;

			public static Func<LegacyProperty, bool> _003C_003E9__35_2;

			internal int A(ValueTuple<int, string> g)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				return g.Item1;
			}

			internal string a(ValueTuple<int, string> g)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				return g.Item2;
			}

			internal bool A(string P_0)
			{
				return P_0.Length > 0;
			}

			internal bool A(LegacyProperty P_0)
			{
				return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hs();
			}

			internal int A(KeyValuePair<int, LetterModel> P_0)
			{
				return P_0.Key;
			}

			internal int a(LegacyProperty P_0)
			{
				return P_0.ValueStart;
			}

			internal bool B(LegacyProperty P_0)
			{
				return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hs();
			}

			internal bool b(LegacyProperty P_0)
			{
				return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hu();
			}

			internal bool C(LegacyProperty P_0)
			{
				return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HX();
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public string fontName;

			internal bool A(PakEntry P_0)
			{
				return P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg() + fontName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn(), (StringComparison)5);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct B
		{
			public LegacyPackage font;
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct b
		{
			public global::System.Collections.Generic.IReadOnlyList<LegacyProperty> props;
		}

		[CompilerGenerated]
		private sealed class C
		{
			public string name;

			internal bool A(LegacyProperty P_0)
			{
				return P_0.Name == name;
			}
		}

		[CompilerGenerated]
		private sealed class c : global::System.Collections.Generic.IEnumerable<ValueTuple<int, string>>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<ValueTuple<int, string>>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private ValueTuple<int, string> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MeshTextRoad.A _003C_003E4__this;

			private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>> _003C_003E7__wrap1;

			ValueTuple<int, string> global::System.Collections.Generic.IEnumerator<ValueTuple<int, string>>.Current
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
			public c(int P_0)
			{
				_003C_003E1__state = P_0;
				_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
			}

			[DebuggerHidden]
			private void A()
			{
				int num = _003C_003E1__state;
				if (num == -3 || num == 1)
				{
					try
					{
					}
					finally
					{
						a();
					}
				}
			}

			void global::System.IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in A
				this.A();
			}

			private bool MoveNext()
			{
				//IL_0133: Unknown result type (might be due to invalid IL or missing references)
				//IL_0138: Unknown result type (might be due to invalid IL or missing references)
				try
				{
					int num = _003C_003E1__state;
					MeshTextRoad.A a = _003C_003E4__this;
					switch (num)
					{
					default:
						return false;
					case 0:
					{
						_003C_003E1__state = -1;
						LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)a._font.PropertiesOf(a._font.Exports[0]), (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hs()));
						if ((object)legacyProperty == null)
						{
							return false;
						}
						_003C_003E7__wrap1 = ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>>)a._font.StructArray(legacyProperty)).GetEnumerator();
						_003C_003E1__state = -3;
						break;
					}
					case 1:
						_003C_003E1__state = -3;
						break;
					}
					if (((global::System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
					{
						global::System.Collections.Generic.IReadOnlyList<LegacyProperty> current = _003C_003E7__wrap1.Current;
						LegacyProperty legacyProperty2 = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)current, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hu()));
						LegacyProperty legacyProperty3 = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)current, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HX()));
						_003C_003E2__current = new ValueTuple<int, string>(((object)legacyProperty2 == null) ? (-1) : BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(a._font.Bytes, legacyProperty2.ValueStart))), ((object)legacyProperty3 == null) ? string.Empty : a._font.StringAt(legacyProperty3.ValueStart));
						_003C_003E1__state = 1;
						return true;
					}
					this.a();
					_003C_003E7__wrap1 = null;
					return false;
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

			[DebuggerHidden]
			private void B()
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				throw new NotSupportedException();
			}

			void global::System.Collections.IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in B
				this.B();
			}

			[DebuggerHidden]
			private global::System.Collections.Generic.IEnumerator<ValueTuple<int, string>> b()
			{
				c result;
				if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
				{
					_003C_003E1__state = 0;
					result = this;
				}
				else
				{
					result = new c(0)
					{
						_003C_003E4__this = _003C_003E4__this
					};
				}
				return result;
			}

			global::System.Collections.Generic.IEnumerator<ValueTuple<int, string>> global::System.Collections.Generic.IEnumerable<ValueTuple<int, string>>.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in b
				return this.b();
			}

			[DebuggerHidden]
			private global::System.Collections.IEnumerator C()
			{
				return (global::System.Collections.IEnumerator)b();
			}

			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in C
				return this.C();
			}
		}

		private readonly LegacyPackage _font;

		private readonly FontMetrics _arabic;

		private readonly double _scale;

		private readonly HashSet<int> _has;

		private readonly string _letterFolder;

		private readonly Dictionary<int, LetterModel?> _measured = new Dictionary<int, LetterModel>();

		[field: CompilerGenerated]
		public string EntryPath
		{
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public LegacyPackage Template
		{
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public float Em
		{
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public float BaseLine
		{
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public float LineStep
		{
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public double Space
		{
			[CompilerGenerated]
			get;
		}

		[field: CompilerGenerated]
		public Dictionary<int, LetterModel> Letters
		{
			[CompilerGenerated]
			get;
		} = new Dictionary<int, LetterModel>();


		private A(string P_0, LegacyPackage P_1, LegacyPackage P_2, string P_3, FontMetrics P_4)
		{
			B b = default(B);
			b.font = P_1;
			base._002Ector();
			EntryPath = P_0;
			_font = b.font;
			Template = P_2;
			_letterFolder = P_3;
			_arabic = P_4;
			b b2 = default(b);
			b2.props = b.font.PropertiesOf(b.font.Exports[0]);
			Em = A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HS(), 100f, ref b, ref b2);
			BaseLine = A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hs(), Em * 1.2f, ref b, ref b2);
			LineStep = A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HT(), Em * 1.45f, ref b, ref b2) * 1.028f;
			_scale = (double)Em * 1.35 / (double)P_4.UnitsPerEm;
			Space = (double)P_4.AdvanceUnitsOf(32) * _scale;
			_has = Enumerable.ToHashSet<int>(Enumerable.Select<ValueTuple<int, string>, int>(a(), (Func<ValueTuple<int, string>, int>)((ValueTuple<int, string> g) => g.Item1)));
		}

		public static MeshTextRoad.A? A(PakArchive P_0, Dictionary<string, PakEntry> P_1, string P_2, IPakDecompressor? decompressor, FontMetrics P_4, Dictionary<string, MeshTextRoad.A> P_5)
		{
			string fontName = P_2;
			MeshTextRoad.A result = default(MeshTextRoad.A);
			if (P_5.TryGetValue(fontName, ref result))
			{
				return result;
			}
			PakEntry pakEntry = Enumerable.FirstOrDefault<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)P_1.Values, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg() + fontName + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn(), (StringComparison)5)));
			if ((object)pakEntry != null)
			{
				LegacyPackage legacyPackage = MeshTextRoad.A(P_0, pakEntry, decompressor);
				if (legacyPackage != null && ((global::System.Collections.Generic.IReadOnlyCollection<LegacyExport>)legacyPackage.Exports).Count != 0 && !(legacyPackage.ClassOf(legacyPackage.Exports[0]) != _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ht()))
				{
					string text = Enumerable.FirstOrDefault<string>(Enumerable.Select<ValueTuple<int, string>, string>(new MeshTextRoad.A(pakEntry.Path, legacyPackage, legacyPackage, string.Empty, P_4).a(), (Func<ValueTuple<int, string>, string>)((ValueTuple<int, string> g) => g.Item2)), (Func<string, bool>)((string P_0) => P_0.Length > 0));
					if (text == null)
					{
						return null;
					}
					string text2 = A(pakEntry.Path, text);
					PakEntry pakEntry2 = default(PakEntry);
					if (P_1.TryGetValue(text2, ref pakEntry2))
					{
						LegacyPackage legacyPackage2 = MeshTextRoad.A(P_0, pakEntry2, decompressor);
						if (legacyPackage2 != null)
						{
							MeshTextRoad.A a = new MeshTextRoad.A(pakEntry.Path, legacyPackage, legacyPackage2, text2.Substring(0, text2.LastIndexOf('/')), P_4);
							P_5[fontName] = a;
							return a;
						}
					}
					return null;
				}
			}
			return null;
		}

		public LetterModel? A(int P_0)
		{
			LetterModel letterModel = default(LetterModel);
			if (!_measured.TryGetValue(P_0, ref letterModel))
			{
				letterModel = (_arabic.Has(P_0) ? LetterModel.Of(_arabic, P_0, _scale) : null);
				_measured[P_0] = letterModel;
			}
			if ((object)letterModel != null && !_has.Contains(P_0))
			{
				Letters[P_0] = letterModel;
			}
			return letterModel;
		}

		public double A(string P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return Enumerable.Sum<Rune>((global::System.Collections.Generic.IEnumerable<Rune>)(object)P_0.EnumerateRunes(), (Func<Rune, double>)([CompilerGenerated] (Rune P_0) => a(((Rune)(ref P_0)).Value)?.Advance ?? Space));
		}

		private LetterModel? a(int P_0)
		{
			LetterModel letterModel = default(LetterModel);
			if (!_measured.TryGetValue(P_0, ref letterModel))
			{
				letterModel = (_arabic.Has(P_0) ? LetterModel.Of(_arabic, P_0, _scale) : null);
				_measured[P_0] = letterModel;
			}
			return letterModel;
		}

		public string B(int P_0)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(14, 2);
			defaultInterpolatedStringHandler.AppendFormatted(_letterFolder);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HU());
			defaultInterpolatedStringHandler.AppendFormatted<int>(100000 + P_0);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn());
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		public byte[] A()
		{
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			LegacyExport legacyExport = _font.Exports[0];
			LegacyProperty legacyProperty = Enumerable.First<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)_font.PropertiesOf(legacyExport), (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hs()));
			global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>> readOnlyList = _font.StructArray(legacyProperty);
			global::System.Collections.Generic.IReadOnlyList<LegacyProperty> readOnlyList2 = readOnlyList[0];
			int tagStart = readOnlyList2[0].TagStart;
			int num = ((((global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>>)readOnlyList).Count > 1) ? readOnlyList[1][0].TagStart : (legacyProperty.ValueStart + legacyProperty.Size));
			byte[] array = MemoryExtensions.AsSpan<byte>(_font.Bytes, tagStart, num - tagStart).ToArray();
			List<byte> val = new List<byte>();
			global::System.Collections.Generic.IEnumerator<KeyValuePair<int, LetterModel>> enumerator = ((global::System.Collections.Generic.IEnumerable<KeyValuePair<int, LetterModel>>)Enumerable.OrderBy<KeyValuePair<int, LetterModel>, int>((global::System.Collections.Generic.IEnumerable<KeyValuePair<int, LetterModel>>)Letters, (Func<KeyValuePair<int, LetterModel>, int>)((KeyValuePair<int, LetterModel> P_0) => P_0.Key))).GetEnumerator();
			try
			{
				int num2 = default(int);
				LetterModel letterModel = default(LetterModel);
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					enumerator.Current.Deconstruct(ref num2, ref letterModel);
					int num3 = num2;
					LetterModel letterModel2 = letterModel;
					val.AddRange((global::System.Collections.Generic.IEnumerable<byte>)A(array, readOnlyList2, tagStart, num3, letterModel2));
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			List<byte> val2 = Enumerable.ToList<byte>((global::System.Collections.Generic.IEnumerable<byte>)MemoryExtensions.AsSpan<byte>(_font.Bytes, (int)legacyExport.SerialOffset, (int)legacyExport.SerialSize).ToArray());
			int num4 = legacyProperty.ValueStart + legacyProperty.Size - (int)legacyExport.SerialOffset;
			val2.InsertRange(num4, (global::System.Collections.Generic.IEnumerable<byte>)val);
			A(val2, legacyProperty.ValueStart - (int)legacyExport.SerialOffset, ((global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>>)readOnlyList).Count + Letters.Count);
			A(val2, legacyProperty.SizeField - (int)legacyExport.SerialOffset, legacyProperty.Size + val.Count);
			return _font.WithExport(legacyExport, global::System.ReadOnlySpan<byte>.op_Implicit(val2.ToArray())).Bytes;
		}

		private byte[] A(byte[] P_0, global::System.Collections.Generic.IReadOnlyList<LegacyProperty> P_1, int P_2, int P_3, LetterModel P_4)
		{
			List<byte> val = Enumerable.ToList<byte>((global::System.Collections.Generic.IEnumerable<byte>)P_0);
			byte[] array = LegacyPackage.EncodeString(a(B(P_3)) ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa());
			global::System.Collections.Generic.IEnumerator<LegacyProperty> enumerator = ((global::System.Collections.Generic.IEnumerable<LegacyProperty>)Enumerable.OrderByDescending<LegacyProperty, int>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)P_1, (Func<LegacyProperty, int>)((LegacyProperty P_0) => P_0.ValueStart))).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					LegacyProperty current = enumerator.Current;
					int num = current.ValueStart - P_2;
					string name = current.Name;
					if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hu()))
					{
						if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HV()))
						{
							if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hv()))
							{
								if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HW()))
								{
									if (!(name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hw()))
									{
										if (name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HX())
										{
											val.RemoveRange(num, current.Size);
											val.InsertRange(num, (global::System.Collections.Generic.IEnumerable<byte>)array);
											A(val, current.SizeField - P_2, array.Length);
										}
									}
									else
									{
										A(val, num, (float)((P_4.Advance - P_4.Right) / (double)Em));
									}
								}
								else
								{
									A(val, num, (float)(P_4.Left / (double)Em));
								}
							}
							else
							{
								A(val, num, (float)((0.0 - P_4.Bottom) / (double)Em));
							}
						}
						else
						{
							A(val, num, (float)(P_4.Advance / (double)Em));
						}
					}
					else
					{
						A(val, num, P_3);
					}
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			return val.ToArray();
		}

		[IteratorStateMachine(typeof(c))]
		private global::System.Collections.Generic.IEnumerable<ValueTuple<int, string>> a()
		{
			LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)_font.PropertiesOf(_font.Exports[0]), (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hs()));
			if ((object)legacyProperty == null)
			{
				yield break;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>> enumerator = ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IReadOnlyList<LegacyProperty>>)_font.StructArray(legacyProperty)).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					global::System.Collections.Generic.IReadOnlyList<LegacyProperty> current = enumerator.Current;
					LegacyProperty legacyProperty2 = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)current, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hu()));
					LegacyProperty legacyProperty3 = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)current, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HX()));
					yield return new ValueTuple<int, string>(((object)legacyProperty2 == null) ? (-1) : BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(_font.Bytes, legacyProperty2.ValueStart))), ((object)legacyProperty3 == null) ? string.Empty : _font.StringAt(legacyProperty3.ValueStart));
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
		}

		private static string A(string P_0, string P_1)
		{
			string text = P_1.Split('.', (StringSplitOptions)0)[0];
			string text2 = P_0.Substring(0, P_0.IndexOf(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gG(), (StringComparison)5) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hx().Length);
			if (!text.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Eh(), (StringComparison)4))
			{
				return text.TrimStart('/') + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn();
			}
			string text3 = text;
			int length = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HY().Length;
			return text2 + text3.Substring(length, text3.Length - length) + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn();
		}

		private static string a(string P_0)
		{
			int num = P_0.IndexOf(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.gG(), (StringComparison)5);
			string text = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HY();
			string text2 = P_0;
			int num2 = num + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hx().Length;
			int length = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dn().Length;
			string text3 = (text2 = text + text2.Substring(num2, text2.Length - length - num2));
			length = text3.LastIndexOf('/') + 1;
			string text4 = text2.Substring(length, text2.Length - length);
			return text3 + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BC() + text4;
		}

		private static void A(List<byte> P_0, int P_1, int P_2)
		{
			byte[] bytes = BitConverter.GetBytes(P_2);
			for (int i = 0; i < 4; i++)
			{
				P_0[P_1 + i] = bytes[i];
			}
		}

		private static void A(List<byte> P_0, int P_1, float P_2)
		{
			byte[] bytes = BitConverter.GetBytes(P_2);
			for (int i = 0; i < 4; i++)
			{
				P_0[P_1 + i] = bytes[i];
			}
		}

		[CompilerGenerated]
		internal static float A(string P_0, float P_1, ref B P_2, ref b P_3)
		{
			string name = P_0;
			LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)P_3.props, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == name));
			if ((object)legacyProperty == null)
			{
				return P_1;
			}
			return BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(P_2.font.Bytes, legacyProperty.ValueStart)));
		}

		[CompilerGenerated]
		private double A(Rune P_0)
		{
			return a(((Rune)(ref P_0)).Value)?.Advance ?? Space;
		}
	}

	[CompilerGenerated]
	private static class a
	{
		public static Func<string, bool> _003C0_003E__HasMeshFonts;

		public static Func<char, bool> _003C1_003E__IsLetter;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B
	{
		public static readonly B _003C_003E9 = new B();

		public static Func<PakEntry, bool> _003C_003E9__9_0;

		public static Func<LegacyProperty, bool> _003C_003E9__10_0;

		public static Func<KeyValuePair<string, string>, bool> _003C_003E9__11_0;

		public static Func<KeyValuePair<string, string>, ValueTuple<string[], string>> _003C_003E9__11_1;

		public static Func<ValueTuple<string[], string>, bool> _003C_003E9__11_2;

		public static Func<ValueTuple<string[], string>, string> _003C_003E9__11_3;

		public static Func<IGrouping<string, ValueTuple<string[], string>>, string> _003C_003E9__11_4;

		public static Func<ValueTuple<string[], string>, string> _003C_003E9__11_6;

		public static Func<ValueTuple<string[], string>, string> _003C_003E9__11_7;

		public static Func<IGrouping<string, ValueTuple<string[], string>>, Dictionary<string, string>> _003C_003E9__11_5;

		public static Func<PakEntry, string> _003C_003E9__11_8;

		public static Func<LegacyProperty, bool> _003C_003E9__11_9;

		public static Func<A, bool> _003C_003E9__11_10;

		public static Func<LegacyProperty, bool> _003C_003E9__12_1;

		public static Func<LegacyProperty, bool> _003C_003E9__12_3;

		public static Func<ValueTuple<float, float, float>, float> _003C_003E9__12_4;

		public static Func<string, string> _003C_003E9__12_7;

		public static Func<string, bool> _003C_003E9__12_8;

		public static Func<LegacyProperty, bool> _003C_003E9__12_5;

		public static Func<ValueTuple<LegacyProperty, byte[]>, int> _003C_003E9__12_9;

		public static Func<char, char> _003C_003E9__13_0;

		public static Func<PakEntry, bool> _003C_003E9__16_0;

		internal bool A(PakEntry P_0)
		{
			return P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DO(), (StringComparison)5);
		}

		internal bool A(LegacyProperty P_0)
		{
			return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hy();
		}

		internal bool A(KeyValuePair<string, string> P_0)
		{
			return IsMeshTextKey(P_0.Key);
		}

		internal ValueTuple<string[], string> a(KeyValuePair<string, string> P_0)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			string key = P_0.Key;
			int length = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dh().Length;
			return new ValueTuple<string[], string>(key.Substring(length, key.Length - length).Split('|', 2, (StringSplitOptions)0), P_0.Value);
		}

		internal bool A(ValueTuple<string[], string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return t.Item1.Length == 2;
		}

		internal string a(ValueTuple<string[], string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return t.Item1[0];
		}

		internal string A(IGrouping<string, ValueTuple<string[], string>> g)
		{
			return g.Key;
		}

		internal Dictionary<string, string> a(IGrouping<string, ValueTuple<string[], string>> g)
		{
			return Enumerable.ToDictionary<ValueTuple<string[], string>, string, string>((global::System.Collections.Generic.IEnumerable<ValueTuple<string[], string>>)g, (Func<ValueTuple<string[], string>, string>)((ValueTuple<string[], string> t) => t.Item1[1]), (Func<ValueTuple<string[], string>, string>)((ValueTuple<string[], string> t) => t.Item2), (IEqualityComparer<string>)(object)StringComparer.Ordinal);
		}

		internal string B(ValueTuple<string[], string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return t.Item1[1];
		}

		internal string b(ValueTuple<string[], string> t)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return t.Item2;
		}

		internal string a(PakEntry P_0)
		{
			return P_0.Path;
		}

		internal bool a(LegacyProperty P_0)
		{
			return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GK();
		}

		internal bool A(A P_0)
		{
			return P_0.Letters.Count > 0;
		}

		internal bool B(LegacyProperty P_0)
		{
			return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HZ();
		}

		internal bool b(LegacyProperty P_0)
		{
			return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hz();
		}

		internal float A(ValueTuple<float, float, float> p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return p.Item2;
		}

		internal string A(string P_0)
		{
			return P_0.Trim();
		}

		internal bool a(string P_0)
		{
			return P_0.Length > 0;
		}

		internal bool C(LegacyProperty P_0)
		{
			return P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hy();
		}

		internal int A(ValueTuple<LegacyProperty, byte[]> P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return P_0.Item1.ValueStart;
		}

		internal char A(char P_0)
		{
			if (P_0 < '\u0080' || P_0 > '\u009f')
			{
				return P_0;
			}
			return MeshTextRoad.A(P_0);
		}

		internal bool B(PakEntry P_0)
		{
			return P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hA(), (StringComparison)5);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public global::System.Collections.Generic.IReadOnlyList<LegacyProperty> properties;

		public byte[] bytes;

		public LegacyProperty positions;

		internal float A(string P_0, float P_1)
		{
			C CS_0024_003C_003E8__locals0 = new C
			{
				name = P_0
			};
			LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)properties, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == CS_0024_003C_003E8__locals0.name));
			if ((object)legacyProperty == null)
			{
				return P_1;
			}
			return BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, legacyProperty.ValueStart)));
		}

		internal ValueTuple<float, float, float> A(int P_0)
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<float, float, float>(BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, positions.ValueStart + 4 + 12 * P_0))), BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, positions.ValueStart + 8 + 12 * P_0))), BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(bytes, positions.ValueStart + 12 + 12 * P_0))));
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public string name;

		internal bool A(LegacyProperty P_0)
		{
			return P_0.Name == name;
		}
	}

	public const string KeyPrefix = "meshtext#";

	private const double ArabicSize = 1.35;

	private const int ModelNumberBase = 100000;

	private const string SourceLayoutPrefix = "TextLayout_en-US";

	private static readonly Regex Harakat = new Regex(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dm(), (RegexOptions)8);

	internal const long LargestLevel = 268435456L;

	public static string KeyOf(MeshTextLine line)
	{
		return _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dh() + line.Package + _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DI() + line.Layout;
	}

	public static bool IsMeshTextKey(string key)
	{
		return key.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dh(), (StringComparison)4);
	}

	public static bool Available(UnrealGameLayout layout)
	{
		return Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)layout.Packages, (Func<string, bool>)B);
	}

	public static global::System.Collections.Generic.IReadOnlyList<MeshTextLine> Read(UnrealGameLayout layout, IPakDecompressor? decompressor)
	{
		ArgumentNullException.ThrowIfNull((object)layout, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CQ());
		List<MeshTextLine> val = new List<MeshTextLine>();
		try
		{
			A(val, layout, decompressor);
			return (global::System.Collections.Generic.IReadOnlyList<MeshTextLine>)val;
		}
		finally
		{
			EngineNotes.Now(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa());
		}
	}

	private static void A(List<MeshTextLine> P_0, UnrealGameLayout P_1, IPakDecompressor? decompressor)
	{
		global::System.Collections.Generic.IEnumerator<string> enumerator = Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)P_1.Packages, (Func<string, bool>)B).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				using PakArchive pakArchive = PakArchive.Open(current);
				global::System.Collections.Generic.IEnumerator<PakEntry> enumerator2 = Enumerable.Where<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)pakArchive.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DO(), (StringComparison)5))).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						PakEntry current2 = enumerator2.Current;
						EngineNotes.Now(global::System.FormattableString.Invariant(FormattableStringFactory.Create(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Di(), new object[3]
						{
							current2.Path,
							current2.UncompressedSize,
							Path.GetFileName(current)
						})));
						LegacyPackage legacyPackage = A(pakArchive, current2, decompressor);
						if (legacyPackage == null)
						{
							continue;
						}
						global::System.Collections.Generic.IEnumerator<LegacyExport> enumerator3 = ((global::System.Collections.Generic.IEnumerable<LegacyExport>)legacyPackage.Exports).GetEnumerator();
						try
						{
							while (((global::System.Collections.IEnumerator)enumerator3).MoveNext())
							{
								LegacyExport current3 = enumerator3.Current;
								if (current3.Name.StartsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DJ(), (StringComparison)4) && !(legacyPackage.ClassOf(current3) != _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dj()))
								{
									string text = A(legacyPackage, current3);
									if (text != null)
									{
										P_0.Add(new MeshTextLine(current2.Path, current3.Name, text));
									}
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator3)?.Dispose();
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static string? A(LegacyPackage P_0, LegacyExport P_1)
	{
		try
		{
			LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)P_0.PropertiesOf(P_1), (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hy()));
			return ((object)legacyProperty == null) ? null : A(P_0.StringAt(legacyProperty.ValueStart));
		}
		catch (global::System.Exception ex) when (((ex is InvalidDataException || ex is ArgumentException || ex is IndexOutOfRangeException || ex is OverflowException) ? 1 : 0) != 0)
		{
			return null;
		}
	}

	public static Dictionary<string, byte[]> Write(UnrealGameLayout layout, IPakDecompressor? decompressor, IReadOnlyDictionary<string, string> translationsByKey, string arabicFont)
	{
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)layout, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CQ());
		ArgumentNullException.ThrowIfNull((object)translationsByKey, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DK());
		Dictionary<string, byte[]> val = new Dictionary<string, byte[]>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		List<KeyValuePair<string, string>> val2 = Enumerable.ToList<KeyValuePair<string, string>>(Enumerable.Where<KeyValuePair<string, string>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)translationsByKey, (Func<KeyValuePair<string, string>, bool>)((KeyValuePair<string, string> P_0) => IsMeshTextKey(P_0.Key))));
		if (val2.Count == 0)
		{
			return val;
		}
		FontMetrics fontMetrics = FontMetrics.Load(arabicFont);
		Dictionary<string, Dictionary<string, string>> val3 = Enumerable.ToDictionary<IGrouping<string, ValueTuple<string[], string>>, string, Dictionary<string, string>>(Enumerable.GroupBy<ValueTuple<string[], string>, string>(Enumerable.Where<ValueTuple<string[], string>>(Enumerable.Select<KeyValuePair<string, string>, ValueTuple<string[], string>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)val2, (Func<KeyValuePair<string, string>, ValueTuple<string[], string>>)delegate(KeyValuePair<string, string> P_0)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			string key = P_0.Key;
			int length = _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dh().Length;
			return new ValueTuple<string[], string>(key.Substring(length, key.Length - length).Split('|', 2, (StringSplitOptions)0), P_0.Value);
		}), (Func<ValueTuple<string[], string>, bool>)((ValueTuple<string[], string> t) => t.Item1.Length == 2)), (Func<ValueTuple<string[], string>, string>)((ValueTuple<string[], string> t) => t.Item1[0]), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase), (Func<IGrouping<string, ValueTuple<string[], string>>, string>)((IGrouping<string, ValueTuple<string[], string>> g) => g.Key), (Func<IGrouping<string, ValueTuple<string[], string>>, Dictionary<string, string>>)((IGrouping<string, ValueTuple<string[], string>> g) => Enumerable.ToDictionary<ValueTuple<string[], string>, string, string>((global::System.Collections.Generic.IEnumerable<ValueTuple<string[], string>>)g, (Func<ValueTuple<string[], string>, string>)((ValueTuple<string[], string> t) => t.Item1[1]), (Func<ValueTuple<string[], string>, string>)((ValueTuple<string[], string> t) => t.Item2), (IEqualityComparer<string>)(object)StringComparer.Ordinal)), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		global::System.Collections.Generic.IEnumerator<string> enumerator = Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)layout.Packages, (Func<string, bool>)B).GetEnumerator();
		try
		{
			string text = default(string);
			Dictionary<string, string> val6 = default(Dictionary<string, string>);
			PakEntry pakEntry = default(PakEntry);
			string text3 = default(string);
			int num = default(int);
			LetterModel letterModel = default(LetterModel);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				using PakArchive pakArchive = PakArchive.Open(enumerator.Current);
				Dictionary<string, PakEntry> val4 = Enumerable.ToDictionary<PakEntry, string>((global::System.Collections.Generic.IEnumerable<PakEntry>)pakArchive.Entries, (Func<PakEntry, string>)((PakEntry P_0) => P_0.Path), (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
				Dictionary<string, A> val5 = new Dictionary<string, A>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
				Enumerator<string, Dictionary<string, string>> enumerator2 = val3.GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						enumerator2.Current.Deconstruct(ref text, ref val6);
						string text2 = text;
						Dictionary<string, string> val7 = val6;
						if (!val4.TryGetValue(text2, ref pakEntry))
						{
							continue;
						}
						LegacyPackage legacyPackage = A(pakArchive, pakEntry, decompressor);
						if (legacyPackage == null)
						{
							continue;
						}
						Enumerator<LegacyExport> enumerator3 = Enumerable.ToList<LegacyExport>((global::System.Collections.Generic.IEnumerable<LegacyExport>)legacyPackage.Exports).GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								LegacyExport current = enumerator3.Current;
								if (!val7.TryGetValue(current.Name, ref text3))
								{
									continue;
								}
								LegacyExport legacyExport = legacyPackage.Exports[current.Index];
								global::System.Collections.Generic.IReadOnlyList<LegacyProperty> readOnlyList = legacyPackage.PropertiesOf(legacyExport);
								LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)readOnlyList, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GK()));
								string text4 = (((object)legacyProperty != null) ? legacyPackage.ObjectName(BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(legacyPackage.Bytes, legacyProperty.ValueStart)))) : null);
								if (text4 != null)
								{
									A a = MeshTextRoad.A.A(pakArchive, val4, text4, decompressor, fontMetrics, val5);
									if (a != null)
									{
										legacyPackage = A(legacyPackage, legacyExport, readOnlyList, Harakat.Replace(text3, string.Empty), a);
									}
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						val[text2] = legacyPackage.Bytes;
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator2).Dispose();
				}
				global::System.Collections.Generic.IEnumerator<A> enumerator4 = Enumerable.Where<A>((global::System.Collections.Generic.IEnumerable<A>)val5.Values, (Func<A, bool>)((A P_0) => P_0.Letters.Count > 0)).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator4).MoveNext())
					{
						A current2 = enumerator4.Current;
						val[current2.EntryPath] = current2.A();
						Enumerator<int, LetterModel> enumerator5 = current2.Letters.GetEnumerator();
						try
						{
							while (enumerator5.MoveNext())
							{
								enumerator5.Current.Deconstruct(ref num, ref letterModel);
								int num2 = num;
								LetterModel model = letterModel;
								val[current2.B(num2)] = LetterPackage.Write(current2.Template, model, 100000 + num2);
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator5).Dispose();
						}
					}
				}
				finally
				{
					((global::System.IDisposable)enumerator4)?.Dispose();
				}
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private static LegacyPackage A(LegacyPackage P_0, LegacyExport P_1, global::System.Collections.Generic.IReadOnlyList<LegacyProperty> P_2, string P_3, A P_4)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		b CS_0024_003C_003E8__locals0 = new b();
		CS_0024_003C_003E8__locals0.properties = P_2;
		CS_0024_003C_003E8__locals0.bytes = P_0.Bytes;
		CS_0024_003C_003E8__locals0.positions = Enumerable.First<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)CS_0024_003C_003E8__locals0.properties, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.HZ()));
		List<ValueTuple<float, float, float>> val = Enumerable.ToList<ValueTuple<float, float, float>>(Enumerable.Select<int, ValueTuple<float, float, float>>(Enumerable.Range(0, BinaryPrimitives.ReadInt32LittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(CS_0024_003C_003E8__locals0.bytes, CS_0024_003C_003E8__locals0.positions.ValueStart)))), (Func<int, ValueTuple<float, float, float>>)((int P_0) => new ValueTuple<float, float, float>(BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(CS_0024_003C_003E8__locals0.bytes, CS_0024_003C_003E8__locals0.positions.ValueStart + 4 + 12 * P_0))), BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(CS_0024_003C_003E8__locals0.bytes, CS_0024_003C_003E8__locals0.positions.ValueStart + 8 + 12 * P_0))), BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(CS_0024_003C_003E8__locals0.bytes, CS_0024_003C_003E8__locals0.positions.ValueStart + 12 + 12 * P_0)))))));
		float num = ((val.Count > 0) ? val[0].Item1 : 2.5f);
		float num2 = CS_0024_003C_003E8__locals0.A(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dk(), 1f);
		LegacyProperty legacyProperty = Enumerable.FirstOrDefault<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)CS_0024_003C_003E8__locals0.properties, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hz()));
		float num3 = (((object)legacyProperty != null) ? (BinaryPrimitives.ReadSingleLittleEndian(global::System.Span<byte>.op_Implicit(MemoryExtensions.AsSpan<byte>(CS_0024_003C_003E8__locals0.bytes, legacyProperty.ValueStart))) / num2) : ((val.Count > 0) ? (Enumerable.Max<ValueTuple<float, float, float>>((global::System.Collections.Generic.IEnumerable<ValueTuple<float, float, float>>)val, (Func<ValueTuple<float, float, float>, float>)((ValueTuple<float, float, float> p) => p.Item2)) + 40f) : 1500f));
		List<string> val2 = new List<string>();
		global::System.Collections.Generic.IEnumerator<string> enumerator = Enumerable.Where<string>(Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)P_3.Split(new char[2] { '\r', '\n' }), (Func<string, string>)((string P_0) => P_0.Trim())), (Func<string, bool>)((string P_0) => P_0.Length > 0)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				List<string> val3 = new List<string>();
				string[] array = current.Split(' ', (StringSplitOptions)1);
				foreach (string text in array)
				{
					if (val3.Count > 0 && P_4.A(a(string.Join<string>(' ', Enumerable.Append<string>((global::System.Collections.Generic.IEnumerable<string>)val3, text)))) > (double)num3)
					{
						val2.Add(string.Join<string>(' ', (global::System.Collections.Generic.IEnumerable<string>)val3));
						val3.Clear();
					}
					val3.Add(text);
				}
				if (val3.Count > 0)
				{
					val2.Add(string.Join<string>(' ', (global::System.Collections.Generic.IEnumerable<string>)val3));
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		List<ValueTuple<float, float, float>> val4 = new List<ValueTuple<float, float, float>>();
		List<string> val5 = new List<string>();
		for (int j = 0; j < val2.Count; j++)
		{
			string text2 = a(val2[j]);
			val5.Add(text2);
			double num4 = Math.Max((double)num3 - P_4.A(text2), 0.0);
			StringRuneEnumerator val6 = text2.EnumerateRunes();
			StringRuneEnumerator enumerator2 = ((StringRuneEnumerator)(ref val6)).GetEnumerator();
			try
			{
				while (((StringRuneEnumerator)(ref enumerator2)).MoveNext())
				{
					Rune current2 = ((StringRuneEnumerator)(ref enumerator2)).Current;
					LetterModel letterModel = P_4.A(((Rune)(ref current2)).Value);
					if ((object)letterModel == null)
					{
						num4 += P_4.Space;
						continue;
					}
					val4.Add(new ValueTuple<float, float, float>(num, (float)(num4 + letterModel.CentreX), (float)((double)(0f - P_4.BaseLine - (float)j * P_4.LineStep) + letterModel.CentreY)));
					num4 += letterModel.Advance;
				}
			}
			finally
			{
				((global::System.IDisposable)(StringRuneEnumerator)(ref enumerator2)).Dispose();
			}
		}
		byte[] array2 = LegacyPackage.EncodeString(string.Join<string>('\r', (global::System.Collections.Generic.IEnumerable<string>)val5));
		byte[] array3 = new byte[4 + 12 * val4.Count];
		BinaryPrimitives.WriteInt32LittleEndian(global::System.Span<byte>.op_Implicit(array3), val4.Count);
		for (int k = 0; k < val4.Count; k++)
		{
			BinaryPrimitives.WriteSingleLittleEndian(MemoryExtensions.AsSpan<byte>(array3, 4 + 12 * k), val4[k].Item1);
			BinaryPrimitives.WriteSingleLittleEndian(MemoryExtensions.AsSpan<byte>(array3, 8 + 12 * k), val4[k].Item2);
			BinaryPrimitives.WriteSingleLittleEndian(MemoryExtensions.AsSpan<byte>(array3, 12 + 12 * k), val4[k].Item3);
		}
		List<byte> val7 = Enumerable.ToList<byte>((global::System.Collections.Generic.IEnumerable<byte>)MemoryExtensions.AsSpan<byte>(CS_0024_003C_003E8__locals0.bytes, (int)P_1.SerialOffset, (int)P_1.SerialSize).ToArray());
		LegacyProperty legacyProperty2 = Enumerable.First<LegacyProperty>((global::System.Collections.Generic.IEnumerable<LegacyProperty>)CS_0024_003C_003E8__locals0.properties, (Func<LegacyProperty, bool>)((LegacyProperty P_0) => P_0.Name == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Hy()));
		global::System.Collections.Generic.IEnumerator<ValueTuple<LegacyProperty, byte[]>> enumerator3 = ((global::System.Collections.Generic.IEnumerable<ValueTuple<LegacyProperty, byte[]>>)Enumerable.OrderByDescending<ValueTuple<LegacyProperty, byte[]>, int>((global::System.Collections.Generic.IEnumerable<ValueTuple<LegacyProperty, byte[]>>)new ValueTuple<LegacyProperty, byte[]>[2]
		{
			new ValueTuple<LegacyProperty, byte[]>(legacyProperty2, array2),
			new ValueTuple<LegacyProperty, byte[]>(CS_0024_003C_003E8__locals0.positions, array3)
		}, (Func<ValueTuple<LegacyProperty, byte[]>, int>)((ValueTuple<LegacyProperty, byte[]> P_0) => P_0.Item1.ValueStart))).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator3).MoveNext())
			{
				ValueTuple<LegacyProperty, byte[]> current3 = enumerator3.Current;
				LegacyProperty item = current3.Item1;
				byte[] item2 = current3.Item2;
				int num5 = item.ValueStart - (int)P_1.SerialOffset;
				val7.RemoveRange(num5, item.Size);
				val7.InsertRange(num5, (global::System.Collections.Generic.IEnumerable<byte>)item2);
				int num6 = item.SizeField - (int)P_1.SerialOffset;
				byte[] bytes = BitConverter.GetBytes(item2.Length);
				for (int l = 0; l < 4; l++)
				{
					val7[num6 + l] = bytes[l];
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator3)?.Dispose();
		}
		return P_0.WithExport(P_1, global::System.ReadOnlySpan<byte>.op_Implicit(val7.ToArray()));
	}

	private static string? A(string P_0)
	{
		string text = new string(Enumerable.ToArray<char>(Enumerable.Select<char, char>((global::System.Collections.Generic.IEnumerable<char>)P_0, (Func<char, char>)((char P_0) => (P_0 < '\u0080' || P_0 > '\u009f') ? P_0 : A(P_0))))).Trim();
		if (Enumerable.Count<char>((global::System.Collections.Generic.IEnumerable<char>)text, (Func<char, bool>)char.IsLetter) < 2)
		{
			return null;
		}
		return text;
	}

	private static char A(char P_0)
	{
		return P_0 switch
		{
			'\u0091' => '‘', 
			'\u0092' => '’', 
			'\u0093' => '“', 
			'\u0094' => '”', 
			'\u0096' => '–', 
			'\u0097' => '—', 
			'\u0085' => '…', 
			_ => ' ', 
		};
	}

	private static string a(string P_0)
	{
		return ArabicVisualOrder.ToVisual(ArabicShaper.Shape(P_0));
	}

	private static bool B(string P_0)
	{
		try
		{
			using PakArchive pakArchive = PakArchive.Open(P_0);
			return !pakArchive.IndexEncrypted && Enumerable.Any<PakEntry>((global::System.Collections.Generic.IEnumerable<PakEntry>)pakArchive.Entries, (Func<PakEntry, bool>)((PakEntry P_0) => P_0.Path.EndsWith(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hA(), (StringComparison)5)));
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException) ? 1 : 0) != 0)
		{
			return false;
		}
	}

	private static LegacyPackage? A(PakArchive P_0, PakEntry P_1, IPakDecompressor? decompressor)
	{
		long uncompressedSize = P_1.UncompressedSize;
		if ((uncompressedSize <= 0 || uncompressedSize > 268435456) ? true : false)
		{
			EngineNotes.Say(global::System.FormattableString.Invariant(FormattableStringFactory.Create(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DL(), new object[2] { P_1.Path, P_1.UncompressedSize })));
			return null;
		}
		try
		{
			byte[] array = P_0.Read(P_1, decompressor);
			return LegacyPackage.LooksLikeOne(global::System.ReadOnlySpan<byte>.op_Implicit(array)) ? LegacyPackage.Read(array) : null;
		}
		catch (global::System.Exception ex) when (((ex is IOException || ex is InvalidDataException || ex is NotSupportedException || ex is ArgumentException || ex is IndexOutOfRangeException || ex is OverflowException || ex is OutOfMemoryException) ? 1 : 0) != 0)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(24, 3);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Dl());
			defaultInterpolatedStringHandler.AppendFormatted(P_1.Path);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.DM());
			defaultInterpolatedStringHandler.AppendFormatted(((MemberInfo)ex.GetType()).Name);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.cm());
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			EngineNotes.Say(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}
	}
}
