public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 8422
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[Xml("mixed")]
	public bool IsMixed { get; set; }
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnore]
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_IsMixed() { }

	// RVA: 0x2446B60 Offset: 0x2445560 VA: 0x182446B60
	public void set_IsMixed(bool value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
