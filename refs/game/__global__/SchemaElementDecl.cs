internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 8378
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0x242CDE0 Offset: 0x242B7E0 VA: 0x18242CDE0
	internal void .ctor() { }

	// RVA: 0x242CB00 Offset: 0x242B500 VA: 0x18242CB00
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x242CC80 Offset: 0x242B680 VA: 0x18242CC80
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x242C890 Offset: 0x242B290 VA: 0x18242C890
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x1D14B40 Offset: 0x1D13540 VA: 0x181D14B40 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x242C9E0 Offset: 0x242B3E0 VA: 0x18242C9E0 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	internal bool get_IsIdDeclared() { }

	// RVA: 0x83DBC0 Offset: 0x83C5C0 VA: 0x18083DBC0
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x1D14B40 Offset: 0x1D13540 VA: 0x181D14B40
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x1D14D80 Offset: 0x1D13780 VA: 0x181D14D80
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x242C830 Offset: 0x242B230 VA: 0x18242C830
	internal SchemaElementDecl Clone() { }

	// RVA: 0x2389870 Offset: 0x2388270 VA: 0x182389870
	internal bool get_IsAbstract() { }

	// RVA: 0x2389DC0 Offset: 0x23887C0 VA: 0x182389DC0
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x242CEF0 Offset: 0x242B8F0 VA: 0x18242CEF0
	internal bool get_IsNillable() { }

	// RVA: 0x242CF00 Offset: 0x242B900 VA: 0x18242CF00
	internal void set_IsNillable(bool value) { }

	// RVA: 0x4E2430 Offset: 0x4E0E30 VA: 0x1804E2430
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x589020 Offset: 0x587A20 VA: 0x180589020
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x6586F0 Offset: 0x6570F0 VA: 0x1806586F0
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x658830 Offset: 0x657230 VA: 0x180658830
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x9AD4C0 Offset: 0x9ABEC0 VA: 0x1809AD4C0
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x658700 Offset: 0x657100 VA: 0x180658700
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x242C450 Offset: 0x242AE50 VA: 0x18242C450
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x242C960 Offset: 0x242B360 VA: 0x18242C960
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x242C5B0 Offset: 0x242AFB0 VA: 0x18242C5B0
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x242CA90 Offset: 0x242B490 VA: 0x18242CA90
	private static void .cctor() { }
}
