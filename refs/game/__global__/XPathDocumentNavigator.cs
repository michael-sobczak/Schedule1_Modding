internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 8611
{
	// Fields
	private XPathNode[] _pageCurrent; // 0x10
	private XPathNode[] _pageParent; // 0x18
	private int _idxCurrent; // 0x20
	private int _idxParent; // 0x24
	private string _atomizedLocalName; // 0x28

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Name { get; }
	public override string Prefix { get; }
	public override string BaseURI { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x24B96A0 Offset: 0x24B80A0 VA: 0x1824B96A0
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x24B9740 Offset: 0x24B8140 VA: 0x1824B9740
	public void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x24B9BC0 Offset: 0x24B85C0 VA: 0x1824B9BC0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x24B70A0 Offset: 0x24B5AA0 VA: 0x1824B70A0 Slot: 25
	public override XPathNavigator Clone() { }

	// RVA: 0x24B9B40 Offset: 0x24B8540 VA: 0x1824B9B40 Slot: 26
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x24B99E0 Offset: 0x24B83E0 VA: 0x1824B99E0 Slot: 27
	public override string get_LocalName() { }

	// RVA: 0x24B9B00 Offset: 0x24B8500 VA: 0x1824B9B00 Slot: 29
	public override string get_NamespaceURI() { }

	// RVA: 0x24B9A70 Offset: 0x24B8470 VA: 0x1824B9A70 Slot: 28
	public override string get_Name() { }

	// RVA: 0x24B9B80 Offset: 0x24B8580 VA: 0x1824B9B80 Slot: 30
	public override string get_Prefix() { }

	// RVA: 0x24B97A0 Offset: 0x24B81A0 VA: 0x1824B97A0 Slot: 31
	public override string get_BaseURI() { }

	// RVA: 0x24B9A20 Offset: 0x24B8420 VA: 0x1824B9A20 Slot: 21
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x24B7D20 Offset: 0x24B6720 VA: 0x1824B7D20 Slot: 35
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x24B8940 Offset: 0x24B7340 VA: 0x1824B8940 Slot: 36
	public override bool MoveToNextAttribute() { }

	// RVA: 0x24B7830 Offset: 0x24B6230 VA: 0x1824B7830 Slot: 34
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x24B7FD0 Offset: 0x24B69D0 VA: 0x1824B7FD0 Slot: 38
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x24B8A00 Offset: 0x24B7400 VA: 0x1824B8A00 Slot: 39
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x24B8D60 Offset: 0x24B7760 VA: 0x1824B8D60 Slot: 40
	public override bool MoveToNext() { }

	// RVA: 0x24B7DF0 Offset: 0x24B67F0 VA: 0x1824B7DF0 Slot: 41
	public override bool MoveToFirstChild() { }

	// RVA: 0x24B8F60 Offset: 0x24B7960 VA: 0x1824B8F60 Slot: 42
	public override bool MoveToParent() { }

	// RVA: 0x24B90D0 Offset: 0x24B7AD0 VA: 0x1824B90D0 Slot: 44
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x24B8890 Offset: 0x24B7290 VA: 0x1824B8890 Slot: 45
	public override bool MoveToId(string id) { }

	// RVA: 0x24B77A0 Offset: 0x24B61A0 VA: 0x1824B77A0 Slot: 52
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x24B9050 Offset: 0x24B7A50 VA: 0x1824B9050 Slot: 43
	public override void MoveToRoot() { }

	// RVA: 0x24B7B40 Offset: 0x24B6540 VA: 0x1824B7B40 Slot: 46
	public override bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x24B8BD0 Offset: 0x24B75D0 VA: 0x1824B8BD0 Slot: 50
	public override bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x24B7910 Offset: 0x24B6310 VA: 0x1824B7910 Slot: 47
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x24B8E20 Offset: 0x24B7820 VA: 0x1824B8E20 Slot: 51
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x24B8280 Offset: 0x24B6C80 VA: 0x1824B8280 Slot: 48
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x24B8480 Offset: 0x24B6E80 VA: 0x1824B8480 Slot: 49
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x24B9350 Offset: 0x24B7D50 VA: 0x1824B9350 Slot: 60
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x24B9170 Offset: 0x24B7B70 VA: 0x1824B9170 Slot: 61
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x24B9500 Offset: 0x24B7F00 VA: 0x1824B9500 Slot: 62
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x24B9440 Offset: 0x24B7E40 VA: 0x1824B9440 Slot: 63
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x24B7140 Offset: 0x24B5B40 VA: 0x1824B7140 Slot: 54
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x24B74E0 Offset: 0x24B5EE0 VA: 0x1824B74E0 Slot: 53
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x24B7370 Offset: 0x24B5D70 VA: 0x1824B7370
	private int GetPrimaryLocation() { }

	// RVA: 0x24B73D0 Offset: 0x24B5DD0 VA: 0x1824B73D0
	private int GetSecondaryLocation() { }

	// RVA: 0xB298E0 Offset: 0xB282E0 VA: 0x180B298E0 Slot: 33
	public override object get_UnderlyingObject() { }

	// RVA: 0x24B7490 Offset: 0x24B5E90 VA: 0x1824B7490 Slot: 64
	public bool HasLineInfo() { }

	// RVA: 0x24B98C0 Offset: 0x24B82C0 VA: 0x1824B98C0 Slot: 65
	public int get_LineNumber() { }

	// RVA: 0x24B9940 Offset: 0x24B8340 VA: 0x1824B9940 Slot: 66
	public int get_LinePosition() { }

	// RVA: 0x24B7360 Offset: 0x24B5D60 VA: 0x1824B7360
	public int GetPositionHashCode() { }

	// RVA: 0x24B7620 Offset: 0x24B6020 VA: 0x1824B7620
	public bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x24B7710 Offset: 0x24B6110 VA: 0x1824B7710
	public bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x24B7270 Offset: 0x24B5C70 VA: 0x1824B7270
	private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd) { }
}
