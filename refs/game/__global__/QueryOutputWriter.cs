internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 7936
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x24C2FF0 Offset: 0x24C19F0 VA: 0x1824C2FF0
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x24C32E0 Offset: 0x24C1CE0 VA: 0x1824C32E0 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x24C2F90 Offset: 0x24C1990 VA: 0x1824C2F90 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x24C2FC0 Offset: 0x24C19C0 VA: 0x1824C2FC0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x24C2850 Offset: 0x24C1250 VA: 0x1824C2850 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24C2C10 Offset: 0x24C1610 VA: 0x1824C2C10 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C28D0 Offset: 0x24C12D0 VA: 0x1824C28D0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C2990 Offset: 0x24C1390 VA: 0x1824C2990 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C26B0 Offset: 0x24C10B0 VA: 0x1824C26B0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24C2BD0 Offset: 0x24C15D0 VA: 0x1824C2BD0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24C28A0 Offset: 0x24C12A0 VA: 0x1824C28A0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24C29F0 Offset: 0x24C13F0 VA: 0x1824C29F0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x24C32B0 Offset: 0x24C1CB0 VA: 0x1824C32B0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x24C2DF0 Offset: 0x24C17F0 VA: 0x1824C2DF0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x24C2930 Offset: 0x24C1330 VA: 0x1824C2930 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x24C26E0 Offset: 0x24C10E0 VA: 0x1824C26E0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24C2820 Offset: 0x24C1220 VA: 0x1824C2820 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24C2A20 Offset: 0x24C1420 VA: 0x1824C2A20 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24C2EF0 Offset: 0x24C18F0 VA: 0x1824C2EF0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24C2E20 Offset: 0x24C1820 VA: 0x1824C2E20 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24C2740 Offset: 0x24C1140 VA: 0x1824C2740 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C2960 Offset: 0x24C1360 VA: 0x1824C2960 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24C2710 Offset: 0x24C1110 VA: 0x1824C2710 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24C2EC0 Offset: 0x24C18C0 VA: 0x1824C2EC0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24C2A50 Offset: 0x24C1450 VA: 0x1824C2A50 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24C2B30 Offset: 0x24C1530 VA: 0x1824C2B30 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24C2590 Offset: 0x24C0F90 VA: 0x1824C2590 Slot: 28
	public override void Close() { }

	// RVA: 0x24C2640 Offset: 0x24C1040 VA: 0x1824C2640 Slot: 29
	public override void Flush() { }

	// RVA: 0x24C2670 Offset: 0x24C1070 VA: 0x1824C2670
	private bool StartCDataSection() { }

	// RVA: 0x5FF4E0 Offset: 0x5FDEE0 VA: 0x1805FF4E0
	private void EndCDataSection() { }
}
