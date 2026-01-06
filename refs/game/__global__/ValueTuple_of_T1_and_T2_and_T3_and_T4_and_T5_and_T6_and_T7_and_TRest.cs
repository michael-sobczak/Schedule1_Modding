public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple // TypeDefIndex: 3761
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
	public T6 Item6; // 0x0
	public T7 Item7; // 0x0
	public TRest Rest; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135F8E0 Offset: 0x135E2E0 VA: 0x18135F8E0
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>..ctor
	|
	|-RVA: 0x135F1B0 Offset: 0x135DBB0 VA: 0x18135F1B0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134BC80 Offset: 0x134A680 VA: 0x18134BC80
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.Equals
	|
	|-RVA: 0x134BDB0 Offset: 0x134A7B0 VA: 0x18134BDB0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134CEB0 Offset: 0x134B8B0 VA: 0x18134CEB0
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.Equals
	|
	|-RVA: 0x134BEF0 Offset: 0x134A8F0 VA: 0x18134BEF0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1357DF0 Offset: 0x13567F0 VA: 0x181357DF0
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x1356FF0 Offset: 0x13559F0 VA: 0x181356FF0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1358430 Offset: 0x1356E30 VA: 0x181358430
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.IComparable.CompareTo
	|
	|-RVA: 0x1358630 Offset: 0x1357030 VA: 0x181358630
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134B940 Offset: 0x134A340 VA: 0x18134B940
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.CompareTo
	|
	|-RVA: 0x134A970 Offset: 0x1349370 VA: 0x18134A970
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1355B00 Offset: 0x1354500 VA: 0x181355B00
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1356130 Offset: 0x1354B30 VA: 0x181356130
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134F930 Offset: 0x134E330 VA: 0x18134F930
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.GetHashCode
	|
	|-RVA: 0x1350320 Offset: 0x134ED20 VA: 0x181350320
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1358350 Offset: 0x1356D50 VA: 0x181358350
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x13583A0 Offset: 0x1356DA0 VA: 0x1813583A0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134D2F0 Offset: 0x134BCF0 VA: 0x18134D2F0
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.GetHashCodeCore
	|
	|-RVA: 0x134E070 Offset: 0x134CA70 VA: 0x18134E070
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1358350 Offset: 0x1356D50 VA: 0x181358350
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x13583A0 Offset: 0x1356DA0 VA: 0x1813583A0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135BDB0 Offset: 0x135A7B0 VA: 0x18135BDB0
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.ToString
	|
	|-RVA: 0x135C560 Offset: 0x135AF60 VA: 0x18135C560
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1358880 Offset: 0x1357280 VA: 0x181358880
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x1358FE0 Offset: 0x13579E0 VA: 0x181358FE0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x135BBC0 Offset: 0x135A5C0 VA: 0x18135BBC0
	|-ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x135BC60 Offset: 0x135A660 VA: 0x18135BC60
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
