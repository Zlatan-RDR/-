using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class UnrealReflection
{
	public readonly struct DescentStep : IEquatable<DescentStep>
	{
		[field: CompilerGenerated]
		public string Name
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int Own
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[field: CompilerGenerated]
		public int Size
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		public DescentStep(string Name, int Own, int Size)
		{
			this.Name = Name;
			this.Own = Own;
			this.Size = Size;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hg());
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
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bj());
			P_0.Append((object)Name);
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hH());
			P_0.Append(((object)Own).ToString());
			P_0.Append(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.BK());
			P_0.Append(((object)Size).ToString());
			return true;
		}

		[CompilerGenerated]
		public static bool operator !=(DescentStep left, DescentStep right)
		{
			return !(left == right);
		}

		[CompilerGenerated]
		public static bool operator ==(DescentStep left, DescentStep right)
		{
			return left.Equals(right);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<string>.Default.GetHashCode(Name) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Own)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Size);
		}

		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			if (obj is DescentStep)
			{
				return Equals((DescentStep)obj);
			}
			return false;
		}

		[CompilerGenerated]
		public bool Equals(DescentStep other)
		{
			if (EqualityComparer<string>.Default.Equals(Name, other.Name) && EqualityComparer<int>.Default.Equals(Own, other.Own))
			{
				return EqualityComparer<int>.Default.Equals(Size, other.Size);
			}
			return false;
		}

		[CompilerGenerated]
		public void Deconstruct(out string Name, out int Own, out int Size)
		{
			Name = this.Name;
			Own = this.Own;
			Size = this.Size;
		}
	}

	[CompilerGenerated]
	private sealed class a : global::System.Collections.Generic.IEnumerable<LiveProperty>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<LiveProperty>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private LiveProperty _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UnrealReflection _003C_003E4__this;

		private ulong structAddress;

		public ulong _003C_003E3__structAddress;

		private HashSet<ulong> _003Cseen_003E5__2;

		private int _003Ci_003E5__3;

		private ulong _003Cnext_003E5__4;

		LiveProperty global::System.Collections.Generic.IEnumerator<LiveProperty>.Current
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
		public a(int P_0)
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
			int num = _003C_003E1__state;
			UnrealReflection unrealReflection = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0113;
			}
			_003C_003E1__state = -1;
			ulong num2 = ReflectionCalibrator.A(unrealReflection._memory, structAddress + (ulong)unrealReflection._layout.ChildProperties);
			_003Cseen_003E5__2 = new HashSet<ulong>();
			_003Ci_003E5__3 = 0;
			goto IL_012c;
			IL_0113:
			num2 = _003Cnext_003E5__4;
			_003Ci_003E5__3++;
			goto IL_012c;
			IL_012c:
			if (_003Ci_003E5__3 < 2048 && ReflectionCalibrator.A(num2) && _003Cseen_003E5__2.Add(num2))
			{
				string text = unrealReflection.a(num2);
				_003Cnext_003E5__4 = ReflectionCalibrator.A(unrealReflection._memory, num2 + (ulong)unrealReflection._layout.FieldNext);
				if (text != null && ReflectionCalibrator.IsPropertyType(text))
				{
					string name = ReflectionCalibrator.a(unrealReflection._memory, unrealReflection._names, num2 + (ulong)unrealReflection._layout.FieldName) ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa();
					int num3 = ReflectionCalibrator.a(unrealReflection._memory, num2 + (ulong)unrealReflection._layout.ValueOffset);
					if (num3 >= 0)
					{
						_003C_003E2__current = new LiveProperty(name, text, num3, num2, ReflectionCalibrator.a(unrealReflection._memory, num2 + (ulong)unrealReflection._layout.ElementSize));
						_003C_003E1__state = 1;
						return true;
					}
				}
				goto IL_0113;
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
		private global::System.Collections.Generic.IEnumerator<LiveProperty> B()
		{
			a a;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				a = this;
			}
			else
			{
				a = new a(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			a.structAddress = _003C_003E3__structAddress;
			return a;
		}

		global::System.Collections.Generic.IEnumerator<LiveProperty> global::System.Collections.Generic.IEnumerable<LiveProperty>.GetEnumerator()
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

	[CompilerGenerated]
	private sealed class B : global::System.Collections.Generic.IEnumerable<DescentStep>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<DescentStep>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private DescentStep _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private ulong classAddress;

		public ulong _003C_003E3__classAddress;

		public UnrealReflection _003C_003E4__this;

		private HashSet<ulong> _003Cseen_003E5__2;

		private ulong _003Cat_003E5__3;

		private int _003Cdepth_003E5__4;

		DescentStep global::System.Collections.Generic.IEnumerator<DescentStep>.Current
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
		public B(int P_0)
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
			int num = _003C_003E1__state;
			UnrealReflection unrealReflection = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Cseen_003E5__2 = new HashSet<ulong>();
				_003Cat_003E5__3 = classAddress;
				_003Cdepth_003E5__4 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Cat_003E5__3 = ReflectionCalibrator.A(unrealReflection._memory, _003Cat_003E5__3 + (ulong)unrealReflection._layout.SuperStruct);
				_003Cdepth_003E5__4++;
				break;
			}
			if (_003Cdepth_003E5__4 < 64 && ReflectionCalibrator.A(_003Cat_003E5__3) && _003Cseen_003E5__2.Add(_003Cat_003E5__3))
			{
				string name = ReflectionCalibrator.a(unrealReflection._memory, unrealReflection._names, _003Cat_003E5__3 + 24) ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hh();
				_003C_003E2__current = new DescentStep(name, Enumerable.Count<LiveProperty>(unrealReflection.A(_003Cat_003E5__3)), ReflectionCalibrator.a(unrealReflection._memory, _003Cat_003E5__3 + (ulong)unrealReflection._layout.PropertiesSize));
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
		private global::System.Collections.Generic.IEnumerator<DescentStep> B()
		{
			B b;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				b = this;
			}
			else
			{
				b = new B(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			b.classAddress = _003C_003E3__classAddress;
			return b;
		}

		global::System.Collections.Generic.IEnumerator<DescentStep> global::System.Collections.Generic.IEnumerable<DescentStep>.GetEnumerator()
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

	private const int DeepestDescent = 64;

	private const int LongestChain = 2048;

	private readonly ProcessMemory _memory;

	private readonly ReflectionLayout _layout;

	private readonly IReadOnlyDictionary<uint, string> _names;

	private readonly Dictionary<ulong, global::System.Collections.Generic.IReadOnlyList<LiveProperty>> _known = new Dictionary<ulong, global::System.Collections.Generic.IReadOnlyList<LiveProperty>>();

	private readonly Dictionary<ulong, int> _sizes = new Dictionary<ulong, int>();

	public const string TextType = "TextProperty";

	public const string StringType = "StrProperty";

	private const int DeepestNesting = 5;

	private const int LongestArray = 4096;

	public ReflectionLayout Layout => _layout;

	public UnrealReflection(ProcessMemory memory, ReflectionLayout layout, IReadOnlyDictionary<uint, string> names)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		_memory = memory ?? throw new ArgumentNullException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		_layout = layout ?? throw new ArgumentNullException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.CQ());
		_names = names ?? throw new ArgumentNullException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.FO());
	}

	public global::System.Collections.Generic.IReadOnlyList<LiveProperty> PropertiesOf(ulong classAddress)
	{
		global::System.Collections.Generic.IReadOnlyList<LiveProperty> result = default(global::System.Collections.Generic.IReadOnlyList<LiveProperty>);
		if (_known.TryGetValue(classAddress, ref result))
		{
			return result;
		}
		List<LiveProperty> val = new List<LiveProperty>();
		HashSet<ulong> val2 = new HashSet<ulong>();
		ulong num = classAddress;
		for (int i = 0; i < 64; i++)
		{
			if (!ReflectionCalibrator.A(num))
			{
				break;
			}
			if (!val2.Add(num))
			{
				break;
			}
			global::System.Collections.Generic.IEnumerator<LiveProperty> enumerator = A(num).GetEnumerator();
			try
			{
				while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
				{
					LiveProperty current = enumerator.Current;
					val.Add(current);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator)?.Dispose();
			}
			num = ReflectionCalibrator.A(_memory, num + (ulong)_layout.SuperStruct);
		}
		_known[classAddress] = (global::System.Collections.Generic.IReadOnlyList<LiveProperty>)val;
		return (global::System.Collections.Generic.IReadOnlyList<LiveProperty>)val;
	}

	[IteratorStateMachine(typeof(B))]
	public global::System.Collections.Generic.IEnumerable<DescentStep> DescentOf(ulong classAddress)
	{
		HashSet<ulong> seen = new HashSet<ulong>();
		ulong at = classAddress;
		for (int depth = 0; depth < 64; depth++)
		{
			if (!ReflectionCalibrator.A(at))
			{
				break;
			}
			if (!seen.Add(at))
			{
				break;
			}
			string name = ReflectionCalibrator.a(_memory, _names, at + 24) ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.hh();
			yield return new DescentStep(name, Enumerable.Count<LiveProperty>(A(at)), ReflectionCalibrator.a(_memory, at + (ulong)_layout.PropertiesSize));
			at = ReflectionCalibrator.A(_memory, at + (ulong)_layout.SuperStruct);
		}
	}

	[IteratorStateMachine(typeof(a))]
	private global::System.Collections.Generic.IEnumerable<LiveProperty> A(ulong P_0)
	{
		ulong num = ReflectionCalibrator.A(_memory, P_0 + (ulong)_layout.ChildProperties);
		HashSet<ulong> seen = new HashSet<ulong>();
		for (int i = 0; i < 2048; i++)
		{
			if (!ReflectionCalibrator.A(num))
			{
				break;
			}
			if (!seen.Add(num))
			{
				break;
			}
			string text = a(num);
			ulong next = ReflectionCalibrator.A(_memory, num + (ulong)_layout.FieldNext);
			if (text != null && ReflectionCalibrator.IsPropertyType(text))
			{
				string name = ReflectionCalibrator.a(_memory, _names, num + (ulong)_layout.FieldName) ?? _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.aa();
				int num2 = ReflectionCalibrator.a(_memory, num + (ulong)_layout.ValueOffset);
				if (num2 >= 0)
				{
					yield return new LiveProperty(name, text, num2, num, ReflectionCalibrator.a(_memory, num + (ulong)_layout.ElementSize));
				}
			}
			num = next;
		}
	}

	private string? a(ulong P_0)
	{
		ulong num = ReflectionCalibrator.A(_memory, P_0 + (ulong)_layout.FieldClass);
		if (!ReflectionCalibrator.A(num))
		{
			return null;
		}
		ulong num2 = (_layout.Fields ? num : (num + 24));
		return ReflectionCalibrator.a(_memory, _names, num2);
	}

	public int SizeOf(ulong classAddress)
	{
		int result = default(int);
		if (_sizes.TryGetValue(classAddress, ref result))
		{
			return result;
		}
		int num = ReflectionCalibrator.a(_memory, classAddress + (ulong)_layout.PropertiesSize);
		_sizes[classAddress] = num;
		return num;
	}

	public string? BoundTextOf(LiveObject live)
	{
		global::System.Collections.Generic.IEnumerator<LiveProperty> enumerator = ((global::System.Collections.Generic.IEnumerable<LiveProperty>)PropertiesOf(live.ClassAddress)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LiveProperty current = enumerator.Current;
				if (current.Type.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fu(), (StringComparison)4) && current.Name.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gj(), (StringComparison)5))
				{
					string text = ReflectionCalibrator.a(_memory, _names, (ulong)((long)live.Address + (long)current.ValueOffset + 8));
					if (text != null && text.Length > 0 && !string.Equals(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.ay(), (StringComparison)4))
					{
						return text;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	public int? FontFieldOf(LiveObject live)
	{
		int? result = null;
		bool flag = false;
		global::System.Collections.Generic.IEnumerator<LiveProperty> enumerator = ((global::System.Collections.Generic.IEnumerable<LiveProperty>)PropertiesOf(live.ClassAddress)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LiveProperty current = enumerator.Current;
				if (string.Equals(current.Type, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fU(), (StringComparison)4))
				{
					flag = true;
				}
				else if (!result.HasValue && string.Equals(current.Type, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq(), (StringComparison)4) && current.Name.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GK(), (StringComparison)5))
				{
					result = current.ValueOffset;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		if (!flag)
		{
			return null;
		}
		return result;
	}

	public ulong FontUsedBy(LiveObject live)
	{
		int? num = FontFieldOf(live);
		if (num.HasValue)
		{
			int valueOrDefault = num.GetValueOrDefault();
			return PointedAt(live.Address + (ulong)valueOrDefault);
		}
		return 0uL;
	}

	public bool LendFontTo(LiveObject live, ulong font)
	{
		if (font != 0L)
		{
			int? num = FontFieldOf(live);
			if (num.HasValue)
			{
				int valueOrDefault = num.GetValueOrDefault();
				ulong address = live.Address + (ulong)valueOrDefault;
				ulong num2 = PointedAt(address);
				if (num2 != 0L && num2 != font && IsFontAsset(num2))
				{
					return _memory.WriteBytes(address, BitConverter.GetBytes(font));
				}
				return false;
			}
		}
		return false;
	}

	public bool IsFontAsset(ulong address)
	{
		ulong num = ReflectionCalibrator.A(_memory, address + 16);
		if (!ReflectionCalibrator.A(num))
		{
			return false;
		}
		return ReflectionCalibrator.a(_memory, _names, num + 24)?.Contains(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.GK(), (StringComparison)4) ?? false;
	}

	public ulong PointedAt(ulong address)
	{
		ulong num = ReflectionCalibrator.A(_memory, address);
		if (!ReflectionCalibrator.A(num))
		{
			return 0uL;
		}
		return num;
	}

	public List<LiveStrings.FoundString> TextIn(LiveObject live)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<ulong, LiveStrings.FoundString> val = new Dictionary<ulong, LiveStrings.FoundString>();
		A(live.ClassAddress, live.Address, val, 0);
		ValueCollection<ulong, LiveStrings.FoundString> values = val.Values;
		int count = values.Count;
		List<LiveStrings.FoundString> val2 = new List<LiveStrings.FoundString>(count);
		CollectionsMarshal.SetCount<LiveStrings.FoundString>(val2, count);
		global::System.Span<LiveStrings.FoundString> span = CollectionsMarshal.AsSpan<LiveStrings.FoundString>(val2);
		int num = 0;
		Enumerator<ulong, LiveStrings.FoundString> enumerator = values.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				LiveStrings.FoundString current = enumerator.Current;
				span[num] = current;
				num++;
			}
			return val2;
		}
		finally
		{
			((global::System.IDisposable)enumerator).Dispose();
		}
	}

	private void A(ulong P_0, ulong P_1, Dictionary<ulong, LiveStrings.FoundString> P_2, int P_3)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (P_3 > 5 || !ReflectionCalibrator.A(P_0))
		{
			return;
		}
		global::System.Collections.Generic.IEnumerator<LiveProperty> enumerator = ((global::System.Collections.Generic.IEnumerable<LiveProperty>)PropertiesOf(P_0)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LiveProperty current = enumerator.Current;
				ulong num = P_1 + (ulong)current.ValueOffset;
				string type = current.Type;
				if (!(type == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fU()))
				{
					if (!(type == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq()))
					{
						if (type == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bs())
						{
							A(current, num, P_2, P_3);
						}
					}
					else
					{
						A(A(current), num, P_2, P_3 + 1);
					}
					continue;
				}
				Enumerator<LiveStrings.FoundString> enumerator2 = LiveStrings.BehindText(_memory, num).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						LiveStrings.FoundString current2 = enumerator2.Current;
						P_2[current2.Field] = current2;
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
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void A(LiveProperty P_0, ulong P_1, Dictionary<ulong, LiveStrings.FoundString> P_2, int P_3)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		ulong num = A(P_0);
		if (!ReflectionCalibrator.A(num))
		{
			return;
		}
		string text = a(num);
		if ((!(text == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fU()) && !(text == _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq())) || 1 == 0)
		{
			return;
		}
		int num2 = ReflectionCalibrator.a(_memory, num + (ulong)_layout.ElementSize);
		if ((num2 <= 0 || num2 > 4096) ? true : false)
		{
			return;
		}
		byte[] array = new byte[16];
		if (_memory.TryReadBytes(P_1, array) != array.Length)
		{
			return;
		}
		ulong num3 = BitConverter.ToUInt64(array, 0);
		int num4 = BitConverter.ToInt32(array, 8);
		int num5 = BitConverter.ToInt32(array, 12);
		if (!ReflectionCalibrator.A(num3) || num4 <= 0 || num4 > num5 || num4 > 4096)
		{
			return;
		}
		ulong num6 = (string.Equals(text, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bq(), (StringComparison)4) ? ReflectionCalibrator.A(_memory, num + (ulong)_layout.Contained) : 0);
		for (int i = 0; i < num4; i++)
		{
			ulong num7 = num3 + (ulong)(i * num2);
			if (num6 != 0L)
			{
				A(num6, num7, P_2, P_3 + 1);
				continue;
			}
			Enumerator<LiveStrings.FoundString> enumerator = LiveStrings.BehindText(_memory, num7).GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					LiveStrings.FoundString current = enumerator.Current;
					P_2[current.Field] = current;
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
		}
	}

	private ulong A(LiveProperty P_0)
	{
		if (P_0.Address != 0L)
		{
			return ReflectionCalibrator.A(_memory, P_0.Address + (ulong)_layout.Contained);
		}
		return 0uL;
	}

	public List<LiveStrings.FoundString> ValuesOf(LiveObject live, string propertyType, int textWindow = 0)
	{
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)propertyType, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Gk());
		Dictionary<ulong, LiveStrings.FoundString> val = new Dictionary<ulong, LiveStrings.FoundString>();
		global::System.Collections.Generic.IEnumerator<LiveProperty> enumerator = ((global::System.Collections.Generic.IEnumerable<LiveProperty>)PropertiesOf(live.ClassAddress)).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LiveProperty current = enumerator.Current;
				if (!string.Equals(current.Type, propertyType, (StringComparison)4))
				{
					continue;
				}
				ulong address = live.Address + (ulong)current.ValueOffset;
				if (string.Equals(propertyType, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.fU(), (StringComparison)4))
				{
					Enumerator<LiveStrings.FoundString> enumerator2 = ((textWindow > 0) ? LiveStrings.BehindText(_memory, address, textWindow) : LiveStrings.BehindText(_memory, address)).GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							LiveStrings.FoundString current2 = enumerator2.Current;
							val[current2.Field] = current2;
						}
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
				}
				else
				{
					LiveStrings.FoundString? foundString = LiveStrings.At(_memory, address);
					if (foundString.HasValue)
					{
						LiveStrings.FoundString valueOrDefault = foundString.GetValueOrDefault();
						val[valueOrDefault.Field] = valueOrDefault;
					}
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		ValueCollection<ulong, LiveStrings.FoundString> values = val.Values;
		int count = values.Count;
		List<LiveStrings.FoundString> val2 = new List<LiveStrings.FoundString>(count);
		CollectionsMarshal.SetCount<LiveStrings.FoundString>(val2, count);
		global::System.Span<LiveStrings.FoundString> span = CollectionsMarshal.AsSpan<LiveStrings.FoundString>(val2);
		int num = 0;
		Enumerator<ulong, LiveStrings.FoundString> enumerator3 = values.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				LiveStrings.FoundString current3 = enumerator3.Current;
				span[num] = current3;
				num++;
			}
			return val2;
		}
		finally
		{
			((global::System.IDisposable)enumerator3).Dispose();
		}
	}
}
