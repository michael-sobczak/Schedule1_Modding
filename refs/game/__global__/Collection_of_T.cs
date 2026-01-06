public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 4952
{
	// Fields
	private IList<T> items; // 0x0

	// Properties
	public int Count { get; }
	protected IList<T> Items { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144CE90 Offset: 0x144B890 VA: 0x18144CE90
	|-Collection<object>..ctor
	|
	|-RVA: 0x12127C0 Offset: 0x12111C0 VA: 0x1812127C0
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113DE30 Offset: 0x113C830 VA: 0x18113DE30
	|-Collection<object>..ctor
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144CF10 Offset: 0x144B910 VA: 0x18144CF10
	|-Collection<object>.get_Count
	|-Collection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-Collection<object>.get_Items
	|-Collection<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED480 Offset: 0x10EBE80 VA: 0x1810ED480
	|-Collection<object>.get_Item
	|
	|-RVA: 0x144CF60 Offset: 0x144B960 VA: 0x18144CF60
	|-Collection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144D1C0 Offset: 0x144BBC0 VA: 0x18144D1C0
	|-Collection<object>.set_Item
	|
	|-RVA: 0x144D030 Offset: 0x144BA30 VA: 0x18144D030
	|-Collection<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449E00 Offset: 0x1448800 VA: 0x181449E00
	|-Collection<object>.Add
	|
	|-RVA: 0x1449EE0 Offset: 0x14488E0 VA: 0x181449EE0
	|-Collection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A0B0 Offset: 0x1448AB0 VA: 0x18144A0B0
	|-Collection<object>.Clear
	|-Collection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A280 Offset: 0x1448C80 VA: 0x18144A280
	|-Collection<object>.CopyTo
	|-Collection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A220 Offset: 0x1448C20 VA: 0x18144A220
	|-Collection<object>.Contains
	|
	|-RVA: 0x144A130 Offset: 0x1448B30 VA: 0x18144A130
	|-Collection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A2F0 Offset: 0x1448CF0 VA: 0x18144A2F0
	|-Collection<object>.GetEnumerator
	|-Collection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC010 Offset: 0x10EAA10 VA: 0x1810EC010
	|-Collection<object>.IndexOf
	|
	|-RVA: 0x144A340 Offset: 0x1448D40 VA: 0x18144A340
	|-Collection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A5A0 Offset: 0x1448FA0 VA: 0x18144A5A0
	|-Collection<object>.Insert
	|
	|-RVA: 0x144A690 Offset: 0x1449090 VA: 0x18144A690
	|-Collection<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AB00 Offset: 0x1449500 VA: 0x18144AB00
	|-Collection<object>.Remove
	|
	|-RVA: 0x144ABF0 Offset: 0x14495F0 VA: 0x18144ABF0
	|-Collection<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A9C0 Offset: 0x14493C0 VA: 0x18144A9C0
	|-Collection<object>.RemoveAt
	|-Collection<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A060 Offset: 0x1448A60 VA: 0x18144A060
	|-Collection<object>.ClearItems
	|-Collection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A530 Offset: 0x1448F30 VA: 0x18144A530
	|-Collection<object>.InsertItem
	|
	|-RVA: 0x144A430 Offset: 0x1448E30 VA: 0x18144A430
	|-Collection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AAA0 Offset: 0x14494A0 VA: 0x18144AAA0
	|-Collection<object>.RemoveItem
	|-Collection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AE60 Offset: 0x1449860 VA: 0x18144AE60
	|-Collection<object>.SetItem
	|
	|-RVA: 0x144AD60 Offset: 0x1449760 VA: 0x18144AD60
	|-Collection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AED0 Offset: 0x14498D0 VA: 0x18144AED0
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B8A0 Offset: 0x144A2A0 VA: 0x18144B8A0
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x144B850 Offset: 0x144A250 VA: 0x18144B850
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Collection<object>.System.Collections.ICollection.get_IsSynchronized
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B7F0 Offset: 0x144A1F0 VA: 0x18144B7F0
	|-Collection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x144B790 Offset: 0x144A190 VA: 0x18144B790
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AF20 Offset: 0x1449920 VA: 0x18144AF20
	|-Collection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x144B330 Offset: 0x1449D30 VA: 0x18144B330
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED480 Offset: 0x10EBE80 VA: 0x1810ED480
	|-Collection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x144CA80 Offset: 0x144B480 VA: 0x18144CA80
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144CCD0 Offset: 0x144B6D0 VA: 0x18144CCD0
	|-Collection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x144CB50 Offset: 0x144B550 VA: 0x18144CB50
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AED0 Offset: 0x14498D0 VA: 0x18144AED0
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144C920 Offset: 0x144B320 VA: 0x18144C920
	|-Collection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x144C9D0 Offset: 0x144B3D0 VA: 0x18144C9D0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B8F0 Offset: 0x144A2F0 VA: 0x18144B8F0
	|-Collection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x144BB50 Offset: 0x144A550 VA: 0x18144BB50
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BE50 Offset: 0x144A850 VA: 0x18144BE50
	|-Collection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x144BD30 Offset: 0x144A730 VA: 0x18144BD30
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144BF90 Offset: 0x144A990 VA: 0x18144BF90
	|-Collection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x144C0D0 Offset: 0x144AAD0 VA: 0x18144C0D0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144C3C0 Offset: 0x144ADC0 VA: 0x18144C3C0
	|-Collection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x144C1F0 Offset: 0x144ABF0 VA: 0x18144C1F0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144C730 Offset: 0x144B130 VA: 0x18144C730
	|-Collection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x144C5D0 Offset: 0x144AFD0 VA: 0x18144C5D0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A960 Offset: 0x1449360 VA: 0x18144A960
	|-Collection<object>.IsCompatibleObject
	|
	|-RVA: 0x144A820 Offset: 0x1449220 VA: 0x18144A820
	|-Collection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/
}
