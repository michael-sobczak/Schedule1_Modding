public class TaiwanCalendar : Calendar // TypeDefIndex: 4837
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1BED5C0 Offset: 0x1BEBFC0 VA: 0x181BED5C0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1BEDB80 Offset: 0x1BEC580 VA: 0x181BEDB80 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1BEDB30 Offset: 0x1BEC530 VA: 0x181BEDB30 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1BED9C0 Offset: 0x1BEC3C0 VA: 0x181BED9C0
	public void .ctor() { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1BEAF80 Offset: 0x1BE9980 VA: 0x181BEAF80 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1BEAFB0 Offset: 0x1BE99B0 VA: 0x181BEAFB0 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x1BEAF40 Offset: 0x1BE9940 VA: 0x181BEAF40 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1BEAF60 Offset: 0x1BE9960 VA: 0x181BEAF60 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1BEB6E0 Offset: 0x1BEA0E0 VA: 0x181BEB6E0 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1BEB6A0 Offset: 0x1BEA0A0 VA: 0x181BEB6A0 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1BEB6C0 Offset: 0x1BEA0C0 VA: 0x181BEB6C0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1BEB700 Offset: 0x1BEA100 VA: 0x181BEB700 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1BEB720 Offset: 0x1BEA120 VA: 0x181BEB720 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1BEB760 Offset: 0x1BEA160 VA: 0x181BEB760 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1BEBB10 Offset: 0x1BEA510 VA: 0x181BEBB10 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1BEBBD0 Offset: 0x1BEA5D0 VA: 0x181BEBBD0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1BEDBD0 Offset: 0x1BEC5D0 VA: 0x181BEDBD0 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1BED6B0 Offset: 0x1BEC0B0 VA: 0x181BED6B0 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1BED850 Offset: 0x1BEC250 VA: 0x181BED850
	private static void .cctor() { }
}
