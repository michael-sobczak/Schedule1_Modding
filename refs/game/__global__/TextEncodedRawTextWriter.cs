internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 7945
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x24C3D30 Offset: 0x24C2730 VA: 0x1824C3D30
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x24C3D40 Offset: 0x24C2740 VA: 0x1824C3D40
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x24C3D20 Offset: 0x24C2720 VA: 0x1824C3D20 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x24C3CA0 Offset: 0x24C26A0 VA: 0x1824C3CA0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x24C3BA0 Offset: 0x24C25A0 VA: 0x1824C3BA0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x24C3CB0 Offset: 0x24C26B0 VA: 0x1824C3CB0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24C3CB0 Offset: 0x24C26B0 VA: 0x1824C3CB0 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x24C3C10 Offset: 0x24C2610 VA: 0x1824C3C10 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C3C10 Offset: 0x24C2610 VA: 0x1824C3C10 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x24C3CB0 Offset: 0x24C26B0 VA: 0x1824C3CB0 Slot: 24
	public override void WriteRaw(string data) { }
}
