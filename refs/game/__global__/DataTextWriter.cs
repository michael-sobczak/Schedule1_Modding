internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 13004
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x20C7B70 Offset: 0x20C6570 VA: 0x1820C7B70
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x20C7F90 Offset: 0x20C6990 VA: 0x1820C7F90
	private void .ctor(XmlWriter w) { }

	// RVA: 0x20C7FD0 Offset: 0x20C69D0 VA: 0x1820C7FD0
	internal Stream get_BaseStream() { }

	// RVA: 0x1F80D90 Offset: 0x1F7F790 VA: 0x181F80D90 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x20C7EA0 Offset: 0x20C68A0 VA: 0x1820C7EA0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1C199B0 Offset: 0x1C183B0 VA: 0x181C199B0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x20C7D50 Offset: 0x20C6750 VA: 0x1820C7D50 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x20C7ED0 Offset: 0x20C68D0 VA: 0x1820C7ED0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19CA0 Offset: 0x1C186A0 VA: 0x181C19CA0 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x20C7DB0 Offset: 0x20C67B0 VA: 0x1820C7DB0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x20C7E70 Offset: 0x20C6870 VA: 0x1820C7E70 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C19C40 Offset: 0x1C18640 VA: 0x181C19C40 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x20C7C90 Offset: 0x20C6690 VA: 0x1820C7C90 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x20C7D20 Offset: 0x20C6720 VA: 0x1820C7D20 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x20C7DE0 Offset: 0x20C67E0 VA: 0x1820C7DE0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x20C7D80 Offset: 0x20C6780 VA: 0x1820C7D80 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x20C7CC0 Offset: 0x20C66C0 VA: 0x1820C7CC0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x20C7F60 Offset: 0x20C6960 VA: 0x1820C7F60 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x20C7F00 Offset: 0x20C6900 VA: 0x1820C7F00 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x20C7F30 Offset: 0x20C6930 VA: 0x1820C7F30 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x20C7CF0 Offset: 0x20C66F0 VA: 0x1820C7CF0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x20C7E10 Offset: 0x20C6810 VA: 0x1820C7E10 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x20C7E40 Offset: 0x20C6840 VA: 0x1820C7E40 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x20C7C30 Offset: 0x20C6630 VA: 0x1820C7C30 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x20C7C60 Offset: 0x20C6660 VA: 0x1820C7C60 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1B9C7F0 Offset: 0x1B9B1F0 VA: 0x181B9C7F0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1B9C940 Offset: 0x1B9B340 VA: 0x181B9C940 Slot: 28
	public override void Close() { }

	// RVA: 0x20C7BD0 Offset: 0x20C65D0 VA: 0x1820C7BD0 Slot: 29
	public override void Flush() { }

	// RVA: 0x20C7C00 Offset: 0x20C6600 VA: 0x1820C7C00 Slot: 30
	public override string LookupPrefix(string ns) { }
}
