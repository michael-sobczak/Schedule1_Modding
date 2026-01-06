public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable // TypeDefIndex: 4799
{
	// Fields
	private static DateTimeFormatInfo s_invariantInfo; // 0x0
	private CultureData _cultureData; // 0x10
	private string _name; // 0x18
	private string _langName; // 0x20
	private CompareInfo _compareInfo; // 0x28
	private CultureInfo _cultureInfo; // 0x30
	private string amDesignator; // 0x38
	private string pmDesignator; // 0x40
	private string dateSeparator; // 0x48
	private string generalShortTimePattern; // 0x50
	private string generalLongTimePattern; // 0x58
	private string timeSeparator; // 0x60
	private string monthDayPattern; // 0x68
	private string dateTimeOffsetPattern; // 0x70
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	private const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	private const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	private Calendar calendar; // 0x78
	private int firstDayOfWeek; // 0x80
	private int calendarWeekRule; // 0x84
	private string fullDateTimePattern; // 0x88
	private string[] abbreviatedDayNames; // 0x90
	private string[] m_superShortDayNames; // 0x98
	private string[] dayNames; // 0xA0
	private string[] abbreviatedMonthNames; // 0xA8
	private string[] monthNames; // 0xB0
	private string[] genitiveMonthNames; // 0xB8
	private string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	private string[] leapYearMonthNames; // 0xC8
	private string longDatePattern; // 0xD0
	private string shortDatePattern; // 0xD8
	private string yearMonthPattern; // 0xE0
	private string longTimePattern; // 0xE8
	private string shortTimePattern; // 0xF0
	private string[] allYearMonthPatterns; // 0xF8
	private string[] allShortDatePatterns; // 0x100
	private string[] allLongDatePatterns; // 0x108
	private string[] allShortTimePatterns; // 0x110
	private string[] allLongTimePatterns; // 0x118
	private string[] m_eraNames; // 0x120
	private string[] m_abbrevEraNames; // 0x128
	private string[] m_abbrevEnglishEraNames; // 0x130
	private CalendarId[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool _isReadOnly; // 0x140
	private DateTimeFormatFlags formatFlags; // 0x144
	private static readonly char[] s_monthSpaces; // 0x8
	internal const string RoundtripFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.fffffffK";
	internal const string RoundtripDateTimeUnfixed = "yyyy\'-\'MM\'-\'ddTHH\':\'mm\':\'ss zzz";
	private string _fullTimeSpanPositivePattern; // 0x148
	private string _fullTimeSpanNegativePattern; // 0x150
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash; // 0x158
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string JapaneseEraStart = "元";
	internal const string LocalTimeMark = "T";
	internal const string GMTName = "GMT";
	internal const string ZuluName = "Z";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x18

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private CalendarId[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; }
	public string LongTimePattern { get; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; }
	public string ShortTimePattern { get; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x1BA7500 Offset: 0x1BA5F00 VA: 0x181BA7500
	private string get_CultureName() { }

	// RVA: 0x1BA7540 Offset: 0x1BA5F40 VA: 0x181BA7540
	private CultureInfo get_Culture() { }

	// RVA: 0x1BA8110 Offset: 0x1BA6B10 VA: 0x181BA8110
	private string get_LanguageName() { }

	// RVA: 0x1BA8950 Offset: 0x1BA7350 VA: 0x181BA8950
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x1BA88E0 Offset: 0x1BA72E0 VA: 0x181BA88E0
	private string[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	// RVA: 0x1BA8A70 Offset: 0x1BA7470 VA: 0x181BA8A70
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x1BA8A00 Offset: 0x1BA7400 VA: 0x181BA8A00
	private string[] internalGetDayOfWeekNamesCore() { }

	// RVA: 0x1BA89E0 Offset: 0x1BA73E0 VA: 0x181BA89E0
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x1BA8970 Offset: 0x1BA7370 VA: 0x181BA8970
	private string[] internalGetAbbreviatedMonthNamesCore() { }

	// RVA: 0x1BA8E40 Offset: 0x1BA7840 VA: 0x181BA8E40
	private string[] internalGetMonthNames() { }

	// RVA: 0x1BA8DD0 Offset: 0x1BA77D0 VA: 0x181BA8DD0
	private string[] internalGetMonthNamesCore() { }

	// RVA: 0x1BA6AC0 Offset: 0x1BA54C0 VA: 0x181BA6AC0
	public void .ctor() { }

	// RVA: 0x1BA6E30 Offset: 0x1BA5830 VA: 0x181BA6E30
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x1BA44A0 Offset: 0x1BA2EA0 VA: 0x181BA44A0
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	// RVA: 0x1BA7F70 Offset: 0x1BA6970 VA: 0x181BA7F70
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x1BA75E0 Offset: 0x1BA5FE0 VA: 0x181BA75E0
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x1BA3790 Offset: 0x1BA2190 VA: 0x181BA3790
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x1BA3700 Offset: 0x1BA2100 VA: 0x181BA3700 Slot: 4
	public object GetFormat(Type formatType) { }

	// RVA: 0x1BA1D30 Offset: 0x1BA0730 VA: 0x181BA1D30 Slot: 5
	public object Clone() { }

	// RVA: 0x1BA6EA0 Offset: 0x1BA58A0 VA: 0x181BA6EA0
	public string get_AMDesignator() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public Calendar get_Calendar() { }

	// RVA: 0x1BA8E60 Offset: 0x1BA7860 VA: 0x181BA8E60
	public void set_Calendar(Calendar value) { }

	// RVA: 0x1BA8410 Offset: 0x1BA6E10 VA: 0x181BA8410
	private CalendarId[] get_OptionalCalendars() { }

	// RVA: 0x1BA7A50 Offset: 0x1BA6450 VA: 0x181BA7A50
	internal string[] get_EraNames() { }

	// RVA: 0x1BA35C0 Offset: 0x1BA1FC0 VA: 0x181BA35C0
	public string GetEraName(int era) { }

	// RVA: 0x1BA6FF0 Offset: 0x1BA59F0 VA: 0x181BA6FF0
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x1BA2BD0 Offset: 0x1BA15D0 VA: 0x181BA2BD0
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x1BA6F70 Offset: 0x1BA5970 VA: 0x181BA6F70
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x1BA76F0 Offset: 0x1BA60F0 VA: 0x181BA76F0
	public string get_DateSeparator() { }

	// RVA: 0x1BA7AF0 Offset: 0x1BA64F0 VA: 0x181BA7AF0
	public string get_FullDateTimePattern() { }

	// RVA: 0x1BA8150 Offset: 0x1BA6B50 VA: 0x181BA8150
	public string get_LongDatePattern() { }

	// RVA: 0x1BA81B0 Offset: 0x1BA6BB0 VA: 0x181BA81B0
	public string get_LongTimePattern() { }

	// RVA: 0x1BA8240 Offset: 0x1BA6C40 VA: 0x181BA8240
	public string get_MonthDayPattern() { }

	// RVA: 0x1BA8460 Offset: 0x1BA6E60 VA: 0x181BA8460
	public string get_PMDesignator() { }

	// RVA: 0x1BA84A0 Offset: 0x1BA6EA0 VA: 0x181BA84A0
	public string get_RFC1123Pattern() { }

	// RVA: 0x1BA84D0 Offset: 0x1BA6ED0 VA: 0x181BA84D0
	public string get_ShortDatePattern() { }

	// RVA: 0x1BA8530 Offset: 0x1BA6F30 VA: 0x181BA8530
	public string get_ShortTimePattern() { }

	// RVA: 0x1BA85C0 Offset: 0x1BA6FC0 VA: 0x181BA85C0
	public string get_SortableDateTimePattern() { }

	// RVA: 0x1BA7DE0 Offset: 0x1BA67E0 VA: 0x181BA7DE0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x1BA7D20 Offset: 0x1BA6720 VA: 0x181BA7D20
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x1BA7760 Offset: 0x1BA6160 VA: 0x181BA7760
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x1BA85F0 Offset: 0x1BA6FF0 VA: 0x181BA85F0
	public string get_TimeSeparator() { }

	// RVA: 0x1BA8850 Offset: 0x1BA7250 VA: 0x181BA8850
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x1BA8880 Offset: 0x1BA7280 VA: 0x181BA8880
	public string get_YearMonthPattern() { }

	// RVA: 0x1BA6EE0 Offset: 0x1BA58E0 VA: 0x181BA6EE0
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x1BA79C0 Offset: 0x1BA63C0 VA: 0x181BA79C0
	public string[] get_DayNames() { }

	// RVA: 0x1BA7070 Offset: 0x1BA5A70 VA: 0x181BA7070
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x1BA8380 Offset: 0x1BA6D80 VA: 0x181BA8380
	public string[] get_MonthNames() { }

	// RVA: 0x1BA7F10 Offset: 0x1BA6910 VA: 0x181BA7F10
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x1BA7EE0 Offset: 0x1BA68E0 VA: 0x181BA7EE0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x1BA8C00 Offset: 0x1BA7600 VA: 0x181BA8C00
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x1BA8A90 Offset: 0x1BA7490 VA: 0x181BA8A90
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x1BA8B80 Offset: 0x1BA7580 VA: 0x181BA8B80
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x1BA2AC0 Offset: 0x1BA14C0 VA: 0x181BA2AC0
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x1BA3330 Offset: 0x1BA1D30 VA: 0x181BA3330
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x1BA2E60 Offset: 0x1BA1860 VA: 0x181BA2E60
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x1BA34B0 Offset: 0x1BA1EB0 VA: 0x181BA34B0
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x1BA2D40 Offset: 0x1BA1740 VA: 0x181BA2D40
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x1BA3CE0 Offset: 0x1BA26E0 VA: 0x181BA3CE0
	public string GetMonthName(int month) { }

	// RVA: 0x1BA3B10 Offset: 0x1BA2510 VA: 0x181BA3B10
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x1BA73C0 Offset: 0x1BA5DC0 VA: 0x181BA73C0
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x1BA7260 Offset: 0x1BA5C60 VA: 0x181BA7260
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x1BA7310 Offset: 0x1BA5D10 VA: 0x181BA7310
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x1BA7100 Offset: 0x1BA5B00 VA: 0x181BA7100
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x1BA71B0 Offset: 0x1BA5BB0 VA: 0x181BA71B0
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x1BA87D0 Offset: 0x1BA71D0 VA: 0x181BA87D0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x1BA8700 Offset: 0x1BA7100 VA: 0x181BA8700
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x1BA8630 Offset: 0x1BA7030 VA: 0x181BA8630
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x1BA8780 Offset: 0x1BA7180 VA: 0x181BA8780
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x1BA86B0 Offset: 0x1BA70B0 VA: 0x181BA86B0
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x1BA8080 Offset: 0x1BA6A80 VA: 0x181BA8080
	public bool get_IsReadOnly() { }

	// RVA: 0x1BA82B0 Offset: 0x1BA6CB0 VA: 0x181BA82B0
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x1BA7C30 Offset: 0x1BA6630 VA: 0x181BA7C30
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x1BA7BC0 Offset: 0x1BA65C0 VA: 0x181BA7BC0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x1BA7470 Offset: 0x1BA5E70 VA: 0x181BA7470
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x1BA67B0 Offset: 0x1BA51B0 VA: 0x181BA67B0
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x1BA7AD0 Offset: 0x1BA64D0 VA: 0x181BA7AD0
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x1BA3FB0 Offset: 0x1BA29B0 VA: 0x181BA3FB0
	private DateTimeFormatFlags InitializeFormatFlags() { }

	// RVA: 0x1BA7EA0 Offset: 0x1BA68A0 VA: 0x181BA7EA0
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x1BA7F40 Offset: 0x1BA6940 VA: 0x181BA7F40
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x1BA68E0 Offset: 0x1BA52E0 VA: 0x181BA68E0
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x1BA3960 Offset: 0x1BA2360 VA: 0x181BA3960
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x1BA3E00 Offset: 0x1BA2800 VA: 0x181BA3E00
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x1BA1CF0 Offset: 0x1BA06F0 VA: 0x181BA1CF0
	private void ClearTokenHashTable() { }

	// RVA: 0x1BA1FA0 Offset: 0x1BA09A0 VA: 0x181BA1FA0
	internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x1BA4F60 Offset: 0x1BA3960 VA: 0x181BA4F60
	private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	// RVA: 0x1BA4E30 Offset: 0x1BA3830 VA: 0x181BA4E30
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	// RVA: 0x1BA1C20 Offset: 0x1BA0620 VA: 0x181BA1C20
	private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x1BA65C0 Offset: 0x1BA4FC0 VA: 0x181BA65C0
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x1BA4E10 Offset: 0x1BA3810 VA: 0x181BA4E10
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x1BA4CF0 Offset: 0x1BA36F0 VA: 0x181BA4CF0
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	// RVA: 0x1BA5EE0 Offset: 0x1BA48E0 VA: 0x181BA5EE0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x1BA4660 Offset: 0x1BA3060 VA: 0x181BA4660
	private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x1BA48C0 Offset: 0x1BA32C0 VA: 0x181BA48C0
	private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x1BA1E80 Offset: 0x1BA0880 VA: 0x181BA1E80
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x1BA6A20 Offset: 0x1BA5420 VA: 0x181BA6A20
	private static void .cctor() { }
}
