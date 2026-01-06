internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 8512
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x24802D0 Offset: 0x247ECD0 VA: 0x1824802D0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x2480270 Offset: 0x247EC70 VA: 0x182480270
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x247FDA0 Offset: 0x247E7A0 VA: 0x18247FDA0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
