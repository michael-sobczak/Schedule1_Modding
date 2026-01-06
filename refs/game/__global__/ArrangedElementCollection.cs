public class ArrangedElementCollection : ICollection, IEnumerable, IList // TypeDefIndex: 5865
{
	// Fields
	internal ArrayList list; // 0x10

	// Properties
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	internal bool IsFixedSize { get; }
	internal object Item { get; set; }

	// Methods

	// RVA: 0x22B10A0 Offset: 0x22AFAA0 VA: 0x1822B10A0
	internal void .ctor() { }

	// RVA: 0x226C4A0 Offset: 0x226AEA0 VA: 0x18226C4A0 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x20C7760 Offset: 0x20C6160 VA: 0x1820C7760 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1BF6D30 Offset: 0x1BF5730 VA: 0x181BF6D30 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1BF6D60 Offset: 0x1BF5760 VA: 0x181BF6D60 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x22B1000 Offset: 0x22AFA00 VA: 0x1822B1000 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1BF7070 Offset: 0x1BF5A70 VA: 0x181BF7070 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x22B0F60 Offset: 0x22AF960 VA: 0x1822B0F60 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x22B1040 Offset: 0x22AFA40 VA: 0x1822B1040 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x22B1070 Offset: 0x22AFA70 VA: 0x1822B1070 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x21C3E20 Offset: 0x21C2820 VA: 0x1821C3E20 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1BF6BC0 Offset: 0x1BF55C0 VA: 0x181BF6BC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x22B0F90 Offset: 0x22AF990 VA: 0x1822B0F90 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 20
	public virtual int get_Count() { }

	// RVA: 0x1B565B0 Offset: 0x1B54FB0 VA: 0x181B565B0 Slot: 21
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1BF6B90 Offset: 0x1BF5590 VA: 0x181BF6B90 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x22B0EB0 Offset: 0x22AF8B0 VA: 0x1822B0EB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 22
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x226C4A0 Offset: 0x226AEA0 VA: 0x18226C4A0
	internal int Add(object value) { }

	// RVA: 0x20C7760 Offset: 0x20C6160 VA: 0x1820C7760
	internal void Clear() { }

	// RVA: 0x1BF6D30 Offset: 0x1BF5730 VA: 0x181BF6D30
	internal bool Contains(object value) { }

	// RVA: 0x1BF6D60 Offset: 0x1BF5760 VA: 0x181BF6D60
	internal int IndexOf(object value) { }

	// RVA: 0x22B0F30 Offset: 0x22AF930 VA: 0x1822B0F30
	internal void Insert(int index, object value) { }

	// RVA: 0x1BF7070 Offset: 0x1BF5A70 VA: 0x181BF7070
	internal bool get_IsFixedSize() { }

	// RVA: 0x22B0F60 Offset: 0x22AF960 VA: 0x1822B0F60
	internal void Remove(object value) { }

	// RVA: 0x22B1070 Offset: 0x22AFA70 VA: 0x1822B1070
	internal object get_Item(int index) { }

	// RVA: 0x21C3E20 Offset: 0x21C2820 VA: 0x1821C3E20
	internal void set_Item(int index, object value) { }
}
