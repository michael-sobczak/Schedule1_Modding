public struct NativeParallelMultiHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable // TypeDefIndex: 15873
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
	|-RVA: 0x108FD00 Offset: 0x108E700 VA: 0x18108FD00
	|-NativeParallelMultiHashMap<int, int>..ctor
	|
	|-RVA: 0x1085E20 Offset: 0x1084820 VA: 0x181085E20
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	internal void Initialize<U>(int capacity, ref U allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC98C0 Offset: 0xDC82C0 VA: 0x180DC98C0
	|-NativeParallelMultiHashMap<int, int>.Initialize<AllocatorManager.AllocatorHandle>
	|
	|-RVA: 0xDC97B0 Offset: 0xDC81B0 VA: 0x180DC97B0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Initialize<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FC90 Offset: 0x108E690 VA: 0x18108FC90
	|-NativeParallelMultiHashMap<int, int>..ctor
	|
	|-RVA: 0x108C8F0 Offset: 0x108B2F0 VA: 0x18108C8F0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FE10 Offset: 0x108E810 VA: 0x18108FE10
	|-NativeParallelMultiHashMap<int, int>.get_IsEmpty
	|
	|-RVA: 0x1086CB0 Offset: 0x10856B0 VA: 0x181086CB0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F760 Offset: 0x108E160 VA: 0x18108F760
	|-NativeParallelMultiHashMap<int, int>.Count
	|
	|-RVA: 0x10854E0 Offset: 0x1083EE0 VA: 0x1810854E0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FD90 Offset: 0x108E790 VA: 0x18108FD90
	|-NativeParallelMultiHashMap<int, int>.get_Capacity
	|
	|-RVA: 0x1085EC0 Offset: 0x10848C0 VA: 0x181085EC0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FE50 Offset: 0x108E850 VA: 0x18108FE50
	|-NativeParallelMultiHashMap<int, int>.set_Capacity
	|
	|-RVA: 0x1086270 Offset: 0x1084C70 VA: 0x181086270
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F570 Offset: 0x108DF70 VA: 0x18108F570
	|-NativeParallelMultiHashMap<int, int>.Clear
	|
	|-RVA: 0x1085380 Offset: 0x1083D80 VA: 0x181085380
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F4B0 Offset: 0x108DEB0 VA: 0x18108F4B0
	|-NativeParallelMultiHashMap<int, int>.Add
	|
	|-RVA: 0x108B8C0 Offset: 0x108A2C0 VA: 0x18108B8C0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public int Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FAA0 Offset: 0x108E4A0 VA: 0x18108FAA0
	|-NativeParallelMultiHashMap<int, int>.Remove
	|
	|-RVA: 0x108C4D0 Offset: 0x108AED0 VA: 0x18108C4D0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FAF0 Offset: 0x108E4F0 VA: 0x18108FAF0
	|-NativeParallelMultiHashMap<int, int>.Remove
	|
	|-RVA: 0x108C3E0 Offset: 0x108ADE0 VA: 0x18108C3E0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FBC0 Offset: 0x108E5C0 VA: 0x18108FBC0
	|-NativeParallelMultiHashMap<int, int>.TryGetFirstValue
	|
	|-RVA: 0x108C730 Offset: 0x108B130 VA: 0x18108C730
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetFirstValue
	*/

	// RVA: -1 Offset: -1
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FC30 Offset: 0x108E630 VA: 0x18108FC30
	|-NativeParallelMultiHashMap<int, int>.TryGetNextValue
	|
	|-RVA: 0x108C850 Offset: 0x108B250 VA: 0x18108C850
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetNextValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F5B0 Offset: 0x108DFB0 VA: 0x18108F5B0
	|-NativeParallelMultiHashMap<int, int>.ContainsKey
	|
	|-RVA: 0x108BAC0 Offset: 0x108A4C0 VA: 0x18108BAC0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public int CountValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F640 Offset: 0x108E040 VA: 0x18108F640
	|-NativeParallelMultiHashMap<int, int>.CountValuesForKey
	|
	|-RVA: 0x108BC80 Offset: 0x108A680 VA: 0x18108BC80
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CountValuesForKey
	*/

	// RVA: -1 Offset: -1
	public bool SetValue(TValue item, NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FB50 Offset: 0x108E550 VA: 0x18108FB50
	|-NativeParallelMultiHashMap<int, int>.SetValue
	|
	|-RVA: 0x108C5C0 Offset: 0x108AFC0 VA: 0x18108C5C0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.SetValue
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FDD0 Offset: 0x108E7D0 VA: 0x18108FDD0
	|-NativeParallelMultiHashMap<int, int>.get_IsCreated
	|
	|-RVA: 0x108C990 Offset: 0x108B390 VA: 0x18108C990
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F8E0 Offset: 0x108E2E0 VA: 0x18108F8E0
	|-NativeParallelMultiHashMap<int, int>.Dispose
	|
	|-RVA: 0x108BEA0 Offset: 0x108A8A0 VA: 0x18108BEA0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F840 Offset: 0x108E240 VA: 0x18108F840
	|-NativeParallelMultiHashMap<int, int>.Dispose
	|
	|-RVA: 0x108F7A0 Offset: 0x108E1A0 VA: 0x18108F7A0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F920 Offset: 0x108E320 VA: 0x18108F920
	|-NativeParallelMultiHashMap<int, int>.GetKeyArray
	|
	|-RVA: 0x108BFC0 Offset: 0x108A9C0 VA: 0x18108BFC0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FA00 Offset: 0x108E400 VA: 0x18108FA00
	|-NativeParallelMultiHashMap<int, int>.GetValueArray
	|
	|-RVA: 0x108C110 Offset: 0x108AB10 VA: 0x18108C110
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValueArray
	*/

	// RVA: -1 Offset: -1
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F990 Offset: 0x108E390 VA: 0x18108F990
	|-NativeParallelMultiHashMap<int, int>.GetKeyValueArrays
	|
	|-RVA: 0x108C060 Offset: 0x108AA60 VA: 0x18108C060
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValueArrays
	*/

	// RVA: -1 Offset: -1
	public NativeParallelMultiHashMap.ParallelWriter<TKey, TValue> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F510 Offset: 0x108DF10 VA: 0x18108F510
	|-NativeParallelMultiHashMap<int, int>.AsParallelWriter
	|
	|-RVA: 0x108BA20 Offset: 0x108A420 VA: 0x18108BA20
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public NativeParallelMultiHashMap.Enumerator<TKey, TValue> GetValuesForKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108FA70 Offset: 0x108E470 VA: 0x18108FA70
	|-NativeParallelMultiHashMap<int, int>.GetValuesForKey
	|
	|-RVA: 0x108C1B0 Offset: 0x108ABB0 VA: 0x18108C1B0
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValuesForKey
	*/

	// RVA: -1 Offset: -1
	public NativeParallelMultiHashMap.KeyValueEnumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-NativeParallelMultiHashMap<int, int>.GetEnumerator
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeParallelMultiHashMap<int, int>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeParallelMultiHashMap<int, int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckRead() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeParallelMultiHashMap<int, int>.CheckRead
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckRead
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeParallelMultiHashMap<int, int>.CheckWrite
	|-NativeParallelMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckWrite
	*/
}
