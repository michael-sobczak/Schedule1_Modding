public class BindingContext : ICollection, IEnumerable // TypeDefIndex: 5243
{
	// Fields
	private Hashtable managers; // 0x10
	private EventHandler onCollectionChangedHandler; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public BindingManagerBase Item { get; }
	public BindingManagerBase Item { get; }

	// Methods

	// RVA: 0x21C3E80 Offset: 0x21C2880 VA: 0x1821C3E80
	public void .ctor() { }

	// RVA: 0x21C3E20 Offset: 0x21C2820 VA: 0x1821C3E20 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array ar, int index) { }

	// RVA: 0x21C3E50 Offset: 0x21C2850 VA: 0x1821C3E50 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	[MonoInternalNote("our enumerator is slightly different.  in MS's implementation the Values are WeakReferences to the managers.")]
	// RVA: 0x1ABB2C0 Offset: 0x1AB9CC0 VA: 0x181ABB2C0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21C41C0 Offset: 0x21C2BC0 VA: 0x1821C41C0
	public BindingManagerBase get_Item(object dataSource) { }

	// RVA: 0x21C3F00 Offset: 0x21C2900 VA: 0x1821C3F00
	public BindingManagerBase get_Item(object dataSource, string dataMember) { }

	// RVA: 0x21C3A70 Offset: 0x21C2470 VA: 0x1821C3A70
	private BindingManagerBase CreateBindingManager(object data_source, string data_member) { }

	// RVA: 0x21C3D10 Offset: 0x21C2710 VA: 0x1821C3D10
	private bool IsListType(Type t) { }
}
