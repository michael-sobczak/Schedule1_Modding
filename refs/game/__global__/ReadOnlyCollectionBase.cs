public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4913
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1C02050 Offset: 0x1C00A50 VA: 0x181C02050
	protected ArrayList get_InnerList() { }

	// RVA: 0x1C02010 Offset: 0x1C00A10 VA: 0x181C02010 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1C01F90 Offset: 0x1C00990 VA: 0x181C01F90 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1C01FD0 Offset: 0x1C009D0 VA: 0x181C01FD0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1C01F40 Offset: 0x1C00940 VA: 0x181C01F40 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1C01F00 Offset: 0x1C00900 VA: 0x181C01F00 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
