public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 9898
{
	// Fields
	private TKey[] keys; // 0x0
	private TValue[] values; // 0x0
	private int _size; // 0x0
	private int version; // 0x0
	private IComparer<TKey> comparer; // 0x0
	private SortedList.KeyList<TKey, TValue> keyList; // 0x0
	private SortedList.ValueList<TKey, TValue> valueList; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Capacity { set; }
	public IComparer<TKey> Comparer { get; }
	public int Count { get; }
	public IList<TKey> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public IList<TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D1C60 Offset: 0x11D0660 VA: 0x1811D1C60
	|-SortedList<int, ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x11D1650 Offset: 0x11D0050 VA: 0x1811D1650
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0x11D1840 Offset: 0x11D0240 VA: 0x1811D1840
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D16F0 Offset: 0x11D00F0 VA: 0x1811D16F0
	|-SortedList<int, ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x11D1A40 Offset: 0x11D0440 VA: 0x1811D1A40
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0x11D18E0 Offset: 0x11D02E0 VA: 0x1811D18E0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D1580 Offset: 0x11CFF80 VA: 0x1811D1580
	|-SortedList<int, ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x11D1B90 Offset: 0x11D0590 VA: 0x1811D1B90
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0x11D1530 Offset: 0x11CFF30 VA: 0x1811D1530
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C9F10 Offset: 0x11C8910 VA: 0x1811C9F10
	|-SortedList<int, ValueTuple<object, int>>.Add
	|
	|-RVA: 0x11C9DE0 Offset: 0x11C87E0 VA: 0x1811C9DE0
	|-SortedList<object, object>.Add
	|
	|-RVA: 0x11CA030 Offset: 0x11C8A30 VA: 0x1811CA030
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CC840 Offset: 0x11CB240 VA: 0x1811CC840
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x11CC820 Offset: 0x11CB220 VA: 0x1811CC820
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x11CC6B0 Offset: 0x11CB0B0 VA: 0x1811CC6B0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CCBE0 Offset: 0x11CB5E0 VA: 0x1811CCBE0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x11CCAB0 Offset: 0x11CB4B0 VA: 0x1811CCAB0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x11CC870 Offset: 0x11CB270 VA: 0x1811CC870
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CD940 Offset: 0x11CC340 VA: 0x1811CD940
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x11CD7F0 Offset: 0x11CC1F0 VA: 0x1811CD7F0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x11CD5A0 Offset: 0x11CBFA0 VA: 0x1811CD5A0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D21F0 Offset: 0x11D0BF0 VA: 0x1811D21F0
	|-SortedList<int, ValueTuple<object, int>>.set_Capacity
	|-SortedList<object, object>.set_Capacity
	|
	|-RVA: 0x11D23D0 Offset: 0x11D0DD0 VA: 0x1811D23D0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public IComparer<TKey> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	|-SortedList<int, ValueTuple<object, int>>.get_Comparer
	|-SortedList<object, object>.get_Comparer
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CF630 Offset: 0x11CE030 VA: 0x1811CF630
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x11CEF50 Offset: 0x11CD950 VA: 0x1811CEF50
	|-SortedList<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x11CF220 Offset: 0x11CDC20 VA: 0x1811CF220
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-SortedList<int, ValueTuple<object, int>>.get_Count
	|-SortedList<object, object>.get_Count
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IList<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDA60 Offset: 0x11CC460 VA: 0x1811CDA60
	|-SortedList<int, ValueTuple<object, int>>.get_Keys
	|-SortedList<object, object>.get_Keys
	|
	|-RVA: 0x11CDA80 Offset: 0x11CC480 VA: 0x1811CDA80
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDA60 Offset: 0x11CC460 VA: 0x1811CDA60
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|-SortedList<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x11CDA80 Offset: 0x11CC480 VA: 0x1811CDA80
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDA60 Offset: 0x11CC460 VA: 0x1811CDA60
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.get_Keys
	|-SortedList<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x11CDA80 Offset: 0x11CC480 VA: 0x1811CDA80
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDA60 Offset: 0x11CC460 VA: 0x1811CDA60
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|-SortedList<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x11CDA80 Offset: 0x11CC480 VA: 0x1811CDA80
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public IList<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDAA0 Offset: 0x11CC4A0 VA: 0x1811CDAA0
	|-SortedList<int, ValueTuple<object, int>>.get_Values
	|-SortedList<object, object>.get_Values
	|
	|-RVA: 0x11CDAC0 Offset: 0x11CC4C0 VA: 0x1811CDAC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDAA0 Offset: 0x11CC4A0 VA: 0x1811CDAA0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|-SortedList<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x11CDAC0 Offset: 0x11CC4C0 VA: 0x1811CDAC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDAA0 Offset: 0x11CC4A0 VA: 0x1811CDAA0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.get_Values
	|-SortedList<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x11CDAC0 Offset: 0x11CC4C0 VA: 0x1811CDAC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CDAA0 Offset: 0x11CC4A0 VA: 0x1811CDAA0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|-SortedList<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x11CDAC0 Offset: 0x11CC4C0 VA: 0x1811CDAC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	private SortedList.KeyList<TKey, TValue> GetKeyListHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CAE30 Offset: 0x11C9830 VA: 0x1811CAE30
	|-SortedList<int, ValueTuple<object, int>>.GetKeyListHelper
	|-SortedList<object, object>.GetKeyListHelper
	|
	|-RVA: 0x11CAED0 Offset: 0x11C98D0 VA: 0x1811CAED0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyListHelper
	*/

	// RVA: -1 Offset: -1
	private SortedList.ValueList<TKey, TValue> GetValueListHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB270 Offset: 0x11C9C70 VA: 0x1811CB270
	|-SortedList<int, ValueTuple<object, int>>.GetValueListHelper
	|-SortedList<object, object>.GetValueListHelper
	|
	|-RVA: 0x11CB310 Offset: 0x11C9D10 VA: 0x1811CB310
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueListHelper
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.get_IsReadOnly
	|-SortedList<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.get_IsFixedSize
	|-SortedList<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CEEE0 Offset: 0x11CD8E0 VA: 0x1811CEEE0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11CEE70 Offset: 0x11CD870 VA: 0x1811CEE70
	|-SortedList<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11CEE00 Offset: 0x11CD800 VA: 0x1811CEE00
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CA430 Offset: 0x11C8E30 VA: 0x1811CA430
	|-SortedList<int, ValueTuple<object, int>>.Clear
	|
	|-RVA: 0x11CA3F0 Offset: 0x11C8DF0 VA: 0x1811CA3F0
	|-SortedList<object, object>.Clear
	|
	|-RVA: 0x11CA460 Offset: 0x11C8E60 VA: 0x1811CA460
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CFBD0 Offset: 0x11CE5D0 VA: 0x1811CFBD0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x11CF940 Offset: 0x11CE340 VA: 0x1811CF940
	|-SortedList<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x11CFAB0 Offset: 0x11CE4B0 VA: 0x1811CFAB0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CA4E0 Offset: 0x11C8EE0 VA: 0x1811CA4E0
	|-SortedList<int, ValueTuple<object, int>>.ContainsKey
	|
	|-RVA: 0x11CA630 Offset: 0x11C9030 VA: 0x1811CA630
	|-SortedList<object, object>.ContainsKey
	|
	|-RVA: 0x11CA540 Offset: 0x11C8F40 VA: 0x1811CA540
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CA6E0 Offset: 0x11C90E0 VA: 0x1811CA6E0
	|-SortedList<int, ValueTuple<object, int>>.ContainsValue
	|
	|-RVA: 0x11CA830 Offset: 0x11C9230 VA: 0x1811CA830
	|-SortedList<object, object>.ContainsValue
	|
	|-RVA: 0x11CA740 Offset: 0x11C9140 VA: 0x1811CA740
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CD350 Offset: 0x11CBD50 VA: 0x1811CD350
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x11CCCE0 Offset: 0x11CB6E0 VA: 0x1811CCCE0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x11CCEF0 Offset: 0x11CB8F0 VA: 0x1811CCEF0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CE880 Offset: 0x11CD280 VA: 0x1811CE880
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11CDAE0 Offset: 0x11CC4E0 VA: 0x1811CDAE0
	|-SortedList<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11CE000 Offset: 0x11CCA00 VA: 0x1811CE000
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CA8E0 Offset: 0x11C92E0 VA: 0x1811CA8E0
	|-SortedList<int, ValueTuple<object, int>>.EnsureCapacity
	|-SortedList<object, object>.EnsureCapacity
	|
	|-RVA: 0x11CA880 Offset: 0x11C9280 VA: 0x1811CA880
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private TValue GetByIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CAB60 Offset: 0x11C9560 VA: 0x1811CAB60
	|-SortedList<int, ValueTuple<object, int>>.GetByIndex
	|
	|-RVA: 0x11CAA80 Offset: 0x11C9480 VA: 0x1811CAA80
	|-SortedList<object, object>.GetByIndex
	|
	|-RVA: 0x11CA940 Offset: 0x11C9340 VA: 0x1811CA940
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetByIndex
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CADA0 Offset: 0x11C97A0 VA: 0x1811CADA0
	|-SortedList<int, ValueTuple<object, int>>.GetEnumerator
	|
	|-RVA: 0x11CAD10 Offset: 0x11C9710 VA: 0x1811CAD10
	|-SortedList<object, object>.GetEnumerator
	|
	|-RVA: 0x11CAC50 Offset: 0x11C9650 VA: 0x1811CAC50
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CADA0 Offset: 0x11C97A0 VA: 0x1811CADA0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x11CAD10 Offset: 0x11C9710 VA: 0x1811CAD10
	|-SortedList<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x11CAC50 Offset: 0x11C9650 VA: 0x1811CAC50
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CFE90 Offset: 0x11CE890 VA: 0x1811CFE90
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x11CFD40 Offset: 0x11CE740 VA: 0x1811CFD40
	|-SortedList<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x11CFDD0 Offset: 0x11CE7D0 VA: 0x1811CFDD0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CADA0 Offset: 0x11C97A0 VA: 0x1811CADA0
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11CAD10 Offset: 0x11C9710 VA: 0x1811CAD10
	|-SortedList<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11CAC50 Offset: 0x11C9650 VA: 0x1811CAC50
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private TKey GetKey(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB190 Offset: 0x11C9B90 VA: 0x1811CB190
	|-SortedList<int, ValueTuple<object, int>>.GetKey
	|
	|-RVA: 0x11CAF70 Offset: 0x11C9970 VA: 0x1811CAF70
	|-SortedList<object, object>.GetKey
	|
	|-RVA: 0x11CB050 Offset: 0x11C9A50 VA: 0x1811CB050
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKey
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D20D0 Offset: 0x11D0AD0 VA: 0x1811D20D0
	|-SortedList<int, ValueTuple<object, int>>.get_Item
	|
	|-RVA: 0x11D1F80 Offset: 0x11D0980 VA: 0x1811D1F80
	|-SortedList<object, object>.get_Item
	|
	|-RVA: 0x11D1D00 Offset: 0x11D0700 VA: 0x1811D1D00
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D2A70 Offset: 0x11D1470 VA: 0x1811D2A70
	|-SortedList<int, ValueTuple<object, int>>.set_Item
	|
	|-RVA: 0x11D25B0 Offset: 0x11D0FB0 VA: 0x1811D25B0
	|-SortedList<object, object>.set_Item
	|
	|-RVA: 0x11D26C0 Offset: 0x11D10C0 VA: 0x1811D26C0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D0660 Offset: 0x11CF060 VA: 0x1811D0660
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x11D04E0 Offset: 0x11CEEE0 VA: 0x1811D04E0
	|-SortedList<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x11D0330 Offset: 0x11CED30 VA: 0x1811D0330
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D0E90 Offset: 0x11CF890 VA: 0x1811D0E90
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x11D0800 Offset: 0x11CF200 VA: 0x1811D0800
	|-SortedList<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x11D0B00 Offset: 0x11CF500 VA: 0x1811D0B00
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	public int IndexOfKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB610 Offset: 0x11CA010 VA: 0x1811CB610
	|-SortedList<int, ValueTuple<object, int>>.IndexOfKey
	|
	|-RVA: 0x11CB570 Offset: 0x11C9F70 VA: 0x1811CB570
	|-SortedList<object, object>.IndexOfKey
	|
	|-RVA: 0x11CB3B0 Offset: 0x11C9DB0 VA: 0x1811CB3B0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfKey
	*/

	// RVA: -1 Offset: -1
	public int IndexOfValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CB7B0 Offset: 0x11CA1B0 VA: 0x1811CB7B0
	|-SortedList<int, ValueTuple<object, int>>.IndexOfValue
	|
	|-RVA: 0x11CB780 Offset: 0x11CA180 VA: 0x1811CB780
	|-SortedList<object, object>.IndexOfValue
	|
	|-RVA: 0x11CB660 Offset: 0x11CA060 VA: 0x1811CB660
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfValue
	*/

	// RVA: -1 Offset: -1
	private void Insert(int index, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CBA80 Offset: 0x11CA480 VA: 0x1811CBA80
	|-SortedList<int, ValueTuple<object, int>>.Insert
	|
	|-RVA: 0x11CBBD0 Offset: 0x11CA5D0 VA: 0x1811CBBD0
	|-SortedList<object, object>.Insert
	|
	|-RVA: 0x11CB7F0 Offset: 0x11CA1F0 VA: 0x1811CB7F0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11D1390 Offset: 0x11CFD90 VA: 0x1811D1390
	|-SortedList<int, ValueTuple<object, int>>.TryGetValue
	|
	|-RVA: 0x11D1440 Offset: 0x11CFE40 VA: 0x1811D1440
	|-SortedList<object, object>.TryGetValue
	|
	|-RVA: 0x11D11E0 Offset: 0x11CFBE0 VA: 0x1811D11E0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CC2B0 Offset: 0x11CACB0 VA: 0x1811CC2B0
	|-SortedList<int, ValueTuple<object, int>>.RemoveAt
	|
	|-RVA: 0x11CC140 Offset: 0x11CAB40 VA: 0x1811CC140
	|-SortedList<object, object>.RemoveAt
	|
	|-RVA: 0x11CBDC0 Offset: 0x11CA7C0 VA: 0x1811CBDC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CC520 Offset: 0x11CAF20 VA: 0x1811CC520
	|-SortedList<int, ValueTuple<object, int>>.Remove
	|
	|-RVA: 0x11CC5C0 Offset: 0x11CAFC0 VA: 0x1811CC5C0
	|-SortedList<object, object>.Remove
	|
	|-RVA: 0x11CC410 Offset: 0x11CAE10 VA: 0x1811CC410
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CFF20 Offset: 0x11CE920 VA: 0x1811CFF20
	|-SortedList<int, ValueTuple<object, int>>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x11D01B0 Offset: 0x11CEBB0 VA: 0x1811D01B0
	|-SortedList<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x11D00A0 Offset: 0x11CEAA0 VA: 0x1811D00A0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11CBD20 Offset: 0x11CA720 VA: 0x1811CBD20
	|-SortedList<int, ValueTuple<object, int>>.IsCompatibleKey
	|-SortedList<object, object>.IsCompatibleKey
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/
}
