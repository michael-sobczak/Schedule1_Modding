public struct UnsafeParallelHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable // TypeDefIndex: 15987
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; // 0x0
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Capacity { get; set; }
	public TValue Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7900 Offset: 0x12D6300 VA: 0x1812D7900
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D79F0 Offset: 0x12D63F0 VA: 0x1812D79F0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D70A0 Offset: 0x12D5AA0 VA: 0x1812D70A0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2C00 Offset: 0x10F1600 VA: 0x1810F2C00
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7C10 Offset: 0x12D6610 VA: 0x1812D7C10
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6E70 Offset: 0x12D5870 VA: 0x1812D6E70
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7610 Offset: 0x12D6010 VA: 0x1812D7610
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6D00 Offset: 0x12D5700 VA: 0x1812D6D00
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7510 Offset: 0x12D5F10 VA: 0x1812D7510
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7790 Offset: 0x12D6190 VA: 0x1812D7790
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6EE0 Offset: 0x12D58E0 VA: 0x1812D6EE0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7A80 Offset: 0x12D6480 VA: 0x1812D7A80
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7CB0 Offset: 0x12D66B0 VA: 0x1812D7CB0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D70B0 Offset: 0x12D5AB0 VA: 0x1812D70B0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E23B0 Offset: 0x12E0DB0 VA: 0x1812E23B0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7180 Offset: 0x12D5B80 VA: 0x1812D7180
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D73E0 Offset: 0x12D5DE0 VA: 0x1812D73E0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValueArray
	*/

	// RVA: -1 Offset: -1
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D72B0 Offset: 0x12D5CB0 VA: 0x1812D72B0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValueArrays
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelHashMap.ParallelWriter<TKey, TValue> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6E60 Offset: 0x12D5860 VA: 0x1812D6E60
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelHashMap.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
