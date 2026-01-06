public struct FixedList4096Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 15781
{
	// Fields
	[SerializeField]
	internal ushort length; // 0x0
	[SerializeField]
	internal FixedBytes4094 buffer; // 0x0

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
	|-FixedList4096Bytes<byte>.get_Length
	|-FixedList4096Bytes<int>.get_Length
	|-FixedList4096Bytes<float>.get_Length
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	|-FixedList4096Bytes<byte>.set_Length
	|-FixedList4096Bytes<int>.set_Length
	|-FixedList4096Bytes<float>.set_Length
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> get_Elements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1180 Offset: 0x17CFB80 VA: 0x1817D1180
	|-FixedList4096Bytes<byte>.get_Elements
	|
	|-RVA: 0x17D10D0 Offset: 0x17CFAD0 VA: 0x1817D10D0
	|-FixedList4096Bytes<int>.get_Elements
	|-FixedList4096Bytes<float>.get_Elements
	|
	|-RVA: 0x17D1110 Offset: 0x17CFB10 VA: 0x1817D1110
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_Elements
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D11C0 Offset: 0x17CFBC0 VA: 0x1817D11C0
	|-FixedList4096Bytes<byte>.get_IsEmpty
	|-FixedList4096Bytes<int>.get_IsEmpty
	|-FixedList4096Bytes<float>.get_IsEmpty
	|
	|-RVA: 0x17D11F0 Offset: 0x17CFBF0 VA: 0x1817D11F0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal int get_LengthInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D15C0 Offset: 0x17CFFC0 VA: 0x1817D15C0
	|-FixedList4096Bytes<byte>.get_LengthInBytes
	|
	|-RVA: 0x17D16D0 Offset: 0x17D00D0 VA: 0x1817D16D0
	|-FixedList4096Bytes<int>.get_LengthInBytes
	|-FixedList4096Bytes<float>.get_LengthInBytes
	|
	|-RVA: 0x17D1610 Offset: 0x17D0010 VA: 0x1817D1610
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_LengthInBytes
	*/

	// RVA: -1 Offset: -1
	internal byte* get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0F50 Offset: 0x17CF950 VA: 0x1817D0F50
	|-FixedList4096Bytes<byte>.get_Buffer
	|
	|-RVA: 0x17D0F10 Offset: 0x17CF910 VA: 0x1817D0F10
	|-FixedList4096Bytes<int>.get_Buffer
	|-FixedList4096Bytes<float>.get_Buffer
	|
	|-RVA: 0x17D0F90 Offset: 0x17CF990 VA: 0x1817D0F90
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_Buffer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E0830 Offset: 0x17DF230 VA: 0x1817E0830
	|-FixedList4096Bytes<byte>.get_Capacity
	|
	|-RVA: 0x17E0800 Offset: 0x17DF200 VA: 0x1817E0800
	|-FixedList4096Bytes<int>.get_Capacity
	|-FixedList4096Bytes<float>.get_Capacity
	|
	|-RVA: 0x17D1070 Offset: 0x17CFA70 VA: 0x1817D1070
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FixedList4096Bytes<byte>.set_Capacity
	|-FixedList4096Bytes<int>.set_Capacity
	|-FixedList4096Bytes<float>.set_Capacity
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1480 Offset: 0x17CFE80 VA: 0x1817D1480
	|-FixedList4096Bytes<byte>.get_Item
	|
	|-RVA: 0x17D1520 Offset: 0x17CFF20 VA: 0x1817D1520
	|-FixedList4096Bytes<int>.get_Item
	|
	|-RVA: 0x17D13E0 Offset: 0x17CFDE0 VA: 0x1817D13E0
	|-FixedList4096Bytes<float>.get_Item
	|
	|-RVA: 0x17D1270 Offset: 0x17CFC70 VA: 0x1817D1270
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4AB0 Offset: 0x17D34B0 VA: 0x1817D4AB0
	|-FixedList4096Bytes<byte>.set_Item
	|
	|-RVA: 0x17D4C10 Offset: 0x17D3610 VA: 0x1817D4C10
	|-FixedList4096Bytes<int>.set_Item
	|
	|-RVA: 0x17D4B60 Offset: 0x17D3560 VA: 0x1817D4B60
	|-FixedList4096Bytes<float>.set_Item
	|
	|-RVA: 0x17D4940 Offset: 0x17D3340 VA: 0x1817D4940
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CA710 Offset: 0x17C9110 VA: 0x1817CA710
	|-FixedList4096Bytes<byte>.ElementAt
	|
	|-RVA: 0x17CA5B0 Offset: 0x17C8FB0 VA: 0x1817CA5B0
	|-FixedList4096Bytes<int>.ElementAt
	|-FixedList4096Bytes<float>.ElementAt
	|
	|-RVA: 0x17CA640 Offset: 0x17C9040 VA: 0x1817CA640
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC6D0 Offset: 0x17CB0D0 VA: 0x1817CC6D0
	|-FixedList4096Bytes<byte>.GetHashCode
	|
	|-RVA: 0x17CC530 Offset: 0x17CAF30 VA: 0x1817CC530
	|-FixedList4096Bytes<int>.GetHashCode
	|-FixedList4096Bytes<float>.GetHashCode
	|
	|-RVA: 0x17CC600 Offset: 0x17CB000 VA: 0x1817CC600
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void Add(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9500 Offset: 0x17C7F00 VA: 0x1817C9500
	|-FixedList4096Bytes<byte>.Add
	|
	|-RVA: 0x17C92B0 Offset: 0x17C7CB0 VA: 0x1817C92B0
	|-FixedList4096Bytes<int>.Add
	|
	|-RVA: 0x17C9210 Offset: 0x17C7C10 VA: 0x1817C9210
	|-FixedList4096Bytes<float>.Add
	|
	|-RVA: 0x17C9350 Offset: 0x17C7D50 VA: 0x1817C9350
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8C80 Offset: 0x17C7680 VA: 0x1817C8C80
	|-FixedList4096Bytes<byte>.AddRange
	|
	|-RVA: 0x17C90D0 Offset: 0x17C7AD0 VA: 0x1817C90D0
	|-FixedList4096Bytes<int>.AddRange
	|
	|-RVA: 0x17C8F90 Offset: 0x17C7990 VA: 0x1817C8F90
	|-FixedList4096Bytes<float>.AddRange
	|
	|-RVA: 0x17C8DC0 Offset: 0x17C77C0 VA: 0x1817C8DC0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8A20 Offset: 0x17C7420 VA: 0x1817C8A20
	|-FixedList4096Bytes<byte>.AddNoResize
	|
	|-RVA: 0x17C8940 Offset: 0x17C7340 VA: 0x1817C8940
	|-FixedList4096Bytes<int>.AddNoResize
	|
	|-RVA: 0x17C8A70 Offset: 0x17C7470 VA: 0x1817C8A70
	|-FixedList4096Bytes<float>.AddNoResize
	|
	|-RVA: 0x17C8990 Offset: 0x17C7390 VA: 0x1817C8990
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8BC0 Offset: 0x17C75C0 VA: 0x1817C8BC0
	|-FixedList4096Bytes<byte>.AddRangeNoResize
	|
	|-RVA: 0x17C8C20 Offset: 0x17C7620 VA: 0x1817C8C20
	|-FixedList4096Bytes<int>.AddRangeNoResize
	|
	|-RVA: 0x17C8B60 Offset: 0x17C7560 VA: 0x1817C8B60
	|-FixedList4096Bytes<float>.AddRangeNoResize
	|
	|-RVA: 0x17C8AC0 Offset: 0x17C74C0 VA: 0x1817C8AC0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C95A0 Offset: 0x17C7FA0 VA: 0x1817C95A0
	|-FixedList4096Bytes<byte>.Clear
	|-FixedList4096Bytes<int>.Clear
	|-FixedList4096Bytes<float>.Clear
	|
	|-RVA: 0x17C95D0 Offset: 0x17C7FD0 VA: 0x1817C95D0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE4F0 Offset: 0x17CCEF0 VA: 0x1817CE4F0
	|-FixedList4096Bytes<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE870 Offset: 0x17CD270 VA: 0x1817CE870
	|-FixedList4096Bytes<int>.InsertRangeWithBeginEnd
	|-FixedList4096Bytes<float>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE620 Offset: 0x17CD020 VA: 0x1817CE620
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE9C0 Offset: 0x17CD3C0 VA: 0x1817CE9C0
	|-FixedList4096Bytes<byte>.Insert
	|
	|-RVA: 0x17CEA60 Offset: 0x17CD460 VA: 0x1817CEA60
	|-FixedList4096Bytes<int>.Insert
	|
	|-RVA: 0x17CEB00 Offset: 0x17CD500 VA: 0x1817CEB00
	|-FixedList4096Bytes<float>.Insert
	|
	|-RVA: 0x17CEBB0 Offset: 0x17CD5B0 VA: 0x1817CEBB0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEE00 Offset: 0x17CD800 VA: 0x1817CEE00
	|-FixedList4096Bytes<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED20 Offset: 0x17CD720 VA: 0x1817CED20
	|-FixedList4096Bytes<int>.RemoveAtSwapBack
	|-FixedList4096Bytes<float>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED70 Offset: 0x17CD770 VA: 0x1817CED70
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF0E0 Offset: 0x17CDAE0 VA: 0x1817CF0E0
	|-FixedList4096Bytes<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF250 Offset: 0x17CDC50 VA: 0x1817CF250
	|-FixedList4096Bytes<int>.RemoveRangeSwapBack
	|-FixedList4096Bytes<float>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF3E0 Offset: 0x17CDDE0 VA: 0x1817CF3E0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF020 Offset: 0x17CDA20 VA: 0x1817CF020
	|-FixedList4096Bytes<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CF080 Offset: 0x17CDA80 VA: 0x1817CF080
	|-FixedList4096Bytes<int>.RemoveRangeSwapBackWithBeginEnd
	|-FixedList4096Bytes<float>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CEF80 Offset: 0x17CD980 VA: 0x1817CEF80
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEEE0 Offset: 0x17CD8E0 VA: 0x1817CEEE0
	|-FixedList4096Bytes<byte>.RemoveAt
	|
	|-RVA: 0x17CEF30 Offset: 0x17CD930 VA: 0x1817CEF30
	|-FixedList4096Bytes<int>.RemoveAt
	|-FixedList4096Bytes<float>.RemoveAt
	|
	|-RVA: 0x17CEE50 Offset: 0x17CD850 VA: 0x1817CEE50
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFC10 Offset: 0x17CE610 VA: 0x1817CFC10
	|-FixedList4096Bytes<byte>.RemoveRange
	|
	|-RVA: 0x17CFA80 Offset: 0x17CE480 VA: 0x1817CFA80
	|-FixedList4096Bytes<int>.RemoveRange
	|-FixedList4096Bytes<float>.RemoveRange
	|
	|-RVA: 0x17CF7E0 Offset: 0x17CE1E0 VA: 0x1817CF7E0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF6E0 Offset: 0x17CE0E0 VA: 0x1817CF6E0
	|-FixedList4096Bytes<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF680 Offset: 0x17CE080 VA: 0x1817CF680
	|-FixedList4096Bytes<int>.RemoveRangeWithBeginEnd
	|-FixedList4096Bytes<float>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF740 Offset: 0x17CE140 VA: 0x1817CF740
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFEE0 Offset: 0x17CE8E0 VA: 0x1817CFEE0
	|-FixedList4096Bytes<byte>.ToArray
	|
	|-RVA: 0x17CFD80 Offset: 0x17CE780 VA: 0x1817CFD80
	|-FixedList4096Bytes<int>.ToArray
	|-FixedList4096Bytes<float>.ToArray
	|
	|-RVA: 0x17D0040 Offset: 0x17CEA40 VA: 0x1817D0040
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D01D0 Offset: 0x17CEBD0 VA: 0x1817D01D0
	|-FixedList4096Bytes<byte>.ToNativeArray
	|
	|-RVA: 0x17D0350 Offset: 0x17CED50 VA: 0x1817D0350
	|-FixedList4096Bytes<int>.ToNativeArray
	|
	|-RVA: 0x17D06D0 Offset: 0x17CF0D0 VA: 0x1817D06D0
	|-FixedList4096Bytes<float>.ToNativeArray
	|
	|-RVA: 0x17D04E0 Offset: 0x17CEEE0 VA: 0x1817D04E0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.ToNativeArray
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList4096Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E1070 Offset: 0x17DFA70 VA: 0x1817E1070
	|-FixedList4096Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E0AB0 Offset: 0x17DF4B0 VA: 0x1817E0AB0
	|-FixedList4096Bytes<int>.op_Equality
	|
	|-RVA: 0x17E2440 Offset: 0x17E0E40 VA: 0x1817E2440
	|-FixedList4096Bytes<float>.op_Equality
	|
	|-RVA: 0x17E16B0 Offset: 0x17E00B0 VA: 0x1817E16B0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList4096Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E3280 Offset: 0x17E1C80 VA: 0x1817E3280
	|-FixedList4096Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E3590 Offset: 0x17E1F90 VA: 0x1817E3590
	|-FixedList4096Bytes<int>.op_Inequality
	|
	|-RVA: 0x17E3410 Offset: 0x17E1E10 VA: 0x1817E3410
	|-FixedList4096Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D45C0 Offset: 0x17D2FC0 VA: 0x1817D45C0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int CompareTo(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList4096Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList4096Bytes<int>.CompareTo
	|-FixedList4096Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9A30 Offset: 0x17C8430 VA: 0x1817C9A30
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Equals(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC1F0 Offset: 0x17CABF0 VA: 0x1817CC1F0
	|-FixedList4096Bytes<byte>.Equals
	|
	|-RVA: 0x17CAED0 Offset: 0x17C98D0 VA: 0x1817CAED0
	|-FixedList4096Bytes<int>.Equals
	|-FixedList4096Bytes<float>.Equals
	|
	|-RVA: 0x17CAE30 Offset: 0x17C9830 VA: 0x1817CAE30
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E0460 Offset: 0x17DEE60 VA: 0x1817E0460
	|-FixedList4096Bytes<byte>..ctor
	|
	|-RVA: 0x17E03F0 Offset: 0x17DEDF0 VA: 0x1817E03F0
	|-FixedList4096Bytes<int>..ctor
	|
	|-RVA: 0x17E04D0 Offset: 0x17DEED0 VA: 0x1817E04D0
	|-FixedList4096Bytes<float>..ctor
	|
	|-RVA: 0x17E0650 Offset: 0x17DF050 VA: 0x1817E0650
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DE900 Offset: 0x17DD300 VA: 0x1817DE900
	|-FixedList4096Bytes<byte>.Initialize
	|
	|-RVA: 0x17DF030 Offset: 0x17DDA30 VA: 0x1817DF030
	|-FixedList4096Bytes<int>.Initialize
	|
	|-RVA: 0x17DFFB0 Offset: 0x17DE9B0 VA: 0x1817DFFB0
	|-FixedList4096Bytes<float>.Initialize
	|
	|-RVA: 0x17DFD80 Offset: 0x17DE780 VA: 0x1817DFD80
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList4096Bytes<T> op_Implicit(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E2F70 Offset: 0x17E1970 VA: 0x1817E2F70
	|-FixedList4096Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E3180 Offset: 0x17E1B80 VA: 0x1817E3180
	|-FixedList4096Bytes<int>.op_Implicit
	|
	|-RVA: 0x17E3020 Offset: 0x17E1A20 VA: 0x1817E3020
	|-FixedList4096Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E2DE0 Offset: 0x17E17E0 VA: 0x1817E2DE0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList4096Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E1E80 Offset: 0x17E0880 VA: 0x1817E1E80
	|-FixedList4096Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E0E90 Offset: 0x17DF890 VA: 0x1817E0E90
	|-FixedList4096Bytes<int>.op_Equality
	|-FixedList4096Bytes<float>.op_Equality
	|
	|-RVA: 0x17E1890 Offset: 0x17E0290 VA: 0x1817E1890
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList4096Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E3370 Offset: 0x17E1D70 VA: 0x1817E3370
	|-FixedList4096Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E32D0 Offset: 0x17E1CD0 VA: 0x1817E32D0
	|-FixedList4096Bytes<int>.op_Inequality
	|-FixedList4096Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D3FF0 Offset: 0x17D29F0 VA: 0x1817D3FF0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public int CompareTo(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList4096Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList4096Bytes<int>.CompareTo
	|-FixedList4096Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA320 Offset: 0x17C8D20 VA: 0x1817CA320
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Equals(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC010 Offset: 0x17CAA10 VA: 0x1817CC010
	|-FixedList4096Bytes<byte>.Equals
	|
	|-RVA: 0x17CADB0 Offset: 0x17C97B0 VA: 0x1817CADB0
	|-FixedList4096Bytes<int>.Equals
	|-FixedList4096Bytes<float>.Equals
	|
	|-RVA: 0x17CBF60 Offset: 0x17CA960 VA: 0x1817CBF60
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E0190 Offset: 0x17DEB90 VA: 0x1817E0190
	|-FixedList4096Bytes<byte>..ctor
	|
	|-RVA: 0x17E0200 Offset: 0x17DEC00 VA: 0x1817E0200
	|-FixedList4096Bytes<int>..ctor
	|-FixedList4096Bytes<float>..ctor
	|
	|-RVA: 0x17E0760 Offset: 0x17DF160 VA: 0x1817E0760
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DE700 Offset: 0x17DD100 VA: 0x1817DE700
	|-FixedList4096Bytes<byte>.Initialize
	|
	|-RVA: 0x17DFBA0 Offset: 0x17DE5A0 VA: 0x1817DFBA0
	|-FixedList4096Bytes<int>.Initialize
	|-FixedList4096Bytes<float>.Initialize
	|
	|-RVA: 0x17DF720 Offset: 0x17DE120 VA: 0x1817DF720
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList4096Bytes<T> op_Implicit(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E2AC0 Offset: 0x17E14C0 VA: 0x1817E2AC0
	|-FixedList4096Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E2EC0 Offset: 0x17E18C0 VA: 0x1817E2EC0
	|-FixedList4096Bytes<int>.op_Implicit
	|-FixedList4096Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E2B70 Offset: 0x17E1570 VA: 0x1817E2B70
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList4096Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E1C70 Offset: 0x17E0670 VA: 0x1817E1C70
	|-FixedList4096Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E0C80 Offset: 0x17DF680 VA: 0x1817E0C80
	|-FixedList4096Bytes<int>.op_Equality
	|-FixedList4096Bytes<float>.op_Equality
	|
	|-RVA: 0x17E1480 Offset: 0x17DFE80 VA: 0x1817E1480
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList4096Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E3460 Offset: 0x17E1E60 VA: 0x1817E3460
	|-FixedList4096Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E3320 Offset: 0x17E1D20 VA: 0x1817E3320
	|-FixedList4096Bytes<int>.op_Inequality
	|-FixedList4096Bytes<float>.op_Inequality
	|
	|-RVA: 0x17E3500 Offset: 0x17E1F00 VA: 0x1817E3500
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int CompareTo(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList4096Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList4096Bytes<int>.CompareTo
	|-FixedList4096Bytes<float>.CompareTo
	|
	|-RVA: 0x17DC540 Offset: 0x17DAF40 VA: 0x1817DC540
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Equals(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DDAF0 Offset: 0x17DC4F0 VA: 0x1817DDAF0
	|-FixedList4096Bytes<byte>.Equals
	|
	|-RVA: 0x17DCB20 Offset: 0x17DB520 VA: 0x1817DCB20
	|-FixedList4096Bytes<int>.Equals
	|-FixedList4096Bytes<float>.Equals
	|
	|-RVA: 0x17DCBD0 Offset: 0x17DB5D0 VA: 0x1817DCBD0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E06F0 Offset: 0x17DF0F0 VA: 0x1817E06F0
	|-FixedList4096Bytes<byte>..ctor
	|
	|-RVA: 0x17E0380 Offset: 0x17DED80 VA: 0x1817E0380
	|-FixedList4096Bytes<int>..ctor
	|-FixedList4096Bytes<float>..ctor
	|
	|-RVA: 0x17E05B0 Offset: 0x17DEFB0 VA: 0x1817E05B0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DF960 Offset: 0x17DE360 VA: 0x1817DF960
	|-FixedList4096Bytes<byte>.Initialize
	|
	|-RVA: 0x17DE4C0 Offset: 0x17DCEC0 VA: 0x1817DE4C0
	|-FixedList4096Bytes<int>.Initialize
	|-FixedList4096Bytes<float>.Initialize
	|
	|-RVA: 0x17DF480 Offset: 0x17DDE80 VA: 0x1817DF480
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList4096Bytes<T> op_Implicit(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E30D0 Offset: 0x17E1AD0 VA: 0x1817E30D0
	|-FixedList4096Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E2880 Offset: 0x17E1280 VA: 0x1817E2880
	|-FixedList4096Bytes<int>.op_Implicit
	|-FixedList4096Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E2C50 Offset: 0x17E1650 VA: 0x1817E2C50
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList4096Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E0860 Offset: 0x17DF260 VA: 0x1817E0860
	|-FixedList4096Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E1230 Offset: 0x17DFC30 VA: 0x1817E1230
	|-FixedList4096Bytes<int>.op_Equality
	|-FixedList4096Bytes<float>.op_Equality
	|
	|-RVA: 0x17E2630 Offset: 0x17E1030 VA: 0x1817E2630
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList4096Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E33C0 Offset: 0x17E1DC0 VA: 0x1817E33C0
	|-FixedList4096Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E35E0 Offset: 0x17E1FE0 VA: 0x1817E35E0
	|-FixedList4096Bytes<int>.op_Inequality
	|-FixedList4096Bytes<float>.op_Inequality
	|
	|-RVA: 0x17E3630 Offset: 0x17E2030 VA: 0x1817E3630
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public int CompareTo(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList4096Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList4096Bytes<int>.CompareTo
	|-FixedList4096Bytes<float>.CompareTo
	|
	|-RVA: 0x17DC7D0 Offset: 0x17DB1D0 VA: 0x1817DC7D0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Equals(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DCA60 Offset: 0x17DB460 VA: 0x1817DCA60
	|-FixedList4096Bytes<byte>.Equals
	|
	|-RVA: 0x17DE2B0 Offset: 0x17DCCB0 VA: 0x1817DE2B0
	|-FixedList4096Bytes<int>.Equals
	|-FixedList4096Bytes<float>.Equals
	|
	|-RVA: 0x17DE1B0 Offset: 0x17DCBB0 VA: 0x1817DE1B0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E0540 Offset: 0x17DEF40 VA: 0x1817E0540
	|-FixedList4096Bytes<byte>..ctor
	|
	|-RVA: 0x17E0270 Offset: 0x17DEC70 VA: 0x1817E0270
	|-FixedList4096Bytes<int>..ctor
	|-FixedList4096Bytes<float>..ctor
	|
	|-RVA: 0x17E02E0 Offset: 0x17DECE0 VA: 0x1817E02E0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DEDA0 Offset: 0x17DD7A0 VA: 0x1817DEDA0
	|-FixedList4096Bytes<byte>.Initialize
	|
	|-RVA: 0x17DF1F0 Offset: 0x17DDBF0 VA: 0x1817DF1F0
	|-FixedList4096Bytes<int>.Initialize
	|-FixedList4096Bytes<float>.Initialize
	|
	|-RVA: 0x17DEAC0 Offset: 0x17DD4C0 VA: 0x1817DEAC0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList4096Bytes<T> op_Implicit(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E2A10 Offset: 0x17E1410 VA: 0x1817E2A10
	|-FixedList4096Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E2D30 Offset: 0x17E1730 VA: 0x1817E2D30
	|-FixedList4096Bytes<int>.op_Implicit
	|-FixedList4096Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E2930 Offset: 0x17E1330 VA: 0x1817E2930
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList4096Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E1A90 Offset: 0x17E0490 VA: 0x1817E1A90
	|-FixedList4096Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E2260 Offset: 0x17E0C60 VA: 0x1817E2260
	|-FixedList4096Bytes<int>.op_Equality
	|-FixedList4096Bytes<float>.op_Equality
	|
	|-RVA: 0x17E2080 Offset: 0x17E0A80 VA: 0x1817E2080
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList4096Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E34B0 Offset: 0x17E1EB0 VA: 0x1817E34B0
	|-FixedList4096Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E3230 Offset: 0x17E1C30 VA: 0x1817E3230
	|-FixedList4096Bytes<int>.op_Inequality
	|-FixedList4096Bytes<float>.op_Inequality
	|
	|-RVA: 0x17E36C0 Offset: 0x17E20C0 VA: 0x1817E36C0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int CompareTo(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList4096Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList4096Bytes<int>.CompareTo
	|-FixedList4096Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA090 Offset: 0x17C8A90 VA: 0x1817CA090
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Equals(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DDA60 Offset: 0x17DC460 VA: 0x1817DDA60
	|-FixedList4096Bytes<byte>.Equals
	|
	|-RVA: 0x17DD9D0 Offset: 0x17DC3D0 VA: 0x1817DD9D0
	|-FixedList4096Bytes<int>.Equals
	|-FixedList4096Bytes<float>.Equals
	|
	|-RVA: 0x17DE370 Offset: 0x17DCD70 VA: 0x1817DE370
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DDBA0 Offset: 0x17DC5A0 VA: 0x1817DDBA0
	|-FixedList4096Bytes<byte>.Equals
	|
	|-RVA: 0x17DD3C0 Offset: 0x17DBDC0 VA: 0x1817DD3C0
	|-FixedList4096Bytes<int>.Equals
	|-FixedList4096Bytes<float>.Equals
	|
	|-RVA: 0x17DCCB0 Offset: 0x17DB6B0 VA: 0x1817DCCB0
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public FixedList4096Bytes.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DE430 Offset: 0x17DCE30 VA: 0x1817DE430
	|-FixedList4096Bytes<byte>.GetEnumerator
	|-FixedList4096Bytes<int>.GetEnumerator
	|-FixedList4096Bytes<float>.GetEnumerator
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList4096Bytes<byte>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList4096Bytes<int>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList4096Bytes<float>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList4096Bytes<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList4096Bytes<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList4096Bytes<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList4096Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}
