public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple // TypeDefIndex: 3760
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134A950 Offset: 0x1349350 VA: 0x18134A950
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>..ctor
	|
	|-RVA: 0x134A8F0 Offset: 0x13492F0 VA: 0x18134A8F0
	|-ValueTuple<object, bool, bool, object, object>..ctor
	|
	|-RVA: 0x134A4C0 Offset: 0x1348EC0 VA: 0x18134A4C0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13434A0 Offset: 0x1341EA0 VA: 0x1813434A0
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.Equals
	|
	|-RVA: 0x13423C0 Offset: 0x1340DC0 VA: 0x1813423C0
	|-ValueTuple<object, bool, bool, object, object>.Equals
	|
	|-RVA: 0x1343360 Offset: 0x1341D60 VA: 0x181343360
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343150 Offset: 0x1341B50 VA: 0x181343150
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.Equals
	|
	|-RVA: 0x1342F40 Offset: 0x1341940 VA: 0x181342F40
	|-ValueTuple<object, bool, bool, object, object>.Equals
	|
	|-RVA: 0x13424E0 Offset: 0x1340EE0 VA: 0x1813424E0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13464B0 Offset: 0x1344EB0 VA: 0x1813464B0
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x13461F0 Offset: 0x1344BF0 VA: 0x1813461F0
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x13468B0 Offset: 0x13452B0 VA: 0x1813468B0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1347570 Offset: 0x1345F70 VA: 0x181347570
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.IComparable.CompareTo
	|
	|-RVA: 0x1347750 Offset: 0x1346150 VA: 0x181347750
	|-ValueTuple<object, bool, bool, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x1347320 Offset: 0x1345D20 VA: 0x181347320
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1341750 Offset: 0x1340150 VA: 0x181341750
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.CompareTo
	|
	|-RVA: 0x1341550 Offset: 0x133FF50 VA: 0x181341550
	|-ValueTuple<object, bool, bool, object, object>.CompareTo
	|
	|-RVA: 0x1341950 Offset: 0x1340350 VA: 0x181341950
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344FC0 Offset: 0x13439C0 VA: 0x181344FC0
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1345480 Offset: 0x1343E80 VA: 0x181345480
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1345800 Offset: 0x1344200 VA: 0x181345800
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1344CF0 Offset: 0x13436F0 VA: 0x181344CF0
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.GetHashCode
	|
	|-RVA: 0x1344E60 Offset: 0x1343860 VA: 0x181344E60
	|-ValueTuple<object, bool, bool, object, object>.GetHashCode
	|
	|-RVA: 0x1343DF0 Offset: 0x13427F0 VA: 0x181343DF0
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1347240 Offset: 0x1345C40 VA: 0x181347240
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x13471F0 Offset: 0x1345BF0 VA: 0x1813471F0
	|-ValueTuple<object, bool, bool, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x1347290 Offset: 0x1345C90 VA: 0x181347290
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private int GetHashCodeCore(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1343730 Offset: 0x1342130 VA: 0x181343730
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.GetHashCodeCore
	|
	|-RVA: 0x13435C0 Offset: 0x1341FC0 VA: 0x1813435C0
	|-ValueTuple<object, bool, bool, object, object>.GetHashCodeCore
	|
	|-RVA: 0x1343950 Offset: 0x1342350 VA: 0x181343950
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCodeCore
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1347240 Offset: 0x1345C40 VA: 0x181347240
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x13471F0 Offset: 0x1345BF0 VA: 0x1813471F0
	|-ValueTuple<object, bool, bool, object, object>.System.IValueTupleInternal.GetHashCode
	|
	|-RVA: 0x1347290 Offset: 0x1345C90 VA: 0x181347290
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x134A1F0 Offset: 0x1348BF0 VA: 0x18134A1F0
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.ToString
	|
	|-RVA: 0x1348E90 Offset: 0x1347890 VA: 0x181348E90
	|-ValueTuple<object, bool, bool, object, object>.ToString
	|
	|-RVA: 0x1349150 Offset: 0x1347B50 VA: 0x181349150
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1348950 Offset: 0x1347350 VA: 0x181348950
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x1348BF0 Offset: 0x13475F0 VA: 0x181348BF0
	|-ValueTuple<object, bool, bool, object, object>.System.IValueTupleInternal.ToStringEnd
	|
	|-RVA: 0x1347930 Offset: 0x1346330 VA: 0x181347930
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60
	|-ValueTuple<IntPtr, int, IntPtr, int, bool>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<object, bool, bool, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-ValueTuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
