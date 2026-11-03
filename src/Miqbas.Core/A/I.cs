using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Engines;
using Miqbas.Core.Packages;
using Miqbas.Core.Patching;
using Miqbas.Core.Translation;

namespace A;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(BackupManifest))]
[GeneratedCode("System.Text.Json.SourceGeneration", "8.0.10.36612")]
internal class I : JsonSerializerContext, IJsonTypeInfoResolver
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<JsonParameterInfoValues[]> _003C0_003E__BackupEntryCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C1_003E__BackupManifestCtorParamInit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<object[], BackupEntry> _003C_003E9__3_0;

		public static Func<object, string?> _003C_003E9__4_0;

		public static Action<object, string?> _003C_003E9__4_1;

		public static Func<object, BackupEntryKind> _003C_003E9__4_2;

		public static Action<object, BackupEntryKind> _003C_003E9__4_3;

		public static Func<object, string?> _003C_003E9__4_4;

		public static Action<object, string?> _003C_003E9__4_5;

		public static Func<object[], BackupManifest> _003C_003E9__14_0;

		public static Func<object, System.Collections.Generic.IReadOnlyList<BackupEntry>?> _003C_003E9__15_0;

		public static Action<object, System.Collections.Generic.IReadOnlyList<BackupEntry>?> _003C_003E9__15_1;

		internal BackupEntry A(object[] P_0)
		{
			return new BackupEntry
			{
				RelativePath = (string)P_0[0],
				Kind = (BackupEntryKind)P_0[1],
				Sha256 = (string)P_0[2]
			};
		}

		internal string? A(object P_0)
		{
			return ((BackupEntry)P_0).RelativePath;
		}

		internal void A(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal BackupEntryKind a(object P_0)
		{
			return ((BackupEntry)P_0).Kind;
		}

		internal void A(object P_0, BackupEntryKind P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? B(object P_0)
		{
			return ((BackupEntry)P_0).Sha256;
		}

		internal void a(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal BackupManifest a(object[] P_0)
		{
			return new BackupManifest
			{
				Entries = (System.Collections.Generic.IReadOnlyList<BackupEntry>)P_0[0]
			};
		}

		internal System.Collections.Generic.IReadOnlyList<BackupEntry>? b(object P_0)
		{
			return ((BackupManifest)P_0).Entries;
		}

		internal void A(object P_0, System.Collections.Generic.IReadOnlyList<BackupEntry>? value)
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
			return C(options);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return a(options);
		}
	}

	private JsonTypeInfo<BackupEntry>? _BackupEntry;

	private JsonTypeInfo<BackupEntryKind>? _BackupEntryKind;

	private JsonTypeInfo<BackupManifest>? _BackupManifest;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<BackupEntry>>? _IReadOnlyListBackupEntry;

	private JsonTypeInfo<string>? _String;

	private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions
	{
		WriteIndented = true
	};

	private static readonly JsonEncodedText PropName_RelativePath = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kv());

	private static readonly JsonEncodedText PropName_Kind = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap());

	private static readonly JsonEncodedText PropName_Sha256 = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kW());

	private static readonly JsonEncodedText PropName_Entries = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kw());

	public JsonTypeInfo<BackupEntry> BackupEntry => _BackupEntry ?? (_BackupEntry = (JsonTypeInfo<BackupEntry>)base.Options.GetTypeInfo(typeof(BackupEntry)));

	public JsonTypeInfo<BackupEntryKind> BackupEntryKind => _BackupEntryKind ?? (_BackupEntryKind = (JsonTypeInfo<BackupEntryKind>)base.Options.GetTypeInfo(typeof(BackupEntryKind)));

	public JsonTypeInfo<BackupManifest> BackupManifest => _BackupManifest ?? (_BackupManifest = (JsonTypeInfo<BackupManifest>)base.Options.GetTypeInfo(typeof(BackupManifest)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<BackupEntry>> IReadOnlyListBackupEntry => _IReadOnlyListBackupEntry ?? (_IReadOnlyListBackupEntry = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<BackupEntry>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<BackupEntry>)));

	public JsonTypeInfo<string> String => _String ?? (_String = (JsonTypeInfo<string>)base.Options.GetTypeInfo(typeof(string)));

	[field: CompilerGenerated]
	public static I Default
	{
		[CompilerGenerated]
		get;
	} = new I(new JsonSerializerOptions(s_defaultOptions));


	[field: CompilerGenerated]
	protected override JsonSerializerOptions? GeneratedSerializerOptions
	{
		[CompilerGenerated]
		get;
	} = s_defaultOptions;


	private JsonTypeInfo<BackupEntry> A(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<BackupEntry> jsonTypeInfo))
		{
			JsonObjectInfoValues<BackupEntry> objectInfo = new JsonObjectInfoValues<BackupEntry>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new BackupEntry
				{
					RelativePath = (string)P_0[0],
					Kind = (BackupEntryKind)P_0[1],
					Sha256 = (string)P_0[2]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => a(options),
				ConstructorParameterMetadataInitializer = A,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] a(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[3];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(BackupEntry),
			Converter = null,
			Getter = (object P_0) => ((BackupEntry)P_0).RelativePath,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kv(),
			JsonPropertyName = null
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		array[0].IsRequired = true;
		JsonPropertyInfoValues<BackupEntryKind> propertyInfo2 = new JsonPropertyInfoValues<BackupEntryKind>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(BackupEntry),
			Converter = null,
			Getter = (object P_0) => ((BackupEntry)P_0).Kind,
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
			JsonPropertyName = null
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo3 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(BackupEntry),
			Converter = null,
			Getter = (object P_0) => ((BackupEntry)P_0).Sha256,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kW(),
			JsonPropertyName = null
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		return array;
	}

	private void A(Utf8JsonWriter P_0, BackupEntry? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteString(PropName_RelativePath, value.RelativePath);
		P_0.WritePropertyName(PropName_Kind);
		JsonSerializer.Serialize(P_0, value.Kind, BackupEntryKind);
		P_0.WriteString(PropName_Sha256, value.Sha256);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] A()
	{
		return new JsonParameterInfoValues[3]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kv(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap(),
				ParameterType = typeof(BackupEntryKind),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kW(),
				ParameterType = typeof(string),
				Position = 2
			}
		};
	}

	private JsonTypeInfo<BackupEntryKind> B(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<BackupEntryKind> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<BackupEntryKind>(P_0, JsonMetadataServices.GetEnumConverter<BackupEntryKind>(P_0));
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<BackupManifest> b(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<BackupManifest> jsonTypeInfo))
		{
			JsonObjectInfoValues<BackupManifest> objectInfo = new JsonObjectInfoValues<BackupManifest>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new BackupManifest
				{
					Entries = (System.Collections.Generic.IReadOnlyList<BackupEntry>)P_0[0]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => C(options),
				ConstructorParameterMetadataInitializer = a,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] C(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[1];
		JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<BackupEntry>> propertyInfo = new JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<BackupEntry>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(BackupManifest),
			Converter = null,
			Getter = (object P_0) => ((BackupManifest)P_0).Entries,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kw(),
			JsonPropertyName = null
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		array[0].IsRequired = true;
		return array;
	}

	private void A(Utf8JsonWriter P_0, BackupManifest? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WritePropertyName(PropName_Entries);
		A(P_0, value.Entries);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] a()
	{
		return new JsonParameterInfoValues[1]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.kw(),
				ParameterType = typeof(System.Collections.Generic.IReadOnlyList<BackupEntry>),
				Position = 0
			}
		};
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<BackupEntry>> c(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<BackupEntry>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<BackupEntry>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<BackupEntry>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<BackupEntry>, BackupEntry>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<BackupEntry>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<BackupEntry> enumerator = ((System.Collections.Generic.IEnumerable<BackupEntry>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				BackupEntry current = enumerator.Current;
				A(P_0, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<string> D(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<string> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<string>(P_0, JsonMetadataServices.StringConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	public I()
		: base(null)
	{
	}

	public I(JsonSerializerOptions P_0)
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
		if (P_0 == typeof(BackupEntry))
		{
			return A(P_1);
		}
		if (P_0 == typeof(BackupEntryKind))
		{
			return B(P_1);
		}
		if (P_0 == typeof(BackupManifest))
		{
			return b(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<BackupEntry>))
		{
			return c(P_1);
		}
		if (P_0 == typeof(string))
		{
			return D(P_1);
		}
		return null;
	}

	JsonTypeInfo? IJsonTypeInfoResolver.GetTypeInfo(System.Type P_0, JsonSerializerOptions P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0, P_1);
	}
}
[JsonSerializable(typeof(MqbsManifest))]
[JsonSerializable(typeof(MqbsInstall))]
[JsonSerializable(typeof(System.Collections.Generic.IReadOnlyList<MqbsEntry>))]
[JsonSerializable(typeof(List<MqbsEntry>))]
[JsonSerializable(typeof(System.Collections.Generic.IReadOnlyList<GlossaryEntry>))]
[JsonSerializable(typeof(List<GlossaryEntry>))]
[JsonSerializable(typeof(System.Collections.Generic.IReadOnlyList<LearnedShape>))]
[JsonSerializable(typeof(JsonElement))]
[GeneratedCode("System.Text.Json.SourceGeneration", "8.0.10.36612")]
internal sealed class i : JsonSerializerContext, IJsonTypeInfoResolver
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<JsonParameterInfoValues[]> _003C0_003E__LearnedShapeCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C1_003E__ShapeDescriptorCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C2_003E__MqbsEntryCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C3_003E__MqbsInstallCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C4_003E__MqbsManifestCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C5_003E__GlossaryEntryCtorParamInit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<object[], LearnedShape> _003C_003E9__15_0;

		public static Func<object, string?> _003C_003E9__16_0;

		public static Action<object, string?> _003C_003E9__16_1;

		public static Func<object, TextPlaceKind> _003C_003E9__16_2;

		public static Action<object, TextPlaceKind> _003C_003E9__16_3;

		public static Func<object, string?> _003C_003E9__16_4;

		public static Action<object, string?> _003C_003E9__16_5;

		public static Func<object, string?> _003C_003E9__16_6;

		public static Action<object, string?> _003C_003E9__16_7;

		public static Func<object, ShapeDescriptor?> _003C_003E9__16_8;

		public static Action<object, ShapeDescriptor?> _003C_003E9__16_9;

		public static Func<object, long> _003C_003E9__16_10;

		public static Action<object, long> _003C_003E9__16_11;

		public static Func<object, string?> _003C_003E9__16_12;

		public static Action<object, string?> _003C_003E9__16_13;

		public static Func<object, int> _003C_003E9__16_14;

		public static Action<object, int> _003C_003E9__16_15;

		public static Func<object, int> _003C_003E9__16_16;

		public static Action<object, int> _003C_003E9__16_17;

		public static Func<object[], ShapeDescriptor> _003C_003E9__21_0;

		public static Func<object, int> _003C_003E9__22_0;

		public static Action<object, int> _003C_003E9__22_1;

		public static Func<object, string?> _003C_003E9__22_2;

		public static Action<object, string?> _003C_003E9__22_3;

		public static Func<object, string?> _003C_003E9__22_4;

		public static Action<object, string?> _003C_003E9__22_5;

		public static Func<object, string?> _003C_003E9__22_6;

		public static Action<object, string?> _003C_003E9__22_7;

		public static Func<object, string?> _003C_003E9__22_8;

		public static Action<object, string?> _003C_003E9__22_9;

		public static Func<object, string?> _003C_003E9__22_10;

		public static Action<object, string?> _003C_003E9__22_11;

		public static Func<object, string?> _003C_003E9__22_12;

		public static Action<object, string?> _003C_003E9__22_13;

		public static Func<object, bool?> _003C_003E9__22_14;

		public static Action<object, bool?> _003C_003E9__22_15;

		public static Func<object, int?> _003C_003E9__22_16;

		public static Action<object, int?> _003C_003E9__22_17;

		public static Func<object, string?> _003C_003E9__22_18;

		public static Action<object, string?> _003C_003E9__22_19;

		public static Func<object, bool?> _003C_003E9__22_20;

		public static Action<object, bool?> _003C_003E9__22_21;

		public static Func<object, ShapeDescriptor?> _003C_003E9__22_22;

		public static Action<object, ShapeDescriptor?> _003C_003E9__22_23;

		public static Func<object[], MqbsEntry> _003C_003E9__32_0;

		public static Func<object, string?> _003C_003E9__33_0;

		public static Action<object, string?> _003C_003E9__33_1;

		public static Func<object, string?> _003C_003E9__33_2;

		public static Action<object, string?> _003C_003E9__33_3;

		public static Func<object, string?> _003C_003E9__33_4;

		public static Action<object, string?> _003C_003E9__33_5;

		public static Func<object, bool> _003C_003E9__33_6;

		public static Action<object, bool> _003C_003E9__33_7;

		public static Func<object[], MqbsInstall> _003C_003E9__39_0;

		public static Func<object, string?> _003C_003E9__40_0;

		public static Action<object, string?> _003C_003E9__40_1;

		public static Func<object, string?> _003C_003E9__40_2;

		public static Action<object, string?> _003C_003E9__40_3;

		public static Func<object, bool> _003C_003E9__40_4;

		public static Func<object[], MqbsManifest> _003C_003E9__46_0;

		public static Func<object, int> _003C_003E9__47_0;

		public static Action<object, int> _003C_003E9__47_1;

		public static Func<object, string?> _003C_003E9__47_2;

		public static Action<object, string?> _003C_003E9__47_3;

		public static Func<object, string?> _003C_003E9__47_4;

		public static Action<object, string?> _003C_003E9__47_5;

		public static Func<object, string?> _003C_003E9__47_6;

		public static Action<object, string?> _003C_003E9__47_7;

		public static Func<object, string?> _003C_003E9__47_8;

		public static Action<object, string?> _003C_003E9__47_9;

		public static Func<object, double> _003C_003E9__47_10;

		public static Action<object, double> _003C_003E9__47_11;

		public static Func<object, int> _003C_003E9__47_12;

		public static Action<object, int> _003C_003E9__47_13;

		public static Func<object, double> _003C_003E9__47_14;

		public static Action<object, double> _003C_003E9__47_15;

		public static Func<object, string?> _003C_003E9__47_16;

		public static Action<object, string?> _003C_003E9__47_17;

		public static Func<object, DateTimeOffset> _003C_003E9__47_18;

		public static Action<object, DateTimeOffset> _003C_003E9__47_19;

		public static Func<object, string?> _003C_003E9__47_20;

		public static Action<object, string?> _003C_003E9__47_21;

		public static Func<object, string?> _003C_003E9__47_22;

		public static Action<object, string?> _003C_003E9__47_23;

		public static Func<object, System.Collections.Generic.IReadOnlyList<string>?> _003C_003E9__47_24;

		public static Action<object, System.Collections.Generic.IReadOnlyList<string>?> _003C_003E9__47_25;

		public static Func<object[], GlossaryEntry> _003C_003E9__53_0;

		public static Func<object, string?> _003C_003E9__54_0;

		public static Action<object, string?> _003C_003E9__54_1;

		public static Func<object, string?> _003C_003E9__54_2;

		public static Action<object, string?> _003C_003E9__54_3;

		public static Func<object, GlossaryKind> _003C_003E9__54_4;

		public static Action<object, GlossaryKind> _003C_003E9__54_5;

		public static Func<object, bool> _003C_003E9__54_6;

		public static Action<object, bool> _003C_003E9__54_7;

		public static Func<List<MqbsEntry>> _003C_003E9__84_0;

		public static Func<List<GlossaryEntry>> _003C_003E9__89_0;

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

		internal MqbsEntry B(object[] P_0)
		{
			return new MqbsEntry
			{
				Key = (string)P_0[0],
				Source = (string)P_0[1],
				Target = (string)P_0[2],
				Reviewed = (bool)P_0[3]
			};
		}

		internal string? k(object P_0)
		{
			return ((MqbsEntry)P_0).Key;
		}

		internal void f(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? L(object P_0)
		{
			return ((MqbsEntry)P_0).Source;
		}

		internal void G(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? l(object P_0)
		{
			return ((MqbsEntry)P_0).Target;
		}

		internal void g(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal bool M(object P_0)
		{
			return ((MqbsEntry)P_0).Reviewed;
		}

		internal void A(object P_0, bool P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal MqbsInstall b(object[] P_0)
		{
			return new MqbsInstall
			{
				Method = (string)P_0[0],
				EngineId = (string)P_0[1]
			};
		}

		internal string? m(object P_0)
		{
			return ((MqbsInstall)P_0).Method;
		}

		internal void H(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? N(object P_0)
		{
			return ((MqbsInstall)P_0).EngineId;
		}

		internal void h(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal bool n(object P_0)
		{
			return ((MqbsInstall)P_0).IsRuntimeLayer;
		}

		internal MqbsManifest C(object[] P_0)
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			return new MqbsManifest
			{
				MqbsVersion = (int)P_0[0],
				GameFingerprint = (string)P_0[1],
				GameName = (string)P_0[2],
				EngineId = (string)P_0[3],
				EngineVersion = (string)P_0[4],
				Coverage = (double)P_0[5],
				TranslatedCount = (int)P_0[6],
				HumanReviewed = (double)P_0[7],
				Author = (string)P_0[8],
				CreatedAt = (DateTimeOffset)P_0[9],
				SourceLang = (string)P_0[10],
				StyleProfile = (string)P_0[11],
				Fonts = (System.Collections.Generic.IReadOnlyList<string>)P_0[12]
			};
		}

		internal int O(object P_0)
		{
			return ((MqbsManifest)P_0).MqbsVersion;
		}

		internal void b(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? o(object P_0)
		{
			return ((MqbsManifest)P_0).GameFingerprint;
		}

		internal void I(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? P(object P_0)
		{
			return ((MqbsManifest)P_0).GameName;
		}

		internal void i(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? p(object P_0)
		{
			return ((MqbsManifest)P_0).EngineId;
		}

		internal void J(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? Q(object P_0)
		{
			return ((MqbsManifest)P_0).EngineVersion;
		}

		internal void j(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal double q(object P_0)
		{
			return ((MqbsManifest)P_0).Coverage;
		}

		internal void A(object P_0, double P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int R(object P_0)
		{
			return ((MqbsManifest)P_0).TranslatedCount;
		}

		internal void C(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal double r(object P_0)
		{
			return ((MqbsManifest)P_0).HumanReviewed;
		}

		internal void a(object P_0, double P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? S(object P_0)
		{
			return ((MqbsManifest)P_0).Author;
		}

		internal void K(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal DateTimeOffset s(object P_0)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((MqbsManifest)P_0).CreatedAt;
		}

		internal void A(object P_0, DateTimeOffset P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? T(object P_0)
		{
			return ((MqbsManifest)P_0).SourceLang;
		}

		internal void k(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? t(object P_0)
		{
			return ((MqbsManifest)P_0).StyleProfile;
		}

		internal void L(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal System.Collections.Generic.IReadOnlyList<string>? U(object P_0)
		{
			return ((MqbsManifest)P_0).Fonts;
		}

		internal void A(object P_0, System.Collections.Generic.IReadOnlyList<string>? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal GlossaryEntry c(object[] P_0)
		{
			return new GlossaryEntry
			{
				Term = (string)P_0[0],
				Translation = (string)P_0[1],
				Kind = (GlossaryKind)P_0[2],
				Locked = (bool)P_0[3]
			};
		}

		internal string? u(object P_0)
		{
			return ((GlossaryEntry)P_0).Term;
		}

		internal void l(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? V(object P_0)
		{
			return ((GlossaryEntry)P_0).Translation;
		}

		internal void M(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal GlossaryKind v(object P_0)
		{
			return ((GlossaryEntry)P_0).Kind;
		}

		internal void A(object P_0, GlossaryKind P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal bool W(object P_0)
		{
			return ((GlossaryEntry)P_0).Locked;
		}

		internal void a(object P_0, bool P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal List<MqbsEntry> A()
		{
			return new List<MqbsEntry>();
		}

		internal List<GlossaryEntry> a()
		{
			return new List<GlossaryEntry>();
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return C(options);
		}
	}

	[CompilerGenerated]
	private sealed class b
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return D(options);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return e(options);
		}
	}

	[CompilerGenerated]
	private sealed class c
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return f(options);
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return g(options);
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return h(options);
		}
	}

	private JsonTypeInfo<bool>? _Boolean;

	private JsonTypeInfo<bool?>? _NullableBoolean;

	private JsonTypeInfo<double>? _Double;

	private JsonTypeInfo<LearnedShape>? _LearnedShape;

	private JsonTypeInfo<ShapeDescriptor>? _ShapeDescriptor;

	private JsonTypeInfo<TextPlaceKind>? _TextPlaceKind;

	private JsonTypeInfo<MqbsEntry>? _MqbsEntry;

	private JsonTypeInfo<MqbsInstall>? _MqbsInstall;

	private JsonTypeInfo<MqbsManifest>? _MqbsManifest;

	private JsonTypeInfo<GlossaryEntry>? _GlossaryEntry;

	private JsonTypeInfo<GlossaryKind>? _GlossaryKind;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<LearnedShape>>? _IReadOnlyListLearnedShape;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<MqbsEntry>>? _IReadOnlyListMqbsEntry;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>? _IReadOnlyListGlossaryEntry;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>>? _IReadOnlyListString;

	private JsonTypeInfo<List<MqbsEntry>>? _ListMqbsEntry;

	private JsonTypeInfo<List<GlossaryEntry>>? _ListGlossaryEntry;

	private JsonTypeInfo<DateTimeOffset>? _DateTimeOffset;

	private JsonTypeInfo<JsonElement>? _JsonElement;

	private JsonTypeInfo<int>? _Int32;

	private JsonTypeInfo<int?>? _NullableInt32;

	private JsonTypeInfo<long>? _Int64;

	private JsonTypeInfo<string>? _String;

	private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions();

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

	private static readonly JsonEncodedText PropName_key = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MW());

	private static readonly JsonEncodedText PropName_source = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MX());

	private static readonly JsonEncodedText PropName_target = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MY());

	private static readonly JsonEncodedText PropName_reviewed = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MZ());

	private static readonly JsonEncodedText PropName_method = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mA());

	private static readonly JsonEncodedText PropName_engineId = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mB());

	private static readonly JsonEncodedText PropName_IsRuntimeLayer = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mb());

	private static readonly JsonEncodedText PropName_mqbsVersion = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mc());

	private static readonly JsonEncodedText PropName_gameFingerprint = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.md());

	private static readonly JsonEncodedText PropName_gameName = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.me());

	private static readonly JsonEncodedText PropName_engineVersion = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mf());

	private static readonly JsonEncodedText PropName_coverage = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mg());

	private static readonly JsonEncodedText PropName_translatedCount = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mh());

	private static readonly JsonEncodedText PropName_humanReviewed = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mi());

	private static readonly JsonEncodedText PropName_author = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mj());

	private static readonly JsonEncodedText PropName_createdAt = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mk());

	private static readonly JsonEncodedText PropName_sourceLang = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ml());

	private static readonly JsonEncodedText PropName_styleProfile = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mM());

	private static readonly JsonEncodedText PropName_fonts = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mN());

	private static readonly JsonEncodedText PropName_Term = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mn());

	private static readonly JsonEncodedText PropName_Translation = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mO());

	private static readonly JsonEncodedText PropName_Kind = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap());

	private static readonly JsonEncodedText PropName_Locked = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mo());

	public JsonTypeInfo<bool> Boolean => _Boolean ?? (_Boolean = (JsonTypeInfo<bool>)base.Options.GetTypeInfo(typeof(bool)));

	public JsonTypeInfo<bool?> NullableBoolean => _NullableBoolean ?? (_NullableBoolean = (JsonTypeInfo<bool?>)base.Options.GetTypeInfo(typeof(bool?)));

	public JsonTypeInfo<double> Double => _Double ?? (_Double = (JsonTypeInfo<double>)base.Options.GetTypeInfo(typeof(double)));

	public JsonTypeInfo<LearnedShape> LearnedShape => _LearnedShape ?? (_LearnedShape = (JsonTypeInfo<LearnedShape>)base.Options.GetTypeInfo(typeof(LearnedShape)));

	public JsonTypeInfo<ShapeDescriptor> ShapeDescriptor => _ShapeDescriptor ?? (_ShapeDescriptor = (JsonTypeInfo<ShapeDescriptor>)base.Options.GetTypeInfo(typeof(ShapeDescriptor)));

	public JsonTypeInfo<TextPlaceKind> TextPlaceKind => _TextPlaceKind ?? (_TextPlaceKind = (JsonTypeInfo<TextPlaceKind>)base.Options.GetTypeInfo(typeof(TextPlaceKind)));

	public JsonTypeInfo<MqbsEntry> MqbsEntry => _MqbsEntry ?? (_MqbsEntry = (JsonTypeInfo<MqbsEntry>)base.Options.GetTypeInfo(typeof(MqbsEntry)));

	public JsonTypeInfo<MqbsInstall> MqbsInstall => _MqbsInstall ?? (_MqbsInstall = (JsonTypeInfo<MqbsInstall>)base.Options.GetTypeInfo(typeof(MqbsInstall)));

	public JsonTypeInfo<MqbsManifest> MqbsManifest => _MqbsManifest ?? (_MqbsManifest = (JsonTypeInfo<MqbsManifest>)base.Options.GetTypeInfo(typeof(MqbsManifest)));

	public JsonTypeInfo<GlossaryEntry> GlossaryEntry => _GlossaryEntry ?? (_GlossaryEntry = (JsonTypeInfo<GlossaryEntry>)base.Options.GetTypeInfo(typeof(GlossaryEntry)));

	public JsonTypeInfo<GlossaryKind> GlossaryKind => _GlossaryKind ?? (_GlossaryKind = (JsonTypeInfo<GlossaryKind>)base.Options.GetTypeInfo(typeof(GlossaryKind)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<LearnedShape>> IReadOnlyListLearnedShape => _IReadOnlyListLearnedShape ?? (_IReadOnlyListLearnedShape = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<LearnedShape>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<LearnedShape>)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<MqbsEntry>> IReadOnlyListMqbsEntry => _IReadOnlyListMqbsEntry ?? (_IReadOnlyListMqbsEntry = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<MqbsEntry>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<MqbsEntry>)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<GlossaryEntry>> IReadOnlyListGlossaryEntry => _IReadOnlyListGlossaryEntry ?? (_IReadOnlyListGlossaryEntry = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<GlossaryEntry>)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>> IReadOnlyListString => _IReadOnlyListString ?? (_IReadOnlyListString = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<string>)));

	public JsonTypeInfo<List<MqbsEntry>> ListMqbsEntry => _ListMqbsEntry ?? (_ListMqbsEntry = (JsonTypeInfo<List<MqbsEntry>>)base.Options.GetTypeInfo(typeof(List<MqbsEntry>)));

	public JsonTypeInfo<List<GlossaryEntry>> ListGlossaryEntry => _ListGlossaryEntry ?? (_ListGlossaryEntry = (JsonTypeInfo<List<GlossaryEntry>>)base.Options.GetTypeInfo(typeof(List<GlossaryEntry>)));

	public JsonTypeInfo<DateTimeOffset> DateTimeOffset => _DateTimeOffset ?? (_DateTimeOffset = (JsonTypeInfo<DateTimeOffset>)base.Options.GetTypeInfo(typeof(DateTimeOffset)));

	public JsonTypeInfo<JsonElement> JsonElement => _JsonElement ?? (_JsonElement = (JsonTypeInfo<JsonElement>)base.Options.GetTypeInfo(typeof(JsonElement)));

	public JsonTypeInfo<int> Int32 => _Int32 ?? (_Int32 = (JsonTypeInfo<int>)base.Options.GetTypeInfo(typeof(int)));

	public JsonTypeInfo<int?> NullableInt32 => _NullableInt32 ?? (_NullableInt32 = (JsonTypeInfo<int?>)base.Options.GetTypeInfo(typeof(int?)));

	public JsonTypeInfo<long> Int64 => _Int64 ?? (_Int64 = (JsonTypeInfo<long>)base.Options.GetTypeInfo(typeof(long)));

	public JsonTypeInfo<string> String => _String ?? (_String = (JsonTypeInfo<string>)base.Options.GetTypeInfo(typeof(string)));

	[field: CompilerGenerated]
	public static i Default
	{
		[CompilerGenerated]
		get;
	} = new i(new JsonSerializerOptions(s_defaultOptions));


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

	private JsonTypeInfo<double> B(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<double> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<double>(P_0, JsonMetadataServices.DoubleConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<LearnedShape> b(JsonSerializerOptions P_0)
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
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => C(options),
				ConstructorParameterMetadataInitializer = A,
				SerializeHandler = null
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] C(JsonSerializerOptions P_0)
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

	private JsonTypeInfo<ShapeDescriptor> c(JsonSerializerOptions P_0)
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
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => D(options),
				ConstructorParameterMetadataInitializer = a,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] D(JsonSerializerOptions P_0)
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
		P_0.WriteString(PropName_family, value.Family);
		P_0.WriteString(PropName_class, value.Class);
		P_0.WriteString(PropName_fieldPath, value.FieldPath);
		P_0.WriteString(PropName_encoding, value.Encoding);
		P_0.WriteString(PropName_newline, value.Newline);
		P_0.WriteString(PropName_separator, value.Separator);
		P_0.WritePropertyName(PropName_hasHeader);
		JsonSerializer.Serialize(P_0, value.HasHeader, NullableBoolean);
		P_0.WritePropertyName(PropName_column);
		JsonSerializer.Serialize(P_0, value.Column, NullableInt32);
		P_0.WriteString(PropName_keyPath, value.KeyPath);
		P_0.WritePropertyName(PropName_quoted);
		JsonSerializer.Serialize(P_0, value.Quoted, NullableBoolean);
		P_0.WritePropertyName(PropName_inner);
		A(P_0, value.Inner);
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

	private JsonTypeInfo<TextPlaceKind> d(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<TextPlaceKind> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<TextPlaceKind>(P_0, JsonMetadataServices.GetEnumConverter<TextPlaceKind>(P_0));
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<MqbsEntry> E(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<MqbsEntry> jsonTypeInfo))
		{
			JsonObjectInfoValues<MqbsEntry> objectInfo = new JsonObjectInfoValues<MqbsEntry>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new MqbsEntry
				{
					Key = (string)P_0[0],
					Source = (string)P_0[1],
					Target = (string)P_0[2],
					Reviewed = (bool)P_0[3]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => e(options),
				ConstructorParameterMetadataInitializer = B,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] e(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[4];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsEntry),
			Converter = null,
			Getter = (object P_0) => ((MqbsEntry)P_0).Key,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mv(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MW()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		array[0].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsEntry),
			Converter = null,
			Getter = (object P_0) => ((MqbsEntry)P_0).Source,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mw(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MX()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo3 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsEntry),
			Converter = null,
			Getter = (object P_0) => ((MqbsEntry)P_0).Target,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mx(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MY()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		array[2].IsRequired = true;
		JsonPropertyInfoValues<bool> propertyInfo4 = new JsonPropertyInfoValues<bool>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsEntry),
			Converter = null,
			Getter = (object P_0) => ((MqbsEntry)P_0).Reviewed,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.My(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.MZ()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		return array;
	}

	private void A(Utf8JsonWriter P_0, MqbsEntry? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteString(PropName_key, value.Key);
		P_0.WriteString(PropName_source, value.Source);
		P_0.WriteString(PropName_target, value.Target);
		P_0.WriteBoolean(PropName_reviewed, value.Reviewed);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] B()
	{
		return new JsonParameterInfoValues[4]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mv(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mw(),
				ParameterType = typeof(string),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mx(),
				ParameterType = typeof(string),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.My(),
				ParameterType = typeof(bool),
				Position = 3
			}
		};
	}

	private JsonTypeInfo<MqbsInstall> F(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<MqbsInstall> jsonTypeInfo))
		{
			JsonObjectInfoValues<MqbsInstall> objectInfo = new JsonObjectInfoValues<MqbsInstall>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new MqbsInstall
				{
					Method = (string)P_0[0],
					EngineId = (string)P_0[1]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => f(options),
				ConstructorParameterMetadataInitializer = b,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] f(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[3];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsInstall),
			Converter = null,
			Getter = (object P_0) => ((MqbsInstall)P_0).Method,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mz(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mA()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		array[0].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsInstall),
			Converter = null,
			Getter = (object P_0) => ((MqbsInstall)P_0).EngineId,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ma(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mB()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<bool> propertyInfo3 = new JsonPropertyInfoValues<bool>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsInstall),
			Converter = null,
			Getter = (object P_0) => ((MqbsInstall)P_0).IsRuntimeLayer,
			Setter = null,
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mb(),
			JsonPropertyName = null
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		return array;
	}

	private void A(Utf8JsonWriter P_0, MqbsInstall? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteString(PropName_method, value.Method);
		P_0.WriteString(PropName_engineId, value.EngineId);
		P_0.WriteBoolean(PropName_IsRuntimeLayer, value.IsRuntimeLayer);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] b()
	{
		return new JsonParameterInfoValues[2]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Mz(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ma(),
				ParameterType = typeof(string),
				Position = 1
			}
		};
	}

	private JsonTypeInfo<MqbsManifest> G(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<MqbsManifest> jsonTypeInfo))
		{
			JsonObjectInfoValues<MqbsManifest> objectInfo = new JsonObjectInfoValues<MqbsManifest>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new MqbsManifest
				{
					MqbsVersion = (int)P_0[0],
					GameFingerprint = (string)P_0[1],
					GameName = (string)P_0[2],
					EngineId = (string)P_0[3],
					EngineVersion = (string)P_0[4],
					Coverage = (double)P_0[5],
					TranslatedCount = (int)P_0[6],
					HumanReviewed = (double)P_0[7],
					Author = (string)P_0[8],
					CreatedAt = (DateTimeOffset)P_0[9],
					SourceLang = (string)P_0[10],
					StyleProfile = (string)P_0[11],
					Fonts = (System.Collections.Generic.IReadOnlyList<string>)P_0[12]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => g(options),
				ConstructorParameterMetadataInitializer = C,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] g(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[13];
		JsonPropertyInfoValues<int> propertyInfo = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).MqbsVersion,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mC(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mc()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).GameFingerprint,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mD(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.md()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo3 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).GameName,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mE(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.me()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<string> propertyInfo4 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).EngineId,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ma(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mB()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		array[3].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo5 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).EngineVersion,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mF(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mf()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		JsonPropertyInfoValues<double> propertyInfo6 = new JsonPropertyInfoValues<double>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).Coverage,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mG(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mg()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		JsonPropertyInfoValues<int> propertyInfo7 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).TranslatedCount,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mH(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mh()
		};
		array[6] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo7);
		JsonPropertyInfoValues<double> propertyInfo8 = new JsonPropertyInfoValues<double>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).HumanReviewed,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mI(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mi()
		};
		array[7] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo8);
		JsonPropertyInfoValues<string> propertyInfo9 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).Author,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mJ(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mj()
		};
		array[8] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo9);
		JsonPropertyInfoValues<DateTimeOffset> propertyInfo10 = new JsonPropertyInfoValues<DateTimeOffset>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).CreatedAt,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mK(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mk()
		};
		array[9] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo10);
		array[9].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo11 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).SourceLang,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mL(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ml()
		};
		array[10] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo11);
		JsonPropertyInfoValues<string> propertyInfo12 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).StyleProfile,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eZ(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mM()
		};
		array[11] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo12);
		JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<string>> propertyInfo13 = new JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<string>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(MqbsManifest),
			Converter = null,
			Getter = (object P_0) => ((MqbsManifest)P_0).Fonts,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mm(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mN()
		};
		array[12] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo13);
		return array;
	}

	private void A(Utf8JsonWriter P_0, MqbsManifest? value)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteNumber(PropName_mqbsVersion, value.MqbsVersion);
		P_0.WriteString(PropName_gameFingerprint, value.GameFingerprint);
		P_0.WriteString(PropName_gameName, value.GameName);
		P_0.WriteString(PropName_engineId, value.EngineId);
		P_0.WriteString(PropName_engineVersion, value.EngineVersion);
		P_0.WriteNumber(PropName_coverage, value.Coverage);
		P_0.WriteNumber(PropName_translatedCount, value.TranslatedCount);
		P_0.WriteNumber(PropName_humanReviewed, value.HumanReviewed);
		P_0.WriteString(PropName_author, value.Author);
		P_0.WriteString(PropName_createdAt, value.CreatedAt);
		P_0.WriteString(PropName_sourceLang, value.SourceLang);
		P_0.WriteString(PropName_styleProfile, value.StyleProfile);
		P_0.WritePropertyName(PropName_fonts);
		A(P_0, value.Fonts);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] C()
	{
		return new JsonParameterInfoValues[13]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mC(),
				ParameterType = typeof(int),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mD(),
				ParameterType = typeof(string),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mE(),
				ParameterType = typeof(string),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ma(),
				ParameterType = typeof(string),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mF(),
				ParameterType = typeof(string),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mG(),
				ParameterType = typeof(double),
				Position = 5
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mH(),
				ParameterType = typeof(int),
				Position = 6
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mI(),
				ParameterType = typeof(double),
				Position = 7
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mJ(),
				ParameterType = typeof(string),
				Position = 8
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mK(),
				ParameterType = typeof(DateTimeOffset),
				Position = 9
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mL(),
				ParameterType = typeof(string),
				Position = 10
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.eZ(),
				ParameterType = typeof(string),
				Position = 11
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mm(),
				ParameterType = typeof(System.Collections.Generic.IReadOnlyList<string>),
				Position = 12
			}
		};
	}

	private JsonTypeInfo<GlossaryEntry> H(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<GlossaryEntry> jsonTypeInfo))
		{
			JsonObjectInfoValues<GlossaryEntry> objectInfo = new JsonObjectInfoValues<GlossaryEntry>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new GlossaryEntry
				{
					Term = (string)P_0[0],
					Translation = (string)P_0[1],
					Kind = (GlossaryKind)P_0[2],
					Locked = (bool)P_0[3]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => h(options),
				ConstructorParameterMetadataInitializer = c,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] h(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[4];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(GlossaryEntry),
			Converter = null,
			Getter = (object P_0) => ((GlossaryEntry)P_0).Term,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mn(),
			JsonPropertyName = null
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		array[0].IsRequired = true;
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(GlossaryEntry),
			Converter = null,
			Getter = (object P_0) => ((GlossaryEntry)P_0).Translation,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mO(),
			JsonPropertyName = null
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		array[1].IsRequired = true;
		JsonPropertyInfoValues<GlossaryKind> propertyInfo3 = new JsonPropertyInfoValues<GlossaryKind>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(GlossaryEntry),
			Converter = null,
			Getter = (object P_0) => ((GlossaryEntry)P_0).Kind,
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
			JsonPropertyName = null
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<bool> propertyInfo4 = new JsonPropertyInfoValues<bool>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(GlossaryEntry),
			Converter = null,
			Getter = (object P_0) => ((GlossaryEntry)P_0).Locked,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mo(),
			JsonPropertyName = null
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		return array;
	}

	private void A(Utf8JsonWriter P_0, GlossaryEntry? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteString(PropName_Term, value.Term);
		P_0.WriteString(PropName_Translation, value.Translation);
		P_0.WritePropertyName(PropName_Kind);
		JsonSerializer.Serialize(P_0, value.Kind, GlossaryKind);
		P_0.WriteBoolean(PropName_Locked, value.Locked);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] c()
	{
		return new JsonParameterInfoValues[4]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mn(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mO(),
				ParameterType = typeof(string),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap(),
				ParameterType = typeof(GlossaryKind),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mo(),
				ParameterType = typeof(bool),
				Position = 3
			}
		};
	}

	private JsonTypeInfo<GlossaryKind> I(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<GlossaryKind> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<GlossaryKind>(P_0, JsonMetadataServices.GetEnumConverter<GlossaryKind>(P_0));
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<LearnedShape>> i(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<LearnedShape>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<LearnedShape>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<LearnedShape>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<LearnedShape>, LearnedShape>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<LearnedShape>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<LearnedShape> enumerator = ((System.Collections.Generic.IEnumerable<LearnedShape>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				LearnedShape current = enumerator.Current;
				JsonSerializer.Serialize(P_0, current, LearnedShape);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<MqbsEntry>> J(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<MqbsEntry>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<MqbsEntry>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<MqbsEntry>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<MqbsEntry>, MqbsEntry>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<MqbsEntry>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<MqbsEntry> enumerator = ((System.Collections.Generic.IEnumerable<MqbsEntry>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				MqbsEntry current = enumerator.Current;
				A(P_0, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<GlossaryEntry>> j(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<GlossaryEntry>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<GlossaryEntry>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<GlossaryEntry>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<GlossaryEntry>, GlossaryEntry>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<GlossaryEntry>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<GlossaryEntry> enumerator = ((System.Collections.Generic.IEnumerable<GlossaryEntry>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				GlossaryEntry current = enumerator.Current;
				A(P_0, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>> K(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<string>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<string>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<string>, string>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<string>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string current = enumerator.Current;
				P_0.WriteStringValue(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<List<MqbsEntry>> k(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<List<MqbsEntry>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<List<MqbsEntry>> collectionInfo = new JsonCollectionInfoValues<List<MqbsEntry>>
			{
				ObjectCreator = () => new List<MqbsEntry>(),
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<MqbsEntry>, MqbsEntry>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, List<MqbsEntry>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		for (int l = 0; l < value.Count; l++)
		{
			A(P_0, value[l]);
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<List<GlossaryEntry>> L(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<List<GlossaryEntry>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<List<GlossaryEntry>> collectionInfo = new JsonCollectionInfoValues<List<GlossaryEntry>>
			{
				ObjectCreator = () => new List<GlossaryEntry>(),
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateListInfo<List<GlossaryEntry>, GlossaryEntry>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, List<GlossaryEntry>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		for (int l = 0; l < value.Count; l++)
		{
			A(P_0, value[l]);
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<DateTimeOffset> l(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<DateTimeOffset> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<DateTimeOffset>(P_0, JsonMetadataServices.DateTimeOffsetConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<JsonElement> M(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<JsonElement> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<JsonElement>(P_0, JsonMetadataServices.JsonElementConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<int> m(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<int> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int>(P_0, JsonMetadataServices.Int32Converter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<int?> N(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<int?> jsonTypeInfo))
		{
			JsonConverter nullableConverter = JsonMetadataServices.GetNullableConverter<int>(P_0);
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int?>(P_0, nullableConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<long> n(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<long> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<long>(P_0, JsonMetadataServices.Int64Converter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<string> O(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<string> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<string>(P_0, JsonMetadataServices.StringConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	public i()
		: base(null)
	{
	}

	public i(JsonSerializerOptions P_0)
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
		if (P_0 == typeof(double))
		{
			return B(P_1);
		}
		if (P_0 == typeof(LearnedShape))
		{
			return b(P_1);
		}
		if (P_0 == typeof(ShapeDescriptor))
		{
			return c(P_1);
		}
		if (P_0 == typeof(TextPlaceKind))
		{
			return d(P_1);
		}
		if (P_0 == typeof(MqbsEntry))
		{
			return E(P_1);
		}
		if (P_0 == typeof(MqbsInstall))
		{
			return F(P_1);
		}
		if (P_0 == typeof(MqbsManifest))
		{
			return G(P_1);
		}
		if (P_0 == typeof(GlossaryEntry))
		{
			return H(P_1);
		}
		if (P_0 == typeof(GlossaryKind))
		{
			return I(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<LearnedShape>))
		{
			return i(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<MqbsEntry>))
		{
			return J(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<GlossaryEntry>))
		{
			return j(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<string>))
		{
			return K(P_1);
		}
		if (P_0 == typeof(List<MqbsEntry>))
		{
			return k(P_1);
		}
		if (P_0 == typeof(List<GlossaryEntry>))
		{
			return L(P_1);
		}
		if (P_0 == typeof(DateTimeOffset))
		{
			return l(P_1);
		}
		if (P_0 == typeof(JsonElement))
		{
			return M(P_1);
		}
		if (P_0 == typeof(int))
		{
			return m(P_1);
		}
		if (P_0 == typeof(int?))
		{
			return N(P_1);
		}
		if (P_0 == typeof(long))
		{
			return n(P_1);
		}
		if (P_0 == typeof(string))
		{
			return O(P_1);
		}
		return null;
	}

	JsonTypeInfo? IJsonTypeInfoResolver.GetTypeInfo(System.Type P_0, JsonSerializerOptions P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0, P_1);
	}
}
