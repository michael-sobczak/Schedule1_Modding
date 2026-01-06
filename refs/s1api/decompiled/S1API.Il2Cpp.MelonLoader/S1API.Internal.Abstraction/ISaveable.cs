using System.Collections.Generic;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json;

namespace S1API.Internal.Abstraction;

internal interface ISaveable : IRegisterable
{
	internal static JsonSerializerSettings SerializerSettings => new JsonSerializerSettings
	{
		ReferenceLoopHandling = (ReferenceLoopHandling)1,
		Converters = new List<JsonConverter> { (JsonConverter)(object)new GUIDReferenceConverter() }
	};

	void SaveInternal(string path, ref List<string> extraSaveables);

	void LoadInternal(string folderPath);

	void OnSaved();

	void OnLoaded();
}
