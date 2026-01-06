public class GregorianCalendar : Calendar // TypeDefIndex: 4830
{
	// Fields
	internal GregorianCalendarTypes m_type; // 0x20
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	[OnDeserialized]
	// RVA: 0x1BAC740 Offset: 0x1BAB140 VA: 0x181BAC740
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1BACEB0 Offset: 0x1BAB8B0 VA: 0x181BACEB0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1BACE60 Offset: 0x1BAB860 VA: 0x181BACE60 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1BAC1F0 Offset: 0x1BAABF0 VA: 0x181BAC1F0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1BACC80 Offset: 0x1BAB680 VA: 0x181BACC80
	public void .ctor() { }

	// RVA: 0x1BACCB0 Offset: 0x1BAB6B0 VA: 0x181BACCB0
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1BABA30 Offset: 0x1BAA430 VA: 0x181BABA30 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x1BAB840 Offset: 0x1BAA240 VA: 0x181BAB840
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x1BABC00 Offset: 0x1BAA600 VA: 0x181BABC00 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1BABC70 Offset: 0x1BAA670 VA: 0x181BABC70 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1BABCF0 Offset: 0x1BAA6F0 VA: 0x181BABCF0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1BAC010 Offset: 0x1BAAA10 VA: 0x181BAC010 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1BACE00 Offset: 0x1BAB800 VA: 0x181BACE00 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1BAC300 Offset: 0x1BAAD00 VA: 0x181BAC300 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1BAC370 Offset: 0x1BAAD70 VA: 0x181BAC370 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1BAC500 Offset: 0x1BAAF00 VA: 0x181BAC500 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1BAC570 Offset: 0x1BAAF70 VA: 0x181BAC570 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1BAC830 Offset: 0x1BAB230 VA: 0x181BAC830 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1BACA90 Offset: 0x1BAB490 VA: 0x181BACA90 Slot: 24
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x1BACF00 Offset: 0x1BAB900 VA: 0x181BACF00 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1BACF70 Offset: 0x1BAB970 VA: 0x181BACF70 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1BAC910 Offset: 0x1BAB310 VA: 0x181BAC910 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1BACB90 Offset: 0x1BAB590 VA: 0x181BACB90
	private static void .cctor() { }
}
