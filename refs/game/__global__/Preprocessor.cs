internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 8369
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0x23F0810 Offset: 0x23EF210 VA: 0x1823F0810
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x23E8280 Offset: 0x23E6C80 VA: 0x1823E8280
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x23E6FB0 Offset: 0x23E59B0 VA: 0x1823E6FB0
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x23E6F10 Offset: 0x23E5910 VA: 0x1823E6F10
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x4B6CA0 Offset: 0x4B56A0 VA: 0x1804B6CA0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x23E6630 Offset: 0x23E5030 VA: 0x1823E6630
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x23E92F0 Offset: 0x23E7CF0 VA: 0x1823E92F0
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x23E88E0 Offset: 0x23E72E0 VA: 0x1823E88E0
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x23E6380 Offset: 0x23E4D80 VA: 0x1823E6380
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x23EA0D0 Offset: 0x23E8AD0 VA: 0x1823EA0D0
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x23EE950 Offset: 0x23ED350 VA: 0x1823EE950
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x23E70B0 Offset: 0x23E5AB0 VA: 0x1823E70B0
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x23ED340 Offset: 0x23EBD40 VA: 0x1823ED340
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x23E90D0 Offset: 0x23E7AD0 VA: 0x1823E90D0
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x23E9230 Offset: 0x23E7C30 VA: 0x1823E9230
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x23EFFA0 Offset: 0x23EE9A0 VA: 0x1823EFFA0
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x23E7F70 Offset: 0x23E6970 VA: 0x1823E7F70
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x23E6D20 Offset: 0x23E5720 VA: 0x1823E6D20
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x23E67E0 Offset: 0x23E51E0 VA: 0x1823E67E0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x23E6DD0 Offset: 0x23E57D0 VA: 0x1823E6DD0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x23E6930 Offset: 0x23E5330 VA: 0x1823E6930
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x23EA660 Offset: 0x23E9060 VA: 0x1823EA660
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x23EC100 Offset: 0x23EAB00 VA: 0x1823EC100
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x23EA310 Offset: 0x23E8D10 VA: 0x1823EA310
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x23EA530 Offset: 0x23E8F30 VA: 0x1823EA530
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x23EB900 Offset: 0x23EA300 VA: 0x1823EB900
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x23EC2D0 Offset: 0x23EACD0 VA: 0x1823EC2D0
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x23EB540 Offset: 0x23E9F40 VA: 0x1823EB540
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x23EBD50 Offset: 0x23EA750 VA: 0x1823EBD50
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x23EE280 Offset: 0x23ECC80 VA: 0x1823EE280
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x23EAB10 Offset: 0x23E9510 VA: 0x1823EAB10
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x23EBB70 Offset: 0x23EA570 VA: 0x1823EBB70
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x23EC6A0 Offset: 0x23EB0A0 VA: 0x1823EC6A0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x23EC8C0 Offset: 0x23EB2C0 VA: 0x1823EC8C0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x23EA7F0 Offset: 0x23E91F0 VA: 0x1823EA7F0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x23F00B0 Offset: 0x23EEAB0 VA: 0x1823F00B0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x23F0330 Offset: 0x23EED30 VA: 0x1823F0330
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x23F0640 Offset: 0x23EF040 VA: 0x1823F0640
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x23EFF20 Offset: 0x23EE920 VA: 0x1823EFF20
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x23E92B0 Offset: 0x23E7CB0 VA: 0x1823E92B0
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x23E8F60 Offset: 0x23E7960 VA: 0x1823E8F60
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x23EFF70 Offset: 0x23EE970 VA: 0x1823EFF70
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x23EA1A0 Offset: 0x23E8BA0 VA: 0x1823EA1A0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x23EA280 Offset: 0x23E8C80 VA: 0x1823EA280
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }
}
