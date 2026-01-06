public class ListViewGroupCollection : ICollection, IEnumerable, IList // TypeDefIndex: 5464
{
	// Fields
	private List<ListViewGroup> list; // 0x10
	private ListView list_view_owner; // 0x18
	private ListViewGroup default_group; // 0x20

	// Properties
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	public ListViewGroup Item { get; set; }
	internal int InternalCount { get; }
	internal ListViewGroup DefaultGroup { get; }

	// Methods

	// RVA: 0x236CC10 Offset: 0x236B610 VA: 0x18236CC10
	private void .ctor() { }

	// RVA: 0x236CCF0 Offset: 0x236B6F0 VA: 0x18236CCF0
	internal void .ctor(ListView listViewOwner) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x236C490 Offset: 0x236AE90 VA: 0x18236C490 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x236C550 Offset: 0x236AF50 VA: 0x18236C550 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x236C610 Offset: 0x236B010 VA: 0x18236C610 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x236C6D0 Offset: 0x236B0D0 VA: 0x18236C6D0 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x236C830 Offset: 0x236B230 VA: 0x18236C830 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x236C9B0 Offset: 0x236B3B0 VA: 0x18236C9B0 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x236CA70 Offset: 0x236B470 VA: 0x18236CA70 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x236C000 Offset: 0x236AA00 VA: 0x18236C000 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x236BF30 Offset: 0x236A930 VA: 0x18236BF30 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x236CE20 Offset: 0x236B820 VA: 0x18236CE20 Slot: 5
	public int get_Count() { }

	// RVA: 0x236B950 Offset: 0x236A350 VA: 0x18236B950
	public int Add(ListViewGroup group) { }

	// RVA: 0x236BD30 Offset: 0x236A730 VA: 0x18236BD30 Slot: 13
	public void Clear() { }

	// RVA: 0x236BED0 Offset: 0x236A8D0 VA: 0x18236BED0
	public bool Contains(ListViewGroup value) { }

	// RVA: 0x236C0F0 Offset: 0x236AAF0 VA: 0x18236C0F0
	public int IndexOf(ListViewGroup value) { }

	// RVA: 0x236C150 Offset: 0x236AB50 VA: 0x18236C150
	public void Insert(int index, ListViewGroup group) { }

	// RVA: 0x236C350 Offset: 0x236AD50 VA: 0x18236C350
	public void Remove(ListViewGroup group) { }

	// RVA: 0x236C260 Offset: 0x236AC60 VA: 0x18236C260 Slot: 19
	public void RemoveAt(int index) { }

	// RVA: 0x236C9B0 Offset: 0x236B3B0 VA: 0x18236C9B0
	public ListViewGroup get_Item(int index) { }

	// RVA: 0x236CEA0 Offset: 0x236B8A0 VA: 0x18236CEA0
	public void set_Item(int index, ListViewGroup value) { }

	// RVA: 0x236C080 Offset: 0x236AA80 VA: 0x18236C080
	internal ListViewGroup GetInternalGroup(int index) { }

	// RVA: 0x236CE60 Offset: 0x236B860 VA: 0x18236CE60
	internal int get_InternalCount() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal ListViewGroup get_DefaultGroup() { }

	// RVA: 0x236B800 Offset: 0x236A200 VA: 0x18236B800
	private void AddGroup(ListViewGroup group) { }

	// RVA: 0x236BB30 Offset: 0x236A530 VA: 0x18236BB30
	private void CheckListViewItemsInGroup(ListViewGroup value) { }
}
