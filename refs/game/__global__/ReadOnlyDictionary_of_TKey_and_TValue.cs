public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 4958
{
	// Fields
	private readonly IDictionary<TKey, TValue> m_dictionary; // 0x0
	private object _syncRoot; // 0x0
	private ReadOnlyDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private ReadOnlyDictionary.ValueCollection<TKey, TValue> _values; // 0x0

	// Properties
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> Keys { get; }
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C7C0 Offset: 0x119B1C0 VA: 0x18119C7C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C8A0 Offset: 0x119B2A0 VA: 0x18119C8A0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B210 Offset: 0x1199C10 VA: 0x18119B210
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCBFA0 Offset: 0xFCA9A0 VA: 0x180FCBFA0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C5F0 Offset: 0x119AFF0 VA: 0x18119C5F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF41E0 Offset: 0xFF2BE0 VA: 0x180FF41E0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B610 Offset: 0x119A010 VA: 0x18119B610
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B5C0 Offset: 0x1199FC0 VA: 0x18119B5C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B3F0 Offset: 0x1199DF0 VA: 0x18119B3F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B610 Offset: 0x119A010 VA: 0x18119B610
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B5C0 Offset: 0x1199FC0 VA: 0x18119B5C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C770 Offset: 0x119B170 VA: 0x18119C770
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B490 Offset: 0x1199E90 VA: 0x18119B490
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B550 Offset: 0x1199F50 VA: 0x18119B550
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B3F0 Offset: 0x1199DF0 VA: 0x18119B3F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B440 Offset: 0x1199E40 VA: 0x18119B440
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B3F0 Offset: 0x1199DF0 VA: 0x18119B3F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B300 Offset: 0x1199D00 VA: 0x18119B300
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C5A0 Offset: 0x119AFA0 VA: 0x18119C5A0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B350 Offset: 0x1199D50 VA: 0x18119B350
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B5C0 Offset: 0x1199FC0 VA: 0x18119B5C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B440 Offset: 0x1199E40 VA: 0x18119B440
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C250 Offset: 0x119AC50 VA: 0x18119C250
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C370 Offset: 0x119AD70 VA: 0x18119C370
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCBFA0 Offset: 0xFCA9A0 VA: 0x180FCBFA0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B3F0 Offset: 0x1199DF0 VA: 0x18119B3F0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF41E0 Offset: 0xFF2BE0 VA: 0x180FF41E0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C430 Offset: 0x119AE30 VA: 0x18119C430
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B5C0 Offset: 0x1199FC0 VA: 0x18119B5C0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B750 Offset: 0x119A150 VA: 0x18119B750
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119C170 Offset: 0x119AB70 VA: 0x18119C170
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFCBFA0 Offset: 0xFCA9A0 VA: 0x180FCBFA0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF41E0 Offset: 0xFF2BE0 VA: 0x180FF41E0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/
}
