internal struct FixedList<T, U> : INativeList<T>, IIndexable<T> // TypeDefIndex: 15757
{
	// Fields
	[SerializeField]
	internal ushort length; // 0x0
	[SerializeField]
	internal U buffer; // 0x0

	// Properties
	[CreateProperty]
	public int Length { get; set; }
	[CreateProperty]
	private IEnumerable<T> Elements { get; }
	public bool IsEmpty { get; }
	internal int LengthInBytes { get; }
	internal byte* Buffer { get; }
	public int Capacity { get; set; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801950 Offset: 0x1800350 VA: 0x181801950
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801B00 Offset: 0x1800500 VA: 0x181801B00
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> get_Elements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1110 Offset: 0x17CFB10 VA: 0x1817D1110
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Elements
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D11F0 Offset: 0x17CFBF0 VA: 0x1817D11F0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal int get_LengthInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1610 Offset: 0x17D0010 VA: 0x1817D1610
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_LengthInBytes
	*/

	// RVA: -1 Offset: -1
	internal byte* get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18016D0 Offset: 0x18000D0 VA: 0x1818016D0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Buffer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801780 Offset: 0x1800180 VA: 0x181801780
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18017E0 Offset: 0x18001E0 VA: 0x1818017E0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801990 Offset: 0x1800390 VA: 0x181801990
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1800720 Offset: 0x17FF120 VA: 0x181800720
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18007F0 Offset: 0x17FF1F0 VA: 0x1818007F0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void Add(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18004F0 Offset: 0x17FEEF0 VA: 0x1818004F0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1800320 Offset: 0x17FED20 VA: 0x181800320
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18001F0 Offset: 0x17FEBF0 VA: 0x1818001F0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1800280 Offset: 0x17FEC80 VA: 0x181800280
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18006A0 Offset: 0x17FF0A0 VA: 0x1818006A0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18008D0 Offset: 0x17FF2D0 VA: 0x1818008D0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1800B50 Offset: 0x17FF550 VA: 0x181800B50
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DC4A0 Offset: 0x12DAEA0 VA: 0x1812DC4A0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1800D60 Offset: 0x17FF760 VA: 0x181800D60
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1800CC0 Offset: 0x17FF6C0 VA: 0x181800CC0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12DC530 Offset: 0x12DAF30 VA: 0x1812DC530
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18010A0 Offset: 0x17FFAA0 VA: 0x1818010A0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801000 Offset: 0x17FFA00 VA: 0x181801000
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1801340 Offset: 0x17FFD40 VA: 0x181801340
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18014D0 Offset: 0x17FFED0 VA: 0x1818014D0
	|-FixedList<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>.ToNativeArray
	*/
}
