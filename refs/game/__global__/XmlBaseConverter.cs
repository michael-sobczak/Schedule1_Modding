internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 8501
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x2454E50 Offset: 0x2453850 VA: 0x182454E50
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x2454D60 Offset: 0x2453760 VA: 0x182454D60
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x2455040 Offset: 0x2453A40 VA: 0x182455040
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x2454D00 Offset: 0x2453700 VA: 0x182454D00
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x2451A80 Offset: 0x2450480 VA: 0x182451A80 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x2451980 Offset: 0x2450380 VA: 0x182451980 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x24517C0 Offset: 0x24501C0 VA: 0x1824517C0 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x2451C40 Offset: 0x2450640 VA: 0x182451C40 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x24518B0 Offset: 0x24502B0 VA: 0x1824518B0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x2451B70 Offset: 0x2450570 VA: 0x182451B70 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x24523A0 Offset: 0x2450DA0 VA: 0x1824523A0 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x2452560 Offset: 0x2450F60 VA: 0x182452560 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x2451FF0 Offset: 0x24509F0 VA: 0x182451FF0 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x24522B0 Offset: 0x2450CB0 VA: 0x1824522B0 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x24520F0 Offset: 0x2450AF0 VA: 0x1824520F0 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x2452490 Offset: 0x2450E90 VA: 0x182452490 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x24521E0 Offset: 0x2450BE0 VA: 0x1824521E0 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x2451E10 Offset: 0x2450810 VA: 0x182451E10 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x2451D30 Offset: 0x2450730 VA: 0x182451D30 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x2451F10 Offset: 0x2450910 VA: 0x182451F10 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x2452730 Offset: 0x2451130 VA: 0x182452730 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x2452650 Offset: 0x2451050 VA: 0x182452650 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x24529D0 Offset: 0x24513D0 VA: 0x1824529D0 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x24528E0 Offset: 0x24512E0 VA: 0x1824528E0 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x2452B90 Offset: 0x2451590 VA: 0x182452B90 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x2452C80 Offset: 0x2451680 VA: 0x182452C80 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x2452AC0 Offset: 0x24514C0 VA: 0x182452AC0 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x2452810 Offset: 0x2451210 VA: 0x182452810 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x24531F0 Offset: 0x2451BF0 VA: 0x1824531F0 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x2452E40 Offset: 0x2451840 VA: 0x182452E40 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x24530F0 Offset: 0x2451AF0 VA: 0x1824530F0 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x2453000 Offset: 0x2451A00 VA: 0x182453000 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x2452D70 Offset: 0x2451770 VA: 0x182452D70 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x2452F30 Offset: 0x2451930 VA: 0x182452F30 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x2453760 Offset: 0x2452160 VA: 0x182453760 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x24533D0 Offset: 0x2451DD0 VA: 0x1824533D0 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x2453590 Offset: 0x2451F90 VA: 0x182453590 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x24532E0 Offset: 0x2451CE0 VA: 0x1824532E0 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x24534C0 Offset: 0x2451EC0 VA: 0x1824534C0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x2453690 Offset: 0x2452090 VA: 0x182453690 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x2453920 Offset: 0x2452320 VA: 0x182453920 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x2453850 Offset: 0x2452250 VA: 0x182453850 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x2453A20 Offset: 0x2452420 VA: 0x182453A20 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x2454210 Offset: 0x2452C10 VA: 0x182454210 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x2453E50 Offset: 0x2452850 VA: 0x182453E50 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x2453BD0 Offset: 0x24525D0 VA: 0x182453BD0 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x2453D70 Offset: 0x2452770 VA: 0x182453D70 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x2453F30 Offset: 0x2452930 VA: 0x182453F30 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x2453AF0 Offset: 0x24524F0 VA: 0x182453AF0 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x2454110 Offset: 0x2452B10 VA: 0x182454110 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x2454020 Offset: 0x2452A20 VA: 0x182454020 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x2453CB0 Offset: 0x24526B0 VA: 0x182453CB0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24541F0 Offset: 0x2452BF0 VA: 0x1824541F0 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x244EC00 Offset: 0x244D600 VA: 0x18244EC00 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x244ED80 Offset: 0x244D780 VA: 0x18244ED80 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x244EAF0 Offset: 0x244D4F0 VA: 0x18244EAF0 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x244ED00 Offset: 0x244D700 VA: 0x18244ED00 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x244EB80 Offset: 0x244D580 VA: 0x18244EB80 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x244EC80 Offset: 0x244D680 VA: 0x18244EC80 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x244EAD0 Offset: 0x244D4D0 VA: 0x18244EAD0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x244EAA0 Offset: 0x244D4A0 VA: 0x18244EAA0 Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x24550B0 Offset: 0x2453AB0 VA: 0x1824550B0
	protected string get_XmlTypeName() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	protected Type get_DefaultClrType() { }

	// RVA: 0x2450510 Offset: 0x244EF10 VA: 0x182450510
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x244EE00 Offset: 0x244D800 VA: 0x18244EE00
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x24505D0 Offset: 0x244EFD0 VA: 0x1824505D0
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x244EA40 Offset: 0x244D440 VA: 0x18244EA40 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24508D0 Offset: 0x244F2D0 VA: 0x1824508D0
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x2450AF0 Offset: 0x244F4F0 VA: 0x182450AF0
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x2450A70 Offset: 0x244F470 VA: 0x182450A70
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x2450B70 Offset: 0x244F570 VA: 0x182450B70
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x2450BE0 Offset: 0x244F5E0 VA: 0x182450BE0
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x2450CD0 Offset: 0x244F6D0 VA: 0x182450CD0
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x2450EF0 Offset: 0x244F8F0 VA: 0x182450EF0
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x2450DE0 Offset: 0x244F7E0 VA: 0x182450DE0
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x2451110 Offset: 0x244FB10 VA: 0x182451110
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x2451000 Offset: 0x244FA00 VA: 0x182451000
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x2450950 Offset: 0x244F350 VA: 0x182450950
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x24509E0 Offset: 0x244F3E0 VA: 0x1824509E0
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x2450C40 Offset: 0x244F640 VA: 0x182450C40
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x2450E60 Offset: 0x244F860 VA: 0x182450E60
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x2450D50 Offset: 0x244F750 VA: 0x182450D50
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x2451080 Offset: 0x244FA80 VA: 0x182451080
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x2450F70 Offset: 0x244F970 VA: 0x182450F70
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x2451190 Offset: 0x244FB90 VA: 0x182451190
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x2451260 Offset: 0x244FC60 VA: 0x182451260
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x24515D0 Offset: 0x244FFD0 VA: 0x1824515D0
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x2451540 Offset: 0x244FF40 VA: 0x182451540
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x2451650 Offset: 0x2450050 VA: 0x182451650
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x244E9D0 Offset: 0x244D3D0 VA: 0x18244E9D0
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x244E9F0 Offset: 0x244D3F0 VA: 0x18244E9F0
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x244F2E0 Offset: 0x244DCE0 VA: 0x18244F2E0
	protected static string DateToString(DateTime value) { }

	// RVA: 0x244F260 Offset: 0x244DC60 VA: 0x18244F260
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x244F360 Offset: 0x244DD60 VA: 0x18244F360
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x244F9B0 Offset: 0x244E3B0 VA: 0x18244F9B0
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x244FA90 Offset: 0x244E490 VA: 0x18244FA90
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x244FC90 Offset: 0x244E690 VA: 0x18244FC90
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x244FB90 Offset: 0x244E590 VA: 0x18244FB90
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x244FE90 Offset: 0x244E890 VA: 0x18244FE90
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x244FD90 Offset: 0x244E790 VA: 0x18244FD90
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x244F110 Offset: 0x244DB10 VA: 0x18244F110
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x244F1E0 Offset: 0x244DBE0 VA: 0x18244F1E0
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x244FA10 Offset: 0x244E410 VA: 0x18244FA10
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x244FC10 Offset: 0x244E610 VA: 0x18244FC10
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x244FB10 Offset: 0x244E510 VA: 0x18244FB10
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x244FE10 Offset: 0x244E810 VA: 0x18244FE10
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x244FD10 Offset: 0x244E710 VA: 0x18244FD10
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x24506F0 Offset: 0x244F0F0 VA: 0x1824506F0
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2451740 Offset: 0x2450140 VA: 0x182451740
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x24516C0 Offset: 0x24500C0 VA: 0x1824516C0
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x2454400 Offset: 0x2452E00 VA: 0x182454400
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x244F190 Offset: 0x244DB90 VA: 0x18244F190
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x244F3D0 Offset: 0x244DDD0 VA: 0x18244F3D0
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x244F5C0 Offset: 0x244DFC0 VA: 0x18244F5C0
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x244F7C0 Offset: 0x244E1C0 VA: 0x18244F7C0
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x244FF10 Offset: 0x244E910 VA: 0x18244FF10
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x2450010 Offset: 0x244EA10 VA: 0x182450010
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x2450110 Offset: 0x244EB10 VA: 0x182450110
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x2450210 Offset: 0x244EC10 VA: 0x182450210
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x2450310 Offset: 0x244ED10 VA: 0x182450310
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x2450410 Offset: 0x244EE10 VA: 0x182450410
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x2454380 Offset: 0x2452D80 VA: 0x182454380
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x24542F0 Offset: 0x2452CF0 VA: 0x1824542F0
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x2454470 Offset: 0x2452E70 VA: 0x182454470
	private static void .cctor() { }
}
