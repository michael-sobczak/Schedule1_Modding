public abstract class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>, ISerializationCallbackReceiver // TypeDefIndex: 13604
{
	// Fields
	[SerializeField]
	private List<SK> m_Keys; // 0x0
	[SerializeField]
	private List<SV> m_Values; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 48
	public abstract SK SerializeKey(K key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeKey
	*/

	// RVA: -1 Offset: -1 Slot: 49
	public abstract SV SerializeValue(V value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SerializeValue
	*/

	// RVA: -1 Offset: -1 Slot: 50
	public abstract K DeserializeKey(SK serializedKey);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeKey
	*/

	// RVA: -1 Offset: -1 Slot: 51
	public abstract V DeserializeValue(SV serializedValue);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeserializeValue
	*/

	// RVA: -1 Offset: -1 Slot: 46
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB9D0 Offset: 0x11BA3D0 VA: 0x1811BB9D0
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 47
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB6B0 Offset: 0x11BA0B0 VA: 0x1811BB6B0
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BBF40 Offset: 0x11BA940 VA: 0x1811BBF40
	|-SerializedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
