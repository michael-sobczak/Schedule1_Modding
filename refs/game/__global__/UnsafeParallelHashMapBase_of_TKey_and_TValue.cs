internal struct UnsafeParallelHashMapBase<TKey, TValue> // TypeDefIndex: 15982
{
	// Methods

	// RVA: -1 Offset: -1
	internal static void Clear(UnsafeParallelHashMapData* data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF700 Offset: 0x12DE100 VA: 0x1812DF700
	|-UnsafeParallelHashMapBase<int, int>.Clear
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	internal static int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF370 Offset: 0x12DDD70 VA: 0x1812DF370
	|-UnsafeParallelHashMapBase<int, int>.AllocEntry
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AllocEntry
	*/

	// RVA: -1 Offset: -1
	internal static void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF770 Offset: 0x12DE170 VA: 0x1812DF770
	|-UnsafeParallelHashMapBase<int, int>.FreeEntry
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.FreeEntry
	*/

	// RVA: -1 Offset: -1
	internal static bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0470 Offset: 0x12DEE70 VA: 0x1812E0470
	|-UnsafeParallelHashMapBase<int, int>.TryAddAtomic
	|
	|-RVA: 0x12E06C0 Offset: 0x12DF0C0 VA: 0x1812E06C0
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryAddAtomic
	*/

	// RVA: -1 Offset: -1
	internal static void AddAtomicMulti(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DEEF0 Offset: 0x12DD8F0 VA: 0x1812DEEF0
	|-UnsafeParallelHashMapBase<int, int>.AddAtomicMulti
	|
	|-RVA: 0x12DF010 Offset: 0x12DDA10 VA: 0x1812DF010
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AddAtomicMulti
	*/

	// RVA: -1 Offset: -1
	internal static bool TryAdd(UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorManager.AllocatorHandle allocation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E11C0 Offset: 0x12DFBC0 VA: 0x1812E11C0
	|-UnsafeParallelHashMapBase<int, int>.TryAdd
	|
	|-RVA: 0x12E0C70 Offset: 0x12DF670 VA: 0x1812E0C70
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	internal static int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF800 Offset: 0x12DE200 VA: 0x1812DF800
	|-UnsafeParallelHashMapBase<int, int>.Remove
	|
	|-RVA: 0x12DFA60 Offset: 0x12DE460 VA: 0x1812DFA60
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	internal static void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF990 Offset: 0x12DE390 VA: 0x1812DF990
	|-UnsafeParallelHashMapBase<int, int>.Remove
	|
	|-RVA: 0x12DFE70 Offset: 0x12DE870 VA: 0x1812DFE70
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Remove
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void RemoveKeyValue<TValueEQ>(UnsafeParallelHashMapData* data, TKey key, TValueEQ value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCEBB0 Offset: 0xDCD5B0 VA: 0x180DCEBB0
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveKeyValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E13F0 Offset: 0x12DFDF0 VA: 0x1812E13F0
	|-UnsafeParallelHashMapBase<int, int>.TryGetFirstValueAtomic
	|
	|-RVA: 0x12E15A0 Offset: 0x12DFFA0 VA: 0x1812E15A0
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetFirstValueAtomic
	*/

	// RVA: -1 Offset: -1
	internal static bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E1EB0 Offset: 0x12E08B0 VA: 0x1812E1EB0
	|-UnsafeParallelHashMapBase<int, int>.TryGetNextValueAtomic
	|
	|-RVA: 0x12E1950 Offset: 0x12E0350 VA: 0x1812E1950
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.TryGetNextValueAtomic
	*/

	// RVA: -1 Offset: -1
	internal static bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey> it, ref TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0200 Offset: 0x12DEC00 VA: 0x1812E0200
	|-UnsafeParallelHashMapBase<int, int>.SetValue
	|
	|-RVA: 0x12E0260 Offset: 0x12DEC60 VA: 0x1812E0260
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.SetValue
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckOutOfCapacity(int idx, int keyCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF640 Offset: 0x12DE040 VA: 0x1812DF640
	|-UnsafeParallelHashMapBase<int, int>.CheckOutOfCapacity
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckOutOfCapacity
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckIndexOutOfBounds(UnsafeParallelHashMapData* data, int idx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DF5D0 Offset: 0x12DDFD0 VA: 0x1812DF5D0
	|-UnsafeParallelHashMapBase<int, int>.CheckIndexOutOfBounds
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.CheckIndexOutOfBounds
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void ThrowFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E03D0 Offset: 0x12DEDD0 VA: 0x1812E03D0
	|-UnsafeParallelHashMapBase<int, int>.ThrowFull
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ThrowFull
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void ThrowInvalidIterator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0420 Offset: 0x12DEE20 VA: 0x1812E0420
	|-UnsafeParallelHashMapBase<int, int>.ThrowInvalidIterator
	|-UnsafeParallelHashMapBase<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ThrowInvalidIterator
	*/
}
