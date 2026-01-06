internal class CultureData // TypeDefIndex: 4845
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal int IDEFAULTANSICODEPAGE { get; }
	internal bool IsRightToLeft { get; }
	internal string SLIST { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x1BD99F0 Offset: 0x1BD83F0 VA: 0x181BD99F0
	private void .ctor(string name) { }

	// RVA: 0x1BD9CB0 Offset: 0x1BD86B0 VA: 0x181BD9CB0
	public static CultureData get_Invariant() { }

	// RVA: 0x1BD8DA0 Offset: 0x1BD77A0 VA: 0x181BD8DA0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x1BD8C80 Offset: 0x1BD7680 VA: 0x181BD8C80
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x1BD9AE0 Offset: 0x1BD84E0 VA: 0x181BD9AE0
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x1BD8B40 Offset: 0x1BD7540 VA: 0x181BD8B40
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x11E0D60 Offset: 0x11DF760 VA: 0x1811E0D60
	internal string[] get_LongTimes() { }

	// RVA: 0x1BDA0F0 Offset: 0x1BD8AF0 VA: 0x181BDA0F0
	internal string[] get_ShortTimes() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal string get_SAM1159() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal string get_SPM2359() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal string get_TimeSeparator() { }

	// RVA: 0x1BD9B00 Offset: 0x1BD8500 VA: 0x181BD9B00
	internal int[] get_CalendarIds() { }

	// RVA: 0x1BD88A0 Offset: 0x1BD72A0 VA: 0x181BD88A0
	internal CalendarId[] GetCalendarIds() { }

	// RVA: 0x1BDA0B0 Offset: 0x1BD8AB0 VA: 0x181BDA0B0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal string get_CultureName() { }

	// RVA: 0x1BDA0C0 Offset: 0x1BD8AC0 VA: 0x181BDA0C0
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal string get_STEXTINFO() { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	internal int get_IDEFAULTANSICODEPAGE() { }

	// RVA: 0x83DBA0 Offset: 0x83C5A0 VA: 0x18083DBA0
	internal bool get_IsRightToLeft() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	internal string get_SLIST() { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	internal bool get_UseUserOverride() { }

	// RVA: 0x1BD8860 Offset: 0x1BD7260 VA: 0x181BD8860
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x1BD86C0 Offset: 0x1BD70C0 VA: 0x181BD86C0
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x1BD8700 Offset: 0x1BD7100 VA: 0x181BD8700
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x1BD9810 Offset: 0x1BD8210 VA: 0x181BD9810
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x1BD97B0 Offset: 0x1BD81B0 VA: 0x181BD97B0
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x1BD99D0 Offset: 0x1BD83D0 VA: 0x181BD99D0
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x1BD8840 Offset: 0x1BD7240 VA: 0x181BD8840
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x1BD86E0 Offset: 0x1BD70E0 VA: 0x181BD86E0
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x1BD97F0 Offset: 0x1BD81F0 VA: 0x181BD97F0
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x1BD8880 Offset: 0x1BD7280 VA: 0x181BD8880
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x1BD8750 Offset: 0x1BD7150 VA: 0x181BD8750
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x1BD8720 Offset: 0x1BD7120 VA: 0x181BD8720
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x1BD9780 Offset: 0x1BD8180 VA: 0x181BD9780
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x1BD97D0 Offset: 0x1BD81D0 VA: 0x181BD97D0
	internal string MonthDay(int calendarId) { }

	// RVA: 0x1BD8770 Offset: 0x1BD7170 VA: 0x181BD8770
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x1BD8E20 Offset: 0x1BD7820 VA: 0x181BD8E20
	private static string GetDateSeparator(string format) { }

	// RVA: 0x1BD9490 Offset: 0x1BD7E90 VA: 0x181BD9490
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x1BD9690 Offset: 0x1BD8090 VA: 0x181BD9690
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x1BD9830 Offset: 0x1BD8230 VA: 0x181BD9830
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x1BDA170 Offset: 0x1BD8B70 VA: 0x181BDA170
	private static int strlen(byte* s) { }

	// RVA: 0x1BDA110 Offset: 0x1BD8B10 VA: 0x181BDA110
	private static string idx2string(byte* data, int idx) { }

	// RVA: 0x1BD9A30 Offset: 0x1BD8430 VA: 0x181BD9A30
	private int[] create_group_sizes_array(int gs0, int gs1) { }

	// RVA: 0x1BD8E60 Offset: 0x1BD7860 VA: 0x181BD8E60
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x1BD9AF0 Offset: 0x1BD84F0 VA: 0x181BD9AF0
	private static byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe) { }
}
