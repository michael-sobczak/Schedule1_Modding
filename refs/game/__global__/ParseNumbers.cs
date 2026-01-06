internal static class ParseNumbers // TypeDefIndex: 3710
{
	// Methods

	// RVA: 0x1C83D20 Offset: 0x1C82720 VA: 0x181C83D20
	public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags) { }

	// RVA: 0x1C83810 Offset: 0x1C82210 VA: 0x181C83810
	public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos) { }

	// RVA: 0x1C83230 Offset: 0x1C81C30 VA: 0x181C83230
	public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags) { }

	// RVA: 0x1C83260 Offset: 0x1C81C60 VA: 0x181C83260
	public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos) { }

	// RVA: 0x1C82A00 Offset: 0x1C81400 VA: 0x181C82A00
	public static string IntToString(int n, int radix, int width, char paddingChar, int flags) { }

	// RVA: 0x1C82DF0 Offset: 0x1C817F0 VA: 0x181C82DF0
	public static string LongToString(long n, int radix, int width, char paddingChar, int flags) { }

	// RVA: 0x1C82560 Offset: 0x1C80F60 VA: 0x181C82560
	private static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i) { }

	// RVA: 0x1C82820 Offset: 0x1C81220 VA: 0x181C82820
	private static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned) { }

	// RVA: 0x1C82630 Offset: 0x1C81030 VA: 0x181C82630
	private static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned) { }

	// RVA: 0x1C83D50 Offset: 0x1C82750 VA: 0x181C83D50
	private static void ThrowOverflowInt32Exception() { }

	// RVA: 0x1C83DA0 Offset: 0x1C827A0 VA: 0x181C83DA0
	private static void ThrowOverflowInt64Exception() { }

	// RVA: 0x1C83DF0 Offset: 0x1C827F0 VA: 0x181C83DF0
	private static void ThrowOverflowUInt32Exception() { }

	// RVA: 0x1C83E40 Offset: 0x1C82840 VA: 0x181C83E40
	private static void ThrowOverflowUInt64Exception() { }

	// RVA: 0x1C82D90 Offset: 0x1C81790 VA: 0x181C82D90
	private static bool IsDigit(char c, int radix, out int result) { }
}
