internal class WWWTranscoder // TypeDefIndex: 18705
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x2F5C3C0 Offset: 0x2F5ADC0 VA: 0x182F5C3C0
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x2F5BAA0 Offset: 0x2F5A4A0 VA: 0x182F5BAA0
	private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1) { }

	// RVA: 0x2F5BBD0 Offset: 0x2F5A5D0 VA: 0x182F5BBD0
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x2F5C450 Offset: 0x2F5AE50 VA: 0x182F5C450
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x2F5BFA0 Offset: 0x2F5A9A0 VA: 0x182F5BFA0
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x2F5BAE0 Offset: 0x2F5A4E0 VA: 0x182F5BAE0
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x2F5C6C0 Offset: 0x2F5B0C0 VA: 0x182F5C6C0
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x2F5BB30 Offset: 0x2F5A530 VA: 0x182F5BB30
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x2F5BC50 Offset: 0x2F5A650 VA: 0x182F5BC50
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x2F5C590 Offset: 0x2F5AF90 VA: 0x182F5C590
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x2F5C560 Offset: 0x2F5AF60 VA: 0x182F5C560
	public static bool SevenBitClean(byte* input, int inputLength) { }

	// RVA: 0x2F5C730 Offset: 0x2F5B130 VA: 0x182F5C730
	private static void .cctor() { }
}
