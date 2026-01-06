public class XmlValidatingReader : XmlReader // TypeDefIndex: 7994
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0x20C7AE0 Offset: 0x20C64E0 VA: 0x1820C7AE0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1DEB9A0 Offset: 0x1DEA3A0 VA: 0x181DEB9A0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1B56580 Offset: 0x1B54F80 VA: 0x181B56580 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1B56670 Offset: 0x1B55070 VA: 0x181B56670 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1B56640 Offset: 0x1B55040 VA: 0x181B56640 Slot: 11
	public override string get_Value() { }

	// RVA: 0x20C7A50 Offset: 0x20C6450 VA: 0x1820C7A50 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x20C7A20 Offset: 0x20C6420 VA: 0x1820C7A20 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x46FFD0 Offset: 0x46E9D0 VA: 0x18046FFD0 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x20C79F0 Offset: 0x20C63F0 VA: 0x1820C79F0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x456EA0 Offset: 0x4558A0 VA: 0x180456EA0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x20C7830 Offset: 0x20C6230 VA: 0x1820C7830 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x20C7860 Offset: 0x20C6260 VA: 0x1820C7860 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xFDBC40 Offset: 0xFDA640 VA: 0x180FDBC40 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x20C78F0 Offset: 0x20C62F0 VA: 0x1820C78F0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1BFF110 Offset: 0x1BFDB10 VA: 0x181BFF110 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1BFF170 Offset: 0x1BFDB70 VA: 0x181BFF170 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x20C7920 Offset: 0x20C6320 VA: 0x1820C7920 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1ABB2C0 Offset: 0x1AB9CC0 VA: 0x181ABB2C0 Slot: 31
	public override bool Read() { }

	// RVA: 0x1DFDA80 Offset: 0x1DFC480 VA: 0x181DFDA80 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x20C7B10 Offset: 0x20C6510 VA: 0x1820C7B10 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x20C7A80 Offset: 0x20C6480 VA: 0x1820C7A80 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x24D3D00 Offset: 0x24D2700 VA: 0x1824D3D00 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1A67B80 Offset: 0x1A66580 VA: 0x181A67B80 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x24E0050 Offset: 0x24DEA50 VA: 0x1824E0050
	public bool get_Namespaces() { }
}
