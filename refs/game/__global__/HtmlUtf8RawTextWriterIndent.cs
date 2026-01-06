internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 7920
{
	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0x24C1860 Offset: 0x24C0260 VA: 0x1824C1860
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x24C1320 Offset: 0x24BFD20 VA: 0x1824C1320 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24C1540 Offset: 0x24BFF40 VA: 0x1824C1540 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C1260 Offset: 0x24BFC60 VA: 0x1824C1260 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24C1350 Offset: 0x24BFD50 VA: 0x1824C1350 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C1480 Offset: 0x24BFE80 VA: 0x1824C1480 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24C11E0 Offset: 0x24BFBE0 VA: 0x1824C11E0 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x24C1200 Offset: 0x24BFC00 VA: 0x1824C1200
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x24C1430 Offset: 0x24BFE30 VA: 0x1824C1430
	private void WriteIndent() { }
}
