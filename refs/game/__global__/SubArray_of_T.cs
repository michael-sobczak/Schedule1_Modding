public struct SubArray<T> // TypeDefIndex: 10361
{
	// Fields
	public readonly T[] Array; // 0x0
	public readonly int Count; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED810 Offset: 0x11EC210 VA: 0x1811ED810
	|-SubArray<CGSpot>.get_Item
	|
	|-RVA: 0x11ED980 Offset: 0x11EC380 VA: 0x1811ED980
	|-SubArray<int>.get_Item
	|
	|-RVA: 0x11EDA40 Offset: 0x11EC440 VA: 0x1811EDA40
	|-SubArray<float>.get_Item
	|
	|-RVA: 0x11ED9B0 Offset: 0x11EC3B0 VA: 0x1811ED9B0
	|-SubArray<Vector2>.get_Item
	|
	|-RVA: 0x11ED9F0 Offset: 0x11EC3F0 VA: 0x1811ED9F0
	|-SubArray<Vector3>.get_Item
	|
	|-RVA: 0x11ED940 Offset: 0x11EC340 VA: 0x1811ED940
	|-SubArray<Vector4>.get_Item
	|
	|-RVA: 0x11ED870 Offset: 0x11EC270 VA: 0x1811ED870
	|-SubArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EDDE0 Offset: 0x11EC7E0 VA: 0x1811EDDE0
	|-SubArray<CGSpot>.set_Item
	|
	|-RVA: 0x11EDE80 Offset: 0x11EC880 VA: 0x1811EDE80
	|-SubArray<int>.set_Item
	|
	|-RVA: 0x11EDEF0 Offset: 0x11EC8F0 VA: 0x1811EDEF0
	|-SubArray<float>.set_Item
	|
	|-RVA: 0x11EDF20 Offset: 0x11EC920 VA: 0x1811EDF20
	|-SubArray<Vector2>.set_Item
	|
	|-RVA: 0x11EDE40 Offset: 0x11EC840 VA: 0x1811EDE40
	|-SubArray<Vector3>.set_Item
	|
	|-RVA: 0x11EDEB0 Offset: 0x11EC8B0 VA: 0x1811EDEB0
	|-SubArray<Vector4>.set_Item
	|
	|-RVA: 0x11EDC80 Offset: 0x11EC680 VA: 0x1811EDC80
	|-SubArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED690 Offset: 0x11EC090 VA: 0x1811ED690
	|-SubArray<CGSpot>..ctor
	|-SubArray<int>..ctor
	|-SubArray<float>..ctor
	|-SubArray<Vector2>..ctor
	|-SubArray<Vector3>..ctor
	|-SubArray<Vector4>..ctor
	|-SubArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED710 Offset: 0x11EC110 VA: 0x1811ED710
	|-SubArray<CGSpot>..ctor
	|-SubArray<int>..ctor
	|-SubArray<float>..ctor
	|-SubArray<Vector2>..ctor
	|-SubArray<Vector3>..ctor
	|-SubArray<Vector4>..ctor
	|-SubArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] CopyToArray(ArrayPool<T> arrayPool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED010 Offset: 0x11EBA10 VA: 0x1811ED010
	|-SubArray<CGSpot>.CopyToArray
	|
	|-RVA: 0x11ED0D0 Offset: 0x11EBAD0 VA: 0x1811ED0D0
	|-SubArray<int>.CopyToArray
	|
	|-RVA: 0x11ED250 Offset: 0x11EBC50 VA: 0x1811ED250
	|-SubArray<float>.CopyToArray
	|
	|-RVA: 0x11ECE90 Offset: 0x11EB890 VA: 0x1811ECE90
	|-SubArray<Vector2>.CopyToArray
	|
	|-RVA: 0x11ED190 Offset: 0x11EBB90 VA: 0x1811ED190
	|-SubArray<Vector3>.CopyToArray
	|
	|-RVA: 0x11ECF50 Offset: 0x11EB950 VA: 0x1811ECF50
	|-SubArray<Vector4>.CopyToArray
	|
	|-RVA: 0x11ED310 Offset: 0x11EBD10 VA: 0x1811ED310
	|-SubArray<__Il2CppFullySharedGenericType>.CopyToArray
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED650 Offset: 0x11EC050 VA: 0x1811ED650
	|-SubArray<CGSpot>.GetHashCode
	|-SubArray<int>.GetHashCode
	|-SubArray<float>.GetHashCode
	|-SubArray<Vector2>.GetHashCode
	|-SubArray<Vector3>.GetHashCode
	|-SubArray<Vector4>.GetHashCode
	|-SubArray<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED400 Offset: 0x11EBE00 VA: 0x1811ED400
	|-SubArray<CGSpot>.Equals
	|-SubArray<int>.Equals
	|-SubArray<float>.Equals
	|-SubArray<Vector2>.Equals
	|-SubArray<Vector3>.Equals
	|-SubArray<Vector4>.Equals
	|
	|-RVA: 0x11ED510 Offset: 0x11EBF10 VA: 0x1811ED510
	|-SubArray<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(SubArray<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11ED3E0 Offset: 0x11EBDE0 VA: 0x1811ED3E0
	|-SubArray<CGSpot>.Equals
	|-SubArray<int>.Equals
	|-SubArray<float>.Equals
	|-SubArray<Vector2>.Equals
	|-SubArray<Vector3>.Equals
	|-SubArray<Vector4>.Equals
	|-SubArray<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(SubArray<T> a, SubArray<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EDA70 Offset: 0x11EC470 VA: 0x1811EDA70
	|-SubArray<CGSpot>.op_Equality
	|-SubArray<int>.op_Equality
	|-SubArray<float>.op_Equality
	|-SubArray<Vector2>.op_Equality
	|-SubArray<Vector3>.op_Equality
	|-SubArray<Vector4>.op_Equality
	|
	|-RVA: 0x11EDAC0 Offset: 0x11EC4C0 VA: 0x1811EDAC0
	|-SubArray<__Il2CppFullySharedGenericType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(SubArray<T> a, SubArray<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EDBF0 Offset: 0x11EC5F0 VA: 0x1811EDBF0
	|-SubArray<CGSpot>.op_Inequality
	|-SubArray<int>.op_Inequality
	|-SubArray<float>.op_Inequality
	|-SubArray<Vector2>.op_Inequality
	|-SubArray<Vector3>.op_Inequality
	|-SubArray<Vector4>.op_Inequality
	|
	|-RVA: 0x11EDB50 Offset: 0x11EC550 VA: 0x1811EDB50
	|-SubArray<__Il2CppFullySharedGenericType>.op_Inequality
	*/
}
