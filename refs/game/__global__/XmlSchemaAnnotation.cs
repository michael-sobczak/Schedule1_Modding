public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 8410
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Id() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Id(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x2444980 Offset: 0x2443380 VA: 0x182444980
	public void .ctor() { }
}
