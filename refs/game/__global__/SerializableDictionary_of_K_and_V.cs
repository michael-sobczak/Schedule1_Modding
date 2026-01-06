public class SerializableDictionary<K, V> : ISerializationCallbackReceiver // TypeDefIndex: 477
{
	// Fields
	public Dictionary<K, V> dict; // 0x0
	[SerializeField]
	public List<K> m_Keys; // 0x0
	[SerializeField]
	public List<V> m_Values; // 0x0

	// Properties
	public V Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8450 Offset: 0x11B6E50 VA: 0x1811B8450
	|-SerializableDictionary<object, bool>.Clear
	|-SerializableDictionary<object, object>.Clear
	|
	|-RVA: 0x11B8420 Offset: 0x11B6E20 VA: 0x1811B8420
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public V get_Item(K aKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB070 Offset: 0x11B9A70 VA: 0x1811BB070
	|-SerializableDictionary<object, bool>.get_Item
	|
	|-RVA: 0x11BB0D0 Offset: 0x11B9AD0 VA: 0x1811BB0D0
	|-SerializableDictionary<object, object>.get_Item
	|
	|-RVA: 0x11BAF30 Offset: 0x11B9930 VA: 0x1811BAF30
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(K aKey, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB360 Offset: 0x11B9D60 VA: 0x1811BB360
	|-SerializableDictionary<object, bool>.set_Item
	|
	|-RVA: 0x11BB540 Offset: 0x11B9F40 VA: 0x1811BB540
	|-SerializableDictionary<object, object>.set_Item
	|
	|-RVA: 0x11BB1E0 Offset: 0x11B9BE0 VA: 0x1811BB1E0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BA2C0 Offset: 0x11B8CC0 VA: 0x1811BA2C0
	|-SerializableDictionary<object, bool>.OnBeforeSerialize
	|
	|-RVA: 0x11B9FC0 Offset: 0x11B89C0 VA: 0x1811B9FC0
	|-SerializableDictionary<object, object>.OnBeforeSerialize
	|
	|-RVA: 0x11B93D0 Offset: 0x11B7DD0 VA: 0x1811B93D0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8BD0 Offset: 0x11B75D0 VA: 0x1811B8BD0
	|-SerializableDictionary<object, bool>.OnAfterDeserialize
	|
	|-RVA: 0x11B8A50 Offset: 0x11B7450 VA: 0x1811B8A50
	|-SerializableDictionary<object, object>.OnAfterDeserialize
	|
	|-RVA: 0x11B90E0 Offset: 0x11B7AE0 VA: 0x1811B90E0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BAB20 Offset: 0x11B9520 VA: 0x1811BAB20
	|-SerializableDictionary<object, bool>..ctor
	|-SerializableDictionary<object, object>..ctor
	|
	|-RVA: 0x11BA8C0 Offset: 0x11B92C0 VA: 0x1811BA8C0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
