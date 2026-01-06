internal sealed class DocumentXPathNavigator : XPathNavigator, IHasXmlNode // TypeDefIndex: 8023
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlNode source; // 0x18
	private int attributeIndex; // 0x20
	private XmlElement namespaceParent; // 0x28

	// Properties
	public override XmlNameTable NameTable { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Name { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	private string ValueDocument { get; }
	private string ValueText { get; }
	public override string BaseURI { get; }
	public override string XmlLang { get; }
	public override object UnderlyingObject { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x24EBF30 Offset: 0x24EA930 VA: 0x1824EBF30
	public void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x24EBFB0 Offset: 0x24EA9B0 VA: 0x1824EBFB0
	public void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x24E7AA0 Offset: 0x24E64A0 VA: 0x1824E7AA0 Slot: 25
	public override XPathNavigator Clone() { }

	// RVA: 0x24EC0B0 Offset: 0x24EAAB0 VA: 0x1824EC0B0 Slot: 21
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x24EC330 Offset: 0x24EAD30 VA: 0x1824EC330 Slot: 26
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x24EC080 Offset: 0x24EAA80 VA: 0x1824EC080 Slot: 27
	public override string get_LocalName() { }

	// RVA: 0x24EC260 Offset: 0x24EAC60 VA: 0x1824EC260 Slot: 29
	public override string get_NamespaceURI() { }

	// RVA: 0x24EC0E0 Offset: 0x24EAAE0 VA: 0x1824EC0E0 Slot: 28
	public override string get_Name() { }

	// RVA: 0x24EC3B0 Offset: 0x24EADB0 VA: 0x1824EC3B0 Slot: 30
	public override string get_Prefix() { }

	// RVA: 0x24EC710 Offset: 0x24EB110 VA: 0x1824EC710 Slot: 5
	public override string get_Value() { }

	// RVA: 0x24EC510 Offset: 0x24EAF10 VA: 0x1824EC510
	private string get_ValueDocument() { }

	// RVA: 0x24EC590 Offset: 0x24EAF90 VA: 0x1824EC590
	private string get_ValueText() { }

	// RVA: 0x24EC050 Offset: 0x24EAA50 VA: 0x1824EC050 Slot: 31
	public override string get_BaseURI() { }

	// RVA: 0x24EC9A0 Offset: 0x24EB3A0 VA: 0x1824EC9A0 Slot: 32
	public override string get_XmlLang() { }

	// RVA: 0x24EC4B0 Offset: 0x24EAEB0 VA: 0x1824EC4B0 Slot: 33
	public override object get_UnderlyingObject() { }

	// RVA: 0x24E88A0 Offset: 0x24E72A0 VA: 0x1824E88A0 Slot: 34
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x24E8C90 Offset: 0x24E7690 VA: 0x1824E8C90 Slot: 35
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x24E9D80 Offset: 0x24E8780 VA: 0x1824E9D80 Slot: 36
	public override bool MoveToNextAttribute() { }

	// RVA: 0x24E9A40 Offset: 0x24E8440 VA: 0x1824E9A40 Slot: 37
	public override bool MoveToNamespace(string name) { }

	// RVA: 0x24E91E0 Offset: 0x24E7BE0 VA: 0x1824E91E0 Slot: 38
	public override bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x24E9130 Offset: 0x24E7B30 VA: 0x1824E9130
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x24E8F90 Offset: 0x24E7990 VA: 0x1824E8F90
	private static bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x24EA230 Offset: 0x24E8C30 VA: 0x1824EA230 Slot: 39
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x24EA190 Offset: 0x24E8B90 VA: 0x1824EA190
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x24E9FF0 Offset: 0x24E89F0 VA: 0x1824E9FF0
	private static bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x24EB590 Offset: 0x24E9F90 VA: 0x1824EB590
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x24E8830 Offset: 0x24E7230 VA: 0x1824E8830 Slot: 22
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x24EAAC0 Offset: 0x24E94C0 VA: 0x1824EAAC0 Slot: 40
	public override bool MoveToNext() { }

	// RVA: 0x24E8DF0 Offset: 0x24E77F0 VA: 0x1824E8DF0 Slot: 41
	public override bool MoveToFirstChild() { }

	// RVA: 0x24EAEC0 Offset: 0x24E98C0 VA: 0x1824EAEC0 Slot: 42
	public override bool MoveToParent() { }

	// RVA: 0x24EAFF0 Offset: 0x24E99F0 VA: 0x1824EAFF0 Slot: 43
	public override void MoveToRoot() { }

	// RVA: 0x24EB120 Offset: 0x24E9B20 VA: 0x1824EB120 Slot: 44
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x24E99D0 Offset: 0x24E83D0 VA: 0x1824E99D0 Slot: 45
	public override bool MoveToId(string id) { }

	// RVA: 0x24E8A60 Offset: 0x24E7460 VA: 0x1824E8A60 Slot: 46
	public override bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x24E8B90 Offset: 0x24E7590 VA: 0x1824E8B90 Slot: 47
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x24E9490 Offset: 0x24E7E90 VA: 0x1824E9490 Slot: 48
	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x24E9730 Offset: 0x24E8130 VA: 0x1824E9730 Slot: 49
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x24EAC80 Offset: 0x24E9680 VA: 0x1824EAC80 Slot: 50
	public override bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x24EAD70 Offset: 0x24E9770 VA: 0x1824EAD70 Slot: 51
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x24E8630 Offset: 0x24E7030 VA: 0x1824E8630 Slot: 52
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x24E8460 Offset: 0x24E6E60 VA: 0x1824E8460 Slot: 53
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x24EC480 Offset: 0x24EAE80 VA: 0x1824EC480 Slot: 55
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x24EB3E0 Offset: 0x24E9DE0 VA: 0x1824EB3E0
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x24E8300 Offset: 0x24E6D00 VA: 0x1824E8300
	private static int GetDepth(XmlNode node) { }

	// RVA: 0x24E8000 Offset: 0x24E6A00 VA: 0x1824E8000
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x24E7B70 Offset: 0x24E6570 VA: 0x1824E7B70 Slot: 54
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 64
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x24EBC90 Offset: 0x24EA690 VA: 0x1824EBC90 Slot: 63
	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x24EBB60 Offset: 0x24EA560 VA: 0x1824EBB60 Slot: 62
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x24EB9F0 Offset: 0x24EA3F0 VA: 0x1824EB9F0
	internal void ResetPosition(XmlNode node) { }

	// RVA: 0x24EB960 Offset: 0x24EA360 VA: 0x1824EB960
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index) { }

	// RVA: 0x24E79D0 Offset: 0x24E63D0 VA: 0x1824E79D0
	private static bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index) { }

	// RVA: 0x24E7980 Offset: 0x24E6380 VA: 0x1824E7980
	private void CalibrateText() { }

	// RVA: 0x24EB4F0 Offset: 0x24E9EF0 VA: 0x1824EB4F0
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x24EB480 Offset: 0x24E9E80 VA: 0x1824EB480
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x24E8260 Offset: 0x24E6C60 VA: 0x1824E8260
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x24E81F0 Offset: 0x24E6BF0 VA: 0x1824E81F0
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x24EB2B0 Offset: 0x24E9CB0 VA: 0x1824EB2B0
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x24EB1D0 Offset: 0x24E9BD0 VA: 0x1824EB1D0
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x24EB7F0 Offset: 0x24EA1F0 VA: 0x1824EB7F0
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x24EB6B0 Offset: 0x24EA0B0 VA: 0x1824EB6B0
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x24E8570 Offset: 0x24E6F70 VA: 0x1824E8570
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x24E8740 Offset: 0x24E7140 VA: 0x1824E8740
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x24EBEC0 Offset: 0x24EA8C0 VA: 0x1824EBEC0
	private XmlNode TextEnd(XmlNode node) { }
}
