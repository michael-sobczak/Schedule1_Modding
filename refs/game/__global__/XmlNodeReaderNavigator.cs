internal class XmlNodeReaderNavigator // TypeDefIndex: 8064
{
	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0x2519990 Offset: 0x2518390 VA: 0x182519990
	public void .ctor(XmlNode node) { }

	// RVA: 0x251A260 Offset: 0x2518C60 VA: 0x18251A260
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1BFEC60 Offset: 0x1BFD660 VA: 0x181BFEC60
	public string get_NamespaceURI() { }

	// RVA: 0x251A120 Offset: 0x2518B20 VA: 0x18251A120
	public string get_Name() { }

	// RVA: 0x251A040 Offset: 0x2518A40 VA: 0x18251A040
	public string get_LocalName() { }

	// RVA: 0x2519EA0 Offset: 0x25188A0 VA: 0x182519EA0
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x25181D0 Offset: 0x2516BD0 VA: 0x1825181D0
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x20C7A80 Offset: 0x20C6480 VA: 0x1820C7A80
	public string get_Prefix() { }

	// RVA: 0x251A2E0 Offset: 0x2518CE0 VA: 0x18251A2E0
	public string get_Value() { }

	// RVA: 0x2519E70 Offset: 0x2518870 VA: 0x182519E70
	public string get_BaseURI() { }

	// RVA: 0x251A5B0 Offset: 0x2518FB0 VA: 0x18251A5B0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x251A580 Offset: 0x2518F80 VA: 0x18251A580
	public string get_XmlLang() { }

	// RVA: 0x2519F60 Offset: 0x2518960 VA: 0x182519F60
	public bool get_IsEmptyElement() { }

	// RVA: 0x2519EB0 Offset: 0x25188B0 VA: 0x182519EB0
	public bool get_IsDefault() { }

	// RVA: 0x251A2B0 Offset: 0x2518CB0 VA: 0x18251A2B0
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x2519D20 Offset: 0x2518720 VA: 0x182519D20
	public int get_AttributeCount() { }

	// RVA: 0x2516A90 Offset: 0x2515490 VA: 0x182516A90
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x2517E10 Offset: 0x2516810 VA: 0x182517E10
	private void InitDecAttr() { }

	// RVA: 0x2517660 Offset: 0x2516060 VA: 0x182517660
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x2517610 Offset: 0x2516010 VA: 0x182517610
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x2517580 Offset: 0x2515F80 VA: 0x182517580
	public int GetDecAttrInd(string name) { }

	// RVA: 0x2518050 Offset: 0x2516A50 VA: 0x182518050
	private void InitDocTypeAttr() { }

	// RVA: 0x2517820 Offset: 0x2516220 VA: 0x182517820
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x25177D0 Offset: 0x25161D0 VA: 0x1825177D0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x2517740 Offset: 0x2516140 VA: 0x182517740
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x2516CD0 Offset: 0x25156D0 VA: 0x182516CD0
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x2516D30 Offset: 0x2515730 VA: 0x182516D30
	public string GetAttribute(string name) { }

	// RVA: 0x2516C70 Offset: 0x2515670 VA: 0x182516C70
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x2517010 Offset: 0x2515A10 VA: 0x182517010
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x2517320 Offset: 0x2515D20 VA: 0x182517320
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x2518220 Offset: 0x2516C20 VA: 0x182518220
	public void LogMove(int level) { }

	// RVA: 0x2519940 Offset: 0x2518340 VA: 0x182519940
	public void RollBackMove(ref int level) { }

	// RVA: 0x251A000 Offset: 0x2518A00 VA: 0x18251A000
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x2519860 Offset: 0x2518260 VA: 0x182519860
	public void ResetToAttribute(ref int level) { }

	// RVA: 0x25195C0 Offset: 0x2517FC0 VA: 0x1825195C0
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0x2518EE0 Offset: 0x25178E0 VA: 0x182518EE0
	public bool MoveToAttribute(string name) { }

	// RVA: 0x25189C0 Offset: 0x25173C0 VA: 0x1825189C0
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x2518CA0 Offset: 0x25176A0 VA: 0x182518CA0
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x2518AB0 Offset: 0x25174B0 VA: 0x182518AB0
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x2519030 Offset: 0x2517A30 VA: 0x182519030
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0x2519320 Offset: 0x2517D20 VA: 0x182519320
	public bool MoveToParent() { }

	// RVA: 0x2518FD0 Offset: 0x25179D0 VA: 0x182518FD0
	public bool MoveToFirstChild() { }

	// RVA: 0x2519230 Offset: 0x2517C30 VA: 0x182519230
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x2519290 Offset: 0x2517C90 VA: 0x182519290
	public bool MoveToNext() { }

	// RVA: 0x2518F40 Offset: 0x2517940 VA: 0x182518F40
	public bool MoveToElement() { }

	// RVA: 0x2518270 Offset: 0x2516C70 VA: 0x182518270
	public string LookupNamespace(string prefix) { }

	// RVA: 0x2516B00 Offset: 0x2515500 VA: 0x182516B00
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x2518580 Offset: 0x2516F80 VA: 0x182518580
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x25178C0 Offset: 0x25162C0 VA: 0x1825178C0
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2519380 Offset: 0x2517D80 VA: 0x182519380
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public XmlDocument get_Document() { }
}
