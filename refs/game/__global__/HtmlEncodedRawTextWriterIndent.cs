internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 7917
{
	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x23B0410 Offset: 0x23AEE10 VA: 0x1823B0410
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x23B03A0 Offset: 0x23AEDA0 VA: 0x1823B03A0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x23AFE80 Offset: 0x23AE880 VA: 0x1823AFE80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x23B01B0 Offset: 0x23AEBB0 VA: 0x1823B01B0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x23AFDB0 Offset: 0x23AE7B0 VA: 0x1823AFDB0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x23AFEB0 Offset: 0x23AE8B0 VA: 0x1823AFEB0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x23B00F0 Offset: 0x23AEAF0 VA: 0x1823B00F0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x23AFD30 Offset: 0x23AE730 VA: 0x1823AFD30 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x23AFD50 Offset: 0x23AE750 VA: 0x1823AFD50
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x23B0090 Offset: 0x23AEA90 VA: 0x1823B0090
	private void WriteIndent() { }
}
