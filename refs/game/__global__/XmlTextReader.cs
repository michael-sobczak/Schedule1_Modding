public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 7968
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x24D3E80 Offset: 0x24D2880 VA: 0x1824D3E80
	public void .ctor(Stream input) { }

	// RVA: 0x24D41C0 Offset: 0x24D2BC0 VA: 0x1824D41C0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x24D4100 Offset: 0x24D2B00 VA: 0x1824D4100
	public void .ctor(TextReader input) { }

	// RVA: 0x24D3F40 Offset: 0x24D2940 VA: 0x1824D3F40
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x24D4010 Offset: 0x24D2A10 VA: 0x1824D4010
	public void .ctor(string url) { }

	// RVA: 0x24D3DB0 Offset: 0x24D27B0 VA: 0x1824D3DB0
	public void .ctor(string url, XmlNameTable nt) { }

	// RVA: 0x20C7AE0 Offset: 0x20C64E0 VA: 0x1820C7AE0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x20C7AB0 Offset: 0x20C64B0 VA: 0x1820C7AB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1DEB9A0 Offset: 0x1DEA3A0 VA: 0x181DEB9A0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1B56580 Offset: 0x1B54F80 VA: 0x181B56580 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1B56670 Offset: 0x1B55070 VA: 0x181B56670 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1B56640 Offset: 0x1B55040 VA: 0x181B56640 Slot: 11
	public override string get_Value() { }

	// RVA: 0x20C7A50 Offset: 0x20C6450 VA: 0x1820C7A50 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x20C7A20 Offset: 0x20C6420 VA: 0x1820C7A20 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x46FFD0 Offset: 0x46E9D0 VA: 0x18046FFD0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1B56610 Offset: 0x1B55010 VA: 0x181B56610 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1B56550 Offset: 0x1B54F50 VA: 0x181B56550 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1B565E0 Offset: 0x1B54FE0 VA: 0x181B565E0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x20C7B40 Offset: 0x20C6540 VA: 0x1820C7B40 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x20C79F0 Offset: 0x20C63F0 VA: 0x1820C79F0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x456EA0 Offset: 0x4558A0 VA: 0x180456EA0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x20C7830 Offset: 0x20C6230 VA: 0x1820C7830 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x20C7860 Offset: 0x20C6260 VA: 0x1820C7860 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xFDBC40 Offset: 0xFDA640 VA: 0x180FDBC40 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x20C78C0 Offset: 0x20C62C0 VA: 0x1820C78C0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x20C78F0 Offset: 0x20C62F0 VA: 0x1820C78F0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1BFF110 Offset: 0x1BFDB10 VA: 0x181BFF110 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1BFF170 Offset: 0x1BFDB70 VA: 0x181BFF170 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x20C7920 Offset: 0x20C6320 VA: 0x1820C7920 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1ABB2C0 Offset: 0x1AB9CC0 VA: 0x181ABB2C0 Slot: 31
	public override bool Read() { }

	// RVA: 0x1DFDA80 Offset: 0x1DFC480 VA: 0x181DFDA80 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x20C7760 Offset: 0x20C6160 VA: 0x1820C7760 Slot: 33
	public override void Close() { }

	// RVA: 0x20C7B10 Offset: 0x20C6510 VA: 0x1820C7B10 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1BFEC60 Offset: 0x1BFD660 VA: 0x181BFEC60 Slot: 35
	public override void Skip() { }

	// RVA: 0x20C7A80 Offset: 0x20C6480 VA: 0x1820C7A80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x24D3D00 Offset: 0x24D2700 VA: 0x1824D3D00 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x24D3D40 Offset: 0x24D2740 VA: 0x1824D3D40 Slot: 42
	public override string ReadString() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 54
	public bool HasLineInfo() { }

	// RVA: 0x24D42E0 Offset: 0x24D2CE0 VA: 0x1824D42E0 Slot: 55
	public int get_LineNumber() { }

	// RVA: 0x24D4300 Offset: 0x24D2D00 VA: 0x1824D4300 Slot: 56
	public int get_LinePosition() { }

	// RVA: 0x24D3D70 Offset: 0x24D2770 VA: 0x1824D3D70 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x20C7890 Offset: 0x20C6290 VA: 0x1820C7890 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x24D3D90 Offset: 0x24D2790 VA: 0x1824D3D90 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x24C0D40 Offset: 0x24BF740 VA: 0x1824C0D40
	public bool get_Namespaces() { }

	// RVA: 0x24C0D60 Offset: 0x24BF760 VA: 0x1824C0D60
	public bool get_Normalization() { }

	// RVA: 0x24D4370 Offset: 0x24D2D70 VA: 0x1824D4370
	public void set_Normalization(bool value) { }

	// RVA: 0x24D4390 Offset: 0x24D2D90 VA: 0x1824D4390
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x24D4350 Offset: 0x24D2D50 VA: 0x1824D4350
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x24D43B0 Offset: 0x24D2DB0 VA: 0x1824D43B0
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x24D4320 Offset: 0x24D2D20 VA: 0x1824D4320 Slot: 52
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x24D43D0 Offset: 0x24D2DD0 VA: 0x1824D43D0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x24D42B0 Offset: 0x24D2CB0 VA: 0x1824D42B0 Slot: 53
	internal override IDtdInfo get_DtdInfo() { }
}
