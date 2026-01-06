internal static class DateTimeUtils // TypeDefIndex: 11128
{
	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private const string IsoDateFormat = "yyyy-MM-ddTHH:mm:ss.FFFFFFFK";
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysPer4Years = 1461;
	private const int DaysPerYear = 365;
	private const long TicksPerDay = 864000000000;
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x1D65060 Offset: 0x1D63A60 VA: 0x181D65060
	private static void .cctor() { }

	[Extension]
	// RVA: 0x1D62190 Offset: 0x1D60B90 VA: 0x181D62190
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x1D62390 Offset: 0x1D60D90 VA: 0x181D62390
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x1D61CF0 Offset: 0x1D606F0 VA: 0x181D61CF0
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0x1D621F0 Offset: 0x1D60BF0 VA: 0x181D621F0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x1D622C0 Offset: 0x1D60CC0 VA: 0x181D622C0
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x1D625B0 Offset: 0x1D60FB0 VA: 0x181D625B0
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x1D62440 Offset: 0x1D60E40 VA: 0x181D62440
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1D61770 Offset: 0x1D60170 VA: 0x181D61770
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1D61830 Offset: 0x1D60230 VA: 0x181D61830
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x1D61880 Offset: 0x1D60280 VA: 0x181D61880
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x1D64090 Offset: 0x1D62A90 VA: 0x181D64090
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	// RVA: 0x1D61A70 Offset: 0x1D60470 VA: 0x181D61A70
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x1D627B0 Offset: 0x1D611B0 VA: 0x181D627B0
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x1D62E90 Offset: 0x1D61890 VA: 0x181D62E90
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x1D61BA0 Offset: 0x1D605A0 VA: 0x181D61BA0
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x1D637B0 Offset: 0x1D621B0 VA: 0x181D637B0
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1D639E0 Offset: 0x1D623E0 VA: 0x181D639E0
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1D632A0 Offset: 0x1D61CA0 VA: 0x181D632A0
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1D634C0 Offset: 0x1D61EC0 VA: 0x181D634C0
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1D63CB0 Offset: 0x1D626B0 VA: 0x181D63CB0
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x1D62C80 Offset: 0x1D61680 VA: 0x181D62C80
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x1D626C0 Offset: 0x1D610C0 VA: 0x181D626C0
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x1D63120 Offset: 0x1D61B20 VA: 0x181D63120
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x1D62DE0 Offset: 0x1D617E0 VA: 0x181D62DE0
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x1D63E40 Offset: 0x1D62840 VA: 0x181D63E40
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x1D64550 Offset: 0x1D62F50 VA: 0x181D64550
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1D64700 Offset: 0x1D63100 VA: 0x181D64700
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x1D64AF0 Offset: 0x1D634F0 VA: 0x181D64AF0
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x1D61AF0 Offset: 0x1D604F0 VA: 0x181D61AF0
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x1D642F0 Offset: 0x1D62CF0 VA: 0x181D642F0
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x1D64100 Offset: 0x1D62B00 VA: 0x181D64100
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1D61FA0 Offset: 0x1D609A0 VA: 0x181D61FA0
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }
}
