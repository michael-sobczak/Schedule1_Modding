public class HybridDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 9848
{
	// Fields
	private ListDictionary list; // 0x10
	private Hashtable hashtable; // 0x18
	private readonly bool caseInsensitive; // 0x20

	// Properties
	public object Item { get; set; }
	private ListDictionary List { get; }
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

	// RVA: 0x26A73F0 Offset: 0x26A5DF0 VA: 0x1826A73F0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x26A7800 Offset: 0x26A6200 VA: 0x1826A7800 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x26A7660 Offset: 0x26A6060 VA: 0x1826A7660
	private ListDictionary get_List() { }

	// RVA: 0x26A6900 Offset: 0x26A5300 VA: 0x1826A6900
	private void ChangeOver() { }

	// RVA: 0x26A73C0 Offset: 0x26A5DC0 VA: 0x1826A73C0 Slot: 16
	public int get_Count() { }

	// RVA: 0x26A75C0 Offset: 0x26A5FC0 VA: 0x1826A75C0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x26A7760 Offset: 0x26A6160 VA: 0x1826A7760 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x26A67B0 Offset: 0x26A51B0 VA: 0x1826A67B0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x26A6C60 Offset: 0x26A5660 VA: 0x1826A6C60 Slot: 10
	public void Clear() { }

	// RVA: 0x26A6CF0 Offset: 0x26A56F0 VA: 0x1826A6CF0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x26A6EA0 Offset: 0x26A58A0 VA: 0x1826A6EA0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x26A6F10 Offset: 0x26A5910 VA: 0x1826A6F10 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x26A7260 Offset: 0x26A5C60 VA: 0x1826A7260 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26A7070 Offset: 0x26A5A70 VA: 0x1826A7070 Slot: 14
	public void Remove(object key) { }
}
