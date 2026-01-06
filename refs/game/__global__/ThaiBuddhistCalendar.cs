public class ThaiBuddhistCalendar : Calendar // TypeDefIndex: 4839
{
	// Fields
	internal static EraInfo[] thaiBuddhistEraInfo; // 0x0
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

	// RVA: 0x1BF0650 Offset: 0x1BEF050 VA: 0x181BF0650 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1BF0600 Offset: 0x1BEF000 VA: 0x181BF0600 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1BF0550 Offset: 0x1BEEF50 VA: 0x181BF0550
	public void .ctor() { }

	// RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640 Slot: 7
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

	// RVA: 0x1BF06A0 Offset: 0x1BEF0A0 VA: 0x181BF06A0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1BF06F0 Offset: 0x1BEF0F0 VA: 0x181BF06F0 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1BF0370 Offset: 0x1BEED70 VA: 0x181BF0370 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1BF0430 Offset: 0x1BEEE30 VA: 0x181BF0430
	private static void .cctor() { }
}
