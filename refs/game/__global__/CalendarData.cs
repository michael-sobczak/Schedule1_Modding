internal class CalendarData // TypeDefIndex: 4829
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0
	private static string[] HEBREW_MONTH_NAMES; // 0x8
	private static string[] HEBREW_LEAP_MONTH_NAMES; // 0x10

	// Methods

	// RVA: 0x1B9F360 Offset: 0x1B9DD60 VA: 0x181B9F360
	private void .ctor() { }

	// RVA: 0x1B9DA80 Offset: 0x1B9C480 VA: 0x181B9DA80
	private static void .cctor() { }

	// RVA: 0x1B9EAE0 Offset: 0x1B9D4E0 VA: 0x181B9EAE0
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x1B9D540 Offset: 0x1B9BF40 VA: 0x181B9D540
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x1B9D0D0 Offset: 0x1B9BAD0 VA: 0x181B9D0D0
	private static string[] GetJapaneseEraNames() { }

	// RVA: 0x1B9CFE0 Offset: 0x1B9B9E0 VA: 0x181B9CFE0
	private static string[] GetJapaneseEnglishEraNames() { }

	// RVA: 0x1B9D1C0 Offset: 0x1B9BBC0 VA: 0x181B9D1C0
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x1B9CDF0 Offset: 0x1B9B7F0 VA: 0x181B9CDF0
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x1B9CC60 Offset: 0x1B9B660 VA: 0x181B9CC60
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x1B9F390 Offset: 0x1B9DD90 VA: 0x181B9F390
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x1B9F380 Offset: 0x1B9DD80 VA: 0x181B9F380
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}
