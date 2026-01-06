internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 8505
{
	// Methods

	// RVA: 0x2472620 Offset: 0x2471020 VA: 0x182472620
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x2471E80 Offset: 0x2470880 VA: 0x182471E80
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x2472220 Offset: 0x2470C20 VA: 0x182472220 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x2471F10 Offset: 0x2470910 VA: 0x182471F10 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x24725D0 Offset: 0x2470FD0 VA: 0x1824725D0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x24722C0 Offset: 0x2470CC0 VA: 0x1824722C0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2471100 Offset: 0x246FB00 VA: 0x182471100 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x2471B10 Offset: 0x2470510 VA: 0x182471B10 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2471440 Offset: 0x246FE40 VA: 0x182471440 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
