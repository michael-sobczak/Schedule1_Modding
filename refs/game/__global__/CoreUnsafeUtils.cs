public static class CoreUnsafeUtils // TypeDefIndex: 13569
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(List<T> list, void* dest, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6C900 Offset: 0xE6B300 VA: 0x180E6C900
	|-CoreUnsafeUtils.CopyTo<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] list, void* dest, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6CB50 Offset: 0xE6B550 VA: 0x180E6CB50
	|-CoreUnsafeUtils.CopyTo<int>
	|
	|-RVA: 0xE6CA30 Offset: 0xE6B430 VA: 0x180E6CA30
	|-CoreUnsafeUtils.CopyTo<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x29E6B70 Offset: 0x29E5570 VA: 0x1829E6B70
	private static void CalculateRadixParams(int radixBits, out int bitStates) { }

	// RVA: 0x29E6C30 Offset: 0x29E5630 VA: 0x1829E6C30
	private static int CalculateRadixSupportSize(int bitStates, int arrayLength) { }

	// RVA: 0x29E6BF0 Offset: 0x29E55F0 VA: 0x1829E6BF0
	private static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, uint* supportArray, out uint* bucketIndices, out uint* bucketSizes, out uint* bucketPrefix, out uint* arrayOutput) { }

	// RVA: 0x29E7140 Offset: 0x29E5B40 VA: 0x1829E7140
	private static void MergeSort(uint* array, uint* support, int length) { }

	// RVA: 0x29E7320 Offset: 0x29E5D20 VA: 0x1829E7320
	public static void MergeSort(uint[] arr, int sortSize, ref uint[] supportArray) { }

	// RVA: 0x29E7040 Offset: 0x29E5A40 VA: 0x1829E7040
	public static void MergeSort(NativeArray<uint> arr, int sortSize, ref NativeArray<uint> supportArray) { }

	// RVA: 0x29E6F20 Offset: 0x29E5920 VA: 0x1829E6F20
	private static void InsertionSort(uint* arr, int length) { }

	// RVA: 0x29E6F70 Offset: 0x29E5970 VA: 0x1829E6F70
	public static void InsertionSort(uint[] arr, int sortSize) { }

	// RVA: 0x29E6E30 Offset: 0x29E5830 VA: 0x1829E6E30
	public static void InsertionSort(NativeArray<uint> arr, int sortSize) { }

	// RVA: 0x29E7480 Offset: 0x29E5E80 VA: 0x1829E7480
	private static void RadixSort(uint* array, uint* support, int radixBits, int bitStates, int length) { }

	// RVA: 0x29E7640 Offset: 0x29E6040 VA: 0x1829E7640
	public static void RadixSort(uint[] arr, int sortSize, ref uint[] supportArray, int radixBits = 8) { }

	// RVA: 0x29E77C0 Offset: 0x29E61C0 VA: 0x1829E77C0
	public static void RadixSort(NativeArray<uint> array, int sortSize, ref NativeArray<uint> supportArray, int radixBits = 8) { }

	// RVA: 0x29E7410 Offset: 0x29E5E10 VA: 0x1829E7410
	public static void QuickSort(uint[] arr, int left, int right) { }

	// RVA: -1 Offset: -1
	public static void QuickSort<T>(int count, void* data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6DB60 Offset: 0xE6C560 VA: 0x180E6DB60
	|-CoreUnsafeUtils.QuickSort<int>
	|
	|-RVA: 0xE6D8A0 Offset: 0xE6C2A0 VA: 0x180E6D8A0
	|-CoreUnsafeUtils.QuickSort<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void QuickSort<TValue, TKey, TGetter>(int count, void* data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6D8A0 Offset: 0xE6C2A0 VA: 0x180E6D8A0
	|-CoreUnsafeUtils.QuickSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6D9A0 Offset: 0xE6C3A0 VA: 0x180E6D9A0
	|-CoreUnsafeUtils.QuickSort<int, int, CoreUnsafeUtils.DefaultKeyGetter<int>>
	|
	|-RVA: 0xE6DBB0 Offset: 0xE6C5B0 VA: 0x180E6DBB0
	|-CoreUnsafeUtils.QuickSort<uint, uint, CoreUnsafeUtils.UintKeyGetter>
	|
	|-RVA: 0xE6D8F0 Offset: 0xE6C2F0 VA: 0x180E6D8F0
	|-CoreUnsafeUtils.QuickSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(void* data, int count, T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6CBD0 Offset: 0xE6B5D0 VA: 0x180E6CBD0
	|-CoreUnsafeUtils.IndexOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6BCE0 Offset: 0xE6A6E0 VA: 0x180E6BCE0
	|-CoreUnsafeUtils.CompareHashes<Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>, Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	|
	|-RVA: 0xE6C100 Offset: 0xE6AB00 VA: 0x180E6C100
	|-CoreUnsafeUtils.CompareHashes<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x29E6CA0 Offset: 0x29E56A0 VA: 0x1829E6CA0
	public static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) { }

	// RVA: -1 Offset: -1
	public static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6B9C0 Offset: 0xE6A3C0 VA: 0x180E6B9C0
	|-CoreUnsafeUtils.CombineHashes<Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	|
	|-RVA: 0xE6BA70 Offset: 0xE6A470 VA: 0x180E6BA70
	|-CoreUnsafeUtils.CombineHashes<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x29E6C40 Offset: 0x29E5640 VA: 0x1829E6C40
	public static void CombineHashes(int count, Hash128* hashes, Hash128* outHash) { }

	// RVA: -1 Offset: -1
	private static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6D620 Offset: 0xE6C020 VA: 0x180E6D620
	|-CoreUnsafeUtils.Partition<int, int, CoreUnsafeUtils.DefaultKeyGetter<int>>
	|
	|-RVA: 0xE6D760 Offset: 0xE6C160 VA: 0x180E6D760
	|-CoreUnsafeUtils.Partition<uint, uint, CoreUnsafeUtils.UintKeyGetter>
	|
	|-RVA: 0xE6CDD0 Offset: 0xE6B7D0 VA: 0x180E6CDD0
	|-CoreUnsafeUtils.Partition<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x29E6D10 Offset: 0x29E5710 VA: 0x1829E6D10
	public static bool HaveDuplicates(int[] arr) { }
}
