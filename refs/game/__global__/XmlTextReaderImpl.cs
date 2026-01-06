internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 7983
{
	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

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
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0x23E0300 Offset: 0x23DED00 VA: 0x1823E0300
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x23E08F0 Offset: 0x23DF2F0 VA: 0x1823E08F0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x23E0000 Offset: 0x23DEA00 VA: 0x1823E0000
	internal void .ctor(Stream input) { }

	// RVA: 0x23E0F70 Offset: 0x23DF970 VA: 0x1823E0F70
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x23E0ED0 Offset: 0x23DF8D0 VA: 0x1823E0ED0
	internal void .ctor(TextReader input) { }

	// RVA: 0x23E0180 Offset: 0x23DEB80 VA: 0x1823E0180
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x23E01F0 Offset: 0x23DEBF0 VA: 0x1823E01F0
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x23DFD70 Offset: 0x23DE770 VA: 0x1823DFD70
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x23E07A0 Offset: 0x23DF1A0 VA: 0x1823E07A0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x23E10A0 Offset: 0x23DFAA0 VA: 0x1823E10A0
	public void .ctor(string url, XmlNameTable nt) { }

	// RVA: 0x23CF7E0 Offset: 0x23CE1E0 VA: 0x1823CF7E0
	private void FinishInitUriString() { }

	// RVA: 0x23E1380 Offset: 0x23DFD80 VA: 0x1823E1380
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x23CF660 Offset: 0x23CE060 VA: 0x1823CF660
	private void FinishInitStream() { }

	// RVA: 0x23DFEB0 Offset: 0x23DE8B0 VA: 0x1823DFEB0
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x23CF740 Offset: 0x23CE140 VA: 0x1823CF740
	private void FinishInitTextReader() { }

	// RVA: 0x23E12B0 Offset: 0x23DFCB0 VA: 0x1823E12B0
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x23E1A00 Offset: 0x23E0400 VA: 0x1823E1A00 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x23E1980 Offset: 0x23E0380 VA: 0x1823E1980 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x23E1930 Offset: 0x23E0330 VA: 0x1823E1930 Slot: 7
	public override string get_Name() { }

	// RVA: 0x23E1910 Offset: 0x23E0310 VA: 0x1823E1910 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x23E1960 Offset: 0x23E0360 VA: 0x1823E1960 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x23E19A0 Offset: 0x23E03A0 VA: 0x1823E19A0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x23E1BA0 Offset: 0x23E05A0 VA: 0x1823E1BA0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x23E1680 Offset: 0x23E0080 VA: 0x1823E1680 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x599600 Offset: 0x598000 VA: 0x180599600 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x23E1840 Offset: 0x23E0240 VA: 0x1823E1840 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x23E1810 Offset: 0x23E0210 VA: 0x1823E1810 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x23E19C0 Offset: 0x23E03C0 VA: 0x1823E19C0 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x23E1D30 Offset: 0x23E0730 VA: 0x1823E1D30 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x23E1D10 Offset: 0x23E0710 VA: 0x1823E1D10 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x23E19F0 Offset: 0x23E03F0 VA: 0x1823E19F0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x23E17A0 Offset: 0x23E01A0 VA: 0x1823E17A0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x23D0240 Offset: 0x23CEC40 VA: 0x1823D0240 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x23D02D0 Offset: 0x23CECD0 VA: 0x1823D02D0 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x23D0190 Offset: 0x23CEB90 VA: 0x1823D0190 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x23D28D0 Offset: 0x23D12D0 VA: 0x1823D28D0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x23D29A0 Offset: 0x23D13A0 VA: 0x1823D29A0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x23D2B10 Offset: 0x23D1510 VA: 0x1823D2B10 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x23D2B90 Offset: 0x23D1590 VA: 0x1823D2B90 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x23D2A80 Offset: 0x23D1480 VA: 0x1823D2A80 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x23CFB90 Offset: 0x23CE590 VA: 0x1823CFB90
	private void FinishInit() { }

	// RVA: 0x23DC5B0 Offset: 0x23DAFB0 VA: 0x1823DC5B0 Slot: 31
	public override bool Read() { }

	// RVA: 0x23CE420 Offset: 0x23CCE20 VA: 0x1823CE420 Slot: 33
	public override void Close() { }

	// RVA: 0x23DE650 Offset: 0x23DD050 VA: 0x1823DE650 Slot: 35
	public override void Skip() { }

	// RVA: 0x23D26B0 Offset: 0x23D10B0 VA: 0x1823D26B0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x23DB780 Offset: 0x23DA180 VA: 0x1823DB780 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x23DD100 Offset: 0x23DBB00 VA: 0x1823DD100 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x23D2800 Offset: 0x23D1200 VA: 0x1823D2800
	internal void MoveOffEntityReference() { }

	// RVA: 0x23DBFB0 Offset: 0x23DA9B0 VA: 0x1823DBFB0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x23DC080 Offset: 0x23DAA80 VA: 0x1823DC080 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 54
	public bool HasLineInfo() { }

	// RVA: 0x23E18B0 Offset: 0x23E02B0 VA: 0x1823E18B0 Slot: 55
	public int get_LineNumber() { }

	// RVA: 0x23E18E0 Offset: 0x23E02E0 VA: 0x1823E18E0 Slot: 56
	public int get_LinePosition() { }

	// RVA: 0x23D0770 Offset: 0x23CF170 VA: 0x1823D0770 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x23DED70 Offset: 0x23DD770 VA: 0x1823DED70 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x23D27D0 Offset: 0x23D11D0 VA: 0x1823D27D0 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x23D0770 Offset: 0x23CF170 VA: 0x1823D0770
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x23D27D0 Offset: 0x23D11D0 VA: 0x1823D27D0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0xD39680 Offset: 0xD38080 VA: 0x180D39680
	internal bool get_Namespaces() { }

	// RVA: 0x23E1E40 Offset: 0x23E0840 VA: 0x1823E1E40
	internal void set_Namespaces(bool value) { }

	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	internal bool get_Normalization() { }

	// RVA: 0x23E20A0 Offset: 0x23E0AA0 VA: 0x1823E20A0
	internal void set_Normalization(bool value) { }

	// RVA: 0x23E2170 Offset: 0x23E0B70 VA: 0x1823E2170
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x23E1D50 Offset: 0x23E0750 VA: 0x1823E1D50
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x21C7C10 Offset: 0x21C6610 VA: 0x1821C7C10
	internal bool get_IsResolverSet() { }

	// RVA: 0x23E2260 Offset: 0x23E0C60 VA: 0x1823E2260
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x23E1770 Offset: 0x23E0170 VA: 0x1823E1770
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x523400 Offset: 0x521E00 VA: 0x180523400
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0xD39680 Offset: 0xD38080 VA: 0x180D39680
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0xABD6C0 Offset: 0xABC0C0 VA: 0x180ABD6C0
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x23E16A0 Offset: 0x23E00A0 VA: 0x1823E16A0
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0xDA2600 Offset: 0xDA1000 VA: 0x180DA2600
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x23E1780 Offset: 0x23E0180 VA: 0x1823E1780
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x23E1790 Offset: 0x23E0190 VA: 0x1823E1790
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x23CE730 Offset: 0x23CD130 VA: 0x1823CE730
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0xA9F7E0 Offset: 0xA9E1E0 VA: 0x180A9F7E0
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x23CF160 Offset: 0x23CDB60 VA: 0x1823CF160
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x23CECF0 Offset: 0x23CD6F0 VA: 0x1823CECF0
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x23CECE0 Offset: 0x23CD6E0 VA: 0x1823CECE0
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x23CEDA0 Offset: 0x23CD7A0 VA: 0x1823CEDA0
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x23CE920 Offset: 0x23CD320 VA: 0x1823CE920
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x23E1870 Offset: 0x23E0270 VA: 0x1823E1870
	private bool get_IsResolverNull() { }

	// RVA: 0x23D07E0 Offset: 0x23CF1E0 VA: 0x1823D07E0
	private XmlResolver GetTempResolver() { }

	// RVA: 0x23CEE70 Offset: 0x23CD870 VA: 0x1823CEE70
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x23CEDF0 Offset: 0x23CD7F0 VA: 0x1823CEDF0
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x23CEF40 Offset: 0x23CD940 VA: 0x1823CEF40
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x23CF0C0 Offset: 0x23CDAC0 VA: 0x1823CF0C0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x23CF170 Offset: 0x23CDB70 VA: 0x1823CF170
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x23CE830 Offset: 0x23CD230 VA: 0x1823CE830
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x23CE740 Offset: 0x23CD140 VA: 0x1823CE740
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x23DF930 Offset: 0x23DE330 VA: 0x1823DF930
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x23DFA30 Offset: 0x23DE430 VA: 0x1823DFA30
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x23DF770 Offset: 0x23DE170 VA: 0x1823DF770
	private void Throw(int pos, string res) { }

	// RVA: 0x23DF950 Offset: 0x23DE350 VA: 0x1823DF950
	private void Throw(string res) { }

	// RVA: 0x23DF6C0 Offset: 0x23DE0C0 VA: 0x1823DF6C0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x23DF7D0 Offset: 0x23DE1D0 VA: 0x1823DF7D0
	private void Throw(string res, string arg) { }

	// RVA: 0x23DF9A0 Offset: 0x23DE3A0 VA: 0x1823DF9A0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x23DF610 Offset: 0x23DE010 VA: 0x1823DF610
	private void Throw(string res, string[] args) { }

	// RVA: 0x23DF580 Offset: 0x23DDF80 VA: 0x1823DF580
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x23DFA50 Offset: 0x23DE450 VA: 0x1823DFA50
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x23DF880 Offset: 0x23DE280 VA: 0x1823DF880
	private void Throw(Exception e) { }

	// RVA: 0x23DB6E0 Offset: 0x23DA0E0 VA: 0x1823DB6E0
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x23DF4E0 Offset: 0x23DDEE0 VA: 0x1823DF4E0
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x23DF3D0 Offset: 0x23DDDD0 VA: 0x1823DF3D0
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x23DF450 Offset: 0x23DDE50 VA: 0x1823DF450
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x23DEE10 Offset: 0x23DD810 VA: 0x1823DEE10
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x23DD6B0 Offset: 0x23DC0B0 VA: 0x1823DD6B0
	private void SetErrorState() { }

	// RVA: 0x23DD4A0 Offset: 0x23DBEA0 VA: 0x1823DD4A0
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x23DD3C0 Offset: 0x23DBDC0 VA: 0x1823DD3C0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x23E17B0 Offset: 0x23E01B0 VA: 0x1823E17B0
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x23CF450 Offset: 0x23CDE50 VA: 0x1823CF450
	private void FinishAttributeValueIterator() { }

	// RVA: 0x23E1770 Offset: 0x23E0170 VA: 0x1823E1770
	private bool get_DtdValidation() { }

	// RVA: 0x23D21A0 Offset: 0x23D0BA0 VA: 0x1823D21A0
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x23D22A0 Offset: 0x23D0CA0 VA: 0x1823D22A0
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x23D2220 Offset: 0x23D0C20 VA: 0x1823D2220
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x23D22D0 Offset: 0x23D0CD0 VA: 0x1823D22D0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x23D1EF0 Offset: 0x23D08F0 VA: 0x1823D1EF0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x23D2420 Offset: 0x23D0E20 VA: 0x1823D2420
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x23D2440 Offset: 0x23D0E40 VA: 0x1823D2440
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x23D2300 Offset: 0x23D0D00 VA: 0x1823D2300
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x23D1C20 Offset: 0x23D0620 VA: 0x1823D1C20
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x23DAD90 Offset: 0x23D9790 VA: 0x1823DAD90
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x23D36B0 Offset: 0x23D20B0 VA: 0x1823D36B0
	private void OpenUrl() { }

	// RVA: 0x23D3520 Offset: 0x23D1F20 VA: 0x1823D3520
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x23CE530 Offset: 0x23CCF30 VA: 0x1823CE530
	private Encoding DetectEncoding() { }

	// RVA: 0x23DD6D0 Offset: 0x23DC0D0 VA: 0x1823DD6D0
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x23DEBD0 Offset: 0x23DD5D0 VA: 0x1823DEBD0
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x23CDFC0 Offset: 0x23CC9C0 VA: 0x1823CDFC0
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x23DFB00 Offset: 0x23DE500 VA: 0x1823DFB00
	private void UnDecodeChars() { }

	// RVA: 0x23DEB60 Offset: 0x23DD560 VA: 0x1823DEB60
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x23DBB20 Offset: 0x23DA520 VA: 0x1823DBB20
	private int ReadData() { }

	// RVA: 0x23D0490 Offset: 0x23CEE90 VA: 0x1823D0490
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x23D2540 Offset: 0x23D0F40 VA: 0x1823D2540
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x23CE310 Offset: 0x23CCD10 VA: 0x1823CE310
	internal void Close(bool closeInput) { }

	// RVA: 0x23DDD00 Offset: 0x23DC700 VA: 0x1823DDD00
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x23D9BA0 Offset: 0x23D85A0 VA: 0x1823D9BA0
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x23D5CB0 Offset: 0x23D46B0 VA: 0x1823D5CB0
	private bool ParseDocumentContent() { }

	// RVA: 0x23D6700 Offset: 0x23D5100 VA: 0x1823D6700
	private bool ParseElementContent() { }

	// RVA: 0x23DF050 Offset: 0x23DDA50 VA: 0x1823DF050
	private void ThrowUnclosedElements() { }

	// RVA: 0x23D6A80 Offset: 0x23D5480 VA: 0x1823D6A80
	private void ParseElement() { }

	// RVA: 0x23CCEC0 Offset: 0x23CB8C0 VA: 0x1823CCEC0
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x23D6FB0 Offset: 0x23D59B0 VA: 0x1823D6FB0
	private void ParseEndElement() { }

	// RVA: 0x23DEE80 Offset: 0x23DD880 VA: 0x1823DEE80
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0x23D4AC0 Offset: 0x23D34C0 VA: 0x1823D4AC0
	private void ParseAttributes() { }

	// RVA: 0x23CF3C0 Offset: 0x23CDDC0 VA: 0x1823CF3C0
	private void ElementNamespaceLookup() { }

	// RVA: 0x23CDEC0 Offset: 0x23CC8C0 VA: 0x1823CDEC0
	private void AttributeNamespaceLookup() { }

	// RVA: 0x23CDA90 Offset: 0x23CC490 VA: 0x1823CDA90
	private void AttributeDuplCheck() { }

	// RVA: 0x23D2D40 Offset: 0x23D1740 VA: 0x1823D2D40
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x23D2F50 Offset: 0x23D1950 VA: 0x1823D2F50
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x23D3040 Offset: 0x23D1A40 VA: 0x1823D3040
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x23D4000 Offset: 0x23D2A00 VA: 0x1823D4000
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x23CBEF0 Offset: 0x23CA8F0 VA: 0x1823CBEF0
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0x23D8E70 Offset: 0x23D7870 VA: 0x1823D8E70
	private bool ParseText() { }

	// RVA: 0x23D9300 Offset: 0x23D7D00 VA: 0x1823D9300
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x23CFD20 Offset: 0x23CE720 VA: 0x1823CFD20
	private void FinishPartialValue() { }

	// RVA: 0x23CFBE0 Offset: 0x23CE5E0 VA: 0x1823CFBE0
	private void FinishOtherValueIterator() { }

	// RVA: 0x23DE0D0 Offset: 0x23DCAD0 VA: 0x1823DE0D0
	private void SkipPartialTextValue() { }

	// RVA: 0x23D0090 Offset: 0x23CEA90 VA: 0x1823D0090
	private void FinishReadValueChunk() { }

	// RVA: 0x23CFE60 Offset: 0x23CE860 VA: 0x1823CFE60
	private void FinishReadContentAsBinary() { }

	// RVA: 0x23CFFC0 Offset: 0x23CE9C0 VA: 0x1823CFFC0
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x23D8C30 Offset: 0x23D7630 VA: 0x1823D8C30
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x23D74A0 Offset: 0x23D5EA0 VA: 0x1823D74A0
	private void ParseEntityReference() { }

	// RVA: 0x23D0A90 Offset: 0x23CF490 VA: 0x1823D0A90
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x23D0D20 Offset: 0x23CF720 VA: 0x1823D0D20
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x23E17D0 Offset: 0x23E01D0 VA: 0x1823E17D0
	private bool get_InEntity() { }

	// RVA: 0x23D08F0 Offset: 0x23CF2F0 VA: 0x1823D08F0
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x23DD8F0 Offset: 0x23DC2F0 VA: 0x1823DD8F0
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x23DD860 Offset: 0x23DC260 VA: 0x1823DD860
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x23D8980 Offset: 0x23D7380 VA: 0x1823D8980
	private bool ParsePI() { }

	// RVA: 0x23D8580 Offset: 0x23D6F80 VA: 0x1823D8580
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x23D8200 Offset: 0x23D6C00 VA: 0x1823D8200
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x23D57B0 Offset: 0x23D41B0 VA: 0x1823D57B0
	private bool ParseComment() { }

	// RVA: 0x23D5720 Offset: 0x23D4120 VA: 0x1823D5720
	private void ParseCData() { }

	// RVA: 0x23D5560 Offset: 0x23D3F60 VA: 0x1823D5560
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x23D5130 Offset: 0x23D3B30 VA: 0x1823D5130
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x23D59E0 Offset: 0x23D43E0 VA: 0x1823D59E0
	private bool ParseDoctypeDecl() { }

	// RVA: 0x23D6440 Offset: 0x23D4E40 VA: 0x1823D6440
	private void ParseDtd() { }

	// RVA: 0x23DDD30 Offset: 0x23DC730 VA: 0x1823DDD30
	private void SkipDtd() { }

	// RVA: 0x23DE130 Offset: 0x23DCB30 VA: 0x1823DE130
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x23DE1C0 Offset: 0x23DCBC0 VA: 0x1823DE1C0
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0x23CF180 Offset: 0x23CDB80 VA: 0x1823CF180
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x23D5730 Offset: 0x23D4130 VA: 0x1823D5730
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x23D8130 Offset: 0x23D6B30 VA: 0x1823D8130
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x23D7980 Offset: 0x23D6380 VA: 0x1823D7980
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x23D7900 Offset: 0x23D6300 VA: 0x1823D7900
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x23D75F0 Offset: 0x23D5FF0 VA: 0x1823D75F0
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x23D75C0 Offset: 0x23D5FC0 VA: 0x1823D75C0
	private int ParseName() { }

	// RVA: 0x23D8C10 Offset: 0x23D7610 VA: 0x1823D8C10
	private int ParseQName(out int colonPos) { }

	// RVA: 0x23D8990 Offset: 0x23D7390 VA: 0x1823D8990
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x23DBAE0 Offset: 0x23DA4E0 VA: 0x1823DBAE0
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0x23D73B0 Offset: 0x23D5DB0 VA: 0x1823D73B0
	private string ParseEntityName() { }

	// RVA: 0x23CD760 Offset: 0x23CC160 VA: 0x1823CD760
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x23CD910 Offset: 0x23CC310 VA: 0x1823CD910
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x23CBF70 Offset: 0x23CA970 VA: 0x1823CBF70
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x23CC000 Offset: 0x23CAA00 VA: 0x1823CC000
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x23CC220 Offset: 0x23CAC20 VA: 0x1823CC220
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x23DAB50 Offset: 0x23D9550 VA: 0x1823DAB50
	private void PopElementContext() { }

	// RVA: 0x23CE730 Offset: 0x23CD130 VA: 0x1823CE730
	private void OnNewLine(int pos) { }

	// RVA: 0x23D2E80 Offset: 0x23D1880 VA: 0x1823D2E80
	private void OnEof() { }

	// RVA: 0x23D26F0 Offset: 0x23D10F0 VA: 0x1823D26F0
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0x23CD4F0 Offset: 0x23CBEF0 VA: 0x1823CD4F0
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x23DD020 Offset: 0x23DBA20 VA: 0x1823DD020
	private void ResetAttributes() { }

	// RVA: 0x23D00D0 Offset: 0x23CEAD0 VA: 0x1823D00D0
	private void FullAttributeCleanup() { }

	// RVA: 0x23DB650 Offset: 0x23DA050 VA: 0x1823DB650
	private void PushXmlContext() { }

	// RVA: 0x23DAD40 Offset: 0x23D9740 VA: 0x1823DAD40
	private void PopXmlContext() { }

	// RVA: 0x23D08A0 Offset: 0x23CF2A0 VA: 0x1823D08A0
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x23D0840 Offset: 0x23CF240 VA: 0x1823D0840
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x23DAE00 Offset: 0x23D9800 VA: 0x1823DAE00
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x23D3270 Offset: 0x23D1C70 VA: 0x1823D3270
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x23DB140 Offset: 0x23D9B40 VA: 0x1823DB140
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x23DB350 Offset: 0x23D9D50 VA: 0x1823DB350
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x23DABD0 Offset: 0x23D95D0 VA: 0x1823DABD0
	private void PopEntity() { }

	// RVA: 0x23DCDF0 Offset: 0x23DB7F0 VA: 0x1823DCDF0
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x23DFBB0 Offset: 0x23DE5B0 VA: 0x1823DFBB0
	private void UnregisterEntity() { }

	// RVA: 0x23DB4C0 Offset: 0x23D9EC0 VA: 0x1823DB4C0
	private void PushParsingState() { }

	// RVA: 0x23DAC70 Offset: 0x23D9670 VA: 0x1823DAC70
	private void PopParsingState() { }

	// RVA: 0x23D11B0 Offset: 0x23CFBB0 VA: 0x1823D11B0
	private int IncrementalRead() { }

	// RVA: 0x23CF5D0 Offset: 0x23CDFD0 VA: 0x1823CF5D0
	private void FinishIncrementalRead() { }

	// RVA: 0x23D7520 Offset: 0x23D5F20 VA: 0x1823D7520
	private bool ParseFragmentAttribute() { }

	// RVA: 0x23D39F0 Offset: 0x23D23F0 VA: 0x1823D39F0
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x23D9B10 Offset: 0x23D8510 VA: 0x1823D9B10
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x23DF260 Offset: 0x23DDC60 VA: 0x1823DF260
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x23DF250 Offset: 0x23DDC50 VA: 0x1823DF250
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x23DF230 Offset: 0x23DDC30 VA: 0x1823DF230
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x23DF280 Offset: 0x23DDC80 VA: 0x1823DF280
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x23D9A10 Offset: 0x23D8410 VA: 0x1823D9A10
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x23D9A20 Offset: 0x23D8420 VA: 0x1823D9A20
	private string ParseUnexpectedToken() { }

	// RVA: 0x23DED90 Offset: 0x23DD790 VA: 0x1823DED90
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x23D0660 Offset: 0x23CF060 VA: 0x1823D0660
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x23D0570 Offset: 0x23CEF70 VA: 0x1823D0570
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x23DFD00 Offset: 0x23DE700 VA: 0x1823DFD00
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x23D6240 Offset: 0x23D4C40 VA: 0x1823D6240
	private void ParseDtdFromParserContext() { }

	// RVA: 0x23D2C30 Offset: 0x23D1630 VA: 0x1823D2C30
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x23DDA30 Offset: 0x23DC430 VA: 0x1823DDA30
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360 Slot: 53
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x23DD5F0 Offset: 0x23DBFF0 VA: 0x1823DD5F0
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x23E2320 Offset: 0x23E0D20 VA: 0x1823E2320
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x7D55E0 Offset: 0x7D3FE0 VA: 0x1807D55E0
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x23CDFA0 Offset: 0x23CC9A0 VA: 0x1823CDFA0
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x23D07A0 Offset: 0x23CF1A0 VA: 0x1823D07A0
	internal XmlResolver GetResolver() { }

	// RVA: 0x23E1DE0 Offset: 0x23E07E0 VA: 0x1823E1DE0
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x23E17E0 Offset: 0x23E01E0 VA: 0x1823E17E0
	internal object get_InternalTypedValue() { }

	// RVA: 0x23E1E10 Offset: 0x23E0810 VA: 0x1823E1E10
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x23E1B90 Offset: 0x23E0590 VA: 0x1823E1B90
	internal bool get_StandAlone() { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850 Slot: 52
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0xABD6C0 Offset: 0xABC0C0 VA: 0x180ABD6C0
	internal bool get_V1Compat() { }

	// RVA: 0x23CC390 Offset: 0x23CAD90 VA: 0x1823CC390
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0x23CCBF0 Offset: 0x23CB5F0 VA: 0x1823CCBF0
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x23CC930 Offset: 0x23CB330 VA: 0x1823CC930
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x860BA0 Offset: 0x85F5A0 VA: 0x180860BA0
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x23DFC10 Offset: 0x23DE610 VA: 0x1823DFC10
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x23DCCC0 Offset: 0x23DB6C0 VA: 0x1823DCCC0
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0x23DE810 Offset: 0x23DD210 VA: 0x1823DE810
	internal static string StripSpaces(string value) { }

	// RVA: 0x23DEA00 Offset: 0x23DD400 VA: 0x1823DEA00
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0x1D1A1F0 Offset: 0x1D18BF0 VA: 0x181D1A1F0
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x23CDF90 Offset: 0x23CC990 VA: 0x1823CDF90
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }
}
