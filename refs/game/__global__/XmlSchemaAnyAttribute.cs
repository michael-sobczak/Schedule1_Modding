public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 8412
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[Xml("namespace")]
	public string Namespace { set; }
	[Xml("processContents")]
	[DefaultValue(0)]
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	public void set_Namespace(string value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x2444D70 Offset: 0x2443770 VA: 0x182444D70
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x2444AE0 Offset: 0x24434E0 VA: 0x182444AE0
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x2444A30 Offset: 0x2443430 VA: 0x182444A30
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x24449F0 Offset: 0x24433F0 VA: 0x1824449F0
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x2444C60 Offset: 0x2443660 VA: 0x182444C60
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x2444B80 Offset: 0x2443580 VA: 0x182444B80
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x2444C90 Offset: 0x2443690 VA: 0x182444C90
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
