internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 8402
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x243F5F0 Offset: 0x243DFF0 VA: 0x18243F5F0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x24379B0 Offset: 0x24363B0 VA: 0x1824379B0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x2437510 Offset: 0x2435F10 VA: 0x182437510 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x4B6C60 Offset: 0x4B5660 VA: 0x1804B6C60
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x2436960 Offset: 0x2435360 VA: 0x182436960
	private bool LoadSchema(string uri) { }

	// RVA: 0x2436770 Offset: 0x2435170 VA: 0x182436770
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x2437C10 Offset: 0x2436610 VA: 0x182437C10 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x2437930 Offset: 0x2436330 VA: 0x182437930 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x24381B0 Offset: 0x2436BB0 VA: 0x1824381B0 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x2435CC0 Offset: 0x24346C0 VA: 0x182435CC0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x2437D30 Offset: 0x2436730 VA: 0x182437D30
	private void Push() { }

	// RVA: 0x2437460 Offset: 0x2435E60 VA: 0x182437460
	private void Pop() { }

	// RVA: 0x2437C70 Offset: 0x2436670 VA: 0x182437C70
	private void PushGroupInfo() { }

	// RVA: 0x24373B0 Offset: 0x2435DB0 VA: 0x1824373B0
	private void PopGroupInfo() { }

	// RVA: 0x243BF10 Offset: 0x243A910 VA: 0x18243BF10
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x243A2C0 Offset: 0x2438CC0 VA: 0x18243A2C0
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438A90 Offset: 0x2437490 VA: 0x182438A90
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x243B2E0 Offset: 0x2439CE0 VA: 0x18243B2E0
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x243BAC0 Offset: 0x243A4C0 VA: 0x18243BAC0
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x2439AE0 Offset: 0x24384E0 VA: 0x182439AE0
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439520 Offset: 0x2437F20 VA: 0x182439520
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439960 Offset: 0x2438360 VA: 0x182439960
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439CF0 Offset: 0x24386F0 VA: 0x182439CF0
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x24396C0 Offset: 0x24380C0 VA: 0x1824396C0
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439860 Offset: 0x2438260 VA: 0x182439860
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x24395C0 Offset: 0x2437FC0 VA: 0x1824395C0
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439640 Offset: 0x2438040 VA: 0x182439640
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438720 Offset: 0x2437120 VA: 0x182438720
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x243AA80 Offset: 0x2439480 VA: 0x18243AA80
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x243B800 Offset: 0x243A200 VA: 0x18243B800
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x2439000 Offset: 0x2437A00 VA: 0x182439000
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x24392E0 Offset: 0x2437CE0 VA: 0x1824392E0
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438B80 Offset: 0x2437580 VA: 0x182438B80
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438CB0 Offset: 0x24376B0 VA: 0x182438CB0
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438F00 Offset: 0x2437900 VA: 0x182438F00
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438BB0 Offset: 0x24375B0 VA: 0x182438BB0
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438C30 Offset: 0x2437630 VA: 0x182438C30
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x24381F0 Offset: 0x2436BF0 VA: 0x1824381F0
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x243A5C0 Offset: 0x2438FC0 VA: 0x18243A5C0
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x243BC60 Offset: 0x243A660 VA: 0x18243BC60
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x2439EB0 Offset: 0x24388B0 VA: 0x182439EB0
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439E30 Offset: 0x2438830 VA: 0x182439E30
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439DB0 Offset: 0x24387B0 VA: 0x182439DB0
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x243AF90 Offset: 0x2439990 VA: 0x18243AF90
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x243B920 Offset: 0x243A320 VA: 0x18243B920
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x2439410 Offset: 0x2437E10 VA: 0x182439410
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439390 Offset: 0x2437D90 VA: 0x182439390
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2439360 Offset: 0x2437D60 VA: 0x182439360
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x2438290 Offset: 0x2436C90 VA: 0x182438290
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x243A920 Offset: 0x2439320 VA: 0x18243A920
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x243BD40 Offset: 0x243A740 VA: 0x18243BD40
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x243A1A0 Offset: 0x2438BA0 VA: 0x18243A1A0
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x243A110 Offset: 0x2438B10 VA: 0x18243A110
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x243A080 Offset: 0x2438A80 VA: 0x18243A080
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x243B0C0 Offset: 0x2439AC0 VA: 0x18243B0C0
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x243B9C0 Offset: 0x243A3C0 VA: 0x18243B9C0
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x243A950 Offset: 0x2439350 VA: 0x18243A950
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x243B760 Offset: 0x243A160 VA: 0x18243B760
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x243A4A0 Offset: 0x2438EA0 VA: 0x18243A4A0
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x24360C0 Offset: 0x2434AC0 VA: 0x1824360C0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x2436670 Offset: 0x2435070 VA: 0x182436670
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x24364B0 Offset: 0x2434EB0 VA: 0x1824364B0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x24362B0 Offset: 0x2434CB0 VA: 0x1824362B0
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x24358B0 Offset: 0x24342B0 VA: 0x1824358B0
	private void AddOrder() { }

	// RVA: 0x2436810 Offset: 0x2435210 VA: 0x182436810
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x2437280 Offset: 0x2435C80 VA: 0x182437280
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x2437130 Offset: 0x2435B30 VA: 0x182437130
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x2436470 Offset: 0x2434E70 VA: 0x182436470
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0x2436E30 Offset: 0x2435830 VA: 0x182436E30
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x2436F90 Offset: 0x2435990 VA: 0x182436F90
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x2435C50 Offset: 0x2434650 VA: 0x182435C50
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0x24370F0 Offset: 0x2435AF0 VA: 0x1824370F0
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0x243A380 Offset: 0x2438D80 VA: 0x18243A380
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x2438160 Offset: 0x2436B60 VA: 0x182438160
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x2435D90 Offset: 0x2434790 VA: 0x182435D90
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x2435FA0 Offset: 0x24349A0 VA: 0x182435FA0
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x2435970 Offset: 0x2434370 VA: 0x182435970
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x2435B20 Offset: 0x2434520 VA: 0x182435B20
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x24364A0 Offset: 0x2434EA0 VA: 0x1824364A0
	private bool IsGlobal(int flags) { }

	// RVA: 0x2437D90 Offset: 0x2436790 VA: 0x182437D90
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x2438100 Offset: 0x2436B00 VA: 0x182438100
	private void SendValidationEvent(string code) { }

	// RVA: 0x2437FF0 Offset: 0x24369F0 VA: 0x182437FF0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x2437ED0 Offset: 0x24368D0 VA: 0x182437ED0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x243BF90 Offset: 0x243A990 VA: 0x18243BF90
	private static void .cctor() { }
}
