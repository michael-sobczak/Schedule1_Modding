public class BaseCollection : MarshalByRefObject, ICollection, IEnumerable // TypeDefIndex: 5237
{
	// Fields
	internal ArrayList list; // 0x18

	// Properties
	[EditorBrowsable(2)]
	[Browsable(False)]
	public virtual int Count { get; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[EditorBrowsable(2)]
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x207E3E0 Offset: 0x207CDE0 VA: 0x18207E3E0 Slot: 11
	public virtual int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 8
	public object get_SyncRoot() { }

	// RVA: 0x21C38C0 Offset: 0x21C22C0 VA: 0x1821C38C0 Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x207E1C0 Offset: 0x207CBC0 VA: 0x18207E1C0 Slot: 6
	public void CopyTo(Array ar, int index) { }

	// RVA: 0x207E220 Offset: 0x207CC20 VA: 0x18207E220 Slot: 10
	public IEnumerator GetEnumerator() { }
}
