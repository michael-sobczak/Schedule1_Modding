public class DataRow // TypeDefIndex: 12898
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public string Item { set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x2078060 Offset: 0x2076A60 VA: 0x182078060
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0x2078350 Offset: 0x2076D50 VA: 0x182078350
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0x2078F90 Offset: 0x2077990 VA: 0x182078F90
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0x2078150 Offset: 0x2076B50 VA: 0x182078150
	internal bool get_HasPropertyChanged() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	internal int get_RBTreeNodeId() { }

	// RVA: 0x2078FA0 Offset: 0x20779A0 VA: 0x182078FA0
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0x2078360 Offset: 0x2076D60 VA: 0x182078360
	public string get_RowError() { }

	// RVA: 0x2079050 Offset: 0x2077A50 VA: 0x182079050
	public void set_RowError(string value) { }

	// RVA: 0x2077470 Offset: 0x2075E70 VA: 0x182077470
	private void RowErrorChanged() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal long get_rowID() { }

	// RVA: 0x2079270 Offset: 0x2077C70 VA: 0x182079270
	internal void set_rowID(long value) { }

	// RVA: 0x20783C0 Offset: 0x2076DC0 VA: 0x1820783C0
	public DataRowState get_RowState() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public DataTable get_Table() { }

	// RVA: 0x2075420 Offset: 0x2073E20 VA: 0x182075420
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0x20764F0 Offset: 0x2074EF0 VA: 0x1820764F0
	internal int GetNestedParentCount() { }

	// RVA: 0x2078A40 Offset: 0x2077440 VA: 0x182078A40
	public void set_Item(string columnName, object value) { }

	// RVA: 0x2078240 Offset: 0x2076C40 VA: 0x182078240
	public object get_Item(DataColumn column) { }

	// RVA: 0x2078AE0 Offset: 0x20774E0 VA: 0x182078AE0
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0x2078160 Offset: 0x2076B60 VA: 0x182078160
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0x2078570 Offset: 0x2076F70 VA: 0x182078570
	public void set_ItemArray(object[] value) { }

	// RVA: 0x2074F70 Offset: 0x2073970 VA: 0x182074F70
	public void AcceptChanges() { }

	[EditorBrowsable(2)]
	// RVA: 0x20752E0 Offset: 0x2073CE0 VA: 0x1820752E0
	public void BeginEdit() { }

	// RVA: 0x2075200 Offset: 0x2073C00 VA: 0x182075200
	private bool BeginEditInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x20752F0 Offset: 0x2073CF0 VA: 0x1820752F0
	public void CancelEdit() { }

	// RVA: 0x2075360 Offset: 0x2073D60 VA: 0x182075360
	private void CheckColumn(DataColumn column) { }

	// RVA: 0x2075520 Offset: 0x2073F20 VA: 0x182075520
	internal void CheckInTable() { }

	// RVA: 0x2075B00 Offset: 0x2074500 VA: 0x182075B00
	public void Delete() { }

	[EditorBrowsable(2)]
	// RVA: 0x2075B70 Offset: 0x2074570 VA: 0x182075B70
	public void EndEdit() { }

	// RVA: 0x20777A0 Offset: 0x20761A0 VA: 0x1820777A0
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0x20774C0 Offset: 0x2075EC0 VA: 0x1820774C0
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x2075F10 Offset: 0x2074910 VA: 0x182075F10
	public string GetColumnError(DataColumn column) { }

	// RVA: 0x2075670 Offset: 0x2074070 VA: 0x182075670
	public void ClearErrors() { }

	// RVA: 0x2075560 Offset: 0x2073F60 VA: 0x182075560
	internal void ClearError(DataColumn column) { }

	// RVA: 0x2078110 Offset: 0x2076B10 VA: 0x182078110
	public bool get_HasErrors() { }

	// RVA: 0x20761B0 Offset: 0x2074BB0 VA: 0x1820761B0
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0x2075C50 Offset: 0x2074650 VA: 0x182075C50
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0x2075C60 Offset: 0x2074660 VA: 0x182075C60
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x2076330 Offset: 0x2074D30 VA: 0x182076330
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0x2076850 Offset: 0x2075250 VA: 0x182076850
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0x20766D0 Offset: 0x20750D0 VA: 0x1820766D0
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x20765C0 Offset: 0x2074FC0 VA: 0x1820765C0
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0x2076B10 Offset: 0x2075510 VA: 0x182076B10
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0x2076860 Offset: 0x2075260 VA: 0x182076860
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x2076160 Offset: 0x2074B60 VA: 0x182076160
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0x2076100 Offset: 0x2074B00 VA: 0x182076100
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0x2076440 Offset: 0x2074E40 VA: 0x182076440
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0x20764C0 Offset: 0x2074EC0 VA: 0x1820764C0
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0x20762F0 Offset: 0x2074CF0 VA: 0x1820762F0
	internal int GetCurrentRecordNo() { }

	// RVA: 0x20763B0 Offset: 0x2074DB0 VA: 0x1820763B0
	internal int GetDefaultRecord() { }

	// RVA: 0x2076690 Offset: 0x2075090 VA: 0x182076690
	internal int GetOriginalRecordNo() { }

	// RVA: 0x2076B20 Offset: 0x2075520 VA: 0x182076B20
	private int GetProposedRecordNo() { }

	// RVA: 0x2076B60 Offset: 0x2075560 VA: 0x182076B60
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0x2076410 Offset: 0x2074E10 VA: 0x182076410
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0x2076C50 Offset: 0x2075650 VA: 0x182076C50
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0x2076CA0 Offset: 0x20756A0 VA: 0x182076CA0
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0x2076CD0 Offset: 0x20756D0 VA: 0x182076CD0
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x2076D60 Offset: 0x2075760 VA: 0x182076D60
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0x2076DF0 Offset: 0x20757F0 VA: 0x182076DF0
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0x2076E20 Offset: 0x2075820 VA: 0x182076E20
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x2076FA0 Offset: 0x20759A0 VA: 0x182076FA0
	public void RejectChanges() { }

	// RVA: 0x2077440 Offset: 0x2075E40 VA: 0x182077440
	internal void ResetLastChangedColumn() { }

	// RVA: 0x2077820 Offset: 0x2076220 VA: 0x182077820
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0x2077940 Offset: 0x2076340 VA: 0x182077940
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0x2077C80 Offset: 0x2076680 VA: 0x182077C80
	internal void SetParentRowToDBNull() { }

	// RVA: 0x2077EA0 Offset: 0x20768A0 VA: 0x182077EA0
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0x2075760 Offset: 0x2074160 VA: 0x182075760
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }
}
