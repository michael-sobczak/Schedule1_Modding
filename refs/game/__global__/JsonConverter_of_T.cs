public abstract class JsonConverter<T> : JsonConverter // TypeDefIndex: 10990
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public sealed override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A8B80 Offset: 0x18A7580 VA: 0x1818A8B80
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteJson(JsonWriter writer, T value, JsonSerializer serializer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A88C0 Offset: 0x18A72C0 VA: 0x1818A88C0
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-JsonConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public sealed override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18A8830 Offset: 0x18A7230 VA: 0x1818A8830
	|-JsonConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	|-JsonConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}
