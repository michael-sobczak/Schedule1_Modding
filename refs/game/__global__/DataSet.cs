public class DataSet : MarshalByValueComponent, IListSource, IXmlSerializable, ISerializable // TypeDefIndex: 12863
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	// Properties
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValue(False)]
	public bool CaseSensitive { get; set; }
	[Browsable(False)]
	public DataViewManager DefaultViewManager { get; }
	[DefaultValue(True)]
	public bool EnforceConstraints { get; set; }
	[DefaultValue("")]
	public string DataSetName { get; set; }
	[DefaultValue("")]
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; set; }
	[DesignerSerializationVisibility(2)]
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibility(2)]
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x2053210 Offset: 0x2051C10 VA: 0x182053210
	public void .ctor() { }

	// RVA: 0x20536F0 Offset: 0x20520F0 VA: 0x1820536F0
	public void .ctor(string dataSetName) { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x2054400 Offset: 0x2052E00 VA: 0x182054400
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 17
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0x20536C0 Offset: 0x20520C0 VA: 0x1820536C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20534B0 Offset: 0x2051EB0 VA: 0x1820534B0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0x204B640 Offset: 0x204A040 VA: 0x18204B640 Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 19
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0x2050CE0 Offset: 0x204F6E0 VA: 0x182050CE0
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x204A330 Offset: 0x2048D30 VA: 0x18204A330
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x2049E10 Offset: 0x2048810 VA: 0x182049E10
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x2049970 Offset: 0x2048370 VA: 0x182049970
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x2050B40 Offset: 0x204F540 VA: 0x182050B40
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2049B40 Offset: 0x2048540 VA: 0x182049B40
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2051380 Offset: 0x204FD80 VA: 0x182051380
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x204A3B0 Offset: 0x2048DB0 VA: 0x18204A3B0
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x204B1B0 Offset: 0x2049BB0 VA: 0x18204B1B0
	internal void FailedEnableConstraints() { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	public bool get_CaseSensitive() { }

	// RVA: 0x2053890 Offset: 0x2052290 VA: 0x182053890
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x2053720 Offset: 0x2052120 VA: 0x182053720
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_EnforceConstraints() { }

	// RVA: 0x2053C70 Offset: 0x2052670 VA: 0x182053C70
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x4D6520 Offset: 0x4D4F20 VA: 0x1804D6520
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0x204AAA0 Offset: 0x20494A0 VA: 0x18204AAA0
	internal void EnableConstraints() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_DataSetName() { }

	// RVA: 0x2053B00 Offset: 0x2052500 VA: 0x182053B00
	public void set_DataSetName(string value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Namespace() { }

	// RVA: 0x2053F10 Offset: 0x2052910 VA: 0x182053F10
	public void set_Namespace(string value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_Prefix() { }

	// RVA: 0x20542D0 Offset: 0x2052CD0 VA: 0x1820542D0
	public void set_Prefix(string value) { }

	// RVA: 0x2053820 Offset: 0x2052220 VA: 0x182053820
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public CultureInfo get_Locale() { }

	// RVA: 0x2053DB0 Offset: 0x20527B0 VA: 0x182053DB0
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x20518C0 Offset: 0x20502C0 VA: 0x1820518C0
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 8
	public override ISite get_Site() { }

	// RVA: 0x20544C0 Offset: 0x2052EC0 VA: 0x1820544C0 Slot: 9
	public override void set_Site(ISite value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public DataRelationCollection get_Relations() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public DataTableCollection get_Tables() { }

	// RVA: 0x20487D0 Offset: 0x20471D0 VA: 0x1820487D0
	public void Clear() { }

	// RVA: 0x20489A0 Offset: 0x20473A0 VA: 0x1820489A0 Slot: 20
	public virtual DataSet Clone() { }

	// RVA: 0x204B050 Offset: 0x2049A50 VA: 0x18204B050
	internal int EstimatedXmlStringSize() { }

	// RVA: 0x2051F80 Offset: 0x2050980 VA: 0x182051F80 Slot: 12
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0x204B670 Offset: 0x204A070 VA: 0x18204B670
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0x204B7B0 Offset: 0x204A1B0 VA: 0x18204B7B0
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0x204DAA0 Offset: 0x204C4A0 VA: 0x18204DAA0
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0x204DAB0 Offset: 0x204C4B0 VA: 0x18204DAB0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x2033710 Offset: 0x2032110 VA: 0x182033710
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x204C1C0 Offset: 0x204ABC0 VA: 0x18204C1C0
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0x2035260 Offset: 0x2033C60 VA: 0x182035260
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x204C690 Offset: 0x204B090 VA: 0x18204C690
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x204C520 Offset: 0x204AF20 VA: 0x18204C520
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x2052DD0 Offset: 0x20517D0 VA: 0x182052DD0
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x20508C0 Offset: 0x204F2C0 VA: 0x1820508C0
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0x204F630 Offset: 0x204E030 VA: 0x18204F630
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0x204B960 Offset: 0x204A360 VA: 0x18204B960
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0x204BC70 Offset: 0x204A670 VA: 0x18204BC70
	private bool IsEmpty() { }

	// RVA: 0x204C950 Offset: 0x204B350 VA: 0x18204C950
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x204E7C0 Offset: 0x204D1C0 VA: 0x18204E7C0
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0x204E7E0 Offset: 0x204D1E0 VA: 0x18204E7E0
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x2052FE0 Offset: 0x20519E0 VA: 0x182052FE0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0x204BE40 Offset: 0x204A840 VA: 0x18204BE40
	public void Merge(DataSet dataSet) { }

	// RVA: 0x204BF90 Offset: 0x204A990 VA: 0x18204BF90
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x204C330 Offset: 0x204AD30 VA: 0x18204C330 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x204C2B0 Offset: 0x204ACB0 VA: 0x18204C2B0
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0x204C390 Offset: 0x204AD90 VA: 0x18204C390
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x204C280 Offset: 0x204AC80 VA: 0x18204C280
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0x204C250 Offset: 0x204AC50 VA: 0x18204C250
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 22
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0x204C360 Offset: 0x204AD60 VA: 0x18204C360
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 23
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xB1E190 Offset: 0xB1CB90 VA: 0x180B1E190
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0x204C4A0 Offset: 0x204AEA0 VA: 0x18204C4A0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x2052300 Offset: 0x2050D00 VA: 0x182052300
	internal DataTable[] TopLevelTables() { }

	// RVA: 0x2052310 Offset: 0x2050D10 VA: 0x182052310
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0x20508D0 Offset: 0x204F2D0 VA: 0x1820508D0 Slot: 24
	public virtual void Reset() { }

	// RVA: 0x2052540 Offset: 0x2050F40 VA: 0x182052540
	internal bool ValidateCaseConstraint() { }

	// RVA: 0x2052940 Offset: 0x2051340 VA: 0x182052940
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0x204B1F0 Offset: 0x2049BF0 VA: 0x18204B1F0
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0x204E470 Offset: 0x204CE70 VA: 0x18204E470 Slot: 25
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x204B370 Offset: 0x2049D70 VA: 0x18204B370
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x2051F90 Offset: 0x2050990 VA: 0x182051F90 Slot: 13
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x2052160 Offset: 0x2050B60 VA: 0x182052160 Slot: 14
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20522B0 Offset: 0x2050CB0 VA: 0x1820522B0 Slot: 15
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal string get_MainTableName() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void set_MainTableName(string value) { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	internal int get_ObjectID() { }
}
