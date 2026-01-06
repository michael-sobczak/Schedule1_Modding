private sealed class SortedList.ValueList<TKey, TValue> : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection // TypeDefIndex: 9897
{
	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	|-SortedList.ValueList<int, ValueTuple<object, int>>..ctor
	|-SortedList.ValueList<object, object>..ctor
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317FA0 Offset: 0x13169A0 VA: 0x181317FA0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.get_Count
	|-SortedList.ValueList<object, object>.get_Count
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.get_IsReadOnly
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317EB0 Offset: 0x13168B0 VA: 0x181317EB0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1317F00 Offset: 0x1316900 VA: 0x181317F00
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1317F50 Offset: 0x1316950 VA: 0x181317F50
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317660 Offset: 0x1316060 VA: 0x181317660
	|-SortedList.ValueList<int, ValueTuple<object, int>>.Add
	|-SortedList.ValueList<object, object>.Add
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13176B0 Offset: 0x13160B0 VA: 0x1813176B0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.Clear
	|-SortedList.ValueList<object, object>.Clear
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317700 Offset: 0x1316100 VA: 0x181317700
	|-SortedList.ValueList<int, ValueTuple<object, int>>.Contains
	|
	|-RVA: 0x1317830 Offset: 0x1316230 VA: 0x181317830
	|-SortedList.ValueList<object, object>.Contains
	|
	|-RVA: 0x1317740 Offset: 0x1316140 VA: 0x181317740
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317860 Offset: 0x1316260 VA: 0x181317860
	|-SortedList.ValueList<int, ValueTuple<object, int>>.CopyTo
	|-SortedList.ValueList<object, object>.CopyTo
	|
	|-RVA: 0x13178A0 Offset: 0x13162A0 VA: 0x1813178A0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317C30 Offset: 0x1316630 VA: 0x181317C30
	|-SortedList.ValueList<int, ValueTuple<object, int>>.System.Collections.ICollection.CopyTo
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1317D60 Offset: 0x1316760 VA: 0x181317D60
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317BE0 Offset: 0x13165E0 VA: 0x181317BE0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.Insert
	|-SortedList.ValueList<object, object>.Insert
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13180C0 Offset: 0x1316AC0 VA: 0x1813180C0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.get_Item
	|
	|-RVA: 0x1318090 Offset: 0x1316A90 VA: 0x181318090
	|-SortedList.ValueList<object, object>.get_Item
	|
	|-RVA: 0x1317FC0 Offset: 0x13169C0 VA: 0x181317FC0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317BE0 Offset: 0x13165E0 VA: 0x181317BE0
	|-SortedList.ValueList<int, ValueTuple<object, int>>.set_Item
	|-SortedList.ValueList<object, object>.set_Item
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317990 Offset: 0x1316390 VA: 0x181317990
	|-SortedList.ValueList<int, ValueTuple<object, int>>.GetEnumerator
	|-SortedList.ValueList<object, object>.GetEnumerator
	|
	|-RVA: 0x1317920 Offset: 0x1316320 VA: 0x181317920
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317990 Offset: 0x1316390 VA: 0x181317990
	|-SortedList.ValueList<int, ValueTuple<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1317920 Offset: 0x1316320 VA: 0x181317920
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317B90 Offset: 0x1316590 VA: 0x181317B90
	|-SortedList.ValueList<int, ValueTuple<object, int>>.IndexOf
	|
	|-RVA: 0x1317A00 Offset: 0x1316400 VA: 0x181317A00
	|-SortedList.ValueList<object, object>.IndexOf
	|
	|-RVA: 0x1317A40 Offset: 0x1316440 VA: 0x181317A40
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317660 Offset: 0x1316060 VA: 0x181317660
	|-SortedList.ValueList<int, ValueTuple<object, int>>.Remove
	|-SortedList.ValueList<object, object>.Remove
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1317660 Offset: 0x1316060 VA: 0x181317660
	|-SortedList.ValueList<int, ValueTuple<object, int>>.RemoveAt
	|-SortedList.ValueList<object, object>.RemoveAt
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/
}
