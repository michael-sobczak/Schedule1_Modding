public class DataViewSetting // TypeDefIndex: 12925
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x208BFF0 Offset: 0x208A9F0 VA: 0x18208BFF0
	internal void .ctor() { }

	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x2072170 Offset: 0x2070B70 VA: 0x182072170
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x208BFD0 Offset: 0x208A9D0 VA: 0x18208BFD0
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_RowFilter() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Sort() { }
}
