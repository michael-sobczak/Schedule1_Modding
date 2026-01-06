public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 9607
{
	// Fields
	private readonly List<Oid> _list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x262E5A0 Offset: 0x262CFA0 VA: 0x18262E5A0
	public void .ctor() { }

	// RVA: 0x262E210 Offset: 0x262CC10 VA: 0x18262E210
	public int Add(Oid oid) { }

	// RVA: 0x262E660 Offset: 0x262D060 VA: 0x18262E660
	public Oid get_Item(int index) { }

	// RVA: 0x262E620 Offset: 0x262D020 VA: 0x18262E620 Slot: 5
	public int get_Count() { }

	// RVA: 0x262E2F0 Offset: 0x262CCF0 VA: 0x18262E2F0
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x262E2F0 Offset: 0x262CCF0 VA: 0x18262E2F0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x262E360 Offset: 0x262CD60 VA: 0x18262E360 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }
}
