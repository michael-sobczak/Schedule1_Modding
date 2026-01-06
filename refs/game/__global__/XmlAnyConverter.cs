internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 8509
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x2470B50 Offset: 0x246F550 VA: 0x182470B50
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x246F950 Offset: 0x246E350 VA: 0x18246F950 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x246FD80 Offset: 0x246E780 VA: 0x18246FD80 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x246FB30 Offset: 0x246E530 VA: 0x18246FB30 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x246FF60 Offset: 0x246E960 VA: 0x18246FF60 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x24701B0 Offset: 0x246EBB0 VA: 0x1824701B0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x2470390 Offset: 0x246ED90 VA: 0x182470390 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x2470570 Offset: 0x246EF70 VA: 0x182470570 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x24707F0 Offset: 0x246F1F0 VA: 0x1824707F0 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x246D570 Offset: 0x246BF70 VA: 0x18246D570 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x246D770 Offset: 0x246C170 VA: 0x18246D770 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x246CF30 Offset: 0x246B930 VA: 0x18246CF30 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x246F750 Offset: 0x246E150 VA: 0x18246F750 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x246D970 Offset: 0x246C370 VA: 0x18246D970 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x246D140 Offset: 0x246BB40 VA: 0x18246D140 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x246D340 Offset: 0x246BD40 VA: 0x18246D340 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x246DB70 Offset: 0x246C570 VA: 0x18246DB70 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x246CC60 Offset: 0x246B660 VA: 0x18246CC60
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x246CDB0 Offset: 0x246B7B0 VA: 0x18246CDB0
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2470750 Offset: 0x246F150 VA: 0x182470750
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x2470A30 Offset: 0x246F430 VA: 0x182470A30
	private static void .cctor() { }
}
