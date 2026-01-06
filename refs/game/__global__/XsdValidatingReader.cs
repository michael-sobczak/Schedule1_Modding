internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 8022
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

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
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x24FEE60 Offset: 0x24FD860 VA: 0x1824FEE60
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x24FF070 Offset: 0x24FDA70 VA: 0x1824FF070
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x24FC1C0 Offset: 0x24FABC0 VA: 0x1824FC1C0
	private void Init() { }

	// RVA: 0x24FE1E0 Offset: 0x24FCBE0 VA: 0x1824FE1E0
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x24FF510 Offset: 0x24FDF10 VA: 0x1824FF510 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x24FF3E0 Offset: 0x24FDDE0 VA: 0x1824FF3E0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x24FF250 Offset: 0x24FDC50 VA: 0x1824FF250 Slot: 7
	public override string get_Name() { }

	// RVA: 0x24FF200 Offset: 0x24FDC00 VA: 0x1824FF200 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x24FF390 Offset: 0x24FDD90 VA: 0x1824FF390 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x24FF480 Offset: 0x24FDE80 VA: 0x1824FF480 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x24FF6D0 Offset: 0x24FE0D0 VA: 0x1824FF6D0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x24FF0B0 Offset: 0x24FDAB0 VA: 0x1824FF0B0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x20C7A20 Offset: 0x20C6420 VA: 0x1820C7A20 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x46FFD0 Offset: 0x46E9D0 VA: 0x18046FFD0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x24FF100 Offset: 0x24FDB00 VA: 0x1824FF100 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1B56550 Offset: 0x1B54F50 VA: 0x181B56550 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1B565E0 Offset: 0x1B54FE0 VA: 0x181B565E0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x20C7B40 Offset: 0x20C6540 VA: 0x1820C7B40 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x24FF5F0 Offset: 0x24FDFF0 VA: 0x1824FF5F0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x24FB590 Offset: 0x24F9F90 VA: 0x1824FB590 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x24FB610 Offset: 0x24FA010 VA: 0x1824FB610 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x24FB4A0 Offset: 0x24F9EA0 VA: 0x1824FB4A0 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x24FC680 Offset: 0x24FB080 VA: 0x1824FC680 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x24FC770 Offset: 0x24FB170 VA: 0x1824FC770 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x24FCA00 Offset: 0x24FB400 VA: 0x1824FCA00 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x24FCBF0 Offset: 0x24FB5F0 VA: 0x1824FCBF0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x24FC9A0 Offset: 0x24FB3A0 VA: 0x1824FC9A0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x24FDEC0 Offset: 0x24FC8C0 VA: 0x1824FDEC0 Slot: 31
	public override bool Read() { }

	// RVA: 0x1DFDA80 Offset: 0x1DFC480 VA: 0x181DFDA80 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x24FB0F0 Offset: 0x24F9AF0 VA: 0x1824FB0F0 Slot: 33
	public override void Close() { }

	// RVA: 0x24FF4D0 Offset: 0x24FDED0 VA: 0x1824FF4D0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x24FE430 Offset: 0x24FCE30 VA: 0x1824FE430 Slot: 35
	public override void Skip() { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x24FC620 Offset: 0x24FB020 VA: 0x1824FC620 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x24FE1A0 Offset: 0x24FCBA0 VA: 0x1824FE1A0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x24FDD40 Offset: 0x24FC740 VA: 0x1824FDD40 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x24FE7D0 Offset: 0x24FD1D0 VA: 0x1824FE7D0 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x24FE860 Offset: 0x24FD260 VA: 0x1824FE860 Slot: 56
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x24FEB80 Offset: 0x24FD580 VA: 0x1824FEB80 Slot: 54
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x24FE8B0 Offset: 0x24FD2B0 VA: 0x1824FE8B0 Slot: 57
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x24FEB20 Offset: 0x24FD520 VA: 0x1824FEB20 Slot: 58
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x24FEAC0 Offset: 0x24FD4C0 VA: 0x1824FEAC0 Slot: 59
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x24FEA70 Offset: 0x24FD470 VA: 0x1824FEA70 Slot: 60
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 61
	public bool HasLineInfo() { }

	// RVA: 0x24FF140 Offset: 0x24FDB40 VA: 0x1824FF140 Slot: 62
	public int get_LineNumber() { }

	// RVA: 0x24FF1A0 Offset: 0x24FDBA0 VA: 0x1824FF1A0 Slot: 63
	public int get_LinePosition() { }

	// RVA: 0x24FE5C0 Offset: 0x24FCFC0 VA: 0x1824FE5C0 Slot: 64
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x24FE6B0 Offset: 0x24FD0B0 VA: 0x1824FE6B0 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x24FE740 Offset: 0x24FD140 VA: 0x1824FE740 Slot: 66
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1B56640 Offset: 0x1B55040 VA: 0x181B56640
	private object GetStringValue() { }

	// RVA: 0x24FF090 Offset: 0x24FDA90 VA: 0x1824FF090
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x24FD8B0 Offset: 0x24FC2B0 VA: 0x1824FD8B0
	private void ProcessReaderEvent() { }

	// RVA: 0x24FCDE0 Offset: 0x24FB7E0 VA: 0x1824FCDE0
	private void ProcessElementEvent() { }

	// RVA: 0x24FD450 Offset: 0x24FBE50 VA: 0x1824FD450
	private void ProcessEndElementEvent() { }

	// RVA: 0x24FEC30 Offset: 0x24FD630 VA: 0x1824FEC30
	private void ValidateAttributes() { }

	// RVA: 0x24FB090 Offset: 0x24F9A90 VA: 0x1824FB090
	private void ClearAttributesInfo() { }

	// RVA: 0x24FB2B0 Offset: 0x24F9CB0 VA: 0x1824FB2B0
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x24FB200 Offset: 0x24F9C00 VA: 0x1824FB200
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x24FBB60 Offset: 0x24FA560 VA: 0x1824FBB60
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x24FB9F0 Offset: 0x24FA3F0 VA: 0x1824FB9F0
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x24FADD0 Offset: 0x24F97D0 VA: 0x1824FADD0
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x24FC5D0 Offset: 0x24FAFD0 VA: 0x1824FC5D0
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x24FD780 Offset: 0x24FC180 VA: 0x1824FD780
	private void ProcessInlineSchema() { }

	// RVA: 0x24FDAC0 Offset: 0x24FC4C0 VA: 0x1824FDAC0
	private void ReadAheadForMemberType() { }

	// RVA: 0x24FBCC0 Offset: 0x24FA6C0 VA: 0x1824FBCC0
	private void GetIsDefault() { }

	// RVA: 0x24FC000 Offset: 0x24FAA00 VA: 0x1824FC000
	private void GetMemberType() { }

	// RVA: 0x24FB740 Offset: 0x24FA140 VA: 0x1824FB740
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x24FB130 Offset: 0x24F9B30 VA: 0x1824FB130
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x24FB030 Offset: 0x24F9A30 VA: 0x1824FB030
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x24FC120 Offset: 0x24FAB20 VA: 0x1824FC120
	private string GetOriginalAtomicValueStringOfElement() { }
}
