public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList // TypeDefIndex: 12920
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private string _delayedSort; // 0x88
	private DataViewRowState _delayedRecordStates; // 0x90
	private bool _fInitInProgress; // 0x94
	private bool _fEndInitInProgress; // 0x95
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x98
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0xA0
	private DataViewListener _dvListener; // 0xA8
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xB0

	// Properties
	[DefaultValue(True)]
	public bool AllowDelete { get; }
	[DefaultValue(True)]
	public bool AllowEdit { get; }
	[DefaultValue(True)]
	public bool AllowNew { get; }
	[Browsable(False)]
	public int Count { get; }
	private int CountFromIndex { get; }
	[Browsable(False)]
	public DataViewManager DataViewManager { get; }
	[Browsable(False)]
	protected bool IsOpen { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DefaultValue(22)]
	public DataViewRowState RowStateFilter { get; }
	[DefaultValue("")]
	public string Sort { get; set; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[DefaultValue(null)]
	[RefreshProperties(1)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x208FD30 Offset: 0x208E730 VA: 0x18208FD30
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x2090080 Offset: 0x208EA80 VA: 0x182090080
	public void .ctor(DataTable table) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_AllowDelete() { }

	// RVA: 0x208F640 Offset: 0x208E040 VA: 0x18208F640
	public bool get_AllowEdit() { }

	// RVA: 0x208F650 Offset: 0x208E050 VA: 0x18208F650
	public bool get_AllowNew() { }

	// RVA: 0x2090250 Offset: 0x208EC50 VA: 0x182090250 Slot: 41
	public int get_Count() { }

	// RVA: 0x2090220 Offset: 0x208EC20 VA: 0x182090220
	private int get_CountFromIndex() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x20902A0 Offset: 0x208ECA0 VA: 0x1820902A0
	protected bool get_IsOpen() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 43
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x20902B0 Offset: 0x208ECB0 VA: 0x1820902B0
	public string get_Sort() { }

	// RVA: 0x2090440 Offset: 0x208EE40 VA: 0x182090440
	public void set_Sort(string value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 42
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DataTable get_Table() { }

	// RVA: 0x208F0A0 Offset: 0x208DAA0 VA: 0x18208F0A0 Slot: 29
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x208F100 Offset: 0x208DB00 VA: 0x18208F100 Slot: 30
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x208F0A0 Offset: 0x208DAA0 VA: 0x18208F0A0
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x208C310 Offset: 0x208AD10 VA: 0x18208C310 Slot: 47
	public virtual DataRowView AddNew() { }

	// RVA: 0x208C5D0 Offset: 0x208AFD0 VA: 0x18208C5D0
	private void CheckOpen() { }

	// RVA: 0x208C610 Offset: 0x208B010 VA: 0x18208C610
	private void CheckSort(string sort) { }

	// RVA: 0x208C8B0 Offset: 0x208B2B0 VA: 0x18208C8B0
	protected void Close() { }

	// RVA: 0x208CB60 Offset: 0x208B560 VA: 0x18208CB60 Slot: 40
	public void CopyTo(Array array, int index) { }

	// RVA: 0x208CCC0 Offset: 0x208B6C0 VA: 0x18208CCC0
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x208D1C0 Offset: 0x208BBC0 VA: 0x18208D1C0
	public void Delete(int index) { }

	// RVA: 0x208CFD0 Offset: 0x208B9D0 VA: 0x18208CFD0
	internal void Delete(DataRow row) { }

	// RVA: 0x208D1F0 Offset: 0x208BBF0 VA: 0x18208D1F0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x208D260 Offset: 0x208BC60 VA: 0x18208D260
	internal void FinishAddNew(bool success) { }

	// RVA: 0x208D450 Offset: 0x208BE50 VA: 0x18208D450 Slot: 44
	public IEnumerator GetEnumerator() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 34
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 35
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x208ED50 Offset: 0x208D750 VA: 0x18208ED50 Slot: 31
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x208EDE0 Offset: 0x208D7E0 VA: 0x18208EDE0 Slot: 33
	private void System.Collections.IList.Clear() { }

	// RVA: 0x208EE10 Offset: 0x208D810 VA: 0x18208EE10 Slot: 32
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x208EEA0 Offset: 0x208D8A0 VA: 0x18208EEA0 Slot: 36
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x208DC00 Offset: 0x208C600 VA: 0x18208DC00
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x208DBA0 Offset: 0x208C5A0 VA: 0x18208DBA0
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x208EF30 Offset: 0x208D930 VA: 0x18208EF30 Slot: 37
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x208EF60 Offset: 0x208D960 VA: 0x18208EF60 Slot: 38
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x208D1C0 Offset: 0x208BBC0 VA: 0x18208D1C0 Slot: 39
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x208D4F0 Offset: 0x208BEF0 VA: 0x18208D4F0
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0x208F650 Offset: 0x208E050 VA: 0x18208F650 Slot: 12
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x208F180 Offset: 0x208DB80 VA: 0x18208F180 Slot: 13
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x208F640 Offset: 0x208E040 VA: 0x18208F640 Slot: 14
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0 Slot: 15
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 16
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 17
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 18
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x208F660 Offset: 0x208E060 VA: 0x18208F660 Slot: 19
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x208F700 Offset: 0x208E100 VA: 0x18208F700 Slot: 20
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x208D9B0 Offset: 0x208C3B0 VA: 0x18208D9B0
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0x208F6C0 Offset: 0x208E0C0 VA: 0x18208F6C0 Slot: 21
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x20900F0 Offset: 0x208EAF0 VA: 0x1820900F0 Slot: 22
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x2090310 Offset: 0x208ED10 VA: 0x182090310 Slot: 23
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x208F130 Offset: 0x208DB30 VA: 0x18208F130 Slot: 24
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0x208F1A0 Offset: 0x208DBA0 VA: 0x18208F1A0 Slot: 25
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x208F2B0 Offset: 0x208DCB0 VA: 0x18208F2B0 Slot: 26
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0x208F530 Offset: 0x208DF30 VA: 0x18208F530 Slot: 27
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0x208F580 Offset: 0x208DF80 VA: 0x18208F580 Slot: 28
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x208CEE0 Offset: 0x208B8E0 VA: 0x18208CEE0
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x208F860 Offset: 0x208E260 VA: 0x18208F860 Slot: 45
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x208F790 Offset: 0x208E190 VA: 0x18208F790 Slot: 46
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0 Slot: 48
	internal virtual IFilter GetFilter() { }

	// RVA: 0x208D6B0 Offset: 0x208C0B0 VA: 0x18208D6B0
	private int GetRecord(int recordIndex) { }

	// RVA: 0x208D850 Offset: 0x208C250 VA: 0x18208D850
	internal DataRow GetRow(int index) { }

	// RVA: 0x208D7D0 Offset: 0x208C1D0 VA: 0x18208D7D0
	private DataRowView GetRowView(int record) { }

	// RVA: 0x208D770 Offset: 0x208C170 VA: 0x18208D770
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x208DB10 Offset: 0x208C510 VA: 0x18208DB10 Slot: 49
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x208DA40 Offset: 0x208C440 VA: 0x18208DA40
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x208DD50 Offset: 0x208C750 VA: 0x18208DD50
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x208E040 Offset: 0x208CA40 VA: 0x18208E040 Slot: 50
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x208E870 Offset: 0x208D270 VA: 0x18208E870
	protected void Reset() { }

	// RVA: 0x208E5F0 Offset: 0x208CFF0 VA: 0x18208E5F0
	internal void ResetRowViewCache() { }

	// RVA: 0x208E8A0 Offset: 0x208D2A0 VA: 0x18208E8A0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x208ED30 Offset: 0x208D730 VA: 0x18208ED30 Slot: 51
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x208EAF0 Offset: 0x208D4F0 VA: 0x18208EAF0
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x208FC80 Offset: 0x208E680 VA: 0x18208FC80
	protected void UpdateIndex() { }

	// RVA: 0x208FCA0 Offset: 0x208E6A0 VA: 0x18208FCA0 Slot: 52
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x208F910 Offset: 0x208E310 VA: 0x18208F910
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x208C670 Offset: 0x208B070 VA: 0x18208C670
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x208E3B0 Offset: 0x208CDB0 VA: 0x18208E3B0
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x208C920 Offset: 0x208B320 VA: 0x18208C920 Slot: 53
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x208C900 Offset: 0x208B300 VA: 0x18208C900
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xBBA740 Offset: 0xBB9140 VA: 0x180BBA740
	internal int get_ObjectID() { }

	// RVA: 0x208FCB0 Offset: 0x208E6B0 VA: 0x18208FCB0
	private static void .cctor() { }
}
