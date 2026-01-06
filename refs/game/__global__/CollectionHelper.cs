public static class CollectionHelper // TypeDefIndex: 15738
{
	// Fields
	public const int CacheLineSize = 64;

	// Methods

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271D300 Offset: 0x271BD00 VA: 0x18271D300
	internal static void CheckAllocator(AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x271D820 Offset: 0x271C220 VA: 0x18271D820
	public static int Log2Floor(int value) { }

	// RVA: 0x271D7E0 Offset: 0x271C1E0 VA: 0x18271D7E0
	public static int Log2Ceil(int value) { }

	// RVA: 0x271D2C0 Offset: 0x271BCC0 VA: 0x18271D2C0
	public static int Align(int size, int alignmentPowerOfTwo) { }

	// RVA: 0x271D2E0 Offset: 0x271BCE0 VA: 0x18271D2E0
	public static ulong Align(ulong size, ulong alignmentPowerOfTwo) { }

	// RVA: 0x271D7C0 Offset: 0x271C1C0 VA: 0x18271D7C0
	public static bool IsAligned(void* p, int alignmentPowerOfTwo) { }

	// RVA: 0x271D7C0 Offset: 0x271C1C0 VA: 0x18271D7C0
	public static bool IsAligned(ulong offset, int alignmentPowerOfTwo) { }

	// RVA: 0x271D7D0 Offset: 0x271C1D0 VA: 0x18271D7D0
	public static bool IsPowerOfTwo(int value) { }

	// RVA: 0x271D790 Offset: 0x271C190 VA: 0x18271D790
	public static uint Hash(void* ptr, int bytes) { }

	[NotBurstCompatible]
	// RVA: 0x271D890 Offset: 0x271C290 VA: 0x18271D890
	internal static void WriteLayout(Type type) { }

	// RVA: 0x271D870 Offset: 0x271C270 VA: 0x18271D870
	internal static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	internal static int AssumePositive(int value) { }

	[NotBurstCompatible]
	[BurstDiscard]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	internal static void CheckIsUnmanaged<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE63710 Offset: 0xE62110 VA: 0x180E63710
	|-CollectionHelper.CheckIsUnmanaged<__Il2CppFullySharedGenericType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271D630 Offset: 0x271C030 VA: 0x18271D630
	internal static void CheckIntPositivePowerOfTwo(int value) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271D6E0 Offset: 0x271C0E0 VA: 0x18271D6E0
	internal static void CheckUlongPositivePowerOfTwo(ulong value) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	// RVA: 0x271D4F0 Offset: 0x271BEF0 VA: 0x18271D4F0
	internal static void CheckIndexInRange(int index, int length) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	// RVA: 0x271D3B0 Offset: 0x271BDB0 VA: 0x18271D3B0
	internal static void CheckCapacityInRange(int capacity, int length) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	public static NativeArray<T> CreateNativeArray<T, U>(int length, ref U allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE63A90 Offset: 0xE62490 VA: 0x180E63A90
	|-CollectionHelper.CreateNativeArray<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static NativeArray<T> CreateNativeArray<T>(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE637E0 Offset: 0xE621E0 VA: 0x180E637E0
	|-CollectionHelper.CreateNativeArray<byte>
	|
	|-RVA: 0xE63F50 Offset: 0xE62950 VA: 0x180E63F50
	|-CollectionHelper.CreateNativeArray<int>
	|
	|-RVA: 0xE64030 Offset: 0xE62A30 VA: 0x180E64030
	|-CollectionHelper.CreateNativeArray<float>
	|
	|-RVA: 0xE63D80 Offset: 0xE62780 VA: 0x180E63D80
	|-CollectionHelper.CreateNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static NativeArray<T> CreateNativeArray<T>(NativeArray<T> array, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE63C50 Offset: 0xE62650 VA: 0x180E63C50
	|-CollectionHelper.CreateNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public static NativeArray<T> CreateNativeArray<T>(T[] array, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE63E50 Offset: 0xE62850 VA: 0x180E63E50
	|-CollectionHelper.CreateNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public static NativeArray<T> CreateNativeArray<T, U>(T[] array, ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE638C0 Offset: 0xE622C0 VA: 0x180E638C0
	|-CollectionHelper.CreateNativeArray<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int), typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	public static NativeParallelHashMap<TKey, TValue> CreateNativeParallelHashMap<TKey, TValue, U>(int length, ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64110 Offset: 0xE62B10 VA: 0x180E64110
	|-CollectionHelper.CreateNativeParallelHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Obsolete("CreateNativeMultiHashMap is renamed to CreateNativeParallelHashMap. (UnityUpgradable) -> CreateNativeParallelHashMap<TKey, TValue, U>(*)", True)]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(int), typeof(AllocatorManager.AllocatorHandle) })]
	// RVA: -1 Offset: -1
	public static NativeHashMap<TKey, TValue> CreateNativeMultiHashMap<TKey, TValue, U>(int length, ref U allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64110 Offset: 0xE62B10 VA: 0x180E64110
	|-CollectionHelper.CreateNativeMultiHashMap<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/
}
