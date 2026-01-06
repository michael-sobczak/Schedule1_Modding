public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 4909
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1BF7340 Offset: 0x1BF5D40 VA: 0x181BF7340
	protected void .ctor() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected ArrayList get_InnerList() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	protected IList get_List() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 16
	public int get_Count() { }

	// RVA: 0x1BF6930 Offset: 0x1BF5330 VA: 0x181BF6930 Slot: 8
	public void Clear() { }

	// RVA: 0x1BF69F0 Offset: 0x1BF53F0 VA: 0x181BF69F0 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1B565B0 Offset: 0x1B54FB0 VA: 0x181B565B0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1BF7070 Offset: 0x1BF5A70 VA: 0x181BF7070 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1BF6BC0 Offset: 0x1BF55C0 VA: 0x181BF6BC0 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1BF6BF0 Offset: 0x1BF55F0 VA: 0x181BF6BF0 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1BF6B90 Offset: 0x1BF5590 VA: 0x181BF6B90 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1BF70A0 Offset: 0x1BF5AA0 VA: 0x181BF70A0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1BF7170 Offset: 0x1BF5B70 VA: 0x181BF7170 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1BF6D30 Offset: 0x1BF5730 VA: 0x181BF6D30 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1BF6C20 Offset: 0x1BF5620 VA: 0x181BF6C20 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1BF6F10 Offset: 0x1BF5910 VA: 0x181BF6F10 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1BF6D60 Offset: 0x1BF5760 VA: 0x181BF6D60 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1BF6D90 Offset: 0x1BF5790 VA: 0x181BF6D90 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 20
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	protected virtual void OnClear() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 23
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x1BF6990 Offset: 0x1BF5390 VA: 0x181BF6990 Slot: 24
	protected virtual void OnValidate(object value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 25
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 26
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 27
	protected virtual void OnClearComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 28
	protected virtual void OnRemoveComplete(int index, object value) { }
}
