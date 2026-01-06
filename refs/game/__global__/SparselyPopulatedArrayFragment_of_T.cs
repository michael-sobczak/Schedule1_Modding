internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 3950
{
	// Fields
	internal readonly T[] _elements; // 0x0
	internal int _freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> _next; // 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E0C60 Offset: 0x11DF660 VA: 0x1811E0C60
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E0C80 Offset: 0x11DF680 VA: 0x1811E0C80
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E0D20 Offset: 0x11DF720 VA: 0x1811E0D20
	|-SparselyPopulatedArrayFragment<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-SparselyPopulatedArrayFragment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E0D60 Offset: 0x11DF760 VA: 0x1811E0D60
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E0BE0 Offset: 0x11DF5E0 VA: 0x1811E0BE0
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	*/
}
