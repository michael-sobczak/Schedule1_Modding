public class DataViewSettingCollection : ICollection, IEnumerable // TypeDefIndex: 12927
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x208BC70 Offset: 0x208A670 VA: 0x18208BC70
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0x208BD80 Offset: 0x208A780 VA: 0x18208BD80 Slot: 9
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x208BF10 Offset: 0x208A910 VA: 0x18208BF10 Slot: 10
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x208B8D0 Offset: 0x208A2D0 VA: 0x18208B8D0 Slot: 4
	public void CopyTo(Array ar, int index) { }

	// RVA: 0x208BD30 Offset: 0x208A730 VA: 0x18208BD30 Slot: 11
	public virtual int get_Count() { }

	// RVA: 0x208BB40 Offset: 0x208A540 VA: 0x18208BB40 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x208BC40 Offset: 0x208A640 VA: 0x18208BC40
	internal void Remove(DataTable table) { }
}
