public struct UnsafeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable // TypeDefIndex: 15999
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
	|-RVA: 0x12E3660 Offset: 0x12E2060 VA: 0x1812E3660
	|-UnsafeParallelMultiHashMap<int, int>..ctor
	|
	|-RVA: 0x12D7900 Offset: 0x12D6300 VA: 0x1812D7900
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3700 Offset: 0x12E2100 VA: 0x1812E3700
	|-UnsafeParallelMultiHashMap<int, int>.get_IsEmpty
	|
	|-RVA: 0x12D79F0 Offset: 0x12D63F0 VA: 0x1812D79F0
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DE330 Offset: 0x12DCD30 VA: 0x1812DE330
	|-UnsafeParallelMultiHashMap<int, int>.Count
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2C00 Offset: 0x10F1600 VA: 0x1810F2C00
	|-UnsafeParallelMultiHashMap<int, int>.get_Capacity
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3740 Offset: 0x12E2140 VA: 0x1812E3740
	|-UnsafeParallelMultiHashMap<int, int>.set_Capacity
	|
	|-RVA: 0x12D7C10 Offset: 0x12D6610 VA: 0x1812D7C10
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2BE0 Offset: 0x12E15E0 VA: 0x1812E2BE0
	|-UnsafeParallelMultiHashMap<int, int>.Clear
	|
	|-RVA: 0x12D6E70 Offset: 0x12D5870 VA: 0x1812D6E70
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2B70 Offset: 0x12E1570 VA: 0x1812E2B70
	|-UnsafeParallelMultiHashMap<int, int>.Add
	|
	|-RVA: 0x12DDDD0 Offset: 0x12DC7D0 VA: 0x1812DDDD0
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public int Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3380 Offset: 0x12E1D80 VA: 0x1812E3380
	|-UnsafeParallelMultiHashMap<int, int>.Remove
	|
	|-RVA: 0x12DEB90 Offset: 0x12DD590 VA: 0x1812DEB90
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void Remove<TValueEQ>(TKey key, TValueEQ value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCEA90 Offset: 0xDCD490 VA: 0x180DCEA90
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3290 Offset: 0x12E1C90 VA: 0x1812E3290
	|-UnsafeParallelMultiHashMap<int, int>.Remove
	|
	|-RVA: 0x12DEA90 Offset: 0x12DD490 VA: 0x1812DEA90
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3590 Offset: 0x12E1F90 VA: 0x1812E3590
	|-UnsafeParallelMultiHashMap<int, int>.TryGetFirstValue
	|
	|-RVA: 0x12DED30 Offset: 0x12DD730 VA: 0x1812DED30
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetFirstValue
	*/

	// RVA: -1 Offset: -1
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3600 Offset: 0x12E2000 VA: 0x1812E3600
	|-UnsafeParallelMultiHashMap<int, int>.TryGetNextValue
	|
	|-RVA: 0x12DEE50 Offset: 0x12DD850 VA: 0x1812DEE50
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetNextValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2C60 Offset: 0x12E1660 VA: 0x1812E2C60
	|-UnsafeParallelMultiHashMap<int, int>.ContainsKey
	|
	|-RVA: 0x12DDF50 Offset: 0x12DC950 VA: 0x1812DDF50
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int CountValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2CF0 Offset: 0x12E16F0 VA: 0x1812E2CF0
	|-UnsafeParallelMultiHashMap<int, int>.CountValuesForKey
	|
	|-RVA: 0x12DE110 Offset: 0x12DCB10 VA: 0x1812DE110
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CountValuesForKey
	*/

	// RVA: -1 Offset: -1
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3500 Offset: 0x12E1F00 VA: 0x1812E3500
	|-UnsafeParallelMultiHashMap<int, int>.SetValue
	|
	|-RVA: 0x12DEC90 Offset: 0x12DD690 VA: 0x1812DEC90
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.SetValue
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-UnsafeParallelMultiHashMap<int, int>.get_IsCreated
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D70B0 Offset: 0x12D5AB0 VA: 0x1812D70B0
	|-UnsafeParallelMultiHashMap<int, int>.Dispose
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2E10 Offset: 0x12E1810 VA: 0x1812E2E10
	|-UnsafeParallelMultiHashMap<int, int>.Dispose
	|
	|-RVA: 0x12E2EB0 Offset: 0x12E18B0 VA: 0x1812E2EB0
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2F50 Offset: 0x12E1950 VA: 0x1812E2F50
	|-UnsafeParallelMultiHashMap<int, int>.GetKeyArray
	|
	|-RVA: 0x12DE400 Offset: 0x12DCE00 VA: 0x1812DE400
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3180 Offset: 0x12E1B80 VA: 0x1812E3180
	|-UnsafeParallelMultiHashMap<int, int>.GetValueArray
	|
	|-RVA: 0x12DE6F0 Offset: 0x12DD0F0 VA: 0x1812DE6F0
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValueArray
	*/

	// RVA: -1 Offset: -1
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3060 Offset: 0x12E1A60 VA: 0x1812E3060
	|-UnsafeParallelMultiHashMap<int, int>.GetKeyValueArrays
	|
	|-RVA: 0x12DE570 Offset: 0x12DCF70 VA: 0x1812DE570
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValueArrays
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelMultiHashMap.Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FA70 Offset: 0x108E470 VA: 0x18108FA70
	|-UnsafeParallelMultiHashMap<int, int>.GetValuesForKey
	|
	|-RVA: 0x12DE860 Offset: 0x12DD260 VA: 0x1812DE860
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValuesForKey
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelMultiHashMap.ParallelWriter<TKey, TValue> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6E60 Offset: 0x12D5860 VA: 0x1812D6E60
	|-UnsafeParallelMultiHashMap<int, int>.AsParallelWriter
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelMultiHashMap.KeyValueEnumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-UnsafeParallelMultiHashMap<int, int>.GetEnumerator
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeParallelMultiHashMap<int, int>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeParallelMultiHashMap<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-UnsafeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
