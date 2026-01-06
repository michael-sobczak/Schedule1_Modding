internal static class BigNumber // TypeDefIndex: 18600
{
	// Methods

	// RVA: 0x21A3800 Offset: 0x21A2200 VA: 0x1821A3800
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x21A34A0 Offset: 0x21A1EA0 VA: 0x1821A34A0
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x21A2FF0 Offset: 0x21A19F0 VA: 0x1821A2FF0
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x21A31F0 Offset: 0x21A1BF0 VA: 0x1821A31F0
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x21A2A90 Offset: 0x21A1490 VA: 0x1821A2A90
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x21A2D20 Offset: 0x21A1720 VA: 0x1821A2D20
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x21A3360 Offset: 0x21A1D60 VA: 0x1821A3360
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x21A1580 Offset: 0x219FF80 VA: 0x1821A1580
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0x21A1CC0 Offset: 0x21A06C0 VA: 0x1821A1CC0
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x21A1DB0 Offset: 0x21A07B0 VA: 0x1821A1DB0
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }
}
