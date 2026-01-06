public class TraceListenerCollection : IList, ICollection, IEnumerable // TypeDefIndex: 9586
{
	// Fields
	private ArrayList list; // 0x10

	// Properties
	public int Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x263EAD0 Offset: 0x263D4D0 VA: 0x18263EAD0
	internal void .ctor() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 16
	public int get_Count() { }

	// RVA: 0x263E040 Offset: 0x263CA40 VA: 0x18263E040
	public int Add(TraceListener listener) { }

	// RVA: 0x263E160 Offset: 0x263CB60 VA: 0x18263E160 Slot: 8
	public void Clear() { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x263E1C0 Offset: 0x263CBC0 VA: 0x18263E1C0
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x263E300 Offset: 0x263CD00 VA: 0x18263E300 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x22B1070 Offset: 0x22AFA70 VA: 0x1822B1070 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x263E9B0 Offset: 0x263D3B0 VA: 0x18263E9B0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x263E510 Offset: 0x263CF10 VA: 0x18263E510 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1BF6D30 Offset: 0x1BF5730 VA: 0x181BF6D30 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1BF6D60 Offset: 0x1BF5760 VA: 0x181BF6D60 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x263E6E0 Offset: 0x263D0E0 VA: 0x18263E6E0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x263E8B0 Offset: 0x263D2B0 VA: 0x18263E8B0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x263E400 Offset: 0x263CE00 VA: 0x18263E400 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
}
