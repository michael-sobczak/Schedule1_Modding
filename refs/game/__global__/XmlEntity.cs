public class XmlEntity : XmlNode // TypeDefIndex: 8048
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x250FCA0 Offset: 0x250E6A0 VA: 0x18250FCA0
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x250FC20 Offset: 0x250E620 VA: 0x18250FC20 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x250EEE0 Offset: 0x250D8E0 VA: 0x18250EEE0 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x250FEF0 Offset: 0x250E8F0 VA: 0x18250FEF0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x250FDF0 Offset: 0x250E7F0 VA: 0x18250FDF0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x250FC80 Offset: 0x250E680 VA: 0x18250FC80 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_SystemId() { }

	// RVA: 0x250FF50 Offset: 0x250E950 VA: 0x18250FF50 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void SetBaseURI(string inBaseURI) { }
}
