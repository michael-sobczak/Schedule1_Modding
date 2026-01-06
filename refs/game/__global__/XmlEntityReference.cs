public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 8049
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x250F880 Offset: 0x250E280 VA: 0x18250F880
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public override string get_Value() { }

	// RVA: 0x250FBC0 Offset: 0x250E5C0 VA: 0x18250FBC0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x250F400 Offset: 0x250DE00 VA: 0x18250F400 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x250F530 Offset: 0x250DF30 VA: 0x18250F530 Slot: 49
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x250F510 Offset: 0x250DF10 VA: 0x18250F510 Slot: 50
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x250E170 Offset: 0x250CB70 VA: 0x18250E170 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x250F840 Offset: 0x250E240 VA: 0x18250F840 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x250F610 Offset: 0x250E010 VA: 0x18250F610 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x250FA00 Offset: 0x250E400 VA: 0x18250FA00 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x250F450 Offset: 0x250DE50 VA: 0x18250F450
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x250FA40 Offset: 0x250E440 VA: 0x18250FA40
	internal string get_ChildBaseURI() { }
}
