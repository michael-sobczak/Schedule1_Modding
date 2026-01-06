public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 3741
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-Tuple<FullRank, FullRank>.get_Item1
	|-Tuple<object, Memory<char>>.get_Item1
	|-Tuple<object, char>.get_Item1
	|-Tuple<object, Color>.get_Item1
	|-Tuple<object, object>.get_Item1
	|
	|-RVA: 0x49CD30 Offset: 0x49B730 VA: 0x18049CD30
	|-Tuple<Guid, object>.get_Item1
	|
	|-RVA: 0x9B6540 Offset: 0x9B4F40 VA: 0x1809B6540
	|-Tuple<Vector3, Quaternion>.get_Item1
	|-Tuple<Vector3, Vector3>.get_Item1
	|
	|-RVA: 0xFDD930 Offset: 0xFDC330 VA: 0x180FDD930
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-Tuple<FullRank, FullRank>.get_Item2
	|-Tuple<object, object>.get_Item2
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-Tuple<Guid, object>.get_Item2
	|
	|-RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	|-Tuple<object, Memory<char>>.get_Item2
	|-Tuple<object, Color>.get_Item2
	|
	|-RVA: 0xCC6380 Offset: 0xCC4D80 VA: 0x180CC6380
	|-Tuple<object, char>.get_Item2
	|
	|-RVA: 0x9B6560 Offset: 0x9B4F60 VA: 0x1809B6560
	|-Tuple<Vector3, Quaternion>.get_Item2
	|
	|-RVA: 0x128CD80 Offset: 0x128B780 VA: 0x18128CD80
	|-Tuple<Vector3, Vector3>.get_Item2
	|
	|-RVA: 0xFCAD70 Offset: 0xFC9770 VA: 0x180FCAD70
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128CC00 Offset: 0x128B600 VA: 0x18128CC00
	|-Tuple<FullRank, FullRank>..ctor
	|
	|-RVA: 0x128CCE0 Offset: 0x128B6E0 VA: 0x18128CCE0
	|-Tuple<Guid, object>..ctor
	|
	|-RVA: 0x128CD30 Offset: 0x128B730 VA: 0x18128CD30
	|-Tuple<object, Memory<char>>..ctor
	|
	|-RVA: 0x128CBB0 Offset: 0x128B5B0 VA: 0x18128CBB0
	|-Tuple<object, char>..ctor
	|
	|-RVA: 0x128CC90 Offset: 0x128B690 VA: 0x18128CC90
	|-Tuple<object, Color>..ctor
	|
	|-RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	|-Tuple<object, object>..ctor
	|
	|-RVA: 0x128CC40 Offset: 0x128B640 VA: 0x18128CC40
	|-Tuple<Vector3, Quaternion>..ctor
	|
	|-RVA: 0x128CB60 Offset: 0x128B560 VA: 0x18128CB60
	|-Tuple<Vector3, Vector3>..ctor
	|
	|-RVA: 0xFDD7D0 Offset: 0xFDC1D0 VA: 0x180FDD7D0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12889A0 Offset: 0x12873A0 VA: 0x1812889A0
	|-Tuple<FullRank, FullRank>.Equals
	|
	|-RVA: 0x1288B20 Offset: 0x1287520 VA: 0x181288B20
	|-Tuple<Guid, object>.Equals
	|
	|-RVA: 0x1288C20 Offset: 0x1287620 VA: 0x181288C20
	|-Tuple<object, Memory<char>>.Equals
	|
	|-RVA: 0x1288920 Offset: 0x1287320 VA: 0x181288920
	|-Tuple<object, char>.Equals
	|
	|-RVA: 0x1288BA0 Offset: 0x12875A0 VA: 0x181288BA0
	|-Tuple<object, Color>.Equals
	|
	|-RVA: 0x1288A20 Offset: 0x1287420 VA: 0x181288A20
	|-Tuple<object, object>.Equals
	|
	|-RVA: 0x1288AA0 Offset: 0x12874A0 VA: 0x181288AA0
	|-Tuple<Vector3, Quaternion>.Equals
	|
	|-RVA: 0x1288CA0 Offset: 0x12876A0 VA: 0x181288CA0
	|-Tuple<Vector3, Vector3>.Equals
	|
	|-RVA: 0x12888A0 Offset: 0x12872A0 VA: 0x1812888A0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A680 Offset: 0x1289080 VA: 0x18128A680
	|-Tuple<FullRank, FullRank>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128ABE0 Offset: 0x12895E0 VA: 0x18128ABE0
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128AD30 Offset: 0x1289730 VA: 0x18128AD30
	|-Tuple<object, Memory<char>>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128AE70 Offset: 0x1289870 VA: 0x18128AE70
	|-Tuple<object, char>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128AAA0 Offset: 0x12894A0 VA: 0x18128AAA0
	|-Tuple<object, Color>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128A810 Offset: 0x1289210 VA: 0x18128A810
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128A900 Offset: 0x1289300 VA: 0x18128A900
	|-Tuple<Vector3, Quaternion>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128AFB0 Offset: 0x12899B0 VA: 0x18128AFB0
	|-Tuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x128A3B0 Offset: 0x1288DB0 VA: 0x18128A3B0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128BCC0 Offset: 0x128A6C0 VA: 0x18128BCC0
	|-Tuple<FullRank, FullRank>.System.IComparable.CompareTo
	|
	|-RVA: 0x128BB40 Offset: 0x128A540 VA: 0x18128BB40
	|-Tuple<Guid, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x128BA40 Offset: 0x128A440 VA: 0x18128BA40
	|-Tuple<object, Memory<char>>.System.IComparable.CompareTo
	|
	|-RVA: 0x128BAC0 Offset: 0x128A4C0 VA: 0x18128BAC0
	|-Tuple<object, char>.System.IComparable.CompareTo
	|
	|-RVA: 0x128BBC0 Offset: 0x128A5C0 VA: 0x18128BBC0
	|-Tuple<object, Color>.System.IComparable.CompareTo
	|
	|-RVA: 0x128BD40 Offset: 0x128A740 VA: 0x18128BD40
	|-Tuple<object, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x128B9C0 Offset: 0x128A3C0 VA: 0x18128B9C0
	|-Tuple<Vector3, Quaternion>.System.IComparable.CompareTo
	|
	|-RVA: 0x128B940 Offset: 0x128A340 VA: 0x18128B940
	|-Tuple<Vector3, Vector3>.System.IComparable.CompareTo
	|
	|-RVA: 0x128BC40 Offset: 0x128A640 VA: 0x18128BC40
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12894B0 Offset: 0x1287EB0 VA: 0x1812894B0
	|-Tuple<FullRank, FullRank>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1289FB0 Offset: 0x12889B0 VA: 0x181289FB0
	|-Tuple<Guid, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1289A20 Offset: 0x1288420 VA: 0x181289A20
	|-Tuple<object, Memory<char>>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x12892E0 Offset: 0x1287CE0 VA: 0x1812892E0
	|-Tuple<object, char>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1289110 Offset: 0x1287B10 VA: 0x181289110
	|-Tuple<object, Color>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1289E30 Offset: 0x1288830 VA: 0x181289E30
	|-Tuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x128A180 Offset: 0x1288B80 VA: 0x18128A180
	|-Tuple<Vector3, Quaternion>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x1289BF0 Offset: 0x12885F0 VA: 0x181289BF0
	|-Tuple<Vector3, Vector3>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x12896C0 Offset: 0x12880C0 VA: 0x1812896C0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1288D20 Offset: 0x1287720 VA: 0x181288D20
	|-Tuple<FullRank, FullRank>.GetHashCode
	|
	|-RVA: 0x1288E70 Offset: 0x1287870 VA: 0x181288E70
	|-Tuple<Guid, object>.GetHashCode
	|
	|-RVA: 0x1289030 Offset: 0x1287A30 VA: 0x181289030
	|-Tuple<object, Memory<char>>.GetHashCode
	|
	|-RVA: 0x1288EE0 Offset: 0x12878E0 VA: 0x181288EE0
	|-Tuple<object, char>.GetHashCode
	|
	|-RVA: 0x12890A0 Offset: 0x1287AA0 VA: 0x1812890A0
	|-Tuple<object, Color>.GetHashCode
	|
	|-RVA: 0x1288FC0 Offset: 0x12879C0 VA: 0x181288FC0
	|-Tuple<object, object>.GetHashCode
	|
	|-RVA: 0x1288E00 Offset: 0x1287800 VA: 0x181288E00
	|-Tuple<Vector3, Quaternion>.GetHashCode
	|
	|-RVA: 0x1288F50 Offset: 0x1287950 VA: 0x181288F50
	|-Tuple<Vector3, Vector3>.GetHashCode
	|
	|-RVA: 0x1288D90 Offset: 0x1287790 VA: 0x181288D90
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128B640 Offset: 0x128A040 VA: 0x18128B640
	|-Tuple<FullRank, FullRank>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B590 Offset: 0x1289F90 VA: 0x18128B590
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B410 Offset: 0x1289E10 VA: 0x18128B410
	|-Tuple<object, Memory<char>>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B170 Offset: 0x1289B70 VA: 0x18128B170
	|-Tuple<object, char>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B4D0 Offset: 0x1289ED0 VA: 0x18128B4D0
	|-Tuple<object, Color>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B710 Offset: 0x128A110 VA: 0x18128B710
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B230 Offset: 0x1289C30 VA: 0x18128B230
	|-Tuple<Vector3, Quaternion>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B320 Offset: 0x1289D20 VA: 0x18128B320
	|-Tuple<Vector3, Vector3>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x128B7A0 Offset: 0x128A1A0 VA: 0x18128B7A0
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C9B0 Offset: 0x128B3B0 VA: 0x18128C9B0
	|-Tuple<FullRank, FullRank>.ToString
	|
	|-RVA: 0x128C800 Offset: 0x128B200 VA: 0x18128C800
	|-Tuple<Guid, object>.ToString
	|
	|-RVA: 0x128C6E0 Offset: 0x128B0E0 VA: 0x18128C6E0
	|-Tuple<object, Memory<char>>.ToString
	|
	|-RVA: 0x128CA40 Offset: 0x128B440 VA: 0x18128CA40
	|-Tuple<object, char>.ToString
	|
	|-RVA: 0x128C650 Offset: 0x128B050 VA: 0x18128C650
	|-Tuple<object, Color>.ToString
	|
	|-RVA: 0x128CAD0 Offset: 0x128B4D0 VA: 0x18128CAD0
	|-Tuple<object, object>.ToString
	|
	|-RVA: 0x128C890 Offset: 0x128B290 VA: 0x18128C890
	|-Tuple<Vector3, Quaternion>.ToString
	|
	|-RVA: 0x128C770 Offset: 0x128B170 VA: 0x18128C770
	|-Tuple<Vector3, Vector3>.ToString
	|
	|-RVA: 0x128C920 Offset: 0x128B320 VA: 0x18128C920
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128C250 Offset: 0x128AC50 VA: 0x18128C250
	|-Tuple<FullRank, FullRank>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128C4E0 Offset: 0x128AEE0 VA: 0x18128C4E0
	|-Tuple<Guid, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128C410 Offset: 0x128AE10 VA: 0x18128C410
	|-Tuple<object, Memory<char>>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128BDC0 Offset: 0x128A7C0 VA: 0x18128BDC0
	|-Tuple<object, char>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128C340 Offset: 0x128AD40 VA: 0x18128C340
	|-Tuple<object, Color>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128C5B0 Offset: 0x128AFB0 VA: 0x18128C5B0
	|-Tuple<object, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128C150 Offset: 0x128AB50 VA: 0x18128C150
	|-Tuple<Vector3, Quaternion>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128BE90 Offset: 0x128A890 VA: 0x18128BE90
	|-Tuple<Vector3, Vector3>.System.ITupleInternal.ToString
	|
	|-RVA: 0x128BF90 Offset: 0x128A990 VA: 0x18128BF90
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0
	|-Tuple<FullRank, FullRank>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<Guid, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<object, Memory<char>>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<object, char>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<object, Color>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<Vector3, Quaternion>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<Vector3, Vector3>.System.Runtime.CompilerServices.ITuple.get_Length
	|-Tuple<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}
