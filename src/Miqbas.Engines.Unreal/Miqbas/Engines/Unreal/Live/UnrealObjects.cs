using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BF4362644_002D78A3_002D44A2_002D9C1A_002DF3B48FABB101_007D;

namespace Miqbas.Engines.Unreal.Live;

public sealed class UnrealObjects
{
	[CompilerGenerated]
	private sealed class A : global::System.Collections.Generic.IEnumerable<LiveObject>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<LiveObject>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private LiveObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UnrealObjects _003C_003E4__this;

		private ProcessMemory memory;

		public ProcessMemory _003C_003E3__memory;

		private LiveObjectArray array;

		public LiveObjectArray _003C_003E3__array;

		private global::System.Collections.Generic.IEnumerator<ulong> _003C_003E7__wrap1;

		LiveObject global::System.Collections.Generic.IEnumerator<LiveObject>.Current
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
		public A(int P_0)
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
			try
			{
				int num = _003C_003E1__state;
				UnrealObjects unrealObjects = _003C_003E4__this;
				switch (num)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = unrealObjects.Pointers(memory, array).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (((global::System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
				{
					ulong current = _003C_003E7__wrap1.Current;
					LiveObject? liveObject = unrealObjects.Describe(memory, current);
					if (liveObject.HasValue)
					{
						_003C_003E2__current = liveObject.Value;
						_003C_003E1__state = 1;
						return true;
					}
				}
				a();
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
		private global::System.Collections.Generic.IEnumerator<LiveObject> b()
		{
			A a;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				a = this;
			}
			else
			{
				a = new A(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			a.memory = _003C_003E3__memory;
			a.array = _003C_003E3__array;
			return a;
		}

		global::System.Collections.Generic.IEnumerator<LiveObject> global::System.Collections.Generic.IEnumerable<LiveObject>.GetEnumerator()
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

	[CompilerGenerated]
	private sealed class a : global::System.Collections.Generic.IEnumerable<ulong>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<ulong>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int _003C_003E1__state;

		private ulong _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private ProcessMemory memory;

		public ProcessMemory _003C_003E3__memory;

		private LiveObjectArray array;

		public LiveObjectArray _003C_003E3__array;

		private int _003Cremaining_003E5__2;

		private int _003CchunkIndex_003E5__3;

		private int _003CinThisChunk_003E5__4;

		private byte[] _003Cbytes_003E5__5;

		private int _003Cat_003E5__6;

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
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_014b;
			}
			_003C_003E1__state = -1;
			ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
			ArgumentNullException.ThrowIfNull((object)array, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bv());
			_003Cremaining_003E5__2 = array.Count;
			_003CchunkIndex_003E5__3 = 0;
			goto IL_019f;
			IL_018f:
			_003CchunkIndex_003E5__3++;
			goto IL_019f;
			IL_0163:
			if (_003Cat_003E5__6 + 8 <= _003Cbytes_003E5__5.Length)
			{
				ulong num2 = BitConverter.ToUInt64(_003Cbytes_003E5__5, _003Cat_003E5__6);
				if (num2 != 0L)
				{
					_003C_003E2__current = num2;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_014b;
			}
			_003Cremaining_003E5__2 -= _003CinThisChunk_003E5__4;
			_003Cbytes_003E5__5 = null;
			goto IL_018f;
			IL_019f:
			if (_003CchunkIndex_003E5__3 < ((global::System.Collections.Generic.IReadOnlyCollection<ulong>)array.Chunks).Count && _003Cremaining_003E5__2 > 0)
			{
				_003CinThisChunk_003E5__4 = Math.Min(_003Cremaining_003E5__2, 65536);
				_003Cbytes_003E5__5 = new byte[_003CinThisChunk_003E5__4 * array.ItemStride];
				if (memory.TryReadBytes(array.Chunks[_003CchunkIndex_003E5__3], _003Cbytes_003E5__5) != _003Cbytes_003E5__5.Length)
				{
					_003Cbytes_003E5__5 = UnrealObjects.A(memory, array.Chunks[_003CchunkIndex_003E5__3], _003Cbytes_003E5__5.Length, array.ItemStride);
					if (_003Cbytes_003E5__5.Length == 0)
					{
						_003Cremaining_003E5__2 -= _003CinThisChunk_003E5__4;
						goto IL_018f;
					}
				}
				_003Cat_003E5__6 = 0;
				goto IL_0163;
			}
			return false;
			IL_014b:
			_003Cat_003E5__6 += array.ItemStride;
			goto IL_0163;
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
			a.memory = _003C_003E3__memory;
			a.array = _003C_003E3__array;
			return a;
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

	private const int ClassOffset = 16;

	private const int NameOffset = 24;

	private const int OuterOffset = 32;

	private readonly IReadOnlyDictionary<uint, string> _names;

	public UnrealObjects(IReadOnlyDictionary<uint, string> namesById)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_names = namesById ?? throw new ArgumentNullException(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eN());
	}

	public LiveObject? Describe(ProcessMemory memory, ulong address)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		if (address <= 65536 || address >= 140737488355327L)
		{
			return null;
		}
		byte[] array = new byte[40];
		if (memory.TryReadBytes(address, array) != array.Length)
		{
			return null;
		}
		string text = A(array, 24);
		if (text == null)
		{
			return null;
		}
		ulong num = BitConverter.ToUInt64(array, 16);
		if (num <= 65536 || num >= 140737488355327L)
		{
			return null;
		}
		byte[] array2 = new byte[40];
		if (memory.TryReadBytes(num, array2) != array2.Length)
		{
			return null;
		}
		string text2 = A(array2, 24);
		if (text2 != null)
		{
			return new LiveObject(address, text, text2, num);
		}
		return null;
	}

	public ulong OuterOf(ProcessMemory memory, ulong address)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		byte[] array = new byte[40];
		if (memory.TryReadBytes(address, array) != array.Length)
		{
			return 0uL;
		}
		return BitConverter.ToUInt64(array, 32);
	}

	public static uint? NameIdOf(ProcessMemory memory, ulong address)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		if (address <= 65536 || address >= 140737488355327L)
		{
			return null;
		}
		byte[] array = new byte[28];
		if (memory.TryReadBytes(address, array) != array.Length)
		{
			return null;
		}
		return BitConverter.ToUInt32(array, 24);
	}

	private string? A(byte[] P_0, int P_1)
	{
		uint num = BitConverter.ToUInt32(P_0, P_1);
		string text = default(string);
		if (!_names.TryGetValue(num, ref text))
		{
			return null;
		}
		uint num2 = BitConverter.ToUInt32(P_0, P_1 + 4);
		if (num2 != 0)
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(_856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.By());
			defaultInterpolatedStringHandler.AppendFormatted<uint>(num2 - 1);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	[IteratorStateMachine(typeof(A))]
	public global::System.Collections.Generic.IEnumerable<LiveObject> All(ProcessMemory memory, LiveObjectArray array)
	{
		global::System.Collections.Generic.IEnumerator<ulong> enumerator = Pointers(memory, array).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ulong current = enumerator.Current;
				LiveObject? liveObject = Describe(memory, current);
				if (liveObject.HasValue)
				{
					yield return liveObject.Value;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
	}

	[IteratorStateMachine(typeof(a))]
	public global::System.Collections.Generic.IEnumerable<ulong> Pointers(ProcessMemory memory, LiveObjectArray array)
	{
		ArgumentNullException.ThrowIfNull((object)memory, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.eo());
		ArgumentNullException.ThrowIfNull((object)array, _856A536D_002D231A_002D4E25_002D9AF8_002D9391176C4B15.Bv());
		int remaining = array.Count;
		for (int chunkIndex = 0; chunkIndex < ((global::System.Collections.Generic.IReadOnlyCollection<ulong>)array.Chunks).Count && remaining > 0; chunkIndex++)
		{
			int inThisChunk = Math.Min(remaining, 65536);
			byte[] bytes = new byte[inThisChunk * array.ItemStride];
			if (memory.TryReadBytes(array.Chunks[chunkIndex], bytes) != bytes.Length)
			{
				bytes = A(memory, array.Chunks[chunkIndex], bytes.Length, array.ItemStride);
				if (bytes.Length == 0)
				{
					remaining -= inThisChunk;
					continue;
				}
			}
			for (int at = 0; at + 8 <= bytes.Length; at += array.ItemStride)
			{
				ulong num = BitConverter.ToUInt64(bytes, at);
				if (num != 0L)
				{
					yield return num;
				}
			}
			remaining -= inThisChunk;
		}
	}

	private static byte[] A(ProcessMemory P_0, ulong P_1, int P_2, int P_3)
	{
		byte[] array = new byte[4096];
		List<byte> val = new List<byte>(P_2);
		for (int i = 0; i < P_2 && P_0.TryReadBytes(P_1 + (ulong)i, array) == array.Length; i += array.Length)
		{
			val.AddRange((global::System.Collections.Generic.IEnumerable<byte>)array);
		}
		int num = val.Count - val.Count % P_3;
		List<byte> obj = new List<byte>();
		obj.AddRange(Enumerable.Take<byte>((global::System.Collections.Generic.IEnumerable<byte>)val, num));
		return obj.ToArray();
	}
}
