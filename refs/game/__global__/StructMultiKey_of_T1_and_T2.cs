internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> // TypeDefIndex: 11205
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 v1, T2 v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6B0 Offset: 0x43B0B0 VA: 0x18043C6B0
	|-StructMultiKey<object, object>..ctor
	|
	|-RVA: 0x10EFFD0 Offset: 0x10EE9D0 VA: 0x1810EFFD0
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E7390 Offset: 0x11E5D90 VA: 0x1811E7390
	|-StructMultiKey<object, object>.GetHashCode
	|
	|-RVA: 0x11E7400 Offset: 0x11E5E00 VA: 0x1811E7400
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E7260 Offset: 0x11E5C60 VA: 0x1811E7260
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x11E6D40 Offset: 0x11E5740 VA: 0x1811E6D40
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StructMultiKey<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E6CF0 Offset: 0x11E56F0 VA: 0x1811E6CF0
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x11E6F20 Offset: 0x11E5920 VA: 0x1811E6F20
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/
}
