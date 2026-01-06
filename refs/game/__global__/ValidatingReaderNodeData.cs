internal class ValidatingReaderNodeData // TypeDefIndex: 7947
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x24C4110 Offset: 0x24C2B10 VA: 0x1824C4110
	public void .ctor() { }

	// RVA: 0x24C40E0 Offset: 0x24C2AE0 VA: 0x1824C40E0
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_LocalName() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_LocalName(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Namespace() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Namespace(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Prefix() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_Prefix(string value) { }

	// RVA: 0x24C3E80 Offset: 0x24C2880 VA: 0x1824C3E80
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_Depth() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	public void set_Depth(int value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_RawValue() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_RawValue(string value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_OriginalStringValue() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public XmlNodeType get_NodeType() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public int get_LineNumber() { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get_LinePosition() { }

	// RVA: 0x24C3DA0 Offset: 0x24C27A0 VA: 0x1824C3DA0
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x24C40D0 Offset: 0x24C2AD0 VA: 0x1824C40D0
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x24C4060 Offset: 0x24C2A60 VA: 0x1824C4060
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x24C3F30 Offset: 0x24C2930 VA: 0x1824C3F30
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x24C4020 Offset: 0x24C2A20 VA: 0x1824C4020
	internal void SetItemData(string value) { }

	// RVA: 0x24C3FE0 Offset: 0x24C29E0 VA: 0x1824C3FE0
	internal void SetItemData(string value, string originalStringValue) { }
}
