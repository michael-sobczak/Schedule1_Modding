public struct FixedList128Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 15771
{
	// Fields
	[SerializeField]
	internal ushort length; // 0x0
	[SerializeField]
	internal FixedBytes126 buffer; // 0x0

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
	|-FixedList128Bytes<byte>.get_Length
	|-FixedList128Bytes<int>.get_Length
	|-FixedList128Bytes<float>.get_Length
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	|-FixedList128Bytes<byte>.set_Length
	|-FixedList128Bytes<int>.set_Length
	|-FixedList128Bytes<float>.set_Length
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> get_Elements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1180 Offset: 0x17CFB80 VA: 0x1817D1180
	|-FixedList128Bytes<byte>.get_Elements
	|
	|-RVA: 0x17D10D0 Offset: 0x17CFAD0 VA: 0x1817D10D0
	|-FixedList128Bytes<int>.get_Elements
	|-FixedList128Bytes<float>.get_Elements
	|
	|-RVA: 0x17D1110 Offset: 0x17CFB10 VA: 0x1817D1110
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_Elements
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D11C0 Offset: 0x17CFBC0 VA: 0x1817D11C0
	|-FixedList128Bytes<byte>.get_IsEmpty
	|-FixedList128Bytes<int>.get_IsEmpty
	|-FixedList128Bytes<float>.get_IsEmpty
	|
	|-RVA: 0x17D11F0 Offset: 0x17CFBF0 VA: 0x1817D11F0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal int get_LengthInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D15C0 Offset: 0x17CFFC0 VA: 0x1817D15C0
	|-FixedList128Bytes<byte>.get_LengthInBytes
	|
	|-RVA: 0x17D16D0 Offset: 0x17D00D0 VA: 0x1817D16D0
	|-FixedList128Bytes<int>.get_LengthInBytes
	|-FixedList128Bytes<float>.get_LengthInBytes
	|
	|-RVA: 0x17D1610 Offset: 0x17D0010 VA: 0x1817D1610
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_LengthInBytes
	*/

	// RVA: -1 Offset: -1
	internal byte* get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0F50 Offset: 0x17CF950 VA: 0x1817D0F50
	|-FixedList128Bytes<byte>.get_Buffer
	|
	|-RVA: 0x17D0F10 Offset: 0x17CF910 VA: 0x1817D0F10
	|-FixedList128Bytes<int>.get_Buffer
	|-FixedList128Bytes<float>.get_Buffer
	|
	|-RVA: 0x17D0F90 Offset: 0x17CF990 VA: 0x1817D0F90
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_Buffer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1010 Offset: 0x17CFA10 VA: 0x1817D1010
	|-FixedList128Bytes<byte>.get_Capacity
	|
	|-RVA: 0x17D1040 Offset: 0x17CFA40 VA: 0x1817D1040
	|-FixedList128Bytes<int>.get_Capacity
	|-FixedList128Bytes<float>.get_Capacity
	|
	|-RVA: 0x17D1070 Offset: 0x17CFA70 VA: 0x1817D1070
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FixedList128Bytes<byte>.set_Capacity
	|-FixedList128Bytes<int>.set_Capacity
	|-FixedList128Bytes<float>.set_Capacity
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1480 Offset: 0x17CFE80 VA: 0x1817D1480
	|-FixedList128Bytes<byte>.get_Item
	|
	|-RVA: 0x17D1520 Offset: 0x17CFF20 VA: 0x1817D1520
	|-FixedList128Bytes<int>.get_Item
	|
	|-RVA: 0x17D13E0 Offset: 0x17CFDE0 VA: 0x1817D13E0
	|-FixedList128Bytes<float>.get_Item
	|
	|-RVA: 0x17D1270 Offset: 0x17CFC70 VA: 0x1817D1270
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4AB0 Offset: 0x17D34B0 VA: 0x1817D4AB0
	|-FixedList128Bytes<byte>.set_Item
	|
	|-RVA: 0x17D4C10 Offset: 0x17D3610 VA: 0x1817D4C10
	|-FixedList128Bytes<int>.set_Item
	|
	|-RVA: 0x17D4B60 Offset: 0x17D3560 VA: 0x1817D4B60
	|-FixedList128Bytes<float>.set_Item
	|
	|-RVA: 0x17D4940 Offset: 0x17D3340 VA: 0x1817D4940
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CA710 Offset: 0x17C9110 VA: 0x1817CA710
	|-FixedList128Bytes<byte>.ElementAt
	|
	|-RVA: 0x17CA5B0 Offset: 0x17C8FB0 VA: 0x1817CA5B0
	|-FixedList128Bytes<int>.ElementAt
	|-FixedList128Bytes<float>.ElementAt
	|
	|-RVA: 0x17CA640 Offset: 0x17C9040 VA: 0x1817CA640
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC6D0 Offset: 0x17CB0D0 VA: 0x1817CC6D0
	|-FixedList128Bytes<byte>.GetHashCode
	|
	|-RVA: 0x17CC530 Offset: 0x17CAF30 VA: 0x1817CC530
	|-FixedList128Bytes<int>.GetHashCode
	|-FixedList128Bytes<float>.GetHashCode
	|
	|-RVA: 0x17CC600 Offset: 0x17CB000 VA: 0x1817CC600
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void Add(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9500 Offset: 0x17C7F00 VA: 0x1817C9500
	|-FixedList128Bytes<byte>.Add
	|
	|-RVA: 0x17C92B0 Offset: 0x17C7CB0 VA: 0x1817C92B0
	|-FixedList128Bytes<int>.Add
	|
	|-RVA: 0x17C9210 Offset: 0x17C7C10 VA: 0x1817C9210
	|-FixedList128Bytes<float>.Add
	|
	|-RVA: 0x17C9350 Offset: 0x17C7D50 VA: 0x1817C9350
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8C80 Offset: 0x17C7680 VA: 0x1817C8C80
	|-FixedList128Bytes<byte>.AddRange
	|
	|-RVA: 0x17C90D0 Offset: 0x17C7AD0 VA: 0x1817C90D0
	|-FixedList128Bytes<int>.AddRange
	|
	|-RVA: 0x17C8F90 Offset: 0x17C7990 VA: 0x1817C8F90
	|-FixedList128Bytes<float>.AddRange
	|
	|-RVA: 0x17C8DC0 Offset: 0x17C77C0 VA: 0x1817C8DC0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8A20 Offset: 0x17C7420 VA: 0x1817C8A20
	|-FixedList128Bytes<byte>.AddNoResize
	|
	|-RVA: 0x17C8940 Offset: 0x17C7340 VA: 0x1817C8940
	|-FixedList128Bytes<int>.AddNoResize
	|
	|-RVA: 0x17C8A70 Offset: 0x17C7470 VA: 0x1817C8A70
	|-FixedList128Bytes<float>.AddNoResize
	|
	|-RVA: 0x17C8990 Offset: 0x17C7390 VA: 0x1817C8990
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8BC0 Offset: 0x17C75C0 VA: 0x1817C8BC0
	|-FixedList128Bytes<byte>.AddRangeNoResize
	|
	|-RVA: 0x17C8C20 Offset: 0x17C7620 VA: 0x1817C8C20
	|-FixedList128Bytes<int>.AddRangeNoResize
	|
	|-RVA: 0x17C8B60 Offset: 0x17C7560 VA: 0x1817C8B60
	|-FixedList128Bytes<float>.AddRangeNoResize
	|
	|-RVA: 0x17C8AC0 Offset: 0x17C74C0 VA: 0x1817C8AC0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C95A0 Offset: 0x17C7FA0 VA: 0x1817C95A0
	|-FixedList128Bytes<byte>.Clear
	|-FixedList128Bytes<int>.Clear
	|-FixedList128Bytes<float>.Clear
	|
	|-RVA: 0x17C95D0 Offset: 0x17C7FD0 VA: 0x1817C95D0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE4F0 Offset: 0x17CCEF0 VA: 0x1817CE4F0
	|-FixedList128Bytes<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE870 Offset: 0x17CD270 VA: 0x1817CE870
	|-FixedList128Bytes<int>.InsertRangeWithBeginEnd
	|-FixedList128Bytes<float>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE620 Offset: 0x17CD020 VA: 0x1817CE620
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE9C0 Offset: 0x17CD3C0 VA: 0x1817CE9C0
	|-FixedList128Bytes<byte>.Insert
	|
	|-RVA: 0x17CEA60 Offset: 0x17CD460 VA: 0x1817CEA60
	|-FixedList128Bytes<int>.Insert
	|
	|-RVA: 0x17CEB00 Offset: 0x17CD500 VA: 0x1817CEB00
	|-FixedList128Bytes<float>.Insert
	|
	|-RVA: 0x17CEBB0 Offset: 0x17CD5B0 VA: 0x1817CEBB0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEE00 Offset: 0x17CD800 VA: 0x1817CEE00
	|-FixedList128Bytes<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED20 Offset: 0x17CD720 VA: 0x1817CED20
	|-FixedList128Bytes<int>.RemoveAtSwapBack
	|-FixedList128Bytes<float>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED70 Offset: 0x17CD770 VA: 0x1817CED70
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF0E0 Offset: 0x17CDAE0 VA: 0x1817CF0E0
	|-FixedList128Bytes<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF250 Offset: 0x17CDC50 VA: 0x1817CF250
	|-FixedList128Bytes<int>.RemoveRangeSwapBack
	|-FixedList128Bytes<float>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF3E0 Offset: 0x17CDDE0 VA: 0x1817CF3E0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF020 Offset: 0x17CDA20 VA: 0x1817CF020
	|-FixedList128Bytes<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CF080 Offset: 0x17CDA80 VA: 0x1817CF080
	|-FixedList128Bytes<int>.RemoveRangeSwapBackWithBeginEnd
	|-FixedList128Bytes<float>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CEF80 Offset: 0x17CD980 VA: 0x1817CEF80
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEEE0 Offset: 0x17CD8E0 VA: 0x1817CEEE0
	|-FixedList128Bytes<byte>.RemoveAt
	|
	|-RVA: 0x17CEF30 Offset: 0x17CD930 VA: 0x1817CEF30
	|-FixedList128Bytes<int>.RemoveAt
	|-FixedList128Bytes<float>.RemoveAt
	|
	|-RVA: 0x17CEE50 Offset: 0x17CD850 VA: 0x1817CEE50
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFC10 Offset: 0x17CE610 VA: 0x1817CFC10
	|-FixedList128Bytes<byte>.RemoveRange
	|
	|-RVA: 0x17CFA80 Offset: 0x17CE480 VA: 0x1817CFA80
	|-FixedList128Bytes<int>.RemoveRange
	|-FixedList128Bytes<float>.RemoveRange
	|
	|-RVA: 0x17CF7E0 Offset: 0x17CE1E0 VA: 0x1817CF7E0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF6E0 Offset: 0x17CE0E0 VA: 0x1817CF6E0
	|-FixedList128Bytes<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF680 Offset: 0x17CE080 VA: 0x1817CF680
	|-FixedList128Bytes<int>.RemoveRangeWithBeginEnd
	|-FixedList128Bytes<float>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF740 Offset: 0x17CE140 VA: 0x1817CF740
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFEE0 Offset: 0x17CE8E0 VA: 0x1817CFEE0
	|-FixedList128Bytes<byte>.ToArray
	|
	|-RVA: 0x17CFD80 Offset: 0x17CE780 VA: 0x1817CFD80
	|-FixedList128Bytes<int>.ToArray
	|-FixedList128Bytes<float>.ToArray
	|
	|-RVA: 0x17D0040 Offset: 0x17CEA40 VA: 0x1817D0040
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D01D0 Offset: 0x17CEBD0 VA: 0x1817D01D0
	|-FixedList128Bytes<byte>.ToNativeArray
	|
	|-RVA: 0x17D0350 Offset: 0x17CED50 VA: 0x1817D0350
	|-FixedList128Bytes<int>.ToNativeArray
	|
	|-RVA: 0x17D06D0 Offset: 0x17CF0D0 VA: 0x1817D06D0
	|-FixedList128Bytes<float>.ToNativeArray
	|
	|-RVA: 0x17D04E0 Offset: 0x17CEEE0 VA: 0x1817D04E0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.ToNativeArray
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList128Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1720 Offset: 0x17D0120 VA: 0x1817D1720
	|-FixedList128Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D30A0 Offset: 0x17D1AA0 VA: 0x1817D30A0
	|-FixedList128Bytes<int>.op_Equality
	|
	|-RVA: 0x17D1940 Offset: 0x17D0340 VA: 0x1817D1940
	|-FixedList128Bytes<float>.op_Equality
	|
	|-RVA: 0x17D1F80 Offset: 0x17D0980 VA: 0x1817D1F80
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList128Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4570 Offset: 0x17D2F70 VA: 0x1817D4570
	|-FixedList128Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D46E0 Offset: 0x17D30E0 VA: 0x1817D46E0
	|-FixedList128Bytes<int>.op_Inequality
	|
	|-RVA: 0x17D4520 Offset: 0x17D2F20 VA: 0x1817D4520
	|-FixedList128Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D45C0 Offset: 0x17D2FC0 VA: 0x1817D45C0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int CompareTo(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList128Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList128Bytes<int>.CompareTo
	|-FixedList128Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9A30 Offset: 0x17C8430 VA: 0x1817C9A30
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Equals(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC1F0 Offset: 0x17CABF0 VA: 0x1817CC1F0
	|-FixedList128Bytes<byte>.Equals
	|
	|-RVA: 0x17CAED0 Offset: 0x17C98D0 VA: 0x1817CAED0
	|-FixedList128Bytes<int>.Equals
	|-FixedList128Bytes<float>.Equals
	|
	|-RVA: 0x17CAE30 Offset: 0x17C9830 VA: 0x1817CAE30
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0B10 Offset: 0x17CF510 VA: 0x1817D0B10
	|-FixedList128Bytes<byte>..ctor
	|
	|-RVA: 0x17D09F0 Offset: 0x17CF3F0 VA: 0x1817D09F0
	|-FixedList128Bytes<int>..ctor
	|
	|-RVA: 0x17D0CA0 Offset: 0x17CF6A0 VA: 0x1817D0CA0
	|-FixedList128Bytes<float>..ctor
	|
	|-RVA: 0x17D0B80 Offset: 0x17CF580 VA: 0x1817D0B80
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CD730 Offset: 0x17CC130 VA: 0x1817CD730
	|-FixedList128Bytes<byte>.Initialize
	|
	|-RVA: 0x17CC9A0 Offset: 0x17CB3A0 VA: 0x1817CC9A0
	|-FixedList128Bytes<int>.Initialize
	|
	|-RVA: 0x17CD920 Offset: 0x17CC320 VA: 0x1817CD920
	|-FixedList128Bytes<float>.Initialize
	|
	|-RVA: 0x17CD2C0 Offset: 0x17CBCC0 VA: 0x1817CD2C0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList128Bytes<T> op_Implicit(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D3A40 Offset: 0x17D2440 VA: 0x1817D3A40
	|-FixedList128Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D3960 Offset: 0x17D2360 VA: 0x1817D3960
	|-FixedList128Bytes<int>.op_Implicit
	|
	|-RVA: 0x17D3EA0 Offset: 0x17D28A0 VA: 0x1817D3EA0
	|-FixedList128Bytes<float>.op_Implicit
	|
	|-RVA: 0x17D3DC0 Offset: 0x17D27C0 VA: 0x1817D3DC0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList128Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D2EB0 Offset: 0x17D18B0 VA: 0x1817D2EB0
	|-FixedList128Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D32C0 Offset: 0x17D1CC0 VA: 0x1817D32C0
	|-FixedList128Bytes<int>.op_Equality
	|-FixedList128Bytes<float>.op_Equality
	|
	|-RVA: 0x17D2CA0 Offset: 0x17D16A0 VA: 0x1817D2CA0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList128Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4730 Offset: 0x17D3130 VA: 0x1817D4730
	|-FixedList128Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D43F0 Offset: 0x17D2DF0 VA: 0x1817D43F0
	|-FixedList128Bytes<int>.op_Inequality
	|-FixedList128Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D3FF0 Offset: 0x17D29F0 VA: 0x1817D3FF0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public int CompareTo(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList128Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList128Bytes<int>.CompareTo
	|-FixedList128Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA320 Offset: 0x17C8D20 VA: 0x1817CA320
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Equals(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC010 Offset: 0x17CAA10 VA: 0x1817CC010
	|-FixedList128Bytes<byte>.Equals
	|
	|-RVA: 0x17CADB0 Offset: 0x17C97B0 VA: 0x1817CADB0
	|-FixedList128Bytes<int>.Equals
	|-FixedList128Bytes<float>.Equals
	|
	|-RVA: 0x17CBF60 Offset: 0x17CA960 VA: 0x1817CBF60
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0980 Offset: 0x17CF380 VA: 0x1817D0980
	|-FixedList128Bytes<byte>..ctor
	|
	|-RVA: 0x17D0EA0 Offset: 0x17CF8A0 VA: 0x1817D0EA0
	|-FixedList128Bytes<int>..ctor
	|-FixedList128Bytes<float>..ctor
	|
	|-RVA: 0x17D0A60 Offset: 0x17CF460 VA: 0x1817D0A60
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CDAF0 Offset: 0x17CC4F0 VA: 0x1817CDAF0
	|-FixedList128Bytes<byte>.Initialize
	|
	|-RVA: 0x17CC7A0 Offset: 0x17CB1A0 VA: 0x1817CC7A0
	|-FixedList128Bytes<int>.Initialize
	|-FixedList128Bytes<float>.Initialize
	|
	|-RVA: 0x17CCDD0 Offset: 0x17CB7D0 VA: 0x1817CCDD0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList128Bytes<T> op_Implicit(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D3E30 Offset: 0x17D2830 VA: 0x1817D3E30
	|-FixedList128Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D3C70 Offset: 0x17D2670 VA: 0x1817D3C70
	|-FixedList128Bytes<int>.op_Implicit
	|-FixedList128Bytes<float>.op_Implicit
	|
	|-RVA: 0x17D3C00 Offset: 0x17D2600 VA: 0x1817D3C00
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList128Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D2A80 Offset: 0x17D1480 VA: 0x1817D2A80
	|-FixedList128Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D1D60 Offset: 0x17D0760 VA: 0x1817D1D60
	|-FixedList128Bytes<int>.op_Equality
	|-FixedList128Bytes<float>.op_Equality
	|
	|-RVA: 0x17D23B0 Offset: 0x17D0DB0 VA: 0x1817D23B0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList128Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4120 Offset: 0x17D2B20 VA: 0x1817D4120
	|-FixedList128Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D40D0 Offset: 0x17D2AD0 VA: 0x1817D40D0
	|-FixedList128Bytes<int>.op_Inequality
	|-FixedList128Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D4650 Offset: 0x17D3050 VA: 0x1817D4650
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int CompareTo(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList128Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList128Bytes<int>.CompareTo
	|-FixedList128Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA090 Offset: 0x17C8A90 VA: 0x1817CA090
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Equals(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC140 Offset: 0x17CAB40 VA: 0x1817CC140
	|-FixedList128Bytes<byte>.Equals
	|
	|-RVA: 0x17CC090 Offset: 0x17CAA90 VA: 0x1817CC090
	|-FixedList128Bytes<int>.Equals
	|-FixedList128Bytes<float>.Equals
	|
	|-RVA: 0x17CAF40 Offset: 0x17C9940 VA: 0x1817CAF40
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList128Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D25C0 Offset: 0x17D0FC0 VA: 0x1817D25C0
	|-FixedList128Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D2820 Offset: 0x17D1220 VA: 0x1817D2820
	|-FixedList128Bytes<int>.op_Equality
	|-FixedList128Bytes<float>.op_Equality
	|
	|-RVA: 0x17D36E0 Offset: 0x17D20E0 VA: 0x1817D36E0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList128Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4170 Offset: 0x17D2B70 VA: 0x1817D4170
	|-FixedList128Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D4080 Offset: 0x17D2A80 VA: 0x1817D4080
	|-FixedList128Bytes<int>.op_Inequality
	|-FixedList128Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D3F10 Offset: 0x17D2910 VA: 0x1817D3F10
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public int CompareTo(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList128Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList128Bytes<int>.CompareTo
	|-FixedList128Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9E00 Offset: 0x17C8800 VA: 0x1817C9E00
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Equals(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC260 Offset: 0x17CAC60 VA: 0x1817CC260
	|-FixedList128Bytes<byte>.Equals
	|
	|-RVA: 0x17CBEA0 Offset: 0x17CA8A0 VA: 0x1817CBEA0
	|-FixedList128Bytes<int>.Equals
	|-FixedList128Bytes<float>.Equals
	|
	|-RVA: 0x17CC320 Offset: 0x17CAD20 VA: 0x1817CC320
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0E30 Offset: 0x17CF830 VA: 0x1817D0E30
	|-FixedList128Bytes<byte>..ctor
	|
	|-RVA: 0x17D0C30 Offset: 0x17CF630 VA: 0x1817D0C30
	|-FixedList128Bytes<int>..ctor
	|-FixedList128Bytes<float>..ctor
	|
	|-RVA: 0x17D0860 Offset: 0x17CF260 VA: 0x1817D0860
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CDF70 Offset: 0x17CC970 VA: 0x1817CDF70
	|-FixedList128Bytes<byte>.Initialize
	|
	|-RVA: 0x17CD030 Offset: 0x17CBA30 VA: 0x1817CD030
	|-FixedList128Bytes<int>.Initialize
	|-FixedList128Bytes<float>.Initialize
	|
	|-RVA: 0x17CE200 Offset: 0x17CCC00 VA: 0x1817CE200
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList128Bytes<T> op_Implicit(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D3B90 Offset: 0x17D2590 VA: 0x1817D3B90
	|-FixedList128Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D39D0 Offset: 0x17D23D0 VA: 0x1817D39D0
	|-FixedList128Bytes<int>.op_Implicit
	|-FixedList128Bytes<float>.op_Implicit
	|
	|-RVA: 0x17D3AB0 Offset: 0x17D24B0 VA: 0x1817D3AB0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList128Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1B40 Offset: 0x17D0540 VA: 0x1817D1B40
	|-FixedList128Bytes<byte>.op_Equality
	|
	|-RVA: 0x17D2190 Offset: 0x17D0B90 VA: 0x1817D2190
	|-FixedList128Bytes<int>.op_Equality
	|-FixedList128Bytes<float>.op_Equality
	|
	|-RVA: 0x17D34B0 Offset: 0x17D1EB0 VA: 0x1817D34B0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList128Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D44D0 Offset: 0x17D2ED0 VA: 0x1817D44D0
	|-FixedList128Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17D3FA0 Offset: 0x17D29A0 VA: 0x1817D3FA0
	|-FixedList128Bytes<int>.op_Inequality
	|-FixedList128Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D4440 Offset: 0x17D2E40 VA: 0x1817D4440
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int CompareTo(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList128Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList128Bytes<int>.CompareTo
	|-FixedList128Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9650 Offset: 0x17C8050 VA: 0x1817C9650
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Equals(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC420 Offset: 0x17CAE20 VA: 0x1817CC420
	|-FixedList128Bytes<byte>.Equals
	|
	|-RVA: 0x17CB020 Offset: 0x17C9A20 VA: 0x1817CB020
	|-FixedList128Bytes<int>.Equals
	|-FixedList128Bytes<float>.Equals
	|
	|-RVA: 0x17CB0B0 Offset: 0x17C9AB0 VA: 0x1817CB0B0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0D10 Offset: 0x17CF710 VA: 0x1817D0D10
	|-FixedList128Bytes<byte>..ctor
	|
	|-RVA: 0x17D0910 Offset: 0x17CF310 VA: 0x1817D0910
	|-FixedList128Bytes<int>..ctor
	|-FixedList128Bytes<float>..ctor
	|
	|-RVA: 0x17D0D80 Offset: 0x17CF780 VA: 0x1817D0D80
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CCBA0 Offset: 0x17CB5A0 VA: 0x1817CCBA0
	|-FixedList128Bytes<byte>.Initialize
	|
	|-RVA: 0x17CD500 Offset: 0x17CBF00 VA: 0x1817CD500
	|-FixedList128Bytes<int>.Initialize
	|-FixedList128Bytes<float>.Initialize
	|
	|-RVA: 0x17CDCF0 Offset: 0x17CC6F0 VA: 0x1817CDCF0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList128Bytes<T> op_Implicit(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D3D50 Offset: 0x17D2750 VA: 0x1817D3D50
	|-FixedList128Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17D3B20 Offset: 0x17D2520 VA: 0x1817D3B20
	|-FixedList128Bytes<int>.op_Implicit
	|-FixedList128Bytes<float>.op_Implicit
	|
	|-RVA: 0x17D3CE0 Offset: 0x17D26E0 VA: 0x1817D3CE0
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CB170 Offset: 0x17C9B70 VA: 0x1817CB170
	|-FixedList128Bytes<byte>.Equals
	|
	|-RVA: 0x17CA7A0 Offset: 0x17C91A0 VA: 0x1817CA7A0
	|-FixedList128Bytes<int>.Equals
	|-FixedList128Bytes<float>.Equals
	|
	|-RVA: 0x17CB780 Offset: 0x17CA180 VA: 0x1817CB780
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public FixedList128Bytes.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC4B0 Offset: 0x17CAEB0 VA: 0x1817CC4B0
	|-FixedList128Bytes<byte>.GetEnumerator
	|-FixedList128Bytes<int>.GetEnumerator
	|-FixedList128Bytes<float>.GetEnumerator
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList128Bytes<byte>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList128Bytes<int>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList128Bytes<float>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList128Bytes<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList128Bytes<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList128Bytes<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList128Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}
