internal struct UnsafeParallelHashMapData // TypeDefIndex: 15979
{
	// Fields
	internal byte* values; // 0x0
	internal byte* keys; // 0x8
	internal byte* next; // 0x10
	internal byte* buckets; // 0x18
	internal int keyCapacity; // 0x20
	internal int bucketCapacityMask; // 0x24
	internal int allocatedIndexLength; // 0x28
	[FixedBuffer(typeof(int), 2048)]
	internal UnsafeParallelHashMapData.<firstFreeTLS>e__FixedBuffer firstFreeTLS; // 0x40
	internal const int IntsPerCacheLine = 16;

	// Methods

	// RVA: 0x2740FD0 Offset: 0x273F9D0 VA: 0x182740FD0
	internal static int GetBucketSize(int capacity) { }

	// RVA: 0x2741050 Offset: 0x273FA50 VA: 0x182741050
	internal static int GrowCapacity(int capacity) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6AF30 Offset: 0xF69930 VA: 0x180F6AF30
	|-UnsafeParallelHashMapData.AllocateHashMap<int, int>
	|
	|-RVA: 0xF6AE00 Offset: 0xF69800 VA: 0x180F6AE00
	|-UnsafeParallelHashMapData.AllocateHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6BF10 Offset: 0xF6A910 VA: 0x180F6BF10
	|-UnsafeParallelHashMapData.ReallocateHashMap<int, int>
	|
	|-RVA: 0xF6BB10 Offset: 0xF6A510 VA: 0x180F6BB10
	|-UnsafeParallelHashMapData.ReallocateHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2740F30 Offset: 0x273F930 VA: 0x182740F30
	internal static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6B1D0 Offset: 0xF69BD0 VA: 0x180F6B1D0
	|-UnsafeParallelHashMapData.CalculateDataSize<int, int>
	|
	|-RVA: 0xF6B0D0 Offset: 0xF69AD0 VA: 0x180F6B0D0
	|-UnsafeParallelHashMapData.CalculateDataSize<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2741060 Offset: 0x273FA60 VA: 0x182741060
	internal static bool IsEmpty(UnsafeParallelHashMapData* data) { }

	// RVA: 0x2740FE0 Offset: 0x273F9E0 VA: 0x182740FE0
	internal static int GetCount(UnsafeParallelHashMapData* data) { }

	// RVA: 0x27410B0 Offset: 0x273FAB0 VA: 0x1827410B0
	internal static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void GetKeyArray<TKey>(UnsafeParallelHashMapData* data, NativeArray<TKey> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6B480 Offset: 0xF69E80 VA: 0x180F6B480
	|-UnsafeParallelHashMapData.GetKeyArray<int>
	|
	|-RVA: 0xF6B2C0 Offset: 0xF69CC0 VA: 0x180F6B2C0
	|-UnsafeParallelHashMapData.GetKeyArray<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void GetValueArray<TValue>(UnsafeParallelHashMapData* data, NativeArray<TValue> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6BA50 Offset: 0xF6A450 VA: 0x180F6BA50
	|-UnsafeParallelHashMapData.GetValueArray<int>
	|
	|-RVA: 0xF6B890 Offset: 0xF6A290 VA: 0x180F6B890
	|-UnsafeParallelHashMapData.GetValueArray<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	internal static void GetKeyValueArrays<TKey, TValue>(UnsafeParallelHashMapData* data, NativeKeyValueArrays<TKey, TValue> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6B7B0 Offset: 0xF6A1B0 VA: 0x180F6B7B0
	|-UnsafeParallelHashMapData.GetKeyValueArrays<int, int>
	|
	|-RVA: 0xF6B540 Offset: 0xF69F40 VA: 0x180F6B540
	|-UnsafeParallelHashMapData.GetKeyValueArrays<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2740FA0 Offset: 0x273F9A0 VA: 0x182740FA0
	internal UnsafeHashMapBucketData GetBucketData() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2740EC0 Offset: 0x273F8C0 VA: 0x182740EC0
	private static void CheckHashMapReallocateDoesNotShrink(UnsafeParallelHashMapData* data, int newCapacity) { }
}
