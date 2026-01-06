public struct UnsafeMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable // TypeDefIndex: 15951
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; // 0x0
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Capacity { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7900 Offset: 0x12D6300 VA: 0x1812D7900
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D79F0 Offset: 0x12D63F0 VA: 0x1812D79F0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE330 Offset: 0x12DCD30 VA: 0x1812DE330
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2C00 Offset: 0x10F1600 VA: 0x1810F2C00
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7C10 Offset: 0x12D6610 VA: 0x1812D7C10
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6E70 Offset: 0x12D5870 VA: 0x1812D6E70
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DDDD0 Offset: 0x12DC7D0 VA: 0x1812DDDD0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public int Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEB90 Offset: 0x12DD590 VA: 0x1812DEB90
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove<TValueEQ>(TKey key, TValueEQ value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCEA90 Offset: 0xDCD490 VA: 0x180DCEA90
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEA90 Offset: 0x12DD490 VA: 0x1812DEA90
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DED30 Offset: 0x12DD730 VA: 0x1812DED30
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetFirstValue
	*/

	// RVA: -1 Offset: -1
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEE50 Offset: 0x12DD850 VA: 0x1812DEE50
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetNextValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DDF50 Offset: 0x12DC950 VA: 0x1812DDF50
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int CountValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE110 Offset: 0x12DCB10 VA: 0x1812DE110
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CountValuesForKey
	*/

	// RVA: -1 Offset: -1
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEC90 Offset: 0x12DD690 VA: 0x1812DEC90
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.SetValue
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D70B0 Offset: 0x12D5AB0 VA: 0x1812D70B0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE360 Offset: 0x12DCD60 VA: 0x1812DE360
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE400 Offset: 0x12DCE00 VA: 0x1812DE400
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE6F0 Offset: 0x12DD0F0 VA: 0x1812DE6F0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValueArray
	*/

	// RVA: -1 Offset: -1
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE570 Offset: 0x12DCF70 VA: 0x1812DE570
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValueArrays
	*/

	// RVA: -1 Offset: -1
	public UnsafeMultiHashMap.Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE860 Offset: 0x12DD260 VA: 0x1812DE860
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValuesForKey
	*/

	// RVA: -1 Offset: -1
	public UnsafeMultiHashMap.ParallelWriter<TKey, TValue> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6E60 Offset: 0x12D5860 VA: 0x1812D6E60
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public UnsafeMultiHashMap.KeyValueEnumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
