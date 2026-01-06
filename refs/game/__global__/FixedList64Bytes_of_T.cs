public struct FixedList64Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> // TypeDefIndex: 15766
{
	// Fields
	[SerializeField]
	internal ushort length; // 0x0
	[SerializeField]
	internal FixedBytes62 buffer; // 0x0

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
	|-FixedList64Bytes<byte>.get_Length
	|-FixedList64Bytes<int>.get_Length
	|-FixedList64Bytes<float>.get_Length
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void set_Length(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	|-FixedList64Bytes<byte>.set_Length
	|-FixedList64Bytes<int>.set_Length
	|-FixedList64Bytes<float>.set_Length
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<T> get_Elements() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1180 Offset: 0x17CFB80 VA: 0x1817D1180
	|-FixedList64Bytes<byte>.get_Elements
	|
	|-RVA: 0x17D10D0 Offset: 0x17CFAD0 VA: 0x1817D10D0
	|-FixedList64Bytes<int>.get_Elements
	|-FixedList64Bytes<float>.get_Elements
	|
	|-RVA: 0x17D1110 Offset: 0x17CFB10 VA: 0x1817D1110
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_Elements
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D11C0 Offset: 0x17CFBC0 VA: 0x1817D11C0
	|-FixedList64Bytes<byte>.get_IsEmpty
	|-FixedList64Bytes<int>.get_IsEmpty
	|-FixedList64Bytes<float>.get_IsEmpty
	|
	|-RVA: 0x17D11F0 Offset: 0x17CFBF0 VA: 0x1817D11F0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal int get_LengthInBytes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D15C0 Offset: 0x17CFFC0 VA: 0x1817D15C0
	|-FixedList64Bytes<byte>.get_LengthInBytes
	|
	|-RVA: 0x17D16D0 Offset: 0x17D00D0 VA: 0x1817D16D0
	|-FixedList64Bytes<int>.get_LengthInBytes
	|-FixedList64Bytes<float>.get_LengthInBytes
	|
	|-RVA: 0x17D1610 Offset: 0x17D0010 VA: 0x1817D1610
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_LengthInBytes
	*/

	// RVA: -1 Offset: -1
	internal byte* get_Buffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D0F50 Offset: 0x17CF950 VA: 0x1817D0F50
	|-FixedList64Bytes<byte>.get_Buffer
	|
	|-RVA: 0x17D0F10 Offset: 0x17CF910 VA: 0x1817D0F10
	|-FixedList64Bytes<int>.get_Buffer
	|-FixedList64Bytes<float>.get_Buffer
	|
	|-RVA: 0x17D0F90 Offset: 0x17CF990 VA: 0x1817D0F90
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_Buffer
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB8A0 Offset: 0x17EA2A0 VA: 0x1817EB8A0
	|-FixedList64Bytes<byte>.get_Capacity
	|
	|-RVA: 0x17FE900 Offset: 0x17FD300 VA: 0x1817FE900
	|-FixedList64Bytes<int>.get_Capacity
	|-FixedList64Bytes<float>.get_Capacity
	|
	|-RVA: 0x17D1070 Offset: 0x17CFA70 VA: 0x1817D1070
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-FixedList64Bytes<byte>.set_Capacity
	|-FixedList64Bytes<int>.set_Capacity
	|-FixedList64Bytes<float>.set_Capacity
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D1480 Offset: 0x17CFE80 VA: 0x1817D1480
	|-FixedList64Bytes<byte>.get_Item
	|
	|-RVA: 0x17D1520 Offset: 0x17CFF20 VA: 0x1817D1520
	|-FixedList64Bytes<int>.get_Item
	|
	|-RVA: 0x17D13E0 Offset: 0x17CFDE0 VA: 0x1817D13E0
	|-FixedList64Bytes<float>.get_Item
	|
	|-RVA: 0x17D1270 Offset: 0x17CFC70 VA: 0x1817D1270
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D4AB0 Offset: 0x17D34B0 VA: 0x1817D4AB0
	|-FixedList64Bytes<byte>.set_Item
	|
	|-RVA: 0x17D4C10 Offset: 0x17D3610 VA: 0x1817D4C10
	|-FixedList64Bytes<int>.set_Item
	|
	|-RVA: 0x17D4B60 Offset: 0x17D3560 VA: 0x1817D4B60
	|-FixedList64Bytes<float>.set_Item
	|
	|-RVA: 0x17D4940 Offset: 0x17D3340 VA: 0x1817D4940
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public ref T ElementAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CA710 Offset: 0x17C9110 VA: 0x1817CA710
	|-FixedList64Bytes<byte>.ElementAt
	|
	|-RVA: 0x17CA5B0 Offset: 0x17C8FB0 VA: 0x1817CA5B0
	|-FixedList64Bytes<int>.ElementAt
	|-FixedList64Bytes<float>.ElementAt
	|
	|-RVA: 0x17CA640 Offset: 0x17C9040 VA: 0x1817CA640
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.ElementAt
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC6D0 Offset: 0x17CB0D0 VA: 0x1817CC6D0
	|-FixedList64Bytes<byte>.GetHashCode
	|
	|-RVA: 0x17CC530 Offset: 0x17CAF30 VA: 0x1817CC530
	|-FixedList64Bytes<int>.GetHashCode
	|-FixedList64Bytes<float>.GetHashCode
	|
	|-RVA: 0x17CC600 Offset: 0x17CB000 VA: 0x1817CC600
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void Add(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9500 Offset: 0x17C7F00 VA: 0x1817C9500
	|-FixedList64Bytes<byte>.Add
	|
	|-RVA: 0x17C92B0 Offset: 0x17C7CB0 VA: 0x1817C92B0
	|-FixedList64Bytes<int>.Add
	|
	|-RVA: 0x17C9210 Offset: 0x17C7C10 VA: 0x1817C9210
	|-FixedList64Bytes<float>.Add
	|
	|-RVA: 0x17C9350 Offset: 0x17C7D50 VA: 0x1817C9350
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8C80 Offset: 0x17C7680 VA: 0x1817C8C80
	|-FixedList64Bytes<byte>.AddRange
	|
	|-RVA: 0x17C90D0 Offset: 0x17C7AD0 VA: 0x1817C90D0
	|-FixedList64Bytes<int>.AddRange
	|
	|-RVA: 0x17C8F90 Offset: 0x17C7990 VA: 0x1817C8F90
	|-FixedList64Bytes<float>.AddRange
	|
	|-RVA: 0x17C8DC0 Offset: 0x17C77C0 VA: 0x1817C8DC0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void AddNoResize(in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8A20 Offset: 0x17C7420 VA: 0x1817C8A20
	|-FixedList64Bytes<byte>.AddNoResize
	|
	|-RVA: 0x17C8940 Offset: 0x17C7340 VA: 0x1817C8940
	|-FixedList64Bytes<int>.AddNoResize
	|
	|-RVA: 0x17C8A70 Offset: 0x17C7470 VA: 0x1817C8A70
	|-FixedList64Bytes<float>.AddNoResize
	|
	|-RVA: 0x17C8990 Offset: 0x17C7390 VA: 0x1817C8990
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.AddNoResize
	*/

	// RVA: -1 Offset: -1
	public void AddRangeNoResize(void* ptr, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C8BC0 Offset: 0x17C75C0 VA: 0x1817C8BC0
	|-FixedList64Bytes<byte>.AddRangeNoResize
	|
	|-RVA: 0x17C8C20 Offset: 0x17C7620 VA: 0x1817C8C20
	|-FixedList64Bytes<int>.AddRangeNoResize
	|
	|-RVA: 0x17C8B60 Offset: 0x17C7560 VA: 0x1817C8B60
	|-FixedList64Bytes<float>.AddRangeNoResize
	|
	|-RVA: 0x17C8AC0 Offset: 0x17C74C0 VA: 0x1817C8AC0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.AddRangeNoResize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C95A0 Offset: 0x17C7FA0 VA: 0x1817C95A0
	|-FixedList64Bytes<byte>.Clear
	|-FixedList64Bytes<int>.Clear
	|-FixedList64Bytes<float>.Clear
	|
	|-RVA: 0x17C95D0 Offset: 0x17C7FD0 VA: 0x1817C95D0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void InsertRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE4F0 Offset: 0x17CCEF0 VA: 0x1817CE4F0
	|-FixedList64Bytes<byte>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE870 Offset: 0x17CD270 VA: 0x1817CE870
	|-FixedList64Bytes<int>.InsertRangeWithBeginEnd
	|-FixedList64Bytes<float>.InsertRangeWithBeginEnd
	|
	|-RVA: 0x17CE620 Offset: 0x17CD020 VA: 0x1817CE620
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.InsertRangeWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, in T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CE9C0 Offset: 0x17CD3C0 VA: 0x1817CE9C0
	|-FixedList64Bytes<byte>.Insert
	|
	|-RVA: 0x17CEA60 Offset: 0x17CD460 VA: 0x1817CEA60
	|-FixedList64Bytes<int>.Insert
	|
	|-RVA: 0x17CEB00 Offset: 0x17CD500 VA: 0x1817CEB00
	|-FixedList64Bytes<float>.Insert
	|
	|-RVA: 0x17CEBB0 Offset: 0x17CD5B0 VA: 0x1817CEBB0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveAtSwapBack(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEE00 Offset: 0x17CD800 VA: 0x1817CEE00
	|-FixedList64Bytes<byte>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED20 Offset: 0x17CD720 VA: 0x1817CED20
	|-FixedList64Bytes<int>.RemoveAtSwapBack
	|-FixedList64Bytes<float>.RemoveAtSwapBack
	|
	|-RVA: 0x17CED70 Offset: 0x17CD770 VA: 0x1817CED70
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.RemoveAtSwapBack
	*/

	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBack(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF0E0 Offset: 0x17CDAE0 VA: 0x1817CF0E0
	|-FixedList64Bytes<byte>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF250 Offset: 0x17CDC50 VA: 0x1817CF250
	|-FixedList64Bytes<int>.RemoveRangeSwapBack
	|-FixedList64Bytes<float>.RemoveRangeSwapBack
	|
	|-RVA: 0x17CF3E0 Offset: 0x17CDDE0 VA: 0x1817CF3E0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBack
	*/

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF020 Offset: 0x17CDA20 VA: 0x1817CF020
	|-FixedList64Bytes<byte>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CF080 Offset: 0x17CDA80 VA: 0x1817CF080
	|-FixedList64Bytes<int>.RemoveRangeSwapBackWithBeginEnd
	|-FixedList64Bytes<float>.RemoveRangeSwapBackWithBeginEnd
	|
	|-RVA: 0x17CEF80 Offset: 0x17CD980 VA: 0x1817CEF80
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeSwapBackWithBeginEnd
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CEEE0 Offset: 0x17CD8E0 VA: 0x1817CEEE0
	|-FixedList64Bytes<byte>.RemoveAt
	|
	|-RVA: 0x17CEF30 Offset: 0x17CD930 VA: 0x1817CEF30
	|-FixedList64Bytes<int>.RemoveAt
	|-FixedList64Bytes<float>.RemoveAt
	|
	|-RVA: 0x17CEE50 Offset: 0x17CD850 VA: 0x1817CEE50
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFC10 Offset: 0x17CE610 VA: 0x1817CFC10
	|-FixedList64Bytes<byte>.RemoveRange
	|
	|-RVA: 0x17CFA80 Offset: 0x17CE480 VA: 0x1817CFA80
	|-FixedList64Bytes<int>.RemoveRange
	|-FixedList64Bytes<float>.RemoveRange
	|
	|-RVA: 0x17CF7E0 Offset: 0x17CE1E0 VA: 0x1817CF7E0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.RemoveRange
	*/

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", False)]
	// RVA: -1 Offset: -1
	public void RemoveRangeWithBeginEnd(int begin, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CF6E0 Offset: 0x17CE0E0 VA: 0x1817CF6E0
	|-FixedList64Bytes<byte>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF680 Offset: 0x17CE080 VA: 0x1817CF680
	|-FixedList64Bytes<int>.RemoveRangeWithBeginEnd
	|-FixedList64Bytes<float>.RemoveRangeWithBeginEnd
	|
	|-RVA: 0x17CF740 Offset: 0x17CE140 VA: 0x1817CF740
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.RemoveRangeWithBeginEnd
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CFEE0 Offset: 0x17CE8E0 VA: 0x1817CFEE0
	|-FixedList64Bytes<byte>.ToArray
	|
	|-RVA: 0x17CFD80 Offset: 0x17CE780 VA: 0x1817CFD80
	|-FixedList64Bytes<int>.ToArray
	|-FixedList64Bytes<float>.ToArray
	|
	|-RVA: 0x17D0040 Offset: 0x17CEA40 VA: 0x1817D0040
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D01D0 Offset: 0x17CEBD0 VA: 0x1817D01D0
	|-FixedList64Bytes<byte>.ToNativeArray
	|
	|-RVA: 0x17D0350 Offset: 0x17CED50 VA: 0x1817D0350
	|-FixedList64Bytes<int>.ToNativeArray
	|
	|-RVA: 0x17D06D0 Offset: 0x17CF0D0 VA: 0x1817D06D0
	|-FixedList64Bytes<float>.ToNativeArray
	|
	|-RVA: 0x17D04E0 Offset: 0x17CEEE0 VA: 0x1817D04E0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.ToNativeArray
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList64Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC090 Offset: 0x17EAA90 VA: 0x1817EC090
	|-FixedList64Bytes<byte>.op_Equality
	|
	|-RVA: 0x17FF0D0 Offset: 0x17FDAD0 VA: 0x1817FF0D0
	|-FixedList64Bytes<int>.op_Equality
	|-FixedList64Bytes<float>.op_Equality
	|
	|-RVA: 0x17FF850 Offset: 0x17FE250 VA: 0x1817FF850
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList64Bytes<T> a, in FixedList32Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC7A0 Offset: 0x17EB1A0 VA: 0x1817EC7A0
	|-FixedList64Bytes<byte>.op_Inequality
	|
	|-RVA: 0x17FFFD0 Offset: 0x17FE9D0 VA: 0x1817FFFD0
	|-FixedList64Bytes<int>.op_Inequality
	|-FixedList64Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D45C0 Offset: 0x17D2FC0 VA: 0x1817D45C0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int CompareTo(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList64Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList64Bytes<int>.CompareTo
	|-FixedList64Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9A30 Offset: 0x17C8430 VA: 0x1817C9A30
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Equals(FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC1F0 Offset: 0x17CABF0 VA: 0x1817CC1F0
	|-FixedList64Bytes<byte>.Equals
	|
	|-RVA: 0x17CAED0 Offset: 0x17C98D0 VA: 0x1817CAED0
	|-FixedList64Bytes<int>.Equals
	|-FixedList64Bytes<float>.Equals
	|
	|-RVA: 0x17CAE30 Offset: 0x17C9830 VA: 0x1817CAE30
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB7E0 Offset: 0x17EA1E0 VA: 0x1817EB7E0
	|-FixedList64Bytes<byte>..ctor
	|
	|-RVA: 0x17FE7A0 Offset: 0x17FD1A0 VA: 0x1817FE7A0
	|-FixedList64Bytes<int>..ctor
	|-FixedList64Bytes<float>..ctor
	|
	|-RVA: 0x17FE500 Offset: 0x17FCF00 VA: 0x1817FE500
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB080 Offset: 0x17E9A80 VA: 0x1817EB080
	|-FixedList64Bytes<byte>.Initialize
	|
	|-RVA: 0x17FDC20 Offset: 0x17FC620 VA: 0x1817FDC20
	|-FixedList64Bytes<int>.Initialize
	|-FixedList64Bytes<float>.Initialize
	|
	|-RVA: 0x17FE060 Offset: 0x17FCA60 VA: 0x1817FE060
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList64Bytes<T> op_Implicit(in FixedList32Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC370 Offset: 0x17EAD70 VA: 0x1817EC370
	|-FixedList64Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17FFCD0 Offset: 0x17FE6D0 VA: 0x1817FFCD0
	|-FixedList64Bytes<int>.op_Implicit
	|-FixedList64Bytes<float>.op_Implicit
	|
	|-RVA: 0x17FFD70 Offset: 0x17FE770 VA: 0x1817FFD70
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList64Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EBAB0 Offset: 0x17EA4B0 VA: 0x1817EBAB0
	|-FixedList64Bytes<byte>.op_Equality
	|
	|-RVA: 0x17FF680 Offset: 0x17FE080 VA: 0x1817FF680
	|-FixedList64Bytes<int>.op_Equality
	|-FixedList64Bytes<float>.op_Equality
	|
	|-RVA: 0x17FFA10 Offset: 0x17FE410 VA: 0x1817FFA10
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList64Bytes<T> a, in FixedList64Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC4B0 Offset: 0x17EAEB0 VA: 0x1817EC4B0
	|-FixedList64Bytes<byte>.op_Inequality
	|
	|-RVA: 0x18001A0 Offset: 0x17FEBA0 VA: 0x1818001A0
	|-FixedList64Bytes<int>.op_Inequality
	|-FixedList64Bytes<float>.op_Inequality
	|
	|-RVA: 0x1800110 Offset: 0x17FEB10 VA: 0x181800110
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public int CompareTo(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList64Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList64Bytes<int>.CompareTo
	|-FixedList64Bytes<float>.CompareTo
	|
	|-RVA: 0x17CA090 Offset: 0x17C8A90 VA: 0x1817CA090
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Equals(FixedList64Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EAD50 Offset: 0x17E9750 VA: 0x1817EAD50
	|-FixedList64Bytes<byte>.Equals
	|
	|-RVA: 0x17FC490 Offset: 0x17FAE90 VA: 0x1817FC490
	|-FixedList64Bytes<int>.Equals
	|-FixedList64Bytes<float>.Equals
	|
	|-RVA: 0x17FC3E0 Offset: 0x17FADE0 VA: 0x1817FC3E0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList64Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB8D0 Offset: 0x17EA2D0 VA: 0x1817EB8D0
	|-FixedList64Bytes<byte>.op_Equality
	|
	|-RVA: 0x17FE930 Offset: 0x17FD330 VA: 0x1817FE930
	|-FixedList64Bytes<int>.op_Equality
	|-FixedList64Bytes<float>.op_Equality
	|
	|-RVA: 0x17FEED0 Offset: 0x17FD8D0 VA: 0x1817FEED0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList64Bytes<T> a, in FixedList128Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC5A0 Offset: 0x17EAFA0 VA: 0x1817EC5A0
	|-FixedList64Bytes<byte>.op_Inequality
	|
	|-RVA: 0x1800020 Offset: 0x17FEA20 VA: 0x181800020
	|-FixedList64Bytes<int>.op_Inequality
	|-FixedList64Bytes<float>.op_Inequality
	|
	|-RVA: 0x17DC400 Offset: 0x17DAE00 VA: 0x1817DC400
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int CompareTo(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList64Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList64Bytes<int>.CompareTo
	|-FixedList64Bytes<float>.CompareTo
	|
	|-RVA: 0x17D8D90 Offset: 0x17D7790 VA: 0x1817D8D90
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Equals(FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17D5B70 Offset: 0x17D4570 VA: 0x1817D5B70
	|-FixedList64Bytes<byte>.Equals
	|
	|-RVA: 0x17D4DA0 Offset: 0x17D37A0 VA: 0x1817D4DA0
	|-FixedList64Bytes<int>.Equals
	|-FixedList64Bytes<float>.Equals
	|
	|-RVA: 0x17D9B20 Offset: 0x17D8520 VA: 0x1817D9B20
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB840 Offset: 0x17EA240 VA: 0x1817EB840
	|-FixedList64Bytes<byte>..ctor
	|
	|-RVA: 0x17FE800 Offset: 0x17FD200 VA: 0x1817FE800
	|-FixedList64Bytes<int>..ctor
	|-FixedList64Bytes<float>..ctor
	|
	|-RVA: 0x17FE700 Offset: 0x17FD100 VA: 0x1817FE700
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EAE40 Offset: 0x17E9840 VA: 0x1817EAE40
	|-FixedList64Bytes<byte>.Initialize
	|
	|-RVA: 0x17FD700 Offset: 0x17FC100 VA: 0x1817FD700
	|-FixedList64Bytes<int>.Initialize
	|-FixedList64Bytes<float>.Initialize
	|
	|-RVA: 0x17FD460 Offset: 0x17FBE60 VA: 0x1817FD460
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList64Bytes<T> op_Implicit(in FixedList128Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC230 Offset: 0x17EAC30 VA: 0x1817EC230
	|-FixedList64Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17FFED0 Offset: 0x17FE8D0 VA: 0x1817FFED0
	|-FixedList64Bytes<int>.op_Implicit
	|-FixedList64Bytes<float>.op_Implicit
	|
	|-RVA: 0x17FFBD0 Offset: 0x17FE5D0 VA: 0x1817FFBD0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList64Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EBC80 Offset: 0x17EA680 VA: 0x1817EBC80
	|-FixedList64Bytes<byte>.op_Equality
	|
	|-RVA: 0x17FEB10 Offset: 0x17FD510 VA: 0x1817FEB10
	|-FixedList64Bytes<int>.op_Equality
	|-FixedList64Bytes<float>.op_Equality
	|
	|-RVA: 0x17FF280 Offset: 0x17FDC80 VA: 0x1817FF280
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList64Bytes<T> a, in FixedList512Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC500 Offset: 0x17EAF00 VA: 0x1817EC500
	|-FixedList64Bytes<byte>.op_Inequality
	|
	|-RVA: 0x18000C0 Offset: 0x17FEAC0 VA: 0x1818000C0
	|-FixedList64Bytes<int>.op_Inequality
	|-FixedList64Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D3F10 Offset: 0x17D2910 VA: 0x1817D3F10
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public int CompareTo(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList64Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList64Bytes<int>.CompareTo
	|-FixedList64Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9E00 Offset: 0x17C8800 VA: 0x1817C9E00
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Equals(FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC260 Offset: 0x17CAC60 VA: 0x1817CC260
	|-FixedList64Bytes<byte>.Equals
	|
	|-RVA: 0x17CBEA0 Offset: 0x17CA8A0 VA: 0x1817CBEA0
	|-FixedList64Bytes<int>.Equals
	|-FixedList64Bytes<float>.Equals
	|
	|-RVA: 0x17CC320 Offset: 0x17CAD20 VA: 0x1817CC320
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB780 Offset: 0x17EA180 VA: 0x1817EB780
	|-FixedList64Bytes<byte>..ctor
	|
	|-RVA: 0x17FE5A0 Offset: 0x17FCFA0 VA: 0x1817FE5A0
	|-FixedList64Bytes<int>..ctor
	|-FixedList64Bytes<float>..ctor
	|
	|-RVA: 0x17FE860 Offset: 0x17FD260 VA: 0x1817FE860
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB480 Offset: 0x17E9E80 VA: 0x1817EB480
	|-FixedList64Bytes<byte>.Initialize
	|
	|-RVA: 0x17FDDE0 Offset: 0x17FC7E0 VA: 0x1817FDDE0
	|-FixedList64Bytes<int>.Initialize
	|-FixedList64Bytes<float>.Initialize
	|
	|-RVA: 0x17FD940 Offset: 0x17FC340 VA: 0x1817FD940
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList64Bytes<T> op_Implicit(in FixedList512Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC410 Offset: 0x17EAE10 VA: 0x1817EC410
	|-FixedList64Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17FFDD0 Offset: 0x17FE7D0 VA: 0x1817FFDD0
	|-FixedList64Bytes<int>.op_Implicit
	|-FixedList64Bytes<float>.op_Implicit
	|
	|-RVA: 0x17FFE70 Offset: 0x17FE870 VA: 0x1817FFE70
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(in FixedList64Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EBEB0 Offset: 0x17EA8B0 VA: 0x1817EBEB0
	|-FixedList64Bytes<byte>.op_Equality
	|
	|-RVA: 0x17FED20 Offset: 0x17FD720 VA: 0x1817FED20
	|-FixedList64Bytes<int>.op_Equality
	|-FixedList64Bytes<float>.op_Equality
	|
	|-RVA: 0x17FF4B0 Offset: 0x17FDEB0 VA: 0x1817FF4B0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(in FixedList64Bytes<T> a, in FixedList4096Bytes<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC550 Offset: 0x17EAF50 VA: 0x1817EC550
	|-FixedList64Bytes<byte>.op_Inequality
	|
	|-RVA: 0x1800070 Offset: 0x17FEA70 VA: 0x181800070
	|-FixedList64Bytes<int>.op_Inequality
	|-FixedList64Bytes<float>.op_Inequality
	|
	|-RVA: 0x17D4440 Offset: 0x17D2E40 VA: 0x1817D4440
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int CompareTo(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C9CC0 Offset: 0x17C86C0 VA: 0x1817C9CC0
	|-FixedList64Bytes<byte>.CompareTo
	|
	|-RVA: 0x17C98E0 Offset: 0x17C82E0 VA: 0x1817C98E0
	|-FixedList64Bytes<int>.CompareTo
	|-FixedList64Bytes<float>.CompareTo
	|
	|-RVA: 0x17C9650 Offset: 0x17C8050 VA: 0x1817C9650
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Equals(FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17CC420 Offset: 0x17CAE20 VA: 0x1817CC420
	|-FixedList64Bytes<byte>.Equals
	|
	|-RVA: 0x17CB020 Offset: 0x17C9A20 VA: 0x1817CB020
	|-FixedList64Bytes<int>.Equals
	|-FixedList64Bytes<float>.Equals
	|
	|-RVA: 0x17CB0B0 Offset: 0x17C9AB0 VA: 0x1817CB0B0
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void .ctor(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB720 Offset: 0x17EA120 VA: 0x1817EB720
	|-FixedList64Bytes<byte>..ctor
	|
	|-RVA: 0x17FE6A0 Offset: 0x17FD0A0 VA: 0x1817FE6A0
	|-FixedList64Bytes<int>..ctor
	|-FixedList64Bytes<float>..ctor
	|
	|-RVA: 0x17FE600 Offset: 0x17FD000 VA: 0x1817FE600
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int Initialize(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EB240 Offset: 0x17E9C40 VA: 0x1817EB240
	|-FixedList64Bytes<byte>.Initialize
	|
	|-RVA: 0x17FD240 Offset: 0x17FBC40 VA: 0x1817FD240
	|-FixedList64Bytes<int>.Initialize
	|-FixedList64Bytes<float>.Initialize
	|
	|-RVA: 0x17FE290 Offset: 0x17FCC90 VA: 0x1817FE290
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static FixedList64Bytes<T> op_Implicit(in FixedList4096Bytes<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EC2D0 Offset: 0x17EACD0 VA: 0x1817EC2D0
	|-FixedList64Bytes<byte>.op_Implicit
	|
	|-RVA: 0x17FFC30 Offset: 0x17FE630 VA: 0x1817FFC30
	|-FixedList64Bytes<int>.op_Implicit
	|-FixedList64Bytes<float>.op_Implicit
	|
	|-RVA: 0x17FFF70 Offset: 0x17FE970 VA: 0x1817FFF70
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EA740 Offset: 0x17E9140 VA: 0x1817EA740
	|-FixedList64Bytes<byte>.Equals
	|
	|-RVA: 0x17FC510 Offset: 0x17FAF10 VA: 0x1817FC510
	|-FixedList64Bytes<int>.Equals
	|-FixedList64Bytes<float>.Equals
	|
	|-RVA: 0x17FCB20 Offset: 0x17FB520 VA: 0x1817FCB20
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public FixedList64Bytes.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17EADD0 Offset: 0x17E97D0 VA: 0x1817EADD0
	|-FixedList64Bytes<byte>.GetEnumerator
	|-FixedList64Bytes<int>.GetEnumerator
	|-FixedList64Bytes<float>.GetEnumerator
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList64Bytes<byte>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList64Bytes<int>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList64Bytes<float>.System.Collections.IEnumerable.GetEnumerator
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-FixedList64Bytes<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList64Bytes<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList64Bytes<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-FixedList64Bytes<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}
