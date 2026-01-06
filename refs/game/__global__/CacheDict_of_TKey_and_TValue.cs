internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 15650
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1434AE0 Offset: 0x14334E0 VA: 0x181434AE0
	|-CacheDict<object, object>..ctor
	|
	|-RVA: 0x1434B70 Offset: 0x1433570 VA: 0x181434B70
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14345D0 Offset: 0x1432FD0 VA: 0x1814345D0
	|-CacheDict<object, object>.AlignSize
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1434600 Offset: 0x1433000 VA: 0x181434600
	|-CacheDict<object, object>.TryGetValue
	|
	|-RVA: 0x14346D0 Offset: 0x14330D0 VA: 0x1814346D0
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1434480 Offset: 0x1432E80 VA: 0x181434480
	|-CacheDict<object, object>.Add
	|
	|-RVA: 0x1433FA0 Offset: 0x14329A0 VA: 0x181433FA0
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1434C00 Offset: 0x1433600 VA: 0x181434C00
	|-CacheDict<object, object>.set_Item
	|
	|-RVA: 0x1434D60 Offset: 0x1433760 VA: 0x181434D60
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/
}
