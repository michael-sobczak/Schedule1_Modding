internal struct XPathNode // TypeDefIndex: 8612
{
	// Fields
	private XPathNodeInfoAtom _info; // 0x0
	private ushort _idxSibling; // 0x8
	private ushort _idxParent; // 0xA
	private ushort _idxSimilar; // 0xC
	private ushort _posOffset; // 0xE
	private uint _props; // 0x10
	private string _value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string Name { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public string BaseUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool HasAttribute { get; }
	public bool HasContentChild { get; }
	public bool HasElementChild { get; }
	public bool IsAttrNmsp { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x24BB880 Offset: 0x24BA280 VA: 0x1824BB880
	public XPathNodeType get_NodeType() { }

	// RVA: 0x24BB8B0 Offset: 0x24BA2B0 VA: 0x1824BB8B0
	public string get_Prefix() { }

	// RVA: 0xD07690 Offset: 0xD06090 VA: 0x180D07690
	public string get_LocalName() { }

	// RVA: 0x24BB7F0 Offset: 0x24BA1F0 VA: 0x1824BB7F0
	public string get_Name() { }

	// RVA: 0x24BB860 Offset: 0x24BA260 VA: 0x1824BB860
	public string get_NamespaceUri() { }

	// RVA: 0x24BB640 Offset: 0x24BA040 VA: 0x1824BB640
	public XPathDocument get_Document() { }

	// RVA: 0x24BB5F0 Offset: 0x24B9FF0 VA: 0x1824BB5F0
	public string get_BaseUri() { }

	// RVA: 0x24BB7A0 Offset: 0x24BA1A0 VA: 0x1824BB7A0
	public int get_LineNumber() { }

	// RVA: 0x24BB7D0 Offset: 0x24BA1D0 VA: 0x1824BB7D0
	public int get_LinePosition() { }

	// RVA: 0x24BB610 Offset: 0x24BA010 VA: 0x1824BB610
	public int get_CollapsedLinePosition() { }

	// RVA: 0x24BB890 Offset: 0x24BA290 VA: 0x1824BB890
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x24BB500 Offset: 0x24B9F00 VA: 0x1824BB500
	public int GetRoot(out XPathNode[] pageNode) { }

	// RVA: 0x24BB4C0 Offset: 0x24B9EC0 VA: 0x1824BB4C0
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x24BB530 Offset: 0x24B9F30 VA: 0x1824BB530
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x24BB570 Offset: 0x24B9F70 VA: 0x1824BB570
	public int GetSimilarElement(out XPathNode[] pageNode) { }

	// RVA: 0x24BB5B0 Offset: 0x24B9FB0 VA: 0x1824BB5B0
	public bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x24BB480 Offset: 0x24B9E80 VA: 0x1824BB480
	public bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x24BB730 Offset: 0x24BA130 VA: 0x1824BB730
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x24BB6B0 Offset: 0x24BA0B0 VA: 0x1824BB6B0
	public bool get_HasSibling() { }

	// RVA: 0x24BB670 Offset: 0x24BA070 VA: 0x1824BB670
	public bool get_HasCollapsedText() { }

	// RVA: 0x24BB660 Offset: 0x24BA060 VA: 0x1824BB660
	public bool get_HasAttribute() { }

	// RVA: 0x24BB680 Offset: 0x24BA080 VA: 0x1824BB680
	public bool get_HasContentChild() { }

	// RVA: 0x24BB690 Offset: 0x24BA090 VA: 0x1824BB690
	public bool get_HasElementChild() { }

	// RVA: 0x24BB6C0 Offset: 0x24BA0C0 VA: 0x1824BB6C0
	public bool get_IsAttrNmsp() { }

	// RVA: 0x24BB6E0 Offset: 0x24BA0E0 VA: 0x1824BB6E0
	public bool get_IsText() { }

	// RVA: 0x24BB6A0 Offset: 0x24BA0A0 VA: 0x1824BB6A0
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Value() { }
}
