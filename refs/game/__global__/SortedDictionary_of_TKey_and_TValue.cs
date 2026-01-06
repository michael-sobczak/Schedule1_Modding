public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 9891
{
	// Fields
	private SortedDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private SortedDictionary.ValueCollection<TKey, TValue> _values; // 0x0
	private TreeSet<KeyValuePair<TKey, TValue>> _set; // 0x0

	// Properties
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public SortedDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public SortedDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C7720 Offset: 0x11C6120 VA: 0x1811C7720
	|-SortedDictionary<object, char>..ctor
	|
	|-RVA: 0x11C78E0 Offset: 0x11C62E0 VA: 0x1811C78E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C7800 Offset: 0x11C6200 VA: 0x1811C7800
	|-SortedDictionary<object, char>..ctor
	|
	|-RVA: 0x11C7900 Offset: 0x11C6300 VA: 0x1811C7900
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4E30 Offset: 0x11C3830 VA: 0x1811C4E30
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x11C4E70 Offset: 0x11C3870 VA: 0x1811C4E70
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4F10 Offset: 0x11C3910 VA: 0x1811C4F10
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x11C4FD0 Offset: 0x11C39D0 VA: 0x1811C4FD0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C52F0 Offset: 0x11C3CF0 VA: 0x1811C52F0
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x11C53E0 Offset: 0x11C3DE0 VA: 0x1811C53E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C7A60 Offset: 0x11C6460 VA: 0x1811C7A60
	|-SortedDictionary<object, char>.get_Item
	|
	|-RVA: 0x11C7BA0 Offset: 0x11C65A0 VA: 0x1811C7BA0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8330 Offset: 0x11C6D30 VA: 0x1811C8330
	|-SortedDictionary<object, char>.set_Item
	|
	|-RVA: 0x11C84D0 Offset: 0x11C6ED0 VA: 0x1811C84D0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C79E0 Offset: 0x11C63E0 VA: 0x1811C79E0
	|-SortedDictionary<object, char>.get_Count
	|
	|-RVA: 0x11C7A20 Offset: 0x11C6420 VA: 0x1811C7A20
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C80B0 Offset: 0x11C6AB0 VA: 0x1811C80B0
	|-SortedDictionary<object, char>.get_Keys
	|
	|-RVA: 0x11C8150 Offset: 0x11C6B50 VA: 0x1811C8150
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C56A0 Offset: 0x11C40A0 VA: 0x1811C56A0
	|-SortedDictionary<object, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x11C56C0 Offset: 0x11C40C0 VA: 0x1811C56C0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C56A0 Offset: 0x11C40A0 VA: 0x1811C56A0
	|-SortedDictionary<object, char>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x11C56C0 Offset: 0x11C40C0 VA: 0x1811C56C0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8290 Offset: 0x11C6C90 VA: 0x1811C8290
	|-SortedDictionary<object, char>.get_Values
	|
	|-RVA: 0x11C81F0 Offset: 0x11C6BF0 VA: 0x1811C81F0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C56E0 Offset: 0x11C40E0 VA: 0x1811C56E0
	|-SortedDictionary<object, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x11C5700 Offset: 0x11C4100 VA: 0x1811C5700
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C56E0 Offset: 0x11C40E0 VA: 0x1811C56E0
	|-SortedDictionary<object, char>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x11C5700 Offset: 0x11C4100 VA: 0x1811C5700
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3C10 Offset: 0x11C2610 VA: 0x1811C3C10
	|-SortedDictionary<object, char>.Add
	|
	|-RVA: 0x11C3CD0 Offset: 0x11C26D0 VA: 0x1811C3CD0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3FB0 Offset: 0x11C29B0 VA: 0x1811C3FB0
	|-SortedDictionary<object, char>.Clear
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C42F0 Offset: 0x11C2CF0 VA: 0x1811C42F0
	|-SortedDictionary<object, char>.ContainsKey
	|
	|-RVA: 0x11C3FE0 Offset: 0x11C29E0 VA: 0x1811C3FE0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4720 Offset: 0x11C3120 VA: 0x1811C4720
	|-SortedDictionary<object, char>.ContainsValue
	|
	|-RVA: 0x11C43B0 Offset: 0x11C2DB0 VA: 0x1811C43B0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C48F0 Offset: 0x11C32F0 VA: 0x1811C48F0
	|-SortedDictionary<object, char>.CopyTo
	|
	|-RVA: 0x11C48C0 Offset: 0x11C32C0 VA: 0x1811C48C0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4960 Offset: 0x11C3360 VA: 0x1811C4960
	|-SortedDictionary<object, char>.GetEnumerator
	|
	|-RVA: 0x11C4920 Offset: 0x11C3320 VA: 0x1811C4920
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5720 Offset: 0x11C4120 VA: 0x1811C5720
	|-SortedDictionary<object, char>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x11C57B0 Offset: 0x11C41B0 VA: 0x1811C57B0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4A50 Offset: 0x11C3450 VA: 0x1811C4A50
	|-SortedDictionary<object, char>.Remove
	|
	|-RVA: 0x11C4B10 Offset: 0x11C3510 VA: 0x1811C4B10
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C71F0 Offset: 0x11C5BF0 VA: 0x1811C71F0
	|-SortedDictionary<object, char>.TryGetValue
	|
	|-RVA: 0x11C72E0 Offset: 0x11C5CE0 VA: 0x1811C72E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5840 Offset: 0x11C4240 VA: 0x1811C5840
	|-SortedDictionary<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x11C58B0 Offset: 0x11C42B0 VA: 0x1811C58B0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_IsFixedSize
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_IsReadOnly
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C56A0 Offset: 0x11C40A0 VA: 0x1811C56A0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x11C56C0 Offset: 0x11C40C0 VA: 0x1811C56C0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C56E0 Offset: 0x11C40E0 VA: 0x1811C56E0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x11C5700 Offset: 0x11C4100 VA: 0x1811C5700
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C6940 Offset: 0x11C5340 VA: 0x1811C6940
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x11C6780 Offset: 0x11C5180 VA: 0x1811C6780
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C6F20 Offset: 0x11C5920 VA: 0x1811C6F20
	|-SortedDictionary<object, char>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x11C6AF0 Offset: 0x11C54F0 VA: 0x1811C6AF0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5DF0 Offset: 0x11C47F0 VA: 0x1811C5DF0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x11C59C0 Offset: 0x11C43C0 VA: 0x1811C59C0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C6110 Offset: 0x11C4B10 VA: 0x1811C6110
	|-SortedDictionary<object, char>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x11C6290 Offset: 0x11C4C90 VA: 0x1811C6290
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C49A0 Offset: 0x11C33A0 VA: 0x1811C49A0
	|-SortedDictionary<object, char>.IsCompatibleKey
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C6450 Offset: 0x11C4E50 VA: 0x1811C6450
	|-SortedDictionary<object, char>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x11C63C0 Offset: 0x11C4DC0 VA: 0x1811C63C0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C6600 Offset: 0x11C5000 VA: 0x1811C6600
	|-SortedDictionary<object, char>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x11C64E0 Offset: 0x11C4EE0 VA: 0x1811C64E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SortedDictionary<object, char>.System.Collections.ICollection.get_IsSynchronized
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5970 Offset: 0x11C4370 VA: 0x1811C5970
	|-SortedDictionary<object, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11C5920 Offset: 0x11C4320 VA: 0x1811C5920
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5720 Offset: 0x11C4120 VA: 0x1811C5720
	|-SortedDictionary<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11C57B0 Offset: 0x11C41B0 VA: 0x1811C57B0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
