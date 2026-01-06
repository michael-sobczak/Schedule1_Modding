internal struct ArraySlice<T> : IEquatable<ArraySlice<T>> // TypeDefIndex: 9166
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public T Item { get; set; }
	public int Stride { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169E1D0 Offset: 0x169CBD0 VA: 0x18169E1D0
	|-ArraySlice<int>..ctor
	|
	|-RVA: 0x169E280 Offset: 0x169CC80 VA: 0x18169E280
	|-ArraySlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ArraySlice<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105CBF0 Offset: 0x105B5F0 VA: 0x18105CBF0
	|-ArraySlice<int>.Equals
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169DDA0 Offset: 0x169C7A0 VA: 0x18169DDA0
	|-ArraySlice<int>.Equals
	|
	|-RVA: 0x169DEB0 Offset: 0x169C8B0 VA: 0x18169DEB0
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169DFF0 Offset: 0x169C9F0 VA: 0x18169DFF0
	|-ArraySlice<int>.GetHashCode
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(ArraySlice<T> left, ArraySlice<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169E520 Offset: 0x169CF20 VA: 0x18169E520
	|-ArraySlice<int>.op_Equality
	|
	|-RVA: 0x169E490 Offset: 0x169CE90 VA: 0x18169E490
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(ArraySlice<T> left, ArraySlice<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169E610 Offset: 0x169D010 VA: 0x18169E610
	|-ArraySlice<int>.op_Inequality
	|
	|-RVA: 0x169E580 Offset: 0x169CF80 VA: 0x18169E580
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1
	public static ArraySlice<T> ConvertExistingDataToArraySlice(void* dataPointer, int stride, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169DA00 Offset: 0x169C400 VA: 0x18169DA00
	|-ArraySlice<int>.ConvertExistingDataToArraySlice
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.ConvertExistingDataToArraySlice
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094720 Offset: 0x1093120 VA: 0x181094720
	|-ArraySlice<int>.get_Item
	|
	|-RVA: 0x169E370 Offset: 0x169CD70 VA: 0x18169E370
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094FF0 Offset: 0x10939F0 VA: 0x181094FF0
	|-ArraySlice<int>.set_Item
	|
	|-RVA: 0x169E670 Offset: 0x169D070 VA: 0x18169E670
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1
	internal void* GetUnsafeReadOnlyPtr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-ArraySlice<int>.GetUnsafeReadOnlyPtr
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.GetUnsafeReadOnlyPtr
	*/

	// RVA: -1 Offset: -1
	internal void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169DB40 Offset: 0x169C540 VA: 0x18169DB40
	|-ArraySlice<int>.CopyTo
	|
	|-RVA: 0x169DC20 Offset: 0x169C620 VA: 0x18169DC20
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	internal T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x169E120 Offset: 0x169CB20 VA: 0x18169E120
	|-ArraySlice<int>.ToArray
	|
	|-RVA: 0x169E010 Offset: 0x169CA10 VA: 0x18169E010
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public int get_Stride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-ArraySlice<int>.get_Stride
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.get_Stride
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	|-ArraySlice<int>.get_Length
	|-ArraySlice<__Il2CppFullySharedGenericStructType>.get_Length
	*/
}
