public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 11391
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E05B0 Offset: 0x14DEFB0 VA: 0x1814E05B0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E03A0 Offset: 0x14DEDA0 VA: 0x1814E03A0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract T Create(Type objectType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E0310 Offset: 0x14DED10 VA: 0x1814E0310
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool get_CanWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.get_CanWrite
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}
