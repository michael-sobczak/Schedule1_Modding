public struct FixedList32Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 15761
{
	// Fields
	[SerializeField]
	internal ushort length; // 0x0
	[SerializeField]
	internal FixedBytes30 buffer; // 0x0

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
	|-RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50
	|-FixedList32Bytes<byte>.get_Length
	|-FixedList32Bytes<int>.get_Length
	|-FixedList32Bytes<float>.get_Length
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	|-FixedList32Bytes<byte>.set_Length
	|-FixedList32Bytes<int>.set_Length
	|-FixedList32Bytes<float>.set_Length
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> get_Elements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1180 Offset: 0x17CFB80 VA: 0x1817D1180
	|-FixedList32Bytes<byte>.get_Elements
	|
	|-RVA: 0x17D10D0 Offset: 0x17CFAD0 VA: 0x1817D10D0
	|-FixedList32Bytes<int>.get_Elements
	|-FixedList32Bytes<float>.get_Elements
	|
	|-RVA: 0x17D1110 Offset: 0x17CFB10 VA: 0x1817D1110
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_Elements
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D11C0 Offset: 0x17CFBC0 VA: 0x1817D11C0
	|-FixedList32Bytes<byte>.get_IsEmpty
	|-FixedList32Bytes<int>.get_IsEmpty
	|-FixedList32Bytes<float>.get_IsEmpty
	|
	|-RVA: 0x17D11F0 Offset: 0x17CFBF0 VA: 0x1817D11F0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal int get_LengthInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D15C0 Offset: 0x17CFFC0 VA: 0x1817D15C0
	|-FixedList32Bytes<byte>.get_LengthInBytes
	|
	|-RVA: 0x17D16D0 Offset: 0x17D00D0 VA: 0x1817D16D0
	|-FixedList32Bytes<int>.get_LengthInBytes
	|-FixedList32Bytes<float>.get_LengthInBytes
	|
	|-RVA: 0x17D1610 Offset: 0x17D0010 VA: 0x1817D1610
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_LengthInBytes
	*/

	// RVA: -1 Offset: -1
	internal byte* get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0F50 Offset: 0x17CF950 VA: 0x1817D0F50
	|-FixedList32Bytes<byte>.get_Buffer
	|
	|-RVA: 0x17D0F10 Offset: 0x17CF910 VA: 0x1817D0F10
	|-FixedList32Bytes<int>.get_Buffer
	|-FixedList32Bytes<float>.get_Buffer
	|
	|-RVA: 0x17D0F90 Offset: 0x17CF990 VA: 0x1817D0F90
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_Buffer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D7140 Offset: 0x17D5B40 VA: 0x1817D7140
	|-FixedList32Bytes<byte>.get_Capacity
	|
	|-RVA: 0x17D7110 Offset: 0x17D5B10 VA: 0x1817D7110
	|-FixedList32Bytes<int>.get_Capacity
	|-FixedList32Bytes<float>.get_Capacity
	|
	|-RVA: 0x17D1070 Offset: 0x17CFA70 VA: 0x1817D1070
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FixedList32Bytes<byte>.set_Capacity
	|-FixedList32Bytes<int>.set_Capacity
	|-FixedList32Bytes<float>.set_Capacity
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1480 Offset: 0x17CFE80 VA: 0x1817D1480
	|-FixedList32Bytes<byte>.get_Item
	|
	|-RVA: 0x17D1520 Offset: 0x17CFF20 VA: 0x1817D1520
	|-FixedList32Bytes<int>.get_Item
	|
	|-RVA: 0x17D13E0 Offset: 0x17CFDE0 VA: 0x1817D13E0
	|-FixedList32Bytes<float>.get_Item
	|
	|-RVA: 0x17D1270 Offset: 0x17CFC70 VA: 0x1817D1270
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4AB0 Offset: 0x17D34B0 VA: 0x1817D4AB0
	|-FixedList32Bytes<byte>.set_Item
	|
	|-RVA: 0x17D4C10 Offset: 0x17D3610 VA: 0x1817D4C10
	|-FixedList32Bytes<int>.set_Item
	|
	|-RVA: 0x17D4B60 Offset: 0x17D3560 VA: 0x1817D4B60
	|-FixedList32Bytes<float>.set_Item
	|
	|-RVA: 0x17D4940 Offset: 0x17D3340 VA: 0x1817D4940
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CA710 Offset: 0x17C9110 VA: 0x1817CA710
	|-FixedList32Bytes<byte>.ElementAt
	|
	|-RVA: 0x17CA5B0 Offset: 0x17C8FB0 VA: 0x1817CA5B0
	|-FixedList32Bytes<int>.ElementAt
	|-FixedList32Bytes<float>.ElementAt
	|
	|-RVA: 0x17CA640 Offset: 0x17C9040 VA: 0x1817CA640
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC6D0 Offset: 0x17CB0D0 VA: 0x1817CC6D0
	|-FixedList32Bytes<byte>.GetHashCode
	|
	|-RVA: 0x17CC530 Offset: 0x17CAF30 VA: 0x1817CC530
	|-FixedList32Bytes<int>.GetHashCode
	|-FixedList32Bytes<float>.GetHashCode
	|
	|-RVA: 0x17CC600 Offset: 0x17CB000 VA: 0x1817CC600
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void Add(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9500 Offset: 0x17C7F00 VA: 0x1817C9500
	|-FixedList32Bytes<byte>.Add
	|
	|-RVA: 0x17C92B0 Offset: 0x17C7CB0 VA: 0x1817C92B0
	|-FixedList32Bytes<int>.Add
	|
	|-RVA: 0x17C9210 Offset: 0x17C7C10 VA: 0x1817C9210
	|-FixedList32Bytes<float>.Add
	|
	|-RVA: 0x17C9350 Offset: 0x17C7D50 VA: 0x1817C9350
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8C80 Offset: 0x17C7680 VA: 0x1817C8C80
	|-FixedList32Bytes<byte>.AddRange
	|
	|-RVA: 0x17C90D0 Offset: 0x17C7AD0 VA: 0x1817C90D0
	|-FixedList32Bytes<int>.AddRange
	|
	|-RVA: 0x17C8F90 Offset: 0x17C7990 VA: 0x1817C8F90
	|-FixedList32Bytes<float>.AddRange
	|
	|-RVA: 0x17C8DC0 Offset: 0x17C77C0 VA: 0x1817C8DC0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8A20 Offset: 0x17C7420 VA: 0x1817C8A20
	|-FixedList32Bytes<byte>.AddNoResize
	|
	|-RVA: 0x17C8940 Offset: 0x17C7340 VA: 0x1817C8940
	|-FixedList32Bytes<int>.AddNoResize
	|
	|-RVA: 0x17C8A70 Offset: 0x17C7470 VA: 0x1817C8A70
	|-FixedList32Bytes<float>.AddNoResize
	|
	|-RVA: 0x17C8990 Offset: 0x17C7390 VA: 0x1817C8990
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8BC0 Offset: 0x17C75C0 VA: 0x1817C8BC0
	|-FixedList32Bytes<byte>.AddRangeNoResize
	|
	|-RVA: 0x17C8C20 Offset: 0x17C7620 VA: 0x1817C8C20
	|-FixedList32Bytes<int>.AddRangeNoResize
	|
	|-RVA: 0x17C8B60 Offset: 0x17C7560 VA: 0x1817C8B60
	|-FixedList32Bytes<float>.AddRangeNoResize
	|
	|-RVA: 0x17C8AC0 Offset: 0x17C74C0 VA: 0x1817C8AC0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C95A0 Offset: 0x17C7FA0 VA: 0x1817C95A0
	|-FixedList32Bytes<byte>.Clear
	|-FixedList32Bytes<int>.Clear
	|-FixedList32Bytes<float>.Clear
	|
	|-RVA: 0x17C95D0 Offset: 0x17C7FD0 VA: 0x1817C95D0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE4F0 Offset: 0x17CCEF0 VA: 0x1817CE4F0
	|-FixedList32Bytes<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE870 Offset: 0x17CD270 VA: 0x1817CE870
	|-FixedList32Bytes<int>.InsertRangeWithBeginEnd
	|-FixedList32Bytes<float>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE620 Offset: 0x17CD020 VA: 0x1817CE620
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE9C0 Offset: 0x17CD3C0 VA: 0x1817CE9C0
	|-FixedList32Bytes<byte>.Insert
	|
	|-RVA: 0x17CEA60 Offset: 0x17CD460 VA: 0x1817CEA60
	|-FixedList32Bytes<int>.Insert
	|
	|-RVA: 0x17CEB00 Offset: 0x17CD500 VA: 0x1817CEB00
	|-FixedList32Bytes<float>.Insert
	|
	|-RVA: 0x17CEBB0 Offset: 0x17CD5B0 VA: 0x1817CEBB0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEE00 Offset: 0x17CD800 VA: 0x1817CEE00
	|-FixedList32Bytes<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED20 Offset: 0x17CD720 VA: 0x1817CED20
	|-FixedList32Bytes<int>.RemoveAtSwapBack
	|-FixedList32Bytes<float>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED70 Offset: 0x17CD770 VA: 0x1817CED70
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF0E0 Offset: 0x17CDAE0 VA: 0x1817CF0E0
	|-FixedList32Bytes<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF250 Offset: 0x17CDC50 VA: 0x1817CF250
	|-FixedList32Bytes<int>.RemoveRangeSwapBack
	|-FixedList32Bytes<float>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF3E0 Offset: 0x17CDDE0 VA: 0x1817CF3E0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF020 Offset: 0x17CDA20 VA: 0x1817CF020
	|-FixedList32Bytes<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CF080 Offset: 0x17CDA80 VA: 0x1817CF080
	|-FixedList32Bytes<int>.RemoveRangeSwapBackWithBeginEnd
	|-FixedList32Bytes<float>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CEF80 Offset: 0x17CD980 VA: 0x1817CEF80
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEEE0 Offset: 0x17CD8E0 VA: 0x1817CEEE0
	|-FixedList32Bytes<byte>.RemoveAt
	|
	|-RVA: 0x17CEF30 Offset: 0x17CD930 VA: 0x1817CEF30
	|-FixedList32Bytes<int>.RemoveAt
	|-FixedList32Bytes<float>.RemoveAt
	|
	|-RVA: 0x17CEE50 Offset: 0x17CD850 VA: 0x1817CEE50
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFC10 Offset: 0x17CE610 VA: 0x1817CFC10
	|-FixedList32Bytes<byte>.RemoveRange
	|
	|-RVA: 0x17CFA80 Offset: 0x17CE480 VA: 0x1817CFA80
	|-FixedList32Bytes<int>.RemoveRange
	|-FixedList32Bytes<float>.RemoveRange
	|
	|-RVA: 0x17CF7E0 Offset: 0x17CE1E0 VA: 0x1817CF7E0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF6E0 Offset: 0x17CE0E0 VA: 0x1817CF6E0
	|-FixedList32Bytes<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF680 Offset: 0x17CE080 VA: 0x1817CF680
	|-FixedList32Bytes<int>.RemoveRangeWithBeginEnd
	|-FixedList32Bytes<float>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF740 Offset: 0x17CE140 VA: 0x1817CF740
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFEE0 Offset: 0x17CE8E0 VA: 0x1817CFEE0
	|-FixedList32Bytes<byte>.ToArray
	|
	|-RVA: 0x17CFD80 Offset: 0x17CE780 VA: 0x1817CFD80
	|-FixedList32Bytes<int>.ToArray
	|-FixedList32Bytes<float>.ToArray
	|
	|-RVA: 0x17D0040 Offset: 0x17CEA40 VA: 0x1817D0040
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D01D0 Offset: 0x17CEBD0 VA: 0x1817D01D0
	|-FixedList32Bytes<byte>.ToNativeArray
	|
	|-RVA: 0x17D0350 Offset: 0x17CED50 VA: 0x1817D0350
	|-FixedList32Bytes<int>.ToNativeArray
	|
	|-RVA: 0x17D06D0 Offset: 0x17CF0D0 VA: 0x1817D06D0
	|-FixedList32Bytes<float>.ToNativeArray
	|
	|-RVA: 0x17D04E0 Offset: 0x17CEEE0 VA: 0x1817D04E0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.ToNativeArray
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList32Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D7300 Offset: 0x17D5D00 VA: 0x1817D7300
	|-FixedList32Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D7DA0 Offset: 0x17D67A0 VA: 0x1817D7DA0
	|-FixedList32Bytes<int>.op_Equality
	|-FixedList32Bytes<float>.op_Equality
	|
	|-RVA: 0x17DB450 Offset: 0x17D9E50 VA: 0x1817DB450
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList32Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D8B40 Offset: 0x17D7540 VA: 0x1817D8B40
	|-FixedList32Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D89B0 Offset: 0x17D73B0 VA: 0x1817D89B0
	|-FixedList32Bytes<int>.op_Inequality
	|-FixedList32Bytes<float>.op_Inequality
	|
	|-RVA: 0x17DC370 Offset: 0x17DAD70 VA: 0x1817DC370
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int CompareTo(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList32Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList32Bytes<int>.CompareTo
	|-FixedList32Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA090 Offset: 0x17C8A90 VA: 0x1817CA090
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Equals(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4D30 Offset: 0x17D3730 VA: 0x1817D4D30
	|-FixedList32Bytes<byte>.Equals
	|
	|-RVA: 0x17D4CC0 Offset: 0x17D36C0 VA: 0x1817D4CC0
	|-FixedList32Bytes<int>.Equals
	|-FixedList32Bytes<float>.Equals
	|
	|-RVA: 0x17D92B0 Offset: 0x17D7CB0 VA: 0x1817D92B0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList32Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D7F40 Offset: 0x17D6940 VA: 0x1817D7F40
	|-FixedList32Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D7490 Offset: 0x17D5E90 VA: 0x1817D7490
	|-FixedList32Bytes<int>.op_Equality
	|-FixedList32Bytes<float>.op_Equality
	|
	|-RVA: 0x17DB0A0 Offset: 0x17D9AA0 VA: 0x1817DB0A0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList32Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D87F0 Offset: 0x17D71F0 VA: 0x1817D87F0
	|-FixedList32Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D8A50 Offset: 0x17D7450 VA: 0x1817D8A50
	|-FixedList32Bytes<int>.op_Inequality
	|-FixedList32Bytes<float>.op_Inequality
	|
	|-RVA: 0x17DC2E0 Offset: 0x17DACE0 VA: 0x1817DC2E0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public int CompareTo(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList32Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList32Bytes<int>.CompareTo
	|-FixedList32Bytes<float>.CompareTo
	|
	|-RVA: 0x17D9020 Offset: 0x17D7A20 VA: 0x1817D9020
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Equals(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D5AF0 Offset: 0x17D44F0 VA: 0x1817D5AF0
	|-FixedList32Bytes<byte>.Equals
	|
	|-RVA: 0x17D5460 Offset: 0x17D3E60 VA: 0x1817D5460
	|-FixedList32Bytes<int>.Equals
	|-FixedList32Bytes<float>.Equals
	|
	|-RVA: 0x17D9A70 Offset: 0x17D8470 VA: 0x1817D9A70
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D6ED0 Offset: 0x17D58D0 VA: 0x1817D6ED0
	|-FixedList32Bytes<byte>..ctor
	|
	|-RVA: 0x17D7050 Offset: 0x17D5A50 VA: 0x1817D7050
	|-FixedList32Bytes<int>..ctor
	|-FixedList32Bytes<float>..ctor
	|
	|-RVA: 0x17DB010 Offset: 0x17D9A10 VA: 0x1817DB010
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D6620 Offset: 0x17D5020 VA: 0x1817D6620
	|-FixedList32Bytes<byte>.Initialize
	|
	|-RVA: 0x17D6A10 Offset: 0x17D5410 VA: 0x1817D6A10
	|-FixedList32Bytes<int>.Initialize
	|-FixedList32Bytes<float>.Initialize
	|
	|-RVA: 0x17DAAF0 Offset: 0x17D94F0 VA: 0x1817DAAF0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList32Bytes<T> op_Implicit(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D8510 Offset: 0x17D6F10 VA: 0x1817D8510
	|-FixedList32Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D8630 Offset: 0x17D7030 VA: 0x1817D8630
	|-FixedList32Bytes<int>.op_Implicit
	|-FixedList32Bytes<float>.op_Implicit
	|
	|-RVA: 0x17DBFD0 Offset: 0x17DA9D0 VA: 0x1817DBFD0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList32Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D7BA0 Offset: 0x17D65A0 VA: 0x1817D7BA0
	|-FixedList32Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D77C0 Offset: 0x17D61C0 VA: 0x1817D77C0
	|-FixedList32Bytes<int>.op_Equality
	|
	|-RVA: 0x17DB990 Offset: 0x17DA390 VA: 0x1817DB990
	|-FixedList32Bytes<float>.op_Equality
	|
	|-RVA: 0x17DBB70 Offset: 0x17DA570 VA: 0x1817DBB70
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList32Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D8AF0 Offset: 0x17D74F0 VA: 0x1817D8AF0
	|-FixedList32Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D8A00 Offset: 0x17D7400 VA: 0x1817D8A00
	|-FixedList32Bytes<int>.op_Inequality
	|
	|-RVA: 0x17DC290 Offset: 0x17DAC90 VA: 0x1817DC290
	|-FixedList32Bytes<float>.op_Inequality
	|
	|-RVA: 0x17DC400 Offset: 0x17DAE00 VA: 0x1817DC400
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int CompareTo(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList32Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList32Bytes<int>.CompareTo
	|-FixedList32Bytes<float>.CompareTo
	|
	|-RVA: 0x17D8D90 Offset: 0x17D7790 VA: 0x1817D8D90
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Equals(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D5B70 Offset: 0x17D4570 VA: 0x1817D5B70
	|-FixedList32Bytes<byte>.Equals
	|
	|-RVA: 0x17D4DA0 Offset: 0x17D37A0 VA: 0x1817D4DA0
	|-FixedList32Bytes<int>.Equals
	|-FixedList32Bytes<float>.Equals
	|
	|-RVA: 0x17D9B20 Offset: 0x17D8520 VA: 0x1817D9B20
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D70B0 Offset: 0x17D5AB0 VA: 0x1817D70B0
	|-FixedList32Bytes<byte>..ctor
	|
	|-RVA: 0x17D6FF0 Offset: 0x17D59F0 VA: 0x1817D6FF0
	|-FixedList32Bytes<int>..ctor
	|
	|-RVA: 0x17DAFB0 Offset: 0x17D99B0 VA: 0x1817DAFB0
	|-FixedList32Bytes<float>..ctor
	|
	|-RVA: 0x17DAD40 Offset: 0x17D9740 VA: 0x1817DAD40
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D5EF0 Offset: 0x17D48F0 VA: 0x1817D5EF0
	|-FixedList32Bytes<byte>.Initialize
	|
	|-RVA: 0x17D6150 Offset: 0x17D4B50 VA: 0x1817D6150
	|-FixedList32Bytes<int>.Initialize
	|
	|-RVA: 0x17D9C00 Offset: 0x17D8600 VA: 0x1817D9C00
	|-FixedList32Bytes<float>.Initialize
	|
	|-RVA: 0x17D9E40 Offset: 0x17D8840 VA: 0x1817D9E40
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList32Bytes<T> op_Implicit(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D8480 Offset: 0x17D6E80 VA: 0x1817D8480
	|-FixedList32Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D86C0 Offset: 0x17D70C0 VA: 0x1817D86C0
	|-FixedList32Bytes<int>.op_Implicit
	|
	|-RVA: 0x17DC030 Offset: 0x17DAA30 VA: 0x1817DC030
	|-FixedList32Bytes<float>.op_Implicit
	|
	|-RVA: 0x17DC1E0 Offset: 0x17DABE0 VA: 0x1817DC1E0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList32Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D79C0 Offset: 0x17D63C0 VA: 0x1817D79C0
	|-FixedList32Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D80E0 Offset: 0x17D6AE0 VA: 0x1817D80E0
	|-FixedList32Bytes<int>.op_Equality
	|
	|-RVA: 0x17DB780 Offset: 0x17DA180 VA: 0x1817DB780
	|-FixedList32Bytes<float>.op_Equality
	|
	|-RVA: 0x17DB250 Offset: 0x17D9C50 VA: 0x1817DB250
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList32Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D8B90 Offset: 0x17D7590 VA: 0x1817D8B90
	|-FixedList32Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D8750 Offset: 0x17D7150 VA: 0x1817D8750
	|-FixedList32Bytes<int>.op_Inequality
	|
	|-RVA: 0x17DC490 Offset: 0x17DAE90 VA: 0x1817DC490
	|-FixedList32Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D3F10 Offset: 0x17D2910 VA: 0x1817D3F10
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public int CompareTo(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList32Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList32Bytes<int>.CompareTo
	|-FixedList32Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9E00 Offset: 0x17C8800 VA: 0x1817C9E00
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Equals(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC260 Offset: 0x17CAC60 VA: 0x1817CC260
	|-FixedList32Bytes<byte>.Equals
	|
	|-RVA: 0x17CBEA0 Offset: 0x17CA8A0 VA: 0x1817CBEA0
	|-FixedList32Bytes<int>.Equals
	|-FixedList32Bytes<float>.Equals
	|
	|-RVA: 0x17CC320 Offset: 0x17CAD20 VA: 0x1817CC320
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D6F90 Offset: 0x17D5990 VA: 0x1817D6F90
	|-FixedList32Bytes<byte>..ctor
	|
	|-RVA: 0x17D6E70 Offset: 0x17D5870 VA: 0x1817D6E70
	|-FixedList32Bytes<int>..ctor
	|
	|-RVA: 0x17DADD0 Offset: 0x17D97D0 VA: 0x1817DADD0
	|-FixedList32Bytes<float>..ctor
	|
	|-RVA: 0x17DAE30 Offset: 0x17D9830 VA: 0x1817DAE30
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D5C80 Offset: 0x17D4680 VA: 0x1817D5C80
	|-FixedList32Bytes<byte>.Initialize
	|
	|-RVA: 0x17D63B0 Offset: 0x17D4DB0 VA: 0x1817D63B0
	|-FixedList32Bytes<int>.Initialize
	|
	|-RVA: 0x17DA3C0 Offset: 0x17D8DC0 VA: 0x1817DA3C0
	|-FixedList32Bytes<float>.Initialize
	|
	|-RVA: 0x17DA0E0 Offset: 0x17D8AE0 VA: 0x1817DA0E0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList32Bytes<T> op_Implicit(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D83F0 Offset: 0x17D6DF0 VA: 0x1817D83F0
	|-FixedList32Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D82D0 Offset: 0x17D6CD0 VA: 0x1817D82D0
	|-FixedList32Bytes<int>.op_Implicit
	|
	|-RVA: 0x17DC0C0 Offset: 0x17DAAC0 VA: 0x1817DC0C0
	|-FixedList32Bytes<float>.op_Implicit
	|
	|-RVA: 0x17DBF70 Offset: 0x17DA970 VA: 0x1817DBF70
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList32Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D7630 Offset: 0x17D6030 VA: 0x1817D7630
	|-FixedList32Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D7170 Offset: 0x17D5B70 VA: 0x1817D7170
	|-FixedList32Bytes<int>.op_Equality
	|
	|-RVA: 0x17DB5D0 Offset: 0x17D9FD0 VA: 0x1817DB5D0
	|-FixedList32Bytes<float>.op_Equality
	|
	|-RVA: 0x17DBD60 Offset: 0x17DA760 VA: 0x1817DBD60
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList32Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D8AA0 Offset: 0x17D74A0 VA: 0x1817D8AA0
	|-FixedList32Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D87A0 Offset: 0x17D71A0 VA: 0x1817D87A0
	|-FixedList32Bytes<int>.op_Inequality
	|
	|-RVA: 0x17DC240 Offset: 0x17DAC40 VA: 0x1817DC240
	|-FixedList32Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D4440 Offset: 0x17D2E40 VA: 0x1817D4440
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int CompareTo(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList32Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList32Bytes<int>.CompareTo
	|-FixedList32Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9650 Offset: 0x17C8050 VA: 0x1817C9650
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Equals(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC420 Offset: 0x17CAE20 VA: 0x1817CC420
	|-FixedList32Bytes<byte>.Equals
	|
	|-RVA: 0x17CB020 Offset: 0x17C9A20 VA: 0x1817CB020
	|-FixedList32Bytes<int>.Equals
	|-FixedList32Bytes<float>.Equals
	|
	|-RVA: 0x17CB0B0 Offset: 0x17C9AB0 VA: 0x1817CB0B0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D6F30 Offset: 0x17D5930 VA: 0x1817D6F30
	|-FixedList32Bytes<byte>..ctor
	|
	|-RVA: 0x17D6E10 Offset: 0x17D5810 VA: 0x1817D6E10
	|-FixedList32Bytes<int>..ctor
	|
	|-RVA: 0x17DAF50 Offset: 0x17D9950 VA: 0x1817DAF50
	|-FixedList32Bytes<float>..ctor
	|
	|-RVA: 0x17DAEC0 Offset: 0x17D98C0 VA: 0x1817DAEC0
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D6C00 Offset: 0x17D5600 VA: 0x1817D6C00
	|-FixedList32Bytes<byte>.Initialize
	|
	|-RVA: 0x17D6800 Offset: 0x17D5200 VA: 0x1817D6800
	|-FixedList32Bytes<int>.Initialize
	|
	|-RVA: 0x17DA8C0 Offset: 0x17D92C0 VA: 0x1817DA8C0
	|-FixedList32Bytes<float>.Initialize
	|
	|-RVA: 0x17DA650 Offset: 0x17D9050 VA: 0x1817DA650
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList32Bytes<T> op_Implicit(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D85A0 Offset: 0x17D6FA0 VA: 0x1817D85A0
	|-FixedList32Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D8360 Offset: 0x17D6D60 VA: 0x1817D8360
	|-FixedList32Bytes<int>.op_Implicit
	|
	|-RVA: 0x17DC150 Offset: 0x17DAB50 VA: 0x1817DC150
	|-FixedList32Bytes<float>.op_Implicit
	|
	|-RVA: 0x17DBF10 Offset: 0x17DA910 VA: 0x1817DBF10
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4E50 Offset: 0x17D3850 VA: 0x1817D4E50
	|-FixedList32Bytes<byte>.Equals
	|
	|-RVA: 0x17D54E0 Offset: 0x17D3EE0 VA: 0x1817D54E0
	|-FixedList32Bytes<int>.Equals
	|-FixedList32Bytes<float>.Equals
	|
	|-RVA: 0x17D9350 Offset: 0x17D7D50 VA: 0x1817D9350
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public FixedList32Bytes.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D5C20 Offset: 0x17D4620 VA: 0x1817D5C20
	|-FixedList32Bytes<byte>.GetEnumerator
	|-FixedList32Bytes<int>.GetEnumerator
	|-FixedList32Bytes<float>.GetEnumerator
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList32Bytes<byte>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList32Bytes<int>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList32Bytes<float>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList32Bytes<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList32Bytes<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList32Bytes<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList32Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}
