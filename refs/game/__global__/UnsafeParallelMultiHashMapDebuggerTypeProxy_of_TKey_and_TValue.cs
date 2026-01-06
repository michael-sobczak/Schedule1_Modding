internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue> // TypeDefIndex: 16000
{
	// Fields
	private UnsafeParallelMultiHashMap<TKey, TValue> m_Target; // 0x0

	// Properties
	public List<ListPair<TKey, List<TValue>>> Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(UnsafeParallelMultiHashMap<TKey, TValue> target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086450 Offset: 0x1084E50 VA: 0x181086450
	|-UnsafeParallelMultiHashMapDebuggerTypeProxy<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static ValueTuple<NativeArray<TKey>, int> GetUniqueKeyArray(ref UnsafeParallelMultiHashMap<TKey, TValue> hashMap, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2450 Offset: 0x12E0E50 VA: 0x1812E2450
	|-UnsafeParallelMultiHashMapDebuggerTypeProxy<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetUniqueKeyArray
	*/

	// RVA: -1 Offset: -1
	public List<ListPair<TKey, List<TValue>>> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E25E0 Offset: 0x12E0FE0 VA: 0x1812E25E0
	|-UnsafeParallelMultiHashMapDebuggerTypeProxy<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Items
	*/
}
