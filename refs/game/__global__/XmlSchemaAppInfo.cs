public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 8413
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[XmlText]
	[XmlAnyElement]
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Source(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public XmlNode[] get_Markup() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
