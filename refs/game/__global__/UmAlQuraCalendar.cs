public class UmAlQuraCalendar : Calendar // TypeDefIndex: 4841
{
	// Fields
	private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo; // 0x0
	internal static DateTime minDate; // 0x8
	internal static DateTime maxDate; // 0x10

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1BF1840 Offset: 0x1BF0240 VA: 0x181BF1840
	private static UmAlQuraCalendar.DateMapping[] InitDateMapping() { }

	// RVA: 0x1BF22B0 Offset: 0x1BF0CB0 VA: 0x181BF22B0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1BF2260 Offset: 0x1BF0C60 VA: 0x181BF2260 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1BF21E0 Offset: 0x1BF0BE0 VA: 0x181BF21E0
	public void .ctor() { }

	// RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x1BF2250 Offset: 0x1BF0C50 VA: 0x181BF2250 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1BF1080 Offset: 0x1BEFA80 VA: 0x181BF1080
	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	// RVA: 0x1BF11F0 Offset: 0x1BEFBF0 VA: 0x181BF11F0
	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	// RVA: 0x1BF08D0 Offset: 0x1BEF2D0 VA: 0x181BF08D0
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x1BF0840 Offset: 0x1BEF240 VA: 0x181BF0840
	internal static void CheckEraRange(int era) { }

	// RVA: 0x1BF0BA0 Offset: 0x1BEF5A0 VA: 0x181BF0BA0
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x1BF0AD0 Offset: 0x1BEF4D0 VA: 0x181BF0AD0
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x1BF0D60 Offset: 0x1BEF760 VA: 0x181BF0D60
	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	// RVA: 0x1BF13B0 Offset: 0x1BEFDB0 VA: 0x181BF13B0 Slot: 31
	internal virtual int GetDatePart(DateTime time, int part) { }

	// RVA: 0x1BF1560 Offset: 0x1BEFF60 VA: 0x181BF1560 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1BF1580 Offset: 0x1BEFF80 VA: 0x181BF1580 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1BF1600 Offset: 0x1BF0000 VA: 0x181BF1600 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1BF1A40 Offset: 0x1BF0440 VA: 0x181BF1A40
	internal static int RealGetDaysInYear(int year) { }

	// RVA: 0x1BF16C0 Offset: 0x1BF00C0 VA: 0x181BF16C0 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x1BF1720 Offset: 0x1BF0120 VA: 0x181BF1720 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1BF21F0 Offset: 0x1BF0BF0 VA: 0x181BF21F0 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1BF17A0 Offset: 0x1BF01A0 VA: 0x181BF17A0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1BF17C0 Offset: 0x1BF01C0 VA: 0x181BF17C0 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1BF1820 Offset: 0x1BF0220 VA: 0x181BF1820 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1BF19D0 Offset: 0x1BF03D0 VA: 0x181BF19D0 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1BF1AE0 Offset: 0x1BF04E0 VA: 0x181BF1AE0 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1BF2300 Offset: 0x1BF0D00 VA: 0x181BF2300 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1BF2350 Offset: 0x1BF0D50 VA: 0x181BF2350 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1BF1D50 Offset: 0x1BF0750 VA: 0x181BF1D50 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1BF1EF0 Offset: 0x1BF08F0 VA: 0x181BF1EF0
	private static void .cctor() { }
}
