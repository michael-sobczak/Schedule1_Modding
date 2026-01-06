internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 7963
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x24CEAD0 Offset: 0x24CD4D0 VA: 0x1824CEAD0 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x24CEB30 Offset: 0x24CD530 VA: 0x1824CEB30 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x24CE8F0 Offset: 0x24CD2F0 VA: 0x1824CE8F0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x24CE950 Offset: 0x24CD350 VA: 0x1824CE950 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x24CE9F0 Offset: 0x24CD3F0 VA: 0x1824CE9F0 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x24CE780 Offset: 0x24CD180 VA: 0x1824CE780 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x24CE6C0 Offset: 0x24CD0C0 VA: 0x1824CE6C0 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x24CEC80 Offset: 0x24CD680 VA: 0x1824CEC80 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x24CE840 Offset: 0x24CD240 VA: 0x1824CE840 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x24CEBD0 Offset: 0x24CD5D0 VA: 0x1824CEBD0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x24C6D80 Offset: 0x24C5780 VA: 0x1824C6D80 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x24C6D80 Offset: 0x24C5780 VA: 0x1824C6D80 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x24CE720 Offset: 0x24CD120 VA: 0x1824CE720 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x24CEA70 Offset: 0x24CD470 VA: 0x1824CEA70 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 35
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 36
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 37
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract void StartElementContent();

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 39
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0x24CEA50 Offset: 0x24CD450 VA: 0x1824CEA50 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x24CEB90 Offset: 0x24CD590 VA: 0x1824CEB90 Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x24CE9B0 Offset: 0x24CD3B0 VA: 0x1824CE9B0 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x24CE8D0 Offset: 0x24CD2D0 VA: 0x1824CE8D0 Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0x24CE6A0 Offset: 0x24CD0A0 VA: 0x1824CE6A0 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }
}
