public class ObservableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 13600
{
	// Fields
	private IList<T> m_List; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler<T> ItemAdded; // 0x0
	[CompilerGenerated]
	private ListChangedEventHandler<T> ItemRemoved; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_ItemAdded(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED290 Offset: 0x10EBC90 VA: 0x1810ED290
	|-ObservableList<object>.add_ItemAdded
	|-ObservableList<__Il2CppFullySharedGenericType>.add_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_ItemAdded(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED5B0 Offset: 0x10EBFB0 VA: 0x1810ED5B0
	|-ObservableList<object>.remove_ItemAdded
	|-ObservableList<__Il2CppFullySharedGenericType>.remove_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_ItemRemoved(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED360 Offset: 0x10EBD60 VA: 0x1810ED360
	|-ObservableList<object>.add_ItemRemoved
	|-ObservableList<__Il2CppFullySharedGenericType>.add_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_ItemRemoved(ListChangedEventHandler<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED680 Offset: 0x10EC080 VA: 0x1810ED680
	|-ObservableList<object>.remove_ItemRemoved
	|-ObservableList<__Il2CppFullySharedGenericType>.remove_ItemRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED480 Offset: 0x10EBE80 VA: 0x1810ED480
	|-ObservableList<object>.get_Item
	|
	|-RVA: 0x10ED4E0 Offset: 0x10EBEE0 VA: 0x1810ED4E0
	|-ObservableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED750 Offset: 0x10EC150 VA: 0x1810ED750
	|-ObservableList<object>.set_Item
	|
	|-RVA: 0x10ED860 Offset: 0x10EC260 VA: 0x1810ED860
	|-ObservableList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED430 Offset: 0x10EBE30 VA: 0x1810ED430
	|-ObservableList<object>.get_Count
	|-ObservableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ObservableList<object>.get_IsReadOnly
	|-ObservableList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED030 Offset: 0x10EBA30 VA: 0x1810ED030
	|-ObservableList<object>..ctor
	|
	|-RVA: 0x10ED150 Offset: 0x10EBB50 VA: 0x1810ED150
	|-ObservableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED170 Offset: 0x10EBB70 VA: 0x1810ED170
	|-ObservableList<object>..ctor
	|
	|-RVA: 0x10ED200 Offset: 0x10EBC00 VA: 0x1810ED200
	|-ObservableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ECFA0 Offset: 0x10EB9A0 VA: 0x1810ECFA0
	|-ObservableList<object>..ctor
	|
	|-RVA: 0x10ED0C0 Offset: 0x10EBAC0 VA: 0x1810ED0C0
	|-ObservableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void OnEvent(ListChangedEventHandler<T> e, int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC3D0 Offset: 0x10EADD0 VA: 0x1810EC3D0
	|-ObservableList<object>.OnEvent
	|
	|-RVA: 0x10EC480 Offset: 0x10EAE80 VA: 0x1810EC480
	|-ObservableList<__Il2CppFullySharedGenericType>.OnEvent
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBE90 Offset: 0x10EA890 VA: 0x1810EBE90
	|-ObservableList<object>.Contains
	|
	|-RVA: 0x10EBDA0 Offset: 0x10EA7A0 VA: 0x1810EBDA0
	|-ObservableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC010 Offset: 0x10EAA10 VA: 0x1810EC010
	|-ObservableList<object>.IndexOf
	|
	|-RVA: 0x10EC070 Offset: 0x10EAA70 VA: 0x1810EC070
	|-ObservableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBA50 Offset: 0x10EA450 VA: 0x1810EBA50
	|-ObservableList<object>.Add
	|
	|-RVA: 0x10EB780 Offset: 0x10EA180 VA: 0x1810EB780
	|-ObservableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB630 Offset: 0x10EA030 VA: 0x1810EB630
	|-ObservableList<object>.Add
	|
	|-RVA: 0x10EB4B0 Offset: 0x10E9EB0 VA: 0x1810EB4B0
	|-ObservableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC320 Offset: 0x10EAD20 VA: 0x1810EC320
	|-ObservableList<object>.Insert
	|
	|-RVA: 0x10EC160 Offset: 0x10EAB60 VA: 0x1810EC160
	|-ObservableList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ECBD0 Offset: 0x10EB5D0 VA: 0x1810ECBD0
	|-ObservableList<object>.Remove
	|
	|-RVA: 0x10ECCD0 Offset: 0x10EB6D0 VA: 0x1810ECCD0
	|-ObservableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int Remove(T[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC8B0 Offset: 0x10EB2B0 VA: 0x1810EC8B0
	|-ObservableList<object>.Remove
	|
	|-RVA: 0x10ECA30 Offset: 0x10EB430 VA: 0x1810ECA30
	|-ObservableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC5E0 Offset: 0x10EAFE0 VA: 0x1810EC5E0
	|-ObservableList<object>.RemoveAt
	|
	|-RVA: 0x10EC6D0 Offset: 0x10EB0D0 VA: 0x1810EC6D0
	|-ObservableList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBBE0 Offset: 0x10EA5E0 VA: 0x1810EBBE0
	|-ObservableList<object>.Clear
	|
	|-RVA: 0x10EBB40 Offset: 0x10EA540 VA: 0x1810EBB40
	|-ObservableList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBEF0 Offset: 0x10EA8F0 VA: 0x1810EBEF0
	|-ObservableList<object>.CopyTo
	|-ObservableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBFC0 Offset: 0x10EA9C0 VA: 0x1810EBFC0
	|-ObservableList<object>.GetEnumerator
	|-ObservableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ECF40 Offset: 0x10EB940 VA: 0x1810ECF40
	|-ObservableList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10ECF20 Offset: 0x10EB920 VA: 0x1810ECF20
	|-ObservableList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
