internal class FormatProvider // TypeDefIndex: 18605
{
	// Methods

	// RVA: 0x21A3970 Offset: 0x21A2370 VA: 0x1821A3970
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x21A3AE0 Offset: 0x21A24E0 VA: 0x1821A3AE0
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}
