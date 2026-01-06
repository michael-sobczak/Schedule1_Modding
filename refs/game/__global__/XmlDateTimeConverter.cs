internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 8504
{
	// Methods

	// RVA: 0x2474B80 Offset: 0x2473580 VA: 0x182474B80
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x24736F0 Offset: 0x24720F0 VA: 0x1824736F0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x2473DD0 Offset: 0x24727D0 VA: 0x182473DD0 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x2473E30 Offset: 0x2472830 VA: 0x182473E30 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x2474040 Offset: 0x2472A40 VA: 0x182474040 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x2473B70 Offset: 0x2472570 VA: 0x182473B70 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x2473BA0 Offset: 0x24725A0 VA: 0x182473BA0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x2473780 Offset: 0x2472180 VA: 0x182473780 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x2474610 Offset: 0x2473010 VA: 0x182474610 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x2474400 Offset: 0x2472E00 VA: 0x182474400 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x24747D0 Offset: 0x24731D0 VA: 0x1824747D0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2473330 Offset: 0x2471D30 VA: 0x182473330 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x2472680 Offset: 0x2471080 VA: 0x182472680 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2472A70 Offset: 0x2471470 VA: 0x182472A70 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
