public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 8479
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
