public static class CharUnicodeInfo // TypeDefIndex: 4791
{
	// Properties
	private static ReadOnlySpan<byte> CategoryLevel1Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel2Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel3Index { get; }
	private static ReadOnlySpan<byte> CategoriesValue { get; }

	// Methods

	// RVA: 0x1B7FCA0 Offset: 0x1B7E6A0 VA: 0x181B7FCA0
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x1B7FD40 Offset: 0x1B7E740 VA: 0x181B7FD40
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x1B7FC90 Offset: 0x1B7E690 VA: 0x181B7FC90
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x1B7FB60 Offset: 0x1B7E560 VA: 0x181B7FB60
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x1B7FA00 Offset: 0x1B7E400 VA: 0x181B7FA00
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	// RVA: 0x1B7FDE0 Offset: 0x1B7E7E0 VA: 0x181B7FDE0
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x1B7FF50 Offset: 0x1B7E950 VA: 0x181B7FF50
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x1B7FFE0 Offset: 0x1B7E9E0 VA: 0x181B7FFE0
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x1B800B0 Offset: 0x1B7EAB0 VA: 0x181B800B0
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x1B80090 Offset: 0x1B7EA90 VA: 0x181B80090
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x1B80240 Offset: 0x1B7EC40 VA: 0x181B80240
	private static ReadOnlySpan<byte> get_CategoryLevel1Index() { }

	// RVA: 0x1B80290 Offset: 0x1B7EC90 VA: 0x181B80290
	private static ReadOnlySpan<byte> get_CategoryLevel2Index() { }

	// RVA: 0x1B802E0 Offset: 0x1B7ECE0 VA: 0x181B802E0
	private static ReadOnlySpan<byte> get_CategoryLevel3Index() { }

	// RVA: 0x1B801F0 Offset: 0x1B7EBF0 VA: 0x181B801F0
	private static ReadOnlySpan<byte> get_CategoriesValue() { }
}
