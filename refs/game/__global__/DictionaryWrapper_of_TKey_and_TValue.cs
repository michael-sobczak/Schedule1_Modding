internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection // TypeDefIndex: 11132
{
	// Fields
	[Nullable(2)]
	private readonly IDictionary _dictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IDictionary<TKey, TValue> _genericDictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	internal IDictionary<TKey, TValue> GenericDictionary { get; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ECB40 Offset: 0x14EB540 VA: 0x1814ECB40
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ECC20 Offset: 0x14EB620 VA: 0x1814ECC20
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IReadOnlyDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ECBB0 Offset: 0x14EB5B0 VA: 0x1814ECBB0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IDictionary<TKey, TValue> get_GenericDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_GenericDictionary
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E9EF0 Offset: 0x14E88F0 VA: 0x1814E9EF0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EA520 Offset: 0x14E8F20 VA: 0x1814EA520
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED100 Offset: 0x14EBB00 VA: 0x1814ED100
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EB630 Offset: 0x14EA030 VA: 0x1814EB630
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC7B0 Offset: 0x14EB1B0 VA: 0x1814EC7B0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED270 Offset: 0x14EBC70 VA: 0x1814ED270
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ECE60 Offset: 0x14EB860 VA: 0x1814ECE60
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED3C0 Offset: 0x14EBDC0 VA: 0x1814ED3C0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EA180 Offset: 0x14E8B80 VA: 0x1814EA180
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EA420 Offset: 0x14E8E20 VA: 0x1814EA420
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EA740 Offset: 0x14E9140 VA: 0x1814EA740
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EA940 Offset: 0x14E9340 VA: 0x1814EA940
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ECC90 Offset: 0x14EB690 VA: 0x1814ECC90
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ECD80 Offset: 0x14EB780 VA: 0x1814ECD80
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EB130 Offset: 0x14E9B30 VA: 0x1814EB130
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EAEA0 Offset: 0x14E98A0 VA: 0x1814EAEA0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC790 Offset: 0x14EB190 VA: 0x1814EC790
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EBB10 Offset: 0x14EA510 VA: 0x1814EBB10
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC100 Offset: 0x14EAB00 VA: 0x1814EC100
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC550 Offset: 0x14EAF50 VA: 0x1814EC550
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EBF30 Offset: 0x14EA930 VA: 0x1814EBF30
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EBD50 Offset: 0x14EA750 VA: 0x1814EBD50
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC090 Offset: 0x14EAA90 VA: 0x1814EC090
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC350 Offset: 0x14EAD50 VA: 0x1814EC350
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EB490 Offset: 0x14E9E90 VA: 0x1814EB490
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EC450 Offset: 0x14EAE50 VA: 0x1814EC450
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EB880 Offset: 0x14EA280 VA: 0x1814EB880
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EBA50 Offset: 0x14EA450 VA: 0x1814EBA50
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14EBAA0 Offset: 0x14EA4A0 VA: 0x1814EBAA0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public object get_UnderlyingDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ED240 Offset: 0x14EBC40 VA: 0x1814ED240
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_UnderlyingDictionary
	*/
}
