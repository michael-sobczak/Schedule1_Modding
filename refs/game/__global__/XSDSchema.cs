internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 12991
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	internal bool get_FromInference() { }

	// RVA: 0xAE7D60 Offset: 0xAE6760 VA: 0x180AE7D60
	internal void set_FromInference(bool value) { }

	// RVA: 0x20B0320 Offset: 0x20AED20 VA: 0x1820B0320
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0x20AFA10 Offset: 0x20AE410 VA: 0x1820AFA10
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0x20BD5F0 Offset: 0x20BBFF0 VA: 0x1820BD5F0
	internal static string QualifiedName(string name) { }

	// RVA: 0x20BDC70 Offset: 0x20BC670 VA: 0x1820BDC70
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x20BD8D0 Offset: 0x20BC2D0 VA: 0x1820BD8D0
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x20B3320 Offset: 0x20B1D20 VA: 0x1820B3320
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x20B13F0 Offset: 0x20AFDF0 VA: 0x1820B13F0
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0x20BD660 Offset: 0x20BC060 VA: 0x1820BD660
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x20B7600 Offset: 0x20B6000 VA: 0x1820B7600
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0x20B7700 Offset: 0x20B6100 VA: 0x1820B7700
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0x20B9690 Offset: 0x20B8090 VA: 0x1820B9690
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x20BB1F0 Offset: 0x20B9BF0 VA: 0x1820BB1F0
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0x20B03B0 Offset: 0x20AEDB0 VA: 0x1820B03B0
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0x20B0580 Offset: 0x20AEF80 VA: 0x1820B0580
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0x20BD310 Offset: 0x20BBD10 VA: 0x1820BD310
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0x20BBB40 Offset: 0x20BA540 VA: 0x1820BBB40
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0x20B8100 Offset: 0x20B6B00 VA: 0x1820B8100
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0x20B17A0 Offset: 0x20B01A0 VA: 0x1820B17A0
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0x20B6DA0 Offset: 0x20B57A0 VA: 0x1820B6DA0
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0x20B3080 Offset: 0x20B1A80 VA: 0x1820B3080
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0x20B2D20 Offset: 0x20B1720 VA: 0x1820B2D20
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0x20B3530 Offset: 0x20B1F30 VA: 0x1820B3530
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0x20B1A70 Offset: 0x20B0470 VA: 0x1820B1A70
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0x20B0AB0 Offset: 0x20AF4B0 VA: 0x1820B0AB0
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0x20AF7B0 Offset: 0x20AE1B0 VA: 0x1820AF7B0
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0x20B1140 Offset: 0x20AFB40 VA: 0x1820B1140
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0x20B1E80 Offset: 0x20B0880 VA: 0x1820B1E80
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0x20BE1A0 Offset: 0x20BCBA0 VA: 0x1820BE1A0
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0x20BE210 Offset: 0x20BCC10 VA: 0x1820BE210
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0x20B6420 Offset: 0x20B4E20 VA: 0x1820B6420
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0x20B3DB0 Offset: 0x20B27B0 VA: 0x1820B3DB0
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0x20B9870 Offset: 0x20B8270 VA: 0x1820B9870
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0x20B12A0 Offset: 0x20AFCA0 VA: 0x1820B12A0
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0x20B9FC0 Offset: 0x20B89C0 VA: 0x1820B9FC0
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0x20BE2E0 Offset: 0x20BCCE0 VA: 0x1820BE2E0
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0x20B0C70 Offset: 0x20AF670 VA: 0x1820B0C70
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0x20BD340 Offset: 0x20BBD40 VA: 0x1820BD340
	private Type ParseDataType(string dt) { }

	// RVA: 0x20BBAD0 Offset: 0x20BA4D0 VA: 0x1820BBAD0
	internal static bool IsXsdType(string name) { }

	// RVA: 0x20B0D50 Offset: 0x20AF750 VA: 0x1820B0D50
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0x20B8B00 Offset: 0x20B7500 VA: 0x1820B8B00
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x20B8380 Offset: 0x20B6D80 VA: 0x1820B8380
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x20B21C0 Offset: 0x20B0BC0 VA: 0x1820B21C0
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0x20B5490 Offset: 0x20B3E90 VA: 0x1820B5490
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0x20B42A0 Offset: 0x20B2CA0 VA: 0x1820B42A0
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0x20AF610 Offset: 0x20AE010 VA: 0x1820AF610
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0x20B1C10 Offset: 0x20B0610 VA: 0x1820B1C10
	private string GetPrefix(string ns) { }

	// RVA: 0x20B1520 Offset: 0x20AFF20 VA: 0x1820B1520
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0x20B2020 Offset: 0x20B0A20 VA: 0x1820B2020
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x20B1F00 Offset: 0x20B0900 VA: 0x1820B1F00
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x20BB7E0 Offset: 0x20BA1E0 VA: 0x1820BB7E0
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0x20B94D0 Offset: 0x20B7ED0 VA: 0x1820B94D0
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x20BE3C0 Offset: 0x20BCDC0 VA: 0x1820BE3C0
	private static void .cctor() { }
}
