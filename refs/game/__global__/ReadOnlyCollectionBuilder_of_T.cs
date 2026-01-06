public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 15608
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B7A0 Offset: 0x110A1A0 VA: 0x18110B7A0
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0x110B8E0 Offset: 0x110A2E0 VA: 0x18110B8E0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11271A0 Offset: 0x1125BA0 VA: 0x1811271A0
	|-ReadOnlyCollectionBuilder<object>..ctor
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11273D0 Offset: 0x1125DD0 VA: 0x1811273D0
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	|
	|-RVA: 0x11274E0 Offset: 0x1125EE0 VA: 0x1811274E0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-ReadOnlyCollectionBuilder<object>.get_Count
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124FB0 Offset: 0x11239B0 VA: 0x181124FB0
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	|
	|-RVA: 0x1124EA0 Offset: 0x11238A0 VA: 0x181124EA0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124FE0 Offset: 0x11239E0 VA: 0x181124FE0
	|-ReadOnlyCollectionBuilder<object>.Insert
	|
	|-RVA: 0x11250F0 Offset: 0x1123AF0 VA: 0x1811250F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125470 Offset: 0x1123E70 VA: 0x181125470
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	|
	|-RVA: 0x1125530 Offset: 0x1123F30 VA: 0x181125530
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127250 Offset: 0x1125C50 VA: 0x181127250
	|-ReadOnlyCollectionBuilder<object>.get_Item
	|
	|-RVA: 0x11272D0 Offset: 0x1125CD0 VA: 0x1811272D0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127760 Offset: 0x1126160 VA: 0x181127760
	|-ReadOnlyCollectionBuilder<object>.set_Item
	|
	|-RVA: 0x11275F0 Offset: 0x1125FF0 VA: 0x1811275F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124760 Offset: 0x1123160 VA: 0x181124760
	|-ReadOnlyCollectionBuilder<object>.Add
	|
	|-RVA: 0x11245F0 Offset: 0x1122FF0 VA: 0x1811245F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105A5F0 Offset: 0x1058FF0 VA: 0x18105A5F0
	|-ReadOnlyCollectionBuilder<object>.Clear
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11247F0 Offset: 0x11231F0 VA: 0x1811247F0
	|-ReadOnlyCollectionBuilder<object>.Contains
	|
	|-RVA: 0x11249F0 Offset: 0x11233F0 VA: 0x1811249F0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101C800 Offset: 0x101B200 VA: 0x18101C800
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125700 Offset: 0x1124100 VA: 0x181125700
	|-ReadOnlyCollectionBuilder<object>.Remove
	|
	|-RVA: 0x1125820 Offset: 0x1124220 VA: 0x181125820
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124DC0 Offset: 0x11237C0 VA: 0x181124DC0
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	|
	|-RVA: 0x1124E30 Offset: 0x1123830 VA: 0x181124E30
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125A20 Offset: 0x1124420 VA: 0x181125A20
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1057F30 Offset: 0x1056930 VA: 0x181057F30
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125C50 Offset: 0x1124650 VA: 0x181125C50
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	|
	|-RVA: 0x1125AA0 Offset: 0x11244A0 VA: 0x181125AA0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125DF0 Offset: 0x11247F0 VA: 0x181125DF0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x1125EF0 Offset: 0x11248F0 VA: 0x181125EF0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126130 Offset: 0x1124B30 VA: 0x181126130
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1126010 Offset: 0x1124A10 VA: 0x181126010
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126410 Offset: 0x1124E10 VA: 0x181126410
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x1126250 Offset: 0x1124C50 VA: 0x181126250
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsFixedSize
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126720 Offset: 0x1125120 VA: 0x181126720
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x1126610 Offset: 0x1125010 VA: 0x181126610
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126900 Offset: 0x1125300 VA: 0x181126900
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1126990 Offset: 0x1125390 VA: 0x181126990
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126C20 Offset: 0x1125620 VA: 0x181126C20
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x1126A60 Offset: 0x1125460 VA: 0x181126A60
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125930 Offset: 0x1124330 VA: 0x181125930
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_IsSynchronized
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_SyncRoot
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126DB0 Offset: 0x11257B0 VA: 0x181126DB0
	|-ReadOnlyCollectionBuilder<object>.ToArray
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126F10 Offset: 0x1125910 VA: 0x181126F10
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	|
	|-RVA: 0x1126E20 Offset: 0x1125820 VA: 0x181126E20
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124C20 Offset: 0x1123620 VA: 0x181124C20
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	|
	|-RVA: 0x1124D60 Offset: 0x1123760 VA: 0x181124D60
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125410 Offset: 0x1123E10 VA: 0x181125410
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	|
	|-RVA: 0x11252D0 Offset: 0x1123CD0 VA: 0x1811252D0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	|
	|-RVA: 0x1127040 Offset: 0x1125A40 VA: 0x181127040
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ValidateNullValue
	*/
}
