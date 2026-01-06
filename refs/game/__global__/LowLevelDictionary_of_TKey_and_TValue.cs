internal class LowLevelDictionary<TKey, TValue> // TypeDefIndex: 4993
{
	// Fields
	private LowLevelDictionary.Entry<TKey, TValue>[] _buckets; // 0x0
	private int _numEntries; // 0x0
	private int _version; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0

	// Properties
	public TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10598D0 Offset: 0x10582D0 VA: 0x1810598D0
	|-LowLevelDictionary<int, object>..ctor
	|
	|-RVA: 0x1059A30 Offset: 0x1058430 VA: 0x181059A30
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1059AC0 Offset: 0x10584C0 VA: 0x181059AC0
	|-LowLevelDictionary<int, object>..ctor
	|
	|-RVA: 0x10599C0 Offset: 0x10583C0 VA: 0x1810599C0
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1059E10 Offset: 0x1058810 VA: 0x181059E10
	|-LowLevelDictionary<int, object>.set_Item
	|
	|-RVA: 0x1059B60 Offset: 0x1058560 VA: 0x181059B60
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear(int capacity = 17) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10585B0 Offset: 0x1056FB0 VA: 0x1810585B0
	|-LowLevelDictionary<int, object>.Clear
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1059290 Offset: 0x1057C90 VA: 0x181059290
	|-LowLevelDictionary<int, object>.Remove
	|
	|-RVA: 0x1058EF0 Offset: 0x10578F0 VA: 0x181058EF0
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private LowLevelDictionary.Entry<TKey, TValue> Find(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1058C20 Offset: 0x1057620 VA: 0x181058C20
	|-LowLevelDictionary<int, object>.Find
	|
	|-RVA: 0x10589C0 Offset: 0x10573C0 VA: 0x1810589C0
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private LowLevelDictionary.Entry<TKey, TValue> UncheckedAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1059420 Offset: 0x1057E20 VA: 0x181059420
	|-LowLevelDictionary<int, object>.UncheckedAdd
	|
	|-RVA: 0x10595B0 Offset: 0x1057FB0 VA: 0x1810595B0
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UncheckedAdd
	*/

	// RVA: -1 Offset: -1
	private void ExpandBuckets() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1058610 Offset: 0x1057010 VA: 0x181058610
	|-LowLevelDictionary<int, object>.ExpandBuckets
	|
	|-RVA: 0x1058760 Offset: 0x1057160 VA: 0x181058760
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ExpandBuckets
	*/

	// RVA: -1 Offset: -1
	private int GetBucket(TKey key, int numBuckets = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1058E60 Offset: 0x1057860 VA: 0x181058E60
	|-LowLevelDictionary<int, object>.GetBucket
	|
	|-RVA: 0x1058D40 Offset: 0x1057740 VA: 0x181058D40
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/
}
