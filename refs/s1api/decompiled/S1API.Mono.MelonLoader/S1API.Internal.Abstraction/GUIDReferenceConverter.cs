using System;
using System.Reflection;
using Newtonsoft.Json;
using S1API.Internal.Utils;

namespace S1API.Internal.Abstraction;

internal class GUIDReferenceConverter : JsonConverter
{
	public override bool CanRead => true;

	public override bool CanConvert(Type objectType)
	{
		return typeof(IGUIDReference).IsAssignableFrom(objectType);
	}

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		if (value is IGUIDReference iGUIDReference)
		{
			writer.WriteValue(iGUIDReference.GUID);
		}
		else
		{
			writer.WriteNull();
		}
	}

	public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		string text = reader.Value?.ToString();
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		MethodInfo method = ReflectionUtils.GetMethod(objectType, "GetFromGUID", BindingFlags.Static | BindingFlags.NonPublic);
		if (method == null)
		{
			throw new Exception("The type " + objectType.Name + " does not have a valid implementation of the GetFromGUID(string guid) method!");
		}
		return method.Invoke(null, new object[1] { text });
	}
}
