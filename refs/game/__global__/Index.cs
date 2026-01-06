internal sealed class Index // TypeDefIndex: 12979
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x209DCE0 Offset: 0x209C6E0 VA: 0x18209DCE0
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x209D850 Offset: 0x209C250 VA: 0x18209D850
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x209B5B0 Offset: 0x2099FB0 VA: 0x18209B5B0
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0x209D9B0 Offset: 0x209C3B0 VA: 0x18209D9B0
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x209AD20 Offset: 0x2099720 VA: 0x18209AD20
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x605160 Offset: 0x603B60 VA: 0x180605160
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	internal int get_ObjectID() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public DataViewRowState get_RecordStates() { }

	// RVA: 0x209DDD0 Offset: 0x209C7D0 VA: 0x18209DDD0
	public IFilter get_RowFilter() { }

	// RVA: 0x209BAD0 Offset: 0x209A4D0 VA: 0x18209BAD0
	public int GetRecord(int recordIndex) { }

	// RVA: 0x209DD80 Offset: 0x209C780 VA: 0x18209DD80
	public bool get_HasDuplicates() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_RecordCount() { }

	// RVA: 0x209A330 Offset: 0x2098D30 VA: 0x18209A330
	private bool AcceptRecord(int record) { }

	// RVA: 0x209A1E0 Offset: 0x2098BE0 VA: 0x18209A1E0
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0x209C850 Offset: 0x209B250 VA: 0x18209C850
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0x209C8B0 Offset: 0x209B2B0 VA: 0x18209C8B0
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public int get_RefCount() { }

	// RVA: 0x209A360 Offset: 0x2098D60 VA: 0x18209A360
	public void AddRef() { }

	// RVA: 0x209D4C0 Offset: 0x209BEC0 VA: 0x18209D4C0
	public int RemoveRef() { }

	// RVA: 0x209A560 Offset: 0x2098F60 VA: 0x18209A560
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0x209A630 Offset: 0x2099030 VA: 0x18209A630
	public bool CheckUnique() { }

	// RVA: 0x209A9E0 Offset: 0x20993E0 VA: 0x18209A9E0
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0x209A680 Offset: 0x2099080 VA: 0x18209A680
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0x209A700 Offset: 0x2099100 VA: 0x18209A700
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0x209A8F0 Offset: 0x20992F0 VA: 0x18209A8F0
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0x209ABE0 Offset: 0x20995E0 VA: 0x18209ABE0
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0x209AD10 Offset: 0x2099710 VA: 0x18209AD10
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0x209ABF0 Offset: 0x20995F0 VA: 0x18209ABF0
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0x209B6E0 Offset: 0x209A0E0 VA: 0x18209B6E0
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0x209B750 Offset: 0x209A150 VA: 0x18209B750
	public int GetIndex(int record) { }

	// RVA: 0x209B7B0 Offset: 0x209A1B0 VA: 0x18209B7B0
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0x209BE00 Offset: 0x209A800 VA: 0x18209BE00
	public object[] GetUniqueKeyValues() { }

	// RVA: 0x209AED0 Offset: 0x20998D0 VA: 0x18209AED0
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0x209B0D0 Offset: 0x2099AD0 VA: 0x18209B0D0
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0x209ADF0 Offset: 0x20997F0 VA: 0x18209ADF0
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0x209B950 Offset: 0x209A350 VA: 0x18209B950
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0x209B430 Offset: 0x2099E30 VA: 0x18209B430
	public Range FindRecords(object key) { }

	// RVA: 0x209B3E0 Offset: 0x2099DE0 VA: 0x18209B3E0
	public Range FindRecords(object[] key) { }

	// RVA: 0x209B480 Offset: 0x2099E80 VA: 0x18209B480
	internal void FireResetEvent() { }

	// RVA: 0x209B6C0 Offset: 0x209A0C0 VA: 0x18209B6C0
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x209BB30 Offset: 0x209A530 VA: 0x18209BB30
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0x209BB50 Offset: 0x209A550 VA: 0x18209BB50
	public DataRow GetRow(int i) { }

	// RVA: 0x209BDB0 Offset: 0x209A7B0 VA: 0x18209BDB0
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0x209BBE0 Offset: 0x209A5E0 VA: 0x18209BBE0
	public DataRow[] GetRows(Range range) { }

	// RVA: 0x209C120 Offset: 0x209AB20 VA: 0x18209C120
	private void InitRecords(IFilter filter) { }

	// RVA: 0x209C490 Offset: 0x209AE90 VA: 0x18209C490
	public int InsertRecordToIndex(int record) { }

	// RVA: 0x209C4F0 Offset: 0x209AEF0 VA: 0x18209C4F0
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0x209C730 Offset: 0x209B130 VA: 0x18209C730
	public bool IsKeyInIndex(object key) { }

	// RVA: 0x209C750 Offset: 0x209B150 VA: 0x18209C750
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0x209C770 Offset: 0x209B170 VA: 0x18209C770
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0x209DD10 Offset: 0x209C710 VA: 0x18209DD10
	private bool get_DoListChanged() { }

	// RVA: 0x209CB10 Offset: 0x209B510 VA: 0x18209CB10
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0x209CA40 Offset: 0x209B440 VA: 0x18209CA40
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0x209CC00 Offset: 0x209B600 VA: 0x18209CC00
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x209C910 Offset: 0x209B310 VA: 0x18209C910
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0x209D670 Offset: 0x209C070 VA: 0x18209D670
	public void Reset() { }

	// RVA: 0x209CEF0 Offset: 0x209B8F0 VA: 0x18209CEF0
	public void RecordChanged(int record) { }

	// RVA: 0x209CDB0 Offset: 0x209B7B0 VA: 0x18209CDB0
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0x209D3B0 Offset: 0x209BDB0 VA: 0x18209D3B0
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x209D030 Offset: 0x209BA30 VA: 0x18209D030
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal DataTable get_Table() { }

	// RVA: 0x209BED0 Offset: 0x209A8D0 VA: 0x18209BED0
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECA590 Offset: 0xEC8F90 VA: 0x180ECA590
	|-Index.IndexOfReference<object>
	*/
}
