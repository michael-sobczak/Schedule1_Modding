public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 8065
{
	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x251BA80 Offset: 0x251A480 VA: 0x18251BA80
	public void .ctor(XmlNode node) { }

	// RVA: 0xABCB70 Offset: 0xABB570 VA: 0x180ABCB70
	internal bool IsInReadingStates() { }

	// RVA: 0x251BF80 Offset: 0x251A980 VA: 0x18251BF80 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x251BEA0 Offset: 0x251A8A0 VA: 0x18251BEA0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x251BD50 Offset: 0x251A750 VA: 0x18251BD50 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x251BF00 Offset: 0x251A900 VA: 0x18251BF00 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x251BF90 Offset: 0x251A990 VA: 0x18251BF90 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x251C060 Offset: 0x251AA60 VA: 0x18251C060 Slot: 11
	public override string get_Value() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x251BBC0 Offset: 0x251A5C0 VA: 0x18251BBC0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x251BD20 Offset: 0x251A720 VA: 0x18251BD20 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x251BC40 Offset: 0x251A640 VA: 0x18251BC40 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x251C140 Offset: 0x251AB40 VA: 0x18251C140 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x251C0C0 Offset: 0x251AAC0 VA: 0x18251C0C0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x251C010 Offset: 0x251AA10 VA: 0x18251C010 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x251BB80 Offset: 0x251A580 VA: 0x18251BB80 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x251A6A0 Offset: 0x25190A0 VA: 0x18251A6A0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x251A6D0 Offset: 0x25190D0 VA: 0x18251A6D0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x251A620 Offset: 0x2519020 VA: 0x18251A620 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x251A960 Offset: 0x2519360 VA: 0x18251A960 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x251A7A0 Offset: 0x25191A0 VA: 0x18251A7A0 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x251AC60 Offset: 0x2519660 VA: 0x18251AC60 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x251AD80 Offset: 0x2519780 VA: 0x18251AD80 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x251AAB0 Offset: 0x25194B0 VA: 0x18251AAB0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x251B5B0 Offset: 0x2519FB0 VA: 0x18251B5B0 Slot: 31
	public override bool Read() { }

	// RVA: 0x251B5C0 Offset: 0x2519FC0 VA: 0x18251B5C0
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x251B210 Offset: 0x2519C10 VA: 0x18251B210
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x251B820 Offset: 0x251A220 VA: 0x18251B820
	private void SetEndOfFile() { }

	// RVA: 0x251AF00 Offset: 0x2519900 VA: 0x18251AF00
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x251AFF0 Offset: 0x25199F0 VA: 0x18251AFF0
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x251AED0 Offset: 0x25198D0 VA: 0x18251AED0
	private void ReSetReadingMarks() { }

	// RVA: 0x251BC30 Offset: 0x251A630 VA: 0x18251BC30 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x251A5E0 Offset: 0x2518FE0 VA: 0x18251A5E0 Slot: 33
	public override void Close() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x251B840 Offset: 0x251A240 VA: 0x18251B840 Slot: 35
	public override void Skip() { }

	// RVA: 0x251B500 Offset: 0x2519F00 VA: 0x18251B500 Slot: 42
	public override string ReadString() { }

	// RVA: 0x24D2310 Offset: 0x24D0D10 VA: 0x1824D2310 Slot: 50
	public override bool get_HasAttributes() { }

	// RVA: 0x251BE80 Offset: 0x251A880 VA: 0x18251BE80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x251A760 Offset: 0x2519160 VA: 0x18251A760 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x251B790 Offset: 0x251A190 VA: 0x18251B790 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x251AFA0 Offset: 0x25199A0 VA: 0x18251AFA0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x251A5F0 Offset: 0x2518FF0 VA: 0x18251A5F0
	private void FinishReadBinary() { }

	// RVA: 0x251B850 Offset: 0x251A250 VA: 0x18251B850 Slot: 54
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x251BA60 Offset: 0x251A460 VA: 0x18251BA60 Slot: 56
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x251B870 Offset: 0x251A270 VA: 0x18251B870 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x251BC00 Offset: 0x251A600 VA: 0x18251BC00 Slot: 53
	internal override IDtdInfo get_DtdInfo() { }
}
