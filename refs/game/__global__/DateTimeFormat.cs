internal static class DateTimeFormat // TypeDefIndex: 3634
{
	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static readonly DateTimeFormatInfo InvariantFormatInfo; // 0x10
	internal static readonly string[] InvariantAbbreviatedMonthNames; // 0x18
	internal static readonly string[] InvariantAbbreviatedDayNames; // 0x20
	internal static string[] fixedNumberFormats; // 0x28

	// Methods

	// RVA: 0x1C46020 Offset: 0x1C44A20 VA: 0x181C46020
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x1C460A0 Offset: 0x1C44AA0 VA: 0x181C460A0
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x1C46CE0 Offset: 0x1C456E0 VA: 0x181C46CE0
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x1C470E0 Offset: 0x1C45AE0 VA: 0x181C470E0
	internal static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar) { }

	// RVA: 0x1C45FE0 Offset: 0x1C449E0 VA: 0x181C45FE0
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C46270 Offset: 0x1C44C70 VA: 0x181C46270
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C461A0 Offset: 0x1C44BA0 VA: 0x181C461A0
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C46EF0 Offset: 0x1C458F0 VA: 0x181C46EF0
	internal static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result) { }

	// RVA: 0x1C46E80 Offset: 0x1C45880 VA: 0x181C46E80
	internal static int ParseNextChar(ReadOnlySpan<char> format, int pos) { }

	// RVA: 0x1C46D50 Offset: 0x1C45750 VA: 0x181C46D50
	private static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x1C44CD0 Offset: 0x1C436D0 VA: 0x181C44CD0
	private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x1C44850 Offset: 0x1C43250 VA: 0x181C44850
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x1C44530 Offset: 0x1C42F30 VA: 0x181C44530
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x1C43DE0 Offset: 0x1C427E0 VA: 0x181C43DE0
	private static void Append2DigitNumber(StringBuilder result, int val) { }

	// RVA: 0x1C469A0 Offset: 0x1C453A0 VA: 0x181C469A0
	internal static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1C43E60 Offset: 0x1C42860 VA: 0x181C43E60
	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x1C46630 Offset: 0x1C45030 VA: 0x181C46630
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider) { }

	// RVA: 0x1C466C0 Offset: 0x1C450C0 VA: 0x181C466C0
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset) { }

	// RVA: 0x1C47E70 Offset: 0x1C46870 VA: 0x181C47E70
	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C47F30 Offset: 0x1C46930 VA: 0x181C47F30
	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset) { }

	// RVA: 0x1C462B0 Offset: 0x1C44CB0 VA: 0x181C462B0
	private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x1C47170 Offset: 0x1C45B70 VA: 0x181C47170
	private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C47910 Offset: 0x1C46310 VA: 0x181C47910
	private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C48220 Offset: 0x1C46C20 VA: 0x181C48220
	private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset) { }

	// RVA: 0x1C42BE0 Offset: 0x1C415E0 VA: 0x181C42BE0
	private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0) { }

	// RVA: 0x1C48160 Offset: 0x1C46B60 VA: 0x181C48160
	private static void WriteDigits(ulong value, Span<char> buffer) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void InvalidFormatForLocal(ReadOnlySpan<char> format, DateTime dateTime) { }

	// RVA: 0x1C48280 Offset: 0x1C46C80 VA: 0x181C48280
	private static void .cctor() { }
}
