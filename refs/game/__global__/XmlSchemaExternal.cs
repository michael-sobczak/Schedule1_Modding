public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 8435
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[Xml("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation { get; set; }
	[XmlIgnore]
	public XmlSchema Schema { get; set; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_SchemaLocation() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	public void set_SchemaLocation(string value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public XmlSchema get_Schema() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_Id() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Id(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Uri get_BaseUri() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	internal Compositor get_Compositor() { }

	// RVA: 0x4E2900 Offset: 0x4E1300 VA: 0x1804E2900
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
