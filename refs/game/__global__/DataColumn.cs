public class DataColumn : MarshalByValueComponent // TypeDefIndex: 12848
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValue(True)]
	public bool AllowDBNull { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(False)]
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValue(0)]
	public long AutoIncrementSeed { get; set; }
	[DefaultValue(1)]
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[DefaultValue(typeof(string))]
	[RefreshProperties(1)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(3)]
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string Expression { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValue(-1)]
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Ordinal { get; }
	[DefaultValue(False)]
	public bool ReadOnly { get; set; }
	[DebuggerBrowsable(0)]
	private Index SortIndex { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibility(0)]
	[DefaultValue(False)]
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValue(1)]
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x20446A0 Offset: 0x20430A0 VA: 0x1820446A0
	public void .ctor() { }

	// RVA: 0x2044670 Offset: 0x2043070 VA: 0x182044670
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x2044730 Offset: 0x2043130 VA: 0x182044730
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x2044560 Offset: 0x2042F60 VA: 0x182044560
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_AllowDBNull() { }

	// RVA: 0x2045290 Offset: 0x2043C90 VA: 0x182045290
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x2044CA0 Offset: 0x20436A0 VA: 0x182044CA0
	public bool get_AutoIncrement() { }

	// RVA: 0x20457A0 Offset: 0x20441A0 VA: 0x1820457A0
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x2044BD0 Offset: 0x20435D0 VA: 0x182044BD0
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x20453E0 Offset: 0x2043DE0 VA: 0x1820453E0
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x2044AC0 Offset: 0x20434C0 VA: 0x182044AC0
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x2044C40 Offset: 0x2043640 VA: 0x182044C40
	public long get_AutoIncrementSeed() { }

	// RVA: 0x2045590 Offset: 0x2043F90 VA: 0x182045590
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x2044C70 Offset: 0x2043670 VA: 0x182044C70
	public long get_AutoIncrementStep() { }

	// RVA: 0x2045690 Offset: 0x2044090 VA: 0x182045690
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x2044CC0 Offset: 0x20436C0 VA: 0x182044CC0
	public string get_Caption() { }

	// RVA: 0x20459A0 Offset: 0x20443A0 VA: 0x1820459A0
	public void set_Caption(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_ColumnName() { }

	// RVA: 0x2045D70 Offset: 0x2044770 VA: 0x182045D70
	public void set_ColumnName(string value) { }

	// RVA: 0x2044E40 Offset: 0x2043840 VA: 0x182044E40
	internal string get_EncodedColumnName() { }

	// RVA: 0x2044F90 Offset: 0x2043990 VA: 0x182044F90
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x20450C0 Offset: 0x2043AC0 VA: 0x1820450C0
	internal CultureInfo get_Locale() { }

	// RVA: 0x516290 Offset: 0x514C90 VA: 0x180516290
	internal int get_ObjectID() { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public string get_Prefix() { }

	// RVA: 0x20480A0 Offset: 0x2046AA0 VA: 0x1820480A0
	public void set_Prefix(string value) { }

	// RVA: 0x2042DD0 Offset: 0x20417D0 VA: 0x182042DD0
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x2044CE0 Offset: 0x20436E0 VA: 0x182044CE0
	internal bool get_Computed() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal DataExpression get_DataExpression() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Type get_DataType() { }

	// RVA: 0x2046180 Offset: 0x2044B80 VA: 0x182046180
	public void set_DataType(Type value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x2046D20 Offset: 0x2045720 VA: 0x182046D20
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x2044CF0 Offset: 0x20436F0 VA: 0x182044CF0
	public object get_DefaultValue() { }

	// RVA: 0x2046EA0 Offset: 0x20458A0 VA: 0x182046EA0
	public void set_DefaultValue(object value) { }

	// RVA: 0x4B62F0 Offset: 0x4B4CF0 VA: 0x1804B62F0
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x2044EC0 Offset: 0x20438C0 VA: 0x182044EC0
	public string get_Expression() { }

	// RVA: 0x20471B0 Offset: 0x2045BB0 VA: 0x1820471B0
	public void set_Expression(string value) { }

	// RVA: 0x2044F10 Offset: 0x2043910 VA: 0x182044F10
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x11A73B0 Offset: 0x11A5DB0 VA: 0x1811A73B0
	internal bool get_HasData() { }

	// RVA: 0xC3F680 Offset: 0xC3E080 VA: 0x180C3F680
	internal bool get_ImplementsINullable() { }

	// RVA: 0xC3F690 Offset: 0xC3E090 VA: 0x180C3F690
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0x2044FF0 Offset: 0x20439F0 VA: 0x182044FF0
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x2045070 Offset: 0x2043A70 VA: 0x182045070
	internal bool get_IsValueType() { }

	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	internal bool get_IsSqlType() { }

	// RVA: 0x2044030 Offset: 0x2042A30 VA: 0x182044030
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int get_MaxLength() { }

	// RVA: 0x2047B00 Offset: 0x2046500 VA: 0x182047B00
	public void set_MaxLength(int value) { }

	// RVA: 0x2045120 Offset: 0x2043B20 VA: 0x182045120
	public string get_Namespace() { }

	// RVA: 0x2047F00 Offset: 0x2046900 VA: 0x182047F00
	public void set_Namespace(string value) { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int get_Ordinal() { }

	// RVA: 0x2044160 Offset: 0x2042B60 VA: 0x182044160
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_ReadOnly() { }

	// RVA: 0x2048220 Offset: 0x2046C20 VA: 0x182048220
	public void set_ReadOnly(bool value) { }

	// RVA: 0x20451A0 Offset: 0x2043BA0 VA: 0x1820451A0
	private Index get_SortIndex() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public DataTable get_Table() { }

	// RVA: 0x20442F0 Offset: 0x2042CF0 VA: 0x1820442F0
	internal void SetTable(DataTable table) { }

	// RVA: 0x2042EC0 Offset: 0x20418C0 VA: 0x182042EC0
	private DataRow GetDataRow(int index) { }

	// RVA: 0x2045090 Offset: 0x2043A90 VA: 0x182045090
	internal object get_Item(int record) { }

	// RVA: 0x2047960 Offset: 0x2046360 VA: 0x182047960
	internal void set_Item(int record, object value) { }

	// RVA: 0x2043300 Offset: 0x2041D00 VA: 0x182043300
	internal void InitializeRecord(int record) { }

	// RVA: 0x20443D0 Offset: 0x2042DD0 VA: 0x1820443D0
	internal void SetValue(int record, object value) { }

	// RVA: 0x2042CA0 Offset: 0x20416A0 VA: 0x182042CA0
	internal void FreeRecord(int record) { }

	// RVA: 0x7798E0 Offset: 0x7782E0 VA: 0x1807798E0
	public bool get_Unique() { }

	// RVA: 0x2048360 Offset: 0x2046D60 VA: 0x182048360
	public void set_Unique(bool value) { }

	// RVA: 0x779970 Offset: 0x778370 VA: 0x180779970
	internal void InternalUnique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	internal string get_XmlDataType() { }

	[CompilerGenerated]
	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	internal void set_XmlDataType(string value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	internal SimpleType get_SimpleType() { }

	// RVA: 0x2048300 Offset: 0x2046D00 VA: 0x182048300
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0 Slot: 12
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x2045A80 Offset: 0x2044480 VA: 0x182045A80 Slot: 13
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x2041A20 Offset: 0x2040420 VA: 0x182041A20
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x2041BE0 Offset: 0x20405E0 VA: 0x182041BE0
	internal bool CheckMaxLength() { }

	// RVA: 0x2041B50 Offset: 0x2040550 VA: 0x182041B50
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x2041E30 Offset: 0x2040830 VA: 0x182041E30
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x2042150 Offset: 0x2040B50 VA: 0x182042150
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x20421E0 Offset: 0x2040BE0 VA: 0x1820421E0
	protected void CheckUnique() { }

	// RVA: 0x2042A70 Offset: 0x2041470 VA: 0x182042A70
	internal int Compare(int record1, int record2) { }

	// RVA: 0x2042830 Offset: 0x2041230 VA: 0x182042830
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x2042A40 Offset: 0x2041440 VA: 0x182042A40
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x2042B60 Offset: 0x2041560 VA: 0x182042B60
	internal object ConvertValue(object value) { }

	// RVA: 0x2042C70 Offset: 0x2041670 VA: 0x182042C70
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x2042240 Offset: 0x2040C40 VA: 0x182042240
	internal DataColumn Clone() { }

	// RVA: 0x2042CE0 Offset: 0x20416E0 VA: 0x182042CE0
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x2042F30 Offset: 0x2041930 VA: 0x182042F30
	private int GetStringLength(int record) { }

	// RVA: 0x2043230 Offset: 0x2041C30 VA: 0x182043230
	internal void Init(int record) { }

	// RVA: 0x20433E0 Offset: 0x2041DE0 VA: 0x1820433E0
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x2045000 Offset: 0x2043A00 VA: 0x182045000
	internal bool get_IsCustomType() { }

	// RVA: 0x2043DC0 Offset: 0x20427C0 VA: 0x182043DC0
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x4B62E0 Offset: 0x4B4CE0 VA: 0x1804B62E0
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x20436A0 Offset: 0x20420A0 VA: 0x1820436A0
	internal bool IsInRelation() { }

	// RVA: 0x20437F0 Offset: 0x20421F0 VA: 0x1820437F0
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x2043C10 Offset: 0x2042610 VA: 0x182043C10
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x2043E90 Offset: 0x2042890 VA: 0x182043E90 Slot: 14
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x2043EC0 Offset: 0x20428C0 VA: 0x182043EC0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x2043350 Offset: 0x2041D50 VA: 0x182043350
	private void InsureStorage() { }

	// RVA: 0x2043FE0 Offset: 0x20429E0 VA: 0x182043FE0
	internal void SetCapacity(int capacity) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void OnSetDataSet() { }

	// RVA: 0x20444C0 Offset: 0x2042EC0 VA: 0x1820444C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2042B90 Offset: 0x2041590 VA: 0x182042B90
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x2042BE0 Offset: 0x20415E0 VA: 0x182042BE0
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x2042AA0 Offset: 0x20414A0 VA: 0x182042AA0
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x2042AF0 Offset: 0x20414F0 VA: 0x182042AF0
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x2042EF0 Offset: 0x20418F0 VA: 0x182042EF0
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x2042C40 Offset: 0x2041640 VA: 0x182042C40
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x20442A0 Offset: 0x2042CA0 VA: 0x1820442A0
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x2041900 Offset: 0x2040300 VA: 0x182041900
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x2043F40 Offset: 0x2042940 VA: 0x182043F40
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x2042F60 Offset: 0x2041960 VA: 0x182042F60
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }
}
