public static class NativeSortExtension // TypeDefIndex: 15891
{
	// Fields
	private const int k_IntrosortSizeThreshold = 16;

	// Methods

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void Sort<T>(T* array, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D900 Offset: 0xF0C300 VA: 0x180F0D900
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static void Sort<T, U>(T* array, int length, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D520 Offset: 0xF0BF20 VA: 0x180F0D520
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(T*, int).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T>(T* array, int length, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DD30 Offset: 0xF0C730 VA: 0x180F0DD30
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(T* array, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CDC0 Offset: 0xF0B7C0 VA: 0x180F0CDC0
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType>
	*/

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(T*, int, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T, U>(T* array, int length, U comp, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D080 Offset: 0xF0BA80 VA: 0x180F0D080
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, U> SortJob<T, U>(T* array, int length, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C6F0 Offset: 0xF0B0F0 VA: 0x180F0C6F0
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T* ptr, int length, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AEF0 Offset: 0xF098F0 VA: 0x180F0AEF0
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T, U>(T* ptr, int length, T value, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AB10 Offset: 0xF09510 VA: 0x180F0AB10
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void Sort<T>(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D990 Offset: 0xF0C390 VA: 0x180F0D990
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static void Sort<T, U>(NativeArray<T> array, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CF50 Offset: 0xF0B950 VA: 0x180F0CF50
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeArray<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T>(NativeArray<T> array, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DBC0 Offset: 0xF0C5C0 VA: 0x180F0DBC0
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int) })]
	[Extension]
	// RVA: -1 Offset: -1
	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CC30 Offset: 0xF0B630 VA: 0x180F0CC30
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeArray<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T, U>(NativeArray<T> array, U comp, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CDE0 Offset: 0xF0B7E0 VA: 0x180F0CDE0
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, U> SortJob<T, U>(NativeArray<T> array, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CA30 Offset: 0xF0B430 VA: 0x180F0CA30
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(NativeArray<T> array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AFC0 Offset: 0xF099C0 VA: 0x180F0AFC0
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T, U>(NativeArray<T> array, T value, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A990 Offset: 0xF09390 VA: 0x180F0A990
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void Sort<T>(NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D890 Offset: 0xF0C290 VA: 0x180F0D890
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static void Sort<T, U>(NativeList<T> list, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CF50 Offset: 0xF0B950 VA: 0x180F0CF50
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[NotBurstCompatible]
	[Extension]
	[Obsolete("Instead call SortJob(this NativeList<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T>(NativeList<T> array, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DA40 Offset: 0xF0C440 VA: 0x180F0DA40
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int) })]
	[Extension]
	// RVA: -1 Offset: -1
	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(NativeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CC30 Offset: 0xF0B630 VA: 0x180F0CC30
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeList<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T, U>(NativeList<T> list, U comp, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CDE0 Offset: 0xF0B7E0 VA: 0x180F0CDE0
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, U> SortJob<T, U>(NativeList<T> list, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C580 Offset: 0xF0AF80 VA: 0x180F0C580
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(NativeList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AFC0 Offset: 0xF099C0 VA: 0x180F0AFC0
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T, U>(NativeList<T> list, T value, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A990 Offset: 0xF09390 VA: 0x180F0A990
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void Sort<T>(UnsafeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DCB0 Offset: 0xF0C6B0 VA: 0x180F0DCB0
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static void Sort<T, U>(UnsafeList<T> list, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D770 Offset: 0xF0C170 VA: 0x180F0D770
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this UnsafeList<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T>(UnsafeList<T> list, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DB00 Offset: 0xF0C500 VA: 0x180F0DB00
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(UnsafeList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CD00 Offset: 0xF0B700 VA: 0x180F0CD00
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this UnsafeList<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T, U>(UnsafeList<T> list, U comp, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D610 Offset: 0xF0C010 VA: 0x180F0D610
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, U> SortJob<T, U>(UnsafeList<T> list, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C8C0 Offset: 0xF0B2C0 VA: 0x180F0C8C0
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(UnsafeList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B090 Offset: 0xF09A90 VA: 0x180F0B090
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T, U>(UnsafeList<T> list, T value, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AD70 Offset: 0xF09770 VA: 0x180F0AD70
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static void Sort<T>(NativeSlice<T> slice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0D890 Offset: 0xF0C290 VA: 0x180F0D890
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static void Sort<T, U>(NativeSlice<T> slice, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CF50 Offset: 0xF0B950 VA: 0x180F0CF50
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Obsolete("Instead call SortJob(this NativeSlice<T>).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	[NotBurstCompatible]
	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T>(NativeSlice<T> slice, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DA40 Offset: 0xF0C440 VA: 0x180F0DA40
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, NativeSortExtension.DefaultComparer<T>> SortJob<T>(NativeSlice<T> slice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CC30 Offset: 0xF0B630 VA: 0x180F0CC30
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[NotBurstCompatible]
	[Obsolete("Instead call SortJob(this NativeSlice<T>, U).Schedule(JobHandle). (RemovedAfter 2021-06-20)", False)]
	// RVA: -1 Offset: -1
	public static JobHandle Sort<T, U>(NativeSlice<T> slice, U comp, JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0CDE0 Offset: 0xF0B7E0 VA: 0x180F0CDE0
	|-NativeSortExtension.Sort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static SortJob<T, U> SortJob<T, U>(NativeSlice<T> slice, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0C580 Offset: 0xF0AF80 VA: 0x180F0C580
	|-NativeSortExtension.SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(NativeSlice<T> slice, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0AFC0 Offset: 0xF099C0 VA: 0x180F0AFC0
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	public static int BinarySearch<T, U>(NativeSlice<T> slice, T value, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0A990 Offset: 0xF09390 VA: 0x180F0A990
	|-NativeSortExtension.BinarySearch<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int), typeof(NativeSortExtension.DefaultComparer<int>) })]
	// RVA: -1 Offset: -1
	internal static void IntroSort<T, U>(void* array, int length, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0BE20 Offset: 0xF0A820 VA: 0x180F0BE20
	|-NativeSortExtension.IntroSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort<T, U>(void* array, int lo, int hi, int depth, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B8E0 Offset: 0xF0A2E0 VA: 0x180F0B8E0
	|-NativeSortExtension.IntroSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF05B70 Offset: 0xF04570 VA: 0x180F05B70
	|-NativeSortExtension.InsertionSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static int Partition<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0BF50 Offset: 0xF0A950 VA: 0x180F0BF50
	|-NativeSortExtension.Partition<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void HeapSort<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B1E0 Offset: 0xF09BE0 VA: 0x180F0B1E0
	|-NativeSortExtension.HeapSort<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void Heapify<T, U>(void* array, int i, int n, int lo, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B420 Offset: 0xF09E20 VA: 0x180F0B420
	|-NativeSortExtension.Heapify<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void Swap<T>(void* array, int lhs, int rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DFE0 Offset: 0xF0C9E0 VA: 0x180F0DFE0
	|-NativeSortExtension.Swap<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DDF0 Offset: 0xF0C7F0 VA: 0x180F0DDF0
	|-NativeSortExtension.SwapIfGreaterWithItems<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void IntroSortStruct<T, U>(void* array, int length, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0BE20 Offset: 0xF0A820 VA: 0x180F0BE20
	|-NativeSortExtension.IntroSortStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void IntroSortStruct<T, U>(void* array, int lo, int hi, int depth, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B8E0 Offset: 0xF0A2E0 VA: 0x180F0B8E0
	|-NativeSortExtension.IntroSortStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSortStruct<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF05B70 Offset: 0xF04570 VA: 0x180F05B70
	|-NativeSortExtension.InsertionSortStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static int PartitionStruct<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0BF50 Offset: 0xF0A950 VA: 0x180F0BF50
	|-NativeSortExtension.PartitionStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void HeapSortStruct<T, U>(void* array, int lo, int hi, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B1E0 Offset: 0xF09BE0 VA: 0x180F0B1E0
	|-NativeSortExtension.HeapSortStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void HeapifyStruct<T, U>(void* array, int i, int n, int lo, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B420 Offset: 0xF09E20 VA: 0x180F0B420
	|-NativeSortExtension.HeapifyStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void SwapStruct<T>(void* array, int lhs, int rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DFE0 Offset: 0xF0C9E0 VA: 0x180F0DFE0
	|-NativeSortExtension.SwapStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItemsStruct<T, U>(void* array, int lhs, int rhs, U comp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0DDF0 Offset: 0xF0C7F0 VA: 0x180F0DDF0
	|-NativeSortExtension.SwapIfGreaterWithItemsStruct<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private static void CheckStrideMatchesSize<T>(int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF0B160 Offset: 0xF09B60 VA: 0x180F0B160
	|-NativeSortExtension.CheckStrideMatchesSize<__Il2CppFullySharedGenericStructType>
	*/
}
