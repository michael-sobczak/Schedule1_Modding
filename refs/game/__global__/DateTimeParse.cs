internal static class DateTimeParse // TypeDefIndex: 3640
{
	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x1C54020 Offset: 0x1C52A20 VA: 0x181C54020
	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x1C53DD0 Offset: 0x1C527D0 VA: 0x181C53DD0
	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x1C56BB0 Offset: 0x1C555B0 VA: 0x181C56BB0
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x1C56DB0 Offset: 0x1C557B0 VA: 0x181C56DB0
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x1C56AB0 Offset: 0x1C554B0 VA: 0x181C56AB0
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x1C53CA0 Offset: 0x1C526A0 VA: 0x181C53CA0
	internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x1C56550 Offset: 0x1C54F50 VA: 0x181C56550
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x1C566F0 Offset: 0x1C550F0 VA: 0x181C566F0
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x1C51F70 Offset: 0x1C50970 VA: 0x181C51F70
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x1C4FCE0 Offset: 0x1C4E6E0 VA: 0x181C4FCE0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x1C502A0 Offset: 0x1C4ECA0 VA: 0x181C502A0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x1C54380 Offset: 0x1C52D80 VA: 0x181C54380
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x1C55050 Offset: 0x1C53A50 VA: 0x181C55050
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x1C50110 Offset: 0x1C4EB10 VA: 0x181C50110
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x1C502B0 Offset: 0x1C4ECB0 VA: 0x181C502B0
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x1C4F840 Offset: 0x1C4E240 VA: 0x181C4F840
	private static Calendar GetJapaneseCalendarDefaultInstance() { }

	// RVA: 0x1C4FAC0 Offset: 0x1C4E4C0 VA: 0x181C4FAC0
	internal static Calendar GetTaiwanCalendarDefaultInstance() { }

	// RVA: 0x1C57CD0 Offset: 0x1C566D0 VA: 0x181C57CD0
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x1C4FD90 Offset: 0x1C4E790 VA: 0x181C4FD90
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x1C4FFC0 Offset: 0x1C4E9C0 VA: 0x181C4FFC0
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x1C4F930 Offset: 0x1C4E330 VA: 0x181C4F930
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x1C564F0 Offset: 0x1C54EF0 VA: 0x181C564F0
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x1C56460 Offset: 0x1C54E60 VA: 0x181C56460
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x1C56360 Offset: 0x1C54D60 VA: 0x181C56360
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x1C562E0 Offset: 0x1C54CE0 VA: 0x181C562E0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x1C563E0 Offset: 0x1C54DE0 VA: 0x181C563E0
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x1C4F640 Offset: 0x1C4E040 VA: 0x181C4F640
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1C4F150 Offset: 0x1C4DB50 VA: 0x181C4F150
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4ECA0 Offset: 0x1C4D6A0 VA: 0x181C4ECA0
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4E820 Offset: 0x1C4D220 VA: 0x181C4E820
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4F6E0 Offset: 0x1C4E0E0 VA: 0x181C4F6E0
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4EA60 Offset: 0x1C4D460 VA: 0x181C4EA60
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4E530 Offset: 0x1C4CF30 VA: 0x181C4E530
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4F440 Offset: 0x1C4DE40 VA: 0x181C4F440
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4EFE0 Offset: 0x1C4D9E0 VA: 0x181C4EFE0
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C4F2D0 Offset: 0x1C4DCD0 VA: 0x181C4F2D0
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4F590 Offset: 0x1C4DF90 VA: 0x181C4F590
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4F390 Offset: 0x1C4DD90 VA: 0x181C4F390
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4C240 Offset: 0x1C4AC40 VA: 0x181C4C240
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4C200 Offset: 0x1C4AC00 VA: 0x181C4C200
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x1C4FC90 Offset: 0x1C4E690 VA: 0x181C4FC90
	private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4FC30 Offset: 0x1C4E630 VA: 0x181C4FC30
	private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4FBB0 Offset: 0x1C4E5B0 VA: 0x181C4FBB0
	private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4DEC0 Offset: 0x1C4C8C0 VA: 0x181C4DEC0
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4DF00 Offset: 0x1C4C900 VA: 0x181C4DF00
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1C4DFA0 Offset: 0x1C4C9A0 VA: 0x181C4DFA0
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C55660 Offset: 0x1C54060 VA: 0x181C55660
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x1C55720 Offset: 0x1C54120 VA: 0x181C55720
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C55C70 Offset: 0x1C54670 VA: 0x181C55C70
	internal static bool ProcessTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C55540 Offset: 0x1C53F40 VA: 0x181C55540
	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x1C55400 Offset: 0x1C53E00 VA: 0x181C55400
	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x1C572B0 Offset: 0x1C55CB0 VA: 0x181C572B0
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x1C57120 Offset: 0x1C55B20 VA: 0x181C57120
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x1C573E0 Offset: 0x1C55DE0 VA: 0x181C573E0
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1C4CC90 Offset: 0x1C4B690 VA: 0x181C4CC90
	private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x1C4CA00 Offset: 0x1C4B400 VA: 0x181C4CA00
	private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x1C4C5E0 Offset: 0x1C4AFE0 VA: 0x181C4C5E0
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x1C4C300 Offset: 0x1C4AD00 VA: 0x181C4C300
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x1C54470 Offset: 0x1C52E70 VA: 0x181C54470
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1C51AD0 Offset: 0x1C504D0 VA: 0x181C51AD0
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x1C53C00 Offset: 0x1C52600 VA: 0x181C53C00
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x1C53B10 Offset: 0x1C52510 VA: 0x181C53B10
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x1C54210 Offset: 0x1C52C10 VA: 0x181C54210
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x1C54C10 Offset: 0x1C53610 VA: 0x181C54C10
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x1C54CC0 Offset: 0x1C536C0 VA: 0x181C54CC0
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x1C514C0 Offset: 0x1C4FEC0 VA: 0x181C514C0
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1C51BD0 Offset: 0x1C505D0 VA: 0x181C51BD0
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1C51360 Offset: 0x1C4FD60 VA: 0x181C51360
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1C517E0 Offset: 0x1C501E0 VA: 0x181C517E0
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1C51940 Offset: 0x1C50340 VA: 0x181C51940
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1C51DF0 Offset: 0x1C507F0 VA: 0x181C51DF0
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x1C51690 Offset: 0x1C50090 VA: 0x181C51690
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x1C4C950 Offset: 0x1C4B350 VA: 0x181C4C950
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x1C4E1F0 Offset: 0x1C4CBF0 VA: 0x181C4E1F0
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1C4C710 Offset: 0x1C4B110 VA: 0x181C4C710
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x1C4D800 Offset: 0x1C4C200 VA: 0x181C4D800
	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x1C54B20 Offset: 0x1C53520 VA: 0x181C54B20
	private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C52140 Offset: 0x1C50B40 VA: 0x181C52140
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x1C57010 Offset: 0x1C55A10 VA: 0x181C57010
	internal static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x1C4CEF0 Offset: 0x1C4B8F0 VA: 0x181C4CEF0
	private static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x1C4E340 Offset: 0x1C4CD40 VA: 0x181C4E340
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x1C57EE0 Offset: 0x1C568E0 VA: 0x181C57EE0
	private static void .cctor() { }
}
