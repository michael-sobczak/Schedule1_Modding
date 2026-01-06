public class XmlAttribute : XmlNode // TypeDefIndex: 8035
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override string XPLocalName { get; }
	internal bool IsNamespace { get; }

	// Methods

	// RVA: 0x24F0560 Offset: 0x24EEF60 VA: 0x1824F0560
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x24F0760 Offset: 0x24EF160 VA: 0x1824F0760
	internal int get_LocalNameHash() { }

	// RVA: 0x24F0510 Offset: 0x24EEF10 VA: 0x1824F0510
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal XmlName get_XmlName() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x24EFDA0 Offset: 0x24EE7A0 VA: 0x1824EFDA0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x24F0780 Offset: 0x24EF180 VA: 0x1824F0780 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1DF3BB0 Offset: 0x1DF25B0 VA: 0x181DF3BB0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x14E79D0 Offset: 0x14E63D0 VA: 0x1814E79D0 Slot: 35
	public override string get_NamespaceURI() { }

	// RVA: 0x1DF3BE0 Offset: 0x1DF25E0 VA: 0x181DF3BE0 Slot: 36
	public override string get_Prefix() { }

	// RVA: 0x24F0B00 Offset: 0x24EF500 VA: 0x1824F0B00 Slot: 37
	public override void set_Prefix(string value) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1DF3CF0 Offset: 0x1DF26F0 VA: 0x181DF3CF0 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C043E0 Offset: 0x1C02DE0 VA: 0x181C043E0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x11DC8F0 Offset: 0x11DB2F0 VA: 0x1811DC8F0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 43
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x24F0A00 Offset: 0x24EF400 VA: 0x1824F0A00 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x24EFFE0 Offset: 0x24EE9E0 VA: 0x1824EFFE0
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x24F0280 Offset: 0x24EEC80 VA: 0x1824F0280
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x24EFB50 Offset: 0x24EE550 VA: 0x1824EFB50 Slot: 28
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x24EFFD0 Offset: 0x24EE9D0 VA: 0x1824EFFD0 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 61
	public virtual bool get_Specified() { }

	// RVA: 0x24EFF30 Offset: 0x24EE930 VA: 0x1824EFF30 Slot: 23
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x24EFE90 Offset: 0x24EE890 VA: 0x1824EFE90 Slot: 24
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x24F0200 Offset: 0x24EEC00 VA: 0x1824F0200 Slot: 25
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x24F0180 Offset: 0x24EEB80 VA: 0x1824F0180 Slot: 26
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x24EFD20 Offset: 0x24EE720 VA: 0x1824EFD20 Slot: 27
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x24F07A0 Offset: 0x24EF1A0 VA: 0x1824F07A0 Slot: 62
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x24F0A70 Offset: 0x24EF470 VA: 0x1824F0A70 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x24F0430 Offset: 0x24EEE30 VA: 0x1824F0430 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x24F03B0 Offset: 0x24EEDB0 VA: 0x1824F03B0 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x24F0680 Offset: 0x24EF080 VA: 0x1824F0680 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0 Slot: 49
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x24F0990 Offset: 0x24EF390 VA: 0x1824F0990 Slot: 55
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x24F08F0 Offset: 0x24EF2F0 VA: 0x1824F08F0 Slot: 56
	internal override string get_XmlLang() { }

	// RVA: 0x24F08B0 Offset: 0x24EF2B0 VA: 0x1824F08B0 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x24F0820 Offset: 0x24EF220 VA: 0x1824F0820 Slot: 58
	internal override string get_XPLocalName() { }

	// RVA: 0x24F0720 Offset: 0x24EF120 VA: 0x1824F0720
	internal bool get_IsNamespace() { }
}
