internal class NewtonsoftSerializer : IJsonSerializer // TypeDefIndex: 17886
{
	// Fields
	private readonly JsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x2B9F330 Offset: 0x2B9DD30 VA: 0x182B9F330
	public void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(JsonSerializer serializer) { }

	// RVA: -1 Offset: -1 Slot: 4
	public string SerializeObject<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF17470 Offset: 0xF15E70 VA: 0x180F17470
	|-NewtonsoftSerializer.SerializeObject<object>
	|
	|-RVA: 0xF17140 Offset: 0xF15B40 VA: 0x180F17140
	|-NewtonsoftSerializer.SerializeObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16F80 Offset: 0xF15980 VA: 0x180F16F80
	|-NewtonsoftSerializer.DeserializeObject<SerializableProjectConfiguration>
	|
	|-RVA: 0xF16D20 Offset: 0xF15720 VA: 0x180F16D20
	|-NewtonsoftSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	*/
}
