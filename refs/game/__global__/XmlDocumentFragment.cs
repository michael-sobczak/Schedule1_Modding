public class XmlDocumentFragment : XmlNode // TypeDefIndex: 8044
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0x250D2F0 Offset: 0x250BCF0 VA: 0x18250D2F0
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x250D380 Offset: 0x250BD80 VA: 0x18250D380 Slot: 8
	public override string get_Name() { }

	// RVA: 0x250D380 Offset: 0x250BD80 VA: 0x18250D380 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0xA141A0 Offset: 0xA12BA0 VA: 0x180A141A0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x250D3B0 Offset: 0x250BDB0 VA: 0x18250D3B0 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x250D420 Offset: 0x250BE20 VA: 0x18250D420 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x250CF60 Offset: 0x250B960 VA: 0x18250CF60 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x250D000 Offset: 0x250BA00 VA: 0x18250D000 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x250CE60 Offset: 0x250B860 VA: 0x18250CE60 Slot: 31
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x250CEE0 Offset: 0x250B8E0 VA: 0x18250CEE0 Slot: 30
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x24F6A10 Offset: 0x24F5410 VA: 0x1824F6A10 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x250D0C0 Offset: 0x250BAC0 VA: 0x18250D0C0 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }
}
