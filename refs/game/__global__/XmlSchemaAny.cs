public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 8411
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[Xml("namespace")]
	public string Namespace { get; set; }
	[DefaultValue(0)]
	[Xml("processContents")]
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal string ResolvedNamespace { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_Namespace() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_Namespace(string value) { }

	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x24453B0 Offset: 0x2443DB0 VA: 0x1824453B0
	internal string get_ResolvedNamespace() { }

	// RVA: 0x2445390 Offset: 0x2443D90 VA: 0x182445390
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x2444F80 Offset: 0x2443980 VA: 0x182444F80 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x2444E80 Offset: 0x2443880 VA: 0x182444E80
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x2444DC0 Offset: 0x24437C0 VA: 0x182444DC0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x2444D80 Offset: 0x2443780 VA: 0x182444D80
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x2444F30 Offset: 0x2443930 VA: 0x182444F30
	public void .ctor() { }
}
