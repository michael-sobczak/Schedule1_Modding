internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 8508
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x2486F10 Offset: 0x2485910 VA: 0x182486F10
	protected void .ctor() { }

	// RVA: 0x2486E10 Offset: 0x2485810 VA: 0x182486E10
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x24847F0 Offset: 0x24831F0 VA: 0x1824847F0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x2484600 Offset: 0x2483000 VA: 0x182484600 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x2484B50 Offset: 0x2483550 VA: 0x182484B50 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x2484BF0 Offset: 0x24835F0 VA: 0x182484BF0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x2484A90 Offset: 0x2483490 VA: 0x182484A90 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x2484890 Offset: 0x2483290 VA: 0x182484890 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x2484DD0 Offset: 0x24837D0 VA: 0x182484DD0 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x2484E90 Offset: 0x2483890 VA: 0x182484E90 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x2485290 Offset: 0x2483C90 VA: 0x182485290 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x24850A0 Offset: 0x2483AA0 VA: 0x1824850A0 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x2485330 Offset: 0x2483D30 VA: 0x182485330 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x24853D0 Offset: 0x2483DD0 VA: 0x1824853D0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x24857B0 Offset: 0x24841B0 VA: 0x1824857B0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x24855C0 Offset: 0x2483FC0 VA: 0x1824855C0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x2485A40 Offset: 0x2484440 VA: 0x182485A40 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x2485850 Offset: 0x2484250 VA: 0x182485850 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x2486A40 Offset: 0x2485440 VA: 0x182486A40 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x2486BD0 Offset: 0x24855D0 VA: 0x182486BD0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x2486C20 Offset: 0x2485620 VA: 0x182486C20 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x2485AE0 Offset: 0x24844E0 VA: 0x182485AE0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x2486A90 Offset: 0x2485490 VA: 0x182486A90 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x2486B80 Offset: 0x2485580 VA: 0x182486B80 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x2486B30 Offset: 0x2485530 VA: 0x182486B30 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x2486AE0 Offset: 0x24854E0 VA: 0x182486AE0 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x2485B40 Offset: 0x2484540 VA: 0x182485B40 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2480FB0 Offset: 0x247F9B0 VA: 0x182480FB0 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x2481FC0 Offset: 0x24809C0 VA: 0x182481FC0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x2482390 Offset: 0x2480D90 VA: 0x182482390 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x2480DC0 Offset: 0x247F7C0 VA: 0x182480DC0 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x24821A0 Offset: 0x2480BA0 VA: 0x1824821A0 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x2480BD0 Offset: 0x247F5D0 VA: 0x182480BD0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x24811A0 Offset: 0x247FBA0 VA: 0x1824811A0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2482590 Offset: 0x2480F90 VA: 0x182482590 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24808F0 Offset: 0x247F2F0 VA: 0x1824808F0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2480A40 Offset: 0x247F440 VA: 0x182480A40
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2480580 Offset: 0x247EF80 VA: 0x182480580 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2483FA0 Offset: 0x24829A0 VA: 0x182483FA0
	private bool SupportsType(Type clrType) { }

	// RVA: 0x2486C80 Offset: 0x2485680 VA: 0x182486C80
	private static void .cctor() { }
}
