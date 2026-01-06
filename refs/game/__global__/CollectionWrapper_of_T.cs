internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection // TypeDefIndex: 11119
{
	// Fields
	[Nullable(2)]
	private readonly IList _list; // 0x0
	[Nullable(new[] { 2, 1 })]
	private readonly ICollection<T> _genericCollection; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449BF0 Offset: 0x14485F0 VA: 0x181449BF0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449B80 Offset: 0x1448580 VA: 0x181449B80
	|-CollectionWrapper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448610 Offset: 0x1447010 VA: 0x181448610
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14487F0 Offset: 0x14471F0 VA: 0x1814487F0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448890 Offset: 0x1447290 VA: 0x181448890
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448A00 Offset: 0x1447400 VA: 0x181448A00
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449CB0 Offset: 0x14486B0 VA: 0x181449CB0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449D50 Offset: 0x1448750 VA: 0x181449D50
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448D10 Offset: 0x1447710 VA: 0x181448D10
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public virtual IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448B20 Offset: 0x1447520 VA: 0x181448B20
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449070 Offset: 0x1447A70 VA: 0x181449070
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 16
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14490C0 Offset: 0x1447AC0 VA: 0x1814490C0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14491D0 Offset: 0x1447BD0 VA: 0x1814491D0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 21
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14492F0 Offset: 0x1447CF0 VA: 0x1814492F0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14495C0 Offset: 0x1447FC0 VA: 0x1814495C0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449460 Offset: 0x1447E60 VA: 0x181449460
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449780 Offset: 0x1448180 VA: 0x181449780
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449670 Offset: 0x1448070 VA: 0x181449670
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 14
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449820 Offset: 0x1448220 VA: 0x181449820
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14498D0 Offset: 0x14482D0 VA: 0x1814498D0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448F60 Offset: 0x1447960 VA: 0x181448F60
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449000 Offset: 0x1447A00 VA: 0x181449000
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static void VerifyValueType(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449A30 Offset: 0x1448430 VA: 0x181449A30
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.VerifyValueType
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448BA0 Offset: 0x14475A0 VA: 0x181448BA0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public object get_UnderlyingCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449DF0 Offset: 0x14487F0 VA: 0x181449DF0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_UnderlyingCollection
	*/
}
