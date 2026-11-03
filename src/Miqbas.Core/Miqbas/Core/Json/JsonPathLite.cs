using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Json;

public static class JsonPathLite
{
	public static System.Collections.Generic.IReadOnlyList<object> Parse(string path)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		List<object> val = new List<object>();
		int i = 0;
		int num3 = default(int);
		while (i < path.Length)
		{
			if (path[i] == '.')
			{
				i++;
			}
			else if (path[i] == '[')
			{
				int num = path.IndexOf(']', i);
				if (num < 0)
				{
					throw new FormatException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mT() + path + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ls());
				}
				int num2 = i + 1;
				string text = path.Substring(num2, num - num2);
				if (!int.TryParse(text, ref num3))
				{
					System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(32, 2);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mt());
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mU());
					defaultInterpolatedStringHandler.AppendFormatted(path);
					defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.ls());
					throw new FormatException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				val.Add((object)num3);
				i = num + 1;
			}
			else
			{
				int num4 = i;
				for (; i < path.Length && path[i] != '.' && path[i] != '['; i++)
				{
				}
				int num2 = num4;
				val.Add((object)path.Substring(num2, i - num2));
			}
		}
		return (System.Collections.Generic.IReadOnlyList<object>)val;
	}

	public static void SetString(JsonNode root, string path, string value)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IReadOnlyList<object> readOnlyList = Parse(path);
		if (((System.Collections.Generic.IReadOnlyCollection<object>)readOnlyList).Count == 0)
		{
			throw new FormatException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mu());
		}
		JsonNode jsonNode = root;
		for (int i = 0; i < ((System.Collections.Generic.IReadOnlyCollection<object>)readOnlyList).Count - 1; i++)
		{
			JsonNode? jsonNode2 = A(jsonNode, readOnlyList[i], path);
			if (jsonNode2 == null)
			{
				System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(42, 3);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mV());
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mv());
				defaultInterpolatedStringHandler.AppendFormatted<object>(readOnlyList[i]);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mW());
				defaultInterpolatedStringHandler.AppendFormatted(path);
				defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mw());
				throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			jsonNode = jsonNode2;
		}
		object obj = readOnlyList[((System.Collections.Generic.IReadOnlyCollection<object>)readOnlyList).Count - 1];
		if (!(obj is string propertyName))
		{
			if (obj is int index)
			{
				jsonNode[index] = value;
			}
		}
		else
		{
			jsonNode[propertyName] = value;
		}
	}

	public static string? GetString(JsonNode root, string path)
	{
		System.Collections.Generic.IReadOnlyList<object> readOnlyList = Parse(path);
		JsonNode jsonNode = root;
		System.Collections.Generic.IEnumerator<object> enumerator = ((System.Collections.Generic.IEnumerable<object>)readOnlyList).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				object current = enumerator.Current;
				jsonNode = A(jsonNode, current, path);
				if (jsonNode == null)
				{
					return null;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		if (jsonNode.GetValueKind() != JsonValueKind.String)
		{
			return null;
		}
		return jsonNode.GetValue<string>();
	}

	private static JsonNode? A(JsonNode P_0, object P_1, string P_2)
	{
		//IL_0040: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!(P_1 is string propertyName))
			{
				if (P_1 is int index)
				{
					return P_0[index];
				}
				throw new InvalidOperationException(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mX());
			}
			return P_0[propertyName];
		}
		catch (InvalidOperationException val)
		{
			InvalidOperationException val2 = val;
			System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(49, 3);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mx());
			defaultInterpolatedStringHandler.AppendFormatted<object>(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.mY());
			defaultInterpolatedStringHandler.AppendFormatted(P_2);
			defaultInterpolatedStringHandler.AppendLiteral(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.my());
			defaultInterpolatedStringHandler.AppendFormatted(((System.Exception)(object)val2).Message);
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear(), (System.Exception)(object)val2);
		}
	}
}
