internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 7993
{
	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x24DAF60 Offset: 0x24D9960 VA: 0x1824DAF60
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x24DA5E0 Offset: 0x24D8FE0 VA: 0x1824DA5E0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24DACA0 Offset: 0x24D96A0 VA: 0x1824DACA0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24DA4A0 Offset: 0x24D8EA0 VA: 0x1824DA4A0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xBBA7C0 Offset: 0xBB91C0 VA: 0x180BBA7C0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x24DA650 Offset: 0x24D9050 VA: 0x1824DA650 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24DA7A0 Offset: 0x24D91A0 VA: 0x1824DA7A0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x24DAB80 Offset: 0x24D9580 VA: 0x1824DAB80 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24DA530 Offset: 0x24D8F30 VA: 0x1824DA530 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24DA5A0 Offset: 0x24D8FA0 VA: 0x1824DA5A0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24DA990 Offset: 0x24D9390 VA: 0x1824DA990 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x24DA6E0 Offset: 0x24D90E0 VA: 0x1824DA6E0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24DA540 Offset: 0x24D8F40 VA: 0x1824DA540 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24DAE20 Offset: 0x24D9820 VA: 0x1824DAE20 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24DADB0 Offset: 0x24D97B0 VA: 0x1824DADB0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24DADB0 Offset: 0x24D97B0 VA: 0x1824DADB0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24DA550 Offset: 0x24D8F50 VA: 0x1824DA550 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24DAB30 Offset: 0x24D9530 VA: 0x1824DAB30 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24DAAD0 Offset: 0x24D94D0 VA: 0x1824DAAD0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24DA510 Offset: 0x24D8F10 VA: 0x1824DA510 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24DA380 Offset: 0x24D8D80 VA: 0x1824DA380
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x24DA8F0 Offset: 0x24D92F0 VA: 0x1824DA8F0
	private void WriteIndent() { }
}
