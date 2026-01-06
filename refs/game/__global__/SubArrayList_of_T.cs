public struct SubArrayList<T> // TypeDefIndex: 10362
{
	// Fields
	private readonly ArrayPool<T> typePool; // 0x0
	private SubArray<T> subArray; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public T[] Array { get; }
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	|-SubArrayList<CGSpot>.get_Array
	|-SubArrayList<float>.get_Array
	|-SubArrayList<Vector3>.get_Array
	|-SubArrayList<__Il2CppFullySharedGenericType>.get_Array
	*/

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-SubArrayList<CGSpot>.get_Count
	|-SubArrayList<float>.get_Count
	|-SubArrayList<Vector3>.get_Count
	|-SubArrayList<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	|-SubArrayList<CGSpot>.set_Count
	|-SubArrayList<float>.set_Count
	|-SubArrayList<Vector3>.set_Count
	|-SubArrayList<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity, ArrayPool<T> typePool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EC880 Offset: 0x11EB280 VA: 0x1811EC880
	|-SubArrayList<CGSpot>..ctor
	|
	|-RVA: 0x11ECB60 Offset: 0x11EB560 VA: 0x1811ECB60
	|-SubArrayList<float>..ctor
	|
	|-RVA: 0x11ECA80 Offset: 0x11EB480 VA: 0x1811ECA80
	|-SubArrayList<Vector3>..ctor
	|
	|-RVA: 0x11EC960 Offset: 0x11EB360 VA: 0x1811EC960
	|-SubArrayList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EBA90 Offset: 0x11EA490 VA: 0x1811EBA90
	|-SubArrayList<CGSpot>.Add
	|
	|-RVA: 0x11EBCF0 Offset: 0x11EA6F0 VA: 0x1811EBCF0
	|-SubArrayList<float>.Add
	|
	|-RVA: 0x11EBBD0 Offset: 0x11EA5D0 VA: 0x1811EBBD0
	|-SubArrayList<Vector3>.Add
	|
	|-RVA: 0x11EBE00 Offset: 0x11EA800 VA: 0x1811EBE00
	|-SubArrayList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public SubArray<T> ToSubArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EC7F0 Offset: 0x11EB1F0 VA: 0x1811EC7F0
	|-SubArrayList<CGSpot>.ToSubArray
	|-SubArrayList<float>.ToSubArray
	|
	|-RVA: 0x11EC760 Offset: 0x11EB160 VA: 0x1811EC760
	|-SubArrayList<Vector3>.ToSubArray
	|
	|-RVA: 0x11EC690 Offset: 0x11EB090 VA: 0x1811EC690
	|-SubArrayList<__Il2CppFullySharedGenericType>.ToSubArray
	*/

	// RVA: -1 Offset: -1
	public bool Equals(SubArrayList<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EC110 Offset: 0x11EAB10 VA: 0x1811EC110
	|-SubArrayList<CGSpot>.Equals
	|-SubArrayList<float>.Equals
	|-SubArrayList<Vector3>.Equals
	|
	|-RVA: 0x11EC2C0 Offset: 0x11EACC0 VA: 0x1811EC2C0
	|-SubArrayList<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EC1A0 Offset: 0x11EABA0 VA: 0x1811EC1A0
	|-SubArrayList<CGSpot>.Equals
	|-SubArrayList<float>.Equals
	|-SubArrayList<Vector3>.Equals
	|
	|-RVA: 0x11EC400 Offset: 0x11EAE00 VA: 0x1811EC400
	|-SubArrayList<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EC550 Offset: 0x11EAF50 VA: 0x1811EC550
	|-SubArrayList<CGSpot>.GetHashCode
	|-SubArrayList<float>.GetHashCode
	|-SubArrayList<Vector3>.GetHashCode
	|
	|-RVA: 0x11EC5D0 Offset: 0x11EAFD0 VA: 0x1811EC5D0
	|-SubArrayList<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(SubArrayList<T> a, SubArrayList<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ECCD0 Offset: 0x11EB6D0 VA: 0x1811ECCD0
	|-SubArrayList<CGSpot>.op_Equality
	|-SubArrayList<float>.op_Equality
	|-SubArrayList<Vector3>.op_Equality
	|
	|-RVA: 0x11ECC40 Offset: 0x11EB640 VA: 0x1811ECC40
	|-SubArrayList<__Il2CppFullySharedGenericType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(SubArrayList<T> a, SubArrayList<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ECD30 Offset: 0x11EB730 VA: 0x1811ECD30
	|-SubArrayList<CGSpot>.op_Inequality
	|-SubArrayList<float>.op_Inequality
	|-SubArrayList<Vector3>.op_Inequality
	|
	|-RVA: 0x11ECDD0 Offset: 0x11EB7D0 VA: 0x1811ECDD0
	|-SubArrayList<__Il2CppFullySharedGenericType>.op_Inequality
	*/
}
