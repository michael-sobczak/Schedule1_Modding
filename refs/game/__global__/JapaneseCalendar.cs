public class JapaneseCalendar : Calendar // TypeDefIndex: 4835
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1BEBB80 Offset: 0x1BEA580 VA: 0x181BEBB80 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1BEBB30 Offset: 0x1BEA530 VA: 0x181BEBB30 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1BEB0C0 Offset: 0x1BE9AC0 VA: 0x181BEB0C0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x1BEAFD0 Offset: 0x1BE99D0 VA: 0x181BEAFD0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1BEB9A0 Offset: 0x1BEA3A0 VA: 0x181BEB9A0
	public void .ctor() { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 7
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

	// RVA: 0x1BEB790 Offset: 0x1BEA190 VA: 0x181BEB790 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1BEBB10 Offset: 0x1BEA510 VA: 0x181BEBB10 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1BEAE50 Offset: 0x1BE9850 VA: 0x181BEAE50
	internal static string[] EraNames() { }

	// RVA: 0x1BEAD60 Offset: 0x1BE9760 VA: 0x181BEAD60
	internal static string[] EnglishEraNames() { }

	// RVA: 0x1BEB740 Offset: 0x1BEA140 VA: 0x181BEB740 Slot: 25
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x1BEBBD0 Offset: 0x1BEA5D0 VA: 0x181BEBBD0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1BEBC20 Offset: 0x1BEA620 VA: 0x181BEBC20 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1BEB930 Offset: 0x1BEA330 VA: 0x181BEB930
	private static void .cctor() { }
}
