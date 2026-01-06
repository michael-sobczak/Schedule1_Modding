public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 4169
{
	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[Obsolete]
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1AD1E70 Offset: 0x1AD0870 VA: 0x181AD1E70 Slot: 5
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }

	[Obsolete]
	// RVA: 0x1AD1CD0 Offset: 0x1AD06D0 VA: 0x181AD1CD0 Slot: 4
	public void CopyTo(Array array, int index) { }

	[Obsolete]
	// RVA: 0x1AD1DA0 Offset: 0x1AD07A0 VA: 0x181AD1DA0 Slot: 8
	public IEnumerator GetEnumerator() { }
}
