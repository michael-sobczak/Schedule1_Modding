internal class XmlLoader // TypeDefIndex: 8053
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x25143A0 Offset: 0x2512DA0 VA: 0x1825143A0
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x2512050 Offset: 0x2510A50 VA: 0x182512050
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x2514ED0 Offset: 0x25138D0 VA: 0x182514ED0
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x2513C70 Offset: 0x2512670 VA: 0x182513C70
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x2511580 Offset: 0x250FF80 VA: 0x182511580
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x2511E60 Offset: 0x2510860 VA: 0x182511E60
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x2511930 Offset: 0x2510330 VA: 0x182511930
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x25130C0 Offset: 0x2511AC0 VA: 0x1825130C0
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x2511C70 Offset: 0x2510670 VA: 0x182511C70
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x25120D0 Offset: 0x2510AD0 VA: 0x1825120D0
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x25134E0 Offset: 0x2511EE0 VA: 0x1825134E0
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x25113C0 Offset: 0x250FDC0 VA: 0x1825113C0
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x2514940 Offset: 0x2513340 VA: 0x182514940
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x2514680 Offset: 0x2513080 VA: 0x182514680
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x2512320 Offset: 0x2510D20 VA: 0x182512320
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x2510B20 Offset: 0x250F520 VA: 0x182510B20
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x25149C0 Offset: 0x25133C0 VA: 0x1825149C0
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x2513340 Offset: 0x2511D40 VA: 0x182513340
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x2513320 Offset: 0x2511D20 VA: 0x182513320
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x2515090 Offset: 0x2513A90 VA: 0x182515090
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x25104D0 Offset: 0x250EED0 VA: 0x1825104D0
	private string EntitizeName(string name) { }

	// RVA: 0x2510A70 Offset: 0x250F470 VA: 0x182510A70
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x2510520 Offset: 0x250EF20 VA: 0x182510520
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x2510260 Offset: 0x250EC60 VA: 0x182510260
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x2514C40 Offset: 0x2513640 VA: 0x182514C40
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x25153D0 Offset: 0x2513DD0 VA: 0x1825153D0
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }
}
