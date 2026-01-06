public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple // TypeDefIndex: 3756
{
	// Fields
	public T1 Item1; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131D950 Offset: 0x131C350 VA: 0x18131D950
	|-ValueTuple<bool>..ctor
	|
	|-RVA: 0x131D960 Offset: 0x131C360 VA: 0x18131D960
	|-ValueTuple<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B5B0 Offset: 0x1319FB0 VA: 0x18131B5B0
	|-ValueTuple<bool>.Equals
	|
	|-RVA: 0x131B920 Offset: 0x131A320 VA: 0x18131B920
	|-ValueTuple<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B540 Offset: 0x1319F40 VA: 0x18131B540
	|-ValueTuple<bool>.Equals
	|
	|-RVA: 0x131B6C0 Offset: 0x131A0C0 VA: 0x18131B6C0
	|-ValueTuple<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131C3B0 Offset: 0x131ADB0 VA: 0x18131C3B0
	|-ValueTuple<bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x131C530 Offset: 0x131AF30 VA: 0x18131C530
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131CE00 Offset: 0x131B800 VA: 0x18131CE00
	|-ValueTuple<bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x131CA00 Offset: 0x131B400 VA: 0x18131CA00
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B270 Offset: 0x1319C70 VA: 0x18131B270
	|-ValueTuple<bool>.CompareTo
	|
	|-RVA: 0x131B2E0 Offset: 0x1319CE0 VA: 0x18131B2E0
	|-ValueTuple<__Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131C170 Offset: 0x131AB70 VA: 0x18131C170
	|-ValueTuple<bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x131BDC0 Offset: 0x131A7C0 VA: 0x18131BDC0
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BD40 Offset: 0x131A740 VA: 0x18131BD40
	|-ValueTuple<bool>.GetHashCode
	|
	|-RVA: 0x131BA60 Offset: 0x131A460 VA: 0x18131BA60
	|-ValueTuple<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131C830 Offset: 0x131B230 VA: 0x18131C830
	|-ValueTuple<bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x131C8D0 Offset: 0x131B2D0 VA: 0x18131C8D0
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131D110 Offset: 0x131BB10 VA: 0x18131D110
	|-ValueTuple<bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x131CFE0 Offset: 0x131B9E0 VA: 0x18131CFE0
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131D560 Offset: 0x131BF60 VA: 0x18131D560
	|-ValueTuple<bool>.ToString
	|
	|-RVA: 0x131D620 Offset: 0x131C020 VA: 0x18131D620
	|-ValueTuple<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131D1B0 Offset: 0x131BBB0 VA: 0x18131D1B0
	|-ValueTuple<bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x131D250 Offset: 0x131BC50 VA: 0x18131D250
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	|-ValueTuple<bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
