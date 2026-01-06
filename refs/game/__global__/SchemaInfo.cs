internal class SchemaInfo : IDtdInfo // TypeDefIndex: 8381
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0x242E6B0 Offset: 0x242D0B0 VA: 0x18242E6B0
	internal void .ctor() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x242E890 Offset: 0x242D290 VA: 0x18242E890
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x242E990 Offset: 0x242D390 VA: 0x18242E990
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	internal SchemaType get_SchemaType() { }

	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x242E910 Offset: 0x242D310 VA: 0x18242E910
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	internal int get_ErrorCount() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	internal void set_ErrorCount(int value) { }

	// RVA: 0x242E320 Offset: 0x242CD20 VA: 0x18242E320
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x242E430 Offset: 0x242CE30 VA: 0x18242E430
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x242E3A0 Offset: 0x242CDA0 VA: 0x18242E3A0
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x242E4B0 Offset: 0x242CEB0 VA: 0x18242E4B0
	internal bool HasSchema(string ns) { }

	// RVA: 0x242DBA0 Offset: 0x242C5A0 VA: 0x18242DBA0
	internal bool Contains(string ns) { }

	// RVA: 0x242DD90 Offset: 0x242C790 VA: 0x18242DD90
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x242E0A0 Offset: 0x242CAA0 VA: 0x18242E0A0
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x242DF50 Offset: 0x242C950 VA: 0x18242DF50
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x242D250 Offset: 0x242BC50 VA: 0x18242D250
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x242DC00 Offset: 0x242C600 VA: 0x18242DC00
	internal void Finish() { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x242E510 Offset: 0x242CF10 VA: 0x18242E510 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x242E5E0 Offset: 0x242CFE0 VA: 0x18242E5E0 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }
}
