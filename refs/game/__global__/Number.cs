internal static class Number // TypeDefIndex: 3703
{
	// Fields
	private static readonly string[] s_posCurrencyFormats; // 0x0
	private static readonly string[] s_negCurrencyFormats; // 0x8
	private static readonly string[] s_posPercentFormats; // 0x10
	private static readonly string[] s_negPercentFormats; // 0x18
	private static readonly string[] s_negNumberFormats; // 0x20
	private static readonly int[] s_charToHexLookup; // 0x28
	private static readonly ulong[] s_rgval64Power10; // 0x30
	private static readonly sbyte[] s_rgexp64Power10; // 0x38
	private static readonly ulong[] s_rgval64Power10By16; // 0x40
	private static readonly short[] s_rgexp64Power10By16; // 0x48

	// Methods

	// RVA: 0x1C6AD70 Offset: 0x1C69770 VA: 0x181C6AD70
	public static string FormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x1C722B0 Offset: 0x1C70CB0 VA: 0x181C722B0
	public static bool TryFormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6A6B0 Offset: 0x1C690B0 VA: 0x181C6A6B0
	private static void DecimalToNumber(Decimal value, ref Number.NumberBuffer number) { }

	// RVA: 0x1C6AF40 Offset: 0x1C69940 VA: 0x181C6AF40
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x1C72490 Offset: 0x1C70E90 VA: 0x181C72490
	public static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6B080 Offset: 0x1C69A80 VA: 0x181C6B080
	private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x1C6C8A0 Offset: 0x1C6B2A0 VA: 0x181C6C8A0
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x1C72D20 Offset: 0x1C71720 VA: 0x181C72D20
	public static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6C9E0 Offset: 0x1C6B3E0 VA: 0x181C6C9E0
	private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x1C721D0 Offset: 0x1C70BD0 VA: 0x181C721D0
	private static bool TryCopyTo(string source, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6BD30 Offset: 0x1C6A730 VA: 0x181C6BD30
	public static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C72650 Offset: 0x1C71050 VA: 0x181C72650
	public static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6CCE0 Offset: 0x1C6B6E0 VA: 0x181C6CCE0
	public static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C72EE0 Offset: 0x1C718E0 VA: 0x181C72EE0
	public static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6C020 Offset: 0x1C6AA20 VA: 0x181C6C020
	public static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C729B0 Offset: 0x1C713B0 VA: 0x181C729B0
	public static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6CF70 Offset: 0x1C6B970 VA: 0x181C6CF70
	public static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1C731C0 Offset: 0x1C71BC0 VA: 0x181C731C0
	public static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6D3A0 Offset: 0x1C6BDA0 VA: 0x181C6D3A0
	private static void Int32ToNumber(int value, ref Number.NumberBuffer number) { }

	// RVA: 0x1C6DA30 Offset: 0x1C6C430 VA: 0x181C6DA30
	private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) { }

	// RVA: 0x1C73830 Offset: 0x1C72230 VA: 0x181C73830
	private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6D270 Offset: 0x1C6BC70 VA: 0x181C6D270
	private static string Int32ToHexStr(int value, char hexBase, int digits) { }

	// RVA: 0x1C734A0 Offset: 0x1C71EA0 VA: 0x181C734A0
	private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6D220 Offset: 0x1C6BC20 VA: 0x181C6D220
	private static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits) { }

	// RVA: 0x1C76D90 Offset: 0x1C75790 VA: 0x181C76D90
	private static void UInt32ToNumber(uint value, ref Number.NumberBuffer number) { }

	// RVA: 0x1C76BD0 Offset: 0x1C755D0 VA: 0x181C76BD0
	internal static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits) { }

	// RVA: 0x1C76C10 Offset: 0x1C75610 VA: 0x181C76C10
	private static string UInt32ToDecStr(uint value, int digits) { }

	// RVA: 0x1C76840 Offset: 0x1C75240 VA: 0x181C76840
	private static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6D700 Offset: 0x1C6C100 VA: 0x181C6D700
	private static void Int64ToNumber(long input, ref Number.NumberBuffer number) { }

	// RVA: 0x1C6DBD0 Offset: 0x1C6C5D0 VA: 0x181C6DBD0
	private static string NegativeInt64ToDecStr(long input, int digits, string sNegative) { }

	// RVA: 0x1C739E0 Offset: 0x1C723E0 VA: 0x181C739E0
	private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C6D500 Offset: 0x1C6BF00 VA: 0x181C6D500
	private static string Int64ToHexStr(long value, char hexBase, int digits) { }

	// RVA: 0x1C735F0 Offset: 0x1C71FF0 VA: 0x181C735F0
	private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C77050 Offset: 0x1C75A50 VA: 0x181C77050
	private static void UInt64ToNumber(ulong value, ref Number.NumberBuffer number) { }

	// RVA: 0x1C76E90 Offset: 0x1C75890 VA: 0x181C76E90
	private static string UInt64ToDecStr(ulong value, int digits) { }

	// RVA: 0x1C769E0 Offset: 0x1C753E0 VA: 0x181C769E0
	private static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x1C70380 Offset: 0x1C6ED80 VA: 0x181C70380
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x1C6F5F0 Offset: 0x1C6DFF0 VA: 0x181C6F5F0
	internal static void NumberToString(ref ValueStringBuilder sb, ref Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x1C6E8F0 Offset: 0x1C6D2F0 VA: 0x181C6E8F0
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x1C6AB50 Offset: 0x1C69550 VA: 0x181C6AB50
	private static void FormatCurrency(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1C6B4E0 Offset: 0x1C69EE0 VA: 0x181C6B4E0
	private static void FormatFixed(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x1C6C310 Offset: 0x1C6AD10 VA: 0x181C6C310
	private static void FormatNumber(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1C6C720 Offset: 0x1C6B120 VA: 0x181C6C720
	private static void FormatScientific(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x1C6B370 Offset: 0x1C69D70 VA: 0x181C6B370
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x1C6B9F0 Offset: 0x1C6A3F0 VA: 0x181C6B9F0
	private static void FormatGeneral(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x1C6C4F0 Offset: 0x1C6AEF0 VA: 0x181C6C4F0
	private static void FormatPercent(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1C71E20 Offset: 0x1C70820 VA: 0x181C71E20
	private static void RoundNumber(ref Number.NumberBuffer number, int pos) { }

	// RVA: 0x1C6AA30 Offset: 0x1C69430 VA: 0x181C6AA30
	private static int FindSection(ReadOnlySpan<char> format, int section) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	private static uint Low32(ulong value) { }

	// RVA: 0x1C6D210 Offset: 0x1C6BC10 VA: 0x181C6D210
	private static uint High32(ulong value) { }

	// RVA: 0x1C6D4B0 Offset: 0x1C6BEB0 VA: 0x181C6D4B0
	private static uint Int64DivMod1E9(ref ulong value) { }

	// RVA: 0x1C6E7A0 Offset: 0x1C6D1A0 VA: 0x181C6E7A0
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x1C6E840 Offset: 0x1C6D240 VA: 0x181C6E840
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x1C6FCE0 Offset: 0x1C6E6E0 VA: 0x181C6FCE0
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x1C6FD80 Offset: 0x1C6E780 VA: 0x181C6FD80
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x1C70520 Offset: 0x1C6EF20 VA: 0x181C70520
	internal static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C70760 Offset: 0x1C6F160 VA: 0x181C70760
	internal static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C71990 Offset: 0x1C70390 VA: 0x181C71990
	internal static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C71BD0 Offset: 0x1C705D0 VA: 0x181C71BD0
	internal static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C709C0 Offset: 0x1C6F3C0 VA: 0x181C709C0
	private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x1C744D0 Offset: 0x1C72ED0 VA: 0x181C744D0
	internal static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result) { }

	// RVA: 0x1C73E90 Offset: 0x1C72890 VA: 0x181C73E90
	private static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow) { }

	// RVA: 0x1C74690 Offset: 0x1C73090 VA: 0x181C74690
	private static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow) { }

	// RVA: 0x1C74CE0 Offset: 0x1C736E0 VA: 0x181C74CE0
	internal static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result) { }

	// RVA: 0x1C759A0 Offset: 0x1C743A0 VA: 0x181C759A0
	internal static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result) { }

	// RVA: 0x1C753B0 Offset: 0x1C73DB0 VA: 0x181C753B0
	private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	// RVA: 0x1C75030 Offset: 0x1C73A30 VA: 0x181C75030
	private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	// RVA: 0x1C764F0 Offset: 0x1C74EF0 VA: 0x181C764F0
	internal static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x1C75EF0 Offset: 0x1C748F0 VA: 0x181C75EF0
	private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	// RVA: 0x1C75B70 Offset: 0x1C74570 VA: 0x181C75B70
	private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	// RVA: 0x1C6FE30 Offset: 0x1C6E830 VA: 0x181C6FE30
	internal static Decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C6DDD0 Offset: 0x1C6C7D0 VA: 0x181C6DDD0
	private static bool NumberBufferToDecimal(ref Number.NumberBuffer number, ref Decimal value) { }

	// RVA: 0x1C6FF50 Offset: 0x1C6E950 VA: 0x181C6FF50
	internal static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C71530 Offset: 0x1C6FF30 VA: 0x181C71530
	internal static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x1C73C00 Offset: 0x1C72600 VA: 0x181C73C00
	internal static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out Decimal result) { }

	// RVA: 0x1C73D10 Offset: 0x1C72710 VA: 0x181C73D10
	internal static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out double result) { }

	// RVA: 0x1C74EA0 Offset: 0x1C738A0 VA: 0x181C74EA0
	internal static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out float result) { }

	// RVA: 0x1C71F10 Offset: 0x1C70910 VA: 0x181C71F10
	private static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x1C766C0 Offset: 0x1C750C0 VA: 0x181C766C0
	internal static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x1C72150 Offset: 0x1C70B50 VA: 0x181C72150
	private static bool TrailingZeros(ReadOnlySpan<char> value, int index) { }

	// RVA: 0x1C6D900 Offset: 0x1C6C300 VA: 0x181C6D900
	private static char* MatchChars(char* p, char* pEnd, string value) { }

	// RVA: 0x1C6D8E0 Offset: 0x1C6C2E0 VA: 0x181C6D8E0
	private static bool IsWhite(int ch) { }

	// RVA: 0x1C6D8D0 Offset: 0x1C6C2D0 VA: 0x181C6D8D0
	private static bool IsDigit(int ch) { }

	// RVA: 0x1C720B0 Offset: 0x1C70AB0 VA: 0x181C720B0
	private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey) { }

	// RVA: 0x1C6E090 Offset: 0x1C6CA90 VA: 0x181C6E090
	private static bool NumberBufferToDouble(ref Number.NumberBuffer number, ref double value) { }

	// RVA: 0x1C6A8A0 Offset: 0x1C692A0 VA: 0x181C6A8A0
	private static uint DigitsToInt(char* p, int count) { }

	// RVA: 0x1C6D990 Offset: 0x1C6C390 VA: 0x181C6D990
	private static ulong Mul32x32To64(uint a, uint b) { }

	// RVA: 0x1C6D9A0 Offset: 0x1C6C3A0 VA: 0x181C6D9A0
	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	// RVA: 0x1C77CA0 Offset: 0x1C766A0 VA: 0x181C77CA0
	private static int abs(int value) { }

	// RVA: 0x1C6E130 Offset: 0x1C6CB30 VA: 0x181C6E130
	private static double NumberToDouble(ref Number.NumberBuffer number) { }

	// RVA: 0x1C6A8E0 Offset: 0x1C692E0 VA: 0x181C6A8E0
	private static void DoubleToNumber(double value, int precision, ref Number.NumberBuffer number) { }

	// RVA: 0x1C77210 Offset: 0x1C75C10 VA: 0x181C77210
	private static void .cctor() { }
}
