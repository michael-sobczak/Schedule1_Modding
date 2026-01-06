internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 8506
{
	// Methods

	// RVA: 0x2478E20 Offset: 0x2477820 VA: 0x182478E20
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x24786D0 Offset: 0x24770D0 VA: 0x1824786D0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x2478760 Offset: 0x2477160 VA: 0x182478760 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2477040 Offset: 0x2475A40 VA: 0x182477040 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24776A0 Offset: 0x24760A0 VA: 0x1824776A0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2476D70 Offset: 0x2475770 VA: 0x182476D70
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2476EC0 Offset: 0x24758C0 VA: 0x182476EC0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
