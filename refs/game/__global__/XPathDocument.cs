public class XPathDocument // TypeDefIndex: 8129
{
	// Fields
	private XPathNode[] pageText; // 0x10
	private XPathNode[] pageRoot; // 0x18
	private XPathNode[] pageXmlNmsp; // 0x20
	private int idxText; // 0x28
	private int idxRoot; // 0x2C
	private int idxXmlNmsp; // 0x30
	private XmlNameTable nameTable; // 0x38
	private bool hasLineInfo; // 0x40
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x48
	private Dictionary<string, XPathNodeRef> idValueMap; // 0x50

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	internal bool get_HasLineInfo() { }

	// RVA: 0x252BEF0 Offset: 0x252A8F0 VA: 0x18252BEF0
	internal int GetCollapsedTextNode(out XPathNode[] pageText) { }

	// RVA: 0x252BF20 Offset: 0x252A920 VA: 0x18252BF20
	internal int GetRootNode(out XPathNode[] pageRoot) { }

	// RVA: 0x252BF50 Offset: 0x252A950 VA: 0x18252BF50
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x252C050 Offset: 0x252AA50 VA: 0x18252C050
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x252BF80 Offset: 0x252A980 VA: 0x18252BF80
	internal int LookupIdElement(string id, out XPathNode[] pageElem) { }
}
