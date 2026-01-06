public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 8432
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[Xml("xml:lang")]
	public string Language { set; }
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Source(string value) { }

	// RVA: 0x244A2A0 Offset: 0x2448CA0 VA: 0x18244A2A0
	public void set_Language(string value) { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x244A1D0 Offset: 0x2448BD0 VA: 0x18244A1D0
	private static void .cctor() { }
}
