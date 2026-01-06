public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 3742
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-Tuple<FullRank, int, int>.get_Item1
	|-Tuple<object, Memory<byte>, object>.get_Item1
	|-Tuple<object, object, object>.get_Item1
	|
	|-RVA: 0xFDD930 Offset: 0xFDC330 VA: 0x180FDD930
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-Tuple<FullRank, int, int>.get_Item2
	|
	|-RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	|-Tuple<object, Memory<byte>, object>.get_Item2
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-Tuple<object, object, object>.get_Item2
	|
	|-RVA: 0xFCAD70 Offset: 0xFC9770 VA: 0x180FCAD70
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	|-Tuple<FullRank, int, int>.get_Item3
	|
	|-RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	|-Tuple<object, Memory<byte>, object>.get_Item3
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-Tuple<object, object, object>.get_Item3
	|
	|-RVA: 0xFDF5A0 Offset: 0xFDDFA0 VA: 0x180FDF5A0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F290 Offset: 0x128DC90 VA: 0x18128F290
	|-Tuple<FullRank, int, int>..ctor
	|
	|-RVA: 0x128F4D0 Offset: 0x128DED0 VA: 0x18128F4D0
	|-Tuple<object, Memory<byte>, object>..ctor
	|
	|-RVA: 0x43EE90 Offset: 0x43D890 VA: 0x18043EE90
	|-Tuple<object, object, object>..ctor
	|
	|-RVA: 0x128F2E0 Offset: 0x128DCE0 VA: 0x18128F2E0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CF20 Offset: 0x128B920 VA: 0x18128CF20
	|-Tuple<FullRank, int, int>.Equals
	|
	|-RVA: 0x128CDA0 Offset: 0x128B7A0 VA: 0x18128CDA0
	|-Tuple<object, Memory<byte>, object>.Equals
	|
	|-RVA: 0x128CEA0 Offset: 0x128B8A0 VA: 0x18128CEA0
	|-Tuple<object, object, object>.Equals
	|
	|-RVA: 0x128CE20 Offset: 0x128B820 VA: 0x18128CE20
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128DD10 Offset: 0x128C710 VA: 0x18128DD10
	|-Tuple<FullRank, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128E2D0 Offset: 0x128CCD0 VA: 0x18128E2D0
	|-Tuple<object, Memory<byte>, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128DC00 Offset: 0x128C600 VA: 0x18128DC00
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128DEF0 Offset: 0x128C8F0 VA: 0x18128DEF0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128EA30 Offset: 0x128D430 VA: 0x18128EA30
	|-Tuple<FullRank, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x128E9B0 Offset: 0x128D3B0 VA: 0x18128E9B0
	|-Tuple<object, Memory<byte>, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x128E930 Offset: 0x128D330 VA: 0x18128E930
	|-Tuple<object, object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x128EAB0 Offset: 0x128D4B0 VA: 0x18128EAB0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D160 Offset: 0x128BB60 VA: 0x18128D160
	|-Tuple<FullRank, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x128DA00 Offset: 0x128C400 VA: 0x18128DA00
	|-Tuple<object, Memory<byte>, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x128D3E0 Offset: 0x128BDE0 VA: 0x18128D3E0
	|-Tuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x128D590 Offset: 0x128BF90 VA: 0x18128D590
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128D0F0 Offset: 0x128BAF0 VA: 0x18128D0F0
	|-Tuple<FullRank, int, int>.GetHashCode
	|
	|-RVA: 0x128D080 Offset: 0x128BA80 VA: 0x18128D080
	|-Tuple<object, Memory<byte>, object>.GetHashCode
	|
	|-RVA: 0x128CFA0 Offset: 0x128B9A0 VA: 0x18128CFA0
	|-Tuple<object, object, object>.GetHashCode
	|
	|-RVA: 0x128D010 Offset: 0x128BA10 VA: 0x18128D010
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128E730 Offset: 0x128D130 VA: 0x18128E730
	|-Tuple<FullRank, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128E850 Offset: 0x128D250 VA: 0x18128E850
	|-Tuple<object, Memory<byte>, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128E680 Offset: 0x128D080 VA: 0x18128E680
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128E440 Offset: 0x128CE40 VA: 0x18128E440
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F050 Offset: 0x128DA50 VA: 0x18128F050
	|-Tuple<FullRank, int, int>.ToString
	|
	|-RVA: 0x128F200 Offset: 0x128DC00 VA: 0x18128F200
	|-Tuple<object, Memory<byte>, object>.ToString
	|
	|-RVA: 0x128F170 Offset: 0x128DB70 VA: 0x18128F170
	|-Tuple<object, object, object>.ToString
	|
	|-RVA: 0x128F0E0 Offset: 0x128DAE0 VA: 0x18128F0E0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128EF30 Offset: 0x128D930 VA: 0x18128EF30
	|-Tuple<FullRank, int, int>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128EE40 Offset: 0x128D840 VA: 0x18128EE40
	|-Tuple<object, Memory<byte>, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128ED80 Offset: 0x128D780 VA: 0x18128ED80
	|-Tuple<object, object, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128EB30 Offset: 0x128D530 VA: 0x18128EB30
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x583670 Offset: 0x582070 VA: 0x180583670
	|-Tuple<FullRank, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<object, Memory<byte>, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
