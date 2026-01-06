internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 8375
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x2416C30 Offset: 0x2415630 VA: 0x182416C30
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x240EF60 Offset: 0x240D960 VA: 0x18240EF60
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x240EA00 Offset: 0x240D400 VA: 0x18240EA00
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x240F270 Offset: 0x240DC70 VA: 0x18240F270
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x240E0C0 Offset: 0x240CAC0 VA: 0x18240E0C0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x2414840 Offset: 0x2413240 VA: 0x182414840
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0x2412E70 Offset: 0x2411870 VA: 0x182412E70
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x240EC80 Offset: 0x240D680 VA: 0x18240EC80
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x240E830 Offset: 0x240D230 VA: 0x18240E830
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x240E2F0 Offset: 0x240CCF0 VA: 0x18240E2F0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x240E8C0 Offset: 0x240D2C0 VA: 0x18240E8C0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x240E440 Offset: 0x240CE40 VA: 0x18240E440
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x2410290 Offset: 0x240EC90 VA: 0x182410290
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x2411D00 Offset: 0x2410700 VA: 0x182411D00
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x240FF30 Offset: 0x240E930 VA: 0x18240FF30
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x2410160 Offset: 0x240EB60 VA: 0x182410160
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x2411500 Offset: 0x240FF00 VA: 0x182411500
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x2411ED0 Offset: 0x24108D0 VA: 0x182411ED0
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x2411100 Offset: 0x240FB00 VA: 0x182411100
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x2411950 Offset: 0x2410350 VA: 0x182411950
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x2414130 Offset: 0x2412B30 VA: 0x182414130
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x24106D0 Offset: 0x240F0D0 VA: 0x1824106D0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x2411770 Offset: 0x2410170 VA: 0x182411770
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x24122A0 Offset: 0x2410CA0 VA: 0x1824122A0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x2412490 Offset: 0x2410E90 VA: 0x182412490
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x2410420 Offset: 0x240EE20 VA: 0x182410420
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x24165E0 Offset: 0x2414FE0 VA: 0x1824165E0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x2416800 Offset: 0x2415200 VA: 0x182416800
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x2416B10 Offset: 0x2415510 VA: 0x182416B10
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x23EFF70 Offset: 0x23EE970 VA: 0x1823EFF70
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x240FE20 Offset: 0x240E820 VA: 0x18240FE20
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x2416590 Offset: 0x2414F90 VA: 0x182416590
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x240F1C0 Offset: 0x240DBC0 VA: 0x18240F1C0
	private Stream GetSchemaEntity(Uri ruri) { }
}
