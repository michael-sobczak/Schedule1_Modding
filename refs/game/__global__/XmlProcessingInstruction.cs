public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 8067
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }
	internal override string XPLocalName { get; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0x251FDA0 Offset: 0x251E7A0 VA: 0x18251FDA0
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x251FE80 Offset: 0x251E880 VA: 0x18251FE80 Slot: 8
	public override string get_Name() { }

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x251FFB0 Offset: 0x251E9B0 VA: 0x18251FFB0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x251FED0 Offset: 0x251E8D0 VA: 0x18251FED0
	public void set_Data(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x251FFB0 Offset: 0x251E9B0 VA: 0x18251FFB0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x251FD10 Offset: 0x251E710 VA: 0x18251FD10 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x251FD60 Offset: 0x251E760 VA: 0x18251FD60 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30 Slot: 58
	internal override string get_XPLocalName() { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }
}
