using System.Text.Json;
using A;

namespace Miqbas.Core.Engines;

public static class LearnedShapesJson
{
	public static JsonSerializerOptions Options => J.Default.Options;

	public static string Write(ShapeDescriptor shape)
	{
		return JsonSerializer.Serialize(shape, J.Default.ShapeDescriptor);
	}

	public static ShapeDescriptor? Read(string json)
	{
		try
		{
			return JsonSerializer.Deserialize(json, J.Default.ShapeDescriptor);
		}
		catch (JsonException)
		{
			return null;
		}
	}
}
