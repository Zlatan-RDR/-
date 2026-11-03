using System;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using _003CPrivateImplementationDetails_003E_007B22FF1825_002D9170_002D4C83_002DB2B8_002D44085C325CFF_007D;

namespace Miqbas.Core.Text;

public static class JsonStrings
{
	public static string Quote(string value, bool leaveArabicAsItIs = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		MemoryStream val = new MemoryStream();
		try
		{
			using (Utf8JsonWriter utf8JsonWriter = new Utf8JsonWriter((Stream)(object)val, new JsonWriterOptions
			{
				Encoder = (leaveArabicAsItIs ? JavaScriptEncoder.UnsafeRelaxedJsonEscaping : null)
			}))
			{
				utf8JsonWriter.WriteStringValue(value);
			}
			return Encoding.UTF8.GetString(val.ToArray());
		}
		finally
		{
			((System.IDisposable)val)?.Dispose();
		}
	}

	public static string? Unquote(string insideTheQuotes)
	{
		try
		{
			using JsonDocument jsonDocument = JsonDocument.Parse(EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hu() + insideTheQuotes + EA400944_002D83DF_002D44E6_002D86A0_002D4E8ED58C790A.Hu());
			return jsonDocument.RootElement.GetString();
		}
		catch (JsonException)
		{
			return null;
		}
	}
}
