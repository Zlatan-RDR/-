using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;
using Miqbas.Core.Text;
using Miqbas.Core.Trees;

namespace A;

[JsonSerializable(typeof(TreeNode))]
[JsonSerializable(typeof(IReadOnlyDictionary<string, string>))]
[GeneratedCode("System.Text.Json.SourceGeneration", "8.0.10.36612")]
internal sealed class G : JsonSerializerContext, IJsonTypeInfoResolver
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<JsonParameterInfoValues[]> _003C0_003E__TreeNodeCtorParamInit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<object[], TreeNode> _003C_003E9__3_0;

		public static Func<object, string?> _003C_003E9__4_0;

		public static Action<object, string?> _003C_003E9__4_1;

		public static Func<object, string?> _003C_003E9__4_2;

		public static Action<object, string?> _003C_003E9__4_3;

		public static Func<object, int> _003C_003E9__4_4;

		public static Action<object, int> _003C_003E9__4_5;

		public static Func<object, string?> _003C_003E9__4_6;

		public static Action<object, string?> _003C_003E9__4_7;

		public static Func<object, string?> _003C_003E9__4_8;

		public static Action<object, string?> _003C_003E9__4_9;

		public static Func<object, System.Collections.Generic.IReadOnlyList<string>?> _003C_003E9__4_10;

		public static Action<object, System.Collections.Generic.IReadOnlyList<string>?> _003C_003E9__4_11;

		public static Func<object, System.Collections.Generic.IReadOnlyList<TreeNode>?> _003C_003E9__4_12;

		public static Action<object, System.Collections.Generic.IReadOnlyList<TreeNode>?> _003C_003E9__4_13;

		public static Func<IReadOnlyDictionary<string, string>> _003C_003E9__10_0;

		internal TreeNode A(object[] P_0)
		{
			return new TreeNode
			{
				Label = (string)P_0[0],
				Sub = (string)P_0[1],
				Count = (int)P_0[2],
				Kind = (string)P_0[3],
				Accept = (string)P_0[4],
				Games = (System.Collections.Generic.IReadOnlyList<string>)P_0[5],
				Kids = (System.Collections.Generic.IReadOnlyList<TreeNode>)P_0[6]
			};
		}

		internal string? A(object P_0)
		{
			return ((TreeNode)P_0).Label;
		}

		internal void A(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? a(object P_0)
		{
			return ((TreeNode)P_0).Sub;
		}

		internal void a(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int B(object P_0)
		{
			return ((TreeNode)P_0).Count;
		}

		internal void A(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? b(object P_0)
		{
			return ((TreeNode)P_0).Kind;
		}

		internal void B(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal string? C(object P_0)
		{
			return ((TreeNode)P_0).Accept;
		}

		internal void b(object P_0, string? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal System.Collections.Generic.IReadOnlyList<string>? c(object P_0)
		{
			return ((TreeNode)P_0).Games;
		}

		internal void A(object P_0, System.Collections.Generic.IReadOnlyList<string>? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal System.Collections.Generic.IReadOnlyList<TreeNode>? D(object P_0)
		{
			return ((TreeNode)P_0).Kids;
		}

		internal void A(object P_0, System.Collections.Generic.IReadOnlyList<TreeNode>? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal IReadOnlyDictionary<string, string> A()
		{
			return (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>();
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

	private JsonTypeInfo<TreeNode>? _TreeNode;

	private JsonTypeInfo<IReadOnlyDictionary<string, string>>? _IReadOnlyDictionaryStringString;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<TreeNode>>? _IReadOnlyListTreeNode;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>>? _IReadOnlyListString;

	private JsonTypeInfo<int>? _Int32;

	private JsonTypeInfo<string>? _String;

	private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions();

	private static readonly JsonEncodedText PropName_label = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aN());

	private static readonly JsonEncodedText PropName_sub = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aO());

	private static readonly JsonEncodedText PropName_n = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aP());

	private static readonly JsonEncodedText PropName_kind = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aQ());

	private static readonly JsonEncodedText PropName_accept = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aR());

	private static readonly JsonEncodedText PropName_games = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aS());

	private static readonly JsonEncodedText PropName_kids = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aT());

	public JsonTypeInfo<TreeNode> TreeNode => _TreeNode ?? (_TreeNode = (JsonTypeInfo<TreeNode>)base.Options.GetTypeInfo(typeof(TreeNode)));

	public JsonTypeInfo<IReadOnlyDictionary<string, string>> IReadOnlyDictionaryStringString => _IReadOnlyDictionaryStringString ?? (_IReadOnlyDictionaryStringString = (JsonTypeInfo<IReadOnlyDictionary<string, string>>)base.Options.GetTypeInfo(typeof(IReadOnlyDictionary<string, string>)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<TreeNode>> IReadOnlyListTreeNode => _IReadOnlyListTreeNode ?? (_IReadOnlyListTreeNode = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<TreeNode>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<TreeNode>)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>> IReadOnlyListString => _IReadOnlyListString ?? (_IReadOnlyListString = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<string>)));

	public JsonTypeInfo<int> Int32 => _Int32 ?? (_Int32 = (JsonTypeInfo<int>)base.Options.GetTypeInfo(typeof(int)));

	public JsonTypeInfo<string> String => _String ?? (_String = (JsonTypeInfo<string>)base.Options.GetTypeInfo(typeof(string)));

	[field: CompilerGenerated]
	public static G Default
	{
		[CompilerGenerated]
		get;
	} = new G(new JsonSerializerOptions(s_defaultOptions));


	[field: CompilerGenerated]
	protected override JsonSerializerOptions? GeneratedSerializerOptions
	{
		[CompilerGenerated]
		get;
	} = s_defaultOptions;


	private JsonTypeInfo<TreeNode> A(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<TreeNode> jsonTypeInfo))
		{
			JsonObjectInfoValues<TreeNode> objectInfo = new JsonObjectInfoValues<TreeNode>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new TreeNode
				{
					Label = (string)P_0[0],
					Sub = (string)P_0[1],
					Count = (int)P_0[2],
					Kind = (string)P_0[3],
					Accept = (string)P_0[4],
					Games = (System.Collections.Generic.IReadOnlyList<string>)P_0[5],
					Kids = (System.Collections.Generic.IReadOnlyList<TreeNode>)P_0[6]
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
		JsonPropertyInfo[] array = new JsonPropertyInfo[7];
		JsonPropertyInfoValues<string> propertyInfo = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Label,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.am(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aN()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<string> propertyInfo2 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Sub,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.an(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aO()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		JsonPropertyInfoValues<int> propertyInfo3 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Count,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ao(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aP()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<string> propertyInfo4 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Kind,
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
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		JsonPropertyInfoValues<string> propertyInfo5 = new JsonPropertyInfoValues<string>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Accept,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aq(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aR()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<string>> propertyInfo6 = new JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<string>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Games,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ar(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aS()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<TreeNode>> propertyInfo7 = new JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<TreeNode>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TreeNode),
			Converter = null,
			Getter = (object P_0) => ((TreeNode)P_0).Kids,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@as(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aT()
		};
		array[6] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo7);
		return array;
	}

	private void A(Utf8JsonWriter P_0, TreeNode? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteString(PropName_label, value.Label);
		P_0.WriteString(PropName_sub, value.Sub);
		P_0.WriteNumber(PropName_n, value.Count);
		P_0.WriteString(PropName_kind, value.Kind);
		P_0.WriteString(PropName_accept, value.Accept);
		P_0.WritePropertyName(PropName_games);
		A(P_0, value.Games);
		P_0.WritePropertyName(PropName_kids);
		A(P_0, value.Kids);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] A()
	{
		return new JsonParameterInfoValues[7]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.am(),
				ParameterType = typeof(string),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.an(),
				ParameterType = typeof(string),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ao(),
				ParameterType = typeof(int),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ap(),
				ParameterType = typeof(string),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.aq(),
				ParameterType = typeof(string),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ar(),
				ParameterType = typeof(System.Collections.Generic.IReadOnlyList<string>),
				Position = 5
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@as(),
				ParameterType = typeof(System.Collections.Generic.IReadOnlyList<TreeNode>),
				Position = 6
			}
		};
	}

	private JsonTypeInfo<IReadOnlyDictionary<string, string>> B(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<IReadOnlyDictionary<string, string>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<IReadOnlyDictionary<string, string>> collectionInfo = new JsonCollectionInfoValues<IReadOnlyDictionary<string, string>>
			{
				ObjectCreator = () => (IReadOnlyDictionary<string, string>)(object)new Dictionary<string, string>(),
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIReadOnlyDictionaryInfo<IReadOnlyDictionary<string, string>, string, string>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, IReadOnlyDictionary<string, string>? value)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		System.Collections.Generic.IEnumerator<KeyValuePair<string, string>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				KeyValuePair<string, string> current = enumerator.Current;
				P_0.WriteString(current.Key, current.Value);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndObject();
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<TreeNode>> b(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<TreeNode>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<TreeNode>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<TreeNode>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<TreeNode>, TreeNode>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<TreeNode>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<TreeNode> enumerator = ((System.Collections.Generic.IEnumerable<TreeNode>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				TreeNode current = enumerator.Current;
				A(P_0, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<string>> C(JsonSerializerOptions P_0)
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

	private JsonTypeInfo<int> c(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<int> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int>(P_0, JsonMetadataServices.Int32Converter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
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

	public G()
		: base(null)
	{
	}

	public G(JsonSerializerOptions P_0)
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
		if (P_0 == typeof(TreeNode))
		{
			return A(P_1);
		}
		if (P_0 == typeof(IReadOnlyDictionary<string, string>))
		{
			return B(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<TreeNode>))
		{
			return b(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<string>))
		{
			return C(P_1);
		}
		if (P_0 == typeof(int))
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
[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
[JsonSerializable(typeof(TheBakedFaceRecord))]
[GeneratedCode("System.Text.Json.SourceGeneration", "8.0.10.36612")]
internal sealed class g : JsonSerializerContext, IJsonTypeInfoResolver
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<JsonParameterInfoValues[]> _003C0_003E__ABakedCharacterCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C1_003E__ABakedGlyphCtorParamInit;

		public static Func<JsonParameterInfoValues[]> _003C2_003E__TheBakedFaceRecordCtorParamInit;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class a
	{
		public static readonly a _003C_003E9 = new a();

		public static Func<object[], ABakedCharacter> _003C_003E9__7_0;

		public static Func<object, int> _003C_003E9__8_0;

		public static Action<object, int> _003C_003E9__8_1;

		public static Func<object, int> _003C_003E9__8_2;

		public static Action<object, int> _003C_003E9__8_3;

		public static Func<object[], ABakedGlyph> _003C_003E9__14_0;

		public static Func<object, int> _003C_003E9__15_0;

		public static Action<object, int> _003C_003E9__15_1;

		public static Func<object, int> _003C_003E9__15_2;

		public static Action<object, int> _003C_003E9__15_3;

		public static Func<object, int> _003C_003E9__15_4;

		public static Action<object, int> _003C_003E9__15_5;

		public static Func<object, int> _003C_003E9__15_6;

		public static Action<object, int> _003C_003E9__15_7;

		public static Func<object, int> _003C_003E9__15_8;

		public static Action<object, int> _003C_003E9__15_9;

		public static Func<object, float> _003C_003E9__15_10;

		public static Action<object, float> _003C_003E9__15_11;

		public static Func<object, float> _003C_003E9__15_12;

		public static Action<object, float> _003C_003E9__15_13;

		public static Func<object, float> _003C_003E9__15_14;

		public static Action<object, float> _003C_003E9__15_15;

		public static Func<object, float> _003C_003E9__15_16;

		public static Action<object, float> _003C_003E9__15_17;

		public static Func<object, float> _003C_003E9__15_18;

		public static Action<object, float> _003C_003E9__15_19;

		public static Func<object[], TheBakedFaceRecord> _003C_003E9__21_0;

		public static Func<object, float> _003C_003E9__22_0;

		public static Action<object, float> _003C_003E9__22_1;

		public static Func<object, float> _003C_003E9__22_2;

		public static Action<object, float> _003C_003E9__22_3;

		public static Func<object, int> _003C_003E9__22_4;

		public static Action<object, int> _003C_003E9__22_5;

		public static Func<object, int> _003C_003E9__22_6;

		public static Action<object, int> _003C_003E9__22_7;

		public static Func<object, int> _003C_003E9__22_8;

		public static Action<object, int> _003C_003E9__22_9;

		public static Func<object, int> _003C_003E9__22_10;

		public static Action<object, int> _003C_003E9__22_11;

		public static Func<object, float> _003C_003E9__22_12;

		public static Action<object, float> _003C_003E9__22_13;

		public static Func<object, float> _003C_003E9__22_14;

		public static Action<object, float> _003C_003E9__22_15;

		public static Func<object, float> _003C_003E9__22_16;

		public static Action<object, float> _003C_003E9__22_17;

		public static Func<object, float> _003C_003E9__22_18;

		public static Action<object, float> _003C_003E9__22_19;

		public static Func<object, System.Collections.Generic.IReadOnlyList<ABakedGlyph>?> _003C_003E9__22_20;

		public static Action<object, System.Collections.Generic.IReadOnlyList<ABakedGlyph>?> _003C_003E9__22_21;

		public static Func<object, System.Collections.Generic.IReadOnlyList<ABakedCharacter>?> _003C_003E9__22_22;

		public static Action<object, System.Collections.Generic.IReadOnlyList<ABakedCharacter>?> _003C_003E9__22_23;

		internal ABakedCharacter A(object[] P_0)
		{
			return new ABakedCharacter
			{
				Unicode = (int)P_0[0],
				GlyphIndex = (int)P_0[1]
			};
		}

		internal int A(object P_0)
		{
			return ((ABakedCharacter)P_0).Unicode;
		}

		internal void A(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int a(object P_0)
		{
			return ((ABakedCharacter)P_0).GlyphIndex;
		}

		internal void a(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal ABakedGlyph a(object[] P_0)
		{
			return new ABakedGlyph
			{
				Index = (int)P_0[0],
				X = (int)P_0[1],
				Y = (int)P_0[2],
				W = (int)P_0[3],
				H = (int)P_0[4],
				Width = (float)P_0[5],
				Height = (float)P_0[6],
				BearingX = (float)P_0[7],
				BearingY = (float)P_0[8],
				Advance = (float)P_0[9]
			};
		}

		internal int B(object P_0)
		{
			return ((ABakedGlyph)P_0).Index;
		}

		internal void B(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int b(object P_0)
		{
			return ((ABakedGlyph)P_0).X;
		}

		internal void b(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int C(object P_0)
		{
			return ((ABakedGlyph)P_0).Y;
		}

		internal void C(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int c(object P_0)
		{
			return ((ABakedGlyph)P_0).W;
		}

		internal void c(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int D(object P_0)
		{
			return ((ABakedGlyph)P_0).H;
		}

		internal void D(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float d(object P_0)
		{
			return ((ABakedGlyph)P_0).Width;
		}

		internal void A(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float E(object P_0)
		{
			return ((ABakedGlyph)P_0).Height;
		}

		internal void a(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float e(object P_0)
		{
			return ((ABakedGlyph)P_0).BearingX;
		}

		internal void B(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float F(object P_0)
		{
			return ((ABakedGlyph)P_0).BearingY;
		}

		internal void b(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float f(object P_0)
		{
			return ((ABakedGlyph)P_0).Advance;
		}

		internal void C(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal TheBakedFaceRecord B(object[] P_0)
		{
			return new TheBakedFaceRecord
			{
				PointSize = (float)P_0[0],
				Scale = (float)P_0[1],
				Padding = (int)P_0[2],
				AtlasWidth = (int)P_0[3],
				AtlasHeight = (int)P_0[4],
				RenderMode = (int)P_0[5],
				LineHeight = (float)P_0[6],
				AscentLine = (float)P_0[7],
				DescentLine = (float)P_0[8],
				Baseline = (float)P_0[9],
				Glyphs = (System.Collections.Generic.IReadOnlyList<ABakedGlyph>)P_0[10],
				Characters = (System.Collections.Generic.IReadOnlyList<ABakedCharacter>)P_0[11]
			};
		}

		internal float G(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).PointSize;
		}

		internal void c(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float g(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).Scale;
		}

		internal void D(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int H(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).Padding;
		}

		internal void d(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int h(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).AtlasWidth;
		}

		internal void E(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int I(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).AtlasHeight;
		}

		internal void e(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal int i(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).RenderMode;
		}

		internal void F(object P_0, int P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float J(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).LineHeight;
		}

		internal void d(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float j(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).AscentLine;
		}

		internal void E(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float K(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).DescentLine;
		}

		internal void e(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal float k(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).Baseline;
		}

		internal void F(object P_0, float P_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal System.Collections.Generic.IReadOnlyList<ABakedGlyph>? L(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).Glyphs;
		}

		internal void A(object P_0, System.Collections.Generic.IReadOnlyList<ABakedGlyph>? value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
		}

		internal System.Collections.Generic.IReadOnlyList<ABakedCharacter>? l(object P_0)
		{
			return ((TheBakedFaceRecord)P_0).Characters;
		}

		internal void A(object P_0, System.Collections.Generic.IReadOnlyList<ABakedCharacter>? value)
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
			return D(options);
		}
	}

	[CompilerGenerated]
	private sealed class C
	{
		public JsonSerializerOptions options;

		internal JsonPropertyInfo[] A(JsonSerializerContext P_0)
		{
			return B(options);
		}
	}

	private JsonTypeInfo<float>? _Single;

	private JsonTypeInfo<ABakedCharacter>? _ABakedCharacter;

	private JsonTypeInfo<ABakedGlyph>? _ABakedGlyph;

	private JsonTypeInfo<TheBakedFaceRecord>? _TheBakedFaceRecord;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedCharacter>>? _IReadOnlyListABakedCharacter;

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedGlyph>>? _IReadOnlyListABakedGlyph;

	private JsonTypeInfo<int>? _Int32;

	private static readonly JsonSerializerOptions s_defaultOptions = new JsonSerializerOptions
	{
		PropertyNameCaseInsensitive = true
	};

	private static readonly JsonEncodedText PropName_unicode = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Im());

	private static readonly JsonEncodedText PropName_glyphIndex = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.In());

	private static readonly JsonEncodedText PropName_index = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Io());

	private static readonly JsonEncodedText PropName_x = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ip());

	private static readonly JsonEncodedText PropName_y = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iq());

	private static readonly JsonEncodedText PropName_w = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ir());

	private static readonly JsonEncodedText PropName_h = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Is());

	private static readonly JsonEncodedText PropName_width = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.It());

	private static readonly JsonEncodedText PropName_height = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iu());

	private static readonly JsonEncodedText PropName_bearingX = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iv());

	private static readonly JsonEncodedText PropName_bearingY = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iw());

	private static readonly JsonEncodedText PropName_advance = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ix());

	private static readonly JsonEncodedText PropName_pointSize = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iy());

	private static readonly JsonEncodedText PropName_scale = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iz());

	private static readonly JsonEncodedText PropName_padding = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ia());

	private static readonly JsonEncodedText PropName_atlasWidth = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ib());

	private static readonly JsonEncodedText PropName_atlasHeight = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ic());

	private static readonly JsonEncodedText PropName_renderMode = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.id());

	private static readonly JsonEncodedText PropName_lineHeight = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ie());

	private static readonly JsonEncodedText PropName_ascentLine = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@if());

	private static readonly JsonEncodedText PropName_descentLine = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ig());

	private static readonly JsonEncodedText PropName_baseline = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ih());

	private static readonly JsonEncodedText PropName_glyphs = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ii());

	private static readonly JsonEncodedText PropName_characters = JsonEncodedText.Encode(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ij());

	public JsonTypeInfo<float> Single => _Single ?? (_Single = (JsonTypeInfo<float>)base.Options.GetTypeInfo(typeof(float)));

	public JsonTypeInfo<ABakedCharacter> ABakedCharacter => _ABakedCharacter ?? (_ABakedCharacter = (JsonTypeInfo<ABakedCharacter>)base.Options.GetTypeInfo(typeof(ABakedCharacter)));

	public JsonTypeInfo<ABakedGlyph> ABakedGlyph => _ABakedGlyph ?? (_ABakedGlyph = (JsonTypeInfo<ABakedGlyph>)base.Options.GetTypeInfo(typeof(ABakedGlyph)));

	public JsonTypeInfo<TheBakedFaceRecord> TheBakedFaceRecord => _TheBakedFaceRecord ?? (_TheBakedFaceRecord = (JsonTypeInfo<TheBakedFaceRecord>)base.Options.GetTypeInfo(typeof(TheBakedFaceRecord)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedCharacter>> IReadOnlyListABakedCharacter => _IReadOnlyListABakedCharacter ?? (_IReadOnlyListABakedCharacter = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedCharacter>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<ABakedCharacter>)));

	public JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedGlyph>> IReadOnlyListABakedGlyph => _IReadOnlyListABakedGlyph ?? (_IReadOnlyListABakedGlyph = (JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedGlyph>>)base.Options.GetTypeInfo(typeof(System.Collections.Generic.IReadOnlyList<ABakedGlyph>)));

	public JsonTypeInfo<int> Int32 => _Int32 ?? (_Int32 = (JsonTypeInfo<int>)base.Options.GetTypeInfo(typeof(int)));

	[field: CompilerGenerated]
	public static g Default
	{
		[CompilerGenerated]
		get;
	} = new g(new JsonSerializerOptions(s_defaultOptions));


	[field: CompilerGenerated]
	protected override JsonSerializerOptions? GeneratedSerializerOptions
	{
		[CompilerGenerated]
		get;
	} = s_defaultOptions;


	private JsonTypeInfo<float> A(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<float> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<float>(P_0, JsonMetadataServices.SingleConverter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private JsonTypeInfo<ABakedCharacter> a(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<ABakedCharacter> jsonTypeInfo))
		{
			JsonObjectInfoValues<ABakedCharacter> objectInfo = new JsonObjectInfoValues<ABakedCharacter>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new ABakedCharacter
				{
					Unicode = (int)P_0[0],
					GlyphIndex = (int)P_0[1]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => B(options),
				ConstructorParameterMetadataInitializer = A,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateObjectInfo(options, objectInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private static JsonPropertyInfo[] B(JsonSerializerOptions P_0)
	{
		JsonPropertyInfo[] array = new JsonPropertyInfo[2];
		JsonPropertyInfoValues<int> propertyInfo = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedCharacter),
			Converter = null,
			Getter = (object P_0) => ((ABakedCharacter)P_0).Unicode,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IM(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Im()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<int> propertyInfo2 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedCharacter),
			Converter = null,
			Getter = (object P_0) => ((ABakedCharacter)P_0).GlyphIndex,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IN(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.In()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		return array;
	}

	private void A(Utf8JsonWriter P_0, ABakedCharacter? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteNumber(PropName_unicode, value.Unicode);
		P_0.WriteNumber(PropName_glyphIndex, value.GlyphIndex);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] A()
	{
		return new JsonParameterInfoValues[2]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IM(),
				ParameterType = typeof(int),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IN(),
				ParameterType = typeof(int),
				Position = 1
			}
		};
	}

	private JsonTypeInfo<ABakedGlyph> b(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<ABakedGlyph> jsonTypeInfo))
		{
			JsonObjectInfoValues<ABakedGlyph> objectInfo = new JsonObjectInfoValues<ABakedGlyph>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new ABakedGlyph
				{
					Index = (int)P_0[0],
					X = (int)P_0[1],
					Y = (int)P_0[2],
					W = (int)P_0[3],
					H = (int)P_0[4],
					Width = (float)P_0[5],
					Height = (float)P_0[6],
					BearingX = (float)P_0[7],
					BearingY = (float)P_0[8],
					Advance = (float)P_0[9]
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
		JsonPropertyInfo[] array = new JsonPropertyInfo[10];
		JsonPropertyInfoValues<int> propertyInfo = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).Index,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IO(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Io()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<int> propertyInfo2 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).X,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IP(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ip()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		JsonPropertyInfoValues<int> propertyInfo3 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).Y,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IQ(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iq()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<int> propertyInfo4 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).W,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IR(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ir()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		JsonPropertyInfoValues<int> propertyInfo5 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).H,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IS(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Is()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		JsonPropertyInfoValues<float> propertyInfo6 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).Width,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IT(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.It()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		JsonPropertyInfoValues<float> propertyInfo7 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).Height,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IU(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iu()
		};
		array[6] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo7);
		JsonPropertyInfoValues<float> propertyInfo8 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).BearingX,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IV(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iv()
		};
		array[7] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo8);
		JsonPropertyInfoValues<float> propertyInfo9 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).BearingY,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IW(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iw()
		};
		array[8] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo9);
		JsonPropertyInfoValues<float> propertyInfo10 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(ABakedGlyph),
			Converter = null,
			Getter = (object P_0) => ((ABakedGlyph)P_0).Advance,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IX(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Ix()
		};
		array[9] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo10);
		return array;
	}

	private void A(Utf8JsonWriter P_0, ABakedGlyph? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteNumber(PropName_index, value.Index);
		P_0.WriteNumber(PropName_x, value.X);
		P_0.WriteNumber(PropName_y, value.Y);
		P_0.WriteNumber(PropName_w, value.W);
		P_0.WriteNumber(PropName_h, value.H);
		P_0.WriteNumber(PropName_width, value.Width);
		P_0.WriteNumber(PropName_height, value.Height);
		P_0.WriteNumber(PropName_bearingX, value.BearingX);
		P_0.WriteNumber(PropName_bearingY, value.BearingY);
		P_0.WriteNumber(PropName_advance, value.Advance);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] a()
	{
		return new JsonParameterInfoValues[10]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IO(),
				ParameterType = typeof(int),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IP(),
				ParameterType = typeof(int),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IQ(),
				ParameterType = typeof(int),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IR(),
				ParameterType = typeof(int),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IS(),
				ParameterType = typeof(int),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IT(),
				ParameterType = typeof(float),
				Position = 5
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IU(),
				ParameterType = typeof(float),
				Position = 6
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IV(),
				ParameterType = typeof(float),
				Position = 7
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IW(),
				ParameterType = typeof(float),
				Position = 8
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IX(),
				ParameterType = typeof(float),
				Position = 9
			}
		};
	}

	private JsonTypeInfo<TheBakedFaceRecord> c(JsonSerializerOptions P_0)
	{
		JsonSerializerOptions options = P_0;
		if (!A(options, out JsonTypeInfo<TheBakedFaceRecord> jsonTypeInfo))
		{
			JsonObjectInfoValues<TheBakedFaceRecord> objectInfo = new JsonObjectInfoValues<TheBakedFaceRecord>
			{
				ObjectCreator = null,
				ObjectWithParameterizedConstructorCreator = (object[] P_0) => new TheBakedFaceRecord
				{
					PointSize = (float)P_0[0],
					Scale = (float)P_0[1],
					Padding = (int)P_0[2],
					AtlasWidth = (int)P_0[3],
					AtlasHeight = (int)P_0[4],
					RenderMode = (int)P_0[5],
					LineHeight = (float)P_0[6],
					AscentLine = (float)P_0[7],
					DescentLine = (float)P_0[8],
					Baseline = (float)P_0[9],
					Glyphs = (System.Collections.Generic.IReadOnlyList<ABakedGlyph>)P_0[10],
					Characters = (System.Collections.Generic.IReadOnlyList<ABakedCharacter>)P_0[11]
				},
				PropertyMetadataInitializer = (JsonSerializerContext P_0) => D(options),
				ConstructorParameterMetadataInitializer = B,
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
		JsonPropertyInfoValues<float> propertyInfo = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).PointSize,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IY(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iy()
		};
		array[0] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo);
		JsonPropertyInfoValues<float> propertyInfo2 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).Scale,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IZ(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Iz()
		};
		array[1] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo2);
		JsonPropertyInfoValues<int> propertyInfo3 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).Padding,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iA(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ia()
		};
		array[2] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo3);
		JsonPropertyInfoValues<int> propertyInfo4 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).AtlasWidth,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iB(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ib()
		};
		array[3] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo4);
		JsonPropertyInfoValues<int> propertyInfo5 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).AtlasHeight,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iC(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ic()
		};
		array[4] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo5);
		JsonPropertyInfoValues<int> propertyInfo6 = new JsonPropertyInfoValues<int>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).RenderMode,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iD(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.id()
		};
		array[5] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo6);
		JsonPropertyInfoValues<float> propertyInfo7 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).LineHeight,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iE(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ie()
		};
		array[6] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo7);
		JsonPropertyInfoValues<float> propertyInfo8 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).AscentLine,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iF(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.@if()
		};
		array[7] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo8);
		JsonPropertyInfoValues<float> propertyInfo9 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).DescentLine,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iG(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ig()
		};
		array[8] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo9);
		JsonPropertyInfoValues<float> propertyInfo10 = new JsonPropertyInfoValues<float>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).Baseline,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iH(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ih()
		};
		array[9] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo10);
		JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<ABakedGlyph>> propertyInfo11 = new JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<ABakedGlyph>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).Glyphs,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iI(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ii()
		};
		array[10] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo11);
		JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<ABakedCharacter>> propertyInfo12 = new JsonPropertyInfoValues<System.Collections.Generic.IReadOnlyList<ABakedCharacter>>
		{
			IsProperty = true,
			IsPublic = true,
			IsVirtual = false,
			DeclaringType = typeof(TheBakedFaceRecord),
			Converter = null,
			Getter = (object P_0) => ((TheBakedFaceRecord)P_0).Characters,
			Setter = delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.RG());
			},
			IgnoreCondition = null,
			HasJsonInclude = false,
			IsExtensionData = false,
			NumberHandling = null,
			PropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iJ(),
			JsonPropertyName = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ij()
		};
		array[11] = JsonMetadataServices.CreatePropertyInfo(P_0, propertyInfo12);
		return array;
	}

	private void A(Utf8JsonWriter P_0, TheBakedFaceRecord? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartObject();
		P_0.WriteNumber(PropName_pointSize, value.PointSize);
		P_0.WriteNumber(PropName_scale, value.Scale);
		P_0.WriteNumber(PropName_padding, value.Padding);
		P_0.WriteNumber(PropName_atlasWidth, value.AtlasWidth);
		P_0.WriteNumber(PropName_atlasHeight, value.AtlasHeight);
		P_0.WriteNumber(PropName_renderMode, value.RenderMode);
		P_0.WriteNumber(PropName_lineHeight, value.LineHeight);
		P_0.WriteNumber(PropName_ascentLine, value.AscentLine);
		P_0.WriteNumber(PropName_descentLine, value.DescentLine);
		P_0.WriteNumber(PropName_baseline, value.Baseline);
		P_0.WritePropertyName(PropName_glyphs);
		A(P_0, value.Glyphs);
		P_0.WritePropertyName(PropName_characters);
		A(P_0, value.Characters);
		P_0.WriteEndObject();
	}

	private static JsonParameterInfoValues[] B()
	{
		return new JsonParameterInfoValues[12]
		{
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IY(),
				ParameterType = typeof(float),
				Position = 0
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.IZ(),
				ParameterType = typeof(float),
				Position = 1
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iA(),
				ParameterType = typeof(int),
				Position = 2
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iB(),
				ParameterType = typeof(int),
				Position = 3
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iC(),
				ParameterType = typeof(int),
				Position = 4
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iD(),
				ParameterType = typeof(int),
				Position = 5
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iE(),
				ParameterType = typeof(float),
				Position = 6
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iF(),
				ParameterType = typeof(float),
				Position = 7
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iG(),
				ParameterType = typeof(float),
				Position = 8
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iH(),
				ParameterType = typeof(float),
				Position = 9
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iI(),
				ParameterType = typeof(System.Collections.Generic.IReadOnlyList<ABakedGlyph>),
				Position = 10
			},
			new JsonParameterInfoValues
			{
				Name = EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.iJ(),
				ParameterType = typeof(System.Collections.Generic.IReadOnlyList<ABakedCharacter>),
				Position = 11
			}
		};
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedCharacter>> d(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedCharacter>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<ABakedCharacter>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<ABakedCharacter>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<ABakedCharacter>, ABakedCharacter>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<ABakedCharacter>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<ABakedCharacter> enumerator = ((System.Collections.Generic.IEnumerable<ABakedCharacter>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ABakedCharacter current = enumerator.Current;
				A(P_0, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedGlyph>> E(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<System.Collections.Generic.IReadOnlyList<ABakedGlyph>> jsonTypeInfo))
		{
			JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<ABakedGlyph>> collectionInfo = new JsonCollectionInfoValues<System.Collections.Generic.IReadOnlyList<ABakedGlyph>>
			{
				ObjectCreator = null,
				SerializeHandler = A
			};
			jsonTypeInfo = JsonMetadataServices.CreateIEnumerableInfo<System.Collections.Generic.IReadOnlyList<ABakedGlyph>, ABakedGlyph>(P_0, collectionInfo);
			jsonTypeInfo.NumberHandling = null;
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	private void A(Utf8JsonWriter P_0, System.Collections.Generic.IReadOnlyList<ABakedGlyph>? value)
	{
		if (value == null)
		{
			P_0.WriteNullValue();
			return;
		}
		P_0.WriteStartArray();
		System.Collections.Generic.IEnumerator<ABakedGlyph> enumerator = ((System.Collections.Generic.IEnumerable<ABakedGlyph>)value).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ABakedGlyph current = enumerator.Current;
				A(P_0, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		P_0.WriteEndArray();
	}

	private JsonTypeInfo<int> e(JsonSerializerOptions P_0)
	{
		if (!A(P_0, out JsonTypeInfo<int> jsonTypeInfo))
		{
			jsonTypeInfo = JsonMetadataServices.CreateValueInfo<int>(P_0, JsonMetadataServices.Int32Converter);
		}
		jsonTypeInfo.OriginatingResolver = this;
		return jsonTypeInfo;
	}

	public g()
		: base(null)
	{
	}

	public g(JsonSerializerOptions P_0)
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
		if (P_0 == typeof(float))
		{
			return A(P_1);
		}
		if (P_0 == typeof(ABakedCharacter))
		{
			return a(P_1);
		}
		if (P_0 == typeof(ABakedGlyph))
		{
			return b(P_1);
		}
		if (P_0 == typeof(TheBakedFaceRecord))
		{
			return c(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<ABakedCharacter>))
		{
			return d(P_1);
		}
		if (P_0 == typeof(System.Collections.Generic.IReadOnlyList<ABakedGlyph>))
		{
			return E(P_1);
		}
		if (P_0 == typeof(int))
		{
			return e(P_1);
		}
		return null;
	}

	JsonTypeInfo? IJsonTypeInfoResolver.GetTypeInfo(System.Type P_0, JsonSerializerOptions P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a
		return this.a(P_0, P_1);
	}
}
