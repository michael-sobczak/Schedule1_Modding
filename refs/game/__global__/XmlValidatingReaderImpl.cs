internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 7997
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

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
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x24DF790 Offset: 0x24DE190 VA: 0x1824DF790
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x24DFF00 Offset: 0x24DE900 VA: 0x1824DFF00 Slot: 5
	public override XmlReaderSettings get_Settings() { }

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

	// RVA: 0x24DFEC0 Offset: 0x24DE8C0 VA: 0x1824DFEC0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1DFDA80 Offset: 0x1DFC480 VA: 0x181DFDA80 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x20C7A80 Offset: 0x20C6480 VA: 0x1820C7A80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x20C79F0 Offset: 0x20C63F0 VA: 0x1820C79F0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x456EA0 Offset: 0x4558A0 VA: 0x180456EA0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x20C7830 Offset: 0x20C6230 VA: 0x1820C7830 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x20C7860 Offset: 0x20C6260 VA: 0x1820C7860 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x24DEC00 Offset: 0x24DD600 VA: 0x1824DEC00 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x24DEBC0 Offset: 0x24DD5C0 VA: 0x1824DEBC0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x24DECA0 Offset: 0x24DD6A0 VA: 0x1824DECA0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x24DECF0 Offset: 0x24DD6F0 VA: 0x1824DECF0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x24DEC50 Offset: 0x24DD650 VA: 0x1824DEC50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x24DF170 Offset: 0x24DDB70 VA: 0x1824DF170 Slot: 31
	public override bool Read() { }

	// RVA: 0x24DE880 Offset: 0x24DD280 VA: 0x1824DE880 Slot: 33
	public override void Close() { }

	// RVA: 0x24DEA70 Offset: 0x24DD470 VA: 0x1824DEA70 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x24DF030 Offset: 0x24DDA30 VA: 0x1824DF030 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x24DF3D0 Offset: 0x24DDDD0 VA: 0x1824DF3D0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x24DEB00 Offset: 0x24DD500 VA: 0x1824DEB00
	internal void MoveOffEntityReference() { }

	// RVA: 0x24DF0A0 Offset: 0x24DDAA0 VA: 0x1824DF0A0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 54
	public bool HasLineInfo() { }

	// RVA: 0x24DFD30 Offset: 0x24DE730 VA: 0x1824DFD30 Slot: 55
	public int get_LineNumber() { }

	// RVA: 0x24DFDD0 Offset: 0x24DE7D0 VA: 0x1824DFDD0 Slot: 56
	public int get_LinePosition() { }

	// RVA: 0x24DE8C0 Offset: 0x24DD2C0 VA: 0x1824DE8C0 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x23DED70 Offset: 0x23DD770 VA: 0x1823DED70 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x24DEAA0 Offset: 0x24DD4A0 VA: 0x1824DEAA0 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x24DE8C0 Offset: 0x24DD2C0 VA: 0x1824DE8C0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x24DEAA0 Offset: 0x24DD4A0 VA: 0x1824DEAA0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	internal ValidationType get_ValidationType() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x24DFEA0 Offset: 0x24DE8A0 VA: 0x1824DFEA0
	internal bool get_Namespaces() { }

	// RVA: 0x24DED40 Offset: 0x24DD740 VA: 0x1824DED40
	private void ParseDtdFromParserContext() { }

	// RVA: 0x24DF700 Offset: 0x24DE100 VA: 0x1824DF700
	private void ValidateDtd() { }

	// RVA: 0x24DF320 Offset: 0x24DDD20 VA: 0x1824DF320
	private void ResolveEntityInternally() { }

	// RVA: 0x24DF410 Offset: 0x24DDE10 VA: 0x1824DF410
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x24DE970 Offset: 0x24DD370 VA: 0x1824DE970
	private XmlResolver GetResolver() { }

	// RVA: 0x24DEF10 Offset: 0x24DD910 VA: 0x1824DEF10
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal BaseValidator get_Validator() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x24DFE70 Offset: 0x24DE870 VA: 0x1824DFE70 Slot: 52
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x24DFFD0 Offset: 0x24DE9D0 VA: 0x1824DFFD0
	internal bool get_StandAlone() { }

	// RVA: 0x24E0010 Offset: 0x24DEA10 VA: 0x1824E0010
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x24DFFF0 Offset: 0x24DE9F0 VA: 0x1824DFFF0
	internal object get_TypedValueObject() { }

	// RVA: 0x24E0030 Offset: 0x24DEA30 VA: 0x1824E0030
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x24DE860 Offset: 0x24DD260 VA: 0x1824DE860
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x24DFD00 Offset: 0x24DE700 VA: 0x1824DFD00 Slot: 53
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x24DF5C0 Offset: 0x24DDFC0 VA: 0x1824DF5C0
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}
