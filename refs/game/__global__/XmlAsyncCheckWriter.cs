internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 7955
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x24C6710 Offset: 0x24C5110 VA: 0x1824C6710
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x24C5CE0 Offset: 0x24C46E0 VA: 0x1824C5CE0
	private void CheckAsync() { }

	// RVA: 0x24C6510 Offset: 0x24C4F10 VA: 0x1824C6510 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x24C64C0 Offset: 0x24C4EC0 VA: 0x1824C64C0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x24C61C0 Offset: 0x24C4BC0 VA: 0x1824C61C0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x24C6110 Offset: 0x24C4B10 VA: 0x1824C6110 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24C6550 Offset: 0x24C4F50 VA: 0x1824C6550 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x24C6200 Offset: 0x24C4C00 VA: 0x1824C6200 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x24C6290 Offset: 0x24C4C90 VA: 0x1824C6290 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x24C6450 Offset: 0x24C4E50 VA: 0x1824C6450 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24C6180 Offset: 0x24C4B80 VA: 0x1824C6180 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x24C5FB0 Offset: 0x24C49B0 VA: 0x1824C5FB0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24C60C0 Offset: 0x24C4AC0 VA: 0x1824C60C0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x24C6330 Offset: 0x24C4D30 VA: 0x1824C6330 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x24C6240 Offset: 0x24C4C40 VA: 0x1824C6240 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x24C6000 Offset: 0x24C4A00 VA: 0x1824C6000 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24C66C0 Offset: 0x24C50C0 VA: 0x1824C66C0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24C65C0 Offset: 0x24C4FC0 VA: 0x1824C65C0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x24C6610 Offset: 0x24C5010 VA: 0x1824C6610 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24C6050 Offset: 0x24C4A50 VA: 0x1824C6050 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C6390 Offset: 0x24C4D90 VA: 0x1824C6390 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24C6400 Offset: 0x24C4E00 VA: 0x1824C6400 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x24C5ED0 Offset: 0x24C48D0 VA: 0x1824C5ED0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24C5F40 Offset: 0x24C4940 VA: 0x1824C5F40 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x24C67A0 Offset: 0x24C51A0 VA: 0x1824C67A0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x24C5D70 Offset: 0x24C4770 VA: 0x1824C5D70 Slot: 28
	public override void Close() { }

	// RVA: 0x24C5DE0 Offset: 0x24C47E0 VA: 0x1824C5DE0 Slot: 29
	public override void Flush() { }

	// RVA: 0x24C5E20 Offset: 0x24C4820 VA: 0x1824C5E20 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x24C6670 Offset: 0x24C5070 VA: 0x1824C6670 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x24C5E70 Offset: 0x24C4870 VA: 0x1824C5E70 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x24C62D0 Offset: 0x24C4CD0 VA: 0x1824C62D0 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x24C5DB0 Offset: 0x24C47B0 VA: 0x1824C5DB0 Slot: 34
	protected override void Dispose(bool disposing) { }
}
