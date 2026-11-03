using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Engines;

namespace A;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(ShapeDescriptor))]
[JsonSerializable(typeof(LearnedShape))]
[GeneratedCode("System.Text.Json.SourceGeneration", "8.0.10.36612")]
internal sealed class J : JsonSerializerContext, IJsonTypeInfoResolver
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<JsonParameterInfoValues[]> _003C0_003E__LearnedShapeCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C1_003E__ShapeDescriptorCtorParamInit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<object[], LearnedShape> _003C_003E9__11_0;

		public static Func<object, string?> _003C_003E9__12_0;

		public static Action<object, string?> _003C_003E9__12_1;

		public static Func<object, TextPlaceKind> _003C_003E9__12_2;

		public static Action<object, TextPlaceKind> _003C_003E9__12_3;

		public static Func<object, string?> _003C_003E9__12_4;

		public static Action<object, string?> _003C_003E9__12_5;

		public static Func<object, string?> _003C_003E9__12_6;

		public static Action<object, string?> _003C_003E9__12_7;

		public static Func<object, ShapeDescriptor?> _003C_003E9__12_8;

		public static Action<object, ShapeDescriptor?> _003C_003E9__12_9;

		public static Func<object, long> _003C_003E9__12_10;

		public static Action<object, long> _003C_003E9__12_11;

		public static Func<object, string?> _003C_003E9__12_12;

		public static Action<object, string?> _003C_003E9__12_13;

		public static Func<object, int> _003C_003E9__12_14;

		public static Action<object, int> _003C_003E9__12_15;

		public static Func<object, int> _003C_003E9__12_16;

		public static Action<object, int> _003C_003E9__12_17;

		public static Func<object[], ShapeDescriptor> _003C_003E9__17_0;

		public static Func<object, int> _003C_003E9__18_0;

		public static Action<object, int> _003C_003E9__18_1;

		public static Func<object, string?> _003C_003E9__18_2;

		public static Action<object, string?> _003C_003E9__18_3;

		public static Func<object, string?> _003C_003E9__18_4;

		public static Action<object, string?> _003C_003E9__18_5;

		public static Func<object, string?> _003C_003E9__18_6;

		public static Action<object, string?> _003C_003E9__18_7;

		public static Func<object, string?> _003C_003E9__18_8;

		public static Action<object, string?> _003C_003E9__18_9;

		public static Func<object, string?> _003C_003E9__18_10;

		public static Action<object, string?> _003C_003E9__18_11;

		public static Func<object, string?> _003C_003E9__18_12;

		public static Action<object, string?> _003C_003E9__18_13;

		public static Func<object, bool?> _003C_003E9__18_14;

		public static Action<object, bool?> _003C_003E9__18_15;

		public static Func<object, int?> _003C_003E9__18_16;

		public static Action<object, int?> _003C_003E9__18_17;

		public static Func<object, string?> _003C_003E9__18_18;

		public static Action<object, string?> _003C_003E9__18_19;

		public static Func<object, bool?> _003C_003E9__18_20;

		public static Action<object, bool?> _003C_003E9__18_21;

		public static Func<object, ShapeDescriptor?> _003C_003E9__18_22;

		public static Action<object, ShapeDescriptor?> _003C_003E9__18_23;

		internal LearnedShape A(object[] P_0)
		{
			return new LearnedShape
			{
				File = (string)P_0[0],
				Kind = (TextPlaceKind)P_0[1],
				What = (string)P_0[2],
				Field = (string)P_0[3],
				Shape = (ShapeDescriptor)P_0[4],
				OriginalSize = (long)P_0[5],
				OriginalSha256 = (string)P_0[6],
				Lines = (int)P_0[7],
				RulesVersion = (int)P_0[8]
			};
		}

		internal string? A(object P_0)
		{
			return ((LearnedShape)P_0).File;
		}

		internal void A(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal TextPlaceKind a(object P_0)
		{
			return ((LearnedShape)P_0).Kind;
		}

		internal void A(object P_0, TextPlaceKind P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? B(object P_0)
		{
			return ((LearnedShape)P_0).What;
		}

		internal void a(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? b(object P_0)
		{
			return ((LearnedShape)P_0).Field;
		}

		internal void B(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal ShapeDescriptor? C(object P_0)
		{
			return ((LearnedShape)P_0).Shape;
		}

		internal void A(object P_0, ShapeDescriptor? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal long c(object P_0)
		{
			return ((LearnedShape)P_0).OriginalSize;
		}

		internal void A(object P_0, long P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? D(object P_0)
		{
			return ((LearnedShape)P_0).OriginalSha256;
		}

		internal void b(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int d(object P_0)
		{
			return ((LearnedShape)P_0).Lines;
		}

		internal void A(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int E(object P_0)
		{
			return ((LearnedShape)P_0).RulesVersion;
		}

		internal void a(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal ShapeDescriptor a(object[] P_0)
		{
			return new ShapeDescriptor
			{
				Version = (int)P_0[0],
				Family = (string)P_0[1],
				Class = (string)P_0[2],
				FieldPath = (string)P_0[3],
				Encoding = (string)P_0[4],
				Newline = (string)P_0[5],
				Separator = (string)P_0[6],
				HasHeader = (bool?)P_0[7],
				Column = (int?)P_0[8],
				KeyPath = (string)P_0[9],
				Quoted = (bool?)P_0[10],
				Inner = (ShapeDescriptor)P_0[11]
			};
		}

		internal int e(object P_0)
		{
			return ((ShapeDescriptor)P_0).Version;
		}

		internal void B(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? F(object P_0)
		{
			return ((ShapeDescriptor)P_0).Family;
		}

		internal void C(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? f(object P_0)
		{
			return ((ShapeDescriptor)P_0).Class;
		}

		internal void c(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? G(object P_0)
		{
			return ((ShapeDescriptor)P_0).FieldPath;
		}

		internal void D(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? g(object P_0)
		{
			return ((ShapeDescriptor)P_0).Encoding;
		}

		internal void d(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? H(object P_0)
		{
			return ((ShapeDescriptor)P_0).Newline;
		}

		internal void E(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? h(object P_0)
		{
			return ((ShapeDescriptor)P_0).Separator;
		}

		internal void e(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal bool? I(object P_0)
		{
			return ((ShapeDescriptor)P_0).HasHeader;
		}

		internal void A(object P_0, bool? P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int? i(object P_0)
		{
			return ((ShapeDescriptor)P_0).Column;
		}

		internal void A(object P_0, int? P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? J(object P_0)
		{
			return ((ShapeDescriptor)P_0).KeyPath;
		}

		internal void F(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal bool? j(object P_0)
		{
			return ((ShapeDescriptor)P_0).Quoted;
		}

		internal void a(object P_0, bool? P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal ShapeDescriptor? K(object P_0)
		{
			return ((ShapeDescriptor)P_0).Inner;
		}

		internal void a(object P_0, ShapeDescriptor? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return b(options);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return c(options);
		}
	}

	private JsonTypeInfo<bool>? _Boolean;

	private JsonTypeInfo<bool?>? _NullableBoolean;

	private JsonTypeInfo<LearnedShape>? _LearnedShape;

	private JsonTypeInfo<ShapeDescriptor>? _ShapeDescriptor;

	private JsonTypeInfo<TextPlaceKind>? _TextPlaceKind;

	private JsonTypeInfo<int>? _Int32;

	private JsonTypeInfo<int?>? _NullableInt32;

	private JsonTypeInfo<long>? _Int64;

	private JsonTypeInfo<string>? _String;

	private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions
	{
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
	};

	private static readonly JsonEncodedText PropName_v = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MK());

	private static readonly JsonEncodedText PropName_family = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ML());

	private static readonly JsonEncodedText PropName_class = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MM());

	private static readonly JsonEncodedText PropName_fieldPath = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MN());

	private static readonly JsonEncodedText PropName_encoding = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MO());

	private static readonly JsonEncodedText PropName_newline = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MP());

	private static readonly JsonEncodedText PropName_separator = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MQ());

	private static readonly JsonEncodedText PropName_hasHeader = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MR());

	private static readonly JsonEncodedText PropName_column = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MS());

	private static readonly JsonEncodedText PropName_keyPath = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MT());

	private static readonly JsonEncodedText PropName_quoted = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MU());

	private static readonly JsonEncodedText PropName_inner = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MV());

	public JsonTypeInfo<bool> Boolean => _Boolean ?? (_Boolean = (JsonTypeInfo<bool>)base.Options.GetTypeInfo(typeof(bool)));

	public JsonTypeInfo<bool?> NullableBoolean => _NullableBoolean ?? (_NullableBoolean = (JsonTypeInfo<bool?>)base.Options.GetTypeInfo(typeof(bool?)));

	public JsonTypeInfo<LearnedShape> LearnedShape => _LearnedShape ?? (_LearnedShape = (JsonTypeInfo<LearnedShape>)base.Options.GetTypeInfo(typeof(LearnedShape)));

	public JsonTypeInfo<ShapeDescriptor> ShapeDescriptor => _ShapeDescriptor ?? (_ShapeDescriptor = (JsonTypeInfo<ShapeDescriptor>)base.Options.GetTypeInfo(typeof(ShapeDescriptor)));

	public JsonTypeInfo<TextPlaceKind> TextPlaceKind => _TextPlaceKind ?? (_TextPlaceKind = (JsonTypeInfo<TextPlaceKind>)base.Options.GetTypeInfo(typeof(TextPlaceKind)));

	public JsonTypeInfo<int> Int32 => _Int32 ?? (_Int32 = (JsonTypeInfo<int>)base.Options.GetTypeInfo(typeof(int)));

	public JsonTypeInfo<int?> NullableInt32 => _NullableInt32 ?? (_NullableInt32 = (JsonTypeInfo<int?>)base.Options.GetTypeInfo(typeof(int?)));

	public JsonTypeInfo<long> Int64 => _Int64 ?? (_Int64 = (JsonTypeInfo<long>)base.Options.GetTypeInfo(typeof(long)));

	public JsonTypeInfo<string> String => _String ?? (_String = (JsonTypeInfo<string>)base.Options.GetTypeInfo(typeof(string)));

	[field: CompilerGenerated]
	public static J Default
	{
		[CompilerGenerated]
		get;
	} = new J(new JsonSerializerOptions(s_defaultOptions));


	[field: CompilerGenerated]
	protected override JsonSerializerOptions? GeneratedSerializerOptions
	{
		[CompilerGenerated]
		get;
	} = s_defaultOptions;


	private JsonTypeInfo<bool> A(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<bool> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<bool>(P_0, JsonMetadataServices.BooleanConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<bool?> a(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<bool?> jsonTypeInfo))
		{
			JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<bool>(P_0);
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<bool?>(P_0, nullableConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<LearnedShape> B(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<LearnedShape> jsonTypeInfo))
		{
			JsonObjectInfoValues<LearnedShape> objectInfo = new JsonObjectInfoValues<LearnedShape>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new LearnedShape
				{
					File = (string)P_0[0],
					Kind = (TextPlaceKind)P_0[1],
					What = (string)P_0[2],
					Field = (string)P_0[3],
					Shape = (ShapeDescriptor)P_0[4],
					OriginalSize = (long)P_0[5],
					OriginalSha256 = (string)P_0[6],
					Lines = (int)P_0[7],
					RulesVersion = (int)P_0[8]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => b(options),
				ConstructorParameterMetadataInitializer = A,
				SerializeHandler = null
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] b(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[10];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).File,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MC(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mc()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		array[0].IsRequired = true;
		JsonPropertyInfoValues<TextPlaceKind> propertyInfo2 = new JsonPropertyInfoValues<TextPlaceKind>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = (JsonConverter<TextPlaceKind>)A(typeof(TextPlaceKind), new JsonStringEnumConverter<TextPlaceKind>(), P_0),
			Getter = (object P_0) => ((LearnedShape)P_0).Kind,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aQ()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo3 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).What,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MD(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.gZ()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		array[2].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo4 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).Field,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Md(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ME()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		array[3].IsRequired = true;
		JsonPropertyInfoValues<ShapeDescriptor> propertyInfo5 = new JsonPropertyInfoValues<ShapeDescriptor>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).Shape,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Me(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MF()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		array[4].IsRequired = true;
		JsonPropertyInfoValues<long> propertyInfo6 = new JsonPropertyInfoValues<long>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).OriginalSize,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mf(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MG()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		array[5].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo7 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).OriginalSha256,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mg(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MH()
		};
		array[6] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo7);
		array[6].IsRequired = true;
		JsonPropertyInfoValues<int> propertyInfo8 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).Lines,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mh(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.he()
		};
		array[7] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo8);
		array[7].IsRequired = true;
		JsonPropertyInfoValues<int> propertyInfo9 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = (object P_0) => ((LearnedShape)P_0).RulesVersion,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MI(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mi()
		};
		array[8] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo9);
		array[8].IsRequired = true;
		JsonPropertyInfoValues<bool> propertyInfo10 = new JsonPropertyInfoValues<bool>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(LearnedShape),
			Converter = null,
			Getter = null,
			Setter = null,
			IgnoreCondition = JsonIgnoreCondition.Always,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MJ(),
			JsonPropertyName = null
		};
		array[9] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo10);
		return array;
	}

	private static JsonParameterInfoValues[] A()
	{
		return new JsonParameterInfoValues[9]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MC(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap(),
				ParameterType = typeof(TextPlaceKind),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MD(),
				ParameterType = typeof(string),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Md(),
				ParameterType = typeof(string),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Me(),
				ParameterType = typeof(ShapeDescriptor),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mf(),
				ParameterType = typeof(long),
				Position = 5
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mg(),
				ParameterType = typeof(string),
				Position = 6
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mh(),
				ParameterType = typeof(int),
				Position = 7
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MI(),
				ParameterType = typeof(int),
				Position = 8
			}
		};
	}

	private JsonTypeInfo<ShapeDescriptor> C(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<ShapeDescriptor> jsonTypeInfo))
		{
			JsonObjectInfoValues<ShapeDescriptor> objectInfo = new JsonObjectInfoValues<ShapeDescriptor>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new ShapeDescriptor
				{
					Version = (int)P_0[0],
					Family = (string)P_0[1],
					Class = (string)P_0[2],
					FieldPath = (string)P_0[3],
					Encoding = (string)P_0[4],
					Newline = (string)P_0[5],
					Separator = (string)P_0[6],
					HasHeader = (bool?)P_0[7],
					Column = (int?)P_0[8],
					KeyPath = (string)P_0[9],
					Quoted = (bool?)P_0[10],
					Inner = (ShapeDescriptor)P_0[11]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => c(options),
				ConstructorParameterMetadataInitializer = a,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] c(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[12];
		JsonPropertyInfoValues<int> propertyInfo = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Version,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mj(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MK()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Family,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mk(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ML()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo3 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Class,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ml(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MM()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<string> propertyInfo4 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).FieldPath,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mm(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MN()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		JsonPropertyInfoValues<string> propertyInfo5 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Encoding,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mn(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MO()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		JsonPropertyInfoValues<string> propertyInfo6 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Newline,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mo(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MP()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		JsonPropertyInfoValues<string> propertyInfo7 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Separator,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mp(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MQ()
		};
		array[6] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo7);
		JsonPropertyInfoValues<bool?> propertyInfo8 = new JsonPropertyInfoValues<bool?>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).HasHeader,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mq(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MR()
		};
		array[7] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo8);
		JsonPropertyInfoValues<int?> propertyInfo9 = new JsonPropertyInfoValues<int?>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Column,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mr(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MS()
		};
		array[8] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo9);
		JsonPropertyInfoValues<string> propertyInfo10 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).KeyPath,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ms(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MT()
		};
		array[9] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo10);
		JsonPropertyInfoValues<bool?> propertyInfo11 = new JsonPropertyInfoValues<bool?>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Quoted,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mt(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MU()
		};
		array[10] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo11);
		JsonPropertyInfoValues<ShapeDescriptor> propertyInfo12 = new JsonPropertyInfoValues<ShapeDescriptor>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ShapeDescriptor),
			Converter = null,
			Getter = (object P_0) => ((ShapeDescriptor)P_0).Inner,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mu(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MV()
		};
		array[11] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo12);
		return array;
	}

	private void A(Utf8JsonWriter P_0, ShapeDescriptor? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteNumber(PropName_v, value.Version);
		string family = value.Family;
		if (family != null)
		{
			P_0.WriteString(PropName_family, family);
		}
		string @class = value.Class;
		if (@class != null)
		{
			P_0.WriteString(PropName_class, @class);
		}
		string fieldPath = value.FieldPath;
		if (fieldPath != null)
		{
			P_0.WriteString(PropName_fieldPath, fieldPath);
		}
		string encoding = value.Encoding;
		if (encoding != null)
		{
			P_0.WriteString(PropName_encoding, encoding);
		}
		string newline = value.Newline;
		if (newline != null)
		{
			P_0.WriteString(PropName_newline, newline);
		}
		string separator = value.Separator;
		if (separator != null)
		{
			P_0.WriteString(PropName_separator, separator);
		}
		bool? hasHeader = value.HasHeader;
		if (hasHeader.HasValue)
		{
			P_0.WritePropertyName(PropName_hasHeader);
			JsonSerializer.Serialize(P_0, hasHeader, NullableBoolean);
		}
		int? column = value.Column;
		if (column.HasValue)
		{
			P_0.WritePropertyName(PropName_column);
			JsonSerializer.Serialize(P_0, column, NullableInt32);
		}
		string keyPath = value.KeyPath;
		if (keyPath != null)
		{
			P_0.WriteString(PropName_keyPath, keyPath);
		}
		bool? quoted = value.Quoted;
		if (quoted.HasValue)
		{
			P_0.WritePropertyName(PropName_quoted);
			JsonSerializer.Serialize(P_0, quoted, NullableBoolean);
		}
		ShapeDescriptor inner = value.Inner;
		if (inner != null)
		{
			P_0.WritePropertyName(PropName_inner);
			A(P_0, inner);
		}
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] a()
	{
		return new JsonParameterInfoValues[12]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mj(),
				ParameterType = typeof(int),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mk(),
				ParameterType = typeof(string),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ml(),
				ParameterType = typeof(string),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mm(),
				ParameterType = typeof(string),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mn(),
				ParameterType = typeof(string),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mo(),
				ParameterType = typeof(string),
				Position = 5
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mp(),
				ParameterType = typeof(string),
				Position = 6
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mq(),
				ParameterType = typeof(bool?),
				Position = 7
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mr(),
				ParameterType = typeof(int?),
				Position = 8
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ms(),
				ParameterType = typeof(string),
				Position = 9
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mt(),
				ParameterType = typeof(bool?),
				Position = 10
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mu(),
				ParameterType = typeof(ShapeDescriptor),
				Position = 11
			}
		};
	}

	private JsonTypeInfo<TextPlaceKind> D(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<TextPlaceKind> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<TextPlaceKind>(P_0, JsonMetadataServices.GetEnumConverter<TextPlaceKind>(P_0));
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<int> d(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<int> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int>(P_0, JsonMetadataServices.Int32Converter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<int?> E(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<int?> jsonTypeInfo))
		{
			JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<int>(P_0);
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int?>(P_0, nullableConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<long> e(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<long> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<long>(P_0, JsonMetadataServices.Int64Converter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<string> F(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<string> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<string>(P_0, JsonMetadataServices.StringConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	public J()
		: base(null)
	{
	}

	public J(JsonSerializerOptions P_0)
		: base(P_0)
	{
	}

	private static bool A<TJsonMetadataType>(JsonSerializerOptions P_0, out JsonTypeInfo<TJsonMetadataType> P_1)
	{
		JsonConverter jsonConverter = A(typeof(TJsonMetadataType), P_0);
		if (jsonConverter != null)
		{
			P_1 = JsonMetadataServices.CreateValueInfo<TJsonMetadataType>(P_0, jsonConverter);
			return true;
		}
		P_1 = null;
		return false;
	}

	private static JsonConverter? A(System.Type P_0, JsonSerializerOptions P_1)
	{
		for (int l = 0; l < ((System.Collections.Generic.ICollection<JsonConverter>)P_1.Converters).Count; l++)
		{
			JsonConverter jsonConverter = P_1.Converters[l];
			if (jsonConverter != null && jsonConverter.CanConvert(P_0))
			{
				return A(P_0, jsonConverter, P_1, false);
			}
		}
		return null;
	}

	private static JsonConverter A(System.Type P_0, JsonConverter P_1, JsonSerializerOptions P_2, bool P_3 = true)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (P_3 && !P_1.CanConvert(P_0))
		{
			throw new InvalidOperationException(string.Format(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.at(), (object)((object)P_1).GetType(), (object)P_0));
		}
		if (P_1 is JsonConverterFactory jsonConverterFactory)
		{
			P_1 = jsonConverterFactory.CreateConverter(P_0, P_2);
			if (P_1 == null || P_1 is JsonConverterFactory)
			{
				throw new InvalidOperationException(string.Format(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aU(), (object)((object)jsonConverterFactory).GetType()));
			}
		}
		return P_1;
	}

	public override JsonTypeInfo? GetTypeInfo(System.Type type)
	{
		base.Options.TryGetTypeInfo(type, out JsonTypeInfo typeInfo);
		return typeInfo;
	}

	private JsonTypeInfo? a(System.Type P_0, JsonSerializerOptions P_1)
	{
		if (P_0 == typeof(bool))
		{
			return A(P_1);
		}
		if (P_0 == typeof(bool?))
		{
			return a(P_1);
		}
		if (P_0 == typeof(LearnedShape))
		{
			return B(P_1);
		}
		if (P_0 == typeof(ShapeDescriptor))
		{
			return C(P_1);
		}
		if (P_0 == typeof(TextPlaceKind))
		{
			return D(P_1);
		}
		if (P_0 == typeof(int))
		{
			return d(P_1);
		}
		if (P_0 == typeof(int?))
		{
			return E(P_1);
		}
		if (P_0 == typeof(long))
		{
			return e(P_1);
		}
		if (P_0 == typeof(string))
		{
			return F(P_1);
		}
		return null;
	}

	JsonTypeInfo? IJsonTypeInfoResolver.GetTypeInfo(System.Type P_0, JsonSerializerOptions P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0, P_1);
	}
}
[CompilerGenerated]
internal sealed class j
{
	[StructLayout(2, Pack = 1, Size = 6)]
	internal struct A
	{
	}

	[StructLayout(2, Pack = 1, Size = 10)]
	internal struct a
	{
	}

	[StructLayout(2, Pack = 1, Size = 12)]
	internal struct B
	{
	}

	[StructLayout(2, Pack = 1, Size = 14)]
	internal struct b
	{
	}

	[StructLayout(2, Pack = 1, Size = 16)]
	internal struct C
	{
	}

	[StructLayout(2, Pack = 1, Size = 20)]
	internal struct c
	{
	}

	[StructLayout(2, Pack = 1, Size = 28)]
	internal struct D
	{
	}

	internal static readonly c _19FBEB13B424D57313F13ACC2F7465637220AFC005CB26E792E8791333A414EF/* Not supported: data(20 00 09 00 0A 00 2C 00 2E 00 3A 00 2D 00 2F 00 28 00 29 00) */;

	internal static readonly D _23F4BE77E0D3E4383ED3ED4F4A22BB9D336614DA08EC01EA3D26ABB52B6A27DD/* Not supported: data(22 00 27 00 28 00 29 00 5B 00 5D 00 7B 00 7D 00 2C 00 3B 00 3A 00 2E 00 21 00 3F 00) */;

	internal static readonly A _2B9628851C762B5A42C3BD40372A2F5644EEC6248049E31E747CF5A9877335FB/* Not supported: data(20 00 2D 00 3A 00) */;

	internal static readonly C _3C17DA885F7916F14BECDDD5A559E146795A03758C28EA455EC8E9E803B90531/* Not supported: data(00 00 00 00 00 00 FF 03 FE FF FF 87 FE FF FF 07) */;

	internal static readonly B _4E40164744ED80B28DCAF594D1417E202E208B11601B08C1D83512F823E26B0A/* Not supported: data(2E 00 21 00 3F 00 2C 00 3B 00 3A 00) */;

	internal static readonly C _6CDF0AF4431F4C6BA863542B0873A6C2879F77865B59E613570E8444E8F8A315/* Not supported: data(2E 00 21 00 3F 00 2C 00 3B 00 26 20 0C 06 1F 06) */;

	internal static readonly a _8B9EEA238E600EE765C5DF511866D78D6055AAA9D16F51201DC1206B01CFC9A2/* Not supported: data(20 00 09 00 0A 00 0B 00 22 00) */;

	internal static readonly B _8C832C1029D8F7803F85CF35907602514763430D981593D58B8C7F6B6490D654/* Not supported: data(5B 00 5D 00 7B 00 7D 00 3C 00 3E 00) */;

	internal static readonly C B7A5FF91B09BD90CB618711A317A3869F55E438F5D5D59A13884079774E31A1E/* Not supported: data(00 04 00 00 00 08 00 00 00 10 00 00 00 20 00 00) */;

	internal static readonly long DACC0E6568D9B10337A1A693F10D42C3175E80C378154406C6FBFA989F919F51/* Not supported: data(20 00 09 00 0A 00 0D 00) */;

	internal static readonly B EDBE52767BFCB7BAF92CC20C0B5EBCF209CDBF673C421C89C4F80DF5B1B0B552/* Not supported: data(5F 00 2D 00 2E 00 20 00 2F 00 5C 00) */;

	internal static readonly b EE88CB8CA22506CA63984BC65E378C6DFDEFC06646E265B974C3EE6E4A707C3D/* Not supported: data(20 00 09 00 22 00 27 00 28 00 29 00 2D 00) */;

	internal static readonly a F1844FD6F14FB70F9E27C11942658371DB1E42C7FC6719DC840DFEC411D2C8B2/* Not supported: data(28 00 22 00 27 00 AB 00 5B 00) */;
}
