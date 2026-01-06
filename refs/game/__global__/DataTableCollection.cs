public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 12914
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x207C790 Offset: 0x207B190 VA: 0x18207C790
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	internal int get_ObjectID() { }

	// RVA: 0x207CB10 Offset: 0x207B510 VA: 0x18207CB10
	public DataTable get_Item(int index) { }

	// RVA: 0x207CA00 Offset: 0x207B400 VA: 0x18207CA00
	public DataTable get_Item(string name) { }

	// RVA: 0x207CBF0 Offset: 0x207B5F0 VA: 0x18207CBF0
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x207B830 Offset: 0x207A230 VA: 0x18207B830
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x207B6D0 Offset: 0x207A0D0 VA: 0x18207B6D0
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x207A0A0 Offset: 0x2078AA0 VA: 0x18207A0A0
	public void Add(DataTable table) { }

	// RVA: 0x207C8F0 Offset: 0x207B2F0 VA: 0x18207C8F0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x207CD20 Offset: 0x207B720 VA: 0x18207CD20
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x207A300 Offset: 0x2078D00 VA: 0x18207A300
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x207A330 Offset: 0x2078D30 VA: 0x18207A330
	internal string AssignName() { }

	// RVA: 0x207A400 Offset: 0x2078E00 VA: 0x18207A400
	private void BaseAdd(DataTable table) { }

	// RVA: 0x207A650 Offset: 0x2079050 VA: 0x18207A650
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x207A810 Offset: 0x2079210 VA: 0x18207A810
	private void BaseRemove(DataTable table) { }

	// RVA: 0x207A990 Offset: 0x2079390 VA: 0x18207A990
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x207B0A0 Offset: 0x2079AA0 VA: 0x18207B0A0
	public void Clear() { }

	// RVA: 0x207B500 Offset: 0x2079F00 VA: 0x18207B500
	public bool Contains(string name) { }

	// RVA: 0x207B520 Offset: 0x2079F20 VA: 0x18207B520
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x207B390 Offset: 0x2079D90 VA: 0x18207B390
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x207BA20 Offset: 0x207A420 VA: 0x18207BA20
	public int IndexOf(DataTable table) { }

	// RVA: 0x207B970 Offset: 0x207A370 VA: 0x18207B970
	public int IndexOf(string tableName) { }

	// RVA: 0x207B990 Offset: 0x207A390 VA: 0x18207B990
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x207C620 Offset: 0x207B020 VA: 0x18207C620
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x207BB10 Offset: 0x207A510 VA: 0x18207BB10
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x207BDA0 Offset: 0x207A7A0 VA: 0x18207BDA0
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x207BFB0 Offset: 0x207A9B0 VA: 0x18207BFB0
	private string MakeName(int index) { }

	// RVA: 0x207C050 Offset: 0x207AA50 VA: 0x18207C050
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x207C110 Offset: 0x207AB10 VA: 0x18207C110
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x207C1D0 Offset: 0x207ABD0 VA: 0x18207C1D0
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x207C460 Offset: 0x207AE60 VA: 0x18207C460
	public void Remove(DataTable table) { }

	// RVA: 0x207C680 Offset: 0x207B080 VA: 0x18207C680
	internal void UnregisterName(string name) { }
}
