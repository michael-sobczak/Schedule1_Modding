public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> // TypeDefIndex: 6814
{
	// Fields
	private T m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x0

	// Properties
	public T value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB250 Offset: 0x11E9C50 VA: 0x1811EB250
	|-StyleEnum<Int32Enum>.get_value
	|
	|-RVA: 0x11EB080 Offset: 0x11E9A80 VA: 0x1811EB080
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public StyleKeyword get_keyword() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB070 Offset: 0x11E9A70 VA: 0x1811EB070
	|-StyleEnum<Int32Enum>.get_keyword
	|
	|-RVA: 0x11EB020 Offset: 0x11E9A20 VA: 0x1811EB020
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.get_keyword
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EAEA0 Offset: 0x11E98A0 VA: 0x1811EAEA0
	|-StyleEnum<Int32Enum>..ctor
	|
	|-RVA: 0x11EAC20 Offset: 0x11E9620 VA: 0x1811EAC20
	|-StyleEnum<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EAE60 Offset: 0x11E9860 VA: 0x1811EAE60
	|-StyleEnum<Int32Enum>..ctor
	|
	|-RVA: 0x11EAD20 Offset: 0x11E9720 VA: 0x1811EAD20
	|-StyleEnum<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T v, StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB010 Offset: 0x11E9A10 VA: 0x1811EB010
	|-StyleEnum<Int32Enum>..ctor
	|
	|-RVA: 0x11EAEE0 Offset: 0x11E98E0 VA: 0x1811EAEE0
	|-StyleEnum<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB510 Offset: 0x11E9F10 VA: 0x1811EB510
	|-StyleEnum<Int32Enum>.op_Equality
	|
	|-RVA: 0x11EB260 Offset: 0x11E9C60 VA: 0x1811EB260
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB8E0 Offset: 0x11EA2E0 VA: 0x1811EB8E0
	|-StyleEnum<Int32Enum>.op_Inequality
	|
	|-RVA: 0x11EB960 Offset: 0x11EA360 VA: 0x1811EB960
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1
	public static StyleEnum<T> op_Implicit(StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB560 Offset: 0x11E9F60 VA: 0x1811EB560
	|-StyleEnum<Int32Enum>.op_Implicit
	|
	|-RVA: 0x11EB760 Offset: 0x11EA160 VA: 0x1811EB760
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static StyleEnum<T> op_Implicit(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EB880 Offset: 0x11EA280 VA: 0x1811EB880
	|-StyleEnum<Int32Enum>.op_Implicit
	|
	|-RVA: 0x11EB5C0 Offset: 0x11E9FC0 VA: 0x1811EB5C0
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(StyleEnum<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EA590 Offset: 0x11E8F90 VA: 0x1811EA590
	|-StyleEnum<Int32Enum>.Equals
	|
	|-RVA: 0x11EA460 Offset: 0x11E8E60 VA: 0x1811EA460
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EA610 Offset: 0x11E9010 VA: 0x1811EA610
	|-StyleEnum<Int32Enum>.Equals
	|
	|-RVA: 0x11EA720 Offset: 0x11E9120 VA: 0x1811EA720
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EAA50 Offset: 0x11E9450 VA: 0x1811EAA50
	|-StyleEnum<Int32Enum>.GetHashCode
	|
	|-RVA: 0x11EA900 Offset: 0x11E9300 VA: 0x1811EA900
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EABA0 Offset: 0x11E95A0 VA: 0x1811EABA0
	|-StyleEnum<Int32Enum>.ToString
	|
	|-RVA: 0x11EAAA0 Offset: 0x11E94A0 VA: 0x1811EAAA0
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.ToString
	*/
}
