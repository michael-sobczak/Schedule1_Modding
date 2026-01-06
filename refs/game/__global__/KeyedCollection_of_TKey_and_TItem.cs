public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> // TypeDefIndex: 4954
{
	// Fields
	private readonly IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary<TKey, TItem> dict; // 0x0
	private int keyCount; // 0x0
	private readonly int threshold; // 0x0

	// Properties
	private List<TItem> Items { get; }
	public TItem Item { get; }
	protected IDictionary<TKey, TItem> Dictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D0D20 Offset: 0x18CF720 VA: 0x1818D0D20
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x1624930 Offset: 0x1623330 VA: 0x181624930
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D0940 Offset: 0x18CF340 VA: 0x1818D0940
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x1625590 Offset: 0x1623F90 VA: 0x181625590
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D0B00 Offset: 0x18CF500 VA: 0x1818D0B00
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x18D0D40 Offset: 0x18CF740 VA: 0x1818D0D40
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private List<TItem> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1270 Offset: 0x18CFC70 VA: 0x1818D1270
	|-KeyedCollection<object, object>.get_Items
	|
	|-RVA: 0x18D11C0 Offset: 0x18CFBC0 VA: 0x1818D11C0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public TItem get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D1100 Offset: 0x18CFB00 VA: 0x1818D1100
	|-KeyedCollection<object, object>.get_Item
	|
	|-RVA: 0x18D0E80 Offset: 0x18CF880 VA: 0x1818D0E80
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CE480 Offset: 0x18CCE80 VA: 0x1818CE480
	|-KeyedCollection<object, object>.Contains
	|
	|-RVA: 0x18CDEE0 Offset: 0x18CC8E0 VA: 0x1818CDEE0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CFFD0 Offset: 0x18CE9D0 VA: 0x1818CFFD0
	|-KeyedCollection<object, object>.TryGetValue
	|
	|-RVA: 0x18D02C0 Offset: 0x18CECC0 VA: 0x1818D02C0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	protected IDictionary<TKey, TItem> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-KeyedCollection<object, object>.get_Dictionary
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CDE70 Offset: 0x18CC870 VA: 0x1818CDE70
	|-KeyedCollection<object, object>.ClearItems
	|
	|-RVA: 0x18CDE00 Offset: 0x18CC800 VA: 0x1818CDE00
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract TKey GetKeyForItem(TItem item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyForItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CEE90 Offset: 0x18CD890 VA: 0x1818CEE90
	|-KeyedCollection<object, object>.InsertItem
	|
	|-RVA: 0x18CEF20 Offset: 0x18CD920 VA: 0x1818CEF20
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CF210 Offset: 0x18CDC10 VA: 0x1818CF210
	|-KeyedCollection<object, object>.RemoveItem
	|
	|-RVA: 0x18CF370 Offset: 0x18CDD70 VA: 0x1818CF370
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CF700 Offset: 0x18CE100 VA: 0x1818CF700
	|-KeyedCollection<object, object>.SetItem
	|
	|-RVA: 0x18CF920 Offset: 0x18CE320 VA: 0x1818CF920
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	private void AddKey(TKey key, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CDCE0 Offset: 0x18CC6E0 VA: 0x1818CDCE0
	|-KeyedCollection<object, object>.AddKey
	|
	|-RVA: 0x18CD9E0 Offset: 0x18CC3E0 VA: 0x1818CD9E0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddKey
	*/

	// RVA: -1 Offset: -1
	private void CreateDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CE730 Offset: 0x18CD130 VA: 0x1818CE730
	|-KeyedCollection<object, object>.CreateDictionary
	|
	|-RVA: 0x18CE980 Offset: 0x18CD380 VA: 0x1818CE980
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDictionary
	*/

	// RVA: -1 Offset: -1
	private void RemoveKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18CF5D0 Offset: 0x18CDFD0 VA: 0x1818CF5D0
	|-KeyedCollection<object, object>.RemoveKey
	|
	|-RVA: 0x18CF610 Offset: 0x18CE010 VA: 0x1818CF610
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveKey
	*/
}
