public class HijriCalendar : Calendar // TypeDefIndex: 4834
{
	// Fields
	public static readonly int HijriEra; // 0x0
	internal static readonly int[] HijriMonthDays; // 0x8
	private int m_HijriAdvance; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10
	internal static readonly DateTime calendarMaxValue; // 0x18

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public int HijriAdjustment { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1BAF1C0 Offset: 0x1BADBC0 VA: 0x181BAF1C0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1BAF170 Offset: 0x1BADB70 VA: 0x181BAF170 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1BAF060 Offset: 0x1BADA60 VA: 0x181BAF060
	public void .ctor() { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1BAE0E0 Offset: 0x1BACAE0 VA: 0x181BAE0E0
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	// RVA: 0x1BAE020 Offset: 0x1BACA20 VA: 0x181BAE020
	private long DaysUpToHijriYear(int HijriYear) { }

	// RVA: 0x1BAF110 Offset: 0x1BADB10 VA: 0x181BAF110
	public int get_HijriAdjustment() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	private static int GetAdvanceHijriDate() { }

	// RVA: 0x1BADA60 Offset: 0x1BAC460 VA: 0x181BADA60
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x1BAD990 Offset: 0x1BAC390 VA: 0x181BAD990
	internal static void CheckEraRange(int era) { }

	// RVA: 0x1BADE30 Offset: 0x1BAC830 VA: 0x181BADE30
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x1BADC60 Offset: 0x1BAC660 VA: 0x181BADC60
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x1BAE1F0 Offset: 0x1BACBF0 VA: 0x181BAE1F0 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x1BAE490 Offset: 0x1BACE90 VA: 0x181BAE490 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1BAE500 Offset: 0x1BACF00 VA: 0x181BAE500 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1BAE580 Offset: 0x1BACF80 VA: 0x181BAE580 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1BAE7E0 Offset: 0x1BAD1E0 VA: 0x181BAE7E0 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x1BAE870 Offset: 0x1BAD270 VA: 0x181BAE870 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1BAF080 Offset: 0x1BADA80 VA: 0x181BAF080 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1BAE900 Offset: 0x1BAD300 VA: 0x181BAE900 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1BAE970 Offset: 0x1BAD370 VA: 0x181BAE970 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1BAE9D0 Offset: 0x1BAD3D0 VA: 0x181BAE9D0 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1BAEA40 Offset: 0x1BAD440 VA: 0x181BAEA40 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1BAEAC0 Offset: 0x1BAD4C0 VA: 0x181BAEAC0 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1BAF210 Offset: 0x1BADC10 VA: 0x181BAF210 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1BAF280 Offset: 0x1BADC80 VA: 0x181BAF280 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1BAED90 Offset: 0x1BAD790 VA: 0x181BAED90 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1BAEF30 Offset: 0x1BAD930 VA: 0x181BAEF30
	private static void .cctor() { }
}
