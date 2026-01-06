internal interface IJsonSerializer // TypeDefIndex: 17885
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string SerializeObject<T>(T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJsonSerializer.SerializeObject<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract T DeserializeObject<T>(string value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IJsonSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	|-IJsonSerializer.DeserializeObject<SerializableProjectConfiguration>
	*/
}
