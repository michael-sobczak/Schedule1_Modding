public struct FixedList512Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 15776
{
	// Fields
	[SerializeField]
	internal ushort length; // 0x0
	[SerializeField]
	internal FixedBytes510 buffer; // 0x0

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
	|-FixedList512Bytes<byte>.get_Length
	|-FixedList512Bytes<int>.get_Length
	|-FixedList512Bytes<float>.get_Length
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	|-FixedList512Bytes<byte>.set_Length
	|-FixedList512Bytes<int>.set_Length
	|-FixedList512Bytes<float>.set_Length
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> get_Elements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1180 Offset: 0x17CFB80 VA: 0x1817D1180
	|-FixedList512Bytes<byte>.get_Elements
	|
	|-RVA: 0x17D10D0 Offset: 0x17CFAD0 VA: 0x1817D10D0
	|-FixedList512Bytes<int>.get_Elements
	|-FixedList512Bytes<float>.get_Elements
	|
	|-RVA: 0x17D1110 Offset: 0x17CFB10 VA: 0x1817D1110
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_Elements
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D11C0 Offset: 0x17CFBC0 VA: 0x1817D11C0
	|-FixedList512Bytes<byte>.get_IsEmpty
	|-FixedList512Bytes<int>.get_IsEmpty
	|-FixedList512Bytes<float>.get_IsEmpty
	|
	|-RVA: 0x17D11F0 Offset: 0x17CFBF0 VA: 0x1817D11F0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal int get_LengthInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D15C0 Offset: 0x17CFFC0 VA: 0x1817D15C0
	|-FixedList512Bytes<byte>.get_LengthInBytes
	|
	|-RVA: 0x17D16D0 Offset: 0x17D00D0 VA: 0x1817D16D0
	|-FixedList512Bytes<int>.get_LengthInBytes
	|-FixedList512Bytes<float>.get_LengthInBytes
	|
	|-RVA: 0x17D1610 Offset: 0x17D0010 VA: 0x1817D1610
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_LengthInBytes
	*/

	// RVA: -1 Offset: -1
	internal byte* get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0F50 Offset: 0x17CF950 VA: 0x1817D0F50
	|-FixedList512Bytes<byte>.get_Buffer
	|
	|-RVA: 0x17D0F10 Offset: 0x17CF910 VA: 0x1817D0F10
	|-FixedList512Bytes<int>.get_Buffer
	|-FixedList512Bytes<float>.get_Buffer
	|
	|-RVA: 0x17D0F90 Offset: 0x17CF990 VA: 0x1817D0F90
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_Buffer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E7000 Offset: 0x17E5A00 VA: 0x1817E7000
	|-FixedList512Bytes<byte>.get_Capacity
	|
	|-RVA: 0x17E7030 Offset: 0x17E5A30 VA: 0x1817E7030
	|-FixedList512Bytes<int>.get_Capacity
	|-FixedList512Bytes<float>.get_Capacity
	|
	|-RVA: 0x17D1070 Offset: 0x17CFA70 VA: 0x1817D1070
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FixedList512Bytes<byte>.set_Capacity
	|-FixedList512Bytes<int>.set_Capacity
	|-FixedList512Bytes<float>.set_Capacity
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1480 Offset: 0x17CFE80 VA: 0x1817D1480
	|-FixedList512Bytes<byte>.get_Item
	|
	|-RVA: 0x17D1520 Offset: 0x17CFF20 VA: 0x1817D1520
	|-FixedList512Bytes<int>.get_Item
	|
	|-RVA: 0x17D13E0 Offset: 0x17CFDE0 VA: 0x1817D13E0
	|-FixedList512Bytes<float>.get_Item
	|
	|-RVA: 0x17D1270 Offset: 0x17CFC70 VA: 0x1817D1270
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4AB0 Offset: 0x17D34B0 VA: 0x1817D4AB0
	|-FixedList512Bytes<byte>.set_Item
	|
	|-RVA: 0x17D4C10 Offset: 0x17D3610 VA: 0x1817D4C10
	|-FixedList512Bytes<int>.set_Item
	|
	|-RVA: 0x17D4B60 Offset: 0x17D3560 VA: 0x1817D4B60
	|-FixedList512Bytes<float>.set_Item
	|
	|-RVA: 0x17D4940 Offset: 0x17D3340 VA: 0x1817D4940
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CA710 Offset: 0x17C9110 VA: 0x1817CA710
	|-FixedList512Bytes<byte>.ElementAt
	|
	|-RVA: 0x17CA5B0 Offset: 0x17C8FB0 VA: 0x1817CA5B0
	|-FixedList512Bytes<int>.ElementAt
	|-FixedList512Bytes<float>.ElementAt
	|
	|-RVA: 0x17CA640 Offset: 0x17C9040 VA: 0x1817CA640
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC6D0 Offset: 0x17CB0D0 VA: 0x1817CC6D0
	|-FixedList512Bytes<byte>.GetHashCode
	|
	|-RVA: 0x17CC530 Offset: 0x17CAF30 VA: 0x1817CC530
	|-FixedList512Bytes<int>.GetHashCode
	|-FixedList512Bytes<float>.GetHashCode
	|
	|-RVA: 0x17CC600 Offset: 0x17CB000 VA: 0x1817CC600
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void Add(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9500 Offset: 0x17C7F00 VA: 0x1817C9500
	|-FixedList512Bytes<byte>.Add
	|
	|-RVA: 0x17C92B0 Offset: 0x17C7CB0 VA: 0x1817C92B0
	|-FixedList512Bytes<int>.Add
	|
	|-RVA: 0x17C9210 Offset: 0x17C7C10 VA: 0x1817C9210
	|-FixedList512Bytes<float>.Add
	|
	|-RVA: 0x17C9350 Offset: 0x17C7D50 VA: 0x1817C9350
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8C80 Offset: 0x17C7680 VA: 0x1817C8C80
	|-FixedList512Bytes<byte>.AddRange
	|
	|-RVA: 0x17C90D0 Offset: 0x17C7AD0 VA: 0x1817C90D0
	|-FixedList512Bytes<int>.AddRange
	|
	|-RVA: 0x17C8F90 Offset: 0x17C7990 VA: 0x1817C8F90
	|-FixedList512Bytes<float>.AddRange
	|
	|-RVA: 0x17C8DC0 Offset: 0x17C77C0 VA: 0x1817C8DC0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8A20 Offset: 0x17C7420 VA: 0x1817C8A20
	|-FixedList512Bytes<byte>.AddNoResize
	|
	|-RVA: 0x17C8940 Offset: 0x17C7340 VA: 0x1817C8940
	|-FixedList512Bytes<int>.AddNoResize
	|
	|-RVA: 0x17C8A70 Offset: 0x17C7470 VA: 0x1817C8A70
	|-FixedList512Bytes<float>.AddNoResize
	|
	|-RVA: 0x17C8990 Offset: 0x17C7390 VA: 0x1817C8990
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8BC0 Offset: 0x17C75C0 VA: 0x1817C8BC0
	|-FixedList512Bytes<byte>.AddRangeNoResize
	|
	|-RVA: 0x17C8C20 Offset: 0x17C7620 VA: 0x1817C8C20
	|-FixedList512Bytes<int>.AddRangeNoResize
	|
	|-RVA: 0x17C8B60 Offset: 0x17C7560 VA: 0x1817C8B60
	|-FixedList512Bytes<float>.AddRangeNoResize
	|
	|-RVA: 0x17C8AC0 Offset: 0x17C74C0 VA: 0x1817C8AC0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C95A0 Offset: 0x17C7FA0 VA: 0x1817C95A0
	|-FixedList512Bytes<byte>.Clear
	|-FixedList512Bytes<int>.Clear
	|-FixedList512Bytes<float>.Clear
	|
	|-RVA: 0x17C95D0 Offset: 0x17C7FD0 VA: 0x1817C95D0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE4F0 Offset: 0x17CCEF0 VA: 0x1817CE4F0
	|-FixedList512Bytes<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE870 Offset: 0x17CD270 VA: 0x1817CE870
	|-FixedList512Bytes<int>.InsertRangeWithBeginEnd
	|-FixedList512Bytes<float>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE620 Offset: 0x17CD020 VA: 0x1817CE620
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE9C0 Offset: 0x17CD3C0 VA: 0x1817CE9C0
	|-FixedList512Bytes<byte>.Insert
	|
	|-RVA: 0x17CEA60 Offset: 0x17CD460 VA: 0x1817CEA60
	|-FixedList512Bytes<int>.Insert
	|
	|-RVA: 0x17CEB00 Offset: 0x17CD500 VA: 0x1817CEB00
	|-FixedList512Bytes<float>.Insert
	|
	|-RVA: 0x17CEBB0 Offset: 0x17CD5B0 VA: 0x1817CEBB0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEE00 Offset: 0x17CD800 VA: 0x1817CEE00
	|-FixedList512Bytes<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED20 Offset: 0x17CD720 VA: 0x1817CED20
	|-FixedList512Bytes<int>.RemoveAtSwapBack
	|-FixedList512Bytes<float>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED70 Offset: 0x17CD770 VA: 0x1817CED70
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF0E0 Offset: 0x17CDAE0 VA: 0x1817CF0E0
	|-FixedList512Bytes<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF250 Offset: 0x17CDC50 VA: 0x1817CF250
	|-FixedList512Bytes<int>.RemoveRangeSwapBack
	|-FixedList512Bytes<float>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF3E0 Offset: 0x17CDDE0 VA: 0x1817CF3E0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF020 Offset: 0x17CDA20 VA: 0x1817CF020
	|-FixedList512Bytes<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CF080 Offset: 0x17CDA80 VA: 0x1817CF080
	|-FixedList512Bytes<int>.RemoveRangeSwapBackWithBeginEnd
	|-FixedList512Bytes<float>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CEF80 Offset: 0x17CD980 VA: 0x1817CEF80
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEEE0 Offset: 0x17CD8E0 VA: 0x1817CEEE0
	|-FixedList512Bytes<byte>.RemoveAt
	|
	|-RVA: 0x17CEF30 Offset: 0x17CD930 VA: 0x1817CEF30
	|-FixedList512Bytes<int>.RemoveAt
	|-FixedList512Bytes<float>.RemoveAt
	|
	|-RVA: 0x17CEE50 Offset: 0x17CD850 VA: 0x1817CEE50
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFC10 Offset: 0x17CE610 VA: 0x1817CFC10
	|-FixedList512Bytes<byte>.RemoveRange
	|
	|-RVA: 0x17CFA80 Offset: 0x17CE480 VA: 0x1817CFA80
	|-FixedList512Bytes<int>.RemoveRange
	|-FixedList512Bytes<float>.RemoveRange
	|
	|-RVA: 0x17CF7E0 Offset: 0x17CE1E0 VA: 0x1817CF7E0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF6E0 Offset: 0x17CE0E0 VA: 0x1817CF6E0
	|-FixedList512Bytes<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF680 Offset: 0x17CE080 VA: 0x1817CF680
	|-FixedList512Bytes<int>.RemoveRangeWithBeginEnd
	|-FixedList512Bytes<float>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF740 Offset: 0x17CE140 VA: 0x1817CF740
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFEE0 Offset: 0x17CE8E0 VA: 0x1817CFEE0
	|-FixedList512Bytes<byte>.ToArray
	|
	|-RVA: 0x17CFD80 Offset: 0x17CE780 VA: 0x1817CFD80
	|-FixedList512Bytes<int>.ToArray
	|-FixedList512Bytes<float>.ToArray
	|
	|-RVA: 0x17D0040 Offset: 0x17CEA40 VA: 0x1817D0040
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D01D0 Offset: 0x17CEBD0 VA: 0x1817D01D0
	|-FixedList512Bytes<byte>.ToNativeArray
	|
	|-RVA: 0x17D0350 Offset: 0x17CED50 VA: 0x1817D0350
	|-FixedList512Bytes<int>.ToNativeArray
	|
	|-RVA: 0x17D06D0 Offset: 0x17CF0D0 VA: 0x1817D06D0
	|-FixedList512Bytes<float>.ToNativeArray
	|
	|-RVA: 0x17D04E0 Offset: 0x17CEEE0 VA: 0x1817D04E0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.ToNativeArray
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList512Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E8DD0 Offset: 0x17E77D0 VA: 0x1817E8DD0
	|-FixedList512Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E7A30 Offset: 0x17E6430 VA: 0x1817E7A30
	|-FixedList512Bytes<int>.op_Equality
	|
	|-RVA: 0x17E8920 Offset: 0x17E7320 VA: 0x1817E8920
	|-FixedList512Bytes<float>.op_Equality
	|
	|-RVA: 0x17E77E0 Offset: 0x17E61E0 VA: 0x1817E77E0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList512Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EA440 Offset: 0x17E8E40 VA: 0x1817EA440
	|-FixedList512Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17EA050 Offset: 0x17E8A50 VA: 0x1817EA050
	|-FixedList512Bytes<int>.op_Inequality
	|
	|-RVA: 0x17EA0F0 Offset: 0x17E8AF0 VA: 0x1817EA0F0
	|-FixedList512Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D45C0 Offset: 0x17D2FC0 VA: 0x1817D45C0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int CompareTo(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList512Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList512Bytes<int>.CompareTo
	|-FixedList512Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9A30 Offset: 0x17C8430 VA: 0x1817C9A30
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Equals(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC1F0 Offset: 0x17CABF0 VA: 0x1817CC1F0
	|-FixedList512Bytes<byte>.Equals
	|
	|-RVA: 0x17CAED0 Offset: 0x17C98D0 VA: 0x1817CAED0
	|-FixedList512Bytes<int>.Equals
	|-FixedList512Bytes<float>.Equals
	|
	|-RVA: 0x17CAE30 Offset: 0x17C9830 VA: 0x1817CAE30
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E6A70 Offset: 0x17E5470 VA: 0x1817E6A70
	|-FixedList512Bytes<byte>..ctor
	|
	|-RVA: 0x17E6DE0 Offset: 0x17E57E0 VA: 0x1817E6DE0
	|-FixedList512Bytes<int>..ctor
	|
	|-RVA: 0x17E6C90 Offset: 0x17E5690 VA: 0x1817E6C90
	|-FixedList512Bytes<float>..ctor
	|
	|-RVA: 0x17E6E50 Offset: 0x17E5850 VA: 0x1817E6E50
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E67D0 Offset: 0x17E51D0 VA: 0x1817E67D0
	|-FixedList512Bytes<byte>.Initialize
	|
	|-RVA: 0x17E5210 Offset: 0x17E3C10 VA: 0x1817E5210
	|-FixedList512Bytes<int>.Initialize
	|
	|-RVA: 0x17E63B0 Offset: 0x17E4DB0 VA: 0x1817E63B0
	|-FixedList512Bytes<float>.Initialize
	|
	|-RVA: 0x17E5640 Offset: 0x17E4040 VA: 0x1817E5640
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList512Bytes<T> op_Implicit(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E98D0 Offset: 0x17E82D0 VA: 0x1817E98D0
	|-FixedList512Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E9A10 Offset: 0x17E8410 VA: 0x1817E9A10
	|-FixedList512Bytes<int>.op_Implicit
	|
	|-RVA: 0x17E9DE0 Offset: 0x17E87E0 VA: 0x1817E9DE0
	|-FixedList512Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E9D70 Offset: 0x17E8770 VA: 0x1817E9D70
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList512Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E81B0 Offset: 0x17E6BB0 VA: 0x1817E81B0
	|-FixedList512Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E9000 Offset: 0x17E7A00 VA: 0x1817E9000
	|-FixedList512Bytes<int>.op_Equality
	|-FixedList512Bytes<float>.op_Equality
	|
	|-RVA: 0x17E9240 Offset: 0x17E7C40 VA: 0x1817E9240
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList512Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EA6A0 Offset: 0x17E90A0 VA: 0x1817EA6A0
	|-FixedList512Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17EA0A0 Offset: 0x17E8AA0 VA: 0x1817EA0A0
	|-FixedList512Bytes<int>.op_Inequality
	|-FixedList512Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D3FF0 Offset: 0x17D29F0 VA: 0x1817D3FF0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public int CompareTo(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList512Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList512Bytes<int>.CompareTo
	|-FixedList512Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA320 Offset: 0x17C8D20 VA: 0x1817CA320
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Equals(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC010 Offset: 0x17CAA10 VA: 0x1817CC010
	|-FixedList512Bytes<byte>.Equals
	|
	|-RVA: 0x17CADB0 Offset: 0x17C97B0 VA: 0x1817CADB0
	|-FixedList512Bytes<int>.Equals
	|-FixedList512Bytes<float>.Equals
	|
	|-RVA: 0x17CBF60 Offset: 0x17CA960 VA: 0x1817CBF60
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E6A00 Offset: 0x17E5400 VA: 0x1817E6A00
	|-FixedList512Bytes<byte>..ctor
	|
	|-RVA: 0x17E6EF0 Offset: 0x17E58F0 VA: 0x1817E6EF0
	|-FixedList512Bytes<int>..ctor
	|-FixedList512Bytes<float>..ctor
	|
	|-RVA: 0x17E6F60 Offset: 0x17E5960 VA: 0x1817E6F60
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E5AA0 Offset: 0x17E44A0 VA: 0x1817E5AA0
	|-FixedList512Bytes<byte>.Initialize
	|
	|-RVA: 0x17E5030 Offset: 0x17E3A30 VA: 0x1817E5030
	|-FixedList512Bytes<int>.Initialize
	|-FixedList512Bytes<float>.Initialize
	|
	|-RVA: 0x17E6590 Offset: 0x17E4F90 VA: 0x1817E6590
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList512Bytes<T> op_Implicit(in FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E9AB0 Offset: 0x17E84B0 VA: 0x1817E9AB0
	|-FixedList512Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E9BC0 Offset: 0x17E85C0 VA: 0x1817E9BC0
	|-FixedList512Bytes<int>.op_Implicit
	|-FixedList512Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E9D00 Offset: 0x17E8700 VA: 0x1817E9D00
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList512Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E7060 Offset: 0x17E5A60 VA: 0x1817E7060
	|-FixedList512Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E72E0 Offset: 0x17E5CE0 VA: 0x1817E72E0
	|-FixedList512Bytes<int>.op_Equality
	|-FixedList512Bytes<float>.op_Equality
	|
	|-RVA: 0x17E7EF0 Offset: 0x17E68F0 VA: 0x1817E7EF0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList512Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EA140 Offset: 0x17E8B40 VA: 0x1817EA140
	|-FixedList512Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17EA000 Offset: 0x17E8A00 VA: 0x1817EA000
	|-FixedList512Bytes<int>.op_Inequality
	|-FixedList512Bytes<float>.op_Inequality
	|
	|-RVA: 0x17E3500 Offset: 0x17E1F00 VA: 0x1817E3500
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int CompareTo(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList512Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList512Bytes<int>.CompareTo
	|-FixedList512Bytes<float>.CompareTo
	|
	|-RVA: 0x17DC540 Offset: 0x17DAF40 VA: 0x1817DC540
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Equals(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17DDAF0 Offset: 0x17DC4F0 VA: 0x1817DDAF0
	|-FixedList512Bytes<byte>.Equals
	|
	|-RVA: 0x17DCB20 Offset: 0x17DB520 VA: 0x1817DCB20
	|-FixedList512Bytes<int>.Equals
	|-FixedList512Bytes<float>.Equals
	|
	|-RVA: 0x17DCBD0 Offset: 0x17DB5D0 VA: 0x1817DCBD0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E6D00 Offset: 0x17E5700 VA: 0x1817E6D00
	|-FixedList512Bytes<byte>..ctor
	|
	|-RVA: 0x17E6D70 Offset: 0x17E5770 VA: 0x1817E6D70
	|-FixedList512Bytes<int>..ctor
	|-FixedList512Bytes<float>..ctor
	|
	|-RVA: 0x17E6AE0 Offset: 0x17E54E0 VA: 0x1817E6AE0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E5CA0 Offset: 0x17E46A0 VA: 0x1817E5CA0
	|-FixedList512Bytes<byte>.Initialize
	|
	|-RVA: 0x17E4DF0 Offset: 0x17E37F0 VA: 0x1817E4DF0
	|-FixedList512Bytes<int>.Initialize
	|-FixedList512Bytes<float>.Initialize
	|
	|-RVA: 0x17E6110 Offset: 0x17E4B10 VA: 0x1817E6110
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList512Bytes<T> op_Implicit(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E9970 Offset: 0x17E8370 VA: 0x1817E9970
	|-FixedList512Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E9C60 Offset: 0x17E8660 VA: 0x1817E9C60
	|-FixedList512Bytes<int>.op_Implicit
	|-FixedList512Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E9B50 Offset: 0x17E8550 VA: 0x1817E9B50
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList512Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E8690 Offset: 0x17E7090 VA: 0x1817E8690
	|-FixedList512Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E7C60 Offset: 0x17E6660 VA: 0x1817E7C60
	|-FixedList512Bytes<int>.op_Equality
	|-FixedList512Bytes<float>.op_Equality
	|
	|-RVA: 0x17E8410 Offset: 0x17E6E10 VA: 0x1817E8410
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList512Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EA3F0 Offset: 0x17E8DF0 VA: 0x1817EA3F0
	|-FixedList512Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E9ED0 Offset: 0x17E88D0 VA: 0x1817E9ED0
	|-FixedList512Bytes<int>.op_Inequality
	|-FixedList512Bytes<float>.op_Inequality
	|
	|-RVA: 0x17E9F20 Offset: 0x17E8920 VA: 0x1817E9F20
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public int CompareTo(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList512Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList512Bytes<int>.CompareTo
	|-FixedList512Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA090 Offset: 0x17C8A90 VA: 0x1817CA090
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Equals(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E4CC0 Offset: 0x17E36C0 VA: 0x1817E4CC0
	|-FixedList512Bytes<byte>.Equals
	|
	|-RVA: 0x17E3EE0 Offset: 0x17E28E0 VA: 0x1817E3EE0
	|-FixedList512Bytes<int>.Equals
	|-FixedList512Bytes<float>.Equals
	|
	|-RVA: 0x17E3DE0 Offset: 0x17E27E0 VA: 0x1817E3DE0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList512Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E94B0 Offset: 0x17E7EB0 VA: 0x1817E94B0
	|-FixedList512Bytes<byte>.op_Equality
	|
	|-RVA: 0x17E7570 Offset: 0x17E5F70 VA: 0x1817E7570
	|-FixedList512Bytes<int>.op_Equality
	|-FixedList512Bytes<float>.op_Equality
	|
	|-RVA: 0x17E8B60 Offset: 0x17E7560 VA: 0x1817E8B60
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList512Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E9FB0 Offset: 0x17E89B0 VA: 0x1817E9FB0
	|-FixedList512Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17E9E80 Offset: 0x17E8880 VA: 0x1817E9E80
	|-FixedList512Bytes<int>.op_Inequality
	|-FixedList512Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D4440 Offset: 0x17D2E40 VA: 0x1817D4440
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int CompareTo(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList512Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList512Bytes<int>.CompareTo
	|-FixedList512Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9650 Offset: 0x17C8050 VA: 0x1817C9650
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Equals(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC420 Offset: 0x17CAE20 VA: 0x1817CC420
	|-FixedList512Bytes<byte>.Equals
	|
	|-RVA: 0x17CB020 Offset: 0x17C9A20 VA: 0x1817CB020
	|-FixedList512Bytes<int>.Equals
	|-FixedList512Bytes<float>.Equals
	|
	|-RVA: 0x17CB0B0 Offset: 0x17C9AB0 VA: 0x1817CB0B0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E6990 Offset: 0x17E5390 VA: 0x1817E6990
	|-FixedList512Bytes<byte>..ctor
	|
	|-RVA: 0x17E6C20 Offset: 0x17E5620 VA: 0x1817E6C20
	|-FixedList512Bytes<int>..ctor
	|-FixedList512Bytes<float>..ctor
	|
	|-RVA: 0x17E6B80 Offset: 0x17E5580 VA: 0x1817E6B80
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E5EE0 Offset: 0x17E48E0 VA: 0x1817E5EE0
	|-FixedList512Bytes<byte>.Initialize
	|
	|-RVA: 0x17E5870 Offset: 0x17E4270 VA: 0x1817E5870
	|-FixedList512Bytes<int>.Initialize
	|-FixedList512Bytes<float>.Initialize
	|
	|-RVA: 0x17E53D0 Offset: 0x17E3DD0 VA: 0x1817E53D0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList512Bytes<T> op_Implicit(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E97C0 Offset: 0x17E81C0 VA: 0x1817E97C0
	|-FixedList512Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17E9720 Offset: 0x17E8120 VA: 0x1817E9720
	|-FixedList512Bytes<int>.op_Implicit
	|-FixedList512Bytes<float>.op_Implicit
	|
	|-RVA: 0x17E9860 Offset: 0x17E8260 VA: 0x1817E9860
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E46B0 Offset: 0x17E30B0 VA: 0x1817E46B0
	|-FixedList512Bytes<byte>.Equals
	|
	|-RVA: 0x17E37D0 Offset: 0x17E21D0 VA: 0x1817E37D0
	|-FixedList512Bytes<int>.Equals
	|-FixedList512Bytes<float>.Equals
	|
	|-RVA: 0x17E3FA0 Offset: 0x17E29A0 VA: 0x1817E3FA0
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public FixedList512Bytes.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17E4D80 Offset: 0x17E3780 VA: 0x1817E4D80
	|-FixedList512Bytes<byte>.GetEnumerator
	|-FixedList512Bytes<int>.GetEnumerator
	|-FixedList512Bytes<float>.GetEnumerator
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList512Bytes<byte>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList512Bytes<int>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList512Bytes<float>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList512Bytes<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList512Bytes<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList512Bytes<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList512Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}
