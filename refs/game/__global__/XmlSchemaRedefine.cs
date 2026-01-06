public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 8476
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x24569D0 Offset: 0x24553D0 VA: 0x1824569D0
	public void .ctor() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x24569B0 Offset: 0x24553B0 VA: 0x1824569B0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}
