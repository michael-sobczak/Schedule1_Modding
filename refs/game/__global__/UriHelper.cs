internal static class UriHelper // TypeDefIndex: 9511
{
	// Fields
	private static readonly char[] HexUpperChars; // 0x0

	// Methods

	// RVA: 0x260D7B0 Offset: 0x260C1B0 VA: 0x18260D7B0
	internal static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase) { }

	// RVA: 0x260C880 Offset: 0x260B280 VA: 0x18260C880
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x260C670 Offset: 0x260B070 VA: 0x18260C670
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x260D950 Offset: 0x260C350 VA: 0x18260D950
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x260DA30 Offset: 0x260C430 VA: 0x18260DA30
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x260D2C0 Offset: 0x260BCC0 VA: 0x18260D2C0
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x260C770 Offset: 0x260B170 VA: 0x18260C770
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x260CEF0 Offset: 0x260B8F0 VA: 0x18260CEF0
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x260D020 Offset: 0x260BA20 VA: 0x18260D020
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x260D070 Offset: 0x260BA70 VA: 0x18260D070
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x260D1A0 Offset: 0x260BBA0 VA: 0x18260D1A0
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x260CF90 Offset: 0x260B990 VA: 0x18260CF90
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x260E500 Offset: 0x260CF00 VA: 0x18260E500
	private static void .cctor() { }
}
