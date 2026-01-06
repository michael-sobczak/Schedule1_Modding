public class SerializableDictionary<TKey, TValue> : ISerializationCallbackReceiver, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 874
{
	// Fields
	[SerializeField]
	private List<TKey> keys; // 0x0
	[SerializeField]
	private List<TValue> values; // 0x0
	private Dictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public TValue Item { get; set; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void OnBeforeSerialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B98D0 Offset: 0x11B82D0 VA: 0x1811B98D0
	|-SerializableDictionary<Int32Enum, int>.OnBeforeSerialize
	|
	|-RVA: 0x11B9B30 Offset: 0x11B8530 VA: 0x1811B9B30
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnBeforeSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B88A0 Offset: 0x11B72A0 VA: 0x1811B88A0
	|-SerializableDictionary<Int32Enum, int>.OnAfterDeserialize
	|
	|-RVA: 0x11B8D50 Offset: 0x11B7750 VA: 0x1811B8D50
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8380 Offset: 0x11B6D80 VA: 0x1811B8380
	|-SerializableDictionary<Int32Enum, int>.Add
	|
	|-RVA: 0x11B8080 Offset: 0x11B6A80 VA: 0x1811B8080
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B84B0 Offset: 0x11B6EB0 VA: 0x1811B84B0
	|-SerializableDictionary<Int32Enum, int>.ContainsKey
	|
	|-RVA: 0x11B84E0 Offset: 0x11B6EE0 VA: 0x1811B84E0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BA590 Offset: 0x11B8F90 VA: 0x1811BA590
	|-SerializableDictionary<Int32Enum, int>.Remove
	|
	|-RVA: 0x11BA5C0 Offset: 0x11B8FC0 VA: 0x1811BA5C0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BA790 Offset: 0x11B9190 VA: 0x1811BA790
	|-SerializableDictionary<Int32Enum, int>.TryGetValue
	|
	|-RVA: 0x11BA7C0 Offset: 0x11B91C0 VA: 0x1811BA7C0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB0A0 Offset: 0x11B9AA0 VA: 0x1811BB0A0
	|-SerializableDictionary<Int32Enum, int>.get_Item
	|
	|-RVA: 0x11BADF0 Offset: 0x11B97F0 VA: 0x1811BADF0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB510 Offset: 0x11B9F10 VA: 0x1811BB510
	|-SerializableDictionary<Int32Enum, int>.set_Item
	|
	|-RVA: 0x11BB390 Offset: 0x11B9D90 VA: 0x1811BB390
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB140 Offset: 0x11B9B40 VA: 0x1811BB140
	|-SerializableDictionary<Int32Enum, int>.get_Keys
	|
	|-RVA: 0x11BB100 Offset: 0x11B9B00 VA: 0x1811BB100
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB1B0 Offset: 0x11B9BB0 VA: 0x1811BB1B0
	|-SerializableDictionary<Int32Enum, int>.get_Values
	|
	|-RVA: 0x11BB170 Offset: 0x11B9B70 VA: 0x1811BB170
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BAD80 Offset: 0x11B9780 VA: 0x1811BAD80
	|-SerializableDictionary<Int32Enum, int>.get_Count
	|
	|-RVA: 0x11BADB0 Offset: 0x11B97B0 VA: 0x1811BADB0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SerializableDictionary<Int32Enum, int>.get_IsReadOnly
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B83B0 Offset: 0x11B6DB0 VA: 0x1811B83B0
	|-SerializableDictionary<Int32Enum, int>.Add
	|
	|-RVA: 0x11B8200 Offset: 0x11B6C00 VA: 0x1811B8200
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B83F0 Offset: 0x11B6DF0 VA: 0x1811B83F0
	|-SerializableDictionary<Int32Enum, int>.Clear
	|
	|-RVA: 0x11B8480 Offset: 0x11B6E80 VA: 0x1811B8480
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B84B0 Offset: 0x11B6EB0 VA: 0x1811B84B0
	|-SerializableDictionary<Int32Enum, int>.Contains
	|
	|-RVA: 0x11B85D0 Offset: 0x11B6FD0 VA: 0x1811B85D0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B86B0 Offset: 0x11B70B0 VA: 0x1811B86B0
	|-SerializableDictionary<Int32Enum, int>.CopyTo
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BA590 Offset: 0x11B8F90 VA: 0x1811BA590
	|-SerializableDictionary<Int32Enum, int>.Remove
	|
	|-RVA: 0x11BA6B0 Offset: 0x11B90B0 VA: 0x1811BA6B0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8780 Offset: 0x11B7180 VA: 0x1811B8780
	|-SerializableDictionary<Int32Enum, int>.GetEnumerator
	|
	|-RVA: 0x11B87F0 Offset: 0x11B71F0 VA: 0x1811B87F0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B8780 Offset: 0x11B7180 VA: 0x1811B8780
	|-SerializableDictionary<Int32Enum, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11B87F0 Offset: 0x11B71F0 VA: 0x1811B87F0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BAC50 Offset: 0x11B9650 VA: 0x1811BAC50
	|-SerializableDictionary<Int32Enum, int>..ctor
	|
	|-RVA: 0x11BA9F0 Offset: 0x11B93F0 VA: 0x1811BA9F0
	|-SerializableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
