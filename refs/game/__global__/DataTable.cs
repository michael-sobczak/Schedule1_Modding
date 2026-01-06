public class DataTable : MarshalByValueComponent, IListSource, ISerializable, IXmlSerializable // TypeDefIndex: 12866
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private readonly DataRowBuilder _rowBuilder; // 0x1F0
	internal readonly List<DataView> _delayedViews; // 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; // 0x200
	internal Hashtable _rowDiffId; // 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
	internal int _ukColumnPositionForInference; // 0x218
	private SerializationFormat _remotingFormat; // 0x21C
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x220

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsable(0)]
	internal List<Index> LiveIndexes { get; }
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibility(2)]
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibility(2)]
	public ConstraintCollection Constraints { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataSet DataSet { get; }
	[Browsable(False)]
	public DataView DefaultView { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValue(50)]
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey { get; set; }
	[Browsable(False)]
	public DataRowCollection Rows { get; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; set; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x203DB70 Offset: 0x203C570 VA: 0x18203DB70
	public void .ctor() { }

	// RVA: 0x203E040 Offset: 0x203CA40 VA: 0x18203E040
	public void .ctor(string tableName) { }

	// RVA: 0x203E0B0 Offset: 0x203CAB0 VA: 0x18203E0B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2031390 Offset: 0x202FD90 VA: 0x182031390 Slot: 17
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2039D30 Offset: 0x2038730 VA: 0x182039D30
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x202C930 Offset: 0x202B330 VA: 0x18202C930
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x203A7F0 Offset: 0x20391F0 VA: 0x18203A7F0
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x202D850 Offset: 0x202C250 VA: 0x18202D850
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x2039530 Offset: 0x2037F30 VA: 0x182039530
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x202BDE0 Offset: 0x202A7E0 VA: 0x18202BDE0
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x203A010 Offset: 0x2038A10 VA: 0x18203A010
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x202CC80 Offset: 0x202B680 VA: 0x18202CC80
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x203A1A0 Offset: 0x2038BA0 VA: 0x18203A1A0
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x202CE10 Offset: 0x202B810 VA: 0x18202CE10
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x202B2C0 Offset: 0x2029CC0 VA: 0x18202B2C0
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0x20317C0 Offset: 0x20301C0 VA: 0x1820317C0
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x202AFB0 Offset: 0x20299B0 VA: 0x18202AFB0
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x510B30 Offset: 0x50F530 VA: 0x180510B30
	public bool get_CaseSensitive() { }

	// RVA: 0x203EE80 Offset: 0x203D880 VA: 0x18203EE80
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x203E240 Offset: 0x203CC40 VA: 0x18203E240
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0x20390F0 Offset: 0x2037AF0 VA: 0x1820390F0
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0x203CFC0 Offset: 0x203B9C0 VA: 0x18203CFC0
	internal void SuspendIndexEvents() { }

	// RVA: 0x203E590 Offset: 0x203CF90 VA: 0x18203E590
	private bool get_IsTypedDataTable() { }

	// RVA: 0x203B530 Offset: 0x2039F30 VA: 0x18203B530
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0x5233B0 Offset: 0x521DB0 VA: 0x1805233B0
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0x203EBD0 Offset: 0x203D5D0 VA: 0x18203EBD0
	internal bool get_SelfNested() { }

	// RVA: 0x203E640 Offset: 0x203D040 VA: 0x18203E640
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0x203EB30 Offset: 0x203D530 VA: 0x18203EB30
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x203FCB0 Offset: 0x203E6B0 VA: 0x18203FCB0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x203EE70 Offset: 0x203D870 VA: 0x18203EE70
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x2040410 Offset: 0x203EE10 VA: 0x182040410
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0x203E250 Offset: 0x203CC50 VA: 0x18203E250
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public DataColumnCollection get_Columns() { }

	// RVA: 0x203E2D0 Offset: 0x203CCD0 VA: 0x18203E2D0
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public ConstraintCollection get_Constraints() { }

	// RVA: 0x2038BF0 Offset: 0x20375F0 VA: 0x182038BF0
	private void ResetConstraints() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DataSet get_DataSet() { }

	// RVA: 0x203B7B0 Offset: 0x203A1B0 VA: 0x18203B7B0
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x203D070 Offset: 0x203BA70 VA: 0x18203D070
	public DataView get_DefaultView() { }

	// RVA: 0x203E340 Offset: 0x203CD40 VA: 0x18203E340
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0x203E430 Offset: 0x203CE30 VA: 0x18203E430
	internal bool get_EnforceConstraints() { }

	// RVA: 0x203EF90 Offset: 0x203D990 VA: 0x18203EF90
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0x1E43D20 Offset: 0x1E42720 VA: 0x181E43D20
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0x1E44770 Offset: 0x1E43170 VA: 0x181E44770
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0x202EC80 Offset: 0x202D680 VA: 0x18202EC80
	internal void EnableConstraints() { }

	// RVA: 0x203E460 Offset: 0x203CE60 VA: 0x18203E460
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x203E4E0 Offset: 0x203CEE0 VA: 0x18203E4E0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public CultureInfo get_Locale() { }

	// RVA: 0x203EFD0 Offset: 0x203D9D0 VA: 0x18203EFD0
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x203B920 Offset: 0x203A320 VA: 0x18203B920
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x4E8B60 Offset: 0x4E7560 VA: 0x1804E8B60
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x203E6F0 Offset: 0x203D0F0 VA: 0x18203E6F0
	public int get_MinimumCapacity() { }

	// RVA: 0x203F3B0 Offset: 0x203DDB0 VA: 0x18203F3B0
	public void set_MinimumCapacity(int value) { }

	// RVA: 0x203EB10 Offset: 0x203D510 VA: 0x18203EB10
	internal int get_RecordCapacity() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	internal int get_ElementColumnCount() { }

	// RVA: 0x203EF40 Offset: 0x203D940 VA: 0x18203EF40
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0x203EA30 Offset: 0x203D430 VA: 0x18203EA30
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0x88C120 Offset: 0x88AB20 VA: 0x18088C120
	internal bool get_MergingData() { }

	// RVA: 0x88C240 Offset: 0x88AC40 VA: 0x18088C240
	internal void set_MergingData(bool value) { }

	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0x203EBC0 Offset: 0x203D5C0 VA: 0x18203EBC0
	internal bool get_SchemaLoading() { }

	// RVA: 0x2028240 Offset: 0x2026C40 VA: 0x182028240
	internal void CacheNestedParent() { }

	// RVA: 0x20307D0 Offset: 0x202F1D0 VA: 0x1820307D0
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0x203E7D0 Offset: 0x203D1D0 VA: 0x18203E7D0
	internal int get_NestedParentsCount() { }

	// RVA: 0x203EAB0 Offset: 0x203D4B0 VA: 0x18203EAB0
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0x203F7E0 Offset: 0x203E1E0 VA: 0x18203F7E0
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public DataRowCollection get_Rows() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_TableName() { }

	// RVA: 0x203FE90 Offset: 0x203E890 VA: 0x18203FE90
	public void set_TableName(string value) { }

	// RVA: 0x203E3A0 Offset: 0x203CDA0 VA: 0x18203E3A0
	internal string get_EncodedTableName() { }

	// RVA: 0x20310D0 Offset: 0x202FAD0 VA: 0x1820310D0
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0x203E710 Offset: 0x203D110 VA: 0x18203E710
	public string get_Namespace() { }

	// RVA: 0x203F3E0 Offset: 0x203DDE0 VA: 0x18203F3E0
	public void set_Namespace(string value) { }

	// RVA: 0x2032D40 Offset: 0x2031740 VA: 0x182032D40
	internal bool IsNamespaceInherited() { }

	// RVA: 0x2028340 Offset: 0x2026D40 VA: 0x182028340
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0x2028CF0 Offset: 0x20276F0 VA: 0x182028CF0
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0x2028A90 Offset: 0x2027490 VA: 0x182028A90
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0x202E750 Offset: 0x202D150 VA: 0x18202E750
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	public string get_Prefix() { }

	// RVA: 0x203F660 Offset: 0x203E060 VA: 0x18203F660
	public void set_Prefix(string value) { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	internal DataColumn get_XmlText() { }

	// RVA: 0x2040420 Offset: 0x203EE20 VA: 0x182040420
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0x66FB70 Offset: 0x66E570 VA: 0x18066FB70
	internal Decimal get_MaxOccurs() { }

	// RVA: 0x66FC20 Offset: 0x66E620 VA: 0x18066FC20
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0x203E6E0 Offset: 0x203D0E0 VA: 0x18203E6E0
	internal Decimal get_MinOccurs() { }

	// RVA: 0x203F3A0 Offset: 0x203DDA0 VA: 0x18203F3A0
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0x203B890 Offset: 0x203A290 VA: 0x18203B890
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0x2030630 Offset: 0x202F030 VA: 0x182030630
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0x20306D0 Offset: 0x202F0D0 VA: 0x1820306D0
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0x203BF30 Offset: 0x203A930 VA: 0x18203BF30
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0x2032E10 Offset: 0x2031810 VA: 0x182032E10
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0x202B6B0 Offset: 0x202A0B0 VA: 0x18202B6B0 Slot: 18
	protected virtual DataTable CreateInstance() { }

	// RVA: 0x202AB50 Offset: 0x2029550 VA: 0x18202AB50 Slot: 19
	public virtual DataTable Clone() { }

	// RVA: 0x202A970 Offset: 0x2029370 VA: 0x18202A970
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0x2031DA0 Offset: 0x20307A0 VA: 0x182031DA0
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0x20297F0 Offset: 0x20281F0 VA: 0x1820297F0
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0x2029C10 Offset: 0x2028610 VA: 0x182029C10
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 8
	public override ISite get_Site() { }

	// RVA: 0x203FD30 Offset: 0x203E730 VA: 0x18203FD30 Slot: 9
	public override void set_Site(ISite value) { }

	// RVA: 0x2027EE0 Offset: 0x20268E0 VA: 0x182027EE0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0x2032B00 Offset: 0x2031500 VA: 0x182032B00
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0x2032720 Offset: 0x2031120 VA: 0x182032720
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0x2029020 Offset: 0x2027A20 VA: 0x182029020
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0x2029050 Offset: 0x2027A50 VA: 0x182029050
	public void Clear() { }

	// RVA: 0x2029060 Offset: 0x2027A60 VA: 0x182029060
	internal void Clear(bool clearAll) { }

	// RVA: 0x2028270 Offset: 0x2026C70 VA: 0x182028270
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0x202AB60 Offset: 0x2029560 VA: 0x18202AB60
	internal void CommitRow(DataRow row) { }

	// RVA: 0x202AE50 Offset: 0x2029850 VA: 0x18202AE50
	internal int Compare(string s1, string s2) { }

	// RVA: 0x202ACB0 Offset: 0x20296B0 VA: 0x18202ACB0
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0x2032030 Offset: 0x2030A30 VA: 0x182032030
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0x2032D50 Offset: 0x2031750 VA: 0x182032D50
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0x202BD30 Offset: 0x202A730 VA: 0x18202BD30
	internal void DeleteRow(DataRow row) { }

	// RVA: 0x2030AD0 Offset: 0x202F4D0 VA: 0x182030AD0
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0x2030C10 Offset: 0x202F610 VA: 0x182030C10
	internal void FreeRecord(ref int record) { }

	// RVA: 0x2031080 Offset: 0x202FA80 VA: 0x182031080
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x2030E90 Offset: 0x202F890 VA: 0x182030E90
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x203D070 Offset: 0x203BA70 VA: 0x18203D070 Slot: 12
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0x2031C90 Offset: 0x2030690 VA: 0x182031C90
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0x2032310 Offset: 0x2030D10 VA: 0x182032310
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0x2033860 Offset: 0x2032260 VA: 0x182033860
	internal int NewRecord() { }

	// RVA: 0x2033D80 Offset: 0x2032780 VA: 0x182033D80
	internal int NewUninitializedRecord() { }

	// RVA: 0x2033870 Offset: 0x2032270 VA: 0x182033870
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0x20337F0 Offset: 0x20321F0 VA: 0x1820337F0
	internal DataRow NewEmptyRow() { }

	// RVA: 0x2033DA0 Offset: 0x20327A0 VA: 0x182033DA0
	private DataRow NewUninitializedRow() { }

	// RVA: 0x2033C80 Offset: 0x2032680 VA: 0x182033C80
	public DataRow NewRow() { }

	// RVA: 0x202B3A0 Offset: 0x2029DA0 VA: 0x18202B3A0
	internal DataRow CreateEmptyRow() { }

	// RVA: 0x2033AF0 Offset: 0x20324F0 VA: 0x182033AF0
	private void NewRowCreated(DataRow row) { }

	// RVA: 0x2033BE0 Offset: 0x20325E0 VA: 0x182033BE0
	internal DataRow NewRow(int record) { }

	// RVA: 0x2033B80 Offset: 0x2032580 VA: 0x182033B80 Slot: 20
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0x2031A60 Offset: 0x2030460 VA: 0x182031A60 Slot: 21
	protected virtual Type GetRowType() { }

	// RVA: 0x2033960 Offset: 0x2032360 VA: 0x182033960
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0x203E790 Offset: 0x203D190 VA: 0x18203E790
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0x2033EB0 Offset: 0x20328B0 VA: 0x182033EB0 Slot: 22
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0x2033DE0 Offset: 0x20327E0 VA: 0x182033DE0 Slot: 23
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0x2033F80 Offset: 0x2032980 VA: 0x182033F80 Slot: 24
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x2034050 Offset: 0x2032A50 VA: 0x182034050
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 25
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0x2034070 Offset: 0x2032A70 VA: 0x182034070
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x20341F0 Offset: 0x2032BF0 VA: 0x1820341F0
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x2034120 Offset: 0x2032B20 VA: 0x182034120 Slot: 26
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0x20342A0 Offset: 0x2032CA0 VA: 0x1820342A0 Slot: 27
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0x2034440 Offset: 0x2032E40 VA: 0x182034440 Slot: 28
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0x2034370 Offset: 0x2032D70 VA: 0x182034370 Slot: 29
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0x2034510 Offset: 0x2032F10 VA: 0x182034510 Slot: 30
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0x20345E0 Offset: 0x2032FE0 VA: 0x1820345E0 Slot: 31
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0x20346B0 Offset: 0x20330B0 VA: 0x1820346B0 Slot: 32
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0x2034780 Offset: 0x2033180 VA: 0x182034780
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0x2034B10 Offset: 0x2033510 VA: 0x182034B10
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0x2038020 Offset: 0x2036A20 VA: 0x182038020
	internal void RecordChanged(int record) { }

	// RVA: 0x20381A0 Offset: 0x2036BA0 VA: 0x1820381A0
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0x2038590 Offset: 0x2036F90 VA: 0x182038590
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x2038370 Offset: 0x2036D70 VA: 0x182038370
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0x20387C0 Offset: 0x20371C0 VA: 0x1820387C0
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x20320F0 Offset: 0x2030AF0 VA: 0x1820320F0
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x203CE20 Offset: 0x203B820 VA: 0x18203CE20
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0x2038A30 Offset: 0x2037430 VA: 0x182038A30
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0x2038E00 Offset: 0x2037800 VA: 0x182038E00 Slot: 33
	public virtual void Reset() { }

	// RVA: 0x2038C10 Offset: 0x2037610 VA: 0x182038C10
	internal void ResetIndexes() { }

	// RVA: 0x2038C20 Offset: 0x2037620 VA: 0x182038C20
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0x2039490 Offset: 0x2037E90 VA: 0x182039490
	internal void RollbackRow(DataRow row) { }

	// RVA: 0x2034B90 Offset: 0x2033590 VA: 0x182034B90
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x2034FD0 Offset: 0x20339D0 VA: 0x182034FD0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x2034E00 Offset: 0x2033800 VA: 0x182034E00
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0x203C9F0 Offset: 0x203B3F0 VA: 0x18203C9F0
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0x203C070 Offset: 0x203AA70 VA: 0x18203C070
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0x203CA70 Offset: 0x203B470 VA: 0x18203CA70
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0x2039470 Offset: 0x2037E70 VA: 0x182039470
	private void RestoreShadowIndexes() { }

	// RVA: 0x203CD40 Offset: 0x203B740 VA: 0x18203CD40
	private void SetShadowIndexes() { }

	// RVA: 0x203CD90 Offset: 0x203B790 VA: 0x18203CD90
	internal void ShadowIndexCopy() { }

	// RVA: 0x203D280 Offset: 0x203BC80 VA: 0x18203D280 Slot: 3
	public override string ToString() { }

	// RVA: 0x203D350 Offset: 0x203BD50 VA: 0x18203D350
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0x2027F20 Offset: 0x2026920 VA: 0x182027F20
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0x2027F10 Offset: 0x2026910 VA: 0x182027F10
	internal DataColumn AddUniqueKey() { }

	// RVA: 0x2027E20 Offset: 0x2026820 VA: 0x182027E20
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0x203D330 Offset: 0x203BD30 VA: 0x18203D330
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0x2031480 Offset: 0x202FE80 VA: 0x182031480
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0x203EDC0 Offset: 0x203D7C0 VA: 0x18203EDC0
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0x20334C0 Offset: 0x2031EC0 VA: 0x1820334C0
	public void Merge(DataTable table) { }

	// RVA: 0x20334E0 Offset: 0x2031EE0 VA: 0x1820334E0
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x203D770 Offset: 0x203C170 VA: 0x18203D770
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0x2028970 Offset: 0x2027370 VA: 0x182028970
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x2028620 Offset: 0x2027020 VA: 0x182028620
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0x203D380 Offset: 0x203BD80 VA: 0x18203D380
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0x2039090 Offset: 0x2037A90 VA: 0x182039090
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0x2032B20 Offset: 0x2031520 VA: 0x182032B20
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0x2037040 Offset: 0x2035A40 VA: 0x182037040
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x2035260 Offset: 0x2033C60 VA: 0x182035260
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x2035320 Offset: 0x2033D20 VA: 0x182035320
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x2033710 Offset: 0x2032110 VA: 0x182033710
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x20355B0 Offset: 0x2033FB0 VA: 0x1820355B0
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x20353A0 Offset: 0x2033DA0 VA: 0x1820353A0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x2035FC0 Offset: 0x20349C0 VA: 0x182035FC0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x202BA50 Offset: 0x202A450 VA: 0x18202BA50
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0x202B730 Offset: 0x202A130 VA: 0x18202B730
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0x2030C30 Offset: 0x202F630 VA: 0x182030C30
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x4E26E0 Offset: 0x4E10E0 VA: 0x1804E26E0 Slot: 14
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x2031AC0 Offset: 0x20304C0 VA: 0x182031AC0 Slot: 34
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0x203D160 Offset: 0x203BB60 VA: 0x18203D160 Slot: 15
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x203D230 Offset: 0x203BC30 VA: 0x18203D230 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x2037020 Offset: 0x2035A20 VA: 0x182037020 Slot: 35
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x203EB40 Offset: 0x203D540 VA: 0x18203EB40
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xA2A290 Offset: 0xA28C90 VA: 0x180A2A290
	internal int get_ObjectID() { }

	// RVA: 0x2027CE0 Offset: 0x20266E0 VA: 0x182027CE0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x2038730 Offset: 0x2037130 VA: 0x182038730
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x202FDE0 Offset: 0x202E7E0 VA: 0x18202FDE0
	internal void EvaluateExpressions() { }

	// RVA: 0x2030090 Offset: 0x202EA90 VA: 0x182030090
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0x202FB70 Offset: 0x202E570 VA: 0x18202FB70
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0x202FA30 Offset: 0x202E430 VA: 0x18202FA30
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0x202F1B0 Offset: 0x202DBB0 VA: 0x18202F1B0
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }
}
