internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 12971
{
	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB8
	private readonly DataKey _childKey; // 0xC8
	private readonly DataRowView _parentRowView; // 0xD0
	private readonly object[] _filterValues; // 0xD8

	// Methods

	// RVA: 0x20A3990 Offset: 0x20A2390 VA: 0x1820A3990
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0x20A3B00 Offset: 0x20A2500 VA: 0x1820A3B00
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0x20A3740 Offset: 0x20A2140 VA: 0x1820A3740
	private object[] GetParentValues() { }

	// RVA: 0x20A37F0 Offset: 0x20A21F0 VA: 0x1820A37F0 Slot: 54
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 48
	internal override IFilter GetFilter() { }

	// RVA: 0x20A36D0 Offset: 0x20A20D0 VA: 0x1820A36D0 Slot: 47
	public override DataRowView AddNew() { }

	// RVA: 0x20A3960 Offset: 0x20A2360 VA: 0x1820A3960 Slot: 51
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }
}
