using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public static class ReflectionCalibrator
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A _003C_003E9 = new A();

		public static Func<List<ulong>, global::System.Collections.Generic.IEnumerable<ulong>> _003C_003E9__10_0;

		internal global::System.Collections.Generic.IEnumerable<ulong> A(List<ulong> P_0)
		{
			return (global::System.Collections.Generic.IEnumerable<ulong>)P_0;
		}
	}

	[CompilerGenerated]
	private sealed class a
	{
		public ProcessMemory memory;

		public int offset;

		public Func<ulong, bool> _003C_003E9__0;

		internal bool A(ulong P_0)
		{
			return ReflectionCalibrator.A(memory, P_0 + (ulong)offset) == 0;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public List<ulong> parents;

		public a CS_0024_003C_003E8__locals1;

		internal bool A(ulong P_0)
		{
			ulong num = ReflectionCalibrator.A(CS_0024_003C_003E8__locals1.memory, P_0 + (ulong)CS_0024_003C_003E8__locals1.offset);
			return parents.Contains(num);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public ProcessMemory memory;

		public int at;

		public Func<ulong, bool> _003C_003E9__0;

		internal bool A(ulong P_0)
		{
			return a(memory, P_0 + (ulong)at) == 40;
		}
	}

	[CompilerGenerated]
	private sealed class C : global::System.Collections.Generic.IEnumerable<ulong>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<ulong>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private ulong _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private ProcessMemory memory;

		public ProcessMemory _003C_003E3__memory;

		private ulong owner;

		public ulong _003C_003E3__owner;

		private int where;

		public int _003C_003E3__where;

		private int next;

		public int _003C_003E3__next;

		private ulong _003Cat_003E5__2;

		private int _003Cseen_003E5__3;

		private HashSet<ulong> _003Cvisited_003E5__4;

		ulong global::System.Collections.Generic.IEnumerator<ulong>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object global::System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public C(int P_0)
		{
			_003C_003E1__state = P_0;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void A()
		{
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Cat_003E5__2 = ReflectionCalibrator.A(memory, owner + (ulong)where);
				_003Cseen_003E5__3 = 0;
				_003Cvisited_003E5__4 = new HashSet<ulong>();
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Cat_003E5__2 = ReflectionCalibrator.A(memory, _003Cat_003E5__2 + (ulong)next);
				break;
			}
			if (ReflectionCalibrator.A(_003Cat_003E5__2) && _003Cseen_003E5__3++ < 400 && _003Cvisited_003E5__4.Add(_003Cat_003E5__2))
			{
				_003C_003E2__current = _003Cat_003E5__2;
				_003C_003E1__state = 1;
				return true;
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void a()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a
			this.a();
		}

		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<ulong> B()
		{
			C c;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				c = this;
			}
			else
			{
				c = new C(0);
			}
			c.memory = _003C_003E3__memory;
			c.owner = _003C_003E3__owner;
			c.where = _003C_003E3__where;
			c.next = _003C_003E3__next;
			return c;
		}

		global::System.Collections.Generic.IEnumerator<ulong> global::System.Collections.Generic.IEnumerable<ulong>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in B
			return this.B();
		}

		[DebuggerHidden]
		private global::System.Collections.IEnumerator b()
		{
			return (global::System.Collections.IEnumerator)B();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b
			return this.b();
		}
	}

	private const int Sample = 600;

	private const int LongestChain = 400;

	private const int LargestStruct = 262144;

	private const int ObjectSize = 40;

	private static readonly ValueTuple<string, string>[] KnownDescent = new ValueTuple<string, string>[25]
	{
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fx(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FY(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fx()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fy(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FY()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FZ(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fx()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fz(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FZ()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fA(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fa(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fA()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FN(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fa()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FX(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fa()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fB(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fa()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fb(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fA()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fC(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fc(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fD(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fc()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fd(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fD()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fE(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fe(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fE()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fF(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fe()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ff(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fe()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fG(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fg(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fH(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.R(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fh(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fI()),
		new ValueTuple<string, string>(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fi(), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fI())
	};

	private static readonly HashSet<string> PropertyTypes;

	private static readonly Dictionary<string, int> KnownSizes;

	public static bool IsPropertyType(string name)
	{
		return PropertyTypes.Contains(name);
	}

	public static Dictionary<string, List<ulong>> ClassesByName(global::System.Collections.Generic.IEnumerable<LiveObject> objects)
	{
		ArgumentNullException.ThrowIfNull((object)objects, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fm());
		Dictionary<string, List<ulong>> val = new Dictionary<string, List<ulong>>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		global::System.Collections.Generic.IEnumerator<LiveObject> enumerator = objects.GetEnumerator();
		try
		{
			List<ulong> val2 = default(List<ulong>);
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LiveObject current = enumerator.Current;
				if (string.Equals(current.ClassName, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FN(), (StringComparison)4))
				{
					if (!val.TryGetValue(current.Name, ref val2))
					{
						val2 = new List<ulong>();
						val[current.Name] = val2;
					}
					val2.Add(current.Address);
				}
			}
			return val;
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	public static ReflectionLayout? Calibrate(ProcessMemory memory, IReadOnlyDictionary<string, List<ulong>> classes, IReadOnlyDictionary<uint, string> names, Action<string>? say = null)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)classes, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fn());
		ArgumentNullException.ThrowIfNull((object)names, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FO());
		List<CalibrationScore> val = new List<CalibrationScore>();
		CalibrationScore calibrationScore = A(memory, classes);
		val.Add(calibrationScore);
		if (calibrationScore.Agreed < 8 || calibrationScore.Share < 0.6)
		{
			if (say != null)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(35, 2);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fo());
				defaultInterpolatedStringHandler.AppendFormatted<int>(calibrationScore.Agreed);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg());
				defaultInterpolatedStringHandler.AppendFormatted<int>(calibrationScore.Tried);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bo());
				say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return null;
		}
		List<ulong> val2 = A(classes);
		ValueTuple<CalibrationScore, CalibrationScore, CalibrationScore, bool> val3 = A(memory, classes, val2, names);
		val.Add(val3.Item1);
		val.Add(val3.Item2);
		val.Add(val3.Item3);
		if (val3.Item1.Agreed < 20)
		{
			if (say != null)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(38, 2);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FP());
				defaultInterpolatedStringHandler.AppendFormatted<int>(val3.Item1.Agreed);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg());
				defaultInterpolatedStringHandler.AppendFormatted<int>(val3.Item1.Tried);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bo());
				say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return null;
		}
		CalibrationScore calibrationScore2 = a(memory, val2, names, val3.Item1.Chosen, val3.Item2.Chosen, val3.Item4);
		val.Add(calibrationScore2);
		CalibrationScore calibrationScore3 = A(memory, val2, names, val3.Item1.Chosen, val3.Item2.Chosen, calibrationScore2.Chosen, val3.Item4);
		val.Add(calibrationScore3);
		CalibrationScore calibrationScore4 = A(memory, val2, names, val3.Item1.Chosen, val3.Item2.Chosen, calibrationScore2.Chosen, val3.Item3.Chosen, calibrationScore.Chosen, val3.Item4);
		val.Add(calibrationScore4);
		if (calibrationScore4.Agreed < 20)
		{
			if (say != null)
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(36, 2);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fp());
				defaultInterpolatedStringHandler.AppendFormatted<int>(calibrationScore4.Agreed);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Cg());
				defaultInterpolatedStringHandler.AppendFormatted<int>(calibrationScore4.Tried);
				defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bo());
				say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return null;
		}
		CalibrationScore item = val3.Item3;
		CalibrationScore calibrationScore5 = a(memory, val2, names, val3.Item1.Chosen, val3.Item2.Chosen, calibrationScore2.Chosen, val3.Item4);
		val.Add(calibrationScore5);
		CalibrationScore calibrationScore6 = B(memory, val2, names, val3.Item1.Chosen, val3.Item2.Chosen, calibrationScore2.Chosen, val3.Item4);
		val.Add(calibrationScore6);
		ReflectionLayout result = new ReflectionLayout(calibrationScore.Chosen, val3.Item1.Chosen, item.Chosen, val3.Item2.Chosen, calibrationScore2.Chosen, calibrationScore3.Chosen, calibrationScore4.Chosen, calibrationScore5.Chosen, calibrationScore6.Chosen, val3.Item4)
		{
			Scores = (global::System.Collections.Generic.IReadOnlyList<CalibrationScore>)val
		};
		Enumerator<CalibrationScore> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				CalibrationScore current = enumerator.Current;
				if (say != null)
				{
					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(19, 4);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FQ());
					defaultInterpolatedStringHandler.AppendFormatted(current.What);
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fq());
					defaultInterpolatedStringHandler.AppendFormatted<int>(current.Chosen, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eq());
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FR());
					defaultInterpolatedStringHandler.AppendFormatted<int>(current.Agreed, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
					defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fr());
					defaultInterpolatedStringHandler.AppendFormatted<int>(current.Tried, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CW());
					say.Invoke(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			return result;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	private static List<ulong> A(IReadOnlyDictionary<string, List<ulong>> P_0)
	{
		List<ulong> obj = new List<ulong>();
		obj.AddRange(Enumerable.Take<ulong>(Enumerable.SelectMany<List<ulong>, ulong>(P_0.Values, (Func<List<ulong>, global::System.Collections.Generic.IEnumerable<ulong>>)((List<ulong> P_0) => (global::System.Collections.Generic.IEnumerable<ulong>)P_0)), 600));
		return obj;
	}

	private static CalibrationScore A(ProcessMemory P_0, IReadOnlyDictionary<string, List<ulong>> P_1)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		ProcessMemory memory = P_0;
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FS(), 0, 0, 0);
		int offset;
		List<ulong> val2 = default(List<ulong>);
		List<ulong> parents = default(List<ulong>);
		List<ulong> val3 = default(List<ulong>);
		for (offset = 40; offset <= 152; offset += 8)
		{
			int num = 0;
			int num2 = 0;
			ValueTuple<string, string>[] knownDescent = KnownDescent;
			for (int i = 0; i < knownDescent.Length; i++)
			{
				ValueTuple<string, string> val = knownDescent[i];
				string item = val.Item1;
				string item2 = val.Item2;
				if (P_1.TryGetValue(item, ref val2) && P_1.TryGetValue(item2, ref parents))
				{
					num2++;
					if (Enumerable.Any<ulong>((global::System.Collections.Generic.IEnumerable<ulong>)val2, (Func<ulong, bool>)delegate(ulong P_0)
					{
						ulong num3 = A(memory, P_0 + (ulong)offset);
						return parents.Contains(num3);
					}))
					{
						num++;
					}
				}
			}
			if (P_1.TryGetValue(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs(), ref val3))
			{
				num2++;
				if (Enumerable.Any<ulong>((global::System.Collections.Generic.IEnumerable<ulong>)val3, (Func<ulong, bool>)((ulong P_0) => A(memory, P_0 + (ulong)offset) == 0)))
				{
					num++;
				}
			}
			if (num > result.Agreed)
			{
				result = new CalibrationScore(result.What, offset, num, num2);
			}
		}
		return result;
	}

	private static ValueTuple<CalibrationScore, CalibrationScore, CalibrationScore, bool> A(ProcessMemory P_0, IReadOnlyDictionary<string, List<ulong>> P_1, List<ulong> P_2, IReadOnlyDictionary<uint, string> P_3)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		CalibrationScore calibrationScore = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FT(), 0, 0, 0);
		CalibrationScore calibrationScore2 = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Ft(), 0, 0, 0);
		CalibrationScore calibrationScore3 = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FU(), 0, 0, 0);
		bool flag = true;
		for (int i = 40; i <= 176; i += 8)
		{
			CalibrationScore calibrationScore4 = A(P_0, P_1, i);
			if (calibrationScore4.Agreed == 0)
			{
				continue;
			}
			int[] array = new int[3];
			RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int[] array2 = array;
			foreach (int num in array2)
			{
				ValueTuple<int, int> val = A(P_0, P_2, P_3, i, num, true);
				int item = val.Item1;
				int item2 = val.Item2;
				if (item > calibrationScore.Agreed)
				{
					calibrationScore = new CalibrationScore(calibrationScore.What, i, item, item2);
					calibrationScore2 = new CalibrationScore(calibrationScore2.What, num, item, item2);
					calibrationScore3 = calibrationScore4;
					flag = true;
				}
			}
			ValueTuple<int, int> val2 = A(P_0, P_2, P_3, i, 16, false);
			int item3 = val2.Item1;
			int item4 = val2.Item2;
			if (item3 > calibrationScore.Agreed)
			{
				calibrationScore = new CalibrationScore(calibrationScore.What, i, item3, item4);
				calibrationScore2 = new CalibrationScore(calibrationScore2.What, 16, item3, item4);
				calibrationScore3 = calibrationScore4;
				flag = false;
			}
		}
		return new ValueTuple<CalibrationScore, CalibrationScore, CalibrationScore, bool>(calibrationScore, calibrationScore2, calibrationScore3, flag);
	}

	private static ValueTuple<int, int> A(ProcessMemory P_0, List<ulong> P_1, IReadOnlyDictionary<uint, string> P_2, int P_3, int P_4, bool P_5)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		Enumerator<ulong> enumerator = P_1.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ulong current = enumerator.Current;
				ulong num3 = A(P_0, current + (ulong)P_3);
				if (A(num3))
				{
					num2++;
					string text = A(P_0, P_2, num3, P_4, P_5);
					if (text != null && PropertyTypes.Contains(text))
					{
						num++;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
		return new ValueTuple<int, int>(num, num2);
	}

	private static string? A(ProcessMemory P_0, IReadOnlyDictionary<uint, string> P_1, ulong P_2, int P_3, bool P_4)
	{
		ulong num = A(P_0, P_2 + (ulong)P_3);
		if (!A(num))
		{
			return null;
		}
		ulong num2 = (P_4 ? num : (num + 24));
		return a(P_0, P_1, num2);
	}

	private static CalibrationScore a(ProcessMemory P_0, List<ulong> P_1, IReadOnlyDictionary<uint, string> P_2, int P_3, int P_4, bool P_5)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fu(), 0, 0, 0);
		int[] array = new int[5];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array2 = array;
		foreach (int num in array2)
		{
			int num2 = 0;
			int num3 = 0;
			Enumerator<ulong> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ulong current = enumerator.Current;
					global::System.Collections.Generic.IEnumerator<ulong> enumerator2 = A(P_0, current, P_3, num).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							ulong current2 = enumerator2.Current;
							num3++;
							string text = A(P_0, P_2, current2, P_4, P_5);
							if (text != null && PropertyTypes.Contains(text))
							{
								num2++;
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
				((global::System.IDisposable)enumerator).Dispose();
			}
			if (num2 > result.Agreed)
			{
				result = new CalibrationScore(result.What, num, num2, num3);
			}
		}
		return result;
	}

	private static CalibrationScore A(ProcessMemory P_0, List<ulong> P_1, IReadOnlyDictionary<uint, string> P_2, int P_3, int P_4, int P_5, bool P_6)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FV(), 0, 0, 0);
		int[] array = new int[4];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array2 = array;
		foreach (int num in array2)
		{
			int num2 = 0;
			int num3 = 0;
			Enumerator<ulong> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ulong current = enumerator.Current;
					HashSet<string> val = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
					global::System.Collections.Generic.IEnumerator<ulong> enumerator2 = A(P_0, current, P_3, P_5).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							ulong current2 = enumerator2.Current;
							string text = A(P_0, P_2, current2, P_4, P_6);
							if (text != null && PropertyTypes.Contains(text))
							{
								num3++;
								string text2 = a(P_0, P_2, current2 + (ulong)num);
								if (text2 != null && text2.Length > 0 && val.Add(text2))
								{
									num2++;
								}
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
				((global::System.IDisposable)enumerator).Dispose();
			}
			if (num2 > result.Agreed)
			{
				result = new CalibrationScore(result.What, num, num2, num3);
			}
		}
		return result;
	}

	private static CalibrationScore A(ProcessMemory P_0, IReadOnlyDictionary<string, List<ulong>> P_1, int P_2)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		ProcessMemory memory = P_0;
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FU(), 0, 0, 0);
		int at;
		List<ulong> val = default(List<ulong>);
		List<ulong> val3 = default(List<ulong>);
		List<ulong> val4 = default(List<ulong>);
		for (at = P_2 + 4; at <= P_2 + 32; at += 4)
		{
			if (!P_1.TryGetValue(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fs(), ref val) || !Enumerable.Any<ulong>((global::System.Collections.Generic.IEnumerable<ulong>)val, (Func<ulong, bool>)((ulong P_0) => a(memory, P_0 + (ulong)at) == 40)))
			{
				continue;
			}
			int num = 1;
			int num2 = 1;
			ValueTuple<string, string>[] knownDescent = KnownDescent;
			for (int i = 0; i < knownDescent.Length; i++)
			{
				ValueTuple<string, string> val2 = knownDescent[i];
				string item = val2.Item1;
				string item2 = val2.Item2;
				if (P_1.TryGetValue(item, ref val3) && P_1.TryGetValue(item2, ref val4))
				{
					num2++;
					int num3 = a(memory, val3[0] + (ulong)at);
					int num4 = a(memory, val4[0] + (ulong)at);
					if (num3 >= num4 && num3 > 0 && num3 < 262144)
					{
						num++;
					}
				}
			}
			if (num > result.Agreed)
			{
				result = new CalibrationScore(result.What, at, num, num2);
			}
		}
		return result;
	}

	private static CalibrationScore A(ProcessMemory P_0, List<ulong> P_1, IReadOnlyDictionary<uint, string> P_2, int P_3, int P_4, int P_5, int P_6, int P_7, bool P_8)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fv(), 0, 0, 0);
		int[] array = new int[9];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array2 = array;
		foreach (int num in array2)
		{
			int num2 = 0;
			int num3 = 0;
			Enumerator<ulong> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ulong current = enumerator.Current;
					int num4 = ((P_6 > 0) ? a(P_0, current + (ulong)P_6) : 262144);
					if ((num4 <= 0 || num4 > 262144) ? true : false)
					{
						continue;
					}
					ulong num5 = A(P_0, current + (ulong)P_7);
					int num6 = (A(num5) ? a(P_0, num5 + (ulong)P_6) : 0);
					if (num6 < 0 || num6 > num4)
					{
						continue;
					}
					global::System.Collections.Generic.IEnumerator<ulong> enumerator2 = A(P_0, current, P_3, P_5).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							ulong current2 = enumerator2.Current;
							string text = A(P_0, P_2, current2, P_4, P_8);
							if (text != null && PropertyTypes.Contains(text))
							{
								num3++;
								int num7 = a(P_0, current2 + (ulong)num);
								if (num7 >= num6 && num7 < num4)
								{
									num2++;
								}
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
				((global::System.IDisposable)enumerator).Dispose();
			}
			if (num2 > result.Agreed)
			{
				result = new CalibrationScore(result.What, num, num2, num3);
			}
		}
		return result;
	}

	private static CalibrationScore a(ProcessMemory P_0, List<ulong> P_1, IReadOnlyDictionary<uint, string> P_2, int P_3, int P_4, int P_5, bool P_6)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FW(), 0, 0, 0);
		int[] array = new int[7];
		RuntimeHelpers.InitializeArray((global::System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array2 = array;
		int num4 = default(int);
		foreach (int num in array2)
		{
			int num2 = 0;
			int num3 = 0;
			Enumerator<ulong> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ulong current = enumerator.Current;
					global::System.Collections.Generic.IEnumerator<ulong> enumerator2 = A(P_0, current, P_3, P_5).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							ulong current2 = enumerator2.Current;
							string text = A(P_0, P_2, current2, P_4, P_6);
							if (text != null && KnownSizes.TryGetValue(text, ref num4))
							{
								num3++;
								if (a(P_0, current2 + (ulong)num) == num4)
								{
									num2++;
								}
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
				((global::System.IDisposable)enumerator).Dispose();
			}
			if (num2 > result.Agreed)
			{
				result = new CalibrationScore(result.What, num, num2, num3);
			}
		}
		return result;
	}

	private static CalibrationScore B(ProcessMemory P_0, List<ulong> P_1, IReadOnlyDictionary<uint, string> P_2, int P_3, int P_4, int P_5, bool P_6)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		CalibrationScore result = new CalibrationScore(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Fw(), 0, 0, 0);
		for (int i = 72; i <= 160; i += 8)
		{
			int num = 0;
			int num2 = 0;
			Enumerator<ulong> enumerator = P_1.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ulong current = enumerator.Current;
					global::System.Collections.Generic.IEnumerator<ulong> enumerator2 = A(P_0, current, P_3, P_5).GetEnumerator();
					try
					{
						while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							ulong current2 = enumerator2.Current;
							string text = A(P_0, P_2, current2, P_4, P_6);
							if (text == null)
							{
								continue;
							}
							bool flag = string.Equals(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bs(), (StringComparison)4);
							bool flag2 = string.Equals(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq(), (StringComparison)4);
							if (!flag && !flag2)
							{
								continue;
							}
							num2++;
							ulong num3 = A(P_0, current2 + (ulong)i);
							if (!A(num3))
							{
								continue;
							}
							if (flag)
							{
								string text2 = A(P_0, P_2, num3, P_4, P_6);
								if (text2 != null && PropertyTypes.Contains(text2))
								{
									num++;
								}
							}
							else if (string.Equals(a(P_0, P_2, num3 + 24), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FX(), (StringComparison)4) || A(P_0, P_2, num3))
							{
								num++;
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
				((global::System.IDisposable)enumerator).Dispose();
			}
			if (num > result.Agreed)
			{
				result = new CalibrationScore(result.What, i, num, num2);
			}
		}
		return result;
	}

	private static bool A(ProcessMemory P_0, IReadOnlyDictionary<uint, string> P_1, ulong P_2)
	{
		ulong num = A(P_0, P_2 + 16);
		if (A(num))
		{
			return string.Equals(a(P_0, P_1, num + 24), _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FX(), (StringComparison)4);
		}
		return false;
	}

	[IteratorStateMachine(typeof(C))]
	private static global::System.Collections.Generic.IEnumerable<ulong> A(ProcessMemory P_0, ulong P_1, int P_2, int P_3)
	{
		ulong at = A(P_0, P_1 + (ulong)P_2);
		int seen = 0;
		HashSet<ulong> visited = new HashSet<ulong>();
		while (A(at) && seen++ < 400 && visited.Add(at))
		{
			yield return at;
			at = A(P_0, at + (ulong)P_3);
		}
	}

	internal static string? a(ProcessMemory P_0, IReadOnlyDictionary<uint, string> P_1, ulong P_2)
	{
		byte[] array = new byte[4];
		string result = default(string);
		if (P_0.TryReadBytes(P_2, array) != array.Length || !P_1.TryGetValue(BitConverter.ToUInt32(global::System.ReadOnlySpan<byte>.op_Implicit(array)), ref result))
		{
			return null;
		}
		return result;
	}

	internal static ulong A(ProcessMemory P_0, ulong P_1)
	{
		byte[] array = new byte[8];
		if (P_0.TryReadBytes(P_1, array) != array.Length)
		{
			return 0uL;
		}
		return BitConverter.ToUInt64(global::System.ReadOnlySpan<byte>.op_Implicit(array));
	}

	internal static int a(ProcessMemory P_0, ulong P_1)
	{
		byte[] array = new byte[4];
		if (P_0.TryReadBytes(P_1, array) != array.Length)
		{
			return -1;
		}
		return BitConverter.ToInt32(global::System.ReadOnlySpan<byte>.op_Implicit(array));
	}

	internal static bool A(ulong P_0)
	{
		if (P_0 > 65536 && P_0 < 140737488355327L)
		{
			return (P_0 & 7) == 0;
		}
		return false;
	}

	static ReflectionCalibrator()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		HashSet<string> obj = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.Ordinal);
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Br());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fJ());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fj());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fK());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fk());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fL());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fl());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fM());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fm());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fN());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BR());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fn());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fO());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fo());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fP());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fp());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fQ());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fq());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fR());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fr());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fS());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fs());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fT());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ft());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fU());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bs());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bt());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BT());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fu());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fV());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fv());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fW());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BS());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fw());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fX());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fx());
		obj.Add(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fY());
		PropertyTypes = obj;
		KnownSizes = new Dictionary<string, int>((IEqualityComparer<string>)(object)StringComparer.Ordinal)
		{
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BR()] = 1,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Br()] = 1,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fJ()] = 1,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fj()] = 2,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fL()] = 2,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fK()] = 4,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fl()] = 4,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fm()] = 4,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fk()] = 8,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fM()] = 8,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fN()] = 8,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fS()] = 8,
			[_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fs()] = 16
		};
	}
}
