internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 15598
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18513A0 Offset: 0x184FDA0 VA: 0x1818513A0
	|-HybridReferenceDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x1851430 Offset: 0x184FE30 VA: 0x181851430
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1851320 Offset: 0x184FD20 VA: 0x181851320
	|-HybridReferenceDictionary<object, object>.Remove
	|
	|-RVA: 0x18511C0 Offset: 0x184FBC0 VA: 0x1818511C0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850DD0 Offset: 0x184F7D0 VA: 0x181850DD0
	|-HybridReferenceDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x1850CC0 Offset: 0x184F6C0 VA: 0x181850CC0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1851090 Offset: 0x184FA90 VA: 0x181851090
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x1850FB0 Offset: 0x184F9B0 VA: 0x181850FB0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue>))]
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1850F20 Offset: 0x184F920 VA: 0x181850F20
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	|
	|-RVA: 0x1850E50 Offset: 0x184F850 VA: 0x181850E50
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18517B0 Offset: 0x18501B0 VA: 0x1818517B0
	|-HybridReferenceDictionary<object, object>.get_Item
	|
	|-RVA: 0x1851650 Offset: 0x1850050 VA: 0x181851650
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18518E0 Offset: 0x18502E0 VA: 0x1818518E0
	|-HybridReferenceDictionary<object, object>.set_Item
	|
	|-RVA: 0x1851BF0 Offset: 0x18505F0 VA: 0x181851BF0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-HybridReferenceDictionary<object, object>..ctor
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>..ctor
	*/
}
