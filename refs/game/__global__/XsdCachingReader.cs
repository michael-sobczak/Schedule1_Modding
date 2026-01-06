internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 8018
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

	// Properties
	public override XmlReaderSettings Settings { get; }
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
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x24FABB0 Offset: 0x24F95B0 VA: 0x1824FABB0
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x24F9C00 Offset: 0x24F8600 VA: 0x1824F9C00
	private void Init() { }

	// RVA: 0x24FA810 Offset: 0x24F9210 VA: 0x1824FA810
	internal void Reset(XmlReader reader) { }

	// RVA: 0x1DB2C00 Offset: 0x1DB1600 VA: 0x181DB2C00 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x24FAD60 Offset: 0x24F9760 VA: 0x1824FAD60 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x24FAD30 Offset: 0x24F9730 VA: 0x1824FAD30 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FAD10 Offset: 0x24F9710 VA: 0x1824FAD10 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1E70B70 Offset: 0x1E6F570 VA: 0x181E70B70 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x24FAD80 Offset: 0x24F9780 VA: 0x1824FAD80 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x24FADA0 Offset: 0x24F97A0 VA: 0x1824FADA0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x24FACB0 Offset: 0x24F96B0 VA: 0x1824FACB0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x20C7A20 Offset: 0x20C6420 VA: 0x1820C7A20 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1B56550 Offset: 0x1B54F50 VA: 0x181B56550 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1B565E0 Offset: 0x1B54FE0 VA: 0x181B565E0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x20C7B40 Offset: 0x20C6540 VA: 0x1820C7B40 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x24F9B70 Offset: 0x24F8570 VA: 0x1824F9B70 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x24F9A40 Offset: 0x24F8440 VA: 0x1824F9A40 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x24F99B0 Offset: 0x24F83B0 VA: 0x1824F99B0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x24F9E50 Offset: 0x24F8850 VA: 0x1824F9E50 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x24F9DB0 Offset: 0x24F87B0 VA: 0x1824F9DB0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x24F9F30 Offset: 0x24F8930 VA: 0x1824F9F30 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x24F9F80 Offset: 0x24F8980 VA: 0x1824F9F80 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x24F9EE0 Offset: 0x24F88E0 VA: 0x1824F9EE0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x24FA0D0 Offset: 0x24F8AD0 VA: 0x1824FA0D0 Slot: 31
	public override bool Read() { }

	// RVA: 0x24FA790 Offset: 0x24F9190 VA: 0x1824FA790
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x24FA9F0 Offset: 0x24F93F0 VA: 0x1824FA9F0
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x24FA630 Offset: 0x24F9030 VA: 0x1824FA630
	internal void RecordEndElementNode() { }

	// RVA: 0x24FACD0 Offset: 0x24F96D0 VA: 0x1824FACD0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x24F9720 Offset: 0x24F8120 VA: 0x1824F9720 Slot: 33
	public override void Close() { }

	// RVA: 0x20C7B10 Offset: 0x20C6510 VA: 0x1820C7B10 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x24FA8B0 Offset: 0x24F92B0 VA: 0x1824FA8B0 Slot: 35
	public override void Skip() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x20C7890 Offset: 0x20C6290 VA: 0x1820C7890 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x24FA840 Offset: 0x24F9240 VA: 0x1824FA840 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x24F9FE0 Offset: 0x24F89E0 VA: 0x1824F9FE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 54
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x24FAB70 Offset: 0x24F9570 VA: 0x1824FAB70 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x24FAB90 Offset: 0x24F9590 VA: 0x1824FAB90 Slot: 56
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x24FA880 Offset: 0x24F9280 VA: 0x1824FA880
	internal void SetToReplayMode() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlReader GetCoreReader() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x24F9710 Offset: 0x24F8110 VA: 0x1824F9710
	private void ClearAttributesInfo() { }

	// RVA: 0x24F93F0 Offset: 0x24F7DF0 VA: 0x1824F93F0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x24F9580 Offset: 0x24F7F80 VA: 0x1824F9580
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x24FA450 Offset: 0x24F8E50 VA: 0x1824FA450
	private void RecordAttributes() { }

	// RVA: 0x24F98E0 Offset: 0x24F82E0 VA: 0x1824F98E0
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x24F9820 Offset: 0x24F8220 VA: 0x1824F9820
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x24F9760 Offset: 0x24F8160 VA: 0x1824F9760
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }
}
