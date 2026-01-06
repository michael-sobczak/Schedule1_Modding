public struct Unicode // TypeDefIndex: 15914
{
	// Fields
	public const int kMaximumValidCodePoint = 1114111;

	// Properties
	public static Unicode.Rune ReplacementCharacter { get; }
	public static Unicode.Rune BadRune { get; }

	// Methods

	// RVA: 0x273D940 Offset: 0x273C340 VA: 0x18273D940
	public static bool IsValidCodePoint(int codepoint) { }

	// RVA: 0x273D950 Offset: 0x273C350 VA: 0x18273D950
	public static bool NotTrailer(byte b) { }

	// RVA: 0x273E110 Offset: 0x273CB10 VA: 0x18273E110
	public static Unicode.Rune get_ReplacementCharacter() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public static Unicode.Rune get_BadRune() { }

	// RVA: 0x273DD00 Offset: 0x273C700 VA: 0x18273DD00
	public static ConversionError Utf8ToUcs(out Unicode.Rune rune, byte* buffer, ref int index, int capacity) { }

	// RVA: 0x1BBFC30 Offset: 0x1BBE630 VA: 0x181BBFC30
	private static bool IsLeadingSurrogate(char c) { }

	// RVA: 0x1BBFDF0 Offset: 0x1BBE7F0 VA: 0x181BBFDF0
	private static bool IsTrailingSurrogate(char c) { }

	// RVA: 0x273DB10 Offset: 0x273C510 VA: 0x18273DB10
	public static ConversionError Utf16ToUcs(out Unicode.Rune rune, char* buffer, ref int index, int capacity) { }

	// RVA: 0x273DA00 Offset: 0x273C400 VA: 0x18273DA00
	public static ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Unicode.Rune rune) { }

	// RVA: 0x273D960 Offset: 0x273C360 VA: 0x18273D960
	public static ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Unicode.Rune rune) { }

	// RVA: 0x273DBD0 Offset: 0x273C5D0 VA: 0x18273DBD0
	public static ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, out int utf8Length, int utf8Capacity) { }

	// RVA: 0x273E050 Offset: 0x273CA50 VA: 0x18273E050
	public static ConversionError Utf8ToUtf8(byte* srcBuffer, int srcLength, byte* destBuffer, out int destLength, int destCapacity) { }

	// RVA: 0x273DF50 Offset: 0x273C950 VA: 0x18273DF50
	public static ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, out int utf16Length, int utf16Capacity) { }
}
