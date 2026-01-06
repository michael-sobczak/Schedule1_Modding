public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 13014
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x20E58F0 Offset: 0x20E42F0 VA: 0x1820E58F0
	private void .ctor(bool fNull) { }

	// RVA: 0x20E5880 Offset: 0x20E4280 VA: 0x1820E5880
	public void .ctor(DateTime value) { }

	// RVA: 0x20E5900 Offset: 0x20E4300 VA: 0x1820E5900
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x20E51D0 Offset: 0x20E3BD0 VA: 0x1820E51D0
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0x20E4FF0 Offset: 0x20E39F0 VA: 0x1820E4FF0
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0x20E4640 Offset: 0x20E3040 VA: 0x1820E4640
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0x20E4510 Offset: 0x20E2F10 VA: 0x1820E4510
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x20E5AF0 Offset: 0x20E44F0 VA: 0x1820E5AF0
	public DateTime get_Value() { }

	// RVA: 0x20E5A30 Offset: 0x20E4430 VA: 0x1820E5A30
	public int get_DayTicks() { }

	// RVA: 0x20E5A90 Offset: 0x20E4490 VA: 0x1820E5A90
	public int get_TimeTicks() { }

	// RVA: 0x20E5D70 Offset: 0x20E4770 VA: 0x1820E5D70
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x20E5100 Offset: 0x20E3B00 VA: 0x1820E5100 Slot: 3
	public override string ToString() { }

	// RVA: 0x20E5BA0 Offset: 0x20E45A0 VA: 0x1820E5BA0
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x20E5DF0 Offset: 0x20E47F0 VA: 0x1820E5DF0
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x20E5C80 Offset: 0x20E4680 VA: 0x1820E5C80
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x20E4AE0 Offset: 0x20E34E0 VA: 0x1820E4AE0
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x20E4960 Offset: 0x20E3360 VA: 0x1820E4960
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x20E3FC0 Offset: 0x20E29C0 VA: 0x1820E3FC0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x20E4100 Offset: 0x20E2B00 VA: 0x1820E4100
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x20E42D0 Offset: 0x20E2CD0 VA: 0x1820E42D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20E4850 Offset: 0x20E3250 VA: 0x1820E4850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x20E4C60 Offset: 0x20E3660 VA: 0x1820E4C60 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x20E4E90 Offset: 0x20E3890 VA: 0x1820E4E90 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x20E48F0 Offset: 0x20E32F0 VA: 0x1820E48F0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x20E5250 Offset: 0x20E3C50 VA: 0x1820E5250
	private static void .cctor() { }
}
