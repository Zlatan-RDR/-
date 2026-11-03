using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using _003CPrivateImplementationDetails_003E_007BA96D5846_002D01F9_002D474C_002D8984_002D475E97C7828B_007D;
using Miqbas.Engines.Unity.Hooking;

namespace A;

[JsonSerializable(typeof(TheLoadersBuiltFiles.A))]
[GeneratedCode("System.Text.Json.SourceGeneration", "8.0.10.36612")]
internal sealed class A : JsonSerializerContext, IJsonTypeInfoResolver
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<JsonParameterInfoValues[]> _003C0_003E__ManifestCtorParamInit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<object[], TheLoadersBuiltFiles.A> _003C_003E9__3_0;

		public static Func<object, string?> _003C_003E9__4_0;

		public static Action<object, string?> _003C_003E9__4_1;

		public static Func<object, string?> _003C_003E9__4_2;

		public static Action<object, string?> _003C_003E9__4_3;

		public static Func<object, string?> _003C_003E9__4_4;

		public static Action<object, string?> _003C_003E9__4_5;

		public static Func<object, string?> _003C_003E9__4_6;

		public static Action<object, string?> _003C_003E9__4_7;

		public static Func<object, System.DateTime> _003C_003E9__4_8;

		public static Action<object, System.DateTime> _003C_003E9__4_9;

		public static Func<object, Dictionary<string, string>?> _003C_003E9__4_10;

		public static Action<object, Dictionary<string, string>?> _003C_003E9__4_11;

		public static Func<Dictionary<string, string>> _003C_003E9__10_0;

		internal TheLoadersBuiltFiles.A A(object[] P_0)
		{
			return new TheLoadersBuiltFiles.A
			{
				GameRoot = (string)P_0[0],
				Game = (string)P_0[1],
				Loader = (string)P_0[2],
				Miqbas = (string)P_0[3],
				At = (System.DateTime)P_0[4],
				Files = (Dictionary<string, string>)P_0[5]
			};
		}

		internal string? A(object P_0)
		{
			return ((TheLoadersBuiltFiles.A)P_0).GameRoot;
		}

		internal void A(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
		}

		internal string? a(object P_0)
		{
			return ((TheLoadersBuiltFiles.A)P_0).Game;
		}

		internal void a(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
		}

		internal string? B(object P_0)
		{
			return ((TheLoadersBuiltFiles.A)P_0).Loader;
		}

		internal void B(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
		}

		internal string? b(object P_0)
		{
			return ((TheLoadersBuiltFiles.A)P_0).Miqbas;
		}

		internal void b(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
		}

		internal System.DateTime C(object P_0)
		{
			return ((TheLoadersBuiltFiles.A)P_0).At;
		}

		internal void A(object P_0, System.DateTime P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
		}

		internal Dictionary<string, string>? c(object P_0)
		{
			return ((TheLoadersBuiltFiles.A)P_0).Files;
		}

		internal void A(object P_0, Dictionary<string, string>? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
		}

		internal Dictionary<string, string> A()
		{
			return new Dictionary<string, string>();
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return a(options);
		}
	}

	private JsonTypeInfo<TheLoadersBuiltFiles.A>? _Manifest;

	private JsonTypeInfo<Dictionary<string, string>>? _DictionaryStringString;

	private JsonTypeInfo<System.DateTime>? _DateTime;

	private JsonTypeInfo<string>? _String;

	private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions();

	private static readonly JsonEncodedText PropName_gameRoot = JsonEncodedText.Encode(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aA());

	private static readonly JsonEncodedText PropName_game = JsonEncodedText.Encode(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aO());

	private static readonly JsonEncodedText PropName_loader = JsonEncodedText.Encode(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aP());

	private static readonly JsonEncodedText PropName_miqbas = JsonEncodedText.Encode(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ap());

	private static readonly JsonEncodedText PropName_at = JsonEncodedText.Encode(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aq());

	private static readonly JsonEncodedText PropName_files = JsonEncodedText.Encode(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ar());

	public JsonTypeInfo<TheLoadersBuiltFiles.A> Manifest => _Manifest ?? (_Manifest = (JsonTypeInfo<TheLoadersBuiltFiles.A>)base.Options.GetTypeInfo(typeof(TheLoadersBuiltFiles.A)));

	public JsonTypeInfo<Dictionary<string, string>> DictionaryStringString => _DictionaryStringString ?? (_DictionaryStringString = (JsonTypeInfo<Dictionary<string, string>>)base.Options.GetTypeInfo(typeof(Dictionary<string, string>)));

	public JsonTypeInfo<System.DateTime> DateTime => _DateTime ?? (_DateTime = (JsonTypeInfo<System.DateTime>)base.Options.GetTypeInfo(typeof(System.DateTime)));

	public JsonTypeInfo<string> String => _String ?? (_String = (JsonTypeInfo<string>)base.Options.GetTypeInfo(typeof(string)));

	[field: CompilerGenerated]
	public static global::A.A Default
	{
		[CompilerGenerated]
		get;
	} = new global::A.A(new JsonSerializerOptions(s_defaultOptions));


	[field: CompilerGenerated]
	protected override JsonSerializerOptions? GeneratedSerializerOptions
	{
		[CompilerGenerated]
		get;
	} = s_defaultOptions;


	private JsonTypeInfo<TheLoadersBuiltFiles.A> A(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<TheLoadersBuiltFiles.A> jsonTypeInfo))
		{
			JsonObjectInfoValues<TheLoadersBuiltFiles.A> objectInfo = new JsonObjectInfoValues<TheLoadersBuiltFiles.A>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new TheLoadersBuiltFiles.A
				{
					GameRoot = (string)P_0[0],
					Game = (string)P_0[1],
					Loader = (string)P_0[2],
					Miqbas = (string)P_0[3],
					At = (System.DateTime)P_0[4],
					Files = (Dictionary<string, string>)P_0[5]
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
		JsonPropertyInfo[] array = new JsonPropertyInfo[6];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheLoadersBuiltFiles.A),
			Converter = null,
			Getter = (object P_0) => ((TheLoadersBuiltFiles.A)P_0).GameRoot,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aN(),
			JsonPropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aA()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheLoadersBuiltFiles.A),
			Converter = null,
			Getter = (object P_0) => ((TheLoadersBuiltFiles.A)P_0).Game,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.an(),
			JsonPropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aO()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		JsonPropertyInfoValues<string> propertyInfo3 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheLoadersBuiltFiles.A),
			Converter = null,
			Getter = (object P_0) => ((TheLoadersBuiltFiles.A)P_0).Loader,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ao(),
			JsonPropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aP()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<string> propertyInfo4 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheLoadersBuiltFiles.A),
			Converter = null,
			Getter = (object P_0) => ((TheLoadersBuiltFiles.A)P_0).Miqbas,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aM(),
			JsonPropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ap()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		JsonPropertyInfoValues<System.DateTime> propertyInfo5 = new JsonPropertyInfoValues<System.DateTime>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheLoadersBuiltFiles.A),
			Converter = null,
			Getter = (object P_0) => ((TheLoadersBuiltFiles.A)P_0).At,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aQ(),
			JsonPropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aq()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		JsonPropertyInfoValues<Dictionary<string, string>> propertyInfo6 = new JsonPropertyInfoValues<Dictionary<string, string>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheLoadersBuiltFiles.A),
			Converter = null,
			Getter = (object P_0) => ((TheLoadersBuiltFiles.A)P_0).Files,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.Cg());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aR(),
			JsonPropertyName = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ar()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		return array;
	}

	private void A(Utf8JsonWriter P_0, TheLoadersBuiltFiles.A? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteString(PropName_gameRoot, value.GameRoot);
		P_0.WriteString(PropName_game, value.Game);
		P_0.WriteString(PropName_loader, value.Loader);
		P_0.WriteString(PropName_miqbas, value.Miqbas);
		P_0.WriteString(PropName_at, value.At);
		P_0.WritePropertyName(PropName_files);
		A(P_0, value.Files);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] A()
	{
		return new JsonParameterInfoValues[6]
		{
			new JsonParameterInfoValues
			{
				Name = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aN(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.an(),
				ParameterType = typeof(string),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.ao(),
				ParameterType = typeof(string),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aM(),
				ParameterType = typeof(string),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aQ(),
				ParameterType = typeof(System.DateTime),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = _7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aR(),
				ParameterType = typeof(Dictionary<string, string>),
				Position = 5
			}
		};
	}

	private JsonTypeInfo<Dictionary<string, string>> B(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<Dictionary<string, string>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<Dictionary<string, string>> collectionInfo = new JsonCollectionInfoValues<Dictionary<string, string>>
			{
				ObjectCreator = () => new Dictionary<string, string>(),
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateDictionaryInfo<Dictionary<string, string>, string, string>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, Dictionary<string, string>? value)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		Enumerator<string, string> enumerator = value.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, string> current = enumerator.Current;
				P_0.WriteString(current.Key, current.Value);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		P_0.WriteEndObject();
	}

	private JsonTypeInfo<System.DateTime> b(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.DateTime> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<System.DateTime>(P_0, JsonMetadataServices.DateTimeConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<string> C(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<string> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<string>(P_0, JsonMetadataServices.StringConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	public A()
		: base(null)
	{
	}

	public A(JsonSerializerOptions P_0)
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
			throw new InvalidOperationException(string.Format(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.aS(), (object)((object)P_1).GetType(), (object)P_0));
		}
		if (P_1 is JsonConverterFactory jsonConverterFactory)
		{
			P_1 = jsonConverterFactory.CreateConverter(P_0, P_2);
			if (P_1 == null || P_1 is JsonConverterFactory)
			{
				throw new InvalidOperationException(string.Format(_7201F167_002D10F2_002D4326_002DBE43_002D755EF35C5212.@as(), (object)((object)jsonConverterFactory).GetType()));
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
		if (P_0 == typeof(TheLoadersBuiltFiles.A))
		{
			return A(P_1);
		}
		if (P_0 == typeof(Dictionary<string, string>))
		{
			return B(P_1);
		}
		if (P_0 == typeof(System.DateTime))
		{
			return b(P_1);
		}
		if (P_0 == typeof(string))
		{
			return C(P_1);
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
internal sealed class a
{
}
