public class ListDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 9853
{
	// Fields
	private ListDictionary.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private readonly IComparer comparer; // 0x20
	private object _syncRoot; // 0x28

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

	// RVA: 0xBA33B0 Offset: 0xBA1DB0 VA: 0x180BA33B0
	public void .ctor(IComparer comparer) { }

	// RVA: 0x26ABFE0 Offset: 0x26AA9E0 VA: 0x1826ABFE0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x26AC270 Offset: 0x26AAC70 VA: 0x1826AC270 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 16
	public int get_Count() { }

	// RVA: 0x26AC120 Offset: 0x26AAB20 VA: 0x1826AC120 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x26AC190 Offset: 0x26AAB90 VA: 0x1826AC190 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x26AC200 Offset: 0x26AAC00 VA: 0x1826AC200 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x26AB860 Offset: 0x26AA260 VA: 0x1826AB860 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1BFF3D0 Offset: 0x1BFDDD0 VA: 0x181BFF3D0 Slot: 10
	public void Clear() { }

	// RVA: 0x26ABA60 Offset: 0x26AA460 VA: 0x1826ABA60 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x26ABB80 Offset: 0x26AA580 VA: 0x1826ABB80 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x26ABD70 Offset: 0x26AA770 VA: 0x1826ABD70 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x26ABF50 Offset: 0x26AA950 VA: 0x1826ABF50 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26ABE00 Offset: 0x26AA800 VA: 0x1826ABE00 Slot: 14
	public void Remove(object key) { }
}
