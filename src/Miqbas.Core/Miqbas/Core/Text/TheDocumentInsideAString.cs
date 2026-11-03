using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Translation;

namespace Miqbas.Core.Text;

public static class TheDocumentInsideAString
{
	[RequiredMember]
	private sealed class A : IEquatable<A>
	{
		[CompilerGenerated]
		private System.Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(A);
			}
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public string Path
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public string Field
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public string Value
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public int Start
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[RequiredMember]
		[field: CompilerGenerated]
		public int Length
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			init;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ry());
			val.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.o());
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
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@is());
			P_0.Append((object)Path);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.On());
			P_0.Append((object)Field);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Fk());
			P_0.Append((object)Value);
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iT());
			P_0.Append(((object)Start).ToString());
			P_0.Append(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.it());
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
			return ((((EqualityComparer<System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Field)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Start)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Length);
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
				if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other.Path) && EqualityComparer<string>.Default.Equals(Field, other.Field) && EqualityComparer<string>.Default.Equals(Value, other.Value) && EqualityComparer<int>.Default.Equals(Start, other.Start))
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
		[SetsRequiredMembers]
		private A(A P_0)
		{
			Path = P_0.Path;
			Field = P_0.Field;
			Value = P_0.Value;
			Start = P_0.Start;
			Length = P_0.Length;
		}

		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public A()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Converter<A, ValueTuple<string, string>> _003C_003E9__1_0;

		public static Func<A, int> _003C_003E9__3_1;

		internal ValueTuple<string, string> A(A x)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, string>(x.Path, x.Value);
		}

		internal int a(A P_0)
		{
			return P_0.Start;
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public string path;

		internal bool A(A P_0)
		{
			return P_0.Path == path;
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public IReadOnlyDictionary<string, string> byPath;

		internal bool A(A P_0)
		{
			return byPath.ContainsKey(P_0.Path);
		}
	}

	public const string Inside = "::";

	public static System.Collections.Generic.IReadOnlyList<ALineInADocument> LinesIn(string document)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)document, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iv());
		List<A> val = A(document);
		if (val == null || val.Count <= 0)
		{
			return System.Array.Empty<ALineInADocument>();
		}
		HashSet<string> val2 = ARowIsOneSentenceInManyLanguages.WhatTheOtherLanguagesHold((System.Collections.Generic.IReadOnlyCollection<ValueTuple<string, string>>)val.ConvertAll<ValueTuple<string, string>>((Converter<A, ValueTuple<string, string>>)((A x) => new ValueTuple<string, string>(x.Path, x.Value))));
		List<ALineInADocument> val3 = new List<ALineInADocument>();
		Enumerator<A> enumerator = val.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				A current = enumerator.Current;
				if (!val2.Contains(current.Path) && ALineAPlayerReads.Is(current.Value, current.Field) && !Untranslatable.Is(current.Value))
				{
					val3.Add(new ALineInADocument(current.Path, current.Value));
				}
			}
			return (System.Collections.Generic.IReadOnlyList<ALineInADocument>)val3;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public static string? WhatIsAt(string document, string path)
	{
		string path2 = path;
		ArgumentNullException.ThrowIfNull((object)document, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iv());
		ArgumentNullException.ThrowIfNull((object)path2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.HU());
		List<A>? obj = A(document);
		if (obj == null)
		{
			return null;
		}
		return Enumerable.FirstOrDefault<A>((System.Collections.Generic.IEnumerable<A>)obj, (Func<A, bool>)((A P_0) => P_0.Path == path2))?.Value;
	}

	public static string Write(string document, IReadOnlyDictionary<string, string> byPath)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		IReadOnlyDictionary<string, string> byPath2 = byPath;
		ArgumentNullException.ThrowIfNull((object)document, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iv());
		ArgumentNullException.ThrowIfNull((object)byPath2, EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iu());
		if (((System.Collections.Generic.IReadOnlyCollection<KeyValuePair<string, string>>)byPath2).Count != 0)
		{
			List<A> val = A(document);
			if (val != null && val.Count > 0)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(document);
				List<A> val2 = Enumerable.ToList<A>((System.Collections.Generic.IEnumerable<A>)Enumerable.OrderByDescending<A, int>(Enumerable.Where<A>((System.Collections.Generic.IEnumerable<A>)val, (Func<A, bool>)((A P_0) => byPath2.ContainsKey(P_0.Path))), (Func<A, int>)((A P_0) => P_0.Start)));
				if (val2.Count == 0)
				{
					return document;
				}
				List<byte> val3 = new List<byte>(bytes.Length + val2.Count * 16);
				val3.AddRange((System.Collections.Generic.IEnumerable<byte>)bytes);
				Enumerator<A> enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						A current = enumerator.Current;
						byte[] bytes2 = Encoding.UTF8.GetBytes(a(byPath2[current.Path]));
						val3.RemoveRange(current.Start, current.Length);
						val3.InsertRange(current.Start, (System.Collections.Generic.IEnumerable<byte>)bytes2);
					}
				}
				finally
				{
					((System.IDisposable)enumerator).Dispose();
				}
				return Encoding.UTF8.GetString(new System.ReadOnlySpan<byte>(val3.ToArray()));
			}
		}
		return document;
	}

	private unsafe static List<A>? A(string P_0)
	{
		System.ReadOnlySpan<char> readOnlySpan = MemoryExtensions.Trim(MemoryExtensions.AsSpan(P_0));
		if (readOnlySpan.Length < 2 || (*(ushort*)readOnlySpan[0] != 123 && *(ushort*)readOnlySpan[0] != 91))
		{
			return null;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		List<A> val = new List<A>();
		List<string> val2 = new List<string>();
		List<int> val3 = new List<int>();
		string text = null;
		try
		{
			Utf8JsonReader utf8JsonReader = new Utf8JsonReader(System.ReadOnlySpan<byte>.op_Implicit(bytes), new JsonReaderOptions
			{
				AllowTrailingCommas = true
			});
			while (utf8JsonReader.Read())
			{
				switch (utf8JsonReader.TokenType)
				{
				case JsonTokenType.PropertyName:
					text = utf8JsonReader.GetString();
					break;
				case JsonTokenType.StartObject:
				case JsonTokenType.StartArray:
					val2.Add(A(text, val3));
					val3.Add((utf8JsonReader.TokenType != JsonTokenType.StartArray) ? (-1) : 0);
					text = null;
					break;
				case JsonTokenType.EndObject:
				case JsonTokenType.EndArray:
					if (val2.Count > 0)
					{
						val2.RemoveAt(val2.Count - 1);
						val3.RemoveAt(val3.Count - 1);
					}
					A(val3);
					text = null;
					break;
				case JsonTokenType.String:
				{
					string text2 = text ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
					int num = (int)utf8JsonReader.TokenStartIndex;
					int num2 = A(bytes, num);
					if (num2 > 0)
					{
						val.Add(new A
						{
							Path = A(val2, val3, text2),
							Field = text2,
							Value = (utf8JsonReader.GetString() ?? EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y()),
							Start = num,
							Length = num2
						});
					}
					text = null;
					A(val3);
					break;
				}
				default:
					text = null;
					A(val3);
					break;
				}
			}
			return val;
		}
		catch (JsonException)
		{
			return null;
		}
	}

	private static string A(string? name, List<int> P_1)
	{
		string text = name;
		if (text == null)
		{
			if (P_1.Count > 0)
			{
				if (P_1[P_1.Count - 1] >= 0)
				{
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DH());
					defaultInterpolatedStringHandler.AppendFormatted<int>(P_1[P_1.Count - 1]);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.DJ());
					text = defaultInterpolatedStringHandler.ToStringAndClear();
					goto IL_0062;
				}
			}
			return EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.y();
		}
		goto IL_0062;
		IL_0062:
		return text;
	}

	private static void A(List<int> P_0)
	{
		if (P_0.Count > 0)
		{
			if (P_0[P_0.Count - 1] >= 0)
			{
				int num = P_0.Count - 1;
				int num2 = P_0[num];
				P_0[num] = num2 + 1;
			}
		}
	}

	private static string A(List<string> P_0, List<int> P_1, string P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		StringBuilder val = new StringBuilder();
		Enumerator<string> enumerator = P_0.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (current.Length != 0)
				{
					if (val.Length > 0 && current[0] != '[')
					{
						val.Append('.');
					}
					val.Append(current);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		if (P_1.Count > 0)
		{
			if (P_1[P_1.Count - 1] >= 0)
			{
				val.Append('[').Append(P_1[P_1.Count - 1]).Append(']');
				return ((object)val).ToString();
			}
		}
		if (P_2.Length > 0)
		{
			if (val.Length > 0)
			{
				val.Append('.');
			}
			val.Append(P_2);
		}
		return ((object)val).ToString();
	}

	private static int A(byte[] P_0, int P_1)
	{
		if (P_1 < 0 || P_1 >= P_0.Length || P_0[P_1] != 34)
		{
			return 0;
		}
		for (int i = P_1 + 1; i < P_0.Length; i++)
		{
			if (P_0[i] == 92)
			{
				i++;
			}
			else if (P_0[i] == 34)
			{
				return i - P_1 + 1;
			}
		}
		return 0;
	}

	private static string a(string P_0)
	{
		return JsonStrings.Quote(P_0, leaveArabicAsItIs: true);
	}
}
