public class XmlElement : XmlLinkedNode // TypeDefIndex: 8047
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override string XPLocalName { get; }

	// Methods

	// RVA: 0x250EBB0 Offset: 0x250D5B0 VA: 0x18250EBB0
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x250EB50 Offset: 0x250D550 VA: 0x18250EB50
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal XmlName get_XmlName() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x250DA20 Offset: 0x250C420 VA: 0x18250DA20 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x250EF10 Offset: 0x250D910 VA: 0x18250EF10 Slot: 8
	public override string get_Name() { }

	// RVA: 0x181B1D0 Offset: 0x1819BD0 VA: 0x18181B1D0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x250EF30 Offset: 0x250D930 VA: 0x18250EF30 Slot: 35
	public override string get_NamespaceURI() { }

	// RVA: 0x250EFB0 Offset: 0x250D9B0 VA: 0x18250EFB0 Slot: 36
	public override string get_Prefix() { }

	// RVA: 0x250F330 Offset: 0x250DD30 VA: 0x18250F330 Slot: 37
	public override void set_Prefix(string value) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x250EF90 Offset: 0x250D990 VA: 0x18250EF90 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x250D840 Offset: 0x250C240 VA: 0x18250D840 Slot: 28
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x250EEF0 Offset: 0x250D8F0 VA: 0x18250EEF0
	public bool get_IsEmpty() { }

	// RVA: 0x250F2D0 Offset: 0x250DCD0 VA: 0x18250F2D0
	public void set_IsEmpty(bool value) { }

	// RVA: 0x250EF00 Offset: 0x250D900 VA: 0x18250EF00 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x250E170 Offset: 0x250CB70 VA: 0x18250E170 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x250ED80 Offset: 0x250D780 VA: 0x18250ED80 Slot: 16
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x250EEA0 Offset: 0x250D8A0 VA: 0x18250EEA0 Slot: 61
	public virtual bool get_HasAttributes() { }

	// RVA: 0x250E010 Offset: 0x250CA10 VA: 0x18250E010 Slot: 62
	public virtual string GetAttribute(string name) { }

	// RVA: 0x250E490 Offset: 0x250CE90 VA: 0x18250E490 Slot: 63
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x250DF10 Offset: 0x250C910 VA: 0x18250DF10 Slot: 64
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x250E360 Offset: 0x250CD60 VA: 0x18250E360 Slot: 65
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x250E0A0 Offset: 0x250CAA0 VA: 0x18250E0A0 Slot: 66
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x250E580 Offset: 0x250CF80 VA: 0x18250E580 Slot: 67
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x250DF80 Offset: 0x250C980 VA: 0x18250DF80 Slot: 68
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x250E260 Offset: 0x250CC60 VA: 0x18250E260 Slot: 69
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x250E140 Offset: 0x250CB40 VA: 0x18250E140 Slot: 70
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x250EA30 Offset: 0x250D430 VA: 0x18250EA30 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x250E6C0 Offset: 0x250D0C0 VA: 0x18250E6C0
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x250E8F0 Offset: 0x250D2F0 VA: 0x18250E8F0
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x24F03B0 Offset: 0x24EEDB0 VA: 0x1824F03B0 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x250E1D0 Offset: 0x250CBD0 VA: 0x18250E1D0 Slot: 71
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x250E230 Offset: 0x250CC30 VA: 0x18250E230 Slot: 47
	public override void RemoveAll() { }

	// RVA: 0x250E220 Offset: 0x250CC20 VA: 0x18250E220
	internal void RemoveAllChildren() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 43
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x250F0E0 Offset: 0x250DAE0 VA: 0x18250F0E0 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x250EEE0 Offset: 0x250D8E0 VA: 0x18250EEE0 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x250EFF0 Offset: 0x250D9F0 VA: 0x18250EFF0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x250EF50 Offset: 0x250D950 VA: 0x18250EF50 Slot: 15
	public override XmlNode get_NextSibling() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 49
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x250EFD0 Offset: 0x250D9D0 VA: 0x18250EFD0 Slot: 58
	internal override string get_XPLocalName() { }
}
