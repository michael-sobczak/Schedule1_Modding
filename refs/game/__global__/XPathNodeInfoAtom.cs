internal sealed class XPathNodeInfoAtom // TypeDefIndex: 8616
{
	// Fields
	private string _localName; // 0x10
	private string _namespaceUri; // 0x18
	private string _prefix; // 0x20
	private string _baseUri; // 0x28
	private XPathNode[] _pageParent; // 0x30
	private XPathNode[] _pageSibling; // 0x38
	private XPathNode[] _pageSimilar; // 0x40
	private XPathDocument _doc; // 0x48
	private int _lineNumBase; // 0x50
	private int _linePosBase; // 0x54
	private XPathNodePageInfo _pageInfo; // 0x58

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public string BaseUri { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] SimilarElementPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_LocalName() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_NamespaceUri() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Prefix() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_BaseUri() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public XPathDocument get_Document() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_LineNumberBase() { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public int get_LinePositionBase() { }
}
