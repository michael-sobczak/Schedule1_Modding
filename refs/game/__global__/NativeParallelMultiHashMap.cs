public struct NativeParallelMultiHashMap.KeyValueEnumerator<TKey, TValue> : IEnumerator<KeyValue<TKey, TValue>>, IEnumerator, IDisposable // TypeDefIndex: 15872
{
	// Fields
	internal UnsafeParallelHashMapDataEnumerator m_Enumerator; // 0x0

	// Properties
	public KeyValue<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeParallelMultiHashMap.KeyValueEnumerator<int, int>.Dispose
	|-NativeParallelMultiHashMap.KeyValueEnumerator<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1672BD0 Offset: 0x16715D0 VA: 0x181672BD0
	|-NativeParallelMultiHashMap.KeyValueEnumerator<int, int>.MoveNext
	|-NativeParallelMultiHashMap.KeyValueEnumerator<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1676020 Offset: 0x1674A20 VA: 0x181676020
	|-NativeParallelMultiHashMap.KeyValueEnumerator<int, int>.Reset
	|-NativeParallelMultiHashMap.KeyValueEnumerator<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValue<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18C7580 Offset: 0x18C5F80 VA: 0x1818C7580
	|-NativeParallelMultiHashMap.KeyValueEnumerator<int, int>.get_Current
	|
	|-RVA: 0x169C850 Offset: 0x169B250 VA: 0x18169C850
	|-NativeParallelMultiHashMap.KeyValueEnumerator<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18C74E0 Offset: 0x18C5EE0 VA: 0x1818C74E0
	|-NativeParallelMultiHashMap.KeyValueEnumerator<int, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1699740 Offset: 0x1698140 VA: 0x181699740
	|-NativeParallelMultiHashMap.KeyValueEnumerator<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}
