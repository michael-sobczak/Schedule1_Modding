internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 8503
{
	// Methods

	// RVA: 0x247F210 Offset: 0x247DC10 VA: 0x18247F210
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x247E360 Offset: 0x247CD60 VA: 0x18247E360
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x247E790 Offset: 0x247D190 VA: 0x18247E790 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x247E3F0 Offset: 0x247CDF0 VA: 0x18247E3F0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x475560 Offset: 0x473F60 VA: 0x180475560 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x247E860 Offset: 0x247D260 VA: 0x18247E860 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x247E930 Offset: 0x247D330 VA: 0x18247E930 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x247ED30 Offset: 0x247D730 VA: 0x18247ED30 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x247F180 Offset: 0x247DB80 VA: 0x18247F180 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x247EDE0 Offset: 0x247D7E0 VA: 0x18247EDE0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x247DFC0 Offset: 0x247C9C0 VA: 0x18247DFC0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x247D390 Offset: 0x247BD90 VA: 0x18247D390 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x247D780 Offset: 0x247C180 VA: 0x18247D780 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
