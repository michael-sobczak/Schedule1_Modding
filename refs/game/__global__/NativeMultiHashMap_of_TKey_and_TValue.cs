public struct NativeMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable // TypeDefIndex: 15753
{
	// Fields
	internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Capacity { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085E20 Offset: 0x1084820 VA: 0x181085E20
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void Initialize<U>(int capacity, ref U allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC97B0 Offset: 0xDC81B0 VA: 0x180DC97B0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Initialize<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C8F0 Offset: 0x108B2F0 VA: 0x18108C8F0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086CB0 Offset: 0x10856B0 VA: 0x181086CB0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10854E0 Offset: 0x1083EE0 VA: 0x1810854E0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085EC0 Offset: 0x10848C0 VA: 0x181085EC0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086270 Offset: 0x1084C70 VA: 0x181086270
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085380 Offset: 0x1083D80 VA: 0x181085380
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108B8C0 Offset: 0x108A2C0 VA: 0x18108B8C0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public int Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C4D0 Offset: 0x108AED0 VA: 0x18108C4D0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C3E0 Offset: 0x108ADE0 VA: 0x18108C3E0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C730 Offset: 0x108B130 VA: 0x18108C730
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetFirstValue
	*/

	// RVA: -1 Offset: -1
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C850 Offset: 0x108B250 VA: 0x18108C850
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetNextValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108BAC0 Offset: 0x108A4C0 VA: 0x18108BAC0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int CountValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108BC80 Offset: 0x108A680 VA: 0x18108BC80
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CountValuesForKey
	*/

	// RVA: -1 Offset: -1
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C5C0 Offset: 0x108AFC0 VA: 0x18108C5C0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.SetValue
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C990 Offset: 0x108B390 VA: 0x18108C990
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108BEA0 Offset: 0x108A8A0 VA: 0x18108BEA0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108BF20 Offset: 0x108A920 VA: 0x18108BF20
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108BFC0 Offset: 0x108A9C0 VA: 0x18108BFC0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C110 Offset: 0x108AB10 VA: 0x18108C110
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValueArray
	*/

	// RVA: -1 Offset: -1
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C060 Offset: 0x108AA60 VA: 0x18108C060
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValueArrays
	*/

	// RVA: -1 Offset: -1
	public NativeMultiHashMap.ParallelWriter<TKey, TValue> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108BA20 Offset: 0x108A420 VA: 0x18108BA20
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public NativeMultiHashMap.Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108C1B0 Offset: 0x108ABB0 VA: 0x18108C1B0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValuesForKey
	*/

	// RVA: -1 Offset: -1
	public NativeMultiHashMap.KeyValueEnumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckRead() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckRead
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckWrite
	*/
}
