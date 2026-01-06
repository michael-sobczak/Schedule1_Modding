public static class NativeParallelHashMapExtensions // TypeDefIndex: 15863
{
	// Methods

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static int Unique<T>(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09D90 Offset: 0xF08790 VA: 0x180F09D90
	|-NativeParallelHashMapExtensions.Unique<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static ValueTuple<NativeArray<TKey>, int> GetUniqueKeyArray<TKey, TValue>(UnsafeParallelMultiHashMap<TKey, TValue> container, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09BB0 Offset: 0xF085B0 VA: 0x180F09BB0
	|-NativeParallelHashMapExtensions.GetUniqueKeyArray<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static ValueTuple<NativeArray<TKey>, int> GetUniqueKeyArray<TKey, TValue>(NativeParallelMultiHashMap<TKey, TValue> container, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09BB0 Offset: 0xF085B0 VA: 0x180F09BB0
	|-NativeParallelHashMapExtensions.GetUniqueKeyArray<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	[Obsolete("GetBucketData is deprecated, please use GetUnsafeBucketData instead. (RemovedAfter 2021-07-08) (UnityUpgradable) -> GetUnsafeBucketData<TKey,TValue>(*)", False)]
	[Extension]
	// RVA: -1 Offset: -1
	public static UnsafeHashMapBucketData GetBucketData<TKey, TValue>(NativeParallelHashMap<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09B70 Offset: 0xF08570 VA: 0x180F09B70
	|-NativeParallelHashMapExtensions.GetBucketData<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static UnsafeHashMapBucketData GetUnsafeBucketData<TKey, TValue>(NativeParallelHashMap<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09B70 Offset: 0xF08570 VA: 0x180F09B70
	|-NativeParallelHashMapExtensions.GetUnsafeBucketData<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static UnsafeHashMapBucketData GetUnsafeBucketData<TKey, TValue>(NativeParallelMultiHashMap<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09B70 Offset: 0xF08570 VA: 0x180F09B70
	|-NativeParallelHashMapExtensions.GetUnsafeBucketData<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int) })]
	// RVA: -1 Offset: -1
	public static void Remove<TKey, TValue>(NativeParallelMultiHashMap<TKey, TValue> container, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09C90 Offset: 0xF08690 VA: 0x180F09C90
	|-NativeParallelHashMapExtensions.Remove<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}
