internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 5008
{
	// Fields
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129BFB0 Offset: 0x129A9B0 VA: 0x18129BFB0
	|-ArraySortHelper<int, int>.Sort
	|
	|-RVA: 0x129C530 Offset: 0x129AF30 VA: 0x18129C530
	|-ArraySortHelper<object, int>.Sort
	|
	|-RVA: 0x129C1B0 Offset: 0x129ABB0 VA: 0x18129C1B0
	|-ArraySortHelper<float, int>.Sort
	|
	|-RVA: 0x129BDB0 Offset: 0x129A7B0 VA: 0x18129BDB0
	|-ArraySortHelper<ulong, object>.Sort
	|
	|-RVA: 0x129C3B0 Offset: 0x129ADB0 VA: 0x18129C3B0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129C730 Offset: 0x129B130 VA: 0x18129C730
	|-ArraySortHelper<int, int>.SwapIfGreaterWithItems
	|
	|-RVA: 0x129CFE0 Offset: 0x129B9E0 VA: 0x18129CFE0
	|-ArraySortHelper<object, int>.SwapIfGreaterWithItems
	|
	|-RVA: 0x129CEA0 Offset: 0x129B8A0 VA: 0x18129CEA0
	|-ArraySortHelper<float, int>.SwapIfGreaterWithItems
	|
	|-RVA: 0x129D130 Offset: 0x129BB30 VA: 0x18129D130
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x129C850 Offset: 0x129B250 VA: 0x18129C850
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129D860 Offset: 0x129C260 VA: 0x18129D860
	|-ArraySortHelper<int, int>.Swap
	|
	|-RVA: 0x129D280 Offset: 0x129BC80 VA: 0x18129D280
	|-ArraySortHelper<object, int>.Swap
	|
	|-RVA: 0x129D8F0 Offset: 0x129C2F0 VA: 0x18129D8F0
	|-ArraySortHelper<float, int>.Swap
	|
	|-RVA: 0x129D980 Offset: 0x129C380 VA: 0x18129D980
	|-ArraySortHelper<ulong, object>.Swap
	|
	|-RVA: 0x129D340 Offset: 0x129BD40 VA: 0x18129D340
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1299F00 Offset: 0x1298900 VA: 0x181299F00
	|-ArraySortHelper<int, int>.IntrospectiveSort
	|
	|-RVA: 0x129A2F0 Offset: 0x1298CF0 VA: 0x18129A2F0
	|-ArraySortHelper<object, int>.IntrospectiveSort
	|
	|-RVA: 0x1299FF0 Offset: 0x12989F0 VA: 0x181299FF0
	|-ArraySortHelper<float, int>.IntrospectiveSort
	|
	|-RVA: 0x129A200 Offset: 0x1298C00 VA: 0x18129A200
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	|
	|-RVA: 0x129A0E0 Offset: 0x1298AE0 VA: 0x18129A0E0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1299B20 Offset: 0x1298520 VA: 0x181299B20
	|-ArraySortHelper<int, int>.IntroSort
	|
	|-RVA: 0x1299270 Offset: 0x1297C70 VA: 0x181299270
	|-ArraySortHelper<object, int>.IntroSort
	|
	|-RVA: 0x1298E90 Offset: 0x1297890 VA: 0x181298E90
	|-ArraySortHelper<float, int>.IntroSort
	|
	|-RVA: 0x1298AB0 Offset: 0x12974B0 VA: 0x181298AB0
	|-ArraySortHelper<ulong, object>.IntroSort
	|
	|-RVA: 0x1299650 Offset: 0x1298050 VA: 0x181299650
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129A3E0 Offset: 0x1298DE0 VA: 0x18129A3E0
	|-ArraySortHelper<int, int>.PickPivotAndPartition
	|
	|-RVA: 0x129AF30 Offset: 0x1299930 VA: 0x18129AF30
	|-ArraySortHelper<object, int>.PickPivotAndPartition
	|
	|-RVA: 0x129B8D0 Offset: 0x129A2D0 VA: 0x18129B8D0
	|-ArraySortHelper<float, int>.PickPivotAndPartition
	|
	|-RVA: 0x129B3F0 Offset: 0x1299DF0 VA: 0x18129B3F0
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	|
	|-RVA: 0x129A8A0 Offset: 0x12992A0 VA: 0x18129A8A0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12975A0 Offset: 0x1295FA0 VA: 0x1812975A0
	|-ArraySortHelper<int, int>.Heapsort
	|
	|-RVA: 0x1297820 Offset: 0x1296220 VA: 0x181297820
	|-ArraySortHelper<object, int>.Heapsort
	|
	|-RVA: 0x1296E20 Offset: 0x1295820 VA: 0x181296E20
	|-ArraySortHelper<float, int>.Heapsort
	|
	|-RVA: 0x12972F0 Offset: 0x1295CF0 VA: 0x1812972F0
	|-ArraySortHelper<ulong, object>.Heapsort
	|
	|-RVA: 0x12970A0 Offset: 0x1295AA0 VA: 0x1812970A0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1295D60 Offset: 0x1294760 VA: 0x181295D60
	|-ArraySortHelper<int, int>.DownHeap
	|
	|-RVA: 0x1296B40 Offset: 0x1295540 VA: 0x181296B40
	|-ArraySortHelper<object, int>.DownHeap
	|
	|-RVA: 0x1295A90 Offset: 0x1294490 VA: 0x181295A90
	|-ArraySortHelper<float, int>.DownHeap
	|
	|-RVA: 0x1296030 Offset: 0x1294A30 VA: 0x181296030
	|-ArraySortHelper<ulong, object>.DownHeap
	|
	|-RVA: 0x1296320 Offset: 0x1294D20 VA: 0x181296320
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1298170 Offset: 0x1296B70 VA: 0x181298170
	|-ArraySortHelper<int, int>.InsertionSort
	|
	|-RVA: 0x1298860 Offset: 0x1297260 VA: 0x181298860
	|-ArraySortHelper<object, int>.InsertionSort
	|
	|-RVA: 0x1298620 Offset: 0x1297020 VA: 0x181298620
	|-ArraySortHelper<float, int>.InsertionSort
	|
	|-RVA: 0x12983C0 Offset: 0x1296DC0 VA: 0x1812983C0
	|-ArraySortHelper<ulong, object>.InsertionSort
	|
	|-RVA: 0x1297AE0 Offset: 0x12964E0 VA: 0x181297AE0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129DC70 Offset: 0x129C670 VA: 0x18129DC70
	|-ArraySortHelper<int, int>.get_Default
	|-ArraySortHelper<object, int>.get_Default
	|-ArraySortHelper<float, int>.get_Default
	|-ArraySortHelper<ulong, object>.get_Default
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Default
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	|-ArraySortHelper<int, int>..ctor
	|-ArraySortHelper<object, int>..ctor
	|-ArraySortHelper<float, int>..ctor
	|-ArraySortHelper<ulong, object>..ctor
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x129DB80 Offset: 0x129C580 VA: 0x18129DB80
	|-ArraySortHelper<int, int>..cctor
	|-ArraySortHelper<object, int>..cctor
	|-ArraySortHelper<float, int>..cctor
	|-ArraySortHelper<ulong, object>..cctor
	|
	|-RVA: 0x129DA50 Offset: 0x129C450 VA: 0x18129DA50
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}
