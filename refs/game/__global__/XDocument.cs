public class XDocument : XContainer // TypeDefIndex: 18619
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x23C7840 Offset: 0x23C6240 VA: 0x1823C7840
	public void .ctor(XDocument other) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public XDeclaration get_Declaration() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x23C7910 Offset: 0x23C6310 VA: 0x1823C7910
	public XElement get_Root() { }

	// RVA: 0x23C76F0 Offset: 0x23C60F0 VA: 0x1823C76F0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x23C7100 Offset: 0x23C5B00 VA: 0x1823C7100 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x23C70B0 Offset: 0x23C5AB0 VA: 0x1823C70B0 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x23C7150 Offset: 0x23C5B50 VA: 0x1823C7150 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7E040 Offset: 0xF7CA40 VA: 0x180F7E040
	|-XDocument.GetFirstNode<object>
	*/

	// RVA: 0x23C7240 Offset: 0x23C5C40 VA: 0x1823C7240
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x23C7400 Offset: 0x23C5E00 VA: 0x1823C7400 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x23C72C0 Offset: 0x23C5CC0 VA: 0x1823C72C0
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x23C7630 Offset: 0x23C6030 VA: 0x1823C7630 Slot: 14
	internal override void ValidateString(string s) { }
}
