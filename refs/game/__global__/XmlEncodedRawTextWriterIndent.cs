internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 7958
{
	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x24C8450 Offset: 0x24C6E50 VA: 0x1824C8450
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x24C8480 Offset: 0x24C6E80 VA: 0x1824C8480
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x24C7B80 Offset: 0x24C6580 VA: 0x1824C7B80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24C8210 Offset: 0x24C6C10 VA: 0x1824C8210 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C7950 Offset: 0x24C6350 VA: 0x1824C7950 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xC15350 Offset: 0xC13D50 VA: 0x180C15350 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x24C7BF0 Offset: 0x24C65F0 VA: 0x1824C7BF0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C7D60 Offset: 0x24C6760 VA: 0x1824C7D60 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C80C0 Offset: 0x24C6AC0 VA: 0x1824C80C0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24C7A80 Offset: 0x24C6480 VA: 0x1824C7A80 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24C7B40 Offset: 0x24C6540 VA: 0x1824C7B40 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24C7F70 Offset: 0x24C6970 VA: 0x1824C7F70 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x24C7C80 Offset: 0x24C6680 VA: 0x1824C7C80 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24C7A90 Offset: 0x24C6490 VA: 0x1824C7A90 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24C83C0 Offset: 0x24C6DC0 VA: 0x1824C83C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24C83D0 Offset: 0x24C6DD0 VA: 0x1824C83D0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24C8340 Offset: 0x24C6D40 VA: 0x1824C8340 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24C7AA0 Offset: 0x24C64A0 VA: 0x1824C7AA0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C7FC0 Offset: 0x24C69C0 VA: 0x1824C7FC0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24C8050 Offset: 0x24C6A50 VA: 0x1824C8050 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24C79C0 Offset: 0x24C63C0 VA: 0x1824C79C0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24C7820 Offset: 0x24C6220 VA: 0x1824C7820
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x24C7ED0 Offset: 0x24C68D0 VA: 0x1824C7ED0
	private void WriteIndent() { }
}
