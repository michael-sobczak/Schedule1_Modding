internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 12968
{
	// Fields
	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Properties
	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C3E0 Offset: 0x110ADE0 VA: 0x18110C3E0
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x110C430 Offset: 0x110AE30 VA: 0x18110C430
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x110C540 Offset: 0x110AF40 VA: 0x18110C540
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C480 Offset: 0x110AE80 VA: 0x18110C480
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x110C740 Offset: 0x110B140 VA: 0x18110C740
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x110C800 Offset: 0x110B200 VA: 0x18110C800
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|-RBTree.RBTreeEnumerator<object>.Dispose
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110BA20 Offset: 0x110A420 VA: 0x18110BA20
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x110B930 Offset: 0x110A330 VA: 0x18110B930
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	|
	|-RVA: 0x110BC40 Offset: 0x110A640 VA: 0x18110BC40
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-RBTree.RBTreeEnumerator<object>.get_Current
	|
	|-RVA: 0x110CB50 Offset: 0x110B550 VA: 0x18110CB50
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C250 Offset: 0x110AC50 VA: 0x18110C250
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110C3B0 Offset: 0x110ADB0 VA: 0x18110C3B0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110C2B0 Offset: 0x110ACB0 VA: 0x18110C2B0
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C190 Offset: 0x110AB90 VA: 0x18110C190
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110C1F0 Offset: 0x110ABF0 VA: 0x18110C1F0
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110BF70 Offset: 0x110A970 VA: 0x18110BF70
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
