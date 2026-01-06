public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 12888
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x206C4E0 Offset: 0x206AEE0 VA: 0x18206C4E0
	internal void .ctor(DataTable table) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x206C7F0 Offset: 0x206B1F0 VA: 0x18206C7F0
	public DataColumn get_Item(int index) { }

	// RVA: 0x206C8D0 Offset: 0x206B2D0 VA: 0x18206C8D0
	public DataColumn get_Item(string name) { }

	// RVA: 0x206C740 Offset: 0x206B140 VA: 0x18206C740
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x2069ED0 Offset: 0x20688D0 VA: 0x182069ED0
	public void Add(DataColumn column) { }

	// RVA: 0x2069AA0 Offset: 0x20684A0 VA: 0x182069AA0
	internal void AddAt(int index, DataColumn column) { }

	[CompilerGenerated]
	// RVA: 0x206C600 Offset: 0x206B000 VA: 0x18206C600
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x206CA40 Offset: 0x206B440 VA: 0x18206CA40
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x206C6A0 Offset: 0x206B0A0 VA: 0x18206C6A0
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x206CAE0 Offset: 0x206B4E0 VA: 0x18206CAE0
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x2069F50 Offset: 0x2068950 VA: 0x182069F50
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x2069EE0 Offset: 0x20688E0 VA: 0x182069EE0
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x2069FF0 Offset: 0x20689F0 VA: 0x182069FF0
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x206A260 Offset: 0x2068C60 VA: 0x18206A260
	internal string AssignName() { }

	// RVA: 0x206A380 Offset: 0x2068D80 VA: 0x18206A380
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x206A7B0 Offset: 0x20691B0 VA: 0x18206A7B0
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x206A9E0 Offset: 0x20693E0 VA: 0x18206A9E0
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x206AC50 Offset: 0x2069650 VA: 0x18206AC50
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x206B5A0 Offset: 0x2069FA0 VA: 0x18206B5A0
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x206B5F0 Offset: 0x2069FF0 VA: 0x18206B5F0
	public void Clear() { }

	// RVA: 0x206BAB0 Offset: 0x206A4B0 VA: 0x18206BAB0
	public bool Contains(string name) { }

	// RVA: 0x206B9F0 Offset: 0x206A3F0 VA: 0x18206B9F0
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x206BCE0 Offset: 0x206A6E0 VA: 0x18206BCE0
	public int IndexOf(string columnName) { }

	// RVA: 0x206BB40 Offset: 0x206A540 VA: 0x18206BB40
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x206BDF0 Offset: 0x206A7F0 VA: 0x18206BDF0
	private string MakeName(int index) { }

	// RVA: 0x206BE90 Offset: 0x206A890 VA: 0x18206BE90
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x206BF30 Offset: 0x206A930 VA: 0x18206BF30
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x206BF50 Offset: 0x206A950 VA: 0x18206BF50
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x206BFA0 Offset: 0x206A9A0 VA: 0x18206BFA0
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x206ABF0 Offset: 0x20695F0 VA: 0x18206ABF0
	internal bool CanRegisterName(string name) { }

	// RVA: 0x206C2A0 Offset: 0x206ACA0 VA: 0x18206C2A0
	public void Remove(DataColumn column) { }

	// RVA: 0x206C3B0 Offset: 0x206ADB0 VA: 0x18206C3B0
	internal void UnregisterName(string name) { }

	// RVA: 0x2069DE0 Offset: 0x20687E0 VA: 0x182069DE0
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x206C140 Offset: 0x206AB40 VA: 0x18206C140
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }
}
