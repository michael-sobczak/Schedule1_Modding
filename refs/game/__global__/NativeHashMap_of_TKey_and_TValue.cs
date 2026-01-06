public struct NativeHashMap<TKey, TValue> : INativeDisposable, IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable // TypeDefIndex: 15749
{
	// Fields
	internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; // 0x0

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
	|-RVA: 0x1085E20 Offset: 0x1084820 VA: 0x181085E20
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085DB0 Offset: 0x10847B0 VA: 0x181085DB0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085FB0 Offset: 0x10849B0 VA: 0x181085FB0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10854E0 Offset: 0x1083EE0 VA: 0x1810854E0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085EC0 Offset: 0x10848C0 VA: 0x181085EC0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086270 Offset: 0x1084C70 VA: 0x181086270
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085380 Offset: 0x1083D80 VA: 0x181085380
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085B40 Offset: 0x1084540 VA: 0x181085B40
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085180 Offset: 0x1083B80 VA: 0x181085180
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10858B0 Offset: 0x10842B0 VA: 0x1810858B0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085CA0 Offset: 0x10846A0 VA: 0x181085CA0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10853F0 Offset: 0x1083DF0 VA: 0x1810853F0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086080 Offset: 0x1084A80 VA: 0x181086080
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10862F0 Offset: 0x1084CF0 VA: 0x1810862F0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085F30 Offset: 0x1084930 VA: 0x181085F30
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085550 Offset: 0x1083F50 VA: 0x181085550
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10855D0 Offset: 0x1083FD0 VA: 0x1810855D0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TKey> GetKeyArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10856C0 Offset: 0x10840C0 VA: 0x1810856C0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<TValue> GetValueArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085810 Offset: 0x1084210 VA: 0x181085810
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetValueArray
	*/

	// RVA: -1 Offset: -1
	public NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085760 Offset: 0x1084160 VA: 0x181085760
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetKeyValueArrays
	*/

	// RVA: -1 Offset: -1
	public NativeHashMap.ParallelWriter<TKey, TValue> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10852E0 Offset: 0x1083CE0 VA: 0x1810852E0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public NativeHashMap.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckRead() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckRead
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckWrite
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void ThrowKeyNotPresent(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085A50 Offset: 0x1084450 VA: 0x181085A50
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ThrowKeyNotPresent
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void ThrowKeyAlreadyAdded(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859E0 Offset: 0x10843E0 VA: 0x1810859E0
	|-NativeHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ThrowKeyAlreadyAdded
	*/
}
