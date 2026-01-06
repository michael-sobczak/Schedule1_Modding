public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple // TypeDefIndex: 3759
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13411C0 Offset: 0x133FBC0 VA: 0x1813411C0
	|-ValueTuple<bool, bool, object, object>..ctor
	|
	|-RVA: 0x1341200 Offset: 0x133FC00 VA: 0x181341200
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133C4E0 Offset: 0x133AEE0 VA: 0x18133C4E0
	|-ValueTuple<bool, bool, object, object>.Equals
	|
	|-RVA: 0x1319500 Offset: 0x1317F00 VA: 0x181319500
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133C320 Offset: 0x133AD20 VA: 0x18133C320
	|-ValueTuple<bool, bool, object, object>.Equals
	|
	|-RVA: 0x133BA90 Offset: 0x133A490 VA: 0x18133BA90
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133EB70 Offset: 0x133D570 VA: 0x18133EB70
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x133E3C0 Offset: 0x133CDC0 VA: 0x18133E3C0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133F120 Offset: 0x133DB20 VA: 0x18133F120
	|-ValueTuple<bool, bool, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x133EED0 Offset: 0x133D8D0 VA: 0x18133EED0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133B040 Offset: 0x1339A40 VA: 0x18133B040
	|-ValueTuple<bool, bool, object, object>.CompareTo
	|
	|-RVA: 0x133B200 Offset: 0x1339C00 VA: 0x18133B200
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133D820 Offset: 0x133C220 VA: 0x18133D820
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x133DB60 Offset: 0x133C560 VA: 0x18133DB60
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133CB10 Offset: 0x133B510 VA: 0x18133CB10
	|-ValueTuple<bool, bool, object, object>.GetHashCode
	|
	|-RVA: 0x133CC40 Offset: 0x133B640 VA: 0x18133CC40
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133EDF0 Offset: 0x133D7F0 VA: 0x18133EDF0
	|-ValueTuple<bool, bool, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x133EE40 Offset: 0x133D840 VA: 0x18133EE40
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133C9D0 Offset: 0x133B3D0 VA: 0x18133C9D0
	|-ValueTuple<bool, bool, object, object>.GetHashCodeCore
	|
	|-RVA: 0x133C610 Offset: 0x133B010 VA: 0x18133C610
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133EDF0 Offset: 0x133D7F0 VA: 0x18133EDF0
	|-ValueTuple<bool, bool, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x133EE40 Offset: 0x133D840 VA: 0x18133EE40
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1340F60 Offset: 0x133F960 VA: 0x181340F60
	|-ValueTuple<bool, bool, object, object>.ToString
	|
	|-RVA: 0x1340230 Offset: 0x133EC30 VA: 0x181340230
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x133F310 Offset: 0x133DD10 VA: 0x18133F310
	|-ValueTuple<bool, bool, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x133F540 Offset: 0x133DF40 VA: 0x18133F540
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160
	|-ValueTuple<bool, bool, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
