public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 8409
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAny]
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Id() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_Id(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
