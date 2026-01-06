internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 8502
{
	// Methods

	// RVA: 0x247D330 Offset: 0x247BD30 VA: 0x18247D330
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x247BBC0 Offset: 0x247A5C0 VA: 0x18247BBC0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x247C120 Offset: 0x247AB20 VA: 0x18247C120 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x247BC50 Offset: 0x247A650 VA: 0x18247BC50 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x247C210 Offset: 0x247AC10 VA: 0x18247C210 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x247C260 Offset: 0x247AC60 VA: 0x18247C260 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x247C380 Offset: 0x247AD80 VA: 0x18247C380 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x247CD40 Offset: 0x247B740 VA: 0x18247CD40 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x247C7E0 Offset: 0x247B1E0 VA: 0x18247C7E0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x247C900 Offset: 0x247B300 VA: 0x18247C900 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x247D250 Offset: 0x247BC50 VA: 0x18247D250 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x247D200 Offset: 0x247BC00 VA: 0x18247D200 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x247CD50 Offset: 0x247B750 VA: 0x18247CD50 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x247CDA0 Offset: 0x247B7A0 VA: 0x18247CDA0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x247B700 Offset: 0x247A100 VA: 0x18247B700 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x247B2C0 Offset: 0x2479CC0 VA: 0x18247B2C0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x247A9E0 Offset: 0x24793E0 VA: 0x18247A9E0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x247AE40 Offset: 0x2479840 VA: 0x18247AE40 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24797D0 Offset: 0x24781D0 VA: 0x1824797D0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2478E80 Offset: 0x2477880 VA: 0x182478E80
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2479300 Offset: 0x2477D00 VA: 0x182479300
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}
