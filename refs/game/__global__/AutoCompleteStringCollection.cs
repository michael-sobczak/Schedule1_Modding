public class AutoCompleteStringCollection : ICollection, IList // TypeDefIndex: 5233
{
	// Fields
	private ArrayList list; // 0x10
	private CollectionChangeEventHandler CollectionChanged; // 0x18

	// Properties
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public bool IsReadOnly { get; }
	public string Item { get; set; }

	// Methods

	// RVA: 0x21C35D0 Offset: 0x21C1FD0 VA: 0x1821C35D0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x21C36F0 Offset: 0x21C20F0 VA: 0x1821C36F0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1BF6B90 Offset: 0x1BF5590 VA: 0x181BF6B90 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x21C3060 Offset: 0x21C1A60 VA: 0x1821C3060 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x21C3160 Offset: 0x21C1B60 VA: 0x1821C3160 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x21C31E0 Offset: 0x21C1BE0 VA: 0x1821C31E0 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x21C3260 Offset: 0x21C1C60 VA: 0x1821C3260 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x21C3360 Offset: 0x21C1D60 VA: 0x1821C3360 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x21C3450 Offset: 0x21C1E50 VA: 0x1821C3450 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x21C3460 Offset: 0x21C1E60 VA: 0x1821C3460 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x21C2EC0 Offset: 0x21C18C0 VA: 0x1821C2EC0
	protected void OnCollectionChanged(CollectionChangeEventArgs e) { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 5
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x21C2CB0 Offset: 0x21C16B0 VA: 0x1821C2CB0
	public int Add(string value) { }

	// RVA: 0x21C2D70 Offset: 0x21C1770 VA: 0x1821C2D70 Slot: 13
	public void Clear() { }

	// RVA: 0x1BF6D30 Offset: 0x1BF5730 VA: 0x181BF6D30
	public bool Contains(string value) { }

	// RVA: 0x1BF6D60 Offset: 0x1BF5760 VA: 0x181BF6D60
	public int IndexOf(string value) { }

	// RVA: 0x21C2E10 Offset: 0x21C1810 VA: 0x1821C2E10
	public void Insert(int index, string value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 20
	public bool get_IsReadOnly() { }

	// RVA: 0x21C2FB0 Offset: 0x21C19B0 VA: 0x1821C2FB0
	public void Remove(string value) { }

	// RVA: 0x21C2EF0 Offset: 0x21C18F0 VA: 0x1821C2EF0 Slot: 19
	public void RemoveAt(int index) { }

	// RVA: 0x21C3670 Offset: 0x21C2070 VA: 0x1821C3670
	public string get_Item(int index) { }

	// RVA: 0x21C3790 Offset: 0x21C2190 VA: 0x1821C3790
	public void set_Item(int index, string value) { }
}
