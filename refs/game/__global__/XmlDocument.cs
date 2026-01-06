public class XmlDocument : XmlNode // TypeDefIndex: 8043
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	private XmlAttribute namespaceXml; // 0x138
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	internal Encoding TextEncoding { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal bool HasEntityReferences { get; }
	internal XmlAttribute NamespaceXml { get; }

	// Methods

	// RVA: 0x24F6B90 Offset: 0x24F5590 VA: 0x1824F6B90
	public void .ctor() { }

	// RVA: 0x24F6BF0 Offset: 0x24F55F0 VA: 0x1824F6BF0
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x24F6C60 Offset: 0x24F5660 VA: 0x1824F6C60
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x24F2D40 Offset: 0x24F1740 VA: 0x1824F2D40
	internal static void CheckName(string name) { }

	// RVA: 0x24F2690 Offset: 0x24F1090 VA: 0x1824F2690
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x24F4AB0 Offset: 0x24F34B0 VA: 0x1824F4AB0
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x24F1F30 Offset: 0x24F0930 VA: 0x1824F1F30
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x24F25B0 Offset: 0x24F0FB0 VA: 0x1824F25B0
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x24F4680 Offset: 0x24F3080 VA: 0x1824F4680
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x24F48A0 Offset: 0x24F32A0 VA: 0x1824F48A0
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x24F4030 Offset: 0x24F2A30 VA: 0x1824F4030
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x24F23A0 Offset: 0x24F0DA0 VA: 0x1824F23A0
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x24F6110 Offset: 0x24F4B10 VA: 0x1824F6110
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x24F2E10 Offset: 0x24F1810 VA: 0x1824F2E10 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x24F7330 Offset: 0x24F5D30 VA: 0x1824F7330 Slot: 61
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x24F71F0 Offset: 0x24F5BF0 VA: 0x1824F71F0 Slot: 62
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public XmlImplementation get_Implementation() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250 Slot: 8
	public override string get_Name() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x24F72A0 Offset: 0x24F5CA0 VA: 0x1824F72A0
	public XmlElement get_DocumentElement() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 20
	internal override bool get_IsContainer() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 21
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0 Slot: 22
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	internal bool get_CanReportValidity() { }

	// RVA: 0x67E960 Offset: 0x67D360 VA: 0x18067E960
	internal bool get_HasSetResolver() { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	internal XmlResolver GetResolver() { }

	// RVA: 0x24F77A0 Offset: 0x24F61A0 VA: 0x1824F77A0 Slot: 63
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x24F5720 Offset: 0x24F4120 VA: 0x1824F5720 Slot: 29
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x24F4CA0 Offset: 0x24F36A0 VA: 0x1824F4CA0
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x24F4C20 Offset: 0x24F3620 VA: 0x1824F4C20
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x24F2B80 Offset: 0x24F1580 VA: 0x1824F2B80 Slot: 30
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x24F2A30 Offset: 0x24F1430 VA: 0x1824F2A30 Slot: 31
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x24F2FA0 Offset: 0x24F19A0 VA: 0x1824F2FA0
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x24F66F0 Offset: 0x24F50F0 VA: 0x1824F66F0
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x24F3180 Offset: 0x24F1B80 VA: 0x1824F3180 Slot: 64
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x24F3200 Offset: 0x24F1C00 VA: 0x1824F3200 Slot: 65
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x24F3370 Offset: 0x24F1D70 VA: 0x1824F3370 Slot: 66
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x24F3310 Offset: 0x24F1D10 VA: 0x1824F3310 Slot: 67
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x24F34C0 Offset: 0x24F1EC0 VA: 0x1824F34C0
	public XmlElement CreateElement(string name) { }

	// RVA: 0x24F2070 Offset: 0x24F0A70 VA: 0x1824F2070
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x24F4990 Offset: 0x24F3390 VA: 0x1824F4990
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x24F5EE0 Offset: 0x24F48E0 VA: 0x1824F5EE0
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x24F3640 Offset: 0x24F2040 VA: 0x1824F3640 Slot: 68
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x24F3900 Offset: 0x24F2300 VA: 0x1824F3900 Slot: 69
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x24F3AD0 Offset: 0x24F24D0 VA: 0x1824F3AD0 Slot: 70
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x24F39F0 Offset: 0x24F23F0 VA: 0x1824F39F0 Slot: 71
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x24F3980 Offset: 0x24F2380 VA: 0x1824F3980 Slot: 72
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x24F38E0 Offset: 0x24F22E0 VA: 0x1824F38E0 Slot: 7
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0x24F36B0 Offset: 0x24F20B0 VA: 0x1824F36B0 Slot: 73
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x24F5700 Offset: 0x24F4100 VA: 0x1824F5700
	internal static bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x24F5CF0 Offset: 0x24F46F0 VA: 0x1824F5CF0
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x24F3A60 Offset: 0x24F2460 VA: 0x1824F3A60 Slot: 74
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x24F30D0 Offset: 0x24F1AD0 VA: 0x1824F30D0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x24F3410 Offset: 0x24F1E10 VA: 0x1824F3410
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x24F3DA0 Offset: 0x24F27A0 VA: 0x1824F3DA0 Slot: 75
	public virtual XmlElement GetElementById(string elementId) { }

	// RVA: 0x24F4FC0 Offset: 0x24F39C0 VA: 0x1824F4FC0
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x24F4D90 Offset: 0x24F3790 VA: 0x1824F4D90
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x24F4F00 Offset: 0x24F3900 VA: 0x1824F4F00
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x1DF3BE0 Offset: 0x1DF25E0 VA: 0x181DF3BE0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x24F2F00 Offset: 0x24F1900 VA: 0x1824F2F00 Slot: 76
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x24F3280 Offset: 0x24F1C80 VA: 0x1824F3280 Slot: 77
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x24F3570 Offset: 0x24F1F70 VA: 0x1824F3570 Slot: 78
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x24F73F0 Offset: 0x24F5DF0 VA: 0x1824F73F0
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x2044FF0 Offset: 0x20439F0 VA: 0x182044FF0
	internal bool get_IsLoading() { }

	// RVA: 0x24E6370 Offset: 0x24E4D70 VA: 0x1824E6370
	internal void set_IsLoading(bool value) { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x24F6040 Offset: 0x24F4A40 VA: 0x1824F6040 Slot: 79
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x24F67A0 Offset: 0x24F51A0 VA: 0x1824F67A0
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x24F5A70 Offset: 0x24F4470 VA: 0x1824F5A70 Slot: 80
	public virtual void Load(string filename) { }

	// RVA: 0x24F5BC0 Offset: 0x24F45C0 VA: 0x1824F5BC0 Slot: 81
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x24F58F0 Offset: 0x24F42F0 VA: 0x1824F58F0 Slot: 82
	public virtual void LoadXml(string xml) { }

	// RVA: 0x24F76A0 Offset: 0x24F60A0 VA: 0x1824F76A0
	internal Encoding get_TextEncoding() { }

	// RVA: 0x24F7740 Offset: 0x24F6140 VA: 0x1824F7740 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x1D98530 Offset: 0x1D96F30 VA: 0x181D98530 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x24F6270 Offset: 0x24F4C70 VA: 0x1824F6270 Slot: 83
	public virtual void Save(string filename) { }

	// RVA: 0x24F6490 Offset: 0x24F4E90 VA: 0x1824F6490 Slot: 84
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x24F6A10 Offset: 0x24F5410 VA: 0x1824F6A10 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x24F6810 Offset: 0x24F5210 VA: 0x1824F6810 Slot: 46
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x24F4580 Offset: 0x24F2F80 VA: 0x1824F4580 Slot: 52
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x24F48C0 Offset: 0x24F32C0 VA: 0x1824F48C0
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x24F29B0 Offset: 0x24F13B0 VA: 0x1824F29B0 Slot: 53
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x24F26C0 Offset: 0x24F10C0 VA: 0x1824F26C0 Slot: 54
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x24F3B60 Offset: 0x24F2560 VA: 0x1824F3B60
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x24F7710 Offset: 0x24F6110 VA: 0x1824F7710
	internal string get_Version() { }

	// RVA: 0x24F73C0 Offset: 0x24F5DC0 VA: 0x1824F73C0
	internal string get_Encoding() { }

	// RVA: 0x24F7670 Offset: 0x24F6070 VA: 0x1824F7670
	internal string get_Standalone() { }

	// RVA: 0x24F44A0 Offset: 0x24F2EA0 VA: 0x1824F44A0
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x24F7550 Offset: 0x24F5F50 VA: 0x1824F7550 Slot: 43
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0 Slot: 44
	public override string get_BaseURI() { }

	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x24F2740 Offset: 0x24F1140 VA: 0x1824F2740 Slot: 28
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	internal bool get_HasEntityReferences() { }

	// RVA: 0x24F7460 Offset: 0x24F5E60 VA: 0x1824F7460
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0x24F6A30 Offset: 0x24F5430 VA: 0x1824F6A30
	private static void .cctor() { }
}
