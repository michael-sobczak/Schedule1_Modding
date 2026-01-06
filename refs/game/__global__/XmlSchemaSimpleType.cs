public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 8482
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0x245F590 Offset: 0x245DF90 VA: 0x18245F590
	public void .ctor() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x245F460 Offset: 0x245DE60 VA: 0x18245F460 Slot: 13
	internal override XmlSchemaObject Clone() { }
}
