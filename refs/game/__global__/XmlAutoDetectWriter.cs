internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 7956
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x24C75E0 Offset: 0x24C5FE0 VA: 0x1824C75E0
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x24C75A0 Offset: 0x24C5FA0 VA: 0x1824C75A0
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x24C7560 Offset: 0x24C5F60 VA: 0x1824C7560
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x24C6E00 Offset: 0x24C5800 VA: 0x1824C6E00 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24C7160 Offset: 0x24C5B60 VA: 0x1824C7160 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C70E0 Offset: 0x24C5AE0 VA: 0x1824C70E0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24C6E80 Offset: 0x24C5880 VA: 0x1824C6E80 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24C6CA0 Offset: 0x24C56A0 VA: 0x1824C6CA0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24C6DC0 Offset: 0x24C57C0 VA: 0x1824C6DC0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24C6FE0 Offset: 0x24C59E0 VA: 0x1824C6FE0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24C7470 Offset: 0x24C5E70 VA: 0x1824C7470 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24C7320 Offset: 0x24C5D20 VA: 0x1824C7320 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24C6D80 Offset: 0x24C5780 VA: 0x1824C6D80 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C7020 Offset: 0x24C5A20 VA: 0x1824C7020 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24C7060 Offset: 0x24C5A60 VA: 0x1824C7060 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24C6EE0 Offset: 0x24C58E0 VA: 0x1824C6EE0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24C6D20 Offset: 0x24C5720 VA: 0x1824C6D20 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24C73A0 Offset: 0x24C5DA0 VA: 0x1824C73A0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24C6BA0 Offset: 0x24C55A0 VA: 0x1824C6BA0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24C6C20 Offset: 0x24C5620 VA: 0x1824C6C20 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x24C67E0 Offset: 0x24C51E0 VA: 0x1824C67E0 Slot: 28
	public override void Close() { }

	// RVA: 0x24C6A10 Offset: 0x24C5410 VA: 0x1824C6A10 Slot: 29
	public override void Flush() { }

	// RVA: 0x24C7410 Offset: 0x24C5E10 VA: 0x1824C7410 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x24C76C0 Offset: 0x24C60C0 VA: 0x1824C76C0 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x24C74B0 Offset: 0x24C5EB0 VA: 0x1824C74B0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x24C7500 Offset: 0x24C5F00 VA: 0x1824C7500 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x24C26B0 Offset: 0x24C10B0 VA: 0x1824C26B0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24C6EB0 Offset: 0x24C58B0 VA: 0x1824C6EB0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C6F40 Offset: 0x24C5940 VA: 0x1824C6F40 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C6F70 Offset: 0x24C5970 VA: 0x1824C6F70 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x24C32B0 Offset: 0x24C1CB0 VA: 0x1824C32B0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x24C72C0 Offset: 0x24C5CC0 VA: 0x1824C72C0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x24C2930 Offset: 0x24C1330 VA: 0x1824C2930 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x24C6A60 Offset: 0x24C5460 VA: 0x1824C6A60
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x24C6A00 Offset: 0x24C5400 VA: 0x1824C6A00
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x24C6B40 Offset: 0x24C5540 VA: 0x1824C6B40
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x24C6830 Offset: 0x24C5230 VA: 0x1824C6830
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }
}
