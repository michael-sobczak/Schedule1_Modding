public sealed class XmlWriterSettings // TypeDefIndex: 8016
{
	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x24F83C0 Offset: 0x24F6DC0 VA: 0x1824F83C0
	public void .ctor() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_Async() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Encoding get_Encoding() { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x24F8750 Offset: 0x24F7150 VA: 0x1824F8750
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_NewLineChars() { }

	// RVA: 0x24F8540 Offset: 0x24F6F40 VA: 0x1824F8540
	public bool get_Indent() { }

	// RVA: 0x24F8650 Offset: 0x24F7050 VA: 0x1824F8650
	public void set_Indent(bool value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_IndentChars() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x1C12200 Offset: 0x1C10C00 VA: 0x181C12200
	public bool get_CloseOutput() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x24F85B0 Offset: 0x24F6FB0 VA: 0x1824F85B0
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x4B5BF0 Offset: 0x4B45F0 VA: 0x1804B5BF0
	public bool get_CheckCharacters() { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x24F86B0 Offset: 0x24F70B0 VA: 0x1824F86B0
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x4B5410 Offset: 0x4B3E10 VA: 0x1804B5410
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x24F7A90 Offset: 0x24F6490 VA: 0x1824F7A90
	public XmlWriterSettings Clone() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	internal bool get_MergeCDataSections() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	internal string get_MediaType() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal string get_DocTypeSystem() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal string get_DocTypePublic() { }

	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x4CD060 Offset: 0x4CBA60 VA: 0x1804CD060
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	internal TriState get_IndentInternal() { }

	// RVA: 0x24F8550 Offset: 0x24F6F50 VA: 0x1824F8550
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x24F7B80 Offset: 0x24F6580 VA: 0x1824F7B80
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x24F7FC0 Offset: 0x24F69C0 VA: 0x1824F7FC0
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x4CED90 Offset: 0x4CD790 VA: 0x1804CED90
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x24F79E0 Offset: 0x24F63E0 VA: 0x1824F79E0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x24F8290 Offset: 0x24F6C90 VA: 0x1824F8290
	private void Initialize() { }
}
