internal class DomNameTable // TypeDefIndex: 8032
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x24EDE20 Offset: 0x24EC820 VA: 0x1824EDE20
	public void .ctor(XmlDocument document) { }

	// RVA: 0x24EDB50 Offset: 0x24EC550 VA: 0x1824EDB50
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x24ED760 Offset: 0x24EC160 VA: 0x1824ED760
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x24EDCB0 Offset: 0x24EC6B0 VA: 0x1824EDCB0
	private void Grow() { }
}
