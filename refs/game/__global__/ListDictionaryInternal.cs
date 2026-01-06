internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 4905
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1BFF960 Offset: 0x1BFE360 VA: 0x181BFF960 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1BFFB80 Offset: 0x1BFE580 VA: 0x181BFFB80 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 16
	public int get_Count() { }

	// RVA: 0x1BFFA30 Offset: 0x1BFE430 VA: 0x181BFFA30 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x1BFFAA0 Offset: 0x1BFE4A0 VA: 0x181BFFAA0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1BFFB10 Offset: 0x1BFE510 VA: 0x181BFFB10 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1BFF1F0 Offset: 0x1BFDBF0 VA: 0x181BFF1F0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1BFF3D0 Offset: 0x1BFDDD0 VA: 0x181BFF3D0 Slot: 10
	public void Clear() { }

	// RVA: 0x1BFF400 Offset: 0x1BFDE00 VA: 0x181BFF400 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1BFF4D0 Offset: 0x1BFDED0 VA: 0x181BFF4D0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1BFF720 Offset: 0x1BFE120 VA: 0x181BFF720 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1BFF8D0 Offset: 0x1BFE2D0 VA: 0x181BFF8D0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1BFF7B0 Offset: 0x1BFE1B0 VA: 0x181BFF7B0 Slot: 14
	public void Remove(object key) { }
}
